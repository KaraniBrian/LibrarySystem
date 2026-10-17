Option Strict On
Option Explicit On

Imports System.Drawing
Imports System.Drawing.Printing
Imports System.Windows.Forms

''' <summary>Prints the visible rows of a DataGridView (landscape, paged) via a print preview window.</summary>
Friend NotInheritable Class GridPrinter
    Private ReadOnly _grid As DataGridView
    Private ReadOnly _title As String
    Private _nextRow As Integer
    Private _page As Integer

    Private Sub New(grid As DataGridView, title As String)
        _grid = grid
        _title = title
    End Sub

    Friend Shared Sub ShowPreview(grid As DataGridView, title As String, owner As IWin32Window)
        Dim printer As New GridPrinter(grid, title)
        Using doc As New PrintDocument()
            doc.DefaultPageSettings.Landscape = True
            doc.DocumentName = title
            AddHandler doc.BeginPrint, Sub(sender As Object, e As PrintEventArgs)
                                           printer._nextRow = 0
                                           printer._page = 0
                                       End Sub
            AddHandler doc.PrintPage, AddressOf printer.OnPrintPage
            Using preview As New PrintPreviewDialog() With {.Document = doc, .Width = 1000, .Height = 650}
                preview.ShowDialog(owner)
            End Using
        End Using
    End Sub

    Private Sub OnPrintPage(sender As Object, e As PrintPageEventArgs)
        Dim g As Graphics = e.Graphics
        Dim bounds As Rectangle = e.MarginBounds
        Dim columns As New List(Of DataGridViewColumn)()
        For Each gridColumn As DataGridViewColumn In _grid.Columns
            If gridColumn.Visible Then columns.Add(gridColumn)
        Next
        If columns.Count = 0 Then Return
        _page += 1

        Using titleFont As New Font("Segoe UI", 16.0F, FontStyle.Bold),
              headerFont As New Font("Segoe UI", 9.0F, FontStyle.Bold),
              bodyFont As New Font("Segoe UI", 9.0F),
              format As New StringFormat With {.Trimming = StringTrimming.EllipsisCharacter, .FormatFlags = StringFormatFlags.NoWrap}

            Dim y As Single = bounds.Top
            g.DrawString(_title & " (" & Date.Today.ToString("yyyy-MM-dd") & ")", titleFont, Brushes.DarkGreen, bounds.Left, y)
            y += 40
            Dim colWidth As Single = bounds.Width / CSng(columns.Count)
            Dim rowHeight As Single = 22

            For i As Integer = 0 To columns.Count - 1
                Dim cell As New RectangleF(bounds.Left + i * colWidth, y, colWidth, rowHeight)
                g.FillRectangle(Brushes.Gainsboro, cell)
                g.DrawString(columns(i).HeaderText, headerFont, Brushes.Black, New RectangleF(cell.X + 2, cell.Y + 3, cell.Width - 4, cell.Height), format)
            Next
            y += rowHeight

            Do While _nextRow < _grid.Rows.Count
                If y + rowHeight > bounds.Bottom - 20 Then Exit Do
                Dim row As DataGridViewRow = _grid.Rows(_nextRow)
                For i As Integer = 0 To columns.Count - 1
                    Dim text As String = Convert.ToString(row.Cells(columns(i).Index).FormattedValue)
                    g.DrawString(text, bodyFont, Brushes.Black, New RectangleF(bounds.Left + i * colWidth + 2, y + 3, colWidth - 4, rowHeight), format)
                Next
                g.DrawLine(Pens.LightGray, bounds.Left, y + rowHeight, bounds.Right, y + rowHeight)
                y += rowHeight
                _nextRow += 1
            Loop
            g.DrawString("Page " & _page.ToString(), bodyFont, Brushes.Gray, bounds.Right - 50, bounds.Bottom)
        End Using
        e.HasMorePages = _nextRow < _grid.Rows.Count
    End Sub
End Class
