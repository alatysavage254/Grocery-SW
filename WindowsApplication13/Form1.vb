Public Class Form1

    Private saving, months, annualrate As Integer

    Public Sub input()
        saving = CInt(txtsaving.Text)
        months = CInt(txtmonths.Text)
        annualrate = CInt(txtrate.Text)
    End Sub

    Public Function compute() As Double
        Dim amount As Double = 0.0
        Dim i As Integer
        Dim monthlyrate As Double
        monthlyrate = (annualrate / 12) / 100



        For i = 1 To months Step 1
            amount = (amount + saving) * (1 + monthlyrate)
        Next
        Return amount


    End Function

    Public Sub output()
        lbloutput.Text = Format(compute(), "0.00")

    End Sub



    Private Sub btncompute_Click(sender As Object, e As EventArgs) Handles btncompute.Click
        input()
        output()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
