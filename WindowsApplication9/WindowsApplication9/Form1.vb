Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim result As Integer
        result = addFunction(TextBox1.Text, TextBox2.Text)
        MessageBox.Show("the result is :" & result)
    End Sub

    Private Function addFunction(ByVal a As Integer, ByVal b As Integer) As Integer
        Dim sum As Integer
        sum = a + b
        Return sum


    End Function

    Private Sub add(ByVal a As Integer, ByVal b As Integer)
       
        Dim sum As Integer
        sum = a + b

        MessageBox.Show("the sum of two no.is:" & sum)

    End Sub
End Class
