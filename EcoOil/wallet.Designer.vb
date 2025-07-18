<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class wallet
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
        Label3 = New Label()
        Label2 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        btnWithdraw = New Button()
        btnChangeWalletInfo = New Button()
        btnDeposit = New Button()
        lblCurrentBalance = New Label()
        lstRecent = New ListBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
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
        PictureBox1.TabIndex = 19
        PictureBox1.TabStop = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Green
        Label7.Font = New Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(142, 469)
        Label7.Name = "Label7"
        Label7.Size = New Size(31, 12)
        Label7.TabIndex = 50
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
        btnHome.TabIndex = 49
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
        Label6.TabIndex = 48
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
        Label5.TabIndex = 47
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
        Label4.TabIndex = 46
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
        Label8.TabIndex = 41
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
        btnOption.TabIndex = 45
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
        btnMap.TabIndex = 44
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
        btnWallet.TabIndex = 43
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
        btnProfile.TabIndex = 42
        btnProfile.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.BackColor = Color.Green
        Label3.BorderStyle = BorderStyle.Fixed3D
        Label3.Font = New Font("Cooper Black", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(-8, 431)
        Label3.Name = "Label3"
        Label3.Size = New Size(321, 64)
        Label3.TabIndex = 40
        Label3.Text = vbCrLf
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Lime
        Label2.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(5, 309)
        Label2.Name = "Label2"
        Label2.Size = New Size(141, 15)
        Label2.TabIndex = 52
        Label2.Text = "Recent Transactions"
        ' 
        ' Label9
        ' 
        Label9.BackColor = Color.Lime
        Label9.BorderStyle = BorderStyle.Fixed3D
        Label9.FlatStyle = FlatStyle.Popup
        Label9.Font = New Font("Cooper Black", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(156, 120)
        Label9.Name = "Label9"
        Label9.Size = New Size(132, 112)
        Label9.TabIndex = 53
        Label9.Text = vbCrLf
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.Lime
        Label10.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(205, 212)
        Label10.Name = "Label10"
        Label10.Size = New Size(80, 15)
        Label10.TabIndex = 54
        Label10.Text = "ECO Wallet"
        ' 
        ' btnWithdraw
        ' 
        btnWithdraw.Anchor = AnchorStyles.None
        btnWithdraw.BackColor = Color.Green
        btnWithdraw.BackgroundImageLayout = ImageLayout.None
        btnWithdraw.FlatStyle = FlatStyle.Popup
        btnWithdraw.Font = New Font("Cooper Black", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnWithdraw.ForeColor = Color.White
        btnWithdraw.Location = New Point(14, 251)
        btnWithdraw.Name = "btnWithdraw"
        btnWithdraw.Size = New Size(132, 32)
        btnWithdraw.TabIndex = 55
        btnWithdraw.Text = "WITHDRAW"
        btnWithdraw.UseVisualStyleBackColor = False
        ' 
        ' btnChangeWalletInfo
        ' 
        btnChangeWalletInfo.Anchor = AnchorStyles.None
        btnChangeWalletInfo.BackColor = Color.Green
        btnChangeWalletInfo.BackgroundImageLayout = ImageLayout.None
        btnChangeWalletInfo.FlatStyle = FlatStyle.Popup
        btnChangeWalletInfo.Font = New Font("Cooper Black", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnChangeWalletInfo.ForeColor = Color.White
        btnChangeWalletInfo.Location = New Point(160, 251)
        btnChangeWalletInfo.Name = "btnChangeWalletInfo"
        btnChangeWalletInfo.Size = New Size(132, 32)
        btnChangeWalletInfo.TabIndex = 56
        btnChangeWalletInfo.Text = "EDIT WALLET"
        btnChangeWalletInfo.UseVisualStyleBackColor = False
        ' 
        ' btnDeposit
        ' 
        btnDeposit.Anchor = AnchorStyles.None
        btnDeposit.BackColor = Color.Green
        btnDeposit.BackgroundImageLayout = ImageLayout.None
        btnDeposit.FlatStyle = FlatStyle.Popup
        btnDeposit.Font = New Font("Cooper Black", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnDeposit.ForeColor = Color.White
        btnDeposit.Location = New Point(14, 212)
        btnDeposit.Name = "btnDeposit"
        btnDeposit.Size = New Size(132, 32)
        btnDeposit.TabIndex = 57
        btnDeposit.Text = "DEPOSIT"
        btnDeposit.UseVisualStyleBackColor = False
        ' 
        ' lblCurrentBalance
        ' 
        lblCurrentBalance.AutoSize = True
        lblCurrentBalance.BackColor = Color.Lime
        lblCurrentBalance.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblCurrentBalance.Location = New Point(160, 123)
        lblCurrentBalance.Name = "lblCurrentBalance"
        lblCurrentBalance.Size = New Size(58, 15)
        lblCurrentBalance.TabIndex = 58
        lblCurrentBalance.Text = "RM 0.00"
        ' 
        ' lstRecent
        ' 
        lstRecent.BackColor = Color.Lime
        lstRecent.FormattingEnabled = True
        lstRecent.ItemHeight = 15
        lstRecent.Location = New Point(0, 327)
        lstRecent.Name = "lstRecent"
        lstRecent.Size = New Size(305, 94)
        lstRecent.TabIndex = 59
        ' 
        ' wallet
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        ClientSize = New Size(304, 484)
        Controls.Add(lstRecent)
        Controls.Add(lblCurrentBalance)
        Controls.Add(btnDeposit)
        Controls.Add(btnChangeWalletInfo)
        Controls.Add(btnWithdraw)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label2)
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
        Controls.Add(PictureBox1)
        KeyPreview = True
        Name = "wallet"
        StartPosition = FormStartPosition.CenterScreen
        Text = "EcoOil Ltd."
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(btnHome, ComponentModel.ISupportInitialize).EndInit()
        CType(btnOption, ComponentModel.ISupportInitialize).EndInit()
        CType(btnMap, ComponentModel.ISupportInitialize).EndInit()
        CType(btnWallet, ComponentModel.ISupportInitialize).EndInit()
        CType(btnProfile, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
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
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents btnWithdraw As Button
    Friend WithEvents btnChangeWalletInfo As Button
    Friend WithEvents btnDeposit As Button
    Friend WithEvents lblCurrentBalance As Label
    Friend WithEvents lstRecent As ListBox
End Class
