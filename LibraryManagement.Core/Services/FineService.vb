Option Strict On
Option Explicit On

Imports System.Data

''' <summary>Fines and payments. Balances are derived from the payments table (see vw_fines).</summary>
Public Class FineService
    Public Shared ReadOnly StatusFilters As String() = {"All", "Unpaid", "Partially Paid", "Paid"}
    Public Shared ReadOnly PaymentMethods As String() = {"Cash", "M-Pesa", "Bank Transfer", "Card"}

    Public Function Search(term As String, status As String) As DataTable
        Guard.RequireLibrarian()
        Return Db.Query(
            "SELECT fine_id AS `Fine ID`, student_name AS Student, admission_no AS `Admission No`, book_title AS Book, " &
            "amount AS Amount, paid AS Paid, balance AS Balance, status AS Status FROM vw_fines " &
            "WHERE CONCAT_WS(' ', student_name, admission_no, fine_id) LIKE @like AND (@st = 'All' OR status = @st) ORDER BY fine_id DESC",
            Db.P("@like", Db.LikePattern(term)), Db.P("@st", If(status, "All")))
    End Function

    Public Sub RecordPayment(fineId As Integer, amount As Decimal, method As String)
        Dim librarian As UserAccount = Guard.RequireLibrarian()
        Validator.Require(method, "Payment method")
        amount = Math.Round(amount, 2)
        If amount <= 0D Then Throw New BusinessRuleException("The payment amount must be greater than zero.")
        Using session As New DbSession(True)
            session.Scalar("SELECT fine_id FROM fines WHERE fine_id = @f FOR UPDATE", Db.P("@f", fineId))
            Dim balance As Object = session.Scalar("SELECT balance FROM vw_fines WHERE fine_id = @f", Db.P("@f", fineId))
            If balance Is Nothing Then Throw New BusinessRuleException("Fine not found.")
            If amount > Db.AsDecimal(balance) Then Throw New BusinessRuleException("The payment cannot be more than the outstanding balance.")
            session.Execute("INSERT INTO payments (fine_id, amount, method, recorded_by) VALUES (@f, @a, @m, @u)",
                            Db.P("@f", fineId), Db.P("@a", amount), Db.P("@m", method), Db.P("@u", librarian.UserId))
            session.Commit()
        End Using
    End Sub

    ''' <summary>Payment history of one fine. Students can only see their own fines.</summary>
    Public Function GetPayments(fineId As Integer) As DataTable
        Dim user As UserAccount = Guard.RequireLogin()
        Dim studentFilter As Integer = If(user.IsStudent, user.StudentId, 0)
        Return Db.Query(
            "SELECT p.paid_at AS `Paid On`, p.amount AS Amount, p.method AS Method, CONCAT(u.first_name, ' ', u.last_name) AS `Recorded By` " &
            "FROM payments p JOIN fines f ON f.fine_id = p.fine_id JOIN loans l ON l.loan_id = f.loan_id JOIN users u ON u.user_id = p.recorded_by " &
            "WHERE p.fine_id = @f AND (@s = 0 OR l.student_id = @s) ORDER BY p.paid_at",
            Db.P("@f", fineId), Db.P("@s", studentFilter))
    End Function

    Public Function GetMyFines(status As String) As DataTable
        Dim studentId As Integer = Guard.RequireStudent()
        Return Db.Query(
            "SELECT fine_id AS `Fine ID`, book_title AS Book, created_at AS `Date`, amount AS Amount, paid AS Paid, balance AS Balance, status AS Status " &
            "FROM vw_fines WHERE student_id = @s AND (@st = 'All' OR status = @st) ORDER BY fine_id DESC",
            Db.P("@s", studentId), Db.P("@st", If(status, "All")))
    End Function

    ''' <summary>Totals for the logged-in student: total fines, total paid, balance.</summary>
    Public Sub GetMyTotals(ByRef total As Decimal, ByRef paid As Decimal, ByRef balance As Decimal)
        Dim studentId As Integer = Guard.RequireStudent()
        Dim t As DataTable = Db.Query("SELECT COALESCE(SUM(amount), 0) AS total, COALESCE(SUM(paid), 0) AS paid, COALESCE(SUM(balance), 0) AS balance " &
                                      "FROM vw_fines WHERE student_id = @s", Db.P("@s", studentId))
        total = Db.AsDecimal(t.Rows(0)("total"))
        paid = Db.AsDecimal(t.Rows(0)("paid"))
        balance = Db.AsDecimal(t.Rows(0)("balance"))
    End Sub
End Class
