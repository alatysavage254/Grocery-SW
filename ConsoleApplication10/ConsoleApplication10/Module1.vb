Module Module1
    Sub Main()
        Dim regno() As String = New String() {"SCT121-006", "SCT121-007", "SCT121-008"}
        Dim marks(,) As Integer = New Integer(,) {{14, 5, 23}, {18, 6, 36}, {21, 4, 41}}
        Dim row, col As Integer
        Dim avg As Integer
        Dim grade As Char


        ' For row = LBound(marks, 1) To UBound(marks, 1) Step 1
        'Console.Write(regno(row) & vbTab)
        ' avg = 0
        ' For col = LBound(marks, 2) To UBound(marks, 2) Step 1
        'Console.Write(marks(row, col) & vbTab)
        ' avg = avg + marks(row, col)


        For row = LBound(marks, 1) To UBound(marks, 1) Step 1
            Console.WriteLine(String.Format("Enter the registration number of student {0}:", row + 1))
            regno(row) = Console.ReadLine()
            avg = 0
            For col = LBound(marks, 2) To UBound(marks, 2) Step 1
                Console.WriteLine("Enter a mark: ")
                marks(row, col) = CInt(Console.ReadLine())
                avg += marks(row, col)
            Next
            avg /= 3 ' Calculate average

            Console.WriteLine("Average: " & avg)

            If (avg <= 39) Then
                grade = "E"
            ElseIf (avg <= 49) Then
                grade = "D"
            ElseIf (avg <= 59) Then
                grade = "C"
            ElseIf (avg <= 69) Then
                grade = "B"
            Else
                grade = "A"
            End If

            Console.WriteLine("Grade: " & grade)
            Console.WriteLine()
        Next

        Console.ReadKey()
    End Sub
End Module