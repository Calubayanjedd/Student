<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucStudentInstructors
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
        txtInstructorName = New TextBox()
        txtContact = New TextBox()
        dtExpiry = New DateTimePicker()
        dtIssueDate = New DateTimePicker()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        SuspendLayout()
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(17, 15)
        Label5.Name = "Label5"
        Label5.Size = New Size(105, 28)
        Label5.TabIndex = 10
        Label5.Text = "Instructor"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(292, 126)
        Label1.Name = "Label1"
        Label1.Size = New Size(52, 20)
        Label1.TabIndex = 11
        Label1.Text = "Name:"
        ' 
        ' txtInstructorName
        ' 
        txtInstructorName.Location = New Point(372, 123)
        txtInstructorName.Name = "txtInstructorName"
        txtInstructorName.Size = New Size(303, 27)
        txtInstructorName.TabIndex = 16
        ' 
        ' txtContact
        ' 
        txtContact.Location = New Point(372, 193)
        txtContact.Name = "txtContact"
        txtContact.Size = New Size(303, 27)
        txtContact.TabIndex = 17
        ' 
        ' dtExpiry
        ' 
        dtExpiry.Location = New Point(372, 267)
        dtExpiry.Name = "dtExpiry"
        dtExpiry.Size = New Size(188, 27)
        dtExpiry.TabIndex = 18
        ' 
        ' dtIssueDate
        ' 
        dtIssueDate.Location = New Point(372, 338)
        dtIssueDate.Name = "dtIssueDate"
        dtIssueDate.Size = New Size(188, 27)
        dtIssueDate.TabIndex = 19
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(257, 196)
        Label2.Name = "Label2"
        Label2.Size = New Size(87, 20)
        Label2.TabIndex = 20
        Label2.Text = "Contact no.:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(256, 272)
        Label3.Name = "Label3"
        Label3.Size = New Size(88, 20)
        Label3.TabIndex = 21
        Label3.Text = "Expiry Date:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(264, 343)
        Label4.Name = "Label4"
        Label4.Size = New Size(80, 20)
        Label4.TabIndex = 22
        Label4.Text = "Issue Date:"
        ' 
        ' ucStudentInstructors
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(dtIssueDate)
        Controls.Add(dtExpiry)
        Controls.Add(txtContact)
        Controls.Add(txtInstructorName)
        Controls.Add(Label1)
        Controls.Add(Label5)
        Name = "ucStudentInstructors"
        Size = New Size(917, 492)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtInstructorName As TextBox
    Friend WithEvents txtContact As TextBox
    Friend WithEvents dtExpiry As DateTimePicker
    Friend WithEvents dtIssueDate As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label

End Class
