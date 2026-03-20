Module Module1
    'Kasse
    Public Class Salamander
        Protected intAantalPoten As Integer
        Protected intStaartLengteInCm As Integer
        Protected dblLongCapaciteitInLiter As Double

        'Constructor
        Public Sub New()
            intAantalPoten = 4
            intStaartLengteInCm = 6
            dblLongCapaciteitInLiter = 0.5
        End Sub

        Public Function GeefAantalPoten() As Integer
            Return intAantalPoten
        End Function

        Public Function GeefLongCapaciteit() As Double
            Return dblLongCapaciteitInLiter
        End Function
    End Class

    'Tijger
    Public Class Tijger
        Inherits Salamander

        Protected strHaarKleur As String

        'Constructor met parameter
        Public Sub New(hairColor As String)
            MyBase.New()
            strHaarKleur = hairColor
        End Sub

        Public Function GeefHaarKleur() As String
            Return strHaarKleur
        End Function
    End Class

    'Mens
    Public Class Mens
        Inherits Tijger

        Private intAantalBenen As Integer
        Private intAantalArmen As Integer

        'Constructor
        Public Sub New(hairColor As String)
            MyBase.New(hairColor)
            intAantalBenen = 2
            intAantalArmen = 2
            intAantalPoten = 0
            intStaartLengteInCm = 0
            dblLongCapaciteitInLiter = 7
        End Sub

        Public Function GeefAantalArmenEnBenen() As Integer
            Return intAantalArmen + intAantalBenen
        End Function
    End Class
    Public Sub Main()
        Dim objSalamander As New Salamander()
        Dim objTijger As New Tijger("Oranje met zwarte strepen")
        Dim objMens As New Mens("Rood")

        'De poten
        Console.WriteLine("De Salamander heeft zoveel poten: " & objSalamander.GeefAantalPoten())
        Console.WriteLine("De Tijger heeft zoveel poten: " & objTijger.GeefAantalPoten())
        Console.WriteLine("De Mens heeft zoveel poten: " & objMens.GeefAantalPoten())

        'Kleur van haar
        Console.WriteLine("De Tijger heeft deze kleur van haar: " & objTijger.GeefHaarKleur())
        Console.WriteLine("De Mens heeft deze kleur van haar: " & objMens.GeefHaarKleur())

        'Longcapaciteit
        Console.WriteLine("De Salamander longcapaciteit (in liter): " & objSalamander.GeefLongCapaciteit())
        Console.WriteLine("De Tijger longcapaciteit (in liter): " & objTijger.GeefLongCapaciteit())
        Console.WriteLine("De Mens longcapaciteit (in liter): " & objMens.GeefLongCapaciteit())
    End Sub
End Module
