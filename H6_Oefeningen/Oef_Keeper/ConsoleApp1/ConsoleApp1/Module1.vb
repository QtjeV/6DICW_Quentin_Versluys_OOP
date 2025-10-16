Module Module1
    Public Class Kieper
        Private strVoorkeur As String

        Public Sub New()
            strVoorkeur = "midden"
        End Sub



        Public Sub ZetVoorkeurNietRandom(Voorkeur As String)
            Dim rnd As New Random()
            Dim keuze As Integer = rnd.Next(1, 4)
            If keuze = 1 Then
                strVoorkeur = "Links"
            ElseIf keuze = 2 Then
                strVoorkeur = "Midden"
            ElseIf keuze = 3 Then
                strVoorkeur = "Rechts"
            End If

        End Sub







        Public Function GeefVoorkeur() As String
            Return strVoorkeur
        End Function
    End Class
    Sub Main(args As String())
        Dim Sheldon As New Kieper()

        Sheldon.ZetVoorkeurNietRandom("links")

        Console.WriteLine(Sheldon.GeefVoorkeur())
    End Sub
End Module
