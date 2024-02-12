Module Module1

   


    Sub Main()

        Dim temp() As Single = {32.3, 38.3, 36.2, 35.2, 39.1, 37.4, 35.6}
        Dim i As Integer
        Dim sum As Single = 0
        Dim average As Double
        Dim abn As Integer
        abn = 0
        For i = LBound(temp) To UBound(temp) Step 1
            sum = sum + temp(i)
        Next
        average = sum / temp.Length
        Console.WriteLine("Average body temperature =" & Format(average, "0.0"))
        For i = LBound(temp) To UBound(temp) Step 1

            If (temp(i) < 34.0 Or temp(i) > 37.5) Then
                abn = abn + 1
            End If
        Next

        Console.WriteLine("Abnormal temperature =" & abn)





        Console.ReadKey()





    End Sub

End Module
