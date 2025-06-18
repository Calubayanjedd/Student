<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucStudentPermitDetails
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
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        dtIssueDate = New DateTimePicker()
        dtExpiryDate = New DateTimePicker()
        txtPermitNumber = New TextBox()
        txtPermitName = New TextBox()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(14, 15)
        Label5.Name = "Label5"
        Label5.Size = New Size(146, 28)
        Label5.TabIndex = 10
        Label5.Text = "Permit Details"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(257, 345)
        Label4.Name = "Label4"
        Label4.Size = New Size(80, 20)
        Label4.TabIndex = 30
        Label4.Text = "Issue Date:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(249, 274)
        Label3.Name = "Label3"
        Label3.Size = New Size(88, 20)
        Label3.TabIndex = 29
        Label3.Text = "Expiry Date:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(225, 198)
        Label2.Name = "Label2"
        Label2.Size = New Size(112, 20)
        Label2.TabIndex = 28
        Label2.Text = "Permit Number:"
        ' 
        ' dtIssueDate
        ' 
        dtIssueDate.Location = New Point(365, 340)
        dtIssueDate.Name = "dtIssueDate"
        dtIssueDate.Size = New Size(188, 27)
        dtIssueDate.TabIndex = 27
        ' 
        ' dtExpiryDate
        ' 
        dtExpiryDate.Location = New Point(365, 269)
        dtExpiryDate.Name = "dtExpiryDate"
        dtExpiryDate.Size = New Size(188, 27)
        dtExpiryDate.TabIndex = 26
        ' 
        ' txtPermitNumber
        ' 
        txtPermitNumber.Location = New Point(365, 195)
        txtPermitNumber.Name = "txtPermitNumber"
        txtPermitNumber.Size = New Size(303, 27)
        txtPermitNumber.TabIndex = 25
        ' 
        ' txtPermitName
        ' 
        txtPermitName.Location = New Point(365, 125)
        txtPermitName.Name = "txtPermitName"
        txtPermitName.Size = New Size(303, 27)
        txtPermitName.TabIndex = 24
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(285, 128)
        Label1.Name = "Label1"
        Label1.Size = New Size(52, 20)
        Label1.TabIndex = 23
        Label1.Text = "Name:"
        ' 
        ' ucStudentPermitDetails
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(dtIssueDate)
        Controls.Add(dtExpiryDate)
        Controls.Add(txtPermitNumber)
        Controls.Add(txtPermitName)
        Controls.Add(Label1)
        Controls.Add(Label5)
        Name = "ucStudentPermitDetails"
        Size = New Size(917, 492)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dtIssueDate As DateTimePicker
    Friend WithEvents dtExpiryDate As DateTimePicker
    Friend WithEvents txtPermitNumber As TextBox
    Friend WithEvents txtPermitName As TextBox
    Friend WithEvents Label1 As Label

End Class
