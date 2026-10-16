Option Strict On
Option Explicit On

Imports System.Windows.Forms
Imports LibraryManagement.Core

''' <summary>Screen 2 - Change Password (dialog used by both roles).</summary>
Public Class ChangePasswordForm
    Inherits DialogForm

    Private ReadOnly _auth As New AuthService()
    Private ReadOnly txtCurrentPassword As TextBox = NewPasswordBox("txtCurrentPassword")
    Private ReadOnly txtNewPassword As TextBox = NewPasswordBox("txtNewPassword")
    Private ReadOnly txtConfirmPassword As TextBox = NewPasswordBox("txtConfirmPassword")
    Private ReadOnly chkShowPassword As CheckBox = NewCheck("chkShowPassword", "Show passwords")
    Private ReadOnly btnChangePassword As Button = NewButton("btnChangePassword", "Change Password", ButtonKind.Primary, 170)
    Private ReadOnly btnCancel As Button = NewButton("btnCancel", "Cancel", ButtonKind.Secondary, 110)

    Public Sub New()
        MyBase.New("Change Password")
        Dim fields As TableLayoutPanel = NewFieldTable("tblFields", 1)
        AddField(fields, NewLabel("lblCurrentPassword", "Current Password:"), txtCurrentPassword)
        AddField(fields, NewLabel("lblNewPassword", "New Password:"), txtNewPassword)
        AddField(fields, NewLabel("lblConfirmPassword", "Confirm New Password:"), txtConfirmPassword)
        AddAutoRow(fields)
        AddAutoRow(NewLabel("lblRules", "Use at least 8 characters with letters and numbers."))
        AddAutoRow(chkShowPassword)
        AddAutoRow(NewButtonRow("pnlActions", btnChangePassword, btnCancel))
        AddAutoRow(lblMessage)

        btnCancel.DialogResult = DialogResult.Cancel
        AcceptButton = btnChangePassword
        CancelButton = btnCancel
        AddHandler btnChangePassword.Click, Sub(sender As Object, e As EventArgs) OnChangePassword()
        AddHandler chkShowPassword.CheckedChanged, Sub(sender As Object, e As EventArgs) OnShowToggle()
    End Sub

    Private Sub OnShowToggle()
        For Each box As TextBox In {txtCurrentPassword, txtNewPassword, txtConfirmPassword}
            box.UseSystemPasswordChar = Not chkShowPassword.Checked
        Next
    End Sub

    Private Sub OnChangePassword()
        If Run(Sub() _auth.ChangePassword(txtCurrentPassword.Text, txtNewPassword.Text, txtConfirmPassword.Text)) Then
            Info("Your password was changed successfully.")
            DialogResult = DialogResult.OK
        End If
    End Sub
End Class
