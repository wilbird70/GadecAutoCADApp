'Gadec Engineerings Software (c) 2022

''' <summary>
'''  
''' ///NotYetFullyDocumented\\\
''' 
''' Provides methods for...
''' </summary>
Public Class InputBoxDialog
    Public Property InputText As String = ""

    'form

    Sub New(prompt As String, defaultResponse As String)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.

        Me.Text = Registerizer.GetApplicationVersion()
        Translator.TranslateControles(Me)

        lDescr.Text = prompt
        InputTextBox.Text = defaultResponse
        Me.ShowDialog()
    End Sub

    Private Sub Me_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Try
            InputTextBox.SelectionStart = 0
            InputTextBox.SelectionLength = 100
            InputTextBox.Focus()
        Catch ex As Exception
            GadecException(ex)
        End Try
    End Sub

    Private Sub Me_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        Try
            If Me.Height < 144 Then Me.Height = 144
            If Me.Width < 300 Then Me.Width = 300
            ltOK.Left = Me.Width - 205
            ltCancel.Left = Me.Width - 113
            InputTextBox.Width = Me.Width - 40
        Catch ex As Exception
            GadecException(ex)
        End Try
    End Sub

    'buttons

    Private Sub AcceptButton_Click(sender As Object, e As EventArgs) Handles ltOK.Click
        Try
            InputText = InputTextBox.Text
            Me.Hide()
        Catch ex As Exception
            GadecException(ex)
        End Try
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles ltCancel.Click
        Try
            Me.Hide()
        Catch ex As Exception
            GadecException(ex)
        End Try
    End Sub

End Class