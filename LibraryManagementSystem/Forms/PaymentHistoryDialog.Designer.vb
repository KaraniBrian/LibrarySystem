<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PaymentHistoryDialog
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.LblTitle = New System.Windows.Forms.Label()
        Me.LblStudentName = New System.Windows.Forms.Label()
        Me.DgvPayments = New System.Windows.Forms.DataGridView()
        Me.ColPaidOn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColMethod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColRecordedBy = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.LblMessage = New System.Windows.Forms.Label()
        CType(Me.DgvPayments, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblTitle
        '
        Me.LblTitle.AutoSize = True
        Me.LblTitle.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.LblTitle.Location = New System.Drawing.Point(24, 14)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Text = "Payment History"
        Me.LblTitle.TabIndex = 0
        '
        'LblStudentName
        '
        Me.LblStudentName.AutoSize = True
        Me.LblStudentName.Location = New System.Drawing.Point(28, 56)
        Me.LblStudentName.Name = "LblStudentName"
        Me.LblStudentName.Text = "Student:"
        Me.LblStudentName.TabIndex = 1
        '
        'DgvPayments
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(32, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(32, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(246, Byte), Integer))
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.DgvPayments.AllowUserToAddRows = False
        Me.DgvPayments.AllowUserToDeleteRows = False
        Me.DgvPayments.AllowUserToResizeRows = False
        Me.DgvPayments.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DgvPayments.AutoGenerateColumns = False
        Me.DgvPayments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvPayments.BackgroundColor = System.Drawing.Color.White
        Me.DgvPayments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DgvPayments.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvPayments.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColPaidOn, Me.ColAmount, Me.ColMethod, Me.ColRecordedBy})
        Me.DgvPayments.DefaultCellStyle = DataGridViewCellStyle3
        Me.DgvPayments.EnableHeadersVisualStyles = False
        Me.DgvPayments.Location = New System.Drawing.Point(28, 84)
        Me.DgvPayments.MultiSelect = False
        Me.DgvPayments.Name = "DgvPayments"
        Me.DgvPayments.ReadOnly = True
        Me.DgvPayments.RowHeadersVisible = False
        Me.DgvPayments.RowTemplate.Height = 28
        Me.DgvPayments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvPayments.Size = New System.Drawing.Size(544, 220)
        Me.DgvPayments.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right) Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.DgvPayments.TabIndex = 2
        '
        'ColPaidOn
        '
        DataGridViewCellStyle4.Format = "yyyy-MM-dd"
        Me.ColPaidOn.DataPropertyName = "Paid On"
        Me.ColPaidOn.DefaultCellStyle = DataGridViewCellStyle4
        Me.ColPaidOn.HeaderText = "Paid On"
        Me.ColPaidOn.Name = "ColPaidOn"
        Me.ColPaidOn.ReadOnly = True
        '
        'ColAmount
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N2"
        Me.ColAmount.DataPropertyName = "Amount"
        Me.ColAmount.DefaultCellStyle = DataGridViewCellStyle5
        Me.ColAmount.HeaderText = "Amount"
        Me.ColAmount.Name = "ColAmount"
        Me.ColAmount.ReadOnly = True
        '
        'ColMethod
        '
        Me.ColMethod.DataPropertyName = "Method"
        Me.ColMethod.HeaderText = "Method"
        Me.ColMethod.Name = "ColMethod"
        Me.ColMethod.ReadOnly = True
        '
        'ColRecordedBy
        '
        Me.ColRecordedBy.DataPropertyName = "Recorded By"
        Me.ColRecordedBy.HeaderText = "Recorded By"
        Me.ColRecordedBy.Name = "ColRecordedBy"
        Me.ColRecordedBy.ReadOnly = True
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.Color.White
        Me.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.BtnClose.FlatAppearance.BorderSize = 1
        Me.BtnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClose.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.BtnClose.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.BtnClose.Location = New System.Drawing.Point(28, 320)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(110, 36)
        Me.BtnClose.Text = "Close"
        Me.BtnClose.UseVisualStyleBackColor = False
        Me.BtnClose.TabIndex = 3
        '
        'LblMessage
        '
        Me.LblMessage.AutoSize = True
        Me.LblMessage.ForeColor = System.Drawing.Color.Firebrick
        Me.LblMessage.Location = New System.Drawing.Point(150, 330)
        Me.LblMessage.Name = "LblMessage"
        Me.LblMessage.Text = ""
        Me.LblMessage.TabIndex = 4
        '
        'PaymentHistoryDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AcceptButton = Me.BtnClose
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.CancelButton = Me.BtnClose
        Me.ClientSize = New System.Drawing.Size(600, 380)
        Me.Controls.Add(Me.LblTitle)
        Me.Controls.Add(Me.LblStudentName)
        Me.Controls.Add(Me.DgvPayments)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.LblMessage)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PaymentHistoryDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Payment History"
        CType(Me.DgvPayments, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents LblTitle As System.Windows.Forms.Label
    Friend WithEvents LblStudentName As System.Windows.Forms.Label
    Friend WithEvents DgvPayments As System.Windows.Forms.DataGridView
    Friend WithEvents ColPaidOn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColAmount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColMethod As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColRecordedBy As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents LblMessage As System.Windows.Forms.Label

End Class
