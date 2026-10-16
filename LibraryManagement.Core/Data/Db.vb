Option Strict On
Option Explicit On

Imports System.Data
Imports System.Globalization
Imports System.IO
Imports System.Text.Json
Imports MySqlConnector

''' <summary>
''' Reads configuration from appsettings.json / appsettings.local.json (next to the .exe).
''' The connection string lives in this one place only. The LMS_CONNECTION
''' environment variable overrides the file, which is handy for testing.
''' </summary>
Public NotInheritable Class DbConfig
    Private Sub New()
    End Sub

    Private Shared _values As Dictionary(Of String, String)

    Private Shared Function Values() As Dictionary(Of String, String)
        If _values Is Nothing Then
            Dim result As New Dictionary(Of String, String)(StringComparer.OrdinalIgnoreCase)
            ' appsettings.local.json (not committed to Git) overrides appsettings.json.
            For Each fileName As String In {"appsettings.json", "appsettings.local.json"}
                Dim configPath As String = Path.Combine(AppContext.BaseDirectory, fileName)
                If File.Exists(configPath) Then
                    Using doc As JsonDocument = JsonDocument.Parse(File.ReadAllText(configPath))
                        For Each prop As JsonProperty In doc.RootElement.EnumerateObject()
                            result(prop.Name) = If(prop.Value.ValueKind = JsonValueKind.String, prop.Value.GetString(), prop.Value.ToString())
                        Next
                    End Using
                End If
            Next
            _values = result
        End If
        Return _values
    End Function

    Public Shared ReadOnly Property ConnectionString As String
        Get
            Dim fromEnv As String = Environment.GetEnvironmentVariable("LMS_CONNECTION")
            If Not String.IsNullOrWhiteSpace(fromEnv) Then Return fromEnv
            Dim fromFile As String = Nothing
            If Values().TryGetValue("ConnectionString", fromFile) AndAlso Not String.IsNullOrWhiteSpace(fromFile) Then Return fromFile
            Throw New BusinessRuleException("The database connection is not configured. Edit appsettings.json next to the application.")
        End Get
    End Property

    ''' <summary>Optional folder containing mysqldump and mysql (used by backup/restore).</summary>
    Public Shared ReadOnly Property MySqlBinPath As String
        Get
            Dim folder As String = Nothing
            If Values().TryGetValue("MySqlBinPath", folder) Then Return folder
            Return ""
        End Get
    End Property
End Class

''' <summary>
''' One database connection, optionally wrapped in a transaction. Dispose rolls back
''' anything that was not committed, so multi-step operations stay consistent.
''' </summary>
Public NotInheritable Class DbSession
    Implements IDisposable

    Private ReadOnly _conn As MySqlConnection
    Private _tx As MySqlTransaction
    Private _committed As Boolean

    Public Sub New(Optional useTransaction As Boolean = False)
        _conn = New MySqlConnection(DbConfig.ConnectionString)
        Try
            _conn.Open()
            If useTransaction Then _tx = _conn.BeginTransaction()
        Catch ex As MySqlException
            ErrorLog.Write(ex)
            _conn.Dispose()
            Throw New BusinessRuleException("Could not connect to the database. Check that MySQL is running and that appsettings.json is correct.")
        End Try
    End Sub

    Private Function CreateCommand(sql As String, args As KeyValuePair(Of String, Object)()) As MySqlCommand
        Dim cmd As New MySqlCommand(sql, _conn, _tx)
        If args IsNot Nothing Then
            For Each arg As KeyValuePair(Of String, Object) In args
                cmd.Parameters.AddWithValue(arg.Key, If(arg.Value, DBNull.Value))
            Next
        End If
        Return cmd
    End Function

    ''' <summary>Runs a SELECT and returns the rows. Always use @parameters, never string joins.</summary>
    Public Function Query(sql As String, ParamArray args As KeyValuePair(Of String, Object)()) As DataTable
        Using cmd As MySqlCommand = CreateCommand(sql, args)
            Using adapter As New MySqlDataAdapter(cmd)
                Dim table As New DataTable()
                adapter.Fill(table)
                Return table
            End Using
        End Using
    End Function

    ''' <summary>Runs INSERT/UPDATE/DELETE and returns the number of affected rows.</summary>
    Public Function Execute(sql As String, ParamArray args As KeyValuePair(Of String, Object)()) As Integer
        Using cmd As MySqlCommand = CreateCommand(sql, args)
            Return cmd.ExecuteNonQuery()
        End Using
    End Function

    Public Function Scalar(sql As String, ParamArray args As KeyValuePair(Of String, Object)()) As Object
        Using cmd As MySqlCommand = CreateCommand(sql, args)
            Return cmd.ExecuteScalar()
        End Using
    End Function

    ''' <summary>Runs an INSERT and returns the new auto-increment id.</summary>
    Public Function Insert(sql As String, ParamArray args As KeyValuePair(Of String, Object)()) As Integer
        Using cmd As MySqlCommand = CreateCommand(sql, args)
            cmd.ExecuteNonQuery()
            Return CInt(cmd.LastInsertedId)
        End Using
    End Function

    Public Sub Commit()
        If _tx IsNot Nothing Then _tx.Commit()
        _committed = True
    End Sub

    Public Sub Dispose() Implements IDisposable.Dispose
        If _tx IsNot Nothing Then
            If Not _committed Then
                Try
                    _tx.Rollback()
                Catch
                    ' The connection may already be broken; nothing more to do.
                End Try
            End If
            _tx.Dispose()
        End If
        _conn.Dispose()
    End Sub
End Class

''' <summary>Simple one-shot database helpers plus value converters for DataRow cells.</summary>
Public NotInheritable Class Db
    Private Sub New()
    End Sub

    ''' <summary>Creates a named SQL parameter.</summary>
    Public Shared Function P(name As String, value As Object) As KeyValuePair(Of String, Object)
        Return New KeyValuePair(Of String, Object)(name, value)
    End Function

    Public Shared Function Query(sql As String, ParamArray args As KeyValuePair(Of String, Object)()) As DataTable
        Using session As New DbSession()
            Return session.Query(sql, args)
        End Using
    End Function

    Public Shared Function Execute(sql As String, ParamArray args As KeyValuePair(Of String, Object)()) As Integer
        Using session As New DbSession()
            Return session.Execute(sql, args)
        End Using
    End Function

    Public Shared Function Scalar(sql As String, ParamArray args As KeyValuePair(Of String, Object)()) As Object
        Using session As New DbSession()
            Return session.Scalar(sql, args)
        End Using
    End Function

    ''' <summary>Builds a safe LIKE pattern (%term%) with wildcards in the term escaped.</summary>
    Public Shared Function LikePattern(term As String) As String
        Dim text As String = If(term, "").Trim()
        text = text.Replace("\", "\\").Replace("%", "\%").Replace("_", "\_")
        Return "%" & text & "%"
    End Function

    Public Shared Function AsInt(value As Object) As Integer
        If value Is Nothing OrElse IsDBNull(value) Then Return 0
        Return Convert.ToInt32(value, CultureInfo.InvariantCulture)
    End Function

    Public Shared Function AsDecimal(value As Object) As Decimal
        If value Is Nothing OrElse IsDBNull(value) Then Return 0D
        Return Convert.ToDecimal(value, CultureInfo.InvariantCulture)
    End Function

    Public Shared Function AsString(value As Object) As String
        If value Is Nothing OrElse IsDBNull(value) Then Return ""
        Return Convert.ToString(value, CultureInfo.InvariantCulture)
    End Function

    Public Shared Function AsBool(value As Object) As Boolean
        If value Is Nothing OrElse IsDBNull(value) Then Return False
        Return Convert.ToBoolean(value, CultureInfo.InvariantCulture)
    End Function

    Public Shared Function AsDate(value As Object) As Date
        If value Is Nothing OrElse IsDBNull(value) Then Return Date.MinValue
        Return Convert.ToDateTime(value, CultureInfo.InvariantCulture)
    End Function
End Class
