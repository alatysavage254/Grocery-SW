Module Module1

    Sub Main()
      
            Dim cost() As Double = {220.0, 145.0, 125.0, 10.0, 768.0, 27.0, 100.0}
            Dim sum As Double
            Dim i As Integer
            Dim cheapest As Double = Double.MaxValue
            Dim expensive As Double = Double.MinValue
            Dim average As Double
            Dim overchargedItems As Integer = 0

            For i = LBound(cost) To UBound(cost)
                Console.WriteLine("Enter the cost of item:" & (i + 1))
                cost(i) = CDbl(Console.ReadLine())
                sum += cost(i)
                If (cost(i) < cheapest) Then
                    cheapest = cost(i)
                End If

                If cost(i) > expensive Then
                    expensive = cost(i)
                End If

                If cost(i) > 500 Then
                    overchargedItems += 1
                End If
            Next

            average = sum / cost.Length

            Array.Sort(cost)
            Console.WriteLine("Sorted items")
            For i = LBound(cost) To UBound(cost)
                Console.Write(cost(i) & vbTab)
            Next

            Console.WriteLine("Total cost=" & sum)
            Console.WriteLine("Cheapest item=" & cheapest)
            Console.WriteLine("Most expensive item=" & expensive)
            Console.WriteLine("Average cost=" & average)
            Console.WriteLine("Number of overcharged items=" & overchargedItems)
        Console.ReadKey()

        End Sub

    End Module
 
