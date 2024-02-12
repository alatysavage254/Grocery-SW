Module Module1

    Sub Main()
        Dim i As Integer
        Dim y() As Integer = {24, 29, 30}

        Console.Write("content in array before resizing")
        For i = LBound(y) To UBound(y) Step 1
            Console.Write(y(i) & vbTab)
        Next
        ReDim Preserve y(6)
        Console.Write(vbNewLine & "content in array after resizing")
        For i = LBound(y) To UBound(y) Step 1
            Console.Write(y(i) & vbTab)
        Next



        Console.ReadKey()
    End Sub

End Module