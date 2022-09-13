'Gadec Engineerings Software (c) 2022
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

''' <summary>
''' Represents a rounded button.
''' </summary>
Public Class RoundedButton
    Inherits Button

    ''' <summary>
    ''' Creates a round button.
    ''' </summary>
    Public Sub New()
        MyBase.New
    End Sub

    ''' <summary>
    ''' The new (overridden) onpaint eventhandler.
    ''' </summary>
    ''' <param name="e"></param>
    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)
        Dim graphicsPath = New GraphicsPath(FillMode.Winding)
        graphicsPath.AddArc(0, 0, ClientSize.Height, ClientSize.Height, 90, 180)
        graphicsPath.AddLine(graphicsPath.GetLastPoint, New Point(ClientSize.Width - graphicsPath.GetLastPoint.X * 2, 0))
        graphicsPath.AddArc(New RectangleF(graphicsPath.GetLastPoint, New Size(ClientSize.Height, ClientSize.Height)), 270, 180)
        graphicsPath.CloseFigure()
        Me.Region = New Region(graphicsPath)
        Dim pen As New Pen(Color.Gray, 2) With {.Alignment = PenAlignment.Inset}
        e.Graphics.DrawPath(pen, graphicsPath)
    End Sub

End Class
