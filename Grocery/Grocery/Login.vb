Public Class Login

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles PasswordTb.TextChanged

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Application.Exit()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Dim obj = New Billing
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If UnameTb.Text = "" Or PasswordTb.Text = "" Then
            MsgBox("Enter userName and Password")
        ElseIf UnameTb.Text = "Admin" And PasswordTb.Text = "password" Then
            Dim obj = New Items
            obj.Show()
            Me.Hide()
        Else
            MsgBox("Wrong UserName or Password")
            UnameTb.Text = ""
            PasswordTb.Text = ""


        End If
    End Sub

    Private Sub UnameTb_TextChanged(sender As Object, e As EventArgs) Handles UnameTb.TextChanged

    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class