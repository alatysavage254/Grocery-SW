Module Module1

    Sub Main()

        Dim j, i As Integer

        j = 1
        Do
            i = 1
            Do
                Console.Write(i & vbTab)
                i = i + 1

            Loop While (i <= 5)
            Console.WriteLine()
            j = j + 1
        Loop While (j <= 5)
        Console.ReadKey()

    End Sub
End Module

  
