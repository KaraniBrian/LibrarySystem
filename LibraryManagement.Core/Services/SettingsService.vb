Option Strict On
Option Explicit On

Imports System.Data
Imports System.Globalization

''' <summary>Reads and saves library policies (loan period, fine rate, limits, currency).</summary>
Public Class SettingsService
    Public Function GetSettings() As LibrarySettings
        Dim result As New LibrarySettings()
        Dim table As DataTable = Db.Query("SELECT setting_key, setting_value FROM settings")
        For Each row As DataRow In table.Rows
            Dim value As String = Db.AsString(row("setting_value"))
            Select Case Db.AsString(row("setting_key"))
                Case "library_name"
                    result.LibraryName = value
                Case "loan_days"
                    result.LoanDays = ParseInt(value, result.LoanDays)
                Case "fine_per_day"
                    result.FinePerDay = ParseDecimal(value, result.FinePerDay)
                Case "max_books"
                    result.MaxBooksPerStudent = ParseInt(value, result.MaxBooksPerStudent)
                Case "currency"
                    result.Currency = value
            End Select
        Next
        Return result
    End Function

    Public Sub Save(settings As LibrarySettings)
        Guard.RequireLibrarian()
        Validator.Require(settings.LibraryName, "Library name")
        Validator.MaxLength(settings.LibraryName, 150, "Library name")
        Validator.Require(settings.Currency, "Currency")
        If settings.LoanDays < 1 OrElse settings.LoanDays > 365 Then Throw New BusinessRuleException("Loan period must be between 1 and 365 days.")
        If settings.FinePerDay < 0D Then Throw New BusinessRuleException("Fine per day cannot be negative.")
        If settings.MaxBooksPerStudent < 1 OrElse settings.MaxBooksPerStudent > 100 Then Throw New BusinessRuleException("Maximum books per student must be between 1 and 100.")

        Using session As New DbSession(True)
            Upsert(session, "library_name", settings.LibraryName.Trim())
            Upsert(session, "loan_days", settings.LoanDays.ToString(CultureInfo.InvariantCulture))
            Upsert(session, "fine_per_day", settings.FinePerDay.ToString("F2", CultureInfo.InvariantCulture))
            Upsert(session, "max_books", settings.MaxBooksPerStudent.ToString(CultureInfo.InvariantCulture))
            Upsert(session, "currency", settings.Currency)
            session.Commit()
        End Using
    End Sub

    Private Shared Sub Upsert(session As DbSession, key As String, value As String)
        session.Execute("INSERT INTO settings (setting_key, setting_value) VALUES (@k, @v) ON DUPLICATE KEY UPDATE setting_value = @v",
                        Db.P("@k", key), Db.P("@v", value))
    End Sub

    Private Shared Function ParseInt(text As String, fallback As Integer) As Integer
        Dim parsed As Integer
        If Integer.TryParse(text, NumberStyles.Integer, CultureInfo.InvariantCulture, parsed) Then Return parsed
        Return fallback
    End Function

    Private Shared Function ParseDecimal(text As String, fallback As Decimal) As Decimal
        Dim parsed As Decimal
        If Decimal.TryParse(text, NumberStyles.Number, CultureInfo.InvariantCulture, parsed) Then Return parsed
        Return fallback
    End Function
End Class
