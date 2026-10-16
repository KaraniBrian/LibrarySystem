Option Strict On
Option Explicit On

Imports System.Windows.Forms
Imports LibraryManagement.Core

''' <summary>Screen 12 - Library Settings (policies) plus database backup and restore.</summary>
Public Class LibrarySettingsForm
    Inherits PageForm

    Private ReadOnly _svc As New SettingsService()
    Private ReadOnly _backup As New BackupService()
    Private ReadOnly txtLibraryName As TextBox = NewTextBox("txtLibraryName", 150)
    Private ReadOnly nudLoanDays As NumericUpDown = NewNumeric("nudLoanDays", 1, 365, 14)
    Private ReadOnly nudFineRate As NumericUpDown = NewNumeric("nudFineRate", 0, 10000, 10, 2)
    Private ReadOnly nudMaxBooks As NumericUpDown = NewNumeric("nudMaxBooks", 1, 100, 3)
    Private ReadOnly cmbCurrency As ComboBox = NewCombo("cmbCurrency")
    Private ReadOnly btnSave As Button = NewButton("btnSave", "Save Settings", ButtonKind.Primary, 160)
    Private ReadOnly btnReset As Button = NewButton("btnReset", "Reset", ButtonKind.Secondary, 100)
    Private ReadOnly btnBackup As Button = NewButton("btnBackup", "Backup Database", ButtonKind.Secondary, 180)
    Private ReadOnly btnRestore As Button = NewButton("btnRestore", "Restore Database", ButtonKind.Danger, 180)

    Public Sub New()
        MyBase.New("Library Settings")
        Dim fields As TableLayoutPanel = NewFieldTable("tblFields", 1)
        fields.MaximumSize = New System.Drawing.Size(700, 0)
        AddField(fields, NewLabel("lblLibraryName", "Library Name:"), txtLibraryName)
        AddField(fields, NewLabel("lblLoanDays", "Default Loan Period (Days):"), nudLoanDays)
        AddField(fields, NewLabel("lblFineRate", "Fine per Overdue Day:"), nudFineRate)
        AddField(fields, NewLabel("lblMaxBooks", "Maximum Books per Student:"), nudMaxBooks)
        AddField(fields, NewLabel("lblCurrency", "Currency:"), cmbCurrency)
        AddAutoRow(fields)
        AddAutoRow(NewButtonRow("pnlActions", btnSave, btnReset))
        AddAutoRow(NewLabel("lblBackupTitle", "Database backup (requires the MySQL command-line tools)", True))
        AddAutoRow(NewButtonRow("pnlBackup", btnBackup, btnRestore))
        AddAutoRow(lblMessage)

        FillCombo(cmbCurrency, {"KES", "USD", "EUR", "GBP", "UGX", "TZS"})
        AddHandler btnSave.Click, Sub(sender As Object, e As EventArgs) OnSave()
        AddHandler btnReset.Click, Sub(sender As Object, e As EventArgs) LoadData()
        AddHandler btnBackup.Click, Sub(sender As Object, e As EventArgs) OnBackup()
        AddHandler btnRestore.Click, Sub(sender As Object, e As EventArgs) OnRestore()
    End Sub

    Protected Overrides Sub LoadData()
        Run(Sub()
                Dim s As LibrarySettings = _svc.GetSettings()
                txtLibraryName.Text = s.LibraryName
                nudLoanDays.Value = Math.Min(Math.Max(s.LoanDays, 1), 365)
                nudFineRate.Value = Math.Min(Math.Max(s.FinePerDay, 0D), 10000D)
                nudMaxBooks.Value = Math.Min(Math.Max(s.MaxBooksPerStudent, 1), 100)
                If Not cmbCurrency.Items.Contains(s.Currency) Then cmbCurrency.Items.Add(s.Currency)
                cmbCurrency.SelectedItem = s.Currency
            End Sub)
    End Sub

    Private Sub OnSave()
        Dim s As New LibrarySettings With {
            .LibraryName = txtLibraryName.Text, .LoanDays = CInt(nudLoanDays.Value), .FinePerDay = nudFineRate.Value,
            .MaxBooksPerStudent = CInt(nudMaxBooks.Value), .Currency = Convert.ToString(cmbCurrency.SelectedItem)}
        If Not Confirm("Save these library settings? They apply to all new loans and fines.") Then Return
        If Run(Sub() _svc.Save(s)) Then ShowMsg("Settings saved.", False)
    End Sub

    Private Sub OnBackup()
        Using dialog As New SaveFileDialog With {.Filter = "SQL files (*.sql)|*.sql", .FileName = "library_backup_" & Date.Today.ToString("yyyyMMdd") & ".sql"}
            If dialog.ShowDialog(Me) <> DialogResult.OK Then Return
            If Run(Sub() _backup.Backup(dialog.FileName)) Then ShowMsg("Backup saved to " & dialog.FileName, False)
        End Using
    End Sub

    Private Sub OnRestore()
        Using dialog As New OpenFileDialog With {.Filter = "SQL files (*.sql)|*.sql", .Title = "Choose a backup to restore"}
            If dialog.ShowDialog(Me) <> DialogResult.OK Then Return
            If Not Confirm("Restoring replaces the current data with the backup. Continue?") Then Return
            If Run(Sub() _backup.Restore(dialog.FileName)) Then ShowMsg("Database restored.", False)
        End Using
    End Sub
End Class
