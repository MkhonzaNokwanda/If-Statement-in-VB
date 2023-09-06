Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnGreetings.Click
        'Declaring variables
        Dim strCountryName As String

        strCountryName = txtCountryName.Text.ToUpper

        'Implementing an IF statement
        If strCountryName = "SOUTH AFRICA" Then
            MessageBox.Show("Molo!")
        ElseIf strCountryName = "FRANCE" Then
            MessageBox.Show("Bonjour!")
        ElseIf strCountryName = "SPAIN" Then
            MessageBox.Show("Ola!")
        ElseIf strCountryName = "RUSSIA" Then
            MessageBox.Show("Zdravstvuyte!")
        ElseIf strCountryName = "CHINA" Then
            MessageBox.Show("Nin Hao!")
        ElseIf strCountryName = "GERMANY" Then
            MessageBox.Show("Guten Tag!")
        Else
            MessageBox.Show("Hello!")
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtCountryName.TextChanged

    End Sub
End Class
