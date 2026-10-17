Option Strict On
Option Explicit On

Imports System.Windows.Forms
Imports LibraryManagement.Core

''' <summary>Home page of the librarian dashboard: live statistics and recent borrowings.</summary>
Public Class LibrarianHomePage
    Private ReadOnly _svc As New DashboardService()

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        StatusColors(DgvRecentBorrowings)
    End Sub

    Private Sub LibrarianHomePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblOverdueBooksValue.ForeColor = Theme.Danger
        LblWelcome.Text = "Welcome, " & AppSession.CurrentUser.FirstName
        Dim problem As String = TryRun(Sub()
                                           Dim stats As LibrarianStats = _svc.GetLibrarianStats()
                                           LblTotalBooksValue.Text = stats.TotalCopies.ToString()
                                           LblTotalStudentsValue.Text = stats.ActiveStudents.ToString()
                                           LblActiveLoansValue.Text = stats.ActiveLoans.ToString()
                                           LblOverdueBooksValue.Text = stats.OverdueLoans.ToString()
                                           BindGrid(DgvRecentBorrowings, _svc.GetRecentBorrowings())
                                       End Sub)
        If problem <> "" Then ShowError(problem)
    End Sub
End Class
