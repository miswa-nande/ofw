Public Class ADMDashboardStatTab
    Private Sub ADMDashboardStatTab_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Private Sub btnADMDashOFW_Click(sender As Object, e As EventArgs) Handles btnADMDashOFW.Click
        Dim ADMDashOFW As New ADMDashboardOFWTab()

        Me.Close()
        ADMDashOFW.Show()
    End Sub

    Private Sub Close_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        If MessageBox.Show("Are you sure you want to close the system?", "Confirm Closing",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) =
                            DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        If MessageBox.Show("Are you sure you want to Log out?", "Confirm Log out",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) =
                            DialogResult.Yes Then
            Dim loginPage As New ADMloginPage()

            Me.Close()
            loginPage.Show()
        End If
    End Sub

    Private Sub btnADMDashEMP_Click(sender As Object, e As EventArgs) Handles btnADMDashEMP.Click
        Dim ADMDashEMP As New ADMDashboardEMPTab()

        Me.Close()
        ADMDashEMP.Show()
    End Sub

    Private Sub btnADMDashAGC_Click(sender As Object, e As EventArgs) Handles btnADMDashAGC.Click
        Dim ADMDashAGC As New ADMDashboardAGCTab()
        Me.Close()
        ADMDashAGC.Show()
    End Sub
End Class