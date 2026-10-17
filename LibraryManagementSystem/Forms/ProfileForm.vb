Option Strict On
Option Explicit On

Imports System.Drawing
Imports System.Windows.Forms
Imports LibraryManagement.Core

''' <summary>Screens 3 and 20 - My Profile / Student Profile (one form for both roles).</summary>
Public Class ProfileForm
    Private ReadOnly _auth As New AuthService()

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
    End Sub

    Private Sub ProfileForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadProfile()
    End Sub

    Private Shared Sub SetReadOnly(box As TextBox, isReadOnly As Boolean)
        box.ReadOnly = isReadOnly
        box.BackColor = If(isReadOnly, Color.FromArgb(240, 240, 240), Color.White)
    End Sub

    Private Sub SetEditing(editing As Boolean)
        SetReadOnly(TxtFirstName, Not editing)
        SetReadOnly(TxtLastName, Not editing)
        SetReadOnly(TxtPhone, Not editing)
        BtnSave.Enabled = editing
        BtnCancel.Enabled = editing
        BtnEdit.Enabled = Not editing
    End Sub

    Private Sub LoadProfile()
        Run(Sub()
                Dim user As UserAccount = _auth.RefreshCurrentUser()
                LblTitle.Text = If(user.IsStudent, "Student Profile", "My Profile")
                TxtFirstName.Text = user.FirstName
                TxtLastName.Text = user.LastName
                TxtEmail.Text = user.Email
                TxtPhone.Text = user.Phone
                TxtRole.Text = user.RoleName
                TxtAdmissionNo.Text = user.AdmissionNo
                LblAdmissionNo.Visible = user.IsStudent
                TxtAdmissionNo.Visible = user.IsStudent
                PicProfile.Image = If(LoadImageSafe(user.PhotoPath), MakeAvatar(140))
            End Sub, LblMessage)
        SetEditing(False)
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        SetEditing(True)
        ShowMessage(LblMessage, "", False)
        TxtFirstName.Focus()
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        LoadProfile()
        ShowMessage(LblMessage, "", False)
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If Run(Sub() _auth.UpdateProfile(TxtFirstName.Text, TxtLastName.Text, TxtPhone.Text), LblMessage) Then
            LoadProfile()
            ShowMessage(LblMessage, "Profile updated.", False)
        End If
    End Sub

    Private Sub BtnUploadPhoto_Click(sender As Object, e As EventArgs) Handles BtnUploadPhoto.Click
        Using dialog As New OpenFileDialog With {.Filter = "Pictures (*.png;*.jpg;*.jpeg)|*.png;*.jpg;*.jpeg", .Title = "Choose a profile picture"}
            If dialog.ShowDialog(Me) <> DialogResult.OK Then Return
            If Run(Sub() _auth.SavePhoto(dialog.FileName), LblMessage) Then
                LoadProfile()
                ShowMessage(LblMessage, "Photo updated.", False)
            End If
        End Using
    End Sub

    Private Sub BtnChangePassword_Click(sender As Object, e As EventArgs) Handles BtnChangePassword.Click
        Using dialog As New ChangePasswordForm()
            dialog.ShowDialog(Me)
        End Using
    End Sub
End Class
