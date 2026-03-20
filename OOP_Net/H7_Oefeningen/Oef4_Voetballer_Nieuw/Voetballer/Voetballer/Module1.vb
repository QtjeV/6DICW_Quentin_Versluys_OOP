Module Module1

    Public Class Voetballer
        Protected strNaam As String
        Protected doubleBetrouwbaarheid As Double
        Protected intGeleKaarten As Integer
        Public Function GetNaam() As String
            Return strNaam
        End Function

        Public Sub New(naam As String, doubleBetrouwbaarheid As Double)
            Me.strNaam = naam
            Me.doubleBetrouwbaarheid = doubleBetrouwbaarheid
            Me.intGeleKaarten = 0
        End Sub

        Public Overridable Function DoeStrafschop() As Double
            Return 0.0
        End Function
    End Class

    Public Class Keeper
        Inherits Voetballer
        Private rnd As New Random()

        Public Sub New(naam As String, doubleBetrouwbaarheid As Double)
            MyBase.New(naam, doubleBetrouwbaarheid)
        End Sub
        Public Overrides Function DoeStrafschop() As Double
            Dim variatie As Double = (rnd.NextDouble() * 0.3) - 0.1
            Dim kans As Double = doubleBetrouwbaarheid + variatie
            Return kans
        End Function
    End Class

    Public Class Trapper
        Inherits Voetballer
        Private Shared rnd As New Random()

        Public Sub New(naam As String, doubleBetrouwbaarheid As Double)
            MyBase.New(naam, doubleBetrouwbaarheid)
        End Sub
        Public Overrides Function DoeStrafschop() As Double
            Dim variatie As Double = (rnd.NextDouble() * 0.4) - 0.3
            Dim kans As Double = doubleBetrouwbaarheid + variatie
            Return kans
        End Function
    End Class

    Public Sub Main()
        Dim objMbappe As New Trapper("Kylian Mbappe", 0.8)
        Dim objMartinez As New Keeper("Martinez", 0.6)

        Dim dblTrapper As Double = objMbappe.DoeStrafschop()
        Dim dblKeeper As Double = objMartinez.DoeStrafschop()

        Console.WriteLine("Trapper: " & objMbappe.GetNaam & " (" & Math.Round(dblTrapper * 100, 1) & "% kans)")
        Console.WriteLine("Keeper: " & objMartinez.GetNaam & " (" & Math.Round(dblKeeper * 100, 1) & "% kans)")

        If dblKeeper > dblTrapper Then
            Console.WriteLine("Gepakt door keeper!")
        Else
            Console.WriteLine("Binnen getrapt!")
        End If
    End Sub

End Module
