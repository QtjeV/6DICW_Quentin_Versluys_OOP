Module Module1
    Public Class Dier
        Public naam As String
        Public leeftijd As Integer
        Public aanwezig As Boolean
        Public gewicht As Double

        Public Sub New(naam As String, leeftijd As Integer, aanwezig As Boolean, gewicht As Double)
            Me.naam = naam
            Me.leeftijd = leeftijd
            Me.aanwezig = aanwezig
            Me.gewicht = gewicht
        End Sub

        Public Sub ZetAanwezig(status)
            aanwezig = status
        End Sub

        Public Function GeefAanwezig()
            If aanwezig Then
                Return True
            Else
                Return False
            End If
        End Function

        Public Function GeefNaam()
            Return naam
        End Function
    End Class
    Sub Main()
        Dim objDier As New Dier("Joske de Leeuw", 12, False, 280.2)
        objDier.ZetAanwezig(True)
        If objDier.GeefAanwezig() Then
            Console.WriteLine("Dier met naam: " & objDier.GeefNaam() & " is aanwezig")
        Else
            Console.WriteLine("Dier met naam: " & objDier.GeefNaam() & " is afwezig")
        End If
    End Sub

End Module
