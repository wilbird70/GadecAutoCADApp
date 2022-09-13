'Gadec Engineerings Software (c) 2022
Imports Autodesk.AutoCAD.DatabaseServices
Imports Autodesk.AutoCAD.Geometry

''' <summary>
''' <para><see cref="RollBackModel"/> contains data to roll back the symbol encoding one step.</para>
''' </summary>
Public Class RollBackModel
    ''' <summary>
    ''' The attribute texts to roll back.
    ''' </summary>
    ''' <returns>A dictionary containing the objectids of the attribute references and their texts.</returns>
    Public ReadOnly Property Texts As Dictionary(Of ObjectId, String)
    ''' <summary>
    ''' The number of symbols to roll back.
    ''' </summary>
    ''' <returns>The number.</returns>
    Public ReadOnly Property NumberOfSymbols As Integer
    ''' <summary>
    ''' The objectid of the line drawn, if any.
    ''' </summary>
    ''' <returns>The objectid.</returns>
    Public ReadOnly Property LineId As ObjectId
    ''' <summary>
    ''' The startpoint of this step.
    ''' </summary>
    ''' <returns>The point3d.</returns>
    Public ReadOnly Property Point As Point3d

    ''' <summary>
    ''' Initializes a new instance of <see cref="RollBackModel"/> with the specified properties.
    ''' <para><see cref="RollBackModel"/> contains data to roll back the symbol encoding one step.</para>
    ''' </summary>
    ''' <param name="texts">The attribute texts to roll back.</param>
    ''' <param name="numberOfSymbols">The number of symbols to roll back.</param>
    ''' <param name="lineId">The objectid of the line drawn, if any.</param>
    ''' <param name="point">The startpoint of this step.</param>
    Public Sub New(texts, numberOfSymbols, lineId, point)
        _Texts = texts
        _NumberOfSymbols = numberOfSymbols
        _LineId = lineId
        _Point = point
    End Sub

End Class
