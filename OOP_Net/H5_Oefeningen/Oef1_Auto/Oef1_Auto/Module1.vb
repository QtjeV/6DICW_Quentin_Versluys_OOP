Module Module1
    ' Klasse Auto
    Public Class Auto
        ' Velden
        Public Property Bandenspanning As Double

        ' Constructor
        Public Sub New()
            ' Bandenspanning
            Me.Bandenspanning = 5.0
        End Sub

        ' Methode om op vakantie te gaan
        Public Sub GaOpVakantie()
            Bandenspanning -= 1.0
            If Bandenspanning < 0 Then Bandenspanning = 0
        End Sub

        ' Methode om banden op te pompen
        Public Sub PompBandenOp()
            Bandenspanning = 5.0
        End Sub

        ' Methode om bar weer te geven
        Public Sub GeefStaatWagenWeer()
            Console.WriteLine("Huidige bandenspanning: " & Bandenspanning & " bar")
            If Bandenspanning > 3.0 Then
                Console.WriteLine("Alles is in orde.")
            Else
                Console.WriteLine("Probleem: bandenspanning te laag!")
            End If
        End Sub
    End Class

    Sub Main()
        ' Object aanmaken
        Dim mijnAuto As New Auto()

        ' Demonstratie van constructor
        Console.WriteLine("Na aanmaak van de auto:")
        mijnAuto.GeefStaatWagenWeer()

        ' Auto gaat op vakantie
        Console.WriteLine("Auto gaat op vakantie:")
        mijnAuto.GaOpVakantie()
        mijnAuto.GeefStaatWagenWeer()

        ' Nog een vakantie
        Console.WriteLine("Auto gaat opnieuw op vakantie:")
        mijnAuto.GaOpVakantie()
        mijnAuto.GeefStaatWagenWeer()

        ' Banden oppompen
        Console.WriteLine("Banden worden weer opgepompt:")
        mijnAuto.PompBandenOp()
        mijnAuto.GeefStaatWagenWeer()

        Console.ReadLine()
    End Sub
End Module
