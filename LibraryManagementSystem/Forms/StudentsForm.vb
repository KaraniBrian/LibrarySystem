Option Strict On
Option Explicit On

Imports System.Data
Imports System.Windows.Forms
Imports LibraryManagement.Core

''' <summary>Screen 5 - Manage Students (add, view, update, search, deactivate/delete, reset password).</summary>
Public Class StudentsForm
    Inherits PageForm

    Private ReadOnly _svc As New StudentService()
    Private ReadOnly lblSearch As Label = NewLabel("lblSearch", "Search Student:")
    Private ReadOnly txtSearch As TextBox = NewTextBox("txtSearch", 100, False, "Search by name, email or admission number")
    Private ReadOnly btnSearch As Button = NewButton("btnSearch", "Search", ButtonKind.Primary, 100)
    Private ReadOnly btnRefresh As Button = NewButton("btnRefresh", "Refresh", ButtonKind.Secondary, 100)
    Private ReadOnly dgvStudents As DataGridView = NewGrid("dgvStudents")
    Private ReadOnly txtFirstName As TextBox = NewTextBox("txtFirstName", 100)
    Private ReadOnly txtLastName As TextBox = NewTextBox("txtLastName", 100)
    Private ReadOnly txtAdmissionNo As TextBox = NewTextBox("txtAdmissionNo", 50)
    Private ReadOnly txtEmail As TextBox = NewTextBox("txtEmail", 255)
    Private ReadOnly txtPhone As TextBox = NewTextBox("txtPhone", 20)
    Private ReadOnly cmbStatus As ComboBox = NewCombo("cmbStatus")
    Private ReadOnly btnAdd As Button = NewButton("btnAdd", "Add Student", ButtonKind.Primary, 140)
    Private ReadOnly btnUpdate As Button = NewButton("btnUpdate", "Update Student", ButtonKind.Primary, 150)
    Private ReadOnly btnDelete As Button = NewButton("btnDelete", "Delete Student", ButtonKind.Danger, 150)
    Private ReadOnly btnResetPassword As Button = NewButton("btnResetPassword", "Reset Password", ButtonKind.Secondary, 150)
    Private ReadOnly btnClear As Button = NewButton("btnClear", "Clear", ButtonKind.Secondary, 100)

    Private _selectedId As Integer
    Private _loading As Boolean

    Public Sub New()
        MyBase.New("Manage Students")
        txtSearch.Width = 380
        Dim bar As FlowLayoutPanel = NewToolbar("pnlSearchBar")
        bar.Controls.AddRange(New Control() {lblSearch, txtSearch, btnSearch, btnRefresh})
        AddAutoRow(bar)
        AddFillRow(dgvStudents)

        Dim fields As TableLayoutPanel = NewFieldTable("tblFields", 2)
        AddField(fields, NewLabel("lblFirstName", "First Name:"), txtFirstName)
        AddField(fields, NewLabel("lblLastName", "Last Name:"), txtLastName)
        AddField(fields, NewLabel("lblAdmissionNo", "Admission Number:"), txtAdmissionNo)
        AddField(fields, NewLabel("lblEmail", "Email:"), txtEmail)
        AddField(fields, NewLabel("lblPhone", "Phone:"), txtPhone)
        AddField(fields, NewLabel("lblStatus", "Account Status:"), cmbStatus)
        AddAutoRow(fields)
        AddAutoRow(NewButtonRow("pnlActions", btnAdd, btnUpdate, btnDelete, btnResetPassword, btnClear))
        AddAutoRow(lblMessage)

        FillCombo(cmbStatus, {"Active", "Inactive"})
        AddHandler btnSearch.Click, Sub(sender As Object, e As EventArgs) LoadStudents()
        AddHandler btnRefresh.Click, Sub(sender As Object, e As EventArgs) OnRefresh()
        EnterKeyAction(txtSearch, AddressOf LoadStudents)
        AddHandler dgvStudents.SelectionChanged, Sub(sender As Object, e As EventArgs) OnSelectionChanged()
        AddHandler btnAdd.Click, Sub(sender As Object, e As EventArgs) OnAdd()
        AddHandler btnUpdate.Click, Sub(sender As Object, e As EventArgs) OnUpdate()
        AddHandler btnDelete.Click, Sub(sender As Object, e As EventArgs) OnDelete()
        AddHandler btnResetPassword.Click, Sub(sender As Object, e As EventArgs) OnResetPassword()
        AddHandler btnClear.Click, Sub(sender As Object, e As EventArgs) ClearFields()
    End Sub

    Protected Overrides Sub LoadData()
        LoadStudents()
    End Sub

    Private Sub OnRefresh()
        txtSearch.Clear()
        LoadStudents()
    End Sub

    Private Sub LoadStudents()
        Run(Sub()
                Dim table As DataTable = _svc.Search(txtSearch.Text)
                _loading = True
                Try
                    BindGrid(dgvStudents, table, "Id")
                Finally
                    _loading = False
                End Try
            End Sub)
        ClearFields()
    End Sub

    Private Sub OnSelectionChanged()
        If _loading Then Return
        Dim row As DataGridViewRow = SelectedRow(dgvStudents)
        If row Is Nothing Then Return
        _selectedId = CellInt(row, "Id")
        txtFirstName.Text = CellText(row, "First Name")
        txtLastName.Text = CellText(row, "Last Name")
        txtAdmissionNo.Text = CellText(row, "Admission No")
        txtEmail.Text = CellText(row, "Email")
        txtPhone.Text = CellText(row, "Phone")
        cmbStatus.SelectedItem = CellText(row, "Status")
    End Sub

    Private Sub ClearFields()
        _selectedId = 0
        txtFirstName.Clear()
        txtLastName.Clear()
        txtAdmissionNo.Clear()
        txtEmail.Clear()
        txtPhone.Clear()
        cmbStatus.SelectedIndex = 0
        _loading = True
        Try
            dgvStudents.ClearSelection()
            dgvStudents.CurrentCell = Nothing
        Finally
            _loading = False
        End Try
        txtFirstName.Focus()
    End Sub

    Private Function ReadRecord() As StudentRecord
        Return New StudentRecord With {
            .StudentId = _selectedId, .FirstName = txtFirstName.Text, .LastName = txtLastName.Text,
            .AdmissionNo = txtAdmissionNo.Text, .Email = txtEmail.Text, .Phone = txtPhone.Text,
            .IsActive = (Convert.ToString(cmbStatus.SelectedItem) = "Active")}
    End Function

    Private Function RequireSelection() As Boolean
        If _selectedId > 0 Then Return True
        ShowMsg("Select a student from the list first.", True)
        Return False
    End Function

    Private Sub OnAdd()
        _selectedId = 0
        Dim rec As StudentRecord = ReadRecord()
        If Run(Sub() _svc.Add(rec)) Then
            LoadStudents()
            ShowMsg("Student added. Their starting password is " & StudentService.DefaultPassword & ".", False)
        End If
    End Sub

    Private Sub OnUpdate()
        If Not RequireSelection() Then Return
        Dim rec As StudentRecord = ReadRecord()
        If Run(Sub() _svc.Update(rec)) Then
            LoadStudents()
            ShowMsg("Student updated.", False)
        End If
    End Sub

    Private Sub OnDelete()
        If Not RequireSelection() Then Return
        Dim name As String = txtFirstName.Text & " " & txtLastName.Text
        If Not Confirm("Delete " & name & "? Students with borrowing history are deactivated instead.") Then Return
        Dim outcome As String = ""
        Dim id As Integer = _selectedId
        If Run(Sub() outcome = _svc.Remove(id)) Then
            LoadStudents()
            ShowMsg("Student " & outcome & ".", False)
        End If
    End Sub

    Private Sub OnResetPassword()
        If Not RequireSelection() Then Return
        If Not Confirm("Reset the password for " & txtFirstName.Text & " to the default password?") Then Return
        Dim id As Integer = _selectedId
        If Run(Sub() _svc.ResetPassword(id)) Then ShowMsg("Password reset to " & StudentService.DefaultPassword & ".", False)
    End Sub
End Class
