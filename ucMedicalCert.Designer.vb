<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucMedicalCert
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        txtCertName = New TextBox()
        txtContact = New TextBox()
        txtExamination = New TextBox()
        txtCondition = New TextBox()
        SuspendLayout()
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(29, 22)
        Label5.Name = "Label5"
        Label5.Size = New Size(193, 28)
        Label5.TabIndex = 12
        Label5.Text = "Medical Certificate"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(254, 116)
        Label1.Name = "Label1"
        Label1.Size = New Size(52, 20)
        Label1.TabIndex = 13
        Label1.Text = "Name:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(219, 185)
        Label2.Name = "Label2"
        Label2.Size = New Size(87, 20)
        Label2.TabIndex = 14
        Label2.Text = "Contact no.:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(212, 251)
        Label3.Name = "Label3"
        Label3.Size = New Size(94, 20)
        Label3.TabIndex = 15
        Label3.Text = "Examination:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(182, 322)
        Label4.Name = "Label4"
        Label4.Size = New Size(124, 20)
        Label4.TabIndex = 16
        Label4.Text = "Patient condition:"
        ' 
        ' txtCertName
        ' 
        txtCertName.Location = New Point(338, 113)
        txtCertName.Name = "txtCertName"
        txtCertName.Size = New Size(323, 27)
        txtCertName.TabIndex = 17
        ' 
        ' txtContact
        ' 
        txtContact.Location = New Point(338, 182)
        txtContact.Name = "txtContact"
        txtContact.Size = New Size(323, 27)
        txtContact.TabIndex = 18
        ' 
        ' txtExamination
        ' 
        txtExamination.Location = New Point(338, 248)
        txtExamination.Name = "txtExamination"
        txtExamination.Size = New Size(323, 27)
        txtExamination.TabIndex = 19
        ' 
        ' txtCondition
        ' 
        txtCondition.Location = New Point(338, 319)
        txtCondition.Name = "txtCondition"
        txtCondition.Size = New Size(323, 27)
        txtCondition.TabIndex = 20
        ' 
        ' ucMedicalCert
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(txtCondition)
        Controls.Add(txtExamination)
        Controls.Add(txtContact)
        Controls.Add(txtCertName)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Label5)
        Name = "ucMedicalCert"
        Size = New Size(917, 492)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCertName As TextBox
    Friend WithEvents txtContact As TextBox
    Friend WithEvents txtExamination As TextBox
    Friend WithEvents txtCondition As TextBox

End Class
