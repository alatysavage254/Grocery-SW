Module Module1
    Sub Main()
        Console.WriteLine("Enter your name")
        Dim name As String = Console.ReadLine()
        Dim y = 123456.98
        Console.WriteLine("I " & name & " just wanted to know the type of y")
        Console.WriteLine(y.GetType())

        Console.ReadKey()
    End Sub
End Module