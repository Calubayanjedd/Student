Imports MySql.Data.MySqlClient

Public Class StudentPermitForm
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim PickingForm As New PickingForm()
        PickingForm.Show()
        Me.Hide() ' Optional: hides the student permit form

    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim StudentRegistrationForm As New StudentRegistrationForm()
        StudentRegistrationForm.Show()
        Me.Hide() ' Optional: hides the student permit form

    End Sub

    Private Sub StudentPermitForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAllData()
    End Sub

    Private Sub dgvApplicant_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvApplicant.CellContentClick

    End Sub

    Private Sub dgvInstructor_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvInstructor.CellContentClick

    End Sub

    Private Sub dgvPermitDetails_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPermitDetails.CellContentClick

    End Sub

    Private Sub dgvTestCenter_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTestCenter.CellContentClick

    End Sub

    Private Sub dgvTest_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTest.CellContentClick

    End Sub

    Private Sub dgvPayment_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPayment.CellContentClick

    End Sub

    Private Sub LoadAllData()
        Dim connStr As String = "server=localhost;user id=root;password=yourpassword;database=yourdbname"
        Using conn As New MySqlConnection(connStr)
            Try
                conn.Open()

                Dim applicantQuery As String = "SELECT * FROM Applicants"
                Dim applicantAdapter As New MySqlDataAdapter(applicantQuery, conn)
                Dim applicantTable As New DataTable()
                applicantAdapter.Fill(applicantTable)
                dgvApplicant.DataSource = applicantTable

                Dim instructorQuery As String = "SELECT * FROM Instructors"
                Dim instructorAdapter As New MySqlDataAdapter(instructorQuery, conn)
                Dim instructorTable As New DataTable()
                instructorAdapter.Fill(instructorTable)
                dgvInstructor.DataSource = instructorTable

                Dim permitQuery As String = "SELECT * FROM StudentPermits"
                Dim permitAdapter As New MySqlDataAdapter(permitQuery, conn)
                Dim permitTable As New DataTable()
                permitAdapter.Fill(permitTable)
                dgvPermitDetails.DataSource = permitTable

                Dim testQuery As String = "SELECT * FROM StudentTest"
                Dim testAdapter As New MySqlDataAdapter(testQuery, conn)
                Dim testTable As New DataTable()
                testAdapter.Fill(testTable)
                dgvTest.DataSource = testTable

                Dim centerQuery As String = "SELECT * FROM TestCenter"
                Dim centerAdapter As New MySqlDataAdapter(centerQuery, conn)
                Dim centerTable As New DataTable()
                centerAdapter.Fill(centerTable)
                dgvTestCenter.DataSource = centerTable

                Dim paymentQuery As String = "SELECT * FROM Payments"
                Dim paymentAdapter As New MySqlDataAdapter(paymentQuery, conn)
                Dim paymentTable As New DataTable()
                paymentAdapter.Fill(paymentTable)
                dgvPayment.DataSource = paymentTable

            Catch ex As Exception
                MessageBox.Show("Error loading data: " & ex.Message)
            End Try
        End Using
    End Sub
End Class