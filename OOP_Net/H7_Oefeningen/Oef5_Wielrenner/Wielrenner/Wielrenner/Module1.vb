Module Module1
    Public Class Wielrenner
        Protected strNaam As String
        Protected strLeeftijd As String
        Protected strPloeg As String

        Public Sub New(naam As String, leeftijd As String, ploeg As String)
            strNaam = naam
            strLeeftijd = leeftijd
            strPloeg = ploeg
        End Sub

        Public Function GetNaam() As String
            Return strNaam
        End Function
        Public Function GetLeeftijd() As String
            Return strLeeftijd
        End Function
    End Class

    Public Class ProfWielrenner
        Inherits Wielrenner
        Private strAantalOverwinningen As String
        Private dblSalaris As Double

        Public Sub New(naam As String, leeftijd As String, ploeg As String, strAantalOverwinningen As String, dblSalaris As Double)
            MyBase.New(naam, leeftijd, ploeg)
            Me.strAantalOverwinningen = strAantalOverwinningen
            Me.dblSalaris = dblSalaris
        End Sub

        Public Function ToonAantalOverwinningen() As String
            Return strAantalOverwinningen
        End Function
    End Class

    Public Class AmateurWielrenner
        Inherits Wielrenner
        Private intAantalDeelnames As Integer
        Private intAantalOverwinningen As Integer
        Public Sub New(naam As String, leeftijd As String, ploeg As String, intAantalDeelnames As Integer, intAantalOverwinningen As Integer)
            MyBase.New(naam, leeftijd, ploeg)
            Me.intAantalDeelnames = intAantalDeelnames
            Me.intAantalOverwinningen = intAantalOverwinningen
        End Sub
        Public Function ToonAantalOverwinningen() As Integer
            Return intAantalOverwinningen
        End Function
    End Class
    Sub Main()
        Dim profWielrenner As New ProfWielrenner("Jan Janssen", "30", "Team A", "15", 50000)
        Dim amateurWielrenner As New AmateurWielrenner("Piet Pietersen", "25", "Team B", 10, 3)
        Console.WriteLine("Prof Wielrenner: " & profWielrenner.GetNaam() & ", Leeftijd: " & profWielrenner.GetLeeftijd() & ", Aantal Overwinningen: " & profWielrenner.ToonAantalOverwinningen())
        Console.WriteLine("Amateur Wielrenner: " & amateurWielrenner.GetNaam() & ", Leeftijd: " & amateurWielrenner.GetLeeftijd() & ", Aantal Overwinningen: " & amateurWielrenner.ToonAantalOverwinningen())

    End Sub

End Module
