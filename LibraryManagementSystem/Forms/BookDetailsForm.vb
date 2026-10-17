Option Strict On
Option Explicit On

Imports System.Windows.Forms
Imports LibraryManagement.Core

''' <summary>Screen 15 - Book Details (dialog). Borrow is enabled only when a copy is available.</summary>
Public Class BookDetailsForm
    Private ReadOnly _books As New BookService()
    Private _bookId As Integer

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
    End Sub

    Public Sub New(bookId As Integer)
        Me.New()
        _bookId = bookId
    End Sub

    Private Sub BookDetailsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Run(Sub()
                Dim book As BookInfo = _books.GetBook(_bookId)
                LblBookTitle.Text = book.Title
                LblAuthor.Text = "Author: " & book.Author
                LblIsbn.Text = "ISBN: " & book.Isbn
                LblCategory.Text = "Category: " & book.CategoryName
                LblPublisher.Text = "Publisher: " & book.Publisher
                LblYear.Text = "Publication Year: " & book.PublicationYear.ToString()
                LblAvailability.Text = "Available Copies: " & book.AvailableCopies.ToString() & " of " & book.TotalCopies.ToString()
                TxtDescription.Text = If(book.Description = "", "No description available.", book.Description)
                PicCover.Image = MakeCover(book.Title, 170, 215)
                Dim isStudent As Boolean = AppSession.CurrentUser IsNot Nothing AndAlso AppSession.CurrentUser.IsStudent
                BtnBorrow.Visible = isStudent
                BtnBorrow.Enabled = isStudent AndAlso book.AvailableCopies > 0
            End Sub, LblMessage)
    End Sub

    Private Sub BtnBorrow_Click(sender As Object, e As EventArgs) Handles BtnBorrow.Click
        Using dialog As New BorrowBookForm(_bookId)
            If dialog.ShowDialog(Me) = DialogResult.OK Then DialogResult = DialogResult.OK
        End Using
    End Sub
End Class
