<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class custlogin
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
        Label2 = New Label()
        txtCustLoginUsername = New TextBox()
        txtCustLoginPwd = New TextBox()
        btnCustInside = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources._1_removebg_preview
        PictureBox1.Location = New Point(106, -36)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(224, 206)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 17
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.Open
        PictureBox2.Location = New Point(-54, 299)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(236, 253)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 18
        PictureBox2.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Cooper Black", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(23, 126)
        Label2.Name = "Label2"
        Label2.Size = New Size(159, 68)
        Label2.TabIndex = 20
        Label2.Text = "Customer" & vbCrLf & "Log In"
        ' 
        ' txtCustLoginUsername
        ' 
        txtCustLoginUsername.BackColor = Color.LimeGreen
        txtCustLoginUsername.BorderStyle = BorderStyle.FixedSingle
        txtCustLoginUsername.ForeColor = Color.White
        txtCustLoginUsername.Location = New Point(38, 223)
        txtCustLoginUsername.Name = "txtCustLoginUsername"
        txtCustLoginUsername.Size = New Size(226, 23)
        txtCustLoginUsername.TabIndex = 21
        txtCustLoginUsername.Text = "Username"
        txtCustLoginUsername.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtCustLoginPwd
        ' 
        txtCustLoginPwd.BackColor = Color.LimeGreen
        txtCustLoginPwd.BorderStyle = BorderStyle.FixedSingle
        txtCustLoginPwd.ForeColor = Color.White
        txtCustLoginPwd.Location = New Point(38, 252)
        txtCustLoginPwd.Name = "txtCustLoginPwd"
        txtCustLoginPwd.Size = New Size(226, 23)
        txtCustLoginPwd.TabIndex = 22
        txtCustLoginPwd.Text = "Password"
        txtCustLoginPwd.TextAlign = HorizontalAlignment.Center
        ' 
        ' btnCustInside
        ' 
        btnCustInside.Anchor = AnchorStyles.None
        btnCustInside.BackColor = Color.Green
        btnCustInside.BackgroundImageLayout = ImageLayout.None
        btnCustInside.FlatStyle = FlatStyle.Popup
        btnCustInside.Font = New Font("Cooper Black", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnCustInside.ForeColor = Color.White
        btnCustInside.Location = New Point(88, 299)
        btnCustInside.Name = "btnCustInside"
        btnCustInside.Size = New Size(126, 32)
        btnCustInside.TabIndex = 23
        btnCustInside.Text = "LOG IN"
        btnCustInside.UseVisualStyleBackColor = False
        ' 
        ' custlogin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        ClientSize = New Size(304, 484)
        Controls.Add(btnCustInside)
        Controls.Add(txtCustLoginPwd)
        Controls.Add(txtCustLoginUsername)
        Controls.Add(Label2)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        KeyPreview = True
        Name = "custlogin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "EcoOil Ltd."
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCustLoginUsername As TextBox
    Friend WithEvents txtCustLoginPwd As TextBox
    Friend WithEvents btnCustInside As Button
End Class
