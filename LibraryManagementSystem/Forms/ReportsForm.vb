Option Strict On
Option Explicit On

Imports System.Data
Imports System.Windows.Forms
Imports LibraryManagement.Core

''' <summary>Screen 11 - Reports: seven report types, CSV export and printing.</summary>
Public Class ReportsForm
    Inherits PageForm

    Private ReadOnly _reports As New ReportService()
    Private ReadOnly cmbReportType As ComboBox = NewCombo("cmbReportType")
    Private ReadOnly dtpFromDate As DateTimePicker = NewDate("dtpFromDate")
    Private ReadOnly dtpToDate As DateTimePicker = NewDate("dtpToDate")
    Private ReadOnly btnGenerate As Button = NewButton("btnGenerate", "Generate Report", ButtonKind.Primary, 160)
    Private ReadOnly dgvReport As DataGridView = NewGrid("dgvReport")
    Private ReadOnly btnExportCSV As Button = NewButton("btnExportCSV", "Export CSV", ButtonKind.Secondary, 130)
    Private ReadOnly btnPrint As Button = NewButton("btnPrint", "Print Report", ButtonKind.Secondary, 130)
    Private ReadOnly lblSummary As Label = NewLabel("lblSummary", "Report Summary", True)
    Private ReadOnly lblSummaryText As Label = NewLabel("lblSummaryText", "Choose a report and click Generate.")
    Private ReadOnly pnlSummary As New Panel() With {.Name = "pnlSummary", .BackColor = System.Drawing.Color.White,
                                                     .BorderStyle = BorderStyle.FixedSingle, .Height = 80}
    Private _table As DataTable
    Private _title As String = ""
    Private _currency As String = "KES"

    Public Sub New()
        MyBase.New("Reports")
        cmbReportType.Width = 220
        Dim bar As FlowLayoutPanel = NewToolbar("pnlOptions")
        bar.Controls.AddRange(New Control() {NewLabel("lblReportType", "Report Type:"), cmbReportType,
                                             NewLabel("lblFromDate", "From Date:"), dtpFromDate,
                                             NewLabel("lblToDate", "To Date:"), dtpToDate, btnGenerate})
        AddAutoRow(bar)
        AddAutoRow(NewLabel("lblDateNote", "The date range applies to Returned Books and Payment History."))
        AddFillRow(dgvReport)

        lblSummary.Location = New System.Drawing.Point(10, 6)
        lblSummaryText.Location = New System.Drawing.Point(10, 30)
        pnlSummary.Controls.Add(lblSummary)
        pnlSummary.Controls.Add(lblSummaryText)
        AddAutoRow(pnlSummary)
        AddAutoRow(NewButtonRow("pnlActions", btnExportCSV, btnPrint))
        AddAutoRow(lblMessage)

        FillCombo(cmbReportType, ReportService.ReportTypes)
        dtpFromDate.Value = Date.Today.AddMonths(-1)
        dtpToDate.Value = Date.Today
        AddHandler btnGenerate.Click, Sub(sender As Object, e As EventArgs) OnGenerate()
        AddHandler btnExportCSV.Click, Sub(sender As Object, e As EventArgs) OnExport()
        AddHandler btnPrint.Click, Sub(sender As Object, e As EventArgs) OnPrintReport()
    End Sub

    Protected Overrides Sub LoadData()
        Run(Sub() _currency = New SettingsService().GetSettings().Currency)
    End Sub

    Private Sub OnGenerate()
        Dim kind As String = Convert.ToString(cmbReportType.SelectedItem)
        Dim fromDate As Date = dtpFromDate.Value
        Dim toDate As Date = dtpToDate.Value
        Run(Sub()
                _table = _reports.Generate(kind, fromDate, toDate)
                _title = kind
                BindGrid(dgvReport, _table)
                lblSummaryText.Text = ReportService.Summarize(kind, _table, _currency)
                ShowMsg("", False)
            End Sub)
    End Sub

    Private Function HasReport() As Boolean
        If _table IsNot Nothing AndAlso _table.Rows.Count > 0 Then Return True
        ShowMsg("Generate a report with at least one row first.", True)
        Return False
    End Function

    Private Sub OnExport()
        If Not HasReport() Then Return
        Using dialog As New SaveFileDialog With {.Filter = "CSV files (*.csv)|*.csv", .FileName = _title.Replace(" ", "_") & ".csv"}
            If dialog.ShowDialog(Me) <> DialogResult.OK Then Return
            If Run(Sub() ReportService.ExportCsv(_table, dialog.FileName)) Then ShowMsg("Report exported.", False)
        End Using
    End Sub

    Private Sub OnPrintReport()
        If Not HasReport() Then Return
        Run(Sub() GridPrinter.ShowPreview(dgvReport, _title, Me))
    End Sub
End Class
