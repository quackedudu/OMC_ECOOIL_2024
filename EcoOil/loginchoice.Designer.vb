<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class loginchoice
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
        Label2 = New Label()
        btnCourLogin = New Button()
        btnCustLogin = New Button()
        PictureBox2 = New PictureBox()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox4 = New PictureBox()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BorderStyle = BorderStyle.Fixed3D
        Label2.Font = New Font("Cooper Black", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(98, 127)
        Label2.Name = "Label2"
        Label2.Size = New Size(104, 17)
        Label2.TabIndex = 17
        Label2.Text = "        LOG IN        "
        ' 
        ' btnCourLogin
        ' 
        btnCourLogin.Anchor = AnchorStyles.None
        btnCourLogin.BackColor = Color.Green
        btnCourLogin.BackgroundImageLayout = ImageLayout.None
        btnCourLogin.FlatStyle = FlatStyle.Popup
        btnCourLogin.Font = New Font("Cooper Black", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnCourLogin.ForeColor = Color.White
        btnCourLogin.Location = New Point(163, 259)
        btnCourLogin.Name = "btnCourLogin"
        btnCourLogin.Size = New Size(101, 71)
        btnCourLogin.TabIndex = 14
        btnCourLogin.Text = "COURIER"
        btnCourLogin.UseVisualStyleBackColor = False
        ' 
        ' btnCustLogin
        ' 
        btnCustLogin.Anchor = AnchorStyles.None
        btnCustLogin.BackColor = Color.Green
        btnCustLogin.BackgroundImageLayout = ImageLayout.None
        btnCustLogin.FlatStyle = FlatStyle.Popup
        btnCustLogin.Font = New Font("Cooper Black", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnCustLogin.ForeColor = Color.White
        btnCustLogin.Location = New Point(41, 259)
        btnCustLogin.Name = "btnCustLogin"
        btnCustLogin.Size = New Size(101, 71)
        btnCustLogin.TabIndex = 13
        btnCustLogin.Text = "CUSTOMER"
        btnCustLogin.UseVisualStyleBackColor = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.Open
        PictureBox2.Location = New Point(-54, 299)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(236, 253)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 12
        PictureBox2.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Black", 20F, FontStyle.Bold)
        Label1.Location = New Point(57, 144)
        Label1.Name = "Label1"
        Label1.Size = New Size(192, 37)
        Label1.TabIndex = 11
        Label1.Text = "WHICH ONE?"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources._1_removebg_preview
        PictureBox1.Location = New Point(106, -36)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(224, 206)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 10
        PictureBox1.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = My.Resources.Resources.Open__1_
        PictureBox3.Location = New Point(41, 146)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(99, 159)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 15
        PictureBox3.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = My.Resources.Resources.Open__2_
        PictureBox4.Location = New Point(155, 125)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(118, 209)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 16
        PictureBox4.TabStop = False
        ' 
        ' loginchoice
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        ClientSize = New Size(304, 484)
        Controls.Add(Label2)
        Controls.Add(btnCourLogin)
        Controls.Add(btnCustLogin)
        Controls.Add(PictureBox2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox4)
        KeyPreview = True
        Name = "loginchoice"
        StartPosition = FormStartPosition.CenterScreen
        Text = "EcoOil Ltd."
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents btnCourLogin As Button
    Friend WithEvents btnCustLogin As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
End Class
