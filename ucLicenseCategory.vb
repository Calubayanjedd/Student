Public Class ucLicenseCategory
    Inherits UserControl

    Private regData As RegistrationData

    Public Sub New(data As RegistrationData)
        InitializeComponent()
        regData = data
    End Sub

    Public Sub SaveLicenseCategoryData()
        regData.CategoryName = txtCategoryName.Text.Trim()
        regData.CategoryDescription = txtDescription.Text.Trim()
    End Sub

    Private Sub ucLicenseCategory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'DO NOT DELETE
    End Sub

    Public Sub LoadLicenceCategoryData()
        txtCategoryName.Text = regData.CategoryName
        txtDescription.Text = regData.CategoryDescription
    End Sub
End Class
