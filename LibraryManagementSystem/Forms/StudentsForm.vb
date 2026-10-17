Option Strict On
Option Explicit On

Imports System.Data
Imports System.Windows.Forms
Imports LibraryManagement.Core

''' <summary>Screen 5 - Manage Students (add, view, update, search, deactivate/delete, reset password).</summary>
Public Class StudentsForm
    Private ReadOnly _svc As New StudentService()
    Private _selectedId As Integer
    Private _loading As Boolean

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        StatusColors(DgvStudents)
    End Sub

    Private Sub StudentsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadStudents()
    End Sub

    Private Sub TxtSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            LoadStudents()
        End If
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        LoadStudents()
    End Sub

    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles BtnRefresh.Click
        TxtSearch.Clear()
        LoadStudents()
    End Sub

    Private Sub LoadStudents()
        Run(Sub()
                Dim table As DataTable = _svc.Search(TxtSearch.Text)
                _loading = True
                Try
                    BindGrid(DgvStudents, table)
                Finally
                    _loading = False
                End Try
            End Sub, LblMessage)
        ClearFields()
    End Sub

    Private Sub DgvStudents_SelectionChanged(sender As Object, e As EventArgs) Handles DgvStudents.SelectionChanged
        If _loading Then Return
        Dim row As DataGridViewRow = SelectedRow(DgvStudents)
        If row Is Nothing Then Return
        _selectedId = CellInt(row, "Id")
        TxtFirstName.Text = CellText(row, "First Name")
        TxtLastName.Text = CellText(row, "Last Name")
        TxtAdmissionNo.Text = CellText(row, "Admission No")
        TxtEmail.Text = CellText(row, "Email")
        TxtPhone.Text = CellText(row, "Phone")
        CmbStatus.SelectedItem = CellText(row, "Status")
    End Sub

    Private Sub ClearFields()
        _selectedId = 0
        TxtFirstName.Clear()
        TxtLastName.Clear()
        TxtAdmissionNo.Clear()
        TxtEmail.Clear()
        TxtPhone.Clear()
        CmbStatus.SelectedIndex = 0
        _loading = True
        Try
            ClearGridSelection(DgvStudents)
        Finally
            _loading = False
        End Try
        TxtFirstName.Focus()
    End Sub

    Private Function ReadRecord() As StudentRecord
        Return New StudentRecord With {
            .StudentId = _selectedId, .FirstName = TxtFirstName.Text, .LastName = TxtLastName.Text,
            .AdmissionNo = TxtAdmissionNo.Text, .Email = TxtEmail.Text, .Phone = TxtPhone.Text,
            .IsActive = (Convert.ToString(CmbStatus.SelectedItem) = "Active")}
    End Function

    Private Function RequireSelection() As Boolean
        If _selectedId > 0 Then Return True
        ShowMessage(LblMessage, "Select a student from the list first.", True)
        Return False
    End Function

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        _selectedId = 0
        Dim rec As StudentRecord = ReadRecord()
        If Run(Sub() _svc.Add(rec), LblMessage) Then
            LoadStudents()
            ShowMessage(LblMessage, "Student added. Their starting password is " & StudentService.DefaultPassword & ".", False)
        End If
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        If Not RequireSelection() Then Return
        Dim rec As StudentRecord = ReadRecord()
        If Run(Sub() _svc.Update(rec), LblMessage) Then
            LoadStudents()
            ShowMessage(LblMessage, "Student updated.", False)
        End If
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If Not RequireSelection() Then Return
        Dim name As String = TxtFirstName.Text & " " & TxtLastName.Text
        If Not Confirm("Delete " & name & "? Students with borrowing history are deactivated instead.") Then Return
        Dim outcome As String = ""
        Dim id As Integer = _selectedId
        If Run(Sub() outcome = _svc.Remove(id), LblMessage) Then
            LoadStudents()
            ShowMessage(LblMessage, "Student " & outcome & ".", False)
        End If
    End Sub

    Private Sub BtnResetPassword_Click(sender As Object, e As EventArgs) Handles BtnResetPassword.Click
        If Not RequireSelection() Then Return
        If Not Confirm("Reset the password for " & TxtFirstName.Text & " to the default password?") Then Return
        Dim id As Integer = _selectedId
        If Run(Sub() _svc.ResetPassword(id), LblMessage) Then ShowMessage(LblMessage, "Password reset to " & StudentService.DefaultPassword & ".", False)
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        ClearFields()
    End Sub
End Class
