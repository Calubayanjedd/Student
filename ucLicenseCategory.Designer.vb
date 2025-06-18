<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucLicenseCategory
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
        txtCategoryName = New TextBox()
        txtDescription = New TextBox()
        SuspendLayout()
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(28, 17)
        Label5.Name = "Label5"
        Label5.Size = New Size(173, 28)
        Label5.TabIndex = 10
        Label5.Text = "License Category"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(180, 114)
        Label1.Name = "Label1"
        Label1.Size = New Size(116, 20)
        Label1.TabIndex = 11
        Label1.Text = "Category Name:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(180, 193)
        Label2.Name = "Label2"
        Label2.Size = New Size(88, 20)
        Label2.TabIndex = 12
        Label2.Text = "Description:"
        ' 
        ' txtCategoryName
        ' 
        txtCategoryName.Location = New Point(346, 111)
        txtCategoryName.Name = "txtCategoryName"
        txtCategoryName.Size = New Size(289, 27)
        txtCategoryName.TabIndex = 13
        ' 
        ' txtDescription
        ' 
        txtDescription.Location = New Point(180, 235)
        txtDescription.Multiline = True
        txtDescription.Name = "txtDescription"
        txtDescription.Size = New Size(483, 167)
        txtDescription.TabIndex = 14
        ' 
        ' ucLicenseCategory
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(txtDescription)
        Controls.Add(txtCategoryName)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Label5)
        Name = "ucLicenseCategory"
        Size = New Size(917, 492)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCategoryName As TextBox
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents btnNext As Button

End Class
