Module Module1

    Sub Main()
        Dim grade As String
        Dim tcats, tassign, exam As Integer
        Dim regno() As String = {"sct121-0607/2021", "sct121-0002/2021", "sct121-0003/2021"}
        Dim marks(,) As Integer = {{15, 18, 12, 35, 31}, {9, 21, 4, 36, 41}, {20, 11, 10, 27, 25}}
        Dim r, c As Integer
        Dim avg As Double

        For r = LBound(marks, 1) To UBound(marks, 1) Step 1
            Console.WriteLine("enter regno for student")
            regno(r) = Console.ReadLine()
            For c = LBound(marks, 2) To UBound(marks, 2) Step 1
                If c = 0 Then
                    Console.WriteLine("enter cat1 mark")
                    marks(r, c) = CInt(Console.ReadLine())
                ElseIf c = 1 Then
                    Console.WriteLine("enter a cat2 mark")
                    marks(r, c) = CInt(Console.ReadLine())
                ElseIf c = 2 Then
                    Console.WriteLine("enter assign1 mark")
                    marks(r, c) = CInt(Console.ReadLine())
                ElseIf c = 3 Then
                    Console.WriteLine("enter assign2 mark")
                    marks(r, c) = CInt(Console.ReadLine())
                ElseIf c = 4 Then
                    Console.WriteLine("enter exam mark")
                    marks(r, c) = CInt(Console.ReadLine())
                End If

            Next




        Next
        Console.WriteLine("Registration No" & vbTab & "Cat1" & vbTab & "Cat2" & vbTab & "Assign1" & vbTab & "Assign2" & vbTab & "Exam" & vbTab & "Avg" & vbTab & "Grade")
        For r = LBound(marks, 1) To UBound(marks, 1) Step 1
            Console.Write(regno(r) & vbTab)
            tcats = 0
            tassign = 0
            For c = LBound(marks, 2) To UBound(marks, 2) Step 1
                Console.Write(marks(r, c) & vbTab)
                If c <= 1 Then
                    tcats = tcats + marks(r, c)
                ElseIf c <= 3 Then
                    tassign = tassign + marks(r, c)
                Else
                    exam = marks(r, c)
                End If
            Next
            avg = ((tcats / 70) * 30) + ((tassign / 70) * 10) + exam
            Console.Write(Format(avg, "0.00") & vbTab)
            If avg <= 39 Then
                grade = CChar("E")
            ElseIf avg <= 49 Then
                grade = CChar("D")
            ElseIf avg <= 59 Then
                grade = ("C")
            ElseIf avg <= 69 Then
                grade = ("B")
            Else
                grade = "A"



            End If
            Console.Write(grade)
            Console.WriteLine()
        Next
        Console.ReadKey()



    End Sub

End Module
