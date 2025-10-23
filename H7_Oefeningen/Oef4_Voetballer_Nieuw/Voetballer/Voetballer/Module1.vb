Module Module1

    Public Class Voetballer
        Protected strNaam As String
        Protected doubleBetrouwbaarheid As Double
        Protected intGeleKaarten As Integer

        ' Property om de naam buiten de class toegankelijk te maken
        Public ReadOnly Property Naam As String
            Get
                Return strNaam
            End Get
        End Property

        Public Sub New(naam As String, doubleBetrouwbaarheid As Double)
            Me.strNaam = naam
            Me.doubleBetrouwbaarheid = doubleBetrouwbaarheid
            Me.intGeleKaarten = 0
        End Sub
    End Class

    Public Class Keeper
        Inherits Voetballer
        Private Shared rnd As New Random() ' gedeelde Random voor consistente willekeur

        Public Sub New(naam As String, doubleBetrouwbaarheid As Double)
            MyBase.New(naam, doubleBetrouwbaarheid)
        End Sub

        ' Retourneert de kans dat de keeper de strafschop stopt (0–1)
        Public Function DoeStrafschop() As Double
            ' Willekeurige factor tussen -0.1 en +0.2
            Dim variatie As Double = (rnd.NextDouble() * 0.3) - 0.1
            Dim kans As Double = doubleBetrouwbaarheid + variatie
            If kans > 1 Then kans = 1
            If kans < 0 Then kans = 0
            Return kans
        End Function
    End Class

    Public Class Trapper
        Inherits Voetballer
        Private Shared rnd As New Random()

        Public Sub New(naam As String, doubleBetrouwbaarheid As Double)
            MyBase.New(naam, doubleBetrouwbaarheid)
        End Sub

        ' Retourneert de kans dat de trapper scoort (0–1)
        Public Function DoeStrafschop() As Double
            ' Willekeurige factor tussen -0.3 en +0.1
            Dim variatie As Double = (rnd.NextDouble() * 0.4) - 0.3
            Dim kans As Double = doubleBetrouwbaarheid + variatie
            If kans > 1 Then kans = 1
            If kans < 0 Then kans = 0
            Return kans
        End Function
    End Class

    Public Sub Main()
        ' Randomize() is hier niet nodig

        Dim objMbappe As New Trapper("Kylian Mbappe", 0.8)
        Dim objMartinez As New Keeper("Martinez", 0.6)

        Dim dblTrapper As Double = objMbappe.DoeStrafschop()
        Dim dblKeeper As Double = objMartinez.DoeStrafschop()

        Console.WriteLine("Trapper: " & objMbappe.Naam & " (" & Math.Round(dblTrapper * 100, 1) & "% kans)")
        Console.WriteLine("Keeper: " & objMartinez.Naam & " (" & Math.Round(dblKeeper * 100, 1) & "% kans)")

        If dblKeeper > dblTrapper Then
            Console.WriteLine("Gepakt door keeper!")
        Else
            Console.WriteLine("Binnen getrapt!")
        End If

        Console.ReadLine()
    End Sub

End Module
