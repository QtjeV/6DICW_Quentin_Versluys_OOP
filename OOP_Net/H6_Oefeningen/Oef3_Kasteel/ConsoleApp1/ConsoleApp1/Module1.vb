Module Module1
    Class Kasteel
        ' Velden
        Private strKoning As String
        Private intAantalRidders As Integer

        ' Constructor
        Public Sub New()
            NaamKoning()
        End Sub
        'Maakt een random naam voor de koning door het te vergelijken met een andere naam en op basis van lengte de langste te kiezen.
        'bepaalt het aantal ridders op basis van de lengte van de naam
        Private Sub NaamKoning()
            Dim random As New Random()
            Dim namen As String() = {"Arthur", "Lodewijk", "Richard", "Filips", "Karel", "Sir Bazinga de Viertiende van Langebeke"}
            Dim naam1 As String = namen(random.Next(namen.Length))
            Dim naam2 As String = namen(random.Next(namen.Length))
            If Len(naam1) > Len(naam2) Then
                strKoning = naam1
            Else
                strKoning = naam2
            End If

            intAantalRidders = Len(WielsKoning())

        End Sub

        'Geeft de naam van de koning terug
        Public Function WielsKoning() As String
            Return strKoning
        End Function
        ' Geeft het aantal ridders terug
        Public Function GeefAantalRidders() As Integer
            Return intAantalRidders
        End Function
    End Class
    Sub Main()
        ' Maak een instantie van de Kasteel klasse
        Dim objKasteel As New Kasteel()
        ' Toon de naam van de koning en het aantal ridders
        Console.WriteLine("De koning is " & objKasteel.WielsKoning())
        Console.WriteLine("Aantal ridders: " & objKasteel.GeefAantalRidders())
    End Sub

End Module
