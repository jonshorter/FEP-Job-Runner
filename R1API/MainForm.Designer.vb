<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.btnExecute = New System.Windows.Forms.Button()
        Me.btnAddComputer = New System.Windows.Forms.Button()
        Me.btnRemoveComputer = New System.Windows.Forms.Button()
        Me.lstComputerTargets = New System.Windows.Forms.CheckedListBox()
        Me.txtComputerTarget = New System.Windows.Forms.TextBox()
        Me.grpagent = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rdoagent = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDefaultJobName = New System.Windows.Forms.TextBox()
        Me.txtDefaultProjectName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtApiUser = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtAPIPass = New System.Windows.Forms.TextBox()
        Me.grpshare = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lstNetShare = New System.Windows.Forms.CheckedListBox()
        Me.txtNetSharePath = New System.Windows.Forms.TextBox()
        Me.btnAddNetShare = New System.Windows.Forms.Button()
        Me.btnRemoveNetShare = New System.Windows.Forms.Button()
        Me.txtServer = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtStatusSettings = New System.Windows.Forms.TextBox()
        Me.chkbypasscerts = New System.Windows.Forms.CheckBox()
        Me.txtdefaultshare = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.txtdefaultcomputer = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.btnSaveSettings = New System.Windows.Forms.Button()
        Me.txtDefaultTemplateName = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.tabSubMenu = New System.Windows.Forms.TabControl()
        Me.tabJobInfo = New System.Windows.Forms.TabPage()
        Me.txtTemplateName = New System.Windows.Forms.ComboBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtJobName = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txtProjectName = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.tabTargets = New System.Windows.Forms.TabPage()
        Me.rdoshare = New System.Windows.Forms.RadioButton()
        Me.tabFilters = New System.Windows.Forms.TabPage()
        Me.tabFiltersSubMenu = New System.Windows.Forms.TabControl()
        Me.tabInclusionFilter = New System.Windows.Forms.TabPage()
        Me.rdoinclregexsearch = New System.Windows.Forms.RadioButton()
        Me.rdoinclsimplesearch = New System.Windows.Forms.RadioButton()
        Me.chkinclsearchfilename = New System.Windows.Forms.CheckBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtinclmd5hash = New System.Windows.Forms.TextBox()
        Me.txtinclextensions = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtinclpathcontains = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtinclkeywords = New System.Windows.Forms.TextBox()
        Me.txtinclfiltername = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tabExclusionFilter = New System.Windows.Forms.TabPage()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtexclmd5hash = New System.Windows.Forms.TextBox()
        Me.txtexclextensions = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtexclpathcontains = New System.Windows.Forms.TextBox()
        Me.txtexclfiltername = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.tabAgentRemediation = New System.Windows.Forms.TabPage()
        Me.tabAgentRemediationSubMenu = New System.Windows.Forms.TabControl()
        Me.tabAgentSendFile = New System.Windows.Forms.TabPage()
        Me.chkremsendexecute = New System.Windows.Forms.CheckBox()
        Me.chkremsenddelete = New System.Windows.Forms.CheckBox()
        Me.txtremsenddest = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtremsendsource = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.tabAgentExecute = New System.Windows.Forms.TabPage()
        Me.txtremexecargs = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtremexecpath = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.tabAgentDelete = New System.Windows.Forms.TabPage()
        Me.txtremdelfilepath = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TabAgentKill = New System.Windows.Forms.TabPage()
        Me.txtremkillprocname = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.nmbremkillprocid = New System.Windows.Forms.NumericUpDown()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtStatusBox = New System.Windows.Forms.TextBox()
        Me.tabMenu = New System.Windows.Forms.TabControl()
        Me.tabSettings = New System.Windows.Forms.TabPage()
        Me.tabJobExecution = New System.Windows.Forms.TabPage()
        Me.btnLoadFromBox = New System.Windows.Forms.Button()
        Me.btnSaveAsBox = New System.Windows.Forms.Button()
        Me.tabBoxedJobs = New System.Windows.Forms.TabPage()
        Me.lstBoxedJobs = New System.Windows.Forms.CheckedListBox()
        Me.txtStatusBoxJob = New System.Windows.Forms.TextBox()
        Me.btnBoxJobCollection1 = New System.Windows.Forms.Button()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.txtboxtargetcomputer = New System.Windows.Forms.TextBox()
        Me.tabAbout = New System.Windows.Forms.TabPage()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ofdBox = New System.Windows.Forms.OpenFileDialog()
        Me.sfdBox = New System.Windows.Forms.SaveFileDialog()
        Me.grpagent.SuspendLayout()
        Me.grpshare.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.tabSubMenu.SuspendLayout()
        Me.tabJobInfo.SuspendLayout()
        Me.tabTargets.SuspendLayout()
        Me.tabFilters.SuspendLayout()
        Me.tabFiltersSubMenu.SuspendLayout()
        Me.tabInclusionFilter.SuspendLayout()
        Me.tabExclusionFilter.SuspendLayout()
        Me.tabAgentRemediation.SuspendLayout()
        Me.tabAgentRemediationSubMenu.SuspendLayout()
        Me.tabAgentSendFile.SuspendLayout()
        Me.tabAgentExecute.SuspendLayout()
        Me.tabAgentDelete.SuspendLayout()
        Me.TabAgentKill.SuspendLayout()
        CType(Me.nmbremkillprocid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMenu.SuspendLayout()
        Me.tabSettings.SuspendLayout()
        Me.tabJobExecution.SuspendLayout()
        Me.tabBoxedJobs.SuspendLayout()
        Me.tabAbout.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExecute
        '
        Me.btnExecute.Location = New System.Drawing.Point(543, 400)
        Me.btnExecute.Name = "btnExecute"
        Me.btnExecute.Size = New System.Drawing.Size(75, 23)
        Me.btnExecute.TabIndex = 0
        Me.btnExecute.Text = "Execute Job"
        Me.btnExecute.UseVisualStyleBackColor = True
        '
        'btnAddComputer
        '
        Me.btnAddComputer.Location = New System.Drawing.Point(132, 29)
        Me.btnAddComputer.Name = "btnAddComputer"
        Me.btnAddComputer.Size = New System.Drawing.Size(75, 23)
        Me.btnAddComputer.TabIndex = 2
        Me.btnAddComputer.Text = "Add Computer"
        Me.btnAddComputer.UseVisualStyleBackColor = True
        '
        'btnRemoveComputer
        '
        Me.btnRemoveComputer.Location = New System.Drawing.Point(132, 128)
        Me.btnRemoveComputer.Name = "btnRemoveComputer"
        Me.btnRemoveComputer.Size = New System.Drawing.Size(75, 23)
        Me.btnRemoveComputer.TabIndex = 3
        Me.btnRemoveComputer.Text = "Remove"
        Me.btnRemoveComputer.UseVisualStyleBackColor = True
        '
        'lstComputerTargets
        '
        Me.lstComputerTargets.FormattingEnabled = True
        Me.lstComputerTargets.Location = New System.Drawing.Point(6, 57)
        Me.lstComputerTargets.Name = "lstComputerTargets"
        Me.lstComputerTargets.Size = New System.Drawing.Size(120, 94)
        Me.lstComputerTargets.TabIndex = 4
        '
        'txtComputerTarget
        '
        Me.txtComputerTarget.Location = New System.Drawing.Point(6, 31)
        Me.txtComputerTarget.Name = "txtComputerTarget"
        Me.txtComputerTarget.Size = New System.Drawing.Size(120, 20)
        Me.txtComputerTarget.TabIndex = 5
        '
        'grpagent
        '
        Me.grpagent.Controls.Add(Me.Label1)
        Me.grpagent.Controls.Add(Me.lstComputerTargets)
        Me.grpagent.Controls.Add(Me.txtComputerTarget)
        Me.grpagent.Controls.Add(Me.btnAddComputer)
        Me.grpagent.Controls.Add(Me.btnRemoveComputer)
        Me.grpagent.Location = New System.Drawing.Point(6, 27)
        Me.grpagent.Name = "grpagent"
        Me.grpagent.Size = New System.Drawing.Size(219, 161)
        Me.grpagent.TabIndex = 6
        Me.grpagent.TabStop = False
        Me.grpagent.Text = "Computer Targets"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Hostname:"
        '
        'rdoagent
        '
        Me.rdoagent.AutoSize = True
        Me.rdoagent.Checked = True
        Me.rdoagent.Location = New System.Drawing.Point(7, 6)
        Me.rdoagent.Name = "rdoagent"
        Me.rdoagent.Size = New System.Drawing.Size(98, 17)
        Me.rdoagent.TabIndex = 8
        Me.rdoagent.TabStop = True
        Me.rdoagent.Text = "Agent Endpoint"
        Me.rdoagent.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Job Name*:"
        '
        'txtDefaultJobName
        '
        Me.txtDefaultJobName.Location = New System.Drawing.Point(116, 42)
        Me.txtDefaultJobName.Name = "txtDefaultJobName"
        Me.txtDefaultJobName.Size = New System.Drawing.Size(235, 20)
        Me.txtDefaultJobName.TabIndex = 8
        Me.txtDefaultJobName.Text = "test"
        '
        'txtDefaultProjectName
        '
        Me.txtDefaultProjectName.Location = New System.Drawing.Point(116, 68)
        Me.txtDefaultProjectName.Name = "txtDefaultProjectName"
        Me.txtDefaultProjectName.Size = New System.Drawing.Size(235, 20)
        Me.txtDefaultProjectName.TabIndex = 9
        Me.txtDefaultProjectName.Text = "ETA"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Project Name:"
        '
        'txtApiUser
        '
        Me.txtApiUser.Location = New System.Drawing.Point(441, 17)
        Me.txtApiUser.Name = "txtApiUser"
        Me.txtApiUser.Size = New System.Drawing.Size(154, 20)
        Me.txtApiUser.TabIndex = 11
        Me.txtApiUser.Text = "FireEye"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(357, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "API Username*:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(357, 46)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "API Password*:"
        '
        'txtAPIPass
        '
        Me.txtAPIPass.Location = New System.Drawing.Point(441, 43)
        Me.txtAPIPass.Name = "txtAPIPass"
        Me.txtAPIPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtAPIPass.Size = New System.Drawing.Size(154, 20)
        Me.txtAPIPass.TabIndex = 14
        Me.txtAPIPass.Text = "abc123!"
        '
        'grpshare
        '
        Me.grpshare.Controls.Add(Me.Label6)
        Me.grpshare.Controls.Add(Me.lstNetShare)
        Me.grpshare.Controls.Add(Me.txtNetSharePath)
        Me.grpshare.Controls.Add(Me.btnAddNetShare)
        Me.grpshare.Controls.Add(Me.btnRemoveNetShare)
        Me.grpshare.Location = New System.Drawing.Point(242, 27)
        Me.grpshare.Name = "grpshare"
        Me.grpshare.Size = New System.Drawing.Size(360, 161)
        Me.grpshare.TabIndex = 7
        Me.grpshare.TabStop = False
        Me.grpshare.Text = "Network Shares"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 15)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Path:"
        '
        'lstNetShare
        '
        Me.lstNetShare.FormattingEnabled = True
        Me.lstNetShare.Location = New System.Drawing.Point(6, 57)
        Me.lstNetShare.Name = "lstNetShare"
        Me.lstNetShare.Size = New System.Drawing.Size(267, 94)
        Me.lstNetShare.TabIndex = 4
        '
        'txtNetSharePath
        '
        Me.txtNetSharePath.Location = New System.Drawing.Point(6, 31)
        Me.txtNetSharePath.Name = "txtNetSharePath"
        Me.txtNetSharePath.Size = New System.Drawing.Size(267, 20)
        Me.txtNetSharePath.TabIndex = 5
        '
        'btnAddNetShare
        '
        Me.btnAddNetShare.Location = New System.Drawing.Point(279, 28)
        Me.btnAddNetShare.Name = "btnAddNetShare"
        Me.btnAddNetShare.Size = New System.Drawing.Size(75, 23)
        Me.btnAddNetShare.TabIndex = 2
        Me.btnAddNetShare.Text = "Add Computer"
        Me.btnAddNetShare.UseVisualStyleBackColor = True
        '
        'btnRemoveNetShare
        '
        Me.btnRemoveNetShare.Location = New System.Drawing.Point(279, 128)
        Me.btnRemoveNetShare.Name = "btnRemoveNetShare"
        Me.btnRemoveNetShare.Size = New System.Drawing.Size(75, 23)
        Me.btnRemoveNetShare.TabIndex = 3
        Me.btnRemoveNetShare.Text = "Remove"
        Me.btnRemoveNetShare.UseVisualStyleBackColor = True
        '
        'txtServer
        '
        Me.txtServer.Location = New System.Drawing.Point(116, 17)
        Me.txtServer.Name = "txtServer"
        Me.txtServer.Size = New System.Drawing.Size(235, 20)
        Me.txtServer.TabIndex = 17
        Me.txtServer.Text = "resone55"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(102, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Web Server Name*:"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtStatusSettings)
        Me.GroupBox4.Controls.Add(Me.chkbypasscerts)
        Me.GroupBox4.Controls.Add(Me.txtdefaultshare)
        Me.GroupBox4.Controls.Add(Me.Label29)
        Me.GroupBox4.Controls.Add(Me.txtdefaultcomputer)
        Me.GroupBox4.Controls.Add(Me.Label28)
        Me.GroupBox4.Controls.Add(Me.btnSaveSettings)
        Me.GroupBox4.Controls.Add(Me.txtDefaultTemplateName)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.txtDefaultJobName)
        Me.GroupBox4.Controls.Add(Me.txtServer)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.txtDefaultProjectName)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.txtAPIPass)
        Me.GroupBox4.Controls.Add(Me.txtApiUser)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 7)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(616, 199)
        Me.GroupBox4.TabIndex = 19
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Settings"
        '
        'txtStatusSettings
        '
        Me.txtStatusSettings.BackColor = System.Drawing.SystemColors.Control
        Me.txtStatusSettings.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtStatusSettings.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStatusSettings.Location = New System.Drawing.Point(11, 165)
        Me.txtStatusSettings.Name = "txtStatusSettings"
        Me.txtStatusSettings.ReadOnly = True
        Me.txtStatusSettings.Size = New System.Drawing.Size(482, 16)
        Me.txtStatusSettings.TabIndex = 27
        Me.txtStatusSettings.Text = "Status"
        '
        'chkbypasscerts
        '
        Me.chkbypasscerts.AutoSize = True
        Me.chkbypasscerts.Location = New System.Drawing.Point(441, 97)
        Me.chkbypasscerts.Name = "chkbypasscerts"
        Me.chkbypasscerts.Size = New System.Drawing.Size(145, 17)
        Me.chkbypasscerts.TabIndex = 26
        Me.chkbypasscerts.Text = "ByPass Invalid Certificate"
        Me.chkbypasscerts.UseVisualStyleBackColor = True
        '
        'txtdefaultshare
        '
        Me.txtdefaultshare.Location = New System.Drawing.Point(116, 120)
        Me.txtdefaultshare.Name = "txtdefaultshare"
        Me.txtdefaultshare.Size = New System.Drawing.Size(235, 20)
        Me.txtdefaultshare.TabIndex = 24
        Me.txtdefaultshare.Text = "\\resone55\share"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(8, 123)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(69, 13)
        Me.Label29.TabIndex = 25
        Me.Label29.Text = "Share Name:"
        '
        'txtdefaultcomputer
        '
        Me.txtdefaultcomputer.Location = New System.Drawing.Point(116, 94)
        Me.txtdefaultcomputer.Name = "txtdefaultcomputer"
        Me.txtdefaultcomputer.Size = New System.Drawing.Size(235, 20)
        Me.txtdefaultcomputer.TabIndex = 22
        Me.txtdefaultcomputer.Text = "client-pc7"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(8, 97)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(86, 13)
        Me.Label28.TabIndex = 23
        Me.Label28.Text = "Computer Name:"
        '
        'btnSaveSettings
        '
        Me.btnSaveSettings.Location = New System.Drawing.Point(499, 165)
        Me.btnSaveSettings.Name = "btnSaveSettings"
        Me.btnSaveSettings.Size = New System.Drawing.Size(96, 23)
        Me.btnSaveSettings.TabIndex = 21
        Me.btnSaveSettings.Text = "Save Settings"
        Me.btnSaveSettings.UseVisualStyleBackColor = True
        '
        'txtDefaultTemplateName
        '
        Me.txtDefaultTemplateName.FormattingEnabled = True
        Me.txtDefaultTemplateName.Items.AddRange(New Object() {"coll-evtx", "Drop Process by PID", "ETM Relative Time Query", "EXE-Metadata-Cerb", "Lockdown NIC", "LockdownEnableNIC", "Memory Acquisition", "Memory Analysis", "Registry-Autostart", "Registry-Full", "Remediate-Name", "Remediate-PID", "Small-exes-Cerb", "Software Inventory", "Vol-Deep", "Vol-Deep-Cerb", "Vol-Hidden-Cerb", "Vol-Hidden-Injected", "Vol-Quick", "Vol-Quick-Cerb", "Vol-Quick-Sched"})
        Me.txtDefaultTemplateName.Location = New System.Drawing.Point(441, 68)
        Me.txtDefaultTemplateName.Name = "txtDefaultTemplateName"
        Me.txtDefaultTemplateName.Size = New System.Drawing.Size(154, 21)
        Me.txtDefaultTemplateName.TabIndex = 20
        Me.txtDefaultTemplateName.Text = "coll-evtx"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(353, 71)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(85, 13)
        Me.Label14.TabIndex = 19
        Me.Label14.Text = "Template Name:"
        '
        'tabSubMenu
        '
        Me.tabSubMenu.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.tabSubMenu.Controls.Add(Me.tabJobInfo)
        Me.tabSubMenu.Controls.Add(Me.tabTargets)
        Me.tabSubMenu.Controls.Add(Me.tabFilters)
        Me.tabSubMenu.Controls.Add(Me.tabAgentRemediation)
        Me.tabSubMenu.Location = New System.Drawing.Point(6, 6)
        Me.tabSubMenu.Name = "tabSubMenu"
        Me.tabSubMenu.SelectedIndex = 0
        Me.tabSubMenu.Size = New System.Drawing.Size(616, 388)
        Me.tabSubMenu.TabIndex = 19
        '
        'tabJobInfo
        '
        Me.tabJobInfo.Controls.Add(Me.txtTemplateName)
        Me.tabJobInfo.Controls.Add(Me.Label25)
        Me.tabJobInfo.Controls.Add(Me.txtJobName)
        Me.tabJobInfo.Controls.Add(Me.Label26)
        Me.tabJobInfo.Controls.Add(Me.txtProjectName)
        Me.tabJobInfo.Controls.Add(Me.Label27)
        Me.tabJobInfo.Location = New System.Drawing.Point(4, 25)
        Me.tabJobInfo.Name = "tabJobInfo"
        Me.tabJobInfo.Size = New System.Drawing.Size(608, 359)
        Me.tabJobInfo.TabIndex = 3
        Me.tabJobInfo.Text = "Job Information"
        Me.tabJobInfo.UseVisualStyleBackColor = True
        '
        'txtTemplateName
        '
        Me.txtTemplateName.FormattingEnabled = True
        Me.txtTemplateName.Items.AddRange(New Object() {"coll-evtx", "Drop Process by PID", "ETM Relative Time Query", "EXE-Metadata-Cerb", "Lockdown NIC", "LockdownEnableNIC", "Memory Acquisition", "Memory Analysis", "Registry-Autostart", "Registry-Full", "Remediate-Name", "Remediate-PID", "Small-exes-Cerb", "Software Inventory", "Vol-Deep", "Vol-Deep-Cerb", "Vol-Hidden-Cerb", "Vol-Hidden-Injected", "Vol-Quick", "Vol-Quick-Cerb", "Vol-Quick-Sched"})
        Me.txtTemplateName.Location = New System.Drawing.Point(121, 62)
        Me.txtTemplateName.Name = "txtTemplateName"
        Me.txtTemplateName.Size = New System.Drawing.Size(235, 21)
        Me.txtTemplateName.TabIndex = 26
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(13, 65)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(85, 13)
        Me.Label25.TabIndex = 25
        Me.Label25.Text = "Template Name:"
        '
        'txtJobName
        '
        Me.txtJobName.Location = New System.Drawing.Point(121, 9)
        Me.txtJobName.Name = "txtJobName"
        Me.txtJobName.Size = New System.Drawing.Size(235, 20)
        Me.txtJobName.TabIndex = 22
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(13, 12)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(62, 13)
        Me.Label26.TabIndex = 21
        Me.Label26.Text = "Job Name*:"
        '
        'txtProjectName
        '
        Me.txtProjectName.Location = New System.Drawing.Point(121, 35)
        Me.txtProjectName.Name = "txtProjectName"
        Me.txtProjectName.Size = New System.Drawing.Size(235, 20)
        Me.txtProjectName.TabIndex = 23
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(13, 38)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(74, 13)
        Me.Label27.TabIndex = 24
        Me.Label27.Text = "Project Name:"
        '
        'tabTargets
        '
        Me.tabTargets.Controls.Add(Me.rdoagent)
        Me.tabTargets.Controls.Add(Me.rdoshare)
        Me.tabTargets.Controls.Add(Me.grpshare)
        Me.tabTargets.Controls.Add(Me.grpagent)
        Me.tabTargets.Location = New System.Drawing.Point(4, 25)
        Me.tabTargets.Name = "tabTargets"
        Me.tabTargets.Padding = New System.Windows.Forms.Padding(3)
        Me.tabTargets.Size = New System.Drawing.Size(608, 359)
        Me.tabTargets.TabIndex = 0
        Me.tabTargets.Text = "Targets"
        Me.tabTargets.UseVisualStyleBackColor = True
        '
        'rdoshare
        '
        Me.rdoshare.AutoSize = True
        Me.rdoshare.Location = New System.Drawing.Point(242, 6)
        Me.rdoshare.Name = "rdoshare"
        Me.rdoshare.Size = New System.Drawing.Size(96, 17)
        Me.rdoshare.TabIndex = 9
        Me.rdoshare.Text = "Network Share"
        Me.rdoshare.UseVisualStyleBackColor = True
        '
        'tabFilters
        '
        Me.tabFilters.Controls.Add(Me.tabFiltersSubMenu)
        Me.tabFilters.Location = New System.Drawing.Point(4, 25)
        Me.tabFilters.Name = "tabFilters"
        Me.tabFilters.Padding = New System.Windows.Forms.Padding(3)
        Me.tabFilters.Size = New System.Drawing.Size(608, 359)
        Me.tabFilters.TabIndex = 1
        Me.tabFilters.Text = "Filters"
        Me.tabFilters.UseVisualStyleBackColor = True
        '
        'tabFiltersSubMenu
        '
        Me.tabFiltersSubMenu.Controls.Add(Me.tabInclusionFilter)
        Me.tabFiltersSubMenu.Controls.Add(Me.tabExclusionFilter)
        Me.tabFiltersSubMenu.Location = New System.Drawing.Point(3, 3)
        Me.tabFiltersSubMenu.Name = "tabFiltersSubMenu"
        Me.tabFiltersSubMenu.SelectedIndex = 0
        Me.tabFiltersSubMenu.Size = New System.Drawing.Size(602, 323)
        Me.tabFiltersSubMenu.TabIndex = 0
        '
        'tabInclusionFilter
        '
        Me.tabInclusionFilter.Controls.Add(Me.rdoinclregexsearch)
        Me.tabInclusionFilter.Controls.Add(Me.rdoinclsimplesearch)
        Me.tabInclusionFilter.Controls.Add(Me.chkinclsearchfilename)
        Me.tabInclusionFilter.Controls.Add(Me.Label23)
        Me.tabInclusionFilter.Controls.Add(Me.txtinclmd5hash)
        Me.tabInclusionFilter.Controls.Add(Me.txtinclextensions)
        Me.tabInclusionFilter.Controls.Add(Me.Label11)
        Me.tabInclusionFilter.Controls.Add(Me.Label10)
        Me.tabInclusionFilter.Controls.Add(Me.txtinclpathcontains)
        Me.tabInclusionFilter.Controls.Add(Me.Label9)
        Me.tabInclusionFilter.Controls.Add(Me.txtinclkeywords)
        Me.tabInclusionFilter.Controls.Add(Me.txtinclfiltername)
        Me.tabInclusionFilter.Controls.Add(Me.Label8)
        Me.tabInclusionFilter.Location = New System.Drawing.Point(4, 22)
        Me.tabInclusionFilter.Name = "tabInclusionFilter"
        Me.tabInclusionFilter.Padding = New System.Windows.Forms.Padding(3)
        Me.tabInclusionFilter.Size = New System.Drawing.Size(594, 297)
        Me.tabInclusionFilter.TabIndex = 0
        Me.tabInclusionFilter.Text = "Inclusion"
        Me.tabInclusionFilter.UseVisualStyleBackColor = True
        '
        'rdoinclregexsearch
        '
        Me.rdoinclregexsearch.AutoSize = True
        Me.rdoinclregexsearch.Location = New System.Drawing.Point(348, 64)
        Me.rdoinclregexsearch.Name = "rdoinclregexsearch"
        Me.rdoinclregexsearch.Size = New System.Drawing.Size(94, 17)
        Me.rdoinclregexsearch.TabIndex = 13
        Me.rdoinclregexsearch.Text = "RegEx Search"
        Me.rdoinclregexsearch.UseVisualStyleBackColor = True
        '
        'rdoinclsimplesearch
        '
        Me.rdoinclsimplesearch.AutoSize = True
        Me.rdoinclsimplesearch.Checked = True
        Me.rdoinclsimplesearch.Location = New System.Drawing.Point(238, 64)
        Me.rdoinclsimplesearch.Name = "rdoinclsimplesearch"
        Me.rdoinclsimplesearch.Size = New System.Drawing.Size(93, 17)
        Me.rdoinclsimplesearch.TabIndex = 12
        Me.rdoinclsimplesearch.TabStop = True
        Me.rdoinclsimplesearch.Text = "Simple Search"
        Me.rdoinclsimplesearch.UseVisualStyleBackColor = True
        '
        'chkinclsearchfilename
        '
        Me.chkinclsearchfilename.AutoSize = True
        Me.chkinclsearchfilename.Location = New System.Drawing.Point(453, 65)
        Me.chkinclsearchfilename.Name = "chkinclsearchfilename"
        Me.chkinclsearchfilename.Size = New System.Drawing.Size(131, 17)
        Me.chkinclsearchfilename.TabIndex = 10
        Me.chkinclsearchfilename.Text = "Search FileName Only"
        Me.chkinclsearchfilename.UseVisualStyleBackColor = True
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(6, 84)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(61, 13)
        Me.Label23.TabIndex = 9
        Me.Label23.Text = "MD5 Hash:"
        '
        'txtinclmd5hash
        '
        Me.txtinclmd5hash.Location = New System.Drawing.Point(4, 100)
        Me.txtinclmd5hash.Multiline = True
        Me.txtinclmd5hash.Name = "txtinclmd5hash"
        Me.txtinclmd5hash.Size = New System.Drawing.Size(227, 105)
        Me.txtinclmd5hash.TabIndex = 8
        '
        'txtinclextensions
        '
        Me.txtinclextensions.Location = New System.Drawing.Point(346, 9)
        Me.txtinclextensions.Name = "txtinclextensions"
        Me.txtinclextensions.Size = New System.Drawing.Size(224, 20)
        Me.txtinclextensions.TabIndex = 7
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(279, 12)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(61, 13)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "Extensions:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 42)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(76, 13)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Path Contains:"
        '
        'txtinclpathcontains
        '
        Me.txtinclpathcontains.Location = New System.Drawing.Point(88, 39)
        Me.txtinclpathcontains.Multiline = True
        Me.txtinclpathcontains.Name = "txtinclpathcontains"
        Me.txtinclpathcontains.Size = New System.Drawing.Size(482, 20)
        Me.txtinclpathcontains.TabIndex = 4
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(235, 84)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 13)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Keywords:"
        '
        'txtinclkeywords
        '
        Me.txtinclkeywords.Location = New System.Drawing.Point(237, 100)
        Me.txtinclkeywords.Multiline = True
        Me.txtinclkeywords.Name = "txtinclkeywords"
        Me.txtinclkeywords.Size = New System.Drawing.Size(333, 105)
        Me.txtinclkeywords.TabIndex = 2
        '
        'txtinclfiltername
        '
        Me.txtinclfiltername.Location = New System.Drawing.Point(88, 9)
        Me.txtinclfiltername.Name = "txtinclfiltername"
        Me.txtinclfiltername.Size = New System.Drawing.Size(185, 20)
        Me.txtinclfiltername.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 12)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Filter Name:"
        '
        'tabExclusionFilter
        '
        Me.tabExclusionFilter.Controls.Add(Me.Label24)
        Me.tabExclusionFilter.Controls.Add(Me.txtexclmd5hash)
        Me.tabExclusionFilter.Controls.Add(Me.txtexclextensions)
        Me.tabExclusionFilter.Controls.Add(Me.Label12)
        Me.tabExclusionFilter.Controls.Add(Me.Label13)
        Me.tabExclusionFilter.Controls.Add(Me.txtexclpathcontains)
        Me.tabExclusionFilter.Controls.Add(Me.txtexclfiltername)
        Me.tabExclusionFilter.Controls.Add(Me.Label15)
        Me.tabExclusionFilter.Location = New System.Drawing.Point(4, 22)
        Me.tabExclusionFilter.Name = "tabExclusionFilter"
        Me.tabExclusionFilter.Padding = New System.Windows.Forms.Padding(3)
        Me.tabExclusionFilter.Size = New System.Drawing.Size(594, 297)
        Me.tabExclusionFilter.TabIndex = 1
        Me.tabExclusionFilter.Text = "Exclusion"
        Me.tabExclusionFilter.UseVisualStyleBackColor = True
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(6, 84)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(61, 13)
        Me.Label24.TabIndex = 17
        Me.Label24.Text = "MD5 Hash:"
        '
        'txtexclmd5hash
        '
        Me.txtexclmd5hash.Location = New System.Drawing.Point(4, 100)
        Me.txtexclmd5hash.Multiline = True
        Me.txtexclmd5hash.Name = "txtexclmd5hash"
        Me.txtexclmd5hash.Size = New System.Drawing.Size(227, 105)
        Me.txtexclmd5hash.TabIndex = 16
        '
        'txtexclextensions
        '
        Me.txtexclextensions.Location = New System.Drawing.Point(346, 9)
        Me.txtexclextensions.Name = "txtexclextensions"
        Me.txtexclextensions.Size = New System.Drawing.Size(224, 20)
        Me.txtexclextensions.TabIndex = 15
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(279, 12)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(61, 13)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "Extensions:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 42)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(76, 13)
        Me.Label13.TabIndex = 13
        Me.Label13.Text = "Path Contains:"
        '
        'txtexclpathcontains
        '
        Me.txtexclpathcontains.Location = New System.Drawing.Point(88, 39)
        Me.txtexclpathcontains.Multiline = True
        Me.txtexclpathcontains.Name = "txtexclpathcontains"
        Me.txtexclpathcontains.Size = New System.Drawing.Size(482, 20)
        Me.txtexclpathcontains.TabIndex = 12
        '
        'txtexclfiltername
        '
        Me.txtexclfiltername.Location = New System.Drawing.Point(88, 9)
        Me.txtexclfiltername.Name = "txtexclfiltername"
        Me.txtexclfiltername.Size = New System.Drawing.Size(185, 20)
        Me.txtexclfiltername.TabIndex = 9
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(6, 12)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(63, 13)
        Me.Label15.TabIndex = 8
        Me.Label15.Text = "Filter Name:"
        '
        'tabAgentRemediation
        '
        Me.tabAgentRemediation.Controls.Add(Me.tabAgentRemediationSubMenu)
        Me.tabAgentRemediation.Location = New System.Drawing.Point(4, 25)
        Me.tabAgentRemediation.Name = "tabAgentRemediation"
        Me.tabAgentRemediation.Size = New System.Drawing.Size(608, 359)
        Me.tabAgentRemediation.TabIndex = 2
        Me.tabAgentRemediation.Text = "Agent Remediation"
        Me.tabAgentRemediation.UseVisualStyleBackColor = True
        '
        'tabAgentRemediationSubMenu
        '
        Me.tabAgentRemediationSubMenu.Controls.Add(Me.tabAgentSendFile)
        Me.tabAgentRemediationSubMenu.Controls.Add(Me.tabAgentExecute)
        Me.tabAgentRemediationSubMenu.Controls.Add(Me.tabAgentDelete)
        Me.tabAgentRemediationSubMenu.Controls.Add(Me.TabAgentKill)
        Me.tabAgentRemediationSubMenu.Location = New System.Drawing.Point(0, 0)
        Me.tabAgentRemediationSubMenu.Name = "tabAgentRemediationSubMenu"
        Me.tabAgentRemediationSubMenu.SelectedIndex = 0
        Me.tabAgentRemediationSubMenu.Size = New System.Drawing.Size(608, 329)
        Me.tabAgentRemediationSubMenu.TabIndex = 0
        '
        'tabAgentSendFile
        '
        Me.tabAgentSendFile.Controls.Add(Me.chkremsendexecute)
        Me.tabAgentSendFile.Controls.Add(Me.chkremsenddelete)
        Me.tabAgentSendFile.Controls.Add(Me.txtremsenddest)
        Me.tabAgentSendFile.Controls.Add(Me.Label17)
        Me.tabAgentSendFile.Controls.Add(Me.txtremsendsource)
        Me.tabAgentSendFile.Controls.Add(Me.Label16)
        Me.tabAgentSendFile.Location = New System.Drawing.Point(4, 22)
        Me.tabAgentSendFile.Name = "tabAgentSendFile"
        Me.tabAgentSendFile.Padding = New System.Windows.Forms.Padding(3)
        Me.tabAgentSendFile.Size = New System.Drawing.Size(600, 303)
        Me.tabAgentSendFile.TabIndex = 0
        Me.tabAgentSendFile.Text = "Send File"
        Me.tabAgentSendFile.UseVisualStyleBackColor = True
        '
        'chkremsendexecute
        '
        Me.chkremsendexecute.AutoSize = True
        Me.chkremsendexecute.Location = New System.Drawing.Point(115, 68)
        Me.chkremsendexecute.Name = "chkremsendexecute"
        Me.chkremsendexecute.Size = New System.Drawing.Size(65, 17)
        Me.chkremsendexecute.TabIndex = 25
        Me.chkremsendexecute.Text = "Execute"
        Me.chkremsendexecute.UseVisualStyleBackColor = True
        Me.chkremsendexecute.Visible = False
        '
        'chkremsenddelete
        '
        Me.chkremsenddelete.AutoSize = True
        Me.chkremsenddelete.Location = New System.Drawing.Point(9, 68)
        Me.chkremsenddelete.Name = "chkremsenddelete"
        Me.chkremsenddelete.Size = New System.Drawing.Size(76, 17)
        Me.chkremsenddelete.TabIndex = 24
        Me.chkremsenddelete.Text = "Delete File"
        Me.chkremsenddelete.UseVisualStyleBackColor = True
        '
        'txtremsenddest
        '
        Me.txtremsenddest.Location = New System.Drawing.Point(115, 35)
        Me.txtremsenddest.Name = "txtremsenddest"
        Me.txtremsenddest.Size = New System.Drawing.Size(235, 20)
        Me.txtremsenddest.TabIndex = 22
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(6, 38)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(107, 13)
        Me.Label17.TabIndex = 23
        Me.Label17.Text = "Destination File Path:"
        '
        'txtremsendsource
        '
        Me.txtremsendsource.Location = New System.Drawing.Point(115, 9)
        Me.txtremsendsource.Name = "txtremsendsource"
        Me.txtremsendsource.Size = New System.Drawing.Size(235, 20)
        Me.txtremsendsource.TabIndex = 20
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(6, 12)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(91, 13)
        Me.Label16.TabIndex = 21
        Me.Label16.Text = "Source File Path: "
        '
        'tabAgentExecute
        '
        Me.tabAgentExecute.Controls.Add(Me.txtremexecargs)
        Me.tabAgentExecute.Controls.Add(Me.Label19)
        Me.tabAgentExecute.Controls.Add(Me.txtremexecpath)
        Me.tabAgentExecute.Controls.Add(Me.Label18)
        Me.tabAgentExecute.Location = New System.Drawing.Point(4, 22)
        Me.tabAgentExecute.Name = "tabAgentExecute"
        Me.tabAgentExecute.Padding = New System.Windows.Forms.Padding(3)
        Me.tabAgentExecute.Size = New System.Drawing.Size(600, 303)
        Me.tabAgentExecute.TabIndex = 1
        Me.tabAgentExecute.Text = "Execute"
        Me.tabAgentExecute.UseVisualStyleBackColor = True
        '
        'txtremexecargs
        '
        Me.txtremexecargs.Location = New System.Drawing.Point(118, 43)
        Me.txtremexecargs.Name = "txtremexecargs"
        Me.txtremexecargs.Size = New System.Drawing.Size(235, 20)
        Me.txtremexecargs.TabIndex = 24
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(9, 46)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(60, 13)
        Me.Label19.TabIndex = 25
        Me.Label19.Text = "Arguments:"
        '
        'txtremexecpath
        '
        Me.txtremexecpath.Location = New System.Drawing.Point(118, 13)
        Me.txtremexecpath.Name = "txtremexecpath"
        Me.txtremexecpath.Size = New System.Drawing.Size(235, 20)
        Me.txtremexecpath.TabIndex = 22
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(9, 16)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(85, 13)
        Me.Label18.TabIndex = 23
        Me.Label18.Text = "Target File Path:"
        '
        'tabAgentDelete
        '
        Me.tabAgentDelete.Controls.Add(Me.txtremdelfilepath)
        Me.tabAgentDelete.Controls.Add(Me.Label20)
        Me.tabAgentDelete.Location = New System.Drawing.Point(4, 22)
        Me.tabAgentDelete.Name = "tabAgentDelete"
        Me.tabAgentDelete.Size = New System.Drawing.Size(600, 303)
        Me.tabAgentDelete.TabIndex = 2
        Me.tabAgentDelete.Text = "Delete File"
        Me.tabAgentDelete.UseVisualStyleBackColor = True
        '
        'txtremdelfilepath
        '
        Me.txtremdelfilepath.Location = New System.Drawing.Point(118, 14)
        Me.txtremdelfilepath.Name = "txtremdelfilepath"
        Me.txtremdelfilepath.Size = New System.Drawing.Size(235, 20)
        Me.txtremdelfilepath.TabIndex = 24
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(9, 17)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(85, 13)
        Me.Label20.TabIndex = 25
        Me.Label20.Text = "Target File Path:"
        '
        'TabAgentKill
        '
        Me.TabAgentKill.Controls.Add(Me.txtremkillprocname)
        Me.TabAgentKill.Controls.Add(Me.Label22)
        Me.TabAgentKill.Controls.Add(Me.nmbremkillprocid)
        Me.TabAgentKill.Controls.Add(Me.Label21)
        Me.TabAgentKill.Location = New System.Drawing.Point(4, 22)
        Me.TabAgentKill.Name = "TabAgentKill"
        Me.TabAgentKill.Size = New System.Drawing.Size(600, 303)
        Me.TabAgentKill.TabIndex = 3
        Me.TabAgentKill.Text = "Kill Process"
        Me.TabAgentKill.UseVisualStyleBackColor = True
        '
        'txtremkillprocname
        '
        Me.txtremkillprocname.Location = New System.Drawing.Point(93, 39)
        Me.txtremkillprocname.Name = "txtremkillprocname"
        Me.txtremkillprocname.Size = New System.Drawing.Size(235, 20)
        Me.txtremkillprocname.TabIndex = 14
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(10, 42)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(79, 13)
        Me.Label22.TabIndex = 15
        Me.Label22.Text = "Process Name:"
        '
        'nmbremkillprocid
        '
        Me.nmbremkillprocid.Location = New System.Drawing.Point(93, 13)
        Me.nmbremkillprocid.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.nmbremkillprocid.Name = "nmbremkillprocid"
        Me.nmbremkillprocid.Size = New System.Drawing.Size(76, 20)
        Me.nmbremkillprocid.TabIndex = 13
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(10, 15)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(77, 13)
        Me.Label21.TabIndex = 12
        Me.Label21.Text = "By Process ID:"
        '
        'txtStatusBox
        '
        Me.txtStatusBox.BackColor = System.Drawing.SystemColors.Control
        Me.txtStatusBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtStatusBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStatusBox.Location = New System.Drawing.Point(10, 400)
        Me.txtStatusBox.Name = "txtStatusBox"
        Me.txtStatusBox.ReadOnly = True
        Me.txtStatusBox.Size = New System.Drawing.Size(531, 16)
        Me.txtStatusBox.TabIndex = 20
        Me.txtStatusBox.Text = "Status"
        '
        'tabMenu
        '
        Me.tabMenu.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.tabMenu.Controls.Add(Me.tabSettings)
        Me.tabMenu.Controls.Add(Me.tabJobExecution)
        Me.tabMenu.Controls.Add(Me.tabBoxedJobs)
        Me.tabMenu.Controls.Add(Me.tabAbout)
        Me.tabMenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabMenu.Location = New System.Drawing.Point(0, 0)
        Me.tabMenu.Name = "tabMenu"
        Me.tabMenu.SelectedIndex = 0
        Me.tabMenu.Size = New System.Drawing.Size(638, 463)
        Me.tabMenu.TabIndex = 21
        '
        'tabSettings
        '
        Me.tabSettings.Controls.Add(Me.GroupBox4)
        Me.tabSettings.Location = New System.Drawing.Point(4, 25)
        Me.tabSettings.Name = "tabSettings"
        Me.tabSettings.Padding = New System.Windows.Forms.Padding(3)
        Me.tabSettings.Size = New System.Drawing.Size(630, 434)
        Me.tabSettings.TabIndex = 1
        Me.tabSettings.Text = "Settings"
        Me.tabSettings.UseVisualStyleBackColor = True
        '
        'tabJobExecution
        '
        Me.tabJobExecution.Controls.Add(Me.btnLoadFromBox)
        Me.tabJobExecution.Controls.Add(Me.btnSaveAsBox)
        Me.tabJobExecution.Controls.Add(Me.btnExecute)
        Me.tabJobExecution.Controls.Add(Me.txtStatusBox)
        Me.tabJobExecution.Controls.Add(Me.tabSubMenu)
        Me.tabJobExecution.Location = New System.Drawing.Point(4, 25)
        Me.tabJobExecution.Name = "tabJobExecution"
        Me.tabJobExecution.Padding = New System.Windows.Forms.Padding(3)
        Me.tabJobExecution.Size = New System.Drawing.Size(630, 434)
        Me.tabJobExecution.TabIndex = 0
        Me.tabJobExecution.Text = "Job Execution"
        Me.tabJobExecution.UseVisualStyleBackColor = True
        '
        'btnLoadFromBox
        '
        Me.btnLoadFromBox.Location = New System.Drawing.Point(319, 400)
        Me.btnLoadFromBox.Name = "btnLoadFromBox"
        Me.btnLoadFromBox.Size = New System.Drawing.Size(90, 23)
        Me.btnLoadFromBox.TabIndex = 22
        Me.btnLoadFromBox.Text = "Load From Box"
        Me.btnLoadFromBox.UseVisualStyleBackColor = True
        '
        'btnSaveAsBox
        '
        Me.btnSaveAsBox.Location = New System.Drawing.Point(436, 400)
        Me.btnSaveAsBox.Name = "btnSaveAsBox"
        Me.btnSaveAsBox.Size = New System.Drawing.Size(75, 23)
        Me.btnSaveAsBox.TabIndex = 21
        Me.btnSaveAsBox.Text = "Save as Box"
        Me.btnSaveAsBox.UseVisualStyleBackColor = True
        '
        'tabBoxedJobs
        '
        Me.tabBoxedJobs.Controls.Add(Me.lstBoxedJobs)
        Me.tabBoxedJobs.Controls.Add(Me.txtStatusBoxJob)
        Me.tabBoxedJobs.Controls.Add(Me.btnBoxJobCollection1)
        Me.tabBoxedJobs.Controls.Add(Me.Label30)
        Me.tabBoxedJobs.Controls.Add(Me.txtboxtargetcomputer)
        Me.tabBoxedJobs.Location = New System.Drawing.Point(4, 25)
        Me.tabBoxedJobs.Name = "tabBoxedJobs"
        Me.tabBoxedJobs.Padding = New System.Windows.Forms.Padding(3)
        Me.tabBoxedJobs.Size = New System.Drawing.Size(630, 434)
        Me.tabBoxedJobs.TabIndex = 2
        Me.tabBoxedJobs.Text = "Boxed Jobs"
        Me.tabBoxedJobs.UseVisualStyleBackColor = True
        '
        'lstBoxedJobs
        '
        Me.lstBoxedJobs.FormattingEnabled = True
        Me.lstBoxedJobs.Location = New System.Drawing.Point(22, 98)
        Me.lstBoxedJobs.Name = "lstBoxedJobs"
        Me.lstBoxedJobs.Size = New System.Drawing.Size(311, 214)
        Me.lstBoxedJobs.TabIndex = 22
        '
        'txtStatusBoxJob
        '
        Me.txtStatusBoxJob.BackColor = System.Drawing.SystemColors.Control
        Me.txtStatusBoxJob.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtStatusBoxJob.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStatusBoxJob.Location = New System.Drawing.Point(11, 410)
        Me.txtStatusBoxJob.Name = "txtStatusBoxJob"
        Me.txtStatusBoxJob.ReadOnly = True
        Me.txtStatusBoxJob.Size = New System.Drawing.Size(531, 16)
        Me.txtStatusBoxJob.TabIndex = 21
        Me.txtStatusBoxJob.Text = "Status"
        Me.txtStatusBoxJob.Visible = False
        '
        'btnBoxJobCollection1
        '
        Me.btnBoxJobCollection1.Location = New System.Drawing.Point(11, 42)
        Me.btnBoxJobCollection1.Name = "btnBoxJobCollection1"
        Me.btnBoxJobCollection1.Size = New System.Drawing.Size(75, 23)
        Me.btnBoxJobCollection1.TabIndex = 2
        Me.btnBoxJobCollection1.Text = "Collection1"
        Me.btnBoxJobCollection1.UseVisualStyleBackColor = True
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(8, 9)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(89, 13)
        Me.Label30.TabIndex = 1
        Me.Label30.Text = "Target Computer:"
        '
        'txtboxtargetcomputer
        '
        Me.txtboxtargetcomputer.Location = New System.Drawing.Point(100, 6)
        Me.txtboxtargetcomputer.Name = "txtboxtargetcomputer"
        Me.txtboxtargetcomputer.Size = New System.Drawing.Size(199, 20)
        Me.txtboxtargetcomputer.TabIndex = 0
        '
        'tabAbout
        '
        Me.tabAbout.Controls.Add(Me.TextBox1)
        Me.tabAbout.Location = New System.Drawing.Point(4, 25)
        Me.tabAbout.Name = "tabAbout"
        Me.tabAbout.Size = New System.Drawing.Size(630, 434)
        Me.tabAbout.TabIndex = 3
        Me.tabAbout.Text = "About"
        Me.tabAbout.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(0, 0)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(630, 434)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = resources.GetString("TextBox1.Text")
        '
        'ofdBox
        '
        Me.ofdBox.FileName = "*.json"
        Me.ofdBox.Filter = "Box Files|*.json"
        Me.ofdBox.InitialDirectory = "My.Application.Info.DirectoryPath & ""\BoxedJobs"""
        '
        'sfdBox
        '
        Me.sfdBox.DefaultExt = "json"
        Me.sfdBox.Filter = "Box Files|*.json"
        Me.sfdBox.InitialDirectory = "My.Application.Info.DirectoryPath & ""\BoxedJobs"""
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(638, 463)
        Me.Controls.Add(Me.tabMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Main"
        Me.Text = "R1 Job Runner"
        Me.grpagent.ResumeLayout(False)
        Me.grpagent.PerformLayout()
        Me.grpshare.ResumeLayout(False)
        Me.grpshare.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.tabSubMenu.ResumeLayout(False)
        Me.tabJobInfo.ResumeLayout(False)
        Me.tabJobInfo.PerformLayout()
        Me.tabTargets.ResumeLayout(False)
        Me.tabTargets.PerformLayout()
        Me.tabFilters.ResumeLayout(False)
        Me.tabFiltersSubMenu.ResumeLayout(False)
        Me.tabInclusionFilter.ResumeLayout(False)
        Me.tabInclusionFilter.PerformLayout()
        Me.tabExclusionFilter.ResumeLayout(False)
        Me.tabExclusionFilter.PerformLayout()
        Me.tabAgentRemediation.ResumeLayout(False)
        Me.tabAgentRemediationSubMenu.ResumeLayout(False)
        Me.tabAgentSendFile.ResumeLayout(False)
        Me.tabAgentSendFile.PerformLayout()
        Me.tabAgentExecute.ResumeLayout(False)
        Me.tabAgentExecute.PerformLayout()
        Me.tabAgentDelete.ResumeLayout(False)
        Me.tabAgentDelete.PerformLayout()
        Me.TabAgentKill.ResumeLayout(False)
        Me.TabAgentKill.PerformLayout()
        CType(Me.nmbremkillprocid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMenu.ResumeLayout(False)
        Me.tabSettings.ResumeLayout(False)
        Me.tabJobExecution.ResumeLayout(False)
        Me.tabJobExecution.PerformLayout()
        Me.tabBoxedJobs.ResumeLayout(False)
        Me.tabBoxedJobs.PerformLayout()
        Me.tabAbout.ResumeLayout(False)
        Me.tabAbout.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnExecute As System.Windows.Forms.Button
    Friend WithEvents btnRemoveComputer As System.Windows.Forms.Button
    Friend WithEvents lstComputerTargets As System.Windows.Forms.CheckedListBox
    Friend WithEvents txtComputerTarget As System.Windows.Forms.TextBox
    Friend WithEvents btnAddComputer As System.Windows.Forms.Button
    Friend WithEvents grpagent As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDefaultJobName As System.Windows.Forms.TextBox
    Friend WithEvents txtDefaultProjectName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtApiUser As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtAPIPass As System.Windows.Forms.TextBox
    Friend WithEvents grpshare As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lstNetShare As System.Windows.Forms.CheckedListBox
    Friend WithEvents txtNetSharePath As System.Windows.Forms.TextBox
    Friend WithEvents btnAddNetShare As System.Windows.Forms.Button
    Friend WithEvents btnRemoveNetShare As System.Windows.Forms.Button
    Friend WithEvents txtServer As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents tabSubMenu As System.Windows.Forms.TabControl
    Friend WithEvents tabTargets As System.Windows.Forms.TabPage
    Friend WithEvents tabFilters As System.Windows.Forms.TabPage
    Friend WithEvents tabFiltersSubMenu As System.Windows.Forms.TabControl
    Friend WithEvents tabInclusionFilter As System.Windows.Forms.TabPage
    Friend WithEvents tabExclusionFilter As System.Windows.Forms.TabPage
    Friend WithEvents txtinclfiltername As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtinclextensions As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtinclpathcontains As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtinclkeywords As System.Windows.Forms.TextBox
    Friend WithEvents txtexclextensions As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtexclpathcontains As System.Windows.Forms.TextBox
    Friend WithEvents txtexclfiltername As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents tabAgentRemediation As System.Windows.Forms.TabPage
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents tabAgentRemediationSubMenu As System.Windows.Forms.TabControl
    Friend WithEvents tabAgentSendFile As System.Windows.Forms.TabPage
    Friend WithEvents tabAgentExecute As System.Windows.Forms.TabPage
    Friend WithEvents tabAgentDelete As System.Windows.Forms.TabPage
    Friend WithEvents TabAgentKill As System.Windows.Forms.TabPage
    Friend WithEvents chkremsendexecute As System.Windows.Forms.CheckBox
    Friend WithEvents chkremsenddelete As System.Windows.Forms.CheckBox
    Friend WithEvents txtremsenddest As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtremsendsource As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtremexecargs As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtremexecpath As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtremdelfilepath As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtremkillprocname As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Public WithEvents nmbremkillprocid As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtDefaultTemplateName As System.Windows.Forms.ComboBox
    Friend WithEvents rdoagent As System.Windows.Forms.RadioButton
    Friend WithEvents rdoshare As System.Windows.Forms.RadioButton
    Friend WithEvents chkinclsearchfilename As System.Windows.Forms.CheckBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtinclmd5hash As System.Windows.Forms.TextBox
    Friend WithEvents rdoinclregexsearch As System.Windows.Forms.RadioButton
    Friend WithEvents rdoinclsimplesearch As System.Windows.Forms.RadioButton
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtexclmd5hash As System.Windows.Forms.TextBox
    Friend WithEvents txtStatusBox As System.Windows.Forms.TextBox
    Friend WithEvents tabMenu As System.Windows.Forms.TabControl
    Friend WithEvents tabSettings As System.Windows.Forms.TabPage
    Friend WithEvents tabJobExecution As System.Windows.Forms.TabPage
    Friend WithEvents btnSaveSettings As System.Windows.Forms.Button
    Friend WithEvents tabBoxedJobs As System.Windows.Forms.TabPage
    Friend WithEvents tabAbout As System.Windows.Forms.TabPage
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents tabJobInfo As System.Windows.Forms.TabPage
    Friend WithEvents txtTemplateName As System.Windows.Forms.ComboBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents txtJobName As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents txtProjectName As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents txtdefaultshare As System.Windows.Forms.TextBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents txtdefaultcomputer As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents chkbypasscerts As System.Windows.Forms.CheckBox
    Friend WithEvents txtStatusSettings As System.Windows.Forms.TextBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents txtboxtargetcomputer As System.Windows.Forms.TextBox
    Friend WithEvents btnBoxJobCollection1 As System.Windows.Forms.Button
    Friend WithEvents txtStatusBoxJob As System.Windows.Forms.TextBox
    Friend WithEvents lstBoxedJobs As System.Windows.Forms.CheckedListBox
    Friend WithEvents btnSaveAsBox As System.Windows.Forms.Button
    Friend WithEvents btnLoadFromBox As System.Windows.Forms.Button
    Friend WithEvents ofdBox As System.Windows.Forms.OpenFileDialog
    Friend WithEvents sfdBox As System.Windows.Forms.SaveFileDialog

End Class
