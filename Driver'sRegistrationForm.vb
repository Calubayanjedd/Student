Imports MySql.Data.MySqlClient

Public Class Driver_sRegistrationForm
    Private regData As New RegistrationData()
    Private currentStep As Integer = 1

    Private Sub Driver_sRegistrationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadStep(currentStep)
    End Sub

    Private Sub LoadStep(stepIndex As Integer)
        mainPanel.Controls.Clear()
        Select Case stepIndex
            Case 1
                Dim step1 As New ucApplicant(regData)
                step1.LoadApplicantData()
                mainPanel.Controls.Add(step1)
                step1.Dock = DockStyle.Fill
            Case 2
                Dim step2 As New ucLicenseCategory(regData)
                step2.LoadLicenceCategoryData()
                mainPanel.Controls.Add(step2)
                step2.Dock = DockStyle.Fill
            Case 3
                Dim step3 As New ucLicenseDetails(regData)
                step3.LoadLicenseDetailsData()
                mainPanel.Controls.Add(step3)
                step3.Dock = DockStyle.Fill
            Case 4
                Dim step4 As New ucMedicalCert(regData)
                step4.LoadMedicalData()
                mainPanel.Controls.Add(step4)
                step4.Dock = DockStyle.Fill
        End Select
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If currentStep = 1 Then
            Dim uc = TryCast(mainPanel.Controls(0), ucApplicant)
            If uc IsNot Nothing Then
                uc.SaveApplicantData()
            End If
        ElseIf currentStep = 2 Then
            Dim uc = TryCast(mainPanel.Controls(0), ucLicenseCategory)
            If uc IsNot Nothing Then
                uc.SaveLicenseCategoryData()
            End If
        ElseIf currentStep = 3 Then
            Dim uc = TryCast(mainPanel.Controls(0), ucLicenseDetails)
            If uc IsNot Nothing Then
                uc.SaveLicenseDetailsData()
            End If
        ElseIf currentStep = 4 Then
            Dim uc = TryCast(mainPanel.Controls(0), ucMedicalCert)
            If uc IsNot Nothing Then
                uc.SaveMedicalData()
            End If
        End If
        If currentStep < 4 Then
            currentStep += 1
            LoadStep(currentStep)
        Else
            Dim errorMsg As String = ""
            If ValidateRegistrationData(regData, errorMsg) Then
                Try
                    SaveRegistrationData(regData)
                    MessageBox.Show("Registration successfully saved to the database.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Dim bturn As New DriversPermitForm()
                    bturn.Show()
                    Me.Hide()
                Catch ex As Exception
                    MessageBox.Show("An error occurred while saving the registration: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            Else
                MessageBox.Show(errorMsg, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        If currentStep > 1 Then
            currentStep -= 1
            LoadStep(currentStep)
        End If
    End Sub

    Private Function ValidateRegistrationData(data As RegistrationData, ByRef errorMessage As String) As Boolean
        If String.IsNullOrEmpty(data.FullName) Then
            errorMessage = "Full Name is required."
            Return False
        End If
        If String.IsNullOrEmpty(data.Address) Then
            errorMessage = "Address is required."
            Return False
        End If
        If String.IsNullOrEmpty(data.CategoryName) Then
            errorMessage = "License category is required."
            Return False
        End If
        If String.IsNullOrEmpty(data.LicenseNumber) Then
            errorMessage = "License number is required."
            Return False
        End If
        If String.IsNullOrEmpty(data.CertName) Then
            errorMessage = "Medical certificate name is required."
            Return False
        End If

        Dim birthDate As Date
        If Not Date.TryParse(data.Birthday, birthDate) Then
            errorMessage = "Invalid birth date."
            Return False
        End If

        Dim today As Date = Date.Today
        Dim age As Integer = today.Year - birthDate.Year
        If birthDate > today.AddYears(-age) Then age -= 1

        If age < 17 Then
            errorMessage = "You must be at least 17 years old to register."
            Return False
        End If

        errorMessage = ""
        Return True
    End Function


    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        Dim Pick As New PickingForm()
        Pick.Show()
        Me.Hide()
    End Sub

    Private Sub SaveRegistrationData(data As RegistrationData)
        Dim connStr As String = "server=localhost;user id=root;password=;database=driversdb;"
        Using conn As New MySqlConnection(connStr)
            conn.Open()
            Dim transaction As MySqlTransaction = conn.BeginTransaction()

            Try
                ' Insert into Applicants table
                Dim applicantCmd As New MySqlCommand("INSERT INTO Applicants (FullName, Address, ContactNo, Age, Birthday, Gender) VALUES (@FullName, @Address, @ContactNo, @Age, @Birthday, @Gender);", conn, transaction)

                applicantCmd.Parameters.AddWithValue("@FullName", data.FullName)
                applicantCmd.Parameters.AddWithValue("@Address", data.Address)
                applicantCmd.Parameters.AddWithValue("@ContactNo", data.ContactNo)
                applicantCmd.Parameters.AddWithValue("@Age", data.Age)
                applicantCmd.Parameters.AddWithValue("@Birthday", Date.Parse(data.Birthday))
                applicantCmd.Parameters.AddWithValue("@Gender", data.Gender)
                applicantCmd.ExecuteNonQuery()

                ' Insert into LicenseCategories table
                Dim categoryCmd As New MySqlCommand("INSERT INTO LicenseCategories (CategoryName, Description) VALUES (@CategoryName, @Description);", conn, transaction)
                categoryCmd.Parameters.AddWithValue("@CategoryName", data.CategoryName)
                categoryCmd.Parameters.AddWithValue("@Description", data.CategoryDescription)
                categoryCmd.ExecuteNonQuery()

                ' Insert into LicenseDetails table
                Dim detailsCmd As New MySqlCommand("INSERT INTO LicenseDetails (LicenseType, LicenseCode, LicenseNumber, ExpirationDate)VALUES (@LicenseType, @LicenseCode, @LicenseNumber, @ExpirationDate);", conn, transaction)
                detailsCmd.Parameters.AddWithValue("@LicenseType", data.LicenseType)
                detailsCmd.Parameters.AddWithValue("@LicenseCode", data.LicenseCode)
                detailsCmd.Parameters.AddWithValue("@LicenseNumber", data.LicenseNumber)
                detailsCmd.Parameters.AddWithValue("@ExpirationDate", Date.Parse(data.ExpirationDate))
                detailsCmd.ExecuteNonQuery()

                ' Insert into MedicalCertificates table
                Dim medCmd As New MySqlCommand("INSERT INTO MedicalCertificates (CertName, CertContactNo, Examination, PatientCondition) VALUES (@CertName, @CertContactNo, @Examination, @PatientCondition);", conn, transaction)
                medCmd.Parameters.AddWithValue("@CertName", data.CertName)
                medCmd.Parameters.AddWithValue("@CertContactNo", data.CertContactNo)
                medCmd.Parameters.AddWithValue("@Examination", data.Examination)
                medCmd.Parameters.AddWithValue("@PatientCondition", data.PatientCondition)
                medCmd.ExecuteNonQuery()

                transaction.Commit()
            Catch ex As Exception
                transaction.Rollback()
                Throw New Exception("Database save failed: " & ex.Message)
            End Try
        End Using
    End Sub
End Class
