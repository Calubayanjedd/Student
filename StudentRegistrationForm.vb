Imports System.Reflection
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class StudentRegistrationForm
    Private studentReg As New StudentRegistrationData()
    Private currentStep As Integer = 1
    Private Sub StudentRegistrationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadStep(currentStep) ' Load the first step when the form loads
    End Sub

    Private Sub LoadStep(stepIndex As Integer) 'THIS WILL MAKE SURE THE REGISTRATION IS ON SEQUENCE STRUCTURE.
        mainPanel.Controls.Clear()
        Select Case stepIndex
            Case 1
                Dim step1 As New ucStudentApplicant(studentReg)
                step1.LoadStudentApplicationData()
                mainPanel.Controls.Add(step1)
                step1.Dock = DockStyle.Fill
            Case 2
                Dim step2 As New ucStudentInstructors(studentReg)
                step2.LoadInstructors()
                mainPanel.Controls.Add(step2)
                step2.Dock = DockStyle.Fill
            Case 3
                Dim step3 As New ucStudentPermitDetails(studentReg)
                step3.LoadPermitDetails()
                mainPanel.Controls.Add(step3)
                step3.Dock = DockStyle.Fill
            Case 4
                Dim step4 As New ucStudentPayments(studentReg)
                step4.LoadPayments()
                mainPanel.Controls.Add(step4)
                step4.Dock = DockStyle.Fill
            Case 5
                Dim step5 As New ucStudentTest(studentReg)
                step5.LoadTestData()
                mainPanel.Controls.Add(step5)
                step5.Dock = DockStyle.Fill
            Case 6
                Dim step6 As New ucStudentTestCenter(studentReg)
                step6.LoadTestCenterData()
                mainPanel.Controls.Add(step6)
                step6.Dock = DockStyle.Fill
        End Select
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If currentStep = 1 Then
            Dim uc = TryCast(mainPanel.Controls(0), ucStudentApplicant)
            If uc IsNot Nothing Then
                uc.SaveStudentApplicationData()
            End If
        ElseIf currentStep = 2 Then
            Dim uc = TryCast(mainPanel.Controls(0), ucStudentInstructors)
            If uc IsNot Nothing Then
                uc.SaveInstructors()
            End If
        ElseIf currentStep = 3 Then
            Dim uc = TryCast(mainPanel.Controls(0), ucStudentPermitDetails)
            If uc IsNot Nothing Then
                uc.SavePermitDetails()
            End If
        ElseIf currentStep = 4 Then
            Dim uc = TryCast(mainPanel.Controls(0), ucStudentPayments)
            If uc IsNot Nothing Then
                uc.SavePayments()
            End If
        ElseIf currentStep = 5 Then
            Dim uc = TryCast(mainPanel.Controls(0), ucStudentTest)
            If uc IsNot Nothing Then
                uc.SaveTestData()
            End If
        ElseIf currentStep = 6 Then
            Dim uc = TryCast(mainPanel.Controls(0), ucStudentTestCenter)
            If uc IsNot Nothing Then
                uc.SaveTestCenterData()
            End If
        End If
        If currentStep < 6 Then
            currentStep += 1
            LoadStep(currentStep)
        Else
            Try
                Dim errMsg As String = ""
                If ValidateRegistrationData(studentReg, errMsg) Then
                    SaveStudentRegistrationData(studentReg)
                    MessageBox.Show("Student registration successfully saved to the database.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Dim StudentPermitForm As New StudentPermitForm()
                    StudentPermitForm.Show()
                    Me.Hide()
                Else
                    MessageBox.Show(errMsg, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Catch ex As Exception
                MessageBox.Show("An error occurred while saving the registration: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        If currentStep > 1 Then
            currentStep -= 1
            LoadStep(currentStep)
        End If
    End Sub

    Private Function ValidateRegistrationData(data As StudentRegistrationData, ByRef errorMessage As String) As Boolean
        If String.IsNullOrWhiteSpace(data.FullName) Then
            errorMessage = "Full Name is required."
            Return False
        End If
        If String.IsNullOrWhiteSpace(data.Address) Then
            errorMessage = "Address is required."
            Return False
        End If
        If String.IsNullOrWhiteSpace(data.InstructorName) Then
            errorMessage = "Instructor name is required."
            Return False
        End If
        If String.IsNullOrWhiteSpace(data.PermitNumber) Then
            errorMessage = "Permit number is required."
            Return False
        End If
        If data.PaymentAmount <= 0D Then
            errorMessage = "Payment amount must be greater than zero."
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

        If age < 16 Then
            errorMessage = "You must be at least 16 years old to register."
            Return False
        End If

        errorMessage = ""
        Return True
    End Function

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        Dim pk As New PickingForm()
        pk.Show()
        Me.Hide() ' Optional: hides the registration form
    End Sub

    Private Sub SaveStudentRegistrationData(data As StudentRegistrationData)
        Dim connStr As String = "server=localhost;user id=root;password=;database=studentsdb;"
        Using conn As New MySqlConnection(connStr)
            conn.Open()
            Dim transaction As MySqlTransaction = conn.BeginTransaction()

            Try
                Dim studentCmd As New MySqlCommand("INSERT INTO StudentApplicants (StudentFullName, Address, ContactNo, Email, Age, Birthday, Gender) VALUES (@StudentFullName, @Address, @ContactNo, @Email, @Age, @Birthday, @Gender);", conn, transaction)

                studentCmd.Parameters.AddWithValue("@StudentFullName", data.FullName)
                studentCmd.Parameters.AddWithValue("@Address", data.Address)
                studentCmd.Parameters.AddWithValue("@ContactNo", data.ContactNo)
                studentCmd.Parameters.AddWithValue("@Email", data.Email)
                studentCmd.Parameters.AddWithValue("@Age", data.Age)
                studentCmd.Parameters.AddWithValue("@Birthday", Date.Parse(data.Birthday))
                studentCmd.Parameters.AddWithValue("@Gender", data.Gender)
                studentCmd.ExecuteNonQuery()

                Dim instrCmd As New MySqlCommand("INSERT INTO Instructors (InstructorName, InstructorContactNo, IssueDate, ExpiryDate) VALUES (@InstructorName, @InstructorContactNo, @IssueDate, @ExpiryDate);", conn, transaction)
                instrCmd.Parameters.AddWithValue("@InstructorName", data.InstructorName)
                instrCmd.Parameters.AddWithValue("@InstructorContactNo", data.InstructorContactNo)
                instrCmd.Parameters.AddWithValue("@IssueDate", data.InstructorExpiryDate)
                instrCmd.Parameters.AddWithValue("@ExpiryDate", Date.Parse(data.InstructorIssueDate))
                instrCmd.ExecuteNonQuery()

                Dim permitCmd As New MySqlCommand("INSERT INTO StudentPermits (PermitStudentName, PermitNumber, IssueDate, ExpiryDate) VALUES (@PermitStudentName, @PermitNumber, @IssueDate, @ExpiryDate);", conn, transaction)
                permitCmd.Parameters.AddWithValue("@PermitStudentName", data.PermitName)
                permitCmd.Parameters.AddWithValue("@PermitNumber", data.PermitNumber)
                permitCmd.Parameters.AddWithValue("@IssueDate", Date.Parse(data.PermitIssueDate))
                permitCmd.Parameters.AddWithValue("@ExpiryDate", Date.Parse(data.PermitExpiryDate))

                Dim paymentCmd As New MySqlCommand("INSERT INTO StudentPayments (PaymentStudentName, PermitNumber, PaymentAmount, PaymentUpdate, PaymentMethod) VALUES (@PaymentStudentName, @PermitNumber, @PaymentAmount, @PaymentUpdate, @PaymentMethod);", conn, transaction)
                paymentCmd.Parameters.AddWithValue("@PaymentStudentName", data.PaymentName)
                paymentCmd.Parameters.AddWithValue("@PermitNumber", data.PaymentPermitNo)
                paymentCmd.Parameters.AddWithValue("@PaymentAmount", data.PaymentAmount)
                paymentCmd.Parameters.AddWithValue("@PaymentUpdate", Date.Parse(data.PaymentUpdate))
                paymentCmd.Parameters.AddWithValue("@PaymentMethod", data.PaymentMethod)
                paymentCmd.ExecuteNonQuery()

                Dim testCmd As New MySqlCommand("INSERT INTO StudentTest (TestStudentName, TestType, TestDate, TestResult) VALUES (@TestStudentName, @TestType, @TestDate, @TestResult);", conn, transaction)
                testCmd.Parameters.AddWithValue("@TestStudentName", data.TestName)
                testCmd.Parameters.AddWithValue("@TestType", data.TestType)
                testCmd.Parameters.AddWithValue("@TestDate", Date.Parse(data.TestDate))
                testCmd.Parameters.AddWithValue("@TestResult", data.TestResult)
                testCmd.ExecuteNonQuery()

                Dim centerCmd As New MySqlCommand("INSERT INTO TestCenter (TestStudentName, TestLocation) VALUES (@TestStudentName, @TestLocation);", conn, transaction)
                centerCmd.Parameters.AddWithValue("@TestStudentName", data.TestCenterName)
                centerCmd.Parameters.AddWithValue("@TestLocation", data.TestCenterLocation)
                centerCmd.ExecuteNonQuery()

                transaction.Commit()
            Catch ex As Exception
                transaction.Rollback()
                MessageBox.Show("Error saving data: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub
End Class