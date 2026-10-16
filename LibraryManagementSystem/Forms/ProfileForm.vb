Option Strict On
Option Explicit On

Imports System.Drawing
Imports System.Windows.Forms
Imports LibraryManagement.Core

''' <summary>Screens 3 and 20 - My Profile / Student Profile (one form for both roles).</summary>
Public Class ProfileForm
    Inherits PageForm

    Private ReadOnly _auth As New AuthService()
    Private ReadOnly picProfile As New PictureBox() With {.Name = "picProfile", .Size = New Size(140, 140), .SizeMode = PictureBoxSizeMode.Zoom}
    Private ReadOnly btnUploadPhoto As Button = NewButton("btnUploadPhoto", "Change Photo", ButtonKind.Secondary, 140)
    Private ReadOnly lblAdmissionNo As Label = NewLabel("lblAdmissionNo", "Admission Number:")
    Private ReadOnly txtAdmissionNo As TextBox = NewTextBox("txtAdmissionNo", 50, True)
    Private ReadOnly txtFirstName As TextBox = NewTextBox("txtFirstName", 100, True)
    Private ReadOnly txtLastName As TextBox = NewTextBox("txtLastName", 100, True)
    Private ReadOnly txtEmail As TextBox = NewTextBox("txtEmail", 255, True)
    Private ReadOnly txtPhone As TextBox = NewTextBox("txtPhone", 20, True)
    Private ReadOnly txtRole As TextBox = NewTextBox("txtRole", 30, True)
    Private ReadOnly btnEdit As Button = NewButton("btnEdit", "Edit Profile", ButtonKind.Primary, 140)
    Private ReadOnly btnSave As Button = NewButton("btnSave", "Save Changes", ButtonKind.Primary, 140)
    Private ReadOnly btnCancel As Button = NewButton("btnCancel", "Cancel", ButtonKind.Secondary, 100)
    Private ReadOnly btnChangePassword As Button = NewButton("btnChangePassword", "Change Password", ButtonKind.Secondary, 170)

    Public Sub New()
        MyBase.New(If(AppSession.CurrentUser IsNot Nothing AndAlso AppSession.CurrentUser.IsStudent, "Student Profile", "My Profile"))
        Dim body As New TableLayoutPanel With {.Name = "tblBody", .AutoSize = True, .ColumnCount = 2}
        body.ColumnStyles.Add(New ColumnStyle(SizeType.AutoSize))
        body.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100.0F))

        Dim photoColumn As New FlowLayoutPanel With {.AutoSize = True, .FlowDirection = FlowDirection.TopDown, .WrapContents = False,
                                                     .Margin = New Padding(0, 0, 30, 0)}
        photoColumn.Controls.Add(picProfile)
        photoColumn.Controls.Add(btnUploadPhoto)

        Dim fields As TableLayoutPanel = NewFieldTable("tblFields", 1)
        AddField(fields, lblAdmissionNo, txtAdmissionNo)
        AddField(fields, NewLabel("lblFirstName", "First Name:"), txtFirstName)
        AddField(fields, NewLabel("lblLastName", "Last Name:"), txtLastName)
        AddField(fields, NewLabel("lblEmail", "Email:"), txtEmail)
        AddField(fields, NewLabel("lblPhone", "Phone:"), txtPhone)
        AddField(fields, NewLabel("lblRole", "Role:"), txtRole)
        fields.Dock = DockStyle.Top
        body.Controls.Add(photoColumn)
        body.Controls.Add(fields)

        AddAutoRow(body)
        AddAutoRow(NewButtonRow("pnlActions", btnEdit, btnSave, btnCancel, btnChangePassword))
        AddAutoRow(lblMessage)

        AddHandler btnUploadPhoto.Click, Sub(sender As Object, e As EventArgs) OnUploadPhoto()
        AddHandler btnEdit.Click, Sub(sender As Object, e As EventArgs) OnEdit()
        AddHandler btnSave.Click, Sub(sender As Object, e As EventArgs) OnSave()
        AddHandler btnCancel.Click, Sub(sender As Object, e As EventArgs) OnCancel()
        AddHandler btnChangePassword.Click, Sub(sender As Object, e As EventArgs) OnChangePassword()
    End Sub

    Private Shared Sub SetReadOnly(box As TextBox, isReadOnly As Boolean)
        box.ReadOnly = isReadOnly
        box.BackColor = If(isReadOnly, Color.FromArgb(240, 240, 240), Color.White)
    End Sub

    Private Sub SetEditing(editing As Boolean)
        SetReadOnly(txtFirstName, Not editing)
        SetReadOnly(txtLastName, Not editing)
        SetReadOnly(txtPhone, Not editing)
        btnSave.Enabled = editing
        btnCancel.Enabled = editing
        btnEdit.Enabled = Not editing
    End Sub

    Protected Overrides Sub LoadData()
        Run(Sub()
                Dim user As UserAccount = _auth.RefreshCurrentUser()
                txtFirstName.Text = user.FirstName
                txtLastName.Text = user.LastName
                txtEmail.Text = user.Email
                txtPhone.Text = user.Phone
                txtRole.Text = user.RoleName
                txtAdmissionNo.Text = user.AdmissionNo
                lblAdmissionNo.Visible = user.IsStudent
                txtAdmissionNo.Visible = user.IsStudent
                picProfile.Image = If(LoadImageSafe(user.PhotoPath), MakeAvatar(140))
            End Sub)
        SetEditing(False)
    End Sub

    Private Sub OnEdit()
        SetEditing(True)
        ShowMsg("", False)
        txtFirstName.Focus()
    End Sub

    Private Sub OnCancel()
        LoadData()
        ShowMsg("", False)
    End Sub

    Private Sub OnSave()
        If Run(Sub() _auth.UpdateProfile(txtFirstName.Text, txtLastName.Text, txtPhone.Text)) Then
            LoadData()
            ShowMsg("Profile updated.", False)
        End If
    End Sub

    Private Sub OnUploadPhoto()
        Using dialog As New OpenFileDialog With {.Filter = "Pictures (*.png;*.jpg;*.jpeg)|*.png;*.jpg;*.jpeg", .Title = "Choose a profile picture"}
            If dialog.ShowDialog(Me) <> DialogResult.OK Then Return
            If Run(Sub() _auth.SavePhoto(dialog.FileName)) Then
                LoadData()
                ShowMsg("Photo updated.", False)
            End If
        End Using
    End Sub

    Private Sub OnChangePassword()
        Using dialog As New ChangePasswordForm()
            dialog.ShowDialog(Me)
        End Using
    End Sub
End Class
