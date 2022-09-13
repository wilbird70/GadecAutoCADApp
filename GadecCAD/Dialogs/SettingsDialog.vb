'Gadec Engineerings Software (c) 2022
Imports System.Windows.Forms

''' <summary>
'''  
''' ///NotYetFullyDocumented\\\
''' 
''' Provides methods for...
''' </summary>
Public Class SettingsDialog
    Private ReadOnly _settings As DataTable
    Private ReadOnly _type As String
    Private _button As Integer = vbCancel

    'form

    Sub New(settings As DataTable, Optional type As String = "")
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.

        Me.Text = registerizer.GetApplicationVersion()
        Me.Controls.ToList.ForEach(Sub(c) If c.Name.StartsWith("lt") Then c.Text = c.Name.Translate)

        _settings = settings
        _type = type
        WireUpDialog()

        Me.ShowDialog()
    End Sub

    'functions

    Function GetButton() As Integer
        Return _button
    End Function

    'buttons

    Private Sub AcceptButton_Click(sender As Object, e As EventArgs) Handles ltOK.Click
        Try
            MakingSettings()
            _button = vbOK
            Me.Hide()
        Catch ex As Exception
            GadecException(ex)
        End Try
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles ltCancel.Click
        Try
            _button = vbCancel
            Me.Hide()
        Catch ex As Exception
            GadecException(ex)
        End Try
    End Sub

    'private subs

    Sub WireUpDialog()
        _settings.AssignPrimaryKey("Page")
        Dim row = 0
        Dim top = 0
        Dim types = _settings.GetUniqueStringsFromColumn("Type")
        For Each type In types
            Dim choices = _settings.Select("Type='{0}'".compose(type), "Page")
            Dim choiceNames = choices.CopyToDataTable.GetStringsFromColumn(Translator.Selected)
            Dim previousChoice = _settings.Rows.Find(registerizer.UserSetting("{0}-SelectedPage".compose(type)))
            If IsNothing(previousChoice) Then previousChoice = choices.FirstOrDefault
            Dim previousString = previousChoice.GetString(Translator.Selected)

            Dim checked = _type = "" Or _type = type
            top = row * 24 + 36
            AddCheckBox(top, "CheckBox_{0}".compose(type), checked)
            AddComboBox(top, "ComboBox_{0}".compose(type), choiceNames, previousString)
            row += 1
        Next
        Me.Height = top + 108
        ltOK.Top = top + 36
        ltCancel.Top = top + 36
    End Sub

    Private Sub AddCheckBox(top As Integer, name As String, checked As Boolean)
        Dim checkBox = New CheckBox With {
                .Name = name,
                .Tag = name,
                .Width = 14,
                .Height = 14,
                .Top = top,
                .Left = 12,
                .Checked = checked
            }
        Me.Controls.Add(checkBox)
    End Sub

    Private Sub AddComboBox(top As Integer, name As String, choices As String(), previous As String)
        Dim comboBox = New ComboBox With {
                .Name = name,
                .Tag = name,
                .Width = 330,
                .Height = 14,
                .Top = top,
                .Left = 36,
                .DropDownStyle = ComboBoxStyle.DropDownList
            }
        comboBox.Items.AddRange(choices)
        comboBox.SelectedItem = previous
        Me.Controls.Add(comboBox)
    End Sub

    Private Sub MakingSettings()
        _settings.AssignPrimaryKey(Translator.Selected)

        Dim types = _settings.GetUniqueStringsFromColumn("Type")
        For Each type In types
            Dim checkBox = DirectCast(Me.Controls("CheckBox_{0}".compose(type)), CheckBox)
            Dim comboBox = DirectCast(Me.Controls("ComboBox_{0}".compose(type)), ComboBox)
            If Not checkBox.Checked Then Continue For

            Dim selected = _settings.Rows.Find(comboBox.SelectedItem)
            If IsNothing(selected) Then Continue For

            registerizer.UserSetting("{0}-SelectedPage".compose(type), selected.GetString("Page"))
            Dim pageData = _settings.GetTable("Blocks").Select("Page='{0}'".compose(selected.GetString("Page"))).CopyToDataTable
            Dim parameterData = DataSetHelper.LoadFromXml("{Support}\SetStandards.xml".compose).GetTable(type, "Name")
            pageData.AssignPrimaryKey("Name")
            pageData.Merge(parameterData)
            registerizer.UserData("{0}-DataTable".compose(type), pageData)
        Next
    End Sub

End Class