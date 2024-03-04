Public Class Form1
    Private Sub LoadButton_Click(sender As Object, e As EventArgs) Handles LoadButton.Click
        'Create an instance of the form
        Dim demonstrations As New DemonstrationsForm()

        'Display the form
        DemonstrationsForm.Show()

    End Sub

    Private Sub Form1_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        ' Maximize the form
        Me.WindowState = FormWindowState.Maximized

        ' Change the background color to red
        Me.BackColor = Color.Red
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        'Terminate The Application
        Me.Close()
    End Sub
    Private Sub WelcomingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set tooltips for the buttons buttons
        ToolTip1.SetToolTip(LoadButton, "This is the Load Button")
        ToolTip1.SetToolTip(ExitButton, "This is the Exit button")

    End Sub

End Class
