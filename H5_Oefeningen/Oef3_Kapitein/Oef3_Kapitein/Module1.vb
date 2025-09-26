Module Module1
    Public Class Voetballer
        Public strNaam As String
        Public blnisKapitein As Boolean

        Public Sub New(strNaam As String)
            Me.strNaam = strNaam
            Me.blnisKapitein = False
        End Sub

        Public Sub geefKapitein()
            If blnisKapitein Then
                Console.WriteLine(strNaam & " is al kapitein.")
            Else
                Console.WriteLine(strNaam & " is niet kapitein.")
            End If
        End Sub

        Public Sub setKapitein(blnisKapitein As Boolean)
            Me.blnisKapitein = blnisKapitein
        End Sub

    End Class
    Sub Main()
        Dim objVoetballer As New Voetballer("Jan")
        objVoetballer.geefKapitein()
        objVoetballer.setKapitein(True)
        objVoetballer.geefKapitein()
    End Sub

End Module
