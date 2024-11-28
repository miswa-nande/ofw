Imports MySql.Data.MySqlClient
Imports Mysqlx

Public Class ADMDashboardAGCTab
    Private Sub ADMDashboardAGCTab_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadToDGVAgency()
    End Sub

    Dim connectionString As String = "Server=localhost;Database=ofw_mis;User Id=root;Password=;"
    Dim connection As New MySqlConnection(connectionString)
    Private agencyDataTable As New DataTable()


    Public Sub LoadToDGVAgency()
        Try
            connection.Open()
            Dim query As String = "SELECT * FROM agency"
            Dim adapter As New MySqlDataAdapter(query, connection)
            agencyDataTable.Clear() ' Clear any existing data
            adapter.Fill(agencyDataTable) ' Fill the DataTable with data from the database
            dgvAGC.DataSource = agencyDataTable ' Bind the DataTable to the DataGridView

        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub dataCount_DataSourceChanged(sender As Object, e As EventArgs) Handles dgvAGC.DataSourceChanged
        Dim rowCount As Integer = dgvAGC.Rows.Count
        lblAGCTally.Text = rowCount - 1
    End Sub

    Private Sub btnADMDashOFW_Click(sender As Object, e As EventArgs) Handles btnADMDashOFW.Click
        Dim ADMDashOFW As New ADMDashboardOFWTab()
        Me.Close()
        ADMDashOFW.Show()
    End Sub

    Private Sub btnADMDashEMP_Click(sender As Object, e As EventArgs) Handles btnADMDashEMP.Click
        Dim ADMDashEMP As New ADMDashboardEMPTab()
        Me.Close()
        ADMDashEMP.Show()
    End Sub

    Private Sub btnADMDashSTAT_Click(sender As Object, e As EventArgs) Handles btnADMDashSTAT.Click
        Dim ADMDashStat As New ADMDashboardStatTab()
        Me.Close()
        ADMDashStat.Show()
    End Sub

    Private Sub btnADD_Click(sender As Object, e As EventArgs) Handles btnADD.Click
        Dim AddAGC As New ADMAddAGC()
        AddAGC.ShowDialog()
    End Sub

    Private Sub Close_Click(sender As Object, e As EventArgs) Handles btnCLose.Click
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

    Private Sub btnEDIT_Click(sender As Object, e As EventArgs) Handles btnEDIT.Click
        If dgvAGC.SelectedRows.Count > 0 Then  ' Check if a row is selected
            Dim selectedRow As DataGridViewRow = dgvAGC.SelectedRows(0)
            Dim selectedAGCId As Integer = CInt(selectedRow.Cells("AgencyId").Value)  ' Assuming "OFWId" is the column name for the ID

            Dim EditAGC As New ADMEditAGC(selectedAGCId)  ' Pass the selected ID to the constructor
            EditAGC.ShowDialog()
        Else
            MessageBox.Show("Please select an OFW record to edit!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnDLT_Click(sender As Object, e As EventArgs) Handles btnDLT.Click
        If dgvAGC.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = dgvAGC.SelectedRows(0)
            Dim selectedAGCId As Integer = CInt(selectedRow.Cells("AgencyId").Value)  ' Assuming "OFWId" is the column name for the ID

            If MessageBox.Show("Are you sure you want to delete this OFW record?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Dim query As String = "DELETE FROM AGENCY WHERE AgencyId = @AgencyId"

                Using connection = New MySqlConnection(connectionString)
                    connection.Open()
                    Using command = New MySqlCommand(query, connection)
                        command.Parameters.AddWithValue("@AgencyId", selectedAGCId)
                        command.ExecuteNonQuery()
                    End Using
                End Using

                MessageBox.Show("Agency record deleted successfully!")
                LoadToDGVAgency()  ' Refresh the DataGridView
            End If
        Else
            MessageBox.Show("Please select an Agency record to delete!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
        ApplyFilter()
    End Sub

    Private Sub ApplyFilter()
        ' Build the filter string based on user inputs
        Dim filter As String = ""

        If Not String.IsNullOrWhiteSpace(txtAGCIdFilt.Text) Then
            filter &= $"AgencyId LIKE '%{txtAGCIdFilt.Text}%' AND "
        End If
        If Not String.IsNullOrWhiteSpace(txtAGCNameFilt.Text) Then
            filter &= $"AgencyName LIKE '%{txtAGCNameFilt.Text}%' AND "
        End If
        If Not String.IsNullOrWhiteSpace(txtAGCLicNumFilt.Text) Then
            filter &= $"AgencyLicenseNumber LIKE '%{txtAGCLicNumFilt.Text}%' AND "
        End If
        If Not String.IsNullOrWhiteSpace(txtAGCWebFilt.Text) Then
            filter &= $"WebsiteUrl LIKE '%{txtAGCWebFilt.Text}%' AND "
        End If
        If Not String.IsNullOrWhiteSpace(txtAGCSpecFilt.Text) Then
            filter &= $"Specialization LIKE '%{txtAGCSpecFilt.Text}%' AND "
        End If
        If Not String.IsNullOrWhiteSpace(txtAGCZipFilt.Text) Then
            filter &= $"Zipcode LIKE '%{txtAGCZipFilt.Text}%' AND "
        End If
        If Not String.IsNullOrWhiteSpace(txtAGCContNumFilt.Text) Then
            filter &= $"ContactNum LIKE '%{txtAGCContNumFilt.Text}%' AND "
        End If
        If Not String.IsNullOrWhiteSpace(txtAGCEmailFilt.Text) Then
            filter &= $"Email LIKE '%{txtAGCEmailFilt.Text}%' AND "
        End If


        ' Remove the trailing " AND " if filter is not empty
        If filter.EndsWith(" AND ") Then
            filter = filter.Substring(0, filter.Length - 5)
        End If

        ' Apply the filter to the DataTable
        Dim dataView As New DataView(agencyDataTable)
        dataView.RowFilter = filter
        dgvAGC.DataSource = dataView

        ' Update the total number of OFWs shown
        lblAGCTally.Text = dataView.Count.ToString()
    End Sub
End Class