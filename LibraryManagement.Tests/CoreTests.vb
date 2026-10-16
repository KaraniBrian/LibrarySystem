Option Strict On
Option Explicit On

Imports LibraryManagement.Core
Imports Xunit

''' <summary>Unit tests for the logic that needs no database (security, validation, fines, CSV).</summary>
Public Class CoreTests
    <Fact>
    Public Sub Hash_ThenVerify_Succeeds()
        Dim hash As String = PasswordHasher.Hash("Secret123")
        Assert.True(PasswordHasher.Verify("Secret123", hash))
    End Sub

    <Fact>
    Public Sub Verify_WrongPassword_Fails()
        Assert.False(PasswordHasher.Verify("wrong", PasswordHasher.Hash("Secret123")))
    End Sub

    <Fact>
    Public Sub Hash_UsesRandomSalt()
        Assert.NotEqual(PasswordHasher.Hash("Secret123"), PasswordHasher.Hash("Secret123"))
    End Sub

    <Fact>
    Public Sub Verify_SeededLibrarianHash_Succeeds()
        Assert.True(PasswordHasher.Verify("Admin@123", "PBKDF2$100000$Uh7aPN9Z3WrFkzov5cGLMg==$R1Mmn0B/OmEJzMleQdEf2aQysa7xxI97Ga/Ke8zMajw="))
    End Sub

    <Fact>
    Public Sub Verify_MalformedHash_Fails()
        Assert.False(PasswordHasher.Verify("x", "not-a-hash"))
    End Sub

    <Fact>
    Public Sub CalculateFine_LateReturn_MultipliesDays()
        Assert.Equal(60D, LoanService.CalculateFine(New Date(2026, 1, 1), New Date(2026, 1, 7), 10D))
    End Sub

    <Fact>
    Public Sub CalculateFine_OnTimeOrEarly_IsZero()
        Assert.Equal(0D, LoanService.CalculateFine(New Date(2026, 1, 7), New Date(2026, 1, 7), 10D))
        Assert.Equal(0D, LoanService.CalculateFine(New Date(2026, 1, 7), New Date(2026, 1, 1), 10D))
    End Sub

    <Theory>
    <InlineData("")>
    <InlineData("bad@")>
    <InlineData("no-at-sign.com")>
    Public Sub Email_Invalid_Throws(value As String)
        Assert.Throws(Of BusinessRuleException)(Sub() Validator.Email(value))
    End Sub

    <Theory>
    <InlineData("short1")>
    <InlineData("alllettersonly")>
    <InlineData("12345678")>
    Public Sub Password_Weak_Throws(value As String)
        Assert.Throws(Of BusinessRuleException)(Sub() Validator.Password(value))
    End Sub

    <Fact>
    Public Sub Password_Strong_Accepted()
        Validator.Password("LongEnough1")
    End Sub

    <Fact>
    Public Sub Phone_Invalid_Throws()
        Assert.Throws(Of BusinessRuleException)(Sub() Validator.Phone("abc"))
    End Sub

    <Fact>
    Public Sub CsvCell_NeutralisesFormulas()
        Assert.StartsWith("""'=", ReportService.CsvCell("=1+1"))
    End Sub

    <Fact>
    Public Sub LikePattern_EscapesWildcards()
        Assert.Equal("%50\%\_%", Db.LikePattern("50%_"))
    End Sub
End Class
