Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim a, b, c As Integer
        a = CInt(txtno1.Text)
        b = CInt(txtno2.Text)



        c = a + b

        lbloutput.Text = "The sum of " & a & " and " & b & " = " & c & ""
    End Sub
End Class
