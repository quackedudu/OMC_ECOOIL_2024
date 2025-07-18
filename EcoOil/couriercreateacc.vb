Imports System.Data.OleDb
Imports System.IO

Public Class couriercreateacc
    ' Placeholder text for each TextBox
    Private Const PlaceholderCourName As String = "Enter your name"
    Private Const PlaceholderCourIC As String = "Enter your IC number"
    Private Const PlaceholderCourNoTel As String = "Enter your phone number"
    Private Const PlaceholderCourUsername As String = "Enter your username"
    Private Const PlaceholderCourPwd As String = "Enter your password"

    Private profilePicturePath As String

    Private Sub couriercreateacc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set initial placeholder text
        SetPlaceholderText(txtCourName, PlaceholderCourName)
        SetPlaceholderText(txtCourIC, PlaceholderCourIC)
        SetPlaceholderText(txtCourNoTel, PlaceholderCourNoTel)
        SetPlaceholderText(txtCourUsername, PlaceholderCourUsername)
        SetPlaceholderText(txtCourPwd, PlaceholderCourPwd, isPassword:=True)
    End Sub

    Private Sub SetPlaceholderText(textBox As TextBox, placeholderText As String, Optional isPassword As Boolean = False)
        textBox.Tag = "placeholder"
        textBox.Text = placeholderText
        textBox.ForeColor = Color.Gray
        If isPassword Then
            textBox.PasswordChar = ControlChars.NullChar
        End If
    End Sub

    Private Sub RemovePlaceholderText(textBox As TextBox, placeholderText As String, Optional isPassword As Boolean = False)
        If textBox.Text = placeholderText AndAlso textBox.Tag.ToString() = "placeholder" Then
            textBox.Text = ""
            textBox.ForeColor = Color.Black
            textBox.Tag = ""
            If isPassword Then
                textBox.PasswordChar = "*"c
            End If
        End If
    End Sub

    Private Sub RestorePlaceholderText(textBox As TextBox, placeholderText As String, Optional isPassword As Boolean = False)
        If String.IsNullOrWhiteSpace(textBox.Text) Then
            textBox.Tag = "placeholder"
            textBox.Text = placeholderText
            textBox.ForeColor = Color.Gray
            If isPassword Then
                textBox.PasswordChar = ControlChars.NullChar
            End If
        End If
    End Sub

    Private Sub TextBox_Enter(sender As Object, e As EventArgs) _
        Handles txtCourName.Enter, txtCourIC.Enter, txtCourNoTel.Enter, txtCourUsername.Enter, txtCourPwd.Enter

        Dim textBox As TextBox = CType(sender, TextBox)
        Select Case textBox.Name
            Case "txtCourName"
                RemovePlaceholderText(textBox, PlaceholderCourName)
            Case "txtCourIC"
                RemovePlaceholderText(textBox, PlaceholderCourIC)
            Case "txtCourNoTel"
                RemovePlaceholderText(textBox, PlaceholderCourNoTel)
            Case "txtCourUsername"
                RemovePlaceholderText(textBox, PlaceholderCourUsername)
            Case "txtCourPwd"
                RemovePlaceholderText(textBox, PlaceholderCourPwd, isPassword:=True)
        End Select
    End Sub

    Private Sub TextBox_Leave(sender As Object, e As EventArgs) _
        Handles txtCourName.Leave, txtCourIC.Leave, txtCourNoTel.Leave, txtCourUsername.Leave, txtCourPwd.Leave

        Dim textBox As TextBox = CType(sender, TextBox)
        Select Case textBox.Name
            Case "txtCourName"
                RestorePlaceholderText(textBox, PlaceholderCourName)
            Case "txtCourIC"
                RestorePlaceholderText(textBox, PlaceholderCourIC)
            Case "txtCourNoTel"
                RestorePlaceholderText(textBox, PlaceholderCourNoTel)
            Case "txtCourUsername"
                RestorePlaceholderText(textBox, PlaceholderCourUsername)
            Case "txtCourPwd"
                RestorePlaceholderText(textBox, PlaceholderCourPwd, isPassword:=True)
        End Select
    End Sub

    Private Sub btnCompleteCourSignup_Click(sender As Object, e As EventArgs) Handles btnCompleteCourSignup.Click
        Dim myName As String = If(txtCourName.Tag.ToString() = "placeholder", String.Empty, txtCourName.Text)
        Dim icNumber As String = If(txtCourIC.Tag.ToString() = "placeholder", String.Empty, txtCourIC.Text)
        Dim phoneNumber As String = If(txtCourNoTel.Tag.ToString() = "placeholder", String.Empty, txtCourNoTel.Text)
        Dim username As String = If(txtCourUsername.Tag.ToString() = "placeholder", String.Empty, txtCourUsername.Text)
        Dim password As String = If(txtCourPwd.Tag.ToString() = "placeholder", String.Empty, txtCourPwd.Text)

        If String.IsNullOrWhiteSpace(myName) OrElse String.IsNullOrWhiteSpace(icNumber) OrElse String.IsNullOrWhiteSpace(phoneNumber) OrElse String.IsNullOrWhiteSpace(username) OrElse String.IsNullOrWhiteSpace(password) Then
            MessageBox.Show("Please fill in all fields.")
            Return
        End If

        SaveUserToDatabase(myName, icNumber, phoneNumber, username, password)
    End Sub

    Private Sub SaveUserToDatabase(myName As String, icNumber As String, phoneNumber As String, username As String, password As String)
        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Najmin Faiz\Desktop\credentials.accdb;"

        Dim checkUserCommandText As String = "SELECT COUNT(*) FROM CourUsers WHERE ICNumber = @ICNumber OR Username = @Username"

        Using connection As New OleDbConnection(connectionString)
            Try
                connection.Open()

                ' Check if the user already exists
                Using checkCommand As New OleDbCommand(checkUserCommandText, connection)
                    checkCommand.Parameters.AddWithValue("@ICNumber", icNumber)
                    checkCommand.Parameters.AddWithValue("@Username", username)

                    Dim userCount As Integer = Convert.ToInt32(checkCommand.ExecuteScalar())

                    If userCount > 0 Then
                        MessageBox.Show("A user with this IC number or username already exists.")
                        Return
                    End If
                End Using

                ' Proceed with the insert if the user does not exist
                Dim commandText As String = "INSERT INTO CourUsers ([MyName], ICNumber, PhoneNumber, Username, [Password], ProfilePicture) VALUES (@MyName, @ICNumber, @PhoneNumber, @Username, @Password, @ProfilePicture)"

                Using command As New OleDbCommand(commandText, connection)
                    command.Parameters.AddWithValue("@MyName", myName)
                    command.Parameters.AddWithValue("@ICNumber", icNumber)
                    command.Parameters.AddWithValue("@PhoneNumber", phoneNumber)
                    command.Parameters.AddWithValue("@Username", username)
                    command.Parameters.AddWithValue("@Password", password)

                    If String.IsNullOrEmpty(profilePicturePath) Then
                        command.Parameters.AddWithValue("@ProfilePicture", DBNull.Value)
                    Else
                        Dim profilePictureBytes As Byte() = File.ReadAllBytes(profilePicturePath)
                        command.Parameters.AddWithValue("@ProfilePicture", profilePictureBytes)
                    End If

                    command.ExecuteNonQuery()
                    MessageBox.Show("User signed up successfully!")

                    ' Go to main page
                    Dim mainstart As New mainstart()
                    mainstart.Show()
                    Me.Hide()
                End Using
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub picCourPP_Click(sender As Object, e As EventArgs) Handles picCourPP.Click
        Using openFileDialog As New OpenFileDialog()
            openFileDialog.Title = "Select a Profile Picture"
            openFileDialog.Filter = "Image Files|*.bmp;*.jpg;*.jpeg;*.png;*.gif"

            If openFileDialog.ShowDialog() = DialogResult.OK Then
                profilePicturePath = openFileDialog.FileName
                picCourPP.Image = Image.FromFile(profilePicturePath)
                picCourPP.SizeMode = PictureBoxSizeMode.StretchImage ' Adjust image to fit PictureBox
            End If
        End Using
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Oemtilde Then
            Me.Hide()
            Dim previousForm As New signupchoice()
            previousForm.Show()
        End If
    End Sub
    Private Sub Form_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.No Then
                e.Cancel = True ' Cancel the closing event
            End If
        End If
    End Sub

End Class
