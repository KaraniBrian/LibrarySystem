<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReturnBookForm
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
        Me.PnlGrid = New System.Windows.Forms.Panel()
        Me.DgvBorrowedBooks = New System.Windows.Forms.DataGridView()
        Me.ColLoanID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColStudent = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColAdmissionNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColBook = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColCopy = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColIssueDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColDueDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PnlEdit = New System.Windows.Forms.Panel()
        Me.LblStudent = New System.Windows.Forms.Label()
        Me.TxtStudent = New System.Windows.Forms.TextBox()
        Me.LblBook = New System.Windows.Forms.Label()
        Me.TxtBook = New System.Windows.Forms.TextBox()
        Me.LblIssueDate = New System.Windows.Forms.Label()
        Me.TxtIssueDate = New System.Windows.Forms.TextBox()
        Me.LblDueDate = New System.Windows.Forms.Label()
        Me.TxtDueDate = New System.Windows.Forms.TextBox()
        Me.LblReturnDate = New System.Windows.Forms.Label()
        Me.DtpReturnDate = New System.Windows.Forms.DateTimePicker()
        Me.LblFine = New System.Windows.Forms.Label()
        Me.TxtFine = New System.Windows.Forms.TextBox()
        Me.BtnCalculateFine = New System.Windows.Forms.Button()
        Me.BtnProcessReturn = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.LblMessage = New System.Windows.Forms.Label()
        Me.PnlHeader = New System.Windows.Forms.Panel()
        Me.LblTitle = New System.Windows.Forms.Label()
        Me.LblSearch = New System.Windows.Forms.Label()
        Me.TxtSearch = New System.Windows.Forms.TextBox()
        Me.BtnSearch = New System.Windows.Forms.Button()
        CType(Me.DgvBorrowedBooks, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.PnlGrid.Controls.Add(Me.DgvBorrowedBooks)
        '
        'DgvBorrowedBooks
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
        Me.DgvBorrowedBooks.AllowUserToAddRows = False
        Me.DgvBorrowedBooks.AllowUserToDeleteRows = False
        Me.DgvBorrowedBooks.AllowUserToResizeRows = False
        Me.DgvBorrowedBooks.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DgvBorrowedBooks.AutoGenerateColumns = False
        Me.DgvBorrowedBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvBorrowedBooks.BackgroundColor = System.Drawing.Color.White
        Me.DgvBorrowedBooks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DgvBorrowedBooks.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvBorrowedBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvBorrowedBooks.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColLoanID, Me.ColStudent, Me.ColAdmissionNo, Me.ColBook, Me.ColCopy, Me.ColIssueDate, Me.ColDueDate, Me.ColStatus})
        Me.DgvBorrowedBooks.DefaultCellStyle = DataGridViewCellStyle3
        Me.DgvBorrowedBooks.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvBorrowedBooks.EnableHeadersVisualStyles = False
        Me.DgvBorrowedBooks.MultiSelect = False
        Me.DgvBorrowedBooks.Name = "DgvBorrowedBooks"
        Me.DgvBorrowedBooks.ReadOnly = True
        Me.DgvBorrowedBooks.RowHeadersVisible = False
        Me.DgvBorrowedBooks.RowTemplate.Height = 28
        Me.DgvBorrowedBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvBorrowedBooks.TabIndex = 0
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
        'ColCopy
        '
        Me.ColCopy.DataPropertyName = "Copy"
        Me.ColCopy.HeaderText = "Copy"
        Me.ColCopy.Name = "ColCopy"
        Me.ColCopy.ReadOnly = True
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
        Me.PnlEdit.Size = New System.Drawing.Size(0, 204)
        Me.PnlEdit.TabIndex = 1
        Me.PnlEdit.Controls.Add(Me.LblStudent)
        Me.PnlEdit.Controls.Add(Me.TxtStudent)
        Me.PnlEdit.Controls.Add(Me.LblBook)
        Me.PnlEdit.Controls.Add(Me.TxtBook)
        Me.PnlEdit.Controls.Add(Me.LblIssueDate)
        Me.PnlEdit.Controls.Add(Me.TxtIssueDate)
        Me.PnlEdit.Controls.Add(Me.LblDueDate)
        Me.PnlEdit.Controls.Add(Me.TxtDueDate)
        Me.PnlEdit.Controls.Add(Me.LblReturnDate)
        Me.PnlEdit.Controls.Add(Me.DtpReturnDate)
        Me.PnlEdit.Controls.Add(Me.LblFine)
        Me.PnlEdit.Controls.Add(Me.TxtFine)
        Me.PnlEdit.Controls.Add(Me.BtnCalculateFine)
        Me.PnlEdit.Controls.Add(Me.BtnProcessReturn)
        Me.PnlEdit.Controls.Add(Me.BtnCancel)
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
        'LblBook
        '
        Me.LblBook.AutoSize = True
        Me.LblBook.Location = New System.Drawing.Point(444, 12)
        Me.LblBook.Name = "LblBook"
        Me.LblBook.Text = "Book:"
        Me.LblBook.TabIndex = 2
        '
        'TxtBook
        '
        Me.TxtBook.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TxtBook.Location = New System.Drawing.Point(574, 8)
        Me.TxtBook.Name = "TxtBook"
        Me.TxtBook.ReadOnly = True
        Me.TxtBook.Size = New System.Drawing.Size(270, 27)
        Me.TxtBook.TabIndex = 3
        '
        'LblIssueDate
        '
        Me.LblIssueDate.AutoSize = True
        Me.LblIssueDate.Location = New System.Drawing.Point(24, 48)
        Me.LblIssueDate.Name = "LblIssueDate"
        Me.LblIssueDate.Text = "Issue Date:"
        Me.LblIssueDate.TabIndex = 4
        '
        'TxtIssueDate
        '
        Me.TxtIssueDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TxtIssueDate.Location = New System.Drawing.Point(154, 44)
        Me.TxtIssueDate.Name = "TxtIssueDate"
        Me.TxtIssueDate.ReadOnly = True
        Me.TxtIssueDate.Size = New System.Drawing.Size(270, 27)
        Me.TxtIssueDate.TabIndex = 5
        '
        'LblDueDate
        '
        Me.LblDueDate.AutoSize = True
        Me.LblDueDate.Location = New System.Drawing.Point(444, 48)
        Me.LblDueDate.Name = "LblDueDate"
        Me.LblDueDate.Text = "Due Date:"
        Me.LblDueDate.TabIndex = 6
        '
        'TxtDueDate
        '
        Me.TxtDueDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TxtDueDate.Location = New System.Drawing.Point(574, 44)
        Me.TxtDueDate.Name = "TxtDueDate"
        Me.TxtDueDate.ReadOnly = True
        Me.TxtDueDate.Size = New System.Drawing.Size(270, 27)
        Me.TxtDueDate.TabIndex = 7
        '
        'LblReturnDate
        '
        Me.LblReturnDate.AutoSize = True
        Me.LblReturnDate.Location = New System.Drawing.Point(24, 84)
        Me.LblReturnDate.Name = "LblReturnDate"
        Me.LblReturnDate.Text = "Return Date:"
        Me.LblReturnDate.TabIndex = 8
        '
        'DtpReturnDate
        '
        Me.DtpReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DtpReturnDate.Location = New System.Drawing.Point(154, 80)
        Me.DtpReturnDate.Name = "DtpReturnDate"
        Me.DtpReturnDate.Size = New System.Drawing.Size(150, 27)
        Me.DtpReturnDate.TabIndex = 9
        '
        'LblFine
        '
        Me.LblFine.AutoSize = True
        Me.LblFine.Location = New System.Drawing.Point(444, 84)
        Me.LblFine.Name = "LblFine"
        Me.LblFine.Text = "Fine Amount:"
        Me.LblFine.TabIndex = 10
        '
        'TxtFine
        '
        Me.TxtFine.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TxtFine.Location = New System.Drawing.Point(574, 80)
        Me.TxtFine.Name = "TxtFine"
        Me.TxtFine.ReadOnly = True
        Me.TxtFine.Size = New System.Drawing.Size(270, 27)
        Me.TxtFine.TabIndex = 11
        '
        'BtnCalculateFine
        '
        Me.BtnCalculateFine.BackColor = System.Drawing.Color.White
        Me.BtnCalculateFine.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCalculateFine.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.BtnCalculateFine.FlatAppearance.BorderSize = 1
        Me.BtnCalculateFine.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.BtnCalculateFine.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCalculateFine.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCalculateFine.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.BtnCalculateFine.Enabled = False
        Me.BtnCalculateFine.Location = New System.Drawing.Point(24, 124)
        Me.BtnCalculateFine.Name = "BtnCalculateFine"
        Me.BtnCalculateFine.Size = New System.Drawing.Size(150, 36)
        Me.BtnCalculateFine.Text = "Calculate Fine"
        Me.BtnCalculateFine.UseVisualStyleBackColor = False
        Me.BtnCalculateFine.TabIndex = 12
        '
        'BtnProcessReturn
        '
        Me.BtnProcessReturn.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.BtnProcessReturn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnProcessReturn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.BtnProcessReturn.FlatAppearance.BorderSize = 1
        Me.BtnProcessReturn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnProcessReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnProcessReturn.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnProcessReturn.ForeColor = System.Drawing.Color.White
        Me.BtnProcessReturn.Enabled = False
        Me.BtnProcessReturn.Location = New System.Drawing.Point(184, 124)
        Me.BtnProcessReturn.Name = "BtnProcessReturn"
        Me.BtnProcessReturn.Size = New System.Drawing.Size(160, 36)
        Me.BtnProcessReturn.Text = "Confirm Return"
        Me.BtnProcessReturn.UseVisualStyleBackColor = False
        Me.BtnProcessReturn.TabIndex = 13
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
        Me.BtnCancel.Location = New System.Drawing.Point(354, 124)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(100, 36)
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = False
        Me.BtnCancel.TabIndex = 14
        '
        'LblMessage
        '
        Me.LblMessage.AutoSize = True
        Me.LblMessage.ForeColor = System.Drawing.Color.Firebrick
        Me.LblMessage.Location = New System.Drawing.Point(24, 170)
        Me.LblMessage.Name = "LblMessage"
        Me.LblMessage.Text = ""
        Me.LblMessage.TabIndex = 15
        '
        'PnlHeader
        '
        Me.PnlHeader.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlHeader.Name = "PnlHeader"
        Me.PnlHeader.Size = New System.Drawing.Size(0, 100)
        Me.PnlHeader.TabIndex = 2
        Me.PnlHeader.Controls.Add(Me.LblTitle)
        Me.PnlHeader.Controls.Add(Me.LblSearch)
        Me.PnlHeader.Controls.Add(Me.TxtSearch)
        Me.PnlHeader.Controls.Add(Me.BtnSearch)
        '
        'LblTitle
        '
        Me.LblTitle.AutoSize = True
        Me.LblTitle.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.LblTitle.Location = New System.Drawing.Point(24, 10)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Text = "Process Book Returns"
        Me.LblTitle.TabIndex = 0
        '
        'LblSearch
        '
        Me.LblSearch.AutoSize = True
        Me.LblSearch.Location = New System.Drawing.Point(24, 62)
        Me.LblSearch.Name = "LblSearch"
        Me.LblSearch.Text = "Search Loan:"
        Me.LblSearch.TabIndex = 1
        '
        'TxtSearch
        '
        Me.TxtSearch.Location = New System.Drawing.Point(130, 58)
        Me.TxtSearch.MaxLength = 100
        Me.TxtSearch.Name = "TxtSearch"
        Me.TxtSearch.PlaceholderText = "Student name, admission number or loan ID"
        Me.TxtSearch.Size = New System.Drawing.Size(340, 27)
        Me.TxtSearch.TabIndex = 2
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
        Me.BtnSearch.Location = New System.Drawing.Point(480, 54)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(90, 34)
        Me.BtnSearch.Text = "Search"
        Me.BtnSearch.UseVisualStyleBackColor = False
        Me.BtnSearch.TabIndex = 3
        '
        'ReturnBookForm
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
        Me.Name = "ReturnBookForm"
        Me.Text = "Process Book Returns"
        CType(Me.DgvBorrowedBooks, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents DgvBorrowedBooks As System.Windows.Forms.DataGridView
    Friend WithEvents ColLoanID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColStudent As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColAdmissionNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColBook As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColCopy As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColIssueDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColDueDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColStatus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PnlEdit As System.Windows.Forms.Panel
    Friend WithEvents LblStudent As System.Windows.Forms.Label
    Friend WithEvents TxtStudent As System.Windows.Forms.TextBox
    Friend WithEvents LblBook As System.Windows.Forms.Label
    Friend WithEvents TxtBook As System.Windows.Forms.TextBox
    Friend WithEvents LblIssueDate As System.Windows.Forms.Label
    Friend WithEvents TxtIssueDate As System.Windows.Forms.TextBox
    Friend WithEvents LblDueDate As System.Windows.Forms.Label
    Friend WithEvents TxtDueDate As System.Windows.Forms.TextBox
    Friend WithEvents LblReturnDate As System.Windows.Forms.Label
    Friend WithEvents DtpReturnDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents LblFine As System.Windows.Forms.Label
    Friend WithEvents TxtFine As System.Windows.Forms.TextBox
    Friend WithEvents BtnCalculateFine As System.Windows.Forms.Button
    Friend WithEvents BtnProcessReturn As System.Windows.Forms.Button
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents LblMessage As System.Windows.Forms.Label
    Friend WithEvents PnlHeader As System.Windows.Forms.Panel
    Friend WithEvents LblTitle As System.Windows.Forms.Label
    Friend WithEvents LblSearch As System.Windows.Forms.Label
    Friend WithEvents TxtSearch As System.Windows.Forms.TextBox
    Friend WithEvents BtnSearch As System.Windows.Forms.Button

End Class
