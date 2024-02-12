Public Class Patient
    Inherits Person_class

    Private patientId As String
    Private bmi As Decimal

    Public Overrides Sub CaptureDetails()
        MyBase.CaptureDetails()

        Console.Write("Enter patient ID: ")
        patientId = Console.ReadLine()
    End Sub

    Public Sub ComputeBMI()
        ' Convert height from cm to m
        Dim heightInMeters As Decimal = height / 100
        bmi = weight / (heightInMeters * heightInMeters)
    End Sub

    Public Function GetBMIInterpretation() As String
        ComputeBMI()

        If bmi < 18.5 Then
            Return "Underweight"
        ElseIf bmi < 24.9 Then
            Return "Normal weight"
        ElseIf bmi < 29.9 Then
            Return "Overweight"
        Else
            Return "Obesity"
        End If
    End Function

    Public Function ComputeAge() As Integer
        Dim today As Date = Date.Today
        Dim age As Integer = today.Year - dob.Year

        If (dob > today.AddYears(-age)) Then
            age -= 1
        End If

        Return age
    End Function

    Public Overrides Sub DisplayDetails()
        MyBase.DisplayDetails()

        Console.WriteLine("Patient ID: " & patientId)
        Console.WriteLine("BMI: " & bmi)
        Console.WriteLine("BMI Interpretation: " & GetBMIInterpretation())
        Console.WriteLine("Age: " & ComputeAge())
    End Sub
End Class