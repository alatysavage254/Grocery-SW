Module Module1

    Sub Main()
        Dim a, b As Integer
        Console.WriteLine("Enter the value of a")
        a = CInt(Console.ReadLine())
        Console.WriteLine("Enter the value of b")
        b = (Console.ReadLine())
        Console.WriteLine("Before interchanging a = " & a & " b = " & b)
        interchange(a, b)
        Console.WriteLine("After interchanging a = " & a & " b = " & b)
        Console.ReadKey()








    End Sub
    Sub interchange(ByRef x As Integer, ByRef y As Integer)
        Dim temp As Integer
        temp = x
        x = y
        y = temp
    End Sub



End Module
