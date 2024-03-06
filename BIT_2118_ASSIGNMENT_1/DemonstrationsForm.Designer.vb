<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DemonstrationsForm
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
        ExitButton = New Button()
        LoadButton = New Button()
        PictureBox1 = New PictureBox()
        GroupBox1 = New GroupBox()
        TextBox1 = New TextBox()
        GroupBox2 = New GroupBox()
        GroupBox7 = New GroupBox()
        RadioButton3 = New RadioButton()
        GroupBox6 = New GroupBox()
        RadioButton2 = New RadioButton()
        GroupBox5 = New GroupBox()
        RadioButton1 = New RadioButton()
        RadioButtonBlue = New RadioButton()
        GroupBox3 = New GroupBox()
        CheckBoxBoldItalic = New CheckBox()
        CheckBoxBold = New CheckBox()
        CheckBoxItalic = New CheckBox()
        GroupBox4 = New GroupBox()
        RadioButtonRed = New RadioButton()
        RadioButtonGreen = New RadioButton()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox7.SuspendLayout()
        GroupBox6.SuspendLayout()
        GroupBox5.SuspendLayout()
        GroupBox3.SuspendLayout()
        GroupBox4.SuspendLayout()
        SuspendLayout()
        ' 
        ' ExitButton
        ' 
        ExitButton.Location = New Point(625, 397)
        ExitButton.Name = "ExitButton"
        ExitButton.Size = New Size(119, 41)
        ExitButton.TabIndex = 0
        ExitButton.Text = "Exit"
        ExitButton.UseVisualStyleBackColor = True
        ' 
        ' LoadButton
        ' 
        LoadButton.Location = New Point(39, 397)
        LoadButton.Name = "LoadButton"
        LoadButton.Size = New Size(112, 41)
        LoadButton.TabIndex = 1
        LoadButton.Text = "Load Picture "
        LoadButton.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(12, 102)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(403, 289)
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Location = New Point(27, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(250, 66)
        GroupBox1.TabIndex = 3
        GroupBox1.TabStop = False
        GroupBox1.Text = "Display Text"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(12, 22)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(191, 23)
        TextBox1.TabIndex = 7
        TextBox1.Text = "Sample Text"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(GroupBox7)
        GroupBox2.Controls.Add(GroupBox6)
        GroupBox2.Controls.Add(GroupBox5)
        GroupBox2.Location = New Point(317, 12)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(427, 66)
        GroupBox2.TabIndex = 4
        GroupBox2.TabStop = False
        GroupBox2.Text = "Font"
        ' 
        ' GroupBox7
        ' 
        GroupBox7.Controls.Add(RadioButton3)
        GroupBox7.Location = New Point(296, 22)
        GroupBox7.Name = "GroupBox7"
        GroupBox7.Size = New Size(125, 38)
        GroupBox7.TabIndex = 2
        GroupBox7.TabStop = False
        ' 
        ' RadioButton3
        ' 
        RadioButton3.AutoSize = True
        RadioButton3.Location = New Point(6, 13)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New Size(67, 19)
        RadioButton3.TabIndex = 0
        RadioButton3.TabStop = True
        RadioButton3.Text = "Tahoma"
        RadioButton3.UseVisualStyleBackColor = True
        ' 
        ' GroupBox6
        ' 
        GroupBox6.Controls.Add(RadioButton2)
        GroupBox6.Location = New Point(142, 22)
        GroupBox6.Name = "GroupBox6"
        GroupBox6.Size = New Size(133, 38)
        GroupBox6.TabIndex = 1
        GroupBox6.TabStop = False
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(6, 13)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(81, 19)
        RadioButton2.TabIndex = 0
        RadioButton2.TabStop = True
        RadioButton2.Text = "Garamond"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' GroupBox5
        ' 
        GroupBox5.Controls.Add(RadioButton1)
        GroupBox5.Location = New Point(6, 21)
        GroupBox5.Name = "GroupBox5"
        GroupBox5.Size = New Size(122, 39)
        GroupBox5.TabIndex = 0
        GroupBox5.TabStop = False
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(6, 14)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(73, 19)
        RadioButton1.TabIndex = 0
        RadioButton1.TabStop = True
        RadioButton1.Text = "Magneto"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' RadioButtonBlue
        ' 
        RadioButtonBlue.AutoSize = True
        RadioButtonBlue.ForeColor = Color.Blue
        RadioButtonBlue.Location = New Point(13, 121)
        RadioButtonBlue.Name = "RadioButtonBlue"
        RadioButtonBlue.Size = New Size(48, 19)
        RadioButtonBlue.TabIndex = 1
        RadioButtonBlue.TabStop = True
        RadioButtonBlue.Text = "Blue"
        RadioButtonBlue.UseVisualStyleBackColor = True
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(CheckBoxBoldItalic)
        GroupBox3.Controls.Add(CheckBoxBold)
        GroupBox3.Controls.Add(CheckBoxItalic)
        GroupBox3.Location = New Point(444, 102)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(155, 289)
        GroupBox3.TabIndex = 5
        GroupBox3.TabStop = False
        GroupBox3.Text = "Font Style"
        ' 
        ' CheckBoxBoldItalic
        ' 
        CheckBoxBoldItalic.AutoSize = True
        CheckBoxBoldItalic.Font = New Font("Segoe UI", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        CheckBoxBoldItalic.Location = New Point(8, 213)
        CheckBoxBoldItalic.Name = "CheckBoxBoldItalic"
        CheckBoxBoldItalic.Size = New Size(85, 19)
        CheckBoxBoldItalic.TabIndex = 2
        CheckBoxBoldItalic.Text = "Bold Italic"
        CheckBoxBoldItalic.UseVisualStyleBackColor = True
        ' 
        ' CheckBoxBold
        ' 
        CheckBoxBold.AutoSize = True
        CheckBoxBold.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CheckBoxBold.Location = New Point(12, 123)
        CheckBoxBold.Name = "CheckBoxBold"
        CheckBoxBold.Size = New Size(51, 19)
        CheckBoxBold.TabIndex = 1
        CheckBoxBold.Text = "Bold"
        CheckBoxBold.UseVisualStyleBackColor = True
        ' 
        ' CheckBoxItalic
        ' 
        CheckBoxItalic.AutoSize = True
        CheckBoxItalic.Font = New Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        CheckBoxItalic.Location = New Point(15, 40)
        CheckBoxItalic.Name = "CheckBoxItalic"
        CheckBoxItalic.Size = New Size(51, 19)
        CheckBoxItalic.TabIndex = 0
        CheckBoxItalic.Text = "Italic"
        CheckBoxItalic.UseVisualStyleBackColor = True
        ' 
        ' GroupBox4
        ' 
        GroupBox4.BackColor = Color.Transparent
        GroupBox4.Controls.Add(RadioButtonRed)
        GroupBox4.Controls.Add(RadioButtonBlue)
        GroupBox4.Controls.Add(RadioButtonGreen)
        GroupBox4.Location = New Point(625, 104)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(163, 287)
        GroupBox4.TabIndex = 6
        GroupBox4.TabStop = False
        GroupBox4.Text = "Font Color"
        ' 
        ' RadioButtonRed
        ' 
        RadioButtonRed.AutoSize = True
        RadioButtonRed.BackColor = Color.Transparent
        RadioButtonRed.ForeColor = Color.Red
        RadioButtonRed.Location = New Point(7, 206)
        RadioButtonRed.Name = "RadioButtonRed"
        RadioButtonRed.Size = New Size(45, 19)
        RadioButtonRed.TabIndex = 2
        RadioButtonRed.TabStop = True
        RadioButtonRed.Text = "Red"
        RadioButtonRed.UseVisualStyleBackColor = False
        ' 
        ' RadioButtonGreen
        ' 
        RadioButtonGreen.AutoSize = True
        RadioButtonGreen.ForeColor = Color.DarkGreen
        RadioButtonGreen.Location = New Point(13, 40)
        RadioButtonGreen.Name = "RadioButtonGreen"
        RadioButtonGreen.Size = New Size(56, 19)
        RadioButtonGreen.TabIndex = 0
        RadioButtonGreen.TabStop = True
        RadioButtonGreen.Text = "Green"
        RadioButtonGreen.UseVisualStyleBackColor = True
        ' 
        ' DemonstrationsForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(784, 450)
        Controls.Add(GroupBox4)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(PictureBox1)
        Controls.Add(LoadButton)
        Controls.Add(ExitButton)
        Name = "DemonstrationsForm"
        Text = "        Object Demonstrations"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox7.ResumeLayout(False)
        GroupBox7.PerformLayout()
        GroupBox6.ResumeLayout(False)
        GroupBox6.PerformLayout()
        GroupBox5.ResumeLayout(False)
        GroupBox5.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        GroupBox4.ResumeLayout(False)
        GroupBox4.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents ExitButton As Button
    Friend WithEvents LoadButton As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents RadioButtonRed As RadioButton
    Friend WithEvents RadioButtonBlue As RadioButton
    Friend WithEvents RadioButtonGreen As RadioButton
    Friend WithEvents CheckBoxBoldItalic As CheckBox
    Friend WithEvents CheckBoxBold As CheckBox
    Friend WithEvents CheckBoxItalic As CheckBox
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
End Class
