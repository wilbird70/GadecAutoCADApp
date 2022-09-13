'Gadec Engineerings Software (c) 2022
Imports Autodesk.AutoCAD.ApplicationServices
Imports Autodesk.AutoCAD.DatabaseServices
Imports Autodesk.AutoCAD.EditorInput
Imports Autodesk.AutoCAD.Geometry

''' <summary>
''' Provides methods to draw a lines between insertion points of blockreferences.
''' </summary>
Public Class LoopLineMethods

    'subs

    ''' <summary>
    ''' Allows the user to select blockreferences for drawing a polyline (3 vertices) between them.
    ''' </summary>
    ''' <param name="document">The present document.</param>
    ''' <param name="type">'LL' for loopline and 'RL' for remoteline.</param>
    ''' <param name="layerId">The objectid of the layer to be used.</param>
    Public Shared Sub DrawLoopLine(document As Document, layerId As ObjectId)
        Dim db = document.Database
        Dim ed = document.Editor
        Dim referenceIds = New ObjectIdCollection
        Dim basePoint As Nullable(Of Point3d) = Nothing
        Dim promptEntityOptions = New PromptEntityOptions("X")
        Do
            Select Case IsNothing(basePoint)
                Case True : promptEntityOptions.Message = ("Sel First Block").Translate
                Case Else : promptEntityOptions.Message = ("Sel Next Block").Translate
            End Select
            Dim selectionResult = ed.GetEntity(promptEntityOptions)
            If Not selectionResult.Status = PromptStatus.OK Then Exit Do

            Dim symbolData = ReferenceHelper.GetReferenceData(db, selectionResult.ObjectId)
            If IsNothing(symbolData) Then Continue Do

            If Not referenceIds.Contains(selectionResult.ObjectId) Then referenceIds.Add(selectionResult.ObjectId)
            Dim selectedInsertionPoint = symbolData.GetValue("Position")
            If IsNothing(basePoint) Then basePoint = selectedInsertionPoint : Continue Do

            LoopLineHelper.CreateLoopLine(document, basePoint, selectedInsertionPoint, layerId)
            basePoint = selectedInsertionPoint
        Loop
        DrawOrderHelper.BringToFront(document, referenceIds)
    End Sub

    ''' <summary>
    ''' Allows the user to select blockreferences for drawing a dashed line between them.
    ''' </summary>
    ''' <param name="document">The present document.</param>
    ''' <param name="type">'LL' for loopline and 'RL' for remoteline.</param>
    ''' <param name="layerId">The objectid of the layer to be used.</param>
    Public Shared Sub DrawRemoteLine(document As Document, layerId As ObjectId)
        Dim db = document.Database
        Dim ed = document.Editor
        Dim referenceIds = New ObjectIdCollection
        Dim basePoint As Nullable(Of Point3d) = Nothing
        Dim promptEntityOptions = New PromptEntityOptions("X")
        Do
            Select Case IsNothing(basePoint)
                Case True : promptEntityOptions.Message = ("Sel First Block").Translate
                Case Else : promptEntityOptions.Message = ("Sel Next Block").Translate
            End Select
            Dim selectionResult = ed.GetEntity(promptEntityOptions)
            If Not selectionResult.Status = PromptStatus.OK Then Exit Do

            Dim symbolData = ReferenceHelper.GetReferenceData(db, selectionResult.ObjectId)
            If IsNothing(symbolData) Then Continue Do

            If Not referenceIds.Contains(selectionResult.ObjectId) Then referenceIds.Add(selectionResult.ObjectId)
            Dim selectedInsertionPoint = symbolData.GetValue("Position")
            If IsNothing(basePoint) Then basePoint = selectedInsertionPoint : Continue Do

            LoopLineHelper.CreateRemoteLine(document, basePoint, selectedInsertionPoint, layerId)
            basePoint = Nothing
        Loop
        DrawOrderHelper.BringToFront(document, referenceIds)
    End Sub

End Class

