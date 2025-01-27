'Gadec Engineerings Software (c) 2022
Imports System.Threading
Imports Autodesk.AutoCAD.ApplicationServices
Imports Autodesk.AutoCAD.DatabaseServices
Imports GadecCAD.Extensions

''' <summary>
''' Provides a method of re-rooting the paths to xrefs if the links are broken.
''' </summary>
Public Class XrefHelper

    ''' <summary>
    ''' Re-roots the paths to xrefs if the links are broken.
    ''' </summary>
    ''' <param name="document">The present document.</param>
    Public Shared Sub ReRootPaths(document As Document)
        Dim db = document.Database
        Dim xrefsToReload = New ObjectIdCollection
        Dim countedXrefs = 0
        Dim resolvedXrefs = 0
        Using tr = db.TransactionManager.StartTransaction()
            Dim bt = tr.GetBlockTable(db.BlockTableId)
            For Each objectId In bt
                Dim btr = tr.GetBlockTableRecord(objectId)
                If Not btr.IsFromExternalReference Then Continue For

                countedXrefs += 1
                If btr.IsResolved Then Continue For

                resolvedXrefs += 1
                btr.UpgradeOpen()
                Dim oldPath = btr.PathName
                If fileExistsFast(oldPath) Then Continue For

                Dim searchFolder = IO.Path.GetDirectoryName(document.Name)
                Dim resultPath = "."
                Do
                    Dim xrefName = "{0}.dwg".Compose(IO.Path.GetFileNameWithoutExtension(oldPath))
                    Dim foundFiles = IO.Directory.GetFiles(searchFolder, xrefName, IO.SearchOption.AllDirectories)
                    Select Case foundFiles.Count > 0
                        Case True
                            'maak paden relatief
                            For i = 0 To foundFiles.Count - 1
                                Select Case searchFolder.EndsWith("\")
                                    Case True : foundFiles(i) = foundFiles(i).Replace(searchFolder.EraseEnd(1), resultPath)
                                    Case Else : foundFiles(i) = foundFiles(i).Replace(searchFolder, resultPath)
                                End Select
                            Next
                            Dim prompt = ("SelectXref").Translate(btr.Name.Cut)
                            Dim dialog = New ListBoxDialog(prompt, foundFiles)
                            If Not dialog.DialogResult = Windows.Forms.DialogResult.OK Then Exit Do

                            btr.PathName = foundFiles(dialog.GetSelectedIndex)
                            xrefsToReload.Add(objectId)
                            Exit Do
                        Case Else
                            Dim prompt = ("FileNotFoundinFolder").Translate(searchFolder.Cut)
                            Dim dialogResult = MessageBoxQuestion(prompt, Windows.Forms.MessageBoxButtons.OKCancel)
                            If Not dialogResult = Windows.Forms.DialogResult.OK Then Exit Do

                            searchFolder = IO.Path.GetDirectoryName(searchFolder)
                            Select Case resultPath = "."
                                Case True : resultPath = ".."
                                Case Else : resultPath &= "\.."
                            End Select
                    End Select
                Loop
            Next
            tr.Commit()
        End Using
        If xrefsToReload.Count > 0 Then db.ReloadXrefs(xrefsToReload)
        Select Case True
            Case countedXrefs = 0 : MsgBox("NoXrefinDwg".Translate)
            Case resolvedXrefs = 0 : MsgBox("AllXrefFound".Translate)
        End Select
    End Sub

    ''' <summary>
    ''' Determines whether the specified file exists with a time-out of 500ms.
    ''' </summary>
    ''' <param name="path">The file to check.</param>
    ''' <returns>True if found within the time-out, otherwise false.</returns>
    Private Shared Function fileExistsFast(ByVal path As String) As Boolean
        Dim output = False
        Dim thread = New Thread(New ThreadStart(Sub() output = IO.File.Exists(path)))
        thread.Start()
        If Not thread.Join(500) Then thread.Abort()
        Return output
    End Function

End Class
