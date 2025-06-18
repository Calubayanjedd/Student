Public Class ucStudentInstructors
    Inherits UserControl

    Private studentReg As StudentRegistrationData

    Public Sub New(data As StudentRegistrationData)
        InitializeComponent()
        studentReg = data
    End Sub

    Public Sub SaveInstructors()
        studentReg.InstructorName = txtInstructorName.Text.Trim()
        studentReg.InstructorContactNo = txtContact.Text.Trim()
        studentReg.InstructorExpiryDate = dtExpiry.Value.ToString("yyyy-MM-dd")
        studentReg.InstructorIssueDate = dtIssueDate.Value.ToString("yyyy-MM-dd")
    End Sub

    Private Sub ucStudentInstructors_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtExpiry.MinDate = Date.Today.AddDays(1)
    End Sub

    Public Sub LoadInstructors()
        txtInstructorName.Text = studentReg.InstructorName
        txtContact.Text = studentReg.InstructorContactNo
        dtExpiry.Value = If(DateTime.TryParse(studentReg.InstructorExpiryDate, Nothing), DateTime.Parse(studentReg.InstructorExpiryDate), DateTime.Today)
        dtIssueDate.Value = If(DateTime.TryParse(studentReg.InstructorIssueDate, Nothing), DateTime.Parse(studentReg.InstructorIssueDate), DateTime.Today)
    End Sub

End Class
