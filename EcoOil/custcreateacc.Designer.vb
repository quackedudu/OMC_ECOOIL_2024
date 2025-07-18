<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class custcreateacc
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
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        txtCustName = New TextBox()
        txtCustIC = New TextBox()
        txtCustNoTel = New TextBox()
        txtCustUsername = New TextBox()
        txtCustPwd = New TextBox()
        Label3 = New Label()
        OpenFileDialog1 = New OpenFileDialog()
        picCustPP = New PictureBox()
        btnCompleteCustSignup = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(picCustPP, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources._1_removebg_preview
        PictureBox1.Location = New Point(106, -36)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(224, 206)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.Open
        PictureBox2.Location = New Point(-54, 299)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(236, 253)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 5
        PictureBox2.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BorderStyle = BorderStyle.Fixed3D
        Label1.Font = New Font("Cooper Black", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(29, 22)
        Label1.Name = "Label1"
        Label1.Size = New Size(134, 17)
        Label1.TabIndex = 6
        Label1.Text = "        CUSTOMER        "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Cooper Black", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(18, 84)
        Label2.Name = "Label2"
        Label2.Size = New Size(138, 68)
        Label2.TabIndex = 7
        Label2.Text = "Create" & vbCrLf & "Account"
        ' 
        ' txtCustName
        ' 
        txtCustName.BackColor = Color.LimeGreen
        txtCustName.BorderStyle = BorderStyle.FixedSingle
        txtCustName.ForeColor = Color.White
        txtCustName.Location = New Point(38, 167)
        txtCustName.Name = "txtCustName"
        txtCustName.Size = New Size(226, 23)
        txtCustName.TabIndex = 8
        txtCustName.Text = "Name"
        txtCustName.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtCustIC
        ' 
        txtCustIC.BackColor = Color.LimeGreen
        txtCustIC.BorderStyle = BorderStyle.FixedSingle
        txtCustIC.ForeColor = Color.White
        txtCustIC.Location = New Point(38, 196)
        txtCustIC.Name = "txtCustIC"
        txtCustIC.Size = New Size(226, 23)
        txtCustIC.TabIndex = 9
        txtCustIC.Text = "IC Number"
        txtCustIC.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtCustNoTel
        ' 
        txtCustNoTel.BackColor = Color.LimeGreen
        txtCustNoTel.BorderStyle = BorderStyle.FixedSingle
        txtCustNoTel.ForeColor = Color.White
        txtCustNoTel.Location = New Point(38, 225)
        txtCustNoTel.Name = "txtCustNoTel"
        txtCustNoTel.Size = New Size(226, 23)
        txtCustNoTel.TabIndex = 10
        txtCustNoTel.Text = "Phone Number"
        txtCustNoTel.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtCustUsername
        ' 
        txtCustUsername.BackColor = Color.LimeGreen
        txtCustUsername.BorderStyle = BorderStyle.FixedSingle
        txtCustUsername.ForeColor = Color.White
        txtCustUsername.Location = New Point(38, 254)
        txtCustUsername.Name = "txtCustUsername"
        txtCustUsername.Size = New Size(226, 23)
        txtCustUsername.TabIndex = 11
        txtCustUsername.Text = "Username"
        txtCustUsername.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtCustPwd
        ' 
        txtCustPwd.BackColor = Color.LimeGreen
        txtCustPwd.BorderStyle = BorderStyle.FixedSingle
        txtCustPwd.ForeColor = Color.White
        txtCustPwd.Location = New Point(38, 283)
        txtCustPwd.Name = "txtCustPwd"
        txtCustPwd.PasswordChar = "*"c
        txtCustPwd.Size = New Size(226, 23)
        txtCustPwd.TabIndex = 12
        txtCustPwd.Text = "Password"
        txtCustPwd.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Copperplate Gothic Light", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(29, 334)
        Label3.Name = "Label3"
        Label3.Size = New Size(144, 12)
        Label3.TabIndex = 13
        Label3.Text = "Upload your picture :"
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        OpenFileDialog1.Title = "Select Profile Picture"
        ' 
        ' picCustPP
        ' 
        picCustPP.BackColor = Color.LimeGreen
        picCustPP.Location = New Point(179, 324)
        picCustPP.Name = "picCustPP"
        picCustPP.Size = New Size(100, 99)
        picCustPP.SizeMode = PictureBoxSizeMode.StretchImage
        picCustPP.TabIndex = 14
        picCustPP.TabStop = False
        ' 
        ' btnCompleteCustSignup
        ' 
        btnCompleteCustSignup.Anchor = AnchorStyles.None
        btnCompleteCustSignup.BackColor = Color.Green
        btnCompleteCustSignup.BackgroundImageLayout = ImageLayout.None
        btnCompleteCustSignup.FlatStyle = FlatStyle.Popup
        btnCompleteCustSignup.Font = New Font("Cooper Black", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnCompleteCustSignup.ForeColor = Color.White
        btnCompleteCustSignup.Location = New Point(138, 440)
        btnCompleteCustSignup.Name = "btnCompleteCustSignup"
        btnCompleteCustSignup.Size = New Size(126, 32)
        btnCompleteCustSignup.TabIndex = 15
        btnCompleteCustSignup.Text = "SIGN UP"
        btnCompleteCustSignup.UseVisualStyleBackColor = False
        ' 
        ' custcreateacc
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        ClientSize = New Size(304, 484)
        Controls.Add(btnCompleteCustSignup)
        Controls.Add(picCustPP)
        Controls.Add(Label3)
        Controls.Add(txtCustPwd)
        Controls.Add(txtCustUsername)
        Controls.Add(txtCustNoTel)
        Controls.Add(txtCustIC)
        Controls.Add(txtCustName)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        KeyPreview = True
        Name = "custcreateacc"
        StartPosition = FormStartPosition.CenterScreen
        Text = "EcoOil Ltd."
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(picCustPP, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCustName As TextBox
    Friend WithEvents txtCustIC As TextBox
    Friend WithEvents txtCustNoTel As TextBox
    Friend WithEvents txtCustUsername As TextBox
    Friend WithEvents txtCustPwd As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents picCustPP As PictureBox
    Friend WithEvents btnCompleteCustSignup As Button
End Class
