'Gadec Engineerings Software (c) 2022
Imports System.Windows.Forms

''' <summary>
'''  
''' ///NotYetFullyDocumented\\\
''' 
''' Provides methods for...
''' </summary>
Public Class RevisionDialog
    Private _revisionTexts As Dictionary(Of String, String)

    'form

    Sub New(drawnIni As String, checkIni As String)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.

        Me.Text = registerizer.GetApplicationVersion()
        Me.Controls.ToList.ForEach(Sub(c) If c.Name.StartsWith("lt") Then c.Text = c.Name.Translate)

        InputDateTimePicker.Value = Now
        DescriptionComboBox.Items.AddRange("REVTEXTS".Translate.Cut)
        DrawnTextBox.Text = drawnIni
        CheckTextBox.Text = checkIni
        DescriptionComboBox.Select()
        Me.ShowDialog()
    End Sub

    Private Sub Me_Click(sender As Object, e As EventArgs) Handles Me.Click
        Try
            If _screenShot Then ImageHelper.GetScreenShot(Me.Location, Me.Size)
        Catch ex As Exception
            GadecException(ex)
        End Try
    End Sub

    'functions

    Function GetRevisionTexts() As Dictionary(Of String, String)
        Return _revisionTexts
    End Function

    'buttons

    Private Sub AcceptButton_Click(sender As Object, e As EventArgs) Handles ltOK.Click
        Try
            _revisionTexts = New Dictionary(Of String, String) From {
                {"Date", InputDateTimePicker.Value.ToString("dd-MM-yyyy")},
                {"Descr", DescriptionComboBox.Text},
                {"Drawn", DrawnTextBox.Text},
                {"Check", CheckTextBox.Text},
                {"Char", ""},
                {"KOPREV", ""}
            }
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