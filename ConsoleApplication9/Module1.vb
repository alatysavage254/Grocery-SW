'Module Module1

    'Sub Main()
    'Dim unit As New unit("SCT121-006", 1, "COMPUTER SCIENCE", "programming", 14, 5, 23)
    'unit.captureDetails()
    'unit.DisplayDetails()

    'Console.ReadKey()

    'End Sub

'End Module
Module Module1
    Sub Main()
        Dim students() As Unit = {
            New Unit("SCT121-006", 1, "Computer Science", "Programming", 14, 5, 23),
            New Unit("SCT121-007", 2, "Mathematics", "Calculus", 18, 6, 36),
            New Unit("SCT121-008", 3, "Physics", "Mechanics", 21, 4, 41)
        }

        For Each student In students
            student.CaptureDetails()
            student.DisplayDetails()
            Console.WriteLine("Grade: " & student.ComputeGrade())
            Console.WriteLine()
        Next

        Console.ReadKey()
    End Sub
End Module
