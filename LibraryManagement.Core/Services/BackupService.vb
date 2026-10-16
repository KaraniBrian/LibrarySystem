Option Strict On
Option Explicit On

Imports System.ComponentModel
Imports System.Diagnostics
Imports System.IO
Imports MySqlConnector

''' <summary>Database backup and restore using the MySQL command-line tools (mysqldump / mysql).</summary>
Public Class BackupService
    Public Sub Backup(targetFile As String)
        Guard.RequireLibrarian()
        Dim builder As New MySqlConnectionStringBuilder(DbConfig.ConnectionString)
        Dim info As ProcessStartInfo = BuildStartInfo("mysqldump", builder, False)
        info.ArgumentList.Add("--single-transaction")
        info.ArgumentList.Add("--routines")
        info.ArgumentList.Add("--result-file=" & targetFile)
        info.ArgumentList.Add(builder.Database)
        RunTool(info, Nothing)
    End Sub

    Public Sub Restore(sourceFile As String)
        Guard.RequireLibrarian()
        If Not File.Exists(sourceFile) Then Throw New BusinessRuleException("The backup file was not found.")
        Dim builder As New MySqlConnectionStringBuilder(DbConfig.ConnectionString)
        Dim info As ProcessStartInfo = BuildStartInfo("mysql", builder, True)
        info.ArgumentList.Add(builder.Database)
        RunTool(info, sourceFile)
    End Sub

    Private Shared Function BuildStartInfo(tool As String, builder As MySqlConnectionStringBuilder, needsInput As Boolean) As ProcessStartInfo
        Dim exe As String = tool
        If Not String.IsNullOrWhiteSpace(DbConfig.MySqlBinPath) Then exe = Path.Combine(DbConfig.MySqlBinPath, tool)
        Dim info As New ProcessStartInfo(exe) With {
            .UseShellExecute = False, .CreateNoWindow = True,
            .RedirectStandardError = True, .RedirectStandardInput = needsInput}
        info.ArgumentList.Add("--host=" & builder.Server)
        info.ArgumentList.Add("--port=" & builder.Port.ToString())
        info.ArgumentList.Add("--user=" & builder.UserID)
        info.Environment("MYSQL_PWD") = builder.Password
        Return info
    End Function

    Private Shared Sub RunTool(info As ProcessStartInfo, inputFile As String)
        Try
            Using proc As Process = Process.Start(info)
                If inputFile IsNot Nothing Then
                    Using source As FileStream = File.OpenRead(inputFile)
                        source.CopyTo(proc.StandardInput.BaseStream)
                    End Using
                    proc.StandardInput.Close()
                End If
                Dim errors As String = proc.StandardError.ReadToEnd()
                proc.WaitForExit()
                If proc.ExitCode <> 0 Then
                    ErrorLog.Write(New InvalidOperationException(errors))
                    Throw New BusinessRuleException("The MySQL tool reported an error. Details were saved to the log file.")
                End If
            End Using
        Catch ex As Win32Exception
            Throw New BusinessRuleException("MySQL command-line tools were not found. Set ""MySqlBinPath"" in appsettings.json to MySQL's bin folder.")
        End Try
    End Sub
End Class
