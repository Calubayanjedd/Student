Public Class ucStudentPayments
    Inherits UserControl

    Private studentReg As StudentRegistrationData

    Public Sub New(data As StudentRegistrationData)
        InitializeComponent()
        studentReg = data
    End Sub

    Public Sub SavePayments()
        studentReg.PaymentName = txtPermitName.Text.Trim()
        studentReg.PaymentPermitNo = txtPaymentPermitNumber.Text.Trim()
        studentReg.PaymentMethod = txtPaymentMethod.Text.Trim()
        studentReg.PaymentUpdate = txtPaymentUpdate.Text.Trim()
        Dim parsedAmount As Decimal
        Decimal.TryParse(txtPaymentAmount.Text.Trim(), parsedAmount)
        studentReg.PaymentAmount = parsedAmount

    End Sub

    Private Sub ucStudentPayments_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPermitName.Text = studentReg.FullName
        txtPaymentPermitNumber.Text = studentReg.PermitNumber
    End Sub

    Public Sub LoadPayments()
        txtPermitName.Text = studentReg.PaymentName
        txtPaymentPermitNumber.Text = studentReg.PaymentPermitNo
        txtPaymentMethod.Text = studentReg.PaymentMethod
        txtPaymentUpdate.Text = studentReg.PaymentUpdate
        txtPaymentAmount.Text = studentReg.PaymentAmount.ToString("0")
    End Sub

End Class
