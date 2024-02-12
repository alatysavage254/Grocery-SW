Public Class Form1





    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        MsgBox("welcome")
        MsgBox("to")
        MsgBox("VB.NET")
        MsgBox("programming")
        MsgBox("course")


        MessageBox.Show("this is another message")



    End Sub

    Private Sub btnVariables_Click(sender As Object, e As EventArgs) Handles btnVariables.Click

        Dim stFirstname As String
        Dim stLastname As String

        stFirstname = "alaty"
        stLastname = "savage"

        MsgBox("hello and welcome " & stFirstname & " " & stLastname & "i hope you are well")

        stFirstname = "ace"
        stLastname = "hood"

        MsgBox("hello and welcome " & stFirstname & " " & stLastname & "i hope you are well")

    End Sub

    Private Sub btnDataTypes_Click(sender As Object, e As EventArgs) Handles btnDataTypes.Click
        Dim stMake As String
        Dim stModel As String
        Dim iDoors As Integer
        Dim stcolour As String
        Dim bTaxed As Boolean
        Dim iEnginesize As Integer
        Dim decPrice As Decimal
        Dim dtdateregistered As Date

        stmake = "subaru"
        stmodel = "escort"
        iDoors = 5
        stColour = "red"
        bTaxed = True
        iEnginesize = 1200
        decPrice = 999.99
        dtdateregistered = #5/23/2023#


        MsgBox("the car is  " & stMake & vbNewLine & stModel & vbNewLine & _
               iDoors & vbNewLine & stcolour & vbNewLine & bTaxed & vbNewLine & _
               iEnginesize & vbNewLine & decPrice & vbNewLine & dtdateregistered)


    End Sub
End Class
