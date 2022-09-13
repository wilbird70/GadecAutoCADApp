'Gadec Engineerings Software (c) 2022

''' <summary>
'''  
''' ///NotYetFullyDocumented\\\
''' 
''' Provides methods for...
''' </summary>
Public Class ProgressSmall

    'form

    Sub New(maximumValue As Integer)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.

        ActionLabel.Text = ""
        OutputProgessBar.Value = 0
        OutputProgessBar.Maximum = (maximumValue * 1000) + 2
        Me.Show()
    End Sub

    'subs

    Sub StopShow()
        Me.Hide()
        Me.Dispose()
    End Sub

    Sub SetValue(value As Integer, text As String)
        Dim maximum = CInt(OutputProgessBar.Maximum / 1000)
        Dim current = CInt(OutputProgessBar.Value / 1000)
        Dim newValue = value
        Select Case True
            Case newValue > -1 : If newValue > maximum Then newValue = maximum
            Case current < maximum : newValue = current + 1
            Case Else : newValue = current : Me.Text = "Waarde te hoog" : Beep()
        End Select
        OutputProgessBar.Value = newValue * 1000
        OutputProgessBar.Value += 1
        OutputProgessBar.Value -= 1
        ActionLabel.Text = text
        Windows.Forms.Application.DoEvents()
        Me.Refresh()
    End Sub

End Class