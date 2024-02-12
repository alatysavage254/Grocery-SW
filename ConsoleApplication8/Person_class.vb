Public Class Person_class
    Protected name As String
    Protected dob As Date
    Protected weight As Decimal
    Protected height As Decimal
    Protected gender As String

    Public Overridable Sub captureDetails()
        Console.Write("Enter name: ")
        name = Console.ReadLine

        Console.Write("enter date of birth (yyyy/mm/dd): ")
        dob = CDate(Console.ReadLine())

        Console.Write("enter weight (in kg): ")
        weight = CDec(Console.ReadLine())

        Console.Write("enter height (in cm): ")
        height = CDec(Console.ReadLine())

        Console.Write("enter gender (M/F): ")
        gender = Console.ReadLine()

    End Sub

    Public Overridable Sub DisplayDetails()
        Console.WriteLine("Name :" & name)
        Console.WriteLine("Date of birth: " & dob.ToString("yyyy/MM/dd"))
        Console.WriteLine("weight: " & weight & " kg")
        Console.WriteLine("height: " & height & " cm")
        Console.WriteLine("Gender: " & gender)

    End Sub
End Class
