Option Strict On
Option Explicit On

Imports System.Windows.Forms
Imports LibraryManagement.Core

''' <summary>Screen 16 - Borrow Book (student). Checks eligibility, shows the rules and borrows only after confirmation.</summary>
Public Class BorrowBookForm
    Private ReadOnly _books As New BookService()
    Private ReadOnly _loans As New LoanService()
    Private _bookId As Integer
    Private _canBorrow As Boolean

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
    End Sub

    Public Sub New(bookId As Integer)
        Me.New()
        _bookId = bookId
    End Sub

    Private Sub BorrowBookForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Run(Sub()
                Dim user As UserAccount = Guard.RequireLogin()
                Dim book As BookInfo = _books.GetBook(_bookId)
                Dim policy As LibrarySettings = New SettingsService().GetSettings()
                Dim reason As String = _loans.GetMyEligibilityMessage()
                TxtStudent.Text = user.FullName & " (" & user.AdmissionNo & ")"
                TxtBook.Text = book.Title
                TxtAvailability.Text = book.AvailableCopies.ToString() & " of " & book.TotalCopies.ToString() & " copies available"
                DtpBorrowDate.Value = Date.Today
                TxtDueDate.Text = Date.Today.AddDays(policy.LoanDays).ToString("yyyy-MM-dd")
                LblRules.Text = "Rules: books are lent for " & policy.LoanDays.ToString() & " days. Late returns cost " &
                                Formatting.Money(policy.FinePerDay, policy.Currency) & " per day. You may borrow up to " &
                                policy.MaxBooksPerStudent.ToString() & " books at a time."
                If book.AvailableCopies <= 0 Then reason = "No copies are available right now."
                _canBorrow = (reason = "")
                If reason <> "" Then ShowMessage(LblMessage, reason, True)
            End Sub, LblMessage)
        UpdateButton()
    End Sub

    Private Sub ChkConfirmRules_CheckedChanged(sender As Object, e As EventArgs) Handles ChkConfirmRules.CheckedChanged
        UpdateButton()
    End Sub

    Private Sub UpdateButton()
        BtnConfirmBorrow.Enabled = _canBorrow AndAlso ChkConfirmRules.Checked
    End Sub

    Private Sub BtnConfirmBorrow_Click(sender As Object, e As EventArgs) Handles BtnConfirmBorrow.Click
        Dim due As Date = Date.Today
        If Run(Sub() due = _loans.BorrowAsStudent(_bookId), LblMessage) Then
            Info("Borrowed successfully. Please return it by " & due.ToString("yyyy-MM-dd") & ".")
            DialogResult = DialogResult.OK
        End If
    End Sub
End Class
