Public Class Settings
    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.SE = "Google" Then
            RadioButton1.Checked = True
        ElseIf My.Settings.SE = "Bing" Then
            RadioButton2.Checked = True
        End If
    End Sub



    Private Sub btnAccept_Click(sender As Object, e As EventArgs) Handles btnAccept.Click
        If RadioButton1.Checked = True Then
            My.Settings.SE = "Google"

        ElseIf RadioButton2.Checked = True Then
            My.Settings.SE = "Bing"
            My.Settings.Save()
            My.Settings.Reload()

        End If
    End Sub

End Class