Module Module1
    ' Klasse
    Public Class Draak
        ' Velden 
        Public Property Naam As String
        Public Property Origin As String
        Public Property Gender As String
        Public Property Leeftijd As Integer
        Public Property Classificatie As String

        ' Constructor 
        Public Sub New(naam As String, origin As String, gender As String, leeftijd As Integer, classificatie As String)
            Me.Naam = naam
            Me.Origin = origin
            Me.Gender = gender
            Me.Leeftijd = leeftijd
            Me.Classificatie = classificatie
        End Sub
    End Class

    Sub Main()
        ' Objecten aanmaken van draken
        Dim draak1 As New Draak("Drogon", "Essos", "Mannelijk", 7, "Vuurdraak")
        Dim draak2 As New Draak("Rhaegal", "Essos", "Mannelijk", 7, "Vuurdraak")
        Dim draak3 As New Draak("Viserion", "Essos", "Mannelijk", 6, "Vuurdraak")

        ' print draken
        Console.WriteLine("Draak 1: " & draak1.Naam & ", " & draak1.Origin & ", " & draak1.Gender & ", " & draak1.Leeftijd & " jaar, " & draak1.Classificatie)
        Console.WriteLine("Draak 2: " & draak2.Naam & ", " & draak2.Origin & ", " & draak2.Gender & ", " & draak2.Leeftijd & " jaar, " & draak2.Classificatie)
        Console.WriteLine("Draak 3: " & draak3.Naam & ", " & draak3.Origin & ", " & draak3.Gender & ", " & draak3.Leeftijd & " jaar, " & draak3.Classificatie)
        Console.ReadLine()
    End Sub
End Module
