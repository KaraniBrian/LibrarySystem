Option Strict On
Option Explicit On

Imports System.Windows.Forms
Imports LibraryManagement.Core

''' <summary>Screen 12 - Library Settings (policies) plus database backup and restore.</summary>
Public Class LibrarySettingsForm
    Private ReadOnly _svc As New SettingsService()
    Private ReadOnly _backup As New BackupService()

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
    End Sub

    Private Sub LibrarySettingsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSettings()
    End Sub

    Private Sub LoadSettings()
        Run(Sub()
                Dim s As LibrarySettings = _svc.GetSettings()
                TxtLibraryName.Text = s.LibraryName
                NudLoanDays.Value = Math.Min(Math.Max(s.LoanDays, 1), 365)
                NudFineRate.Value = Math.Min(Math.Max(s.FinePerDay, 0D), 10000D)
                NudMaxBooks.Value = Math.Min(Math.Max(s.MaxBooksPerStudent, 1), 100)
                If Not CmbCurrency.Items.Contains(s.Currency) Then CmbCurrency.Items.Add(s.Currency)
                CmbCurrency.SelectedItem = s.Currency
            End Sub, LblMessage)
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Dim s As New LibrarySettings With {
            .LibraryName = TxtLibraryName.Text, .LoanDays = CInt(NudLoanDays.Value), .FinePerDay = NudFineRate.Value,
            .MaxBooksPerStudent = CInt(NudMaxBooks.Value), .Currency = Convert.ToString(CmbCurrency.SelectedItem)}
        If Not Confirm("Save these library settings? They apply to all new loans and fines.") Then Return
        If Run(Sub() _svc.Save(s), LblMessage) Then ShowMessage(LblMessage, "Settings saved.", False)
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        LoadSettings()
        ShowMessage(LblMessage, "", False)
    End Sub

    Private Sub BtnBackup_Click(sender As Object, e As EventArgs) Handles BtnBackup.Click
        Using dialog As New SaveFileDialog With {.Filter = "SQL files (*.sql)|*.sql", .FileName = "library_backup_" & Date.Today.ToString("yyyyMMdd") & ".sql"}
            If dialog.ShowDialog(Me) <> DialogResult.OK Then Return
            If Run(Sub() _backup.Backup(dialog.FileName), LblMessage) Then ShowMessage(LblMessage, "Backup saved to " & dialog.FileName, False)
        End Using
    End Sub

    Private Sub BtnRestore_Click(sender As Object, e As EventArgs) Handles BtnRestore.Click
        Using dialog As New OpenFileDialog With {.Filter = "SQL files (*.sql)|*.sql", .Title = "Choose a backup to restore"}
            If dialog.ShowDialog(Me) <> DialogResult.OK Then Return
            If Not Confirm("Restoring replaces the current data with the backup. Continue?") Then Return
            If Run(Sub() _backup.Restore(dialog.FileName), LblMessage) Then ShowMessage(LblMessage, "Database restored.", False)
        End Using
    End Sub
End Class
