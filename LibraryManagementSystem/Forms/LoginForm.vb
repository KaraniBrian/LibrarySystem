Option Strict On
Option Explicit On

Imports System.Drawing
Imports System.IO
Imports System.Windows.Forms
Imports LibraryManagement.Core

''' <summary>Screen 1 - Login. Opens the correct dashboard for the user's role (see Program.Main).</summary>
Public Class LoginForm
    Inherits Form

    Private ReadOnly _auth As New AuthService()
    Private ReadOnly picLogo As New PictureBox() With {.Name = "picLogo", .Size = New Size(100, 100), .SizeMode = PictureBoxSizeMode.Zoom}
    Private ReadOnly lblTitle As Label = NewTitle("lblTitle", "Library Management System", 18.0F)
    Private ReadOnly lblEmail As Label = NewLabel("lblEmail", "Email Address:")
    Private ReadOnly txtEmail As TextBox = NewTextBox("txtEmail", 255, False, "Enter your email")
    Private ReadOnly lblPassword As Label = NewLabel("lblPassword", "Password:")
    Private ReadOnly txtPassword As TextBox = NewPasswordBox("txtPassword")
    Private ReadOnly chkRememberMe As CheckBox = NewCheck("chkRememberMe", "Remember me")
    Private ReadOnly chkShowPassword As CheckBox = NewCheck("chkShowPassword", "Show password")
    Private ReadOnly btnLogin As Button = NewButton("btnLogin", "Login", ButtonKind.Primary, 300)
    Private ReadOnly btnForgotPassword As Button = NewButton("btnForgotPassword", "Forgot Password?", ButtonKind.Secondary, 300)
    Private ReadOnly lblMessage As Label = NewMessageLabel("lblMessage")
    Private ReadOnly lblFooter As Label = NewLabel("lblFooter", "Library Management System")

    Private Shared ReadOnly RememberFile As String = Path.Combine(AppPaths.DataDirectory, "remember.txt")

    Public Sub New()
        Text = "Library Management System - Login"
        Size = New Size(500, 550)
        StartPosition = FormStartPosition.CenterScreen
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        BackColor = Color.White
        Font = Theme.BodyFont
        AutoScaleMode = AutoScaleMode.Dpi

        picLogo.Image = MakeLogo(100)
        picLogo.Location = New Point(200, 25)
        lblTitle.AutoSize = False
        lblTitle.TextAlign = ContentAlignment.MiddleCenter
        lblTitle.SetBounds(0, 140, 500, 40)
        lblEmail.Location = New Point(100, 200)
        txtEmail.SetBounds(100, 224, 300, 30)
        lblPassword.Location = New Point(100, 268)
        txtPassword.SetBounds(100, 292, 300, 30)
        chkRememberMe.Location = New Point(100, 335)
        chkShowPassword.Location = New Point(270, 335)
        btnLogin.Location = New Point(100, 380)
        btnLogin.Height = 40
        btnForgotPassword.Location = New Point(100, 430)
        btnForgotPassword.FlatAppearance.BorderSize = 0
        lblMessage.SetBounds(100, 478, 300, 22)
        lblFooter.Location = New Point(165, 510)
        lblFooter.ForeColor = Color.Gray

        Controls.AddRange(New Control() {picLogo, lblTitle, lblEmail, txtEmail, lblPassword, txtPassword, chkRememberMe,
                                         chkShowPassword, btnLogin, btnForgotPassword, lblMessage, lblFooter})
        AcceptButton = btnLogin

        AddHandler btnLogin.Click, Sub(sender As Object, e As EventArgs) OnLogin()
        AddHandler btnForgotPassword.Click, Sub(sender As Object, e As EventArgs) OnForgotPassword()
        AddHandler chkShowPassword.CheckedChanged, Sub(sender As Object, e As EventArgs) txtPassword.UseSystemPasswordChar = Not chkShowPassword.Checked

        Dim remembered As String = ReadRemembered()
        If remembered <> "" Then
            txtEmail.Text = remembered
            chkRememberMe.Checked = True
        End If
    End Sub

    Protected Overrides Sub OnShown(e As EventArgs)
        MyBase.OnShown(e)
        If txtEmail.Text = "" Then txtEmail.Focus() Else txtPassword.Focus()
    End Sub

    Private Sub OnLogin()
        ShowMessage(lblMessage, "", True)
        btnLogin.Enabled = False
        Try
            Dim user As UserAccount = _auth.Login(txtEmail.Text, txtPassword.Text)
            If user Is Nothing Then
                ShowMessage(lblMessage, "Invalid email or password.", True)
                txtPassword.Clear()
                txtPassword.Focus()
                Return
            End If
            SaveRemembered(If(chkRememberMe.Checked, txtEmail.Text.Trim(), ""))
            DialogResult = DialogResult.OK
        Catch ex As BusinessRuleException
            ShowMessage(lblMessage, ex.Message, True)
        Catch ex As Exception
            ErrorLog.Write(ex)
            ShowMessage(lblMessage, "Something went wrong. Details were saved to the log file.", True)
        Finally
            btnLogin.Enabled = True
        End Try
    End Sub

    Private Sub OnForgotPassword()
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
