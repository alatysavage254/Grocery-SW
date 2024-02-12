
Module Module1

    Sub Main()
        Dim letter As String
        Console.WriteLine("enter a letter:")
        letter = Console.ReadLine().ToUpper
        Select Case letter
            Case "A", "E", "I", "O", "U"
                Console.WriteLine("is a vowel")
            Case Else
                Console.WriteLine("is not a vowel")
        End Select
        Console.ReadKey()














    End Sub

End Module
