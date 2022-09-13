<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PictureBalloon
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PictureBalloon))
        Me.PreviewPictureBox = New System.Windows.Forms.PictureBox()
        Me.BackPictureBox = New System.Windows.Forms.PictureBox()
        CType(Me.PreviewPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BackPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PreviewPictureBox
        '
        Me.PreviewPictureBox.BackColor = System.Drawing.Color.Black
        resources.ApplyResources(Me.PreviewPictureBox, "PreviewPictureBox")
        Me.PreviewPictureBox.Name = "PreviewPictureBox"
        Me.PreviewPictureBox.TabStop = False
        '
        'BackPictureBox
        '
        Me.BackPictureBox.BackColor = System.Drawing.Color.Black
        resources.ApplyResources(Me.BackPictureBox, "BackPictureBox")
        Me.BackPictureBox.Name = "BackPictureBox"
        Me.BackPictureBox.TabStop = False
        '
        'PictureBalloon
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ControlBox = False
        Me.Controls.Add(Me.PreviewPictureBox)
        Me.Controls.Add(Me.BackPictureBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PictureBalloon"
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.SystemColors.Control
        CType(Me.PreviewPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BackPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PreviewPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents BackPictureBox As Windows.Forms.PictureBox
End Class
