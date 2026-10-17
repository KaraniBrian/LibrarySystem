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

            If AppSession.CurrentUser.IsLibrarian Then
                Using dashboard As New LibrarianDashboard()
                    Application.Run(dashboard)
                    showLogin = dashboard.LoggedOut
                End Using
            Else
                Using dashboard As New StudentDashboard()
                    Application.Run(dashboard)
                    showLogin = dashboard.LoggedOut
                End Using
            End If
        Loop
    End Sub

    Private Sub OnUnhandledException(sender As Object, e As ThreadExceptionEventArgs)
        ErrorLog.Write(e.Exception)
        MessageBox.Show("An unexpected error occurred. Details were saved to the log file.",
                        "Library Management System", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub
End Module
