Module Module1
    Public Class Speler
        Protected strNaam As String

        Public Sub New(naam As String)
            strNaam = naam
        End Sub

        Public Overridable Sub TrapBal()
            Console.WriteLine(strNaam & " trapt de bal.")
        End Sub
    End Class

    Public Class Verdediger
        Inherits Speler

        Public Sub New(naam As String)
            MyBase.New(naam)
        End Sub

        Public Overrides Sub TrapBal()
            Dim random As New Random()
            Dim kans As Double = random.NextDouble()
            If kans < 0.5 Then
                Console.WriteLine(strNaam & " verliest de bal!")
            Else
                Console.WriteLine(strNaam & " geeft de bal goed af aan een ploeggenoot.")
            End If
        End Sub
    End Class

    Public Class Aanvaller
        Inherits Speler

        Public Sub New(naam As String)
            MyBase.New(naam)
        End Sub

        Public Overrides Sub TrapBal()
            Dim random As Random = New Random()
            Dim kans As Double = random.NextDouble()
            If kans < 0.3 Then
                Console.WriteLine(strNaam & " scoort een GOAL!")
            Else
                Console.WriteLine(strNaam & " mist de kans om te scoren.")
            End If
        End Sub
    End Class

    Sub Main()
        Dim mijnverdediger As New Verdediger("Jan")
        Dim mijnaanvaller As New Aanvaller("Piet")

        mijnverdediger.TrapBal()
        mijnaanvaller.TrapBal()

    End Sub
End Module
