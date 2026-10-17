<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IssueBookForm
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
        Me.LblTitle = New System.Windows.Forms.Label()
        Me.LblStudent = New System.Windows.Forms.Label()
        Me.CmbStudent = New System.Windows.Forms.ComboBox()
        Me.LblBook = New System.Windows.Forms.Label()
        Me.CmbBook = New System.Windows.Forms.ComboBox()
        Me.LblCopy = New System.Windows.Forms.Label()
        Me.CmbBookCopy = New System.Windows.Forms.ComboBox()
        Me.LblAvailability = New System.Windows.Forms.Label()
        Me.TxtAvailability = New System.Windows.Forms.TextBox()
        Me.LblIssueDate = New System.Windows.Forms.Label()
        Me.DtpIssueDate = New System.Windows.Forms.DateTimePicker()
        Me.LblDueDate = New System.Windows.Forms.Label()
        Me.DtpDueDate = New System.Windows.Forms.DateTimePicker()
        Me.BtnIssue = New System.Windows.Forms.Button()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.LblMessage = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LblTitle
        '
        Me.LblTitle.AutoSize = True
        Me.LblTitle.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.LblTitle.Location = New System.Drawing.Point(24, 14)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Text = "Issue / Borrow Book"
        Me.LblTitle.TabIndex = 0
        '
        'LblStudent
        '
        Me.LblStudent.AutoSize = True
        Me.LblStudent.Location = New System.Drawing.Point(24, 74)
        Me.LblStudent.Name = "LblStudent"
        Me.LblStudent.Text = "Select Student:"
        Me.LblStudent.TabIndex = 1
        '
        'CmbStudent
        '
        Me.CmbStudent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbStudent.FormattingEnabled = True
        Me.CmbStudent.Location = New System.Drawing.Point(234, 70)
        Me.CmbStudent.Name = "CmbStudent"
        Me.CmbStudent.Size = New System.Drawing.Size(380, 28)
        Me.CmbStudent.TabIndex = 2
        '
        'LblBook
        '
        Me.LblBook.AutoSize = True
        Me.LblBook.Location = New System.Drawing.Point(24, 116)
        Me.LblBook.Name = "LblBook"
        Me.LblBook.Text = "Select Book:"
        Me.LblBook.TabIndex = 3
        '
        'CmbBook
        '
        Me.CmbBook.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbBook.FormattingEnabled = True
        Me.CmbBook.Location = New System.Drawing.Point(234, 112)
        Me.CmbBook.Name = "CmbBook"
        Me.CmbBook.Size = New System.Drawing.Size(380, 28)
        Me.CmbBook.TabIndex = 4
        '
        'LblCopy
        '
        Me.LblCopy.AutoSize = True
        Me.LblCopy.Location = New System.Drawing.Point(24, 158)
        Me.LblCopy.Name = "LblCopy"
        Me.LblCopy.Text = "Select Available Copy:"
        Me.LblCopy.TabIndex = 5
        '
        'CmbBookCopy
        '
        Me.CmbBookCopy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbBookCopy.FormattingEnabled = True
        Me.CmbBookCopy.Location = New System.Drawing.Point(234, 154)
        Me.CmbBookCopy.Name = "CmbBookCopy"
        Me.CmbBookCopy.Size = New System.Drawing.Size(380, 28)
        Me.CmbBookCopy.TabIndex = 6
        '
        'LblAvailability
        '
        Me.LblAvailability.AutoSize = True
        Me.LblAvailability.Location = New System.Drawing.Point(24, 200)
        Me.LblAvailability.Name = "LblAvailability"
        Me.LblAvailability.Text = "Availability:"
        Me.LblAvailability.TabIndex = 7
        '
        'TxtAvailability
        '
        Me.TxtAvailability.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TxtAvailability.Location = New System.Drawing.Point(234, 196)
        Me.TxtAvailability.Name = "TxtAvailability"
        Me.TxtAvailability.ReadOnly = True
        Me.TxtAvailability.Size = New System.Drawing.Size(380, 27)
        Me.TxtAvailability.TabIndex = 8
        '
        'LblIssueDate
        '
        Me.LblIssueDate.AutoSize = True
        Me.LblIssueDate.Location = New System.Drawing.Point(24, 242)
        Me.LblIssueDate.Name = "LblIssueDate"
        Me.LblIssueDate.Text = "Issue Date:"
        Me.LblIssueDate.TabIndex = 9
        '
        'DtpIssueDate
        '
        Me.DtpIssueDate.Enabled = False
        Me.DtpIssueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DtpIssueDate.Location = New System.Drawing.Point(234, 238)
        Me.DtpIssueDate.Name = "DtpIssueDate"
        Me.DtpIssueDate.Size = New System.Drawing.Size(160, 27)
        Me.DtpIssueDate.TabIndex = 10
        '
        'LblDueDate
        '
        Me.LblDueDate.AutoSize = True
        Me.LblDueDate.Location = New System.Drawing.Point(24, 284)
        Me.LblDueDate.Name = "LblDueDate"
        Me.LblDueDate.Text = "Due Date:"
        Me.LblDueDate.TabIndex = 11
        '
        'DtpDueDate
        '
        Me.DtpDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DtpDueDate.Location = New System.Drawing.Point(234, 280)
        Me.DtpDueDate.Name = "DtpDueDate"
        Me.DtpDueDate.Size = New System.Drawing.Size(160, 27)
        Me.DtpDueDate.TabIndex = 12
        '
        'BtnIssue
        '
        Me.BtnIssue.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.BtnIssue.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnIssue.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.BtnIssue.FlatAppearance.BorderSize = 1
        Me.BtnIssue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnIssue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnIssue.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnIssue.ForeColor = System.Drawing.Color.White
        Me.BtnIssue.Enabled = False
        Me.BtnIssue.Location = New System.Drawing.Point(24, 330)
        Me.BtnIssue.Name = "BtnIssue"
        Me.BtnIssue.Size = New System.Drawing.Size(150, 36)
        Me.BtnIssue.Text = "Issue Book"
        Me.BtnIssue.UseVisualStyleBackColor = False
        Me.BtnIssue.TabIndex = 13
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
        Me.BtnClear.Location = New System.Drawing.Point(184, 330)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(100, 36)
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = False
        Me.BtnClear.TabIndex = 14
        '
        'LblMessage
        '
        Me.LblMessage.AutoSize = True
        Me.LblMessage.ForeColor = System.Drawing.Color.Firebrick
        Me.LblMessage.Location = New System.Drawing.Point(24, 380)
        Me.LblMessage.Name = "LblMessage"
        Me.LblMessage.Text = ""
        Me.LblMessage.TabIndex = 15
        '
        'IssueBookForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScroll = True
        Me.AutoScrollMinSize = New System.Drawing.Size(700, 440)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(880, 560)
        Me.Controls.Add(Me.LblTitle)
        Me.Controls.Add(Me.LblStudent)
        Me.Controls.Add(Me.CmbStudent)
        Me.Controls.Add(Me.LblBook)
        Me.Controls.Add(Me.CmbBook)
        Me.Controls.Add(Me.LblCopy)
        Me.Controls.Add(Me.CmbBookCopy)
        Me.Controls.Add(Me.LblAvailability)
        Me.Controls.Add(Me.TxtAvailability)
        Me.Controls.Add(Me.LblIssueDate)
        Me.Controls.Add(Me.DtpIssueDate)
        Me.Controls.Add(Me.LblDueDate)
        Me.Controls.Add(Me.DtpDueDate)
        Me.Controls.Add(Me.BtnIssue)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.LblMessage)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "IssueBookForm"
        Me.Text = "Issue / Borrow Book"
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents LblTitle As System.Windows.Forms.Label
    Friend WithEvents LblStudent As System.Windows.Forms.Label
    Friend WithEvents CmbStudent As System.Windows.Forms.ComboBox
    Friend WithEvents LblBook As System.Windows.Forms.Label
    Friend WithEvents CmbBook As System.Windows.Forms.ComboBox
    Friend WithEvents LblCopy As System.Windows.Forms.Label
    Friend WithEvents CmbBookCopy As System.Windows.Forms.ComboBox
    Friend WithEvents LblAvailability As System.Windows.Forms.Label
    Friend WithEvents TxtAvailability As System.Windows.Forms.TextBox
    Friend WithEvents LblIssueDate As System.Windows.Forms.Label
    Friend WithEvents DtpIssueDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents LblDueDate As System.Windows.Forms.Label
    Friend WithEvents DtpDueDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents BtnIssue As System.Windows.Forms.Button
    Friend WithEvents BtnClear As System.Windows.Forms.Button
    Friend WithEvents LblMessage As System.Windows.Forms.Label

End Class
