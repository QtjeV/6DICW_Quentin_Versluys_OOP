Module Module1
    ' Klasse Voetballer
    Public Class Voetballer
        ' Velden
        Public Property Naam As String
        Public Property Leeftijd As Integer
        Public Property GeleKaarten As Integer

        ' Constructor
        Public Sub New(naam As String, leeftijd As Integer)
            Me.Naam = naam
            Me.Leeftijd = leeftijd
            Me.GeleKaarten = 0 ' Start met 0
        End Sub

        ' Methode naar kleedkamer & spelen
        Public Function NaarKleedkamer() As String
            If GeleKaarten > 1 Then
                Return "KLEEDKAMER"
            Else
                Return "SPELEN"
            End If
        End Function

        ' Methode gele kaart
        Public Sub GeefKaart()
            If GeleKaarten < 2 Then
                GeleKaarten += 1
            End If
        End Sub

        ' Methode status speler
        Public Sub ToonStatus()
            Console.WriteLine("Naam: " & Naam)
            Console.WriteLine("Leeftijd: " & Leeftijd)
            Console.WriteLine("Aantal gele kaarten: " & GeleKaarten)
            Console.WriteLine("Actie: " & NaarKleedkamer())
        End Sub
    End Class

    Sub Main()
        ' Objecten
        Dim speler1 As New Voetballer("Lionel Messi", 36)
        Dim speler2 As New Voetballer("Cristiano Ronaldo", 38)

        ' Demonstratie van de werking
        Console.WriteLine("Aanvang van de wedstrijd:")
        speler1.ToonStatus()
        speler2.ToonStatus()

        ' Speler1 krijgt een gele kaart
        Console.WriteLine("Na een overtreding krijgt speler1 een gele kaart:")
        speler1.GeefKaart()
        speler1.ToonStatus()

        ' Speler1 krijgt nog een gele kaart
        Console.WriteLine("Na een tweede overtreding krijgt speler1 nog een gele kaart:")
        speler1.GeefKaart()
        speler1.ToonStatus()

        ' Speler2 krijgt één gele kaart
        Console.WriteLine("Speler2 krijgt een gele kaart:")
        speler2.GeefKaart()
        speler2.ToonStatus()

        Console.ReadLine()
    End Sub
End Module

