Option Strict On
Option Explicit On

Imports System.Drawing
Imports System.Windows.Forms
Imports LibraryManagement.Core

''' <summary>
''' Common base for pages and dialogs: a title, a vertical stack of rows (Root),
''' a message label and safe error handling.
''' </summary>
Public MustInherit Class BaseForm
    Inherits Form

    Protected ReadOnly Root As New TableLayoutPanel()
    Protected ReadOnly lblTitle As Label
    Protected ReadOnly lblMessage As Label = NewMessageLabel("lblMessage")

    Protected Sub New(title As String, titleSize As Single)
        Text = title
        Font = Theme.BodyFont
        BackColor = Theme.PageBack
        AutoScaleMode = AutoScaleMode.Dpi
        Root.Name = "tblRoot"
        Root.ColumnCount = 1
        Root.RowCount = 0
        Root.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100.0F))
        lblTitle = NewTitle("lblTitle", title, titleSize)
        Controls.Add(Root)
        AddAutoRow(lblTitle)
    End Sub

    ''' <summary>Adds a row that is as tall as its content.</summary>
    Protected Sub AddAutoRow(c As Control)
        AddRow(c, New RowStyle(SizeType.AutoSize))
    End Sub

    ''' <summary>Adds the row that takes all remaining height (use once per page, for the grid).</summary>
    Protected Sub AddFillRow(c As Control)
        AddRow(c, New RowStyle(SizeType.Percent, 100.0F))
    End Sub

    Private Sub AddRow(c As Control, style As RowStyle)
        Dim index As Integer = Root.RowCount
        Root.RowCount = index + 1
        Root.RowStyles.Add(style)
        c.Dock = DockStyle.Fill
        Root.Controls.Add(c, 0, index)
    End Sub

    Protected Sub ShowMsg(text As String, isError As Boolean)
        ShowMessage(lblMessage, text, isError)
    End Sub

    ''' <summary>Runs an action; on failure shows the message and returns False.</summary>
    Protected Function Run(action As Action) As Boolean
        Dim problem As String = TryRun(action)
        If problem = "" Then Return True
        ShowMsg(problem, True)
        Return False
    End Function
End Class

''' <summary>A page embedded in the dashboard's content area.</summary>
Public MustInherit Class PageForm
    Inherits BaseForm

    Protected Sub New(title As String)
        MyBase.New(title, 20.0F)
        FormBorderStyle = FormBorderStyle.None
        TopLevel = False
        Dock = DockStyle.Fill
        Padding = New Padding(24, 20, 24, 16)
        Root.Dock = DockStyle.Fill
    End Sub

    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)
        LoadData()
    End Sub

    ''' <summary>Called when the page first appears; override to load data.</summary>
    Protected Overridable Sub LoadData()
    End Sub
End Class

''' <summary>A small modal window that sizes itself to its content.</summary>
Public MustInherit Class DialogForm
    Inherits BaseForm

    Protected Sub New(title As String, Optional minWidth As Integer = 480)
        MyBase.New(title, 16.0F)
        FormBorderStyle = FormBorderStyle.FixedDialog
        StartPosition = FormStartPosition.CenterParent
        MaximizeBox = False
        MinimizeBox = False
        ShowInTaskbar = False
        AutoSize = True
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        Padding = New Padding(24)
        Root.AutoSize = True
        Root.AutoSizeMode = AutoSizeMode.GrowAndShrink
        Root.Dock = DockStyle.None
        Root.Location = Point.Empty
        Root.MinimumSize = New Size(minWidth, 0)
        lblMessage.MaximumSize = New Size(minWidth, 0)
    End Sub
End Class

''' <summary>
''' Dashboard frame: green sidebar with navigation on the left and a content area on the right.
''' Librarian and student dashboards inherit from this.
''' </summary>
Public MustInherit Class ShellForm
    Inherits Form

    Private ReadOnly _sidebar As New TableLayoutPanel()
    Private ReadOnly _nav As New FlowLayoutPanel()
    Private ReadOnly _bottom As New FlowLayoutPanel()
    Private ReadOnly _buttons As New List(Of Button)()
    Protected ReadOnly pnlContent As New Panel()
    Private _current As Form
    Private _firstButton As Button
    Private _firstFactory As Func(Of Form)

    ''' <summary>True when the user chose Logout (so the login screen is shown again).</summary>
    Public Property LoggedOut As Boolean

    Protected Sub New(appTitle As String)
        Text = "Library Management System - " & appTitle
        Size = New Size(1200, 750)
        MinimumSize = New Size(1000, 650)
        StartPosition = FormStartPosition.CenterScreen
        BackColor = Theme.PageBack
        Font = Theme.BodyFont
        AutoScaleMode = AutoScaleMode.Dpi

        pnlContent.Name = "pnlContent"
        pnlContent.Dock = DockStyle.Fill
        pnlContent.BackColor = Theme.PageBack

        _sidebar.Name = "pnlSidebar"
        _sidebar.Dock = DockStyle.Left
        _sidebar.Width = 230
        _sidebar.BackColor = Color.DarkGreen
        _sidebar.ColumnCount = 1
        _sidebar.RowCount = 3
        _sidebar.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100.0F))
        _sidebar.RowStyles.Add(New RowStyle(SizeType.Absolute, 80.0F))
        _sidebar.RowStyles.Add(New RowStyle(SizeType.Percent, 100.0F))
        _sidebar.RowStyles.Add(New RowStyle(SizeType.AutoSize))

        Dim lblAppTitle As New Label With {.Name = "lblAppTitle", .Text = appTitle, .ForeColor = Color.White,
                                           .Font = New Font("Segoe UI", 16.0F, FontStyle.Bold), .Dock = DockStyle.Fill,
                                           .TextAlign = ContentAlignment.MiddleCenter}
        ConfigureFlow(_nav)
        ConfigureFlow(_bottom)
        _bottom.AutoSize = True
        _sidebar.Controls.Add(lblAppTitle, 0, 0)
        _sidebar.Controls.Add(_nav, 0, 1)
        _sidebar.Controls.Add(_bottom, 0, 2)

        Controls.Add(pnlContent)
        Controls.Add(_sidebar)
    End Sub

    Private Shared Sub ConfigureFlow(flow As FlowLayoutPanel)
        flow.Dock = DockStyle.Fill
        flow.FlowDirection = FlowDirection.TopDown
        flow.WrapContents = False
        flow.Margin = New Padding(0)
        flow.BackColor = Color.DarkGreen
    End Sub

    Private Function CreateSidebarButton(name As String, text As String, inBottomGroup As Boolean) As Button
        Dim btn As New Button With {.Name = name, .Text = text, .Size = New Size(230, 46), .Margin = New Padding(0),
                                    .FlatStyle = FlatStyle.Flat, .ForeColor = Color.White, .BackColor = Color.DarkGreen,
                                    .TextAlign = ContentAlignment.MiddleLeft, .Padding = New Padding(16, 0, 0, 0),
                                    .Cursor = Cursors.Hand, .UseVisualStyleBackColor = False}
        btn.FlatAppearance.BorderSize = 0
        btn.FlatAppearance.MouseOverBackColor = Theme.PrimaryHover
        If inBottomGroup Then _bottom.Controls.Add(btn) Else _nav.Controls.Add(btn)
        _buttons.Add(btn)
        Return btn
    End Function

    ''' <summary>Adds a sidebar button that opens a page. The first one added is shown at start-up.</summary>
    Protected Sub AddNav(name As String, text As String, factory As Func(Of Form), Optional inBottomGroup As Boolean = False)
        Dim btn As Button = CreateSidebarButton(name, text, inBottomGroup)
        AddHandler btn.Click, Sub(sender As Object, e As EventArgs) ShowPage(btn, factory)
        If _firstButton Is Nothing Then
            _firstButton = btn
            _firstFactory = factory
        End If
    End Sub

    ''' <summary>Adds a sidebar button that runs an action (for example Logout).</summary>
    Protected Sub AddAction(name As String, text As String, action As Action, Optional inBottomGroup As Boolean = False)
        Dim btn As Button = CreateSidebarButton(name, text, inBottomGroup)
        AddHandler btn.Click, Sub(sender As Object, e As EventArgs) action()
    End Sub

    Private Sub ShowPage(active As Button, factory As Func(Of Form))
        Try
            Dim page As Form = factory()
            pnlContent.Controls.Add(page)
            page.Show()
            page.BringToFront()
            If _current IsNot Nothing Then
                pnlContent.Controls.Remove(_current)
                _current.Dispose()
            End If
            _current = page
            For Each btn As Button In _buttons
                btn.BackColor = If(btn Is active, Color.FromArgb(56, 142, 60), Color.DarkGreen)
            Next
        Catch ex As Exception
            ErrorLog.Write(ex)
            ShowError("The page could not be opened. Details were saved to the log file.")
        End Try
    End Sub

    Protected Overrides Sub OnShown(e As EventArgs)
        MyBase.OnShown(e)
        If _firstButton IsNot Nothing Then ShowPage(_firstButton, _firstFactory)
    End Sub

    Protected Sub ShowChangePassword()
        Using dialog As New ChangePasswordForm()
            dialog.ShowDialog(Me)
        End Using
    End Sub

    Protected Sub ConfirmLogout()
        If Confirm("Do you want to log out?") Then
            LoggedOut = True
            AppSession.Clear()
            Close()
        End If
    End Sub
End Class
