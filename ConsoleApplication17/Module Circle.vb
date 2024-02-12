Module Module_Circle

   
    Private radius As Integer
    Sub main()
        getdimensions()
        print()
        Console.ReadKey()
    End Sub
    Public Sub getdimensions()
        Console.WriteLine("Enter radius")
        radius = CInt(Console.ReadLine())
    End Sub
    Private Function computeArea() As Double
        Dim area As Double
        area = Math.PI * Math.Pow(radius, 2)
        Return area
    End Function
    Private Function computeperimeter() As Double
        Dim perimeter As Double
        perimeter = Math.PI * radius * 2
        Return perimeter
    End Function

    Public Sub print()
        Console.WriteLine("Area = " & Format(computeArea(), "0.00"))
        Console.WriteLine("Perimeter = " & Format(computeperimeter(), "0.00"))
    End Sub

End Module
