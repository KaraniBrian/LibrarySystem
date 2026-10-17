<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PaymentDialog
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
        Me.LblStudentName = New System.Windows.Forms.Label()
        Me.LblBalanceInfo = New System.Windows.Forms.Label()
        Me.LblAmount = New System.Windows.Forms.Label()
        Me.NudAmount = New System.Windows.Forms.NumericUpDown()
        Me.LblPaymentMethod = New System.Windows.Forms.Label()
        Me.CmbMethod = New System.Windows.Forms.ComboBox()
        Me.BtnConfirm = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblTitle
        '
        Me.LblTitle.AutoSize = True
        Me.LblTitle.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.LblTitle.Location = New System.Drawing.Point(24, 14)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Text = "Record Payment"
        Me.LblTitle.TabIndex = 0
        '
        'LblStudentName
        '
        Me.LblStudentName.AutoSize = True
        Me.LblStudentName.Location = New System.Drawing.Point(28, 58)
        Me.LblStudentName.Name = "LblStudentName"
        Me.LblStudentName.Text = "Student:"
        Me.LblStudentName.TabIndex = 1
        '
        'LblBalanceInfo
        '
        Me.LblBalanceInfo.AutoSize = True
        Me.LblBalanceInfo.Location = New System.Drawing.Point(28, 84)
        Me.LblBalanceInfo.Name = "LblBalanceInfo"
        Me.LblBalanceInfo.Text = "Outstanding balance:"
        Me.LblBalanceInfo.TabIndex = 2
        '
        'LblAmount
        '
        Me.LblAmount.AutoSize = True
        Me.LblAmount.Location = New System.Drawing.Point(28, 124)
        Me.LblAmount.Name = "LblAmount"
        Me.LblAmount.Text = "Amount received:"
        Me.LblAmount.TabIndex = 3
        '
        'NudAmount
        '
        Me.NudAmount.Location = New System.Drawing.Point(28, 148)
        Me.NudAmount.DecimalPlaces = 2
        Me.NudAmount.Maximum = New Decimal(New Integer() {100000000, 0, 0, 131072})
        Me.NudAmount.Minimum = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.NudAmount.Name = "NudAmount"
        Me.NudAmount.Size = New System.Drawing.Size(200, 27)
        Me.NudAmount.TabIndex = 4
        '
        'LblPaymentMethod
        '
        Me.LblPaymentMethod.AutoSize = True
        Me.LblPaymentMethod.Location = New System.Drawing.Point(28, 188)
        Me.LblPaymentMethod.Name = "LblPaymentMethod"
        Me.LblPaymentMethod.Text = "Payment method:"
        Me.LblPaymentMethod.TabIndex = 5
        '
        'CmbMethod
        '
        Me.CmbMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbMethod.FormattingEnabled = True
        Me.CmbMethod.Items.AddRange(New Object() {"Cash", "M-Pesa", "Bank Transfer", "Card"})
        Me.CmbMethod.Location = New System.Drawing.Point(28, 212)
        Me.CmbMethod.Name = "CmbMethod"
        Me.CmbMethod.Size = New System.Drawing.Size(250, 28)
        Me.CmbMethod.TabIndex = 6
        '
        'BtnConfirm
        '
        Me.BtnConfirm.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.BtnConfirm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnConfirm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.BtnConfirm.FlatAppearance.BorderSize = 1
        Me.BtnConfirm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnConfirm.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConfirm.ForeColor = System.Drawing.Color.White
        Me.BtnConfirm.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.BtnConfirm.Location = New System.Drawing.Point(28, 262)
        Me.BtnConfirm.Name = "BtnConfirm"
        Me.BtnConfirm.Size = New System.Drawing.Size(170, 36)
        Me.BtnConfirm.Text = "Confirm Payment"
        Me.BtnConfirm.UseVisualStyleBackColor = False
        Me.BtnConfirm.TabIndex = 7
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
        Me.BtnCancel.Location = New System.Drawing.Point(208, 262)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(110, 36)
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = False
        Me.BtnCancel.TabIndex = 8
        '
        'PaymentDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AcceptButton = Me.BtnConfirm
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.CancelButton = Me.BtnCancel
        Me.ClientSize = New System.Drawing.Size(420, 330)
        Me.Controls.Add(Me.LblTitle)
        Me.Controls.Add(Me.LblStudentName)
        Me.Controls.Add(Me.LblBalanceInfo)
        Me.Controls.Add(Me.LblAmount)
        Me.Controls.Add(Me.NudAmount)
        Me.Controls.Add(Me.LblPaymentMethod)
        Me.Controls.Add(Me.CmbMethod)
        Me.Controls.Add(Me.BtnConfirm)
        Me.Controls.Add(Me.BtnCancel)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PaymentDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Record Payment"
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents LblTitle As System.Windows.Forms.Label
    Friend WithEvents LblStudentName As System.Windows.Forms.Label
    Friend WithEvents LblBalanceInfo As System.Windows.Forms.Label
    Friend WithEvents LblAmount As System.Windows.Forms.Label
    Friend WithEvents NudAmount As System.Windows.Forms.NumericUpDown
    Friend WithEvents LblPaymentMethod As System.Windows.Forms.Label
    Friend WithEvents CmbMethod As System.Windows.Forms.ComboBox
    Friend WithEvents BtnConfirm As System.Windows.Forms.Button
    Friend WithEvents BtnCancel As System.Windows.Forms.Button

End Class
