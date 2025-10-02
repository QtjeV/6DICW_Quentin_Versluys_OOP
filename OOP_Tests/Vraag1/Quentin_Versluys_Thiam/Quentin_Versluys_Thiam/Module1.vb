Module Module1
    Public Class Atleet
        'velden
        Public geboorteplaats As String
        Public lengteInCm As Integer
        Public gewichtInKg As Integer
        'constructor
        Public Sub New(geboorteplaats As String, lengteInCm As Integer, gewichtInKg As Integer)
            Me.geboorteplaats = geboorteplaats
            Me.lengteInCm = lengteInCm
            Me.gewichtInKg = gewichtInKg
        End Sub

        'Geef thiams geboorteplaats weer
        Public Function getgeboorteplaats()
            Return "Thiam is geboren in : " & geboorteplaats
        End Function
        'geeft thiams lengte weer
        Public Function getlengteInCm()
            Return "Thiam haar lengte (in Cm) is : " & lengteInCm
        End Function
        'Geeft thiams gewicht weer
        Public Function getgewichtInKg()
            Return "Thiam haar gewicht (in Kg) is : " & gewichtInKg
        End Function
    End Class
    Sub Main()
        Dim objThiam As New Atleet("Gent", 180, 77)
        'geeft geboorteplaats, lengte en gewicht van Thiam weer
        Console.WriteLine("---")
        Console.WriteLine(objThiam.getgeboorteplaats())
        Console.WriteLine(objThiam.getlengteInCm())
        Console.WriteLine(objThiam.getgewichtInKg())
        Console.WriteLine("---")
    End Sub

End Module
