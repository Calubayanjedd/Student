<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DriversPermitForm
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
        Label1 = New Label()
        dtvApplicant = New DataGridView()
        Label2 = New Label()
        dtvCategory = New DataGridView()
        Label3 = New Label()
        dtvDetails = New DataGridView()
        Label4 = New Label()
        dtvMedCert = New DataGridView()
        Label5 = New Label()
        btnReg = New Button()
        CType(dtvApplicant, ComponentModel.ISupportInitialize).BeginInit()
        CType(dtvCategory, ComponentModel.ISupportInitialize).BeginInit()
        CType(dtvDetails, ComponentModel.ISupportInitialize).BeginInit()
        CType(dtvMedCert, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnBack
        ' 
        btnBack.Location = New Point(12, 12)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(122, 39)
        btnBack.TabIndex = 1
        btnBack.Text = "⬅️ Back"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(31, 83)
        Label1.Name = "Label1"
        Label1.Size = New Size(103, 28)
        Label1.TabIndex = 3
        Label1.Text = "Applicant"
        ' 
        ' dtvApplicant
        ' 
        dtvApplicant.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dtvApplicant.Location = New Point(31, 128)
        dtvApplicant.Name = "dtvApplicant"
        dtvApplicant.RowHeadersWidth = 51
        dtvApplicant.Size = New Size(395, 230)
        dtvApplicant.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(469, 83)
        Label2.Name = "Label2"
        Label2.Size = New Size(173, 28)
        Label2.TabIndex = 5
        Label2.Text = "License Category"
        ' 
        ' dtvCategory
        ' 
        dtvCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dtvCategory.Location = New Point(469, 128)
        dtvCategory.Name = "dtvCategory"
        dtvCategory.RowHeadersWidth = 51
        dtvCategory.Size = New Size(392, 230)
        dtvCategory.TabIndex = 6
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(903, 83)
        Label3.Name = "Label3"
        Label3.Size = New Size(154, 28)
        Label3.TabIndex = 7
        Label3.Text = "Licence Details"
        ' 
        ' dtvDetails
        ' 
        dtvDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dtvDetails.Location = New Point(903, 128)
        dtvDetails.Name = "dtvDetails"
        dtvDetails.RowHeadersWidth = 51
        dtvDetails.Size = New Size(396, 230)
        dtvDetails.TabIndex = 8
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(31, 418)
        Label4.Name = "Label4"
        Label4.Size = New Size(193, 28)
        Label4.TabIndex = 9
        Label4.Text = "Medical Certificate"
        ' 
        ' dtvMedCert
        ' 
        dtvMedCert.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dtvMedCert.Location = New Point(31, 461)
        dtvMedCert.Name = "dtvMedCert"
        dtvMedCert.RowHeadersWidth = 51
        dtvMedCert.Size = New Size(767, 230)
        dtvMedCert.TabIndex = 10
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(566, 9)
        Label5.Name = "Label5"
        Label5.Size = New Size(160, 28)
        Label5.TabIndex = 11
        Label5.Text = "Driver's License"
        Label5.TextAlign = ContentAlignment.TopCenter
        ' 
        ' btnReg
        ' 
        btnReg.Location = New Point(978, 539)
        btnReg.Name = "btnReg"
        btnReg.Size = New Size(236, 74)
        btnReg.TabIndex = 12
        btnReg.Text = "Register"
        btnReg.UseVisualStyleBackColor = True
        ' 
        ' DriversPermitForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1329, 712)
        Controls.Add(btnReg)
        Controls.Add(Label5)
        Controls.Add(dtvMedCert)
        Controls.Add(Label4)
        Controls.Add(dtvDetails)
        Controls.Add(Label3)
        Controls.Add(dtvCategory)
        Controls.Add(Label2)
        Controls.Add(dtvApplicant)
        Controls.Add(Label1)
        Controls.Add(btnBack)
        MaximizeBox = False
        MaximumSize = New Size(1347, 759)
        MinimumSize = New Size(1347, 759)
        Name = "DriversPermitForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "DriversPermitForm"
        CType(dtvApplicant, ComponentModel.ISupportInitialize).EndInit()
        CType(dtvCategory, ComponentModel.ISupportInitialize).EndInit()
        CType(dtvDetails, ComponentModel.ISupportInitialize).EndInit()
        CType(dtvMedCert, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents dtvApplicant As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents dtvCategory As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents dtvDetails As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents dtvMedCert As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents btnReg As Button
End Class
