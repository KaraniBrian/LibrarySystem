<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LibrarianHomePage
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
        Me.DgvRecentBorrowings = New System.Windows.Forms.DataGridView()
        Me.ColLoanID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColStudent = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColBook = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColIssueDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColDueDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PnlHeader = New System.Windows.Forms.Panel()
        Me.LblWelcome = New System.Windows.Forms.Label()
        Me.PnlTotalBooks = New System.Windows.Forms.Panel()
        Me.LblTotalBooksTitle = New System.Windows.Forms.Label()
        Me.LblTotalBooksValue = New System.Windows.Forms.Label()
        Me.PnlTotalStudents = New System.Windows.Forms.Panel()
        Me.LblTotalStudentsTitle = New System.Windows.Forms.Label()
        Me.LblTotalStudentsValue = New System.Windows.Forms.Label()
        Me.PnlActiveLoans = New System.Windows.Forms.Panel()
        Me.LblActiveLoansTitle = New System.Windows.Forms.Label()
        Me.LblActiveLoansValue = New System.Windows.Forms.Label()
        Me.PnlOverdueBooks = New System.Windows.Forms.Panel()
        Me.LblOverdueBooksTitle = New System.Windows.Forms.Label()
        Me.LblOverdueBooksValue = New System.Windows.Forms.Label()
        Me.LblRecentBorrowings = New System.Windows.Forms.Label()
        CType(Me.DgvRecentBorrowings, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlGrid.SuspendLayout()
        Me.PnlHeader.SuspendLayout()
        Me.PnlTotalBooks.SuspendLayout()
        Me.PnlTotalStudents.SuspendLayout()
        Me.PnlActiveLoans.SuspendLayout()
        Me.PnlOverdueBooks.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlGrid
        '
        Me.PnlGrid.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PnlGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlGrid.Name = "PnlGrid"
        Me.PnlGrid.Padding = New System.Windows.Forms.Padding(24, 0, 24, 16)
        Me.PnlGrid.TabIndex = 0
        Me.PnlGrid.Controls.Add(Me.DgvRecentBorrowings)
        '
        'DgvRecentBorrowings
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
        Me.DgvRecentBorrowings.AllowUserToAddRows = False
        Me.DgvRecentBorrowings.AllowUserToDeleteRows = False
        Me.DgvRecentBorrowings.AllowUserToResizeRows = False
        Me.DgvRecentBorrowings.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DgvRecentBorrowings.AutoGenerateColumns = False
        Me.DgvRecentBorrowings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvRecentBorrowings.BackgroundColor = System.Drawing.Color.White
        Me.DgvRecentBorrowings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DgvRecentBorrowings.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvRecentBorrowings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvRecentBorrowings.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColLoanID, Me.ColStudent, Me.ColBook, Me.ColIssueDate, Me.ColDueDate, Me.ColStatus})
        Me.DgvRecentBorrowings.DefaultCellStyle = DataGridViewCellStyle3
        Me.DgvRecentBorrowings.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvRecentBorrowings.EnableHeadersVisualStyles = False
        Me.DgvRecentBorrowings.MultiSelect = False
        Me.DgvRecentBorrowings.Name = "DgvRecentBorrowings"
        Me.DgvRecentBorrowings.ReadOnly = True
        Me.DgvRecentBorrowings.RowHeadersVisible = False
        Me.DgvRecentBorrowings.RowTemplate.Height = 28
        Me.DgvRecentBorrowings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvRecentBorrowings.TabIndex = 0
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
        'ColStatus
        '
        Me.ColStatus.DataPropertyName = "Status"
        Me.ColStatus.HeaderText = "Status"
        Me.ColStatus.Name = "ColStatus"
        Me.ColStatus.ReadOnly = True
        '
        'PnlHeader
        '
        Me.PnlHeader.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlHeader.Name = "PnlHeader"
        Me.PnlHeader.Size = New System.Drawing.Size(0, 214)
        Me.PnlHeader.TabIndex = 1
        Me.PnlHeader.Controls.Add(Me.LblWelcome)
        Me.PnlHeader.Controls.Add(Me.PnlTotalBooks)
        Me.PnlHeader.Controls.Add(Me.PnlTotalStudents)
        Me.PnlHeader.Controls.Add(Me.PnlActiveLoans)
        Me.PnlHeader.Controls.Add(Me.PnlOverdueBooks)
        Me.PnlHeader.Controls.Add(Me.LblRecentBorrowings)
        '
        'LblWelcome
        '
        Me.LblWelcome.AutoSize = True
        Me.LblWelcome.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblWelcome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.LblWelcome.Location = New System.Drawing.Point(24, 12)
        Me.LblWelcome.Name = "LblWelcome"
        Me.LblWelcome.Text = "Welcome"
        Me.LblWelcome.TabIndex = 0
        '
        'PnlTotalBooks
        '
        Me.PnlTotalBooks.BackColor = System.Drawing.Color.White
        Me.PnlTotalBooks.Location = New System.Drawing.Point(24, 60)
        Me.PnlTotalBooks.Name = "PnlTotalBooks"
        Me.PnlTotalBooks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlTotalBooks.Size = New System.Drawing.Size(200, 100)
        Me.PnlTotalBooks.TabIndex = 1
        Me.PnlTotalBooks.Controls.Add(Me.LblTotalBooksTitle)
        Me.PnlTotalBooks.Controls.Add(Me.LblTotalBooksValue)
        '
        'LblTotalBooksTitle
        '
        Me.LblTotalBooksTitle.AutoSize = True
        Me.LblTotalBooksTitle.ForeColor = System.Drawing.Color.DimGray
        Me.LblTotalBooksTitle.Location = New System.Drawing.Point(12, 12)
        Me.LblTotalBooksTitle.Name = "LblTotalBooksTitle"
        Me.LblTotalBooksTitle.Text = "Total Books"
        Me.LblTotalBooksTitle.TabIndex = 0
        '
        'LblTotalBooksValue
        '
        Me.LblTotalBooksValue.AutoSize = True
        Me.LblTotalBooksValue.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalBooksValue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.LblTotalBooksValue.Location = New System.Drawing.Point(10, 42)
        Me.LblTotalBooksValue.Name = "LblTotalBooksValue"
        Me.LblTotalBooksValue.Text = "0"
        Me.LblTotalBooksValue.TabIndex = 1
        '
        'PnlTotalStudents
        '
        Me.PnlTotalStudents.BackColor = System.Drawing.Color.White
        Me.PnlTotalStudents.Location = New System.Drawing.Point(236, 60)
        Me.PnlTotalStudents.Name = "PnlTotalStudents"
        Me.PnlTotalStudents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlTotalStudents.Size = New System.Drawing.Size(200, 100)
        Me.PnlTotalStudents.TabIndex = 2
        Me.PnlTotalStudents.Controls.Add(Me.LblTotalStudentsTitle)
        Me.PnlTotalStudents.Controls.Add(Me.LblTotalStudentsValue)
        '
        'LblTotalStudentsTitle
        '
        Me.LblTotalStudentsTitle.AutoSize = True
        Me.LblTotalStudentsTitle.ForeColor = System.Drawing.Color.DimGray
        Me.LblTotalStudentsTitle.Location = New System.Drawing.Point(12, 12)
        Me.LblTotalStudentsTitle.Name = "LblTotalStudentsTitle"
        Me.LblTotalStudentsTitle.Text = "Total Students"
        Me.LblTotalStudentsTitle.TabIndex = 0
        '
        'LblTotalStudentsValue
        '
        Me.LblTotalStudentsValue.AutoSize = True
        Me.LblTotalStudentsValue.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalStudentsValue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.LblTotalStudentsValue.Location = New System.Drawing.Point(10, 42)
        Me.LblTotalStudentsValue.Name = "LblTotalStudentsValue"
        Me.LblTotalStudentsValue.Text = "0"
        Me.LblTotalStudentsValue.TabIndex = 1
        '
        'PnlActiveLoans
        '
        Me.PnlActiveLoans.BackColor = System.Drawing.Color.White
        Me.PnlActiveLoans.Location = New System.Drawing.Point(448, 60)
        Me.PnlActiveLoans.Name = "PnlActiveLoans"
        Me.PnlActiveLoans.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlActiveLoans.Size = New System.Drawing.Size(200, 100)
        Me.PnlActiveLoans.TabIndex = 3
        Me.PnlActiveLoans.Controls.Add(Me.LblActiveLoansTitle)
        Me.PnlActiveLoans.Controls.Add(Me.LblActiveLoansValue)
        '
        'LblActiveLoansTitle
        '
        Me.LblActiveLoansTitle.AutoSize = True
        Me.LblActiveLoansTitle.ForeColor = System.Drawing.Color.DimGray
        Me.LblActiveLoansTitle.Location = New System.Drawing.Point(12, 12)
        Me.LblActiveLoansTitle.Name = "LblActiveLoansTitle"
        Me.LblActiveLoansTitle.Text = "Active Loans"
        Me.LblActiveLoansTitle.TabIndex = 0
        '
        'LblActiveLoansValue
        '
        Me.LblActiveLoansValue.AutoSize = True
        Me.LblActiveLoansValue.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblActiveLoansValue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.LblActiveLoansValue.Location = New System.Drawing.Point(10, 42)
        Me.LblActiveLoansValue.Name = "LblActiveLoansValue"
        Me.LblActiveLoansValue.Text = "0"
        Me.LblActiveLoansValue.TabIndex = 1
        '
        'PnlOverdueBooks
        '
        Me.PnlOverdueBooks.BackColor = System.Drawing.Color.White
        Me.PnlOverdueBooks.Location = New System.Drawing.Point(660, 60)
        Me.PnlOverdueBooks.Name = "PnlOverdueBooks"
        Me.PnlOverdueBooks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlOverdueBooks.Size = New System.Drawing.Size(200, 100)
        Me.PnlOverdueBooks.TabIndex = 4
        Me.PnlOverdueBooks.Controls.Add(Me.LblOverdueBooksTitle)
        Me.PnlOverdueBooks.Controls.Add(Me.LblOverdueBooksValue)
        '
        'LblOverdueBooksTitle
        '
        Me.LblOverdueBooksTitle.AutoSize = True
        Me.LblOverdueBooksTitle.ForeColor = System.Drawing.Color.DimGray
        Me.LblOverdueBooksTitle.Location = New System.Drawing.Point(12, 12)
        Me.LblOverdueBooksTitle.Name = "LblOverdueBooksTitle"
        Me.LblOverdueBooksTitle.Text = "Overdue Books"
        Me.LblOverdueBooksTitle.TabIndex = 0
        '
        'LblOverdueBooksValue
        '
        Me.LblOverdueBooksValue.AutoSize = True
        Me.LblOverdueBooksValue.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblOverdueBooksValue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.LblOverdueBooksValue.Location = New System.Drawing.Point(10, 42)
        Me.LblOverdueBooksValue.Name = "LblOverdueBooksValue"
        Me.LblOverdueBooksValue.Text = "0"
        Me.LblOverdueBooksValue.TabIndex = 1
        '
        'LblRecentBorrowings
        '
        Me.LblRecentBorrowings.AutoSize = True
        Me.LblRecentBorrowings.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRecentBorrowings.Location = New System.Drawing.Point(24, 178)
        Me.LblRecentBorrowings.Name = "LblRecentBorrowings"
        Me.LblRecentBorrowings.Text = "Recent Borrowings"
        Me.LblRecentBorrowings.TabIndex = 5
        '
        'LibrarianHomePage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScroll = True
        Me.AutoScrollMinSize = New System.Drawing.Size(860, 420)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(880, 560)
        Me.Controls.Add(Me.PnlGrid)
        Me.Controls.Add(Me.PnlHeader)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "LibrarianHomePage"
        Me.Text = "Dashboard"
        CType(Me.DgvRecentBorrowings, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlGrid.ResumeLayout(False)
        Me.PnlGrid.PerformLayout()
        Me.PnlHeader.ResumeLayout(False)
        Me.PnlHeader.PerformLayout()
        Me.PnlTotalBooks.ResumeLayout(False)
        Me.PnlTotalBooks.PerformLayout()
        Me.PnlTotalStudents.ResumeLayout(False)
        Me.PnlTotalStudents.PerformLayout()
        Me.PnlActiveLoans.ResumeLayout(False)
        Me.PnlActiveLoans.PerformLayout()
        Me.PnlOverdueBooks.ResumeLayout(False)
        Me.PnlOverdueBooks.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents PnlGrid As System.Windows.Forms.Panel
    Friend WithEvents DgvRecentBorrowings As System.Windows.Forms.DataGridView
    Friend WithEvents ColLoanID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColStudent As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColBook As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColIssueDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColDueDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColStatus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PnlHeader As System.Windows.Forms.Panel
    Friend WithEvents LblWelcome As System.Windows.Forms.Label
    Friend WithEvents PnlTotalBooks As System.Windows.Forms.Panel
    Friend WithEvents LblTotalBooksTitle As System.Windows.Forms.Label
    Friend WithEvents LblTotalBooksValue As System.Windows.Forms.Label
    Friend WithEvents PnlTotalStudents As System.Windows.Forms.Panel
    Friend WithEvents LblTotalStudentsTitle As System.Windows.Forms.Label
    Friend WithEvents LblTotalStudentsValue As System.Windows.Forms.Label
    Friend WithEvents PnlActiveLoans As System.Windows.Forms.Panel
    Friend WithEvents LblActiveLoansTitle As System.Windows.Forms.Label
    Friend WithEvents LblActiveLoansValue As System.Windows.Forms.Label
    Friend WithEvents PnlOverdueBooks As System.Windows.Forms.Panel
    Friend WithEvents LblOverdueBooksTitle As System.Windows.Forms.Label
    Friend WithEvents LblOverdueBooksValue As System.Windows.Forms.Label
    Friend WithEvents LblRecentBorrowings As System.Windows.Forms.Label

End Class
