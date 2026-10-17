Option Strict On
Option Explicit On

Imports System.Data
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.IO
Imports System.Windows.Forms
Imports LibraryManagement.Core

''' <summary>The green-and-white palette used by every form (consistency).</summary>
Friend Module Theme
    Friend ReadOnly Primary As Color = Color.FromArgb(27, 94, 32)
    Friend ReadOnly PrimaryHover As Color = Color.FromArgb(46, 125, 50)
    Friend ReadOnly ActiveNav As Color = Color.FromArgb(56, 142, 60)
    Friend ReadOnly Tint As Color = Color.FromArgb(232, 245, 233)
    Friend ReadOnly Danger As Color = Color.Firebrick
    Friend ReadOnly Warning As Color = Color.DarkOrange
End Module

''' <summary>Small helpers shared by the forms. Controls themselves are placed in each form's Designer.</summary>
Friend Module UiKit
    ' -------------------------------------------------------------- messages
    Friend Sub ShowMessage(target As Label, text As String, isError As Boolean)
        target.ForeColor = If(isError, Theme.Danger, Theme.Primary)
        target.Text = text
    End Sub

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

    ''' <summary>Runs an action; on failure shows the message in the given label and returns False.</summary>
    Friend Function Run(action As Action, messageLabel As Label) As Boolean
        Dim problem As String = TryRun(action)
        If problem = "" Then Return True
        ShowMessage(messageLabel, problem, True)
        Return False
    End Function

    ' ---------------------------------------------------------------- combos
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

    ' ------------------------------------------------------------------ grids
    ''' <summary>Colours the Status column (red = overdue/unpaid, orange = pending, green = fine).</summary>
    Friend Sub StatusColors(grid As DataGridView)
        AddHandler grid.CellFormatting, AddressOf StatusCellFormatting
    End Sub

    Private Sub StatusCellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs)
        Dim grid As DataGridView = DirectCast(sender, DataGridView)
        If e.RowIndex < 0 OrElse e.ColumnIndex < 0 OrElse e.ColumnIndex >= grid.Columns.Count Then Return
        If grid.Columns(e.ColumnIndex).DataPropertyName <> "Status" Then Return
        Select Case Convert.ToString(e.Value)
            Case "Overdue", "Unpaid", "Inactive"
                e.CellStyle.ForeColor = Theme.Danger
            Case "Return Requested", "Partially Paid"
                e.CellStyle.ForeColor = Theme.Warning
            Case "Active", "Returned", "Paid"
                e.CellStyle.ForeColor = Theme.Primary
        End Select
    End Sub

    ''' <summary>Shows a table in a grid. Grids designed with columns keep their layout; others get formats applied.</summary>
    Friend Sub BindGrid(grid As DataGridView, table As DataTable)
        grid.DataSource = table
        If Not grid.AutoGenerateColumns Then Return
        For Each gridColumn As DataGridViewColumn In grid.Columns
            If gridColumn.ValueType Is GetType(Date) Then
                gridColumn.DefaultCellStyle.Format = "yyyy-MM-dd"
            ElseIf gridColumn.ValueType Is GetType(Decimal) Then
                gridColumn.DefaultCellStyle.Format = "N2"
                gridColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            End If
        Next
    End Sub

    Friend Sub ClearGridSelection(grid As DataGridView)
        grid.ClearSelection()
        grid.CurrentCell = Nothing
    End Sub

    Friend Function SelectedRow(grid As DataGridView) As DataGridViewRow
        If grid.CurrentRow Is Nothing OrElse grid.CurrentRow.IsNewRow Then Return Nothing
        If grid.SelectedRows.Count = 0 Then Return Nothing
        Return grid.CurrentRow
    End Function

    ''' <summary>Reads a value from the bound DataTable row behind a grid row (by SQL column name).</summary>
    Friend Function CellValue(row As DataGridViewRow, column As String) As Object
        Dim view As DataRowView = TryCast(row.DataBoundItem, DataRowView)
        If view Is Nothing Then Return Nothing
        Return view(column)
    End Function

    Friend Function CellText(row As DataGridViewRow, column As String) As String
        Return Db.AsString(CellValue(row, column))
    End Function

    Friend Function CellInt(row As DataGridViewRow, column As String) As Integer
        Return Db.AsInt(CellValue(row, column))
    End Function

    Friend Function CellDecimal(row As DataGridViewRow, column As String) As Decimal
        Return Db.AsDecimal(CellValue(row, column))
    End Function

    Friend Function CellDate(row As DataGridViewRow, column As String) As Date
        Return Db.AsDate(CellValue(row, column))
    End Function

    ' ------------------------------------------------------------ navigation
    ''' <summary>Shows a page inside the dashboard's content panel and highlights the active sidebar button.</summary>
    Friend Sub ShowPage(host As Panel, sidebar As Panel, active As Button, ByRef current As Form, page As Form)
        Try
            page.TopLevel = False
            page.FormBorderStyle = FormBorderStyle.None
            page.Dock = DockStyle.Fill
            host.Controls.Add(page)
            page.Show()
            page.BringToFront()
            If current IsNot Nothing Then
                host.Controls.Remove(current)
                current.Dispose()
            End If
            current = page
            For Each navButton As Button In sidebar.Controls.OfType(Of Button)()
                navButton.BackColor = If(navButton Is active, Theme.ActiveNav, Color.DarkGreen)
            Next
        Catch ex As Exception
            ErrorLog.Write(ex)
            ShowError("The page could not be opened. Details were saved to the log file.")
        End Try
    End Sub

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
            Using coverFont As New Font("Segoe UI", 12.0F, FontStyle.Bold)
                Using format As New StringFormat With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center}
                    g.DrawString(title, coverFont, Brushes.White, New RectangleF(20, 10, width - 30, height - 20), format)
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
            Using logoFont As New Font("Segoe UI", size / 4.0F, FontStyle.Bold)
                Using format As New StringFormat With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center}
                    g.DrawString("LMS", logoFont, Brushes.White, New RectangleF(0, 0, size, size), format)
                End Using
            End Using
        End Using
        Return bmp
    End Function
End Module
