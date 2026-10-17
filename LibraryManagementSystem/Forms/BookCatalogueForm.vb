Option Strict On
Option Explicit On

Imports System.Data
Imports System.Windows.Forms
Imports LibraryManagement.Core

''' <summary>Screen 14 - Browse Books (search, filters and a details panel).</summary>
Public Class BookCatalogueForm
    Private ReadOnly _books As New BookService()
    Private _bookId As Integer
    Private _loading As Boolean

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
    End Sub

    Private Sub BookCatalogueForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Run(Sub() BindLookup(CmbCategory, _books.GetCategories(True), "category_id", "name"), LblMessage)
        If CmbCategory.Items.Count > 0 Then CmbCategory.SelectedIndex = 0
        CmbAvailability.SelectedIndex = 0
        PicBookCover.Image = MakeCover("Select a book", 160, 200)
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

    Private Sub CmbCategory_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CmbCategory.SelectionChangeCommitted
        LoadBooks()
    End Sub

    Private Sub CmbAvailability_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CmbAvailability.SelectionChangeCommitted
        LoadBooks()
    End Sub

    Private Sub BtnClearFilters_Click(sender As Object, e As EventArgs) Handles BtnClearFilters.Click
        TxtSearch.Clear()
        If CmbCategory.Items.Count > 0 Then CmbCategory.SelectedIndex = 0
        CmbAvailability.SelectedIndex = 0
        LoadBooks()
    End Sub

    Private Sub LoadBooks()
        Run(Sub()
                Dim table As DataTable = _books.Search(TxtSearch.Text, SelectedId(CmbCategory), Convert.ToString(CmbAvailability.SelectedItem))
                _loading = True
                Try
                    BindGrid(DgvBooks, table)
                Finally
                    _loading = False
                End Try
            End Sub, LblMessage)
        ShowSelectedBook()
    End Sub

    Private Sub DgvBooks_SelectionChanged(sender As Object, e As EventArgs) Handles DgvBooks.SelectionChanged
        If _loading Then Return
        ShowSelectedBook()
    End Sub

    Private Sub ShowSelectedBook()
        Dim row As DataGridViewRow = SelectedRow(DgvBooks)
        If row Is Nothing Then
            _bookId = 0
            BtnViewDetails.Enabled = False
            BtnBorrow.Enabled = False
            Return
        End If
        _bookId = CellInt(row, "Id")
        Dim available As Integer = CellInt(row, "Available")
        LblBookTitle.Text = CellText(row, "Title")
        LblAuthor.Text = "Author: " & CellText(row, "Author")
        LblIsbn.Text = "ISBN: " & CellText(row, "ISBN")
        LblAvailabilityValue.Text = "Availability: " & available.ToString() & " of " & CellText(row, "Copies") & " copies"
        PicBookCover.Image = MakeCover(CellText(row, "Title"), 160, 200)
        BtnViewDetails.Enabled = True
        BtnBorrow.Enabled = available > 0
    End Sub

    Private Sub BtnViewDetails_Click(sender As Object, e As EventArgs) Handles BtnViewDetails.Click
        If _bookId <= 0 Then Return
        Using dialog As New BookDetailsForm(_bookId)
            If dialog.ShowDialog(Me) = DialogResult.OK Then
                LoadBooks()
                ShowMessage(LblMessage, "Book borrowed. See 'My Borrowed Books' for the due date.", False)
            End If
        End Using
    End Sub

    Private Sub BtnBorrow_Click(sender As Object, e As EventArgs) Handles BtnBorrow.Click
        If _bookId <= 0 Then Return
        Using dialog As New BorrowBookForm(_bookId)
            If dialog.ShowDialog(Me) = DialogResult.OK Then
                LoadBooks()
                ShowMessage(LblMessage, "Book borrowed. See 'My Borrowed Books' for the due date.", False)
            End If
        End Using
    End Sub
End Class
