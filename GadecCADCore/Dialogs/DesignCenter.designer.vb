<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DesignCenter
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
    'Do not modify it using the code editor
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DesignCenter))
        Me.PicturePanel = New System.Windows.Forms.Panel()
        Me.ltCancel = New System.Windows.Forms.Button()
        Me.ltOK = New System.Windows.Forms.Button()
        Me.ScaleComboBox = New System.Windows.Forms.ComboBox()
        Me.ltScale = New System.Windows.Forms.Label()
        Me.ModulesDataGridView = New System.Windows.Forms.DataGridView()
        Me.PagesDataGridView = New System.Windows.Forms.DataGridView()
        Me.ItemsDataGridView = New System.Windows.Forms.DataGridView()
        Me.ltDescription = New System.Windows.Forms.Label()
        CType(Me.ModulesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PagesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PicturePanel
        '
        Me.PicturePanel.AutoScroll = True
        Me.PicturePanel.BackColor = System.Drawing.SystemColors.Window
        Me.PicturePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PicturePanel.Location = New System.Drawing.Point(138, 12)
        Me.PicturePanel.Name = "PicturePanel"
        Me.PicturePanel.Size = New System.Drawing.Size(502, 421)
        Me.PicturePanel.TabIndex = 5
        '
        'ltCancel
        '
        Me.ltCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ltCancel.Location = New System.Drawing.Point(555, 439)
        Me.ltCancel.Name = "ltCancel"
        Me.ltCancel.Size = New System.Drawing.Size(85, 23)
        Me.ltCancel.TabIndex = 6
        Me.ltCancel.Text = "XXX"
        Me.ltCancel.UseVisualStyleBackColor = True
        '
        'ltOK
        '
        Me.ltOK.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.ltOK.Location = New System.Drawing.Point(463, 439)
        Me.ltOK.Name = "ltOK"
        Me.ltOK.Size = New System.Drawing.Size(86, 23)
        Me.ltOK.TabIndex = 7
        Me.ltOK.Text = "XXX"
        Me.ltOK.UseVisualStyleBackColor = True
        '
        'ScaleComboBox
        '
        Me.ScaleComboBox.FormattingEnabled = True
        Me.ScaleComboBox.Location = New System.Drawing.Point(407, 441)
        Me.ScaleComboBox.Name = "ScaleComboBox"
        Me.ScaleComboBox.Size = New System.Drawing.Size(50, 21)
        Me.ScaleComboBox.TabIndex = 12
        '
        'ltScale
        '
        Me.ltScale.Location = New System.Drawing.Point(351, 443)
        Me.ltScale.Name = "ltScale"
        Me.ltScale.Size = New System.Drawing.Size(50, 15)
        Me.ltScale.TabIndex = 13
        Me.ltScale.Text = "XXX"
        Me.ltScale.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ModulesDataGridView
        '
        Me.ModulesDataGridView.AllowUserToAddRows = False
        Me.ModulesDataGridView.AllowUserToDeleteRows = False
        Me.ModulesDataGridView.AllowUserToResizeColumns = False
        Me.ModulesDataGridView.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ModulesDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.ModulesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ModulesDataGridView.ColumnHeadersVisible = False
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial Narrow", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ModulesDataGridView.DefaultCellStyle = DataGridViewCellStyle2
        Me.ModulesDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.ModulesDataGridView.Location = New System.Drawing.Point(12, 12)
        Me.ModulesDataGridView.MultiSelect = False
        Me.ModulesDataGridView.Name = "ModulesDataGridView"
        Me.ModulesDataGridView.RowHeadersVisible = False
        Me.ModulesDataGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White
        Me.ModulesDataGridView.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ModulesDataGridView.RowTemplate.Height = 15
        Me.ModulesDataGridView.RowTemplate.ReadOnly = True
        Me.ModulesDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.ModulesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ModulesDataGridView.ShowCellToolTips = False
        Me.ModulesDataGridView.Size = New System.Drawing.Size(120, 104)
        Me.ModulesDataGridView.TabIndex = 41
        '
        'PagesDataGridView
        '
        Me.PagesDataGridView.AllowUserToAddRows = False
        Me.PagesDataGridView.AllowUserToDeleteRows = False
        Me.PagesDataGridView.AllowUserToResizeColumns = False
        Me.PagesDataGridView.AllowUserToResizeRows = False
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PagesDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.PagesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PagesDataGridView.ColumnHeadersVisible = False
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial Narrow", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.PagesDataGridView.DefaultCellStyle = DataGridViewCellStyle4
        Me.PagesDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.PagesDataGridView.Location = New System.Drawing.Point(12, 122)
        Me.PagesDataGridView.MultiSelect = False
        Me.PagesDataGridView.Name = "PagesDataGridView"
        Me.PagesDataGridView.RowHeadersVisible = False
        Me.PagesDataGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White
        Me.PagesDataGridView.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PagesDataGridView.RowTemplate.Height = 15
        Me.PagesDataGridView.RowTemplate.ReadOnly = True
        Me.PagesDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.PagesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.PagesDataGridView.ShowCellToolTips = False
        Me.PagesDataGridView.Size = New System.Drawing.Size(120, 311)
        Me.PagesDataGridView.TabIndex = 42
        '
        'ItemsDataGridView
        '
        Me.ItemsDataGridView.AllowUserToAddRows = False
        Me.ItemsDataGridView.AllowUserToDeleteRows = False
        Me.ItemsDataGridView.AllowUserToResizeColumns = False
        Me.ItemsDataGridView.AllowUserToResizeRows = False
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ItemsDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.ItemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ItemsDataGridView.ColumnHeadersVisible = False
        Me.ItemsDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.ItemsDataGridView.Location = New System.Drawing.Point(138, 12)
        Me.ItemsDataGridView.Name = "ItemsDataGridView"
        Me.ItemsDataGridView.RowHeadersVisible = False
        Me.ItemsDataGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White
        Me.ItemsDataGridView.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ItemsDataGridView.RowTemplate.Height = 15
        Me.ItemsDataGridView.RowTemplate.ReadOnly = True
        Me.ItemsDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.ItemsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ItemsDataGridView.ShowCellToolTips = False
        Me.ItemsDataGridView.Size = New System.Drawing.Size(502, 421)
        Me.ItemsDataGridView.TabIndex = 45
        '
        'ltDescription
        '
        Me.ltDescription.Location = New System.Drawing.Point(12, 444)
        Me.ltDescription.Name = "ltDescription"
        Me.ltDescription.Size = New System.Drawing.Size(350, 15)
        Me.ltDescription.TabIndex = 46
        Me.ltDescription.Text = "XXX"
        Me.ltDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DesignCenter
        '
        Me.AcceptButton = Me.ltOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ltCancel
        Me.ClientSize = New System.Drawing.Size(652, 474)
        Me.Controls.Add(Me.ltDescription)
        Me.Controls.Add(Me.ItemsDataGridView)
        Me.Controls.Add(Me.PagesDataGridView)
        Me.Controls.Add(Me.ModulesDataGridView)
        Me.Controls.Add(Me.ltScale)
        Me.Controls.Add(Me.ScaleComboBox)
        Me.Controls.Add(Me.ltOK)
        Me.Controls.Add(Me.ltCancel)
        Me.Controls.Add(Me.PicturePanel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "DesignCenter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "XXX"
        CType(Me.ModulesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PagesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PicturePanel As System.Windows.Forms.Panel
    Friend WithEvents ltCancel As System.Windows.Forms.Button
    Friend WithEvents ltOK As System.Windows.Forms.Button
    Friend WithEvents ScaleComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ltScale As System.Windows.Forms.Label
    Friend WithEvents ModulesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents PagesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ItemsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ltDescription As Windows.Forms.Label
End Class
