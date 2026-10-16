Option Strict On
Option Explicit On

Imports System.Threading
Imports System.Windows.Forms
Imports LibraryManagement.Core

''' <summary>Application entry point: login, then the dashboard for the user's role, repeated after logout.</summary>
Friend Module Program
    <STAThread>
    Friend Sub Main()
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)
        Application.SetHighDpiMode(HighDpiMode.SystemAware)
        Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException)
        AddHandler Application.ThreadException, AddressOf OnUnhandledException

        Dim showLogin As Boolean = True
        Do While showLogin
            showLogin = False
            Using login As New LoginForm()
                If login.ShowDialog() <> DialogResult.OK Then Exit Do
            End Using

            Dim shell As ShellForm
            If AppSession.CurrentUser.IsLibrarian Then
                shell = New LibrarianDashboard()
            Else
                shell = New StudentDashboard()
            End If
            Application.Run(shell)
            showLogin = shell.LoggedOut
            shell.Dispose()
        Loop
    End Sub

    Private Sub OnUnhandledException(sender As Object, e As ThreadExceptionEventArgs)
        ErrorLog.Write(e.Exception)
        MessageBox.Show("An unexpected error occurred. Details were saved to the log file.",
                        "Library Management System", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub
End Module
