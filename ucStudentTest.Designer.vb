<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucStudentTest
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
        dtTestDate = New DateTimePicker()
        txtTestType = New TextBox()
        txtTestName = New TextBox()
        Label1 = New Label()
        txtTestResult = New TextBox()
        SuspendLayout()
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(21, 16)
        Label5.Name = "Label5"
        Label5.Size = New Size(50, 28)
        Label5.TabIndex = 10
        Label5.Text = "Test"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(285, 345)
        Label4.Name = "Label4"
        Label4.Size = New Size(52, 20)
        Label4.TabIndex = 30
        Label4.Text = "Result:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(263, 274)
        Label3.Name = "Label3"
        Label3.Size = New Size(74, 20)
        Label3.TabIndex = 29
        Label3.Text = "Test Date:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(264, 198)
        Label2.Name = "Label2"
        Label2.Size = New Size(73, 20)
        Label2.TabIndex = 28
        Label2.Text = "Test Type:"
        ' 
        ' dtTestDate
        ' 
        dtTestDate.Location = New Point(365, 269)
        dtTestDate.Name = "dtTestDate"
        dtTestDate.Size = New Size(188, 27)
        dtTestDate.TabIndex = 26
        ' 
        ' txtTestType
        ' 
        txtTestType.Location = New Point(365, 195)
        txtTestType.Name = "txtTestType"
        txtTestType.Size = New Size(303, 27)
        txtTestType.TabIndex = 25
        ' 
        ' txtTestName
        ' 
        txtTestName.Location = New Point(365, 125)
        txtTestName.Name = "txtTestName"
        txtTestName.Size = New Size(303, 27)
        txtTestName.TabIndex = 24
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
        ' txtTestResult
        ' 
        txtTestResult.Location = New Point(365, 342)
        txtTestResult.Name = "txtTestResult"
        txtTestResult.Size = New Size(303, 27)
        txtTestResult.TabIndex = 31
        ' 
        ' ucStudentTest
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(txtTestResult)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(dtTestDate)
        Controls.Add(txtTestType)
        Controls.Add(txtTestName)
        Controls.Add(Label1)
        Controls.Add(Label5)
        Name = "ucStudentTest"
        Size = New Size(917, 492)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dtTestDate As DateTimePicker
    Friend WithEvents txtTestType As TextBox
    Friend WithEvents txtTestName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTestResult As TextBox

End Class
