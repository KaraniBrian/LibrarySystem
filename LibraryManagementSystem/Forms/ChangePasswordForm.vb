Option Strict On
Option Explicit On

Imports System.Windows.Forms
Imports LibraryManagement.Core

''' <summary>Screen 2 - Change Password (dialog used by both roles).</summary>
Public Class ChangePasswordForm
    Private ReadOnly _auth As New AuthService()

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
    End Sub

    Private Sub ChkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles ChkShowPassword.CheckedChanged
        For Each box As TextBox In {TxtCurrentPassword, TxtNewPassword, TxtConfirmPassword}
            box.UseSystemPasswordChar = Not ChkShowPassword.Checked
        Next
    End Sub

    Private Sub BtnChangePassword_Click(sender As Object, e As EventArgs) Handles BtnChangePassword.Click
        If Run(Sub() _auth.ChangePassword(TxtCurrentPassword.Text, TxtNewPassword.Text, TxtConfirmPassword.Text), LblMessage) Then
            Info("Your password was changed successfully.")
            DialogResult = DialogResult.OK
        End If
    End Sub
End Class
