Module Module1
    Sub Main()
        ' i) Declare arrays
        Dim names(4) As String
        Dim marks(4) As Integer

        ' ii) Capture names and marks
        For i As Integer = 0 To 4
            Console.Write("Enter name for candidate " & (i + 1) & ": ")
            names(i) = Console.ReadLine()
            Console.Write("Enter mark for candidate " & (i + 1) & ": ")
            marks(i) = CInt(Console.ReadLine())
        Next

        ' iii) Increase size of arrays
        ReDim Preserve names(8)
        ReDim Preserve marks(8)

        ' iv) Capture names and marks of additional candidates
        For i As Integer = 5 To 8
            Console.Write("Enter name for candidate " & (i + 1) & ": ")
            names(i) = Console.ReadLine()
            Console.Write("Enter mark for candidate " & (i + 1) & ": ")
            marks(i) = CInt(Console.ReadLine())
        Next

        ' v) Display details
        Console.WriteLine()
        Console.WriteLine("Candidate Details:")
        For i As Integer = 0 To 8
            Console.WriteLine("Name: " & names(i) & ", Mark: " & marks(i))
        Next


        Console.ReadKey()
    End Sub
End Module