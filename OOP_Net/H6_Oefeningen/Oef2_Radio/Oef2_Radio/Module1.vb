Imports System
Public Class Radio
    Private rnd As New Random()
    Private liedjes() As String
    Private indexliedje As Integer

    Public Sub SpeelLiedje()
        SpeelLiedjeRadio()
    End Sub
    Private Sub SpeelLiedjeRadio()
        liedjes = {"Imagine Dragons", "Coldplay", "Despacito"}
        indexliedje = rnd.Next(liedjes.Length)
        Console.WriteLine("Ik ga een liedje spelen...")
        Console.WriteLine(liedjes(indexliedje))
    End Sub
End Class
Module Module1
    Sub Main()
        Dim mijnRadio As New Radio()
        mijnRadio.SpeelLiedje()
    End Sub
End Module

