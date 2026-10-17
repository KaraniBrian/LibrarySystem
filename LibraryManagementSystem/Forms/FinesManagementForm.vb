Option Strict On
Option Explicit On

Imports System.Data
Imports System.Windows.Forms
Imports LibraryManagement.Core

''' <summary>Screen 9 - Fines Management (librarian records payments).</summary>
Public Class FinesManagementForm
    Private ReadOnly _fines As New FineService()
    Private _fineId As Integer
    Private _balance As Decimal
    Private _currency As String = "KES"
    Private _loading As Boolean = True

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        StatusColors(DgvFines)
    End Sub

    Private Sub FinesManagementForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CmbFineStatus.SelectedIndex = 0
        _loading = False
        Run(Sub() _currency = New SettingsService().GetSettings().Currency, LblMessage)
        LoadFines()
    End Sub

    Private Sub TxtSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            LoadFines()
        End If
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        LoadFines()
    End Sub

    Private Sub CmbFineStatus_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CmbFineStatus.SelectionChangeCommitted
        LoadFines()
    End Sub

    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles BtnRefresh.Click
        LoadFines()
    End Sub

    Private Sub LoadFines()
        Run(Sub()
                Dim table As DataTable = _fines.Search(TxtSearch.Text, Convert.ToString(CmbFineStatus.SelectedItem))
                _loading = True
                Try
                    BindGrid(DgvFines, table)
                Finally
                    _loading = False
                End Try
            End Sub, LblMessage)
        ClearDetails()
    End Sub

    Private Sub ClearDetails()
        _fineId = 0
        _balance = 0D
        TxtStudent.Clear()
        TxtFineAmount.Clear()
        TxtAmountPaid.Clear()
        TxtBalance.Clear()
        BtnRecordPayment.Enabled = False
        _loading = True
        Try
            ClearGridSelection(DgvFines)
        Finally
            _loading = False
        End Try
    End Sub

    Private Sub DgvFines_SelectionChanged(sender As Object, e As EventArgs) Handles DgvFines.SelectionChanged
        If _loading Then Return
        Dim row As DataGridViewRow = SelectedRow(DgvFines)
        If row Is Nothing Then Return
        _fineId = CellInt(row, "Fine ID")
        _balance = CellDecimal(row, "Balance")
        TxtStudent.Text = CellText(row, "Student")
        TxtFineAmount.Text = Formatting.Money(CellDecimal(row, "Amount"), _currency)
        TxtAmountPaid.Text = Formatting.Money(CellDecimal(row, "Paid"), _currency)
        TxtBalance.Text = Formatting.Money(_balance, _currency)
        BtnRecordPayment.Enabled = _balance > 0D
    End Sub

    Private Sub BtnRecordPayment_Click(sender As Object, e As EventArgs) Handles BtnRecordPayment.Click
        If _fineId <= 0 OrElse _balance <= 0D Then
            ShowMessage(LblMessage, "Select a fine with an outstanding balance.", True)
            Return
        End If
        Using dialog As New PaymentDialog(_balance, _currency, TxtStudent.Text)
            If dialog.ShowDialog(Me) <> DialogResult.OK Then Return
            Dim id As Integer = _fineId
            Dim amount As Decimal = dialog.Amount
            Dim method As String = dialog.Method
            If Run(Sub() _fines.RecordPayment(id, amount, method), LblMessage) Then
                LoadFines()
                ShowMessage(LblMessage, "Payment of " & Formatting.Money(amount, _currency) & " recorded.", False)
            End If
        End Using
    End Sub

    Private Sub BtnViewDetails_Click(sender As Object, e As EventArgs) Handles BtnViewDetails.Click
        If _fineId <= 0 Then
            ShowMessage(LblMessage, "Select a fine first.", True)
            Return
        End If
        Using dialog As New PaymentHistoryDialog(_fineId, TxtStudent.Text)
            dialog.ShowDialog(Me)
        End Using
    End Sub
End Class
