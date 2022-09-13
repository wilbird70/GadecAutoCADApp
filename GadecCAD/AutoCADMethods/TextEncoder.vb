﻿'Gadec Engineerings Software (c) 2022
Imports Autodesk.AutoCAD.ApplicationServices
Imports Autodesk.AutoCAD.DatabaseServices
Imports Autodesk.AutoCAD.EditorInput
Imports Autodesk.AutoCAD.Geometry
Imports GadecCAD.Extensions

''' <summary>
''' <para><see cref="TextEncoder"/> allows the user to select DBText-objects to encode them.</para>
''' </summary>
Public Class TextEncoder
    Private ReadOnly _document As Document

    ''' <summary>
    ''' Initializes a new instance of <see cref="TextEncoder"/>.
    ''' <para><see cref="TextEncoder"/> allows the user to select DBText-objects to encode them.</para>
    ''' </summary>
    ''' <param name="document">The present document.</param>
    Public Sub New(document As Document)
        _document = document
    End Sub

    ''' <summary>
    ''' Runs the encode command.
    ''' <para>The code can consist of a prefix and a counting number (eg 'X1-01').</para>
    ''' <para>For example, with that code for the first text, the code after that will be 'X1-02', 'X1-03', etc...</para>
    ''' </summary>
    Public Sub Start(code As String)
        Dim db = _document.Database
        Dim ed = _document.Editor
        Dim promptEntityOptions = New PromptEntityOptions("X")
        Do
            Dim textToChange = New Dictionary(Of ObjectId, String)
            promptEntityOptions.Message = "Sel Element:".Translate(code)
            Dim selectionResult = ed.GetEntity(promptEntityOptions)
            If Not selectionResult.Status = PromptStatus.OK Then Exit Do

            Using tr = db.TransactionManager.StartTransaction
                Dim entity = tr.GetEntity(selectionResult.ObjectId)
                If Not entity.GetDBObjectType = "DBText" Then Continue Do

                textToChange.TryAdd(entity.ObjectId, code)
                tr.Commit()
            End Using
            TextHelper.ChangeTextStrings(_document, textToChange)
            Autodesk.AutoCAD.Internal.Utils.PostCommandPrompt()
            code = code.AutoNumber
        Loop
    End Sub

End Class
