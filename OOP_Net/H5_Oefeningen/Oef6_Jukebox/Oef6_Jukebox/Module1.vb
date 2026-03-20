Imports System.Threading

Module Module1
    Public Class JukeBox
        Private muntjes As Integer
        Private rand As New Random()

        ' Constructor
        Public Sub New()
            muntjes = 0
        End Sub

        ' Muntjes toevoegen
        Public Sub VoegMuntjesToe(aantal As Integer)
            muntjes += aantal
            Console.WriteLine($"{aantal} muntje(s) toegevoegd. Totaal: {muntjes}")
        End Sub

        ' Liedjes spelen (1 muntje = 1 liedje)
        Public Sub SpeelLiedjes()
            While muntjes > 0
                SpeelLiedje()
                muntjes -= 1
                Thread.Sleep(3000) ' wacht 3 seconden voor het volgende liedje
            End While
        End Sub

        Public Sub SpeelLiedje()
            Dim rnd As New Random
            Dim liedjeNummer As Integer = rnd.Next(1, 5)
            Console.WriteLine($"Liedje {liedjeNummer} wordt afgespeeld...")
        End Sub
    End Class
    Sub Main()
        Dim mijnJukeBox As New JukeBox()
        mijnJukeBox.VoegMuntjesToe(3)
        mijnJukeBox.SpeelLiedjes()
        Console.WriteLine("Alle muntjes zijn opgebruikt.")
    End Sub
End Module
