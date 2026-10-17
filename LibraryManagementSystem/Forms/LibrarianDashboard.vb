Option Strict On
Option Explicit On

Imports System.Windows.Forms
Imports LibraryManagement.Core

''' <summary>Screen 4 - Librarian Dashboard: sidebar navigation to every librarian feature.</summary>
Public Class LibrarianDashboard
    Private _current As Form

    ''' <summary>True when the user chose Logout (so the login screen is shown again).</summary>
    Public Property LoggedOut As Boolean

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
    End Sub

    Private Sub LibrarianDashboard_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        OpenPage(BtnDashboard, New LibrarianHomePage())
    End Sub

    Private Sub OpenPage(active As Button, page As Form)
        ShowPage(PnlContent, PnlSidebar, active, _current, page)
    End Sub

    Private Sub BtnDashboard_Click(sender As Object, e As EventArgs) Handles BtnDashboard.Click
        OpenPage(BtnDashboard, New LibrarianHomePage())
    End Sub

    Private Sub BtnStudents_Click(sender As Object, e As EventArgs) Handles BtnStudents.Click
        OpenPage(BtnStudents, New StudentsForm())
    End Sub

    Private Sub BtnBooks_Click(sender As Object, e As EventArgs) Handles BtnBooks.Click
        OpenPage(BtnBooks, New BooksForm())
    End Sub

    Private Sub BtnBorrowing_Click(sender As Object, e As EventArgs) Handles BtnBorrowing.Click
        OpenPage(BtnBorrowing, New IssueBookForm())
    End Sub

    Private Sub BtnReturns_Click(sender As Object, e As EventArgs) Handles BtnReturns.Click
        OpenPage(BtnReturns, New ReturnBookForm())
    End Sub

    Private Sub BtnFines_Click(sender As Object, e As EventArgs) Handles BtnFines.Click
        OpenPage(BtnFines, New FinesManagementForm())
    End Sub

    Private Sub BtnRecords_Click(sender As Object, e As EventArgs) Handles BtnRecords.Click
        OpenPage(BtnRecords, New BorrowingRecordsForm())
    End Sub

    Private Sub BtnReports_Click(sender As Object, e As EventArgs) Handles BtnReports.Click
        OpenPage(BtnReports, New ReportsForm())
    End Sub

    Private Sub BtnSettings_Click(sender As Object, e As EventArgs) Handles BtnSettings.Click
        OpenPage(BtnSettings, New LibrarySettingsForm())
    End Sub

    Private Sub BtnProfile_Click(sender As Object, e As EventArgs) Handles BtnProfile.Click
        OpenPage(BtnProfile, New ProfileForm())
    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click
        If Confirm("Do you want to log out?") Then
            LoggedOut = True
            AppSession.Clear()
            Close()
        End If
    End Sub
End Class
