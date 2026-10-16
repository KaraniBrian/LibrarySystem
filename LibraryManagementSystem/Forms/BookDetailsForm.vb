Option Strict On
Option Explicit On

Imports System.Drawing
Imports System.Windows.Forms
Imports LibraryManagement.Core

''' <summary>Screen 15 - Book Details (dialog). Borrow is enabled only when a copy is available.</summary>
Public Class BookDetailsForm
    Inherits DialogForm

    Private ReadOnly _books As New BookService()
    Private ReadOnly _bookId As Integer
    Private ReadOnly picCover As New PictureBox() With {.Name = "picCover", .Size = New Size(180, 230), .SizeMode = PictureBoxSizeMode.Zoom}
    Private ReadOnly lblBookTitle As Label = NewLabel("lblBookTitle", "", True)
    Private ReadOnly lblAuthor As Label = NewLabel("lblAuthor", "Author:")
    Private ReadOnly lblISBN As Label = NewLabel("lblISBN", "ISBN:")
    Private ReadOnly lblCategory As Label = NewLabel("lblCategory", "Category:")
    Private ReadOnly lblPublisher As Label = NewLabel("lblPublisher", "Publisher:")
    Private ReadOnly lblYear As Label = NewLabel("lblYear", "Publication Year:")
    Private ReadOnly lblAvailability As Label = NewLabel("lblAvailability", "Available Copies:", True)
    Private ReadOnly txtDescription As TextBox = NewMultiline("txtDescription", 1000, 90, True)
    Private ReadOnly btnBorrow As Button = NewButton("btnBorrow", "Borrow Book", ButtonKind.Primary, 150)
    Private ReadOnly btnClose As Button = NewButton("btnClose", "Close", ButtonKind.Secondary, 110)

    Public Sub New(bookId As Integer)
        MyBase.New("Book Details", 620)
        _bookId = bookId
        Dim info As New FlowLayoutPanel With {.AutoSize = True, .FlowDirection = FlowDirection.TopDown, .WrapContents = False}
        For Each wrapped As Label In {lblBookTitle, lblAuthor, lblISBN, lblCategory, lblPublisher, lblYear, lblAvailability}
            wrapped.MaximumSize = New Size(360, 0)
            info.Controls.Add(wrapped)
        Next
        lblBookTitle.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold)

        Dim body As New TableLayoutPanel With {.AutoSize = True, .ColumnCount = 2}
        body.Controls.Add(picCover)
        body.Controls.Add(info)
        AddAutoRow(body)
        AddAutoRow(NewLabel("lblDescription", "Description:"))
        AddAutoRow(txtDescription)
        AddAutoRow(NewButtonRow("pnlActions", btnBorrow, btnClose))
        AddAutoRow(lblMessage)

        btnBorrow.Enabled = False
        btnClose.DialogResult = DialogResult.Cancel
        CancelButton = btnClose
        AddHandler btnBorrow.Click, Sub(sender As Object, e As EventArgs) OnBorrow()
    End Sub

    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)
        Run(Sub()
                Dim book As BookInfo = _books.GetBook(_bookId)
                lblBookTitle.Text = book.Title
                lblAuthor.Text = "Author: " & book.Author
                lblISBN.Text = "ISBN: " & book.Isbn
                lblCategory.Text = "Category: " & book.CategoryName
                lblPublisher.Text = "Publisher: " & book.Publisher
                lblYear.Text = "Publication Year: " & book.PublicationYear.ToString()
                lblAvailability.Text = "Available Copies: " & book.AvailableCopies.ToString() & " of " & book.TotalCopies.ToString()
                txtDescription.Text = If(book.Description = "", "No description available.", book.Description)
                picCover.Image = MakeCover(book.Title, 180, 230)
                Dim student As Boolean = AppSession.CurrentUser IsNot Nothing AndAlso AppSession.CurrentUser.IsStudent
                btnBorrow.Visible = student
                btnBorrow.Enabled = student AndAlso book.AvailableCopies > 0
            End Sub)
    End Sub

    Private Sub OnBorrow()
        Using dialog As New BorrowBookForm(_bookId)
            If dialog.ShowDialog(Me) = DialogResult.OK Then DialogResult = DialogResult.OK
        End Using
    End Sub
End Class
