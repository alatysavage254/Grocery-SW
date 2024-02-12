Public Class Shape
    Protected area, perimeter As Double

    Public Overridable Sub print()
        Console.WriteLine("Area=" & area)
        Console.WriteLine("parameter=" & perimeter)
    End Sub

End Class
