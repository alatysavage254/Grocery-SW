Module Module1

    Sub Main()

        Dim temperatures(6, 3) As Double

        ' Capture temperature readings
        For patient As Integer = 0 To 6
            For reading As Integer = 0 To 3
                Console.Write("Enter temperature for patient {0}, reading {1}: ", patient + 1, reading + 1)
                temperatures(patient, reading) = Double.Parse(Console.ReadLine())
            Next
        Next

        ' Display temperature readings
        For patient As Integer = 0 To 6
            Console.WriteLine("Temperatures for patient {0}:", patient + 1)
            For reading As Integer = 0 To 3
                Console.WriteLine("Reading {0}: {1}", reading + 1, temperatures(patient, reading))
            Next
            Console.WriteLine()
        Next
        Console.ReadKey()
   

    End Sub

End Module
