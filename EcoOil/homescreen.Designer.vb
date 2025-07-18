<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class homescreen
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
        GroupBox1 = New GroupBox()
        Label2 = New Label()
        btnProfile = New PictureBox()
        btnWallet = New PictureBox()
        btnMap = New PictureBox()
        btnOption = New PictureBox()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        btnHome = New PictureBox()
        Label7 = New Label()
        PictureBox7 = New PictureBox()
        btnCompleteCourSignup = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(btnProfile, ComponentModel.ISupportInitialize).BeginInit()
        CType(btnWallet, ComponentModel.ISupportInitialize).BeginInit()
        CType(btnMap, ComponentModel.ISupportInitialize).BeginInit()
        CType(btnOption, ComponentModel.ISupportInitialize).BeginInit()
        CType(btnHome, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources._1_removebg_preview
        PictureBox1.Location = New Point(50, -40)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(194, 178)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 17
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(99, 113)
        Label1.Name = "Label1"
        Label1.Size = New Size(96, 32)
        Label1.TabIndex = 18
        Label1.Text = "HOME"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Location = New Point(16, 160)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(265, 151)
        GroupBox1.TabIndex = 19
        GroupBox1.TabStop = False
        GroupBox1.Text = "News and Updates"
        ' 
        ' Label2
        ' 
        Label2.BackColor = Color.Green
        Label2.BorderStyle = BorderStyle.Fixed3D
        Label2.Font = New Font("Cooper Black", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(-8, 431)
        Label2.Name = "Label2"
        Label2.Size = New Size(321, 64)
        Label2.TabIndex = 20
        Label2.Text = vbCrLf
        ' 
        ' btnProfile
        ' 
        btnProfile.BackColor = Color.Green
        btnProfile.Image = My.Resources.Resources.Untitled_design
        btnProfile.Location = New Point(22, 436)
        btnProfile.Name = "btnProfile"
        btnProfile.Size = New Size(30, 30)
        btnProfile.SizeMode = PictureBoxSizeMode.Zoom
        btnProfile.TabIndex = 21
        btnProfile.TabStop = False
        ' 
        ' btnWallet
        ' 
        btnWallet.BackColor = Color.Green
        btnWallet.Image = My.Resources.Resources.Untitled_design__1_
        btnWallet.Location = New Point(80, 436)
        btnWallet.Name = "btnWallet"
        btnWallet.Size = New Size(37, 30)
        btnWallet.SizeMode = PictureBoxSizeMode.Zoom
        btnWallet.TabIndex = 22
        btnWallet.TabStop = False
        ' 
        ' btnMap
        ' 
        btnMap.BackColor = Color.Green
        btnMap.Image = My.Resources.Resources.Untitled_design__2_
        btnMap.Location = New Point(194, 433)
        btnMap.Name = "btnMap"
        btnMap.Size = New Size(30, 36)
        btnMap.SizeMode = PictureBoxSizeMode.Zoom
        btnMap.TabIndex = 23
        btnMap.TabStop = False
        ' 
        ' btnOption
        ' 
        btnOption.BackColor = Color.Green
        btnOption.Image = My.Resources.Resources.Untitled_design__4_
        btnOption.Location = New Point(251, 436)
        btnOption.Name = "btnOption"
        btnOption.Size = New Size(30, 30)
        btnOption.SizeMode = PictureBoxSizeMode.Zoom
        btnOption.TabIndex = 24
        btnOption.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Green
        Label3.Font = New Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(18, 469)
        Label3.Name = "Label3"
        Label3.Size = New Size(37, 12)
        Label3.TabIndex = 0
        Label3.Text = "PROFILE"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Green
        Label4.Font = New Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(80, 469)
        Label4.Name = "Label4"
        Label4.Size = New Size(37, 12)
        Label4.TabIndex = 25
        Label4.Text = "WALLET"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Green
        Label5.Font = New Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(195, 470)
        Label5.Name = "Label5"
        Label5.Size = New Size(29, 12)
        Label5.TabIndex = 26
        Label5.Text = "MAPS"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Green
        Label6.Font = New Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(245, 469)
        Label6.Name = "Label6"
        Label6.Size = New Size(43, 12)
        Label6.TabIndex = 27
        Label6.Text = "OPTIONS"
        ' 
        ' btnHome
        ' 
        btnHome.BackColor = Color.Green
        btnHome.Image = My.Resources.Resources.Untitled_design__5_
        btnHome.Location = New Point(142, 436)
        btnHome.Name = "btnHome"
        btnHome.Size = New Size(30, 30)
        btnHome.SizeMode = PictureBoxSizeMode.Zoom
        btnHome.TabIndex = 28
        btnHome.TabStop = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Green
        Label7.Font = New Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(142, 469)
        Label7.Name = "Label7"
        Label7.Size = New Size(31, 12)
        Label7.TabIndex = 29
        Label7.Text = "HOME"
        ' 
        ' PictureBox7
        ' 
        PictureBox7.Image = My.Resources.Resources.Open
        PictureBox7.Location = New Point(-53, 255)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(236, 253)
        PictureBox7.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox7.TabIndex = 30
        PictureBox7.TabStop = False
        ' 
        ' btnCompleteCourSignup
        ' 
        btnCompleteCourSignup.Anchor = AnchorStyles.None
        btnCompleteCourSignup.BackColor = Color.Green
        btnCompleteCourSignup.BackgroundImageLayout = ImageLayout.None
        btnCompleteCourSignup.FlatStyle = FlatStyle.Popup
        btnCompleteCourSignup.Font = New Font("Cooper Black", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnCompleteCourSignup.ForeColor = Color.White
        btnCompleteCourSignup.Location = New Point(162, 375)
        btnCompleteCourSignup.Name = "btnCompleteCourSignup"
        btnCompleteCourSignup.Size = New Size(126, 32)
        btnCompleteCourSignup.TabIndex = 31
        btnCompleteCourSignup.Text = "CONTACT US"
        btnCompleteCourSignup.UseVisualStyleBackColor = False
        ' 
        ' homescreen
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        ClientSize = New Size(304, 484)
        Controls.Add(btnCompleteCourSignup)
        Controls.Add(Label7)
        Controls.Add(btnHome)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(btnOption)
        Controls.Add(btnMap)
        Controls.Add(btnWallet)
        Controls.Add(btnProfile)
        Controls.Add(GroupBox1)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Controls.Add(Label2)
        Controls.Add(PictureBox7)
        KeyPreview = True
        Name = "homescreen"
        StartPosition = FormStartPosition.CenterScreen
        Text = "EcoOil Ltd."
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(btnProfile, ComponentModel.ISupportInitialize).EndInit()
        CType(btnWallet, ComponentModel.ISupportInitialize).EndInit()
        CType(btnMap, ComponentModel.ISupportInitialize).EndInit()
        CType(btnOption, ComponentModel.ISupportInitialize).EndInit()
        CType(btnHome, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnProfile As PictureBox
    Friend WithEvents btnWallet As PictureBox
    Friend WithEvents btnMap As PictureBox
    Friend WithEvents btnOption As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnHome As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents btnCompleteCourSignup As Button
End Class
