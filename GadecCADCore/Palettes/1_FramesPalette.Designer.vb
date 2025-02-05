Imports GadecCADCore.Extensions
Imports System.Data
Imports System.Windows.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FramesPalette
    Inherits UserControl

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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        FramesDataGridView = New DataGridView()
        ltFrames = New Label()
        GroupsListBox = New ListBox()
        DownButton = New Button()
        UpButton = New Button()
        OverviewButton = New Button()
        ZoomExtentsButton = New Button()
        OpenFolderButton = New Button()
        ltSelectAll = New Button()
        GroupingLabel = New Label()
        ltThisFileOnly = New CheckBox()
        FilterListBox = New ListBox()
        FilterButton = New Button()
        CType(FramesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' FramesDataGridView
        ' 
        FramesDataGridView.AllowUserToAddRows = False
        FramesDataGridView.AllowUserToDeleteRows = False
        FramesDataGridView.AllowUserToResizeColumns = False
        FramesDataGridView.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        FramesDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        FramesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        FramesDataGridView.EditMode = DataGridViewEditMode.EditProgrammatically
        FramesDataGridView.Location = New System.Drawing.Point(4, 31)
        FramesDataGridView.Margin = New Padding(4, 3, 4, 3)
        FramesDataGridView.Name = "FramesDataGridView"
        FramesDataGridView.RowHeadersVisible = False
        FramesDataGridView.RowTemplate.DefaultCellStyle.BackColor = Drawing.Color.White
        FramesDataGridView.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, CByte(0))
        FramesDataGridView.RowTemplate.Height = 15
        FramesDataGridView.RowTemplate.ReadOnly = True
        FramesDataGridView.ScrollBars = ScrollBars.Vertical
        FramesDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        FramesDataGridView.ShowCellToolTips = False
        FramesDataGridView.Size = New System.Drawing.Size(198, 365)
        FramesDataGridView.TabIndex = 53
        ' 
        ' ltFrames
        ' 
        ltFrames.AutoSize = True
        ltFrames.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, CByte(0))
        ltFrames.Location = New System.Drawing.Point(4, 13)
        ltFrames.Margin = New Padding(4, 0, 4, 0)
        ltFrames.Name = "ltFrames"
        ltFrames.Size = New System.Drawing.Size(31, 13)
        ltFrames.TabIndex = 55
        ltFrames.Text = "XXX"
        ' 
        ' GroupsListBox
        ' 
        GroupsListBox.FormattingEnabled = True
        GroupsListBox.ItemHeight = 15
        GroupsListBox.Location = New System.Drawing.Point(4, 445)
        GroupsListBox.Margin = New Padding(4, 3, 4, 3)
        GroupsListBox.Name = "GroupsListBox"
        GroupsListBox.Size = New System.Drawing.Size(170, 94)
        GroupsListBox.TabIndex = 64
        ' 
        ' DownButton
        ' 
        DownButton.Location = New System.Drawing.Point(175, 486)
        DownButton.Margin = New Padding(4, 3, 4, 3)
        DownButton.Name = "DownButton"
        DownButton.Size = New System.Drawing.Size(28, 28)
        DownButton.TabIndex = 66
        DownButton.UseVisualStyleBackColor = True
        ' 
        ' UpButton
        ' 
        UpButton.Location = New System.Drawing.Point(175, 444)
        UpButton.Margin = New Padding(4, 3, 4, 3)
        UpButton.Name = "UpButton"
        UpButton.Size = New System.Drawing.Size(28, 28)
        UpButton.TabIndex = 65
        UpButton.UseVisualStyleBackColor = True
        ' 
        ' OverviewButton
        ' 
        OverviewButton.Location = New System.Drawing.Point(147, 2)
        OverviewButton.Margin = New Padding(4, 3, 4, 3)
        OverviewButton.Name = "OverviewButton"
        OverviewButton.Size = New System.Drawing.Size(28, 28)
        OverviewButton.TabIndex = 63
        OverviewButton.UseVisualStyleBackColor = True
        ' 
        ' ZoomExtentsButton
        ' 
        ZoomExtentsButton.Location = New System.Drawing.Point(175, 2)
        ZoomExtentsButton.Margin = New Padding(4, 3, 4, 3)
        ZoomExtentsButton.Name = "ZoomExtentsButton"
        ZoomExtentsButton.Size = New System.Drawing.Size(28, 28)
        ZoomExtentsButton.TabIndex = 60
        ZoomExtentsButton.TextImageRelation = TextImageRelation.ImageBeforeText
        ZoomExtentsButton.UseVisualStyleBackColor = True
        ' 
        ' OpenFolderButton
        ' 
        OpenFolderButton.Location = New System.Drawing.Point(175, 513)
        OpenFolderButton.Margin = New Padding(4, 3, 4, 3)
        OpenFolderButton.Name = "OpenFolderButton"
        OpenFolderButton.Size = New System.Drawing.Size(28, 28)
        OpenFolderButton.TabIndex = 59
        OpenFolderButton.TextImageRelation = TextImageRelation.ImageBeforeText
        OpenFolderButton.UseVisualStyleBackColor = True
        ' 
        ' ltSelectAll
        ' 
        ltSelectAll.ImageAlign = Drawing.ContentAlignment.MiddleLeft
        ltSelectAll.Location = New System.Drawing.Point(2, 397)
        ltSelectAll.Margin = New Padding(4, 3, 4, 3)
        ltSelectAll.Name = "ltSelectAll"
        ltSelectAll.Size = New System.Drawing.Size(173, 28)
        ltSelectAll.TabIndex = 54
        ltSelectAll.Text = "XXX"
        ltSelectAll.TextImageRelation = TextImageRelation.ImageBeforeText
        ltSelectAll.UseVisualStyleBackColor = True
        ' 
        ' GroupingLabel
        ' 
        GroupingLabel.Location = New System.Drawing.Point(175, 465)
        GroupingLabel.Margin = New Padding(4, 0, 4, 0)
        GroupingLabel.Name = "GroupingLabel"
        GroupingLabel.Size = New System.Drawing.Size(28, 28)
        GroupingLabel.TabIndex = 67
        GroupingLabel.Text = "0"
        GroupingLabel.TextAlign = Drawing.ContentAlignment.MiddleCenter
        ' 
        ' ltThisFileOnly
        ' 
        ltThisFileOnly.AutoSize = True
        ltThisFileOnly.Location = New System.Drawing.Point(4, 425)
        ltThisFileOnly.Margin = New Padding(4, 3, 4, 3)
        ltThisFileOnly.Name = "ltThisFileOnly"
        ltThisFileOnly.Size = New System.Drawing.Size(47, 19)
        ltThisFileOnly.TabIndex = 68
        ltThisFileOnly.Text = "XXX"
        ltThisFileOnly.UseVisualStyleBackColor = True
        ' 
        ' FilterListBox
        ' 
        FilterListBox.FormattingEnabled = True
        FilterListBox.ItemHeight = 15
        FilterListBox.Location = New System.Drawing.Point(4, 445)
        FilterListBox.Margin = New Padding(4, 3, 4, 3)
        FilterListBox.Name = "FilterListBox"
        FilterListBox.SelectionMode = SelectionMode.MultiExtended
        FilterListBox.Size = New System.Drawing.Size(170, 94)
        FilterListBox.TabIndex = 69
        ' 
        ' FilterButton
        ' 
        FilterButton.Location = New System.Drawing.Point(175, 397)
        FilterButton.Margin = New Padding(4, 3, 4, 3)
        FilterButton.Name = "FilterButton"
        FilterButton.Size = New System.Drawing.Size(28, 28)
        FilterButton.TabIndex = 70
        FilterButton.UseVisualStyleBackColor = True
        ' 
        ' FramesPalette
        ' 
        AutoScaleDimensions = New System.Drawing.SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(FilterButton)
        Controls.Add(ltSelectAll)
        Controls.Add(DownButton)
        Controls.Add(UpButton)
        Controls.Add(OverviewButton)
        Controls.Add(FramesDataGridView)
        Controls.Add(ZoomExtentsButton)
        Controls.Add(OpenFolderButton)
        Controls.Add(ltFrames)
        Controls.Add(GroupingLabel)
        Controls.Add(FilterListBox)
        Controls.Add(GroupsListBox)
        Controls.Add(ltThisFileOnly)
        Margin = New Padding(4, 3, 4, 3)
        Name = "FramesPalette"
        Size = New System.Drawing.Size(203, 543)
        CType(FramesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents OverviewButton As Button
    Friend WithEvents FramesDataGridView As DataGridView
    Friend WithEvents ZoomExtentsButton As Button
    Friend WithEvents OpenFolderButton As Button
    Friend WithEvents ltSelectAll As Button
    Friend WithEvents ltFrames As Label
    Friend WithEvents GroupsListBox As ListBox
    Friend WithEvents UpButton As Button
    Friend WithEvents DownButton As Button
    Friend WithEvents GroupingLabel As Label
    Friend WithEvents ltThisFileOnly As CheckBox
    Friend WithEvents FilterListBox As ListBox
    Friend WithEvents FilterButton As Button
End Class
