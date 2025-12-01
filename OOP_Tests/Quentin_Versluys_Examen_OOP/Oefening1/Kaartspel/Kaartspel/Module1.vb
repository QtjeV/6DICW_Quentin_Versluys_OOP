Imports System.Security.Cryptography

Module Module1
    Public Class Deck
        'velden
        Private intCurrentSuit As Integer
        Private intCurrentValue As Integer

        'constructor geen parameters zet alels op 0
        Public Sub New()
            intCurrentSuit = 0
            intCurrentValue = 0
        End Sub

        'checkt als de kaarten op zijn of niet als het zo is dan doet het de volgende suit en anders de volgende kaart
        'geeft de kaart weer en welke suit het is
        Public Function ShowNextCard()
            Dim suits As String() = {"Harten", "Ruiten", "Schoppen", "Klaveren"}
            Dim deck As String() = {"2", "3", "4", "5", "6", "7", "8", "9", "10", "Boer", "Dame", "Heer", "Aas"}
            If intCurrentValue + 1 > 13 Then
                IncrementCard()
                Console.WriteLine(deck(intCurrentValue) & " van " & suits(intCurrentSuit))
                intCurrentValue += 1
            Else
                Console.WriteLine(deck(intCurrentValue) & " van " & suits(intCurrentSuit))
                intCurrentValue += 1
            End If
        End Function

        'schakelt over naar de volgende suit en het beginkaart
        Private Function IncrementCard()
            intCurrentSuit += 1
            intCurrentValue = 0
        End Function
    End Class
    Sub Main()
        Dim myDeck As New Deck()

        'trekt 15 kaarten
        Console.WriteLine("De getrokken kaarten zijn:")
        For i As Integer = 1 To 15
            myDeck.ShowNextCard()
        Next
    End Sub

End Module
