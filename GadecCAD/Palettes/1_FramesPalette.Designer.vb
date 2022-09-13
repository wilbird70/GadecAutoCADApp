﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FramesPalette
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
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.FramesDataGridView = New System.Windows.Forms.DataGridView()
        Me.ltFrames = New System.Windows.Forms.Label()
        Me.GroupsListBox = New System.Windows.Forms.ListBox()
        Me.DownButton = New System.Windows.Forms.Button()
        Me.UpButton = New System.Windows.Forms.Button()
        Me.OverviewButton = New System.Windows.Forms.Button()
        Me.ZoomExtentsButton = New System.Windows.Forms.Button()
        Me.OpenFolderButton = New System.Windows.Forms.Button()
        Me.ltSelectAll = New System.Windows.Forms.Button()
        Me.GroupingLabel = New System.Windows.Forms.Label()
        Me.ltThisFileOnly = New System.Windows.Forms.CheckBox()
        Me.FilterListBox = New System.Windows.Forms.ListBox()
        Me.FilterButton = New System.Windows.Forms.Button()
        CType(Me.FramesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FramesDataGridView
        '
        Me.FramesDataGridView.AllowUserToAddRows = False
        Me.FramesDataGridView.AllowUserToDeleteRows = False
        Me.FramesDataGridView.AllowUserToResizeColumns = False
        Me.FramesDataGridView.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.FramesDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.FramesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FramesDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.FramesDataGridView.Location = New System.Drawing.Point(3, 27)
        Me.FramesDataGridView.Name = "FramesDataGridView"
        Me.FramesDataGridView.RowHeadersVisible = False
        Me.FramesDataGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White
        Me.FramesDataGridView.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FramesDataGridView.RowTemplate.Height = 15
        Me.FramesDataGridView.RowTemplate.ReadOnly = True
        Me.FramesDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.FramesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.FramesDataGridView.ShowCellToolTips = False
        Me.FramesDataGridView.Size = New System.Drawing.Size(170, 316)
        Me.FramesDataGridView.TabIndex = 53
        '
        'ltFrames
        '
        Me.ltFrames.AutoSize = True
        Me.ltFrames.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ltFrames.Location = New System.Drawing.Point(3, 11)
        Me.ltFrames.Name = "ltFrames"
        Me.ltFrames.Size = New System.Drawing.Size(31, 13)
        Me.ltFrames.TabIndex = 55
        Me.ltFrames.Text = "XXX"
        '
        'GroupsListBox
        '
        Me.GroupsListBox.FormattingEnabled = True
        Me.GroupsListBox.Location = New System.Drawing.Point(3, 386)
        Me.GroupsListBox.Name = "GroupsListBox"
        Me.GroupsListBox.Size = New System.Drawing.Size(146, 82)
        Me.GroupsListBox.TabIndex = 64
        '
        'DownButton
        '
        Me.DownButton.Image = Global.GadecCAD.My.Resources.Resources.Down
        Me.DownButton.Location = New System.Drawing.Point(150, 421)
        Me.DownButton.Name = "DownButton"
        Me.DownButton.Size = New System.Drawing.Size(24, 24)
        Me.DownButton.TabIndex = 66
        Me.DownButton.UseVisualStyleBackColor = True
        '
        'UpButton
        '
        Me.UpButton.Image = Global.GadecCAD.My.Resources.Resources.Up
        Me.UpButton.Location = New System.Drawing.Point(150, 385)
        Me.UpButton.Name = "UpButton"
        Me.UpButton.Size = New System.Drawing.Size(24, 24)
        Me.UpButton.TabIndex = 65
        Me.UpButton.UseVisualStyleBackColor = True
        '
        'OverviewButton
        '
        Me.OverviewButton.Image = Global.GadecCAD.My.Resources.Resources.Wisselen16
        Me.OverviewButton.Location = New System.Drawing.Point(126, 2)
        Me.OverviewButton.Name = "OverviewButton"
        Me.OverviewButton.Size = New System.Drawing.Size(24, 24)
        Me.OverviewButton.TabIndex = 63
        Me.OverviewButton.UseVisualStyleBackColor = True
        '
        'ZoomExtentsButton
        '
        Me.ZoomExtentsButton.Image = Global.GadecCAD.My.Resources.Resources.bmpZE
        Me.ZoomExtentsButton.Location = New System.Drawing.Point(150, 2)
        Me.ZoomExtentsButton.Name = "ZoomExtentsButton"
        Me.ZoomExtentsButton.Size = New System.Drawing.Size(24, 24)
        Me.ZoomExtentsButton.TabIndex = 60
        Me.ZoomExtentsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ZoomExtentsButton.UseVisualStyleBackColor = True
        '
        'OpenFolderButton
        '
        Me.OpenFolderButton.Image = Global.GadecCAD.My.Resources.Resources.Folder
        Me.OpenFolderButton.Location = New System.Drawing.Point(150, 445)
        Me.OpenFolderButton.Name = "OpenFolderButton"
        Me.OpenFolderButton.Size = New System.Drawing.Size(24, 24)
        Me.OpenFolderButton.TabIndex = 59
        Me.OpenFolderButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.OpenFolderButton.UseVisualStyleBackColor = True
        '
        'ltSelectAll
        '
        Me.ltSelectAll.Image = Global.GadecCAD.My.Resources.Resources.SelectAll
        Me.ltSelectAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ltSelectAll.Location = New System.Drawing.Point(2, 344)
        Me.ltSelectAll.Name = "ltSelectAll"
        Me.ltSelectAll.Size = New System.Drawing.Size(148, 24)
        Me.ltSelectAll.TabIndex = 54
        Me.ltSelectAll.Text = "XXX"
        Me.ltSelectAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ltSelectAll.UseVisualStyleBackColor = True
        '
        'GroupingLabel
        '
        Me.GroupingLabel.Location = New System.Drawing.Point(150, 403)
        Me.GroupingLabel.Name = "GroupingLabel"
        Me.GroupingLabel.Size = New System.Drawing.Size(24, 24)
        Me.GroupingLabel.TabIndex = 67
        Me.GroupingLabel.Text = "0"
        Me.GroupingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ltThisFileOnly
        '
        Me.ltThisFileOnly.AutoSize = True
        Me.ltThisFileOnly.Location = New System.Drawing.Point(3, 368)
        Me.ltThisFileOnly.Name = "ltThisFileOnly"
        Me.ltThisFileOnly.Size = New System.Drawing.Size(47, 17)
        Me.ltThisFileOnly.TabIndex = 68
        Me.ltThisFileOnly.Text = "XXX"
        Me.ltThisFileOnly.UseVisualStyleBackColor = True
        '
        'FilterListBox
        '
        Me.FilterListBox.FormattingEnabled = True
        Me.FilterListBox.Location = New System.Drawing.Point(3, 386)
        Me.FilterListBox.Name = "FilterListBox"
        Me.FilterListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.FilterListBox.Size = New System.Drawing.Size(146, 82)
        Me.FilterListBox.TabIndex = 69
        '
        'FilterButton
        '
        Me.FilterButton.Image = Global.GadecCAD.My.Resources.Resources.Filter
        Me.FilterButton.Location = New System.Drawing.Point(150, 344)
        Me.FilterButton.Name = "FilterButton"
        Me.FilterButton.Size = New System.Drawing.Size(24, 24)
        Me.FilterButton.TabIndex = 70
        Me.FilterButton.UseVisualStyleBackColor = True
        '
        'FramesPalette
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.FilterButton)
        Me.Controls.Add(Me.ltSelectAll)
        Me.Controls.Add(Me.DownButton)
        Me.Controls.Add(Me.UpButton)
        Me.Controls.Add(Me.OverviewButton)
        Me.Controls.Add(Me.FramesDataGridView)
        Me.Controls.Add(Me.ZoomExtentsButton)
        Me.Controls.Add(Me.OpenFolderButton)
        Me.Controls.Add(Me.ltFrames)
        Me.Controls.Add(Me.GroupingLabel)
        Me.Controls.Add(Me.FilterListBox)
        Me.Controls.Add(Me.GroupsListBox)
        Me.Controls.Add(Me.ltThisFileOnly)
        Me.Name = "FramesPalette"
        Me.Size = New System.Drawing.Size(174, 471)
        CType(Me.FramesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OverviewButton As Windows.Forms.Button
    Friend WithEvents FramesDataGridView As Windows.Forms.DataGridView
    Friend WithEvents ZoomExtentsButton As Windows.Forms.Button
    Friend WithEvents OpenFolderButton As Windows.Forms.Button
    Friend WithEvents ltSelectAll As Windows.Forms.Button
    Friend WithEvents ltFrames As Windows.Forms.Label
    Friend WithEvents GroupsListBox As Windows.Forms.ListBox
    Friend WithEvents UpButton As Windows.Forms.Button
    Friend WithEvents DownButton As Windows.Forms.Button
    Friend WithEvents GroupingLabel As Windows.Forms.Label
    Friend WithEvents ltThisFileOnly As Windows.Forms.CheckBox
    Friend WithEvents FilterListBox As Windows.Forms.ListBox
    Friend WithEvents FilterButton As Windows.Forms.Button
End Class
