<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtBuyingPrice = New System.Windows.Forms.TextBox()
        Me.txttransportCost = New System.Windows.Forms.TextBox()
        Me.txtSellingPrice = New System.Windows.Forms.TextBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtBuyingPrice
        '
        Me.txtBuyingPrice.Location = New System.Drawing.Point(46, 24)
        Me.txtBuyingPrice.Name = "txtBuyingPrice"
        Me.txtBuyingPrice.Size = New System.Drawing.Size(100, 20)
        Me.txtBuyingPrice.TabIndex = 0
        Me.txtBuyingPrice.Text = "buyingPrice"
        '
        'txttransportCost
        '
        Me.txttransportCost.Location = New System.Drawing.Point(46, 86)
        Me.txttransportCost.Name = "txttransportCost"
        Me.txttransportCost.Size = New System.Drawing.Size(100, 20)
        Me.txttransportCost.TabIndex = 1
        Me.txttransportCost.Text = "transportCost"
        '
        'txtSellingPrice
        '
        Me.txtSellingPrice.Location = New System.Drawing.Point(46, 147)
        Me.txtSellingPrice.Name = "txtSellingPrice"
        Me.txtSellingPrice.Size = New System.Drawing.Size(100, 20)
        Me.txtSellingPrice.TabIndex = 2
        Me.txtSellingPrice.Text = "sellingPrice"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(46, 228)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(57, 17)
        Me.RadioButton1.TabIndex = 3
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Mpesa"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(46, 264)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(49, 17)
        Me.RadioButton2.TabIndex = 4
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Cash"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(46, 300)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(62, 17)
        Me.RadioButton3.TabIndex = 5
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Cheque"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(385, 24)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(120, 95)
        Me.ListBox1.TabIndex = 6
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(46, 186)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(85, 22)
        Me.btnCalculate.TabIndex = 8
        Me.btnCalculate.Text = "CALCULATE"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(532, 386)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.RadioButton3)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.txtSellingPrice)
        Me.Controls.Add(Me.txttransportCost)
        Me.Controls.Add(Me.txtBuyingPrice)
        Me.Name = "Form1"
        Me.Text = "CALCULATE"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtBuyingPrice As System.Windows.Forms.TextBox
    Friend WithEvents txttransportCost As System.Windows.Forms.TextBox
    Friend WithEvents txtSellingPrice As System.Windows.Forms.TextBox
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents btnCalculate As System.Windows.Forms.Button

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        CaptureDetails()
        Dim buyingPrice As Double
        Dim transportCost As Double
        Dim paymentMode As String
        Dim sellingPrice As Double

        Dim profitOrLoss As String = CalculateProfitOrLoss(buyingPrice, transportCost, sellingPrice)
        DisplayDetails(buyingPrice, transportCost, sellingPrice, paymentMode, profitOrLoss)
    End Sub



    Private Sub CaptureDetails()
        Dim buyingPrice As Double
        Dim transportCost As Double
        Dim paymentMode As String
        Dim sellingPrice As Double

        Console.WriteLine("enter buying price: ")
        buyingPrice = CInt(Console.ReadLine())

        Console.WriteLine("enter transport cost: ")
        transportCost = CInt(Console.ReadLine())

        Console.WriteLine("enter payment mode: ")
        paymentMode = CInt(Console.ReadLine())

        Console.WriteLine("enter selling price: ")
        sellingPrice = CInt(Console.ReadLine())






    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        Dim buyingPrice As Double
        Dim transportCost As Double
        Dim paymentMode As String
        Dim sellingPrice As Double
        Dim rdoCash As Boolean
        Dim rdoCredit As Boolean
        Dim lstDetails As Boolean


        txtBuyingPrice.Clear()
        txtTransportCost.Clear()
        txtSellingPrice.Clear()
        rdoCash.Checked = False
        rdoCredit.Checked = False
        lstDetails.Items.Clear()
    End Sub


    Private Function CalculateProfitOrLoss(buyingPrice As Double, transportCost As Double, sellingPrice As Double) As String
        Dim profitOrLoss As Double = sellingPrice - (buyingPrice + transportCost)
        If profitOrLoss < 0 Then
            Return "Loss: " & Math.Abs(profitOrLoss)
        Else
            Return "Profit: " & profitOrLoss
        End If
    End Function
End Class

