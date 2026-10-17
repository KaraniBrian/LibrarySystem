<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FinesManagementForm
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
        Me.DgvFines = New System.Windows.Forms.DataGridView()
        Me.ColFineID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColStudent = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColAdmissionNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColBook = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColPaid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColBalance = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PnlEdit = New System.Windows.Forms.Panel()
        Me.LblStudent = New System.Windows.Forms.Label()
        Me.TxtStudent = New System.Windows.Forms.TextBox()
        Me.LblFineAmount = New System.Windows.Forms.Label()
        Me.TxtFineAmount = New System.Windows.Forms.TextBox()
        Me.LblAmountPaid = New System.Windows.Forms.Label()
        Me.TxtAmountPaid = New System.Windows.Forms.TextBox()
        Me.LblBalance = New System.Windows.Forms.Label()
        Me.TxtBalance = New System.Windows.Forms.TextBox()
        Me.BtnRecordPayment = New System.Windows.Forms.Button()
        Me.BtnViewDetails = New System.Windows.Forms.Button()
        Me.BtnRefresh = New System.Windows.Forms.Button()
        Me.LblMessage = New System.Windows.Forms.Label()
        Me.PnlHeader = New System.Windows.Forms.Panel()
        Me.LblTitle = New System.Windows.Forms.Label()
        Me.TxtSearch = New System.Windows.Forms.TextBox()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.LblFineStatus = New System.Windows.Forms.Label()
        Me.CmbFineStatus = New System.Windows.Forms.ComboBox()
        CType(Me.DgvFines, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlGrid.SuspendLayout()
        Me.PnlEdit.SuspendLayout()
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
        Me.PnlGrid.Controls.Add(Me.DgvFines)
        '
        'DgvFines
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
        Me.DgvFines.AllowUserToAddRows = False
        Me.DgvFines.AllowUserToDeleteRows = False
        Me.DgvFines.AllowUserToResizeRows = False
        Me.DgvFines.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DgvFines.AutoGenerateColumns = False
        Me.DgvFines.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvFines.BackgroundColor = System.Drawing.Color.White
        Me.DgvFines.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DgvFines.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvFines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvFines.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColFineID, Me.ColStudent, Me.ColAdmissionNo, Me.ColBook, Me.ColAmount, Me.ColPaid, Me.ColBalance, Me.ColStatus})
        Me.DgvFines.DefaultCellStyle = DataGridViewCellStyle3
        Me.DgvFines.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvFines.EnableHeadersVisualStyles = False
        Me.DgvFines.MultiSelect = False
        Me.DgvFines.Name = "DgvFines"
        Me.DgvFines.ReadOnly = True
        Me.DgvFines.RowHeadersVisible = False
        Me.DgvFines.RowTemplate.Height = 28
        Me.DgvFines.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvFines.TabIndex = 0
        '
        'ColFineID
        '
        Me.ColFineID.DataPropertyName = "Fine ID"
        Me.ColFineID.HeaderText = "Fine ID"
        Me.ColFineID.Name = "ColFineID"
        Me.ColFineID.ReadOnly = True
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
        'ColAmount
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        Me.ColAmount.DataPropertyName = "Amount"
        Me.ColAmount.DefaultCellStyle = DataGridViewCellStyle4
        Me.ColAmount.HeaderText = "Amount"
        Me.ColAmount.Name = "ColAmount"
        Me.ColAmount.ReadOnly = True
        '
        'ColPaid
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N2"
        Me.ColPaid.DataPropertyName = "Paid"
        Me.ColPaid.DefaultCellStyle = DataGridViewCellStyle5
        Me.ColPaid.HeaderText = "Paid"
        Me.ColPaid.Name = "ColPaid"
        Me.ColPaid.ReadOnly = True
        '
        'ColBalance
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "N2"
        Me.ColBalance.DataPropertyName = "Balance"
        Me.ColBalance.DefaultCellStyle = DataGridViewCellStyle6
        Me.ColBalance.HeaderText = "Balance"
        Me.ColBalance.Name = "ColBalance"
        Me.ColBalance.ReadOnly = True
        '
        'ColStatus
        '
        Me.ColStatus.DataPropertyName = "Status"
        Me.ColStatus.HeaderText = "Status"
        Me.ColStatus.Name = "ColStatus"
        Me.ColStatus.ReadOnly = True
        '
        'PnlEdit
        '
        Me.PnlEdit.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PnlEdit.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PnlEdit.Name = "PnlEdit"
        Me.PnlEdit.Size = New System.Drawing.Size(0, 166)
        Me.PnlEdit.TabIndex = 1
        Me.PnlEdit.Controls.Add(Me.LblStudent)
        Me.PnlEdit.Controls.Add(Me.TxtStudent)
        Me.PnlEdit.Controls.Add(Me.LblFineAmount)
        Me.PnlEdit.Controls.Add(Me.TxtFineAmount)
        Me.PnlEdit.Controls.Add(Me.LblAmountPaid)
        Me.PnlEdit.Controls.Add(Me.TxtAmountPaid)
        Me.PnlEdit.Controls.Add(Me.LblBalance)
        Me.PnlEdit.Controls.Add(Me.TxtBalance)
        Me.PnlEdit.Controls.Add(Me.BtnRecordPayment)
        Me.PnlEdit.Controls.Add(Me.BtnViewDetails)
        Me.PnlEdit.Controls.Add(Me.BtnRefresh)
        Me.PnlEdit.Controls.Add(Me.LblMessage)
        '
        'LblStudent
        '
        Me.LblStudent.AutoSize = True
        Me.LblStudent.Location = New System.Drawing.Point(24, 12)
        Me.LblStudent.Name = "LblStudent"
        Me.LblStudent.Text = "Student:"
        Me.LblStudent.TabIndex = 0
        '
        'TxtStudent
        '
        Me.TxtStudent.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TxtStudent.Location = New System.Drawing.Point(154, 8)
        Me.TxtStudent.Name = "TxtStudent"
        Me.TxtStudent.ReadOnly = True
        Me.TxtStudent.Size = New System.Drawing.Size(270, 27)
        Me.TxtStudent.TabIndex = 1
        '
        'LblFineAmount
        '
        Me.LblFineAmount.AutoSize = True
        Me.LblFineAmount.Location = New System.Drawing.Point(444, 12)
        Me.LblFineAmount.Name = "LblFineAmount"
        Me.LblFineAmount.Text = "Fine Amount:"
        Me.LblFineAmount.TabIndex = 2
        '
        'TxtFineAmount
        '
        Me.TxtFineAmount.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TxtFineAmount.Location = New System.Drawing.Point(574, 8)
        Me.TxtFineAmount.Name = "TxtFineAmount"
        Me.TxtFineAmount.ReadOnly = True
        Me.TxtFineAmount.Size = New System.Drawing.Size(270, 27)
        Me.TxtFineAmount.TabIndex = 3
        '
        'LblAmountPaid
        '
        Me.LblAmountPaid.AutoSize = True
        Me.LblAmountPaid.Location = New System.Drawing.Point(24, 48)
        Me.LblAmountPaid.Name = "LblAmountPaid"
        Me.LblAmountPaid.Text = "Amount Paid:"
        Me.LblAmountPaid.TabIndex = 4
        '
        'TxtAmountPaid
        '
        Me.TxtAmountPaid.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TxtAmountPaid.Location = New System.Drawing.Point(154, 44)
        Me.TxtAmountPaid.Name = "TxtAmountPaid"
        Me.TxtAmountPaid.ReadOnly = True
        Me.TxtAmountPaid.Size = New System.Drawing.Size(270, 27)
        Me.TxtAmountPaid.TabIndex = 5
        '
        'LblBalance
        '
        Me.LblBalance.AutoSize = True
        Me.LblBalance.Location = New System.Drawing.Point(444, 48)
        Me.LblBalance.Name = "LblBalance"
        Me.LblBalance.Text = "Outstanding Balance:"
        Me.LblBalance.TabIndex = 6
        '
        'TxtBalance
        '
        Me.TxtBalance.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TxtBalance.Location = New System.Drawing.Point(574, 44)
        Me.TxtBalance.Name = "TxtBalance"
        Me.TxtBalance.ReadOnly = True
        Me.TxtBalance.Size = New System.Drawing.Size(270, 27)
        Me.TxtBalance.TabIndex = 7
        '
        'BtnRecordPayment
        '
        Me.BtnRecordPayment.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.BtnRecordPayment.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRecordPayment.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.BtnRecordPayment.FlatAppearance.BorderSize = 1
        Me.BtnRecordPayment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnRecordPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRecordPayment.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRecordPayment.ForeColor = System.Drawing.Color.White
        Me.BtnRecordPayment.Enabled = False
        Me.BtnRecordPayment.Location = New System.Drawing.Point(24, 88)
        Me.BtnRecordPayment.Name = "BtnRecordPayment"
        Me.BtnRecordPayment.Size = New System.Drawing.Size(160, 36)
        Me.BtnRecordPayment.Text = "Record Payment"
        Me.BtnRecordPayment.UseVisualStyleBackColor = False
        Me.BtnRecordPayment.TabIndex = 8
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
        Me.BtnViewDetails.Location = New System.Drawing.Point(194, 88)
        Me.BtnViewDetails.Name = "BtnViewDetails"
        Me.BtnViewDetails.Size = New System.Drawing.Size(140, 36)
        Me.BtnViewDetails.Text = "View Details"
        Me.BtnViewDetails.UseVisualStyleBackColor = False
        Me.BtnViewDetails.TabIndex = 9
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
        Me.BtnRefresh.Location = New System.Drawing.Point(344, 88)
        Me.BtnRefresh.Name = "BtnRefresh"
        Me.BtnRefresh.Size = New System.Drawing.Size(100, 36)
        Me.BtnRefresh.Text = "Refresh"
        Me.BtnRefresh.UseVisualStyleBackColor = False
        Me.BtnRefresh.TabIndex = 10
        '
        'LblMessage
        '
        Me.LblMessage.AutoSize = True
        Me.LblMessage.ForeColor = System.Drawing.Color.Firebrick
        Me.LblMessage.Location = New System.Drawing.Point(24, 134)
        Me.LblMessage.Name = "LblMessage"
        Me.LblMessage.Text = ""
        Me.LblMessage.TabIndex = 11
        '
        'PnlHeader
        '
        Me.PnlHeader.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlHeader.Name = "PnlHeader"
        Me.PnlHeader.Size = New System.Drawing.Size(0, 100)
        Me.PnlHeader.TabIndex = 2
        Me.PnlHeader.Controls.Add(Me.LblTitle)
        Me.PnlHeader.Controls.Add(Me.TxtSearch)
        Me.PnlHeader.Controls.Add(Me.BtnSearch)
        Me.PnlHeader.Controls.Add(Me.LblFineStatus)
        Me.PnlHeader.Controls.Add(Me.CmbFineStatus)
        '
        'LblTitle
        '
        Me.LblTitle.AutoSize = True
        Me.LblTitle.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.LblTitle.Location = New System.Drawing.Point(24, 10)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Text = "Fines Management"
        Me.LblTitle.TabIndex = 0
        '
        'TxtSearch
        '
        Me.TxtSearch.Location = New System.Drawing.Point(24, 58)
        Me.TxtSearch.MaxLength = 100
        Me.TxtSearch.Name = "TxtSearch"
        Me.TxtSearch.PlaceholderText = "Search student or fine ID"
        Me.TxtSearch.Size = New System.Drawing.Size(260, 27)
        Me.TxtSearch.TabIndex = 1
        '
        'BtnSearch
        '
        Me.BtnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.BtnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.BtnSearch.FlatAppearance.BorderSize = 1
        Me.BtnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSearch.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSearch.ForeColor = System.Drawing.Color.White
        Me.BtnSearch.Location = New System.Drawing.Point(294, 54)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(90, 34)
        Me.BtnSearch.Text = "Search"
        Me.BtnSearch.UseVisualStyleBackColor = False
        Me.BtnSearch.TabIndex = 2
        '
        'LblFineStatus
        '
        Me.LblFineStatus.AutoSize = True
        Me.LblFineStatus.Location = New System.Drawing.Point(404, 62)
        Me.LblFineStatus.Name = "LblFineStatus"
        Me.LblFineStatus.Text = "Payment Status:"
        Me.LblFineStatus.TabIndex = 3
        '
        'CmbFineStatus
        '
        Me.CmbFineStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbFineStatus.FormattingEnabled = True
        Me.CmbFineStatus.Items.AddRange(New Object() {"All", "Unpaid", "Partially Paid", "Paid"})
        Me.CmbFineStatus.Location = New System.Drawing.Point(526, 58)
        Me.CmbFineStatus.Name = "CmbFineStatus"
        Me.CmbFineStatus.Size = New System.Drawing.Size(150, 28)
        Me.CmbFineStatus.TabIndex = 4
        '
        'FinesManagementForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScroll = True
        Me.AutoScrollMinSize = New System.Drawing.Size(860, 520)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(880, 560)
        Me.Controls.Add(Me.PnlGrid)
        Me.Controls.Add(Me.PnlEdit)
        Me.Controls.Add(Me.PnlHeader)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FinesManagementForm"
        Me.Text = "Fines Management"
        CType(Me.DgvFines, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlGrid.ResumeLayout(False)
        Me.PnlGrid.PerformLayout()
        Me.PnlEdit.ResumeLayout(False)
        Me.PnlEdit.PerformLayout()
        Me.PnlHeader.ResumeLayout(False)
        Me.PnlHeader.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents PnlGrid As System.Windows.Forms.Panel
    Friend WithEvents DgvFines As System.Windows.Forms.DataGridView
    Friend WithEvents ColFineID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColStudent As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColAdmissionNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColBook As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColAmount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColPaid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColBalance As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColStatus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PnlEdit As System.Windows.Forms.Panel
    Friend WithEvents LblStudent As System.Windows.Forms.Label
    Friend WithEvents TxtStudent As System.Windows.Forms.TextBox
    Friend WithEvents LblFineAmount As System.Windows.Forms.Label
    Friend WithEvents TxtFineAmount As System.Windows.Forms.TextBox
    Friend WithEvents LblAmountPaid As System.Windows.Forms.Label
    Friend WithEvents TxtAmountPaid As System.Windows.Forms.TextBox
    Friend WithEvents LblBalance As System.Windows.Forms.Label
    Friend WithEvents TxtBalance As System.Windows.Forms.TextBox
    Friend WithEvents BtnRecordPayment As System.Windows.Forms.Button
    Friend WithEvents BtnViewDetails As System.Windows.Forms.Button
    Friend WithEvents BtnRefresh As System.Windows.Forms.Button
    Friend WithEvents LblMessage As System.Windows.Forms.Label
    Friend WithEvents PnlHeader As System.Windows.Forms.Panel
    Friend WithEvents LblTitle As System.Windows.Forms.Label
    Friend WithEvents TxtSearch As System.Windows.Forms.TextBox
    Friend WithEvents BtnSearch As System.Windows.Forms.Button
    Friend WithEvents LblFineStatus As System.Windows.Forms.Label
    Friend WithEvents CmbFineStatus As System.Windows.Forms.ComboBox

End Class
