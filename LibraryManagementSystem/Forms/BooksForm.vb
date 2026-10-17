Option Strict On
Option Explicit On

Imports System.Data
Imports System.Windows.Forms
Imports LibraryManagement.Core

''' <summary>Screen 6 - Manage Books (details plus number of copies).</summary>
Public Class BooksForm
    Private ReadOnly _svc As New BookService()
    Private _selectedId As Integer
    Private _loading As Boolean

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
    End Sub

    Private Sub BooksForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Run(Sub() BindLookup(CmbCategory, _svc.GetCategories(False), "category_id", "name"), LblMessage)
        LoadBooks()
    End Sub

    Private Sub TxtSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            LoadBooks()
        End If
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        LoadBooks()
    End Sub

    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles BtnRefresh.Click
        TxtSearch.Clear()
        LoadBooks()
    End Sub

    Private Sub LoadBooks()
        Run(Sub()
                Dim table As DataTable = _svc.Search(TxtSearch.Text, 0, "All")
                _loading = True
                Try
                    BindGrid(DgvBooks, table)
                Finally
                    _loading = False
                End Try
            End Sub, LblMessage)
        ClearFields()
    End Sub

    Private Sub DgvBooks_SelectionChanged(sender As Object, e As EventArgs) Handles DgvBooks.SelectionChanged
        If _loading Then Return
        Dim row As DataGridViewRow = SelectedRow(DgvBooks)
        If row Is Nothing Then Return
        Dim id As Integer = CellInt(row, "Id")
        Run(Sub()
                Dim book As BookInfo = _svc.GetBook(id)
                _selectedId = book.BookId
                TxtIsbn.Text = book.Isbn
                TxtBookTitle.Text = book.Title
                TxtAuthor.Text = book.Author
                CmbCategory.SelectedValue = book.CategoryId
                TxtPublisher.Text = book.Publisher
                NudYear.Value = Math.Min(Math.Max(book.PublicationYear, 1000), 2100)
                NudCopies.Value = Math.Min(book.TotalCopies, 10000)
                TxtDescription.Text = book.Description
            End Sub, LblMessage)
    End Sub

    Private Sub ClearFields()
        _selectedId = 0
        TxtIsbn.Clear()
        TxtBookTitle.Clear()
        TxtAuthor.Clear()
        TxtPublisher.Clear()
        TxtDescription.Clear()
        CmbCategory.SelectedIndex = -1
        NudYear.Value = Math.Min(Math.Max(Date.Today.Year, 1000), 2100)
        NudCopies.Value = 1
        _loading = True
        Try
            ClearGridSelection(DgvBooks)
        Finally
            _loading = False
        End Try
        TxtIsbn.Focus()
    End Sub

    Private Function ReadBook() As BookInfo
        Return New BookInfo With {
            .BookId = _selectedId, .Isbn = TxtIsbn.Text, .Title = TxtBookTitle.Text, .Author = TxtAuthor.Text,
            .CategoryId = SelectedId(CmbCategory), .Publisher = TxtPublisher.Text, .PublicationYear = CInt(NudYear.Value),
            .Description = TxtDescription.Text, .TotalCopies = CInt(NudCopies.Value)}
    End Function

    Private Function RequireSelection() As Boolean
        If _selectedId > 0 Then Return True
        ShowMessage(LblMessage, "Select a book from the list first.", True)
        Return False
    End Function

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        _selectedId = 0
        Dim book As BookInfo = ReadBook()
        If Run(Sub() _svc.Add(book), LblMessage) Then
            LoadBooks()
            ShowMessage(LblMessage, "Book added.", False)
        End If
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        If Not RequireSelection() Then Return
        Dim book As BookInfo = ReadBook()
        If Run(Sub() _svc.Update(book), LblMessage) Then
            LoadBooks()
            ShowMessage(LblMessage, "Book updated.", False)
        End If
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If Not RequireSelection() Then Return
        If Not Confirm("Delete '" & TxtBookTitle.Text & "' and all its copies?") Then Return
        Dim id As Integer = _selectedId
        If Run(Sub() _svc.Remove(id), LblMessage) Then
            LoadBooks()
            ShowMessage(LblMessage, "Book deleted.", False)
        End If
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        ClearFields()
    End Sub
End Class
