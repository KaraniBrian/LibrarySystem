<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LibrarianDashboard
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
        Me.PnlContent = New System.Windows.Forms.Panel()
        Me.PnlSidebar = New System.Windows.Forms.Panel()
        Me.LblAppTitle = New System.Windows.Forms.Label()
        Me.BtnDashboard = New System.Windows.Forms.Button()
        Me.BtnStudents = New System.Windows.Forms.Button()
        Me.BtnBooks = New System.Windows.Forms.Button()
        Me.BtnBorrowing = New System.Windows.Forms.Button()
        Me.BtnReturns = New System.Windows.Forms.Button()
        Me.BtnFines = New System.Windows.Forms.Button()
        Me.BtnRecords = New System.Windows.Forms.Button()
        Me.BtnReports = New System.Windows.Forms.Button()
        Me.BtnSettings = New System.Windows.Forms.Button()
        Me.BtnProfile = New System.Windows.Forms.Button()
        Me.BtnLogout = New System.Windows.Forms.Button()
        Me.PnlContent.SuspendLayout()
        Me.PnlSidebar.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlContent
        '
        Me.PnlContent.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PnlContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlContent.Name = "PnlContent"
        Me.PnlContent.TabIndex = 0
        '
        'PnlSidebar
        '
        Me.PnlSidebar.BackColor = System.Drawing.Color.DarkGreen
        Me.PnlSidebar.Dock = System.Windows.Forms.DockStyle.Left
        Me.PnlSidebar.Name = "PnlSidebar"
        Me.PnlSidebar.Size = New System.Drawing.Size(220, 0)
        Me.PnlSidebar.AutoScroll = True
        Me.PnlSidebar.TabIndex = 1
        Me.PnlSidebar.Controls.Add(Me.BtnProfile)
        Me.PnlSidebar.Controls.Add(Me.BtnLogout)
        Me.PnlSidebar.Controls.Add(Me.BtnSettings)
        Me.PnlSidebar.Controls.Add(Me.BtnReports)
        Me.PnlSidebar.Controls.Add(Me.BtnRecords)
        Me.PnlSidebar.Controls.Add(Me.BtnFines)
        Me.PnlSidebar.Controls.Add(Me.BtnReturns)
        Me.PnlSidebar.Controls.Add(Me.BtnBorrowing)
        Me.PnlSidebar.Controls.Add(Me.BtnBooks)
        Me.PnlSidebar.Controls.Add(Me.BtnStudents)
        Me.PnlSidebar.Controls.Add(Me.BtnDashboard)
        Me.PnlSidebar.Controls.Add(Me.LblAppTitle)
        '
        'LblAppTitle
        '
        Me.LblAppTitle.AutoSize = False
        Me.LblAppTitle.BackColor = System.Drawing.Color.DarkGreen
        Me.LblAppTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.LblAppTitle.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAppTitle.ForeColor = System.Drawing.Color.White
        Me.LblAppTitle.Location = New System.Drawing.Point(0, 0)
        Me.LblAppTitle.Name = "LblAppTitle"
        Me.LblAppTitle.Size = New System.Drawing.Size(220, 64)
        Me.LblAppTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LblAppTitle.Text = "Library System"
        Me.LblAppTitle.TabIndex = 0
        '
        'BtnDashboard
        '
        Me.BtnDashboard.BackColor = System.Drawing.Color.DarkGreen
        Me.BtnDashboard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnDashboard.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen
        Me.BtnDashboard.FlatAppearance.BorderSize = 0
        Me.BtnDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDashboard.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDashboard.ForeColor = System.Drawing.Color.White
        Me.BtnDashboard.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnDashboard.Location = New System.Drawing.Point(0, 0)
        Me.BtnDashboard.Name = "BtnDashboard"
        Me.BtnDashboard.Size = New System.Drawing.Size(220, 40)
        Me.BtnDashboard.Text = "Dashboard"
        Me.BtnDashboard.UseVisualStyleBackColor = False
        Me.BtnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDashboard.Padding = New System.Windows.Forms.Padding(16, 0, 0, 0)
        Me.BtnDashboard.TabIndex = 1
        '
        'BtnStudents
        '
        Me.BtnStudents.BackColor = System.Drawing.Color.DarkGreen
        Me.BtnStudents.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnStudents.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen
        Me.BtnStudents.FlatAppearance.BorderSize = 0
        Me.BtnStudents.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnStudents.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnStudents.ForeColor = System.Drawing.Color.White
        Me.BtnStudents.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnStudents.Location = New System.Drawing.Point(0, 0)
        Me.BtnStudents.Name = "BtnStudents"
        Me.BtnStudents.Size = New System.Drawing.Size(220, 40)
        Me.BtnStudents.Text = "Manage Students"
        Me.BtnStudents.UseVisualStyleBackColor = False
        Me.BtnStudents.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnStudents.Padding = New System.Windows.Forms.Padding(16, 0, 0, 0)
        Me.BtnStudents.TabIndex = 2
        '
        'BtnBooks
        '
        Me.BtnBooks.BackColor = System.Drawing.Color.DarkGreen
        Me.BtnBooks.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnBooks.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen
        Me.BtnBooks.FlatAppearance.BorderSize = 0
        Me.BtnBooks.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBooks.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBooks.ForeColor = System.Drawing.Color.White
        Me.BtnBooks.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnBooks.Location = New System.Drawing.Point(0, 0)
        Me.BtnBooks.Name = "BtnBooks"
        Me.BtnBooks.Size = New System.Drawing.Size(220, 40)
        Me.BtnBooks.Text = "Manage Books"
        Me.BtnBooks.UseVisualStyleBackColor = False
        Me.BtnBooks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBooks.Padding = New System.Windows.Forms.Padding(16, 0, 0, 0)
        Me.BtnBooks.TabIndex = 3
        '
        'BtnBorrowing
        '
        Me.BtnBorrowing.BackColor = System.Drawing.Color.DarkGreen
        Me.BtnBorrowing.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnBorrowing.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen
        Me.BtnBorrowing.FlatAppearance.BorderSize = 0
        Me.BtnBorrowing.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnBorrowing.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBorrowing.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBorrowing.ForeColor = System.Drawing.Color.White
        Me.BtnBorrowing.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnBorrowing.Location = New System.Drawing.Point(0, 0)
        Me.BtnBorrowing.Name = "BtnBorrowing"
        Me.BtnBorrowing.Size = New System.Drawing.Size(220, 40)
        Me.BtnBorrowing.Text = "Borrow/Issue Books"
        Me.BtnBorrowing.UseVisualStyleBackColor = False
        Me.BtnBorrowing.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBorrowing.Padding = New System.Windows.Forms.Padding(16, 0, 0, 0)
        Me.BtnBorrowing.TabIndex = 4
        '
        'BtnReturns
        '
        Me.BtnReturns.BackColor = System.Drawing.Color.DarkGreen
        Me.BtnReturns.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnReturns.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen
        Me.BtnReturns.FlatAppearance.BorderSize = 0
        Me.BtnReturns.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnReturns.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnReturns.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReturns.ForeColor = System.Drawing.Color.White
        Me.BtnReturns.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnReturns.Location = New System.Drawing.Point(0, 0)
        Me.BtnReturns.Name = "BtnReturns"
        Me.BtnReturns.Size = New System.Drawing.Size(220, 40)
        Me.BtnReturns.Text = "Process Returns"
        Me.BtnReturns.UseVisualStyleBackColor = False
        Me.BtnReturns.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnReturns.Padding = New System.Windows.Forms.Padding(16, 0, 0, 0)
        Me.BtnReturns.TabIndex = 5
        '
        'BtnFines
        '
        Me.BtnFines.BackColor = System.Drawing.Color.DarkGreen
        Me.BtnFines.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFines.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen
        Me.BtnFines.FlatAppearance.BorderSize = 0
        Me.BtnFines.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnFines.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFines.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFines.ForeColor = System.Drawing.Color.White
        Me.BtnFines.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnFines.Location = New System.Drawing.Point(0, 0)
        Me.BtnFines.Name = "BtnFines"
        Me.BtnFines.Size = New System.Drawing.Size(220, 40)
        Me.BtnFines.Text = "Fines Management"
        Me.BtnFines.UseVisualStyleBackColor = False
        Me.BtnFines.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnFines.Padding = New System.Windows.Forms.Padding(16, 0, 0, 0)
        Me.BtnFines.TabIndex = 6
        '
        'BtnRecords
        '
        Me.BtnRecords.BackColor = System.Drawing.Color.DarkGreen
        Me.BtnRecords.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRecords.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen
        Me.BtnRecords.FlatAppearance.BorderSize = 0
        Me.BtnRecords.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRecords.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRecords.ForeColor = System.Drawing.Color.White
        Me.BtnRecords.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnRecords.Location = New System.Drawing.Point(0, 0)
        Me.BtnRecords.Name = "BtnRecords"
        Me.BtnRecords.Size = New System.Drawing.Size(220, 40)
        Me.BtnRecords.Text = "Borrowing Records"
        Me.BtnRecords.UseVisualStyleBackColor = False
        Me.BtnRecords.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnRecords.Padding = New System.Windows.Forms.Padding(16, 0, 0, 0)
        Me.BtnRecords.TabIndex = 7
        '
        'BtnReports
        '
        Me.BtnReports.BackColor = System.Drawing.Color.DarkGreen
        Me.BtnReports.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnReports.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen
        Me.BtnReports.FlatAppearance.BorderSize = 0
        Me.BtnReports.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnReports.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReports.ForeColor = System.Drawing.Color.White
        Me.BtnReports.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnReports.Location = New System.Drawing.Point(0, 0)
        Me.BtnReports.Name = "BtnReports"
        Me.BtnReports.Size = New System.Drawing.Size(220, 40)
        Me.BtnReports.Text = "Reports"
        Me.BtnReports.UseVisualStyleBackColor = False
        Me.BtnReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnReports.Padding = New System.Windows.Forms.Padding(16, 0, 0, 0)
        Me.BtnReports.TabIndex = 8
        '
        'BtnSettings
        '
        Me.BtnSettings.BackColor = System.Drawing.Color.DarkGreen
        Me.BtnSettings.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSettings.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen
        Me.BtnSettings.FlatAppearance.BorderSize = 0
        Me.BtnSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSettings.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSettings.ForeColor = System.Drawing.Color.White
        Me.BtnSettings.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnSettings.Location = New System.Drawing.Point(0, 0)
        Me.BtnSettings.Name = "BtnSettings"
        Me.BtnSettings.Size = New System.Drawing.Size(220, 40)
        Me.BtnSettings.Text = "Settings"
        Me.BtnSettings.UseVisualStyleBackColor = False
        Me.BtnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSettings.Padding = New System.Windows.Forms.Padding(16, 0, 0, 0)
        Me.BtnSettings.TabIndex = 9
        '
        'BtnProfile
        '
        Me.BtnProfile.BackColor = System.Drawing.Color.DarkGreen
        Me.BtnProfile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnProfile.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen
        Me.BtnProfile.FlatAppearance.BorderSize = 0
        Me.BtnProfile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnProfile.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnProfile.ForeColor = System.Drawing.Color.White
        Me.BtnProfile.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BtnProfile.Location = New System.Drawing.Point(0, 0)
        Me.BtnProfile.Name = "BtnProfile"
        Me.BtnProfile.Size = New System.Drawing.Size(220, 40)
        Me.BtnProfile.Text = "My Profile"
        Me.BtnProfile.UseVisualStyleBackColor = False
        Me.BtnProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnProfile.Padding = New System.Windows.Forms.Padding(16, 0, 0, 0)
        Me.BtnProfile.TabIndex = 10
        '
        'BtnLogout
        '
        Me.BtnLogout.BackColor = System.Drawing.Color.DarkGreen
        Me.BtnLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnLogout.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen
        Me.BtnLogout.FlatAppearance.BorderSize = 0
        Me.BtnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLogout.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogout.ForeColor = System.Drawing.Color.White
        Me.BtnLogout.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BtnLogout.Location = New System.Drawing.Point(0, 0)
        Me.BtnLogout.Name = "BtnLogout"
        Me.BtnLogout.Size = New System.Drawing.Size(220, 40)
        Me.BtnLogout.Text = "Logout"
        Me.BtnLogout.UseVisualStyleBackColor = False
        Me.BtnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnLogout.Padding = New System.Windows.Forms.Padding(16, 0, 0, 0)
        Me.BtnLogout.TabIndex = 11
        '
        'LibrarianDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1100, 640)
        Me.Controls.Add(Me.PnlContent)
        Me.Controls.Add(Me.PnlSidebar)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MinimumSize = New System.Drawing.Size(900, 600)
        Me.Name = "LibrarianDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Library Management System - Librarian"
        Me.PnlContent.ResumeLayout(False)
        Me.PnlSidebar.ResumeLayout(False)
        Me.PnlSidebar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents PnlContent As System.Windows.Forms.Panel
    Friend WithEvents PnlSidebar As System.Windows.Forms.Panel
    Friend WithEvents LblAppTitle As System.Windows.Forms.Label
    Friend WithEvents BtnDashboard As System.Windows.Forms.Button
    Friend WithEvents BtnStudents As System.Windows.Forms.Button
    Friend WithEvents BtnBooks As System.Windows.Forms.Button
    Friend WithEvents BtnBorrowing As System.Windows.Forms.Button
    Friend WithEvents BtnReturns As System.Windows.Forms.Button
    Friend WithEvents BtnFines As System.Windows.Forms.Button
    Friend WithEvents BtnRecords As System.Windows.Forms.Button
    Friend WithEvents BtnReports As System.Windows.Forms.Button
    Friend WithEvents BtnSettings As System.Windows.Forms.Button
    Friend WithEvents BtnProfile As System.Windows.Forms.Button
    Friend WithEvents BtnLogout As System.Windows.Forms.Button

End Class
