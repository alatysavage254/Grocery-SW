Public Class Circle
    Inherits Shape
    Private radius As Integer
    Public Sub getdimensions()
        Console.WriteLine("Enter the radius: ")
        radius = CInt(Console.ReadLine())


    End Sub
    Public Sub computearea()
        area = Math.PI * Math.Pow(radius, 2)
    End Sub

    Public Sub computeperimeter()
        perimeter = Math.PI * radius * 2

    End Sub


End Class
