<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class editprof
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
        Label1 = New Label()
        Label2 = New Label()
        txtChangeUsername = New TextBox()
        txtChangeNoTel = New TextBox()
        txtChangeAddr = New TextBox()
        currentpic = New PictureBox()
        btnEditProfile = New Button()
        Label3 = New Label()
        Label7 = New Label()
        btnHome = New PictureBox()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label8 = New Label()
        btnOption = New PictureBox()
        btnMap = New PictureBox()
        btnWallet = New PictureBox()
        btnProfile = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(currentpic, ComponentModel.ISupportInitialize).BeginInit()
        CType(btnHome, ComponentModel.ISupportInitialize).BeginInit()
        CType(btnOption, ComponentModel.ISupportInitialize).BeginInit()
        CType(btnMap, ComponentModel.ISupportInitialize).BeginInit()
        CType(btnWallet, ComponentModel.ISupportInitialize).BeginInit()
        CType(btnProfile, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources._1_removebg_preview
        PictureBox1.Location = New Point(50, -40)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(194, 178)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 18
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(80, 106)
        Label1.Name = "Label1"
        Label1.Size = New Size(134, 15)
        Label1.TabIndex = 19
        Label1.Text = "PROFILE SETTINGS"
        ' 
        ' Label2
        ' 
        Label2.BackColor = Color.Silver
        Label2.BorderStyle = BorderStyle.Fixed3D
        Label2.Font = New Font("Cooper Black", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(36, 191)
        Label2.Name = "Label2"
        Label2.Size = New Size(226, 196)
        Label2.TabIndex = 21
        Label2.Text = vbCrLf
        ' 
        ' txtChangeUsername
        ' 
        txtChangeUsername.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        txtChangeUsername.BorderStyle = BorderStyle.FixedSingle
        txtChangeUsername.ForeColor = Color.Black
        txtChangeUsername.Location = New Point(52, 238)
        txtChangeUsername.Name = "txtChangeUsername"
        txtChangeUsername.Size = New Size(191, 23)
        txtChangeUsername.TabIndex = 22
        txtChangeUsername.Text = "Username"
        txtChangeUsername.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtChangeNoTel
        ' 
        txtChangeNoTel.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        txtChangeNoTel.BorderStyle = BorderStyle.FixedSingle
        txtChangeNoTel.ForeColor = Color.Black
        txtChangeNoTel.Location = New Point(52, 267)
        txtChangeNoTel.Name = "txtChangeNoTel"
        txtChangeNoTel.Size = New Size(191, 23)
        txtChangeNoTel.TabIndex = 23
        txtChangeNoTel.Text = "Phone Number"
        txtChangeNoTel.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtChangeAddr
        ' 
        txtChangeAddr.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        txtChangeAddr.BorderStyle = BorderStyle.FixedSingle
        txtChangeAddr.ForeColor = Color.Black
        txtChangeAddr.Location = New Point(52, 296)
        txtChangeAddr.Name = "txtChangeAddr"
        txtChangeAddr.Size = New Size(191, 23)
        txtChangeAddr.TabIndex = 24
        txtChangeAddr.Text = "Address"
        txtChangeAddr.TextAlign = HorizontalAlignment.Center
        ' 
        ' currentpic
        ' 
        currentpic.BackColor = Color.Gray
        currentpic.Location = New Point(99, 141)
        currentpic.Name = "currentpic"
        currentpic.Size = New Size(95, 91)
        currentpic.SizeMode = PictureBoxSizeMode.StretchImage
        currentpic.TabIndex = 25
        currentpic.TabStop = False
        ' 
        ' btnEditProfile
        ' 
        btnEditProfile.Anchor = AnchorStyles.None
        btnEditProfile.BackColor = Color.Green
        btnEditProfile.BackgroundImageLayout = ImageLayout.None
        btnEditProfile.FlatStyle = FlatStyle.Popup
        btnEditProfile.Font = New Font("Cooper Black", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnEditProfile.ForeColor = Color.White
        btnEditProfile.Location = New Point(85, 372)
        btnEditProfile.Name = "btnEditProfile"
        btnEditProfile.Size = New Size(126, 32)
        btnEditProfile.TabIndex = 28
        btnEditProfile.Text = "EDIT PROFILE"
        btnEditProfile.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.BackColor = Color.Green
        Label3.BorderStyle = BorderStyle.Fixed3D
        Label3.Font = New Font("Cooper Black", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(-8, 431)
        Label3.Name = "Label3"
        Label3.Size = New Size(321, 64)
        Label3.TabIndex = 29
        Label3.Text = vbCrLf
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Green
        Label7.Font = New Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(142, 469)
        Label7.Name = "Label7"
        Label7.Size = New Size(31, 12)
        Label7.TabIndex = 39
        Label7.Text = "HOME"
        ' 
        ' btnHome
        ' 
        btnHome.BackColor = Color.Green
        btnHome.Image = My.Resources.Resources.Untitled_design__5_
        btnHome.Location = New Point(142, 436)
        btnHome.Name = "btnHome"
        btnHome.Size = New Size(30, 30)
        btnHome.SizeMode = PictureBoxSizeMode.Zoom
        btnHome.TabIndex = 38
        btnHome.TabStop = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Green
        Label6.Font = New Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(245, 469)
        Label6.Name = "Label6"
        Label6.Size = New Size(43, 12)
        Label6.TabIndex = 37
        Label6.Text = "OPTIONS"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Green
        Label5.Font = New Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(195, 470)
        Label5.Name = "Label5"
        Label5.Size = New Size(29, 12)
        Label5.TabIndex = 36
        Label5.Text = "MAPS"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Green
        Label4.Font = New Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(80, 469)
        Label4.Name = "Label4"
        Label4.Size = New Size(37, 12)
        Label4.TabIndex = 35
        Label4.Text = "WALLET"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Green
        Label8.Font = New Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(18, 469)
        Label8.Name = "Label8"
        Label8.Size = New Size(37, 12)
        Label8.TabIndex = 30
        Label8.Text = "PROFILE"
        ' 
        ' btnOption
        ' 
        btnOption.BackColor = Color.Green
        btnOption.Image = My.Resources.Resources.Untitled_design__4_
        btnOption.Location = New Point(251, 436)
        btnOption.Name = "btnOption"
        btnOption.Size = New Size(30, 30)
        btnOption.SizeMode = PictureBoxSizeMode.Zoom
        btnOption.TabIndex = 34
        btnOption.TabStop = False
        ' 
        ' btnMap
        ' 
        btnMap.BackColor = Color.Green
        btnMap.Image = My.Resources.Resources.Untitled_design__2_
        btnMap.Location = New Point(194, 433)
        btnMap.Name = "btnMap"
        btnMap.Size = New Size(30, 36)
        btnMap.SizeMode = PictureBoxSizeMode.Zoom
        btnMap.TabIndex = 33
        btnMap.TabStop = False
        ' 
        ' btnWallet
        ' 
        btnWallet.BackColor = Color.Green
        btnWallet.Image = My.Resources.Resources.Untitled_design__1_
        btnWallet.Location = New Point(80, 436)
        btnWallet.Name = "btnWallet"
        btnWallet.Size = New Size(37, 30)
        btnWallet.SizeMode = PictureBoxSizeMode.Zoom
        btnWallet.TabIndex = 32
        btnWallet.TabStop = False
        ' 
        ' btnProfile
        ' 
        btnProfile.BackColor = Color.Green
        btnProfile.Image = My.Resources.Resources.Untitled_design
        btnProfile.Location = New Point(22, 436)
        btnProfile.Name = "btnProfile"
        btnProfile.Size = New Size(30, 30)
        btnProfile.SizeMode = PictureBoxSizeMode.Zoom
        btnProfile.TabIndex = 31
        btnProfile.TabStop = False
        ' 
        ' editprof
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        ClientSize = New Size(304, 484)
        Controls.Add(Label7)
        Controls.Add(btnHome)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label8)
        Controls.Add(btnOption)
        Controls.Add(btnMap)
        Controls.Add(btnWallet)
        Controls.Add(btnProfile)
        Controls.Add(Label3)
        Controls.Add(btnEditProfile)
        Controls.Add(currentpic)
        Controls.Add(txtChangeAddr)
        Controls.Add(txtChangeNoTel)
        Controls.Add(txtChangeUsername)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        KeyPreview = True
        Name = "editprof"
        StartPosition = FormStartPosition.CenterScreen
        Text = "EcoOil Ltd."
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(currentpic, ComponentModel.ISupportInitialize).EndInit()
        CType(btnHome, ComponentModel.ISupportInitialize).EndInit()
        CType(btnOption, ComponentModel.ISupportInitialize).EndInit()
        CType(btnMap, ComponentModel.ISupportInitialize).EndInit()
        CType(btnWallet, ComponentModel.ISupportInitialize).EndInit()
        CType(btnProfile, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtChangeUsername As TextBox
    Friend WithEvents txtChangeNoTel As TextBox
    Friend WithEvents txtChangeAddr As TextBox
    Friend WithEvents currentpic As PictureBox
    Friend WithEvents btnEditProfile As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnHome As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btnOption As PictureBox
    Friend WithEvents btnMap As PictureBox
    Friend WithEvents btnWallet As PictureBox
    Friend WithEvents btnProfile As PictureBox
End Class
