Public Class ucStudentTest
    Inherits UserControl

    Private studentReg As StudentRegistrationData

    Public Sub New(data As StudentRegistrationData)
        InitializeComponent()
        studentReg = data
    End Sub

    Public Sub SaveTestData()
        studentReg.TestName = txtTestName.Text.Trim()
        studentReg.TestType = txtTestType.Text.Trim()
        studentReg.TestDate = dtTestDate.Value.ToString("yyyy-MM-dd")
        studentReg.TestResult = txtTestResult.Text.Trim()
    End Sub

    Private Sub ucStudentTest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtTestName.Text = studentReg.FullName
    End Sub

    Public Sub LoadTestData()
        txtTestName.Text = studentReg.TestName
        txtTestType.Text = studentReg.TestType
        dtTestDate.Value = If(DateTime.TryParse(studentReg.TestDate, Nothing), DateTime.Parse(studentReg.TestDate), DateTime.Today)
        txtTestResult.Text = studentReg.TestResult
    End Sub

End Class
