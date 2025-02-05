Imports System.Windows.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DesignCenter
    Inherits Form

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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DesignCenter))
        PicturePanel = New Panel()
        ltCancel = New Button()
        ltOK = New Button()
        ScaleComboBox = New ComboBox()
        ltScale = New Label()
        ModulesDataGridView = New DataGridView()
        PagesDataGridView = New DataGridView()
        ItemsDataGridView = New DataGridView()
        ltDescription = New Label()
        CType(ModulesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(PagesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(ItemsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PicturePanel
        ' 
        PicturePanel.AutoScroll = True
        PicturePanel.BackColor = Drawing.SystemColors.Window
        PicturePanel.BorderStyle = BorderStyle.FixedSingle
        PicturePanel.Location = New System.Drawing.Point(161, 14)
        PicturePanel.Margin = New Padding(4, 3, 4, 3)
        PicturePanel.Name = "PicturePanel"
        PicturePanel.Size = New System.Drawing.Size(585, 485)
        PicturePanel.TabIndex = 5
        ' 
        ' ltCancel
        ' 
        ltCancel.DialogResult = DialogResult.Cancel
        ltCancel.Location = New System.Drawing.Point(648, 507)
        ltCancel.Margin = New Padding(4, 3, 4, 3)
        ltCancel.Name = "ltCancel"
        ltCancel.Size = New System.Drawing.Size(99, 27)
        ltCancel.TabIndex = 6
        ltCancel.Text = "XXX"
        ltCancel.UseVisualStyleBackColor = True
        ' 
        ' ltOK
        ' 
        ltOK.DialogResult = DialogResult.OK
        ltOK.Location = New System.Drawing.Point(540, 507)
        ltOK.Margin = New Padding(4, 3, 4, 3)
        ltOK.Name = "ltOK"
        ltOK.Size = New System.Drawing.Size(100, 27)
        ltOK.TabIndex = 7
        ltOK.Text = "XXX"
        ltOK.UseVisualStyleBackColor = True
        ' 
        ' ScaleComboBox
        ' 
        ScaleComboBox.FormattingEnabled = True
        ScaleComboBox.Location = New System.Drawing.Point(475, 509)
        ScaleComboBox.Margin = New Padding(4, 3, 4, 3)
        ScaleComboBox.Name = "ScaleComboBox"
        ScaleComboBox.Size = New System.Drawing.Size(58, 23)
        ScaleComboBox.TabIndex = 12
        ' 
        ' ltScale
        ' 
        ltScale.Location = New System.Drawing.Point(410, 511)
        ltScale.Margin = New Padding(4, 0, 4, 0)
        ltScale.Name = "ltScale"
        ltScale.Size = New System.Drawing.Size(58, 17)
        ltScale.TabIndex = 13
        ltScale.Text = "XXX"
        ltScale.TextAlign = Drawing.ContentAlignment.MiddleRight
        ' 
        ' ModulesDataGridView
        ' 
        ModulesDataGridView.AllowUserToAddRows = False
        ModulesDataGridView.AllowUserToDeleteRows = False
        ModulesDataGridView.AllowUserToResizeColumns = False
        ModulesDataGridView.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        ModulesDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        ModulesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        ModulesDataGridView.ColumnHeadersVisible = False
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial Narrow", 6.75F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        ModulesDataGridView.DefaultCellStyle = DataGridViewCellStyle2
        ModulesDataGridView.EditMode = DataGridViewEditMode.EditProgrammatically
        ModulesDataGridView.Location = New System.Drawing.Point(14, 14)
        ModulesDataGridView.Margin = New Padding(4, 3, 4, 3)
        ModulesDataGridView.MultiSelect = False
        ModulesDataGridView.Name = "ModulesDataGridView"
        ModulesDataGridView.RowHeadersVisible = False
        ModulesDataGridView.RowTemplate.DefaultCellStyle.BackColor = Drawing.Color.White
        ModulesDataGridView.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, CByte(0))
        ModulesDataGridView.RowTemplate.Height = 15
        ModulesDataGridView.RowTemplate.ReadOnly = True
        ModulesDataGridView.ScrollBars = ScrollBars.Vertical
        ModulesDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        ModulesDataGridView.ShowCellToolTips = False
        ModulesDataGridView.Size = New System.Drawing.Size(140, 120)
        ModulesDataGridView.TabIndex = 41
        ' 
        ' PagesDataGridView
        ' 
        PagesDataGridView.AllowUserToAddRows = False
        PagesDataGridView.AllowUserToDeleteRows = False
        PagesDataGridView.AllowUserToResizeColumns = False
        PagesDataGridView.AllowUserToResizeRows = False
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle3.ForeColor = Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        PagesDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        PagesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        PagesDataGridView.ColumnHeadersVisible = False
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial Narrow", 6.75F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle4.ForeColor = Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.False
        PagesDataGridView.DefaultCellStyle = DataGridViewCellStyle4
        PagesDataGridView.EditMode = DataGridViewEditMode.EditProgrammatically
        PagesDataGridView.Location = New System.Drawing.Point(14, 141)
        PagesDataGridView.Margin = New Padding(4, 3, 4, 3)
        PagesDataGridView.MultiSelect = False
        PagesDataGridView.Name = "PagesDataGridView"
        PagesDataGridView.RowHeadersVisible = False
        PagesDataGridView.RowTemplate.DefaultCellStyle.BackColor = Drawing.Color.White
        PagesDataGridView.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, CByte(0))
        PagesDataGridView.RowTemplate.Height = 15
        PagesDataGridView.RowTemplate.ReadOnly = True
        PagesDataGridView.ScrollBars = ScrollBars.Vertical
        PagesDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        PagesDataGridView.ShowCellToolTips = False
        PagesDataGridView.Size = New System.Drawing.Size(140, 359)
        PagesDataGridView.TabIndex = 42
        ' 
        ' ItemsDataGridView
        ' 
        ItemsDataGridView.AllowUserToAddRows = False
        ItemsDataGridView.AllowUserToDeleteRows = False
        ItemsDataGridView.AllowUserToResizeColumns = False
        ItemsDataGridView.AllowUserToResizeRows = False
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle5.ForeColor = Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.True
        ItemsDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        ItemsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        ItemsDataGridView.ColumnHeadersVisible = False
        ItemsDataGridView.EditMode = DataGridViewEditMode.EditProgrammatically
        ItemsDataGridView.Location = New System.Drawing.Point(161, 14)
        ItemsDataGridView.Margin = New Padding(4, 3, 4, 3)
        ItemsDataGridView.Name = "ItemsDataGridView"
        ItemsDataGridView.RowHeadersVisible = False
        ItemsDataGridView.RowTemplate.DefaultCellStyle.BackColor = Drawing.Color.White
        ItemsDataGridView.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, CByte(0))
        ItemsDataGridView.RowTemplate.Height = 15
        ItemsDataGridView.RowTemplate.ReadOnly = True
        ItemsDataGridView.ScrollBars = ScrollBars.Vertical
        ItemsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        ItemsDataGridView.ShowCellToolTips = False
        ItemsDataGridView.Size = New System.Drawing.Size(586, 486)
        ItemsDataGridView.TabIndex = 45
        ' 
        ' ltDescription
        ' 
        ltDescription.Location = New System.Drawing.Point(14, 512)
        ltDescription.Margin = New Padding(4, 0, 4, 0)
        ltDescription.Name = "ltDescription"
        ltDescription.Size = New System.Drawing.Size(408, 17)
        ltDescription.TabIndex = 46
        ltDescription.Text = "XXX"
        ltDescription.TextAlign = Drawing.ContentAlignment.MiddleLeft
        ' 
        ' DesignCenter
        ' 
        AcceptButton = ltOK
        AutoScaleDimensions = New System.Drawing.SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Drawing.Color.IndianRed
        CancelButton = ltCancel
        ClientSize = New System.Drawing.Size(761, 547)
        Controls.Add(ltDescription)
        Controls.Add(ItemsDataGridView)
        Controls.Add(PagesDataGridView)
        Controls.Add(ModulesDataGridView)
        Controls.Add(ltScale)
        Controls.Add(ScaleComboBox)
        Controls.Add(ltOK)
        Controls.Add(ltCancel)
        Controls.Add(PicturePanel)
        Icon = CType(resources.GetObject("$this.Icon"), Drawing.Icon)
        Margin = New Padding(4, 3, 4, 3)
        Name = "DesignCenter"
        StartPosition = FormStartPosition.CenterParent
        Text = "XXX"
        CType(ModulesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(PagesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(ItemsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)

    End Sub
    Friend WithEvents PicturePanel As Panel
    Friend WithEvents ltCancel As Button
    Friend WithEvents ltOK As Button
    Friend WithEvents ScaleComboBox As ComboBox
    Friend WithEvents ltScale As Label
    Friend WithEvents ModulesDataGridView As DataGridView
    Friend WithEvents PagesDataGridView As DataGridView
    Friend WithEvents ItemsDataGridView As DataGridView
    Friend WithEvents ltDescription As Label
End Class
