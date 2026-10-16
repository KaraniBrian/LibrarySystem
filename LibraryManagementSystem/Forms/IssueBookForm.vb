Option Strict On
Option Explicit On

Imports System.Data
Imports System.Windows.Forms
Imports LibraryManagement.Core

''' <summary>Screen 7 - Issue / Borrow Book (librarian issues a copy to a student).</summary>
Public Class IssueBookForm
    Inherits PageForm

    Private ReadOnly _students As New StudentService()
    Private ReadOnly _books As New BookService()
    Private ReadOnly _loans As New LoanService()
    Private ReadOnly cmbStudent As ComboBox = NewCombo("cmbStudent")
    Private ReadOnly cmbBook As ComboBox = NewCombo("cmbBook")
    Private ReadOnly cmbBookCopy As ComboBox = NewCombo("cmbBookCopy")
    Private ReadOnly dtpIssueDate As DateTimePicker = NewDate("dtpIssueDate")
    Private ReadOnly dtpDueDate As DateTimePicker = NewDate("dtpDueDate")
    Private ReadOnly txtAvailability As TextBox = NewTextBox("txtAvailability", 0, True)
    Private ReadOnly btnIssue As Button = NewButton("btnIssue", "Issue Book", ButtonKind.Primary, 150)
    Private ReadOnly btnClear As Button = NewButton("btnClear", "Clear", ButtonKind.Secondary, 100)
    Private _eligible As Boolean = True

    Public Sub New()
        MyBase.New("Issue / Borrow Book")
        Dim fields As TableLayoutPanel = NewFieldTable("tblFields", 1)
        fields.MaximumSize = New System.Drawing.Size(650, 0)
        fields.Dock = DockStyle.Left
        AddField(fields, NewLabel("lblStudent", "Select Student:"), cmbStudent)
        AddField(fields, NewLabel("lblBook", "Select Book:"), cmbBook)
        AddField(fields, NewLabel("lblCopy", "Select Available Copy:"), cmbBookCopy)
        AddField(fields, NewLabel("lblAvailability", "Availability:"), txtAvailability)
        AddField(fields, NewLabel("lblIssueDate", "Issue Date:"), dtpIssueDate)
        AddField(fields, NewLabel("lblDueDate", "Due Date:"), dtpDueDate)
        AddAutoRow(fields)
        AddAutoRow(NewButtonRow("pnlActions", btnIssue, btnClear))
        AddAutoRow(lblMessage)
        Root.RowStyles.Add(New RowStyle(SizeType.Percent, 100.0F))
        Root.RowCount += 1

        dtpIssueDate.Enabled = False
        AddHandler cmbStudent.SelectedIndexChanged, Sub(sender As Object, e As EventArgs) OnStudentChanged()
        AddHandler cmbBook.SelectedIndexChanged, Sub(sender As Object, e As EventArgs) OnBookChanged()
        AddHandler cmbBookCopy.SelectedIndexChanged, Sub(sender As Object, e As EventArgs) UpdateIssueButton()
        AddHandler btnIssue.Click, Sub(sender As Object, e As EventArgs) OnIssue()
        AddHandler btnClear.Click, Sub(sender As Object, e As EventArgs) LoadData()
    End Sub

    Protected Overrides Sub LoadData()
        Run(Sub()
                Dim loanDays As Integer = New SettingsService().GetSettings().LoanDays
                dtpDueDate.MinDate = Date.Today
                dtpDueDate.MaxDate = Date.Today.AddDays(365)
                dtpDueDate.Value = Date.Today.AddDays(loanDays)
                dtpIssueDate.Value = Date.Today
                BindLookup(cmbStudent, _students.GetActiveLookup(), "student_id", "label")
                BindLookup(cmbBook, _books.GetAvailableLookup(), "book_id", "label")
                cmbBookCopy.DataSource = Nothing
                txtAvailability.Clear()
            End Sub)
        _eligible = True
        UpdateIssueButton()
    End Sub

    Private Sub OnStudentChanged()
        _eligible = True
        Dim studentId As Integer = SelectedId(cmbStudent)
        If studentId > 0 Then
            Dim reason As String = ""
            If Run(Sub() reason = _loans.GetEligibilityMessage(studentId)) Then
                _eligible = (reason = "")
                ShowMsg(reason, True)
            End If
        End If
        UpdateIssueButton()
    End Sub

    Private Sub OnBookChanged()
        Dim bookId As Integer = SelectedId(cmbBook)
        If bookId <= 0 Then Return
        Run(Sub()
                Dim copies As DataTable = _loans.GetAvailableCopies(bookId)
                BindLookup(cmbBookCopy, copies, "copy_id", "label")
                txtAvailability.Text = copies.Rows.Count.ToString() & " copy(ies) available"
                If copies.Rows.Count > 0 Then cmbBookCopy.SelectedIndex = 0
            End Sub)
        UpdateIssueButton()
    End Sub

    Private Sub UpdateIssueButton()
        btnIssue.Enabled = _eligible AndAlso SelectedId(cmbStudent) > 0 AndAlso SelectedId(cmbBookCopy) > 0
    End Sub

    Private Sub OnIssue()
        Dim studentId As Integer = SelectedId(cmbStudent)
        Dim copyId As Integer = SelectedId(cmbBookCopy)
        Dim dueDate As Date = dtpDueDate.Value
        Dim summary As String = cmbBook.Text & " to " & cmbStudent.Text & ", due " & dueDate.ToString("yyyy-MM-dd")
        If Not Confirm("Issue " & summary & "?") Then Return
        If Run(Sub() _loans.Issue(studentId, copyId, dueDate)) Then
            LoadData()
            ShowMsg("Book issued: " & summary & ".", False)
        End If
    End Sub
End Class
