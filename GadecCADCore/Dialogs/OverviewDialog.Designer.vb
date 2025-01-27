<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class OverviewDialog
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ltCancel = New System.Windows.Forms.Button()
        Me.GroupsListBox = New System.Windows.Forms.ListBox()
        Me.ltOK = New System.Windows.Forms.Button()
        Me.GroupingLabel = New System.Windows.Forms.Label()
        Me.FramesDataGridView = New System.Windows.Forms.DataGridView()
        Me.ltClose = New System.Windows.Forms.Button()
        Me.AssociateFoldersListBox = New System.Windows.Forms.ListBox()
        Me.ViewDesignButton = New System.Windows.Forms.Button()
        Me.ViewProjectButton = New System.Windows.Forms.Button()
        Me.ViewDescriptionButton = New System.Windows.Forms.Button()
        Me.ltSelectAll = New System.Windows.Forms.Button()
        Me.ViewClientButton = New System.Windows.Forms.Button()
        Me.ViewRevisionButton = New System.Windows.Forms.Button()
        Me.DownButton = New System.Windows.Forms.Button()
        Me.UpButton = New System.Windows.Forms.Button()
        CType(Me.FramesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ltCancel
        '
        Me.ltCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ltCancel.Location = New System.Drawing.Point(557, 439)
        Me.ltCancel.Name = "ltCancel"
        Me.ltCancel.Size = New System.Drawing.Size(85, 23)
        Me.ltCancel.TabIndex = 43
        Me.ltCancel.Text = "XXX"
        Me.ltCancel.UseVisualStyleBackColor = True
        '
        'GroupsListBox
        '
        Me.GroupsListBox.FormattingEnabled = True
        Me.GroupsListBox.Location = New System.Drawing.Point(239, 381)
        Me.GroupsListBox.Name = "GroupsListBox"
        Me.GroupsListBox.Size = New System.Drawing.Size(148, 82)
        Me.GroupsListBox.TabIndex = 46
        '
        'ltOK
        '
        Me.ltOK.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.ltOK.Location = New System.Drawing.Point(466, 439)
        Me.ltOK.Name = "ltOK"
        Me.ltOK.Size = New System.Drawing.Size(85, 23)
        Me.ltOK.TabIndex = 49
        Me.ltOK.Text = "XXX"
        Me.ltOK.UseVisualStyleBackColor = True
        '
        'GroupingLabel
        '
        Me.GroupingLabel.Location = New System.Drawing.Point(390, 422)
        Me.GroupingLabel.Name = "GroupingLabel"
        Me.GroupingLabel.Size = New System.Drawing.Size(24, 24)
        Me.GroupingLabel.TabIndex = 51
        Me.GroupingLabel.Text = "0"
        Me.GroupingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FramesDataGridView
        '
        Me.FramesDataGridView.AllowUserToAddRows = False
        Me.FramesDataGridView.AllowUserToDeleteRows = False
        Me.FramesDataGridView.AllowUserToOrderColumns = True
        Me.FramesDataGridView.AllowUserToResizeRows = False
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.FramesDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.FramesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FramesDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.FramesDataGridView.Location = New System.Drawing.Point(10, 12)
        Me.FramesDataGridView.Name = "FramesDataGridView"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.FramesDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.FramesDataGridView.RowHeadersVisible = False
        Me.FramesDataGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White
        Me.FramesDataGridView.RowTemplate.Height = 15
        Me.FramesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.FramesDataGridView.ShowCellToolTips = False
        Me.FramesDataGridView.Size = New System.Drawing.Size(632, 365)
        Me.FramesDataGridView.TabIndex = 52
        '
        'ltClose
        '
        Me.ltClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ltClose.Location = New System.Drawing.Point(557, 439)
        Me.ltClose.Name = "ltClose"
        Me.ltClose.Size = New System.Drawing.Size(85, 23)
        Me.ltClose.TabIndex = 59
        Me.ltClose.Text = "XXX"
        Me.ltClose.UseVisualStyleBackColor = True
        '
        'AssociateFoldersListBox
        '
        Me.AssociateFoldersListBox.BackColor = System.Drawing.SystemColors.Window
        Me.AssociateFoldersListBox.FormattingEnabled = True
        Me.AssociateFoldersListBox.Location = New System.Drawing.Point(10, 381)
        Me.AssociateFoldersListBox.Name = "AssociateFoldersListBox"
        Me.AssociateFoldersListBox.Size = New System.Drawing.Size(226, 82)
        Me.AssociateFoldersListBox.TabIndex = 61
        '
        'ViewDesignButton
        '
        Me.ViewDesignButton.Image = Global.GadecCAD.My.Resources.Resources.Design
        Me.ViewDesignButton.Location = New System.Drawing.Point(594, 380)
        Me.ViewDesignButton.Name = "ViewDesignButton"
        Me.ViewDesignButton.Size = New System.Drawing.Size(24, 24)
        Me.ViewDesignButton.TabIndex = 64
        Me.ViewDesignButton.UseVisualStyleBackColor = True
        '
        'ViewProjectButton
        '
        Me.ViewProjectButton.Image = Global.GadecCAD.My.Resources.Resources.Project
        Me.ViewProjectButton.Location = New System.Drawing.Point(570, 380)
        Me.ViewProjectButton.Name = "ViewProjectButton"
        Me.ViewProjectButton.Size = New System.Drawing.Size(24, 24)
        Me.ViewProjectButton.TabIndex = 63
        Me.ViewProjectButton.UseVisualStyleBackColor = True
        '
        'ViewDescriptionButton
        '
        Me.ViewDescriptionButton.Image = Global.GadecCAD.My.Resources.Resources.Descr
        Me.ViewDescriptionButton.Location = New System.Drawing.Point(522, 380)
        Me.ViewDescriptionButton.Name = "ViewDescriptionButton"
        Me.ViewDescriptionButton.Size = New System.Drawing.Size(24, 24)
        Me.ViewDescriptionButton.TabIndex = 62
        Me.ViewDescriptionButton.UseVisualStyleBackColor = True
        '
        'ltSelectAll
        '
        Me.ltSelectAll.Image = Global.GadecCAD.My.Resources.Resources.SelectAll
        Me.ltSelectAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ltSelectAll.Location = New System.Drawing.Point(390, 380)
        Me.ltSelectAll.Name = "ltSelectAll"
        Me.ltSelectAll.Size = New System.Drawing.Size(132, 24)
        Me.ltSelectAll.TabIndex = 55
        Me.ltSelectAll.Text = "XXX"
        Me.ltSelectAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ltSelectAll.UseVisualStyleBackColor = True
        '
        'ViewClientButton
        '
        Me.ViewClientButton.Image = Global.GadecCAD.My.Resources.Resources.Client
        Me.ViewClientButton.Location = New System.Drawing.Point(546, 380)
        Me.ViewClientButton.Name = "ViewClientButton"
        Me.ViewClientButton.Size = New System.Drawing.Size(24, 24)
        Me.ViewClientButton.TabIndex = 57
        Me.ViewClientButton.UseVisualStyleBackColor = True
        '
        'ViewRevisionButton
        '
        Me.ViewRevisionButton.Image = Global.GadecCAD.My.Resources.Resources.Revision
        Me.ViewRevisionButton.Location = New System.Drawing.Point(618, 380)
        Me.ViewRevisionButton.Name = "ViewRevisionButton"
        Me.ViewRevisionButton.Size = New System.Drawing.Size(24, 24)
        Me.ViewRevisionButton.TabIndex = 56
        Me.ViewRevisionButton.UseVisualStyleBackColor = True
        '
        'DownButton
        '
        Me.DownButton.Image = Global.GadecCAD.My.Resources.Resources.Down
        Me.DownButton.Location = New System.Drawing.Point(389, 440)
        Me.DownButton.Name = "DownButton"
        Me.DownButton.Size = New System.Drawing.Size(24, 24)
        Me.DownButton.TabIndex = 48
        Me.DownButton.UseVisualStyleBackColor = True
        '
        'UpButton
        '
        Me.UpButton.Image = Global.GadecCAD.My.Resources.Resources.Up
        Me.UpButton.Location = New System.Drawing.Point(389, 404)
        Me.UpButton.Name = "UpButton"
        Me.UpButton.Size = New System.Drawing.Size(24, 24)
        Me.UpButton.TabIndex = 47
        Me.UpButton.UseVisualStyleBackColor = True
        '
        'DrawingsDialog
        '
        Me.AcceptButton = Me.ltOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ltClose
        Me.ClientSize = New System.Drawing.Size(652, 474)
        Me.Controls.Add(Me.ViewDesignButton)
        Me.Controls.Add(Me.ViewProjectButton)
        Me.Controls.Add(Me.ViewDescriptionButton)
        Me.Controls.Add(Me.ltSelectAll)
        Me.Controls.Add(Me.AssociateFoldersListBox)
        Me.Controls.Add(Me.ltClose)
        Me.Controls.Add(Me.ViewClientButton)
        Me.Controls.Add(Me.ViewRevisionButton)
        Me.Controls.Add(Me.FramesDataGridView)
        Me.Controls.Add(Me.ltOK)
        Me.Controls.Add(Me.DownButton)
        Me.Controls.Add(Me.UpButton)
        Me.Controls.Add(Me.GroupsListBox)
        Me.Controls.Add(Me.ltCancel)
        Me.Controls.Add(Me.GroupingLabel)
        Me.Name = "DrawingsDialog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "fDrawinglist"
        CType(Me.FramesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ltCancel As System.Windows.Forms.Button
    Friend WithEvents DownButton As System.Windows.Forms.Button
    Friend WithEvents UpButton As System.Windows.Forms.Button
    Friend WithEvents GroupsListBox As System.Windows.Forms.ListBox
    Friend WithEvents ltOK As System.Windows.Forms.Button
    Friend WithEvents GroupingLabel As System.Windows.Forms.Label
    Friend WithEvents FramesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ltSelectAll As System.Windows.Forms.Button
    Friend WithEvents ViewRevisionButton As System.Windows.Forms.Button
    Friend WithEvents ViewClientButton As Windows.Forms.Button
    Friend WithEvents ltClose As Windows.Forms.Button
    Friend WithEvents AssociateFoldersListBox As Windows.Forms.ListBox
    Friend WithEvents ViewDescriptionButton As Windows.Forms.Button
    Friend WithEvents ViewProjectButton As Windows.Forms.Button
    Friend WithEvents ViewDesignButton As Windows.Forms.Button
End Class
