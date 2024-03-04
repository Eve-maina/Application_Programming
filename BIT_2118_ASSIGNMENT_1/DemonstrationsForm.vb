Public Class DemonstrationsForm
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        'Terminate the window
        Me.Close()

    End Sub

    Private Sub LoadButton_Click(sender As Object, e As EventArgs) Handles LoadButton.Click
        ' Load the embedded image from resources
        Dim embeddedImage As Image = My.Resources.logo

        ' Display the image in PictureBox1
        PictureBox1.Image = embeddedImage
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
        ' Create a variable to hold the font family
        Dim fontFamily As String = "Arial" ' Default font family

        ' Check which radio button is checked and update the font family
        If RadioButtonGaramond.Checked Then
            fontFamily = "Garamond"
        ElseIf RadioButtonMagneto.Checked Then
            fontFamily = "Magneto"
        ElseIf RadiobuttonTahoma.Checked Then
            fontFamily = "Tahoma"
        End If

        'Apply the updated font family to the text box
        TextBox1.Font = New Font(fontFamily, TextBox1.Font.Size, TextBox1.Font.Style)

    End Sub
End Class

