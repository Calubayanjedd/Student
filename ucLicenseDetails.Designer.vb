<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucLicenseDetails
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label5 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label6 = New Label()
        txtLicenseType = New TextBox()
        txtLicenseCode = New TextBox()
        txtLicenseNum = New TextBox()
        dtpExpirationDate = New DateTimePicker()
        SuspendLayout()
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(29, 22)
        Label5.Name = "Label5"
        Label5.Size = New Size(153, 28)
        Label5.TabIndex = 11
        Label5.Text = "License Details"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(204, 147)
        Label2.Name = "Label2"
        Label2.Size = New Size(93, 20)
        Label2.TabIndex = 13
        Label2.Text = "License type:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(200, 212)
        Label3.Name = "Label3"
        Label3.Size = New Size(97, 20)
        Label3.TabIndex = 14
        Label3.Text = "License code:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(213, 283)
        Label4.Name = "Label4"
        Label4.Size = New Size(84, 20)
        Label4.TabIndex = 15
        Label4.Text = "License no.:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(184, 352)
        Label6.Name = "Label6"
        Label6.Size = New Size(113, 20)
        Label6.TabIndex = 16
        Label6.Text = "Expiration date:"
        ' 
        ' txtLicenseType
        ' 
        txtLicenseType.Location = New Point(362, 144)
        txtLicenseType.Name = "txtLicenseType"
        txtLicenseType.Size = New Size(311, 27)
        txtLicenseType.TabIndex = 18
        ' 
        ' txtLicenseCode
        ' 
        txtLicenseCode.Location = New Point(362, 209)
        txtLicenseCode.Name = "txtLicenseCode"
        txtLicenseCode.Size = New Size(311, 27)
        txtLicenseCode.TabIndex = 19
        ' 
        ' txtLicenseNum
        ' 
        txtLicenseNum.Location = New Point(362, 280)
        txtLicenseNum.Name = "txtLicenseNum"
        txtLicenseNum.Size = New Size(311, 27)
        txtLicenseNum.TabIndex = 20
        ' 
        ' dtpExpirationDate
        ' 
        dtpExpirationDate.Location = New Point(362, 347)
        dtpExpirationDate.Name = "dtpExpirationDate"
        dtpExpirationDate.Size = New Size(169, 27)
        dtpExpirationDate.TabIndex = 21
        ' 
        ' ucLicenseDetails
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(dtpExpirationDate)
        Controls.Add(txtLicenseNum)
        Controls.Add(txtLicenseCode)
        Controls.Add(txtLicenseType)
        Controls.Add(Label6)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label5)
        Name = "ucLicenseDetails"
        Size = New Size(917, 492)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtLicenseType As TextBox
    Friend WithEvents txtLicenseCode As TextBox
    Friend WithEvents txtLicenseNum As TextBox
    Friend WithEvents dtpExpirationDate As DateTimePicker
    Friend WithEvents btnNext As Button

End Class
