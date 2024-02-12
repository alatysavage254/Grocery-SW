
Module Module1

    Sub Main()
        Dim x, y As Integer
        Dim d As Double

        Console.WriteLine("Enter the x coordinate of a point")
        x = CInt(Console.ReadLine())
        Console.WriteLine("enter the y cordinate of a point")
        y = CInt(Console.ReadLine())
        d = Math.Sqrt(Math.Pow((x - 0), 2) + Math.Pow((y - 0), 2))
        If (d <= 10) Then
            Console.WriteLine("The point (" & x & "," & y & ") is within the circle")
        Else
            Console.WriteLine("The point (" & x & "," & y & ") is not within the circle")
        End If
        Console.ReadKey()







    End Sub

End Module
