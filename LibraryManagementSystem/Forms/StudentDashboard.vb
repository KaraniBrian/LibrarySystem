Option Strict On
Option Explicit On

Imports System.Windows.Forms
Imports LibraryManagement.Core

''' <summary>Screen 13 - Student Dashboard: sidebar navigation for students.</summary>
Public Class StudentDashboard
    Private _current As Form

    ''' <summary>True when the user chose Logout (so the login screen is shown again).</summary>
    Public Property LoggedOut As Boolean

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
    End Sub

    Private Sub StudentDashboard_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        OpenPage(BtnDashboard, New StudentHomePage())
    End Sub

    Private Sub OpenPage(active As Button, page As Form)
        ShowPage(PnlContent, PnlSidebar, active, _current, page)
    End Sub

    Private Sub BtnDashboard_Click(sender As Object, e As EventArgs) Handles BtnDashboard.Click
        OpenPage(BtnDashboard, New StudentHomePage())
    End Sub

    Private Sub BtnCatalogue_Click(sender As Object, e As EventArgs) Handles BtnCatalogue.Click
        OpenPage(BtnCatalogue, New BookCatalogueForm())
    End Sub

    Private Sub BtnMyBorrowedBooks_Click(sender As Object, e As EventArgs) Handles BtnMyBorrowedBooks.Click
        OpenPage(BtnMyBorrowedBooks, New MyBorrowedBooksForm())
    End Sub

    Private Sub BtnMyFines_Click(sender As Object, e As EventArgs) Handles BtnMyFines.Click
        OpenPage(BtnMyFines, New MyFinesForm())
    End Sub

    Private Sub BtnProfile_Click(sender As Object, e As EventArgs) Handles BtnProfile.Click
        OpenPage(BtnProfile, New ProfileForm())
    End Sub

    Private Sub BtnChangePassword_Click(sender As Object, e As EventArgs) Handles BtnChangePassword.Click
        Using dialog As New ChangePasswordForm()
            dialog.ShowDialog(Me)
        End Using
    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click
        If Confirm("Do you want to log out?") Then
            LoggedOut = True
            AppSession.Clear()
            Close()
        End If
    End Sub
End Class
