Module Module1

    Sub Main()
        Dim radius As Integer
        Dim area As Integer
        Dim perimeter As Integer
        Console.WriteLine("Enter the value of radius")
        radius = CInt(Console.ReadLine())
        area = Math.PI * Math.Pow(radius, 2)
        perimeter = Math.PI * radius * 2
        Console.WriteLine("Area=" & area & "perimeter=" & perimeter)
        Console.ReadKey()

    End Sub

End Module
