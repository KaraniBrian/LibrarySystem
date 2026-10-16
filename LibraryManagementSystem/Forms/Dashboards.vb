Option Strict On
Option Explicit On

Imports System.Data
Imports System.Windows.Forms
Imports LibraryManagement.Core

''' <summary>Screen 4 - Librarian Dashboard: sidebar navigation to every librarian feature.</summary>
Public Class LibrarianDashboard
    Inherits ShellForm

    Public Sub New()
        MyBase.New("Library System")
        AddNav("btnDashboard", "Dashboard", Function() New LibrarianHomePage())
        AddNav("btnStudents", "Manage Students", Function() New StudentsForm())
        AddNav("btnBooks", "Manage Books", Function() New BooksForm())
        AddNav("btnBorrowing", "Borrow/Issue Books", Function() New IssueBookForm())
        AddNav("btnReturns", "Process Returns", Function() New ReturnBookForm())
        AddNav("btnFines", "Fines Management", Function() New FinesManagementForm())
        AddNav("btnRecords", "Borrowing Records", Function() New BorrowingRecordsForm())
        AddNav("btnReports", "Reports", Function() New ReportsForm())
        AddNav("btnSettings", "Settings", Function() New LibrarySettingsForm())
        AddNav("btnProfile", "My Profile", Function() New ProfileForm(), True)
        AddAction("btnLogout", "Logout", AddressOf ConfirmLogout, True)
    End Sub
End Class

''' <summary>Screen 13 - Student Dashboard: sidebar navigation for students.</summary>
Public Class StudentDashboard
    Inherits ShellForm

    Public Sub New()
        MyBase.New("Student Portal")
        AddNav("btnDashboard", "Dashboard", Function() New StudentHomePage())
        AddNav("btnCatalogue", "Browse Books", Function() New BookCatalogueForm())
        AddNav("btnMyBorrowedBooks", "My Borrowed Books", Function() New MyBorrowedBooksForm())
        AddNav("btnMyFines", "My Fines and Payments", Function() New MyFinesForm())
        AddNav("btnProfile", "My Profile", Function() New ProfileForm(), True)
        AddAction("btnChangePassword", "Change Password", AddressOf ShowChangePassword, True)
        AddAction("btnLogout", "Logout", AddressOf ConfirmLogout, True)
    End Sub
End Class

''' <summary>Home page of the librarian dashboard: live statistics and recent borrowings.</summary>
Public Class LibrarianHomePage
    Inherits PageForm

    Private ReadOnly _svc As New DashboardService()
    Private ReadOnly cardBooks As New StatCard("TotalBooks", "Total Books")
    Private ReadOnly cardStudents As New StatCard("TotalStudents", "Total Students")
    Private ReadOnly cardLoans As New StatCard("ActiveLoans", "Active Loans")
    Private ReadOnly cardOverdue As New StatCard("OverdueBooks", "Overdue Books")
    Private ReadOnly dgvRecentBorrowings As DataGridView = NewGrid("dgvRecentBorrowings")

    Public Sub New()
        MyBase.New("Welcome, " & AppSession.CurrentUser.FirstName)
        Dim cards As New FlowLayoutPanel With {.Name = "pnlCards", .AutoSize = True, .WrapContents = True}
        cardOverdue.ValueLabel.ForeColor = Theme.Danger
        cards.Controls.AddRange(New Control() {cardBooks, cardStudents, cardLoans, cardOverdue})
        AddAutoRow(cards)
        AddAutoRow(NewLabel("lblRecentBorrowings", "Recent Borrowings", True))
        AddFillRow(dgvRecentBorrowings)
        AddAutoRow(lblMessage)
    End Sub

    Protected Overrides Sub LoadData()
        Run(Sub()
                Dim stats As LibrarianStats = _svc.GetLibrarianStats()
                cardBooks.ValueLabel.Text = stats.TotalCopies.ToString()
                cardStudents.ValueLabel.Text = stats.ActiveStudents.ToString()
                cardLoans.ValueLabel.Text = stats.ActiveLoans.ToString()
                cardOverdue.ValueLabel.Text = stats.OverdueLoans.ToString()
                BindGrid(dgvRecentBorrowings, _svc.GetRecentBorrowings())
            End Sub)
    End Sub
End Class

''' <summary>Home page of the student dashboard: only the logged-in student's own numbers.</summary>
Public Class StudentHomePage
    Inherits PageForm

    Private ReadOnly _svc As New DashboardService()
    Private ReadOnly cardBorrowed As New StatCard("BorrowedBooks", "My Borrowed Books")
    Private ReadOnly cardDueSoon As New StatCard("DueSoon", "Books Due Soon")
    Private ReadOnly cardOverdue As New StatCard("Overdue", "Overdue Books")
    Private ReadOnly cardFine As New StatCard("FineBalance", "Outstanding Fine", "0.00")
    Private ReadOnly dgvMyBorrowings As DataGridView = NewGrid("dgvMyBorrowings")

    Public Sub New()
        MyBase.New("Welcome, " & AppSession.CurrentUser.FirstName)
        Dim cards As New FlowLayoutPanel With {.Name = "pnlCards", .AutoSize = True, .WrapContents = True}
        cardOverdue.ValueLabel.ForeColor = Theme.Danger
        cardFine.ValueLabel.ForeColor = Theme.Danger
        cards.Controls.AddRange(New Control() {cardBorrowed, cardDueSoon, cardOverdue, cardFine})
        AddAutoRow(cards)
        AddAutoRow(NewLabel("lblRecentBorrowings", "My Recent Borrowings", True))
        AddFillRow(dgvMyBorrowings)
        AddAutoRow(lblMessage)
    End Sub

    Protected Overrides Sub LoadData()
        Run(Sub()
                Dim stats As StudentStats = _svc.GetStudentStats()
                Dim currency As String = New SettingsService().GetSettings().Currency
                cardBorrowed.ValueLabel.Text = stats.Borrowed.ToString()
                cardDueSoon.ValueLabel.Text = stats.DueSoon.ToString()
                cardOverdue.ValueLabel.Text = stats.Overdue.ToString()
                cardFine.ValueLabel.Text = Formatting.Money(stats.FineBalance, currency)
                cardFine.ValueLabel.Font = New System.Drawing.Font("Segoe UI", 16.0F, System.Drawing.FontStyle.Bold)
                BindGrid(dgvMyBorrowings, _svc.GetMyRecentBorrowings())
            End Sub)
    End Sub
End Class
