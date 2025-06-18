<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentPermitForm
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
        btnBack = New Button()
        dgvApplicant = New DataGridView()
        Label1 = New Label()
        Label2 = New Label()
        dgvInstructor = New DataGridView()
        Label3 = New Label()
        dgvPermitDetails = New DataGridView()
        Label5 = New Label()
        Label4 = New Label()
        dgvTestCenter = New DataGridView()
        dgvTest = New DataGridView()
        dgvPayment = New DataGridView()
        Label6 = New Label()
        Label7 = New Label()
        btnRegister = New Button()
        CType(dgvApplicant, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvInstructor, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvPermitDetails, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvTestCenter, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvTest, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvPayment, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnBack
        ' 
        btnBack.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnBack.Location = New Point(12, 12)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(122, 39)
        btnBack.TabIndex = 0
        btnBack.Text = "⬅️ Back"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' dgvApplicant
        ' 
        dgvApplicant.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvApplicant.Location = New Point(31, 110)
        dgvApplicant.Name = "dgvApplicant"
        dgvApplicant.RowHeadersWidth = 51
        dgvApplicant.Size = New Size(381, 230)
        dgvApplicant.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(31, 69)
        Label1.Name = "Label1"
        Label1.Size = New Size(103, 28)
        Label1.TabIndex = 2
        Label1.Text = "Applicant"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(475, 69)
        Label2.Name = "Label2"
        Label2.Size = New Size(105, 28)
        Label2.TabIndex = 3
        Label2.Text = "Instructor"
        ' 
        ' dgvInstructor
        ' 
        dgvInstructor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvInstructor.Location = New Point(475, 110)
        dgvInstructor.Name = "dgvInstructor"
        dgvInstructor.RowHeadersWidth = 51
        dgvInstructor.Size = New Size(381, 230)
        dgvInstructor.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(918, 69)
        Label3.Name = "Label3"
        Label3.Size = New Size(146, 28)
        Label3.TabIndex = 5
        Label3.Text = "Permit Details"
        ' 
        ' dgvPermitDetails
        ' 
        dgvPermitDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvPermitDetails.Location = New Point(918, 110)
        dgvPermitDetails.Name = "dgvPermitDetails"
        dgvPermitDetails.RowHeadersWidth = 51
        dgvPermitDetails.Size = New Size(381, 230)
        dgvPermitDetails.TabIndex = 6
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(592, 9)
        Label5.Name = "Label5"
        Label5.Size = New Size(154, 28)
        Label5.TabIndex = 12
        Label5.Text = "Student Permit"
        Label5.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(31, 355)
        Label4.Name = "Label4"
        Label4.Size = New Size(118, 28)
        Label4.TabIndex = 13
        Label4.Text = "Test Center"
        ' 
        ' dgvTestCenter
        ' 
        dgvTestCenter.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvTestCenter.Location = New Point(31, 395)
        dgvTestCenter.Name = "dgvTestCenter"
        dgvTestCenter.RowHeadersWidth = 51
        dgvTestCenter.Size = New Size(381, 230)
        dgvTestCenter.TabIndex = 14
        ' 
        ' dgvTest
        ' 
        dgvTest.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvTest.Location = New Point(475, 393)
        dgvTest.Name = "dgvTest"
        dgvTest.RowHeadersWidth = 51
        dgvTest.Size = New Size(381, 230)
        dgvTest.TabIndex = 15
        ' 
        ' dgvPayment
        ' 
        dgvPayment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvPayment.Location = New Point(918, 393)
        dgvPayment.Name = "dgvPayment"
        dgvPayment.RowHeadersWidth = 51
        dgvPayment.Size = New Size(381, 230)
        dgvPayment.TabIndex = 16
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(475, 355)
        Label6.Name = "Label6"
        Label6.Size = New Size(50, 28)
        Label6.TabIndex = 17
        Label6.Text = "Test"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(918, 355)
        Label7.Name = "Label7"
        Label7.Size = New Size(95, 28)
        Label7.TabIndex = 18
        Label7.Text = "Payment"
        ' 
        ' btnRegister
        ' 
        btnRegister.Location = New Point(1078, 642)
        btnRegister.Name = "btnRegister"
        btnRegister.Size = New Size(178, 48)
        btnRegister.TabIndex = 19
        btnRegister.Text = "Register"
        btnRegister.UseVisualStyleBackColor = True
        ' 
        ' StudentPermitForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1329, 712)
        Controls.Add(btnRegister)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(dgvPayment)
        Controls.Add(dgvTest)
        Controls.Add(dgvTestCenter)
        Controls.Add(Label4)
        Controls.Add(Label5)
        Controls.Add(dgvPermitDetails)
        Controls.Add(Label3)
        Controls.Add(dgvInstructor)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(dgvApplicant)
        Controls.Add(btnBack)
        MaximizeBox = False
        MaximumSize = New Size(1347, 759)
        MinimumSize = New Size(1347, 759)
        Name = "StudentPermitForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "StudentPermitForm"
        CType(dgvApplicant, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvInstructor, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvPermitDetails, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvTestCenter, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvTest, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvPayment, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents dgvApplicant As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dgvInstructor As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents dgvPermitDetails As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents dgvTestCenter As DataGridView
    Friend WithEvents dgvTest As DataGridView
    Friend WithEvents dgvPayment As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnRegister As Button
End Class
