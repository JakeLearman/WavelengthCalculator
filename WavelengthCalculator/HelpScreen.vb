Public Class helpScreen
    'This subroutine would manage anything which would load when the help screen open.
    Private Sub helpScreen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub
    'This subroutine manages what happens when the user presses the OK button
    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
        'This closes the help screen when the button is pressed.
        Me.Close()
    End Sub
End Class
