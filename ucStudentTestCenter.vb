Public Class ucStudentTestCenter
    Inherits UserControl

    Private studentReg As StudentRegistrationData

    Public Sub New(data As StudentRegistrationData)
        InitializeComponent()
        studentReg = data
    End Sub

    Public Sub SaveTestCenterData()
        studentReg.TestCenterLocation = txtTestCenterLocation.Text.Trim()
        studentReg.TestCenterName = txtTestCenterName.Text.Trim()
    End Sub

    Private Sub ucStudentTestCenter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtTestCenterName.Text = studentReg.FullName
    End Sub

    Public Sub LoadTestCenterData()
        txtTestCenterLocation.Text = studentReg.TestCenterLocation
        txtTestCenterName.Text = studentReg.TestCenterName
    End Sub

End Class
