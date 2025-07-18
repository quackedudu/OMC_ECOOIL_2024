Imports System.Data.OleDb
Public Class Options

    Private Sub btnProfile_Click(sender As Object, e As EventArgs) Handles btnProfile.Click
        Dim currentUsername As String = UserSession.CurrentUsername
        Dim isCourier As Boolean = UserSession.IsCourier

        Dim userDetails = GetUserDetails(currentUsername, isCourier)

        If userDetails IsNot Nothing Then
            Dim editProfileForm As New editprof(userDetails.Item1, userDetails.Item2, userDetails.Item3, userDetails.Item4)
            editProfileForm.Show()
            Me.Hide()
        Else
            MessageBox.Show("User not found.")
        End If
    End Sub

    Private Function GetUserDetails(username As String, isCourier As Boolean) As Tuple(Of String, String, String, Byte())
        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Najmin Faiz\Desktop\credentials.accdb;"
        Dim commandText As String

        If isCourier Then
            commandText = "SELECT MyName, PhoneNumber, Address, ProfilePicture FROM CourUsers WHERE Username = @Username"
        Else
            commandText = "SELECT MyName, PhoneNumber, Address, ProfilePicture FROM CustUsers WHERE Username = @Username"
        End If

        Using connection As New OleDbConnection(connectionString)
            Using command As New OleDbCommand(commandText, connection)
                command.Parameters.AddWithValue("@Username", username)
                connection.Open()

                Using reader As OleDbDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        Dim myName As String = reader("MyName").ToString()
                        Dim phoneNumber As String = reader("PhoneNumber").ToString()
                        Dim address As String = reader("Address").ToString()
                        Dim profilePicture As Byte() = If(IsDBNull(reader("ProfilePicture")), Nothing, CType(reader("ProfilePicture"), Byte()))

                        Return New Tuple(Of String, String, String, Byte())(myName, phoneNumber, address, profilePicture)
                    End If
                End Using
            End Using
        End Using

        Return Nothing ' Return Nothing if user not found
    End Function

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

    Private Sub btnDeactivateAccount_Click(sender As Object, e As EventArgs) Handles btnDeactivate.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to deactivate your account?", "Confirm Deactivation", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then
            DeactivateAccount(UserSession.CurrentUsername, UserSession.IsCourier)
        End If
    End Sub

    Private Sub DeactivateAccount(username As String, isCourier As Boolean)
        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Najmin Faiz\Desktop\credentials.accdb;"
        Dim commandText As String

        If isCourier Then
            commandText = "DELETE FROM CourUsers WHERE Username = @username"
        Else
            commandText = "DELETE FROM CustUsers WHERE Username = @username"
        End If

        Using connection As New OleDbConnection(connectionString)
            Try
                connection.Open()
                Using command As New OleDbCommand(commandText, connection)
                    command.Parameters.AddWithValue("@username", username)
                    command.ExecuteNonQuery()
                    MessageBox.Show("Account deactivated successfully.")

                    Dim mainstart As New mainstart()
                    mainstart.Show()
                    Me.Hide()
                End Using
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to logout?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            UserSession.CurrentUsername = String.Empty
            UserSession.IsCourier = False

            MessageBox.Show("You have successfully logged out.", "Logout", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Dim loginChoice As New loginchoice()
            loginChoice.Show()
            Me.Hide()
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
