Module Module1

    Sub Main()
        Dim costs() As Integer = {500, 100, 300, 900, 650, 980, 450, 800, 432, 200}
        Dim sum As Integer = 0
        Dim minCost As Integer = costs(0)
        Dim maxCost As Integer = costs(0)
        Dim overchargedCount As Integer = 0
        Dim maxAllowedCost As Integer = 500

        For Each cost As Integer In costs
            sum += cost
            If cost < minCost Then
                minCost = cost
            End If
            If cost > maxCost Then
                maxCost = cost
            End If
            If cost > maxAllowedCost Then
                overchargedCount += 1
            End If
        Next

        Dim averageCost As Double = sum / costs.Length

        Console.WriteLine("Average cost: " & averageCost)
        Console.WriteLine("Cheapest item: " & minCost)
        Console.WriteLine("Most expensive item: " & maxCost)
        Console.WriteLine("Number of overcharged items: " & overchargedCount)

        Console.ReadKey()

    End Sub

End Module
