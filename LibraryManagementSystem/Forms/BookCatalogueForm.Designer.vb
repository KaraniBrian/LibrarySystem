<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BookCatalogueForm
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
        Me.DgvBooks = New System.Windows.Forms.DataGridView()
        Me.ColId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColISBN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColTitle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColAuthor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColCategory = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColYear = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColCopies = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColAvailable = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PnlBottom = New System.Windows.Forms.Panel()
        Me.LblMessage = New System.Windows.Forms.Label()
        Me.PnlDetails = New System.Windows.Forms.Panel()
        Me.PicBookCover = New System.Windows.Forms.PictureBox()
        Me.LblBookTitle = New System.Windows.Forms.Label()
        Me.LblAuthor = New System.Windows.Forms.Label()
        Me.LblIsbn = New System.Windows.Forms.Label()
        Me.LblAvailabilityValue = New System.Windows.Forms.Label()
        Me.BtnViewDetails = New System.Windows.Forms.Button()
        Me.BtnBorrow = New System.Windows.Forms.Button()
        Me.PnlHeader = New System.Windows.Forms.Panel()
        Me.LblTitle = New System.Windows.Forms.Label()
        Me.TxtSearch = New System.Windows.Forms.TextBox()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.LblCategory = New System.Windows.Forms.Label()
        Me.CmbCategory = New System.Windows.Forms.ComboBox()
        Me.LblAvailability = New System.Windows.Forms.Label()
        Me.CmbAvailability = New System.Windows.Forms.ComboBox()
        Me.BtnClearFilters = New System.Windows.Forms.Button()
        CType(Me.DgvBooks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlGrid.SuspendLayout()
        Me.PnlBottom.SuspendLayout()
        Me.PnlDetails.SuspendLayout()
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
        Me.PnlGrid.Controls.Add(Me.DgvBooks)
        '
        'DgvBooks
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
        Me.DgvBooks.AllowUserToAddRows = False
        Me.DgvBooks.AllowUserToDeleteRows = False
        Me.DgvBooks.AllowUserToResizeRows = False
        Me.DgvBooks.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DgvBooks.AutoGenerateColumns = False
        Me.DgvBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvBooks.BackgroundColor = System.Drawing.Color.White
        Me.DgvBooks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DgvBooks.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvBooks.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColId, Me.ColISBN, Me.ColTitle, Me.ColAuthor, Me.ColCategory, Me.ColYear, Me.ColCopies, Me.ColAvailable})
        Me.DgvBooks.DefaultCellStyle = DataGridViewCellStyle3
        Me.DgvBooks.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvBooks.EnableHeadersVisualStyles = False
        Me.DgvBooks.MultiSelect = False
        Me.DgvBooks.Name = "DgvBooks"
        Me.DgvBooks.ReadOnly = True
        Me.DgvBooks.RowHeadersVisible = False
        Me.DgvBooks.RowTemplate.Height = 28
        Me.DgvBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvBooks.TabIndex = 0
        '
        'ColId
        '
        Me.ColId.DataPropertyName = "Id"
        Me.ColId.HeaderText = "Id"
        Me.ColId.Name = "ColId"
        Me.ColId.ReadOnly = True
        Me.ColId.Visible = False
        '
        'ColISBN
        '
        Me.ColISBN.DataPropertyName = "ISBN"
        Me.ColISBN.HeaderText = "ISBN"
        Me.ColISBN.Name = "ColISBN"
        Me.ColISBN.ReadOnly = True
        '
        'ColTitle
        '
        Me.ColTitle.DataPropertyName = "Title"
        Me.ColTitle.HeaderText = "Title"
        Me.ColTitle.Name = "ColTitle"
        Me.ColTitle.ReadOnly = True
        '
        'ColAuthor
        '
        Me.ColAuthor.DataPropertyName = "Author"
        Me.ColAuthor.HeaderText = "Author"
        Me.ColAuthor.Name = "ColAuthor"
        Me.ColAuthor.ReadOnly = True
        '
        'ColCategory
        '
        Me.ColCategory.DataPropertyName = "Category"
        Me.ColCategory.HeaderText = "Category"
        Me.ColCategory.Name = "ColCategory"
        Me.ColCategory.ReadOnly = True
        '
        'ColYear
        '
        Me.ColYear.DataPropertyName = "Year"
        Me.ColYear.HeaderText = "Year"
        Me.ColYear.Name = "ColYear"
        Me.ColYear.ReadOnly = True
        '
        'ColCopies
        '
        Me.ColCopies.DataPropertyName = "Copies"
        Me.ColCopies.HeaderText = "Copies"
        Me.ColCopies.Name = "ColCopies"
        Me.ColCopies.ReadOnly = True
        '
        'ColAvailable
        '
        Me.ColAvailable.DataPropertyName = "Available"
        Me.ColAvailable.HeaderText = "Available"
        Me.ColAvailable.Name = "ColAvailable"
        Me.ColAvailable.ReadOnly = True
        '
        'PnlBottom
        '
        Me.PnlBottom.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PnlBottom.Name = "PnlBottom"
        Me.PnlBottom.Size = New System.Drawing.Size(0, 34)
        Me.PnlBottom.TabIndex = 1
        Me.PnlBottom.Controls.Add(Me.LblMessage)
        '
        'LblMessage
        '
        Me.LblMessage.AutoSize = True
        Me.LblMessage.ForeColor = System.Drawing.Color.Firebrick
        Me.LblMessage.Location = New System.Drawing.Point(24, 8)
        Me.LblMessage.Name = "LblMessage"
        Me.LblMessage.Text = ""
        Me.LblMessage.TabIndex = 0
        '
        'PnlDetails
        '
        Me.PnlDetails.BackColor = System.Drawing.Color.White
        Me.PnlDetails.Dock = System.Windows.Forms.DockStyle.Right
        Me.PnlDetails.Name = "PnlDetails"
        Me.PnlDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlDetails.Size = New System.Drawing.Size(250, 0)
        Me.PnlDetails.AutoScroll = True
        Me.PnlDetails.TabIndex = 2
        Me.PnlDetails.Controls.Add(Me.PicBookCover)
        Me.PnlDetails.Controls.Add(Me.LblBookTitle)
        Me.PnlDetails.Controls.Add(Me.LblAuthor)
        Me.PnlDetails.Controls.Add(Me.LblIsbn)
        Me.PnlDetails.Controls.Add(Me.LblAvailabilityValue)
        Me.PnlDetails.Controls.Add(Me.BtnViewDetails)
        Me.PnlDetails.Controls.Add(Me.BtnBorrow)
        '
        'PicBookCover
        '
        Me.PicBookCover.Location = New System.Drawing.Point(44, 12)
        Me.PicBookCover.Name = "PicBookCover"
        Me.PicBookCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicBookCover.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PicBookCover.Size = New System.Drawing.Size(160, 200)
        Me.PicBookCover.TabIndex = 0
        '
        'LblBookTitle
        '
        Me.LblBookTitle.AutoSize = False
        Me.LblBookTitle.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBookTitle.Location = New System.Drawing.Point(12, 220)
        Me.LblBookTitle.Name = "LblBookTitle"
        Me.LblBookTitle.Size = New System.Drawing.Size(226, 44)
        Me.LblBookTitle.Text = "Select a book"
        Me.LblBookTitle.TabIndex = 1
        '
        'LblAuthor
        '
        Me.LblAuthor.AutoSize = False
        Me.LblAuthor.Location = New System.Drawing.Point(12, 268)
        Me.LblAuthor.Name = "LblAuthor"
        Me.LblAuthor.Size = New System.Drawing.Size(226, 22)
        Me.LblAuthor.Text = "Author:"
        Me.LblAuthor.TabIndex = 2
        '
        'LblIsbn
        '
        Me.LblIsbn.AutoSize = False
        Me.LblIsbn.Location = New System.Drawing.Point(12, 292)
        Me.LblIsbn.Name = "LblIsbn"
        Me.LblIsbn.Size = New System.Drawing.Size(226, 22)
        Me.LblIsbn.Text = "ISBN:"
        Me.LblIsbn.TabIndex = 3
        '
        'LblAvailabilityValue
        '
        Me.LblAvailabilityValue.AutoSize = False
        Me.LblAvailabilityValue.Location = New System.Drawing.Point(12, 316)
        Me.LblAvailabilityValue.Name = "LblAvailabilityValue"
        Me.LblAvailabilityValue.Size = New System.Drawing.Size(226, 40)
        Me.LblAvailabilityValue.Text = "Availability:"
        Me.LblAvailabilityValue.TabIndex = 4
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
        Me.BtnViewDetails.Location = New System.Drawing.Point(12, 364)
        Me.BtnViewDetails.Name = "BtnViewDetails"
        Me.BtnViewDetails.Size = New System.Drawing.Size(226, 36)
        Me.BtnViewDetails.Text = "View Details"
        Me.BtnViewDetails.UseVisualStyleBackColor = False
        Me.BtnViewDetails.TabIndex = 5
        '
        'BtnBorrow
        '
        Me.BtnBorrow.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.BtnBorrow.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnBorrow.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.BtnBorrow.FlatAppearance.BorderSize = 1
        Me.BtnBorrow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnBorrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBorrow.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBorrow.ForeColor = System.Drawing.Color.White
        Me.BtnBorrow.Enabled = False
        Me.BtnBorrow.Location = New System.Drawing.Point(12, 408)
        Me.BtnBorrow.Name = "BtnBorrow"
        Me.BtnBorrow.Size = New System.Drawing.Size(226, 36)
        Me.BtnBorrow.Text = "Borrow Book"
        Me.BtnBorrow.UseVisualStyleBackColor = False
        Me.BtnBorrow.TabIndex = 6
        '
        'PnlHeader
        '
        Me.PnlHeader.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlHeader.Name = "PnlHeader"
        Me.PnlHeader.Size = New System.Drawing.Size(0, 100)
        Me.PnlHeader.TabIndex = 3
        Me.PnlHeader.Controls.Add(Me.LblTitle)
        Me.PnlHeader.Controls.Add(Me.TxtSearch)
        Me.PnlHeader.Controls.Add(Me.BtnSearch)
        Me.PnlHeader.Controls.Add(Me.LblCategory)
        Me.PnlHeader.Controls.Add(Me.CmbCategory)
        Me.PnlHeader.Controls.Add(Me.LblAvailability)
        Me.PnlHeader.Controls.Add(Me.CmbAvailability)
        Me.PnlHeader.Controls.Add(Me.BtnClearFilters)
        '
        'LblTitle
        '
        Me.LblTitle.AutoSize = True
        Me.LblTitle.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.LblTitle.Location = New System.Drawing.Point(24, 10)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Text = "Browse Books"
        Me.LblTitle.TabIndex = 0
        '
        'TxtSearch
        '
        Me.TxtSearch.Location = New System.Drawing.Point(24, 58)
        Me.TxtSearch.MaxLength = 100
        Me.TxtSearch.Name = "TxtSearch"
        Me.TxtSearch.PlaceholderText = "Search title, author or ISBN"
        Me.TxtSearch.Size = New System.Drawing.Size(230, 27)
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
        Me.BtnSearch.Location = New System.Drawing.Point(262, 54)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(80, 34)
        Me.BtnSearch.Text = "Search"
        Me.BtnSearch.UseVisualStyleBackColor = False
        Me.BtnSearch.TabIndex = 2
        '
        'LblCategory
        '
        Me.LblCategory.AutoSize = True
        Me.LblCategory.Location = New System.Drawing.Point(354, 62)
        Me.LblCategory.Name = "LblCategory"
        Me.LblCategory.Text = "Category:"
        Me.LblCategory.TabIndex = 3
        '
        'CmbCategory
        '
        Me.CmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbCategory.FormattingEnabled = True
        Me.CmbCategory.Location = New System.Drawing.Point(424, 58)
        Me.CmbCategory.Name = "CmbCategory"
        Me.CmbCategory.Size = New System.Drawing.Size(130, 28)
        Me.CmbCategory.TabIndex = 4
        '
        'LblAvailability
        '
        Me.LblAvailability.AutoSize = True
        Me.LblAvailability.Location = New System.Drawing.Point(566, 62)
        Me.LblAvailability.Name = "LblAvailability"
        Me.LblAvailability.Text = "Availability:"
        Me.LblAvailability.TabIndex = 5
        '
        'CmbAvailability
        '
        Me.CmbAvailability.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbAvailability.FormattingEnabled = True
        Me.CmbAvailability.Items.AddRange(New Object() {"All", "Available", "Unavailable"})
        Me.CmbAvailability.Location = New System.Drawing.Point(660, 58)
        Me.CmbAvailability.Name = "CmbAvailability"
        Me.CmbAvailability.Size = New System.Drawing.Size(100, 28)
        Me.CmbAvailability.TabIndex = 6
        '
        'BtnClearFilters
        '
        Me.BtnClearFilters.BackColor = System.Drawing.Color.White
        Me.BtnClearFilters.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnClearFilters.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.BtnClearFilters.FlatAppearance.BorderSize = 1
        Me.BtnClearFilters.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.BtnClearFilters.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClearFilters.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClearFilters.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.BtnClearFilters.Location = New System.Drawing.Point(768, 54)
        Me.BtnClearFilters.Name = "BtnClearFilters"
        Me.BtnClearFilters.Size = New System.Drawing.Size(100, 34)
        Me.BtnClearFilters.Text = "Clear Filters"
        Me.BtnClearFilters.UseVisualStyleBackColor = False
        Me.BtnClearFilters.TabIndex = 7
        '
        'BookCatalogueForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScroll = True
        Me.AutoScrollMinSize = New System.Drawing.Size(860, 520)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(880, 560)
        Me.Controls.Add(Me.PnlGrid)
        Me.Controls.Add(Me.PnlBottom)
        Me.Controls.Add(Me.PnlDetails)
        Me.Controls.Add(Me.PnlHeader)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "BookCatalogueForm"
        Me.Text = "Browse Books"
        CType(Me.DgvBooks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlGrid.ResumeLayout(False)
        Me.PnlGrid.PerformLayout()
        Me.PnlBottom.ResumeLayout(False)
        Me.PnlBottom.PerformLayout()
        Me.PnlDetails.ResumeLayout(False)
        Me.PnlDetails.PerformLayout()
        Me.PnlHeader.ResumeLayout(False)
        Me.PnlHeader.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents PnlGrid As System.Windows.Forms.Panel
    Friend WithEvents DgvBooks As System.Windows.Forms.DataGridView
    Friend WithEvents ColId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColISBN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColTitle As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColAuthor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColCategory As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColYear As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColCopies As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColAvailable As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PnlBottom As System.Windows.Forms.Panel
    Friend WithEvents LblMessage As System.Windows.Forms.Label
    Friend WithEvents PnlDetails As System.Windows.Forms.Panel
    Friend WithEvents PicBookCover As System.Windows.Forms.PictureBox
    Friend WithEvents LblBookTitle As System.Windows.Forms.Label
    Friend WithEvents LblAuthor As System.Windows.Forms.Label
    Friend WithEvents LblIsbn As System.Windows.Forms.Label
    Friend WithEvents LblAvailabilityValue As System.Windows.Forms.Label
    Friend WithEvents BtnViewDetails As System.Windows.Forms.Button
    Friend WithEvents BtnBorrow As System.Windows.Forms.Button
    Friend WithEvents PnlHeader As System.Windows.Forms.Panel
    Friend WithEvents LblTitle As System.Windows.Forms.Label
    Friend WithEvents TxtSearch As System.Windows.Forms.TextBox
    Friend WithEvents BtnSearch As System.Windows.Forms.Button
    Friend WithEvents LblCategory As System.Windows.Forms.Label
    Friend WithEvents CmbCategory As System.Windows.Forms.ComboBox
    Friend WithEvents LblAvailability As System.Windows.Forms.Label
    Friend WithEvents CmbAvailability As System.Windows.Forms.ComboBox
    Friend WithEvents BtnClearFilters As System.Windows.Forms.Button

End Class
