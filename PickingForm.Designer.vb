<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PickingForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PickingForm))
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        Button1 = New Button()
        Button2 = New Button()
        btnExit = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.ImageLocation = ""
        PictureBox1.Location = New Point(30, 35)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(270, 239)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), Image)
        PictureBox2.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox2.Location = New Point(356, 35)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(278, 239)
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(60, 300)
        Button1.Name = "Button1"
        Button1.Size = New Size(204, 42)
        Button1.TabIndex = 2
        Button1.Text = "Student Permit"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(394, 300)
        Button2.Name = "Button2"
        Button2.Size = New Size(204, 42)
        Button2.TabIndex = 3
        Button2.Text = "Driver's Permit"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = Color.Red
        btnExit.FlatStyle = FlatStyle.Popup
        btnExit.ForeColor = SystemColors.Control
        btnExit.Location = New Point(266, 366)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(124, 30)
        btnExit.TabIndex = 4
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' PickingForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(664, 408)
        Controls.Add(btnExit)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        MaximizeBox = False
        MaximumSize = New Size(682, 455)
        MinimumSize = New Size(682, 455)
        Name = "PickingForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "PickingForm"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btnExit As Button
End Class
