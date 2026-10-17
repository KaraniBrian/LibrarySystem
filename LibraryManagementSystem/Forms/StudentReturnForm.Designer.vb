<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentReturnForm
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
        Me.LblBook = New System.Windows.Forms.Label()
        Me.TxtBook = New System.Windows.Forms.TextBox()
        Me.LblLoanId = New System.Windows.Forms.Label()
        Me.TxtLoanId = New System.Windows.Forms.TextBox()
        Me.LblDueDate = New System.Windows.Forms.Label()
        Me.TxtDueDate = New System.Windows.Forms.TextBox()
        Me.LblReturnDate = New System.Windows.Forms.Label()
        Me.DtpReturnDate = New System.Windows.Forms.DateTimePicker()
        Me.LblCondition = New System.Windows.Forms.Label()
        Me.CmbCondition = New System.Windows.Forms.ComboBox()
        Me.LblNotes = New System.Windows.Forms.Label()
        Me.TxtNotes = New System.Windows.Forms.TextBox()
        Me.LblInfo = New System.Windows.Forms.Label()
        Me.BtnSubmitRequest = New System.Windows.Forms.Button()
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
        Me.LblTitle.Text = "Request Book Return"
        Me.LblTitle.TabIndex = 0
        '
        'LblBook
        '
        Me.LblBook.AutoSize = True
        Me.LblBook.Location = New System.Drawing.Point(28, 62)
        Me.LblBook.Name = "LblBook"
        Me.LblBook.Text = "Book:"
        Me.LblBook.TabIndex = 1
        '
        'TxtBook
        '
        Me.TxtBook.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TxtBook.Location = New System.Drawing.Point(168, 58)
        Me.TxtBook.Name = "TxtBook"
        Me.TxtBook.ReadOnly = True
        Me.TxtBook.Size = New System.Drawing.Size(320, 27)
        Me.TxtBook.TabIndex = 2
        '
        'LblLoanId
        '
        Me.LblLoanId.AutoSize = True
        Me.LblLoanId.Location = New System.Drawing.Point(28, 102)
        Me.LblLoanId.Name = "LblLoanId"
        Me.LblLoanId.Text = "Loan ID:"
        Me.LblLoanId.TabIndex = 3
        '
        'TxtLoanId
        '
        Me.TxtLoanId.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TxtLoanId.Location = New System.Drawing.Point(168, 98)
        Me.TxtLoanId.Name = "TxtLoanId"
        Me.TxtLoanId.ReadOnly = True
        Me.TxtLoanId.Size = New System.Drawing.Size(320, 27)
        Me.TxtLoanId.TabIndex = 4
        '
        'LblDueDate
        '
        Me.LblDueDate.AutoSize = True
        Me.LblDueDate.Location = New System.Drawing.Point(28, 142)
        Me.LblDueDate.Name = "LblDueDate"
        Me.LblDueDate.Text = "Due Date:"
        Me.LblDueDate.TabIndex = 5
        '
        'TxtDueDate
        '
        Me.TxtDueDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TxtDueDate.Location = New System.Drawing.Point(168, 138)
        Me.TxtDueDate.Name = "TxtDueDate"
        Me.TxtDueDate.ReadOnly = True
        Me.TxtDueDate.Size = New System.Drawing.Size(320, 27)
        Me.TxtDueDate.TabIndex = 6
        '
        'LblReturnDate
        '
        Me.LblReturnDate.AutoSize = True
        Me.LblReturnDate.Location = New System.Drawing.Point(28, 182)
        Me.LblReturnDate.Name = "LblReturnDate"
        Me.LblReturnDate.Text = "Return Date:"
        Me.LblReturnDate.TabIndex = 7
        '
        'DtpReturnDate
        '
        Me.DtpReturnDate.Enabled = False
        Me.DtpReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DtpReturnDate.Location = New System.Drawing.Point(168, 178)
        Me.DtpReturnDate.Name = "DtpReturnDate"
        Me.DtpReturnDate.Size = New System.Drawing.Size(150, 27)
        Me.DtpReturnDate.TabIndex = 8
        '
        'LblCondition
        '
        Me.LblCondition.AutoSize = True
        Me.LblCondition.Location = New System.Drawing.Point(28, 222)
        Me.LblCondition.Name = "LblCondition"
        Me.LblCondition.Text = "Book Condition:"
        Me.LblCondition.TabIndex = 9
        '
        'CmbCondition
        '
        Me.CmbCondition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbCondition.FormattingEnabled = True
        Me.CmbCondition.Items.AddRange(New Object() {"Good", "Fair", "Damaged"})
        Me.CmbCondition.Location = New System.Drawing.Point(168, 218)
        Me.CmbCondition.Name = "CmbCondition"
        Me.CmbCondition.Size = New System.Drawing.Size(320, 28)
        Me.CmbCondition.TabIndex = 10
        '
        'LblNotes
        '
        Me.LblNotes.AutoSize = True
        Me.LblNotes.Location = New System.Drawing.Point(28, 262)
        Me.LblNotes.Name = "LblNotes"
        Me.LblNotes.Text = "Additional Notes:"
        Me.LblNotes.TabIndex = 11
        '
        'TxtNotes
        '
        Me.TxtNotes.Location = New System.Drawing.Point(168, 258)
        Me.TxtNotes.MaxLength = 500
        Me.TxtNotes.Multiline = True
        Me.TxtNotes.Name = "TxtNotes"
        Me.TxtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtNotes.Size = New System.Drawing.Size(320, 70)
        Me.TxtNotes.TabIndex = 12
        '
        'LblInfo
        '
        Me.LblInfo.AutoSize = False
        Me.LblInfo.ForeColor = System.Drawing.Color.DimGray
        Me.LblInfo.Location = New System.Drawing.Point(28, 342)
        Me.LblInfo.Name = "LblInfo"
        Me.LblInfo.Size = New System.Drawing.Size(464, 36)
        Me.LblInfo.Text = "The librarian confirms the return and records the official return date."
        Me.LblInfo.TabIndex = 13
        '
        'BtnSubmitRequest
        '
        Me.BtnSubmitRequest.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.BtnSubmitRequest.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSubmitRequest.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.BtnSubmitRequest.FlatAppearance.BorderSize = 1
        Me.BtnSubmitRequest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnSubmitRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSubmitRequest.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSubmitRequest.ForeColor = System.Drawing.Color.White
        Me.BtnSubmitRequest.Location = New System.Drawing.Point(28, 386)
        Me.BtnSubmitRequest.Name = "BtnSubmitRequest"
        Me.BtnSubmitRequest.Size = New System.Drawing.Size(210, 36)
        Me.BtnSubmitRequest.Text = "Submit Return Request"
        Me.BtnSubmitRequest.UseVisualStyleBackColor = False
        Me.BtnSubmitRequest.TabIndex = 14
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
        Me.BtnCancel.Location = New System.Drawing.Point(248, 386)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(110, 36)
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = False
        Me.BtnCancel.TabIndex = 15
        '
        'LblMessage
        '
        Me.LblMessage.AutoSize = False
        Me.LblMessage.ForeColor = System.Drawing.Color.Firebrick
        Me.LblMessage.Location = New System.Drawing.Point(28, 432)
        Me.LblMessage.Name = "LblMessage"
        Me.LblMessage.Size = New System.Drawing.Size(464, 30)
        Me.LblMessage.Text = ""
        Me.LblMessage.TabIndex = 16
        '
        'StudentReturnForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.CancelButton = Me.BtnCancel
        Me.ClientSize = New System.Drawing.Size(520, 480)
        Me.Controls.Add(Me.LblTitle)
        Me.Controls.Add(Me.LblBook)
        Me.Controls.Add(Me.TxtBook)
        Me.Controls.Add(Me.LblLoanId)
        Me.Controls.Add(Me.TxtLoanId)
        Me.Controls.Add(Me.LblDueDate)
        Me.Controls.Add(Me.TxtDueDate)
        Me.Controls.Add(Me.LblReturnDate)
        Me.Controls.Add(Me.DtpReturnDate)
        Me.Controls.Add(Me.LblCondition)
        Me.Controls.Add(Me.CmbCondition)
        Me.Controls.Add(Me.LblNotes)
        Me.Controls.Add(Me.TxtNotes)
        Me.Controls.Add(Me.LblInfo)
        Me.Controls.Add(Me.BtnSubmitRequest)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.LblMessage)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "StudentReturnForm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Request Book Return"
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents LblTitle As System.Windows.Forms.Label
    Friend WithEvents LblBook As System.Windows.Forms.Label
    Friend WithEvents TxtBook As System.Windows.Forms.TextBox
    Friend WithEvents LblLoanId As System.Windows.Forms.Label
    Friend WithEvents TxtLoanId As System.Windows.Forms.TextBox
    Friend WithEvents LblDueDate As System.Windows.Forms.Label
    Friend WithEvents TxtDueDate As System.Windows.Forms.TextBox
    Friend WithEvents LblReturnDate As System.Windows.Forms.Label
    Friend WithEvents DtpReturnDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents LblCondition As System.Windows.Forms.Label
    Friend WithEvents CmbCondition As System.Windows.Forms.ComboBox
    Friend WithEvents LblNotes As System.Windows.Forms.Label
    Friend WithEvents TxtNotes As System.Windows.Forms.TextBox
    Friend WithEvents LblInfo As System.Windows.Forms.Label
    Friend WithEvents BtnSubmitRequest As System.Windows.Forms.Button
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents LblMessage As System.Windows.Forms.Label

End Class
