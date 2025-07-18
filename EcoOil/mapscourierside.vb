Public Class mapscourierside
    Private Sub btnKedah_Click(sender As Object, e As EventArgs) Handles btnKedah.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to station your courier in Kedah?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            MessageBox.Show("Your courier has been stationed successfully!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub btnKelantan_Click(sender As Object, e As EventArgs) Handles btnKelantan.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to station your courier in Kelantan?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            MessageBox.Show("Your courier has been stationed successfully!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub btnPerak_Click(sender As Object, e As EventArgs) Handles btnPerak.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to station your courier in Perak?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            MessageBox.Show("Your courier has been stationed successfully!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub btnTerengganu_Click(sender As Object, e As EventArgs) Handles btnTerengganu.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to station your courier Terengganu?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            MessageBox.Show("Your courier has been stationed successfully!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub btnPahang_Click(sender As Object, e As EventArgs) Handles btnPahang.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to station your courier Pahang?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            MessageBox.Show("Your courier has been stationed successfully!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub btnSelangor_Click(sender As Object, e As EventArgs) Handles btnSelangor.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to station your courier Selangor?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            MessageBox.Show("Your courier has been stationed successfully!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub btnN9_Click(sender As Object, e As EventArgs) Handles btnN9.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to station your courier Negeri Sembilan?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            MessageBox.Show("Your courier has been stationed successfully!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub btnJohor_Click(sender As Object, e As EventArgs) Handles btnJohor.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to station your courier Johor?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            MessageBox.Show("Your courier has been stationed successfully!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub btnSabah_Click(sender As Object, e As EventArgs) Handles btnSabah.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to station your courier Sabah?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            MessageBox.Show("Your courier has been stationed successfully!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub btnSarawak_Click(sender As Object, e As EventArgs) Handles btnSarawak.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to station your courier Sarawak?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            MessageBox.Show("Your courier has been stationed successfully!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub btnOption_Click(sender As Object, e As EventArgs) Handles btnOption.Click
        Dim options As New options()
        options.Show()
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