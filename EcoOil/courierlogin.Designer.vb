<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class courierlogin
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
        btnCourInside = New Button()
        txtCourLoginPwd = New TextBox()
        txtCourLoginUsername = New TextBox()
        Label2 = New Label()
        PictureBox2 = New PictureBox()
        PictureBox1 = New PictureBox()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnCourInside
        ' 
        btnCourInside.Anchor = AnchorStyles.None
        btnCourInside.BackColor = Color.Green
        btnCourInside.BackgroundImageLayout = ImageLayout.None
        btnCourInside.FlatStyle = FlatStyle.Popup
        btnCourInside.Font = New Font("Cooper Black", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnCourInside.ForeColor = Color.White
        btnCourInside.Location = New Point(88, 299)
        btnCourInside.Name = "btnCourInside"
        btnCourInside.Size = New Size(126, 32)
        btnCourInside.TabIndex = 29
        btnCourInside.Text = "LOG IN"
        btnCourInside.UseVisualStyleBackColor = False
        ' 
        ' txtCourLoginPwd
        ' 
        txtCourLoginPwd.BackColor = Color.LimeGreen
        txtCourLoginPwd.BorderStyle = BorderStyle.FixedSingle
        txtCourLoginPwd.ForeColor = Color.White
        txtCourLoginPwd.Location = New Point(38, 252)
        txtCourLoginPwd.Name = "txtCourLoginPwd"
        txtCourLoginPwd.Size = New Size(226, 23)
        txtCourLoginPwd.TabIndex = 28
        txtCourLoginPwd.Text = "Password"
        txtCourLoginPwd.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtCourLoginUsername
        ' 
        txtCourLoginUsername.BackColor = Color.LimeGreen
        txtCourLoginUsername.BorderStyle = BorderStyle.FixedSingle
        txtCourLoginUsername.ForeColor = Color.White
        txtCourLoginUsername.Location = New Point(38, 223)
        txtCourLoginUsername.Name = "txtCourLoginUsername"
        txtCourLoginUsername.Size = New Size(226, 23)
        txtCourLoginUsername.TabIndex = 27
        txtCourLoginUsername.Text = "Username"
        txtCourLoginUsername.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Cooper Black", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(23, 126)
        Label2.Name = "Label2"
        Label2.Size = New Size(130, 68)
        Label2.TabIndex = 26
        Label2.Text = "Courier" & vbCrLf & "Log In"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.Open
        PictureBox2.Location = New Point(-54, 299)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(236, 253)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 25
        PictureBox2.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources._1_removebg_preview
        PictureBox1.Location = New Point(106, -36)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(224, 206)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 24
        PictureBox1.TabStop = False
        ' 
        ' courierlogin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        ClientSize = New Size(304, 484)
        Controls.Add(btnCourInside)
        Controls.Add(txtCourLoginPwd)
        Controls.Add(txtCourLoginUsername)
        Controls.Add(Label2)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        KeyPreview = True
        Name = "courierlogin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "EcoOil Ltd."
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnCourInside As Button
    Friend WithEvents txtCourLoginPwd As TextBox
    Friend WithEvents txtCourLoginUsername As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
