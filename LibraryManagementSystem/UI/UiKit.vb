Option Strict On
Option Explicit On

Imports System.Data
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.IO
Imports System.Windows.Forms
Imports LibraryManagement.Core

''' <summary>The green-and-white palette and fonts used on every form (consistency).</summary>
Friend Module Theme
    Friend ReadOnly Primary As Color = Color.FromArgb(27, 94, 32)
    Friend ReadOnly PrimaryHover As Color = Color.FromArgb(46, 125, 50)
    Friend ReadOnly Tint As Color = Color.FromArgb(232, 245, 233)
    Friend ReadOnly PageBack As Color = Color.WhiteSmoke
    Friend ReadOnly Danger As Color = Color.Firebrick
    Friend ReadOnly Warning As Color = Color.DarkOrange
    Friend ReadOnly BodyFont As New Font("Segoe UI", 10.0F)
End Module

Friend Enum ButtonKind
    Primary
    Secondary
    Danger
End Enum

''' <summary>A white statistic card: a caption and a big number.</summary>
Friend Class StatCard
    Inherits Panel

    Friend ReadOnly ValueLabel As Label

    Friend Sub New(baseName As String, title As String, Optional initial As String = "0")
        Name = "pnl" & baseName
        Size = New Size(220, 120)
        BackColor = Color.White
        BorderStyle = BorderStyle.FixedSingle
        Margin = New Padding(0, 0, 16, 16)
        Dim caption As New Label With {.Name = "lbl" & baseName & "Title", .Text = title, .AutoSize = True,
                                       .Location = New Point(14, 14), .ForeColor = Color.DimGray}
        ValueLabel = New Label With {.Name = "lbl" & baseName & "Value", .Text = initial, .AutoSize = True,
                                     .Location = New Point(12, 48), .ForeColor = Theme.Primary,
                                     .Font = New Font("Segoe UI", 22.0F, FontStyle.Bold)}
        Controls.Add(caption)
        Controls.Add(ValueLabel)
    End Sub
End Class

''' <summary>Factory and helper functions so every screen builds controls the same way.</summary>
Friend Module UiKit
    ' ---------------------------------------------------------------- labels
    Friend Function NewTitle(name As String, text As String, Optional size As Single = 20.0F) As Label
        Return New Label With {.Name = name, .Text = text, .AutoSize = True, .ForeColor = Theme.Primary,
                               .Font = New Font("Segoe UI", size, FontStyle.Bold), .Margin = New Padding(0, 0, 0, 10)}
    End Function

    Friend Function NewLabel(name As String, text As String, Optional bold As Boolean = False) As Label
        Dim lbl As New Label With {.Name = name, .Text = text, .AutoSize = True, .Anchor = AnchorStyles.Left,
                                   .Margin = New Padding(3, 6, 8, 6)}
        If bold Then lbl.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        Return lbl
    End Function

    Friend Function NewMessageLabel(name As String) As Label
        Return New Label With {.Name = name, .Text = "", .AutoSize = True, .ForeColor = Theme.Danger, .Margin = New Padding(0, 8, 0, 0)}
    End Function

    Friend Sub ShowMessage(target As Label, text As String, isError As Boolean)
        target.ForeColor = If(isError, Theme.Danger, Theme.Primary)
        target.Text = text
    End Sub

    ' ---------------------------------------------------------------- inputs
    Friend Function NewTextBox(name As String, Optional maxLength As Integer = 0, Optional isReadOnly As Boolean = False,
                               Optional placeholder As String = "") As TextBox
        Dim box As New TextBox With {.Name = name, .Width = 250, .Anchor = AnchorStyles.Left Or AnchorStyles.Right,
                                     .Margin = New Padding(3, 4, 12, 4), .ReadOnly = isReadOnly, .PlaceholderText = placeholder}
        If maxLength > 0 Then box.MaxLength = maxLength
        If isReadOnly Then box.BackColor = Color.FromArgb(240, 240, 240)
        Return box
    End Function

    Friend Function NewPasswordBox(name As String) As TextBox
        Dim box As TextBox = NewTextBox(name, 100)
        box.UseSystemPasswordChar = True
        Return box
    End Function

    Friend Function NewMultiline(name As String, maxLength As Integer, height As Integer, Optional isReadOnly As Boolean = False) As TextBox
        Dim box As TextBox = NewTextBox(name, maxLength, isReadOnly)
        box.Multiline = True
        box.ScrollBars = ScrollBars.Vertical
        box.Height = height
        Return box
    End Function

    Friend Function NewNumeric(name As String, minimum As Decimal, maximum As Decimal, value As Decimal,
                               Optional decimals As Integer = 0) As NumericUpDown
        Dim box As New NumericUpDown With {.Name = name, .DecimalPlaces = decimals, .Width = 140, .Anchor = AnchorStyles.Left,
                                           .Margin = New Padding(3, 4, 12, 4)}
        box.Minimum = minimum
        box.Maximum = maximum
        box.Value = value
        Return box
    End Function

    Friend Function NewCombo(name As String) As ComboBox
        Return New ComboBox With {.Name = name, .DropDownStyle = ComboBoxStyle.DropDownList, .Width = 250,
                                  .Anchor = AnchorStyles.Left Or AnchorStyles.Right, .Margin = New Padding(3, 4, 12, 4)}
    End Function

    Friend Function NewDate(name As String, Optional width As Integer = 150) As DateTimePicker
        Return New DateTimePicker With {.Name = name, .Format = DateTimePickerFormat.Short, .Width = width,
                                        .Anchor = AnchorStyles.Left, .Margin = New Padding(3, 4, 12, 4)}
    End Function

    Friend Function NewCheck(name As String, text As String) As CheckBox
        Return New CheckBox With {.Name = name, .Text = text, .AutoSize = True, .Margin = New Padding(3, 6, 12, 6)}
    End Function

    ''' <summary>Fills a combo box with plain text items and selects the first.</summary>
    Friend Sub FillCombo(combo As ComboBox, items As IEnumerable(Of String))
        combo.DataSource = Nothing
        combo.Items.Clear()
        For Each item As String In items
            combo.Items.Add(item)
        Next
        If combo.Items.Count > 0 Then combo.SelectedIndex = 0
    End Sub

    ''' <summary>Binds a combo box to a lookup table (nothing selected at first).</summary>
    Friend Sub BindLookup(combo As ComboBox, table As DataTable, valueColumn As String, displayColumn As String)
        combo.DataSource = Nothing
        combo.DisplayMember = displayColumn
        combo.ValueMember = valueColumn
        combo.DataSource = table
        combo.SelectedIndex = -1
    End Sub

    Friend Function SelectedId(combo As ComboBox) As Integer
        If combo.SelectedIndex < 0 Then Return 0
        Dim rowView As DataRowView = TryCast(combo.SelectedItem, DataRowView)
        If rowView Is Nothing Then Return 0
        Return Db.AsInt(rowView(combo.ValueMember))
    End Function

    ''' <summary>Runs an action when Enter is pressed in a text box.</summary>
    Friend Sub EnterKeyAction(box As TextBox, action As Action)
        AddHandler box.KeyDown, Sub(sender As Object, e As KeyEventArgs)
                                    If e.KeyCode = Keys.Enter Then
                                        e.SuppressKeyPress = True
                                        action()
                                    End If
                                End Sub
    End Sub

    ' --------------------------------------------------------------- buttons
    Friend Function NewButton(name As String, text As String, Optional kind As ButtonKind = ButtonKind.Primary,
                              Optional width As Integer = 130) As Button
        Dim btn As New Button With {.Name = name, .Text = text, .Size = New Size(width, 38), .FlatStyle = FlatStyle.Flat,
                                    .Font = New Font("Segoe UI", 10.0F, FontStyle.Bold), .Cursor = Cursors.Hand,
                                    .Margin = New Padding(3, 4, 10, 4), .UseVisualStyleBackColor = False}
        btn.FlatAppearance.BorderSize = 1
        Select Case kind
            Case ButtonKind.Primary
                btn.BackColor = Theme.Primary : btn.ForeColor = Color.White
                btn.FlatAppearance.BorderColor = Theme.Primary
                btn.FlatAppearance.MouseOverBackColor = Theme.PrimaryHover
            Case ButtonKind.Danger
                btn.BackColor = Theme.Danger : btn.ForeColor = Color.White
                btn.FlatAppearance.BorderColor = Theme.Danger
                btn.FlatAppearance.MouseOverBackColor = Color.Brown
            Case Else
                btn.BackColor = Color.White : btn.ForeColor = Theme.Primary
                btn.FlatAppearance.BorderColor = Theme.Primary
                btn.FlatAppearance.MouseOverBackColor = Theme.Tint
        End Select
        Return btn
    End Function

    ' ---------------------------------------------------------------- layout
    Friend Function NewToolbar(name As String) As FlowLayoutPanel
        Return New FlowLayoutPanel With {.Name = name, .AutoSize = True, .WrapContents = True, .Margin = New Padding(0, 0, 0, 6)}
    End Function

    Friend Function NewButtonRow(name As String, ParamArray buttons As Control()) As FlowLayoutPanel
        Dim row As FlowLayoutPanel = NewToolbar(name)
        row.Controls.AddRange(buttons)
        Return row
    End Function

    ''' <summary>A label/field table: each "pair" is one label column plus one stretchy field column.</summary>
    Friend Function NewFieldTable(name As String, pairs As Integer) As TableLayoutPanel
        Dim table As New TableLayoutPanel With {.Name = name, .AutoSize = True, .ColumnCount = pairs * 2,
                                                .GrowStyle = TableLayoutPanelGrowStyle.AddRows, .Margin = New Padding(0, 4, 0, 4)}
        For i As Integer = 1 To pairs
            table.ColumnStyles.Add(New ColumnStyle(SizeType.AutoSize))
            table.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, CSng(100.0 / pairs)))
        Next
        Return table
    End Function

    Friend Sub AddField(table As TableLayoutPanel, caption As Label, field As Control)
        table.Controls.Add(caption)
        table.Controls.Add(field)
    End Sub

    ' ------------------------------------------------------------------ grids
    Friend Function NewGrid(name As String) As DataGridView
        Dim grid As New DataGridView With {
            .Name = name, .ReadOnly = True, .AllowUserToAddRows = False, .AllowUserToDeleteRows = False,
            .AllowUserToResizeRows = False, .SelectionMode = DataGridViewSelectionMode.FullRowSelect, .MultiSelect = False,
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill, .BackgroundColor = Color.White,
            .BorderStyle = BorderStyle.FixedSingle, .RowHeadersVisible = False, .EnableHeadersVisualStyles = False,
            .Margin = New Padding(0, 4, 0, 4), .MinimumSize = New Size(200, 120)}
        grid.ColumnHeadersDefaultCellStyle.BackColor = Theme.Primary
        grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        grid.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        grid.ColumnHeadersDefaultCellStyle.SelectionBackColor = Theme.Primary
        grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        grid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(246, 250, 246)
        grid.DefaultCellStyle.SelectionBackColor = Theme.PrimaryHover
        grid.DefaultCellStyle.SelectionForeColor = Color.White
        grid.RowTemplate.Height = 28
        AddHandler grid.CellFormatting, AddressOf StatusCellFormatting
        Return grid
    End Function

    Private Sub StatusCellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs)
        Dim grid As DataGridView = DirectCast(sender, DataGridView)
        If e.RowIndex < 0 OrElse e.ColumnIndex < 0 OrElse e.ColumnIndex >= grid.Columns.Count Then Return
        If grid.Columns(e.ColumnIndex).Name <> "Status" Then Return
        Select Case Convert.ToString(e.Value)
            Case "Overdue", "Unpaid", "Inactive"
                e.CellStyle.ForeColor = Theme.Danger
            Case "Return Requested", "Partially Paid"
                e.CellStyle.ForeColor = Theme.Warning
            Case "Active", "Returned", "Paid"
                e.CellStyle.ForeColor = Theme.Primary
        End Select
    End Sub

    ''' <summary>Shows a table in a grid, hides id columns and formats dates and money.</summary>
    Friend Sub BindGrid(grid As DataGridView, table As DataTable, ParamArray hiddenColumns As String())
        grid.DataSource = table
        For Each col As DataGridViewColumn In grid.Columns
            If col.ValueType Is GetType(Date) Then
                col.DefaultCellStyle.Format = "yyyy-MM-dd"
            ElseIf col.ValueType Is GetType(Decimal) Then
                col.DefaultCellStyle.Format = "N2"
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            End If
        Next
        For Each hidden As String In hiddenColumns
            If grid.Columns.Contains(hidden) Then grid.Columns(hidden).Visible = False
        Next
    End Sub

    Friend Function SelectedRow(grid As DataGridView) As DataGridViewRow
        If grid.CurrentRow Is Nothing OrElse grid.CurrentRow.IsNewRow Then Return Nothing
        Return grid.CurrentRow
    End Function

    Friend Function CellText(row As DataGridViewRow, column As String) As String
        Return Convert.ToString(row.Cells(column).Value, System.Globalization.CultureInfo.InvariantCulture)
    End Function

    Friend Function CellInt(row As DataGridViewRow, column As String) As Integer
        Return Db.AsInt(row.Cells(column).Value)
    End Function

    Friend Function CellDecimal(row As DataGridViewRow, column As String) As Decimal
        Return Db.AsDecimal(row.Cells(column).Value)
    End Function

    Friend Function CellDate(row As DataGridViewRow, column As String) As Date
        Return Db.AsDate(row.Cells(column).Value)
    End Function

    ' -------------------------------------------------------------- messages
    Friend Sub Info(text As String)
        MessageBox.Show(text, "Library Management System", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Friend Sub ShowError(text As String)
        MessageBox.Show(text, "Library Management System", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Friend Function Confirm(text As String) As Boolean
        Return MessageBox.Show(text, "Please confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                               MessageBoxDefaultButton.Button2) = DialogResult.Yes
    End Function

    ''' <summary>Runs an action and converts any exception into a user-friendly message (details go to the log).</summary>
    Friend Function TryRun(action As Action) As String
        Try
            action()
            Return ""
        Catch ex As BusinessRuleException
            Return ex.Message
        Catch ex As UnauthorizedAccessException
            Return ex.Message
        Catch ex As Exception
            ErrorLog.Write(ex)
            Return "Something went wrong. The details were saved to the log file."
        End Try
    End Function

    ' --------------------------------------------------------------- pictures
    Friend Function LoadImageSafe(filePath As String) As Image
        Try
            If String.IsNullOrWhiteSpace(filePath) OrElse Not File.Exists(filePath) Then Return Nothing
            Using stream As New MemoryStream(File.ReadAllBytes(filePath))
                Using img As Image = Image.FromStream(stream)
                    Return New Bitmap(img)
                End Using
            End Using
        Catch
            Return Nothing
        End Try
    End Function

    Friend Function MakeAvatar(size As Integer) As Bitmap
        Dim bmp As New Bitmap(size, size)
        Using g As Graphics = Graphics.FromImage(bmp)
            g.SmoothingMode = SmoothingMode.AntiAlias
            Using clip As New GraphicsPath()
                clip.AddEllipse(0, 0, size - 1, size - 1)
                g.SetClip(clip)
                Using bg As New SolidBrush(Theme.Tint)
                    g.FillEllipse(bg, 0, 0, size - 1, size - 1)
                End Using
                Using fg As New SolidBrush(Theme.PrimaryHover)
                    g.FillEllipse(fg, CInt(size * 0.33), CInt(size * 0.2), CInt(size * 0.34), CInt(size * 0.34))
                    g.FillEllipse(fg, CInt(size * 0.2), CInt(size * 0.62), CInt(size * 0.6), CInt(size * 0.6))
                End Using
            End Using
        End Using
        Return bmp
    End Function

    ''' <summary>A simple generated book cover showing the title.</summary>
    Friend Function MakeCover(title As String, width As Integer, height As Integer) As Bitmap
        Dim bmp As New Bitmap(width, height)
        Using g As Graphics = Graphics.FromImage(bmp)
            g.SmoothingMode = SmoothingMode.AntiAlias
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
            Using brush As New LinearGradientBrush(New Rectangle(0, 0, width, height), Theme.Primary, Theme.PrimaryHover, 60.0F)
                g.FillRectangle(brush, 0, 0, width, height)
            End Using
            Using spine As New SolidBrush(Color.FromArgb(60, 0, 0, 0))
                g.FillRectangle(spine, 0, 0, 12, height)
            End Using
            Using font As New Font("Segoe UI", 12.0F, FontStyle.Bold)
                Using format As New StringFormat With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center}
                    g.DrawString(title, font, Brushes.White, New RectangleF(20, 10, width - 30, height - 20), format)
                End Using
            End Using
        End Using
        Return bmp
    End Function

    Friend Function MakeLogo(size As Integer) As Bitmap
        Dim bmp As New Bitmap(size, size)
        Using g As Graphics = Graphics.FromImage(bmp)
            g.SmoothingMode = SmoothingMode.AntiAlias
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
            Using bg As New SolidBrush(Theme.Primary)
                g.FillEllipse(bg, 0, 0, size - 1, size - 1)
            End Using
            Using font As New Font("Segoe UI", size / 4.0F, FontStyle.Bold)
                Using format As New StringFormat With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center}
                    g.DrawString("LMS", font, Brushes.White, New RectangleF(0, 0, size, size), format)
                End Using
            End Using
        End Using
        Return bmp
    End Function
End Module
