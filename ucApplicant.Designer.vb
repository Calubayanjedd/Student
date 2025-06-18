<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucApplicant
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
        Label1 = New Label()
        txtFullname = New TextBox()
        txtAddress = New TextBox()
        txtContact = New TextBox()
        txtAge = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        dtBirthday = New DateTimePicker()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        rbMale = New RadioButton()
        rbFemale = New RadioButton()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(54, 85)
        Label1.Name = "Label1"
        Label1.Size = New Size(72, 20)
        Label1.TabIndex = 0
        Label1.Text = "Fullname:"
        ' 
        ' txtFullname
        ' 
        txtFullname.Location = New Point(158, 82)
        txtFullname.Name = "txtFullname"
        txtFullname.Size = New Size(303, 27)
        txtFullname.TabIndex = 1
        ' 
        ' txtAddress
        ' 
        txtAddress.Location = New Point(158, 142)
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(303, 27)
        txtAddress.TabIndex = 2
        ' 
        ' txtContact
        ' 
        txtContact.Location = New Point(158, 272)
        txtContact.Name = "txtContact"
        txtContact.Size = New Size(303, 27)
        txtContact.TabIndex = 3
        ' 
        ' txtAge
        ' 
        txtAge.Location = New Point(158, 335)
        txtAge.Name = "txtAge"
        txtAge.Size = New Size(74, 27)
        txtAge.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(54, 145)
        Label2.Name = "Label2"
        Label2.Size = New Size(65, 20)
        Label2.TabIndex = 5
        Label2.Text = "Address:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(52, 211)
        Label3.Name = "Label3"
        Label3.Size = New Size(67, 20)
        Label3.TabIndex = 6
        Label3.Text = "Birthday:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(36, 275)
        Label4.Name = "Label4"
        Label4.Size = New Size(90, 20)
        Label4.TabIndex = 7
        Label4.Text = "Contact No.:"
        ' 
        ' dtBirthday
        ' 
        dtBirthday.Location = New Point(158, 206)
        dtBirthday.Name = "dtBirthday"
        dtBirthday.Size = New Size(203, 27)
        dtBirthday.TabIndex = 8
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(30, 17)
        Label5.Name = "Label5"
        Label5.Size = New Size(157, 28)
        Label5.TabIndex = 9
        Label5.Text = "Applicant Form"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(80, 338)
        Label6.Name = "Label6"
        Label6.Size = New Size(39, 20)
        Label6.TabIndex = 10
        Label6.Text = "Age:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(59, 393)
        Label7.Name = "Label7"
        Label7.Size = New Size(60, 20)
        Label7.TabIndex = 11
        Label7.Text = "Gender:"
        ' 
        ' rbMale
        ' 
        rbMale.AutoSize = True
        rbMale.Location = New Point(158, 391)
        rbMale.Name = "rbMale"
        rbMale.Size = New Size(63, 24)
        rbMale.TabIndex = 12
        rbMale.TabStop = True
        rbMale.Text = "Male"
        rbMale.UseVisualStyleBackColor = True
        ' 
        ' rbFemale
        ' 
        rbFemale.AutoSize = True
        rbFemale.Location = New Point(243, 391)
        rbFemale.Name = "rbFemale"
        rbFemale.Size = New Size(78, 24)
        rbFemale.TabIndex = 13
        rbFemale.TabStop = True
        rbFemale.Text = "Female"
        rbFemale.UseVisualStyleBackColor = True
        ' 
        ' ucApplicant
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(rbFemale)
        Controls.Add(rbMale)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(dtBirthday)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(txtAge)
        Controls.Add(txtContact)
        Controls.Add(txtAddress)
        Controls.Add(txtFullname)
        Controls.Add(Label1)
        Name = "ucApplicant"
        Size = New Size(917, 492)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtFullname As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtContact As TextBox
    Friend WithEvents txtAge As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents dtBirthday As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents rbMale As RadioButton
    Friend WithEvents rbFemale As RadioButton

End Class
