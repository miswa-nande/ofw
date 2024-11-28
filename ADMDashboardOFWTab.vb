
Imports MySql.Data.MySqlClient

Public Class ADMDashboardOFWTab

    Private Sub ADMDashboardOFWTab_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadToDGVOfw()
    End Sub

    Dim connectionString As String = "Server=localhost;Database=ofw_mis;User Id=root;Password=;"
    Dim connection As New MySqlConnection(connectionString)
    Private ofwDataTable As New DataTable()

    Public Sub LoadToDGVOfw()
        Try
            connection.Open()
            Dim query As String = "SELECT * FROM ofw"
            Dim adapter As New MySqlDataAdapter(query, connection)
            ofwDataTable.Clear() ' Clear any existing data
            adapter.Fill(ofwDataTable) ' Fill the DataTable with data from the database
            dgvOFW.DataSource = ofwDataTable ' Bind the DataTable to the DataGridView

        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub





    Private Sub btnADD_Click(sender As Object, e As EventArgs) Handles btnADD.Click
        Dim AddOFW As New ADMAddOFW()
        AddOFW.ShowDialog()
    End Sub

    Private Sub btnEDIT_Click(sender As Object, e As EventArgs) Handles btnEDIT.Click
        If dgvOFW.SelectedRows.Count > 0 Then  ' Check if a row is selected
            Dim selectedRow As DataGridViewRow = dgvOFW.SelectedRows(0)
            Dim selectedOFWId As Integer = CInt(selectedRow.Cells("OFWId").Value)  ' Assuming "OFWId" is the column name for the ID

            Dim EditOFW As New ADMEditOFW(selectedOFWId)  ' Pass the selected ID to the constructor
            EditOFW.ShowDialog()
        Else
            MessageBox.Show("Please select an OFW record to edit!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnDLT_Click(sender As Object, e As EventArgs) Handles btnDLT.Click
        If dgvOFW.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = dgvOFW.SelectedRows(0)
            Dim selectedOFWId As Integer = CInt(selectedRow.Cells("OFWId").Value)  ' Assuming "OFWId" is the column name for the ID

            If MessageBox.Show("Are you sure you want to delete this OFW record?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Dim query As String = "DELETE FROM OFW WHERE OFWId = @OFWId"

                Using connection = New MySqlConnection(connectionString)
                    connection.Open()
                    Using command = New MySqlCommand(query, connection)
                        command.Parameters.AddWithValue("@OFWId", selectedOFWId)
                        command.ExecuteNonQuery()
                    End Using
                End Using

                MessageBox.Show("OFW record deleted successfully!")
                LoadToDGVOfw()  ' Refresh the DataGridView
            End If
        Else
            MessageBox.Show("Please select an OFW record to delete!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
        ApplyFilter()
    End Sub

    Private Sub ApplyFilter()
        ' Build the filter string based on user inputs
        Dim filter As String = ""

        If Not String.IsNullOrWhiteSpace(txtbxOFWIdFilt.Text) Then
            filter &= $"OFWID LIKE '%{txtbxOFWIdFilt.Text}%' AND "
        End If
        If Not String.IsNullOrWhiteSpace(txtbxOFWFNameFilt.Text) Then
            filter &= $"FirstName LIKE '%{txtbxOFWFNameFilt.Text}%' AND "
        End If
        If Not String.IsNullOrWhiteSpace(txtbxOFWMNameFilt.Text) Then
            filter &= $"MiddleName LIKE '%{txtbxOFWMNameFilt.Text}%' AND "
        End If
        If Not String.IsNullOrWhiteSpace(txtbxOFWLNameFilt.Text) Then
            filter &= $"LastName LIKE '%{txtbxOFWLNameFilt.Text}%' AND "
        End If
        If cbxOFWGenderFilt.SelectedIndex <> -1 Then
            filter &= $"Sex = '{cbxOFWGenderFilt.SelectedItem.ToString()}' AND "
        End If
        If cbxOFWCivStatFilt.SelectedIndex <> -1 Then
            filter &= $"CivilStatus = '{cbxOFWCivStatFilt.SelectedItem.ToString()}' AND "
        End If
        If Not String.IsNullOrWhiteSpace(txtbxOFWZipFilt.Text) Then
            filter &= $"Zipcode LIKE '%{txtbxOFWZipFilt.Text}%' AND "
        End If
        If chkOFWEmpStatFilt.Checked Then
            filter &= $"Employed = True AND "
        End If
        If Not String.IsNullOrWhiteSpace(txtbxOFWVisaFilt.Text) Then
            filter &= $"VISANumber LIKE '%{txtbxOFWVisaFilt.Text}%' AND "
        End If
        If Not String.IsNullOrWhiteSpace(txtbxOFWOECFilt.Text) Then
            filter &= $"OECNumber LIKE '%{txtbxOFWOECFilt.Text}%' AND "
        End If

        ' Remove the trailing " AND " if filter is not empty
        If filter.EndsWith(" AND ") Then
            filter = filter.Substring(0, filter.Length - 5)
        End If

        ' Apply the filter to the DataTable
        Dim dataView As New DataView(ofwDataTable)
        dataView.RowFilter = filter
        dgvOFW.DataSource = dataView

        ' Update the total number of OFWs shown
        lblOFWTally.Text = dataView.Count.ToString()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClearFilter.Click

        txtbxOFWIdFilt.Clear()
        txtbxOFWFNameFilt.Clear()
        txtbxOFWMNameFilt.Clear()
        txtbxOFWLNameFilt.Clear()
        cbxOFWGenderFilt.SelectedIndex = -1
        cbxOFWCivStatFilt.SelectedIndex = -1
        txtbxOFWZipFilt.Clear()
        chkOFWEmpStatFilt.Checked = False
        txtbxOFWVisaFilt.Clear()
        txtbxOFWOECFilt.Clear()


        dgvOFW.DataSource = ofwDataTable
        lblOFWTally.Text = ofwDataTable.Rows.Count.ToString()
    End Sub


    Private Sub dataCount_DataSourceChanged(sender As Object, e As EventArgs) Handles dgvOFW.DataSourceChanged
        Dim rowCount As Integer = dgvOFW.Rows.Count
        lblOFWTally.Text = rowCount - 1
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
    Private Sub btnADMDashAGC_Click(sender As Object, e As EventArgs) Handles btnADMDashAGC.Click
        Dim ADMDashAGC As New ADMDashboardAGCTab()
        Me.Close()
        ADMDashAGC.Show()
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


End Class