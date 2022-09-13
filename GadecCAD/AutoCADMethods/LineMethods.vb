'Gadec Engineerings Software (c) 2022
Imports Autodesk.AutoCAD.ApplicationServices
Imports Autodesk.AutoCAD.DatabaseServices
Imports Autodesk.AutoCAD.EditorInput
Imports GadecCAD.Extensions

''' <summary>
''' Provides a method for manipulating lines.
''' </summary>
Public Class LineMethods

    ''' <summary>
    ''' Allows the user to select lines to join them when they are (nearly) in line with each other.
    ''' </summary>
    ''' <param name="document">The present drawing.</param>
    Public Shared Sub Join(document As Document)
        Dim db = document.Database
        Dim ed = document.Editor
        Dim promptSelectionOptions = New PromptSelectionOptions With {.MessageForAdding = "Sel Lines:".Translate, .MessageForRemoval = "Rem Lines:".Translate}
        Dim selectionResult = ed.GetSelection(promptSelectionOptions)
        If Not selectionResult.Status = PromptStatus.OK Then Exit Sub

        Dim horizontalLines = New Dictionary(Of Line, Double)
        Dim verticalLines = New Dictionary(Of Line, Double)
        Using tr = db.TransactionManager.StartTransaction
            For Each entityId In selectionResult.Value.GetObjectIds
                Dim line = tr.GetLine(entityId, OpenMode.ForWrite)
                If IsNothing(line) Then Continue For

                line.Sequence
                Select Case line.Alignment
                    Case LineAlignment.horizontal : horizontalLines.TryAdd(line, line.StartPoint.Y)
                    Case LineAlignment.vertical : verticalLines.TryAdd(line, line.StartPoint.X)
                End Select
            Next
            If horizontalLines.Count > 1 Then
                Dim lines = (From pair As KeyValuePair(Of Line, Double) In horizontalLines Order By pair.Value Ascending Select pair.Key).ToList
                Dim firstPointY = horizontalLines(lines(0))
                For i = 1 To lines.Count - 1
                    Dim secondPointY = horizontalLines(lines(i))
                    If firstPointY.IsEqual(secondPointY) Then
                        If lines(i).StartPoint.X > lines(i - 1).StartPoint.X Then
                            lines(i).StartPoint = lines(i - 1).StartPoint
                        End If
                        If lines(i).EndPoint.X < lines(i - 1).EndPoint.X Then
                            lines(i).EndPoint = lines(i - 1).EndPoint
                        End If
                        lines(i - 1).Erase()
                    End If
                    firstPointY = secondPointY
                Next
            End If
            If verticalLines.Count > 1 Then
                Dim verticalKeys = (From tPair As KeyValuePair(Of Line, Double) In verticalLines Order By tPair.Value Ascending Select tPair.Key).ToList
                Dim firstPointX = verticalLines(verticalKeys(0))
                For i = 1 To verticalKeys.Count - 1
                    Dim secondPointX = verticalLines(verticalKeys(i))
                    If firstPointX.IsEqual(secondPointX) Then
                        If verticalKeys(i).StartPoint.Y > verticalKeys(i - 1).StartPoint.Y Then
                            verticalKeys(i).StartPoint = verticalKeys(i - 1).StartPoint
                        End If
                        If verticalKeys(i).EndPoint.Y < verticalKeys(i - 1).EndPoint.Y Then
                            verticalKeys(i).EndPoint = verticalKeys(i - 1).EndPoint
                        End If
                        verticalKeys(i - 1).Erase()
                    End If
                    firstPointX = secondPointX
                Next
            End If
            tr.Commit()
        End Using
    End Sub

End Class
