Public Class PickingForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim StudentPermitForm As New StudentPermitForm()
        StudentPermitForm.Show()
        Me.Hide() ' Optional: hides the picking form

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        'Do not delete the design will be broken if deleted
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim DriversPermitForm As New DriversPermitForm()
        DriversPermitForm.Show()
        Me.Hide() ' Optional: hides the picking form

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim result As DialogResult = MessageBox.Show(
        "Are you sure you want to exit?",
        "Confirm Exit",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question
    )

        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub
End Class