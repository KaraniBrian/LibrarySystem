<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MyFinesForm
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PnlGrid = New System.Windows.Forms.Panel()
        Me.DgvMyFines = New System.Windows.Forms.DataGridView()
        Me.ColFineID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColBook = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColPaid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColBalance = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PnlBottom = New System.Windows.Forms.Panel()
        Me.BtnViewDetails = New System.Windows.Forms.Button()
        Me.BtnViewPayments = New System.Windows.Forms.Button()
        Me.BtnRefresh = New System.Windows.Forms.Button()
        Me.LblNote = New System.Windows.Forms.Label()
        Me.LblMessage = New System.Windows.Forms.Label()
        Me.PnlHeader = New System.Windows.Forms.Panel()
        Me.LblTitle = New System.Windows.Forms.Label()
        Me.PnlTotalFine = New System.Windows.Forms.Panel()
        Me.LblTotalFineTitle = New System.Windows.Forms.Label()
        Me.LblTotalFineValue = New System.Windows.Forms.Label()
        Me.PnlPaid = New System.Windows.Forms.Panel()
        Me.LblPaidTitle = New System.Windows.Forms.Label()
        Me.LblPaidValue = New System.Windows.Forms.Label()
        Me.PnlBalance = New System.Windows.Forms.Panel()
        Me.LblBalanceTitle = New System.Windows.Forms.Label()
        Me.LblBalanceValue = New System.Windows.Forms.Label()
        Me.LblStatus = New System.Windows.Forms.Label()
        Me.CmbStatus = New System.Windows.Forms.ComboBox()
        CType(Me.DgvMyFines, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlGrid.SuspendLayout()
        Me.PnlBottom.SuspendLayout()
        Me.PnlHeader.SuspendLayout()
        Me.PnlTotalFine.SuspendLayout()
        Me.PnlPaid.SuspendLayout()
        Me.PnlBalance.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlGrid
        '
        Me.PnlGrid.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PnlGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlGrid.Name = "PnlGrid"
        Me.PnlGrid.Padding = New System.Windows.Forms.Padding(24, 4, 24, 4)
        Me.PnlGrid.TabIndex = 0
        Me.PnlGrid.Controls.Add(Me.DgvMyFines)
        '
        'DgvMyFines
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
        Me.DgvMyFines.AllowUserToAddRows = False
        Me.DgvMyFines.AllowUserToDeleteRows = False
        Me.DgvMyFines.AllowUserToResizeRows = False
        Me.DgvMyFines.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DgvMyFines.AutoGenerateColumns = False
        Me.DgvMyFines.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvMyFines.BackgroundColor = System.Drawing.Color.White
        Me.DgvMyFines.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DgvMyFines.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvMyFines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvMyFines.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColFineID, Me.ColBook, Me.ColDate, Me.ColAmount, Me.ColPaid, Me.ColBalance, Me.ColStatus})
        Me.DgvMyFines.DefaultCellStyle = DataGridViewCellStyle3
        Me.DgvMyFines.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvMyFines.EnableHeadersVisualStyles = False
        Me.DgvMyFines.MultiSelect = False
        Me.DgvMyFines.Name = "DgvMyFines"
        Me.DgvMyFines.ReadOnly = True
        Me.DgvMyFines.RowHeadersVisible = False
        Me.DgvMyFines.RowTemplate.Height = 28
        Me.DgvMyFines.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvMyFines.TabIndex = 0
        '
        'ColFineID
        '
        Me.ColFineID.DataPropertyName = "Fine ID"
        Me.ColFineID.HeaderText = "Fine ID"
        Me.ColFineID.Name = "ColFineID"
        Me.ColFineID.ReadOnly = True
        '
        'ColBook
        '
        Me.ColBook.DataPropertyName = "Book"
        Me.ColBook.HeaderText = "Book"
        Me.ColBook.Name = "ColBook"
        Me.ColBook.ReadOnly = True
        '
        'ColDate
        '
        DataGridViewCellStyle4.Format = "yyyy-MM-dd"
        Me.ColDate.DataPropertyName = "Date"
        Me.ColDate.DefaultCellStyle = DataGridViewCellStyle4
        Me.ColDate.HeaderText = "Date"
        Me.ColDate.Name = "ColDate"
        Me.ColDate.ReadOnly = True
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
        'ColPaid
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "N2"
        Me.ColPaid.DataPropertyName = "Paid"
        Me.ColPaid.DefaultCellStyle = DataGridViewCellStyle6
        Me.ColPaid.HeaderText = "Paid"
        Me.ColPaid.Name = "ColPaid"
        Me.ColPaid.ReadOnly = True
        '
        'ColBalance
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "N2"
        Me.ColBalance.DataPropertyName = "Balance"
        Me.ColBalance.DefaultCellStyle = DataGridViewCellStyle7
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
        'PnlBottom
        '
        Me.PnlBottom.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PnlBottom.Name = "PnlBottom"
        Me.PnlBottom.Size = New System.Drawing.Size(0, 100)
        Me.PnlBottom.TabIndex = 1
        Me.PnlBottom.Controls.Add(Me.BtnViewDetails)
        Me.PnlBottom.Controls.Add(Me.BtnViewPayments)
        Me.PnlBottom.Controls.Add(Me.BtnRefresh)
        Me.PnlBottom.Controls.Add(Me.LblNote)
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
        Me.BtnViewDetails.Size = New System.Drawing.Size(160, 36)
        Me.BtnViewDetails.Text = "View Fine Details"
        Me.BtnViewDetails.UseVisualStyleBackColor = False
        Me.BtnViewDetails.TabIndex = 0
        '
        'BtnViewPayments
        '
        Me.BtnViewPayments.BackColor = System.Drawing.Color.White
        Me.BtnViewPayments.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnViewPayments.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.BtnViewPayments.FlatAppearance.BorderSize = 1
        Me.BtnViewPayments.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.BtnViewPayments.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnViewPayments.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnViewPayments.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.BtnViewPayments.Location = New System.Drawing.Point(194, 8)
        Me.BtnViewPayments.Name = "BtnViewPayments"
        Me.BtnViewPayments.Size = New System.Drawing.Size(150, 36)
        Me.BtnViewPayments.Text = "Payment History"
        Me.BtnViewPayments.UseVisualStyleBackColor = False
        Me.BtnViewPayments.TabIndex = 1
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
        Me.BtnRefresh.Location = New System.Drawing.Point(354, 8)
        Me.BtnRefresh.Name = "BtnRefresh"
        Me.BtnRefresh.Size = New System.Drawing.Size(90, 36)
        Me.BtnRefresh.Text = "Refresh"
        Me.BtnRefresh.UseVisualStyleBackColor = False
        Me.BtnRefresh.TabIndex = 2
        '
        'LblNote
        '
        Me.LblNote.AutoSize = True
        Me.LblNote.ForeColor = System.Drawing.Color.DimGray
        Me.LblNote.Location = New System.Drawing.Point(24, 54)
        Me.LblNote.Name = "LblNote"
        Me.LblNote.Text = "Fines are paid at the library desk. The librarian records your payment."
        Me.LblNote.TabIndex = 3
        '
        'LblMessage
        '
        Me.LblMessage.AutoSize = True
        Me.LblMessage.ForeColor = System.Drawing.Color.Firebrick
        Me.LblMessage.Location = New System.Drawing.Point(24, 76)
        Me.LblMessage.Name = "LblMessage"
        Me.LblMessage.Text = ""
        Me.LblMessage.TabIndex = 4
        '
        'PnlHeader
        '
        Me.PnlHeader.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlHeader.Name = "PnlHeader"
        Me.PnlHeader.Size = New System.Drawing.Size(0, 200)
        Me.PnlHeader.TabIndex = 2
        Me.PnlHeader.Controls.Add(Me.LblTitle)
        Me.PnlHeader.Controls.Add(Me.PnlTotalFine)
        Me.PnlHeader.Controls.Add(Me.PnlPaid)
        Me.PnlHeader.Controls.Add(Me.PnlBalance)
        Me.PnlHeader.Controls.Add(Me.LblStatus)
        Me.PnlHeader.Controls.Add(Me.CmbStatus)
        '
        'LblTitle
        '
        Me.LblTitle.AutoSize = True
        Me.LblTitle.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.LblTitle.Location = New System.Drawing.Point(24, 10)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Text = "My Fines and Payments"
        Me.LblTitle.TabIndex = 0
        '
        'PnlTotalFine
        '
        Me.PnlTotalFine.BackColor = System.Drawing.Color.White
        Me.PnlTotalFine.Location = New System.Drawing.Point(24, 56)
        Me.PnlTotalFine.Name = "PnlTotalFine"
        Me.PnlTotalFine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlTotalFine.Size = New System.Drawing.Size(200, 100)
        Me.PnlTotalFine.TabIndex = 1
        Me.PnlTotalFine.Controls.Add(Me.LblTotalFineTitle)
        Me.PnlTotalFine.Controls.Add(Me.LblTotalFineValue)
        '
        'LblTotalFineTitle
        '
        Me.LblTotalFineTitle.AutoSize = True
        Me.LblTotalFineTitle.ForeColor = System.Drawing.Color.DimGray
        Me.LblTotalFineTitle.Location = New System.Drawing.Point(12, 12)
        Me.LblTotalFineTitle.Name = "LblTotalFineTitle"
        Me.LblTotalFineTitle.Text = "Total Fines"
        Me.LblTotalFineTitle.TabIndex = 0
        '
        'LblTotalFineValue
        '
        Me.LblTotalFineValue.AutoSize = True
        Me.LblTotalFineValue.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalFineValue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.LblTotalFineValue.Location = New System.Drawing.Point(10, 42)
        Me.LblTotalFineValue.Name = "LblTotalFineValue"
        Me.LblTotalFineValue.Text = "0"
        Me.LblTotalFineValue.TabIndex = 1
        '
        'PnlPaid
        '
        Me.PnlPaid.BackColor = System.Drawing.Color.White
        Me.PnlPaid.Location = New System.Drawing.Point(236, 56)
        Me.PnlPaid.Name = "PnlPaid"
        Me.PnlPaid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlPaid.Size = New System.Drawing.Size(200, 100)
        Me.PnlPaid.TabIndex = 2
        Me.PnlPaid.Controls.Add(Me.LblPaidTitle)
        Me.PnlPaid.Controls.Add(Me.LblPaidValue)
        '
        'LblPaidTitle
        '
        Me.LblPaidTitle.AutoSize = True
        Me.LblPaidTitle.ForeColor = System.Drawing.Color.DimGray
        Me.LblPaidTitle.Location = New System.Drawing.Point(12, 12)
        Me.LblPaidTitle.Name = "LblPaidTitle"
        Me.LblPaidTitle.Text = "Total Paid"
        Me.LblPaidTitle.TabIndex = 0
        '
        'LblPaidValue
        '
        Me.LblPaidValue.AutoSize = True
        Me.LblPaidValue.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPaidValue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.LblPaidValue.Location = New System.Drawing.Point(10, 42)
        Me.LblPaidValue.Name = "LblPaidValue"
        Me.LblPaidValue.Text = "0"
        Me.LblPaidValue.TabIndex = 1
        '
        'PnlBalance
        '
        Me.PnlBalance.BackColor = System.Drawing.Color.White
        Me.PnlBalance.Location = New System.Drawing.Point(448, 56)
        Me.PnlBalance.Name = "PnlBalance"
        Me.PnlBalance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlBalance.Size = New System.Drawing.Size(200, 100)
        Me.PnlBalance.TabIndex = 3
        Me.PnlBalance.Controls.Add(Me.LblBalanceTitle)
        Me.PnlBalance.Controls.Add(Me.LblBalanceValue)
        '
        'LblBalanceTitle
        '
        Me.LblBalanceTitle.AutoSize = True
        Me.LblBalanceTitle.ForeColor = System.Drawing.Color.DimGray
        Me.LblBalanceTitle.Location = New System.Drawing.Point(12, 12)
        Me.LblBalanceTitle.Name = "LblBalanceTitle"
        Me.LblBalanceTitle.Text = "Outstanding Balance"
        Me.LblBalanceTitle.TabIndex = 0
        '
        'LblBalanceValue
        '
        Me.LblBalanceValue.AutoSize = True
        Me.LblBalanceValue.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBalanceValue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.LblBalanceValue.Location = New System.Drawing.Point(10, 42)
        Me.LblBalanceValue.Name = "LblBalanceValue"
        Me.LblBalanceValue.Text = "0"
        Me.LblBalanceValue.TabIndex = 1
        '
        'LblStatus
        '
        Me.LblStatus.AutoSize = True
        Me.LblStatus.Location = New System.Drawing.Point(24, 168)
        Me.LblStatus.Name = "LblStatus"
        Me.LblStatus.Text = "Payment Status:"
        Me.LblStatus.TabIndex = 4
        '
        'CmbStatus
        '
        Me.CmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbStatus.FormattingEnabled = True
        Me.CmbStatus.Items.AddRange(New Object() {"All", "Unpaid", "Partially Paid", "Paid"})
        Me.CmbStatus.Location = New System.Drawing.Point(150, 164)
        Me.CmbStatus.Name = "CmbStatus"
        Me.CmbStatus.Size = New System.Drawing.Size(160, 28)
        Me.CmbStatus.TabIndex = 5
        '
        'MyFinesForm
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
        Me.Name = "MyFinesForm"
        Me.Text = "My Fines and Payments"
        CType(Me.DgvMyFines, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlGrid.ResumeLayout(False)
        Me.PnlGrid.PerformLayout()
        Me.PnlBottom.ResumeLayout(False)
        Me.PnlBottom.PerformLayout()
        Me.PnlHeader.ResumeLayout(False)
        Me.PnlHeader.PerformLayout()
        Me.PnlTotalFine.ResumeLayout(False)
        Me.PnlTotalFine.PerformLayout()
        Me.PnlPaid.ResumeLayout(False)
        Me.PnlPaid.PerformLayout()
        Me.PnlBalance.ResumeLayout(False)
        Me.PnlBalance.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents PnlGrid As System.Windows.Forms.Panel
    Friend WithEvents DgvMyFines As System.Windows.Forms.DataGridView
    Friend WithEvents ColFineID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColBook As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColAmount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColPaid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColBalance As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColStatus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PnlBottom As System.Windows.Forms.Panel
    Friend WithEvents BtnViewDetails As System.Windows.Forms.Button
    Friend WithEvents BtnViewPayments As System.Windows.Forms.Button
    Friend WithEvents BtnRefresh As System.Windows.Forms.Button
    Friend WithEvents LblNote As System.Windows.Forms.Label
    Friend WithEvents LblMessage As System.Windows.Forms.Label
    Friend WithEvents PnlHeader As System.Windows.Forms.Panel
    Friend WithEvents LblTitle As System.Windows.Forms.Label
    Friend WithEvents PnlTotalFine As System.Windows.Forms.Panel
    Friend WithEvents LblTotalFineTitle As System.Windows.Forms.Label
    Friend WithEvents LblTotalFineValue As System.Windows.Forms.Label
    Friend WithEvents PnlPaid As System.Windows.Forms.Panel
    Friend WithEvents LblPaidTitle As System.Windows.Forms.Label
    Friend WithEvents LblPaidValue As System.Windows.Forms.Label
    Friend WithEvents PnlBalance As System.Windows.Forms.Panel
    Friend WithEvents LblBalanceTitle As System.Windows.Forms.Label
    Friend WithEvents LblBalanceValue As System.Windows.Forms.Label
    Friend WithEvents LblStatus As System.Windows.Forms.Label
    Friend WithEvents CmbStatus As System.Windows.Forms.ComboBox

End Class
