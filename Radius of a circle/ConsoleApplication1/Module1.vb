Module Module1
    Private radius As Double
    Sub main()
        Dim area, circumference As Double

        Console.WriteLine("enter the radius:")
        radius = CInt(Console.ReadLine())

        area = Math.PI * Math.Pow(radius, 2)
        circumference = Math.PI * radius * 2

        Console.WriteLine("The area = " & area & ", circumfence = " & circumference)
        Console.ReadLine()
    End Sub
End Module