Public Class ucApplicant
    Inherits UserControl

    Private regData As RegistrationData
    Private isDriver As Boolean = False
    Public Sub New(data As RegistrationData)
        InitializeComponent()
        regData = data
    End Sub

    Public Sub SaveApplicantData()
        regData.FullName = txtFullname.Text.Trim()
        regData.Address = txtAddress.Text.Trim()
        regData.Birthday = dtBirthday.Value.ToString("yyyy-MM-dd")
        regData.ContactNo = txtContact.Text.Trim()
        regData.Age = If(Integer.TryParse(txtAge.Text.Trim(), Nothing), Convert.ToInt32(txtAge.Text.Trim()), 0)
        regData.Gender = If(rbMale.Checked, "Male", If(rbFemale.Checked, "Female", ""))
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        'DO NOT DELETE
    End Sub

    Private Sub ucApplicant_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'DO NOT DELETE
        dtBirthday.MaxDate = Date.Today
    End Sub

    Public Sub LoadApplicantData()
        txtFullname.Text = regData.FullName
        txtAddress.Text = regData.Address
        dtBirthday.Value = If(DateTime.TryParse(regData.Birthday, Nothing), DateTime.Parse(regData.Birthday), DateTime.Today)
        txtContact.Text = regData.ContactNo
        txtAge.Text = regData.Age.ToString()
        If regData.Gender = "Male" Then rbMale.Checked = True
        If regData.Gender = "Female" Then rbFemale.Checked = True
    End Sub

    Private Sub dtBirthday_ValueChanged(sender As Object, e As EventArgs) Handles dtBirthday.ValueChanged
        Dim today As Date = Date.Today
        Dim birthDate As Date = dtBirthday.Value
        Dim age As Integer = today.Year - birthDate.Year

        If birthDate > today.AddYears(-age) Then
            age -= 1
        End If

        txtAge.Text = age.ToString()
    End Sub
End Class
