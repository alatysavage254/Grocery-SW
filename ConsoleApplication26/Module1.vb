Module Module1

    Sub Main()
        Dim rect1 As Rectangle = New Rectangle()
        Dim rect2 As Rectangle = New Rectangle(10, 15)

        rect1.getdimensions()
        rect1.print()
        rect2.print()
      
        Console.ReadKey()

    End Sub

End Module
