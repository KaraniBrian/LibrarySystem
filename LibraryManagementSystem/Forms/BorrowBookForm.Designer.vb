<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BorrowBookForm
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
        Me.TxtStudent = New System.Windows.Forms.TextBox()
        Me.LblBook = New System.Windows.Forms.Label()
        Me.TxtBook = New System.Windows.Forms.TextBox()
        Me.LblAvailability = New System.Windows.Forms.Label()
        Me.TxtAvailability = New System.Windows.Forms.TextBox()
        Me.LblBorrowDate = New System.Windows.Forms.Label()
        Me.DtpBorrowDate = New System.Windows.Forms.DateTimePicker()
        Me.LblDueDate = New System.Windows.Forms.Label()
        Me.TxtDueDate = New System.Windows.Forms.TextBox()
        Me.LblRules = New System.Windows.Forms.Label()
        Me.ChkConfirmRules = New System.Windows.Forms.CheckBox()
        Me.BtnConfirmBorrow = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.LblMessage = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LblTitle
        '
        Me.LblTitle.AutoSize = True
        Me.LblTitle.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.LblTitle.Location = New System.Drawing.Point(24, 14)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Text = "Borrow Book"
        Me.LblTitle.TabIndex = 0
        '
        'LblStudent
        '
        Me.LblStudent.AutoSize = True
        Me.LblStudent.Location = New System.Drawing.Point(28, 62)
        Me.LblStudent.Name = "LblStudent"
        Me.LblStudent.Text = "Student:"
        Me.LblStudent.TabIndex = 1
        '
        'TxtStudent
        '
        Me.TxtStudent.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TxtStudent.Location = New System.Drawing.Point(168, 58)
        Me.TxtStudent.Name = "TxtStudent"
        Me.TxtStudent.ReadOnly = True
        Me.TxtStudent.Size = New System.Drawing.Size(320, 27)
        Me.TxtStudent.TabIndex = 2
        '
        'LblBook
        '
        Me.LblBook.AutoSize = True
        Me.LblBook.Location = New System.Drawing.Point(28, 102)
        Me.LblBook.Name = "LblBook"
        Me.LblBook.Text = "Selected Book:"
        Me.LblBook.TabIndex = 3
        '
        'TxtBook
        '
        Me.TxtBook.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TxtBook.Location = New System.Drawing.Point(168, 98)
        Me.TxtBook.Name = "TxtBook"
        Me.TxtBook.ReadOnly = True
        Me.TxtBook.Size = New System.Drawing.Size(320, 27)
        Me.TxtBook.TabIndex = 4
        '
        'LblAvailability
        '
        Me.LblAvailability.AutoSize = True
        Me.LblAvailability.Location = New System.Drawing.Point(28, 142)
        Me.LblAvailability.Name = "LblAvailability"
        Me.LblAvailability.Text = "Availability:"
        Me.LblAvailability.TabIndex = 5
        '
        'TxtAvailability
        '
        Me.TxtAvailability.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TxtAvailability.Location = New System.Drawing.Point(168, 138)
        Me.TxtAvailability.Name = "TxtAvailability"
        Me.TxtAvailability.ReadOnly = True
        Me.TxtAvailability.Size = New System.Drawing.Size(320, 27)
        Me.TxtAvailability.TabIndex = 6
        '
        'LblBorrowDate
        '
        Me.LblBorrowDate.AutoSize = True
        Me.LblBorrowDate.Location = New System.Drawing.Point(28, 182)
        Me.LblBorrowDate.Name = "LblBorrowDate"
        Me.LblBorrowDate.Text = "Borrow Date:"
        Me.LblBorrowDate.TabIndex = 7
        '
        'DtpBorrowDate
        '
        Me.DtpBorrowDate.Enabled = False
        Me.DtpBorrowDate.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DtpBorrowDate.Location = New System.Drawing.Point(168, 178)
        Me.DtpBorrowDate.Name = "DtpBorrowDate"
        Me.DtpBorrowDate.Size = New System.Drawing.Size(150, 27)
        Me.DtpBorrowDate.TabIndex = 8
        '
        'LblDueDate
        '
        Me.LblDueDate.AutoSize = True
        Me.LblDueDate.Location = New System.Drawing.Point(28, 222)
        Me.LblDueDate.Name = "LblDueDate"
        Me.LblDueDate.Text = "Due Date:"
        Me.LblDueDate.TabIndex = 9
        '
        'TxtDueDate
        '
        Me.TxtDueDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TxtDueDate.Location = New System.Drawing.Point(168, 218)
        Me.TxtDueDate.Name = "TxtDueDate"
        Me.TxtDueDate.ReadOnly = True
        Me.TxtDueDate.Size = New System.Drawing.Size(320, 27)
        Me.TxtDueDate.TabIndex = 10
        '
        'LblRules
        '
        Me.LblRules.AutoSize = False
        Me.LblRules.Location = New System.Drawing.Point(28, 262)
        Me.LblRules.Name = "LblRules"
        Me.LblRules.Size = New System.Drawing.Size(464, 64)
        Me.LblRules.Text = ""
        Me.LblRules.TabIndex = 11
        '
        'ChkConfirmRules
        '
        Me.ChkConfirmRules.AutoSize = True
        Me.ChkConfirmRules.Location = New System.Drawing.Point(28, 332)
        Me.ChkConfirmRules.Name = "ChkConfirmRules"
        Me.ChkConfirmRules.Text = "I agree to the library borrowing rules"
        Me.ChkConfirmRules.UseVisualStyleBackColor = True
        Me.ChkConfirmRules.TabIndex = 12
        '
        'BtnConfirmBorrow
        '
        Me.BtnConfirmBorrow.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.BtnConfirmBorrow.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnConfirmBorrow.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.BtnConfirmBorrow.FlatAppearance.BorderSize = 1
        Me.BtnConfirmBorrow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnConfirmBorrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnConfirmBorrow.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConfirmBorrow.ForeColor = System.Drawing.Color.White
        Me.BtnConfirmBorrow.Enabled = False
        Me.BtnConfirmBorrow.Location = New System.Drawing.Point(28, 366)
        Me.BtnConfirmBorrow.Name = "BtnConfirmBorrow"
        Me.BtnConfirmBorrow.Size = New System.Drawing.Size(190, 36)
        Me.BtnConfirmBorrow.Text = "Confirm Borrowing"
        Me.BtnConfirmBorrow.UseVisualStyleBackColor = False
        Me.BtnConfirmBorrow.TabIndex = 13
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
        Me.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnCancel.Location = New System.Drawing.Point(228, 366)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(110, 36)
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = False
        Me.BtnCancel.TabIndex = 14
        '
        'LblMessage
        '
        Me.LblMessage.AutoSize = False
        Me.LblMessage.ForeColor = System.Drawing.Color.Firebrick
        Me.LblMessage.Location = New System.Drawing.Point(28, 414)
        Me.LblMessage.Name = "LblMessage"
        Me.LblMessage.Size = New System.Drawing.Size(464, 40)
        Me.LblMessage.Text = ""
        Me.LblMessage.TabIndex = 15
        '
        'BorrowBookForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.CancelButton = Me.BtnCancel
        Me.ClientSize = New System.Drawing.Size(520, 470)
        Me.Controls.Add(Me.LblTitle)
        Me.Controls.Add(Me.LblStudent)
        Me.Controls.Add(Me.TxtStudent)
        Me.Controls.Add(Me.LblBook)
        Me.Controls.Add(Me.TxtBook)
        Me.Controls.Add(Me.LblAvailability)
        Me.Controls.Add(Me.TxtAvailability)
        Me.Controls.Add(Me.LblBorrowDate)
        Me.Controls.Add(Me.DtpBorrowDate)
        Me.Controls.Add(Me.LblDueDate)
        Me.Controls.Add(Me.TxtDueDate)
        Me.Controls.Add(Me.LblRules)
        Me.Controls.Add(Me.ChkConfirmRules)
        Me.Controls.Add(Me.BtnConfirmBorrow)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.LblMessage)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "BorrowBookForm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Borrow Book"
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents LblTitle As System.Windows.Forms.Label
    Friend WithEvents LblStudent As System.Windows.Forms.Label
    Friend WithEvents TxtStudent As System.Windows.Forms.TextBox
    Friend WithEvents LblBook As System.Windows.Forms.Label
    Friend WithEvents TxtBook As System.Windows.Forms.TextBox
    Friend WithEvents LblAvailability As System.Windows.Forms.Label
    Friend WithEvents TxtAvailability As System.Windows.Forms.TextBox
    Friend WithEvents LblBorrowDate As System.Windows.Forms.Label
    Friend WithEvents DtpBorrowDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents LblDueDate As System.Windows.Forms.Label
    Friend WithEvents TxtDueDate As System.Windows.Forms.TextBox
    Friend WithEvents LblRules As System.Windows.Forms.Label
    Friend WithEvents ChkConfirmRules As System.Windows.Forms.CheckBox
    Friend WithEvents BtnConfirmBorrow As System.Windows.Forms.Button
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents LblMessage As System.Windows.Forms.Label

End Class
