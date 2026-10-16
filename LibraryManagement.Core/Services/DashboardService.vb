Option Strict On
Option Explicit On

Imports System.Data

''' <summary>Live numbers for the two dashboards.</summary>
Public Class DashboardService
    Public Function GetLibrarianStats() As LibrarianStats
        Guard.RequireLibrarian()
        Return New LibrarianStats With {
            .TotalCopies = Db.AsInt(Db.Scalar("SELECT COUNT(*) FROM book_copies")),
            .ActiveStudents = Db.AsInt(Db.Scalar("SELECT COUNT(*) FROM students s JOIN users u ON u.user_id = s.user_id WHERE u.is_active = 1")),
            .ActiveLoans = Db.AsInt(Db.Scalar("SELECT COUNT(*) FROM loans WHERE status <> 'Returned'")),
            .OverdueLoans = Db.AsInt(Db.Scalar("SELECT COUNT(*) FROM vw_loans WHERE status = 'Overdue'"))}
    End Function

    Public Function GetRecentBorrowings() As DataTable
        Guard.RequireLibrarian()
        Return Db.Query("SELECT loan_id AS `Loan ID`, student_name AS Student, book_title AS Book, issue_date AS `Issue Date`, due_date AS `Due Date`, status AS Status " &
                        "FROM vw_loans ORDER BY loan_id DESC LIMIT 10")
    End Function

    Public Function GetStudentStats() As StudentStats
        Dim studentId As Integer = Guard.RequireStudent()
        Dim p As KeyValuePair(Of String, Object) = Db.P("@s", studentId)
        Return New StudentStats With {
            .Borrowed = Db.AsInt(Db.Scalar("SELECT COUNT(*) FROM loans WHERE student_id = @s AND status <> 'Returned'", p)),
            .DueSoon = Db.AsInt(Db.Scalar("SELECT COUNT(*) FROM loans WHERE student_id = @s AND status = 'Active' AND due_date BETWEEN CURDATE() AND CURDATE() + INTERVAL 3 DAY", p)),
            .Overdue = Db.AsInt(Db.Scalar("SELECT COUNT(*) FROM vw_loans WHERE student_id = @s AND status = 'Overdue'", p)),
            .FineBalance = Db.AsDecimal(Db.Scalar("SELECT COALESCE(SUM(balance), 0) FROM vw_fines WHERE student_id = @s", p))}
    End Function

    Public Function GetMyRecentBorrowings() As DataTable
        Dim studentId As Integer = Guard.RequireStudent()
        Return Db.Query("SELECT loan_id AS `Loan ID`, book_title AS Book, issue_date AS `Borrow Date`, due_date AS `Due Date`, status AS Status " &
                        "FROM vw_loans WHERE student_id = @s ORDER BY loan_id DESC LIMIT 10", Db.P("@s", studentId))
    End Function
End Class
