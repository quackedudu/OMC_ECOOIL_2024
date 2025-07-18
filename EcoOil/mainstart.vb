Public Class mainstart
    Private Sub btnSignup_Click(sender As Object, e As EventArgs) Handles btnSignup.Click
        Dim signupchoice As New signupchoice()
        signupchoice.Show()
        Me.Hide()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim loginchoice As New loginchoice()
        loginchoice.Show()
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
