Module Module1
    Public Class Veelhoek
        Protected aantalZijden As Integer
        Public Sub New(aantalZijden As Integer)
            Me.aantalZijden = aantalZijden
        End Sub
    End Class

    Public Class Vierkant
        Inherits Veelhoek

        Public Sub New()
            MyBase.New(4)
        End Sub

    End Class

    Sub Main()

    End Sub

End Module
