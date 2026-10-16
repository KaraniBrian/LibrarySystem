Option Strict On
Option Explicit On

Imports System.Data

''' <summary>Book catalogue and copy management.</summary>
Public Class BookService
    ''' <summary>Categories for drop-downs: category_id, name. Optionally adds an "All categories" row first.</summary>
    Public Function GetCategories(includeAll As Boolean) As DataTable
        Guard.RequireLogin()
        Dim table As DataTable = Db.Query("SELECT category_id, name FROM categories ORDER BY name")
        If includeAll Then
            Dim all As DataRow = table.NewRow()
            all("category_id") = 0
            all("name") = "All categories"
            table.Rows.InsertAt(all, 0)
        End If
        Return table
    End Function

    ''' <summary>
    ''' Searches books. categoryId 0 = all; availability is "All", "Available" or "Unavailable".
    ''' Available to librarians and students (the catalogue is public to logged-in users).
    ''' </summary>
    Public Function Search(term As String, categoryId As Integer, availability As String) As DataTable
        Guard.RequireLogin()
        Return Db.Query(
            "SELECT b.book_id AS Id, b.isbn AS ISBN, b.title AS Title, b.author AS Author, c.name AS Category, " &
            "COALESCE(b.publisher, '') AS Publisher, b.publication_year AS `Year`, " &
            "COUNT(bc.copy_id) AS Copies, CAST(COALESCE(SUM(bc.status = 'Available'), 0) AS SIGNED) AS Available " &
            "FROM books b JOIN categories c ON c.category_id = b.category_id " &
            "LEFT JOIN book_copies bc ON bc.book_id = b.book_id " &
            "WHERE CONCAT_WS(' ', b.title, b.author, b.isbn) LIKE @like AND (@cat = 0 OR b.category_id = @cat) " &
            "GROUP BY b.book_id, b.isbn, b.title, b.author, c.name, b.publisher, b.publication_year " &
            "HAVING (@av = 'All' OR (@av = 'Available' AND Available > 0) OR (@av = 'Unavailable' AND Available = 0)) " &
            "ORDER BY b.title",
            Db.P("@like", Db.LikePattern(term)), Db.P("@cat", categoryId), Db.P("@av", If(availability, "All")))
    End Function

    ''' <summary>Books with at least one available copy: book_id, label.</summary>
    Public Function GetAvailableLookup() As DataTable
        Guard.RequireLibrarian()
        Return Db.Query(
            "SELECT b.book_id, CONCAT(b.title, ' - ', b.author) AS label " &
            "FROM books b WHERE EXISTS (SELECT 1 FROM book_copies bc WHERE bc.book_id = b.book_id AND bc.status = 'Available') ORDER BY b.title")
    End Function

    Public Function GetBook(bookId As Integer) As BookInfo
        Guard.RequireLogin()
        Dim table As DataTable = Db.Query(
            "SELECT b.book_id, b.isbn, b.title, b.author, b.category_id, c.name AS category, COALESCE(b.publisher, '') AS publisher, " &
            "b.publication_year, COALESCE(b.description, '') AS description, " &
            "(SELECT COUNT(*) FROM book_copies WHERE book_id = b.book_id) AS total_copies, " &
            "(SELECT COUNT(*) FROM book_copies WHERE book_id = b.book_id AND status = 'Available') AS available_copies " &
            "FROM books b JOIN categories c ON c.category_id = b.category_id WHERE b.book_id = @id", Db.P("@id", bookId))
        If table.Rows.Count = 0 Then Throw New BusinessRuleException("Book not found.")
        Dim r As DataRow = table.Rows(0)
        Return New BookInfo With {
            .BookId = Db.AsInt(r("book_id")), .Isbn = Db.AsString(r("isbn")), .Title = Db.AsString(r("title")),
            .Author = Db.AsString(r("author")), .CategoryId = Db.AsInt(r("category_id")), .CategoryName = Db.AsString(r("category")),
            .Publisher = Db.AsString(r("publisher")), .PublicationYear = Db.AsInt(r("publication_year")),
            .Description = Db.AsString(r("description")), .TotalCopies = Db.AsInt(r("total_copies")),
            .AvailableCopies = Db.AsInt(r("available_copies"))}
    End Function

    Private Shared Sub Validate(book As BookInfo)
        Validator.Require(book.Isbn, "ISBN")
        Validator.Require(book.Title, "Book title")
        Validator.Require(book.Author, "Author")
        Validator.MaxLength(book.Isbn, 20, "ISBN")
        Validator.MaxLength(book.Title, 255, "Book title")
        Validator.MaxLength(book.Author, 150, "Author")
        Validator.MaxLength(book.Publisher, 150, "Publisher")
        Validator.MaxLength(book.Description, 1000, "Description")
        If book.CategoryId <= 0 Then Throw New BusinessRuleException("Please choose a category.")
        If book.PublicationYear < 1000 OrElse book.PublicationYear > Date.Today.Year + 1 Then Throw New BusinessRuleException("Please enter a valid publication year.")
        If book.TotalCopies < 0 OrElse book.TotalCopies > 10000 Then Throw New BusinessRuleException("Number of copies must be between 0 and 10000.")
    End Sub

    Private Shared Sub EnsureIsbnUnique(session As DbSession, book As BookInfo)
        Dim count As Integer = Db.AsInt(session.Scalar("SELECT COUNT(*) FROM books WHERE isbn = @i AND book_id <> @id",
                                                       Db.P("@i", book.Isbn.Trim()), Db.P("@id", book.BookId)))
        If count > 0 Then Throw New BusinessRuleException("A book with this ISBN already exists.")
    End Sub

    ''' <summary>Adds a book and creates the requested number of copies (book.TotalCopies).</summary>
    Public Sub Add(book As BookInfo)
        Guard.RequireLibrarian()
        Validate(book)
        Using session As New DbSession(True)
            EnsureIsbnUnique(session, book)
            Dim id As Integer = session.Insert(
                "INSERT INTO books (isbn, title, author, category_id, publisher, publication_year, description) VALUES (@i, @t, @a, @c, @p, @y, @d)",
                Db.P("@i", book.Isbn.Trim()), Db.P("@t", book.Title.Trim()), Db.P("@a", book.Author.Trim()), Db.P("@c", book.CategoryId),
                Db.P("@p", If(String.IsNullOrWhiteSpace(book.Publisher), Nothing, book.Publisher.Trim())), Db.P("@y", book.PublicationYear),
                Db.P("@d", If(String.IsNullOrWhiteSpace(book.Description), Nothing, book.Description.Trim())))
            AddCopies(session, id, 1, book.TotalCopies)
            session.Commit()
        End Using
    End Sub

    Private Shared Sub AddCopies(session As DbSession, bookId As Integer, firstNumber As Integer, count As Integer)
        For n As Integer = firstNumber To firstNumber + count - 1
            session.Execute("INSERT INTO book_copies (book_id, copy_no) VALUES (@b, @n)", Db.P("@b", bookId), Db.P("@n", n))
        Next
    End Sub

    ''' <summary>Updates details and adjusts the copy count (extra copies are added; surplus unused copies removed).</summary>
    Public Sub Update(book As BookInfo)
        Guard.RequireLibrarian()
        If book.BookId <= 0 Then Throw New BusinessRuleException("Select a book first.")
        Validate(book)
        Using session As New DbSession(True)
            EnsureIsbnUnique(session, book)
            session.Execute(
                "UPDATE books SET isbn = @i, title = @t, author = @a, category_id = @c, publisher = @p, publication_year = @y, description = @d WHERE book_id = @id",
                Db.P("@i", book.Isbn.Trim()), Db.P("@t", book.Title.Trim()), Db.P("@a", book.Author.Trim()), Db.P("@c", book.CategoryId),
                Db.P("@p", If(String.IsNullOrWhiteSpace(book.Publisher), Nothing, book.Publisher.Trim())), Db.P("@y", book.PublicationYear),
                Db.P("@d", If(String.IsNullOrWhiteSpace(book.Description), Nothing, book.Description.Trim())), Db.P("@id", book.BookId))

            Dim current As Integer = Db.AsInt(session.Scalar("SELECT COUNT(*) FROM book_copies WHERE book_id = @b", Db.P("@b", book.BookId)))
            If book.TotalCopies > current Then
                Dim lastNumber As Integer = Db.AsInt(session.Scalar("SELECT COALESCE(MAX(copy_no), 0) FROM book_copies WHERE book_id = @b", Db.P("@b", book.BookId)))
                AddCopies(session, book.BookId, lastNumber + 1, book.TotalCopies - current)
            ElseIf book.TotalCopies < current Then
                Dim toRemove As Integer = current - book.TotalCopies
                Dim removed As Integer = session.Execute(
                    "DELETE FROM book_copies WHERE book_id = @b AND status = 'Available' " &
                    "AND NOT EXISTS (SELECT 1 FROM loans l WHERE l.copy_id = book_copies.copy_id) ORDER BY copy_no DESC LIMIT " & toRemove.ToString(),
                    Db.P("@b", book.BookId))
                If removed < toRemove Then
                    Throw New BusinessRuleException("Cannot reduce the copies that far: borrowed copies and copies with borrowing history must be kept.")
                End If
            End If
            session.Commit()
        End Using
    End Sub

    Public Sub Remove(bookId As Integer)
        Guard.RequireLibrarian()
        If bookId <= 0 Then Throw New BusinessRuleException("Select a book first.")
        Using session As New DbSession(True)
            Dim history As Integer = Db.AsInt(session.Scalar(
                "SELECT COUNT(*) FROM loans l JOIN book_copies c ON c.copy_id = l.copy_id WHERE c.book_id = @b", Db.P("@b", bookId)))
            If history > 0 Then Throw New BusinessRuleException("This book has borrowing history and cannot be deleted. Set its copies to 0 instead.")
            session.Execute("DELETE FROM book_copies WHERE book_id = @b", Db.P("@b", bookId))
            session.Execute("DELETE FROM books WHERE book_id = @b", Db.P("@b", bookId))
            session.Commit()
        End Using
    End Sub
End Class
