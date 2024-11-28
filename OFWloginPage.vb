Public Class OFWloginPage
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles imgLoginPg.Click

    End Sub

    Private Sub btnCloseLoginPg_Click(sender As Object, e As EventArgs) Handles btnCloseLoginPg.Click
        Application.Exit()
    End Sub

    Private Sub btnADMLoginPg_Click(sender As Object, e As EventArgs) Handles btnADMLoginPg.Click
        Dim ADMLoginPage As New ADMloginPage()

        Me.Hide()
        ADMLoginPage.Show()
    End Sub
End Class