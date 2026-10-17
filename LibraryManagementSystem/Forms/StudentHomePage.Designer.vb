<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentHomePage
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
        Me.DgvMyBorrowings = New System.Windows.Forms.DataGridView()
        Me.ColLoanID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColBook = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColBorrowDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColDueDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PnlHeader = New System.Windows.Forms.Panel()
        Me.LblWelcome = New System.Windows.Forms.Label()
        Me.PnlBorrowedBooks = New System.Windows.Forms.Panel()
        Me.LblBorrowedBooksTitle = New System.Windows.Forms.Label()
        Me.LblBorrowedBooksValue = New System.Windows.Forms.Label()
        Me.PnlDueSoon = New System.Windows.Forms.Panel()
        Me.LblDueSoonTitle = New System.Windows.Forms.Label()
        Me.LblDueSoonValue = New System.Windows.Forms.Label()
        Me.PnlOverdue = New System.Windows.Forms.Panel()
        Me.LblOverdueTitle = New System.Windows.Forms.Label()
        Me.LblOverdueValue = New System.Windows.Forms.Label()
        Me.PnlFineBalance = New System.Windows.Forms.Panel()
        Me.LblFineBalanceTitle = New System.Windows.Forms.Label()
        Me.LblFineBalanceValue = New System.Windows.Forms.Label()
        Me.LblRecentBorrowings = New System.Windows.Forms.Label()
        CType(Me.DgvMyBorrowings, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlGrid.SuspendLayout()
        Me.PnlHeader.SuspendLayout()
        Me.PnlBorrowedBooks.SuspendLayout()
        Me.PnlDueSoon.SuspendLayout()
        Me.PnlOverdue.SuspendLayout()
        Me.PnlFineBalance.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlGrid
        '
        Me.PnlGrid.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PnlGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlGrid.Name = "PnlGrid"
        Me.PnlGrid.Padding = New System.Windows.Forms.Padding(24, 0, 24, 16)
        Me.PnlGrid.TabIndex = 0
        Me.PnlGrid.Controls.Add(Me.DgvMyBorrowings)
        '
        'DgvMyBorrowings
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
        Me.DgvMyBorrowings.AllowUserToAddRows = False
        Me.DgvMyBorrowings.AllowUserToDeleteRows = False
        Me.DgvMyBorrowings.AllowUserToResizeRows = False
        Me.DgvMyBorrowings.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DgvMyBorrowings.AutoGenerateColumns = False
        Me.DgvMyBorrowings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvMyBorrowings.BackgroundColor = System.Drawing.Color.White
        Me.DgvMyBorrowings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DgvMyBorrowings.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvMyBorrowings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvMyBorrowings.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColLoanID, Me.ColBook, Me.ColBorrowDate, Me.ColDueDate, Me.ColStatus})
        Me.DgvMyBorrowings.DefaultCellStyle = DataGridViewCellStyle3
        Me.DgvMyBorrowings.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvMyBorrowings.EnableHeadersVisualStyles = False
        Me.DgvMyBorrowings.MultiSelect = False
        Me.DgvMyBorrowings.Name = "DgvMyBorrowings"
        Me.DgvMyBorrowings.ReadOnly = True
        Me.DgvMyBorrowings.RowHeadersVisible = False
        Me.DgvMyBorrowings.RowTemplate.Height = 28
        Me.DgvMyBorrowings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvMyBorrowings.TabIndex = 0
        '
        'ColLoanID
        '
        Me.ColLoanID.DataPropertyName = "Loan ID"
        Me.ColLoanID.HeaderText = "Loan ID"
        Me.ColLoanID.Name = "ColLoanID"
        Me.ColLoanID.ReadOnly = True
        '
        'ColBook
        '
        Me.ColBook.DataPropertyName = "Book"
        Me.ColBook.HeaderText = "Book"
        Me.ColBook.Name = "ColBook"
        Me.ColBook.ReadOnly = True
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
        Me.PnlHeader.Controls.Add(Me.PnlBorrowedBooks)
        Me.PnlHeader.Controls.Add(Me.PnlDueSoon)
        Me.PnlHeader.Controls.Add(Me.PnlOverdue)
        Me.PnlHeader.Controls.Add(Me.PnlFineBalance)
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
        'PnlBorrowedBooks
        '
        Me.PnlBorrowedBooks.BackColor = System.Drawing.Color.White
        Me.PnlBorrowedBooks.Location = New System.Drawing.Point(24, 60)
        Me.PnlBorrowedBooks.Name = "PnlBorrowedBooks"
        Me.PnlBorrowedBooks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlBorrowedBooks.Size = New System.Drawing.Size(200, 100)
        Me.PnlBorrowedBooks.TabIndex = 1
        Me.PnlBorrowedBooks.Controls.Add(Me.LblBorrowedBooksTitle)
        Me.PnlBorrowedBooks.Controls.Add(Me.LblBorrowedBooksValue)
        '
        'LblBorrowedBooksTitle
        '
        Me.LblBorrowedBooksTitle.AutoSize = True
        Me.LblBorrowedBooksTitle.ForeColor = System.Drawing.Color.DimGray
        Me.LblBorrowedBooksTitle.Location = New System.Drawing.Point(12, 12)
        Me.LblBorrowedBooksTitle.Name = "LblBorrowedBooksTitle"
        Me.LblBorrowedBooksTitle.Text = "My Borrowed Books"
        Me.LblBorrowedBooksTitle.TabIndex = 0
        '
        'LblBorrowedBooksValue
        '
        Me.LblBorrowedBooksValue.AutoSize = True
        Me.LblBorrowedBooksValue.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBorrowedBooksValue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.LblBorrowedBooksValue.Location = New System.Drawing.Point(10, 42)
        Me.LblBorrowedBooksValue.Name = "LblBorrowedBooksValue"
        Me.LblBorrowedBooksValue.Text = "0"
        Me.LblBorrowedBooksValue.TabIndex = 1
        '
        'PnlDueSoon
        '
        Me.PnlDueSoon.BackColor = System.Drawing.Color.White
        Me.PnlDueSoon.Location = New System.Drawing.Point(236, 60)
        Me.PnlDueSoon.Name = "PnlDueSoon"
        Me.PnlDueSoon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlDueSoon.Size = New System.Drawing.Size(200, 100)
        Me.PnlDueSoon.TabIndex = 2
        Me.PnlDueSoon.Controls.Add(Me.LblDueSoonTitle)
        Me.PnlDueSoon.Controls.Add(Me.LblDueSoonValue)
        '
        'LblDueSoonTitle
        '
        Me.LblDueSoonTitle.AutoSize = True
        Me.LblDueSoonTitle.ForeColor = System.Drawing.Color.DimGray
        Me.LblDueSoonTitle.Location = New System.Drawing.Point(12, 12)
        Me.LblDueSoonTitle.Name = "LblDueSoonTitle"
        Me.LblDueSoonTitle.Text = "Books Due Soon"
        Me.LblDueSoonTitle.TabIndex = 0
        '
        'LblDueSoonValue
        '
        Me.LblDueSoonValue.AutoSize = True
        Me.LblDueSoonValue.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDueSoonValue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.LblDueSoonValue.Location = New System.Drawing.Point(10, 42)
        Me.LblDueSoonValue.Name = "LblDueSoonValue"
        Me.LblDueSoonValue.Text = "0"
        Me.LblDueSoonValue.TabIndex = 1
        '
        'PnlOverdue
        '
        Me.PnlOverdue.BackColor = System.Drawing.Color.White
        Me.PnlOverdue.Location = New System.Drawing.Point(448, 60)
        Me.PnlOverdue.Name = "PnlOverdue"
        Me.PnlOverdue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlOverdue.Size = New System.Drawing.Size(200, 100)
        Me.PnlOverdue.TabIndex = 3
        Me.PnlOverdue.Controls.Add(Me.LblOverdueTitle)
        Me.PnlOverdue.Controls.Add(Me.LblOverdueValue)
        '
        'LblOverdueTitle
        '
        Me.LblOverdueTitle.AutoSize = True
        Me.LblOverdueTitle.ForeColor = System.Drawing.Color.DimGray
        Me.LblOverdueTitle.Location = New System.Drawing.Point(12, 12)
        Me.LblOverdueTitle.Name = "LblOverdueTitle"
        Me.LblOverdueTitle.Text = "Overdue Books"
        Me.LblOverdueTitle.TabIndex = 0
        '
        'LblOverdueValue
        '
        Me.LblOverdueValue.AutoSize = True
        Me.LblOverdueValue.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblOverdueValue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.LblOverdueValue.Location = New System.Drawing.Point(10, 42)
        Me.LblOverdueValue.Name = "LblOverdueValue"
        Me.LblOverdueValue.Text = "0"
        Me.LblOverdueValue.TabIndex = 1
        '
        'PnlFineBalance
        '
        Me.PnlFineBalance.BackColor = System.Drawing.Color.White
        Me.PnlFineBalance.Location = New System.Drawing.Point(660, 60)
        Me.PnlFineBalance.Name = "PnlFineBalance"
        Me.PnlFineBalance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlFineBalance.Size = New System.Drawing.Size(200, 100)
        Me.PnlFineBalance.TabIndex = 4
        Me.PnlFineBalance.Controls.Add(Me.LblFineBalanceTitle)
        Me.PnlFineBalance.Controls.Add(Me.LblFineBalanceValue)
        '
        'LblFineBalanceTitle
        '
        Me.LblFineBalanceTitle.AutoSize = True
        Me.LblFineBalanceTitle.ForeColor = System.Drawing.Color.DimGray
        Me.LblFineBalanceTitle.Location = New System.Drawing.Point(12, 12)
        Me.LblFineBalanceTitle.Name = "LblFineBalanceTitle"
        Me.LblFineBalanceTitle.Text = "Outstanding Fine"
        Me.LblFineBalanceTitle.TabIndex = 0
        '
        'LblFineBalanceValue
        '
        Me.LblFineBalanceValue.AutoSize = True
        Me.LblFineBalanceValue.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFineBalanceValue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.LblFineBalanceValue.Location = New System.Drawing.Point(10, 42)
        Me.LblFineBalanceValue.Name = "LblFineBalanceValue"
        Me.LblFineBalanceValue.Text = "0"
        Me.LblFineBalanceValue.TabIndex = 1
        '
        'LblRecentBorrowings
        '
        Me.LblRecentBorrowings.AutoSize = True
        Me.LblRecentBorrowings.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRecentBorrowings.Location = New System.Drawing.Point(24, 178)
        Me.LblRecentBorrowings.Name = "LblRecentBorrowings"
        Me.LblRecentBorrowings.Text = "My Recent Borrowings"
        Me.LblRecentBorrowings.TabIndex = 5
        '
        'StudentHomePage
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
        Me.Name = "StudentHomePage"
        Me.Text = "Dashboard"
        CType(Me.DgvMyBorrowings, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlGrid.ResumeLayout(False)
        Me.PnlGrid.PerformLayout()
        Me.PnlHeader.ResumeLayout(False)
        Me.PnlHeader.PerformLayout()
        Me.PnlBorrowedBooks.ResumeLayout(False)
        Me.PnlBorrowedBooks.PerformLayout()
        Me.PnlDueSoon.ResumeLayout(False)
        Me.PnlDueSoon.PerformLayout()
        Me.PnlOverdue.ResumeLayout(False)
        Me.PnlOverdue.PerformLayout()
        Me.PnlFineBalance.ResumeLayout(False)
        Me.PnlFineBalance.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents PnlGrid As System.Windows.Forms.Panel
    Friend WithEvents DgvMyBorrowings As System.Windows.Forms.DataGridView
    Friend WithEvents ColLoanID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColBook As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColBorrowDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColDueDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColStatus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PnlHeader As System.Windows.Forms.Panel
    Friend WithEvents LblWelcome As System.Windows.Forms.Label
    Friend WithEvents PnlBorrowedBooks As System.Windows.Forms.Panel
    Friend WithEvents LblBorrowedBooksTitle As System.Windows.Forms.Label
    Friend WithEvents LblBorrowedBooksValue As System.Windows.Forms.Label
    Friend WithEvents PnlDueSoon As System.Windows.Forms.Panel
    Friend WithEvents LblDueSoonTitle As System.Windows.Forms.Label
    Friend WithEvents LblDueSoonValue As System.Windows.Forms.Label
    Friend WithEvents PnlOverdue As System.Windows.Forms.Panel
    Friend WithEvents LblOverdueTitle As System.Windows.Forms.Label
    Friend WithEvents LblOverdueValue As System.Windows.Forms.Label
    Friend WithEvents PnlFineBalance As System.Windows.Forms.Panel
    Friend WithEvents LblFineBalanceTitle As System.Windows.Forms.Label
    Friend WithEvents LblFineBalanceValue As System.Windows.Forms.Label
    Friend WithEvents LblRecentBorrowings As System.Windows.Forms.Label

End Class
