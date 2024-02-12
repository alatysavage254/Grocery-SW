Module Module1

    Sub Main()
        ' Using do-while loop
        Dim i As Integer = 1
        Do While i <= 5
            Dim j As Integer = 1
            Do While j <= 5
                If i = 2 And j = 3 Then
                    Console.Write("*")
                ElseIf i = 3 And j = 2 Then
                    Console.Write("*")
                ElseIf i = 3 And j = 4 Then
                    Console.Write("*")
                ElseIf i = 4 And j = 2 Then
                    Console.Write("*")
                ElseIf i = 4 And j = 3 Then
                    Console.Write(" ")
                Else
                    Console.Write("&")
                End If
                j += 1
            Loop
            Console.WriteLine()
            i += 1
        Loop

        Console.WriteLine()

        Console.ReadKey()
    End Sub

End Module