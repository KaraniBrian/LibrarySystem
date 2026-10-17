Option Strict On
Option Explicit On

Imports System.Data
Imports System.Windows.Forms
Imports LibraryManagement.Core

''' <summary>Screen 11 - Reports: seven report types, CSV export and printing.</summary>
Public Class ReportsForm
    Private ReadOnly _reports As New ReportService()
    Private _table As DataTable
    Private _title As String = ""
    Private _currency As String = "KES"

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
    End Sub

    Private Sub ReportsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CmbReportType.SelectedIndex = 0
        DtpFromDate.Value = Date.Today.AddMonths(-1)
        DtpToDate.Value = Date.Today
        Run(Sub() _currency = New SettingsService().GetSettings().Currency, LblMessage)
    End Sub

    Private Sub BtnGenerate_Click(sender As Object, e As EventArgs) Handles BtnGenerate.Click
        Dim kind As String = Convert.ToString(CmbReportType.SelectedItem)
        Dim fromDate As Date = DtpFromDate.Value
        Dim toDate As Date = DtpToDate.Value
        Run(Sub()
                _table = _reports.Generate(kind, fromDate, toDate)
                _title = kind
                BindGrid(DgvReport, _table)
                LblSummaryText.Text = ReportService.Summarize(kind, _table, _currency)
                ShowMessage(LblMessage, "", False)
            End Sub, LblMessage)
    End Sub

    Private Function HasReport() As Boolean
        If _table IsNot Nothing AndAlso _table.Rows.Count > 0 Then Return True
        ShowMessage(LblMessage, "Generate a report with at least one row first.", True)
        Return False
    End Function

    Private Sub BtnExportCsv_Click(sender As Object, e As EventArgs) Handles BtnExportCsv.Click
        If Not HasReport() Then Return
        Using dialog As New SaveFileDialog With {.Filter = "CSV files (*.csv)|*.csv", .FileName = _title.Replace(" ", "_") & ".csv"}
            If dialog.ShowDialog(Me) <> DialogResult.OK Then Return
            If Run(Sub() ReportService.ExportCsv(_table, dialog.FileName), LblMessage) Then ShowMessage(LblMessage, "Report exported.", False)
        End Using
    End Sub

    Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles BtnPrint.Click
        If Not HasReport() Then Return
        Run(Sub() GridPrinter.ShowPreview(DgvReport, _title, Me), LblMessage)
    End Sub
End Class
