<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
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
        Me.PicLogo = New System.Windows.Forms.PictureBox()
        Me.LblTitle = New System.Windows.Forms.Label()
        Me.LblEmail = New System.Windows.Forms.Label()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.LblPassword = New System.Windows.Forms.Label()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.ChkRememberMe = New System.Windows.Forms.CheckBox()
        Me.ChkShowPassword = New System.Windows.Forms.CheckBox()
        Me.BtnLogin = New System.Windows.Forms.Button()
        Me.BtnForgotPassword = New System.Windows.Forms.Button()
        Me.LblMessage = New System.Windows.Forms.Label()
        Me.LblFooter = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'PicLogo
        '
        Me.PicLogo.Location = New System.Drawing.Point(192, 25)
        Me.PicLogo.Name = "PicLogo"
        Me.PicLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicLogo.Size = New System.Drawing.Size(100, 100)
        Me.PicLogo.TabIndex = 0
        '
        'LblTitle
        '
        Me.LblTitle.AutoSize = False
        Me.LblTitle.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.LblTitle.Location = New System.Drawing.Point(0, 140)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Size = New System.Drawing.Size(484, 40)
        Me.LblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LblTitle.Text = "Library Management System"
        Me.LblTitle.TabIndex = 1
        '
        'LblEmail
        '
        Me.LblEmail.AutoSize = True
        Me.LblEmail.Location = New System.Drawing.Point(92, 200)
        Me.LblEmail.Name = "LblEmail"
        Me.LblEmail.Text = "Email Address:"
        Me.LblEmail.TabIndex = 2
        '
        'TxtEmail
        '
        Me.TxtEmail.Location = New System.Drawing.Point(92, 224)
        Me.TxtEmail.MaxLength = 255
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.PlaceholderText = "Enter your email"
        Me.TxtEmail.Size = New System.Drawing.Size(300, 27)
        Me.TxtEmail.TabIndex = 3
        '
        'LblPassword
        '
        Me.LblPassword.AutoSize = True
        Me.LblPassword.Location = New System.Drawing.Point(92, 268)
        Me.LblPassword.Name = "LblPassword"
        Me.LblPassword.Text = "Password:"
        Me.LblPassword.TabIndex = 4
        '
        'TxtPassword
        '
        Me.TxtPassword.Location = New System.Drawing.Point(92, 292)
        Me.TxtPassword.MaxLength = 100
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.Size = New System.Drawing.Size(300, 27)
        Me.TxtPassword.UseSystemPasswordChar = True
        Me.TxtPassword.TabIndex = 5
        '
        'ChkRememberMe
        '
        Me.ChkRememberMe.AutoSize = True
        Me.ChkRememberMe.Location = New System.Drawing.Point(92, 335)
        Me.ChkRememberMe.Name = "ChkRememberMe"
        Me.ChkRememberMe.Text = "Remember me"
        Me.ChkRememberMe.UseVisualStyleBackColor = True
        Me.ChkRememberMe.TabIndex = 6
        '
        'ChkShowPassword
        '
        Me.ChkShowPassword.AutoSize = True
        Me.ChkShowPassword.Location = New System.Drawing.Point(262, 335)
        Me.ChkShowPassword.Name = "ChkShowPassword"
        Me.ChkShowPassword.Text = "Show password"
        Me.ChkShowPassword.UseVisualStyleBackColor = True
        Me.ChkShowPassword.TabIndex = 7
        '
        'BtnLogin
        '
        Me.BtnLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.BtnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.BtnLogin.FlatAppearance.BorderSize = 1
        Me.BtnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLogin.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogin.ForeColor = System.Drawing.Color.White
        Me.BtnLogin.Location = New System.Drawing.Point(92, 380)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.Size = New System.Drawing.Size(300, 40)
        Me.BtnLogin.Text = "Login"
        Me.BtnLogin.UseVisualStyleBackColor = False
        Me.BtnLogin.TabIndex = 8
        '
        'BtnForgotPassword
        '
        Me.BtnForgotPassword.BackColor = System.Drawing.Color.White
        Me.BtnForgotPassword.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnForgotPassword.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnForgotPassword.FlatAppearance.BorderSize = 0
        Me.BtnForgotPassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.BtnForgotPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnForgotPassword.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnForgotPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.BtnForgotPassword.Location = New System.Drawing.Point(92, 428)
        Me.BtnForgotPassword.Name = "BtnForgotPassword"
        Me.BtnForgotPassword.Size = New System.Drawing.Size(300, 34)
        Me.BtnForgotPassword.Text = "Forgot Password?"
        Me.BtnForgotPassword.UseVisualStyleBackColor = False
        Me.BtnForgotPassword.TabIndex = 9
        '
        'LblMessage
        '
        Me.LblMessage.AutoSize = False
        Me.LblMessage.ForeColor = System.Drawing.Color.Firebrick
        Me.LblMessage.Location = New System.Drawing.Point(92, 474)
        Me.LblMessage.Name = "LblMessage"
        Me.LblMessage.Size = New System.Drawing.Size(300, 22)
        Me.LblMessage.Text = ""
        Me.LblMessage.TabIndex = 10
        '
        'LblFooter
        '
        Me.LblFooter.AutoSize = False
        Me.LblFooter.ForeColor = System.Drawing.Color.Gray
        Me.LblFooter.Location = New System.Drawing.Point(0, 486)
        Me.LblFooter.Name = "LblFooter"
        Me.LblFooter.Size = New System.Drawing.Size(484, 22)
        Me.LblFooter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LblFooter.Text = "Library Management System"
        Me.LblFooter.TabIndex = 11
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AcceptButton = Me.BtnLogin
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(484, 511)
        Me.Controls.Add(Me.PicLogo)
        Me.Controls.Add(Me.LblTitle)
        Me.Controls.Add(Me.LblEmail)
        Me.Controls.Add(Me.TxtEmail)
        Me.Controls.Add(Me.LblPassword)
        Me.Controls.Add(Me.TxtPassword)
        Me.Controls.Add(Me.ChkRememberMe)
        Me.Controls.Add(Me.ChkShowPassword)
        Me.Controls.Add(Me.BtnLogin)
        Me.Controls.Add(Me.BtnForgotPassword)
        Me.Controls.Add(Me.LblMessage)
        Me.Controls.Add(Me.LblFooter)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "LoginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Library Management System - Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents PicLogo As System.Windows.Forms.PictureBox
    Friend WithEvents LblTitle As System.Windows.Forms.Label
    Friend WithEvents LblEmail As System.Windows.Forms.Label
    Friend WithEvents TxtEmail As System.Windows.Forms.TextBox
    Friend WithEvents LblPassword As System.Windows.Forms.Label
    Friend WithEvents TxtPassword As System.Windows.Forms.TextBox
    Friend WithEvents ChkRememberMe As System.Windows.Forms.CheckBox
    Friend WithEvents ChkShowPassword As System.Windows.Forms.CheckBox
    Friend WithEvents BtnLogin As System.Windows.Forms.Button
    Friend WithEvents BtnForgotPassword As System.Windows.Forms.Button
    Friend WithEvents LblMessage As System.Windows.Forms.Label
    Friend WithEvents LblFooter As System.Windows.Forms.Label

End Class
