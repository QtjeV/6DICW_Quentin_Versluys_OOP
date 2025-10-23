Module Module1
    Public Class Dier
        Protected intKleur As Integer

        Public Sub New(intKleur As Integer)
            Me.intKleur = intKleur
        End Sub

        Public Sub Eet()
            Console.WriteLine("Het dier eet.")
        End Sub

        Public Sub Slaap()
            Console.WriteLine("Het dier slaapt.")
        End Sub

    End Class

    Public Class Hond
        Inherits Dier
        Private strBaas As String

        Public Sub New(intKleur As Integer)
            MyBase.New(intKleur)
            Me.strBaas = strBaas
        End Sub
        Public Sub Blaf()
            Console.WriteLine("De hond blaft.")
        End Sub

        Public Function GetEigenaar() As String
            Return strBaas
        End Function

        Public Sub ZetEigenaar(naam As String)
            strBaas = naam
        End Sub
    End Class

    Public Class leeuw
        Inherits Dier
        Private strJungleNaam As String

        Public Sub New(intKleur As Integer)
            MyBase.New(intKleur)
            Me.strJungleNaam = strJungleNaam
        End Sub

        Public Sub Brult()
            Console.WriteLine("De leeuw brult.")
        End Sub

        Public Function GetJungle() As String
            Return strJungleNaam
        End Function

        Public Sub ZetJungle(naam As String)
            strJungleNaam = naam
        End Sub
    End Class
    Sub Main()
        Dim mijnHond As New Hond(0)
        mijnHond.ZetEigenaar("Jan")
        mijnHond.Eet()
        mijnHond.Blaf()
        Console.WriteLine("De eigenaar van de hond is: " & mijnHond.GetEigenaar())
        mijnHond.Slaap()

        Dim mijnLeeuw As New leeuw(0)
        mijnLeeuw.ZetJungle("Savanne")
        mijnLeeuw.Eet()
        mijnLeeuw.Brult()
        Console.WriteLine("De jungle van de leeuw is: " & mijnLeeuw.GetJungle())
        mijnLeeuw.Slaap()

    End Sub

End Module
