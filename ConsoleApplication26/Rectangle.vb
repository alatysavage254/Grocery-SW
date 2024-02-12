Public Class Rectangle

    Private rlength, rwidth As Double
    Public Sub New()
        rlength = 5
        rwidth = 2


    End Sub
    Public Property Prolength
        Get
            Return rlength
        End Get
        Set(value)


            If value <= 0 Then
                Console.WriteLine("length can't be negative")
                rlength = 1
            Else
                rlength = value

            End If


        End Set
    End Property

    Public Property Prowidth
        Get
            Return rwidth

        End Get
        Set(value)
            rwidth = value
            If value <= 0 Then
                Console.WriteLine("width can't be negative")
                rwidth = 1
            Else
                rwidth = value
            End If

        End Set
    End Property
    Public Sub New(ByVal a As Double, ByVal b As Double)
        rlength = a
        rwidth = b

    End Sub

    Public Sub getdimensions()
        Console.WriteLine("Enter length")
        Prolength = CDbl(Console.ReadLine())

        Console.WriteLine("Enter width")
        Prowidth = CDbl(Console.ReadLine())




    End Sub
    Public Function computeArea() As Double
        Dim area As Double
        area = Prowidth * Prolength
        Return area


    End Function
    Public Sub print()
        Console.WriteLine("area = " & computeArea())

    End Sub

End Class
