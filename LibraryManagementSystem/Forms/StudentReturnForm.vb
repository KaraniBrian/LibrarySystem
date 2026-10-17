Option Strict On
Option Explicit On

Imports System.Windows.Forms
Imports LibraryManagement.Core

''' <summary>
''' Screen 18 - Student return request (dialog). The copy stays borrowed until the librarian
''' confirms the physical return on the Process Returns screen.
''' </summary>
Public Class StudentReturnForm
    Private ReadOnly _loans As New LoanService()
    Private _loanId As Integer

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
    End Sub

    Public Sub New(loanId As Integer, bookTitle As String, dueDate As String)
        Me.New()
        _loanId = loanId
        TxtBook.Text = bookTitle
        TxtLoanId.Text = loanId.ToString()
        TxtDueDate.Text = dueDate
    End Sub

    Private Sub StudentReturnForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DtpReturnDate.Value = Date.Today
        CmbCondition.SelectedIndex = 0
    End Sub

    Private Sub BtnSubmitRequest_Click(sender As Object, e As EventArgs) Handles BtnSubmitRequest.Click
        Dim condition As String = Convert.ToString(CmbCondition.SelectedItem)
        Dim notes As String = TxtNotes.Text
        If Run(Sub() _loans.RequestReturn(_loanId, condition, notes), LblMessage) Then DialogResult = DialogResult.OK
    End Sub
End Class
