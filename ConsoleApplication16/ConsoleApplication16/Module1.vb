Module Module1

    Sub Main()
        Dim num, fdigit, rem1, sdigit, rem2, hdigit, ldigit, sum As Integer
        Console.WriteLine("enter a four digit integer")
        num = CInt(Console.ReadLine())
        fdigit = num \ 1000
        rem1 = num Mod 1000
        sdigit = rem1 \ 100
        rem2 = rem1 Mod 100
        hdigit = rem2 \ 10
        ldigit = rem2 Mod 10
        sum = fdigit + sdigit + hdigit + ldigit
        Console.WriteLine("the sum of digits in " & num & " = " & sum)
        Console.ReadKey()
    End Sub

End Module

'Module Module1
'Sub Main()
'Dim num, fdigit, rem1, sdigit, rem2, hdigit, ldigit, sum As Integer
'   Console.WriteLine("enter a four digit integer")
'  num = CInt(Console.ReadLine())
' fdigit = num \ 1000
'rem1 = num Mod 1000
'sdigit = rem1 \ 100
'rem2 = rem1 Mod 100
'hdigit = rem2 \ 10
'ldigit = rem2 Mod 10
'sum = fdigit + sdigit + hdigit + ldigit
'Console.WriteLine("the sum of digits in " & num & " = " & sum)
'Console.ReadKey()
'End Sub
'End Module
