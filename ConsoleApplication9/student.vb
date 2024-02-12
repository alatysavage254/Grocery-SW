Public Class student
    Protected regNo As String
    Protected yearsOfStudy As Integer
    Protected courseTaken As String
    Protected unitExamined As String
    Protected avg As Integer

    Public Sub New(regNo As String, yearsOfstudy As Integer, courseTaken As String, unitExamined As String)
        Me.regNo = regNo
        Me.yearsOfStudy = yearsOfstudy
        Me.unitExamined = unitExamined
    End Sub

    Public Overridable Sub captureDetails()
        Console.Write("Enter reg num: ")
        regNo = Console.ReadLine()

        Console.Write("enter year of study: ")
        yearsOfStudy = CInt(Console.ReadLine())

        Console.Write("enter course taken: ")
        courseTaken = Console.ReadLine()

        Console.Write("enter unit examined: ")
        unitExamined = Console.ReadLine()

    End Sub

    Public Overridable Sub DisplayDetails()
        Console.WriteLine("Registration Number: " & regNo)
        Console.WriteLine("Year of Study: " & yearsOfStudy)
        Console.WriteLine("Course Taken: " & courseTaken)
        Console.WriteLine("Unit Examined: " & unitExamined)
        Console.WriteLine("average: " & avg)

    End Sub


End Class



