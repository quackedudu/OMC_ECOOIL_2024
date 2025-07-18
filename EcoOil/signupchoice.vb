Public Class signupchoice
    Private Sub btnCustSignup_Click(sender As Object, e As EventArgs) Handles btnCustSignup.Click
        Dim custcreateacc As New custcreateacc()
        custcreateacc.Show()
        Me.Hide()
    End Sub

    Private Sub btnCourSignup_Click(sender As Object, e As EventArgs) Handles btnCourSignup.Click
        Dim couriercreateacc As New couriercreateacc()
        couriercreateacc.Show()
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