<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentRegistrationForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        mainPanel = New Panel()
        btnBack = New Button()
        btnNext = New Button()
        btnMenu = New Button()
        SuspendLayout()
        ' 
        ' mainPanel
        ' 
        mainPanel.Location = New Point(0, 2)
        mainPanel.Name = "mainPanel"
        mainPanel.Size = New Size(917, 492)
        mainPanel.TabIndex = 1
        ' 
        ' btnBack
        ' 
        btnBack.Location = New Point(653, 523)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(123, 37)
        btnBack.TabIndex = 2
        btnBack.Text = "⬅️ Back"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' btnNext
        ' 
        btnNext.Location = New Point(782, 523)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(123, 37)
        btnNext.TabIndex = 3
        btnNext.Text = "Next ➡️"
        btnNext.UseVisualStyleBackColor = True
        ' 
        ' btnMenu
        ' 
        btnMenu.Location = New Point(12, 522)
        btnMenu.Name = "btnMenu"
        btnMenu.Size = New Size(125, 38)
        btnMenu.TabIndex = 4
        btnMenu.Text = "Back to Menu"
        btnMenu.UseVisualStyleBackColor = True
        ' 
        ' StudentRegistrationForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(917, 583)
        Controls.Add(btnMenu)
        Controls.Add(btnNext)
        Controls.Add(btnBack)
        Controls.Add(mainPanel)
        MaximizeBox = False
        MaximumSize = New Size(935, 630)
        MinimumSize = New Size(935, 630)
        Name = "StudentRegistrationForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "StudentRegistrationForm"
        ResumeLayout(False)
    End Sub

    Friend WithEvents mainPanel As Panel
    Friend WithEvents btnBack As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnMenu As Button
End Class
