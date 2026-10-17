<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProfileForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LblTitle = New System.Windows.Forms.Label()
        Me.PicProfile = New System.Windows.Forms.PictureBox()
        Me.BtnUploadPhoto = New System.Windows.Forms.Button()
        Me.LblFirstName = New System.Windows.Forms.Label()
        Me.TxtFirstName = New System.Windows.Forms.TextBox()
        Me.LblLastName = New System.Windows.Forms.Label()
        Me.TxtLastName = New System.Windows.Forms.TextBox()
        Me.LblEmail = New System.Windows.Forms.Label()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.LblPhone = New System.Windows.Forms.Label()
        Me.TxtPhone = New System.Windows.Forms.TextBox()
        Me.LblRole = New System.Windows.Forms.Label()
        Me.TxtRole = New System.Windows.Forms.TextBox()
        Me.LblAdmissionNo = New System.Windows.Forms.Label()
        Me.TxtAdmissionNo = New System.Windows.Forms.TextBox()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnChangePassword = New System.Windows.Forms.Button()
        Me.LblMessage = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LblTitle
        '
        Me.LblTitle.AutoSize = True
        Me.LblTitle.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.LblTitle.Location = New System.Drawing.Point(24, 14)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Text = "My Profile"
        Me.LblTitle.TabIndex = 0
        '
        'PicProfile
        '
        Me.PicProfile.Location = New System.Drawing.Point(30, 70)
        Me.PicProfile.Name = "PicProfile"
        Me.PicProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PicProfile.Size = New System.Drawing.Size(140, 140)
        Me.PicProfile.TabIndex = 1
        '
        'BtnUploadPhoto
        '
        Me.BtnUploadPhoto.BackColor = System.Drawing.Color.White
        Me.BtnUploadPhoto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnUploadPhoto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.BtnUploadPhoto.FlatAppearance.BorderSize = 1
        Me.BtnUploadPhoto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.BtnUploadPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUploadPhoto.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUploadPhoto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.BtnUploadPhoto.Location = New System.Drawing.Point(30, 218)
        Me.BtnUploadPhoto.Name = "BtnUploadPhoto"
        Me.BtnUploadPhoto.Size = New System.Drawing.Size(140, 34)
        Me.BtnUploadPhoto.Text = "Change Photo"
        Me.BtnUploadPhoto.UseVisualStyleBackColor = False
        Me.BtnUploadPhoto.TabIndex = 2
        '
        'LblFirstName
        '
        Me.LblFirstName.AutoSize = True
        Me.LblFirstName.Location = New System.Drawing.Point(210, 74)
        Me.LblFirstName.Name = "LblFirstName"
        Me.LblFirstName.Text = "First Name:"
        Me.LblFirstName.TabIndex = 3
        '
        'TxtFirstName
        '
        Me.TxtFirstName.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TxtFirstName.Location = New System.Drawing.Point(360, 70)
        Me.TxtFirstName.MaxLength = 100
        Me.TxtFirstName.Name = "TxtFirstName"
        Me.TxtFirstName.ReadOnly = True
        Me.TxtFirstName.Size = New System.Drawing.Size(300, 27)
        Me.TxtFirstName.TabIndex = 4
        '
        'LblLastName
        '
        Me.LblLastName.AutoSize = True
        Me.LblLastName.Location = New System.Drawing.Point(210, 116)
        Me.LblLastName.Name = "LblLastName"
        Me.LblLastName.Text = "Last Name:"
        Me.LblLastName.TabIndex = 5
        '
        'TxtLastName
        '
        Me.TxtLastName.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TxtLastName.Location = New System.Drawing.Point(360, 112)
        Me.TxtLastName.MaxLength = 100
        Me.TxtLastName.Name = "TxtLastName"
        Me.TxtLastName.ReadOnly = True
        Me.TxtLastName.Size = New System.Drawing.Size(300, 27)
        Me.TxtLastName.TabIndex = 6
        '
        'LblEmail
        '
        Me.LblEmail.AutoSize = True
        Me.LblEmail.Location = New System.Drawing.Point(210, 158)
        Me.LblEmail.Name = "LblEmail"
        Me.LblEmail.Text = "Email:"
        Me.LblEmail.TabIndex = 7
        '
        'TxtEmail
        '
        Me.TxtEmail.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TxtEmail.Location = New System.Drawing.Point(360, 154)
        Me.TxtEmail.MaxLength = 255
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.ReadOnly = True
        Me.TxtEmail.Size = New System.Drawing.Size(300, 27)
        Me.TxtEmail.TabIndex = 8
        '
        'LblPhone
        '
        Me.LblPhone.AutoSize = True
        Me.LblPhone.Location = New System.Drawing.Point(210, 200)
        Me.LblPhone.Name = "LblPhone"
        Me.LblPhone.Text = "Phone:"
        Me.LblPhone.TabIndex = 9
        '
        'TxtPhone
        '
        Me.TxtPhone.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TxtPhone.Location = New System.Drawing.Point(360, 196)
        Me.TxtPhone.MaxLength = 20
        Me.TxtPhone.Name = "TxtPhone"
        Me.TxtPhone.ReadOnly = True
        Me.TxtPhone.Size = New System.Drawing.Size(300, 27)
        Me.TxtPhone.TabIndex = 10
        '
        'LblRole
        '
        Me.LblRole.AutoSize = True
        Me.LblRole.Location = New System.Drawing.Point(210, 242)
        Me.LblRole.Name = "LblRole"
        Me.LblRole.Text = "Role:"
        Me.LblRole.TabIndex = 11
        '
        'TxtRole
        '
        Me.TxtRole.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TxtRole.Location = New System.Drawing.Point(360, 238)
        Me.TxtRole.MaxLength = 30
        Me.TxtRole.Name = "TxtRole"
        Me.TxtRole.ReadOnly = True
        Me.TxtRole.Size = New System.Drawing.Size(300, 27)
        Me.TxtRole.TabIndex = 12
        '
        'LblAdmissionNo
        '
        Me.LblAdmissionNo.AutoSize = True
        Me.LblAdmissionNo.Location = New System.Drawing.Point(210, 284)
        Me.LblAdmissionNo.Name = "LblAdmissionNo"
        Me.LblAdmissionNo.Text = "Admission Number:"
        Me.LblAdmissionNo.TabIndex = 13
        '
        'TxtAdmissionNo
        '
        Me.TxtAdmissionNo.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TxtAdmissionNo.Location = New System.Drawing.Point(360, 280)
        Me.TxtAdmissionNo.MaxLength = 50
        Me.TxtAdmissionNo.Name = "TxtAdmissionNo"
        Me.TxtAdmissionNo.ReadOnly = True
        Me.TxtAdmissionNo.Size = New System.Drawing.Size(300, 27)
        Me.TxtAdmissionNo.TabIndex = 14
        '
        'BtnEdit
        '
        Me.BtnEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.BtnEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.BtnEdit.FlatAppearance.BorderSize = 1
        Me.BtnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEdit.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEdit.ForeColor = System.Drawing.Color.White
        Me.BtnEdit.Location = New System.Drawing.Point(210, 340)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(130, 36)
        Me.BtnEdit.Text = "Edit Profile"
        Me.BtnEdit.UseVisualStyleBackColor = False
        Me.BtnEdit.TabIndex = 15
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.BtnSave.FlatAppearance.BorderSize = 1
        Me.BtnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.ForeColor = System.Drawing.Color.White
        Me.BtnSave.Enabled = False
        Me.BtnSave.Location = New System.Drawing.Point(350, 340)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(130, 36)
        Me.BtnSave.Text = "Save Changes"
        Me.BtnSave.UseVisualStyleBackColor = False
        Me.BtnSave.TabIndex = 16
        '
        'BtnCancel
        '
        Me.BtnCancel.BackColor = System.Drawing.Color.White
        Me.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.BtnCancel.FlatAppearance.BorderSize = 1
        Me.BtnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancel.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.BtnCancel.Enabled = False
        Me.BtnCancel.Location = New System.Drawing.Point(490, 340)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(90, 36)
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = False
        Me.BtnCancel.TabIndex = 17
        '
        'BtnChangePassword
        '
        Me.BtnChangePassword.BackColor = System.Drawing.Color.White
        Me.BtnChangePassword.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnChangePassword.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.BtnChangePassword.FlatAppearance.BorderSize = 1
        Me.BtnChangePassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.BtnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnChangePassword.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnChangePassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.BtnChangePassword.Location = New System.Drawing.Point(590, 340)
        Me.BtnChangePassword.Name = "BtnChangePassword"
        Me.BtnChangePassword.Size = New System.Drawing.Size(160, 36)
        Me.BtnChangePassword.Text = "Change Password"
        Me.BtnChangePassword.UseVisualStyleBackColor = False
        Me.BtnChangePassword.TabIndex = 18
        '
        'LblMessage
        '
        Me.LblMessage.AutoSize = True
        Me.LblMessage.ForeColor = System.Drawing.Color.Firebrick
        Me.LblMessage.Location = New System.Drawing.Point(210, 390)
        Me.LblMessage.Name = "LblMessage"
        Me.LblMessage.Text = ""
        Me.LblMessage.TabIndex = 19
        '
        'ProfileForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScroll = True
        Me.AutoScrollMinSize = New System.Drawing.Size(780, 440)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(880, 560)
        Me.Controls.Add(Me.LblTitle)
        Me.Controls.Add(Me.PicProfile)
        Me.Controls.Add(Me.BtnUploadPhoto)
        Me.Controls.Add(Me.LblFirstName)
        Me.Controls.Add(Me.TxtFirstName)
        Me.Controls.Add(Me.LblLastName)
        Me.Controls.Add(Me.TxtLastName)
        Me.Controls.Add(Me.LblEmail)
        Me.Controls.Add(Me.TxtEmail)
        Me.Controls.Add(Me.LblPhone)
        Me.Controls.Add(Me.TxtPhone)
        Me.Controls.Add(Me.LblRole)
        Me.Controls.Add(Me.TxtRole)
        Me.Controls.Add(Me.LblAdmissionNo)
        Me.Controls.Add(Me.TxtAdmissionNo)
        Me.Controls.Add(Me.BtnEdit)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnChangePassword)
        Me.Controls.Add(Me.LblMessage)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "ProfileForm"
        Me.Text = "My Profile"
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents LblTitle As System.Windows.Forms.Label
    Friend WithEvents PicProfile As System.Windows.Forms.PictureBox
    Friend WithEvents BtnUploadPhoto As System.Windows.Forms.Button
    Friend WithEvents LblFirstName As System.Windows.Forms.Label
    Friend WithEvents TxtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents LblLastName As System.Windows.Forms.Label
    Friend WithEvents TxtLastName As System.Windows.Forms.TextBox
    Friend WithEvents LblEmail As System.Windows.Forms.Label
    Friend WithEvents TxtEmail As System.Windows.Forms.TextBox
    Friend WithEvents LblPhone As System.Windows.Forms.Label
    Friend WithEvents TxtPhone As System.Windows.Forms.TextBox
    Friend WithEvents LblRole As System.Windows.Forms.Label
    Friend WithEvents TxtRole As System.Windows.Forms.TextBox
    Friend WithEvents LblAdmissionNo As System.Windows.Forms.Label
    Friend WithEvents TxtAdmissionNo As System.Windows.Forms.TextBox
    Friend WithEvents BtnEdit As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents BtnChangePassword As System.Windows.Forms.Button
    Friend WithEvents LblMessage As System.Windows.Forms.Label

End Class
