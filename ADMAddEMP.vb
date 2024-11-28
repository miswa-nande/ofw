Imports MySql.Data.MySqlClient

Public Class ADMAddEMP
    Dim connectionString As String = "Server=localhost;Database=ofw_mis;User Id=root;Password=;"
    Dim connection As New MySqlConnection(connectionString)
    Private Sub ADMAddEMP_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnADD_Click(sender As Object, e As EventArgs) Handles btnADD.Click
        Dim EmployerFirstName As String = txtEMPFName.Text
        Dim EmployerMiddleName As String = txtEMPMName.Text
        Dim EmployerLastName As String = txtEMPLName.Text
        Dim CompanyName As String = txtEMPCompanyName.Text
        Dim CompanyStreet As String = txtEMPStreet.Text
        Dim CompanyCity As String = txtEMPCity.Text
        Dim CompanyState As String = txtEMPState.Text
        Dim CompanyCountry As String = txtEMPCountry.Text
        Dim CompanyZipcode As String = txtEMPZip.Text
        Dim EmployerContactNum As String = txtEMPContNum.Text
        Dim EmployerEmail As String = txtEMPEmail.Text
        Dim Industry As String = txtEMPIndustry.Text



        Dim query As String = "INSERT INTO EMPLOYER (EmployerFirstName, EmployerMiddleName, EmployerLastName, CompanyName, CompanyStreet, CompanyCity, CompanyState, CompanyCountry,
                                                CompanyZipcode, EmployerContactNum, EmployerEmail, Industry) 
                                        VALUES (@EmployerFirstName, @EmployerMiddleName, @EmployerLastName, @CompanyName, @CompanyStreet, @CompanyCity, @CompanyState, @CompanyCountry,
                                                @CompanyZipcode, @EmployerContactNum, @EmployerEmail, @Industry)"

        Using connection = New MySqlConnection(connectionString)
            connection.Open()
            Using command = New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@EmployerFirstName", EmployerFirstName)
                command.Parameters.AddWithValue("@EmployerMiddleName", EmployerMiddleName)
                command.Parameters.AddWithValue("@EmployerLastName", EmployerLastName)
                command.Parameters.AddWithValue("@CompanyName", CompanyName)
                command.Parameters.AddWithValue("@CompanyStreet", CompanyStreet)
                command.Parameters.AddWithValue("@CompanyCity", CompanyCity)
                command.Parameters.AddWithValue("@CompanyState", CompanyState)
                command.Parameters.AddWithValue("@CompanyCountry", CompanyCountry)
                command.Parameters.AddWithValue("@CompanyZipcode", CompanyZipcode)
                command.Parameters.AddWithValue("@EmployerContactNum", EmployerContactNum)
                command.Parameters.AddWithValue("@EmployerEmail", EmployerEmail)
                command.Parameters.AddWithValue("@Industry", Industry)


                command.ExecuteNonQuery()
                MessageBox.Show("Employer record added successfully!")

                Me.Close()
                ADMDashboardEMPTab.LoadToDGVEmployer()
            End Using
        End Using
    End Sub
    Private Sub btnCANCEL_Click(sender As Object, e As EventArgs) Handles btnCANCEL.Click
        Me.Close()
    End Sub

End Class