Module Module1
    Public Class Koppel
        Private lengteVrouwInCm As Double
        Private lengteManInCm As Double

        Public Sub New(lengteVrouwInCm As Double, lengteManInCm As Double)
            Me.lengteVrouwInCm = lengteVrouwInCm
            Me.lengteManInCm = lengteManInCm
        End Sub
        Public Function Berekenlengtekind(jongen As Boolean) As Double
            If jongen Then
                Return (lengteManInCm + lengteVrouwInCm) / 2 + 6.5
            Else
                Return (lengteManInCm + lengteVrouwInCm) / 2 - 6.5
            End If
        End Function


    End Class

    Sub Main()
        Dim objbaby As New Koppel(170, 180)
        Console.WriteLine("De lengte van een jongen is: " & objbaby.Berekenlengtekind(True) & " cm")
    End Sub

End Module
