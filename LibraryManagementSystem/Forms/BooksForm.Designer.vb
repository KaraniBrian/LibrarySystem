<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BooksForm
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
        Me.ColPublisher = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColYear = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColCopies = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColAvailable = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PnlEdit = New System.Windows.Forms.Panel()
        Me.LblIsbn = New System.Windows.Forms.Label()
        Me.TxtIsbn = New System.Windows.Forms.TextBox()
        Me.LblBookTitle = New System.Windows.Forms.Label()
        Me.TxtBookTitle = New System.Windows.Forms.TextBox()
        Me.LblAuthor = New System.Windows.Forms.Label()
        Me.TxtAuthor = New System.Windows.Forms.TextBox()
        Me.LblCategory = New System.Windows.Forms.Label()
        Me.CmbCategory = New System.Windows.Forms.ComboBox()
        Me.LblPublisher = New System.Windows.Forms.Label()
        Me.TxtPublisher = New System.Windows.Forms.TextBox()
        Me.LblYear = New System.Windows.Forms.Label()
        Me.NudYear = New System.Windows.Forms.NumericUpDown()
        Me.LblCopies = New System.Windows.Forms.Label()
        Me.NudCopies = New System.Windows.Forms.NumericUpDown()
        Me.LblDescription = New System.Windows.Forms.Label()
        Me.TxtDescription = New System.Windows.Forms.TextBox()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.LblMessage = New System.Windows.Forms.Label()
        Me.PnlHeader = New System.Windows.Forms.Panel()
        Me.LblTitle = New System.Windows.Forms.Label()
        Me.LblSearch = New System.Windows.Forms.Label()
        Me.TxtSearch = New System.Windows.Forms.TextBox()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.BtnRefresh = New System.Windows.Forms.Button()
        CType(Me.DgvBooks, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.DgvBooks.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColId, Me.ColISBN, Me.ColTitle, Me.ColAuthor, Me.ColCategory, Me.ColPublisher, Me.ColYear, Me.ColCopies, Me.ColAvailable})
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
        'ColPublisher
        '
        Me.ColPublisher.DataPropertyName = "Publisher"
        Me.ColPublisher.HeaderText = "Publisher"
        Me.ColPublisher.Name = "ColPublisher"
        Me.ColPublisher.ReadOnly = True
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
        'PnlEdit
        '
        Me.PnlEdit.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PnlEdit.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PnlEdit.Name = "PnlEdit"
        Me.PnlEdit.Size = New System.Drawing.Size(0, 250)
        Me.PnlEdit.TabIndex = 1
        Me.PnlEdit.Controls.Add(Me.LblIsbn)
        Me.PnlEdit.Controls.Add(Me.TxtIsbn)
        Me.PnlEdit.Controls.Add(Me.LblBookTitle)
        Me.PnlEdit.Controls.Add(Me.TxtBookTitle)
        Me.PnlEdit.Controls.Add(Me.LblAuthor)
        Me.PnlEdit.Controls.Add(Me.TxtAuthor)
        Me.PnlEdit.Controls.Add(Me.LblCategory)
        Me.PnlEdit.Controls.Add(Me.CmbCategory)
        Me.PnlEdit.Controls.Add(Me.LblPublisher)
        Me.PnlEdit.Controls.Add(Me.TxtPublisher)
        Me.PnlEdit.Controls.Add(Me.LblYear)
        Me.PnlEdit.Controls.Add(Me.NudYear)
        Me.PnlEdit.Controls.Add(Me.LblCopies)
        Me.PnlEdit.Controls.Add(Me.NudCopies)
        Me.PnlEdit.Controls.Add(Me.LblDescription)
        Me.PnlEdit.Controls.Add(Me.TxtDescription)
        Me.PnlEdit.Controls.Add(Me.BtnAdd)
        Me.PnlEdit.Controls.Add(Me.BtnUpdate)
        Me.PnlEdit.Controls.Add(Me.BtnDelete)
        Me.PnlEdit.Controls.Add(Me.BtnClear)
        Me.PnlEdit.Controls.Add(Me.LblMessage)
        '
        'LblIsbn
        '
        Me.LblIsbn.AutoSize = True
        Me.LblIsbn.Location = New System.Drawing.Point(24, 12)
        Me.LblIsbn.Name = "LblIsbn"
        Me.LblIsbn.Text = "ISBN:"
        Me.LblIsbn.TabIndex = 0
        '
        'TxtIsbn
        '
        Me.TxtIsbn.Location = New System.Drawing.Point(154, 8)
        Me.TxtIsbn.MaxLength = 20
        Me.TxtIsbn.Name = "TxtIsbn"
        Me.TxtIsbn.Size = New System.Drawing.Size(270, 27)
        Me.TxtIsbn.TabIndex = 1
        '
        'LblBookTitle
        '
        Me.LblBookTitle.AutoSize = True
        Me.LblBookTitle.Location = New System.Drawing.Point(444, 12)
        Me.LblBookTitle.Name = "LblBookTitle"
        Me.LblBookTitle.Text = "Book Title:"
        Me.LblBookTitle.TabIndex = 2
        '
        'TxtBookTitle
        '
        Me.TxtBookTitle.Location = New System.Drawing.Point(574, 8)
        Me.TxtBookTitle.MaxLength = 255
        Me.TxtBookTitle.Name = "TxtBookTitle"
        Me.TxtBookTitle.Size = New System.Drawing.Size(270, 27)
        Me.TxtBookTitle.TabIndex = 3
        '
        'LblAuthor
        '
        Me.LblAuthor.AutoSize = True
        Me.LblAuthor.Location = New System.Drawing.Point(24, 48)
        Me.LblAuthor.Name = "LblAuthor"
        Me.LblAuthor.Text = "Author:"
        Me.LblAuthor.TabIndex = 4
        '
        'TxtAuthor
        '
        Me.TxtAuthor.Location = New System.Drawing.Point(154, 44)
        Me.TxtAuthor.MaxLength = 150
        Me.TxtAuthor.Name = "TxtAuthor"
        Me.TxtAuthor.Size = New System.Drawing.Size(270, 27)
        Me.TxtAuthor.TabIndex = 5
        '
        'LblCategory
        '
        Me.LblCategory.AutoSize = True
        Me.LblCategory.Location = New System.Drawing.Point(444, 48)
        Me.LblCategory.Name = "LblCategory"
        Me.LblCategory.Text = "Category:"
        Me.LblCategory.TabIndex = 6
        '
        'CmbCategory
        '
        Me.CmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbCategory.FormattingEnabled = True
        Me.CmbCategory.Location = New System.Drawing.Point(574, 44)
        Me.CmbCategory.Name = "CmbCategory"
        Me.CmbCategory.Size = New System.Drawing.Size(270, 28)
        Me.CmbCategory.TabIndex = 7
        '
        'LblPublisher
        '
        Me.LblPublisher.AutoSize = True
        Me.LblPublisher.Location = New System.Drawing.Point(24, 84)
        Me.LblPublisher.Name = "LblPublisher"
        Me.LblPublisher.Text = "Publisher:"
        Me.LblPublisher.TabIndex = 8
        '
        'TxtPublisher
        '
        Me.TxtPublisher.Location = New System.Drawing.Point(154, 80)
        Me.TxtPublisher.MaxLength = 150
        Me.TxtPublisher.Name = "TxtPublisher"
        Me.TxtPublisher.Size = New System.Drawing.Size(270, 27)
        Me.TxtPublisher.TabIndex = 9
        '
        'LblYear
        '
        Me.LblYear.AutoSize = True
        Me.LblYear.Location = New System.Drawing.Point(444, 84)
        Me.LblYear.Name = "LblYear"
        Me.LblYear.Text = "Publication Year:"
        Me.LblYear.TabIndex = 10
        '
        'NudYear
        '
        Me.NudYear.Location = New System.Drawing.Point(574, 80)
        Me.NudYear.Maximum = New Decimal(New Integer() {2100, 0, 0, 0})
        Me.NudYear.Minimum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.NudYear.Name = "NudYear"
        Me.NudYear.Size = New System.Drawing.Size(120, 27)
        Me.NudYear.TabIndex = 11
        '
        'LblCopies
        '
        Me.LblCopies.AutoSize = True
        Me.LblCopies.Location = New System.Drawing.Point(24, 120)
        Me.LblCopies.Name = "LblCopies"
        Me.LblCopies.Text = "Number of Copies:"
        Me.LblCopies.TabIndex = 12
        '
        'NudCopies
        '
        Me.NudCopies.Location = New System.Drawing.Point(154, 116)
        Me.NudCopies.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.NudCopies.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.NudCopies.Name = "NudCopies"
        Me.NudCopies.Size = New System.Drawing.Size(120, 27)
        Me.NudCopies.TabIndex = 13
        '
        'LblDescription
        '
        Me.LblDescription.AutoSize = True
        Me.LblDescription.Location = New System.Drawing.Point(444, 120)
        Me.LblDescription.Name = "LblDescription"
        Me.LblDescription.Text = "Description:"
        Me.LblDescription.TabIndex = 14
        '
        'TxtDescription
        '
        Me.TxtDescription.Location = New System.Drawing.Point(574, 116)
        Me.TxtDescription.MaxLength = 1000
        Me.TxtDescription.Multiline = True
        Me.TxtDescription.Name = "TxtDescription"
        Me.TxtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtDescription.Size = New System.Drawing.Size(270, 56)
        Me.TxtDescription.TabIndex = 15
        '
        'BtnAdd
        '
        Me.BtnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.BtnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.BtnAdd.FlatAppearance.BorderSize = 1
        Me.BtnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAdd.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdd.ForeColor = System.Drawing.Color.White
        Me.BtnAdd.Location = New System.Drawing.Point(24, 184)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(130, 36)
        Me.BtnAdd.Text = "Add Book"
        Me.BtnAdd.UseVisualStyleBackColor = False
        Me.BtnAdd.TabIndex = 16
        '
        'BtnUpdate
        '
        Me.BtnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.BtnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.BtnUpdate.FlatAppearance.BorderSize = 1
        Me.BtnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUpdate.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUpdate.ForeColor = System.Drawing.Color.White
        Me.BtnUpdate.Location = New System.Drawing.Point(164, 184)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(140, 36)
        Me.BtnUpdate.Text = "Update Book"
        Me.BtnUpdate.UseVisualStyleBackColor = False
        Me.BtnUpdate.TabIndex = 17
        '
        'BtnDelete
        '
        Me.BtnDelete.BackColor = System.Drawing.Color.Firebrick
        Me.BtnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick
        Me.BtnDelete.FlatAppearance.BorderSize = 1
        Me.BtnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown
        Me.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDelete.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDelete.ForeColor = System.Drawing.Color.White
        Me.BtnDelete.Location = New System.Drawing.Point(314, 184)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(140, 36)
        Me.BtnDelete.Text = "Delete Book"
        Me.BtnDelete.UseVisualStyleBackColor = False
        Me.BtnDelete.TabIndex = 18
        '
        'BtnClear
        '
        Me.BtnClear.BackColor = System.Drawing.Color.White
        Me.BtnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.BtnClear.FlatAppearance.BorderSize = 1
        Me.BtnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.BtnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClear.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.BtnClear.Location = New System.Drawing.Point(464, 184)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(90, 36)
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = False
        Me.BtnClear.TabIndex = 19
        '
        'LblMessage
        '
        Me.LblMessage.AutoSize = True
        Me.LblMessage.ForeColor = System.Drawing.Color.Firebrick
        Me.LblMessage.Location = New System.Drawing.Point(24, 226)
        Me.LblMessage.Name = "LblMessage"
        Me.LblMessage.Text = ""
        Me.LblMessage.TabIndex = 20
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
        Me.PnlHeader.Controls.Add(Me.BtnRefresh)
        '
        'LblTitle
        '
        Me.LblTitle.AutoSize = True
        Me.LblTitle.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.LblTitle.Location = New System.Drawing.Point(24, 10)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Text = "Manage Books"
        Me.LblTitle.TabIndex = 0
        '
        'LblSearch
        '
        Me.LblSearch.AutoSize = True
        Me.LblSearch.Location = New System.Drawing.Point(24, 62)
        Me.LblSearch.Name = "LblSearch"
        Me.LblSearch.Text = "Search Book:"
        Me.LblSearch.TabIndex = 1
        '
        'TxtSearch
        '
        Me.TxtSearch.Location = New System.Drawing.Point(150, 58)
        Me.TxtSearch.MaxLength = 100
        Me.TxtSearch.Name = "TxtSearch"
        Me.TxtSearch.PlaceholderText = "Search by title, ISBN or author"
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
        Me.BtnSearch.Location = New System.Drawing.Point(500, 54)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(90, 34)
        Me.BtnSearch.Text = "Search"
        Me.BtnSearch.UseVisualStyleBackColor = False
        Me.BtnSearch.TabIndex = 3
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
        Me.BtnRefresh.Location = New System.Drawing.Point(598, 54)
        Me.BtnRefresh.Name = "BtnRefresh"
        Me.BtnRefresh.Size = New System.Drawing.Size(90, 34)
        Me.BtnRefresh.Text = "Refresh"
        Me.BtnRefresh.UseVisualStyleBackColor = False
        Me.BtnRefresh.TabIndex = 4
        '
        'BooksForm
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
        Me.Name = "BooksForm"
        Me.Text = "Manage Books"
        CType(Me.DgvBooks, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents DgvBooks As System.Windows.Forms.DataGridView
    Friend WithEvents ColId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColISBN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColTitle As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColAuthor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColCategory As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColPublisher As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColYear As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColCopies As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColAvailable As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PnlEdit As System.Windows.Forms.Panel
    Friend WithEvents LblIsbn As System.Windows.Forms.Label
    Friend WithEvents TxtIsbn As System.Windows.Forms.TextBox
    Friend WithEvents LblBookTitle As System.Windows.Forms.Label
    Friend WithEvents TxtBookTitle As System.Windows.Forms.TextBox
    Friend WithEvents LblAuthor As System.Windows.Forms.Label
    Friend WithEvents TxtAuthor As System.Windows.Forms.TextBox
    Friend WithEvents LblCategory As System.Windows.Forms.Label
    Friend WithEvents CmbCategory As System.Windows.Forms.ComboBox
    Friend WithEvents LblPublisher As System.Windows.Forms.Label
    Friend WithEvents TxtPublisher As System.Windows.Forms.TextBox
    Friend WithEvents LblYear As System.Windows.Forms.Label
    Friend WithEvents NudYear As System.Windows.Forms.NumericUpDown
    Friend WithEvents LblCopies As System.Windows.Forms.Label
    Friend WithEvents NudCopies As System.Windows.Forms.NumericUpDown
    Friend WithEvents LblDescription As System.Windows.Forms.Label
    Friend WithEvents TxtDescription As System.Windows.Forms.TextBox
    Friend WithEvents BtnAdd As System.Windows.Forms.Button
    Friend WithEvents BtnUpdate As System.Windows.Forms.Button
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents BtnClear As System.Windows.Forms.Button
    Friend WithEvents LblMessage As System.Windows.Forms.Label
    Friend WithEvents PnlHeader As System.Windows.Forms.Panel
    Friend WithEvents LblTitle As System.Windows.Forms.Label
    Friend WithEvents LblSearch As System.Windows.Forms.Label
    Friend WithEvents TxtSearch As System.Windows.Forms.TextBox
    Friend WithEvents BtnSearch As System.Windows.Forms.Button
    Friend WithEvents BtnRefresh As System.Windows.Forms.Button

End Class
