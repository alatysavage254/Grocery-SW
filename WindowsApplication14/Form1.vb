Public Class Form1

    Private Sub Form_Load()
        FillList()


    End Sub
    Private Sub FillList()
        Dim dWorkDate As Date = Now()
        Dim myListBox As ListBox = Me.ListBox1
        While dWorkDate < Date.Today
            myListBox.Items.Add(dWorkDate.ToString("dd.MM.yyyy"))
            dWorkDate = dWorkDate.AddDays(1)
        End While
    End Sub

    Private Sub DisplayDetails(buyingPrice As Double, transportCost As Double, sellingPrice As Double, paymentMode As String, profitOrLoss As String)
        Throw New NotImplementedException
    End Sub




End Class

