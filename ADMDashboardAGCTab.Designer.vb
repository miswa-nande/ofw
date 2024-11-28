<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ADMDashboardAGCTab
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
        txtAGCSpecFilt = New TextBox()
        Label8 = New Label()
        txtAGCWebFilt = New TextBox()
        btnADMDashSTAT = New Button()
        btnADMDashDEP = New Button()
        btnADMDashJOB = New Button()
        btnADMDashAGC = New Button()
        btnADMDashEMP = New Button()
        btnADMDashOFW = New Button()
        PictureBox1 = New PictureBox()
        Label14 = New Label()
        Label13 = New Label()
        btnClearFilter = New Button()
        lblAGCTally = New Label()
        Label12 = New Label()
        btnDLT = New Button()
        btnGEN = New Button()
        btnEDIT = New Button()
        btnADD = New Button()
        btnFilter = New Button()
        Label11 = New Label()
        txtAGCContNumFilt = New TextBox()
        Label10 = New Label()
        txtAGCEmailFilt = New TextBox()
        Label9 = New Label()
        txtAGCZipFilt = New TextBox()
        Label7 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        txtAGCNameFilt = New TextBox()
        Label3 = New Label()
        txtAGCIdFilt = New TextBox()
        Label2 = New Label()
        btnLogout = New Button()
        dgvAGC = New DataGridView()
        txtAGCLicNumFilt = New TextBox()
        Label1 = New Label()
        Panel4 = New Panel()
        btnCLose = New Button()
        Panel1 = New Panel()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvAGC, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' txtAGCSpecFilt
        ' 
        txtAGCSpecFilt.Location = New Point(1373, 327)
        txtAGCSpecFilt.Name = "txtAGCSpecFilt"
        txtAGCSpecFilt.PlaceholderText = "Industry"
        txtAGCSpecFilt.Size = New Size(84, 23)
        txtAGCSpecFilt.TabIndex = 112
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(1230, 355)
        Label8.Name = "Label8"
        Label8.Size = New Size(49, 15)
        Label8.TabIndex = 111
        Label8.Text = "Website"
        ' 
        ' txtAGCWebFilt
        ' 
        txtAGCWebFilt.Location = New Point(1230, 328)
        txtAGCWebFilt.Name = "txtAGCWebFilt"
        txtAGCWebFilt.PlaceholderText = "Company Name"
        txtAGCWebFilt.Size = New Size(137, 23)
        txtAGCWebFilt.TabIndex = 110
        ' 
        ' btnADMDashSTAT
        ' 
        btnADMDashSTAT.BackColor = Color.RoyalBlue
        btnADMDashSTAT.FlatAppearance.BorderSize = 0
        btnADMDashSTAT.FlatStyle = FlatStyle.Flat
        btnADMDashSTAT.Font = New Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnADMDashSTAT.ForeColor = Color.MidnightBlue
        btnADMDashSTAT.Location = New Point(36, 739)
        btnADMDashSTAT.Name = "btnADMDashSTAT"
        btnADMDashSTAT.Size = New Size(258, 73)
        btnADMDashSTAT.TabIndex = 7
        btnADMDashSTAT.Text = "Statistics"
        btnADMDashSTAT.UseVisualStyleBackColor = False
        ' 
        ' btnADMDashDEP
        ' 
        btnADMDashDEP.BackColor = Color.RoyalBlue
        btnADMDashDEP.FlatAppearance.BorderSize = 0
        btnADMDashDEP.FlatStyle = FlatStyle.Flat
        btnADMDashDEP.Font = New Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnADMDashDEP.ForeColor = Color.MidnightBlue
        btnADMDashDEP.Location = New Point(36, 660)
        btnADMDashDEP.Name = "btnADMDashDEP"
        btnADMDashDEP.Size = New Size(258, 73)
        btnADMDashDEP.TabIndex = 6
        btnADMDashDEP.Text = "Deployments"
        btnADMDashDEP.UseVisualStyleBackColor = False
        ' 
        ' btnADMDashJOB
        ' 
        btnADMDashJOB.BackColor = Color.RoyalBlue
        btnADMDashJOB.FlatAppearance.BorderSize = 0
        btnADMDashJOB.FlatStyle = FlatStyle.Flat
        btnADMDashJOB.Font = New Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnADMDashJOB.ForeColor = Color.MidnightBlue
        btnADMDashJOB.Location = New Point(36, 581)
        btnADMDashJOB.Name = "btnADMDashJOB"
        btnADMDashJOB.Size = New Size(258, 73)
        btnADMDashJOB.TabIndex = 5
        btnADMDashJOB.Text = "Job Placements"
        btnADMDashJOB.UseVisualStyleBackColor = False
        ' 
        ' btnADMDashAGC
        ' 
        btnADMDashAGC.BackColor = Color.DeepSkyBlue
        btnADMDashAGC.FlatAppearance.BorderSize = 0
        btnADMDashAGC.FlatStyle = FlatStyle.Flat
        btnADMDashAGC.Font = New Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnADMDashAGC.ForeColor = Color.MidnightBlue
        btnADMDashAGC.Location = New Point(36, 502)
        btnADMDashAGC.Name = "btnADMDashAGC"
        btnADMDashAGC.Size = New Size(301, 73)
        btnADMDashAGC.TabIndex = 4
        btnADMDashAGC.Text = "Agencies"
        btnADMDashAGC.UseVisualStyleBackColor = False
        ' 
        ' btnADMDashEMP
        ' 
        btnADMDashEMP.BackColor = Color.RoyalBlue
        btnADMDashEMP.FlatAppearance.BorderSize = 0
        btnADMDashEMP.FlatStyle = FlatStyle.Flat
        btnADMDashEMP.Font = New Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnADMDashEMP.ForeColor = Color.MidnightBlue
        btnADMDashEMP.Location = New Point(36, 423)
        btnADMDashEMP.Name = "btnADMDashEMP"
        btnADMDashEMP.Size = New Size(258, 73)
        btnADMDashEMP.TabIndex = 3
        btnADMDashEMP.Text = "Employers"
        btnADMDashEMP.UseVisualStyleBackColor = False
        ' 
        ' btnADMDashOFW
        ' 
        btnADMDashOFW.BackColor = Color.RoyalBlue
        btnADMDashOFW.FlatAppearance.BorderSize = 0
        btnADMDashOFW.FlatStyle = FlatStyle.Flat
        btnADMDashOFW.Font = New Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnADMDashOFW.ForeColor = Color.MidnightBlue
        btnADMDashOFW.Location = New Point(36, 344)
        btnADMDashOFW.Name = "btnADMDashOFW"
        btnADMDashOFW.Size = New Size(258, 73)
        btnADMDashOFW.TabIndex = 2
        btnADMDashOFW.Text = "OFWs"
        btnADMDashOFW.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.Untitled_design__8_
        PictureBox1.Location = New Point(13, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(314, 335)
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(1373, 356)
        Label14.Name = "Label14"
        Label14.Size = New Size(79, 15)
        Label14.TabIndex = 113
        Label14.Text = "Specialization"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(1233, 198)
        Label13.Name = "Label13"
        Label13.Size = New Size(36, 15)
        Label13.TabIndex = 109
        Label13.Text = "AGC-"
        ' 
        ' btnClearFilter
        ' 
        btnClearFilter.FlatStyle = FlatStyle.Popup
        btnClearFilter.Location = New Point(1299, 514)
        btnClearFilter.Name = "btnClearFilter"
        btnClearFilter.Size = New Size(76, 27)
        btnClearFilter.TabIndex = 108
        btnClearFilter.Text = "Clear"
        btnClearFilter.UseVisualStyleBackColor = True
        ' 
        ' lblAGCTally
        ' 
        lblAGCTally.AutoSize = True
        lblAGCTally.Location = New Point(1421, 554)
        lblAGCTally.Name = "lblAGCTally"
        lblAGCTally.Size = New Size(13, 15)
        lblAGCTally.TabIndex = 107
        lblAGCTally.Text = "0"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(1230, 554)
        Label12.Name = "Label12"
        Label12.Size = New Size(183, 15)
        Label12.TabIndex = 106
        Label12.Text = "Total number of Agencies shown:"
        ' 
        ' btnDLT
        ' 
        btnDLT.BackColor = Color.MistyRose
        btnDLT.FlatStyle = FlatStyle.Popup
        btnDLT.ForeColor = Color.DarkRed
        btnDLT.Location = New Point(1389, 752)
        btnDLT.Name = "btnDLT"
        btnDLT.Size = New Size(73, 66)
        btnDLT.TabIndex = 105
        btnDLT.Text = "DELETE"
        btnDLT.UseVisualStyleBackColor = False
        ' 
        ' btnGEN
        ' 
        btnGEN.BackColor = Color.LightCyan
        btnGEN.FlatStyle = FlatStyle.Popup
        btnGEN.ForeColor = Color.DarkBlue
        btnGEN.Location = New Point(1389, 680)
        btnGEN.Name = "btnGEN"
        btnGEN.Size = New Size(73, 66)
        btnGEN.TabIndex = 104
        btnGEN.Text = "GENERATE"
        btnGEN.UseVisualStyleBackColor = False
        ' 
        ' btnEDIT
        ' 
        btnEDIT.BackColor = Color.LightCyan
        btnEDIT.FlatStyle = FlatStyle.Popup
        btnEDIT.ForeColor = Color.DarkBlue
        btnEDIT.Location = New Point(1310, 680)
        btnEDIT.Name = "btnEDIT"
        btnEDIT.Size = New Size(73, 66)
        btnEDIT.TabIndex = 103
        btnEDIT.Text = "EDIT"
        btnEDIT.UseVisualStyleBackColor = False
        ' 
        ' btnADD
        ' 
        btnADD.BackColor = Color.LightCyan
        btnADD.FlatStyle = FlatStyle.Popup
        btnADD.ForeColor = Color.DarkBlue
        btnADD.Location = New Point(1232, 680)
        btnADD.Name = "btnADD"
        btnADD.Size = New Size(73, 66)
        btnADD.TabIndex = 102
        btnADD.Text = "ADD"
        btnADD.UseVisualStyleBackColor = False
        ' 
        ' btnFilter
        ' 
        btnFilter.FlatStyle = FlatStyle.Popup
        btnFilter.Location = New Point(1381, 514)
        btnFilter.Name = "btnFilter"
        btnFilter.Size = New Size(76, 27)
        btnFilter.TabIndex = 101
        btnFilter.Text = "Filter"
        btnFilter.UseVisualStyleBackColor = True
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(1230, 448)
        Label11.Name = "Label11"
        Label11.Size = New Size(96, 15)
        Label11.TabIndex = 100
        Label11.Text = "Contact Number"
        ' 
        ' txtAGCContNumFilt
        ' 
        txtAGCContNumFilt.Location = New Point(1230, 421)
        txtAGCContNumFilt.Name = "txtAGCContNumFilt"
        txtAGCContNumFilt.PlaceholderText = "####"
        txtAGCContNumFilt.Size = New Size(137, 23)
        txtAGCContNumFilt.TabIndex = 99
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(1230, 494)
        Label10.Name = "Label10"
        Label10.Size = New Size(36, 15)
        Label10.TabIndex = 98
        Label10.Text = "Email"
        ' 
        ' txtAGCEmailFilt
        ' 
        txtAGCEmailFilt.Location = New Point(1230, 467)
        txtAGCEmailFilt.Name = "txtAGCEmailFilt"
        txtAGCEmailFilt.PlaceholderText = "####"
        txtAGCEmailFilt.Size = New Size(137, 23)
        txtAGCEmailFilt.TabIndex = 97
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(1230, 402)
        Label9.Name = "Label9"
        Label9.Size = New Size(50, 15)
        Label9.TabIndex = 96
        Label9.Text = "Zipcode"
        ' 
        ' txtAGCZipFilt
        ' 
        txtAGCZipFilt.Location = New Point(1230, 375)
        txtAGCZipFilt.Name = "txtAGCZipFilt"
        txtAGCZipFilt.PlaceholderText = "####"
        txtAGCZipFilt.Size = New Size(137, 23)
        txtAGCZipFilt.TabIndex = 95
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(1230, 402)
        Label7.Name = "Label7"
        Label7.Size = New Size(0, 15)
        Label7.TabIndex = 94
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(1230, 310)
        Label5.Name = "Label5"
        Label5.Size = New Size(136, 15)
        Label5.TabIndex = 91
        Label5.Text = "Agency License Number"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(1230, 264)
        Label4.Name = "Label4"
        Label4.Size = New Size(82, 15)
        Label4.TabIndex = 89
        Label4.Text = "Agency Name"
        ' 
        ' txtAGCNameFilt
        ' 
        txtAGCNameFilt.Location = New Point(1230, 237)
        txtAGCNameFilt.Name = "txtAGCNameFilt"
        txtAGCNameFilt.PlaceholderText = "First Name"
        txtAGCNameFilt.Size = New Size(227, 23)
        txtAGCNameFilt.TabIndex = 88
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(1230, 218)
        Label3.Name = "Label3"
        Label3.Size = New Size(108, 15)
        Label3.TabIndex = 87
        Label3.Text = "Agency ID Number"
        ' 
        ' txtAGCIdFilt
        ' 
        txtAGCIdFilt.Location = New Point(1272, 193)
        txtAGCIdFilt.Name = "txtAGCIdFilt"
        txtAGCIdFilt.PlaceholderText = "#####"
        txtAGCIdFilt.Size = New Size(57, 23)
        txtAGCIdFilt.TabIndex = 86
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial Rounded MT Bold", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(1230, 155)
        Label2.Name = "Label2"
        Label2.Size = New Size(197, 33)
        Label2.TabIndex = 85
        Label2.Text = "Filter Search"
        ' 
        ' btnLogout
        ' 
        btnLogout.BackColor = Color.LightSlateGray
        btnLogout.FlatAppearance.BorderSize = 0
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.Font = New Font("Arial Rounded MT Bold", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnLogout.ForeColor = Color.Black
        btnLogout.Location = New Point(1347, 2)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(63, 21)
        btnLogout.TabIndex = 84
        btnLogout.Text = "LOGOUT"
        btnLogout.UseVisualStyleBackColor = False
        ' 
        ' dgvAGC
        ' 
        dgvAGC.BackgroundColor = SystemColors.ActiveCaption
        dgvAGC.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvAGC.Location = New Point(346, 155)
        dgvAGC.Name = "dgvAGC"
        dgvAGC.Size = New Size(878, 663)
        dgvAGC.TabIndex = 83
        ' 
        ' txtAGCLicNumFilt
        ' 
        txtAGCLicNumFilt.Location = New Point(1230, 283)
        txtAGCLicNumFilt.Name = "txtAGCLicNumFilt"
        txtAGCLicNumFilt.PlaceholderText = "Middle Name"
        txtAGCLicNumFilt.Size = New Size(227, 23)
        txtAGCLicNumFilt.TabIndex = 90
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Maiandra GD", 48F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.MidnightBlue
        Label1.Location = New Point(337, 39)
        Label1.Name = "Label1"
        Label1.Size = New Size(279, 77)
        Label1.TabIndex = 82
        Label1.Text = "Agencies"
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.MidnightBlue
        Panel4.Location = New Point(333, 118)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(1140, 22)
        Panel4.TabIndex = 81
        ' 
        ' btnCLose
        ' 
        btnCLose.BackColor = Color.Crimson
        btnCLose.FlatAppearance.BorderSize = 0
        btnCLose.FlatStyle = FlatStyle.Flat
        btnCLose.Font = New Font("Arial Rounded MT Bold", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnCLose.ForeColor = Color.MistyRose
        btnCLose.Location = New Point(1416, 2)
        btnCLose.Name = "btnCLose"
        btnCLose.Size = New Size(52, 21)
        btnCLose.TabIndex = 80
        btnCLose.Text = "CLOSE"
        btnCLose.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.MidnightBlue
        Panel1.Controls.Add(btnADMDashSTAT)
        Panel1.Controls.Add(btnADMDashDEP)
        Panel1.Controls.Add(btnADMDashJOB)
        Panel1.Controls.Add(btnADMDashAGC)
        Panel1.Controls.Add(btnADMDashEMP)
        Panel1.Controls.Add(btnADMDashOFW)
        Panel1.Controls.Add(PictureBox1)
        Panel1.ForeColor = SystemColors.ControlText
        Panel1.Location = New Point(-2, -1)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(337, 836)
        Panel1.TabIndex = 79
        ' 
        ' ADMDashboardAGCTab
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DeepSkyBlue
        ClientSize = New Size(1471, 834)
        Controls.Add(txtAGCSpecFilt)
        Controls.Add(Label8)
        Controls.Add(txtAGCWebFilt)
        Controls.Add(Label14)
        Controls.Add(Label13)
        Controls.Add(btnClearFilter)
        Controls.Add(lblAGCTally)
        Controls.Add(Label12)
        Controls.Add(btnDLT)
        Controls.Add(btnGEN)
        Controls.Add(btnEDIT)
        Controls.Add(btnADD)
        Controls.Add(btnFilter)
        Controls.Add(Label11)
        Controls.Add(txtAGCContNumFilt)
        Controls.Add(Label10)
        Controls.Add(txtAGCEmailFilt)
        Controls.Add(Label9)
        Controls.Add(txtAGCZipFilt)
        Controls.Add(Label7)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(txtAGCNameFilt)
        Controls.Add(Label3)
        Controls.Add(txtAGCIdFilt)
        Controls.Add(Label2)
        Controls.Add(btnLogout)
        Controls.Add(dgvAGC)
        Controls.Add(txtAGCLicNumFilt)
        Controls.Add(Label1)
        Controls.Add(Panel4)
        Controls.Add(btnCLose)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "ADMDashboardAGCTab"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ADMDashboardAGCTab"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvAGC, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtAGCSpecFilt As TextBox
    Friend WithEvents Label8 As Label
    Private WithEvents txtAGCWebFilt As TextBox
    Friend WithEvents btnADMDashSTAT As Button
    Friend WithEvents btnADMDashDEP As Button
    Friend WithEvents btnADMDashJOB As Button
    Friend WithEvents btnADMDashAGC As Button
    Friend WithEvents btnADMDashEMP As Button
    Friend WithEvents btnADMDashOFW As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents btnClearFilter As Button
    Private WithEvents lblAGCTally As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents btnDLT As Button
    Friend WithEvents btnGEN As Button
    Friend WithEvents btnEDIT As Button
    Friend WithEvents btnADD As Button
    Friend WithEvents btnFilter As Button
    Friend WithEvents Label11 As Label
    Private WithEvents txtAGCContNumFilt As TextBox
    Friend WithEvents Label10 As Label
    Private WithEvents txtAGCEmailFilt As TextBox
    Friend WithEvents Label9 As Label
    Private WithEvents txtAGCZipFilt As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Private WithEvents txtAGCNameFilt As TextBox
    Friend WithEvents Label3 As Label
    Private WithEvents txtAGCIdFilt As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnLogout As Button
    Friend WithEvents dgvAGC As DataGridView
    Private WithEvents txtAGCLicNumFilt As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnCLose As Button
    Friend WithEvents Panel1 As Panel
End Class
