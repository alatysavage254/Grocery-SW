Public Class unit
    Inherits student

    Private cat As Integer
    Private assignment As Integer
    Private exam As Integer
    Private avg As Integer

    Public Sub New(regNo As String, yearsOfStudy As Integer, courseTaken As String, unitExamined As String, cat As Integer, assignment As Integer, exam As Integer)
        MyBase.New(regNo, yearsOfStudy, courseTaken, unitExamined)
        Me.cat = cat
        Me.assignment = assignment
        Me.exam = exam
    End Sub

    Public Overrides Sub captureDetails()
        MyBase.captureDetails()

        Console.Write("enter cat marks: ")
        cat = CInt(Console.ReadLine())

        Console.Write("enter assignment marks: ")
        assignment = CInt(Console.ReadLine())

        Console.Write("enter exam marks: ")
        exam = CInt(Console.ReadLine())

    End Sub
    Public Function computeGrade() As Char
        Dim total As Integer = cat + assignment + exam
        Dim avg As Integer = total
        If avg <= 39 Then
            Return "E"
        ElseIf avg <= 49 Then
            Return "D"
        ElseIf avg <= 59 Then
            Return "C"
        ElseIf avg <= 69 Then
            Return "B"
        Else
            Return "A"
        End If
    End Function

    Public Overrides Sub DisplayDetails()
        MyBase.DisplayDetails()

        Console.WriteLine("cat marks: " & cat)
        Console.WriteLine("assignment marks: " & assignment)
        Console.WriteLine("exam marks: " & exam)
        Console.WriteLine("grade: " & computeGrade())
        Console.WriteLine("average: " & avg)
    End Sub

End Class
