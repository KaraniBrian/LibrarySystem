Option Strict On
Option Explicit On

Imports System.Security.Cryptography

''' <summary>
''' Hashes passwords with PBKDF2 (HMAC-SHA256, random salt, 100,000 iterations).
''' Stored format: PBKDF2$iterations$saltBase64$hashBase64
''' </summary>
Public NotInheritable Class PasswordHasher
    Private Sub New()
    End Sub

    Private Const SaltSize As Integer = 16
    Private Const HashSize As Integer = 32
    Private Const DefaultIterations As Integer = 100000

    Public Shared Function Hash(password As String) As String
        Dim salt(SaltSize - 1) As Byte
        RandomNumberGenerator.Fill(salt)
        Dim key As Byte() = Rfc2898DeriveBytes.Pbkdf2(password, salt, DefaultIterations, HashAlgorithmName.SHA256, HashSize)
        Return String.Join("$", "PBKDF2", DefaultIterations.ToString(Globalization.CultureInfo.InvariantCulture),
                           Convert.ToBase64String(salt), Convert.ToBase64String(key))
    End Function

    Public Shared Function Verify(password As String, stored As String) As Boolean
        If String.IsNullOrEmpty(password) OrElse String.IsNullOrEmpty(stored) Then Return False
        Dim parts As String() = stored.Split("$"c)
        Dim iterations As Integer
        If parts.Length <> 4 OrElse parts(0) <> "PBKDF2" OrElse Not Integer.TryParse(parts(1), iterations) Then Return False
        Try
            Dim salt As Byte() = Convert.FromBase64String(parts(2))
            Dim expected As Byte() = Convert.FromBase64String(parts(3))
            Dim actual As Byte() = Rfc2898DeriveBytes.Pbkdf2(password, salt, iterations, HashAlgorithmName.SHA256, expected.Length)
            Return CryptographicOperations.FixedTimeEquals(actual, expected)
        Catch ex As FormatException
            Return False
        End Try
    End Function
End Class
