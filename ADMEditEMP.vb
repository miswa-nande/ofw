Imports MySql.Data.MySqlClient

Public Class ADMEditEMP
    Dim connectionString As String = "Server=localhost;Database=ofw_mis;User Id=root;Password=;"
    Dim connection As New MySqlConnection(connectionString)
    Private selectedEMPId As Integer

    Private Sub ADMEditEMP_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub New(empId As Integer)
        InitializeComponent()
        selectedEMPId = empId
        ' Populate form fields with data from the selected OFW
        PopulateFormFields(empId)
    End Sub

    Private Sub PopulateFormFields(ofwId As Integer)
        Dim query As String = "SELECT * FROM EMPLOYER WHERE EmployerId = @EmployerId"

        Using connection = New MySqlConnection(connectionString)
            connection.Open()
            Using command = New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@EmployerId", selectedEMPId)
                Dim reader As MySqlDataReader = command.ExecuteReader()

                If reader.Read() Then
                    txtEMPFName.Text = reader("EmployerFirstName").ToString()
                    txtEMPMName.Text = reader("EmployerMiddleName").ToString()
                    txtEMPLName.Text = reader("EmployerLastName").ToString()
                    txtEMPCompanyName.Text = reader("CompanyName").ToString()
                    txtEMPStreet.Text = reader("CompanyStreet").ToString()
                    txtEMPCity.Text = reader("CompanyCity").ToString()
                    txtEMPState.Text = reader("CompanyState").ToString()
                    txtEMPCountry.Text = reader("CompanyCountry").ToString()
                    txtEMPZip.Text = reader("CompanyZipcode").ToString()
                    txtEMPContNum.Text = reader("EmployerContactNum").ToString()
                    txtEMPEmail.Text = reader("EmployerEmail").ToString()
                    txtEMPIndustry.Text = reader("Industry").ToString()
                End If
            End Using
        End Using
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSAVE.Click
        Dim updatedEmployerFirstName As String = txtEMPFName.Text
        Dim updatedEmployerMiddleName As String = txtEMPMName.Text
        Dim updatedEmployerLastName As String = txtEMPLName.Text
        Dim updatedCompanyName As String = txtEMPCompanyName.Text
        Dim updatedCompanyStreet As String = txtEMPStreet.Text
        Dim updatedCompanyCity As String = txtEMPCity.Text
        Dim updatedCompanyState As String = txtEMPState.Text
        Dim updatedCompanyCountry As String = txtEMPCountry.Text
        Dim updatedCompanyZipcode As String = txtEMPZip.Text




        Dim updatedEmployerContactNum As String = txtEMPContNum.Text
        Dim updatedEmployerEmail As String = txtEMPEmail.Text
        Dim updatedIndustry As String = txtEMPIndustry.Text

        ' ... other updated fields ...

        Dim query As String = "UPDATE EMPLOYER SET EmployerFirstName = @EmployerFirstName, EmployerMiddleName = @EmployerMiddleName, EmployerLastName = @EmployerLastName, CompanyName = @CompanyName, CompanyStreet = @CompanyStreet, CompanyCity = @CompanyCity,
                                              CompanyState = @CompanyState, CompanyCountry = @CompanyCountry, CompanyZipcode = @CompanyZipcode, EmployerContactNum = @EmployerContactNum, EmployerEmail = @EmployerEmail, Industry = @Industry WHERE EmployerId = @EmployerId"

        Using connection = New MySqlConnection(connectionString)
            connection.Open()
            Using command = New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@EmployerFirstName", updatedEmployerFirstName)
                command.Parameters.AddWithValue("@EmployerMiddleName", updatedEmployerMiddleName)
                command.Parameters.AddWithValue("@EmployerLastName", updatedEmployerLastName)
                command.Parameters.AddWithValue("@CompanyName", updatedCompanyName)
                command.Parameters.AddWithValue("@CompanyStreet", updatedCompanyStreet)
                command.Parameters.AddWithValue("@CompanyCity", updatedCompanyCity)
                command.Parameters.AddWithValue("@CompanyState", updatedCompanyState)
                command.Parameters.AddWithValue("@CompanyCountry", updatedCompanyCountry)
                command.Parameters.AddWithValue("@CompanyZipcode", updatedCompanyZipcode)
                command.Parameters.AddWithValue("@EmployerContactNum", updatedEmployerContactNum)
                command.Parameters.AddWithValue("@EmployerEmail", updatedEmployerEmail)
                command.Parameters.AddWithValue("@Industry", updatedIndustry)
                command.Parameters.AddWithValue("@EmployerId", selectedEMPId)
                ' ... other parameters ...

                command.ExecuteNonQuery()
                MessageBox.Show("Employer record updated successfully!")

                ' Close the edit form and refresh the main form's DataGridView
                Me.Close()
                ' Assuming you have a reference to the main form:
                ADMDashboardEMPTab.LoadToDGVEmployer() ' Call the refresh method in the main form
            End Using
        End Using
    End Sub

End Class