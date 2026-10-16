Option Strict On
Option Explicit On

Imports System.Data
Imports System.Windows.Forms
Imports LibraryManagement.Core

''' <summary>Screen 9 - Fines Management (librarian records payments).</summary>
Public Class FinesManagementForm
    Inherits PageForm

    Private ReadOnly _fines As New FineService()
    Private ReadOnly txtSearch As TextBox = NewTextBox("txtSearch", 100, False, "Search student or fine ID")
    Private ReadOnly btnSearch As Button = NewButton("btnSearch", "Search", ButtonKind.Primary, 100)
    Private ReadOnly cmbFineStatus As ComboBox = NewCombo("cmbFineStatus")
    Private ReadOnly dgvFines As DataGridView = NewGrid("dgvFines")
    Private ReadOnly txtStudent As TextBox = NewTextBox("txtStudent", 0, True)
    Private ReadOnly txtFineAmount As TextBox = NewTextBox("txtFineAmount", 0, True)
    Private ReadOnly txtAmountPaid As TextBox = NewTextBox("txtAmountPaid", 0, True)
    Private ReadOnly txtBalance As TextBox = NewTextBox("txtBalance", 0, True)
    Private ReadOnly btnRecordPayment As Button = NewButton("btnRecordPayment", "Record Payment", ButtonKind.Primary, 160)
    Private ReadOnly btnViewDetails As Button = NewButton("btnViewDetails", "View Details", ButtonKind.Secondary, 140)
    Private ReadOnly btnRefresh As Button = NewButton("btnRefresh", "Refresh", ButtonKind.Secondary, 100)

    Private _fineId As Integer
    Private _balance As Decimal
    Private _currency As String = "KES"
    Private _loading As Boolean

    Public Sub New()
        MyBase.New("Fines Management")
        txtSearch.Width = 300
        cmbFineStatus.Width = 160
        Dim bar As FlowLayoutPanel = NewToolbar("pnlSearchBar")
        bar.Controls.AddRange(New Control() {txtSearch, btnSearch, NewLabel("lblFineStatus", "Payment Status:"), cmbFineStatus})
        AddAutoRow(bar)
        AddFillRow(dgvFines)

        Dim fields As TableLayoutPanel = NewFieldTable("tblFields", 2)
        AddField(fields, NewLabel("lblStudent", "Student:"), txtStudent)
        AddField(fields, NewLabel("lblFineAmount", "Fine Amount:"), txtFineAmount)
        AddField(fields, NewLabel("lblAmountPaid", "Amount Paid:"), txtAmountPaid)
        AddField(fields, NewLabel("lblBalance", "Outstanding Balance:"), txtBalance)
        AddAutoRow(fields)
        AddAutoRow(NewButtonRow("pnlActions", btnRecordPayment, btnViewDetails, btnRefresh))
        AddAutoRow(lblMessage)

        FillCombo(cmbFineStatus, FineService.StatusFilters)
        AddHandler btnSearch.Click, Sub(sender As Object, e As EventArgs) LoadFines()
        EnterKeyAction(txtSearch, AddressOf LoadFines)
        AddHandler cmbFineStatus.SelectedIndexChanged, Sub(sender As Object, e As EventArgs) LoadFines()
        AddHandler btnRefresh.Click, Sub(sender As Object, e As EventArgs) LoadFines()
        AddHandler dgvFines.SelectionChanged, Sub(sender As Object, e As EventArgs) OnSelectionChanged()
        AddHandler btnRecordPayment.Click, Sub(sender As Object, e As EventArgs) OnRecordPayment()
        AddHandler btnViewDetails.Click, Sub(sender As Object, e As EventArgs) OnViewDetails()
    End Sub

    Protected Overrides Sub LoadData()
        Run(Sub() _currency = New SettingsService().GetSettings().Currency)
        LoadFines()
    End Sub

    Private Sub LoadFines()
        Run(Sub()
                Dim table As DataTable = _fines.Search(txtSearch.Text, Convert.ToString(cmbFineStatus.SelectedItem))
                _loading = True
                Try
                    BindGrid(dgvFines, table)
                Finally
                    _loading = False
                End Try
            End Sub)
        ClearDetails()
    End Sub

    Private Sub ClearDetails()
        _fineId = 0
        _balance = 0D
        txtStudent.Clear()
        txtFineAmount.Clear()
        txtAmountPaid.Clear()
        txtBalance.Clear()
        btnRecordPayment.Enabled = False
        _loading = True
        Try
            dgvFines.ClearSelection()
            dgvFines.CurrentCell = Nothing
        Finally
            _loading = False
        End Try
    End Sub

    Private Sub OnSelectionChanged()
        If _loading Then Return
        Dim row As DataGridViewRow = SelectedRow(dgvFines)
        If row Is Nothing Then Return
        _fineId = CellInt(row, "Fine ID")
        _balance = CellDecimal(row, "Balance")
        txtStudent.Text = CellText(row, "Student")
        txtFineAmount.Text = Formatting.Money(CellDecimal(row, "Amount"), _currency)
        txtAmountPaid.Text = Formatting.Money(CellDecimal(row, "Paid"), _currency)
        txtBalance.Text = Formatting.Money(_balance, _currency)
        btnRecordPayment.Enabled = _balance > 0D
    End Sub

    Private Sub OnRecordPayment()
        If _fineId <= 0 OrElse _balance <= 0D Then
            ShowMsg("Select a fine with an outstanding balance.", True)
            Return
        End If
        Using dialog As New PaymentDialog(_balance, _currency, txtStudent.Text)
            If dialog.ShowDialog(Me) <> DialogResult.OK Then Return
            Dim id As Integer = _fineId
            Dim amount As Decimal = dialog.Amount
            Dim method As String = dialog.Method
            If Run(Sub() _fines.RecordPayment(id, amount, method)) Then
                LoadFines()
                ShowMsg("Payment of " & Formatting.Money(amount, _currency) & " recorded.", False)
            End If
        End Using
    End Sub

    Private Sub OnViewDetails()
        If _fineId <= 0 Then
            ShowMsg("Select a fine first.", True)
            Return
        End If
        Using dialog As New PaymentHistoryDialog(_fineId, txtStudent.Text)
            dialog.ShowDialog(Me)
        End Using
    End Sub
End Class

''' <summary>Payment confirmation dialog: amount and payment method.</summary>
Public Class PaymentDialog
    Inherits DialogForm

    Private ReadOnly nudAmount As NumericUpDown
    Private ReadOnly cmbMethod As ComboBox = NewCombo("cmbMethod")
    Private ReadOnly btnConfirm As Button = NewButton("btnConfirm", "Confirm Payment", ButtonKind.Primary, 170)
    Private ReadOnly btnCancel As Button = NewButton("btnCancel", "Cancel", ButtonKind.Secondary, 110)

    Public ReadOnly Property Amount As Decimal
        Get
            Return nudAmount.Value
        End Get
    End Property

    Public ReadOnly Property Method As String
        Get
            Return Convert.ToString(cmbMethod.SelectedItem)
        End Get
    End Property

    Public Sub New(balance As Decimal, currency As String, studentName As String)
        MyBase.New("Record Payment")
        nudAmount = NewNumeric("nudAmount", 0.01D, balance, balance, 2)
        AddAutoRow(NewLabel("lblStudentName", "Student: " & studentName))
        AddAutoRow(NewLabel("lblBalanceInfo", "Outstanding balance: " & Formatting.Money(balance, currency)))
        Dim fields As TableLayoutPanel = NewFieldTable("tblFields", 1)
        AddField(fields, NewLabel("lblAmount", "Amount received (" & currency & "):"), nudAmount)
        AddField(fields, NewLabel("lblPaymentMethod", "Payment method:"), cmbMethod)
        AddAutoRow(fields)
        AddAutoRow(NewLabel("lblNote", "Only record money that was actually received.", False))
        AddAutoRow(NewButtonRow("pnlActions", btnConfirm, btnCancel))
        FillCombo(cmbMethod, FineService.PaymentMethods)
        btnConfirm.DialogResult = DialogResult.OK
        btnCancel.DialogResult = DialogResult.Cancel
        AcceptButton = btnConfirm
        CancelButton = btnCancel
    End Sub
End Class

''' <summary>Lists the payments made against one fine.</summary>
Public Class PaymentHistoryDialog
    Inherits DialogForm

    Private ReadOnly _fines As New FineService()
    Private ReadOnly _fineId As Integer
    Private ReadOnly dgvPayments As DataGridView = NewGrid("dgvPayments")
    Private ReadOnly btnClose As Button = NewButton("btnClose", "Close", ButtonKind.Secondary, 110)

    Public Sub New(fineId As Integer, studentName As String)
        MyBase.New("Payment History", 620)
        _fineId = fineId
        AddAutoRow(NewLabel("lblStudentName", "Student: " & studentName))
        dgvPayments.Height = 220
        AddAutoRow(dgvPayments)
        AddAutoRow(NewButtonRow("pnlActions", btnClose))
        AddAutoRow(lblMessage)
        btnClose.DialogResult = DialogResult.OK
        AcceptButton = btnClose
    End Sub

    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)
        Run(Sub()
                Dim table As DataTable = _fines.GetPayments(_fineId)
                BindGrid(dgvPayments, table)
                If table.Rows.Count = 0 Then ShowMsg("No payments have been made yet.", False)
            End Sub)
    End Sub
End Class
