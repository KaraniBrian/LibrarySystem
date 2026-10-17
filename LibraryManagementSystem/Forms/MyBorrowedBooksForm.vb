Option Strict On
Option Explicit On

Imports System.Data
Imports System.Windows.Forms
Imports LibraryManagement.Core

''' <summary>Screen 17 - My Borrowed Books (only the logged-in student's loans).</summary>
Public Class MyBorrowedBooksForm
    Private ReadOnly _loans As New LoanService()
    Private _loanId As Integer
    Private _bookId As Integer
    Private _loading As Boolean

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        StatusColors(DgvMyBooks)
    End Sub

    Private Sub MyBorrowedBooksForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CmbStatus.SelectedIndex = 0
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

    Private Sub CmbStatus_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CmbStatus.SelectionChangeCommitted
        LoadLoans()
    End Sub

    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles BtnRefresh.Click
        LoadLoans()
    End Sub

    Private Sub LoadLoans()
        Run(Sub()
                Dim table As DataTable = _loans.GetMyLoans(TxtSearch.Text, Convert.ToString(CmbStatus.SelectedItem))
                _loading = True
                Try
                    BindGrid(DgvMyBooks, table)
                Finally
                    _loading = False
                End Try
            End Sub, LblMessage)
        ClearDetails()
    End Sub

    Private Sub ClearDetails()
        _loanId = 0
        _bookId = 0
        TxtSelectedBook.Clear()
        TxtDueDate.Clear()
        TxtStatusValue.Clear()
        BtnViewDetails.Enabled = False
        BtnRequestReturn.Enabled = False
        _loading = True
        Try
            ClearGridSelection(DgvMyBooks)
        Finally
            _loading = False
        End Try
    End Sub

    Private Sub DgvMyBooks_SelectionChanged(sender As Object, e As EventArgs) Handles DgvMyBooks.SelectionChanged
        If _loading Then Return
        Dim row As DataGridViewRow = SelectedRow(DgvMyBooks)
        If row Is Nothing Then Return
        _loanId = CellInt(row, "Loan ID")
        _bookId = CellInt(row, "BookId")
        Dim status As String = CellText(row, "Status")
        TxtSelectedBook.Text = CellText(row, "Book")
        TxtDueDate.Text = CellDate(row, "Due Date").ToString("yyyy-MM-dd")
        TxtStatusValue.Text = status
        BtnViewDetails.Enabled = True
        BtnRequestReturn.Enabled = (status = "Active" OrElse status = "Overdue")
    End Sub

    Private Sub BtnViewDetails_Click(sender As Object, e As EventArgs) Handles BtnViewDetails.Click
        If _bookId <= 0 Then Return
        Using dialog As New BookDetailsForm(_bookId)
            dialog.ShowDialog(Me)
        End Using
    End Sub

    Private Sub BtnRequestReturn_Click(sender As Object, e As EventArgs) Handles BtnRequestReturn.Click
        If _loanId <= 0 Then Return
        Using dialog As New StudentReturnForm(_loanId, TxtSelectedBook.Text, TxtDueDate.Text)
            If dialog.ShowDialog(Me) = DialogResult.OK Then
                LoadLoans()
                ShowMessage(LblMessage, "Return request sent. Please hand the book to the librarian.", False)
            End If
        End Using
    End Sub
End Class
