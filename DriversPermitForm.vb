Imports MySql.Data.MySqlClient

Public Class DriversPermitForm
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim PickingForm As New PickingForm()
        PickingForm.Show()
        Me.Hide() ' Optional: hides the drivers permit form

    End Sub

    Private Sub btnReg_Click(sender As Object, e As EventArgs) Handles btnReg.Click
        Dim Driver_sRegistrationForm As New Driver_sRegistrationForm()
        Driver_sRegistrationForm.Show()
        Me.Hide() ' Optional: hides the drivers permit form

    End Sub

    Private Sub dtvDetails_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtvDetails.CellContentClick
        'DO NOT DELETE
    End Sub

    Private Sub DriversPermitForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'DO NOT DELETE
        LoadAllData()
    End Sub

    Private Sub dtvApplicant_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtvApplicant.CellContentClick
        'DO NOT DELETE
    End Sub

    Private Sub dtvCategory_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtvCategory.CellContentClick
        'DO NOT DELETE
    End Sub

    Private Sub dtvMedCert_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtvMedCert.CellContentClick
        'DO NOT DELETE
    End Sub

    Private Sub LoadAllData()
        Dim connStr As String = "server=localhost;user id=root;password=;database=registration_db;"
        Using conn As New MySqlConnection(connStr)
            Try
                conn.Open()

                Dim applicantQuery As String = "SELECT * FROM Applicants"
                Dim applicantAdapter As New MySqlDataAdapter(applicantQuery, conn)
                Dim applicantTable As New DataTable()
                applicantAdapter.Fill(applicantTable)
                dtvApplicant.DataSource = applicantTable

                Dim categoryQuery As String = "SELECT * FROM LicenseCategories"
                Dim categoryAdapter As New MySqlDataAdapter(categoryQuery, conn)
                Dim categoryTable As New DataTable()
                categoryAdapter.Fill(categoryTable)
                dtvCategory.DataSource = categoryTable

                Dim detailsQuery As String = "SELECT * FROM LicenseDetails"
                Dim detailsAdapter As New MySqlDataAdapter(detailsQuery, conn)
                Dim detailsTable As New DataTable()
                detailsAdapter.Fill(detailsTable)
                dtvDetails.DataSource = detailsTable

                Dim medCertQuery As String = "SELECT * FROM MedicalCertificates"
                Dim medCertAdapter As New MySqlDataAdapter(medCertQuery, conn)
                Dim medCertTable As New DataTable()
                medCertAdapter.Fill(medCertTable)
                dtvMedCert.DataSource = medCertTable

            Catch ex As Exception
                MessageBox.Show("Error loading data: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub
End Class