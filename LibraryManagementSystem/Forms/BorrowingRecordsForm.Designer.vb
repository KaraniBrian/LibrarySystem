<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BorrowingRecordsForm
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PnlGrid = New System.Windows.Forms.Panel()
        Me.DgvRecords = New System.Windows.Forms.DataGridView()
        Me.ColLoanID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColStudent = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColAdmissionNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColBook = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColIssueDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColDueDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColReturnDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PnlBottom = New System.Windows.Forms.Panel()
        Me.BtnViewDetails = New System.Windows.Forms.Button()
        Me.BtnExport = New System.Windows.Forms.Button()
        Me.BtnRefresh = New System.Windows.Forms.Button()
        Me.LblRecordCount = New System.Windows.Forms.Label()
        Me.LblMessage = New System.Windows.Forms.Label()
        Me.PnlHeader = New System.Windows.Forms.Panel()
        Me.LblTitle = New System.Windows.Forms.Label()
        Me.LblSearch = New System.Windows.Forms.Label()
        Me.TxtSearch = New System.Windows.Forms.TextBox()
        Me.LblStatus = New System.Windows.Forms.Label()
        Me.CmbStatus = New System.Windows.Forms.ComboBox()
        Me.LblFromDate = New System.Windows.Forms.Label()
        Me.DtpFromDate = New System.Windows.Forms.DateTimePicker()
        Me.LblToDate = New System.Windows.Forms.Label()
        Me.DtpToDate = New System.Windows.Forms.DateTimePicker()
        Me.BtnFilter = New System.Windows.Forms.Button()
        Me.BtnReset = New System.Windows.Forms.Button()
        CType(Me.DgvRecords, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlGrid.SuspendLayout()
        Me.PnlBottom.SuspendLayout()
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
        Me.PnlGrid.Controls.Add(Me.DgvRecords)
        '
        'DgvRecords
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
        Me.DgvRecords.AllowUserToAddRows = False
        Me.DgvRecords.AllowUserToDeleteRows = False
        Me.DgvRecords.AllowUserToResizeRows = False
        Me.DgvRecords.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DgvRecords.AutoGenerateColumns = False
        Me.DgvRecords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvRecords.BackgroundColor = System.Drawing.Color.White
        Me.DgvRecords.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DgvRecords.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvRecords.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColLoanID, Me.ColStudent, Me.ColAdmissionNo, Me.ColBook, Me.ColIssueDate, Me.ColDueDate, Me.ColReturnDate, Me.ColStatus})
        Me.DgvRecords.DefaultCellStyle = DataGridViewCellStyle3
        Me.DgvRecords.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvRecords.EnableHeadersVisualStyles = False
        Me.DgvRecords.MultiSelect = False
        Me.DgvRecords.Name = "DgvRecords"
        Me.DgvRecords.ReadOnly = True
        Me.DgvRecords.RowHeadersVisible = False
        Me.DgvRecords.RowTemplate.Height = 28
        Me.DgvRecords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvRecords.TabIndex = 0
        '
        'ColLoanID
        '
        Me.ColLoanID.DataPropertyName = "Loan ID"
        Me.ColLoanID.HeaderText = "Loan ID"
        Me.ColLoanID.Name = "ColLoanID"
        Me.ColLoanID.ReadOnly = True
        '
        'ColStudent
        '
        Me.ColStudent.DataPropertyName = "Student"
        Me.ColStudent.HeaderText = "Student"
        Me.ColStudent.Name = "ColStudent"
        Me.ColStudent.ReadOnly = True
        '
        'ColAdmissionNo
        '
        Me.ColAdmissionNo.DataPropertyName = "Admission No"
        Me.ColAdmissionNo.HeaderText = "Admission No"
        Me.ColAdmissionNo.Name = "ColAdmissionNo"
        Me.ColAdmissionNo.ReadOnly = True
        '
        'ColBook
        '
        Me.ColBook.DataPropertyName = "Book"
        Me.ColBook.HeaderText = "Book"
        Me.ColBook.Name = "ColBook"
        Me.ColBook.ReadOnly = True
        '
        'ColIssueDate
        '
        DataGridViewCellStyle4.Format = "yyyy-MM-dd"
        Me.ColIssueDate.DataPropertyName = "Issue Date"
        Me.ColIssueDate.DefaultCellStyle = DataGridViewCellStyle4
        Me.ColIssueDate.HeaderText = "Issue Date"
        Me.ColIssueDate.Name = "ColIssueDate"
        Me.ColIssueDate.ReadOnly = True
        '
        'ColDueDate
        '
        DataGridViewCellStyle5.Format = "yyyy-MM-dd"
        Me.ColDueDate.DataPropertyName = "Due Date"
        Me.ColDueDate.DefaultCellStyle = DataGridViewCellStyle5
        Me.ColDueDate.HeaderText = "Due Date"
        Me.ColDueDate.Name = "ColDueDate"
        Me.ColDueDate.ReadOnly = True
        '
        'ColReturnDate
        '
        DataGridViewCellStyle6.Format = "yyyy-MM-dd"
        Me.ColReturnDate.DataPropertyName = "Return Date"
        Me.ColReturnDate.DefaultCellStyle = DataGridViewCellStyle6
        Me.ColReturnDate.HeaderText = "Return Date"
        Me.ColReturnDate.Name = "ColReturnDate"
        Me.ColReturnDate.ReadOnly = True
        '
        'ColStatus
        '
        Me.ColStatus.DataPropertyName = "Status"
        Me.ColStatus.HeaderText = "Status"
        Me.ColStatus.Name = "ColStatus"
        Me.ColStatus.ReadOnly = True
        '
        'PnlBottom
        '
        Me.PnlBottom.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PnlBottom.Name = "PnlBottom"
        Me.PnlBottom.Size = New System.Drawing.Size(0, 84)
        Me.PnlBottom.TabIndex = 1
        Me.PnlBottom.Controls.Add(Me.BtnViewDetails)
        Me.PnlBottom.Controls.Add(Me.BtnExport)
        Me.PnlBottom.Controls.Add(Me.BtnRefresh)
        Me.PnlBottom.Controls.Add(Me.LblRecordCount)
        Me.PnlBottom.Controls.Add(Me.LblMessage)
        '
        'BtnViewDetails
        '
        Me.BtnViewDetails.BackColor = System.Drawing.Color.White
        Me.BtnViewDetails.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnViewDetails.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.BtnViewDetails.FlatAppearance.BorderSize = 1
        Me.BtnViewDetails.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.BtnViewDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnViewDetails.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnViewDetails.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.BtnViewDetails.Location = New System.Drawing.Point(24, 8)
        Me.BtnViewDetails.Name = "BtnViewDetails"
        Me.BtnViewDetails.Size = New System.Drawing.Size(130, 36)
        Me.BtnViewDetails.Text = "View Details"
        Me.BtnViewDetails.UseVisualStyleBackColor = False
        Me.BtnViewDetails.TabIndex = 0
        '
        'BtnExport
        '
        Me.BtnExport.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.BtnExport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnExport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.BtnExport.FlatAppearance.BorderSize = 1
        Me.BtnExport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExport.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExport.ForeColor = System.Drawing.Color.White
        Me.BtnExport.Location = New System.Drawing.Point(164, 8)
        Me.BtnExport.Name = "BtnExport"
        Me.BtnExport.Size = New System.Drawing.Size(150, 36)
        Me.BtnExport.Text = "Export Records"
        Me.BtnExport.UseVisualStyleBackColor = False
        Me.BtnExport.TabIndex = 1
        '
        'BtnRefresh
        '
        Me.BtnRefresh.BackColor = System.Drawing.Color.White
        Me.BtnRefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.BtnRefresh.FlatAppearance.BorderSize = 1
        Me.BtnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.BtnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRefresh.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRefresh.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.BtnRefresh.Location = New System.Drawing.Point(324, 8)
        Me.BtnRefresh.Name = "BtnRefresh"
        Me.BtnRefresh.Size = New System.Drawing.Size(90, 36)
        Me.BtnRefresh.Text = "Refresh"
        Me.BtnRefresh.UseVisualStyleBackColor = False
        Me.BtnRefresh.TabIndex = 2
        '
        'LblRecordCount
        '
        Me.LblRecordCount.AutoSize = True
        Me.LblRecordCount.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRecordCount.Location = New System.Drawing.Point(430, 16)
        Me.LblRecordCount.Name = "LblRecordCount"
        Me.LblRecordCount.Text = "Records: 0"
        Me.LblRecordCount.TabIndex = 3
        '
        'LblMessage
        '
        Me.LblMessage.AutoSize = True
        Me.LblMessage.ForeColor = System.Drawing.Color.Firebrick
        Me.LblMessage.Location = New System.Drawing.Point(24, 56)
        Me.LblMessage.Name = "LblMessage"
        Me.LblMessage.Text = ""
        Me.LblMessage.TabIndex = 4
        '
        'PnlHeader
        '
        Me.PnlHeader.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlHeader.Name = "PnlHeader"
        Me.PnlHeader.Size = New System.Drawing.Size(0, 136)
        Me.PnlHeader.TabIndex = 2
        Me.PnlHeader.Controls.Add(Me.LblTitle)
        Me.PnlHeader.Controls.Add(Me.LblSearch)
        Me.PnlHeader.Controls.Add(Me.TxtSearch)
        Me.PnlHeader.Controls.Add(Me.LblStatus)
        Me.PnlHeader.Controls.Add(Me.CmbStatus)
        Me.PnlHeader.Controls.Add(Me.LblFromDate)
        Me.PnlHeader.Controls.Add(Me.DtpFromDate)
        Me.PnlHeader.Controls.Add(Me.LblToDate)
        Me.PnlHeader.Controls.Add(Me.DtpToDate)
        Me.PnlHeader.Controls.Add(Me.BtnFilter)
        Me.PnlHeader.Controls.Add(Me.BtnReset)
        '
        'LblTitle
        '
        Me.LblTitle.AutoSize = True
        Me.LblTitle.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.LblTitle.Location = New System.Drawing.Point(24, 10)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Text = "Borrowing and Returns Records"
        Me.LblTitle.TabIndex = 0
        '
        'LblSearch
        '
        Me.LblSearch.AutoSize = True
        Me.LblSearch.Location = New System.Drawing.Point(24, 58)
        Me.LblSearch.Name = "LblSearch"
        Me.LblSearch.Text = "Search:"
        Me.LblSearch.TabIndex = 1
        '
        'TxtSearch
        '
        Me.TxtSearch.Location = New System.Drawing.Point(86, 54)
        Me.TxtSearch.MaxLength = 100
        Me.TxtSearch.Name = "TxtSearch"
        Me.TxtSearch.PlaceholderText = "Student, book or loan ID"
        Me.TxtSearch.Size = New System.Drawing.Size(200, 27)
        Me.TxtSearch.TabIndex = 2
        '
        'LblStatus
        '
        Me.LblStatus.AutoSize = True
        Me.LblStatus.Location = New System.Drawing.Point(300, 58)
        Me.LblStatus.Name = "LblStatus"
        Me.LblStatus.Text = "Loan Status:"
        Me.LblStatus.TabIndex = 3
        '
        'CmbStatus
        '
        Me.CmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbStatus.FormattingEnabled = True
        Me.CmbStatus.Items.AddRange(New Object() {"All", "Active", "Overdue", "Return Requested", "Returned"})
        Me.CmbStatus.Location = New System.Drawing.Point(396, 54)
        Me.CmbStatus.Name = "CmbStatus"
        Me.CmbStatus.Size = New System.Drawing.Size(150, 28)
        Me.CmbStatus.TabIndex = 4
        '
        'LblFromDate
        '
        Me.LblFromDate.AutoSize = True
        Me.LblFromDate.Location = New System.Drawing.Point(24, 98)
        Me.LblFromDate.Name = "LblFromDate"
        Me.LblFromDate.Text = "From Date:"
        Me.LblFromDate.TabIndex = 5
        '
        'DtpFromDate
        '
        Me.DtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DtpFromDate.Location = New System.Drawing.Point(100, 94)
        Me.DtpFromDate.Name = "DtpFromDate"
        Me.DtpFromDate.Size = New System.Drawing.Size(130, 27)
        Me.DtpFromDate.TabIndex = 6
        '
        'LblToDate
        '
        Me.LblToDate.AutoSize = True
        Me.LblToDate.Location = New System.Drawing.Point(246, 98)
        Me.LblToDate.Name = "LblToDate"
        Me.LblToDate.Text = "To Date:"
        Me.LblToDate.TabIndex = 7
        '
        'DtpToDate
        '
        Me.DtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DtpToDate.Location = New System.Drawing.Point(310, 94)
        Me.DtpToDate.Name = "DtpToDate"
        Me.DtpToDate.Size = New System.Drawing.Size(130, 27)
        Me.DtpToDate.TabIndex = 8
        '
        'BtnFilter
        '
        Me.BtnFilter.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.BtnFilter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFilter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.BtnFilter.FlatAppearance.BorderSize = 1
        Me.BtnFilter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFilter.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFilter.ForeColor = System.Drawing.Color.White
        Me.BtnFilter.Location = New System.Drawing.Point(456, 92)
        Me.BtnFilter.Name = "BtnFilter"
        Me.BtnFilter.Size = New System.Drawing.Size(130, 34)
        Me.BtnFilter.Text = "Apply Filters"
        Me.BtnFilter.UseVisualStyleBackColor = False
        Me.BtnFilter.TabIndex = 9
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
        Me.BtnReset.Location = New System.Drawing.Point(596, 92)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.Size = New System.Drawing.Size(90, 34)
        Me.BtnReset.Text = "Reset"
        Me.BtnReset.UseVisualStyleBackColor = False
        Me.BtnReset.TabIndex = 10
        '
        'BorrowingRecordsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScroll = True
        Me.AutoScrollMinSize = New System.Drawing.Size(860, 500)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(880, 560)
        Me.Controls.Add(Me.PnlGrid)
        Me.Controls.Add(Me.PnlBottom)
        Me.Controls.Add(Me.PnlHeader)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "BorrowingRecordsForm"
        Me.Text = "Borrowing and Returns Records"
        CType(Me.DgvRecords, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlGrid.ResumeLayout(False)
        Me.PnlGrid.PerformLayout()
        Me.PnlBottom.ResumeLayout(False)
        Me.PnlBottom.PerformLayout()
        Me.PnlHeader.ResumeLayout(False)
        Me.PnlHeader.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents PnlGrid As System.Windows.Forms.Panel
    Friend WithEvents DgvRecords As System.Windows.Forms.DataGridView
    Friend WithEvents ColLoanID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColStudent As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColAdmissionNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColBook As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColIssueDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColDueDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColReturnDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColStatus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PnlBottom As System.Windows.Forms.Panel
    Friend WithEvents BtnViewDetails As System.Windows.Forms.Button
    Friend WithEvents BtnExport As System.Windows.Forms.Button
    Friend WithEvents BtnRefresh As System.Windows.Forms.Button
    Friend WithEvents LblRecordCount As System.Windows.Forms.Label
    Friend WithEvents LblMessage As System.Windows.Forms.Label
    Friend WithEvents PnlHeader As System.Windows.Forms.Panel
    Friend WithEvents LblTitle As System.Windows.Forms.Label
    Friend WithEvents LblSearch As System.Windows.Forms.Label
    Friend WithEvents TxtSearch As System.Windows.Forms.TextBox
    Friend WithEvents LblStatus As System.Windows.Forms.Label
    Friend WithEvents CmbStatus As System.Windows.Forms.ComboBox
    Friend WithEvents LblFromDate As System.Windows.Forms.Label
    Friend WithEvents DtpFromDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents LblToDate As System.Windows.Forms.Label
    Friend WithEvents DtpToDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents BtnFilter As System.Windows.Forms.Button
    Friend WithEvents BtnReset As System.Windows.Forms.Button

End Class
