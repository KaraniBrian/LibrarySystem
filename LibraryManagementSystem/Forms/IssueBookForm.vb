Option Strict On
Option Explicit On

Imports System.Data
Imports System.Windows.Forms
Imports LibraryManagement.Core

''' <summary>Screen 7 - Issue / Borrow Book (librarian issues a copy to a student).</summary>
Public Class IssueBookForm
    Private ReadOnly _students As New StudentService()
    Private ReadOnly _books As New BookService()
    Private ReadOnly _loans As New LoanService()
    Private _eligible As Boolean = True
    Private _loading As Boolean

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
    End Sub

    Private Sub IssueBookForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ResetForm()
    End Sub

    Private Sub ResetForm()
        _loading = True
        Try
            Run(Sub()
                    Dim loanDays As Integer = New SettingsService().GetSettings().LoanDays
                    DtpDueDate.MinDate = Date.Today
                    DtpDueDate.MaxDate = Date.Today.AddDays(365)
                    DtpDueDate.Value = Date.Today.AddDays(loanDays)
                    DtpIssueDate.Value = Date.Today
                    BindLookup(CmbStudent, _students.GetActiveLookup(), "student_id", "label")
                    BindLookup(CmbBook, _books.GetAvailableLookup(), "book_id", "label")
                    CmbBookCopy.DataSource = Nothing
                    CmbBookCopy.Items.Clear()
                    TxtAvailability.Clear()
                End Sub, LblMessage)
        Finally
            _loading = False
        End Try
        _eligible = True
        UpdateIssueButton()
    End Sub

    Private Sub CmbStudent_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbStudent.SelectedIndexChanged
        If _loading Then Return
        _eligible = True
        ShowMessage(LblMessage, "", True)
        Dim studentId As Integer = SelectedId(CmbStudent)
        If studentId > 0 Then
            Dim reason As String = ""
            If Run(Sub() reason = _loans.GetEligibilityMessage(studentId), LblMessage) Then
                _eligible = (reason = "")
                ShowMessage(LblMessage, reason, True)
            End If
        End If
        UpdateIssueButton()
    End Sub

    Private Sub CmbBook_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbBook.SelectedIndexChanged
        If _loading Then Return
        Dim bookId As Integer = SelectedId(CmbBook)
        If bookId <= 0 Then Return
        Run(Sub()
                Dim copies As DataTable = _loans.GetAvailableCopies(bookId)
                BindLookup(CmbBookCopy, copies, "copy_id", "label")
                TxtAvailability.Text = copies.Rows.Count.ToString() & " copy(ies) available"
                If copies.Rows.Count > 0 Then CmbBookCopy.SelectedIndex = 0
            End Sub, LblMessage)
        UpdateIssueButton()
    End Sub

    Private Sub CmbBookCopy_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbBookCopy.SelectedIndexChanged
        UpdateIssueButton()
    End Sub

    Private Sub UpdateIssueButton()
        BtnIssue.Enabled = _eligible AndAlso SelectedId(CmbStudent) > 0 AndAlso SelectedId(CmbBookCopy) > 0
    End Sub

    Private Sub BtnIssue_Click(sender As Object, e As EventArgs) Handles BtnIssue.Click
        Dim studentId As Integer = SelectedId(CmbStudent)
        Dim copyId As Integer = SelectedId(CmbBookCopy)
        Dim dueDate As Date = DtpDueDate.Value
        Dim summary As String = CmbBook.Text & " to " & CmbStudent.Text & ", due " & dueDate.ToString("yyyy-MM-dd")
        If Not Confirm("Issue " & summary & "?") Then Return
        If Run(Sub() _loans.Issue(studentId, copyId, dueDate), LblMessage) Then
            ResetForm()
            ShowMessage(LblMessage, "Book issued: " & summary & ".", False)
        End If
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        ResetForm()
        ShowMessage(LblMessage, "", False)
    End Sub
End Class
