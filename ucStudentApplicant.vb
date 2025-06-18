Imports Org.BouncyCastle.Ocsp

Public Class ucStudentApplicant
    Inherits UserControl

    Private studentReg As StudentRegistrationData

    Public Sub New(data As StudentRegistrationData)
        InitializeComponent()
        studentReg = data
    End Sub

    Public Sub SaveStudentApplicationData()
        studentReg.FullName = txtFullname.Text.Trim()
        studentReg.Address = txtAddress.Text.Trim()
        studentReg.Birthday = dtBirthdate.Value.ToString("yyyy-MM-dd")
        studentReg.Gender = If(rdMale.Checked, "Male", If(rdFemale.Checked, "Female", ""))
        studentReg.ContactNo = txtContact.Text.Trim()
        studentReg.Age = If(Integer.TryParse(txtAge.Text.Trim(), Nothing), Convert.ToInt32(txtAge.Text.Trim()), 0)
        studentReg.Email = txtEmail.Text.Trim()
    End Sub

    Private Sub ucStudentApplicant_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtBirthdate.MaxDate = Date.Today
    End Sub

    Public Sub LoadStudentApplicationData()
        txtFullname.Text = studentReg.FullName
        txtAddress.Text = studentReg.Address
        dtBirthdate.Value = If(DateTime.TryParse(studentReg.Birthday, Nothing), DateTime.Parse(studentReg.Birthday), DateTime.Today)
        If studentReg.Gender = "Male" Then rdMale.Checked = True
        If studentReg.Gender = "Female" Then rdFemale.Checked = True
        txtContact.Text = studentReg.ContactNo
        txtAge.Text = studentReg.Age.ToString()
        txtEmail.Text = studentReg.Email
    End Sub

    Private Sub dtBirthdate_ValueChanged(sender As Object, e As EventArgs) Handles dtBirthdate.ValueChanged
        Dim today As Date = Date.Today
        Dim birthDate As Date = dtBirthdate.Value
        Dim age As Integer = today.Year - birthDate.Year

        If birthDate > today.AddYears(-age) Then
            age -= 1
        End If

        txtAge.Text = age.ToString()
    End Sub
End Class
