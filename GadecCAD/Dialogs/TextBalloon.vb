'Gadec Engineerings Software (c) 2022
Imports System.Windows.Forms
Imports System.Drawing

''' <summary>
'''  
''' ///NotYetFullyDocumented\\\
''' 
''' Provides methods for...
''' </summary>
Public Class TextBalloon
    Private _timerFadeIn As Timer
    Private _position As Point
    Private _previewWidth As Integer = 236

    Private ReadOnly _frameInfo As DataRow
    Private ReadOnly _alignment As HorizontalAlignment
    Private ReadOnly _borderColor As Color
    Private ReadOnly _speed As Integer

    'form

    Sub New(frameInfo As DataRow, position As Point, alignment As HorizontalAlignment, borderColor As Color)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.

        _frameInfo = frameInfo
        _position = New Point(position.X, position.Y - 20)
        _alignment = alignment
        _borderColor = borderColor

        WireUpDialog()
        _speed = _previewWidth / 5

        Me.SetDesktopLocation(0, 0)
        Me.TopMost = True
        Me.Show()
    End Sub

    Private Sub Me_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            If _alignment = HorizontalAlignment.Left Then
                For Each control In Me.Controls.ToArray
                    Select Case True
                        Case control.Name = "cBack"
                        Case Else : control.Left -= _previewWidth
                    End Select
                Next
            End If
            Me.Width = 0
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

    'eventhandlers

    Private Sub TimerTickFadeInEventHandler(ByVal sender As Object, ByVal e As EventArgs)
        Try
            If Me.IsDisposed Then _timerFadeIn.Enabled = False
            Dim newWidth = Me.Width + _speed
            Select Case _alignment
                Case HorizontalAlignment.Left
                    Me.SetDesktopLocation(_position.X, _position.Y)
                    Select Case newWidth < _previewWidth
                        Case True
                            Me.Width = newWidth
                            For Each c As Control In Me.Controls
                                Select Case True
                                    Case c.Name = "cBack"
                                    Case Else : c.Left += _speed
                                End Select
                            Next
                        Case Else
                            For Each c As Control In Me.Controls
                                Select Case True
                                    Case c.Name = "cBack"
                                    Case Else : c.Left = c.Tag
                                End Select
                            Next
                            Me.Width = _previewWidth
                            BackPictureBox.Left = 5
                            BackPictureBox.Width = Me.Width - 6
                            _timerFadeIn.Enabled = False
                    End Select
                Case HorizontalAlignment.Right
                    Select Case newWidth < _previewWidth
                        Case True
                            Me.Width = newWidth
                            Me.SetDesktopLocation(_position.X - Me.Width, _position.Y)
                        Case Else
                            Me.Width = _previewWidth
                            BackPictureBox.Left = 1
                            BackPictureBox.Width = Me.Width - 6
                            Me.SetDesktopLocation(_position.X - Me.Width, _position.Y)
                            _timerFadeIn.Enabled = False
                    End Select
            End Select
            Me.Refresh()
        Catch ex As Exception
            _timerFadeIn.Enabled = False
        End Try
    End Sub

    'private subs

    Private Sub WireUpDialog()
        If NotNothing(_frameInfo) Then
            For Each control In Me.Controls.ToArray
                If Not control.Name = "cPreview" Then
                    control.Text = _frameInfo.GetString(control.Name.EraseStart(1))
                    If control.Name = "cDescr3" Then cDescr4.Left = cDescr3.Left + cDescr3.Width + 3
                    If control.Name = "cClient3" Then cClient4.Left = cClient3.Left + cClient3.Width + 3
                End If
            Next
            For Each control In Me.Controls.ToArray
                control.Tag = control.Left
                Select Case True
                    Case control.Name = "cBack"
                    Case control.Left + control.Width + 5 < _previewWidth
                    Case Else : _previewWidth = control.Left + control.Width + 5
                End Select
            Next
        End If
        Me.TopMost = True
    End Sub

    'private functions

    Private Function PointArray(ParamArray points As (x As Integer, y As Integer)()) As Point()
        Return points.Select(Function(x) New Point(x.x, x.y)).ToArray
    End Function

End Class