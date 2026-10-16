Option Strict On
Option Explicit On

Imports System.Data
Imports System.Globalization
Imports System.IO
Imports System.Text

''' <summary>Builds the seven report types and exports tables to CSV.</summary>
Public Class ReportService
    Public Shared ReadOnly ReportTypes As String() = {
        "Book Inventory", "Registered Students", "Current Loans", "Overdue Books",
        "Returned Books", "Outstanding Fines", "Payment History"}

    ''' <summary>Generates a report. The date range applies to Returned Books and Payment History.</summary>
    Public Function Generate(reportType As String, fromDate As Date, toDate As Date) As DataTable
        Guard.RequireLibrarian()
        If fromDate.Date > toDate.Date Then Throw New BusinessRuleException("The 'From' date must not be after the 'To' date.")
        Select Case reportType
            Case "Book Inventory"
                Dim t As DataTable = New BookService().Search("", 0, "All")
                t.Columns.Remove("Id")
                Return t
            Case "Registered Students"
                Dim t As DataTable = New StudentService().Search("")
                t.Columns.Remove("Id")
                Return t
            Case "Current Loans"
                Return Db.Query("SELECT loan_id AS `Loan ID`, student_name AS Student, admission_no AS `Admission No`, book_title AS Book, " &
                                "issue_date AS `Issue Date`, due_date AS `Due Date`, status AS Status FROM vw_loans WHERE status <> 'Returned' ORDER BY due_date")
            Case "Overdue Books"
                Return Db.Query("SELECT loan_id AS `Loan ID`, student_name AS Student, admission_no AS `Admission No`, book_title AS Book, " &
                                "due_date AS `Due Date`, DATEDIFF(CURDATE(), due_date) AS `Days Overdue` FROM vw_loans WHERE status = 'Overdue' ORDER BY due_date")
            Case "Returned Books"
                Return Db.Query("SELECT loan_id AS `Loan ID`, student_name AS Student, book_title AS Book, issue_date AS `Issue Date`, " &
                                "due_date AS `Due Date`, return_date AS `Return Date` FROM vw_loans " &
                                "WHERE status = 'Returned' AND return_date BETWEEN @f AND @t ORDER BY return_date DESC",
                                Db.P("@f", fromDate.Date), Db.P("@t", toDate.Date))
            Case "Outstanding Fines"
                Return Db.Query("SELECT fine_id AS `Fine ID`, student_name AS Student, admission_no AS `Admission No`, book_title AS Book, " &
                                "amount AS Amount, paid AS Paid, balance AS Balance FROM vw_fines WHERE balance > 0 ORDER BY balance DESC")
            Case "Payment History"
                Return Db.Query("SELECT p.payment_id AS `Payment ID`, p.paid_at AS `Paid On`, v.student_name AS Student, v.book_title AS Book, " &
                                "p.amount AS Amount, p.method AS Method FROM payments p JOIN vw_fines v ON v.fine_id = p.fine_id " &
                                "WHERE DATE(p.paid_at) BETWEEN @f AND @t ORDER BY p.paid_at DESC",
                                Db.P("@f", fromDate.Date), Db.P("@t", toDate.Date))
            Case Else
                Throw New BusinessRuleException("Please choose a report type.")
        End Select
    End Function

    ''' <summary>One-line summary: row count plus totals for money reports.</summary>
    Public Shared Function Summarize(reportType As String, table As DataTable, currency As String) As String
        Dim text As String = "Report: " & reportType & vbCrLf & "Rows: " & table.Rows.Count.ToString(CultureInfo.InvariantCulture)
        If reportType = "Outstanding Fines" AndAlso table.Rows.Count > 0 Then
            text &= vbCrLf & "Total outstanding: " & Formatting.Money(Db.AsDecimal(table.Compute("SUM(Balance)", "")), currency)
        ElseIf reportType = "Payment History" AndAlso table.Rows.Count > 0 Then
            text &= vbCrLf & "Total collected: " & Formatting.Money(Db.AsDecimal(table.Compute("SUM(Amount)", "")), currency)
        End If
        Return text
    End Function

    ''' <summary>Writes a table to a CSV file (UTF-8 with BOM so Excel opens it correctly).</summary>
    Public Shared Sub ExportCsv(table As DataTable, filePath As String)
        Dim sb As New StringBuilder()
        sb.AppendLine(String.Join(",", table.Columns.Cast(Of DataColumn)().Select(Function(c As DataColumn) CsvCell(c.ColumnName))))
        For Each row As DataRow In table.Rows
            Dim cells As New List(Of String)()
            For Each col As DataColumn In table.Columns
                cells.Add(CsvCell(row(col)))
            Next
            sb.AppendLine(String.Join(",", cells))
        Next
        File.WriteAllText(filePath, sb.ToString(), New UTF8Encoding(True))
    End Sub

    ''' <summary>Quotes a cell and neutralises spreadsheet formulas (CSV injection).</summary>
    Public Shared Function CsvCell(value As Object) As String
        If value Is Nothing OrElse IsDBNull(value) Then Return ""
        Dim text As String
        If TypeOf value Is DateTime Then
            text = CDate(value).ToString("yyyy-MM-dd", CultureInfo.InvariantCulture)
        ElseIf TypeOf value Is IFormattable Then
            text = DirectCast(value, IFormattable).ToString(Nothing, CultureInfo.InvariantCulture)
        Else
            text = Convert.ToString(value, CultureInfo.InvariantCulture)
            If text.Length > 0 AndAlso "=+-@".IndexOf(text(0)) >= 0 Then text = "'" & text
        End If
        Return """" & text.Replace("""", """""") & """"
    End Function
End Class
