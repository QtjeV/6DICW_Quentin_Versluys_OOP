Module Module1
    ' Klasse
    Public Class Draak
        ' Velden 
        Private Naam As String
        Private Origin As String
        Private Gender As String
        Private Leeftijd As Integer
        Private Classificatie As String

        ' Constructor 
        Public Sub New(naam As String, origin As String, gender As String, leeftijd As Integer, classificatie As String)
            Me.Naam = naam
            Me.Origin = origin
            Me.Gender = gender
            Me.Leeftijd = leeftijd
            Me.Classificatie = classificatie
        End Sub

        Public Function getnaam()
            Return Naam
        End Function
        Public Function getorigin()
            Return Origin
        End Function
        Public Function getgender()
            Return Gender
        End Function
        Public Function getleeftijd()
            Return Leeftijd
        End Function
        Public Function getclassificatie()
            Return Classificatie
        End Function
    End Class

    Sub Main()
        ' Objecten aanmaken van draken
        Dim draak1 As New Draak("Drogon", "Essos", "Mannelijk", 7, "Vuurdraak")
        Dim draak2 As New Draak("Rhaegal", "Essos", "Mannelijk", 7, "Vuurdraak")
        Dim draak3 As New Draak("Viserion", "Essos", "Mannelijk", 6, "Vuurdraak")

        ' print draken
        Console.WriteLine("Draak 1: " & draak1.getnaam & ", " & draak1.getorigin & ", " & draak1.getgender & ", " & draak1.getleeftijd & " jaar, " & draak1.getclassificatie)
        Console.WriteLine("Draak 2: " & draak2.getnaam & ", " & draak2.getorigin & ", " & draak2.getgender & ", " & draak2.getleeftijd & " jaar, " & draak2.getclassificatie)
        Console.WriteLine("Draak 3: " & draak3.getnaam & ", " & draak3.getorigin & ", " & draak3.getgender & ", " & draak3.getleeftijd & " jaar, " & draak3.getclassificatie)
        Console.ReadLine()
    End Sub
End Module
