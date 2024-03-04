Public Class DemonstrationsForm
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        'Terminate the window
        Me.Close()

    End Sub

    Private Sub Loadbutton_Click(sender As Object, e As EventArgs) Handles LoadButton.Click
        ' Create an instance of OpenFileDialog
        Dim openFileDialog1 As New OpenFileDialog()

        ' Set properties of OpenFileDialog
        openFileDialog1.Title = "Select an Image"
        openFileDialog1.Filter = "Image Files|*.bmp;*.jpg;*.jpeg;*.png;*.gif"

        ' Show the file dialog and check if the user clicked OK
        If openFileDialog1.ShowDialog() = DialogResult.OK Then
            ' Get the selected file path
            Dim selectedImagePath As String = openFileDialog1.FileName

            ' Load the image into PictureBox1
            PictureBox1.Image = Image.FromFile(selectedImagePath)
        End If
    End Sub

    Private Sub RadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonRed.CheckedChanged, RadioButtonGreen.CheckedChanged, RadioButtonBlue.CheckedChanged
        'Change the the Font Color According to the radio button selected
        If RadioButtonRed.Checked Then
            TextBox1.ForeColor = Color.Red
        ElseIf RadioButtonGreen.Checked Then
            TextBox1.ForeColor = Color.Green
        ElseIf RadioButtonBlue.Checked Then
            TextBox1.ForeColor = Color.Blue
        End If

    End Sub

    Private Sub CheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxBold.CheckedChanged, CheckBoxItalic.CheckedChanged, CheckBoxBoldItalic.CheckedChanged
        ' Create a variable to hold the font style
        Dim fontStyle As FontStyle = FontStyle.Regular

        ' Check which checkboxes are checked and update the font style
        If CheckBoxBold.Checked Then
            fontStyle = fontStyle Or FontStyle.Bold
        End If

        If CheckBoxItalic.Checked Then
            fontStyle = fontStyle Or FontStyle.Italic
        End If

        If CheckBoxBoldItalic.Checked Then
            fontStyle = fontStyle Or FontStyle.Bold Or FontStyle.Italic


        End If

        ' Apply the updated font style to the TextBox
        TextBox1.Font = New Font(TextBox1.Font, fontStyle)
    End Sub
    Private Sub RadioButtonFont_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonGaramond.CheckedChanged, RadioButtonMagneto.CheckedChanged, RadioButtonTahoma.CheckedChanged
        ' Apply the updated font family to the text box directly inside the conditions
        If RadioButtonGaramond.Checked Then
            TextBox1.Font = New Font("Garamond", TextBox1.Font.Size, TextBox1.Font.Style)
        ElseIf RadioButtonMagneto.Checked Then
            TextBox1.Font = New Font("Magneto", TextBox1.Font.Size, TextBox1.Font.Style)
        ElseIf RadioButtonTahoma.Checked Then
            TextBox1.Font = New Font("Tahoma", TextBox1.Font.Size, TextBox1.Font.Style)
        End If
    End Sub
End Class

