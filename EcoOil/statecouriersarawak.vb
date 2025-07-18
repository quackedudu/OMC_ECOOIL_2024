Public Class statecouriersarawak
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim maps As New maps()
        maps.Show()
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