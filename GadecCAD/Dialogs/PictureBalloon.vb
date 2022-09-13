'Gadec Engineerings Software (c) 2022
Imports System.Windows.Forms
Imports System.Drawing

''' <summary>
'''  
''' ///NotYetFullyDocumented\\\
''' 
''' Provides methods for...
''' </summary>
Public Class PictureBalloon
    Private _timerFadeIn As Timer
    Private _position As Point

    Private ReadOnly _bitmap As Bitmap
    Private ReadOnly _borderColor As Color
    Private ReadOnly _height As Integer
    Private ReadOnly _alignment As HorizontalAlignment
    Private ReadOnly _text As String
    Private ReadOnly _textHeight As Integer
    Private ReadOnly _previewWidth As Integer = 88
    Private ReadOnly _speed As Integer

    'form

    Sub New(bitmap As Bitmap, position As Point, alignment As HorizontalAlignment, borderColor As Color, height As Integer, text As String, textHeight As Integer)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.

        _bitmap = bitmap
        _position = New Point(position.X, position.Y - 20)
        _height = height
        _alignment = alignment
        _text = text
        _textHeight = textHeight
        _borderColor = borderColor

        Me.Height = _height
        BackPictureBox.Height = _height - 2
        PreviewPictureBox.Height = _height - 10

        If IsNothing(_bitmap) Then _bitmap = PreviewPictureBox.ErrorImage
        If NotNothing(_bitmap) Then _previewWidth = _bitmap.Width * (PreviewPictureBox.Height / _bitmap.Height)

        _speed = _previewWidth / 5

        Me.SetDesktopLocation(0, 0)
        Me.TopMost = True
        Me.Show()
    End Sub

    Private Sub Me_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            Select Case True
                Case IsNothing(_bitmap)
                Case _alignment = HorizontalAlignment.Left
                    PreviewPictureBox.Width = _previewWidth
                    BackPictureBox.Width = _previewWidth + 8
                    PreviewPictureBox.Left = -PreviewPictureBox.Width - 5
                    Me.Width = 0
                    PreviewPictureBox.SizeMode = PictureBoxSizeMode.Zoom
                    PreviewPictureBox.Image = _bitmap
                    PreviewPictureBox.BringToFront()
                Case _alignment = HorizontalAlignment.Right
                    PreviewPictureBox.Width = _previewWidth
                    BackPictureBox.Width = _previewWidth + 8
                    PreviewPictureBox.Left = 5
                    Me.Width = 0
                    PreviewPictureBox.SizeMode = PictureBoxSizeMode.Zoom
                    PreviewPictureBox.Image = _bitmap
                    PreviewPictureBox.BringToFront()
            End Select
            _timerFadeIn = New Timer
            AddHandler _timerFadeIn.Tick, AddressOf TimerTickFadeInEventHandler
            _timerFadeIn.Interval = 20
            _timerFadeIn.Enabled = True
        Catch ex As Exception
            GadecException(ex)
        End Try
    End Sub

    Private Sub Me_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Try
            Select Case _alignment
                Case HorizontalAlignment.Left
                    Dim contour = PointArray((4, 0), (Me.Width - 1, 0), (Me.Width - 1, Me.Height - 1), (4, Me.Height - 1), (4, 24), (0, 20), (4, 16), (4, 0))
                    Dim arrow = PointArray((5, 25), (0, 20), (5, 15))
                    e.Graphics.FillPolygon(New SolidBrush(Color.Black), arrow)
                    e.Graphics.DrawLines(New Pen(_borderColor, 1), contour)
                Case HorizontalAlignment.Right
                    Dim contour = PointArray((Me.Width - 5, 0), (0, 0), (0, Me.Height - 1), (Me.Width - 5, Me.Height - 1), (Me.Width - 5, 24), (Me.Width - 1, 20), (Me.Width - 5, 16), (Me.Width - 5, 0))
                    Dim arrow = PointArray((Me.Width - 6, 25), (Me.Width - 1, 20), (Me.Width - 6, 15))
                    e.Graphics.FillPolygon(New SolidBrush(Color.Black), arrow)
                    e.Graphics.DrawLines(New Pen(_borderColor, 1), contour)
            End Select
        Catch ex As Exception
            GadecException(ex)
        End Try
    End Sub


    Private Sub Me_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        Try
            Me.Dispose()
        Catch ex As Exception
            GadecException(ex)
        End Try
    End Sub

    'pictureboxes

    Private Sub PreviewPictureBox_MouseMove(sender As Object, e As MouseEventArgs) Handles PreviewPictureBox.MouseMove
        Try
            Me.Dispose()
        Catch ex As Exception
            GadecException(ex)
        End Try
    End Sub

    'eventhandlers

    Private Sub TimerTickFadeInEventHandler(ByVal sender As Object, ByVal e As EventArgs)
        Try
            If Me.IsDisposed Then _timerFadeIn.Enabled = False
            Dim newWidth = Me.Width + _speed
            Select Case _alignment
                Case 0
                    Me.SetDesktopLocation(_position.X, _position.Y)
                    Select Case newWidth < _previewWidth + 14
                        Case True
                            PreviewPictureBox.Left += _speed
                            Me.Width = newWidth
                        Case Else
                            PreviewPictureBox.Left = 10
                            BackPictureBox.Left = 5
                            Me.Width = _previewWidth + 14
                            If Not _text = "" Then CreateCustumLabel()
                            _timerFadeIn.Enabled = False
                    End Select
                Case 1
                    Select Case newWidth < _previewWidth + 14
                        Case True
                            Me.Width = newWidth
                            Me.SetDesktopLocation(_position.X - Me.Width, _position.Y)
                        Case Else
                            Me.Width = _previewWidth + 14
                            Me.SetDesktopLocation(_position.X - Me.Width, _position.Y)
                            If Not _text = "" Then CreateCustumLabel()
                            _timerFadeIn.Enabled = False
                    End Select
            End Select
            Me.Refresh()
        Catch ex As Exception
            _timerFadeIn.Enabled = False
        End Try
    End Sub

    'private subs

    Private Sub CreateCustumLabel()
        Dim customLabel = New OutlinedLabel(Color.Gray, 2) With {
            .Font = FontHelper.SansSerifBold(_textHeight),
            .AutoSize = True,
            .ForeColor = Color.White,
            .BackColor = Color.Transparent,
            .Text = IO.Path.GetFileName(_text),
            .Left = 0,
            .Top = 0
        }
        Me.Controls.Add(customLabel)
        customLabel.Parent = PreviewPictureBox
        customLabel.BringToFront()
    End Sub

    'private functions

    Private Function PointArray(ParamArray points As (x As Integer, y As Integer)()) As Point()
        Return points.Select(Function(x) New Point(x.x, x.y)).ToArray
    End Function

End Class