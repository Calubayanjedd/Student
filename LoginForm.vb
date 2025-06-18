Public Class LoginForm

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim PickingForm As New PickingForm()
        PickingForm.Show()
        Me.Hide() ' Optional: hides the login form
    End Sub

End Class
