Option Strict On
Option Explicit On

Imports System.IO
Imports System.Windows.Forms
Imports LibraryManagement.Core

''' <summary>Screen 1 - Login. Opens the correct dashboard for the user's role (see Program.Main).</summary>
Public Class LoginForm
    Private ReadOnly _auth As New AuthService()
    Private Shared ReadOnly RememberFile As String = Path.Combine(AppPaths.DataDirectory, "remember.txt")

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PicLogo.Image = MakeLogo(100)
        Dim remembered As String = ReadRemembered()
        If remembered <> "" Then
            TxtEmail.Text = remembered
            ChkRememberMe.Checked = True
        End If
    End Sub

    Private Sub LoginForm_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        If TxtEmail.Text = "" Then TxtEmail.Focus() Else TxtPassword.Focus()
    End Sub

    Private Sub ChkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles ChkShowPassword.CheckedChanged
        TxtPassword.UseSystemPasswordChar = Not ChkShowPassword.Checked
    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        ShowMessage(LblMessage, "", True)
        BtnLogin.Enabled = False
        Try
            Dim user As UserAccount = _auth.Login(TxtEmail.Text, TxtPassword.Text)
            If user Is Nothing Then
                ShowMessage(LblMessage, "Invalid email or password.", True)
                TxtPassword.Clear()
                TxtPassword.Focus()
                Return
            End If
            SaveRemembered(If(ChkRememberMe.Checked, TxtEmail.Text.Trim(), ""))
            DialogResult = DialogResult.OK
        Catch ex As BusinessRuleException
            ShowMessage(LblMessage, ex.Message, True)
        Catch ex As Exception
            ErrorLog.Write(ex)
            ShowMessage(LblMessage, "Something went wrong. Details were saved to the log file.", True)
        Finally
            BtnLogin.Enabled = True
        End Try
    End Sub

    Private Sub BtnForgotPassword_Click(sender As Object, e As EventArgs) Handles BtnForgotPassword.Click
        Info("Please ask the librarian to reset your password. You can change it after you log in.")
    End Sub

    ' Only the email address is remembered - never the password.
    Private Shared Function ReadRemembered() As String
        Try
            If File.Exists(RememberFile) Then Return File.ReadAllText(RememberFile).Trim()
        Catch
        End Try
        Return ""
    End Function

    Private Shared Sub SaveRemembered(email As String)
        Try
            Directory.CreateDirectory(AppPaths.DataDirectory)
            If email = "" Then
                If File.Exists(RememberFile) Then File.Delete(RememberFile)
            Else
                File.WriteAllText(RememberFile, email)
            End If
        Catch
        End Try
    End Sub
End Class
