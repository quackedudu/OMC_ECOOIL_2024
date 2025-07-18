Imports System.Data.OleDb

Public Class custlogin
    Private Const PlaceholderUsername As String = "Enter your username"
    Private Const PlaceholderPassword As String = "Enter your password"

    Private Sub custlogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set initial placeholder text
        SetPlaceholderText(txtCustLoginUsername, PlaceholderUsername)
        SetPlaceholderText(txtCustLoginPwd, PlaceholderPassword, True)
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
        Handles txtCustLoginUsername.Enter, txtCustLoginPwd.Enter

        Dim textBox As TextBox = CType(sender, TextBox)
        Select Case textBox.Name
            Case "txtCustLoginUsername"
                RemovePlaceholderText(textBox, PlaceholderUsername)
            Case "txtCustLoginPwd"
                RemovePlaceholderText(textBox, PlaceholderPassword, True)
        End Select
    End Sub

    Private Sub TextBox_Leave(sender As Object, e As EventArgs) _
        Handles txtCustLoginUsername.Leave, txtCustLoginPwd.Leave

        Dim textBox As TextBox = CType(sender, TextBox)
        Select Case textBox.Name
            Case "txtCustLoginUsername"
                RestorePlaceholderText(textBox, PlaceholderUsername)
            Case "txtCustLoginPwd"
                RestorePlaceholderText(textBox, PlaceholderPassword, True)
        End Select
    End Sub

    Private Sub btnCustInside_Click(sender As Object, e As EventArgs) Handles btnCustInside.Click
        Dim username As String = txtCustLoginUsername.Text
        Dim password As String = txtCustLoginPwd.Text

        If ValidateCredentials(username, password) Then
            UserSession.CurrentUsername = username
            UserSession.IsCourier = False ' Set as customer
            ' Open the main form
            Dim homescreen As New homescreen()
            homescreen.Show()
            Me.Hide()
        Else
            MessageBox.Show("Invalid username or password.")
        End If
    End Sub

    Private Function ValidateCredentials(username As String, password As String) As Boolean
        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Najmin Faiz\Desktop\credentials.accdb;"
        Dim query As String = "SELECT COUNT(*) FROM CustUsers WHERE Username = @username AND Password = @password"

        Using connection As New OleDbConnection(connectionString)
            Using command As New OleDbCommand(query, connection)
                command.Parameters.AddWithValue("@username", username)
                command.Parameters.AddWithValue("@password", password)

                connection.Open()
                Dim result As Integer = Convert.ToInt32(command.ExecuteScalar())

                Return result > 0
            End Using
        End Using
    End Function

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Oemtilde Then
            Me.Hide()
            Dim previousForm As New loginchoice()
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
