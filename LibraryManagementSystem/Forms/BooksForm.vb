Option Strict On
Option Explicit On

Imports System.Data
Imports System.Windows.Forms
Imports LibraryManagement.Core

''' <summary>Screen 6 - Manage Books (details plus number of copies).</summary>
Public Class BooksForm
    Inherits PageForm

    Private ReadOnly _svc As New BookService()
    Private ReadOnly lblSearch As Label = NewLabel("lblSearch", "Search Book:")
    Private ReadOnly txtSearch As TextBox = NewTextBox("txtSearch", 100, False, "Search by title, ISBN or author")
    Private ReadOnly btnSearch As Button = NewButton("btnSearch", "Search", ButtonKind.Primary, 100)
    Private ReadOnly btnRefresh As Button = NewButton("btnRefresh", "Refresh", ButtonKind.Secondary, 100)
    Private ReadOnly dgvBooks As DataGridView = NewGrid("dgvBooks")
    Private ReadOnly txtISBN As TextBox = NewTextBox("txtISBN", 20)
    Private ReadOnly txtBookTitle As TextBox = NewTextBox("txtBookTitle", 255)
    Private ReadOnly txtAuthor As TextBox = NewTextBox("txtAuthor", 150)
    Private ReadOnly cmbCategory As ComboBox = NewCombo("cmbCategory")
    Private ReadOnly txtPublisher As TextBox = NewTextBox("txtPublisher", 150)
    Private ReadOnly nudYear As NumericUpDown = NewNumeric("nudYear", 1000, 2100, 2020)
    Private ReadOnly nudCopies As NumericUpDown = NewNumeric("nudCopies", 0, 10000, 1)
    Private ReadOnly txtDescription As TextBox = NewMultiline("txtDescription", 1000, 60)
    Private ReadOnly btnAdd As Button = NewButton("btnAdd", "Add Book", ButtonKind.Primary, 130)
    Private ReadOnly btnUpdate As Button = NewButton("btnUpdate", "Update Book", ButtonKind.Primary, 140)
    Private ReadOnly btnDelete As Button = NewButton("btnDelete", "Delete Book", ButtonKind.Danger, 140)
    Private ReadOnly btnClear As Button = NewButton("btnClear", "Clear", ButtonKind.Secondary, 100)

    Private _selectedId As Integer
    Private _loading As Boolean

    Public Sub New()
        MyBase.New("Manage Books")
        txtSearch.Width = 380
        Dim bar As FlowLayoutPanel = NewToolbar("pnlSearchBar")
        bar.Controls.AddRange(New Control() {lblSearch, txtSearch, btnSearch, btnRefresh})
        AddAutoRow(bar)
        AddFillRow(dgvBooks)

        Dim fields As TableLayoutPanel = NewFieldTable("tblFields", 2)
        AddField(fields, NewLabel("lblISBN", "ISBN:"), txtISBN)
        AddField(fields, NewLabel("lblBookTitle", "Book Title:"), txtBookTitle)
        AddField(fields, NewLabel("lblAuthor", "Author:"), txtAuthor)
        AddField(fields, NewLabel("lblCategory", "Category:"), cmbCategory)
        AddField(fields, NewLabel("lblPublisher", "Publisher:"), txtPublisher)
        AddField(fields, NewLabel("lblYear", "Publication Year:"), nudYear)
        AddField(fields, NewLabel("lblCopies", "Number of Copies:"), nudCopies)
        AddAutoRow(fields)
        Dim descriptionRow As TableLayoutPanel = NewFieldTable("tblDescription", 1)
        AddField(descriptionRow, NewLabel("lblDescription", "Description:"), txtDescription)
        AddAutoRow(descriptionRow)
        AddAutoRow(NewButtonRow("pnlActions", btnAdd, btnUpdate, btnDelete, btnClear))
        AddAutoRow(lblMessage)

        AddHandler btnSearch.Click, Sub(sender As Object, e As EventArgs) LoadBooks()
        AddHandler btnRefresh.Click, Sub(sender As Object, e As EventArgs) OnRefresh()
        EnterKeyAction(txtSearch, AddressOf LoadBooks)
        AddHandler dgvBooks.SelectionChanged, Sub(sender As Object, e As EventArgs) OnSelectionChanged()
        AddHandler btnAdd.Click, Sub(sender As Object, e As EventArgs) OnAdd()
        AddHandler btnUpdate.Click, Sub(sender As Object, e As EventArgs) OnUpdate()
        AddHandler btnDelete.Click, Sub(sender As Object, e As EventArgs) OnDelete()
        AddHandler btnClear.Click, Sub(sender As Object, e As EventArgs) ClearFields()
    End Sub

    Protected Overrides Sub LoadData()
        Run(Sub() BindLookup(cmbCategory, _svc.GetCategories(False), "category_id", "name"))
        LoadBooks()
    End Sub

    Private Sub OnRefresh()
        txtSearch.Clear()
        LoadBooks()
    End Sub

    Private Sub LoadBooks()
        Run(Sub()
                Dim table As DataTable = _svc.Search(txtSearch.Text, 0, "All")
                _loading = True
                Try
                    BindGrid(dgvBooks, table, "Id")
                Finally
                    _loading = False
                End Try
            End Sub)
        ClearFields()
    End Sub

    Private Sub OnSelectionChanged()
        If _loading Then Return
        Dim row As DataGridViewRow = SelectedRow(dgvBooks)
        If row Is Nothing Then Return
        Dim id As Integer = CellInt(row, "Id")
        Run(Sub()
                Dim book As BookInfo = _svc.GetBook(id)
                _selectedId = book.BookId
                txtISBN.Text = book.Isbn
                txtBookTitle.Text = book.Title
                txtAuthor.Text = book.Author
                cmbCategory.SelectedValue = book.CategoryId
                txtPublisher.Text = book.Publisher
                nudYear.Value = Math.Min(Math.Max(book.PublicationYear, 1000), 2100)
                nudCopies.Value = Math.Min(book.TotalCopies, 10000)
                txtDescription.Text = book.Description
            End Sub)
    End Sub

    Private Sub ClearFields()
        _selectedId = 0
        txtISBN.Clear()
        txtBookTitle.Clear()
        txtAuthor.Clear()
        txtPublisher.Clear()
        txtDescription.Clear()
        cmbCategory.SelectedIndex = -1
        nudYear.Value = Math.Min(Math.Max(Date.Today.Year, 1000), 2100)
        nudCopies.Value = 1
        _loading = True
        Try
            dgvBooks.ClearSelection()
            dgvBooks.CurrentCell = Nothing
        Finally
            _loading = False
        End Try
        txtISBN.Focus()
    End Sub

    Private Function ReadBook() As BookInfo
        Return New BookInfo With {
            .BookId = _selectedId, .Isbn = txtISBN.Text, .Title = txtBookTitle.Text, .Author = txtAuthor.Text,
            .CategoryId = SelectedId(cmbCategory), .Publisher = txtPublisher.Text, .PublicationYear = CInt(nudYear.Value),
            .Description = txtDescription.Text, .TotalCopies = CInt(nudCopies.Value)}
    End Function

    Private Function RequireSelection() As Boolean
        If _selectedId > 0 Then Return True
        ShowMsg("Select a book from the list first.", True)
        Return False
    End Function

    Private Sub OnAdd()
        _selectedId = 0
        Dim book As BookInfo = ReadBook()
        If Run(Sub() _svc.Add(book)) Then
            LoadBooks()
            ShowMsg("Book added.", False)
        End If
    End Sub

    Private Sub OnUpdate()
        If Not RequireSelection() Then Return
        Dim book As BookInfo = ReadBook()
        If Run(Sub() _svc.Update(book)) Then
            LoadBooks()
            ShowMsg("Book updated.", False)
        End If
    End Sub

    Private Sub OnDelete()
        If Not RequireSelection() Then Return
        If Not Confirm("Delete '" & txtBookTitle.Text & "' and all its copies?") Then Return
        Dim id As Integer = _selectedId
        If Run(Sub() _svc.Remove(id)) Then
            LoadBooks()
            ShowMsg("Book deleted.", False)
        End If
    End Sub
End Class
