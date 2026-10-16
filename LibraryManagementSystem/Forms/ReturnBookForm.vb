Option Strict On
Option Explicit On

Imports System.Data
Imports System.Windows.Forms
Imports LibraryManagement.Core

''' <summary>Screen 8 - Process Book Returns (calculates the fine and frees the copy).</summary>
Public Class ReturnBookForm
    Inherits PageForm

    Private ReadOnly _loans As New LoanService()
    Private ReadOnly lblSearch As Label = NewLabel("lblSearch", "Search Loan:")
    Private ReadOnly txtSearch As TextBox = NewTextBox("txtSearch", 100, False, "Student name, admission number or loan ID")
    Private ReadOnly btnSearch As Button = NewButton("btnSearch", "Search", ButtonKind.Primary, 100)
    Private ReadOnly dgvBorrowedBooks As DataGridView = NewGrid("dgvBorrowedBooks")
    Private ReadOnly txtStudent As TextBox = NewTextBox("txtStudent", 0, True)
    Private ReadOnly txtBook As TextBox = NewTextBox("txtBook", 0, True)
    Private ReadOnly txtIssueDate As TextBox = NewTextBox("txtIssueDate", 0, True)
    Private ReadOnly txtDueDate As TextBox = NewTextBox("txtDueDate", 0, True)
    Private ReadOnly dtpReturnDate As DateTimePicker = NewDate("dtpReturnDate")
    Private ReadOnly txtFine As TextBox = NewTextBox("txtFine", 0, True)
    Private ReadOnly btnCalculateFine As Button = NewButton("btnCalculateFine", "Calculate Fine", ButtonKind.Secondary, 150)
    Private ReadOnly btnProcessReturn As Button = NewButton("btnProcessReturn", "Confirm Return", ButtonKind.Primary, 160)
    Private ReadOnly btnCancel As Button = NewButton("btnCancel", "Cancel", ButtonKind.Secondary, 100)

    Private _loanId As Integer
    Private _currency As String = "KES"
    Private _loading As Boolean

    Public Sub New()
        MyBase.New("Process Book Returns")
        txtSearch.Width = 380
        Dim bar As FlowLayoutPanel = NewToolbar("pnlSearchBar")
        bar.Controls.AddRange(New Control() {lblSearch, txtSearch, btnSearch})
        AddAutoRow(bar)
        AddFillRow(dgvBorrowedBooks)

        Dim fields As TableLayoutPanel = NewFieldTable("tblFields", 2)
        AddField(fields, NewLabel("lblStudent", "Student:"), txtStudent)
        AddField(fields, NewLabel("lblBook", "Book:"), txtBook)
        AddField(fields, NewLabel("lblIssueDate", "Issue Date:"), txtIssueDate)
        AddField(fields, NewLabel("lblDueDate", "Due Date:"), txtDueDate)
        AddField(fields, NewLabel("lblReturnDate", "Return Date:"), dtpReturnDate)
        AddField(fields, NewLabel("lblFine", "Fine Amount:"), txtFine)
        AddAutoRow(fields)
        AddAutoRow(NewButtonRow("pnlActions", btnCalculateFine, btnProcessReturn, btnCancel))
        AddAutoRow(lblMessage)

        dtpReturnDate.MaxDate = Date.Today
        dtpReturnDate.Value = Date.Today
        AddHandler btnSearch.Click, Sub(sender As Object, e As EventArgs) LoadLoans()
        EnterKeyAction(txtSearch, AddressOf LoadLoans)
        AddHandler dgvBorrowedBooks.SelectionChanged, Sub(sender As Object, e As EventArgs) OnSelectionChanged()
        AddHandler dtpReturnDate.ValueChanged, Sub(sender As Object, e As EventArgs) OnCalculateFine()
        AddHandler btnCalculateFine.Click, Sub(sender As Object, e As EventArgs) OnCalculateFine()
        AddHandler btnProcessReturn.Click, Sub(sender As Object, e As EventArgs) OnProcessReturn()
        AddHandler btnCancel.Click, Sub(sender As Object, e As EventArgs) ClearDetails()
    End Sub

    Protected Overrides Sub LoadData()
        Run(Sub() _currency = New SettingsService().GetSettings().Currency)
        LoadLoans()
    End Sub

    Private Sub LoadLoans()
        Run(Sub()
                Dim table As DataTable = _loans.GetOpenLoans(txtSearch.Text)
                _loading = True
                Try
                    BindGrid(dgvBorrowedBooks, table)
                Finally
                    _loading = False
                End Try
            End Sub)
        ClearDetails()
    End Sub

    Private Sub ClearDetails()
        _loanId = 0
        txtStudent.Clear()
        txtBook.Clear()
        txtIssueDate.Clear()
        txtDueDate.Clear()
        txtFine.Clear()
        btnProcessReturn.Enabled = False
        btnCalculateFine.Enabled = False
        _loading = True
        Try
            dgvBorrowedBooks.ClearSelection()
            dgvBorrowedBooks.CurrentCell = Nothing
        Finally
            _loading = False
        End Try
    End Sub

    Private Sub OnSelectionChanged()
        If _loading Then Return
        Dim row As DataGridViewRow = SelectedRow(dgvBorrowedBooks)
        If row Is Nothing Then Return
        _loanId = CellInt(row, "Loan ID")
        txtStudent.Text = CellText(row, "Student")
        txtBook.Text = CellText(row, "Book")
        txtIssueDate.Text = CellDate(row, "Issue Date").ToString("yyyy-MM-dd")
        txtDueDate.Text = CellDate(row, "Due Date").ToString("yyyy-MM-dd")
        btnProcessReturn.Enabled = True
        btnCalculateFine.Enabled = True
        OnCalculateFine()
    End Sub

    Private Sub OnCalculateFine()
        If _loanId <= 0 Then Return
        Dim id As Integer = _loanId
        Dim returnDate As Date = dtpReturnDate.Value
        Run(Sub() txtFine.Text = Formatting.Money(_loans.CalculateFine(id, returnDate), _currency))
    End Sub

    Private Sub OnProcessReturn()
        If _loanId <= 0 Then
            ShowMsg("Select a loan from the list first.", True)
            Return
        End If
        If Not Confirm("Confirm return of '" & txtBook.Text & "' from " & txtStudent.Text & "? Fine: " & txtFine.Text) Then Return
        Dim id As Integer = _loanId
        Dim returnDate As Date = dtpReturnDate.Value
        Dim fine As Decimal = 0D
        If Run(Sub() fine = _loans.ProcessReturn(id, returnDate)) Then
            LoadLoans()
            If fine > 0D Then
                ShowMsg("Return recorded. A fine of " & Formatting.Money(fine, _currency) & " was created.", False)
            Else
                ShowMsg("Return recorded. No fine.", False)
            End If
        End If
    End Sub
End Class
