Option Strict On
Option Explicit On

''' <summary>The logged-in user (librarian or student).</summary>
Public Class UserAccount
    Public Property UserId As Integer
    Public Property RoleName As String = ""
    Public Property Email As String = ""
    Public Property FirstName As String = ""
    Public Property LastName As String = ""
    Public Property Phone As String = ""
    Public Property PhotoPath As String = ""
    ''' <summary>0 for librarians.</summary>
    Public Property StudentId As Integer
    Public Property AdmissionNo As String = ""

    Public ReadOnly Property FullName As String
        Get
            Return (FirstName & " " & LastName).Trim()
        End Get
    End Property

    Public ReadOnly Property IsLibrarian As Boolean
        Get
            Return String.Equals(RoleName, RoleNames.Librarian, StringComparison.OrdinalIgnoreCase)
        End Get
    End Property

    Public ReadOnly Property IsStudent As Boolean
        Get
            Return String.Equals(RoleName, RoleNames.Student, StringComparison.OrdinalIgnoreCase)
        End Get
    End Property
End Class

''' <summary>Library policies stored in the settings table.</summary>
Public Class LibrarySettings
    Public Property LibraryName As String = "Library"
    Public Property LoanDays As Integer = 14
    Public Property FinePerDay As Decimal = 10D
    Public Property MaxBooksPerStudent As Integer = 3
    Public Property Currency As String = "KES"
End Class

''' <summary>A book title with copy counts.</summary>
Public Class BookInfo
    Public Property BookId As Integer
    Public Property Isbn As String = ""
    Public Property Title As String = ""
    Public Property Author As String = ""
    Public Property CategoryId As Integer
    Public Property CategoryName As String = ""
    Public Property Publisher As String = ""
    Public Property PublicationYear As Integer
    Public Property Description As String = ""
    Public Property TotalCopies As Integer
    Public Property AvailableCopies As Integer
End Class

''' <summary>Data entered on the Manage Students screen.</summary>
Public Class StudentRecord
    Public Property StudentId As Integer
    Public Property FirstName As String = ""
    Public Property LastName As String = ""
    Public Property AdmissionNo As String = ""
    Public Property Email As String = ""
    Public Property Phone As String = ""
    Public Property IsActive As Boolean = True
End Class

''' <summary>Numbers shown on the librarian dashboard.</summary>
Public Class LibrarianStats
    Public Property TotalCopies As Integer
    Public Property ActiveStudents As Integer
    Public Property ActiveLoans As Integer
    Public Property OverdueLoans As Integer
End Class

''' <summary>Numbers shown on the student dashboard.</summary>
Public Class StudentStats
    Public Property Borrowed As Integer
    Public Property DueSoon As Integer
    Public Property Overdue As Integer
    Public Property FineBalance As Decimal
End Class
