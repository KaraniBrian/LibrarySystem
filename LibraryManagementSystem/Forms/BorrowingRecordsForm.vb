Option Strict On
Option Explicit On

Imports System.Data
Imports System.Windows.Forms
Imports LibraryManagement.Core

''' <summary>Screen 10 - Borrowing / Returns Records with filters and CSV export.</summary>
Public Class BorrowingRecordsForm
    Private ReadOnly _loans As New LoanService()
    Private _table As DataTable

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        StatusColors(DgvRecords)
    End Sub

    Private Sub BorrowingRecordsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ResetFilters()
        LoadRecords()
    End Sub

    Private Sub ResetFilters()
        TxtSearch.Clear()
        CmbStatus.SelectedIndex = 0
        DtpFromDate.Value = Date.Today.AddYears(-1)
        DtpToDate.Value = Date.Today
    End Sub

    Private Sub TxtSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            LoadRecords()
        End If
    End Sub

    Private Sub BtnFilter_Click(sender As Object, e As EventArgs) Handles BtnFilter.Click
        LoadRecords()
    End Sub

    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles BtnRefresh.Click
        LoadRecords()
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        ResetFilters()
        LoadRecords()
    End Sub

    Private Sub LoadRecords()
        Run(Sub()
                If DtpFromDate.Value.Date > DtpToDate.Value.Date Then Throw New BusinessRuleException("The 'From' date must not be after the 'To' date.")
                _table = _loans.GetRecords(TxtSearch.Text, Convert.ToString(CmbStatus.SelectedItem), DtpFromDate.Value, DtpToDate.Value)
                BindGrid(DgvRecords, _table)
                LblRecordCount.Text = "Records: " & _table.Rows.Count.ToString()
            End Sub, LblMessage)
    End Sub

    Private Sub BtnViewDetails_Click(sender As Object, e As EventArgs) Handles BtnViewDetails.Click
        Dim row As DataGridViewRow = SelectedRow(DgvRecords)
        If row Is Nothing Then
            ShowMessage(LblMessage, "Select a record first.", True)
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

    Private Sub BtnExport_Click(sender As Object, e As EventArgs) Handles BtnExport.Click
        If _table Is Nothing OrElse _table.Rows.Count = 0 Then
            ShowMessage(LblMessage, "There are no records to export.", True)
            Return
        End If
        Using dialog As New SaveFileDialog With {.Filter = "CSV files (*.csv)|*.csv", .FileName = "borrowing_records.csv"}
            If dialog.ShowDialog(Me) <> DialogResult.OK Then Return
            If Run(Sub() ReportService.ExportCsv(_table, dialog.FileName), LblMessage) Then ShowMessage(LblMessage, "Records exported.", False)
        End Using
    End Sub
End Class
