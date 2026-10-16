Option Strict On
Option Explicit On

Imports System.Data
Imports System.Windows.Forms
Imports LibraryManagement.Core

''' <summary>Screen 17 - My Borrowed Books (only the logged-in student's loans).</summary>
Public Class MyBorrowedBooksForm
    Inherits PageForm

    Private ReadOnly _loans As New LoanService()
    Private ReadOnly txtSearch As TextBox = NewTextBox("txtSearch", 100, False, "Search my borrowed books")
    Private ReadOnly btnSearch As Button = NewButton("btnSearch", "Search", ButtonKind.Primary, 100)
    Private ReadOnly cmbStatus As ComboBox = NewCombo("cmbStatus")
    Private ReadOnly dgvMyBooks As DataGridView = NewGrid("dgvMyBooks")
    Private ReadOnly txtSelectedBook As TextBox = NewTextBox("txtSelectedBook", 0, True)
    Private ReadOnly txtDueDate As TextBox = NewTextBox("txtDueDate", 0, True)
    Private ReadOnly txtStatusValue As TextBox = NewTextBox("txtStatusValue", 0, True)
    Private ReadOnly btnViewDetails As Button = NewButton("btnViewDetails", "View Details", ButtonKind.Secondary, 140)
    Private ReadOnly btnRequestReturn As Button = NewButton("btnRequestReturn", "Request Return", ButtonKind.Primary, 160)
    Private ReadOnly btnRefresh As Button = NewButton("btnRefresh", "Refresh", ButtonKind.Secondary, 100)
    Private _loanId As Integer
    Private _bookId As Integer
    Private _loading As Boolean

    Public Sub New()
        MyBase.New("My Borrowed Books")
        txtSearch.Width = 300
        cmbStatus.Width = 170
        Dim bar As FlowLayoutPanel = NewToolbar("pnlSearchBar")
        bar.Controls.AddRange(New Control() {txtSearch, btnSearch, NewLabel("lblStatus", "Borrowing Status:"), cmbStatus})
        AddAutoRow(bar)
        AddFillRow(dgvMyBooks)

        Dim fields As TableLayoutPanel = NewFieldTable("tblFields", 3)
        AddField(fields, NewLabel("lblSelectedBook", "Selected Book:"), txtSelectedBook)
        AddField(fields, NewLabel("lblDueDate", "Due Date:"), txtDueDate)
        AddField(fields, NewLabel("lblStatusValue", "Status:"), txtStatusValue)
        AddAutoRow(fields)
        AddAutoRow(NewButtonRow("pnlActions", btnViewDetails, btnRequestReturn, btnRefresh))
        AddAutoRow(lblMessage)

        FillCombo(cmbStatus, LoanService.StatusFilters)
        AddHandler btnSearch.Click, Sub(sender As Object, e As EventArgs) LoadLoans()
        EnterKeyAction(txtSearch, AddressOf LoadLoans)
        AddHandler cmbStatus.SelectionChangeCommitted, Sub(sender As Object, e As EventArgs) LoadLoans()
        AddHandler btnRefresh.Click, Sub(sender As Object, e As EventArgs) LoadLoans()
        AddHandler dgvMyBooks.SelectionChanged, Sub(sender As Object, e As EventArgs) OnSelectionChanged()
        AddHandler btnViewDetails.Click, Sub(sender As Object, e As EventArgs) OnViewDetails()
        AddHandler btnRequestReturn.Click, Sub(sender As Object, e As EventArgs) OnRequestReturn()
    End Sub

    Protected Overrides Sub LoadData()
        LoadLoans()
    End Sub

    Private Sub LoadLoans()
        Run(Sub()
                Dim table As DataTable = _loans.GetMyLoans(txtSearch.Text, Convert.ToString(cmbStatus.SelectedItem))
                _loading = True
                Try
                    BindGrid(dgvMyBooks, table, "BookId")
                Finally
                    _loading = False
                End Try
            End Sub)
        ClearDetails()
    End Sub

    Private Sub ClearDetails()
        _loanId = 0
        _bookId = 0
        txtSelectedBook.Clear()
        txtDueDate.Clear()
        txtStatusValue.Clear()
        btnViewDetails.Enabled = False
        btnRequestReturn.Enabled = False
        _loading = True
        Try
            dgvMyBooks.ClearSelection()
            dgvMyBooks.CurrentCell = Nothing
        Finally
            _loading = False
        End Try
    End Sub

    Private Sub OnSelectionChanged()
        If _loading Then Return
        Dim row As DataGridViewRow = SelectedRow(dgvMyBooks)
        If row Is Nothing Then Return
        _loanId = CellInt(row, "Loan ID")
        _bookId = CellInt(row, "BookId")
        Dim status As String = CellText(row, "Status")
        txtSelectedBook.Text = CellText(row, "Book")
        txtDueDate.Text = CellDate(row, "Due Date").ToString("yyyy-MM-dd")
        txtStatusValue.Text = status
        btnViewDetails.Enabled = True
        btnRequestReturn.Enabled = (status = "Active" OrElse status = "Overdue")
    End Sub

    Private Sub OnViewDetails()
        If _bookId <= 0 Then Return
        Using dialog As New BookDetailsForm(_bookId)
            dialog.ShowDialog(Me)
        End Using
    End Sub

    Private Sub OnRequestReturn()
        If _loanId <= 0 Then Return
        Using dialog As New StudentReturnForm(_loanId, txtSelectedBook.Text, txtDueDate.Text)
            If dialog.ShowDialog(Me) = DialogResult.OK Then
                LoadLoans()
                ShowMsg("Return request sent. Please hand the book to the librarian.", False)
            End If
        End Using
    End Sub
End Class
