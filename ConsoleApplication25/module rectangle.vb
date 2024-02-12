Module module_rectangle
    Private rlength, rwidth As Double

    Public Sub getdimensions()
        Console.WriteLine("Enter length")
        rlength = CDbl(Console.ReadLine())

        Console.WriteLine("Enter width")
        rwidth = CDbl(Console.ReadLine())


    End Sub
    Public Function computeArea() As Double
        Dim area As Double
        area = rwidth * rlength
        Return area


    End Function
    Public Sub print()
        Console.WriteLine("area = " & computeArea())

    End Sub

End Module
