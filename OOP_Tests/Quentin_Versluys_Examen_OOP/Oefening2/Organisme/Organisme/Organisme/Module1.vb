Module Module1
    Public Class Organisme
        'Velden
        Protected stringNaam As String
        Protected intLeeftijdInDagen As Integer

        'Constructor met parmeter String naam, Double leeftijd
        Public Sub New(naam As String, leeftijd As Double)
            stringNaam = naam
            intLeeftijdInDagen = leeftijd
        End Sub

        'Functie groei checkt als dagen boven 30 is word het weken en als het boven 365 is dan is het in jaren
        Public Overridable Function Groei()
            If intLeeftijdInDagen < 30 Then
                Console.WriteLine(stringNaam & " is zo oud (in dagen): " & intLeeftijdInDagen)
            ElseIf intLeeftijdInDagen < 365 Then
                Console.WriteLine(stringNaam & " is zo oud (in weken): " & intLeeftijdInDagen / 7)
            Else
                Console.WriteLine(stringNaam & " is zo oud (in jaar): " & intLeeftijdInDagen / 365)
            End If
        End Function

    End Class

    Public Class Plant
        'Erft over van Organisme
        Inherits Organisme

        'velden
        Protected doubleHoogteInMeter As Double

        'Constructor met parameters String naam, Double leeftijd en Double hoogte
        Public Sub New(naam As String, leeftijd As Double, hoogte As Double)
            MyBase.New(naam, leeftijd)
            doubleHoogteInMeter = hoogte
        End Sub

        'Functie groei checkt als dagen boven 30 is word het weken en als het boven 365 is dan is het in jaren
        Public Overrides Function Groei()
            doubleHoogteInMeter += 0.1 / 100
            Console.WriteLine(stringNaam & " is gegroeid, het is nu: " & doubleHoogteInMeter & " meter hoog.")
            If intLeeftijdInDagen < 30 Then
                Console.WriteLine("Plant is zo oud (in dagen): " & intLeeftijdInDagen)
            ElseIf intLeeftijdInDagen < 365 Then
                Console.WriteLine("Plant is zo oud (in weken): " & intLeeftijdInDagen / 7)
            Else
                Console.WriteLine("Plant is zo oud (in jaar): " & intLeeftijdInDagen / 365)
            End If
        End Function

        'Geeft weer dat het object aan fotosynthese doet
        Public Function Fotosynthese()
            Console.WriteLine(stringNaam & " is bezig met fotosynthese!")
        End Function

    End Class

    Public Class Boom
        'Erft over van class Plant
        Inherits Plant

        'velden
        Private stringTypeBlad As String

        'Constructor met parameters String naam, Integer leeftijd, Double hoogte en String typeblad
        Public Sub New(naam As String, leeftijd As Integer, hoogte As Double, typeblad As String)
            MyBase.New(naam, leeftijd, hoogte)
            stringTypeBlad = typeblad
        End Sub

        'Functie groei checkt als dagen boven 30 is word het weken en als het boven 365 is dan is het in jaren
        Public Overrides Function Groei() As Object
            doubleHoogteInMeter += 0.2 / 100
            Console.WriteLine(stringNaam & " is gegroeid met type blad: " & stringTypeBlad)
            Console.WriteLine("De nieuwe hoogte van de boom is: " & doubleHoogteInMeter & " meter.")
            If intLeeftijdInDagen < 30 Then
                Console.WriteLine("Boom is zo oud (in dagen): " & intLeeftijdInDagen)
            ElseIf intLeeftijdInDagen < 365 Then
                Console.WriteLine("Boom is zo oud (in weken): " & intLeeftijdInDagen / 7)
            Else
                Console.WriteLine("Boom is zo oud (in jaar): " & intLeeftijdInDagen / 365)
            End If
        End Function
    End Class

    Public Class Dier
        'Erft over van class Organisme
        Inherits Organisme

        'Velden
        Protected stringTypeGeluid As String

        'constructor met parameter String naam, Integer leeftijd en String typegeluid
        Public Sub New(naam As String, leeftijd As Integer, typegeluid As String)
            MyBase.New(naam, leeftijd)
            stringTypeGeluid = typegeluid
        End Sub

        'Functie groei checkt als dagen boven 30 is word het weken en als het boven 365 is dan is het in jaren
        Public Overrides Function Groei() As Object
            Console.WriteLine(stringNaam & " is gegroeid, op een unieke dierlijke manier.")
            If intLeeftijdInDagen < 30 Then
                Console.WriteLine("Dier is zo oud (in dagen): " & intLeeftijdInDagen)
            ElseIf intLeeftijdInDagen < 365 Then
                Console.WriteLine("Dier is zo oud (in weken): " & intLeeftijdInDagen / 7)
            Else
                Console.WriteLine("Dier is zo oud (in jaar): " & intLeeftijdInDagen / 365)
            End If
        End Function

        'geeft weer het geluid dat een dier maakt
        Public Overridable Function MaakGeluid()
            Console.WriteLine(stringNaam & " maakt dit geluid" & stringTypeGeluid)
        End Function
    End Class

    Public Class Vogel
        'Erft over van class dier
        Inherits Dier
        'Velden
        Private intSpanWijdeVleugelsInMeter As Integer

        'constructor met parameter String naam, Integer leeftijd, String typegeluid en Integer spanwijde
        Public Sub New(naam As String, leeftijd As Integer, typegeluid As String, spanwijde As Integer)
            MyBase.New(naam, leeftijd, typegeluid)
            intSpanWijdeVleugelsInMeter = spanwijde
        End Sub

        'geeft weer welke vleugelspanwijdte de vogel heeft en welk geluid hij maakt
        Public Overrides Function MaakGeluid() As Object
            Console.WriteLine(stringNaam & " met vleugelspanwijdte: " & intSpanWijdeVleugelsInMeter & " meter zingt: " & stringTypeGeluid)
        End Function
    End Class
    Sub Main()
        'Maakt object aan van Blauwekorenbloem met velden naam, leeftijd en hoogte
        Dim objBlauweKorenBloem As New Plant("Blauwe Korenbloem", 0.1, 0.05 / 100)

        'Maakt object aan van Blauwekorenbloem met velden naam, leeftijd, hoogte en bladtype
        Dim objEik As New Boom("Eik", 50 * 365, 15, "Eivormig")

        'Maakt object aan van adelaar met velden naam, leeftijd, typegeluid en vleugelspanwijdte
        Dim objAdelaar As New Vogel("Zeearend", 5 * 365, "Krijs", 2)

        objEik.Groei()
        objEik.Fotosynthese()
        Console.WriteLine("---")

        objBlauweKorenBloem.Groei()
        objBlauweKorenBloem.Fotosynthese()
        Console.WriteLine("---")

        objAdelaar.Groei()
        objAdelaar.MaakGeluid()
        Console.WriteLine("---")
    End Sub
End Module

