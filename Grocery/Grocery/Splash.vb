Public Class Splash
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Myprogress.Increment(1)
        Dim Percentage As String
        Percentage = CStr(Myprogress.Value)



        LoadingLbl.Text = Percentage + "%"
        If Myprogress.Value = 100 Then
            Me.Hide()
            Dim log = New Login
            log.Show()
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub



    Private Sub GROCERY_Click(sender As Object, e As EventArgs) Handles GROCERY.Click

    End Sub

    Private Sub Myprogress_Click(sender As Object, e As EventArgs) Handles Myprogress.Click

    End Sub

    Private Sub LoadingLbl_Click(sender As Object, e As EventArgs) Handles LoadingLbl.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
