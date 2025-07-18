Imports System.Data.OleDb
Public Class wallet
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

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Dim homescreen As New homescreen()
        homescreen.Show()
        Me.Hide()
    End Sub

    Private Sub btnChangeWalletInfo_Click(sender As Object, e As EventArgs) Handles btnChangeWalletInfo.Click
        Dim result = MsgBox(" Are you sure want to change Wallet Account? ", MsgBoxStyle.YesNo, "Edit Wallet Information")
        If result = MsgBoxResult.Yes Then
            Dim NewNumAcc As Double
            Dim NewBankNameAcc As String
            NewNumAcc = InputBox(" Please Enter New Number Account : ", "Edit Wallet Information")
            NewBankNameAcc = InputBox(" Please Enter New Bank Name Account : ", "Edit Wallet Information")
            MsgBox(" Information updated! ", MsgBoxStyle.OkOnly)

        End If
        If vbNo Then
            Me.Show()
        End If
    End Sub

    Private Sub btnWithdraw_Click(sender As Object, e As EventArgs) Handles btnWithdraw.Click
        Dim result = MsgBox("Are you sure you want to withdraw funds?", MsgBoxStyle.YesNo, "Withdraw Funds")
        If result = MsgBoxResult.Yes Then
            Dim withdrawalAmount As Decimal
            withdrawalAmount = InputBox("Please enter the amount you wish to withdraw:", "Withdraw Funds")

            Dim currentBalance As Decimal = Decimal.Parse(lblCurrentBalance.Text.Replace("RM", "").Trim())

            If withdrawalAmount <= 0 Then
                MsgBox("Please enter a valid amount.", MsgBoxStyle.OkOnly, "Withdraw Funds")
            ElseIf withdrawalAmount > currentBalance Then
                MsgBox("Insufficient funds. Please enter a smaller amount.", MsgBoxStyle.OkOnly, "Withdraw Funds")
            Else
                Dim newBalance As Decimal = currentBalance - withdrawalAmount
                MsgBox("Withdrawal successful! Your new balance is: RM " & newBalance.ToString("F2"), MsgBoxStyle.OkOnly, "Withdraw Funds")
                lblCurrentBalance.Text = "RM " & newBalance.ToString("F2")

                ' Add transaction to the list box
                lstRecent.Items.Add("Withdrew RM " & withdrawalAmount.ToString("F2") & " on " & DateTime.Now.ToString("g"))
            End If
        End If
    End Sub

    Private Sub btnDeposit_Click(sender As Object, e As EventArgs) Handles btnDeposit.Click
        Dim result = MsgBox("Are you sure you want to deposit funds?", MsgBoxStyle.YesNo, "Deposit Funds")
        If result = MsgBoxResult.Yes Then
            Dim depositAmount As Decimal
            depositAmount = InputBox("Please enter the amount you wish to deposit:", "Deposit Funds")

            Dim currentBalance As Decimal = Decimal.Parse(lblCurrentBalance.Text.Replace("RM", "").Trim())

            If depositAmount <= 0 Then
                MsgBox("Please enter a valid amount.", MsgBoxStyle.OkOnly, "Deposit Funds")
            Else
                Dim newBalance As Decimal = currentBalance + depositAmount
                MsgBox("Deposit successful! Your new balance is: RM " & newBalance.ToString("F2"), MsgBoxStyle.OkOnly, "Deposit Funds")
                lblCurrentBalance.Text = "RM " & newBalance.ToString("F2")

                lstRecent.Items.Add("Deposited RM " & depositAmount.ToString("F2") & " on " & DateTime.Now.ToString("g"))
            End If
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

    Private Sub lblCurrentBalance_Click(sender As Object, e As EventArgs) Handles lblCurrentBalance.Click

    End Sub
End Class