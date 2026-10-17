<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BookDetailsForm
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
        Me.PicCover = New System.Windows.Forms.PictureBox()
        Me.LblBookTitle = New System.Windows.Forms.Label()
        Me.LblAuthor = New System.Windows.Forms.Label()
        Me.LblIsbn = New System.Windows.Forms.Label()
        Me.LblCategory = New System.Windows.Forms.Label()
        Me.LblPublisher = New System.Windows.Forms.Label()
        Me.LblYear = New System.Windows.Forms.Label()
        Me.LblAvailability = New System.Windows.Forms.Label()
        Me.LblDescription = New System.Windows.Forms.Label()
        Me.TxtDescription = New System.Windows.Forms.TextBox()
        Me.BtnBorrow = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
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
        Me.LblTitle.Text = "Book Details"
        Me.LblTitle.TabIndex = 0
        '
        'PicCover
        '
        Me.PicCover.Location = New System.Drawing.Point(28, 56)
        Me.PicCover.Name = "PicCover"
        Me.PicCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicCover.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PicCover.Size = New System.Drawing.Size(170, 215)
        Me.PicCover.TabIndex = 1
        '
        'LblBookTitle
        '
        Me.LblBookTitle.AutoSize = False
        Me.LblBookTitle.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBookTitle.Location = New System.Drawing.Point(216, 56)
        Me.LblBookTitle.Name = "LblBookTitle"
        Me.LblBookTitle.Size = New System.Drawing.Size(376, 52)
        Me.LblBookTitle.Text = "Title"
        Me.LblBookTitle.TabIndex = 2
        '
        'LblAuthor
        '
        Me.LblAuthor.AutoSize = False
        Me.LblAuthor.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAuthor.Location = New System.Drawing.Point(216, 112)
        Me.LblAuthor.Name = "LblAuthor"
        Me.LblAuthor.Size = New System.Drawing.Size(376, 22)
        Me.LblAuthor.Text = "Author:"
        Me.LblAuthor.TabIndex = 3
        '
        'LblIsbn
        '
        Me.LblIsbn.AutoSize = False
        Me.LblIsbn.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblIsbn.Location = New System.Drawing.Point(216, 136)
        Me.LblIsbn.Name = "LblIsbn"
        Me.LblIsbn.Size = New System.Drawing.Size(376, 22)
        Me.LblIsbn.Text = "ISBN:"
        Me.LblIsbn.TabIndex = 4
        '
        'LblCategory
        '
        Me.LblCategory.AutoSize = False
        Me.LblCategory.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCategory.Location = New System.Drawing.Point(216, 160)
        Me.LblCategory.Name = "LblCategory"
        Me.LblCategory.Size = New System.Drawing.Size(376, 22)
        Me.LblCategory.Text = "Category:"
        Me.LblCategory.TabIndex = 5
        '
        'LblPublisher
        '
        Me.LblPublisher.AutoSize = False
        Me.LblPublisher.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPublisher.Location = New System.Drawing.Point(216, 184)
        Me.LblPublisher.Name = "LblPublisher"
        Me.LblPublisher.Size = New System.Drawing.Size(376, 22)
        Me.LblPublisher.Text = "Publisher:"
        Me.LblPublisher.TabIndex = 6
        '
        'LblYear
        '
        Me.LblYear.AutoSize = False
        Me.LblYear.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblYear.Location = New System.Drawing.Point(216, 208)
        Me.LblYear.Name = "LblYear"
        Me.LblYear.Size = New System.Drawing.Size(376, 22)
        Me.LblYear.Text = "Publication Year:"
        Me.LblYear.TabIndex = 7
        '
        'LblAvailability
        '
        Me.LblAvailability.AutoSize = False
        Me.LblAvailability.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAvailability.Location = New System.Drawing.Point(216, 236)
        Me.LblAvailability.Name = "LblAvailability"
        Me.LblAvailability.Size = New System.Drawing.Size(376, 22)
        Me.LblAvailability.Text = "Available Copies:"
        Me.LblAvailability.TabIndex = 8
        '
        'LblDescription
        '
        Me.LblDescription.AutoSize = True
        Me.LblDescription.Location = New System.Drawing.Point(28, 282)
        Me.LblDescription.Name = "LblDescription"
        Me.LblDescription.Text = "Description:"
        Me.LblDescription.TabIndex = 9
        '
        'TxtDescription
        '
        Me.TxtDescription.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TxtDescription.Location = New System.Drawing.Point(28, 306)
        Me.TxtDescription.MaxLength = 1000
        Me.TxtDescription.Multiline = True
        Me.TxtDescription.Name = "TxtDescription"
        Me.TxtDescription.ReadOnly = True
        Me.TxtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtDescription.Size = New System.Drawing.Size(564, 80)
        Me.TxtDescription.TabIndex = 10
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
        Me.BtnBorrow.Location = New System.Drawing.Point(28, 402)
        Me.BtnBorrow.Name = "BtnBorrow"
        Me.BtnBorrow.Size = New System.Drawing.Size(150, 36)
        Me.BtnBorrow.Text = "Borrow Book"
        Me.BtnBorrow.UseVisualStyleBackColor = False
        Me.BtnBorrow.TabIndex = 11
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.Color.White
        Me.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.BtnClose.FlatAppearance.BorderSize = 1
        Me.BtnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClose.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnClose.Location = New System.Drawing.Point(188, 402)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(110, 36)
        Me.BtnClose.Text = "Close"
        Me.BtnClose.UseVisualStyleBackColor = False
        Me.BtnClose.TabIndex = 12
        '
        'LblMessage
        '
        Me.LblMessage.AutoSize = True
        Me.LblMessage.ForeColor = System.Drawing.Color.Firebrick
        Me.LblMessage.Location = New System.Drawing.Point(28, 450)
        Me.LblMessage.Name = "LblMessage"
        Me.LblMessage.Text = ""
        Me.LblMessage.TabIndex = 13
        '
        'BookDetailsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.CancelButton = Me.BtnClose
        Me.ClientSize = New System.Drawing.Size(620, 500)
        Me.Controls.Add(Me.LblTitle)
        Me.Controls.Add(Me.PicCover)
        Me.Controls.Add(Me.LblBookTitle)
        Me.Controls.Add(Me.LblAuthor)
        Me.Controls.Add(Me.LblIsbn)
        Me.Controls.Add(Me.LblCategory)
        Me.Controls.Add(Me.LblPublisher)
        Me.Controls.Add(Me.LblYear)
        Me.Controls.Add(Me.LblAvailability)
        Me.Controls.Add(Me.LblDescription)
        Me.Controls.Add(Me.TxtDescription)
        Me.Controls.Add(Me.BtnBorrow)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.LblMessage)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "BookDetailsForm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Book Details"
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents LblTitle As System.Windows.Forms.Label
    Friend WithEvents PicCover As System.Windows.Forms.PictureBox
    Friend WithEvents LblBookTitle As System.Windows.Forms.Label
    Friend WithEvents LblAuthor As System.Windows.Forms.Label
    Friend WithEvents LblIsbn As System.Windows.Forms.Label
    Friend WithEvents LblCategory As System.Windows.Forms.Label
    Friend WithEvents LblPublisher As System.Windows.Forms.Label
    Friend WithEvents LblYear As System.Windows.Forms.Label
    Friend WithEvents LblAvailability As System.Windows.Forms.Label
    Friend WithEvents LblDescription As System.Windows.Forms.Label
    Friend WithEvents TxtDescription As System.Windows.Forms.TextBox
    Friend WithEvents BtnBorrow As System.Windows.Forms.Button
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents LblMessage As System.Windows.Forms.Label

End Class
