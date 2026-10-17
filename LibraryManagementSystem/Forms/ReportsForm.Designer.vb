<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportsForm
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
        Me.PnlGrid = New System.Windows.Forms.Panel()
        Me.DgvReport = New System.Windows.Forms.DataGridView()
        Me.PnlBottom = New System.Windows.Forms.Panel()
        Me.PnlSummary = New System.Windows.Forms.Panel()
        Me.LblSummary = New System.Windows.Forms.Label()
        Me.LblSummaryText = New System.Windows.Forms.Label()
        Me.BtnExportCsv = New System.Windows.Forms.Button()
        Me.BtnPrint = New System.Windows.Forms.Button()
        Me.LblMessage = New System.Windows.Forms.Label()
        Me.PnlHeader = New System.Windows.Forms.Panel()
        Me.LblTitle = New System.Windows.Forms.Label()
        Me.LblReportType = New System.Windows.Forms.Label()
        Me.CmbReportType = New System.Windows.Forms.ComboBox()
        Me.LblFromDate = New System.Windows.Forms.Label()
        Me.DtpFromDate = New System.Windows.Forms.DateTimePicker()
        Me.LblToDate = New System.Windows.Forms.Label()
        Me.DtpToDate = New System.Windows.Forms.DateTimePicker()
        Me.BtnGenerate = New System.Windows.Forms.Button()
        Me.LblDateNote = New System.Windows.Forms.Label()
        CType(Me.DgvReport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlGrid.SuspendLayout()
        Me.PnlBottom.SuspendLayout()
        Me.PnlSummary.SuspendLayout()
        Me.PnlHeader.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlGrid
        '
        Me.PnlGrid.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PnlGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlGrid.Name = "PnlGrid"
        Me.PnlGrid.Padding = New System.Windows.Forms.Padding(24, 4, 24, 4)
        Me.PnlGrid.TabIndex = 0
        Me.PnlGrid.Controls.Add(Me.DgvReport)
        '
        'DgvReport
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
        Me.DgvReport.AllowUserToAddRows = False
        Me.DgvReport.AllowUserToDeleteRows = False
        Me.DgvReport.AllowUserToResizeRows = False
        Me.DgvReport.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DgvReport.AutoGenerateColumns = True
        Me.DgvReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvReport.BackgroundColor = System.Drawing.Color.White
        Me.DgvReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DgvReport.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvReport.DefaultCellStyle = DataGridViewCellStyle3
        Me.DgvReport.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvReport.EnableHeadersVisualStyles = False
        Me.DgvReport.MultiSelect = False
        Me.DgvReport.Name = "DgvReport"
        Me.DgvReport.ReadOnly = True
        Me.DgvReport.RowHeadersVisible = False
        Me.DgvReport.RowTemplate.Height = 28
        Me.DgvReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvReport.TabIndex = 0
        '
        'PnlBottom
        '
        Me.PnlBottom.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PnlBottom.Name = "PnlBottom"
        Me.PnlBottom.Size = New System.Drawing.Size(0, 172)
        Me.PnlBottom.TabIndex = 1
        Me.PnlBottom.Controls.Add(Me.PnlSummary)
        Me.PnlBottom.Controls.Add(Me.BtnExportCsv)
        Me.PnlBottom.Controls.Add(Me.BtnPrint)
        Me.PnlBottom.Controls.Add(Me.LblMessage)
        '
        'PnlSummary
        '
        Me.PnlSummary.BackColor = System.Drawing.Color.White
        Me.PnlSummary.Location = New System.Drawing.Point(24, 6)
        Me.PnlSummary.Name = "PnlSummary"
        Me.PnlSummary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlSummary.Size = New System.Drawing.Size(440, 84)
        Me.PnlSummary.TabIndex = 0
        Me.PnlSummary.Controls.Add(Me.LblSummary)
        Me.PnlSummary.Controls.Add(Me.LblSummaryText)
        '
        'LblSummary
        '
        Me.LblSummary.AutoSize = True
        Me.LblSummary.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSummary.Location = New System.Drawing.Point(10, 6)
        Me.LblSummary.Name = "LblSummary"
        Me.LblSummary.Text = "Report Summary"
        Me.LblSummary.TabIndex = 0
        '
        'LblSummaryText
        '
        Me.LblSummaryText.AutoSize = True
        Me.LblSummaryText.Location = New System.Drawing.Point(10, 34)
        Me.LblSummaryText.Name = "LblSummaryText"
        Me.LblSummaryText.Text = "Choose a report and click Generate."
        Me.LblSummaryText.TabIndex = 1
        '
        'BtnExportCsv
        '
        Me.BtnExportCsv.BackColor = System.Drawing.Color.White
        Me.BtnExportCsv.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnExportCsv.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.BtnExportCsv.FlatAppearance.BorderSize = 1
        Me.BtnExportCsv.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.BtnExportCsv.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExportCsv.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExportCsv.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.BtnExportCsv.Location = New System.Drawing.Point(24, 100)
        Me.BtnExportCsv.Name = "BtnExportCsv"
        Me.BtnExportCsv.Size = New System.Drawing.Size(130, 36)
        Me.BtnExportCsv.Text = "Export CSV"
        Me.BtnExportCsv.UseVisualStyleBackColor = False
        Me.BtnExportCsv.TabIndex = 1
        '
        'BtnPrint
        '
        Me.BtnPrint.BackColor = System.Drawing.Color.White
        Me.BtnPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPrint.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.BtnPrint.FlatAppearance.BorderSize = 1
        Me.BtnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.BtnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPrint.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrint.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.BtnPrint.Location = New System.Drawing.Point(164, 100)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(130, 36)
        Me.BtnPrint.Text = "Print Report"
        Me.BtnPrint.UseVisualStyleBackColor = False
        Me.BtnPrint.TabIndex = 2
        '
        'LblMessage
        '
        Me.LblMessage.AutoSize = True
        Me.LblMessage.ForeColor = System.Drawing.Color.Firebrick
        Me.LblMessage.Location = New System.Drawing.Point(24, 146)
        Me.LblMessage.Name = "LblMessage"
        Me.LblMessage.Text = ""
        Me.LblMessage.TabIndex = 3
        '
        'PnlHeader
        '
        Me.PnlHeader.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlHeader.Name = "PnlHeader"
        Me.PnlHeader.Size = New System.Drawing.Size(0, 136)
        Me.PnlHeader.TabIndex = 2
        Me.PnlHeader.Controls.Add(Me.LblTitle)
        Me.PnlHeader.Controls.Add(Me.LblReportType)
        Me.PnlHeader.Controls.Add(Me.CmbReportType)
        Me.PnlHeader.Controls.Add(Me.LblFromDate)
        Me.PnlHeader.Controls.Add(Me.DtpFromDate)
        Me.PnlHeader.Controls.Add(Me.LblToDate)
        Me.PnlHeader.Controls.Add(Me.DtpToDate)
        Me.PnlHeader.Controls.Add(Me.BtnGenerate)
        Me.PnlHeader.Controls.Add(Me.LblDateNote)
        '
        'LblTitle
        '
        Me.LblTitle.AutoSize = True
        Me.LblTitle.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.LblTitle.Location = New System.Drawing.Point(24, 10)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Text = "Reports"
        Me.LblTitle.TabIndex = 0
        '
        'LblReportType
        '
        Me.LblReportType.AutoSize = True
        Me.LblReportType.Location = New System.Drawing.Point(24, 58)
        Me.LblReportType.Name = "LblReportType"
        Me.LblReportType.Text = "Report Type:"
        Me.LblReportType.TabIndex = 1
        '
        'CmbReportType
        '
        Me.CmbReportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbReportType.FormattingEnabled = True
        Me.CmbReportType.Items.AddRange(New Object() {"Book Inventory", "Registered Students", "Current Loans", "Overdue Books", "Returned Books", "Outstanding Fines", "Payment History"})
        Me.CmbReportType.Location = New System.Drawing.Point(124, 54)
        Me.CmbReportType.Name = "CmbReportType"
        Me.CmbReportType.Size = New System.Drawing.Size(210, 28)
        Me.CmbReportType.TabIndex = 2
        '
        'LblFromDate
        '
        Me.LblFromDate.AutoSize = True
        Me.LblFromDate.Location = New System.Drawing.Point(350, 58)
        Me.LblFromDate.Name = "LblFromDate"
        Me.LblFromDate.Text = "From Date:"
        Me.LblFromDate.TabIndex = 3
        '
        'DtpFromDate
        '
        Me.DtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DtpFromDate.Location = New System.Drawing.Point(430, 54)
        Me.DtpFromDate.Name = "DtpFromDate"
        Me.DtpFromDate.Size = New System.Drawing.Size(120, 27)
        Me.DtpFromDate.TabIndex = 4
        '
        'LblToDate
        '
        Me.LblToDate.AutoSize = True
        Me.LblToDate.Location = New System.Drawing.Point(566, 58)
        Me.LblToDate.Name = "LblToDate"
        Me.LblToDate.Text = "To Date:"
        Me.LblToDate.TabIndex = 5
        '
        'DtpToDate
        '
        Me.DtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DtpToDate.Location = New System.Drawing.Point(636, 54)
        Me.DtpToDate.Name = "DtpToDate"
        Me.DtpToDate.Size = New System.Drawing.Size(120, 27)
        Me.DtpToDate.TabIndex = 6
        '
        'BtnGenerate
        '
        Me.BtnGenerate.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.BtnGenerate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnGenerate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.BtnGenerate.FlatAppearance.BorderSize = 1
        Me.BtnGenerate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGenerate.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGenerate.ForeColor = System.Drawing.Color.White
        Me.BtnGenerate.Location = New System.Drawing.Point(24, 92)
        Me.BtnGenerate.Name = "BtnGenerate"
        Me.BtnGenerate.Size = New System.Drawing.Size(160, 34)
        Me.BtnGenerate.Text = "Generate Report"
        Me.BtnGenerate.UseVisualStyleBackColor = False
        Me.BtnGenerate.TabIndex = 7
        '
        'LblDateNote
        '
        Me.LblDateNote.AutoSize = True
        Me.LblDateNote.ForeColor = System.Drawing.Color.DimGray
        Me.LblDateNote.Location = New System.Drawing.Point(200, 100)
        Me.LblDateNote.Name = "LblDateNote"
        Me.LblDateNote.Text = "The date range applies to Returned Books and Payment History."
        Me.LblDateNote.TabIndex = 8
        '
        'ReportsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScroll = True
        Me.AutoScrollMinSize = New System.Drawing.Size(860, 520)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(880, 560)
        Me.Controls.Add(Me.PnlGrid)
        Me.Controls.Add(Me.PnlBottom)
        Me.Controls.Add(Me.PnlHeader)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "ReportsForm"
        Me.Text = "Reports"
        CType(Me.DgvReport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlGrid.ResumeLayout(False)
        Me.PnlGrid.PerformLayout()
        Me.PnlBottom.ResumeLayout(False)
        Me.PnlBottom.PerformLayout()
        Me.PnlSummary.ResumeLayout(False)
        Me.PnlSummary.PerformLayout()
        Me.PnlHeader.ResumeLayout(False)
        Me.PnlHeader.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents PnlGrid As System.Windows.Forms.Panel
    Friend WithEvents DgvReport As System.Windows.Forms.DataGridView
    Friend WithEvents PnlBottom As System.Windows.Forms.Panel
    Friend WithEvents PnlSummary As System.Windows.Forms.Panel
    Friend WithEvents LblSummary As System.Windows.Forms.Label
    Friend WithEvents LblSummaryText As System.Windows.Forms.Label
    Friend WithEvents BtnExportCsv As System.Windows.Forms.Button
    Friend WithEvents BtnPrint As System.Windows.Forms.Button
    Friend WithEvents LblMessage As System.Windows.Forms.Label
    Friend WithEvents PnlHeader As System.Windows.Forms.Panel
    Friend WithEvents LblTitle As System.Windows.Forms.Label
    Friend WithEvents LblReportType As System.Windows.Forms.Label
    Friend WithEvents CmbReportType As System.Windows.Forms.ComboBox
    Friend WithEvents LblFromDate As System.Windows.Forms.Label
    Friend WithEvents DtpFromDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents LblToDate As System.Windows.Forms.Label
    Friend WithEvents DtpToDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents BtnGenerate As System.Windows.Forms.Button
    Friend WithEvents LblDateNote As System.Windows.Forms.Label

End Class
