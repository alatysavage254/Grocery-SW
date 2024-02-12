Module Module1

    Sub Main()
        Dim proceed As Boolean = True
        Dim a, b, output As Integer
        Do
            Try
                Console.WriteLine("enter the 1st value: ")
                a = CInt(Console.ReadLine())
                Console.WriteLine("enter the 2nd value: ")
                b = CInt(Console.ReadLine())


                output = a \ b

                Console.WriteLine("output =  " & output)
                proceed = False
            Catch ex As SystemException
                Console.WriteLine(ex.Message)
                ' Catch ex1 As SystemException
                ' Console.WriteLine(ex1.Message)
                '  Catch ex2 As systemException
                'console


            Finally
                Console.WriteLine("we wanted to divide two numbers")

            End Try
        Loop While (proceed = True)
        Console.ReadKey()

    End Sub

End Module
