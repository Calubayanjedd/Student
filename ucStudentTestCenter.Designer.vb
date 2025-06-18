<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucStudentTestCenter
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
        txtTestCenterLocation = New TextBox()
        Label1 = New Label()
        txtTestCenterName = New TextBox()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(23, 19)
        Label5.Name = "Label5"
        Label5.Size = New Size(118, 28)
        Label5.TabIndex = 10
        Label5.Text = "Test Center"
        ' 
        ' txtTestCenterLocation
        ' 
        txtTestCenterLocation.Location = New Point(365, 182)
        txtTestCenterLocation.Name = "txtTestCenterLocation"
        txtTestCenterLocation.Size = New Size(317, 27)
        txtTestCenterLocation.TabIndex = 25
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(239, 185)
        Label1.Name = "Label1"
        Label1.Size = New Size(69, 20)
        Label1.TabIndex = 26
        Label1.Text = "Location:"
        ' 
        ' txtTestCenterName
        ' 
        txtTestCenterName.Location = New Point(365, 270)
        txtTestCenterName.Name = "txtTestCenterName"
        txtTestCenterName.Size = New Size(317, 27)
        txtTestCenterName.TabIndex = 27
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(256, 270)
        Label2.Name = "Label2"
        Label2.Size = New Size(52, 20)
        Label2.TabIndex = 28
        Label2.Text = "Name:"
        ' 
        ' ucStudentTestCenter
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Label2)
        Controls.Add(txtTestCenterName)
        Controls.Add(Label1)
        Controls.Add(txtTestCenterLocation)
        Controls.Add(Label5)
        Name = "ucStudentTestCenter"
        Size = New Size(917, 492)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents txtTestCenterLocation As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTestCenterName As TextBox
    Friend WithEvents Label2 As Label

End Class
