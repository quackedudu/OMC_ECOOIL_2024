<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class mainstart
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        PictureBox1 = New PictureBox()
        btnSignup = New Button()
        btnLogin = New Button()
        PictureBox2 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources._1_removebg_preview
        PictureBox1.Location = New Point(-54, -44)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(413, 386)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' btnSignup
        ' 
        btnSignup.Anchor = AnchorStyles.None
        btnSignup.BackColor = Color.Green
        btnSignup.BackgroundImageLayout = ImageLayout.None
        btnSignup.FlatStyle = FlatStyle.Popup
        btnSignup.Font = New Font("Cooper Black", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnSignup.ForeColor = Color.White
        btnSignup.Location = New Point(88, 279)
        btnSignup.Name = "btnSignup"
        btnSignup.Size = New Size(126, 32)
        btnSignup.TabIndex = 1
        btnSignup.Text = "SIGN UP"
        btnSignup.UseVisualStyleBackColor = False
        ' 
        ' btnLogin
        ' 
        btnLogin.Anchor = AnchorStyles.None
        btnLogin.BackColor = Color.Green
        btnLogin.BackgroundImageLayout = ImageLayout.None
        btnLogin.FlatStyle = FlatStyle.Popup
        btnLogin.Font = New Font("Cooper Black", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnLogin.ForeColor = Color.White
        btnLogin.Location = New Point(88, 323)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(126, 32)
        btnLogin.TabIndex = 2
        btnLogin.Text = "LOG IN"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.Open
        PictureBox2.Location = New Point(-54, 299)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(236, 253)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 3
        PictureBox2.TabStop = False
        ' 
        ' mainstart
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        ClientSize = New Size(304, 484)
        Controls.Add(btnLogin)
        Controls.Add(btnSignup)
        Controls.Add(PictureBox1)
        Controls.Add(PictureBox2)
        KeyPreview = True
        Name = "mainstart"
        StartPosition = FormStartPosition.CenterScreen
        Text = "EcoOil Ltd."
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnSignup As Button
    Friend WithEvents btnLogin As Button
    Friend WithEvents PictureBox2 As PictureBox

End Class
