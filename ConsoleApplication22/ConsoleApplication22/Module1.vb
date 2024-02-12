Module Module1

    Sub Main()
        Dim digit As Integer

        Console.WriteLine("Enter a digit between 1 and 7")
        digit = CInt(Console.ReadLine())
        Select Case digit
            Case 1
                Console.WriteLine("Monday")
            Case 2
                Console.WriteLine("Tuesday")
            Case 3
                Console.WriteLine("Wednesday")
            Case 4
                Console.WriteLine("Thursday")
            Case 5
                Console.WriteLine("Friday")
            Case 6
                Console.WriteLine("Saturday")
            Case 7
                Console.WriteLine("Sunday")
            Case Else
                Console.WriteLine("Invalid input")
        End Select
        Console.ReadKey()
    End Sub
 End Module