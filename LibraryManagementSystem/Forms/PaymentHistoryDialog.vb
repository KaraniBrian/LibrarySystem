Option Strict On
Option Explicit On

Imports System.Data
Imports System.Windows.Forms
Imports LibraryManagement.Core

''' <summary>Lists the payments made against one fine.</summary>
Public Class PaymentHistoryDialog
    Private ReadOnly _fines As New FineService()
    Private _fineId As Integer

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
    End Sub

    Public Sub New(fineId As Integer, studentName As String)
        Me.New()
        _fineId = fineId
        LblStudentName.Text = "Student: " & studentName
    End Sub

    Private Sub PaymentHistoryDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Run(Sub()
                Dim table As DataTable = _fines.GetPayments(_fineId)
                BindGrid(DgvPayments, table)
                If table.Rows.Count = 0 Then ShowMessage(LblMessage, "No payments have been made yet.", False)
            End Sub, LblMessage)
    End Sub
End Class
