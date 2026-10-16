Option Strict On
Option Explicit On

Imports System.Globalization
Imports System.IO
Imports System.Text.RegularExpressions

''' <summary>Raised when input or a business rule is violated. The message is safe to show to the user.</summary>
Public Class BusinessRuleException
    Inherits Exception

    Public Sub New(message As String)
        MyBase.New(message)
    End Sub
End Class

''' <summary>Role names stored in the roles table.</summary>
Public NotInheritable Class RoleNames
    Public Const Librarian As String = "Librarian"
    Public Const Student As String = "Student"
End Class

''' <summary>Holds the currently logged-in user for the running application.</summary>
Public NotInheritable Class AppSession
    Private Sub New()
    End Sub

    Public Shared Property CurrentUser As UserAccount

    Public Shared Sub Clear()
        CurrentUser = Nothing
    End Sub
End Class

''' <summary>
''' Server-side style permission checks. Every service calls these, so security
''' does not depend on hiding or disabling buttons in the interface.
''' </summary>
Public NotInheritable Class Guard
    Private Sub New()
    End Sub

    Public Shared Function RequireLogin() As UserAccount
        Dim user As UserAccount = AppSession.CurrentUser
        If user Is Nothing Then Throw New UnauthorizedAccessException("Please log in first.")
        Return user
    End Function

    Public Shared Function RequireLibrarian() As UserAccount
        Dim user As UserAccount = RequireLogin()
        If Not user.IsLibrarian Then Throw New UnauthorizedAccessException("You do not have permission to perform this action.")
        Return user
    End Function

    ''' <summary>Returns the student id of the logged-in student.</summary>
    Public Shared Function RequireStudent() As Integer
        Dim user As UserAccount = RequireLogin()
        If Not user.IsStudent OrElse user.StudentId <= 0 Then Throw New UnauthorizedAccessException("This action is only available to students.")
        Return user.StudentId
    End Function
End Class

''' <summary>Folders used by the application for logs and photos.</summary>
Public NotInheritable Class AppPaths
    Private Sub New()
    End Sub

    Public Shared ReadOnly Property DataDirectory As String
        Get
            Return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "LibraryManagementSystem")
        End Get
    End Property
End Class

''' <summary>Writes technical error details to a log file instead of showing them to users.</summary>
Public NotInheritable Class ErrorLog
    Private Sub New()
    End Sub

    Public Shared Sub Write(ex As Exception)
        Try
            Directory.CreateDirectory(AppPaths.DataDirectory)
            File.AppendAllText(Path.Combine(AppPaths.DataDirectory, "error.log"),
                               DateTime.Now.ToString("s", CultureInfo.InvariantCulture) & " " & ex.ToString() & Environment.NewLine & Environment.NewLine)
        Catch
            ' Logging must never crash the application.
        End Try
    End Sub
End Class

''' <summary>Input validation shared by all services. Throws BusinessRuleException with a clear message.</summary>
Public NotInheritable Class Validator
    Private Sub New()
    End Sub

    Private Shared ReadOnly EmailPattern As New Regex("^[^@\s]+@[^@\s]+\.[^@\s]+$", RegexOptions.Compiled)
    Private Shared ReadOnly PhonePattern As New Regex("^\+?\d{9,15}$", RegexOptions.Compiled)

    Public Shared Sub Require(value As String, fieldName As String)
        If String.IsNullOrWhiteSpace(value) Then Throw New BusinessRuleException(fieldName & " is required.")
    End Sub

    Public Shared Sub Email(value As String)
        Require(value, "Email")
        If Not EmailPattern.IsMatch(value.Trim()) Then Throw New BusinessRuleException("Please enter a valid email address.")
    End Sub

    ''' <summary>Phone is optional; when given it must be 9-15 digits (optional leading +).</summary>
    Public Shared Sub Phone(value As String)
        If String.IsNullOrWhiteSpace(value) Then Return
        Dim cleaned As String = value.Replace(" ", "").Replace("-", "")
        If Not PhonePattern.IsMatch(cleaned) Then Throw New BusinessRuleException("Phone must contain 9 to 15 digits.")
    End Sub

    Public Shared Sub MaxLength(value As String, max As Integer, fieldName As String)
        If value IsNot Nothing AndAlso value.Length > max Then Throw New BusinessRuleException(fieldName & " must not exceed " & max.ToString(CultureInfo.InvariantCulture) & " characters.")
    End Sub

    ''' <summary>Password policy: at least 8 characters with a letter and a digit.</summary>
    Public Shared Sub Password(value As String)
        Require(value, "Password")
        If value.Length < 8 OrElse Not value.Any(Function(c As Char) Char.IsLetter(c)) OrElse Not value.Any(Function(c As Char) Char.IsDigit(c)) Then
            Throw New BusinessRuleException("Password must be at least 8 characters and contain letters and numbers.")
        End If
    End Sub
End Class

''' <summary>Display helpers.</summary>
Public NotInheritable Class Formatting
    Private Sub New()
    End Sub

    Public Shared Function Money(amount As Decimal, currency As String) As String
        Return currency & " " & amount.ToString("N2", CultureInfo.InvariantCulture)
    End Function
End Class
