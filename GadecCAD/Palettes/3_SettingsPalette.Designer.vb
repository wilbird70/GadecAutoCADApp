﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SettingsPalette
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.LanguageComboBox = New System.Windows.Forms.ComboBox()
        Me.cLayer = New System.Windows.Forms.Label()
        Me.LayersListBox = New System.Windows.Forms.ListBox()
        Me.DisciplinesListBox = New System.Windows.Forms.ListBox()
        Me.ltLayers = New System.Windows.Forms.Label()
        Me.ltLanguage = New System.Windows.Forms.Label()
        Me.ltManual = New System.Windows.Forms.Button()
        Me.LanguagePictureBox = New System.Windows.Forms.PictureBox()
        Me.ltChangelog = New System.Windows.Forms.Button()
        Me.ltReloadMenu = New System.Windows.Forms.Button()
        Me.ltFeedback = New System.Windows.Forms.Button()
        Me.DepartmentsComboBox = New System.Windows.Forms.ComboBox()
        Me.ltPlotSettings = New System.Windows.Forms.Label()
        Me.PreviewCheckBox = New System.Windows.Forms.CheckBox()
        Me.ltPreview = New System.Windows.Forms.Label()
        Me.LinkToPlotFolderLabel = New System.Windows.Forms.Label()
        Me.OpenPdfCheckBox = New System.Windows.Forms.CheckBox()
        Me.ltOpenPdf = New System.Windows.Forms.Label()
        CType(Me.LanguagePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LanguageComboBox
        '
        Me.LanguageComboBox.FormattingEnabled = True
        Me.LanguageComboBox.Location = New System.Drawing.Point(3, 217)
        Me.LanguageComboBox.Name = "LanguageComboBox"
        Me.LanguageComboBox.Size = New System.Drawing.Size(171, 21)
        Me.LanguageComboBox.TabIndex = 14
        '
        'cLayer
        '
        Me.cLayer.AutoSize = True
        Me.cLayer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cLayer.Location = New System.Drawing.Point(3, 144)
        Me.cLayer.Name = "cLayer"
        Me.cLayer.Size = New System.Drawing.Size(28, 13)
        Me.cLayer.TabIndex = 44
        Me.cLayer.Text = "XXX"
        '
        'LayersListBox
        '
        Me.LayersListBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.LayersListBox.FormattingEnabled = True
        Me.LayersListBox.Location = New System.Drawing.Point(92, 20)
        Me.LayersListBox.Name = "LayersListBox"
        Me.LayersListBox.Size = New System.Drawing.Size(82, 121)
        Me.LayersListBox.TabIndex = 43
        '
        'DisciplinesListBox
        '
        Me.DisciplinesListBox.FormattingEnabled = True
        Me.DisciplinesListBox.Location = New System.Drawing.Point(3, 20)
        Me.DisciplinesListBox.Name = "DisciplinesListBox"
        Me.DisciplinesListBox.Size = New System.Drawing.Size(82, 121)
        Me.DisciplinesListBox.TabIndex = 41
        '
        'ltLayers
        '
        Me.ltLayers.AutoSize = True
        Me.ltLayers.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ltLayers.Location = New System.Drawing.Point(3, 4)
        Me.ltLayers.Name = "ltLayers"
        Me.ltLayers.Size = New System.Drawing.Size(31, 13)
        Me.ltLayers.TabIndex = 42
        Me.ltLayers.Text = "XXX"
        '
        'ltLanguage
        '
        Me.ltLanguage.AutoSize = True
        Me.ltLanguage.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ltLanguage.Location = New System.Drawing.Point(3, 201)
        Me.ltLanguage.Name = "ltLanguage"
        Me.ltLanguage.Size = New System.Drawing.Size(28, 13)
        Me.ltLanguage.TabIndex = 45
        Me.ltLanguage.Text = "XXX"
        '
        'ltManual
        '
        Me.ltManual.Image = Global.GadecCAD.My.Resources.Resources.Boek
        Me.ltManual.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ltManual.Location = New System.Drawing.Point(3, 403)
        Me.ltManual.Name = "ltManual"
        Me.ltManual.Size = New System.Drawing.Size(171, 24)
        Me.ltManual.TabIndex = 52
        Me.ltManual.Text = "XXX"
        Me.ltManual.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ltManual.UseVisualStyleBackColor = True
        '
        'LanguagePictureBox
        '
        Me.LanguagePictureBox.Location = New System.Drawing.Point(124, 161)
        Me.LanguagePictureBox.Name = "LanguagePictureBox"
        Me.LanguagePictureBox.Size = New System.Drawing.Size(50, 50)
        Me.LanguagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LanguagePictureBox.TabIndex = 51
        Me.LanguagePictureBox.TabStop = False
        '
        'ltChangelog
        '
        Me.ltChangelog.Image = Global.GadecCAD.My.Resources.Resources.Changelog
        Me.ltChangelog.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ltChangelog.Location = New System.Drawing.Point(3, 373)
        Me.ltChangelog.Name = "ltChangelog"
        Me.ltChangelog.Size = New System.Drawing.Size(171, 24)
        Me.ltChangelog.TabIndex = 46
        Me.ltChangelog.Text = "XXX"
        Me.ltChangelog.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ltChangelog.UseVisualStyleBackColor = True
        '
        'ltReloadMenu
        '
        Me.ltReloadMenu.Image = Global.GadecCAD.My.Resources.Resources.bmpMOD
        Me.ltReloadMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ltReloadMenu.Location = New System.Drawing.Point(3, 343)
        Me.ltReloadMenu.Name = "ltReloadMenu"
        Me.ltReloadMenu.Size = New System.Drawing.Size(171, 24)
        Me.ltReloadMenu.TabIndex = 35
        Me.ltReloadMenu.Text = "XXX"
        Me.ltReloadMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ltReloadMenu.UseVisualStyleBackColor = True
        '
        'ltFeedback
        '
        Me.ltFeedback.Image = Global.GadecCAD.My.Resources.Resources.send_16
        Me.ltFeedback.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ltFeedback.Location = New System.Drawing.Point(3, 433)
        Me.ltFeedback.Name = "ltFeedback"
        Me.ltFeedback.Size = New System.Drawing.Size(171, 24)
        Me.ltFeedback.TabIndex = 21
        Me.ltFeedback.Text = "XXX"
        Me.ltFeedback.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ltFeedback.UseVisualStyleBackColor = True
        '
        'DepartmentsComboBox
        '
        Me.DepartmentsComboBox.FormattingEnabled = True
        Me.DepartmentsComboBox.Location = New System.Drawing.Point(3, 257)
        Me.DepartmentsComboBox.Name = "DepartmentsComboBox"
        Me.DepartmentsComboBox.Size = New System.Drawing.Size(171, 21)
        Me.DepartmentsComboBox.TabIndex = 53
        '
        'ltPlotSettings
        '
        Me.ltPlotSettings.AutoSize = True
        Me.ltPlotSettings.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ltPlotSettings.Location = New System.Drawing.Point(3, 241)
        Me.ltPlotSettings.Name = "ltPlotSettings"
        Me.ltPlotSettings.Size = New System.Drawing.Size(28, 13)
        Me.ltPlotSettings.TabIndex = 54
        Me.ltPlotSettings.Text = "XXX"
        '
        'PreviewCheckBox
        '
        Me.PreviewCheckBox.AutoSize = True
        Me.PreviewCheckBox.Location = New System.Drawing.Point(158, 323)
        Me.PreviewCheckBox.Name = "PreviewCheckBox"
        Me.PreviewCheckBox.Size = New System.Drawing.Size(15, 14)
        Me.PreviewCheckBox.TabIndex = 55
        Me.PreviewCheckBox.UseVisualStyleBackColor = True
        '
        'ltPreview
        '
        Me.ltPreview.AutoSize = True
        Me.ltPreview.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ltPreview.Location = New System.Drawing.Point(3, 323)
        Me.ltPreview.Name = "ltPreview"
        Me.ltPreview.Size = New System.Drawing.Size(28, 13)
        Me.ltPreview.TabIndex = 56
        Me.ltPreview.Text = "XXX"
        '
        'LinkToPlotFolderLabel
        '
        Me.LinkToPlotFolderLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkToPlotFolderLabel.ForeColor = System.Drawing.Color.Blue
        Me.LinkToPlotFolderLabel.Location = New System.Drawing.Point(120, 241)
        Me.LinkToPlotFolderLabel.Name = "LinkToPlotFolderLabel"
        Me.LinkToPlotFolderLabel.Size = New System.Drawing.Size(51, 13)
        Me.LinkToPlotFolderLabel.TabIndex = 57
        Me.LinkToPlotFolderLabel.Text = "Plotfolder"
        Me.LinkToPlotFolderLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'OpenPdfCheckBox
        '
        Me.OpenPdfCheckBox.AutoSize = True
        Me.OpenPdfCheckBox.Location = New System.Drawing.Point(158, 303)
        Me.OpenPdfCheckBox.Name = "OpenPdfCheckBox"
        Me.OpenPdfCheckBox.Size = New System.Drawing.Size(15, 14)
        Me.OpenPdfCheckBox.TabIndex = 58
        Me.OpenPdfCheckBox.UseVisualStyleBackColor = True
        '
        'ltOpenPdf
        '
        Me.ltOpenPdf.AutoSize = True
        Me.ltOpenPdf.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ltOpenPdf.Location = New System.Drawing.Point(3, 303)
        Me.ltOpenPdf.Name = "ltOpenPdf"
        Me.ltOpenPdf.Size = New System.Drawing.Size(28, 13)
        Me.ltOpenPdf.TabIndex = 59
        Me.ltOpenPdf.Text = "XXX"
        '
        'SettingsPalette
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.OpenPdfCheckBox)
        Me.Controls.Add(Me.ltOpenPdf)
        Me.Controls.Add(Me.LinkToPlotFolderLabel)
        Me.Controls.Add(Me.PreviewCheckBox)
        Me.Controls.Add(Me.ltPreview)
        Me.Controls.Add(Me.ltPlotSettings)
        Me.Controls.Add(Me.DepartmentsComboBox)
        Me.Controls.Add(Me.ltManual)
        Me.Controls.Add(Me.LanguagePictureBox)
        Me.Controls.Add(Me.ltChangelog)
        Me.Controls.Add(Me.ltLanguage)
        Me.Controls.Add(Me.cLayer)
        Me.Controls.Add(Me.LayersListBox)
        Me.Controls.Add(Me.DisciplinesListBox)
        Me.Controls.Add(Me.ltLayers)
        Me.Controls.Add(Me.ltReloadMenu)
        Me.Controls.Add(Me.ltFeedback)
        Me.Controls.Add(Me.LanguageComboBox)
        Me.Name = "SettingsPalette"
        Me.Size = New System.Drawing.Size(174, 466)
        CType(Me.LanguagePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LanguageComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ltFeedback As System.Windows.Forms.Button
    Friend WithEvents ltReloadMenu As System.Windows.Forms.Button
    Friend WithEvents cLayer As System.Windows.Forms.Label
    Friend WithEvents LayersListBox As System.Windows.Forms.ListBox
    Friend WithEvents DisciplinesListBox As System.Windows.Forms.ListBox
    Friend WithEvents ltLayers As System.Windows.Forms.Label
    Friend WithEvents ltLanguage As System.Windows.Forms.Label
    Friend WithEvents ltChangelog As System.Windows.Forms.Button
    Friend WithEvents LanguagePictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents ltManual As System.Windows.Forms.Button
    Friend WithEvents DepartmentsComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ltPlotSettings As System.Windows.Forms.Label
    Friend WithEvents PreviewCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ltPreview As System.Windows.Forms.Label
    Friend WithEvents LinkToPlotFolderLabel As Windows.Forms.Label
    Friend WithEvents OpenPdfCheckBox As Windows.Forms.CheckBox
    Friend WithEvents ltOpenPdf As Windows.Forms.Label
End Class
