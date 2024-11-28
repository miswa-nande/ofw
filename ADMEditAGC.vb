Imports MySql.Data.MySqlClient

Public Class ADMEditAGC
    Dim connectionString As String = "Server=localhost;Database=ofw_mis;User Id=root;Password=;"
    Dim connection As New MySqlConnection(connectionString)
    Private selectedAGCId As Integer
    Private Sub ADMEditAGC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbxEditAGCAccredStat.Items.Add("Acceredited")
        cbxEditAGCAccredStat.Items.Add("Not Accredited")
        cbxEditAGCAccredStat.Items.Add("Pending")
    End Sub

    Public Sub New(AgencyId As Integer)
        InitializeComponent()
        selectedAGCId = AgencyId
        ' Populate form fields with data from the selected OFW
        PopulateFormFields(AgencyId)
    End Sub

    Private Sub PopulateFormFields(ofwId As Integer)
        Dim query As String = "SELECT * FROM agency WHERE AgencyId = @AgencyId"

        Using connection = New MySqlConnection(connectionString)
            connection.Open()
            Using command = New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@AgencyId", selectedAGCId)
                Dim reader As MySqlDataReader = command.ExecuteReader()

                If reader.Read() Then
                    txtEditAGCFName.Text = reader("AgencyName").ToString()
                    txtEditAGCLicNum.Text = reader("AgencyLicenseNumber").ToString()
                    txtEditAGCSpec.Text = reader("Specialization").ToString()
                    txtEditAGCWebsite.Text = reader("WebsiteUrl").ToString()
                    cbxEditAGCAccredStat.SelectedItem = reader("GovAccreditationStat")
                    txtEditAGCStreet.Text = reader("Street").ToString()
                    txtEditAGCCity.Text = reader("City").ToString()
                    txtEditAGCState.Text = reader("State").ToString()
                    txtEditAGCCountry.Text = reader("Country").ToString()
                    txtEditAGCZip.Text = reader("Zipcode").ToString()
                    txtEditAGCContNum.Text = reader("ContactNum").ToString()
                    txtEditAGCEmail.Text = reader("Email").ToString()
                    txtEditAGCYrInOp.Text = reader("YearsOfOperation").ToString()
                End If
            End Using
        End Using
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSAVE.Click
        Dim updatedAGCName As String = txtEditAGCFName.Text
        Dim AgencyLicenseNumber As String = txtEditAGCLicNum.Text
        Dim updatedSpecialization As String = txtEditAGCSpec.Text
        Dim updatedWebsite As String = txtEditAGCWebsite.Text
        Dim updatedAccredStat As String = cbxEditAGCAccredStat.SelectedItem.ToString()
        Dim updatedStreet As String = txtEditAGCStreet.Text
        Dim updatedCity As String = txtEditAGCCity.Text
        Dim updatedState As String = txtEditAGCState.Text
        Dim updatedCountry As String = txtEditAGCCountry.Text
        Dim updatedZipcode As String = txtEditAGCZip.Text
        Dim updatedContactNum As String = txtEditAGCContNum.Text
        Dim updatedEmail As String = txtEditAGCEmail.Text
        Dim updatedYrInOp As String = txtEditAGCYrInOp.Text

        ' ... other updated fields ...

        Dim query As String = "UPDATE AGENCY SET AgencyName = @AgencyName, AgencyLicenseNumber = @AgencyLicenseNumber, Specialization = @Specialization, WebsiteUrl = @WebsiteUrl, GovAccreditationStat = @GovAccreditationStat, Street = @Street,
                                              City = @City, State = @State, Country = @Country, Zipcode = @Zipcode, ContactNum = @ContactNum, YearsOfOperation = @YearsOfOperation WHERE AgencyId = @AgencyId"

        Using connection = New MySqlConnection(connectionString)
            connection.Open()
            Using command = New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@AgencyName", updatedAGCName)
                command.Parameters.AddWithValue("@AgencyLicenseNumber", AgencyLicenseNumber)
                command.Parameters.AddWithValue("@Specialization", updatedSpecialization)
                command.Parameters.AddWithValue("@WebsiteUrl", updatedWebsite)
                command.Parameters.AddWithValue("@GovAccreditationStat", updatedAccredStat)
                command.Parameters.AddWithValue("@Street", updatedStreet)
                command.Parameters.AddWithValue("@City", updatedCity)
                command.Parameters.AddWithValue("@State", updatedState)
                command.Parameters.AddWithValue("@Country", updatedCountry)
                command.Parameters.AddWithValue("@Zipcode", updatedZipcode)
                command.Parameters.AddWithValue("@ContactNum", updatedContactNum)
                command.Parameters.AddWithValue("@YearsOfOperation", updatedEmail)
                command.Parameters.AddWithValue("@AgencyId", updatedYrInOp)
                ' ... other parameters ...

                command.ExecuteNonQuery()
                MessageBox.Show("Agency record updated successfully!")

                ' Close the edit form and refresh the main form's DataGridView
                Me.Close()
                ' Assuming you have a reference to the main form:
                ADMDashboardAGCTab.LoadToDGVAgency() ' Call the refresh method in the main form
            End Using
        End Using
    End Sub
End Class