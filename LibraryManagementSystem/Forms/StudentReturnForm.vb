Option Strict On
Option Explicit On

Imports System.Windows.Forms
Imports LibraryManagement.Core

''' <summary>
''' Screen 18 - Student return request (dialog). The copy stays borrowed until the librarian
''' confirms the physical return on the Process Returns screen.
''' </summary>
Public Class StudentReturnForm
    Inherits DialogForm

    Private ReadOnly _loans As New LoanService()
    Private ReadOnly _loanId As Integer
    Private ReadOnly txtBook As TextBox = NewTextBox("txtBook", 0, True)
    Private ReadOnly txtLoanID As TextBox = NewTextBox("txtLoanID", 0, True)
    Private ReadOnly txtDueDate As TextBox = NewTextBox("txtDueDate", 0, True)
    Private ReadOnly dtpReturnDate As DateTimePicker = NewDate("dtpReturnDate")
    Private ReadOnly cmbCondition As ComboBox = NewCombo("cmbCondition")
    Private ReadOnly txtNotes As TextBox = NewMultiline("txtNotes", 500, 70)
    Private ReadOnly btnSubmitRequest As Button = NewButton("btnSubmitRequest", "Submit Return Request", ButtonKind.Primary, 210)
    Private ReadOnly btnCancel As Button = NewButton("btnCancel", "Cancel", ButtonKind.Secondary, 110)

    Public Sub New(loanId As Integer, bookTitle As String, dueDate As String)
        MyBase.New("Request Book Return", 520)
        _loanId = loanId
        Dim fields As TableLayoutPanel = NewFieldTable("tblFields", 1)
        AddField(fields, NewLabel("lblBook", "Book:"), txtBook)
        AddField(fields, NewLabel("lblLoanID", "Loan ID:"), txtLoanID)
        AddField(fields, NewLabel("lblDueDate", "Due Date:"), txtDueDate)
        AddField(fields, NewLabel("lblReturnDate", "Return Date:"), dtpReturnDate)
        AddField(fields, NewLabel("lblCondition", "Book Condition:"), cmbCondition)
        AddField(fields, NewLabel("lblNotes", "Additional Notes:"), txtNotes)
        AddAutoRow(fields)
        AddAutoRow(NewLabel("lblInfo", "The librarian confirms the return and records the official return date."))
        AddAutoRow(NewButtonRow("pnlActions", btnSubmitRequest, btnCancel))
        AddAutoRow(lblMessage)

        txtBook.Text = bookTitle
        txtLoanID.Text = loanId.ToString()
        txtDueDate.Text = dueDate
        dtpReturnDate.Value = Date.Today
        dtpReturnDate.Enabled = False
        FillCombo(cmbCondition, {"Good", "Fair", "Damaged"})
        btnCancel.DialogResult = DialogResult.Cancel
        CancelButton = btnCancel
        AddHandler btnSubmitRequest.Click, Sub(sender As Object, e As EventArgs) OnSubmit()
    End Sub

    Private Sub OnSubmit()
        Dim condition As String = Convert.ToString(cmbCondition.SelectedItem)
        Dim notes As String = txtNotes.Text
        If Run(Sub() _loans.RequestReturn(_loanId, condition, notes)) Then DialogResult = DialogResult.OK
    End Sub
End Class
