Public Class loginchoice
    Private Sub btnCustLogin_Click(sender As Object, e As EventArgs) Handles btnCustLogin.Click
        Dim frm5 As New custlogin()
        frm5.Show()
        Me.Hide()
    End Sub

    Private Sub btnCourLogin_Click(sender As Object, e As EventArgs) Handles btnCourLogin.Click
        Dim frm6 As New courierlogin()
        frm6.Show()
        Me.Hide()
    End Sub
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Oemtilde Then
            Me.Hide()
            Dim previousForm As New mainstart()
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