Option Strict On
Option Explicit On

Imports System.Data
Imports System.Windows.Forms
Imports LibraryManagement.Core

''' <summary>Screen 10 - Borrowing / Returns Records with filters and CSV export.</summary>
Public Class BorrowingRecordsForm
    Inherits PageForm

    Private ReadOnly _loans As New LoanService()
    Private ReadOnly lblSearch As Label = NewLabel("lblSearch", "Search:")
    Private ReadOnly txtSearch As TextBox = NewTextBox("txtSearch", 100, False, "Search student, book or loan ID")
    Private ReadOnly lblStatus As Label = NewLabel("lblStatus", "Loan Status:")
    Private ReadOnly cmbStatus As ComboBox = NewCombo("cmbStatus")
    Private ReadOnly lblFromDate As Label = NewLabel("lblFromDate", "From Date:")
    Private ReadOnly dtpFromDate As DateTimePicker = NewDate("dtpFromDate")
    Private ReadOnly lblToDate As Label = NewLabel("lblToDate", "To Date:")
    Private ReadOnly dtpToDate As DateTimePicker = NewDate("dtpToDate")
    Private ReadOnly btnFilter As Button = NewButton("btnFilter", "Apply Filters", ButtonKind.Primary, 140)
    Private ReadOnly btnReset As Button = NewButton("btnReset", "Reset", ButtonKind.Secondary, 100)
    Private ReadOnly dgvRecords As DataGridView = NewGrid("dgvRecords")
    Private ReadOnly btnViewDetails As Button = NewButton("btnViewDetails", "View Details", ButtonKind.Secondary, 140)
    Private ReadOnly btnExport As Button = NewButton("btnExport", "Export Records", ButtonKind.Primary, 150)
    Private ReadOnly btnRefresh As Button = NewButton("btnRefresh", "Refresh", ButtonKind.Secondary, 100)
    Private ReadOnly lblRecordCount As Label = NewLabel("lblRecordCount", "Records: 0", True)
    Private _table As DataTable

    Public Sub New()
        MyBase.New("Borrowing and Returns Records")
        Dim bar As FlowLayoutPanel = NewToolbar("pnlFilters")
        bar.Controls.AddRange(New Control() {lblSearch, txtSearch, lblStatus, cmbStatus, lblFromDate, dtpFromDate, lblToDate, dtpToDate, btnFilter, btnReset})
        AddAutoRow(bar)
        AddFillRow(dgvRecords)
        AddAutoRow(NewButtonRow("pnlActions", btnViewDetails, btnExport, btnRefresh, lblRecordCount))
        AddAutoRow(lblMessage)

        txtSearch.Width = 240
        cmbStatus.Width = 150
        FillCombo(cmbStatus, LoanService.StatusFilters)
        AddHandler btnFilter.Click, Sub(sender As Object, e As EventArgs) LoadRecords()
        EnterKeyAction(txtSearch, AddressOf LoadRecords)
        AddHandler btnReset.Click, Sub(sender As Object, e As EventArgs) OnReset()
        AddHandler btnRefresh.Click, Sub(sender As Object, e As EventArgs) LoadRecords()
        AddHandler btnViewDetails.Click, Sub(sender As Object, e As EventArgs) OnViewDetails()
        AddHandler btnExport.Click, Sub(sender As Object, e As EventArgs) OnExport()
        ResetFilters()
    End Sub

    Private Sub ResetFilters()
        txtSearch.Clear()
        cmbStatus.SelectedIndex = 0
        dtpFromDate.Value = Date.Today.AddYears(-1)
        dtpToDate.Value = Date.Today
    End Sub

    Protected Overrides Sub LoadData()
        LoadRecords()
    End Sub

    Private Sub OnReset()
        ResetFilters()
        LoadRecords()
    End Sub

    Private Sub LoadRecords()
        Run(Sub()
                If dtpFromDate.Value.Date > dtpToDate.Value.Date Then Throw New BusinessRuleException("The 'From' date must not be after the 'To' date.")
                _table = _loans.GetRecords(txtSearch.Text, Convert.ToString(cmbStatus.SelectedItem), dtpFromDate.Value, dtpToDate.Value)
                BindGrid(dgvRecords, _table)
                lblRecordCount.Text = "Records: " & _table.Rows.Count.ToString()
            End Sub)
    End Sub

    Private Sub OnViewDetails()
        Dim row As DataGridViewRow = SelectedRow(dgvRecords)
        If row Is Nothing Then
            ShowMsg("Select a record first.", True)
            Return
        End If
        Dim returned As String = If(CellText(row, "Return Date") = "", "Not yet returned", CellDate(row, "Return Date").ToString("yyyy-MM-dd"))
        Info("Loan ID: " & CellText(row, "Loan ID") & vbCrLf &
             "Student: " & CellText(row, "Student") & " (" & CellText(row, "Admission No") & ")" & vbCrLf &
             "Book: " & CellText(row, "Book") & vbCrLf &
             "Issued: " & CellDate(row, "Issue Date").ToString("yyyy-MM-dd") & vbCrLf &
             "Due: " & CellDate(row, "Due Date").ToString("yyyy-MM-dd") & vbCrLf &
             "Returned: " & returned & vbCrLf &
             "Status: " & CellText(row, "Status"))
    End Sub

    Private Sub OnExport()
        If _table Is Nothing OrElse _table.Rows.Count = 0 Then
            ShowMsg("There are no records to export.", True)
            Return
        End If
        Using dialog As New SaveFileDialog With {.Filter = "CSV files (*.csv)|*.csv", .FileName = "borrowing_records.csv"}
            If dialog.ShowDialog(Me) <> DialogResult.OK Then Return
            If Run(Sub() ReportService.ExportCsv(_table, dialog.FileName)) Then ShowMsg("Records exported.", False)
        End Using
    End Sub
End Class
