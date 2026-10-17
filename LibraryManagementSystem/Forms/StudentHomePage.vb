Option Strict On
Option Explicit On

Imports System.Windows.Forms
Imports LibraryManagement.Core

''' <summary>Home page of the student dashboard: only the logged-in student's own numbers.</summary>
Public Class StudentHomePage
    Private ReadOnly _svc As New DashboardService()

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        StatusColors(DgvMyBorrowings)
    End Sub

    Private Sub StudentHomePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblOverdueValue.ForeColor = Theme.Danger
        LblFineBalanceValue.ForeColor = Theme.Danger
        LblWelcome.Text = "Welcome, " & AppSession.CurrentUser.FirstName
        Dim problem As String = TryRun(Sub()
                                           Dim stats As StudentStats = _svc.GetStudentStats()
                                           Dim currency As String = New SettingsService().GetSettings().Currency
                                           LblBorrowedBooksValue.Text = stats.Borrowed.ToString()
                                           LblDueSoonValue.Text = stats.DueSoon.ToString()
                                           LblOverdueValue.Text = stats.Overdue.ToString()
                                           LblFineBalanceValue.Text = Formatting.Money(stats.FineBalance, currency)
                                           BindGrid(DgvMyBorrowings, _svc.GetMyRecentBorrowings())
                                       End Sub)
        If problem <> "" Then ShowError(problem)
    End Sub
End Class
