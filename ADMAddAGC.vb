Imports System.Net.NetworkInformation
Imports MySql.Data.MySqlClient

Public Class ADMAddAGC
    Dim connectionString As String = "Server=localhost;Database=ofw_mis;User Id=root;Password=;"
    Dim connection As New MySqlConnection(connectionString)

    Private Sub ADMAddAGC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbxAGCAccredStat.Items.Add("Accredited")
        cbxAGCAccredStat.Items.Add("Not Accredited")
        cbxAGCAccredStat.Items.Add("Pending")
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnADD.Click
        Dim agencyName As String = txtAGCFName.Text
        Dim AgencylicenseNumber As String = txtAGCLicNum.Text
        Dim website As String = txtAGCWebsite.Text
        Dim govAccreditation As String = cbxAGCAccredStat.SelectedItem.ToString()
        Dim licenseExpDate As Date = dateAGCExp.Value
        Dim street As String = txtAGCStreet.Text
        Dim city As String = txtAGCCity.Text
        Dim state As String = txtAGCState.Text
        Dim country As String = txtAGCCountry.Text
        Dim zipcode As Integer = Integer.Parse(txtAGCZip.Text)
        Dim contactNumber As String = txtAGCContNum.Text
        Dim email As String = txtAGCEmail.Text
        Dim yearsOfOperation As Integer = Integer.Parse(txtAGCYrInOp.Text)

        Dim query As String = "INSERT INTO Agency (AgencyName, AgencyLicenseNumber, WebsiteUrl, GovAccreditationStat, LicenseExpDate, Street, City, State, Country, Zipcode, ContactNum, Email, YearsOfOperation) 
                                           VALUES (@AgencyName, @AgencyLicenseNumber, @WebsiteUrl, @GovAccreditationStat, @LicenseExpDate, @Street, @City, @State, @Country, @Zipcode, @ContactNum, @Email, @YearsOfOperation)"

        Using connection = New MySqlConnection(connectionString)
            connection.Open()
            Using command = New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@AgencyName", agencyName)
                command.Parameters.AddWithValue("@AgencyLicenseNumber", AgencylicenseNumber)
                command.Parameters.AddWithValue("@WebsiteUrl", website)
                command.Parameters.AddWithValue("@GovAccreditationStat", govAccreditation)
                command.Parameters.AddWithValue("@LicenseExpDate", licenseExpDate)
                command.Parameters.AddWithValue("@Street", street)
                command.Parameters.AddWithValue("@City", city)
                command.Parameters.AddWithValue("@State", state)
                command.Parameters.AddWithValue("@Country", country)
                command.Parameters.AddWithValue("@Zipcode", zipcode)
                command.Parameters.AddWithValue("@ContactNum", contactNumber)
                command.Parameters.AddWithValue("@Email", email)
                command.Parameters.AddWithValue("@YearsOfOperation", yearsOfOperation)

                command.ExecuteNonQuery()
                MessageBox.Show("Agency added successfully!")
                ' Close the form or clear the fields

                Me.Close()
                ADMDashboardAGCTab.LoadToDGVAgency()
            End Using
        End Using
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCANCEL.Click
        Me.Close()

    End Sub
End Class
