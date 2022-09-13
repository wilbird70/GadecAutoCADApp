'Gadec Engineerings Software (c) 2022
Imports System.Windows.Forms

''' <summary>
'''  
''' ///NotYetFullyDocumented\\\
''' 
''' Provides methods for...
''' </summary>
Public Class ProgressShow
    Private _value As Long = 0
    Private _cancelPressed As Boolean = False

    Private ReadOnly _timer As Timer

    'form

    Sub New(action As String, maximum As Integer, Optional hideCancelButton As Boolean = False)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.

        Me.Text = registerizer.GetApplicationVersion()
        Me.Controls.ToList.ForEach(Sub(c) If c.Name.StartsWith("lt") Then c.Text = c.Name.Translate)

        OutputProgressBar.Maximum = maximum * 1000
        OutputProgressBar.Minimum = 0
        OutputProgressBar.Step = 1000
        OutputProgressBar.Value = 10
        OutputProgressBar.Style = ProgressBarStyle.Continuous
        OutputProgressBar.Value -= 1
        _timer = New Timer With {.Interval = 30000}
        AddHandler _timer.Tick, AddressOf TimerTickEventHandler
        _timer.Start()
        Me.TopMost = True
        Me.Show()
        Me.Refresh()

        ValueLabel.Text = "0"
        ValueLabel.Refresh()
        MaxLabel.Text = maximum.ToString
        MaxLabel.Refresh()
        ltCancel.Visible = Not hideCancelButton

        SetText(action)
    End Sub

    Private Sub Me_Click(sender As Object, e As EventArgs) Handles Me.Click
        Try
            If _ScreenShot Then ImageHelper.GetScreenShot(Me.Location, Me.Size)
        Catch ex As Exception
            GadecException(ex)
        End Try
    End Sub

    Private Sub Me_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        _cancelPressed = True
    End Sub

    'functions

    Function CancelPressed() As Boolean
        Return _cancelPressed
    End Function

    'subs

    Sub PerformStep()
        PerformStep("$$$")
    End Sub

    Sub PerformStep(action As String)
        _timer.Stop()
        _value += 1
        ValueLabel.Text = _value.ToString
        ValueLabel.Refresh()
        OutputProgressBar.PerformStep()
        OutputProgressBar.Value -= 1
        If Not action = "$$$" Then SetText(action)
        Windows.Forms.Application.DoEvents()
        _timer.Start()
    End Sub

    Sub SetText(action As String)
        ActionLabel.Text = action
        ActionLabel.Refresh()
    End Sub

    Sub SetMaximum(maximum As Integer)
        If OutputProgressBar.Value > maximum * 1000 Then OutputProgressBar.Value = maximum * 1000
        OutputProgressBar.Value = 1
        OutputProgressBar.Maximum = 1000 * {maximum, 1}.Max
        OutputProgressBar.Value -= 1
        MaxLabel.Text = maximum.ToString
        MaxLabel.Refresh()
    End Sub

    'buttons

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles ltCancel.Click
        _cancelPressed = True
    End Sub

    'eventhandlers

    Private Sub TimerTickEventHandler(sender As Object, e As EventArgs)
        Try
            Me.Dispose()
        Catch ex As Exception
            GadecException(ex)
        End Try
    End Sub

End Class