Option Strict On
Option Explicit On

Imports System.Data

''' <summary>Student management (librarian only). A student is a users row plus a students row.</summary>
Public Class StudentService
    ''' <summary>Password given to new students and after a reset. They should change it at first login.</summary>
    Public Const DefaultPassword As String = "Student@123"

    Public Function Search(term As String) As DataTable
        Guard.RequireLibrarian()
        Return Db.Query(
            "SELECT s.student_id AS Id, s.admission_no AS `Admission No`, u.first_name AS `First Name`, u.last_name AS `Last Name`, " &
            "u.email AS Email, COALESCE(u.phone, '') AS Phone, IF(u.is_active = 1, 'Active', 'Inactive') AS Status " &
            "FROM students s JOIN users u ON u.user_id = s.user_id " &
            "WHERE CONCAT_WS(' ', u.first_name, u.last_name, u.email, s.admission_no) LIKE @like " &
            "ORDER BY u.first_name, u.last_name", Db.P("@like", Db.LikePattern(term)))
    End Function

    ''' <summary>Active students for drop-down lists: columns student_id, label.</summary>
    Public Function GetActiveLookup() As DataTable
        Guard.RequireLibrarian()
        Return Db.Query(
            "SELECT s.student_id, CONCAT(u.first_name, ' ', u.last_name, ' (', s.admission_no, ')') AS label " &
            "FROM students s JOIN users u ON u.user_id = s.user_id WHERE u.is_active = 1 ORDER BY u.first_name, u.last_name")
    End Function

    Private Shared Sub Validate(rec As StudentRecord)
        Validator.Require(rec.FirstName, "First name")
        Validator.Require(rec.LastName, "Last name")
        Validator.Require(rec.AdmissionNo, "Admission number")
        Validator.MaxLength(rec.FirstName, 100, "First name")
        Validator.MaxLength(rec.LastName, 100, "Last name")
        Validator.MaxLength(rec.AdmissionNo, 50, "Admission number")
        Validator.MaxLength(rec.Email, 255, "Email")
        Validator.Email(rec.Email)
        Validator.Phone(rec.Phone)
    End Sub

    Private Shared Sub EnsureUnique(session As DbSession, rec As StudentRecord)
        Dim emailCount As Integer = Db.AsInt(session.Scalar(
            "SELECT COUNT(*) FROM users u LEFT JOIN students s ON s.user_id = u.user_id WHERE u.email = @e AND (s.student_id IS NULL OR s.student_id <> @id)",
            Db.P("@e", rec.Email.Trim()), Db.P("@id", rec.StudentId)))
        If emailCount > 0 Then Throw New BusinessRuleException("Another account already uses this email address.")
        Dim admissionCount As Integer = Db.AsInt(session.Scalar(
            "SELECT COUNT(*) FROM students WHERE admission_no = @a AND student_id <> @id",
            Db.P("@a", rec.AdmissionNo.Trim()), Db.P("@id", rec.StudentId)))
        If admissionCount > 0 Then Throw New BusinessRuleException("Another student already has this admission number.")
    End Sub

    Public Sub Add(rec As StudentRecord)
        Guard.RequireLibrarian()
        Validate(rec)
        Using session As New DbSession(True)
            EnsureUnique(session, rec)
            Dim userId As Integer = session.Insert(
                "INSERT INTO users (role_id, email, password_hash, first_name, last_name, phone, is_active) " &
                "VALUES ((SELECT role_id FROM roles WHERE role_name = 'Student'), @e, @h, @f, @l, @p, @a)",
                Db.P("@e", rec.Email.Trim()), Db.P("@h", PasswordHasher.Hash(DefaultPassword)),
                Db.P("@f", rec.FirstName.Trim()), Db.P("@l", rec.LastName.Trim()),
                Db.P("@p", If(String.IsNullOrWhiteSpace(rec.Phone), Nothing, rec.Phone.Trim())), Db.P("@a", rec.IsActive))
            session.Execute("INSERT INTO students (user_id, admission_no) VALUES (@u, @a)",
                            Db.P("@u", userId), Db.P("@a", rec.AdmissionNo.Trim()))
            session.Commit()
        End Using
    End Sub

    Public Sub Update(rec As StudentRecord)
        Guard.RequireLibrarian()
        If rec.StudentId <= 0 Then Throw New BusinessRuleException("Select a student first.")
        Validate(rec)
        Using session As New DbSession(True)
            EnsureUnique(session, rec)
            If Not rec.IsActive Then EnsureNoOpenLoans(session, rec.StudentId)
            session.Execute(
                "UPDATE users u JOIN students s ON s.user_id = u.user_id " &
                "SET u.first_name = @f, u.last_name = @l, u.email = @e, u.phone = @p, u.is_active = @a, s.admission_no = @adm " &
                "WHERE s.student_id = @id",
                Db.P("@f", rec.FirstName.Trim()), Db.P("@l", rec.LastName.Trim()), Db.P("@e", rec.Email.Trim()),
                Db.P("@p", If(String.IsNullOrWhiteSpace(rec.Phone), Nothing, rec.Phone.Trim())),
                Db.P("@a", rec.IsActive), Db.P("@adm", rec.AdmissionNo.Trim()), Db.P("@id", rec.StudentId))
            session.Commit()
        End Using
    End Sub

    Private Shared Sub EnsureNoOpenLoans(session As DbSession, studentId As Integer)
        Dim openLoans As Integer = Db.AsInt(session.Scalar(
            "SELECT COUNT(*) FROM loans WHERE student_id = @id AND status <> 'Returned'", Db.P("@id", studentId)))
        If openLoans > 0 Then Throw New BusinessRuleException("This student still has unreturned books. Process the returns first.")
    End Sub

    ''' <summary>
    ''' Deletes the student if there is no borrowing history, otherwise deactivates the account
    ''' so history stays intact. Returns "deleted" or "deactivated".
    ''' </summary>
    Public Function Remove(studentId As Integer) As String
        Guard.RequireLibrarian()
        If studentId <= 0 Then Throw New BusinessRuleException("Select a student first.")
        Using session As New DbSession(True)
            EnsureNoOpenLoans(session, studentId)
            Dim history As Integer = Db.AsInt(session.Scalar("SELECT COUNT(*) FROM loans WHERE student_id = @id", Db.P("@id", studentId)))
            Dim outcome As String
            If history > 0 Then
                session.Execute("UPDATE users u JOIN students s ON s.user_id = u.user_id SET u.is_active = 0 WHERE s.student_id = @id", Db.P("@id", studentId))
                outcome = "deactivated"
            Else
                Dim userId As Integer = Db.AsInt(session.Scalar("SELECT user_id FROM students WHERE student_id = @id", Db.P("@id", studentId)))
                session.Execute("DELETE FROM students WHERE student_id = @id", Db.P("@id", studentId))
                session.Execute("DELETE FROM users WHERE user_id = @u", Db.P("@u", userId))
                outcome = "deleted"
            End If
            session.Commit()
            Return outcome
        End Using
    End Function

    Public Sub ResetPassword(studentId As Integer)
        Guard.RequireLibrarian()
        If studentId <= 0 Then Throw New BusinessRuleException("Select a student first.")
        Db.Execute("UPDATE users u JOIN students s ON s.user_id = u.user_id SET u.password_hash = @h WHERE s.student_id = @id",
                   Db.P("@h", PasswordHasher.Hash(DefaultPassword)), Db.P("@id", studentId))
    End Sub
End Class
