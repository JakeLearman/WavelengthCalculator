Public Class Form1
    'Variables NumberOne and CalcAnswer are declared
    Dim Frequency As Single
    Dim Wavelength As Single

    'This collects the inputted value into TextBox1 and enters it into the equation
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        'This assigns the inputted frequency to NumberOne
        Frequency = TextBox1.Text
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Declaring wavelengthAnswer as instance of wave class
        Dim wavelengthAnswer As New wave()
        'Sets the variable wavelength equal to the output of the wave class
        Wavelength = waveLengthAnswer.Result(Frequency)
        'Outputs calculated wavelength to Label3 with 2 decimal places
        Label3.Text = String.Format("{0:F}", wavelength)
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        helpScreen.Show()
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
