Option Strict On
Option Explicit On

Imports System.Data

''' <summary>Issuing, borrowing, returning and listing loans. Multi-step changes use one transaction.</summary>
Public Class LoanService
    Public Const StatusAll As String = "All"
    Public Shared ReadOnly StatusFilters As String() = {"All", "Active", "Overdue", "Return Requested", "Returned"}

    Private ReadOnly _settings As New SettingsService()

    ' ------------------------------------------------------------------ rules

    ''' <summary>Fine = days late x fine per day (never negative). Pure function, easy to unit-test.</summary>
    Public Shared Function CalculateFine(dueDate As Date, returnDate As Date, finePerDay As Decimal) As Decimal
        Dim daysLate As Integer = CInt((returnDate.Date - dueDate.Date).TotalDays)
        If daysLate <= 0 Then Return 0D
        Return Math.Round(daysLate * finePerDay, 2)
    End Function

    ''' <summary>Returns "" when the student may borrow, otherwise the reason they cannot.</summary>
    Private Function CheckEligibility(session As DbSession, studentId As Integer) As String
        Dim limits As LibrarySettings = _settings.GetSettings()
        Dim isActive As Object = session.Scalar(
            "SELECT u.is_active FROM students s JOIN users u ON u.user_id = s.user_id WHERE s.student_id = @s", Db.P("@s", studentId))
        If isActive Is Nothing Then Return "Student not found."
        If Not Db.AsBool(isActive) Then Return "This student account is inactive."

        Dim openLoans As Integer = Db.AsInt(session.Scalar(
            "SELECT COUNT(*) FROM loans WHERE student_id = @s AND status <> 'Returned'", Db.P("@s", studentId)))
        If openLoans >= limits.MaxBooksPerStudent Then
            Return "Borrowing limit reached (" & limits.MaxBooksPerStudent.ToString() & " books at a time)."
        End If

        Dim overdue As Integer = Db.AsInt(session.Scalar(
            "SELECT COUNT(*) FROM loans WHERE student_id = @s AND status <> 'Returned' AND due_date < CURDATE()", Db.P("@s", studentId)))
        If overdue > 0 Then Return "Overdue books must be returned before borrowing more."
        Return ""
    End Function

    Public Function GetEligibilityMessage(studentId As Integer) As String
        Guard.RequireLibrarian()
        Using session As New DbSession()
            Return CheckEligibility(session, studentId)
        End Using
    End Function

    Public Function GetMyEligibilityMessage() As String
        Dim studentId As Integer = Guard.RequireStudent()
        Using session As New DbSession()
            Return CheckEligibility(session, studentId)
        End Using
    End Function

    ' --------------------------------------------------------------- borrowing

    ''' <summary>Available copies of a book for drop-downs: copy_id, label.</summary>
    Public Function GetAvailableCopies(bookId As Integer) As DataTable
        Guard.RequireLibrarian()
        Return Db.Query("SELECT copy_id, CONCAT('Copy ', copy_no) AS label FROM book_copies WHERE book_id = @b AND status = 'Available' ORDER BY copy_no",
                        Db.P("@b", bookId))
    End Function

    ''' <summary>Creates the loan and marks the copy borrowed. Must run inside a transaction session.</summary>
    Private Sub CreateLoan(session As DbSession, studentId As Integer, copyId As Integer, dueDate As Date, issuedBy As Object)
        session.Scalar("SELECT student_id FROM students WHERE student_id = @s FOR UPDATE", Db.P("@s", studentId))
        Dim copyStatus As Object = session.Scalar("SELECT status FROM book_copies WHERE copy_id = @c FOR UPDATE", Db.P("@c", copyId))
        If copyStatus Is Nothing Then Throw New BusinessRuleException("That copy no longer exists.")
        If Db.AsString(copyStatus) <> "Available" Then Throw New BusinessRuleException("That copy is no longer available.")

        Dim reason As String = CheckEligibility(session, studentId)
        If reason <> "" Then Throw New BusinessRuleException(reason)
        If dueDate.Date < Date.Today OrElse dueDate.Date > Date.Today.AddDays(365) Then
            Throw New BusinessRuleException("The due date must be within the next 365 days.")
        End If

        session.Execute("INSERT INTO loans (copy_id, student_id, issued_by, issue_date, due_date, status) VALUES (@c, @s, @u, CURDATE(), @d, 'Active')",
                        Db.P("@c", copyId), Db.P("@s", studentId), Db.P("@u", issuedBy), Db.P("@d", dueDate.Date))
        session.Execute("UPDATE book_copies SET status = 'Borrowed' WHERE copy_id = @c", Db.P("@c", copyId))
    End Sub

    ''' <summary>Librarian issues a chosen copy to a student.</summary>
    Public Sub Issue(studentId As Integer, copyId As Integer, dueDate As Date)
        Dim librarian As UserAccount = Guard.RequireLibrarian()
        If studentId <= 0 Then Throw New BusinessRuleException("Please select a student.")
        If copyId <= 0 Then Throw New BusinessRuleException("Please select a copy.")
        Using session As New DbSession(True)
            CreateLoan(session, studentId, copyId, dueDate, librarian.UserId)
            session.Commit()
        End Using
    End Sub

    ''' <summary>A student borrows any available copy of a book. The due date comes from library settings.</summary>
    Public Function BorrowAsStudent(bookId As Integer) As Date
        Dim studentId As Integer = Guard.RequireStudent()
        Dim dueDate As Date = Date.Today.AddDays(_settings.GetSettings().LoanDays)
        Using session As New DbSession(True)
            Dim copyId As Object = session.Scalar(
                "SELECT copy_id FROM book_copies WHERE book_id = @b AND status = 'Available' ORDER BY copy_no LIMIT 1 FOR UPDATE", Db.P("@b", bookId))
            If copyId Is Nothing Then Throw New BusinessRuleException("No copies of this book are currently available.")
            CreateLoan(session, studentId, Db.AsInt(copyId), dueDate, Nothing)
            session.Commit()
        End Using
        Return dueDate
    End Function

    ' ---------------------------------------------------------------- returns

    ''' <summary>Loans not yet returned (including return requests) for the librarian's return screen.</summary>
    Public Function GetOpenLoans(term As String) As DataTable
        Guard.RequireLibrarian()
        Return Db.Query(
            "SELECT loan_id AS `Loan ID`, student_name AS Student, admission_no AS `Admission No`, book_title AS Book, copy_no AS Copy, " &
            "issue_date AS `Issue Date`, due_date AS `Due Date`, status AS Status FROM vw_loans " &
            "WHERE status <> 'Returned' AND CONCAT_WS(' ', student_name, admission_no, book_title, loan_id) LIKE @like ORDER BY due_date",
            Db.P("@like", Db.LikePattern(term)))
    End Function

    Public Function CalculateFine(loanId As Integer, returnDate As Date) As Decimal
        Guard.RequireLibrarian()
        Dim due As Object = Db.Scalar("SELECT due_date FROM loans WHERE loan_id = @l", Db.P("@l", loanId))
        If due Is Nothing Then Throw New BusinessRuleException("Loan not found.")
        Return CalculateFine(Db.AsDate(due), returnDate, _settings.GetSettings().FinePerDay)
    End Function

    ''' <summary>Records the return, frees the copy and creates a fine when late. Returns the fine amount.</summary>
    Public Function ProcessReturn(loanId As Integer, returnDate As Date) As Decimal
        Guard.RequireLibrarian()
        Dim rate As Decimal = _settings.GetSettings().FinePerDay
        Using session As New DbSession(True)
            Dim loan As DataTable = session.Query("SELECT copy_id, issue_date, due_date, status FROM loans WHERE loan_id = @l FOR UPDATE", Db.P("@l", loanId))
            If loan.Rows.Count = 0 Then Throw New BusinessRuleException("Loan not found.")
            Dim row As DataRow = loan.Rows(0)
            If Db.AsString(row("status")) = "Returned" Then Throw New BusinessRuleException("This book has already been returned.")
            If returnDate.Date < Db.AsDate(row("issue_date")).Date Then Throw New BusinessRuleException("The return date cannot be before the issue date.")
            If returnDate.Date > Date.Today Then Throw New BusinessRuleException("The return date cannot be in the future.")

            Dim fine As Decimal = CalculateFine(Db.AsDate(row("due_date")), returnDate, rate)
            session.Execute("UPDATE loans SET return_date = @r, status = 'Returned' WHERE loan_id = @l", Db.P("@r", returnDate.Date), Db.P("@l", loanId))
            session.Execute("UPDATE book_copies SET status = 'Available' WHERE copy_id = @c", Db.P("@c", Db.AsInt(row("copy_id"))))
            If fine > 0D Then
                session.Execute("INSERT INTO fines (loan_id, amount) VALUES (@l, @a)", Db.P("@l", loanId), Db.P("@a", fine))
            End If
            session.Commit()
            Return fine
        End Using
    End Function

    ''' <summary>Student asks the librarian to confirm a return. The copy stays borrowed until processed.</summary>
    Public Sub RequestReturn(loanId As Integer, condition As String, notes As String)
        Dim studentId As Integer = Guard.RequireStudent()
        Validator.Require(condition, "Book condition")
        Validator.MaxLength(notes, 500, "Notes")
        Dim changed As Integer = Db.Execute(
            "UPDATE loans SET status = 'ReturnRequested', return_condition = @c, return_notes = @n " &
            "WHERE loan_id = @l AND student_id = @s AND status = 'Active'",
            Db.P("@c", condition), Db.P("@n", If(String.IsNullOrWhiteSpace(notes), Nothing, notes.Trim())), Db.P("@l", loanId), Db.P("@s", studentId))
        If changed = 0 Then Throw New BusinessRuleException("A return request could not be made for this loan.")
    End Sub

    ' --------------------------------------------------------------- listings

    ''' <summary>All loans with filters (librarian).</summary>
    Public Function GetRecords(term As String, status As String, fromDate As Date, toDate As Date) As DataTable
        Guard.RequireLibrarian()
        Return Db.Query(
            "SELECT loan_id AS `Loan ID`, student_name AS Student, admission_no AS `Admission No`, book_title AS Book, " &
            "issue_date AS `Issue Date`, due_date AS `Due Date`, return_date AS `Return Date`, status AS Status FROM vw_loans " &
            "WHERE CONCAT_WS(' ', student_name, admission_no, book_title, loan_id) LIKE @like AND (@st = 'All' OR status = @st) " &
            "AND issue_date BETWEEN @from AND @to ORDER BY loan_id DESC",
            Db.P("@like", Db.LikePattern(term)), Db.P("@st", If(status, "All")), Db.P("@from", fromDate.Date), Db.P("@to", toDate.Date))
    End Function

    ''' <summary>The logged-in student's own loans only.</summary>
    Public Function GetMyLoans(term As String, status As String) As DataTable
        Dim studentId As Integer = Guard.RequireStudent()
        Return Db.Query(
            "SELECT loan_id AS `Loan ID`, book_id AS BookId, book_title AS Book, author AS Author, issue_date AS `Borrow Date`, " &
            "due_date AS `Due Date`, return_date AS `Return Date`, status AS Status FROM vw_loans " &
            "WHERE student_id = @s AND CONCAT_WS(' ', book_title, author) LIKE @like AND (@st = 'All' OR status = @st) ORDER BY loan_id DESC",
            Db.P("@s", studentId), Db.P("@like", Db.LikePattern(term)), Db.P("@st", If(status, "All")))
    End Function
End Class
