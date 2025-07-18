<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class couriercreateacc
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
        btnCompleteCourSignup = New Button()
        picCourPP = New PictureBox()
        Label3 = New Label()
        txtCourPwd = New TextBox()
        txtCourUsername = New TextBox()
        txtCourNoTel = New TextBox()
        txtCourIC = New TextBox()
        txtCourName = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        PictureBox2 = New PictureBox()
        PictureBox1 = New PictureBox()
        OpenFileDialog1 = New OpenFileDialog()
        CType(picCourPP, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnCompleteCourSignup
        ' 
        btnCompleteCourSignup.Anchor = AnchorStyles.None
        btnCompleteCourSignup.BackColor = Color.Green
        btnCompleteCourSignup.BackgroundImageLayout = ImageLayout.None
        btnCompleteCourSignup.FlatStyle = FlatStyle.Popup
        btnCompleteCourSignup.Font = New Font("Cooper Black", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnCompleteCourSignup.ForeColor = Color.White
        btnCompleteCourSignup.Location = New Point(138, 440)
        btnCompleteCourSignup.Name = "btnCompleteCourSignup"
        btnCompleteCourSignup.Size = New Size(126, 32)
        btnCompleteCourSignup.TabIndex = 27
        btnCompleteCourSignup.Text = "SIGN UP"
        btnCompleteCourSignup.UseVisualStyleBackColor = False
        ' 
        ' picCourPP
        ' 
        picCourPP.BackColor = Color.LimeGreen
        picCourPP.Location = New Point(179, 324)
        picCourPP.Name = "picCourPP"
        picCourPP.Size = New Size(100, 99)
        picCourPP.TabIndex = 26
        picCourPP.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Copperplate Gothic Light", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(29, 334)
        Label3.Name = "Label3"
        Label3.Size = New Size(144, 12)
        Label3.TabIndex = 25
        Label3.Text = "Upload your picture :"
        ' 
        ' txtCourPwd
        ' 
        txtCourPwd.BackColor = Color.LimeGreen
        txtCourPwd.BorderStyle = BorderStyle.FixedSingle
        txtCourPwd.ForeColor = Color.White
        txtCourPwd.Location = New Point(38, 283)
        txtCourPwd.Name = "txtCourPwd"
        txtCourPwd.Size = New Size(226, 23)
        txtCourPwd.TabIndex = 24
        txtCourPwd.Text = "Password"
        txtCourPwd.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtCourUsername
        ' 
        txtCourUsername.BackColor = Color.LimeGreen
        txtCourUsername.BorderStyle = BorderStyle.FixedSingle
        txtCourUsername.ForeColor = Color.White
        txtCourUsername.Location = New Point(38, 254)
        txtCourUsername.Name = "txtCourUsername"
        txtCourUsername.Size = New Size(226, 23)
        txtCourUsername.TabIndex = 23
        txtCourUsername.Text = "Username"
        txtCourUsername.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtCourNoTel
        ' 
        txtCourNoTel.BackColor = Color.LimeGreen
        txtCourNoTel.BorderStyle = BorderStyle.FixedSingle
        txtCourNoTel.ForeColor = Color.White
        txtCourNoTel.Location = New Point(38, 225)
        txtCourNoTel.Name = "txtCourNoTel"
        txtCourNoTel.Size = New Size(226, 23)
        txtCourNoTel.TabIndex = 22
        txtCourNoTel.Text = "Phone Number"
        txtCourNoTel.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtCourIC
        ' 
        txtCourIC.BackColor = Color.LimeGreen
        txtCourIC.BorderStyle = BorderStyle.FixedSingle
        txtCourIC.ForeColor = Color.White
        txtCourIC.Location = New Point(38, 196)
        txtCourIC.Name = "txtCourIC"
        txtCourIC.Size = New Size(226, 23)
        txtCourIC.TabIndex = 21
        txtCourIC.Text = "IC Number"
        txtCourIC.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtCourName
        ' 
        txtCourName.BackColor = Color.LimeGreen
        txtCourName.BorderStyle = BorderStyle.FixedSingle
        txtCourName.ForeColor = Color.White
        txtCourName.Location = New Point(38, 167)
        txtCourName.Name = "txtCourName"
        txtCourName.Size = New Size(226, 23)
        txtCourName.TabIndex = 20
        txtCourName.Text = "Name"
        txtCourName.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Cooper Black", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(18, 84)
        Label2.Name = "Label2"
        Label2.Size = New Size(138, 68)
        Label2.TabIndex = 19
        Label2.Text = "Create" & vbCrLf & "Account"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BorderStyle = BorderStyle.Fixed3D
        Label1.Font = New Font("Cooper Black", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(29, 22)
        Label1.Name = "Label1"
        Label1.Size = New Size(121, 17)
        Label1.TabIndex = 18
        Label1.Text = "        COURIER        "
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.Open
        PictureBox2.Location = New Point(-54, 299)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(236, 253)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 17
        PictureBox2.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources._1_removebg_preview
        PictureBox1.Location = New Point(106, -36)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(224, 206)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 16
        PictureBox1.TabStop = False
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' couriercreateacc
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        ClientSize = New Size(304, 484)
        Controls.Add(btnCompleteCourSignup)
        Controls.Add(picCourPP)
        Controls.Add(Label3)
        Controls.Add(txtCourPwd)
        Controls.Add(txtCourUsername)
        Controls.Add(txtCourNoTel)
        Controls.Add(txtCourIC)
        Controls.Add(txtCourName)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        KeyPreview = True
        Name = "couriercreateacc"
        StartPosition = FormStartPosition.CenterScreen
        Text = "EcoOil Ltd."
        CType(picCourPP, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnCompleteCourSignup As Button
    Friend WithEvents picCourPP As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCourPwd As TextBox
    Friend WithEvents txtCourUsername As TextBox
    Friend WithEvents txtCourNoTel As TextBox
    Friend WithEvents txtCourIC As TextBox
    Friend WithEvents txtCourName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
