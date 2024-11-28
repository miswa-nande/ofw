<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ADMEditJOB
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        dateJOBDeadline = New DateTimePicker()
        Label2 = New Label()
        btnSAVE = New Button()
        Panel1 = New Panel()
        cbxJOBStat = New ComboBox()
        Label6 = New Label()
        txtJOBSalary = New TextBox()
        Label16 = New Label()
        txtJOBAgencyId = New TextBox()
        Label14 = New Label()
        Label13 = New Label()
        txtJOBBenefits = New TextBox()
        Label12 = New Label()
        txtJOBConditions = New TextBox()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        txtJOBSkill = New TextBox()
        txtJOBVacancies = New TextBox()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        txtJOBCountry = New TextBox()
        txtJOBDescription = New TextBox()
        txtJOBTitle = New TextBox()
        btnCANCEL = New Button()
        Label1 = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' dateJOBDeadline
        ' 
        dateJOBDeadline.Format = DateTimePickerFormat.Short
        dateJOBDeadline.Location = New Point(14, 203)
        dateJOBDeadline.Name = "dateJOBDeadline"
        dateJOBDeadline.Size = New Size(134, 23)
        dateJOBDeadline.TabIndex = 52
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Maiandra GD", 48F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.MidnightBlue
        Label2.Location = New Point(1, 15)
        Label2.Name = "Label2"
        Label2.Size = New Size(448, 77)
        Label2.TabIndex = 24
        Label2.Text = "Job Placement"
        ' 
        ' btnSAVE
        ' 
        btnSAVE.BackColor = Color.PaleGreen
        btnSAVE.FlatStyle = FlatStyle.Flat
        btnSAVE.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSAVE.ForeColor = Color.DarkGreen
        btnSAVE.Location = New Point(697, 364)
        btnSAVE.Name = "btnSAVE"
        btnSAVE.Size = New Size(119, 40)
        btnSAVE.TabIndex = 25
        btnSAVE.Text = "SAVE"
        btnSAVE.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.SkyBlue
        Panel1.Controls.Add(dateJOBDeadline)
        Panel1.Controls.Add(cbxJOBStat)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(txtJOBSalary)
        Panel1.Controls.Add(Label16)
        Panel1.Controls.Add(txtJOBAgencyId)
        Panel1.Controls.Add(Label14)
        Panel1.Controls.Add(Label13)
        Panel1.Controls.Add(txtJOBBenefits)
        Panel1.Controls.Add(Label12)
        Panel1.Controls.Add(txtJOBConditions)
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(Label10)
        Panel1.Controls.Add(Label11)
        Panel1.Controls.Add(txtJOBSkill)
        Panel1.Controls.Add(txtJOBVacancies)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(txtJOBCountry)
        Panel1.Controls.Add(txtJOBDescription)
        Panel1.Controls.Add(txtJOBTitle)
        Panel1.Location = New Point(1, 95)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(827, 254)
        Panel1.TabIndex = 22
        ' 
        ' cbxJOBStat
        ' 
        cbxJOBStat.FormattingEnabled = True
        cbxJOBStat.Location = New Point(149, 146)
        cbxJOBStat.Name = "cbxJOBStat"
        cbxJOBStat.Size = New Size(102, 23)
        cbxJOBStat.TabIndex = 51
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(197, 70)
        Label6.Name = "Label6"
        Label6.Size = New Size(88, 15)
        Label6.TabIndex = 50
        Label6.Text = "Salary Offered"
        ' 
        ' txtJOBSalary
        ' 
        txtJOBSalary.Location = New Point(197, 88)
        txtJOBSalary.Name = "txtJOBSalary"
        txtJOBSalary.PlaceholderText = "Industry"
        txtJOBSalary.Size = New Size(177, 23)
        txtJOBSalary.TabIndex = 49
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label16.Location = New Point(14, 70)
        Label16.Name = "Label16"
        Label16.Size = New Size(64, 15)
        Label16.TabIndex = 44
        Label16.Text = "Agency ID"
        ' 
        ' txtJOBAgencyId
        ' 
        txtJOBAgencyId.Location = New Point(14, 88)
        txtJOBAgencyId.Name = "txtJOBAgencyId"
        txtJOBAgencyId.PlaceholderText = "Company Name"
        txtJOBAgencyId.Size = New Size(177, 23)
        txtJOBAgencyId.TabIndex = 43
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label14.Location = New Point(14, 185)
        Label14.Name = "Label14"
        Label14.Size = New Size(121, 15)
        Label14.TabIndex = 40
        Label14.Text = "Application Deadline"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label13.Location = New Point(440, 128)
        Label13.Name = "Label13"
        Label13.Size = New Size(54, 15)
        Label13.TabIndex = 38
        Label13.Text = "Benefits"
        ' 
        ' txtJOBBenefits
        ' 
        txtJOBBenefits.Location = New Point(440, 146)
        txtJOBBenefits.Name = "txtJOBBenefits"
        txtJOBBenefits.PlaceholderText = "Zipcode"
        txtJOBBenefits.Size = New Size(188, 23)
        txtJOBBenefits.TabIndex = 37
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(257, 128)
        Label12.Name = "Label12"
        Label12.Size = New Size(65, 15)
        Label12.TabIndex = 36
        Label12.Text = "Conditions"
        ' 
        ' txtJOBConditions
        ' 
        txtJOBConditions.Location = New Point(257, 146)
        txtJOBConditions.Name = "txtJOBConditions"
        txtJOBConditions.PlaceholderText = "Country"
        txtJOBConditions.Size = New Size(177, 23)
        txtJOBConditions.TabIndex = 35
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(380, 70)
        Label9.Name = "Label9"
        Label9.Size = New Size(35, 15)
        Label9.TabIndex = 34
        Label9.Text = "Skills"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(14, 128)
        Label10.Name = "Label10"
        Label10.Size = New Size(124, 15)
        Label10.TabIndex = 33
        Label10.Text = "Number of Vacancies"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(149, 128)
        Label11.Name = "Label11"
        Label11.Size = New Size(42, 15)
        Label11.TabIndex = 32
        Label11.Text = "Status"
        ' 
        ' txtJOBSkill
        ' 
        txtJOBSkill.Location = New Point(380, 88)
        txtJOBSkill.Name = "txtJOBSkill"
        txtJOBSkill.PlaceholderText = "State"
        txtJOBSkill.Size = New Size(177, 23)
        txtJOBSkill.TabIndex = 31
        ' 
        ' txtJOBVacancies
        ' 
        txtJOBVacancies.Location = New Point(14, 146)
        txtJOBVacancies.Name = "txtJOBVacancies"
        txtJOBVacancies.PlaceholderText = "Street"
        txtJOBVacancies.Size = New Size(124, 23)
        txtJOBVacancies.TabIndex = 29
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(432, 14)
        Label5.Name = "Label5"
        Label5.Size = New Size(139, 15)
        Label5.TabIndex = 22
        Label5.Text = "Country of Employment"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(12, 14)
        Label4.Name = "Label4"
        Label4.Size = New Size(54, 15)
        Label4.TabIndex = 21
        Label4.Text = "Job Title"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(222, 14)
        Label3.Name = "Label3"
        Label3.Size = New Size(93, 15)
        Label3.TabIndex = 20
        Label3.Text = "Job Description"
        ' 
        ' txtJOBCountry
        ' 
        txtJOBCountry.Location = New Point(432, 32)
        txtJOBCountry.Name = "txtJOBCountry"
        txtJOBCountry.PlaceholderText = "Last Name"
        txtJOBCountry.Size = New Size(196, 23)
        txtJOBCountry.TabIndex = 2
        ' 
        ' txtJOBDescription
        ' 
        txtJOBDescription.Location = New Point(222, 32)
        txtJOBDescription.Name = "txtJOBDescription"
        txtJOBDescription.PlaceholderText = "Middle Name"
        txtJOBDescription.Size = New Size(196, 23)
        txtJOBDescription.TabIndex = 1
        ' 
        ' txtJOBTitle
        ' 
        txtJOBTitle.Location = New Point(12, 32)
        txtJOBTitle.Name = "txtJOBTitle"
        txtJOBTitle.PlaceholderText = "First Name"
        txtJOBTitle.Size = New Size(196, 23)
        txtJOBTitle.TabIndex = 0
        ' 
        ' btnCANCEL
        ' 
        btnCANCEL.BackColor = Color.MistyRose
        btnCANCEL.FlatStyle = FlatStyle.Flat
        btnCANCEL.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCANCEL.ForeColor = Color.Firebrick
        btnCANCEL.Location = New Point(572, 364)
        btnCANCEL.Name = "btnCANCEL"
        btnCANCEL.Size = New Size(119, 40)
        btnCANCEL.TabIndex = 26
        btnCANCEL.Text = "CANCEL"
        btnCANCEL.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Maiandra GD", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.MidnightBlue
        Label1.Location = New Point(433, 41)
        Label1.Name = "Label1"
        Label1.Size = New Size(135, 45)
        Label1.TabIndex = 23
        Label1.Text = ">EDIT"
        ' 
        ' ADMEditJOB
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DeepSkyBlue
        ClientSize = New Size(828, 419)
        Controls.Add(Label2)
        Controls.Add(btnSAVE)
        Controls.Add(Panel1)
        Controls.Add(btnCANCEL)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "ADMEditJOB"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ADMEditJOB"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dateJOBDeadline As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSAVE As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents cbxJOBStat As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtJOBSalary As TextBox
    Friend WithEvents Label16 As Label
    Private WithEvents txtJOBAgencyId As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtJOBBenefits As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtJOBConditions As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtJOBSkill As TextBox
    Friend WithEvents txtJOBVacancies As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Private WithEvents txtJOBCountry As TextBox
    Private WithEvents txtJOBDescription As TextBox
    Friend WithEvents txtJOBTitle As TextBox
    Friend WithEvents btnCANCEL As Button
    Friend WithEvents Label1 As Label
End Class
