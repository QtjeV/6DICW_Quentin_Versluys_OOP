Module Module1
    Public Class Bestelling
        Protected strKlantNaam As String
        Protected dblTotaalBedrag As Double

        Public Sub New(strKlantNaam As String, dblTotaalBedrag As Double)
            Me.strKlantNaam = strKlantNaam
            Me.dblTotaalBedrag = dblTotaalBedrag
        End Sub
        Public Sub ToonBestelDetails()
            Console.WriteLine("Klant met naam: " & strKlantNaam)
            Console.WriteLine("Totale bedrag zijn: " & dblTotaalBedrag)
        End Sub

        Public Overridable Function BerekenVerzendkosten() As Double
            Return 5
        End Function
    End Class

    Public Class SnelleLevering
        Inherits Bestelling
        Private dblSpoedToeslag As Double
        Public Sub New(strKlantNaam As String, dblTotaalBedrag As Double)
            MyBase.New(strKlantNaam, dblTotaalBedrag)
            Me.strKlantNaam = strKlantNaam
            Me.dblTotaalBedrag = dblTotaalBedrag
            Me.dblSpoedToeslag = 10
        End Sub

        Public Overrides Function BerekenVerzendkosten() As Double
            Return 5 + dblSpoedToeslag
        End Function
    End Class

    Public Class InternationaleBestelling
        Inherits Bestelling
        Private strLand As String
        Public Sub New(strKlantnaam As String, dblTotaalBedrag As Double, strLand As String)
            MyBase.New(strKlantnaam, dblTotaalBedrag)
            Me.strLand = strLand
        End Sub

        Public Function BerekenDouaneKosten() As Double
            Return (1 / 10 * dblTotaalBedrag)
        End Function

        Public Overrides Function BerekenVerzendkosten() As Double
            Return 5 + BerekenDouaneKosten()
        End Function

    End Class

    '--------------------------------------------------------------------------------------
    Public Class Verzending
        Protected strVerzendType As String
        Public Sub New(strVerzendType As String)
            Me.strVerzendType = strVerzendType
        End Sub
        Public Overridable Function BerekenVerzendKosten()
            Return 3
        End Function
    End Class

    Public Class PakketVerzending
        Inherits Verzending
        Private strPakketgrootte As String
        Public Sub New(strVerzendType As String, strPakketgrootte As String)
            MyBase.New(strVerzendType)
            Me.strPakketgrootte = strPakketgrootte
        End Sub

        Public Function GetTypeGrote() As String
            Return strPakketgrootte
        End Function

        Public Overrides Function BerekenVerzendKosten()
            If (strPakketgrootte = "klein") Then
                Return 3
            ElseIf strPakketgrootte = "middelgroot" Then
                Return 5
            Else
                Return 8
            End If
        End Function

    End Class
    Public Class Luchtpost
        Inherits Verzending
        Private dblLuchttarief As Double
        Public Sub New(strVerzendType As String)
            MyBase.New(strVerzendType)
            dblLuchttarief = 15
        End Sub

        Public Overrides Function BerekenVerzendKosten()
            Return 3 + dblLuchttarief
        End Function
    End Class

    Sub Main()
        Dim objJansen As New SnelleLevering("Jansen", 100)
        Dim objMartinez As New InternationaleBestelling("Martinez", 200, "Frankrijk")
        Dim objPakket As New PakketVerzending("pakket", "middelgroot")
        Dim objLuchtpost As New Luchtpost("Luchtpost")
        objJansen.ToonBestelDetails()
        Console.WriteLine("Totale verzendkosten zijn: " & objJansen.BerekenVerzendkosten())
        Console.WriteLine("---")
        objMartinez.ToonBestelDetails()
        Console.WriteLine("Duanekosten zijn: " & objMartinez.BerekenDouaneKosten())
        Console.WriteLine("Totale verzendkosten zijn: " & objMartinez.BerekenVerzendkosten())
        Console.WriteLine("---")
        Console.WriteLine("Verzendkosten voor pakket met grootte: " & objPakket.GetTypeGrote & " is: " & objPakket.BerekenVerzendKosten() & " euro.")
        Console.WriteLine("---")
        Console.WriteLine("Verzendkosten voor luchtpakket zijn: " & objLuchtpost.BerekenVerzendKosten() & " euro.")
        Console.WriteLine("---")
    End Sub

End Module


