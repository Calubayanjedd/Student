Public Class LoginForm

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim PickingForm As New PickingForm()
        PickingForm.Show()
        Me.Hide() ' Optional: hides the login form
    End Sub

    ' in this form you should create a log in information for anyone, since starting palang naman kayo so kahit yung admin tas admin123 lang na pass, no need na ng database to AHAHAHAHAHHA

End Class
