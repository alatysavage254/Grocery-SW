Option Strict Off

Module Module1

    Sub Main()
        ' Uncommenting the next line would result in a compilation error when Option Strict is On.
        Dim result As Integer = "10"

        Dim number As Integer = 10
        Dim text As String = "20"

        ' Uncommenting the next line would result in a compilation error when Option Strict is On.
        ' Dim sum As Integer = number + text 

        ' Explicitly converting the string to an integer to avoid compilation error.
        Dim sum As Integer = number + CInt(text)

        Console.WriteLine("Sum: " & sum)
        Console.ReadKey()
    End Sub

End Module
