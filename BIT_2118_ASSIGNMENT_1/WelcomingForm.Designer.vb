<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        LoadButton = New Button()
        ExitButton = New Button()
        ToolTip1 = New ToolTip(components)
        SuspendLayout()
        ' 
        ' LoadButton
        ' 
        LoadButton.Location = New Point(62, 235)
        LoadButton.Name = "LoadButton"
        LoadButton.Size = New Size(149, 34)
        LoadButton.TabIndex = 0
        LoadButton.Text = "Load Object Demo"
        ToolTip1.SetToolTip(LoadButton, "This is the Load Button")
        LoadButton.UseVisualStyleBackColor = True
        ' 
        ' ExitButton
        ' 
        ExitButton.Location = New Point(584, 235)
        ExitButton.Name = "ExitButton"
        ExitButton.Size = New Size(140, 34)
        ExitButton.TabIndex = 1
        ExitButton.Text = "EXIT"
        ToolTip1.SetToolTip(ExitButton, "This is the exit button" & vbCrLf)
        ExitButton.UseVisualStyleBackColor = True
        ' 
        ' ToolTip1
        ' 
        ToolTip1.ToolTipTitle = "ToolTip"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(ExitButton)
        Controls.Add(LoadButton)
        Name = "Form1"
        Text = "Welcoming Form"
        ResumeLayout(False)
    End Sub

    Friend WithEvents LoadButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents ToolTip1 As ToolTip

End Class
