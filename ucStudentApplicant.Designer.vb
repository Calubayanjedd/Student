<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucStudentApplicant
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
        rdFemale = New RadioButton()
        rdMale = New RadioButton()
        Label7 = New Label()
        Label6 = New Label()
        dtBirthdate = New DateTimePicker()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        txtAge = New TextBox()
        txtContact = New TextBox()
        txtAddress = New TextBox()
        txtFullname = New TextBox()
        Label1 = New Label()
        Label8 = New Label()
        txtEmail = New TextBox()
        SuspendLayout()
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(17, 13)
        Label5.Name = "Label5"
        Label5.Size = New Size(157, 28)
        Label5.TabIndex = 10
        Label5.Text = "Applicant Form"
        ' 
        ' rdFemale
        ' 
        rdFemale.AutoSize = True
        rdFemale.Location = New Point(444, 375)
        rdFemale.Name = "rdFemale"
        rdFemale.Size = New Size(78, 24)
        rdFemale.TabIndex = 26
        rdFemale.TabStop = True
        rdFemale.Text = "Female"
        rdFemale.UseVisualStyleBackColor = True
        ' 
        ' rdMale
        ' 
        rdMale.AutoSize = True
        rdMale.Location = New Point(359, 375)
        rdMale.Name = "rdMale"
        rdMale.Size = New Size(63, 24)
        rdMale.TabIndex = 25
        rdMale.TabStop = True
        rdMale.Text = "Male"
        rdMale.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(260, 377)
        Label7.Name = "Label7"
        Label7.Size = New Size(60, 20)
        Label7.TabIndex = 24
        Label7.Text = "Gender:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(281, 322)
        Label6.Name = "Label6"
        Label6.Size = New Size(39, 20)
        Label6.TabIndex = 23
        Label6.Text = "Age:"
        ' 
        ' dtBirthdate
        ' 
        dtBirthdate.Location = New Point(359, 188)
        dtBirthdate.Name = "dtBirthdate"
        dtBirthdate.Size = New Size(203, 27)
        dtBirthdate.TabIndex = 22
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(237, 259)
        Label4.Name = "Label4"
        Label4.Size = New Size(90, 20)
        Label4.TabIndex = 21
        Label4.Text = "Contact No.:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(253, 193)
        Label3.Name = "Label3"
        Label3.Size = New Size(67, 20)
        Label3.TabIndex = 20
        Label3.Text = "Birthday:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(255, 129)
        Label2.Name = "Label2"
        Label2.Size = New Size(65, 20)
        Label2.TabIndex = 19
        Label2.Text = "Address:"
        ' 
        ' txtAge
        ' 
        txtAge.Location = New Point(359, 319)
        txtAge.Name = "txtAge"
        txtAge.Size = New Size(74, 27)
        txtAge.TabIndex = 18
        ' 
        ' txtContact
        ' 
        txtContact.Location = New Point(359, 256)
        txtContact.Name = "txtContact"
        txtContact.Size = New Size(303, 27)
        txtContact.TabIndex = 17
        ' 
        ' txtAddress
        ' 
        txtAddress.Location = New Point(359, 126)
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(303, 27)
        txtAddress.TabIndex = 16
        ' 
        ' txtFullname
        ' 
        txtFullname.Location = New Point(359, 69)
        txtFullname.Name = "txtFullname"
        txtFullname.Size = New Size(303, 27)
        txtFullname.TabIndex = 15
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(248, 72)
        Label1.Name = "Label1"
        Label1.Size = New Size(72, 20)
        Label1.TabIndex = 14
        Label1.Text = "Fullname:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(248, 422)
        Label8.Name = "Label8"
        Label8.Size = New Size(49, 20)
        Label8.TabIndex = 27
        Label8.Text = "Email:"
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(359, 419)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(303, 27)
        txtEmail.TabIndex = 28
        ' 
        ' ucStudentApplicant
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(txtEmail)
        Controls.Add(Label8)
        Controls.Add(rdFemale)
        Controls.Add(rdMale)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(dtBirthdate)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(txtAge)
        Controls.Add(txtContact)
        Controls.Add(txtAddress)
        Controls.Add(txtFullname)
        Controls.Add(Label1)
        Controls.Add(Label5)
        Name = "ucStudentApplicant"
        Size = New Size(917, 492)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents rdFemale As RadioButton
    Friend WithEvents rdMale As RadioButton
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents dtBirthdate As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtAge As TextBox
    Friend WithEvents txtContact As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtFullname As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtEmail As TextBox

End Class
