Imports MySql.Data.MySqlClient

Public Class ADMEditOFW
    Dim connectionString As String = "Server=localhost;Database=ofw_mis;User Id=root;Password=;"
    Dim connection As New MySqlConnection(connectionString)
    Private selectedOFWId As Integer

    Private Sub ADMEditOFW_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbxEditOFWCivStat.Items.Add("Single")
        cbxEditOFWCivStat.Items.Add("Married")
        cbxEditOFWCivStat.Items.Add("Legally Separated")
        cbxEditOFWCivStat.Items.Add("Widowed")

        cbxEditOFWGender.Items.Add("Male")
        cbxEditOFWGender.Items.Add("Female")
    End Sub

    Public Sub New(ofwId As Integer)
        InitializeComponent()
        selectedOFWId = ofwId
        ' Populate form fields with data from the selected OFW
        PopulateFormFields(ofwId)
    End Sub



    Private Sub PopulateFormFields(ofwId As Integer)
        Dim query As String = "SELECT * FROM OFW WHERE OFWId = @OFWId"

        Using connection = New MySqlConnection(connectionString)
            connection.Open()
            Using command = New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@OFWId", ofwId)
                Dim reader As MySqlDataReader = command.ExecuteReader()

                If reader.Read() Then
                    txtbxEditOFWFName.Text = reader("FirstName").ToString()
                    txtbxEditOFWMName.Text = reader("MiddleName").ToString()
                    txtbxEditOFWLName.Text = reader("LastName").ToString()

                    dateEditOFWDOB.Value = reader("DOB")
                    cbxEditOFWGender.SelectedItem = reader("Sex")
                    cbxEditOFWCivStat.SelectedItem = reader("CivilStatus")

                    txtbxEditOFWStreet.Text = reader("Street").ToString()
                    txtbxEditOFWBrgy.Text = reader("Barangay").ToString()
                    txtbxEditOFWCity.Text = reader("City").ToString()
                    txtbxEditOFWProv.Text = reader("Province").ToString()
                    txtbxEditOFWZip.Text = reader("Zipcode").ToString()
                    txtbxEditOFWContNum.Text = reader("ContactNum").ToString()
                    txtbxEditOFWEmrContNum.Text = reader("EmergencyContactNum").ToString()
                    txtbxEditOFWPassportNum.Text = reader("PassportNum").ToString()
                    txtbxEditOFWVisaNum.Text = reader("VISANum").ToString()
                    txtbxEditOFWOECNum.Text = reader("OECNum").ToString()
                    ' ... populate other fields ...
                End If
            End Using
        End Using
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim updatedFirstName As String = txtbxEditOFWFName.Text
        Dim updatedMiddleName As String = txtbxEditOFWMName.Text
        Dim updatedLastName As String = txtbxEditOFWLName.Text
        Dim updatedDOB As Date = dateEditOFWDOB.Value
        Dim updatedGender As String = cbxEditOFWGender.SelectedItem.ToString()
        Dim updatedCivilStatus As String = cbxEditOFWCivStat.SelectedItem.ToString()
        Dim updatedStreet As String = txtbxEditOFWStreet.Text
        Dim updatedBarangay As String = txtbxEditOFWBrgy.Text
        Dim updatedCity As String = txtbxEditOFWCity.Text
        Dim updatedProvince As String = txtbxEditOFWProv.Text
        Dim updatedZipcode As String = txtbxEditOFWZip.Text
        Dim updatedContactNum As String = txtbxEditOFWContNum.Text
        Dim updatedEmrContactNum As String = txtbxEditOFWEmrContNum.Text
        Dim updatedPassportNum As String = txtbxEditOFWPassportNum.Text
        Dim updatedVisaNum As String = txtbxEditOFWVisaNum.Text
        Dim updatedOECNum As String = txtbxEditOFWOECNum.Text

        ' ... other updated fields ...

        Dim query As String = "UPDATE OFW SET FirstName = @FirstName, MiddleName = @MiddleName, LastName = @LastName, DOB = @DOB, Sex = @Sex, CivilStatus = @CivilStatus,
                                              Street = @Street, Barangay = @Barangay, City = @City, Province = @Province, Zipcode = @Zipcode, ContactNum = @ContactNum,
                                              EmergencyContactNum = @EmergencyContactNum, PassportNum = @PassportNum, VisaNum = @VisaNum, OECNum = @OECNum WHERE OFWId = @OFWId"

        Using connection = New MySqlConnection(connectionString)
                connection.Open()
                Using command = New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@FirstName", updatedFirstName)
                command.Parameters.AddWithValue("@MiddleName", updatedMiddleName)
                command.Parameters.AddWithValue("@LastName", updatedLastName)
                command.Parameters.AddWithValue("@DOB", updatedDOB)
                command.Parameters.AddWithValue("@Sex", updatedGender)
                command.Parameters.AddWithValue("@CivilStatus", updatedCivilStatus)
                command.Parameters.AddWithValue("@Street", updatedStreet)
                command.Parameters.AddWithValue("@Barangay", updatedBarangay)
                command.Parameters.AddWithValue("@City", updatedCity)
                command.Parameters.AddWithValue("@Province", updatedProvince)
                command.Parameters.AddWithValue("@Zipcode", updatedZipcode)
                command.Parameters.AddWithValue("@ContactNum", updatedContactNum)
                command.Parameters.AddWithValue("@EmergencyContactNum", updatedEmrContactNum)
                command.Parameters.AddWithValue("@PassportNum", updatedPassportNum)
                command.Parameters.AddWithValue("@VisaNum", updatedVisaNum)
                command.Parameters.AddWithValue("@OECNum", updatedOECNum)
                command.Parameters.AddWithValue("@OFWId", selectedOFWId)
                ' ... other parameters ...

                command.ExecuteNonQuery()
                MessageBox.Show("OFW record updated successfully!")

                    ' Close the edit form and refresh the main form's DataGridView
                    Me.Close()
                ' Assuming you have a reference to the main form:
                ADMDashboardOFWTab.LoadToDGVOfw() ' Call the refresh method in the main form
            End Using
            End Using
        End Sub

        Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
            Me.Close()

        End Sub
    End Class
