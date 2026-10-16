Option Strict On
Option Explicit On

Imports System.Data
Imports System.IO

''' <summary>Login, password change and profile operations.</summary>
Public Class AuthService
    Private Const UserSelect As String =
        "SELECT u.user_id, u.password_hash, u.first_name, u.last_name, u.email, u.phone, u.photo_path, u.is_active, r.role_name, " &
        "COALESCE(s.student_id, 0) AS student_id, COALESCE(s.admission_no, '') AS admission_no " &
        "FROM users u JOIN roles r ON r.role_id = u.role_id LEFT JOIN students s ON s.user_id = u.user_id "

    Private Shared Function MapUser(row As DataRow) As UserAccount
        Return New UserAccount With {
            .UserId = Db.AsInt(row("user_id")),
            .RoleName = Db.AsString(row("role_name")),
            .Email = Db.AsString(row("email")),
            .FirstName = Db.AsString(row("first_name")),
            .LastName = Db.AsString(row("last_name")),
            .Phone = Db.AsString(row("phone")),
            .PhotoPath = Db.AsString(row("photo_path")),
            .StudentId = Db.AsInt(row("student_id")),
            .AdmissionNo = Db.AsString(row("admission_no"))
        }
    End Function

    ''' <summary>Returns the user when the credentials are correct, otherwise Nothing.</summary>
    Public Function Login(email As String, password As String) As UserAccount
        Validator.Require(email, "Email")
        Validator.Require(password, "Password")

        Dim table As DataTable = Db.Query(UserSelect & "WHERE u.email = @email", Db.P("@email", email.Trim()))
        If table.Rows.Count = 0 Then Return Nothing

        Dim row As DataRow = table.Rows(0)
        If Not PasswordHasher.Verify(password, Db.AsString(row("password_hash"))) Then Return Nothing
        If Not Db.AsBool(row("is_active")) Then Throw New BusinessRuleException("This account is inactive. Please contact the librarian.")

        Dim user As UserAccount = MapUser(row)
        AppSession.CurrentUser = user
        Return user
    End Function

    ''' <summary>Reloads the current user from the database (after a profile change).</summary>
    Public Function RefreshCurrentUser() As UserAccount
        Dim current As UserAccount = Guard.RequireLogin()
        Dim table As DataTable = Db.Query(UserSelect & "WHERE u.user_id = @id", Db.P("@id", current.UserId))
        If table.Rows.Count = 0 Then Throw New BusinessRuleException("Your account could not be found.")
        Dim user As UserAccount = MapUser(table.Rows(0))
        AppSession.CurrentUser = user
        Return user
    End Function

    Public Sub ChangePassword(currentPassword As String, newPassword As String, confirmPassword As String)
        Dim user As UserAccount = Guard.RequireLogin()
        Validator.Require(currentPassword, "Current password")
        Validator.Password(newPassword)
        If newPassword <> confirmPassword Then Throw New BusinessRuleException("The new password and its confirmation do not match.")
        If newPassword = currentPassword Then Throw New BusinessRuleException("The new password must be different from the current one.")

        Dim stored As Object = Db.Scalar("SELECT password_hash FROM users WHERE user_id = @id", Db.P("@id", user.UserId))
        If Not PasswordHasher.Verify(currentPassword, Db.AsString(stored)) Then Throw New BusinessRuleException("The current password is incorrect.")

        Db.Execute("UPDATE users SET password_hash = @h WHERE user_id = @id",
                   Db.P("@h", PasswordHasher.Hash(newPassword)), Db.P("@id", user.UserId))
    End Sub

    Public Sub UpdateProfile(firstName As String, lastName As String, phone As String)
        Dim user As UserAccount = Guard.RequireLogin()
        Validator.Require(firstName, "First name")
        Validator.Require(lastName, "Last name")
        Validator.MaxLength(firstName, 100, "First name")
        Validator.MaxLength(lastName, 100, "Last name")
        Validator.Phone(phone)
        Db.Execute("UPDATE users SET first_name = @f, last_name = @l, phone = @p WHERE user_id = @id",
                   Db.P("@f", firstName.Trim()), Db.P("@l", lastName.Trim()),
                   Db.P("@p", If(String.IsNullOrWhiteSpace(phone), Nothing, phone.Trim())), Db.P("@id", user.UserId))
        RefreshCurrentUser()
    End Sub

    ''' <summary>Copies the chosen picture into the app data folder and saves its path.</summary>
    Public Sub SavePhoto(sourceFile As String)
        Dim user As UserAccount = Guard.RequireLogin()
        Dim extension As String = Path.GetExtension(sourceFile).ToLowerInvariant()
        If extension <> ".png" AndAlso extension <> ".jpg" AndAlso extension <> ".jpeg" Then
            Throw New BusinessRuleException("Please choose a PNG or JPG picture.")
        End If
        If New FileInfo(sourceFile).Length > 2 * 1024 * 1024 Then Throw New BusinessRuleException("The picture must be smaller than 2 MB.")

        Dim folder As String = Path.Combine(AppPaths.DataDirectory, "photos")
        Directory.CreateDirectory(folder)
        Dim target As String = Path.Combine(folder, "user_" & user.UserId.ToString() & extension)
        File.Copy(sourceFile, target, True)
        Db.Execute("UPDATE users SET photo_path = @p WHERE user_id = @id", Db.P("@p", target), Db.P("@id", user.UserId))
        RefreshCurrentUser()
    End Sub
End Class
