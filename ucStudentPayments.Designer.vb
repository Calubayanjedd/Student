<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucStudentPayments
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
        Label2 = New Label()
        txtPaymentPermitNumber = New TextBox()
        txtPermitName = New TextBox()
        Label1 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label6 = New Label()
        txtPaymentMethod = New TextBox()
        txtPaymentUpdate = New TextBox()
        txtPaymentAmount = New TextBox()
        SuspendLayout()
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(23, 18)
        Label5.Name = "Label5"
        Label5.Size = New Size(95, 28)
        Label5.TabIndex = 10
        Label5.Text = "Payment"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(221, 184)
        Label2.Name = "Label2"
        Label2.Size = New Size(112, 20)
        Label2.TabIndex = 28
        Label2.Text = "Permit Number:"
        ' 
        ' txtPaymentPermitNumber
        ' 
        txtPaymentPermitNumber.Location = New Point(361, 181)
        txtPaymentPermitNumber.Name = "txtPaymentPermitNumber"
        txtPaymentPermitNumber.Size = New Size(303, 27)
        txtPaymentPermitNumber.TabIndex = 25
        ' 
        ' txtPermitName
        ' 
        txtPermitName.Location = New Point(361, 111)
        txtPermitName.Name = "txtPermitName"
        txtPermitName.Size = New Size(303, 27)
        txtPermitName.TabIndex = 24
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(281, 114)
        Label1.Name = "Label1"
        Label1.Size = New Size(52, 20)
        Label1.TabIndex = 23
        Label1.Text = "Name:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(209, 258)
        Label3.Name = "Label3"
        Label3.Size = New Size(124, 20)
        Label3.TabIndex = 29
        Label3.Text = "Payment Method:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(212, 329)
        Label4.Name = "Label4"
        Label4.Size = New Size(121, 20)
        Label4.TabIndex = 30
        Label4.Text = "Payment Update:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(236, 392)
        Label6.Name = "Label6"
        Label6.Size = New Size(97, 20)
        Label6.TabIndex = 31
        Label6.Text = "Amount Paid:"
        ' 
        ' txtPaymentMethod
        ' 
        txtPaymentMethod.Location = New Point(361, 255)
        txtPaymentMethod.Name = "txtPaymentMethod"
        txtPaymentMethod.Size = New Size(303, 27)
        txtPaymentMethod.TabIndex = 32
        ' 
        ' txtPaymentUpdate
        ' 
        txtPaymentUpdate.Location = New Point(361, 326)
        txtPaymentUpdate.Name = "txtPaymentUpdate"
        txtPaymentUpdate.Size = New Size(303, 27)
        txtPaymentUpdate.TabIndex = 33
        ' 
        ' txtPaymentAmount
        ' 
        txtPaymentAmount.Location = New Point(361, 389)
        txtPaymentAmount.Name = "txtPaymentAmount"
        txtPaymentAmount.Size = New Size(303, 27)
        txtPaymentAmount.TabIndex = 34
        ' 
        ' ucStudentPayments
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(txtPaymentAmount)
        Controls.Add(txtPaymentUpdate)
        Controls.Add(txtPaymentMethod)
        Controls.Add(Label6)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(txtPaymentPermitNumber)
        Controls.Add(txtPermitName)
        Controls.Add(Label1)
        Controls.Add(Label5)
        Name = "ucStudentPayments"
        Size = New Size(917, 492)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPaymentPermitNumber As TextBox
    Friend WithEvents txtPermitName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtPaymentMethod As TextBox
    Friend WithEvents txtPaymentUpdate As TextBox
    Friend WithEvents txtPaymentAmount As TextBox

End Class
