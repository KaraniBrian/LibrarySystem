<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentDashboard
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
        Me.BtnCatalogue = New System.Windows.Forms.Button()
        Me.BtnMyBorrowedBooks = New System.Windows.Forms.Button()
        Me.BtnMyFines = New System.Windows.Forms.Button()
        Me.BtnProfile = New System.Windows.Forms.Button()
        Me.BtnChangePassword = New System.Windows.Forms.Button()
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
        Me.PnlSidebar.Controls.Add(Me.BtnChangePassword)
        Me.PnlSidebar.Controls.Add(Me.BtnLogout)
        Me.PnlSidebar.Controls.Add(Me.BtnMyFines)
        Me.PnlSidebar.Controls.Add(Me.BtnMyBorrowedBooks)
        Me.PnlSidebar.Controls.Add(Me.BtnCatalogue)
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
        Me.LblAppTitle.Text = "Student Portal"
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
        'BtnCatalogue
        '
        Me.BtnCatalogue.BackColor = System.Drawing.Color.DarkGreen
        Me.BtnCatalogue.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCatalogue.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen
        Me.BtnCatalogue.FlatAppearance.BorderSize = 0
        Me.BtnCatalogue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnCatalogue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCatalogue.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCatalogue.ForeColor = System.Drawing.Color.White
        Me.BtnCatalogue.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnCatalogue.Location = New System.Drawing.Point(0, 0)
        Me.BtnCatalogue.Name = "BtnCatalogue"
        Me.BtnCatalogue.Size = New System.Drawing.Size(220, 40)
        Me.BtnCatalogue.Text = "Browse Books"
        Me.BtnCatalogue.UseVisualStyleBackColor = False
        Me.BtnCatalogue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCatalogue.Padding = New System.Windows.Forms.Padding(16, 0, 0, 0)
        Me.BtnCatalogue.TabIndex = 2
        '
        'BtnMyBorrowedBooks
        '
        Me.BtnMyBorrowedBooks.BackColor = System.Drawing.Color.DarkGreen
        Me.BtnMyBorrowedBooks.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnMyBorrowedBooks.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen
        Me.BtnMyBorrowedBooks.FlatAppearance.BorderSize = 0
        Me.BtnMyBorrowedBooks.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnMyBorrowedBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMyBorrowedBooks.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMyBorrowedBooks.ForeColor = System.Drawing.Color.White
        Me.BtnMyBorrowedBooks.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnMyBorrowedBooks.Location = New System.Drawing.Point(0, 0)
        Me.BtnMyBorrowedBooks.Name = "BtnMyBorrowedBooks"
        Me.BtnMyBorrowedBooks.Size = New System.Drawing.Size(220, 40)
        Me.BtnMyBorrowedBooks.Text = "My Borrowed Books"
        Me.BtnMyBorrowedBooks.UseVisualStyleBackColor = False
        Me.BtnMyBorrowedBooks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnMyBorrowedBooks.Padding = New System.Windows.Forms.Padding(16, 0, 0, 0)
        Me.BtnMyBorrowedBooks.TabIndex = 3
        '
        'BtnMyFines
        '
        Me.BtnMyFines.BackColor = System.Drawing.Color.DarkGreen
        Me.BtnMyFines.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnMyFines.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen
        Me.BtnMyFines.FlatAppearance.BorderSize = 0
        Me.BtnMyFines.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnMyFines.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMyFines.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMyFines.ForeColor = System.Drawing.Color.White
        Me.BtnMyFines.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnMyFines.Location = New System.Drawing.Point(0, 0)
        Me.BtnMyFines.Name = "BtnMyFines"
        Me.BtnMyFines.Size = New System.Drawing.Size(220, 40)
        Me.BtnMyFines.Text = "My Fines and Payments"
        Me.BtnMyFines.UseVisualStyleBackColor = False
        Me.BtnMyFines.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnMyFines.Padding = New System.Windows.Forms.Padding(16, 0, 0, 0)
        Me.BtnMyFines.TabIndex = 4
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
        Me.BtnProfile.TabIndex = 5
        '
        'BtnChangePassword
        '
        Me.BtnChangePassword.BackColor = System.Drawing.Color.DarkGreen
        Me.BtnChangePassword.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnChangePassword.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen
        Me.BtnChangePassword.FlatAppearance.BorderSize = 0
        Me.BtnChangePassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnChangePassword.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnChangePassword.ForeColor = System.Drawing.Color.White
        Me.BtnChangePassword.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BtnChangePassword.Location = New System.Drawing.Point(0, 0)
        Me.BtnChangePassword.Name = "BtnChangePassword"
        Me.BtnChangePassword.Size = New System.Drawing.Size(220, 40)
        Me.BtnChangePassword.Text = "Change Password"
        Me.BtnChangePassword.UseVisualStyleBackColor = False
        Me.BtnChangePassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnChangePassword.Padding = New System.Windows.Forms.Padding(16, 0, 0, 0)
        Me.BtnChangePassword.TabIndex = 6
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
        Me.BtnLogout.TabIndex = 7
        '
        'StudentDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1100, 640)
        Me.Controls.Add(Me.PnlContent)
        Me.Controls.Add(Me.PnlSidebar)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MinimumSize = New System.Drawing.Size(900, 600)
        Me.Name = "StudentDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Library Management System - Student"
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
    Friend WithEvents BtnCatalogue As System.Windows.Forms.Button
    Friend WithEvents BtnMyBorrowedBooks As System.Windows.Forms.Button
    Friend WithEvents BtnMyFines As System.Windows.Forms.Button
    Friend WithEvents BtnProfile As System.Windows.Forms.Button
    Friend WithEvents BtnChangePassword As System.Windows.Forms.Button
    Friend WithEvents BtnLogout As System.Windows.Forms.Button

End Class
