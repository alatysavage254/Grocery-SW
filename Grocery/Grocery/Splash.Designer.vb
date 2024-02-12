<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Splash
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Splash))
        Me.GROCERY = New System.Windows.Forms.Label()
        Me.LoadingLbl = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Myprogress = New Guna.UI.WinForms.GunaProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PercentageLbl = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GROCERY
        '
        Me.GROCERY.AccessibleName = "GROCERY SHOP SOFTWARE"
        Me.GROCERY.AutoSize = True
        Me.GROCERY.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.GROCERY.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GROCERY.ForeColor = System.Drawing.Color.LawnGreen
        Me.GROCERY.Location = New System.Drawing.Point(173, 28)
        Me.GROCERY.Name = "GROCERY"
        Me.GROCERY.Size = New System.Drawing.Size(297, 26)
        Me.GROCERY.TabIndex = 1
        Me.GROCERY.Text = "GROCERY SHOP SOFTWARE"
        '
        'LoadingLbl
        '
        Me.LoadingLbl.AccessibleName = "GROCERY SHOP SOFTWARE"
        Me.LoadingLbl.AutoSize = True
        Me.LoadingLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoadingLbl.ForeColor = System.Drawing.Color.DarkGreen
        Me.LoadingLbl.Location = New System.Drawing.Point(12, 354)
        Me.LoadingLbl.Name = "LoadingLbl"
        Me.LoadingLbl.Size = New System.Drawing.Size(103, 24)
        Me.LoadingLbl.TabIndex = 2
        Me.LoadingLbl.Text = "Loading..."
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(67, 55)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(522, 296)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Myprogress
        '
        Me.Myprogress.BackColor = System.Drawing.Color.Transparent
        Me.Myprogress.BorderColor = System.Drawing.Color.Black
        Me.Myprogress.ColorStyle = Guna.UI.WinForms.ColorStyle.[Default]
        Me.Myprogress.IdleColor = System.Drawing.Color.White
        Me.Myprogress.Location = New System.Drawing.Point(16, 381)
        Me.Myprogress.Name = "Myprogress"
        Me.Myprogress.ProgressMaxColor = System.Drawing.Color.DarkGreen
        Me.Myprogress.ProgressMinColor = System.Drawing.Color.SpringGreen
        Me.Myprogress.Radius = 5
        Me.Myprogress.Size = New System.Drawing.Size(573, 14)
        Me.Myprogress.TabIndex = 4
        '
        'Timer1
        '
        '
        'PercentageLbl
        '
        Me.PercentageLbl.AccessibleName = "GROCERY SHOP SOFTWARE"
        Me.PercentageLbl.AutoSize = True
        Me.PercentageLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PercentageLbl.ForeColor = System.Drawing.Color.Coral
        Me.PercentageLbl.Location = New System.Drawing.Point(121, 353)
        Me.PercentageLbl.Name = "PercentageLbl"
        Me.PercentageLbl.Size = New System.Drawing.Size(32, 25)
        Me.PercentageLbl.TabIndex = 3
        Me.PercentageLbl.Text = "%"
        '
        'Splash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlText
        Me.ClientSize = New System.Drawing.Size(694, 433)
        Me.Controls.Add(Me.Myprogress)
        Me.Controls.Add(Me.PercentageLbl)
        Me.Controls.Add(Me.LoadingLbl)
        Me.Controls.Add(Me.GROCERY)
        Me.Controls.Add(Me.PictureBox1)
        Me.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Splash"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.TransparencyKey = System.Drawing.Color.Maroon
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GROCERY As System.Windows.Forms.Label
    Friend WithEvents LoadingLbl As System.Windows.Forms.Label
    Friend WithEvents Myprogress As Guna.UI.WinForms.GunaProgressBar
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents PercentageLbl As System.Windows.Forms.Label

End Class
