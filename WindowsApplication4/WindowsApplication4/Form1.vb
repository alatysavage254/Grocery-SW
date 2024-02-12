Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("welcome")
        MsgBox("to")
        MsgBox("the")
        MsgBox("VB.NET")
        MsgBox("programming")
        MsgBox("course")

        MessageBox.Show("This is another message")
    End Sub





    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click

        Dim stFirstname As String
        Dim stLastname As String

        stFirstname = "alaty"
        stLastname = "savage"

        MsgBox("hello and welcome " & stFirstname & " " stLastname & "i hope you are well")





        stFirstname = "alaty"
        stLastname = "savage"

        MsgBox("hello and welcome " & stFirstname & " " stlastname & "i hope you are well")







    End Sub

    Private Sub btnVariables_Click(sender As Object, e As EventArgs) Handles btnVariables.Click

    End Sub
End Class
