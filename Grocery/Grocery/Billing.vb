Imports System.Data.SqlClient

Public Class Billing
    Private Sub AddBill()
        Try
            Con.Open()
            Dim query = "insert into BillTbl values('" & ClNameTb.Text & "'," & GrdTotal & ", ' " & DateTime.Today.Date & " ')"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Bill saved successfully")
            Con.Close()
            TotalLbl.Text = "Total"
            BillDVG.Rows.Clear()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub UpdateItem()
        Dim newQty = Stock - Convert.ToInt32(QtyTb.Text)
        Try
            Con.Open()
            Dim query = "Update ItemTbl set ItQty =" & newQty & " where ItId " & key & ""
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Item Updated successfully")
            Con.Close()
            DisplayItem()


        Catch ex As Exception

        End Try
    End Sub
    Dim i = 0, GrdTotal = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If PriceTb.Text = "" Or QtyTb.Text = "" Then
            MsgBox("Enter the Quantity")
        ElseIf ItNameTb.Text = "" Then
            MsgBox("Select The Item")
        Else
            Dim rnum As Integer = BillDVG.Rows.Add()
            i = i + 1
            Dim total = Convert.ToInt32(QtyTb.Text) * Convert.ToInt32(PriceTb.Text)
            BillDVG.Rows.Item(rnum).Cells("Column1").Value = i
            BillDVG.Rows.Item(rnum).Cells("Column2").Value = ItNameTb.Text
            BillDVG.Rows.Item(rnum).Cells("Column3").Value = PriceTb.Text
            BillDVG.Rows.Item(rnum).Cells("Column4").Value = total
            GrdTotal = GrdTotal + total
            Dim tot As String
            tot = "Rs" + Convert.ToString(GrdTotal)
            TotalLbl.Text = tot
            UpdateItem()
            DisplayItem()
            Reset()



        End If
    End Sub
    Dim Con = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\toory\Documents\GroceryDb.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub DisplayItem()
        'Con.Open()
        Dim query = "select * from ItemTbl"
        Dim cmd = New SqlCommand(query, Con)
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(cmd)
        Dim builder As New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        ItemDGV.DataSource = ds.Tables(0)
        Con.Close()


    End Sub

    Private Sub Billing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayItem()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Application.Exit()
    End Sub

    Private Sub ItemDGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ItemDGV.CellContentClick

    End Sub
    Dim key = 0, Stock = 0
    Private Sub Reset()
        ItNameTb.Text = ""
        PriceTb.Text = ""
        QtyTb.Text = ""
        'TotalLbl.Text = "Total"
        key = 0
        Stock = 0


    End Sub
    Private Sub ItemDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles ItemDGV.CellMouseClick
        Dim row As DataGridViewRow = ItemDGV.Rows(e.RowIndex)
        ItNameTb.Text = row.Cells(1).Value.ToString

        PriceTb.Text = row.Cells(3).Value.ToString

        If ItNameTb.Text = "" Then
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
            Stock = Convert.ToInt32(row.Cells(2).Value.ToString)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Reset()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If ClNameTb.Text = "" Then
            MsgBox("Enter Client Name")
        Else
            AddBill()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim Obj = New Login
        Obj.Show()
        Me.Hide()



    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        TotalLbl.Text = "Total"
        BillDVG.Rows.Clear()
    End Sub
End Class