Option Strict On
Option Explicit On

Imports System.Data
Imports System.Windows.Forms
Imports LibraryManagement.Core

''' <summary>Screen 8 - Process Book Returns (calculates the fine and frees the copy).</summary>
Public Class ReturnBookForm
    Private ReadOnly _loans As New LoanService()
    Private _loanId As Integer
    Private _currency As String = "KES"
    Private _loading As Boolean

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        StatusColors(DgvBorrowedBooks)
    End Sub

    Private Sub ReturnBookForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DtpReturnDate.MaxDate = Date.Today
        DtpReturnDate.Value = Date.Today
        Run(Sub() _currency = New SettingsService().GetSettings().Currency, LblMessage)
        LoadLoans()
    End Sub

    Private Sub TxtSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            LoadLoans()
        End If
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        LoadLoans()
    End Sub

    Private Sub LoadLoans()
        Run(Sub()
                Dim table As DataTable = _loans.GetOpenLoans(TxtSearch.Text)
                _loading = True
                Try
                    BindGrid(DgvBorrowedBooks, table)
                Finally
                    _loading = False
                End Try
            End Sub, LblMessage)
        ClearDetails()
    End Sub

    Private Sub ClearDetails()
        _loanId = 0
        TxtStudent.Clear()
        TxtBook.Clear()
        TxtIssueDate.Clear()
        TxtDueDate.Clear()
        TxtFine.Clear()
        BtnProcessReturn.Enabled = False
        BtnCalculateFine.Enabled = False
        _loading = True
        Try
            ClearGridSelection(DgvBorrowedBooks)
        Finally
            _loading = False
        End Try
    End Sub

    Private Sub DgvBorrowedBooks_SelectionChanged(sender As Object, e As EventArgs) Handles DgvBorrowedBooks.SelectionChanged
        If _loading Then Return
        Dim row As DataGridViewRow = SelectedRow(DgvBorrowedBooks)
        If row Is Nothing Then Return
        _loanId = CellInt(row, "Loan ID")
        TxtStudent.Text = CellText(row, "Student")
        TxtBook.Text = CellText(row, "Book")
        TxtIssueDate.Text = CellDate(row, "Issue Date").ToString("yyyy-MM-dd")
        TxtDueDate.Text = CellDate(row, "Due Date").ToString("yyyy-MM-dd")
        BtnProcessReturn.Enabled = True
        BtnCalculateFine.Enabled = True
        CalculateFine()
    End Sub

    Private Sub CalculateFine()
        If _loanId <= 0 Then Return
        Dim id As Integer = _loanId
        Dim returnDate As Date = DtpReturnDate.Value
        Run(Sub() TxtFine.Text = Formatting.Money(_loans.CalculateFine(id, returnDate), _currency), LblMessage)
    End Sub

    Private Sub DtpReturnDate_ValueChanged(sender As Object, e As EventArgs) Handles DtpReturnDate.ValueChanged
        CalculateFine()
    End Sub

    Private Sub BtnCalculateFine_Click(sender As Object, e As EventArgs) Handles BtnCalculateFine.Click
        CalculateFine()
    End Sub

    Private Sub BtnProcessReturn_Click(sender As Object, e As EventArgs) Handles BtnProcessReturn.Click
        If _loanId <= 0 Then
            ShowMessage(LblMessage, "Select a loan from the list first.", True)
            Return
        End If
        If Not Confirm("Confirm return of '" & TxtBook.Text & "' from " & TxtStudent.Text & "? Fine: " & TxtFine.Text) Then Return
        Dim id As Integer = _loanId
        Dim returnDate As Date = DtpReturnDate.Value
        Dim fine As Decimal = 0D
        If Run(Sub() fine = _loans.ProcessReturn(id, returnDate), LblMessage) Then
            LoadLoans()
            If fine > 0D Then
                ShowMessage(LblMessage, "Return recorded. A fine of " & Formatting.Money(fine, _currency) & " was created.", False)
            Else
                ShowMessage(LblMessage, "Return recorded. No fine.", False)
            End If
        End If
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        ClearDetails()
        ShowMessage(LblMessage, "", False)
    End Sub
End Class
