Module Module1
    Sub Main()
        Dim weightInPounds As Double
        Dim weightInKilograms As Double
        Dim heightInInches As Double
        Dim heightInMeters As Double
        Dim BMI As Double

        Console.Write("Enter weight in pounds: ")
        weightInPounds = CDbl(Console.ReadLine())
        weightInKilograms = weightInPounds * 0.45359237

        Console.Write("Enter height in inches: ")
        heightInInches = CDbl(Console.ReadLine())
        heightInMeters = heightInInches * 0.0254

        BMI = weightInKilograms / (heightInMeters * heightInMeters)

        Select Case BMI
            Case Is < 18.5
                Console.WriteLine("Underweight")
            Case 18.5 To 24.9999
                Console.WriteLine("Normal")
            Case 25 To 29.9999
                Console.WriteLine("Overweight")
            Case Else
                Console.WriteLine("Obese")
        End Select

        Console.ReadKey()
    End Sub
End Module