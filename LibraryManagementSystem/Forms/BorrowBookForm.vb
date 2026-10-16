Option Strict On
Option Explicit On

Imports System.Windows.Forms
Imports LibraryManagement.Core

''' <summary>Screen 16 - Borrow Book (student). Checks eligibility, shows the rules and borrows only after confirmation.</summary>
Public Class BorrowBookForm
    Inherits DialogForm

    Private ReadOnly _books As New BookService()
    Private ReadOnly _loans As New LoanService()
    Private ReadOnly _bookId As Integer
    Private ReadOnly txtStudent As TextBox = NewTextBox("txtStudent", 0, True)
    Private ReadOnly txtBook As TextBox = NewTextBox("txtBook", 0, True)
    Private ReadOnly txtAvailability As TextBox = NewTextBox("txtAvailability", 0, True)
    Private ReadOnly dtpBorrowDate As DateTimePicker = NewDate("dtpBorrowDate")
    Private ReadOnly txtDueDate As TextBox = NewTextBox("txtDueDate", 0, True)
    Private ReadOnly lblRules As Label = NewLabel("lblRules", "")
    Private ReadOnly chkConfirmRules As CheckBox = NewCheck("chkConfirmRules", "I agree to the library borrowing rules")
    Private ReadOnly btnConfirmBorrow As Button = NewButton("btnConfirmBorrow", "Confirm Borrowing", ButtonKind.Primary, 190)
    Private ReadOnly btnCancel As Button = NewButton("btnCancel", "Cancel", ButtonKind.Secondary, 110)
    Private _canBorrow As Boolean

    Public Sub New(bookId As Integer)
        MyBase.New("Borrow Book", 520)
        _bookId = bookId
        Dim fields As TableLayoutPanel = NewFieldTable("tblFields", 1)
        AddField(fields, NewLabel("lblStudent", "Student:"), txtStudent)
        AddField(fields, NewLabel("lblBook", "Selected Book:"), txtBook)
        AddField(fields, NewLabel("lblAvailability", "Availability:"), txtAvailability)
        AddField(fields, NewLabel("lblBorrowDate", "Borrow Date:"), dtpBorrowDate)
        AddField(fields, NewLabel("lblDueDate", "Due Date:"), txtDueDate)
        AddAutoRow(fields)
        lblRules.MaximumSize = New System.Drawing.Size(500, 0)
        AddAutoRow(lblRules)
        AddAutoRow(chkConfirmRules)
        AddAutoRow(NewButtonRow("pnlActions", btnConfirmBorrow, btnCancel))
        AddAutoRow(lblMessage)

        dtpBorrowDate.Enabled = False
        btnConfirmBorrow.Enabled = False
        btnCancel.DialogResult = DialogResult.Cancel
        CancelButton = btnCancel
        AddHandler chkConfirmRules.CheckedChanged, Sub(sender As Object, e As EventArgs) UpdateButton()
        AddHandler btnConfirmBorrow.Click, Sub(sender As Object, e As EventArgs) OnConfirm()
    End Sub

    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)
        Run(Sub()
                Dim user As UserAccount = Guard.RequireLogin()
                Dim book As BookInfo = _books.GetBook(_bookId)
                Dim policy As LibrarySettings = New SettingsService().GetSettings()
                Dim reason As String = _loans.GetMyEligibilityMessage()
                txtStudent.Text = user.FullName & " (" & user.AdmissionNo & ")"
                txtBook.Text = book.Title
                txtAvailability.Text = book.AvailableCopies.ToString() & " of " & book.TotalCopies.ToString() & " copies available"
                dtpBorrowDate.Value = Date.Today
                txtDueDate.Text = Date.Today.AddDays(policy.LoanDays).ToString("yyyy-MM-dd")
                lblRules.Text = "Rules: books are lent for " & policy.LoanDays.ToString() & " days. Late returns cost " &
                                Formatting.Money(policy.FinePerDay, policy.Currency) & " per day. You may borrow up to " &
                                policy.MaxBooksPerStudent.ToString() & " books at a time."
                If book.AvailableCopies <= 0 Then reason = "No copies are available right now."
                _canBorrow = (reason = "")
                If reason <> "" Then ShowMsg(reason, True)
            End Sub)
        UpdateButton()
    End Sub

    Private Sub UpdateButton()
        btnConfirmBorrow.Enabled = _canBorrow AndAlso chkConfirmRules.Checked
    End Sub

    Private Sub OnConfirm()
        Dim due As Date = Date.Today
        If Run(Sub() due = _loans.BorrowAsStudent(_bookId)) Then
            Info("Borrowed successfully. Please return it by " & due.ToString("yyyy-MM-dd") & ".")
            DialogResult = DialogResult.OK
        End If
    End Sub
End Class
