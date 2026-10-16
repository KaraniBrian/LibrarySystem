Option Strict On
Option Explicit On

Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms
Imports LibraryManagement.Core

''' <summary>Screen 19 - My Fines and Payments (read-only for students; fines are paid at the library desk).</summary>
Public Class MyFinesForm
    Inherits PageForm

    Private ReadOnly _fines As New FineService()
    Private ReadOnly cardTotal As New StatCard("TotalFine", "Total Fines", "0.00")
    Private ReadOnly cardPaid As New StatCard("Paid", "Total Paid", "0.00")
    Private ReadOnly cardBalance As New StatCard("Balance", "Outstanding Balance", "0.00")
    Private ReadOnly cmbStatus As ComboBox = NewCombo("cmbStatus")
    Private ReadOnly dgvMyFines As DataGridView = NewGrid("dgvMyFines")
    Private ReadOnly btnViewDetails As Button = NewButton("btnViewDetails", "View Fine Details", ButtonKind.Secondary, 170)
    Private ReadOnly btnViewPayments As Button = NewButton("btnViewPayments", "Payment History", ButtonKind.Secondary, 160)
    Private ReadOnly btnRefresh As Button = NewButton("btnRefresh", "Refresh", ButtonKind.Secondary, 100)
    Private _currency As String = "KES"
    Private _loading As Boolean

    Public Sub New()
        MyBase.New("My Fines and Payments")
        Dim cards As New FlowLayoutPanel With {.Name = "pnlCards", .AutoSize = True, .WrapContents = True}
        cardBalance.ValueLabel.ForeColor = Theme.Danger
        cards.Controls.AddRange(New Control() {cardTotal, cardPaid, cardBalance})
        AddAutoRow(cards)

        cmbStatus.Width = 170
        Dim bar As FlowLayoutPanel = NewToolbar("pnlFilter")
        bar.Controls.AddRange(New Control() {NewLabel("lblStatus", "Payment Status:"), cmbStatus})
        AddAutoRow(bar)
        AddFillRow(dgvMyFines)
        AddAutoRow(NewButtonRow("pnlActions", btnViewDetails, btnViewPayments, btnRefresh))
        AddAutoRow(NewLabel("lblNote", "Fines are paid at the library desk. The librarian records your payment."))
        AddAutoRow(lblMessage)

        FillCombo(cmbStatus, FineService.StatusFilters)
        AddHandler cmbStatus.SelectionChangeCommitted, Sub(sender As Object, e As EventArgs) LoadFines()
        AddHandler btnRefresh.Click, Sub(sender As Object, e As EventArgs) LoadFines()
        AddHandler btnViewDetails.Click, Sub(sender As Object, e As EventArgs) OnViewDetails()
        AddHandler btnViewPayments.Click, Sub(sender As Object, e As EventArgs) OnViewPayments()
    End Sub

    Protected Overrides Sub LoadData()
        Run(Sub() _currency = New SettingsService().GetSettings().Currency)
        LoadFines()
    End Sub

    Private Sub LoadFines()
        Run(Sub()
                Dim total As Decimal
                Dim paid As Decimal
                Dim balance As Decimal
                _fines.GetMyTotals(total, paid, balance)
                For Each card As StatCard In {cardTotal, cardPaid, cardBalance}
                    card.ValueLabel.Font = New Font("Segoe UI", 16.0F, FontStyle.Bold)
                Next
                cardTotal.ValueLabel.Text = Formatting.Money(total, _currency)
                cardPaid.ValueLabel.Text = Formatting.Money(paid, _currency)
                cardBalance.ValueLabel.Text = Formatting.Money(balance, _currency)
                Dim table As DataTable = _fines.GetMyFines(Convert.ToString(cmbStatus.SelectedItem))
                _loading = True
                Try
                    BindGrid(dgvMyFines, table)
                Finally
                    _loading = False
                End Try
            End Sub)
    End Sub

    Private Function RequireRow() As DataGridViewRow
        Dim row As DataGridViewRow = SelectedRow(dgvMyFines)
        If row Is Nothing Then ShowMsg("Select a fine first.", True)
        Return row
    End Function

    Private Sub OnViewDetails()
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

    Private Sub OnViewPayments()
        Dim row As DataGridViewRow = RequireRow()
        If row Is Nothing Then Return
        Using dialog As New PaymentHistoryDialog(CellInt(row, "Fine ID"), AppSession.CurrentUser.FullName)
            dialog.ShowDialog(Me)
        End Using
    End Sub
End Class
