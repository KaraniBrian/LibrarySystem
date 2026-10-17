<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChangePasswordForm
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
        Me.LblCurrentPassword = New System.Windows.Forms.Label()
        Me.TxtCurrentPassword = New System.Windows.Forms.TextBox()
        Me.LblNewPassword = New System.Windows.Forms.Label()
        Me.TxtNewPassword = New System.Windows.Forms.TextBox()
        Me.LblConfirmPassword = New System.Windows.Forms.Label()
        Me.TxtConfirmPassword = New System.Windows.Forms.TextBox()
        Me.LblRules = New System.Windows.Forms.Label()
        Me.ChkShowPassword = New System.Windows.Forms.CheckBox()
        Me.BtnChangePassword = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.LblMessage = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LblTitle
        '
        Me.LblTitle.AutoSize = True
        Me.LblTitle.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.LblTitle.Location = New System.Drawing.Point(24, 14)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Text = "Change Password"
        Me.LblTitle.TabIndex = 0
        '
        'LblCurrentPassword
        '
        Me.LblCurrentPassword.AutoSize = True
        Me.LblCurrentPassword.Location = New System.Drawing.Point(28, 64)
        Me.LblCurrentPassword.Name = "LblCurrentPassword"
        Me.LblCurrentPassword.Text = "Current Password:"
        Me.LblCurrentPassword.TabIndex = 1
        '
        'TxtCurrentPassword
        '
        Me.TxtCurrentPassword.Location = New System.Drawing.Point(28, 88)
        Me.TxtCurrentPassword.MaxLength = 100
        Me.TxtCurrentPassword.Name = "TxtCurrentPassword"
        Me.TxtCurrentPassword.Size = New System.Drawing.Size(380, 27)
        Me.TxtCurrentPassword.UseSystemPasswordChar = True
        Me.TxtCurrentPassword.TabIndex = 2
        '
        'LblNewPassword
        '
        Me.LblNewPassword.AutoSize = True
        Me.LblNewPassword.Location = New System.Drawing.Point(28, 124)
        Me.LblNewPassword.Name = "LblNewPassword"
        Me.LblNewPassword.Text = "New Password:"
        Me.LblNewPassword.TabIndex = 3
        '
        'TxtNewPassword
        '
        Me.TxtNewPassword.Location = New System.Drawing.Point(28, 148)
        Me.TxtNewPassword.MaxLength = 100
        Me.TxtNewPassword.Name = "TxtNewPassword"
        Me.TxtNewPassword.Size = New System.Drawing.Size(380, 27)
        Me.TxtNewPassword.UseSystemPasswordChar = True
        Me.TxtNewPassword.TabIndex = 4
        '
        'LblConfirmPassword
        '
        Me.LblConfirmPassword.AutoSize = True
        Me.LblConfirmPassword.Location = New System.Drawing.Point(28, 184)
        Me.LblConfirmPassword.Name = "LblConfirmPassword"
        Me.LblConfirmPassword.Text = "Confirm New Password:"
        Me.LblConfirmPassword.TabIndex = 5
        '
        'TxtConfirmPassword
        '
        Me.TxtConfirmPassword.Location = New System.Drawing.Point(28, 208)
        Me.TxtConfirmPassword.MaxLength = 100
        Me.TxtConfirmPassword.Name = "TxtConfirmPassword"
        Me.TxtConfirmPassword.Size = New System.Drawing.Size(380, 27)
        Me.TxtConfirmPassword.UseSystemPasswordChar = True
        Me.TxtConfirmPassword.TabIndex = 6
        '
        'LblRules
        '
        Me.LblRules.AutoSize = True
        Me.LblRules.ForeColor = System.Drawing.Color.DimGray
        Me.LblRules.Location = New System.Drawing.Point(28, 244)
        Me.LblRules.Name = "LblRules"
        Me.LblRules.Text = "Use at least 8 characters with letters and numbers."
        Me.LblRules.TabIndex = 7
        '
        'ChkShowPassword
        '
        Me.ChkShowPassword.AutoSize = True
        Me.ChkShowPassword.Location = New System.Drawing.Point(28, 268)
        Me.ChkShowPassword.Name = "ChkShowPassword"
        Me.ChkShowPassword.Text = "Show passwords"
        Me.ChkShowPassword.UseVisualStyleBackColor = True
        Me.ChkShowPassword.TabIndex = 8
        '
        'BtnChangePassword
        '
        Me.BtnChangePassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.BtnChangePassword.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnChangePassword.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.BtnChangePassword.FlatAppearance.BorderSize = 1
        Me.BtnChangePassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnChangePassword.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnChangePassword.ForeColor = System.Drawing.Color.White
        Me.BtnChangePassword.Location = New System.Drawing.Point(28, 304)
        Me.BtnChangePassword.Name = "BtnChangePassword"
        Me.BtnChangePassword.Size = New System.Drawing.Size(170, 36)
        Me.BtnChangePassword.Text = "Change Password"
        Me.BtnChangePassword.UseVisualStyleBackColor = False
        Me.BtnChangePassword.TabIndex = 9
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
        Me.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnCancel.Location = New System.Drawing.Point(208, 304)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(110, 36)
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = False
        Me.BtnCancel.TabIndex = 10
        '
        'LblMessage
        '
        Me.LblMessage.AutoSize = True
        Me.LblMessage.ForeColor = System.Drawing.Color.Firebrick
        Me.LblMessage.Location = New System.Drawing.Point(28, 348)
        Me.LblMessage.Name = "LblMessage"
        Me.LblMessage.Text = ""
        Me.LblMessage.TabIndex = 11
        '
        'ChangePasswordForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AcceptButton = Me.BtnChangePassword
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.CancelButton = Me.BtnCancel
        Me.ClientSize = New System.Drawing.Size(440, 380)
        Me.Controls.Add(Me.LblTitle)
        Me.Controls.Add(Me.LblCurrentPassword)
        Me.Controls.Add(Me.TxtCurrentPassword)
        Me.Controls.Add(Me.LblNewPassword)
        Me.Controls.Add(Me.TxtNewPassword)
        Me.Controls.Add(Me.LblConfirmPassword)
        Me.Controls.Add(Me.TxtConfirmPassword)
        Me.Controls.Add(Me.LblRules)
        Me.Controls.Add(Me.ChkShowPassword)
        Me.Controls.Add(Me.BtnChangePassword)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.LblMessage)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ChangePasswordForm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Change Password"
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents LblTitle As System.Windows.Forms.Label
    Friend WithEvents LblCurrentPassword As System.Windows.Forms.Label
    Friend WithEvents TxtCurrentPassword As System.Windows.Forms.TextBox
    Friend WithEvents LblNewPassword As System.Windows.Forms.Label
    Friend WithEvents TxtNewPassword As System.Windows.Forms.TextBox
    Friend WithEvents LblConfirmPassword As System.Windows.Forms.Label
    Friend WithEvents TxtConfirmPassword As System.Windows.Forms.TextBox
    Friend WithEvents LblRules As System.Windows.Forms.Label
    Friend WithEvents ChkShowPassword As System.Windows.Forms.CheckBox
    Friend WithEvents BtnChangePassword As System.Windows.Forms.Button
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents LblMessage As System.Windows.Forms.Label

End Class
