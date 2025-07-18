Imports System.Data.OleDb
Imports System.IO

Public Class editprof
    Private username As String
    Private phoneNumber As String
    Private address As String
    Private profilePicture As Byte()

    ' Placeholder text for address TextBox
    Private Const PlaceholderAddr As String = "Enter your address"

    ' Constructor to receive user details
    Public Sub New(myName As String, myPhoneNumber As String, myAddress As String, myProfilePicture As Byte())
        InitializeComponent()
        username = myName
        phoneNumber = myPhoneNumber
        address = myAddress
        profilePicture = myProfilePicture
    End Sub

    Private Sub editprof_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtChangeUsername.Text = username
        txtChangeNoTel.Text = phoneNumber
        SetPlaceholderText(txtChangeAddr, PlaceholderAddr)

        ' Load profile picture if available
        If profilePicture IsNot Nothing Then
            Using ms As New MemoryStream(profilePicture)
                currentpic.Image = Image.FromStream(ms)
            End Using
        End If
    End Sub

    Private Sub SetPlaceholderText(textBox As TextBox, placeholderText As String)
        textBox.Tag = "placeholder"
        textBox.Text = placeholderText
        textBox.ForeColor = Color.Gray
    End Sub

    Private Sub RemovePlaceholderText(textBox As TextBox, placeholderText As String)
        If textBox.Text = placeholderText AndAlso textBox.Tag.ToString() = "placeholder" Then
            textBox.Text = ""
            textBox.ForeColor = Color.Black
            textBox.Tag = ""
        End If
    End Sub

    Private Sub RestorePlaceholderText(textBox As TextBox, placeholderText As String)
        If String.IsNullOrWhiteSpace(textBox.Text) Then
            SetPlaceholderText(textBox, placeholderText)
        End If
    End Sub

    Private Sub txtChangeAddr_Enter(sender As Object, e As EventArgs) Handles txtChangeAddr.Enter
        RemovePlaceholderText(txtChangeAddr, PlaceholderAddr)
    End Sub

    Private Sub txtChangeAddr_Leave(sender As Object, e As EventArgs) Handles txtChangeAddr.Leave
        RestorePlaceholderText(txtChangeAddr, PlaceholderAddr)
    End Sub

    Private Sub btnEditProfile_Click(sender As Object, e As EventArgs) Handles btnEditProfile.Click
        Dim newUsername As String = txtChangeUsername.Text
        Dim newPhoneNumber As String = txtChangeNoTel.Text
        Dim newAddress As String = txtChangeAddr.Text

        UpdateUserDetails(newUsername, newPhoneNumber, newAddress)
    End Sub

    Private Sub UpdateUserDetails(newUsername As String, newPhoneNumber As String, newAddress As String)
        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Najmin Faiz\Desktop\credentials.accdb;"
        Dim commandText As String

        If UserSession.IsCourier Then
            commandText = "UPDATE CourUsers SET PhoneNumber = @PhoneNumber, Address = @Address WHERE Username = @Username"
        Else
            commandText = "UPDATE CustUsers SET PhoneNumber = @PhoneNumber, Address = @Address WHERE Username = @Username"
        End If

        Using connection As New OleDbConnection(connectionString)
            Using command As New OleDbCommand(commandText, connection)
                command.Parameters.AddWithValue("@PhoneNumber", newPhoneNumber)
                command.Parameters.AddWithValue("@Address", newAddress)
                command.Parameters.AddWithValue("@Username", UserSession.CurrentUsername) ' Using the current username

                connection.Open()
                command.ExecuteNonQuery()
                MessageBox.Show("Profile updated successfully!")
            End Using
        End Using
    End Sub

    Private Sub btnOption_Click(sender As Object, e As EventArgs) Handles btnOption.Click
        Dim options As New options()
        options.Show()
        Me.Hide()
    End Sub

    Private Sub btnMap_Click(sender As Object, e As EventArgs) Handles btnMap.Click
        Dim maps As New maps()
        maps.Show()
        Me.Hide()
    End Sub

    Private Sub btnWallet_Click(sender As Object, e As EventArgs) Handles btnWallet.Click
        Dim wallet As New wallet()
        wallet.Show()
        Me.Hide()
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Dim homescreen As New homescreen()
        homescreen.Show()
        Me.Hide()
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
