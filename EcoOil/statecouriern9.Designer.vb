<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class statecouriern9
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
        Label9 = New Label()
        btnBack = New Button()
        lstStateCourierN9 = New ListBox()
        Label1 = New Label()
        Label2 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources._1_removebg_preview
        PictureBox1.Location = New Point(50, -40)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(194, 178)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 21
        PictureBox1.TabStop = False
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Arial Rounded MT Bold", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(29, 411)
        Label9.Name = "Label9"
        Label9.Size = New Size(242, 12)
        Label9.TabIndex = 76
        Label9.Text = "Double click to display contact information"
        ' 
        ' btnBack
        ' 
        btnBack.Anchor = AnchorStyles.None
        btnBack.BackColor = Color.Green
        btnBack.BackgroundImageLayout = ImageLayout.None
        btnBack.FlatStyle = FlatStyle.Popup
        btnBack.Font = New Font("Cooper Black", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnBack.ForeColor = Color.White
        btnBack.Location = New Point(85, 440)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(132, 32)
        btnBack.TabIndex = 77
        btnBack.Text = "BACK"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' lstStateCourierN9
        ' 
        lstStateCourierN9.BackColor = Color.Lime
        lstStateCourierN9.FormattingEnabled = True
        lstStateCourierN9.ItemHeight = 15
        lstStateCourierN9.Location = New Point(12, 171)
        lstStateCourierN9.Name = "lstStateCourierN9"
        lstStateCourierN9.Size = New Size(280, 214)
        lstStateCourierN9.TabIndex = 78
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(103, 123)
        Label1.Name = "Label1"
        Label1.Size = New Size(91, 15)
        Label1.TabIndex = 79
        Label1.Text = "Couriers List"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(85, 141)
        Label2.Name = "Label2"
        Label2.Size = New Size(130, 15)
        Label2.TabIndex = 80
        Label2.Text = "NEGERI SEMBILAN"
        ' 
        ' statecouriern9
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        ClientSize = New Size(304, 484)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(lstStateCourierN9)
        Controls.Add(btnBack)
        Controls.Add(Label9)
        Controls.Add(PictureBox1)
        Name = "statecouriern9"
        StartPosition = FormStartPosition.CenterScreen
        Text = "EcoOil Ltd."
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents lstStateCourierN9 As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
