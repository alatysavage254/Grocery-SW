Imports MySql.Data.MySqlClient
Public Class Form1


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim MySqlConnection As New SqlClient.SqlConnection

        Try
            MySqlConnection.Open()
            MessageBox.Show("successfully connected to the database")

        Catch ex As Exception
            MessageBox.Show(ex.Message & "try again")

        End Try
    End Sub
End Class
