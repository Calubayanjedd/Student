Public Class ucStudentPermitDetails
    Inherits UserControl

    Private studentReg As StudentRegistrationData

    Public Sub New(data As StudentRegistrationData)
        InitializeComponent()
        studentReg = data
    End Sub

    Public Sub SavePermitDetails()
        studentReg.PermitName = txtPermitName.Text.Trim()
        studentReg.PermitNumber = txtPermitNumber.Text.Trim()
        studentReg.PermitExpiryDate = dtExpiryDate.Value.ToString("yyyy-MM-dd")
        studentReg.PermitIssueDate = dtIssueDate.Value.ToString("yyyy-MM-dd")
    End Sub

    Private Sub ucStudentPermitDetailsvb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPermitName.Text = studentReg.FullName
        dtExpiryDate.MinDate = Date.Today.AddDays(1)
    End Sub

    Public Sub LoadPermitDetails()
        txtPermitName.Text = studentReg.PermitName
        txtPermitNumber.Text = studentReg.PermitNumber
        dtExpiryDate.Value = If(DateTime.TryParse(studentReg.PermitExpiryDate, Nothing), DateTime.Parse(studentReg.PermitExpiryDate), DateTime.Today)
        dtIssueDate.Value = If(DateTime.TryParse(studentReg.PermitIssueDate, Nothing), DateTime.Parse(studentReg.PermitIssueDate), DateTime.Today)
    End Sub

End Class
