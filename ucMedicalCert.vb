Public Class ucMedicalCert
    Inherits UserControl

    Private regData As RegistrationData

    Public Sub New(data As RegistrationData)
        InitializeComponent()
        regData = data
    End Sub

    Public Sub SaveMedicalData()
        regData.CertName = txtCertName.Text.Trim()
        regData.CertContactNo = txtContact.Text.Trim()
        regData.Examination = txtExamination.Text.Trim()
        regData.PatientCondition = txtCondition.Text.Trim()
    End Sub

    Private Sub ucMedicalCert_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'DO NOT DELETE
        txtCertName.Text = regData.FullName
        txtContact.Text = regData.ContactNo
    End Sub

    Public Sub LoadMedicalData()
        txtCertName.Text = regData.CertName
        txtContact.Text = regData.CertContactNo
        txtExamination.Text = regData.Examination
        txtCondition.Text = regData.PatientCondition
    End Sub

End Class
