Imports MySql.Data.MySqlClient
Imports Mysqlx

Public Class ADMDashboardEMPTab

    Private Sub ADMDashboardEMPTab_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadToDGVEmployer()
    End Sub

    Dim connectionString As String = "Server=localhost;Database=ofw_mis;User Id=root;Password=;"
    Dim connection As New MySqlConnection(connectionString)
    Private employerDataTable As New DataTable()

    Public Sub LoadToDGVEmployer()
        Try
            connection.Open()
            Dim query As String = "SELECT * FROM employer"
            Dim adapter As New MySqlDataAdapter(query, connection)
            employerDataTable.Clear() ' Clear any existing data
            adapter.Fill(employerDataTable) ' Fill the DataTable with data from the database
            dgvEMP.DataSource = employerDataTable ' Bind the DataTable to the DataGridView

        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub dataCount_DataSourceChanged(sender As Object, e As EventArgs) Handles dgvEMP.DataSourceChanged
        Dim rowCount As Integer = dgvEMP.Rows.Count
        lblEMPTally.Text = rowCount - 1
    End Sub

    Private Sub btnADMDashSTAT_Click(sender As Object, e As EventArgs) Handles btnADMDashSTAT.Click
        Dim ADMDashStat As New ADMDashboardStatTab()
        Me.Close()
        ADMDashStat.Show()
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

    Private Sub btnADMDashOFW_Click(sender As Object, e As EventArgs) Handles btnADMDashOFW.Click
        Dim ADMDashOFW As New ADMDashboardOFWTab()
        Me.Close()
        ADMDashOFW.Show()
    End Sub

    Private Sub btnADD_Click(sender As Object, e As EventArgs) Handles btnADD.Click
        Dim AddEMP As New ADMAddEMP()
        AddEMP.ShowDialog()
    End Sub

    Private Sub btnEDIT_Click(sender As Object, e As EventArgs) Handles btnEDIT.Click
        If dgvEMP.SelectedRows.Count > 0 Then  ' Check if a row is selected
            Dim selectedRow As DataGridViewRow = dgvEMP.SelectedRows(0)
            Dim selectedEMPId As Integer = CInt(selectedRow.Cells("EmployerId").Value)  ' Assuming "OFWId" is the column name for the ID

            Dim EditEMP As New ADMEditEMP(selectedEMPId)  ' Pass the selected ID to the constructor
            EditEMP.ShowDialog()
        Else
            MessageBox.Show("Please select an OFW record to edit!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnDLT_Click(sender As Object, e As EventArgs) Handles btnDLT.Click
        If dgvEMP.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = dgvEMP.SelectedRows(0)
            Dim selectedEMPId As Integer = CInt(selectedRow.Cells("EmployerId").Value)  ' Assuming "OFWId" is the column name for the ID

            If MessageBox.Show("Are you sure you want to delete this OFW record?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Dim query As String = "DELETE FROM EMPLOYER WHERE EmployerId = @EmployerId"

                Using connection = New MySqlConnection(connectionString)
                    connection.Open()
                    Using command = New MySqlCommand(query, connection)
                        command.Parameters.AddWithValue("@EmployerId", selectedEMPId)
                        command.ExecuteNonQuery()
                    End Using
                End Using

                MessageBox.Show("Employer record deleted successfully!")
                LoadToDGVEmployer()  ' Refresh the DataGridView
            End If
        Else
            MessageBox.Show("Please select an Employer record to delete!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
        ApplyFilter()
    End Sub

    Private Sub ApplyFilter()
        ' Build the filter string based on user inputs
        Dim filter As String = ""

        If Not String.IsNullOrWhiteSpace(txtEMPIdFilt.Text) Then
            filter &= $"EmployerId LIKE '%{txtEMPIdFilt.Text}%' AND "
        End If
        If Not String.IsNullOrWhiteSpace(txtEMPFNameFilt.Text) Then
            filter &= $"EmployerFirstName LIKE '%{txtEMPFNameFilt.Text}%' AND "
        End If
        If Not String.IsNullOrWhiteSpace(txtEMPMNameFilt.Text) Then
            filter &= $"EmployerMiddleName LIKE '%{txtEMPMNameFilt.Text}%' AND "
        End If
        If Not String.IsNullOrWhiteSpace(txtEMPLNameFilt.Text) Then
            filter &= $"EmployerLastName LIKE '%{txtEMPLNameFilt.Text}%' AND "
        End If
        If Not String.IsNullOrWhiteSpace(txtEMPCompanyFilt.Text) Then
            filter &= $"CompanyName LIKE '%{txtEMPCompanyFilt.Text}%' AND "
        End If
        If Not String.IsNullOrWhiteSpace(txtEMPIndustryFilt.Text) Then
            filter &= $"Industry LIKE '%{txtbxOFWFNameFilt.Text}%' AND "
        End If
        If Not String.IsNullOrWhiteSpace(txtEMPZipFilt.Text) Then
            filter &= $"CompanyZip LIKE '%{txtbxOFWMNameFilt.Text}%' AND "
        End If
        If Not String.IsNullOrWhiteSpace(txtEMPContNumFilt.Text) Then
            filter &= $"EmployerContactNum LIKE '%{txtbxOFWLNameFilt.Text}%' AND "
        End If
        If Not String.IsNullOrWhiteSpace(txtEMPEmailFilt.Text) Then
            filter &= $"EmployerEmail LIKE '%{txtEMPIdFilt.Text}%' AND "
        End If

        ' Remove the trailing " AND " if filter is not empty
        If filter.EndsWith(" AND ") Then
            filter = filter.Substring(0, filter.Length - 5)
        End If

        ' Apply the filter to the DataTable
        Dim dataView As New DataView(employerDataTable)
        dataView.RowFilter = filter
        dgvEMP.DataSource = dataView

        ' Update the total number of OFWs shown
        lblEMPTally.Text = dataView.Count.ToString()
    End Sub

    Private Sub btnADMDashAGC_Click(sender As Object, e As EventArgs) Handles btnADMDashAGC.Click
        Dim ADMDashAGC As New ADMDashboardAGCTab()
        Me.Close()
        ADMDashAGC.Show()
    End Sub


End Class