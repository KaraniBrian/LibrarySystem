<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MyBorrowedBooksForm
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
        Me.DgvMyBooks = New System.Windows.Forms.DataGridView()
        Me.ColLoanID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColBookId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColBook = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColAuthor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColBorrowDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColDueDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColReturnDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PnlEdit = New System.Windows.Forms.Panel()
        Me.LblSelectedBook = New System.Windows.Forms.Label()
        Me.TxtSelectedBook = New System.Windows.Forms.TextBox()
        Me.LblDueDate = New System.Windows.Forms.Label()
        Me.TxtDueDate = New System.Windows.Forms.TextBox()
        Me.LblStatusValue = New System.Windows.Forms.Label()
        Me.TxtStatusValue = New System.Windows.Forms.TextBox()
        Me.BtnViewDetails = New System.Windows.Forms.Button()
        Me.BtnRequestReturn = New System.Windows.Forms.Button()
        Me.BtnRefresh = New System.Windows.Forms.Button()
        Me.LblMessage = New System.Windows.Forms.Label()
        Me.PnlHeader = New System.Windows.Forms.Panel()
        Me.LblTitle = New System.Windows.Forms.Label()
        Me.TxtSearch = New System.Windows.Forms.TextBox()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.LblStatus = New System.Windows.Forms.Label()
        Me.CmbStatus = New System.Windows.Forms.ComboBox()
        CType(Me.DgvMyBooks, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.PnlGrid.Controls.Add(Me.DgvMyBooks)
        '
        'DgvMyBooks
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
        Me.DgvMyBooks.AllowUserToAddRows = False
        Me.DgvMyBooks.AllowUserToDeleteRows = False
        Me.DgvMyBooks.AllowUserToResizeRows = False
        Me.DgvMyBooks.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DgvMyBooks.AutoGenerateColumns = False
        Me.DgvMyBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvMyBooks.BackgroundColor = System.Drawing.Color.White
        Me.DgvMyBooks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DgvMyBooks.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvMyBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvMyBooks.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColLoanID, Me.ColBookId, Me.ColBook, Me.ColAuthor, Me.ColBorrowDate, Me.ColDueDate, Me.ColReturnDate, Me.ColStatus})
        Me.DgvMyBooks.DefaultCellStyle = DataGridViewCellStyle3
        Me.DgvMyBooks.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvMyBooks.EnableHeadersVisualStyles = False
        Me.DgvMyBooks.MultiSelect = False
        Me.DgvMyBooks.Name = "DgvMyBooks"
        Me.DgvMyBooks.ReadOnly = True
        Me.DgvMyBooks.RowHeadersVisible = False
        Me.DgvMyBooks.RowTemplate.Height = 28
        Me.DgvMyBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvMyBooks.TabIndex = 0
        '
        'ColLoanID
        '
        Me.ColLoanID.DataPropertyName = "Loan ID"
        Me.ColLoanID.HeaderText = "Loan ID"
        Me.ColLoanID.Name = "ColLoanID"
        Me.ColLoanID.ReadOnly = True
        '
        'ColBookId
        '
        Me.ColBookId.DataPropertyName = "BookId"
        Me.ColBookId.HeaderText = "BookId"
        Me.ColBookId.Name = "ColBookId"
        Me.ColBookId.ReadOnly = True
        Me.ColBookId.Visible = False
        '
        'ColBook
        '
        Me.ColBook.DataPropertyName = "Book"
        Me.ColBook.HeaderText = "Book"
        Me.ColBook.Name = "ColBook"
        Me.ColBook.ReadOnly = True
        '
        'ColAuthor
        '
        Me.ColAuthor.DataPropertyName = "Author"
        Me.ColAuthor.HeaderText = "Author"
        Me.ColAuthor.Name = "ColAuthor"
        Me.ColAuthor.ReadOnly = True
        '
        'ColBorrowDate
        '
        DataGridViewCellStyle4.Format = "yyyy-MM-dd"
        Me.ColBorrowDate.DataPropertyName = "Borrow Date"
        Me.ColBorrowDate.DefaultCellStyle = DataGridViewCellStyle4
        Me.ColBorrowDate.HeaderText = "Borrow Date"
        Me.ColBorrowDate.Name = "ColBorrowDate"
        Me.ColBorrowDate.ReadOnly = True
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
        'PnlEdit
        '
        Me.PnlEdit.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PnlEdit.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PnlEdit.Name = "PnlEdit"
        Me.PnlEdit.Size = New System.Drawing.Size(0, 124)
        Me.PnlEdit.TabIndex = 1
        Me.PnlEdit.Controls.Add(Me.LblSelectedBook)
        Me.PnlEdit.Controls.Add(Me.TxtSelectedBook)
        Me.PnlEdit.Controls.Add(Me.LblDueDate)
        Me.PnlEdit.Controls.Add(Me.TxtDueDate)
        Me.PnlEdit.Controls.Add(Me.LblStatusValue)
        Me.PnlEdit.Controls.Add(Me.TxtStatusValue)
        Me.PnlEdit.Controls.Add(Me.BtnViewDetails)
        Me.PnlEdit.Controls.Add(Me.BtnRequestReturn)
        Me.PnlEdit.Controls.Add(Me.BtnRefresh)
        Me.PnlEdit.Controls.Add(Me.LblMessage)
        '
        'LblSelectedBook
        '
        Me.LblSelectedBook.AutoSize = True
        Me.LblSelectedBook.Location = New System.Drawing.Point(24, 12)
        Me.LblSelectedBook.Name = "LblSelectedBook"
        Me.LblSelectedBook.Text = "Selected Book:"
        Me.LblSelectedBook.TabIndex = 0
        '
        'TxtSelectedBook
        '
        Me.TxtSelectedBook.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TxtSelectedBook.Location = New System.Drawing.Point(136, 8)
        Me.TxtSelectedBook.Name = "TxtSelectedBook"
        Me.TxtSelectedBook.ReadOnly = True
        Me.TxtSelectedBook.Size = New System.Drawing.Size(230, 27)
        Me.TxtSelectedBook.TabIndex = 1
        '
        'LblDueDate
        '
        Me.LblDueDate.AutoSize = True
        Me.LblDueDate.Location = New System.Drawing.Point(384, 12)
        Me.LblDueDate.Name = "LblDueDate"
        Me.LblDueDate.Text = "Due Date:"
        Me.LblDueDate.TabIndex = 2
        '
        'TxtDueDate
        '
        Me.TxtDueDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TxtDueDate.Location = New System.Drawing.Point(462, 8)
        Me.TxtDueDate.Name = "TxtDueDate"
        Me.TxtDueDate.ReadOnly = True
        Me.TxtDueDate.Size = New System.Drawing.Size(120, 27)
        Me.TxtDueDate.TabIndex = 3
        '
        'LblStatusValue
        '
        Me.LblStatusValue.AutoSize = True
        Me.LblStatusValue.Location = New System.Drawing.Point(598, 12)
        Me.LblStatusValue.Name = "LblStatusValue"
        Me.LblStatusValue.Text = "Status:"
        Me.LblStatusValue.TabIndex = 4
        '
        'TxtStatusValue
        '
        Me.TxtStatusValue.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TxtStatusValue.Location = New System.Drawing.Point(660, 8)
        Me.TxtStatusValue.Name = "TxtStatusValue"
        Me.TxtStatusValue.ReadOnly = True
        Me.TxtStatusValue.Size = New System.Drawing.Size(150, 27)
        Me.TxtStatusValue.TabIndex = 5
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
        Me.BtnViewDetails.Enabled = False
        Me.BtnViewDetails.Location = New System.Drawing.Point(24, 48)
        Me.BtnViewDetails.Name = "BtnViewDetails"
        Me.BtnViewDetails.Size = New System.Drawing.Size(130, 36)
        Me.BtnViewDetails.Text = "View Details"
        Me.BtnViewDetails.UseVisualStyleBackColor = False
        Me.BtnViewDetails.TabIndex = 6
        '
        'BtnRequestReturn
        '
        Me.BtnRequestReturn.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.BtnRequestReturn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRequestReturn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.BtnRequestReturn.FlatAppearance.BorderSize = 1
        Me.BtnRequestReturn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnRequestReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRequestReturn.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRequestReturn.ForeColor = System.Drawing.Color.White
        Me.BtnRequestReturn.Enabled = False
        Me.BtnRequestReturn.Location = New System.Drawing.Point(164, 48)
        Me.BtnRequestReturn.Name = "BtnRequestReturn"
        Me.BtnRequestReturn.Size = New System.Drawing.Size(160, 36)
        Me.BtnRequestReturn.Text = "Request Return"
        Me.BtnRequestReturn.UseVisualStyleBackColor = False
        Me.BtnRequestReturn.TabIndex = 7
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
        Me.BtnRefresh.Location = New System.Drawing.Point(334, 48)
        Me.BtnRefresh.Name = "BtnRefresh"
        Me.BtnRefresh.Size = New System.Drawing.Size(90, 36)
        Me.BtnRefresh.Text = "Refresh"
        Me.BtnRefresh.UseVisualStyleBackColor = False
        Me.BtnRefresh.TabIndex = 8
        '
        'LblMessage
        '
        Me.LblMessage.AutoSize = True
        Me.LblMessage.ForeColor = System.Drawing.Color.Firebrick
        Me.LblMessage.Location = New System.Drawing.Point(24, 94)
        Me.LblMessage.Name = "LblMessage"
        Me.LblMessage.Text = ""
        Me.LblMessage.TabIndex = 9
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
        Me.LblTitle.Text = "My Borrowed Books"
        Me.LblTitle.TabIndex = 0
        '
        'TxtSearch
        '
        Me.TxtSearch.Location = New System.Drawing.Point(24, 58)
        Me.TxtSearch.MaxLength = 100
        Me.TxtSearch.Name = "TxtSearch"
        Me.TxtSearch.PlaceholderText = "Search my borrowed books"
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
        'LblStatus
        '
        Me.LblStatus.AutoSize = True
        Me.LblStatus.Location = New System.Drawing.Point(400, 62)
        Me.LblStatus.Name = "LblStatus"
        Me.LblStatus.Text = "Borrowing Status:"
        Me.LblStatus.TabIndex = 3
        '
        'CmbStatus
        '
        Me.CmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbStatus.FormattingEnabled = True
        Me.CmbStatus.Items.AddRange(New Object() {"All", "Active", "Overdue", "Return Requested", "Returned"})
        Me.CmbStatus.Location = New System.Drawing.Point(538, 58)
        Me.CmbStatus.Name = "CmbStatus"
        Me.CmbStatus.Size = New System.Drawing.Size(150, 28)
        Me.CmbStatus.TabIndex = 4
        '
        'MyBorrowedBooksForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScroll = True
        Me.AutoScrollMinSize = New System.Drawing.Size(860, 500)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(880, 560)
        Me.Controls.Add(Me.PnlGrid)
        Me.Controls.Add(Me.PnlEdit)
        Me.Controls.Add(Me.PnlHeader)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "MyBorrowedBooksForm"
        Me.Text = "My Borrowed Books"
        CType(Me.DgvMyBooks, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents DgvMyBooks As System.Windows.Forms.DataGridView
    Friend WithEvents ColLoanID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColBookId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColBook As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColAuthor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColBorrowDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColDueDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColReturnDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColStatus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PnlEdit As System.Windows.Forms.Panel
    Friend WithEvents LblSelectedBook As System.Windows.Forms.Label
    Friend WithEvents TxtSelectedBook As System.Windows.Forms.TextBox
    Friend WithEvents LblDueDate As System.Windows.Forms.Label
    Friend WithEvents TxtDueDate As System.Windows.Forms.TextBox
    Friend WithEvents LblStatusValue As System.Windows.Forms.Label
    Friend WithEvents TxtStatusValue As System.Windows.Forms.TextBox
    Friend WithEvents BtnViewDetails As System.Windows.Forms.Button
    Friend WithEvents BtnRequestReturn As System.Windows.Forms.Button
    Friend WithEvents BtnRefresh As System.Windows.Forms.Button
    Friend WithEvents LblMessage As System.Windows.Forms.Label
    Friend WithEvents PnlHeader As System.Windows.Forms.Panel
    Friend WithEvents LblTitle As System.Windows.Forms.Label
    Friend WithEvents TxtSearch As System.Windows.Forms.TextBox
    Friend WithEvents BtnSearch As System.Windows.Forms.Button
    Friend WithEvents LblStatus As System.Windows.Forms.Label
    Friend WithEvents CmbStatus As System.Windows.Forms.ComboBox

End Class
