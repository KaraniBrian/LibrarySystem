Option Strict On
Option Explicit On

Imports System.Data
Imports System.Windows.Forms
Imports LibraryManagement.Core

''' <summary>Screen 19 - My Fines and Payments (read-only for students; fines are paid at the library desk).</summary>
Public Class MyFinesForm
    Private ReadOnly _fines As New FineService()
    Private _currency As String = "KES"

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        StatusColors(DgvMyFines)
    End Sub

    Private Sub MyFinesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CmbStatus.SelectedIndex = 0
        LblBalanceValue.ForeColor = Theme.Danger
        Run(Sub() _currency = New SettingsService().GetSettings().Currency, LblMessage)
        LoadFines()
    End Sub

    Private Sub CmbStatus_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CmbStatus.SelectionChangeCommitted
        LoadFines()
    End Sub

    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles BtnRefresh.Click
        LoadFines()
    End Sub

    Private Sub LoadFines()
        Run(Sub()
                Dim total As Decimal
                Dim paid As Decimal
                Dim balance As Decimal
                _fines.GetMyTotals(total, paid, balance)
                LblTotalFineValue.Text = Formatting.Money(total, _currency)
                LblPaidValue.Text = Formatting.Money(paid, _currency)
                LblBalanceValue.Text = Formatting.Money(balance, _currency)
                BindGrid(DgvMyFines, _fines.GetMyFines(Convert.ToString(CmbStatus.SelectedItem)))
            End Sub, LblMessage)
    End Sub

    Private Function RequireRow() As DataGridViewRow
        Dim row As DataGridViewRow = SelectedRow(DgvMyFines)
        If row Is Nothing Then ShowMessage(LblMessage, "Select a fine first.", True)
        Return row
    End Function

    Private Sub BtnViewDetails_Click(sender As Object, e As EventArgs) Handles BtnViewDetails.Click
        Dim row As DataGridViewRow = RequireRow()
        If row Is Nothing Then Return
        Info("Fine ID: " & CellText(row, "Fine ID") & vbCrLf &
             "Book: " & CellText(row, "Book") & vbCrLf &
             "Date: " & CellDate(row, "Date").ToString("yyyy-MM-dd") & vbCrLf &
             "Amount: " & Formatting.Money(CellDecimal(row, "Amount"), _currency) & vbCrLf &
             "Paid: " & Formatting.Money(CellDecimal(row, "Paid"), _currency) & vbCrLf &
             "Balance: " & Formatting.Money(CellDecimal(row, "Balance"), _currency) & vbCrLf &
             "Status: " & CellText(row, "Status"))
    End Sub

    Private Sub BtnViewPayments_Click(sender As Object, e As EventArgs) Handles BtnViewPayments.Click
        Dim row As DataGridViewRow = RequireRow()
        If row Is Nothing Then Return
        Using dialog As New PaymentHistoryDialog(CellInt(row, "Fine ID"), AppSession.CurrentUser.FullName)
            dialog.ShowDialog(Me)
        End Using
    End Sub
End Class
