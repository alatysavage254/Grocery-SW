Module Module1

    Sub Main()
        Dim day(4) As String
        Dim readings(4, 2) As Double
        Dim r, c As Integer
        Dim total, average As Double
        For r = LBound(readings, 1) To UBound(readings, 1) Step 1
            Console.WriteLine("Enter the day of the week")
            day(r) = Console.ReadLine
            For c = LBound(readings, 2) To UBound(readings, 2) Step 1
                If (c = 0) Then
                    Console.WriteLine("Enter " & day(r) & "'s morning reading")
                    readings(r, c) = CDbl(Console.ReadLine())
                ElseIf (c = 1) Then
                    Console.WriteLine("Enter " & day(r) & "'s midday reading")
                    readings(r, c) = CDbl(Console.ReadLine())
                ElseIf (c = 2) Then
                    Console.WriteLine("Enter " & day(r) & "'s evening reading")
                    readings(r, c) = CDbl(Console.ReadLine())



                End If
            Next
        Next
        For r = LBound(readings, 1) To UBound(readings, 1) Step 1
            Console.Write(day(r) & vbTab)
            For c = LBound(readings, 2) To UBound(readings, 2) Step 1
                Console.Write(readings(r, c) & vbTab)
                total = total + readings(r, c)

            Next
            average = total / readings.GetLength(1)
            Console.Write(Format(average, "0.00") & vbTab)
            Console.WriteLine()


        Next
        Console.ReadKey()
    End Sub

End Module