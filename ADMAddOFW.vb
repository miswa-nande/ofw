Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class ADMAddOFW
    Dim connectionString As String = "Server=localhost;Database=ofw_mis;User Id=root;Password=;"
    Dim connection As New MySqlConnection(connectionString)

    Private Sub ADMAddOFW_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbxAddOFWCivStat.Items.Add("Single")
        cbxAddOFWCivStat.Items.Add("Married")
        cbxAddOFWCivStat.Items.Add("Legally Separated")
        cbxAddOFWCivStat.Items.Add("Widowed")

        cbxAddOFWGender.Items.Add("Male")
        cbxAddOFWGender.Items.Add("Female")
    End Sub


    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnADD.Click
        Dim firstName As String = txtbxAddOFWFName.Text
        Dim middleName As String = txtbxAddOFWMName.Text
        Dim lastName As String = txtbxAddOFWLName.Text
        Dim dateOfBirth As Date = dateAddOFWDOB.Value
        Dim gender As String = cbxAddOFWGender.SelectedItem.ToString()
        Dim civilStatus As String = cbxAddOFWCivStat.SelectedItem.ToString()
        Dim street As String = txtbxAddOFWStreet.Text
        Dim barangay As String = txtbxAddOFWBrgy.Text
        Dim city As String = txtbxAddOFWCity.Text
        Dim province As String = txtbxAddOFWProv.Text
        Dim zipcode As String = txtbxAddOFWZip.Text
        Dim contactNumber As String = txtbxAddOFWContNum.Text
        Dim emrgContactNum As String = txtbxAddOFWEmrContNum.Text
        Dim passportNum As String = txtbxAddOFWPassportNum.Text
        Dim visaNum As String = txtbxAddOFWVisaNum.Text
        Dim OECNum As String = txtbxAddOFWOECNum.Text


        Dim query As String = "INSERT INTO OFW (FirstName, MiddleName, LastName, DOB, Sex, CivilStatus, Street, Barangay, City, Province, Zipcode,
                                                ContactNum, EmergencyContactNum, PassportNum, VISANum, OECNum) 
                                        VALUES (@FirstName, @MiddleName, @LastName, @DOB, @Sex, @CivilStatus, @Street, @Barangay, @City, @Province, @Zipcode,
                                                @ContactNum, @EmergencyContactNum, @PassportNum, @VISANum, @OECNum)"

        Using connection = New MySqlConnection(connectionString)
            connection.Open()
            Using command = New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@FirstName", firstName)
                command.Parameters.AddWithValue("@MiddleName", middleName)
                command.Parameters.AddWithValue("@LastName", lastName)
                command.Parameters.AddWithValue("@DOB", dateOfBirth)
                command.Parameters.AddWithValue("@Sex", gender)
                command.Parameters.AddWithValue("@CivilStatus", civilStatus)
                command.Parameters.AddWithValue("@Street", street)
                command.Parameters.AddWithValue("@Barangay", barangay)
                command.Parameters.AddWithValue("@City", city)
                command.Parameters.AddWithValue("@Province", province)
                command.Parameters.AddWithValue("@Zipcode", zipcode)
                command.Parameters.AddWithValue("@ContactNum", contactNumber)
                command.Parameters.AddWithValue("@EmergencyContactNum", emrgContactNum)
                command.Parameters.AddWithValue("@PassportNum", passportNum)
                command.Parameters.AddWithValue("@VISANum", visaNum)
                command.Parameters.AddWithValue("@OECNum", OECNum)
                ' ... other parameters ...

                command.ExecuteNonQuery()
                MessageBox.Show("OFW record added successfully!")

                Me.Close()
                ADMDashboardOFWTab.LoadToDGVOfw()
            End Using
        End Using
    End Sub

    Private Sub btnCANCEL_Click(sender As Object, e As EventArgs) Handles btnCANCEL.Click
        Me.Close()
    End Sub

End Class