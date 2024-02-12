Module Module1
    Sub Main()
        Dim patient As New Patient()

        patient.CaptureDetails()
        patient.ComputeBMI()
        patient.DisplayDetails()

        Console.WriteLine("BMI Interpretation: " & patient.GetBMIInterpretation())
        Console.WriteLine("Age: " & patient.ComputeAge())

        Console.ReadKey()
    End Sub
End Module