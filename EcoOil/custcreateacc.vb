Imports System.Data.OleDb
Imports System.IO

Public Class custcreateacc

    ' Placeholder text for each TextBox
    Private Const PlaceholderCustName As String = "Enter your name"
    Private Const PlaceholderCustIC As String = "Enter your IC number"
    Private Const PlaceholderCustNoTel As String = "Enter your phone number"
    Private Const PlaceholderCustUsername As String = "Enter your username"
    Private Const PlaceholderCustPwd As String = "Enter your password"

    Private profilePicturePath As String

    Private Sub custcreateacc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set initial placeholder text
        SetPlaceholderText(txtCustName, PlaceholderCustName)
        SetPlaceholderText(txtCustIC, PlaceholderCustIC)
        SetPlaceholderText(txtCustNoTel, PlaceholderCustNoTel)
        SetPlaceholderText(txtCustUsername, PlaceholderCustUsername)
        SetPlaceholderText(txtCustPwd, PlaceholderCustPwd, isPassword:=True)
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
        Handles txtCustName.Enter, txtCustIC.Enter, txtCustNoTel.Enter, txtCustUsername.Enter, txtCustPwd.Enter

        Dim textBox As TextBox = CType(sender, TextBox)
        Select Case textBox.Name
            Case "txtCustName"
                RemovePlaceholderText(textBox, PlaceholderCustName)
            Case "txtCustIC"
                RemovePlaceholderText(textBox, PlaceholderCustIC)
            Case "txtCustNoTel"
                RemovePlaceholderText(textBox, PlaceholderCustNoTel)
            Case "txtCustUsername"
                RemovePlaceholderText(textBox, PlaceholderCustUsername)
            Case "txtCustPwd"
                RemovePlaceholderText(textBox, PlaceholderCustPwd, isPassword:=True)
        End Select
    End Sub

    Private Sub TextBox_Leave(sender As Object, e As EventArgs) _
        Handles txtCustName.Leave, txtCustIC.Leave, txtCustNoTel.Leave, txtCustUsername.Leave, txtCustPwd.Leave

        Dim textBox As TextBox = CType(sender, TextBox)
        Select Case textBox.Name
            Case "txtCustName"
                RestorePlaceholderText(textBox, PlaceholderCustName)
            Case "txtCustIC"
                RestorePlaceholderText(textBox, PlaceholderCustIC)
            Case "txtCustNoTel"
                RestorePlaceholderText(textBox, PlaceholderCustNoTel)
            Case "txtCustUsername"
                RestorePlaceholderText(textBox, PlaceholderCustUsername)
            Case "txtCustPwd"
                RestorePlaceholderText(textBox, PlaceholderCustPwd, isPassword:=True)
        End Select
    End Sub

    Private Sub btnCompleteCustSignup_Click(sender As Object, e As EventArgs) Handles btnCompleteCustSignup.Click
        Dim myName As String = If(txtCustName.Tag.ToString() = "placeholder", String.Empty, txtCustName.Text)
        Dim icNumber As String = If(txtCustIC.Tag.ToString() = "placeholder", String.Empty, txtCustIC.Text)
        Dim phoneNumber As String = If(txtCustNoTel.Tag.ToString() = "placeholder", String.Empty, txtCustNoTel.Text)
        Dim username As String = If(txtCustUsername.Tag.ToString() = "placeholder", String.Empty, txtCustUsername.Text)
        Dim password As String = If(txtCustPwd.Tag.ToString() = "placeholder", String.Empty, txtCustPwd.Text)

        If String.IsNullOrWhiteSpace(myName) OrElse String.IsNullOrWhiteSpace(icNumber) OrElse String.IsNullOrWhiteSpace(phoneNumber) OrElse String.IsNullOrWhiteSpace(username) OrElse String.IsNullOrWhiteSpace(password) Then
            MessageBox.Show("Please fill in all fields.")
            Return
        End If

        SaveUserToDatabase(myName, icNumber, phoneNumber, username, password)
    End Sub

    Private Sub SaveUserToDatabase(myName As String, icNumber As String, phoneNumber As String, username As String, password As String)
        ' Updating database path ONLY if necessary
        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Najmin Faiz\Desktop\credentials.accdb;"

        ' Check for existing user
        Dim checkUserCommandText As String = "SELECT COUNT(*) FROM CustUsers WHERE ICNumber = @ICNumber OR Username = @Username"

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
                Dim commandText As String = "INSERT INTO CustUsers ([MyName], ICNumber, PhoneNumber, Username, [Password], ProfilePicture) VALUES (@MyName, @ICNumber, @PhoneNumber, @Username, @Password, @ProfilePicture)"

                Using command As New OleDbCommand(commandText, connection)
                    command.Parameters.AddWithValue("@MyName", myName)
                    command.Parameters.AddWithValue("@ICNumber", icNumber)
                    command.Parameters.AddWithValue("@PhoneNumber", phoneNumber)
                    command.Parameters.AddWithValue("@Username", username)
                    command.Parameters.AddWithValue("@Password", password)

                    ' Add profile picture parameter as attachment
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

    Private Sub picCustPP_Click(sender As Object, e As EventArgs) Handles picCustPP.Click
        Using openFileDialog As New OpenFileDialog()
            openFileDialog.Title = "Select a Profile Picture"
            openFileDialog.Filter = "Image Files|*.bmp;*.jpg;*.jpeg;*.png;*.gif"

            If openFileDialog.ShowDialog() = DialogResult.OK Then
                profilePicturePath = openFileDialog.FileName
                picCustPP.Image = Image.FromFile(profilePicturePath)
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
