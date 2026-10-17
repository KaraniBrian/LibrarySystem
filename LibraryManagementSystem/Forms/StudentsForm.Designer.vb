<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentsForm
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
        Me.DgvStudents = New System.Windows.Forms.DataGridView()
        Me.ColId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColAdmissionNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColFirstName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColLastName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColEmail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColPhone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PnlEdit = New System.Windows.Forms.Panel()
        Me.LblFirstName = New System.Windows.Forms.Label()
        Me.TxtFirstName = New System.Windows.Forms.TextBox()
        Me.LblLastName = New System.Windows.Forms.Label()
        Me.TxtLastName = New System.Windows.Forms.TextBox()
        Me.LblAdmissionNo = New System.Windows.Forms.Label()
        Me.TxtAdmissionNo = New System.Windows.Forms.TextBox()
        Me.LblEmail = New System.Windows.Forms.Label()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.LblPhone = New System.Windows.Forms.Label()
        Me.TxtPhone = New System.Windows.Forms.TextBox()
        Me.LblStatus = New System.Windows.Forms.Label()
        Me.CmbStatus = New System.Windows.Forms.ComboBox()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnResetPassword = New System.Windows.Forms.Button()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.LblMessage = New System.Windows.Forms.Label()
        Me.PnlHeader = New System.Windows.Forms.Panel()
        Me.LblTitle = New System.Windows.Forms.Label()
        Me.LblSearch = New System.Windows.Forms.Label()
        Me.TxtSearch = New System.Windows.Forms.TextBox()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.BtnRefresh = New System.Windows.Forms.Button()
        CType(Me.DgvStudents, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.PnlGrid.Controls.Add(Me.DgvStudents)
        '
        'DgvStudents
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
        Me.DgvStudents.AllowUserToAddRows = False
        Me.DgvStudents.AllowUserToDeleteRows = False
        Me.DgvStudents.AllowUserToResizeRows = False
        Me.DgvStudents.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DgvStudents.AutoGenerateColumns = False
        Me.DgvStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvStudents.BackgroundColor = System.Drawing.Color.White
        Me.DgvStudents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DgvStudents.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvStudents.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColId, Me.ColAdmissionNo, Me.ColFirstName, Me.ColLastName, Me.ColEmail, Me.ColPhone, Me.ColStatus})
        Me.DgvStudents.DefaultCellStyle = DataGridViewCellStyle3
        Me.DgvStudents.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvStudents.EnableHeadersVisualStyles = False
        Me.DgvStudents.MultiSelect = False
        Me.DgvStudents.Name = "DgvStudents"
        Me.DgvStudents.ReadOnly = True
        Me.DgvStudents.RowHeadersVisible = False
        Me.DgvStudents.RowTemplate.Height = 28
        Me.DgvStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvStudents.TabIndex = 0
        '
        'ColId
        '
        Me.ColId.DataPropertyName = "Id"
        Me.ColId.HeaderText = "Id"
        Me.ColId.Name = "ColId"
        Me.ColId.ReadOnly = True
        Me.ColId.Visible = False
        '
        'ColAdmissionNo
        '
        Me.ColAdmissionNo.DataPropertyName = "Admission No"
        Me.ColAdmissionNo.HeaderText = "Admission No"
        Me.ColAdmissionNo.Name = "ColAdmissionNo"
        Me.ColAdmissionNo.ReadOnly = True
        '
        'ColFirstName
        '
        Me.ColFirstName.DataPropertyName = "First Name"
        Me.ColFirstName.HeaderText = "First Name"
        Me.ColFirstName.Name = "ColFirstName"
        Me.ColFirstName.ReadOnly = True
        '
        'ColLastName
        '
        Me.ColLastName.DataPropertyName = "Last Name"
        Me.ColLastName.HeaderText = "Last Name"
        Me.ColLastName.Name = "ColLastName"
        Me.ColLastName.ReadOnly = True
        '
        'ColEmail
        '
        Me.ColEmail.DataPropertyName = "Email"
        Me.ColEmail.HeaderText = "Email"
        Me.ColEmail.Name = "ColEmail"
        Me.ColEmail.ReadOnly = True
        '
        'ColPhone
        '
        Me.ColPhone.DataPropertyName = "Phone"
        Me.ColPhone.HeaderText = "Phone"
        Me.ColPhone.Name = "ColPhone"
        Me.ColPhone.ReadOnly = True
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
        Me.PnlEdit.Size = New System.Drawing.Size(0, 212)
        Me.PnlEdit.TabIndex = 1
        Me.PnlEdit.Controls.Add(Me.LblFirstName)
        Me.PnlEdit.Controls.Add(Me.TxtFirstName)
        Me.PnlEdit.Controls.Add(Me.LblLastName)
        Me.PnlEdit.Controls.Add(Me.TxtLastName)
        Me.PnlEdit.Controls.Add(Me.LblAdmissionNo)
        Me.PnlEdit.Controls.Add(Me.TxtAdmissionNo)
        Me.PnlEdit.Controls.Add(Me.LblEmail)
        Me.PnlEdit.Controls.Add(Me.TxtEmail)
        Me.PnlEdit.Controls.Add(Me.LblPhone)
        Me.PnlEdit.Controls.Add(Me.TxtPhone)
        Me.PnlEdit.Controls.Add(Me.LblStatus)
        Me.PnlEdit.Controls.Add(Me.CmbStatus)
        Me.PnlEdit.Controls.Add(Me.BtnAdd)
        Me.PnlEdit.Controls.Add(Me.BtnUpdate)
        Me.PnlEdit.Controls.Add(Me.BtnDelete)
        Me.PnlEdit.Controls.Add(Me.BtnResetPassword)
        Me.PnlEdit.Controls.Add(Me.BtnClear)
        Me.PnlEdit.Controls.Add(Me.LblMessage)
        '
        'LblFirstName
        '
        Me.LblFirstName.AutoSize = True
        Me.LblFirstName.Location = New System.Drawing.Point(24, 12)
        Me.LblFirstName.Name = "LblFirstName"
        Me.LblFirstName.Text = "First Name:"
        Me.LblFirstName.TabIndex = 0
        '
        'TxtFirstName
        '
        Me.TxtFirstName.Location = New System.Drawing.Point(154, 8)
        Me.TxtFirstName.MaxLength = 100
        Me.TxtFirstName.Name = "TxtFirstName"
        Me.TxtFirstName.Size = New System.Drawing.Size(270, 27)
        Me.TxtFirstName.TabIndex = 1
        '
        'LblLastName
        '
        Me.LblLastName.AutoSize = True
        Me.LblLastName.Location = New System.Drawing.Point(444, 12)
        Me.LblLastName.Name = "LblLastName"
        Me.LblLastName.Text = "Last Name:"
        Me.LblLastName.TabIndex = 2
        '
        'TxtLastName
        '
        Me.TxtLastName.Location = New System.Drawing.Point(574, 8)
        Me.TxtLastName.MaxLength = 100
        Me.TxtLastName.Name = "TxtLastName"
        Me.TxtLastName.Size = New System.Drawing.Size(270, 27)
        Me.TxtLastName.TabIndex = 3
        '
        'LblAdmissionNo
        '
        Me.LblAdmissionNo.AutoSize = True
        Me.LblAdmissionNo.Location = New System.Drawing.Point(24, 48)
        Me.LblAdmissionNo.Name = "LblAdmissionNo"
        Me.LblAdmissionNo.Text = "Admission Number:"
        Me.LblAdmissionNo.TabIndex = 4
        '
        'TxtAdmissionNo
        '
        Me.TxtAdmissionNo.Location = New System.Drawing.Point(154, 44)
        Me.TxtAdmissionNo.MaxLength = 50
        Me.TxtAdmissionNo.Name = "TxtAdmissionNo"
        Me.TxtAdmissionNo.Size = New System.Drawing.Size(270, 27)
        Me.TxtAdmissionNo.TabIndex = 5
        '
        'LblEmail
        '
        Me.LblEmail.AutoSize = True
        Me.LblEmail.Location = New System.Drawing.Point(444, 48)
        Me.LblEmail.Name = "LblEmail"
        Me.LblEmail.Text = "Email:"
        Me.LblEmail.TabIndex = 6
        '
        'TxtEmail
        '
        Me.TxtEmail.Location = New System.Drawing.Point(574, 44)
        Me.TxtEmail.MaxLength = 255
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(270, 27)
        Me.TxtEmail.TabIndex = 7
        '
        'LblPhone
        '
        Me.LblPhone.AutoSize = True
        Me.LblPhone.Location = New System.Drawing.Point(24, 84)
        Me.LblPhone.Name = "LblPhone"
        Me.LblPhone.Text = "Phone:"
        Me.LblPhone.TabIndex = 8
        '
        'TxtPhone
        '
        Me.TxtPhone.Location = New System.Drawing.Point(154, 80)
        Me.TxtPhone.MaxLength = 20
        Me.TxtPhone.Name = "TxtPhone"
        Me.TxtPhone.Size = New System.Drawing.Size(270, 27)
        Me.TxtPhone.TabIndex = 9
        '
        'LblStatus
        '
        Me.LblStatus.AutoSize = True
        Me.LblStatus.Location = New System.Drawing.Point(444, 84)
        Me.LblStatus.Name = "LblStatus"
        Me.LblStatus.Text = "Account Status:"
        Me.LblStatus.TabIndex = 10
        '
        'CmbStatus
        '
        Me.CmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbStatus.FormattingEnabled = True
        Me.CmbStatus.Items.AddRange(New Object() {"Active", "Inactive"})
        Me.CmbStatus.Location = New System.Drawing.Point(574, 80)
        Me.CmbStatus.Name = "CmbStatus"
        Me.CmbStatus.Size = New System.Drawing.Size(270, 28)
        Me.CmbStatus.TabIndex = 11
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
        Me.BtnAdd.Location = New System.Drawing.Point(24, 128)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(130, 36)
        Me.BtnAdd.Text = "Add Student"
        Me.BtnAdd.UseVisualStyleBackColor = False
        Me.BtnAdd.TabIndex = 12
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
        Me.BtnUpdate.Location = New System.Drawing.Point(164, 128)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(140, 36)
        Me.BtnUpdate.Text = "Update Student"
        Me.BtnUpdate.UseVisualStyleBackColor = False
        Me.BtnUpdate.TabIndex = 13
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
        Me.BtnDelete.Location = New System.Drawing.Point(314, 128)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(140, 36)
        Me.BtnDelete.Text = "Delete Student"
        Me.BtnDelete.UseVisualStyleBackColor = False
        Me.BtnDelete.TabIndex = 14
        '
        'BtnResetPassword
        '
        Me.BtnResetPassword.BackColor = System.Drawing.Color.White
        Me.BtnResetPassword.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnResetPassword.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.BtnResetPassword.FlatAppearance.BorderSize = 1
        Me.BtnResetPassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.BtnResetPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnResetPassword.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnResetPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.BtnResetPassword.Location = New System.Drawing.Point(464, 128)
        Me.BtnResetPassword.Name = "BtnResetPassword"
        Me.BtnResetPassword.Size = New System.Drawing.Size(140, 36)
        Me.BtnResetPassword.Text = "Reset Password"
        Me.BtnResetPassword.UseVisualStyleBackColor = False
        Me.BtnResetPassword.TabIndex = 15
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
        Me.BtnClear.Location = New System.Drawing.Point(614, 128)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(90, 36)
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = False
        Me.BtnClear.TabIndex = 16
        '
        'LblMessage
        '
        Me.LblMessage.AutoSize = True
        Me.LblMessage.ForeColor = System.Drawing.Color.Firebrick
        Me.LblMessage.Location = New System.Drawing.Point(24, 176)
        Me.LblMessage.Name = "LblMessage"
        Me.LblMessage.Text = ""
        Me.LblMessage.TabIndex = 17
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
        Me.LblTitle.Text = "Manage Students"
        Me.LblTitle.TabIndex = 0
        '
        'LblSearch
        '
        Me.LblSearch.AutoSize = True
        Me.LblSearch.Location = New System.Drawing.Point(24, 62)
        Me.LblSearch.Name = "LblSearch"
        Me.LblSearch.Text = "Search Student:"
        Me.LblSearch.TabIndex = 1
        '
        'TxtSearch
        '
        Me.TxtSearch.Location = New System.Drawing.Point(150, 58)
        Me.TxtSearch.MaxLength = 100
        Me.TxtSearch.Name = "TxtSearch"
        Me.TxtSearch.PlaceholderText = "Search by name, email or admission number"
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
        'StudentsForm
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
        Me.Name = "StudentsForm"
        Me.Text = "Manage Students"
        CType(Me.DgvStudents, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents DgvStudents As System.Windows.Forms.DataGridView
    Friend WithEvents ColId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColAdmissionNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColFirstName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColLastName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColEmail As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColPhone As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColStatus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PnlEdit As System.Windows.Forms.Panel
    Friend WithEvents LblFirstName As System.Windows.Forms.Label
    Friend WithEvents TxtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents LblLastName As System.Windows.Forms.Label
    Friend WithEvents TxtLastName As System.Windows.Forms.TextBox
    Friend WithEvents LblAdmissionNo As System.Windows.Forms.Label
    Friend WithEvents TxtAdmissionNo As System.Windows.Forms.TextBox
    Friend WithEvents LblEmail As System.Windows.Forms.Label
    Friend WithEvents TxtEmail As System.Windows.Forms.TextBox
    Friend WithEvents LblPhone As System.Windows.Forms.Label
    Friend WithEvents TxtPhone As System.Windows.Forms.TextBox
    Friend WithEvents LblStatus As System.Windows.Forms.Label
    Friend WithEvents CmbStatus As System.Windows.Forms.ComboBox
    Friend WithEvents BtnAdd As System.Windows.Forms.Button
    Friend WithEvents BtnUpdate As System.Windows.Forms.Button
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents BtnResetPassword As System.Windows.Forms.Button
    Friend WithEvents BtnClear As System.Windows.Forms.Button
    Friend WithEvents LblMessage As System.Windows.Forms.Label
    Friend WithEvents PnlHeader As System.Windows.Forms.Panel
    Friend WithEvents LblTitle As System.Windows.Forms.Label
    Friend WithEvents LblSearch As System.Windows.Forms.Label
    Friend WithEvents TxtSearch As System.Windows.Forms.TextBox
    Friend WithEvents BtnSearch As System.Windows.Forms.Button
    Friend WithEvents BtnRefresh As System.Windows.Forms.Button

End Class
