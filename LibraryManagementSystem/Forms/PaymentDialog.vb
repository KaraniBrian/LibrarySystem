Option Strict On
Option Explicit On

Imports System.Windows.Forms
Imports LibraryManagement.Core

''' <summary>Payment confirmation dialog: amount and payment method.</summary>
Public Class PaymentDialog
    Public ReadOnly Property Amount As Decimal
        Get
            Return NudAmount.Value
        End Get
    End Property

    Public ReadOnly Property Method As String
        Get
            Return Convert.ToString(CmbMethod.SelectedItem)
        End Get
    End Property

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        CmbMethod.SelectedIndex = 0
    End Sub

    Public Sub New(balance As Decimal, currency As String, studentName As String)
        Me.New()
        LblStudentName.Text = "Student: " & studentName
        LblBalanceInfo.Text = "Outstanding balance: " & Formatting.Money(balance, currency)
        LblAmount.Text = "Amount received (" & currency & "):"
        NudAmount.Maximum = balance
        NudAmount.Value = balance
    End Sub
End Class
