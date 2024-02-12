Module module1
    Sub main()


    End Sub
    Public Class Salary
        Private _basic_salary As Decimal
        Private _allowance As Decimal
        Private gross_salary As Decimal
        Private net_salary As Decimal
        Private tax_amount As Decimal

        Public Sub CaptureSalaryDetails()
            While True
                Try
                    Console.Write("Enter basic salary: ")
                    BasicSalary = Decimal.Parse(Console.ReadLine())

                    Console.Write("Enter allowance: ")
                    Allowance = Decimal.Parse(Console.ReadLine())

                    ' If we've reached this point, both inputs are valid and we can break the loop
                    Exit While
                Catch ex As ArgumentException
                    Console.WriteLine(ex.Message)
                Catch ex As FormatException
                    Console.WriteLine("Invalid input. Please enter a number.")
                End Try
            End While
        End Sub

        Public Property BasicSalary As Decimal
            Get
                Return _basic_salary
            End Get
            Set(value As Decimal)
                If value < 1000 Then
                    Throw New ArgumentException("Basic salary cannot be less than 1000.")
                Else
                    _basic_salary = value
                End If
            End Set
        End Property

        Public Property Allowance As Decimal
            Get
                Return _allowance
            End Get
            Set(value As Decimal)
                If value < 1000 Then
                    Throw New ArgumentException("Allowance cannot be less than 1000.")
                Else
                    _allowance = value
                End If
                Console.ReadKey()
            End Set
        End Property
    End Class

End Module

