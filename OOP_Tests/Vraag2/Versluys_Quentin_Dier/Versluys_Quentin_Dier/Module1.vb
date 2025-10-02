Module Module1
    Public Class Dier
        'velden
        Public naam As String
        Public leeftijd As Integer
        Public aanwezig As Boolean
        Public gewicht As Double

        'constructor
        Public Sub New(naam As String, leeftijd As Integer, aanwezig As Boolean, gewicht As Double)
            Me.naam = naam
            Me.leeftijd = leeftijd
            Me.aanwezig = aanwezig
            Me.gewicht = gewicht
        End Sub
        'zet status aanwezig
        Public Sub ZetAanwezig(status)
            aanwezig = status
        End Sub

        'toont of dier aanwezig is
        Public Function GeefAanwezig()
            If aanwezig Then
                Return True
            Else
                Return False
            End If
        End Function
        'toont naam van dier
        Public Function GeefNaam()
            Return naam
        End Function
    End Class
    Sub Main()
        Dim objDier As New Dier("Joske de Leeuw", 12, False, 280.2)
        'zet dier aanwezig
        objDier.ZetAanwezig(True)
        'controleer of dier aanwezig is
        If objDier.GeefAanwezig() Then
            Console.WriteLine("Dier met naam: " & objDier.GeefNaam() & " is aanwezig")
        Else
            Console.WriteLine("Dier met naam: " & objDier.GeefNaam() & " is afwezig")
        End If
    End Sub

End Module
