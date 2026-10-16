Option Strict On
Option Explicit On

Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms
Imports LibraryManagement.Core

''' <summary>Screen 14 - Browse Books (search, filters and a details panel).</summary>
Public Class BookCatalogueForm
    Inherits PageForm

    Private ReadOnly _books As New BookService()
    Private ReadOnly txtSearch As TextBox = NewTextBox("txtSearch", 100, False, "Search title, author or ISBN")
    Private ReadOnly btnSearch As Button = NewButton("btnSearch", "Search", ButtonKind.Primary, 100)
    Private ReadOnly cmbCategory As ComboBox = NewCombo("cmbCategory")
    Private ReadOnly cmbAvailability As ComboBox = NewCombo("cmbAvailability")
    Private ReadOnly btnClearFilters As Button = NewButton("btnClearFilters", "Clear Filters", ButtonKind.Secondary, 130)
    Private ReadOnly dgvBooks As DataGridView = NewGrid("dgvBooks")
    Private ReadOnly picBookCover As New PictureBox() With {.Name = "picBookCover", .Size = New Size(160, 200), .SizeMode = PictureBoxSizeMode.Zoom}
    Private ReadOnly lblBookTitle As Label = NewLabel("lblBookTitle", "Select a book", True)
    Private ReadOnly lblAuthor As Label = NewLabel("lblAuthor", "Author:")
    Private ReadOnly lblISBN As Label = NewLabel("lblISBN", "ISBN:")
    Private ReadOnly lblAvailabilityValue As Label = NewLabel("lblAvailabilityValue", "Availability:")
    Private ReadOnly btnViewDetails As Button = NewButton("btnViewDetails", "View Details", ButtonKind.Secondary, 200)
    Private ReadOnly btnBorrow As Button = NewButton("btnBorrow", "Borrow Book", ButtonKind.Primary, 200)
    Private _bookId As Integer
    Private _loading As Boolean

    Public Sub New()
        MyBase.New("Browse Books")
        txtSearch.Width = 300
        cmbCategory.Width = 170
        cmbAvailability.Width = 130
        Dim bar As FlowLayoutPanel = NewToolbar("pnlFilters")
        bar.Controls.AddRange(New Control() {txtSearch, btnSearch, NewLabel("lblCategory", "Category:"), cmbCategory,
                                             NewLabel("lblAvailability", "Availability:"), cmbAvailability, btnClearFilters})
        AddAutoRow(bar)

        Dim details As New FlowLayoutPanel With {.Name = "pnlDetails", .Width = 260, .Dock = DockStyle.Fill, .BackColor = Color.White,
                                                 .BorderStyle = BorderStyle.FixedSingle, .FlowDirection = FlowDirection.TopDown,
                                                 .WrapContents = False, .Padding = New Padding(14), .Margin = New Padding(12, 4, 0, 4)}
        For Each wrapped As Label In {lblBookTitle, lblAuthor, lblISBN, lblAvailabilityValue}
            wrapped.MaximumSize = New Size(225, 0)
        Next
        details.Controls.AddRange(New Control() {picBookCover, lblBookTitle, lblAuthor, lblISBN, lblAvailabilityValue, btnViewDetails, btnBorrow})

        Dim body As New TableLayoutPanel With {.Name = "tblBody", .ColumnCount = 2, .RowCount = 1}
        body.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100.0F))
        body.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 275.0F))
        body.RowStyles.Add(New RowStyle(SizeType.Percent, 100.0F))
        body.Controls.Add(dgvBooks, 0, 0)
        body.Controls.Add(details, 1, 0)
        dgvBooks.Dock = DockStyle.Fill
        AddFillRow(body)
        AddAutoRow(lblMessage)

        FillCombo(cmbAvailability, {"All", "Available", "Unavailable"})
        picBookCover.Image = MakeCover("Select a book", 160, 200)
        btnViewDetails.Enabled = False
        btnBorrow.Enabled = False
        AddHandler btnSearch.Click, Sub(sender As Object, e As EventArgs) LoadBooks()
        EnterKeyAction(txtSearch, AddressOf LoadBooks)
        AddHandler cmbCategory.SelectionChangeCommitted, Sub(sender As Object, e As EventArgs) LoadBooks()
        AddHandler cmbAvailability.SelectionChangeCommitted, Sub(sender As Object, e As EventArgs) LoadBooks()
        AddHandler btnClearFilters.Click, Sub(sender As Object, e As EventArgs) OnClearFilters()
        AddHandler dgvBooks.SelectionChanged, Sub(sender As Object, e As EventArgs) OnSelectionChanged()
        AddHandler btnViewDetails.Click, Sub(sender As Object, e As EventArgs) OnViewDetails()
        AddHandler btnBorrow.Click, Sub(sender As Object, e As EventArgs) OnBorrow()
    End Sub

    Protected Overrides Sub LoadData()
        Run(Sub() BindLookup(cmbCategory, _books.GetCategories(True), "category_id", "name"))
        If cmbCategory.Items.Count > 0 Then cmbCategory.SelectedIndex = 0
        LoadBooks()
    End Sub

    Private Sub OnClearFilters()
        txtSearch.Clear()
        If cmbCategory.Items.Count > 0 Then cmbCategory.SelectedIndex = 0
        cmbAvailability.SelectedIndex = 0
        LoadBooks()
    End Sub

    Private Sub LoadBooks()
        Run(Sub()
                Dim table As DataTable = _books.Search(txtSearch.Text, SelectedId(cmbCategory), Convert.ToString(cmbAvailability.SelectedItem))
                _loading = True
                Try
                    BindGrid(dgvBooks, table, "Id")
                Finally
                    _loading = False
                End Try
            End Sub)
        OnSelectionChanged()
    End Sub

    Private Sub OnSelectionChanged()
        If _loading Then Return
        Dim row As DataGridViewRow = SelectedRow(dgvBooks)
        If row Is Nothing Then
            _bookId = 0
            btnViewDetails.Enabled = False
            btnBorrow.Enabled = False
            Return
        End If
        _bookId = CellInt(row, "Id")
        Dim available As Integer = CellInt(row, "Available")
        lblBookTitle.Text = CellText(row, "Title")
        lblAuthor.Text = "Author: " & CellText(row, "Author")
        lblISBN.Text = "ISBN: " & CellText(row, "ISBN")
        lblAvailabilityValue.Text = "Availability: " & available.ToString() & " of " & CellText(row, "Copies") & " copies"
        picBookCover.Image = MakeCover(CellText(row, "Title"), 160, 200)
        btnViewDetails.Enabled = True
        btnBorrow.Enabled = available > 0
    End Sub

    Private Sub OnViewDetails()
        If _bookId <= 0 Then Return
        Using dialog As New BookDetailsForm(_bookId)
            If dialog.ShowDialog(Me) = DialogResult.OK Then
                LoadBooks()
                ShowMsg("Book borrowed. See 'My Borrowed Books' for the due date.", False)
            End If
        End Using
    End Sub

    Private Sub OnBorrow()
        If _bookId <= 0 Then Return
        Using dialog As New BorrowBookForm(_bookId)
            If dialog.ShowDialog(Me) = DialogResult.OK Then
                LoadBooks()
                ShowMsg("Book borrowed. See 'My Borrowed Books' for the due date.", False)
            End If
        End Using
    End Sub
End Class
