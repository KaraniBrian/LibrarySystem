<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LibrarySettingsForm
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
        Me.LblLibraryName = New System.Windows.Forms.Label()
        Me.TxtLibraryName = New System.Windows.Forms.TextBox()
        Me.LblLoanDays = New System.Windows.Forms.Label()
        Me.NudLoanDays = New System.Windows.Forms.NumericUpDown()
        Me.LblFineRate = New System.Windows.Forms.Label()
        Me.NudFineRate = New System.Windows.Forms.NumericUpDown()
        Me.LblMaxBooks = New System.Windows.Forms.Label()
        Me.NudMaxBooks = New System.Windows.Forms.NumericUpDown()
        Me.LblCurrency = New System.Windows.Forms.Label()
        Me.CmbCurrency = New System.Windows.Forms.ComboBox()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnReset = New System.Windows.Forms.Button()
        Me.LblBackupTitle = New System.Windows.Forms.Label()
        Me.BtnBackup = New System.Windows.Forms.Button()
        Me.BtnRestore = New System.Windows.Forms.Button()
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
        Me.LblTitle.Text = "Library Settings"
        Me.LblTitle.TabIndex = 0
        '
        'LblLibraryName
        '
        Me.LblLibraryName.AutoSize = True
        Me.LblLibraryName.Location = New System.Drawing.Point(24, 68)
        Me.LblLibraryName.Name = "LblLibraryName"
        Me.LblLibraryName.Text = "Library Name:"
        Me.LblLibraryName.TabIndex = 1
        '
        'TxtLibraryName
        '
        Me.TxtLibraryName.Location = New System.Drawing.Point(294, 64)
        Me.TxtLibraryName.MaxLength = 150
        Me.TxtLibraryName.Name = "TxtLibraryName"
        Me.TxtLibraryName.Size = New System.Drawing.Size(340, 27)
        Me.TxtLibraryName.TabIndex = 2
        '
        'LblLoanDays
        '
        Me.LblLoanDays.AutoSize = True
        Me.LblLoanDays.Location = New System.Drawing.Point(24, 108)
        Me.LblLoanDays.Name = "LblLoanDays"
        Me.LblLoanDays.Text = "Default Loan Period (Days):"
        Me.LblLoanDays.TabIndex = 3
        '
        'NudLoanDays
        '
        Me.NudLoanDays.Location = New System.Drawing.Point(294, 104)
        Me.NudLoanDays.Maximum = New Decimal(New Integer() {365, 0, 0, 0})
        Me.NudLoanDays.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NudLoanDays.Name = "NudLoanDays"
        Me.NudLoanDays.Size = New System.Drawing.Size(120, 27)
        Me.NudLoanDays.TabIndex = 4
        '
        'LblFineRate
        '
        Me.LblFineRate.AutoSize = True
        Me.LblFineRate.Location = New System.Drawing.Point(24, 148)
        Me.LblFineRate.Name = "LblFineRate"
        Me.LblFineRate.Text = "Fine per Overdue Day:"
        Me.LblFineRate.TabIndex = 5
        '
        'NudFineRate
        '
        Me.NudFineRate.Location = New System.Drawing.Point(294, 144)
        Me.NudFineRate.DecimalPlaces = 2
        Me.NudFineRate.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NudFineRate.Maximum = New Decimal(New Integer() {1000000, 0, 0, 131072})
        Me.NudFineRate.Minimum = New Decimal(New Integer() {0, 0, 0, 131072})
        Me.NudFineRate.Name = "NudFineRate"
        Me.NudFineRate.Size = New System.Drawing.Size(120, 27)
        Me.NudFineRate.TabIndex = 6
        '
        'LblMaxBooks
        '
        Me.LblMaxBooks.AutoSize = True
        Me.LblMaxBooks.Location = New System.Drawing.Point(24, 188)
        Me.LblMaxBooks.Name = "LblMaxBooks"
        Me.LblMaxBooks.Text = "Maximum Books per Student:"
        Me.LblMaxBooks.TabIndex = 7
        '
        'NudMaxBooks
        '
        Me.NudMaxBooks.Location = New System.Drawing.Point(294, 184)
        Me.NudMaxBooks.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.NudMaxBooks.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NudMaxBooks.Name = "NudMaxBooks"
        Me.NudMaxBooks.Size = New System.Drawing.Size(120, 27)
        Me.NudMaxBooks.TabIndex = 8
        '
        'LblCurrency
        '
        Me.LblCurrency.AutoSize = True
        Me.LblCurrency.Location = New System.Drawing.Point(24, 228)
        Me.LblCurrency.Name = "LblCurrency"
        Me.LblCurrency.Text = "Currency:"
        Me.LblCurrency.TabIndex = 9
        '
        'CmbCurrency
        '
        Me.CmbCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbCurrency.FormattingEnabled = True
        Me.CmbCurrency.Items.AddRange(New Object() {"KES", "USD", "EUR", "GBP", "UGX", "TZS"})
        Me.CmbCurrency.Location = New System.Drawing.Point(294, 224)
        Me.CmbCurrency.Name = "CmbCurrency"
        Me.CmbCurrency.Size = New System.Drawing.Size(150, 28)
        Me.CmbCurrency.TabIndex = 10
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
        Me.BtnSave.Location = New System.Drawing.Point(24, 270)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(160, 36)
        Me.BtnSave.Text = "Save Settings"
        Me.BtnSave.UseVisualStyleBackColor = False
        Me.BtnSave.TabIndex = 11
        '
        'BtnReset
        '
        Me.BtnReset.BackColor = System.Drawing.Color.White
        Me.BtnReset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnReset.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.BtnReset.FlatAppearance.BorderSize = 1
        Me.BtnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.BtnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnReset.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReset.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.BtnReset.Location = New System.Drawing.Point(194, 270)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.Size = New System.Drawing.Size(100, 36)
        Me.BtnReset.Text = "Reset"
        Me.BtnReset.UseVisualStyleBackColor = False
        Me.BtnReset.TabIndex = 12
        '
        'LblBackupTitle
        '
        Me.LblBackupTitle.AutoSize = True
        Me.LblBackupTitle.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBackupTitle.Location = New System.Drawing.Point(24, 332)
        Me.LblBackupTitle.Name = "LblBackupTitle"
        Me.LblBackupTitle.Text = "Database backup (needs the MySQL command-line tools)"
        Me.LblBackupTitle.TabIndex = 13
        '
        'BtnBackup
        '
        Me.BtnBackup.BackColor = System.Drawing.Color.White
        Me.BtnBackup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnBackup.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.BtnBackup.FlatAppearance.BorderSize = 1
        Me.BtnBackup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.BtnBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBackup.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBackup.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.BtnBackup.Location = New System.Drawing.Point(24, 360)
        Me.BtnBackup.Name = "BtnBackup"
        Me.BtnBackup.Size = New System.Drawing.Size(170, 36)
        Me.BtnBackup.Text = "Backup Database"
        Me.BtnBackup.UseVisualStyleBackColor = False
        Me.BtnBackup.TabIndex = 14
        '
        'BtnRestore
        '
        Me.BtnRestore.BackColor = System.Drawing.Color.Firebrick
        Me.BtnRestore.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRestore.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick
        Me.BtnRestore.FlatAppearance.BorderSize = 1
        Me.BtnRestore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown
        Me.BtnRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRestore.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRestore.ForeColor = System.Drawing.Color.White
        Me.BtnRestore.Location = New System.Drawing.Point(204, 360)
        Me.BtnRestore.Name = "BtnRestore"
        Me.BtnRestore.Size = New System.Drawing.Size(170, 36)
        Me.BtnRestore.Text = "Restore Database"
        Me.BtnRestore.UseVisualStyleBackColor = False
        Me.BtnRestore.TabIndex = 15
        '
        'LblMessage
        '
        Me.LblMessage.AutoSize = True
        Me.LblMessage.ForeColor = System.Drawing.Color.Firebrick
        Me.LblMessage.Location = New System.Drawing.Point(24, 414)
        Me.LblMessage.Name = "LblMessage"
        Me.LblMessage.Text = ""
        Me.LblMessage.TabIndex = 16
        '
        'LibrarySettingsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScroll = True
        Me.AutoScrollMinSize = New System.Drawing.Size(700, 450)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(880, 560)
        Me.Controls.Add(Me.LblTitle)
        Me.Controls.Add(Me.LblLibraryName)
        Me.Controls.Add(Me.TxtLibraryName)
        Me.Controls.Add(Me.LblLoanDays)
        Me.Controls.Add(Me.NudLoanDays)
        Me.Controls.Add(Me.LblFineRate)
        Me.Controls.Add(Me.NudFineRate)
        Me.Controls.Add(Me.LblMaxBooks)
        Me.Controls.Add(Me.NudMaxBooks)
        Me.Controls.Add(Me.LblCurrency)
        Me.Controls.Add(Me.CmbCurrency)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.BtnReset)
        Me.Controls.Add(Me.LblBackupTitle)
        Me.Controls.Add(Me.BtnBackup)
        Me.Controls.Add(Me.BtnRestore)
        Me.Controls.Add(Me.LblMessage)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "LibrarySettingsForm"
        Me.Text = "Library Settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents LblTitle As System.Windows.Forms.Label
    Friend WithEvents LblLibraryName As System.Windows.Forms.Label
    Friend WithEvents TxtLibraryName As System.Windows.Forms.TextBox
    Friend WithEvents LblLoanDays As System.Windows.Forms.Label
    Friend WithEvents NudLoanDays As System.Windows.Forms.NumericUpDown
    Friend WithEvents LblFineRate As System.Windows.Forms.Label
    Friend WithEvents NudFineRate As System.Windows.Forms.NumericUpDown
    Friend WithEvents LblMaxBooks As System.Windows.Forms.Label
    Friend WithEvents NudMaxBooks As System.Windows.Forms.NumericUpDown
    Friend WithEvents LblCurrency As System.Windows.Forms.Label
    Friend WithEvents CmbCurrency As System.Windows.Forms.ComboBox
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents BtnReset As System.Windows.Forms.Button
    Friend WithEvents LblBackupTitle As System.Windows.Forms.Label
    Friend WithEvents BtnBackup As System.Windows.Forms.Button
    Friend WithEvents BtnRestore As System.Windows.Forms.Button
    Friend WithEvents LblMessage As System.Windows.Forms.Label

End Class
