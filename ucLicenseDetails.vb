Public Class ucLicenseDetails
    Inherits UserControl

    Private regData As RegistrationData

    Public Sub New(data As RegistrationData)
        InitializeComponent()
        regData = data
    End Sub

    Public Sub SaveLicenseDetailsData()
        regData.LicenseType = txtLicenseType.Text.Trim()
        regData.LicenseCode = txtLicenseCode.Text.Trim()
        regData.LicenseNumber = txtLicenseNum.Text.Trim()
        regData.ExpirationDate = dtpExpirationDate.Value.ToString("yyyy-MM-dd")
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)
        ' ' Do not delete this label click event, it is required for design purposes
    End Sub

    Private Sub ucLicenseDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' ' Do not delete this label click event, it is required for design purposes
        dtpExpirationDate.MinDate = Date.Today.AddDays(1)
    End Sub

    Public Sub LoadLicenseDetailsData()
        txtLicenseType.Text = regData.LicenseType
        txtLicenseCode.Text = regData.LicenseCode
        txtLicenseNum.Text = regData.LicenseNumber
        dtpExpirationDate.Value = If(DateTime.TryParse(regData.ExpirationDate, Nothing), DateTime.Parse(regData.ExpirationDate), DateTime.Today)
    End Sub

End Class
