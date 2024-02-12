
Module Program


    Sub Main(args As String())
        Console.WriteLine("Enter the coefficients of the quadratic equation (ax^2 + bx + c = 0):")
        Console.WriteLine("Enter the coefficient a:")
        Dim a As Double = Double.Parse(Console.ReadLine())

        Console.WriteLine("Enter the coefficient b:")
        Dim b As Double = Double.Parse(Console.ReadLine())

        Console.WriteLine("Enter the coefficient c:")
        Dim c As Double = Double.Parse(Console.ReadLine())

        Dim discriminant As Double = b * b - 4 * a * c

        If discriminant > 0 Then
            Dim root1 As Double = (-b + Math.Sqrt(discriminant)) / (2 * a)
            Dim root2 As Double = (-b - Math.Sqrt(discriminant)) / (2 * a)

            Console.WriteLine("Root 1: " & root1)
            Console.WriteLine("Root 2: " & root2)
        ElseIf discriminant = 0 Then
            Dim root As Double = -b / (2 * a)
            Console.WriteLine("The equation has a single root: " & root)
        Else
            Console.WriteLine("The equation has no real roots.")
        End If

        Console.ReadLine()
    End Sub

End Module
