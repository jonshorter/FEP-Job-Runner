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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.btnExecute = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDefaultJobName = New System.Windows.Forms.TextBox()
        Me.txtDefaultProjectName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtApiUser = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtAPIPass = New System.Windows.Forms.TextBox()
        Me.txtServer = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.grpReqSet = New System.Windows.Forms.GroupBox()
        Me.chkRestAPI = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtcustomwebaddress = New System.Windows.Forms.TextBox()
        Me.rdocustom = New System.Windows.Forms.RadioButton()
        Me.rdor1 = New System.Windows.Forms.RadioButton()
        Me.rdoadgmap = New System.Windows.Forms.RadioButton()
        Me.grpOptDefSet = New System.Windows.Forms.GroupBox()
        Me.btnLoadDefaultTemplateName = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.chkUpdates = New System.Windows.Forms.CheckBox()
        Me.btn_CheckForUpdates = New System.Windows.Forms.Button()
        Me.chkbypasscerts = New System.Windows.Forms.CheckBox()
        Me.txtdefaultshare = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtdefaultcomputer = New System.Windows.Forms.TextBox()
        Me.txtDefaultTemplateName = New System.Windows.Forms.ComboBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.txtStatusSettings = New System.Windows.Forms.TextBox()
        Me.btnSaveSettings = New System.Windows.Forms.Button()
        Me.tabSubMenu = New System.Windows.Forms.TabControl()
        Me.tabJobInfo = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdoagent = New System.Windows.Forms.RadioButton()
        Me.rdoshare = New System.Windows.Forms.RadioButton()
        Me.grpshare = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lstNetShare = New System.Windows.Forms.CheckedListBox()
        Me.txtNetSharePath = New System.Windows.Forms.TextBox()
        Me.btnAddNetShare = New System.Windows.Forms.Button()
        Me.btnRemoveNetShare = New System.Windows.Forms.Button()
        Me.grpagent = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstComputerTargets = New System.Windows.Forms.CheckedListBox()
        Me.txtComputerTarget = New System.Windows.Forms.TextBox()
        Me.btnAddComputer = New System.Windows.Forms.Button()
        Me.btnRemoveComputer = New System.Windows.Forms.Button()
        Me.txtTemplateName = New System.Windows.Forms.ComboBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtJobName = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txtProjectName = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.tabFilters = New System.Windows.Forms.TabPage()
        Me.tabFiltersSubMenu = New System.Windows.Forms.TabControl()
        Me.tabInclusionFilter = New System.Windows.Forms.TabPage()
        Me.splitInclusion = New System.Windows.Forms.SplitContainer()
        Me.txtinclkeywords = New System.Windows.Forms.TextBox()
        Me.rdoinclregexsearch = New System.Windows.Forms.RadioButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.rdoinclsimplesearch = New System.Windows.Forms.RadioButton()
        Me.txtinclfiltername = New System.Windows.Forms.TextBox()
        Me.chkinclsearchfilename = New System.Windows.Forms.CheckBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtinclpathcontains = New System.Windows.Forms.TextBox()
        Me.txtinclmd5hash = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtinclextensions = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnSaveIncFilterChanges = New System.Windows.Forms.Button()
        Me.lstboxinclusionfilters = New System.Windows.Forms.CheckedListBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.btnRemoveInclFilterfromList = New System.Windows.Forms.Button()
        Me.btnAddInclFilterToList = New System.Windows.Forms.Button()
        Me.tabExclusionFilter = New System.Windows.Forms.TabPage()
        Me.SplitExclusion = New System.Windows.Forms.SplitContainer()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtexclfiltername = New System.Windows.Forms.TextBox()
        Me.txtexclmd5hash = New System.Windows.Forms.TextBox()
        Me.txtexclpathcontains = New System.Windows.Forms.TextBox()
        Me.txtexclextensions = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnsaveexclusionfilterchanges = New System.Windows.Forms.Button()
        Me.lstboxexclusionfilters = New System.Windows.Forms.CheckedListBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.btnremoveexclusionfilterfromlist = New System.Windows.Forms.Button()
        Me.btnaddexclusionfiltertolist = New System.Windows.Forms.Button()
        Me.tabAgentRemediation = New System.Windows.Forms.TabPage()
        Me.btnSaveRemOptionChange = New System.Windows.Forms.Button()
        Me.btnRemoveRemOption = New System.Windows.Forms.Button()
        Me.btnAddRemOption = New System.Windows.Forms.Button()
        Me.lvRemOptions = New System.Windows.Forms.ListView()
        Me.colRemType = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colitem = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
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
        Me.rdoPName = New System.Windows.Forms.RadioButton()
        Me.rdoPID = New System.Windows.Forms.RadioButton()
        Me.txtremkillprocname = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.nmbremkillprocid = New System.Windows.Forms.NumericUpDown()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.tabMenu = New System.Windows.Forms.TabControl()
        Me.tabSettings = New System.Windows.Forms.TabPage()
        Me.tabRESTUI = New System.Windows.Forms.TabPage()
        Me.tabControlJobsRest = New System.Windows.Forms.TabControl()
        Me.tabTasks = New System.Windows.Forms.TabPage()
        Me.flowTasks = New System.Windows.Forms.FlowLayoutPanel()
        Me.tabProjects = New System.Windows.Forms.TabPage()
        Me.splitProjects = New System.Windows.Forms.SplitContainer()
        Me.btnViewProjectReview = New System.Windows.Forms.Button()
        Me.btnDeleteProject = New System.Windows.Forms.Button()
        Me.btnEditProject = New System.Windows.Forms.Button()
        Me.btnNewProject = New System.Windows.Forms.Button()
        Me.txtSearchProject = New System.Windows.Forms.TextBox()
        Me.dgvProjectList = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CreationDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CreatedBy = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastModDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProjectFolderPath = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProjectID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tabJobsList = New System.Windows.Forms.TabPage()
        Me.splitJobsRestJobs = New System.Windows.Forms.SplitContainer()
        Me.txtJobsSearch = New System.Windows.Forms.TextBox()
        Me.dgvJobsRestJobsList = New System.Windows.Forms.DataGridView()
        Me.jobName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jobStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jobRetry = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.jobCancel = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.jobType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jobStart = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jobEnd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jobID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jobResultID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jobEndpointStatus = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Result = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.splitEndpointStatus = New System.Windows.Forms.SplitContainer()
        Me.flowEndpointStatus = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnBackFromEndpointStatus = New System.Windows.Forms.Button()
        Me.lblJobName = New System.Windows.Forms.Label()
        Me.txtSearchEndpointStatus = New System.Windows.Forms.TextBox()
        Me.lblepStatusTotal = New System.Windows.Forms.Label()
        Me.lblepStatusInProgress = New System.Windows.Forms.Label()
        Me.lblepstatusFailed = New System.Windows.Forms.Label()
        Me.lblepstatusSuccessful = New System.Windows.Forms.Label()
        Me.dgvEndpointStatusJobTargets = New System.Windows.Forms.DataGridView()
        Me.endpoint = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Start = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Hits = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EndPointID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Action = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Review = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.tabAlerts = New System.Windows.Forms.TabPage()
        Me.splitAlerts = New System.Windows.Forms.SplitContainer()
        Me.dgvAlerts = New System.Windows.Forms.DataGridView()
        Me.artifactName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.createDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.severity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.target = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.source = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.project = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.confidence = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.threatScore = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tblAlertBreakdown = New System.Windows.Forms.TableLayoutPanel()
        Me.flowResponseTime = New System.Windows.Forms.FlowLayoutPanel()
        Me.lblResponseTime = New System.Windows.Forms.Label()
        Me.lblTotalNumberofResponses = New System.Windows.Forms.Label()
        Me.flowTotalResponses = New System.Windows.Forms.FlowLayoutPanel()
        Me.lblTotalNumberAlerts = New System.Windows.Forms.Label()
        Me.flowAlertBreakdown = New System.Windows.Forms.FlowLayoutPanel()
        Me.tabJobExecution = New System.Windows.Forms.TabPage()
        Me.lblJobStatus = New System.Windows.Forms.Label()
        Me.btnShowJSON = New System.Windows.Forms.Button()
        Me.btnLoadFromBox = New System.Windows.Forms.Button()
        Me.btnSaveAsBox = New System.Windows.Forms.Button()
        Me.tabFireEye = New System.Windows.Forms.TabPage()
        Me.txtFireEyeMalwareMD5 = New System.Windows.Forms.TextBox()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.lblFEStatus = New System.Windows.Forms.Label()
        Me.txtFELink = New System.Windows.Forms.TextBox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.cmbFEAlertType = New System.Windows.Forms.ComboBox()
        Me.txtFETarget = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.btn_FEEvent = New System.Windows.Forms.Button()
        Me.tabPANW = New System.Windows.Forms.TabPage()
        Me.txtPANWMalwareMD5 = New System.Windows.Forms.TextBox()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.txtPANWSim = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.lblPANWStatus = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.panw_sim_port = New System.Windows.Forms.NumericUpDown()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.lblwildfirestatus = New System.Windows.Forms.Label()
        Me.btn_WildfireStart = New System.Windows.Forms.Button()
        Me.panwPort = New System.Windows.Forms.NumericUpDown()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.cmbPANWAlert = New System.Windows.Forms.ComboBox()
        Me.txtPANWTarget = New System.Windows.Forms.TextBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.btnPANWSend = New System.Windows.Forms.Button()
        Me.tabXPS = New System.Windows.Forms.TabPage()
        Me.txtXPSMalwareMD5 = New System.Windows.Forms.TextBox()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.lblXPSStatus = New System.Windows.Forms.Label()
        Me.txtXPSMalware = New System.Windows.Forms.TextBox()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtXPSSIM = New System.Windows.Forms.TextBox()
        Me.txtFELink2 = New System.Windows.Forms.TextBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.xps_sim_Port = New System.Windows.Forms.NumericUpDown()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.lbldemoxpsstatus = New System.Windows.Forms.Label()
        Me.btnStartXPSListener = New System.Windows.Forms.Button()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.cmbXPSSeverity = New System.Windows.Forms.ComboBox()
        Me.xpsPort = New System.Windows.Forms.NumericUpDown()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.txtXPSTarget = New System.Windows.Forms.TextBox()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.btnXPSSend = New System.Windows.Forms.Button()
        Me.tabAbout = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ofdBox = New System.Windows.Forms.OpenFileDialog()
        Me.sfdBox = New System.Windows.Forms.SaveFileDialog()
        Me.tooltip = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox4.SuspendLayout()
        Me.grpReqSet.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.grpOptDefSet.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.tabSubMenu.SuspendLayout()
        Me.tabJobInfo.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.grpshare.SuspendLayout()
        Me.grpagent.SuspendLayout()
        Me.tabFilters.SuspendLayout()
        Me.tabFiltersSubMenu.SuspendLayout()
        Me.tabInclusionFilter.SuspendLayout()
        CType(Me.splitInclusion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitInclusion.Panel1.SuspendLayout()
        Me.splitInclusion.Panel2.SuspendLayout()
        Me.splitInclusion.SuspendLayout()
        Me.tabExclusionFilter.SuspendLayout()
        CType(Me.SplitExclusion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitExclusion.Panel1.SuspendLayout()
        Me.SplitExclusion.Panel2.SuspendLayout()
        Me.SplitExclusion.SuspendLayout()
        Me.tabAgentRemediation.SuspendLayout()
        Me.tabAgentRemediationSubMenu.SuspendLayout()
        Me.tabAgentSendFile.SuspendLayout()
        Me.tabAgentExecute.SuspendLayout()
        Me.tabAgentDelete.SuspendLayout()
        Me.TabAgentKill.SuspendLayout()
        CType(Me.nmbremkillprocid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMenu.SuspendLayout()
        Me.tabSettings.SuspendLayout()
        Me.tabRESTUI.SuspendLayout()
        Me.tabControlJobsRest.SuspendLayout()
        Me.tabTasks.SuspendLayout()
        Me.tabProjects.SuspendLayout()
        CType(Me.splitProjects, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitProjects.Panel1.SuspendLayout()
        Me.splitProjects.Panel2.SuspendLayout()
        Me.splitProjects.SuspendLayout()
        CType(Me.dgvProjectList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabJobsList.SuspendLayout()
        CType(Me.splitJobsRestJobs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitJobsRestJobs.Panel1.SuspendLayout()
        Me.splitJobsRestJobs.Panel2.SuspendLayout()
        Me.splitJobsRestJobs.SuspendLayout()
        CType(Me.dgvJobsRestJobsList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.splitEndpointStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitEndpointStatus.Panel1.SuspendLayout()
        Me.splitEndpointStatus.Panel2.SuspendLayout()
        Me.splitEndpointStatus.SuspendLayout()
        Me.flowEndpointStatus.SuspendLayout()
        CType(Me.dgvEndpointStatusJobTargets, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabAlerts.SuspendLayout()
        CType(Me.splitAlerts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitAlerts.Panel1.SuspendLayout()
        Me.splitAlerts.Panel2.SuspendLayout()
        Me.splitAlerts.SuspendLayout()
        CType(Me.dgvAlerts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tblAlertBreakdown.SuspendLayout()
        Me.tabJobExecution.SuspendLayout()
        Me.tabFireEye.SuspendLayout()
        Me.tabPANW.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        CType(Me.panw_sim_port, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.panwPort, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabXPS.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.xps_sim_Port, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xpsPort, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabAbout.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExecute
        '
        Me.btnExecute.Location = New System.Drawing.Point(724, 604)
        Me.btnExecute.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExecute.Name = "btnExecute"
        Me.btnExecute.Size = New System.Drawing.Size(100, 28)
        Me.btnExecute.TabIndex = 0
        Me.btnExecute.Text = "Execute Job"
        Me.btnExecute.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 31)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Default Job Name:"
        '
        'txtDefaultJobName
        '
        Me.txtDefaultJobName.Location = New System.Drawing.Point(173, 23)
        Me.txtDefaultJobName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDefaultJobName.Name = "txtDefaultJobName"
        Me.txtDefaultJobName.Size = New System.Drawing.Size(312, 22)
        Me.txtDefaultJobName.TabIndex = 0
        '
        'txtDefaultProjectName
        '
        Me.txtDefaultProjectName.Location = New System.Drawing.Point(173, 55)
        Me.txtDefaultProjectName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDefaultProjectName.Name = "txtDefaultProjectName"
        Me.txtDefaultProjectName.Size = New System.Drawing.Size(312, 22)
        Me.txtDefaultProjectName.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 59)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(146, 17)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Default Project Name:"
        '
        'txtApiUser
        '
        Me.txtApiUser.Location = New System.Drawing.Point(175, 57)
        Me.txtApiUser.Margin = New System.Windows.Forms.Padding(4)
        Me.txtApiUser.Name = "txtApiUser"
        Me.txtApiUser.Size = New System.Drawing.Size(311, 22)
        Me.txtApiUser.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 60)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 17)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "API Username*:"
        Me.tooltip.SetToolTip(Me.Label4, "The Username to use for interaction with R1.")
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 92)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 17)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "API Password*:"
        Me.tooltip.SetToolTip(Me.Label5, "The password for the user.")
        '
        'txtAPIPass
        '
        Me.txtAPIPass.Location = New System.Drawing.Point(175, 89)
        Me.txtAPIPass.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAPIPass.Name = "txtAPIPass"
        Me.txtAPIPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtAPIPass.Size = New System.Drawing.Size(312, 22)
        Me.txtAPIPass.TabIndex = 2
        '
        'txtServer
        '
        Me.txtServer.Location = New System.Drawing.Point(175, 25)
        Me.txtServer.Margin = New System.Windows.Forms.Padding(4)
        Me.txtServer.Name = "txtServer"
        Me.txtServer.Size = New System.Drawing.Size(312, 22)
        Me.txtServer.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 28)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(160, 17)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Web Server Hostname*:"
        Me.tooltip.SetToolTip(Me.Label7, "The webserver hostname where R1 resides.")
        '
        'GroupBox4
        '
        Me.GroupBox4.AutoSize = True
        Me.GroupBox4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox4.Controls.Add(Me.grpReqSet)
        Me.GroupBox4.Controls.Add(Me.grpOptDefSet)
        Me.GroupBox4.Controls.Add(Me.txtStatusSettings)
        Me.GroupBox4.Controls.Add(Me.btnSaveSettings)
        Me.GroupBox4.Location = New System.Drawing.Point(8, 9)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Size = New System.Drawing.Size(821, 462)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Settings"
        '
        'grpReqSet
        '
        Me.grpReqSet.AutoSize = True
        Me.grpReqSet.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.grpReqSet.Controls.Add(Me.chkRestAPI)
        Me.grpReqSet.Controls.Add(Me.GroupBox2)
        Me.grpReqSet.Controls.Add(Me.Label7)
        Me.grpReqSet.Controls.Add(Me.Label4)
        Me.grpReqSet.Controls.Add(Me.Label5)
        Me.grpReqSet.Controls.Add(Me.txtApiUser)
        Me.grpReqSet.Controls.Add(Me.txtServer)
        Me.grpReqSet.Controls.Add(Me.txtAPIPass)
        Me.grpReqSet.Location = New System.Drawing.Point(8, 23)
        Me.grpReqSet.Margin = New System.Windows.Forms.Padding(4)
        Me.grpReqSet.Name = "grpReqSet"
        Me.grpReqSet.Padding = New System.Windows.Forms.Padding(4)
        Me.grpReqSet.Size = New System.Drawing.Size(805, 182)
        Me.grpReqSet.TabIndex = 0
        Me.grpReqSet.TabStop = False
        Me.grpReqSet.Text = "Required Settings"
        '
        'chkRestAPI
        '
        Me.chkRestAPI.AutoSize = True
        Me.chkRestAPI.Checked = True
        Me.chkRestAPI.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkRestAPI.Location = New System.Drawing.Point(560, 139)
        Me.chkRestAPI.Name = "chkRestAPI"
        Me.chkRestAPI.Size = New System.Drawing.Size(182, 21)
        Me.chkRestAPI.TabIndex = 4
        Me.chkRestAPI.Text = "Enable RestAPI (5.8.1+)"
        Me.tooltip.SetToolTip(Me.chkRestAPI, "Enable the Rest API. This is only supported in R1 v5.8.1 and up.")
        Me.chkRestAPI.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtcustomwebaddress)
        Me.GroupBox2.Controls.Add(Me.rdocustom)
        Me.GroupBox2.Controls.Add(Me.rdor1)
        Me.GroupBox2.Controls.Add(Me.rdoadgmap)
        Me.GroupBox2.Location = New System.Drawing.Point(560, 12)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(237, 111)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Website Address:"
        Me.tooltip.SetToolTip(Me.GroupBox2, "Select the trailing website address. 5.8 and up use R1.")
        '
        'txtcustomwebaddress
        '
        Me.txtcustomwebaddress.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcustomwebaddress.Enabled = False
        Me.txtcustomwebaddress.Location = New System.Drawing.Point(31, 79)
        Me.txtcustomwebaddress.Margin = New System.Windows.Forms.Padding(4)
        Me.txtcustomwebaddress.Name = "txtcustomwebaddress"
        Me.txtcustomwebaddress.Size = New System.Drawing.Size(197, 22)
        Me.txtcustomwebaddress.TabIndex = 21
        '
        'rdocustom
        '
        Me.rdocustom.AutoSize = True
        Me.rdocustom.Location = New System.Drawing.Point(8, 82)
        Me.rdocustom.Margin = New System.Windows.Forms.Padding(4)
        Me.rdocustom.Name = "rdocustom"
        Me.rdocustom.Size = New System.Drawing.Size(17, 16)
        Me.rdocustom.TabIndex = 20
        Me.rdocustom.TabStop = True
        Me.tooltip.SetToolTip(Me.rdocustom, "Specify a custom website path.")
        Me.rdocustom.UseVisualStyleBackColor = True
        '
        'rdor1
        '
        Me.rdor1.AutoSize = True
        Me.rdor1.Checked = True
        Me.rdor1.Location = New System.Drawing.Point(8, 53)
        Me.rdor1.Margin = New System.Windows.Forms.Padding(4)
        Me.rdor1.Name = "rdor1"
        Me.rdor1.Size = New System.Drawing.Size(47, 21)
        Me.rdor1.TabIndex = 0
        Me.rdor1.TabStop = True
        Me.rdor1.Text = "R1"
        Me.tooltip.SetToolTip(Me.rdor1, "Default for 5.8 and up.")
        Me.rdor1.UseVisualStyleBackColor = True
        '
        'rdoadgmap
        '
        Me.rdoadgmap.AutoSize = True
        Me.rdoadgmap.Location = New System.Drawing.Point(8, 23)
        Me.rdoadgmap.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoadgmap.Name = "rdoadgmap"
        Me.rdoadgmap.Size = New System.Drawing.Size(123, 21)
        Me.rdoadgmap.TabIndex = 18
        Me.rdoadgmap.Text = "ADG.Map.Web"
        Me.tooltip.SetToolTip(Me.rdoadgmap, "Select for versions below 5.7.")
        Me.rdoadgmap.UseVisualStyleBackColor = True
        '
        'grpOptDefSet
        '
        Me.grpOptDefSet.AutoSize = True
        Me.grpOptDefSet.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.grpOptDefSet.Controls.Add(Me.btnLoadDefaultTemplateName)
        Me.grpOptDefSet.Controls.Add(Me.GroupBox6)
        Me.grpOptDefSet.Controls.Add(Me.Label2)
        Me.grpOptDefSet.Controls.Add(Me.Label3)
        Me.grpOptDefSet.Controls.Add(Me.chkbypasscerts)
        Me.grpOptDefSet.Controls.Add(Me.txtDefaultProjectName)
        Me.grpOptDefSet.Controls.Add(Me.txtdefaultshare)
        Me.grpOptDefSet.Controls.Add(Me.txtDefaultJobName)
        Me.grpOptDefSet.Controls.Add(Me.Label29)
        Me.grpOptDefSet.Controls.Add(Me.Label14)
        Me.grpOptDefSet.Controls.Add(Me.txtdefaultcomputer)
        Me.grpOptDefSet.Controls.Add(Me.txtDefaultTemplateName)
        Me.grpOptDefSet.Controls.Add(Me.Label28)
        Me.grpOptDefSet.Location = New System.Drawing.Point(8, 209)
        Me.grpOptDefSet.Margin = New System.Windows.Forms.Padding(4)
        Me.grpOptDefSet.Name = "grpOptDefSet"
        Me.grpOptDefSet.Padding = New System.Windows.Forms.Padding(4)
        Me.grpOptDefSet.Size = New System.Drawing.Size(794, 198)
        Me.grpOptDefSet.TabIndex = 1
        Me.grpOptDefSet.TabStop = False
        Me.grpOptDefSet.Text = "Optional Default Settings"
        '
        'btnLoadDefaultTemplateName
        '
        Me.btnLoadDefaultTemplateName.Location = New System.Drawing.Point(492, 152)
        Me.btnLoadDefaultTemplateName.Name = "btnLoadDefaultTemplateName"
        Me.btnLoadDefaultTemplateName.Size = New System.Drawing.Size(38, 23)
        Me.btnLoadDefaultTemplateName.TabIndex = 5
        Me.btnLoadDefaultTemplateName.Text = "..."
        Me.btnLoadDefaultTemplateName.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.chkUpdates)
        Me.GroupBox6.Controls.Add(Me.btn_CheckForUpdates)
        Me.GroupBox6.Location = New System.Drawing.Point(536, 66)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(251, 108)
        Me.GroupBox6.TabIndex = 7
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Updates"
        '
        'chkUpdates
        '
        Me.chkUpdates.AutoSize = True
        Me.chkUpdates.Location = New System.Drawing.Point(19, 29)
        Me.chkUpdates.Name = "chkUpdates"
        Me.chkUpdates.Size = New System.Drawing.Size(208, 21)
        Me.chkUpdates.TabIndex = 0
        Me.chkUpdates.Text = "Check For Updates On Start"
        Me.tooltip.SetToolTip(Me.chkUpdates, "Check for updates to Job Runner on start.")
        Me.chkUpdates.UseVisualStyleBackColor = True
        '
        'btn_CheckForUpdates
        '
        Me.btn_CheckForUpdates.Location = New System.Drawing.Point(55, 70)
        Me.btn_CheckForUpdates.Name = "btn_CheckForUpdates"
        Me.btn_CheckForUpdates.Size = New System.Drawing.Size(149, 32)
        Me.btn_CheckForUpdates.TabIndex = 27
        Me.btn_CheckForUpdates.Text = "Check for Updates"
        Me.btn_CheckForUpdates.UseVisualStyleBackColor = True
        '
        'chkbypasscerts
        '
        Me.chkbypasscerts.AutoSize = True
        Me.chkbypasscerts.Location = New System.Drawing.Point(560, 23)
        Me.chkbypasscerts.Margin = New System.Windows.Forms.Padding(4)
        Me.chkbypasscerts.Name = "chkbypasscerts"
        Me.chkbypasscerts.Size = New System.Drawing.Size(188, 21)
        Me.chkbypasscerts.TabIndex = 6
        Me.chkbypasscerts.Text = "ByPass Invalid Certificate"
        Me.tooltip.SetToolTip(Me.chkbypasscerts, "Warning! Allows Job Runner to ignore invalid Website certificates, such as self-s" & _
        "igned certificates.. ")
        Me.chkbypasscerts.UseVisualStyleBackColor = True
        '
        'txtdefaultshare
        '
        Me.txtdefaultshare.Location = New System.Drawing.Point(173, 119)
        Me.txtdefaultshare.Margin = New System.Windows.Forms.Padding(4)
        Me.txtdefaultshare.Name = "txtdefaultshare"
        Me.txtdefaultshare.Size = New System.Drawing.Size(312, 22)
        Me.txtdefaultshare.TabIndex = 3
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(8, 123)
        Me.Label29.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(140, 17)
        Me.Label29.TabIndex = 25
        Me.Label29.Text = "Default Share Name:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(9, 155)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(161, 17)
        Me.Label14.TabIndex = 19
        Me.Label14.Text = "Default Template Name:"
        '
        'txtdefaultcomputer
        '
        Me.txtdefaultcomputer.Location = New System.Drawing.Point(173, 87)
        Me.txtdefaultcomputer.Margin = New System.Windows.Forms.Padding(4)
        Me.txtdefaultcomputer.Name = "txtdefaultcomputer"
        Me.txtdefaultcomputer.Size = New System.Drawing.Size(312, 22)
        Me.txtdefaultcomputer.TabIndex = 2
        '
        'txtDefaultTemplateName
        '
        Me.txtDefaultTemplateName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtDefaultTemplateName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtDefaultTemplateName.FormattingEnabled = True
        Me.txtDefaultTemplateName.Items.AddRange(New Object() {"coll-evtx"})
        Me.txtDefaultTemplateName.Location = New System.Drawing.Point(173, 151)
        Me.txtDefaultTemplateName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDefaultTemplateName.Name = "txtDefaultTemplateName"
        Me.txtDefaultTemplateName.Size = New System.Drawing.Size(312, 24)
        Me.txtDefaultTemplateName.TabIndex = 4
        Me.txtDefaultTemplateName.Text = "coll-evtx"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(8, 91)
        Me.Label28.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(163, 17)
        Me.Label28.TabIndex = 23
        Me.Label28.Text = "Default Computer Name:"
        '
        'txtStatusSettings
        '
        Me.txtStatusSettings.BackColor = System.Drawing.SystemColors.Control
        Me.txtStatusSettings.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtStatusSettings.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStatusSettings.Location = New System.Drawing.Point(8, 415)
        Me.txtStatusSettings.Margin = New System.Windows.Forms.Padding(4)
        Me.txtStatusSettings.Name = "txtStatusSettings"
        Me.txtStatusSettings.ReadOnly = True
        Me.txtStatusSettings.Size = New System.Drawing.Size(643, 19)
        Me.txtStatusSettings.TabIndex = 0
        Me.txtStatusSettings.TabStop = False
        Me.txtStatusSettings.Text = "Status"
        '
        'btnSaveSettings
        '
        Me.btnSaveSettings.Location = New System.Drawing.Point(685, 411)
        Me.btnSaveSettings.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSaveSettings.Name = "btnSaveSettings"
        Me.btnSaveSettings.Size = New System.Drawing.Size(128, 28)
        Me.btnSaveSettings.TabIndex = 2
        Me.btnSaveSettings.Text = "Save Settings"
        Me.btnSaveSettings.UseVisualStyleBackColor = True
        '
        'tabSubMenu
        '
        Me.tabSubMenu.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.tabSubMenu.Controls.Add(Me.tabJobInfo)
        Me.tabSubMenu.Controls.Add(Me.tabFilters)
        Me.tabSubMenu.Controls.Add(Me.tabAgentRemediation)
        Me.tabSubMenu.Location = New System.Drawing.Point(8, 7)
        Me.tabSubMenu.Margin = New System.Windows.Forms.Padding(4)
        Me.tabSubMenu.Name = "tabSubMenu"
        Me.tabSubMenu.SelectedIndex = 0
        Me.tabSubMenu.Size = New System.Drawing.Size(821, 590)
        Me.tabSubMenu.TabIndex = 19
        '
        'tabJobInfo
        '
        Me.tabJobInfo.Controls.Add(Me.GroupBox1)
        Me.tabJobInfo.Controls.Add(Me.txtTemplateName)
        Me.tabJobInfo.Controls.Add(Me.Label25)
        Me.tabJobInfo.Controls.Add(Me.txtJobName)
        Me.tabJobInfo.Controls.Add(Me.Label26)
        Me.tabJobInfo.Controls.Add(Me.txtProjectName)
        Me.tabJobInfo.Controls.Add(Me.Label27)
        Me.tabJobInfo.Location = New System.Drawing.Point(4, 28)
        Me.tabJobInfo.Margin = New System.Windows.Forms.Padding(4)
        Me.tabJobInfo.Name = "tabJobInfo"
        Me.tabJobInfo.Size = New System.Drawing.Size(813, 558)
        Me.tabJobInfo.TabIndex = 3
        Me.tabJobInfo.Text = "Job Information"
        Me.tabJobInfo.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdoagent)
        Me.GroupBox1.Controls.Add(Me.rdoshare)
        Me.GroupBox1.Controls.Add(Me.grpshare)
        Me.GroupBox1.Controls.Add(Me.grpagent)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 110)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(803, 272)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Job Targets"
        '
        'rdoagent
        '
        Me.rdoagent.AutoSize = True
        Me.rdoagent.Checked = True
        Me.rdoagent.Location = New System.Drawing.Point(8, 23)
        Me.rdoagent.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoagent.Name = "rdoagent"
        Me.rdoagent.Size = New System.Drawing.Size(126, 21)
        Me.rdoagent.TabIndex = 12
        Me.rdoagent.TabStop = True
        Me.rdoagent.Text = "Agent Endpoint"
        Me.rdoagent.UseVisualStyleBackColor = True
        '
        'rdoshare
        '
        Me.rdoshare.AutoSize = True
        Me.rdoshare.Location = New System.Drawing.Point(321, 23)
        Me.rdoshare.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoshare.Name = "rdoshare"
        Me.rdoshare.Size = New System.Drawing.Size(122, 21)
        Me.rdoshare.TabIndex = 13
        Me.rdoshare.Text = "Network Share"
        Me.rdoshare.UseVisualStyleBackColor = True
        '
        'grpshare
        '
        Me.grpshare.Controls.Add(Me.Label6)
        Me.grpshare.Controls.Add(Me.lstNetShare)
        Me.grpshare.Controls.Add(Me.txtNetSharePath)
        Me.grpshare.Controls.Add(Me.btnAddNetShare)
        Me.grpshare.Controls.Add(Me.btnRemoveNetShare)
        Me.grpshare.Location = New System.Drawing.Point(312, 49)
        Me.grpshare.Margin = New System.Windows.Forms.Padding(4)
        Me.grpshare.Name = "grpshare"
        Me.grpshare.Padding = New System.Windows.Forms.Padding(4)
        Me.grpshare.Size = New System.Drawing.Size(480, 198)
        Me.grpshare.TabIndex = 11
        Me.grpshare.TabStop = False
        Me.grpshare.Text = "Network Shares"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 18)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 17)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Path:"
        '
        'lstNetShare
        '
        Me.lstNetShare.FormattingEnabled = True
        Me.lstNetShare.Location = New System.Drawing.Point(8, 70)
        Me.lstNetShare.Margin = New System.Windows.Forms.Padding(4)
        Me.lstNetShare.Name = "lstNetShare"
        Me.lstNetShare.Size = New System.Drawing.Size(355, 106)
        Me.lstNetShare.TabIndex = 4
        '
        'txtNetSharePath
        '
        Me.txtNetSharePath.Location = New System.Drawing.Point(8, 38)
        Me.txtNetSharePath.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNetSharePath.Name = "txtNetSharePath"
        Me.txtNetSharePath.Size = New System.Drawing.Size(355, 22)
        Me.txtNetSharePath.TabIndex = 5
        '
        'btnAddNetShare
        '
        Me.btnAddNetShare.Location = New System.Drawing.Point(372, 34)
        Me.btnAddNetShare.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAddNetShare.Name = "btnAddNetShare"
        Me.btnAddNetShare.Size = New System.Drawing.Size(100, 28)
        Me.btnAddNetShare.TabIndex = 2
        Me.btnAddNetShare.Text = "Add Computer"
        Me.btnAddNetShare.UseVisualStyleBackColor = True
        '
        'btnRemoveNetShare
        '
        Me.btnRemoveNetShare.Location = New System.Drawing.Point(372, 158)
        Me.btnRemoveNetShare.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRemoveNetShare.Name = "btnRemoveNetShare"
        Me.btnRemoveNetShare.Size = New System.Drawing.Size(100, 28)
        Me.btnRemoveNetShare.TabIndex = 3
        Me.btnRemoveNetShare.Text = "Remove"
        Me.btnRemoveNetShare.UseVisualStyleBackColor = True
        '
        'grpagent
        '
        Me.grpagent.Controls.Add(Me.Label1)
        Me.grpagent.Controls.Add(Me.lstComputerTargets)
        Me.grpagent.Controls.Add(Me.txtComputerTarget)
        Me.grpagent.Controls.Add(Me.btnAddComputer)
        Me.grpagent.Controls.Add(Me.btnRemoveComputer)
        Me.grpagent.Location = New System.Drawing.Point(7, 49)
        Me.grpagent.Margin = New System.Windows.Forms.Padding(4)
        Me.grpagent.Name = "grpagent"
        Me.grpagent.Padding = New System.Windows.Forms.Padding(4)
        Me.grpagent.Size = New System.Drawing.Size(292, 198)
        Me.grpagent.TabIndex = 10
        Me.grpagent.TabStop = False
        Me.grpagent.Text = "Computer Targets"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 18)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 17)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Hostname:"
        '
        'lstComputerTargets
        '
        Me.lstComputerTargets.FormattingEnabled = True
        Me.lstComputerTargets.Location = New System.Drawing.Point(8, 70)
        Me.lstComputerTargets.Margin = New System.Windows.Forms.Padding(4)
        Me.lstComputerTargets.Name = "lstComputerTargets"
        Me.lstComputerTargets.Size = New System.Drawing.Size(159, 106)
        Me.lstComputerTargets.TabIndex = 4
        '
        'txtComputerTarget
        '
        Me.txtComputerTarget.Location = New System.Drawing.Point(8, 38)
        Me.txtComputerTarget.Margin = New System.Windows.Forms.Padding(4)
        Me.txtComputerTarget.Name = "txtComputerTarget"
        Me.txtComputerTarget.Size = New System.Drawing.Size(159, 22)
        Me.txtComputerTarget.TabIndex = 5
        '
        'btnAddComputer
        '
        Me.btnAddComputer.Location = New System.Drawing.Point(176, 36)
        Me.btnAddComputer.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAddComputer.Name = "btnAddComputer"
        Me.btnAddComputer.Size = New System.Drawing.Size(100, 28)
        Me.btnAddComputer.TabIndex = 2
        Me.btnAddComputer.Text = "Add Computer"
        Me.btnAddComputer.UseVisualStyleBackColor = True
        '
        'btnRemoveComputer
        '
        Me.btnRemoveComputer.Location = New System.Drawing.Point(176, 158)
        Me.btnRemoveComputer.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRemoveComputer.Name = "btnRemoveComputer"
        Me.btnRemoveComputer.Size = New System.Drawing.Size(100, 28)
        Me.btnRemoveComputer.TabIndex = 3
        Me.btnRemoveComputer.Text = "Remove"
        Me.btnRemoveComputer.UseVisualStyleBackColor = True
        '
        'txtTemplateName
        '
        Me.txtTemplateName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtTemplateName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtTemplateName.FormattingEnabled = True
        Me.txtTemplateName.Items.AddRange(New Object() {"coll-evtx", "Drop Process by PID", "ETM Relative Time Query", "EXE-Metadata-Cerb", "Lockdown NIC", "LockdownEnableNIC", "Memory Acquisition", "Memory Analysis", "Registry-Autostart", "Registry-Full", "Remediate-Name", "Remediate-PID", "Small-exes-Cerb", "Software Inventory", "Vol-Deep", "Vol-Deep-Cerb", "Vol-Hidden-Cerb", "Vol-Hidden-Injected", "Vol-Quick", "Vol-Quick-Cerb", "Vol-Quick-Sched"})
        Me.txtTemplateName.Location = New System.Drawing.Point(161, 76)
        Me.txtTemplateName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTemplateName.Name = "txtTemplateName"
        Me.txtTemplateName.Size = New System.Drawing.Size(312, 24)
        Me.txtTemplateName.Sorted = True
        Me.txtTemplateName.TabIndex = 26
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(17, 80)
        Me.Label25.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(112, 17)
        Me.Label25.TabIndex = 25
        Me.Label25.Text = "Template Name:"
        '
        'txtJobName
        '
        Me.txtJobName.Location = New System.Drawing.Point(161, 11)
        Me.txtJobName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtJobName.Name = "txtJobName"
        Me.txtJobName.Size = New System.Drawing.Size(312, 22)
        Me.txtJobName.TabIndex = 22
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(17, 15)
        Me.Label26.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(81, 17)
        Me.Label26.TabIndex = 21
        Me.Label26.Text = "Job Name*:"
        '
        'txtProjectName
        '
        Me.txtProjectName.Location = New System.Drawing.Point(161, 43)
        Me.txtProjectName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtProjectName.Name = "txtProjectName"
        Me.txtProjectName.Size = New System.Drawing.Size(312, 22)
        Me.txtProjectName.TabIndex = 23
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(17, 47)
        Me.Label27.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(97, 17)
        Me.Label27.TabIndex = 24
        Me.Label27.Text = "Project Name:"
        '
        'tabFilters
        '
        Me.tabFilters.Controls.Add(Me.tabFiltersSubMenu)
        Me.tabFilters.Location = New System.Drawing.Point(4, 28)
        Me.tabFilters.Margin = New System.Windows.Forms.Padding(4)
        Me.tabFilters.Name = "tabFilters"
        Me.tabFilters.Padding = New System.Windows.Forms.Padding(4)
        Me.tabFilters.Size = New System.Drawing.Size(813, 558)
        Me.tabFilters.TabIndex = 1
        Me.tabFilters.Text = "Filters"
        Me.tabFilters.UseVisualStyleBackColor = True
        '
        'tabFiltersSubMenu
        '
        Me.tabFiltersSubMenu.Controls.Add(Me.tabInclusionFilter)
        Me.tabFiltersSubMenu.Controls.Add(Me.tabExclusionFilter)
        Me.tabFiltersSubMenu.Location = New System.Drawing.Point(4, 4)
        Me.tabFiltersSubMenu.Margin = New System.Windows.Forms.Padding(4)
        Me.tabFiltersSubMenu.Name = "tabFiltersSubMenu"
        Me.tabFiltersSubMenu.SelectedIndex = 0
        Me.tabFiltersSubMenu.Size = New System.Drawing.Size(803, 546)
        Me.tabFiltersSubMenu.TabIndex = 0
        '
        'tabInclusionFilter
        '
        Me.tabInclusionFilter.Controls.Add(Me.splitInclusion)
        Me.tabInclusionFilter.Location = New System.Drawing.Point(4, 25)
        Me.tabInclusionFilter.Margin = New System.Windows.Forms.Padding(4)
        Me.tabInclusionFilter.Name = "tabInclusionFilter"
        Me.tabInclusionFilter.Padding = New System.Windows.Forms.Padding(4)
        Me.tabInclusionFilter.Size = New System.Drawing.Size(795, 517)
        Me.tabInclusionFilter.TabIndex = 0
        Me.tabInclusionFilter.Text = "Inclusion"
        Me.tabInclusionFilter.UseVisualStyleBackColor = True
        '
        'splitInclusion
        '
        Me.splitInclusion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.splitInclusion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitInclusion.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.splitInclusion.IsSplitterFixed = True
        Me.splitInclusion.Location = New System.Drawing.Point(4, 4)
        Me.splitInclusion.Margin = New System.Windows.Forms.Padding(4)
        Me.splitInclusion.Name = "splitInclusion"
        Me.splitInclusion.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'splitInclusion.Panel1
        '
        Me.splitInclusion.Panel1.Controls.Add(Me.txtinclkeywords)
        Me.splitInclusion.Panel1.Controls.Add(Me.rdoinclregexsearch)
        Me.splitInclusion.Panel1.Controls.Add(Me.Label8)
        Me.splitInclusion.Panel1.Controls.Add(Me.rdoinclsimplesearch)
        Me.splitInclusion.Panel1.Controls.Add(Me.txtinclfiltername)
        Me.splitInclusion.Panel1.Controls.Add(Me.chkinclsearchfilename)
        Me.splitInclusion.Panel1.Controls.Add(Me.Label9)
        Me.splitInclusion.Panel1.Controls.Add(Me.Label23)
        Me.splitInclusion.Panel1.Controls.Add(Me.txtinclpathcontains)
        Me.splitInclusion.Panel1.Controls.Add(Me.txtinclmd5hash)
        Me.splitInclusion.Panel1.Controls.Add(Me.Label10)
        Me.splitInclusion.Panel1.Controls.Add(Me.txtinclextensions)
        Me.splitInclusion.Panel1.Controls.Add(Me.Label11)
        Me.splitInclusion.Panel1MinSize = 216
        '
        'splitInclusion.Panel2
        '
        Me.splitInclusion.Panel2.Controls.Add(Me.btnSaveIncFilterChanges)
        Me.splitInclusion.Panel2.Controls.Add(Me.lstboxinclusionfilters)
        Me.splitInclusion.Panel2.Controls.Add(Me.Label31)
        Me.splitInclusion.Panel2.Controls.Add(Me.btnRemoveInclFilterfromList)
        Me.splitInclusion.Panel2.Controls.Add(Me.btnAddInclFilterToList)
        Me.splitInclusion.Size = New System.Drawing.Size(787, 509)
        Me.splitInclusion.SplitterDistance = 216
        Me.splitInclusion.SplitterWidth = 10
        Me.splitInclusion.TabIndex = 14
        '
        'txtinclkeywords
        '
        Me.txtinclkeywords.Location = New System.Drawing.Point(321, 119)
        Me.txtinclkeywords.Margin = New System.Windows.Forms.Padding(4)
        Me.txtinclkeywords.Multiline = True
        Me.txtinclkeywords.Name = "txtinclkeywords"
        Me.txtinclkeywords.Size = New System.Drawing.Size(443, 128)
        Me.txtinclkeywords.TabIndex = 2
        '
        'rdoinclregexsearch
        '
        Me.rdoinclregexsearch.AutoSize = True
        Me.rdoinclregexsearch.Location = New System.Drawing.Point(469, 75)
        Me.rdoinclregexsearch.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoinclregexsearch.Name = "rdoinclregexsearch"
        Me.rdoinclregexsearch.Size = New System.Drawing.Size(119, 21)
        Me.rdoinclregexsearch.TabIndex = 13
        Me.rdoinclregexsearch.Text = "RegEx Search"
        Me.rdoinclregexsearch.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(13, 11)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 17)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Filter Name:"
        '
        'rdoinclsimplesearch
        '
        Me.rdoinclsimplesearch.AutoSize = True
        Me.rdoinclsimplesearch.Checked = True
        Me.rdoinclsimplesearch.Location = New System.Drawing.Point(323, 75)
        Me.rdoinclsimplesearch.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoinclsimplesearch.Name = "rdoinclsimplesearch"
        Me.rdoinclsimplesearch.Size = New System.Drawing.Size(120, 21)
        Me.rdoinclsimplesearch.TabIndex = 12
        Me.rdoinclsimplesearch.TabStop = True
        Me.rdoinclsimplesearch.Text = "Simple Search"
        Me.rdoinclsimplesearch.UseVisualStyleBackColor = True
        '
        'txtinclfiltername
        '
        Me.txtinclfiltername.Location = New System.Drawing.Point(123, 7)
        Me.txtinclfiltername.Margin = New System.Windows.Forms.Padding(4)
        Me.txtinclfiltername.Name = "txtinclfiltername"
        Me.txtinclfiltername.Size = New System.Drawing.Size(245, 22)
        Me.txtinclfiltername.TabIndex = 1
        '
        'chkinclsearchfilename
        '
        Me.chkinclsearchfilename.AutoSize = True
        Me.chkinclsearchfilename.Location = New System.Drawing.Point(609, 76)
        Me.chkinclsearchfilename.Margin = New System.Windows.Forms.Padding(4)
        Me.chkinclsearchfilename.Name = "chkinclsearchfilename"
        Me.chkinclsearchfilename.Size = New System.Drawing.Size(171, 21)
        Me.chkinclsearchfilename.TabIndex = 10
        Me.chkinclsearchfilename.Text = "Search FileName Only"
        Me.chkinclsearchfilename.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(319, 100)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 17)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Keywords:"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(13, 100)
        Me.Label23.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(78, 17)
        Me.Label23.TabIndex = 9
        Me.Label23.Text = "MD5 Hash:"
        '
        'txtinclpathcontains
        '
        Me.txtinclpathcontains.Location = New System.Drawing.Point(123, 44)
        Me.txtinclpathcontains.Margin = New System.Windows.Forms.Padding(4)
        Me.txtinclpathcontains.Multiline = True
        Me.txtinclpathcontains.Name = "txtinclpathcontains"
        Me.txtinclpathcontains.Size = New System.Drawing.Size(641, 24)
        Me.txtinclpathcontains.TabIndex = 4
        '
        'txtinclmd5hash
        '
        Me.txtinclmd5hash.Location = New System.Drawing.Point(11, 119)
        Me.txtinclmd5hash.Margin = New System.Windows.Forms.Padding(4)
        Me.txtinclmd5hash.Multiline = True
        Me.txtinclmd5hash.Name = "txtinclmd5hash"
        Me.txtinclmd5hash.Size = New System.Drawing.Size(301, 128)
        Me.txtinclmd5hash.TabIndex = 8
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(13, 48)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(100, 17)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Path Contains:"
        '
        'txtinclextensions
        '
        Me.txtinclextensions.Location = New System.Drawing.Point(467, 7)
        Me.txtinclextensions.Margin = New System.Windows.Forms.Padding(4)
        Me.txtinclextensions.Name = "txtinclextensions"
        Me.txtinclextensions.Size = New System.Drawing.Size(297, 22)
        Me.txtinclextensions.TabIndex = 7
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(377, 11)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 17)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "Extensions:"
        '
        'btnSaveIncFilterChanges
        '
        Me.btnSaveIncFilterChanges.Location = New System.Drawing.Point(347, 4)
        Me.btnSaveIncFilterChanges.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSaveIncFilterChanges.Name = "btnSaveIncFilterChanges"
        Me.btnSaveIncFilterChanges.Size = New System.Drawing.Size(100, 28)
        Me.btnSaveIncFilterChanges.TabIndex = 5
        Me.btnSaveIncFilterChanges.Text = "Save"
        Me.btnSaveIncFilterChanges.UseVisualStyleBackColor = True
        '
        'lstboxinclusionfilters
        '
        Me.lstboxinclusionfilters.FormattingEnabled = True
        Me.lstboxinclusionfilters.Location = New System.Drawing.Point(4, 73)
        Me.lstboxinclusionfilters.Margin = New System.Windows.Forms.Padding(4)
        Me.lstboxinclusionfilters.Name = "lstboxinclusionfilters"
        Me.lstboxinclusionfilters.Size = New System.Drawing.Size(773, 140)
        Me.lstboxinclusionfilters.TabIndex = 4
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(7, 53)
        Me.Label31.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(50, 17)
        Me.Label31.TabIndex = 3
        Me.Label31.Text = "Filters:"
        '
        'btnRemoveInclFilterfromList
        '
        Me.btnRemoveInclFilterfromList.Location = New System.Drawing.Point(683, 4)
        Me.btnRemoveInclFilterfromList.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRemoveInclFilterfromList.Name = "btnRemoveInclFilterfromList"
        Me.btnRemoveInclFilterfromList.Size = New System.Drawing.Size(100, 28)
        Me.btnRemoveInclFilterfromList.TabIndex = 1
        Me.btnRemoveInclFilterfromList.Text = "Remove"
        Me.btnRemoveInclFilterfromList.UseVisualStyleBackColor = True
        '
        'btnAddInclFilterToList
        '
        Me.btnAddInclFilterToList.Location = New System.Drawing.Point(4, 4)
        Me.btnAddInclFilterToList.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAddInclFilterToList.Name = "btnAddInclFilterToList"
        Me.btnAddInclFilterToList.Size = New System.Drawing.Size(100, 28)
        Me.btnAddInclFilterToList.TabIndex = 0
        Me.btnAddInclFilterToList.Text = "Add"
        Me.btnAddInclFilterToList.UseVisualStyleBackColor = True
        '
        'tabExclusionFilter
        '
        Me.tabExclusionFilter.Controls.Add(Me.SplitExclusion)
        Me.tabExclusionFilter.Location = New System.Drawing.Point(4, 25)
        Me.tabExclusionFilter.Margin = New System.Windows.Forms.Padding(4)
        Me.tabExclusionFilter.Name = "tabExclusionFilter"
        Me.tabExclusionFilter.Padding = New System.Windows.Forms.Padding(4)
        Me.tabExclusionFilter.Size = New System.Drawing.Size(795, 517)
        Me.tabExclusionFilter.TabIndex = 1
        Me.tabExclusionFilter.Text = "Exclusion"
        Me.tabExclusionFilter.UseVisualStyleBackColor = True
        '
        'SplitExclusion
        '
        Me.SplitExclusion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitExclusion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitExclusion.IsSplitterFixed = True
        Me.SplitExclusion.Location = New System.Drawing.Point(4, 4)
        Me.SplitExclusion.Margin = New System.Windows.Forms.Padding(4)
        Me.SplitExclusion.Name = "SplitExclusion"
        Me.SplitExclusion.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitExclusion.Panel1
        '
        Me.SplitExclusion.Panel1.Controls.Add(Me.Label15)
        Me.SplitExclusion.Panel1.Controls.Add(Me.Label24)
        Me.SplitExclusion.Panel1.Controls.Add(Me.txtexclfiltername)
        Me.SplitExclusion.Panel1.Controls.Add(Me.txtexclmd5hash)
        Me.SplitExclusion.Panel1.Controls.Add(Me.txtexclpathcontains)
        Me.SplitExclusion.Panel1.Controls.Add(Me.txtexclextensions)
        Me.SplitExclusion.Panel1.Controls.Add(Me.Label13)
        Me.SplitExclusion.Panel1.Controls.Add(Me.Label12)
        '
        'SplitExclusion.Panel2
        '
        Me.SplitExclusion.Panel2.Controls.Add(Me.btnsaveexclusionfilterchanges)
        Me.SplitExclusion.Panel2.Controls.Add(Me.lstboxexclusionfilters)
        Me.SplitExclusion.Panel2.Controls.Add(Me.Label32)
        Me.SplitExclusion.Panel2.Controls.Add(Me.btnremoveexclusionfilterfromlist)
        Me.SplitExclusion.Panel2.Controls.Add(Me.btnaddexclusionfiltertolist)
        Me.SplitExclusion.Size = New System.Drawing.Size(787, 509)
        Me.SplitExclusion.SplitterDistance = 266
        Me.SplitExclusion.SplitterWidth = 10
        Me.SplitExclusion.TabIndex = 18
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(13, 11)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(84, 17)
        Me.Label15.TabIndex = 8
        Me.Label15.Text = "Filter Name:"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(13, 100)
        Me.Label24.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(78, 17)
        Me.Label24.TabIndex = 17
        Me.Label24.Text = "MD5 Hash:"
        '
        'txtexclfiltername
        '
        Me.txtexclfiltername.Location = New System.Drawing.Point(123, 7)
        Me.txtexclfiltername.Margin = New System.Windows.Forms.Padding(4)
        Me.txtexclfiltername.Name = "txtexclfiltername"
        Me.txtexclfiltername.Size = New System.Drawing.Size(245, 22)
        Me.txtexclfiltername.TabIndex = 9
        '
        'txtexclmd5hash
        '
        Me.txtexclmd5hash.Location = New System.Drawing.Point(11, 119)
        Me.txtexclmd5hash.Margin = New System.Windows.Forms.Padding(4)
        Me.txtexclmd5hash.Multiline = True
        Me.txtexclmd5hash.Name = "txtexclmd5hash"
        Me.txtexclmd5hash.Size = New System.Drawing.Size(301, 128)
        Me.txtexclmd5hash.TabIndex = 16
        '
        'txtexclpathcontains
        '
        Me.txtexclpathcontains.Location = New System.Drawing.Point(123, 44)
        Me.txtexclpathcontains.Margin = New System.Windows.Forms.Padding(4)
        Me.txtexclpathcontains.Multiline = True
        Me.txtexclpathcontains.Name = "txtexclpathcontains"
        Me.txtexclpathcontains.Size = New System.Drawing.Size(641, 24)
        Me.txtexclpathcontains.TabIndex = 12
        '
        'txtexclextensions
        '
        Me.txtexclextensions.Location = New System.Drawing.Point(467, 7)
        Me.txtexclextensions.Margin = New System.Windows.Forms.Padding(4)
        Me.txtexclextensions.Name = "txtexclextensions"
        Me.txtexclextensions.Size = New System.Drawing.Size(297, 22)
        Me.txtexclextensions.TabIndex = 15
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(13, 48)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(100, 17)
        Me.Label13.TabIndex = 13
        Me.Label13.Text = "Path Contains:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(377, 11)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(80, 17)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "Extensions:"
        '
        'btnsaveexclusionfilterchanges
        '
        Me.btnsaveexclusionfilterchanges.Location = New System.Drawing.Point(347, 4)
        Me.btnsaveexclusionfilterchanges.Margin = New System.Windows.Forms.Padding(4)
        Me.btnsaveexclusionfilterchanges.Name = "btnsaveexclusionfilterchanges"
        Me.btnsaveexclusionfilterchanges.Size = New System.Drawing.Size(100, 28)
        Me.btnsaveexclusionfilterchanges.TabIndex = 10
        Me.btnsaveexclusionfilterchanges.Text = "Save"
        Me.btnsaveexclusionfilterchanges.UseVisualStyleBackColor = True
        '
        'lstboxexclusionfilters
        '
        Me.lstboxexclusionfilters.FormattingEnabled = True
        Me.lstboxexclusionfilters.Location = New System.Drawing.Point(4, 73)
        Me.lstboxexclusionfilters.Margin = New System.Windows.Forms.Padding(4)
        Me.lstboxexclusionfilters.Name = "lstboxexclusionfilters"
        Me.lstboxexclusionfilters.Size = New System.Drawing.Size(773, 140)
        Me.lstboxexclusionfilters.TabIndex = 9
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(7, 53)
        Me.Label32.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(50, 17)
        Me.Label32.TabIndex = 8
        Me.Label32.Text = "Filters:"
        '
        'btnremoveexclusionfilterfromlist
        '
        Me.btnremoveexclusionfilterfromlist.Location = New System.Drawing.Point(683, 4)
        Me.btnremoveexclusionfilterfromlist.Margin = New System.Windows.Forms.Padding(4)
        Me.btnremoveexclusionfilterfromlist.Name = "btnremoveexclusionfilterfromlist"
        Me.btnremoveexclusionfilterfromlist.Size = New System.Drawing.Size(100, 28)
        Me.btnremoveexclusionfilterfromlist.TabIndex = 7
        Me.btnremoveexclusionfilterfromlist.Text = "Remove"
        Me.btnremoveexclusionfilterfromlist.UseVisualStyleBackColor = True
        '
        'btnaddexclusionfiltertolist
        '
        Me.btnaddexclusionfiltertolist.Location = New System.Drawing.Point(4, 4)
        Me.btnaddexclusionfiltertolist.Margin = New System.Windows.Forms.Padding(4)
        Me.btnaddexclusionfiltertolist.Name = "btnaddexclusionfiltertolist"
        Me.btnaddexclusionfiltertolist.Size = New System.Drawing.Size(100, 28)
        Me.btnaddexclusionfiltertolist.TabIndex = 6
        Me.btnaddexclusionfiltertolist.Text = "Add"
        Me.btnaddexclusionfiltertolist.UseVisualStyleBackColor = True
        '
        'tabAgentRemediation
        '
        Me.tabAgentRemediation.Controls.Add(Me.btnSaveRemOptionChange)
        Me.tabAgentRemediation.Controls.Add(Me.btnRemoveRemOption)
        Me.tabAgentRemediation.Controls.Add(Me.btnAddRemOption)
        Me.tabAgentRemediation.Controls.Add(Me.lvRemOptions)
        Me.tabAgentRemediation.Controls.Add(Me.tabAgentRemediationSubMenu)
        Me.tabAgentRemediation.Location = New System.Drawing.Point(4, 28)
        Me.tabAgentRemediation.Margin = New System.Windows.Forms.Padding(4)
        Me.tabAgentRemediation.Name = "tabAgentRemediation"
        Me.tabAgentRemediation.Size = New System.Drawing.Size(813, 558)
        Me.tabAgentRemediation.TabIndex = 2
        Me.tabAgentRemediation.Text = "Agent Remediation"
        Me.tabAgentRemediation.UseVisualStyleBackColor = True
        '
        'btnSaveRemOptionChange
        '
        Me.btnSaveRemOptionChange.Location = New System.Drawing.Point(359, 357)
        Me.btnSaveRemOptionChange.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSaveRemOptionChange.Name = "btnSaveRemOptionChange"
        Me.btnSaveRemOptionChange.Size = New System.Drawing.Size(100, 28)
        Me.btnSaveRemOptionChange.TabIndex = 4
        Me.btnSaveRemOptionChange.Text = "Save"
        Me.btnSaveRemOptionChange.UseVisualStyleBackColor = True
        '
        'btnRemoveRemOption
        '
        Me.btnRemoveRemOption.Location = New System.Drawing.Point(705, 357)
        Me.btnRemoveRemOption.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRemoveRemOption.Name = "btnRemoveRemOption"
        Me.btnRemoveRemOption.Size = New System.Drawing.Size(100, 28)
        Me.btnRemoveRemOption.TabIndex = 3
        Me.btnRemoveRemOption.Text = "Remove"
        Me.btnRemoveRemOption.UseVisualStyleBackColor = True
        '
        'btnAddRemOption
        '
        Me.btnAddRemOption.Location = New System.Drawing.Point(5, 357)
        Me.btnAddRemOption.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAddRemOption.Name = "btnAddRemOption"
        Me.btnAddRemOption.Size = New System.Drawing.Size(100, 28)
        Me.btnAddRemOption.TabIndex = 2
        Me.btnAddRemOption.Text = "Add"
        Me.btnAddRemOption.UseVisualStyleBackColor = True
        '
        'lvRemOptions
        '
        Me.lvRemOptions.CheckBoxes = True
        Me.lvRemOptions.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colRemType, Me.colitem})
        Me.lvRemOptions.FullRowSelect = True
        Me.lvRemOptions.GridLines = True
        Me.lvRemOptions.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvRemOptions.Location = New System.Drawing.Point(5, 393)
        Me.lvRemOptions.Margin = New System.Windows.Forms.Padding(4)
        Me.lvRemOptions.MultiSelect = False
        Me.lvRemOptions.Name = "lvRemOptions"
        Me.lvRemOptions.Size = New System.Drawing.Size(799, 157)
        Me.lvRemOptions.TabIndex = 1
        Me.lvRemOptions.UseCompatibleStateImageBehavior = False
        Me.lvRemOptions.View = System.Windows.Forms.View.Details
        '
        'colRemType
        '
        Me.colRemType.Text = "Remediation Type"
        Me.colRemType.Width = 200
        '
        'colitem
        '
        Me.colitem.Text = "Item"
        Me.colitem.Width = 200
        '
        'tabAgentRemediationSubMenu
        '
        Me.tabAgentRemediationSubMenu.Controls.Add(Me.tabAgentSendFile)
        Me.tabAgentRemediationSubMenu.Controls.Add(Me.tabAgentExecute)
        Me.tabAgentRemediationSubMenu.Controls.Add(Me.tabAgentDelete)
        Me.tabAgentRemediationSubMenu.Controls.Add(Me.TabAgentKill)
        Me.tabAgentRemediationSubMenu.Location = New System.Drawing.Point(0, 0)
        Me.tabAgentRemediationSubMenu.Margin = New System.Windows.Forms.Padding(4)
        Me.tabAgentRemediationSubMenu.Name = "tabAgentRemediationSubMenu"
        Me.tabAgentRemediationSubMenu.SelectedIndex = 0
        Me.tabAgentRemediationSubMenu.Size = New System.Drawing.Size(811, 343)
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
        Me.tabAgentSendFile.Location = New System.Drawing.Point(4, 25)
        Me.tabAgentSendFile.Margin = New System.Windows.Forms.Padding(4)
        Me.tabAgentSendFile.Name = "tabAgentSendFile"
        Me.tabAgentSendFile.Padding = New System.Windows.Forms.Padding(4)
        Me.tabAgentSendFile.Size = New System.Drawing.Size(803, 314)
        Me.tabAgentSendFile.TabIndex = 0
        Me.tabAgentSendFile.Text = "Send File"
        Me.tabAgentSendFile.UseVisualStyleBackColor = True
        '
        'chkremsendexecute
        '
        Me.chkremsendexecute.AutoSize = True
        Me.chkremsendexecute.Location = New System.Drawing.Point(153, 84)
        Me.chkremsendexecute.Margin = New System.Windows.Forms.Padding(4)
        Me.chkremsendexecute.Name = "chkremsendexecute"
        Me.chkremsendexecute.Size = New System.Drawing.Size(80, 21)
        Me.chkremsendexecute.TabIndex = 25
        Me.chkremsendexecute.Text = "Execute"
        Me.chkremsendexecute.UseVisualStyleBackColor = True
        Me.chkremsendexecute.Visible = False
        '
        'chkremsenddelete
        '
        Me.chkremsenddelete.AutoSize = True
        Me.chkremsenddelete.Location = New System.Drawing.Point(12, 84)
        Me.chkremsenddelete.Margin = New System.Windows.Forms.Padding(4)
        Me.chkremsenddelete.Name = "chkremsenddelete"
        Me.chkremsenddelete.Size = New System.Drawing.Size(97, 21)
        Me.chkremsenddelete.TabIndex = 24
        Me.chkremsenddelete.Text = "Delete File"
        Me.chkremsenddelete.UseVisualStyleBackColor = True
        '
        'txtremsenddest
        '
        Me.txtremsenddest.Location = New System.Drawing.Point(153, 43)
        Me.txtremsenddest.Margin = New System.Windows.Forms.Padding(4)
        Me.txtremsenddest.Name = "txtremsenddest"
        Me.txtremsenddest.Size = New System.Drawing.Size(312, 22)
        Me.txtremsenddest.TabIndex = 22
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(8, 47)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(142, 17)
        Me.Label17.TabIndex = 23
        Me.Label17.Text = "Destination File Path:"
        '
        'txtremsendsource
        '
        Me.txtremsendsource.Location = New System.Drawing.Point(153, 11)
        Me.txtremsendsource.Margin = New System.Windows.Forms.Padding(4)
        Me.txtremsendsource.Name = "txtremsendsource"
        Me.txtremsendsource.Size = New System.Drawing.Size(312, 22)
        Me.txtremsendsource.TabIndex = 20
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(8, 15)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(120, 17)
        Me.Label16.TabIndex = 21
        Me.Label16.Text = "Source File Path: "
        '
        'tabAgentExecute
        '
        Me.tabAgentExecute.Controls.Add(Me.txtremexecargs)
        Me.tabAgentExecute.Controls.Add(Me.Label19)
        Me.tabAgentExecute.Controls.Add(Me.txtremexecpath)
        Me.tabAgentExecute.Controls.Add(Me.Label18)
        Me.tabAgentExecute.Location = New System.Drawing.Point(4, 25)
        Me.tabAgentExecute.Margin = New System.Windows.Forms.Padding(4)
        Me.tabAgentExecute.Name = "tabAgentExecute"
        Me.tabAgentExecute.Padding = New System.Windows.Forms.Padding(4)
        Me.tabAgentExecute.Size = New System.Drawing.Size(803, 314)
        Me.tabAgentExecute.TabIndex = 1
        Me.tabAgentExecute.Text = "Execute"
        Me.tabAgentExecute.UseVisualStyleBackColor = True
        '
        'txtremexecargs
        '
        Me.txtremexecargs.Location = New System.Drawing.Point(157, 53)
        Me.txtremexecargs.Margin = New System.Windows.Forms.Padding(4)
        Me.txtremexecargs.Name = "txtremexecargs"
        Me.txtremexecargs.Size = New System.Drawing.Size(312, 22)
        Me.txtremexecargs.TabIndex = 24
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(12, 57)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(80, 17)
        Me.Label19.TabIndex = 25
        Me.Label19.Text = "Arguments:"
        '
        'txtremexecpath
        '
        Me.txtremexecpath.Location = New System.Drawing.Point(157, 16)
        Me.txtremexecpath.Margin = New System.Windows.Forms.Padding(4)
        Me.txtremexecpath.Name = "txtremexecpath"
        Me.txtremexecpath.Size = New System.Drawing.Size(312, 22)
        Me.txtremexecpath.TabIndex = 22
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(12, 20)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(113, 17)
        Me.Label18.TabIndex = 23
        Me.Label18.Text = "Target File Path:"
        '
        'tabAgentDelete
        '
        Me.tabAgentDelete.Controls.Add(Me.txtremdelfilepath)
        Me.tabAgentDelete.Controls.Add(Me.Label20)
        Me.tabAgentDelete.Location = New System.Drawing.Point(4, 25)
        Me.tabAgentDelete.Margin = New System.Windows.Forms.Padding(4)
        Me.tabAgentDelete.Name = "tabAgentDelete"
        Me.tabAgentDelete.Size = New System.Drawing.Size(803, 314)
        Me.tabAgentDelete.TabIndex = 2
        Me.tabAgentDelete.Text = "Delete File"
        Me.tabAgentDelete.UseVisualStyleBackColor = True
        '
        'txtremdelfilepath
        '
        Me.txtremdelfilepath.Location = New System.Drawing.Point(157, 17)
        Me.txtremdelfilepath.Margin = New System.Windows.Forms.Padding(4)
        Me.txtremdelfilepath.Name = "txtremdelfilepath"
        Me.txtremdelfilepath.Size = New System.Drawing.Size(312, 22)
        Me.txtremdelfilepath.TabIndex = 24
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(12, 21)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(113, 17)
        Me.Label20.TabIndex = 25
        Me.Label20.Text = "Target File Path:"
        '
        'TabAgentKill
        '
        Me.TabAgentKill.Controls.Add(Me.rdoPName)
        Me.TabAgentKill.Controls.Add(Me.rdoPID)
        Me.TabAgentKill.Controls.Add(Me.txtremkillprocname)
        Me.TabAgentKill.Controls.Add(Me.Label22)
        Me.TabAgentKill.Controls.Add(Me.nmbremkillprocid)
        Me.TabAgentKill.Controls.Add(Me.Label21)
        Me.TabAgentKill.Location = New System.Drawing.Point(4, 25)
        Me.TabAgentKill.Margin = New System.Windows.Forms.Padding(4)
        Me.TabAgentKill.Name = "TabAgentKill"
        Me.TabAgentKill.Size = New System.Drawing.Size(803, 314)
        Me.TabAgentKill.TabIndex = 3
        Me.TabAgentKill.Text = "Kill Process"
        Me.TabAgentKill.UseVisualStyleBackColor = True
        '
        'rdoPName
        '
        Me.rdoPName.AutoSize = True
        Me.rdoPName.Location = New System.Drawing.Point(213, 18)
        Me.rdoPName.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoPName.Name = "rdoPName"
        Me.rdoPName.Size = New System.Drawing.Size(121, 21)
        Me.rdoPName.TabIndex = 17
        Me.rdoPName.TabStop = True
        Me.rdoPName.Text = "Process Name"
        Me.rdoPName.UseVisualStyleBackColor = True
        '
        'rdoPID
        '
        Me.rdoPID.AutoSize = True
        Me.rdoPID.Location = New System.Drawing.Point(19, 18)
        Me.rdoPID.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoPID.Name = "rdoPID"
        Me.rdoPID.Size = New System.Drawing.Size(97, 21)
        Me.rdoPID.TabIndex = 16
        Me.rdoPID.TabStop = True
        Me.rdoPID.Text = "Process ID"
        Me.rdoPID.UseVisualStyleBackColor = True
        '
        'txtremkillprocname
        '
        Me.txtremkillprocname.Location = New System.Drawing.Point(125, 97)
        Me.txtremkillprocname.Margin = New System.Windows.Forms.Padding(4)
        Me.txtremkillprocname.Name = "txtremkillprocname"
        Me.txtremkillprocname.Size = New System.Drawing.Size(312, 22)
        Me.txtremkillprocname.TabIndex = 14
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(15, 101)
        Me.Label22.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(104, 17)
        Me.Label22.TabIndex = 15
        Me.Label22.Text = "Process Name:"
        '
        'nmbremkillprocid
        '
        Me.nmbremkillprocid.Location = New System.Drawing.Point(125, 65)
        Me.nmbremkillprocid.Margin = New System.Windows.Forms.Padding(4)
        Me.nmbremkillprocid.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.nmbremkillprocid.Name = "nmbremkillprocid"
        Me.nmbremkillprocid.Size = New System.Drawing.Size(101, 22)
        Me.nmbremkillprocid.TabIndex = 13
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(15, 68)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(100, 17)
        Me.Label21.TabIndex = 12
        Me.Label21.Text = "By Process ID:"
        '
        'tabMenu
        '
        Me.tabMenu.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.tabMenu.Controls.Add(Me.tabSettings)
        Me.tabMenu.Controls.Add(Me.tabRESTUI)
        Me.tabMenu.Controls.Add(Me.tabJobExecution)
        Me.tabMenu.Controls.Add(Me.tabFireEye)
        Me.tabMenu.Controls.Add(Me.tabPANW)
        Me.tabMenu.Controls.Add(Me.tabXPS)
        Me.tabMenu.Controls.Add(Me.tabAbout)
        Me.tabMenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabMenu.Location = New System.Drawing.Point(0, 0)
        Me.tabMenu.Margin = New System.Windows.Forms.Padding(4)
        Me.tabMenu.Name = "tabMenu"
        Me.tabMenu.SelectedIndex = 0
        Me.tabMenu.Size = New System.Drawing.Size(840, 732)
        Me.tabMenu.TabIndex = 0
        '
        'tabSettings
        '
        Me.tabSettings.Controls.Add(Me.GroupBox4)
        Me.tabSettings.Location = New System.Drawing.Point(4, 28)
        Me.tabSettings.Margin = New System.Windows.Forms.Padding(4)
        Me.tabSettings.Name = "tabSettings"
        Me.tabSettings.Padding = New System.Windows.Forms.Padding(4)
        Me.tabSettings.Size = New System.Drawing.Size(832, 700)
        Me.tabSettings.TabIndex = 1
        Me.tabSettings.Text = "Settings"
        Me.tabSettings.UseVisualStyleBackColor = True
        '
        'tabRESTUI
        '
        Me.tabRESTUI.Controls.Add(Me.tabControlJobsRest)
        Me.tabRESTUI.Location = New System.Drawing.Point(4, 28)
        Me.tabRESTUI.Name = "tabRESTUI"
        Me.tabRESTUI.Size = New System.Drawing.Size(832, 700)
        Me.tabRESTUI.TabIndex = 7
        Me.tabRESTUI.Text = "REST UI"
        Me.tabRESTUI.UseVisualStyleBackColor = True
        '
        'tabControlJobsRest
        '
        Me.tabControlJobsRest.Controls.Add(Me.tabTasks)
        Me.tabControlJobsRest.Controls.Add(Me.tabProjects)
        Me.tabControlJobsRest.Controls.Add(Me.tabAlerts)
        Me.tabControlJobsRest.Controls.Add(Me.tabJobsList)
        Me.tabControlJobsRest.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabControlJobsRest.Location = New System.Drawing.Point(0, 0)
        Me.tabControlJobsRest.Name = "tabControlJobsRest"
        Me.tabControlJobsRest.SelectedIndex = 0
        Me.tabControlJobsRest.Size = New System.Drawing.Size(832, 700)
        Me.tabControlJobsRest.TabIndex = 0
        '
        'tabTasks
        '
        Me.tabTasks.Controls.Add(Me.flowTasks)
        Me.tabTasks.Location = New System.Drawing.Point(4, 25)
        Me.tabTasks.Name = "tabTasks"
        Me.tabTasks.Size = New System.Drawing.Size(824, 671)
        Me.tabTasks.TabIndex = 2
        Me.tabTasks.Text = "Tasks"
        Me.tabTasks.UseVisualStyleBackColor = True
        '
        'flowTasks
        '
        Me.flowTasks.AutoScroll = True
        Me.flowTasks.AutoSize = True
        Me.flowTasks.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flowTasks.Location = New System.Drawing.Point(0, 0)
        Me.flowTasks.Name = "flowTasks"
        Me.flowTasks.Size = New System.Drawing.Size(824, 671)
        Me.flowTasks.TabIndex = 0
        '
        'tabProjects
        '
        Me.tabProjects.Controls.Add(Me.splitProjects)
        Me.tabProjects.Location = New System.Drawing.Point(4, 25)
        Me.tabProjects.Name = "tabProjects"
        Me.tabProjects.Padding = New System.Windows.Forms.Padding(3)
        Me.tabProjects.Size = New System.Drawing.Size(824, 671)
        Me.tabProjects.TabIndex = 1
        Me.tabProjects.Text = "Projects"
        Me.tabProjects.UseVisualStyleBackColor = True
        '
        'splitProjects
        '
        Me.splitProjects.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitProjects.IsSplitterFixed = True
        Me.splitProjects.Location = New System.Drawing.Point(3, 3)
        Me.splitProjects.Name = "splitProjects"
        Me.splitProjects.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'splitProjects.Panel1
        '
        Me.splitProjects.Panel1.Controls.Add(Me.btnViewProjectReview)
        Me.splitProjects.Panel1.Controls.Add(Me.btnDeleteProject)
        Me.splitProjects.Panel1.Controls.Add(Me.btnEditProject)
        Me.splitProjects.Panel1.Controls.Add(Me.btnNewProject)
        Me.splitProjects.Panel1.Controls.Add(Me.txtSearchProject)
        '
        'splitProjects.Panel2
        '
        Me.splitProjects.Panel2.Controls.Add(Me.dgvProjectList)
        Me.splitProjects.Size = New System.Drawing.Size(818, 665)
        Me.splitProjects.SplitterDistance = 38
        Me.splitProjects.TabIndex = 0
        '
        'btnViewProjectReview
        '
        Me.btnViewProjectReview.Location = New System.Drawing.Point(447, 8)
        Me.btnViewProjectReview.Name = "btnViewProjectReview"
        Me.btnViewProjectReview.Size = New System.Drawing.Size(135, 27)
        Me.btnViewProjectReview.TabIndex = 5
        Me.btnViewProjectReview.Text = "View in Review"
        Me.btnViewProjectReview.UseVisualStyleBackColor = True
        '
        'btnDeleteProject
        '
        Me.btnDeleteProject.AutoSize = True
        Me.btnDeleteProject.Location = New System.Drawing.Point(124, 8)
        Me.btnDeleteProject.Name = "btnDeleteProject"
        Me.btnDeleteProject.Size = New System.Drawing.Size(59, 27)
        Me.btnDeleteProject.TabIndex = 4
        Me.btnDeleteProject.Text = "Delete"
        Me.btnDeleteProject.UseVisualStyleBackColor = True
        '
        'btnEditProject
        '
        Me.btnEditProject.AutoSize = True
        Me.btnEditProject.Location = New System.Drawing.Point(65, 8)
        Me.btnEditProject.Name = "btnEditProject"
        Me.btnEditProject.Size = New System.Drawing.Size(53, 27)
        Me.btnEditProject.TabIndex = 3
        Me.btnEditProject.Text = "Edit"
        Me.btnEditProject.UseVisualStyleBackColor = True
        '
        'btnNewProject
        '
        Me.btnNewProject.AutoSize = True
        Me.btnNewProject.Location = New System.Drawing.Point(9, 8)
        Me.btnNewProject.Name = "btnNewProject"
        Me.btnNewProject.Size = New System.Drawing.Size(50, 27)
        Me.btnNewProject.TabIndex = 2
        Me.btnNewProject.Text = "New"
        Me.btnNewProject.UseVisualStyleBackColor = True
        '
        'txtSearchProject
        '
        Me.txtSearchProject.AcceptsReturn = True
        Me.txtSearchProject.Location = New System.Drawing.Point(216, 10)
        Me.txtSearchProject.Name = "txtSearchProject"
        Me.txtSearchProject.Size = New System.Drawing.Size(209, 22)
        Me.txtSearchProject.TabIndex = 1
        Me.txtSearchProject.Text = "Search"
        '
        'dgvProjectList
        '
        Me.dgvProjectList.AllowUserToAddRows = False
        Me.dgvProjectList.AllowUserToDeleteRows = False
        Me.dgvProjectList.AllowUserToResizeRows = False
        Me.dgvProjectList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvProjectList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProjectList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.CreationDate, Me.CreatedBy, Me.LastModDate, Me.ProjectFolderPath, Me.ProjectID})
        Me.dgvProjectList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvProjectList.Location = New System.Drawing.Point(0, 0)
        Me.dgvProjectList.MultiSelect = False
        Me.dgvProjectList.Name = "dgvProjectList"
        Me.dgvProjectList.ReadOnly = True
        Me.dgvProjectList.RowHeadersVisible = False
        Me.dgvProjectList.RowTemplate.Height = 24
        Me.dgvProjectList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProjectList.Size = New System.Drawing.Size(818, 623)
        Me.dgvProjectList.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Project Name"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'CreationDate
        '
        Me.CreationDate.HeaderText = "Creation Date"
        Me.CreationDate.Name = "CreationDate"
        Me.CreationDate.ReadOnly = True
        '
        'CreatedBy
        '
        Me.CreatedBy.HeaderText = "Created By"
        Me.CreatedBy.Name = "CreatedBy"
        Me.CreatedBy.ReadOnly = True
        '
        'LastModDate
        '
        Me.LastModDate.HeaderText = "Last Modified Date"
        Me.LastModDate.Name = "LastModDate"
        Me.LastModDate.ReadOnly = True
        '
        'ProjectFolderPath
        '
        Me.ProjectFolderPath.HeaderText = "Project Folder Path"
        Me.ProjectFolderPath.Name = "ProjectFolderPath"
        Me.ProjectFolderPath.ReadOnly = True
        '
        'ProjectID
        '
        Me.ProjectID.HeaderText = "Project ID"
        Me.ProjectID.Name = "ProjectID"
        Me.ProjectID.ReadOnly = True
        Me.ProjectID.Visible = False
        '
        'tabJobsList
        '
        Me.tabJobsList.Controls.Add(Me.splitJobsRestJobs)
        Me.tabJobsList.Controls.Add(Me.splitEndpointStatus)
        Me.tabJobsList.Location = New System.Drawing.Point(4, 25)
        Me.tabJobsList.Name = "tabJobsList"
        Me.tabJobsList.Padding = New System.Windows.Forms.Padding(3)
        Me.tabJobsList.Size = New System.Drawing.Size(824, 671)
        Me.tabJobsList.TabIndex = 0
        Me.tabJobsList.Text = "Job Status"
        Me.tabJobsList.UseVisualStyleBackColor = True
        '
        'splitJobsRestJobs
        '
        Me.splitJobsRestJobs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitJobsRestJobs.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.splitJobsRestJobs.IsSplitterFixed = True
        Me.splitJobsRestJobs.Location = New System.Drawing.Point(3, 3)
        Me.splitJobsRestJobs.Name = "splitJobsRestJobs"
        Me.splitJobsRestJobs.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'splitJobsRestJobs.Panel1
        '
        Me.splitJobsRestJobs.Panel1.Controls.Add(Me.txtJobsSearch)
        '
        'splitJobsRestJobs.Panel2
        '
        Me.splitJobsRestJobs.Panel2.Controls.Add(Me.dgvJobsRestJobsList)
        Me.splitJobsRestJobs.Size = New System.Drawing.Size(818, 665)
        Me.splitJobsRestJobs.SplitterDistance = 36
        Me.splitJobsRestJobs.TabIndex = 2
        '
        'txtJobsSearch
        '
        Me.txtJobsSearch.AcceptsReturn = True
        Me.txtJobsSearch.Location = New System.Drawing.Point(10, 6)
        Me.txtJobsSearch.Name = "txtJobsSearch"
        Me.txtJobsSearch.Size = New System.Drawing.Size(209, 22)
        Me.txtJobsSearch.TabIndex = 0
        Me.txtJobsSearch.Text = "Search"
        '
        'dgvJobsRestJobsList
        '
        Me.dgvJobsRestJobsList.AllowUserToAddRows = False
        Me.dgvJobsRestJobsList.AllowUserToDeleteRows = False
        Me.dgvJobsRestJobsList.AllowUserToResizeRows = False
        Me.dgvJobsRestJobsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvJobsRestJobsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvJobsRestJobsList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.jobName, Me.jobStatus, Me.jobRetry, Me.jobCancel, Me.jobType, Me.jobStart, Me.jobEnd, Me.jobID, Me.jobResultID, Me.jobEndpointStatus, Me.Result})
        Me.dgvJobsRestJobsList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvJobsRestJobsList.Location = New System.Drawing.Point(0, 0)
        Me.dgvJobsRestJobsList.Name = "dgvJobsRestJobsList"
        Me.dgvJobsRestJobsList.ReadOnly = True
        Me.dgvJobsRestJobsList.RowHeadersVisible = False
        Me.dgvJobsRestJobsList.RowTemplate.Height = 24
        Me.dgvJobsRestJobsList.Size = New System.Drawing.Size(818, 625)
        Me.dgvJobsRestJobsList.TabIndex = 0
        '
        'jobName
        '
        Me.jobName.FillWeight = 21.22523!
        Me.jobName.HeaderText = "Name"
        Me.jobName.Name = "jobName"
        Me.jobName.ReadOnly = True
        '
        'jobStatus
        '
        Me.jobStatus.DividerWidth = 5
        Me.jobStatus.FillWeight = 21.22523!
        Me.jobStatus.HeaderText = "Status"
        Me.jobStatus.Name = "jobStatus"
        Me.jobStatus.ReadOnly = True
        '
        'jobRetry
        '
        Me.jobRetry.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.jobRetry.DividerWidth = 5
        Me.jobRetry.FillWeight = 1.198895!
        Me.jobRetry.HeaderText = "Retry Job"
        Me.jobRetry.MinimumWidth = 80
        Me.jobRetry.Name = "jobRetry"
        Me.jobRetry.ReadOnly = True
        Me.jobRetry.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.jobRetry.Width = 80
        '
        'jobCancel
        '
        Me.jobCancel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.jobCancel.DividerWidth = 5
        Me.jobCancel.FillWeight = 2.0!
        Me.jobCancel.HeaderText = "Cancel Job"
        Me.jobCancel.MinimumWidth = 80
        Me.jobCancel.Name = "jobCancel"
        Me.jobCancel.ReadOnly = True
        Me.jobCancel.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.jobCancel.Width = 80
        '
        'jobType
        '
        Me.jobType.FillWeight = 21.22523!
        Me.jobType.HeaderText = "Type"
        Me.jobType.Name = "jobType"
        Me.jobType.ReadOnly = True
        '
        'jobStart
        '
        Me.jobStart.FillWeight = 21.22523!
        Me.jobStart.HeaderText = "Start"
        Me.jobStart.Name = "jobStart"
        Me.jobStart.ReadOnly = True
        '
        'jobEnd
        '
        Me.jobEnd.DividerWidth = 5
        Me.jobEnd.FillWeight = 21.22523!
        Me.jobEnd.HeaderText = "End"
        Me.jobEnd.Name = "jobEnd"
        Me.jobEnd.ReadOnly = True
        '
        'jobID
        '
        Me.jobID.HeaderText = "jobID"
        Me.jobID.Name = "jobID"
        Me.jobID.ReadOnly = True
        Me.jobID.Visible = False
        '
        'jobResultID
        '
        Me.jobResultID.HeaderText = "ResultID"
        Me.jobResultID.Name = "jobResultID"
        Me.jobResultID.ReadOnly = True
        Me.jobResultID.Visible = False
        '
        'jobEndpointStatus
        '
        Me.jobEndpointStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.jobEndpointStatus.FillWeight = 2.0!
        Me.jobEndpointStatus.HeaderText = "Endpoint Status"
        Me.jobEndpointStatus.MinimumWidth = 80
        Me.jobEndpointStatus.Name = "jobEndpointStatus"
        Me.jobEndpointStatus.ReadOnly = True
        Me.jobEndpointStatus.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.jobEndpointStatus.Width = 80
        '
        'Result
        '
        Me.Result.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Result.FillWeight = 2.0!
        Me.Result.HeaderText = "Result"
        Me.Result.MinimumWidth = 75
        Me.Result.Name = "Result"
        Me.Result.ReadOnly = True
        Me.Result.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Result.Width = 75
        '
        'splitEndpointStatus
        '
        Me.splitEndpointStatus.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitEndpointStatus.IsSplitterFixed = True
        Me.splitEndpointStatus.Location = New System.Drawing.Point(3, 3)
        Me.splitEndpointStatus.Name = "splitEndpointStatus"
        Me.splitEndpointStatus.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'splitEndpointStatus.Panel1
        '
        Me.splitEndpointStatus.Panel1.Controls.Add(Me.flowEndpointStatus)
        Me.splitEndpointStatus.Panel1MinSize = 90
        '
        'splitEndpointStatus.Panel2
        '
        Me.splitEndpointStatus.Panel2.Controls.Add(Me.dgvEndpointStatusJobTargets)
        Me.splitEndpointStatus.Size = New System.Drawing.Size(818, 665)
        Me.splitEndpointStatus.SplitterDistance = 90
        Me.splitEndpointStatus.TabIndex = 3
        '
        'flowEndpointStatus
        '
        Me.flowEndpointStatus.AutoSize = True
        Me.flowEndpointStatus.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.flowEndpointStatus.Controls.Add(Me.btnBackFromEndpointStatus)
        Me.flowEndpointStatus.Controls.Add(Me.lblJobName)
        Me.flowEndpointStatus.Controls.Add(Me.txtSearchEndpointStatus)
        Me.flowEndpointStatus.Controls.Add(Me.lblepStatusTotal)
        Me.flowEndpointStatus.Controls.Add(Me.lblepStatusInProgress)
        Me.flowEndpointStatus.Controls.Add(Me.lblepstatusFailed)
        Me.flowEndpointStatus.Controls.Add(Me.lblepstatusSuccessful)
        Me.flowEndpointStatus.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flowEndpointStatus.Location = New System.Drawing.Point(0, 0)
        Me.flowEndpointStatus.Name = "flowEndpointStatus"
        Me.flowEndpointStatus.Size = New System.Drawing.Size(818, 90)
        Me.flowEndpointStatus.TabIndex = 0
        '
        'btnBackFromEndpointStatus
        '
        Me.btnBackFromEndpointStatus.Location = New System.Drawing.Point(3, 3)
        Me.btnBackFromEndpointStatus.Name = "btnBackFromEndpointStatus"
        Me.btnBackFromEndpointStatus.Size = New System.Drawing.Size(115, 29)
        Me.btnBackFromEndpointStatus.TabIndex = 20
        Me.btnBackFromEndpointStatus.Text = "Back To Jobs"
        Me.btnBackFromEndpointStatus.UseVisualStyleBackColor = True
        '
        'lblJobName
        '
        Me.lblJobName.AutoSize = True
        Me.flowEndpointStatus.SetFlowBreak(Me.lblJobName, True)
        Me.lblJobName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJobName.Location = New System.Drawing.Point(124, 0)
        Me.lblJobName.Name = "lblJobName"
        Me.lblJobName.Size = New System.Drawing.Size(102, 25)
        Me.lblJobName.TabIndex = 21
        Me.lblJobName.Text = "Job Name"
        '
        'txtSearchEndpointStatus
        '
        Me.txtSearchEndpointStatus.AcceptsReturn = True
        Me.txtSearchEndpointStatus.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.flowEndpointStatus.SetFlowBreak(Me.txtSearchEndpointStatus, True)
        Me.txtSearchEndpointStatus.Location = New System.Drawing.Point(3, 38)
        Me.txtSearchEndpointStatus.Name = "txtSearchEndpointStatus"
        Me.txtSearchEndpointStatus.Size = New System.Drawing.Size(209, 22)
        Me.txtSearchEndpointStatus.TabIndex = 22
        Me.txtSearchEndpointStatus.Text = "Search"
        '
        'lblepStatusTotal
        '
        Me.lblepStatusTotal.AutoSize = True
        Me.lblepStatusTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblepStatusTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblepStatusTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblepStatusTotal.Location = New System.Drawing.Point(3, 63)
        Me.lblepStatusTotal.Name = "lblepStatusTotal"
        Me.lblepStatusTotal.Size = New System.Drawing.Size(58, 22)
        Me.lblepStatusTotal.TabIndex = 16
        Me.lblepStatusTotal.Text = "Total: "
        '
        'lblepStatusInProgress
        '
        Me.lblepStatusInProgress.AutoSize = True
        Me.lblepStatusInProgress.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblepStatusInProgress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblepStatusInProgress.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblepStatusInProgress.Location = New System.Drawing.Point(67, 63)
        Me.lblepStatusInProgress.Name = "lblepStatusInProgress"
        Me.lblepStatusInProgress.Size = New System.Drawing.Size(107, 22)
        Me.lblepStatusInProgress.TabIndex = 17
        Me.lblepStatusInProgress.Text = "In Progress: "
        '
        'lblepstatusFailed
        '
        Me.lblepstatusFailed.AutoSize = True
        Me.lblepstatusFailed.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblepstatusFailed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblepstatusFailed.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblepstatusFailed.Location = New System.Drawing.Point(180, 63)
        Me.lblepstatusFailed.Name = "lblepstatusFailed"
        Me.lblepstatusFailed.Size = New System.Drawing.Size(66, 22)
        Me.lblepstatusFailed.TabIndex = 18
        Me.lblepstatusFailed.Text = "Failed: "
        '
        'lblepstatusSuccessful
        '
        Me.lblepstatusSuccessful.AutoSize = True
        Me.lblepstatusSuccessful.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblepstatusSuccessful.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblepstatusSuccessful.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblepstatusSuccessful.Location = New System.Drawing.Point(252, 63)
        Me.lblepstatusSuccessful.Name = "lblepstatusSuccessful"
        Me.lblepstatusSuccessful.Size = New System.Drawing.Size(104, 22)
        Me.lblepstatusSuccessful.TabIndex = 19
        Me.lblepstatusSuccessful.Text = "Successful: "
        '
        'dgvEndpointStatusJobTargets
        '
        Me.dgvEndpointStatusJobTargets.AllowUserToAddRows = False
        Me.dgvEndpointStatusJobTargets.AllowUserToDeleteRows = False
        Me.dgvEndpointStatusJobTargets.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvEndpointStatusJobTargets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEndpointStatusJobTargets.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.endpoint, Me.Start, Me.Status, Me.Hits, Me.EndPointID, Me.Action, Me.Review})
        Me.dgvEndpointStatusJobTargets.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvEndpointStatusJobTargets.Location = New System.Drawing.Point(0, 0)
        Me.dgvEndpointStatusJobTargets.Name = "dgvEndpointStatusJobTargets"
        Me.dgvEndpointStatusJobTargets.ReadOnly = True
        Me.dgvEndpointStatusJobTargets.RowHeadersVisible = False
        Me.dgvEndpointStatusJobTargets.RowTemplate.Height = 24
        Me.dgvEndpointStatusJobTargets.Size = New System.Drawing.Size(818, 571)
        Me.dgvEndpointStatusJobTargets.TabIndex = 9
        '
        'endpoint
        '
        Me.endpoint.FillWeight = 59.53934!
        Me.endpoint.HeaderText = "Endpoint"
        Me.endpoint.Name = "endpoint"
        Me.endpoint.ReadOnly = True
        '
        'Start
        '
        Me.Start.FillWeight = 59.53934!
        Me.Start.HeaderText = "Start"
        Me.Start.Name = "Start"
        Me.Start.ReadOnly = True
        '
        'Status
        '
        Me.Status.FillWeight = 59.53934!
        Me.Status.HeaderText = "Status"
        Me.Status.Name = "Status"
        Me.Status.ReadOnly = True
        '
        'Hits
        '
        Me.Hits.FillWeight = 59.53934!
        Me.Hits.HeaderText = "Hits"
        Me.Hits.Name = "Hits"
        Me.Hits.ReadOnly = True
        '
        'EndPointID
        '
        Me.EndPointID.HeaderText = "EndPointID"
        Me.EndPointID.Name = "EndPointID"
        Me.EndPointID.ReadOnly = True
        Me.EndPointID.Visible = False
        '
        'Action
        '
        Me.Action.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Action.FillWeight = 1.0!
        Me.Action.HeaderText = "Action"
        Me.Action.MinimumWidth = 80
        Me.Action.Name = "Action"
        Me.Action.ReadOnly = True
        Me.Action.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Action.Width = 80
        '
        'Review
        '
        Me.Review.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Review.FillWeight = 1.0!
        Me.Review.HeaderText = "Review"
        Me.Review.MinimumWidth = 80
        Me.Review.Name = "Review"
        Me.Review.ReadOnly = True
        Me.Review.Width = 80
        '
        'tabAlerts
        '
        Me.tabAlerts.Controls.Add(Me.splitAlerts)
        Me.tabAlerts.Location = New System.Drawing.Point(4, 25)
        Me.tabAlerts.Name = "tabAlerts"
        Me.tabAlerts.Size = New System.Drawing.Size(824, 671)
        Me.tabAlerts.TabIndex = 3
        Me.tabAlerts.Text = "Alerts"
        Me.tabAlerts.UseVisualStyleBackColor = True
        '
        'splitAlerts
        '
        Me.splitAlerts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitAlerts.Location = New System.Drawing.Point(0, 0)
        Me.splitAlerts.Name = "splitAlerts"
        Me.splitAlerts.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'splitAlerts.Panel1
        '
        Me.splitAlerts.Panel1.Controls.Add(Me.dgvAlerts)
        '
        'splitAlerts.Panel2
        '
        Me.splitAlerts.Panel2.Controls.Add(Me.tblAlertBreakdown)
        Me.splitAlerts.Size = New System.Drawing.Size(824, 671)
        Me.splitAlerts.SplitterDistance = 277
        Me.splitAlerts.TabIndex = 0
        '
        'dgvAlerts
        '
        Me.dgvAlerts.AllowUserToAddRows = False
        Me.dgvAlerts.AllowUserToDeleteRows = False
        Me.dgvAlerts.AllowUserToResizeRows = False
        Me.dgvAlerts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvAlerts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAlerts.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.artifactName, Me.createDate, Me.severity, Me.target, Me.source, Me.project, Me.confidence, Me.threatScore})
        Me.dgvAlerts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvAlerts.Location = New System.Drawing.Point(0, 0)
        Me.dgvAlerts.Name = "dgvAlerts"
        Me.dgvAlerts.ReadOnly = True
        Me.dgvAlerts.RowHeadersVisible = False
        Me.dgvAlerts.RowTemplate.Height = 24
        Me.dgvAlerts.Size = New System.Drawing.Size(824, 277)
        Me.dgvAlerts.TabIndex = 0
        '
        'artifactName
        '
        Me.artifactName.HeaderText = "Name"
        Me.artifactName.Name = "artifactName"
        Me.artifactName.ReadOnly = True
        '
        'createDate
        '
        Me.createDate.HeaderText = "Date"
        Me.createDate.Name = "createDate"
        Me.createDate.ReadOnly = True
        '
        'severity
        '
        Me.severity.HeaderText = "Severity"
        Me.severity.Name = "severity"
        Me.severity.ReadOnly = True
        '
        'target
        '
        Me.target.HeaderText = "Target"
        Me.target.Name = "target"
        Me.target.ReadOnly = True
        '
        'source
        '
        Me.source.HeaderText = "Source"
        Me.source.Name = "source"
        Me.source.ReadOnly = True
        '
        'project
        '
        Me.project.HeaderText = "Project"
        Me.project.Name = "project"
        Me.project.ReadOnly = True
        '
        'confidence
        '
        Me.confidence.HeaderText = "Confidence"
        Me.confidence.Name = "confidence"
        Me.confidence.ReadOnly = True
        '
        'threatScore
        '
        Me.threatScore.HeaderText = "Threat Score"
        Me.threatScore.Name = "threatScore"
        Me.threatScore.ReadOnly = True
        '
        'tblAlertBreakdown
        '
        Me.tblAlertBreakdown.ColumnCount = 2
        Me.tblAlertBreakdown.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 210.0!))
        Me.tblAlertBreakdown.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblAlertBreakdown.Controls.Add(Me.flowResponseTime, 1, 2)
        Me.tblAlertBreakdown.Controls.Add(Me.lblResponseTime, 0, 2)
        Me.tblAlertBreakdown.Controls.Add(Me.lblTotalNumberofResponses, 0, 1)
        Me.tblAlertBreakdown.Controls.Add(Me.flowTotalResponses, 1, 1)
        Me.tblAlertBreakdown.Controls.Add(Me.lblTotalNumberAlerts, 0, 0)
        Me.tblAlertBreakdown.Controls.Add(Me.flowAlertBreakdown, 1, 0)
        Me.tblAlertBreakdown.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblAlertBreakdown.Location = New System.Drawing.Point(0, 0)
        Me.tblAlertBreakdown.Name = "tblAlertBreakdown"
        Me.tblAlertBreakdown.RowCount = 3
        Me.tblAlertBreakdown.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tblAlertBreakdown.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.tblAlertBreakdown.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.tblAlertBreakdown.Size = New System.Drawing.Size(824, 390)
        Me.tblAlertBreakdown.TabIndex = 4
        '
        'flowResponseTime
        '
        Me.flowResponseTime.AutoSize = True
        Me.flowResponseTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.flowResponseTime.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flowResponseTime.Location = New System.Drawing.Point(213, 262)
        Me.flowResponseTime.Name = "flowResponseTime"
        Me.flowResponseTime.Size = New System.Drawing.Size(608, 125)
        Me.flowResponseTime.TabIndex = 10
        '
        'lblResponseTime
        '
        Me.lblResponseTime.AutoSize = True
        Me.lblResponseTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblResponseTime.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblResponseTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResponseTime.Location = New System.Drawing.Point(3, 259)
        Me.lblResponseTime.Name = "lblResponseTime"
        Me.lblResponseTime.Size = New System.Drawing.Size(204, 131)
        Me.lblResponseTime.TabIndex = 9
        Me.lblResponseTime.Text = "Response Time:"
        '
        'lblTotalNumberofResponses
        '
        Me.lblTotalNumberofResponses.AutoSize = True
        Me.lblTotalNumberofResponses.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalNumberofResponses.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTotalNumberofResponses.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalNumberofResponses.Location = New System.Drawing.Point(3, 129)
        Me.lblTotalNumberofResponses.Name = "lblTotalNumberofResponses"
        Me.lblTotalNumberofResponses.Size = New System.Drawing.Size(204, 130)
        Me.lblTotalNumberofResponses.TabIndex = 8
        Me.lblTotalNumberofResponses.Text = "Total Number of Responses:"
        '
        'flowTotalResponses
        '
        Me.flowTotalResponses.AutoSize = True
        Me.flowTotalResponses.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.flowTotalResponses.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flowTotalResponses.Location = New System.Drawing.Point(213, 132)
        Me.flowTotalResponses.Name = "flowTotalResponses"
        Me.flowTotalResponses.Size = New System.Drawing.Size(608, 124)
        Me.flowTotalResponses.TabIndex = 7
        '
        'lblTotalNumberAlerts
        '
        Me.lblTotalNumberAlerts.AutoSize = True
        Me.lblTotalNumberAlerts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalNumberAlerts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTotalNumberAlerts.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalNumberAlerts.Location = New System.Drawing.Point(3, 0)
        Me.lblTotalNumberAlerts.Name = "lblTotalNumberAlerts"
        Me.lblTotalNumberAlerts.Size = New System.Drawing.Size(204, 129)
        Me.lblTotalNumberAlerts.TabIndex = 5
        Me.lblTotalNumberAlerts.Text = "Total Number Of Alerts:"
        '
        'flowAlertBreakdown
        '
        Me.flowAlertBreakdown.AutoSize = True
        Me.flowAlertBreakdown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.flowAlertBreakdown.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flowAlertBreakdown.Location = New System.Drawing.Point(213, 3)
        Me.flowAlertBreakdown.Name = "flowAlertBreakdown"
        Me.flowAlertBreakdown.Size = New System.Drawing.Size(608, 123)
        Me.flowAlertBreakdown.TabIndex = 4
        '
        'tabJobExecution
        '
        Me.tabJobExecution.Controls.Add(Me.lblJobStatus)
        Me.tabJobExecution.Controls.Add(Me.btnShowJSON)
        Me.tabJobExecution.Controls.Add(Me.btnLoadFromBox)
        Me.tabJobExecution.Controls.Add(Me.btnSaveAsBox)
        Me.tabJobExecution.Controls.Add(Me.btnExecute)
        Me.tabJobExecution.Controls.Add(Me.tabSubMenu)
        Me.tabJobExecution.Location = New System.Drawing.Point(4, 28)
        Me.tabJobExecution.Margin = New System.Windows.Forms.Padding(4)
        Me.tabJobExecution.Name = "tabJobExecution"
        Me.tabJobExecution.Padding = New System.Windows.Forms.Padding(4)
        Me.tabJobExecution.Size = New System.Drawing.Size(832, 700)
        Me.tabJobExecution.TabIndex = 0
        Me.tabJobExecution.Text = "JobsAPI Execution"
        Me.tabJobExecution.UseVisualStyleBackColor = True
        '
        'lblJobStatus
        '
        Me.lblJobStatus.AutoSize = True
        Me.lblJobStatus.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblJobStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJobStatus.Location = New System.Drawing.Point(4, 676)
        Me.lblJobStatus.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblJobStatus.MaximumSize = New System.Drawing.Size(667, 0)
        Me.lblJobStatus.MinimumSize = New System.Drawing.Size(667, 0)
        Me.lblJobStatus.Name = "lblJobStatus"
        Me.lblJobStatus.Size = New System.Drawing.Size(667, 20)
        Me.lblJobStatus.TabIndex = 33
        Me.lblJobStatus.Text = "lblJobStatus"
        '
        'btnShowJSON
        '
        Me.btnShowJSON.Location = New System.Drawing.Point(280, 604)
        Me.btnShowJSON.Margin = New System.Windows.Forms.Padding(4)
        Me.btnShowJSON.Name = "btnShowJSON"
        Me.btnShowJSON.Size = New System.Drawing.Size(100, 28)
        Me.btnShowJSON.TabIndex = 23
        Me.btnShowJSON.Text = "Show JSON"
        Me.btnShowJSON.UseVisualStyleBackColor = True
        '
        'btnLoadFromBox
        '
        Me.btnLoadFromBox.Location = New System.Drawing.Point(425, 604)
        Me.btnLoadFromBox.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLoadFromBox.Name = "btnLoadFromBox"
        Me.btnLoadFromBox.Size = New System.Drawing.Size(120, 28)
        Me.btnLoadFromBox.TabIndex = 22
        Me.btnLoadFromBox.Text = "Load From Box"
        Me.btnLoadFromBox.UseVisualStyleBackColor = True
        '
        'btnSaveAsBox
        '
        Me.btnSaveAsBox.Location = New System.Drawing.Point(581, 604)
        Me.btnSaveAsBox.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSaveAsBox.Name = "btnSaveAsBox"
        Me.btnSaveAsBox.Size = New System.Drawing.Size(100, 28)
        Me.btnSaveAsBox.TabIndex = 21
        Me.btnSaveAsBox.Text = "Save as Box"
        Me.btnSaveAsBox.UseVisualStyleBackColor = True
        '
        'tabFireEye
        '
        Me.tabFireEye.Controls.Add(Me.txtFireEyeMalwareMD5)
        Me.tabFireEye.Controls.Add(Me.Label47)
        Me.tabFireEye.Controls.Add(Me.lblFEStatus)
        Me.tabFireEye.Controls.Add(Me.txtFELink)
        Me.tabFireEye.Controls.Add(Me.Label37)
        Me.tabFireEye.Controls.Add(Me.Label34)
        Me.tabFireEye.Controls.Add(Me.cmbFEAlertType)
        Me.tabFireEye.Controls.Add(Me.txtFETarget)
        Me.tabFireEye.Controls.Add(Me.Label33)
        Me.tabFireEye.Controls.Add(Me.btn_FEEvent)
        Me.tabFireEye.Location = New System.Drawing.Point(4, 28)
        Me.tabFireEye.Margin = New System.Windows.Forms.Padding(4)
        Me.tabFireEye.Name = "tabFireEye"
        Me.tabFireEye.Padding = New System.Windows.Forms.Padding(4)
        Me.tabFireEye.Size = New System.Drawing.Size(832, 700)
        Me.tabFireEye.TabIndex = 4
        Me.tabFireEye.Text = "FireEye"
        Me.tabFireEye.UseVisualStyleBackColor = True
        '
        'txtFireEyeMalwareMD5
        '
        Me.txtFireEyeMalwareMD5.Location = New System.Drawing.Point(141, 82)
        Me.txtFireEyeMalwareMD5.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFireEyeMalwareMD5.Name = "txtFireEyeMalwareMD5"
        Me.txtFireEyeMalwareMD5.Size = New System.Drawing.Size(233, 22)
        Me.txtFireEyeMalwareMD5.TabIndex = 34
        Me.txtFireEyeMalwareMD5.Text = "47f9fdc617f8c98a6732be534d8dbe9a"
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Location = New System.Drawing.Point(36, 85)
        Me.Label47.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(97, 17)
        Me.Label47.TabIndex = 33
        Me.Label47.Text = "Malware MD5:"
        '
        'lblFEStatus
        '
        Me.lblFEStatus.AutoSize = True
        Me.lblFEStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFEStatus.Location = New System.Drawing.Point(56, 162)
        Me.lblFEStatus.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFEStatus.Name = "lblFEStatus"
        Me.lblFEStatus.Size = New System.Drawing.Size(95, 20)
        Me.lblFEStatus.TabIndex = 32
        Me.lblFEStatus.Text = "lblFEStatus"
        '
        'txtFELink
        '
        Me.txtFELink.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFELink.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtFELink.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFELink.Location = New System.Drawing.Point(14, 290)
        Me.txtFELink.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFELink.Name = "txtFELink"
        Me.txtFELink.ReadOnly = True
        Me.txtFELink.Size = New System.Drawing.Size(720, 19)
        Me.txtFELink.TabIndex = 7
        Me.txtFELink.TabStop = False
        Me.txtFELink.Text = "http://fedeploycheck.fireeye.com/appliance-test/test-infection.exe"
        '
        'Label37
        '
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(8, 211)
        Me.Label37.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(450, 64)
        Me.Label37.TabIndex = 6
        Me.Label37.Text = "To generate a verified hit from a test FireEye ThreatScan download the following " & _
    "EXE to your target, or enter a Custom MD5 Hash above." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(56, 54)
        Me.Label34.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(77, 17)
        Me.Label34.TabIndex = 5
        Me.Label34.Text = "Alert Type:"
        '
        'cmbFEAlertType
        '
        Me.cmbFEAlertType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFEAlertType.FormattingEnabled = True
        Me.cmbFEAlertType.Items.AddRange(New Object() {"malware-object", "malware-callback", "web-infection", "domain-match", "infection-match"})
        Me.cmbFEAlertType.Location = New System.Drawing.Point(141, 50)
        Me.cmbFEAlertType.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbFEAlertType.Name = "cmbFEAlertType"
        Me.cmbFEAlertType.Size = New System.Drawing.Size(233, 24)
        Me.cmbFEAlertType.TabIndex = 4
        '
        'txtFETarget
        '
        Me.txtFETarget.Location = New System.Drawing.Point(141, 18)
        Me.txtFETarget.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFETarget.Name = "txtFETarget"
        Me.txtFETarget.Size = New System.Drawing.Size(233, 22)
        Me.txtFETarget.TabIndex = 3
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(11, 22)
        Me.Label33.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(122, 17)
        Me.Label33.TabIndex = 2
        Me.Label33.Text = "Target Hostname:"
        '
        'btn_FEEvent
        '
        Me.btn_FEEvent.Location = New System.Drawing.Point(141, 118)
        Me.btn_FEEvent.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_FEEvent.Name = "btn_FEEvent"
        Me.btn_FEEvent.Size = New System.Drawing.Size(156, 28)
        Me.btn_FEEvent.TabIndex = 0
        Me.btn_FEEvent.Text = "Send FireEye Event"
        Me.btn_FEEvent.UseVisualStyleBackColor = True
        '
        'tabPANW
        '
        Me.tabPANW.Controls.Add(Me.txtPANWMalwareMD5)
        Me.tabPANW.Controls.Add(Me.Label48)
        Me.tabPANW.Controls.Add(Me.PictureBox2)
        Me.tabPANW.Controls.Add(Me.txtPANWSim)
        Me.tabPANW.Controls.Add(Me.TextBox4)
        Me.tabPANW.Controls.Add(Me.Label45)
        Me.tabPANW.Controls.Add(Me.lblPANWStatus)
        Me.tabPANW.Controls.Add(Me.GroupBox5)
        Me.tabPANW.Controls.Add(Me.panwPort)
        Me.tabPANW.Controls.Add(Me.Label30)
        Me.tabPANW.Controls.Add(Me.Label35)
        Me.tabPANW.Controls.Add(Me.cmbPANWAlert)
        Me.tabPANW.Controls.Add(Me.txtPANWTarget)
        Me.tabPANW.Controls.Add(Me.Label36)
        Me.tabPANW.Controls.Add(Me.btnPANWSend)
        Me.tabPANW.Location = New System.Drawing.Point(4, 28)
        Me.tabPANW.Margin = New System.Windows.Forms.Padding(4)
        Me.tabPANW.Name = "tabPANW"
        Me.tabPANW.Size = New System.Drawing.Size(832, 700)
        Me.tabPANW.TabIndex = 5
        Me.tabPANW.Text = "PANW"
        Me.tabPANW.UseVisualStyleBackColor = True
        '
        'txtPANWMalwareMD5
        '
        Me.txtPANWMalwareMD5.Location = New System.Drawing.Point(173, 118)
        Me.txtPANWMalwareMD5.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPANWMalwareMD5.Name = "txtPANWMalwareMD5"
        Me.txtPANWMalwareMD5.Size = New System.Drawing.Size(233, 22)
        Me.txtPANWMalwareMD5.TabIndex = 38
        Me.txtPANWMalwareMD5.Text = "47f9fdc617f8c98a6732be534d8dbe9a"
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Location = New System.Drawing.Point(44, 122)
        Me.Label48.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(97, 17)
        Me.Label48.TabIndex = 37
        Me.Label48.Text = "Malware MD5:"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(59, 383)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(516, 147)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 35
        Me.PictureBox2.TabStop = False
        '
        'txtPANWSim
        '
        Me.txtPANWSim.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPANWSim.Location = New System.Drawing.Point(472, 150)
        Me.txtPANWSim.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPANWSim.Multiline = True
        Me.txtPANWSim.Name = "txtPANWSim"
        Me.txtPANWSim.ReadOnly = True
        Me.txtPANWSim.Size = New System.Drawing.Size(272, 230)
        Me.txtPANWSim.TabIndex = 34
        Me.txtPANWSim.Text = resources.GetString("txtPANWSim.Text")
        '
        'TextBox4
        '
        Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(37, 336)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(427, 16)
        Me.TextBox4.TabIndex = 33
        Me.TextBox4.TabStop = False
        Me.TextBox4.Text = "http://fedeploycheck.fireeye.com/appliance-test/test-infection.exe"
        '
        'Label45
        '
        Me.Label45.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.Location = New System.Drawing.Point(43, 269)
        Me.Label45.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(400, 63)
        Me.Label45.TabIndex = 32
        Me.Label45.Text = "To generate a verified hit from a test PANW" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " ThreatScan download the following E" & _
    "XE to your target, or enter a custom MD5 Hash above." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblPANWStatus
        '
        Me.lblPANWStatus.AutoSize = True
        Me.lblPANWStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPANWStatus.Location = New System.Drawing.Point(56, 215)
        Me.lblPANWStatus.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPANWStatus.Name = "lblPANWStatus"
        Me.lblPANWStatus.Size = New System.Drawing.Size(124, 20)
        Me.lblPANWStatus.TabIndex = 31
        Me.lblPANWStatus.Text = "lblPANWStatus"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.panw_sim_port)
        Me.GroupBox5.Controls.Add(Me.Label44)
        Me.GroupBox5.Controls.Add(Me.lblwildfirestatus)
        Me.GroupBox5.Controls.Add(Me.btn_WildfireStart)
        Me.GroupBox5.Location = New System.Drawing.Point(475, 17)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox5.Size = New System.Drawing.Size(272, 126)
        Me.GroupBox5.TabIndex = 24
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "PANW Wildfire Sim"
        '
        'panw_sim_port
        '
        Me.panw_sim_port.Location = New System.Drawing.Point(136, 28)
        Me.panw_sim_port.Margin = New System.Windows.Forms.Padding(4)
        Me.panw_sim_port.Maximum = New Decimal(New Integer() {65535, 0, 0, 0})
        Me.panw_sim_port.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.panw_sim_port.Name = "panw_sim_port"
        Me.panw_sim_port.Size = New System.Drawing.Size(128, 22)
        Me.panw_sim_port.TabIndex = 24
        Me.panw_sim_port.Value = New Decimal(New Integer() {8449, 0, 0, 0})
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Location = New System.Drawing.Point(8, 31)
        Me.Label44.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(116, 17)
        Me.Label44.TabIndex = 23
        Me.Label44.Text = "Wildfire Sim Port:"
        '
        'lblwildfirestatus
        '
        Me.lblwildfirestatus.AutoSize = True
        Me.lblwildfirestatus.Location = New System.Drawing.Point(24, 101)
        Me.lblwildfirestatus.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblwildfirestatus.Name = "lblwildfirestatus"
        Me.lblwildfirestatus.Size = New System.Drawing.Size(206, 17)
        Me.lblwildfirestatus.TabIndex = 22
        Me.lblwildfirestatus.Text = "Wildfire Sim Status: Not Started"
        '
        'btn_WildfireStart
        '
        Me.btn_WildfireStart.Location = New System.Drawing.Point(43, 63)
        Me.btn_WildfireStart.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_WildfireStart.Name = "btn_WildfireStart"
        Me.btn_WildfireStart.Size = New System.Drawing.Size(175, 28)
        Me.btn_WildfireStart.TabIndex = 21
        Me.btn_WildfireStart.Text = "Start Wildfire Sim"
        Me.btn_WildfireStart.UseVisualStyleBackColor = True
        '
        'panwPort
        '
        Me.panwPort.Location = New System.Drawing.Point(173, 20)
        Me.panwPort.Margin = New System.Windows.Forms.Padding(4)
        Me.panwPort.Maximum = New Decimal(New Integer() {65535, 0, 0, 0})
        Me.panwPort.Name = "panwPort"
        Me.panwPort.Size = New System.Drawing.Size(160, 22)
        Me.panwPort.TabIndex = 11
        Me.panwPort.Value = New Decimal(New Integer() {514, 0, 0, 0})
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(11, 22)
        Me.Label30.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(160, 17)
        Me.Label30.TabIndex = 10
        Me.Label30.Text = "R1 PANW Listener Port:"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(56, 86)
        Me.Label35.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(77, 17)
        Me.Label35.TabIndex = 9
        Me.Label35.Text = "Alert Type:"
        '
        'cmbPANWAlert
        '
        Me.cmbPANWAlert.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPANWAlert.FormattingEnabled = True
        Me.cmbPANWAlert.Items.AddRange(New Object() {"WILDFIRE", "VIRUS", "FILE", "FLOOD", "URL"})
        Me.cmbPANWAlert.Location = New System.Drawing.Point(173, 82)
        Me.cmbPANWAlert.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbPANWAlert.Name = "cmbPANWAlert"
        Me.cmbPANWAlert.Size = New System.Drawing.Size(233, 24)
        Me.cmbPANWAlert.TabIndex = 8
        '
        'txtPANWTarget
        '
        Me.txtPANWTarget.Location = New System.Drawing.Point(173, 50)
        Me.txtPANWTarget.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPANWTarget.Name = "txtPANWTarget"
        Me.txtPANWTarget.Size = New System.Drawing.Size(233, 22)
        Me.txtPANWTarget.TabIndex = 7
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(11, 54)
        Me.Label36.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(122, 17)
        Me.Label36.TabIndex = 6
        Me.Label36.Text = "Target Hostname:"
        '
        'btnPANWSend
        '
        Me.btnPANWSend.Location = New System.Drawing.Point(173, 150)
        Me.btnPANWSend.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPANWSend.Name = "btnPANWSend"
        Me.btnPANWSend.Size = New System.Drawing.Size(185, 28)
        Me.btnPANWSend.TabIndex = 0
        Me.btnPANWSend.Text = "Send PANW SysLog Alert"
        Me.btnPANWSend.UseVisualStyleBackColor = True
        '
        'tabXPS
        '
        Me.tabXPS.Controls.Add(Me.txtXPSMalwareMD5)
        Me.tabXPS.Controls.Add(Me.Label46)
        Me.tabXPS.Controls.Add(Me.lblXPSStatus)
        Me.tabXPS.Controls.Add(Me.txtXPSMalware)
        Me.tabXPS.Controls.Add(Me.Label42)
        Me.tabXPS.Controls.Add(Me.PictureBox1)
        Me.tabXPS.Controls.Add(Me.txtXPSSIM)
        Me.tabXPS.Controls.Add(Me.txtFELink2)
        Me.tabXPS.Controls.Add(Me.Label39)
        Me.tabXPS.Controls.Add(Me.GroupBox3)
        Me.tabXPS.Controls.Add(Me.Label41)
        Me.tabXPS.Controls.Add(Me.cmbXPSSeverity)
        Me.tabXPS.Controls.Add(Me.xpsPort)
        Me.tabXPS.Controls.Add(Me.Label38)
        Me.tabXPS.Controls.Add(Me.txtXPSTarget)
        Me.tabXPS.Controls.Add(Me.Label40)
        Me.tabXPS.Controls.Add(Me.btnXPSSend)
        Me.tabXPS.Location = New System.Drawing.Point(4, 28)
        Me.tabXPS.Margin = New System.Windows.Forms.Padding(4)
        Me.tabXPS.Name = "tabXPS"
        Me.tabXPS.Padding = New System.Windows.Forms.Padding(4)
        Me.tabXPS.Size = New System.Drawing.Size(832, 700)
        Me.tabXPS.TabIndex = 6
        Me.tabXPS.Text = "XPS"
        Me.tabXPS.UseVisualStyleBackColor = True
        '
        'txtXPSMalwareMD5
        '
        Me.txtXPSMalwareMD5.Location = New System.Drawing.Point(173, 150)
        Me.txtXPSMalwareMD5.Margin = New System.Windows.Forms.Padding(4)
        Me.txtXPSMalwareMD5.Name = "txtXPSMalwareMD5"
        Me.txtXPSMalwareMD5.Size = New System.Drawing.Size(233, 22)
        Me.txtXPSMalwareMD5.TabIndex = 32
        Me.txtXPSMalwareMD5.Text = "47f9fdc617f8c98a6732be534d8dbe9a"
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Location = New System.Drawing.Point(44, 154)
        Me.Label46.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(97, 17)
        Me.Label46.TabIndex = 31
        Me.Label46.Text = "Malware MD5:"
        '
        'lblXPSStatus
        '
        Me.lblXPSStatus.AutoSize = True
        Me.lblXPSStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblXPSStatus.Location = New System.Drawing.Point(44, 228)
        Me.lblXPSStatus.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblXPSStatus.Name = "lblXPSStatus"
        Me.lblXPSStatus.Size = New System.Drawing.Size(107, 20)
        Me.lblXPSStatus.TabIndex = 30
        Me.lblXPSStatus.Text = "lblXPSStatus"
        '
        'txtXPSMalware
        '
        Me.txtXPSMalware.Location = New System.Drawing.Point(173, 118)
        Me.txtXPSMalware.Margin = New System.Windows.Forms.Padding(4)
        Me.txtXPSMalware.Name = "txtXPSMalware"
        Me.txtXPSMalware.Size = New System.Drawing.Size(233, 22)
        Me.txtXPSMalware.TabIndex = 29
        Me.txtXPSMalware.Text = "Super.Evil.Malware"
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Location = New System.Drawing.Point(44, 122)
        Me.Label42.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(105, 17)
        Me.Label42.TabIndex = 28
        Me.Label42.Text = "Malware Name:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(76, 388)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(502, 168)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 27
        Me.PictureBox1.TabStop = False
        '
        'txtXPSSIM
        '
        Me.txtXPSSIM.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtXPSSIM.Location = New System.Drawing.Point(473, 150)
        Me.txtXPSSIM.Margin = New System.Windows.Forms.Padding(4)
        Me.txtXPSSIM.Multiline = True
        Me.txtXPSSIM.Name = "txtXPSSIM"
        Me.txtXPSSIM.ReadOnly = True
        Me.txtXPSSIM.Size = New System.Drawing.Size(272, 230)
        Me.txtXPSSIM.TabIndex = 26
        Me.txtXPSSIM.Text = resources.GetString("txtXPSSIM.Text")
        '
        'txtFELink2
        '
        Me.txtFELink2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFELink2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtFELink2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFELink2.Location = New System.Drawing.Point(38, 337)
        Me.txtFELink2.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFELink2.Name = "txtFELink2"
        Me.txtFELink2.ReadOnly = True
        Me.txtFELink2.Size = New System.Drawing.Size(427, 16)
        Me.txtFELink2.TabIndex = 25
        Me.txtFELink2.TabStop = False
        Me.txtFELink2.Text = "http://fedeploycheck.fireeye.com/appliance-test/test-infection.exe"
        '
        'Label39
        '
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.Location = New System.Drawing.Point(44, 262)
        Me.Label39.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(400, 71)
        Me.Label39.TabIndex = 24
        Me.Label39.Text = "To generate a verified hit from a test XPS ThreatScan download the following EXE " & _
    "to your target, or enter a custom MD5 hash above." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.xps_sim_Port)
        Me.GroupBox3.Controls.Add(Me.Label43)
        Me.GroupBox3.Controls.Add(Me.lbldemoxpsstatus)
        Me.GroupBox3.Controls.Add(Me.btnStartXPSListener)
        Me.GroupBox3.Location = New System.Drawing.Point(473, 17)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(272, 126)
        Me.GroupBox3.TabIndex = 23
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "XPS CP Sim"
        '
        'xps_sim_Port
        '
        Me.xps_sim_Port.Location = New System.Drawing.Point(136, 28)
        Me.xps_sim_Port.Margin = New System.Windows.Forms.Padding(4)
        Me.xps_sim_Port.Maximum = New Decimal(New Integer() {65535, 0, 0, 0})
        Me.xps_sim_Port.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.xps_sim_Port.Name = "xps_sim_Port"
        Me.xps_sim_Port.Size = New System.Drawing.Size(128, 22)
        Me.xps_sim_Port.TabIndex = 24
        Me.xps_sim_Port.Value = New Decimal(New Integer() {8448, 0, 0, 0})
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Location = New System.Drawing.Point(8, 31)
        Me.Label43.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(118, 17)
        Me.Label43.TabIndex = 23
        Me.Label43.Text = "XPS CP Sim Port:"
        '
        'lbldemoxpsstatus
        '
        Me.lbldemoxpsstatus.AutoSize = True
        Me.lbldemoxpsstatus.Location = New System.Drawing.Point(24, 101)
        Me.lbldemoxpsstatus.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbldemoxpsstatus.Name = "lbldemoxpsstatus"
        Me.lbldemoxpsstatus.Size = New System.Drawing.Size(208, 17)
        Me.lbldemoxpsstatus.TabIndex = 22
        Me.lbldemoxpsstatus.Text = "XPS CP Sim Status: Not Started"
        '
        'btnStartXPSListener
        '
        Me.btnStartXPSListener.Location = New System.Drawing.Point(43, 63)
        Me.btnStartXPSListener.Margin = New System.Windows.Forms.Padding(4)
        Me.btnStartXPSListener.Name = "btnStartXPSListener"
        Me.btnStartXPSListener.Size = New System.Drawing.Size(175, 28)
        Me.btnStartXPSListener.TabIndex = 21
        Me.btnStartXPSListener.Text = "Start XPS CP Sim"
        Me.btnStartXPSListener.UseVisualStyleBackColor = True
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Location = New System.Drawing.Point(93, 86)
        Me.Label41.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(63, 17)
        Me.Label41.TabIndex = 20
        Me.Label41.Text = "Severity:"
        '
        'cmbXPSSeverity
        '
        Me.cmbXPSSeverity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbXPSSeverity.FormattingEnabled = True
        Me.cmbXPSSeverity.Items.AddRange(New Object() {"Low", "Medium", "High", "Critical"})
        Me.cmbXPSSeverity.Location = New System.Drawing.Point(173, 82)
        Me.cmbXPSSeverity.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbXPSSeverity.Name = "cmbXPSSeverity"
        Me.cmbXPSSeverity.Size = New System.Drawing.Size(233, 24)
        Me.cmbXPSSeverity.TabIndex = 19
        '
        'xpsPort
        '
        Me.xpsPort.Location = New System.Drawing.Point(173, 20)
        Me.xpsPort.Margin = New System.Windows.Forms.Padding(4)
        Me.xpsPort.Maximum = New Decimal(New Integer() {65535, 0, 0, 0})
        Me.xpsPort.Name = "xpsPort"
        Me.xpsPort.Size = New System.Drawing.Size(160, 22)
        Me.xpsPort.TabIndex = 18
        Me.xpsPort.Value = New Decimal(New Integer() {514, 0, 0, 0})
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(11, 22)
        Me.Label38.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(146, 17)
        Me.Label38.TabIndex = 17
        Me.Label38.Text = "R1 XPS Listener Port:"
        '
        'txtXPSTarget
        '
        Me.txtXPSTarget.Location = New System.Drawing.Point(173, 50)
        Me.txtXPSTarget.Margin = New System.Windows.Forms.Padding(4)
        Me.txtXPSTarget.Name = "txtXPSTarget"
        Me.txtXPSTarget.Size = New System.Drawing.Size(233, 22)
        Me.txtXPSTarget.TabIndex = 14
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(35, 54)
        Me.Label40.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(122, 17)
        Me.Label40.TabIndex = 13
        Me.Label40.Text = "Target Hostname:"
        '
        'btnXPSSend
        '
        Me.btnXPSSend.Location = New System.Drawing.Point(173, 188)
        Me.btnXPSSend.Margin = New System.Windows.Forms.Padding(4)
        Me.btnXPSSend.Name = "btnXPSSend"
        Me.btnXPSSend.Size = New System.Drawing.Size(185, 28)
        Me.btnXPSSend.TabIndex = 12
        Me.btnXPSSend.Text = "Send XPS SysLog Alert"
        Me.btnXPSSend.UseVisualStyleBackColor = True
        '
        'tabAbout
        '
        Me.tabAbout.Controls.Add(Me.Button1)
        Me.tabAbout.Controls.Add(Me.TextBox1)
        Me.tabAbout.Location = New System.Drawing.Point(4, 28)
        Me.tabAbout.Margin = New System.Windows.Forms.Padding(4)
        Me.tabAbout.Name = "tabAbout"
        Me.tabAbout.Size = New System.Drawing.Size(832, 700)
        Me.tabAbout.TabIndex = 3
        Me.tabAbout.Text = "About"
        Me.tabAbout.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(343, 173)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(149, 32)
        Me.Button1.TabIndex = 28
        Me.Button1.Text = "Check for Updates"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(0, 0)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(832, 700)
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
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(840, 732)
        Me.Controls.Add(Me.tabMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Main"
        Me.Text = "R1 Job Runner Version:"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.grpReqSet.ResumeLayout(False)
        Me.grpReqSet.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.grpOptDefSet.ResumeLayout(False)
        Me.grpOptDefSet.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.tabSubMenu.ResumeLayout(False)
        Me.tabJobInfo.ResumeLayout(False)
        Me.tabJobInfo.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grpshare.ResumeLayout(False)
        Me.grpshare.PerformLayout()
        Me.grpagent.ResumeLayout(False)
        Me.grpagent.PerformLayout()
        Me.tabFilters.ResumeLayout(False)
        Me.tabFiltersSubMenu.ResumeLayout(False)
        Me.tabInclusionFilter.ResumeLayout(False)
        Me.splitInclusion.Panel1.ResumeLayout(False)
        Me.splitInclusion.Panel1.PerformLayout()
        Me.splitInclusion.Panel2.ResumeLayout(False)
        Me.splitInclusion.Panel2.PerformLayout()
        CType(Me.splitInclusion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitInclusion.ResumeLayout(False)
        Me.tabExclusionFilter.ResumeLayout(False)
        Me.SplitExclusion.Panel1.ResumeLayout(False)
        Me.SplitExclusion.Panel1.PerformLayout()
        Me.SplitExclusion.Panel2.ResumeLayout(False)
        Me.SplitExclusion.Panel2.PerformLayout()
        CType(Me.SplitExclusion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitExclusion.ResumeLayout(False)
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
        Me.tabSettings.PerformLayout()
        Me.tabRESTUI.ResumeLayout(False)
        Me.tabControlJobsRest.ResumeLayout(False)
        Me.tabTasks.ResumeLayout(False)
        Me.tabTasks.PerformLayout()
        Me.tabProjects.ResumeLayout(False)
        Me.splitProjects.Panel1.ResumeLayout(False)
        Me.splitProjects.Panel1.PerformLayout()
        Me.splitProjects.Panel2.ResumeLayout(False)
        CType(Me.splitProjects, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitProjects.ResumeLayout(False)
        CType(Me.dgvProjectList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabJobsList.ResumeLayout(False)
        Me.splitJobsRestJobs.Panel1.ResumeLayout(False)
        Me.splitJobsRestJobs.Panel1.PerformLayout()
        Me.splitJobsRestJobs.Panel2.ResumeLayout(False)
        CType(Me.splitJobsRestJobs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitJobsRestJobs.ResumeLayout(False)
        CType(Me.dgvJobsRestJobsList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitEndpointStatus.Panel1.ResumeLayout(False)
        Me.splitEndpointStatus.Panel1.PerformLayout()
        Me.splitEndpointStatus.Panel2.ResumeLayout(False)
        CType(Me.splitEndpointStatus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitEndpointStatus.ResumeLayout(False)
        Me.flowEndpointStatus.ResumeLayout(False)
        Me.flowEndpointStatus.PerformLayout()
        CType(Me.dgvEndpointStatusJobTargets, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabAlerts.ResumeLayout(False)
        Me.splitAlerts.Panel1.ResumeLayout(False)
        Me.splitAlerts.Panel2.ResumeLayout(False)
        CType(Me.splitAlerts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitAlerts.ResumeLayout(False)
        CType(Me.dgvAlerts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tblAlertBreakdown.ResumeLayout(False)
        Me.tblAlertBreakdown.PerformLayout()
        Me.tabJobExecution.ResumeLayout(False)
        Me.tabJobExecution.PerformLayout()
        Me.tabFireEye.ResumeLayout(False)
        Me.tabFireEye.PerformLayout()
        Me.tabPANW.ResumeLayout(False)
        Me.tabPANW.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.panw_sim_port, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.panwPort, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabXPS.ResumeLayout(False)
        Me.tabXPS.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.xps_sim_Port, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xpsPort, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabAbout.ResumeLayout(False)
        Me.tabAbout.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnExecute As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDefaultJobName As System.Windows.Forms.TextBox
    Friend WithEvents txtDefaultProjectName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtApiUser As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtAPIPass As System.Windows.Forms.TextBox
    Friend WithEvents txtServer As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents tabSubMenu As System.Windows.Forms.TabControl
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
    Friend WithEvents chkinclsearchfilename As System.Windows.Forms.CheckBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtinclmd5hash As System.Windows.Forms.TextBox
    Friend WithEvents rdoinclregexsearch As System.Windows.Forms.RadioButton
    Friend WithEvents rdoinclsimplesearch As System.Windows.Forms.RadioButton
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtexclmd5hash As System.Windows.Forms.TextBox
    Friend WithEvents tabMenu As System.Windows.Forms.TabControl
    Friend WithEvents tabSettings As System.Windows.Forms.TabPage
    Friend WithEvents tabJobExecution As System.Windows.Forms.TabPage
    Friend WithEvents btnSaveSettings As System.Windows.Forms.Button
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
    Friend WithEvents btnSaveAsBox As System.Windows.Forms.Button
    Friend WithEvents btnLoadFromBox As System.Windows.Forms.Button
    Friend WithEvents ofdBox As System.Windows.Forms.OpenFileDialog
    Friend WithEvents sfdBox As System.Windows.Forms.SaveFileDialog
    Friend WithEvents splitInclusion As System.Windows.Forms.SplitContainer
    Friend WithEvents btnRemoveInclFilterfromList As System.Windows.Forms.Button
    Friend WithEvents btnAddInclFilterToList As System.Windows.Forms.Button
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents lstboxinclusionfilters As System.Windows.Forms.CheckedListBox
    Friend WithEvents btnSaveIncFilterChanges As System.Windows.Forms.Button
    Friend WithEvents SplitExclusion As System.Windows.Forms.SplitContainer
    Friend WithEvents btnsaveexclusionfilterchanges As System.Windows.Forms.Button
    Friend WithEvents lstboxexclusionfilters As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents btnremoveexclusionfilterfromlist As System.Windows.Forms.Button
    Friend WithEvents btnaddexclusionfiltertolist As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rdoagent As System.Windows.Forms.RadioButton
    Friend WithEvents rdoshare As System.Windows.Forms.RadioButton
    Friend WithEvents grpshare As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lstNetShare As System.Windows.Forms.CheckedListBox
    Friend WithEvents txtNetSharePath As System.Windows.Forms.TextBox
    Friend WithEvents btnAddNetShare As System.Windows.Forms.Button
    Friend WithEvents btnRemoveNetShare As System.Windows.Forms.Button
    Friend WithEvents grpagent As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lstComputerTargets As System.Windows.Forms.CheckedListBox
    Friend WithEvents txtComputerTarget As System.Windows.Forms.TextBox
    Friend WithEvents btnAddComputer As System.Windows.Forms.Button
    Friend WithEvents btnRemoveComputer As System.Windows.Forms.Button
    Friend WithEvents lvRemOptions As System.Windows.Forms.ListView
    Friend WithEvents colRemType As System.Windows.Forms.ColumnHeader
    Friend WithEvents colitem As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnAddRemOption As System.Windows.Forms.Button
    Friend WithEvents btnRemoveRemOption As System.Windows.Forms.Button
    Friend WithEvents btnSaveRemOptionChange As System.Windows.Forms.Button
    Friend WithEvents rdoPName As System.Windows.Forms.RadioButton
    Friend WithEvents rdoPID As System.Windows.Forms.RadioButton
    Friend WithEvents tabFireEye As System.Windows.Forms.TabPage
    Friend WithEvents btn_FEEvent As System.Windows.Forms.Button
    Friend WithEvents txtFETarget As System.Windows.Forms.TextBox
    Friend WithEvents Label33 As System.Windows.Forms.Label

    Friend WithEvents tabPANW As System.Windows.Forms.TabPage
    Friend WithEvents btnPANWSend As System.Windows.Forms.Button
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents cmbFEAlertType As System.Windows.Forms.ComboBox
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents cmbPANWAlert As System.Windows.Forms.ComboBox
    Friend WithEvents txtPANWTarget As System.Windows.Forms.TextBox
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents txtFELink As System.Windows.Forms.TextBox
    Friend WithEvents grpReqSet As System.Windows.Forms.GroupBox
    Friend WithEvents grpOptDefSet As System.Windows.Forms.GroupBox
    Friend WithEvents btnShowJSON As System.Windows.Forms.Button
    Friend WithEvents rdor1 As System.Windows.Forms.RadioButton
    Friend WithEvents rdoadgmap As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rdocustom As System.Windows.Forms.RadioButton
    Friend WithEvents txtcustomwebaddress As System.Windows.Forms.TextBox
    Friend WithEvents panwPort As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents tabXPS As System.Windows.Forms.TabPage
    Friend WithEvents xpsPort As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents txtXPSTarget As System.Windows.Forms.TextBox
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents btnXPSSend As System.Windows.Forms.Button
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents cmbXPSSeverity As System.Windows.Forms.ComboBox
    Friend WithEvents btnStartXPSListener As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lbldemoxpsstatus As System.Windows.Forms.Label
    Friend WithEvents txtFELink2 As System.Windows.Forms.TextBox
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents txtXPSSIM As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtXPSMalware As System.Windows.Forms.TextBox
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents xps_sim_Port As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents panw_sim_port As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents lblwildfirestatus As System.Windows.Forms.Label
    Friend WithEvents btn_WildfireStart As System.Windows.Forms.Button
    Friend WithEvents lblXPSStatus As System.Windows.Forms.Label
    Friend WithEvents lblPANWStatus As System.Windows.Forms.Label
    Friend WithEvents lblFEStatus As System.Windows.Forms.Label
    Friend WithEvents lblJobStatus As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents txtPANWSim As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents txtXPSMalwareMD5 As System.Windows.Forms.TextBox
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents txtFireEyeMalwareMD5 As System.Windows.Forms.TextBox
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents txtPANWMalwareMD5 As System.Windows.Forms.TextBox
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents btn_CheckForUpdates As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents chkUpdates As System.Windows.Forms.CheckBox
    Friend WithEvents tabRESTUI As System.Windows.Forms.TabPage
    Friend WithEvents tabControlJobsRest As System.Windows.Forms.TabControl
    Friend WithEvents tabJobsList As System.Windows.Forms.TabPage
    Friend WithEvents txtJobsSearch As System.Windows.Forms.TextBox
    Friend WithEvents splitJobsRestJobs As System.Windows.Forms.SplitContainer
    Friend WithEvents dgvJobsRestJobsList As System.Windows.Forms.DataGridView
    Friend WithEvents splitEndpointStatus As System.Windows.Forms.SplitContainer
    Friend WithEvents dgvEndpointStatusJobTargets As System.Windows.Forms.DataGridView
    Friend WithEvents tabTasks As System.Windows.Forms.TabPage
    Friend WithEvents tabProjects As System.Windows.Forms.TabPage
    Friend WithEvents splitProjects As System.Windows.Forms.SplitContainer
    Friend WithEvents btnNewProject As System.Windows.Forms.Button
    Friend WithEvents txtSearchProject As System.Windows.Forms.TextBox
    Friend WithEvents dgvProjectList As System.Windows.Forms.DataGridView
    Friend WithEvents tabAlerts As System.Windows.Forms.TabPage
    Friend WithEvents flowTasks As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnEditProject As System.Windows.Forms.Button
    Friend WithEvents btnDeleteProject As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CreationDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CreatedBy As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastModDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProjectFolderPath As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProjectID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents splitAlerts As System.Windows.Forms.SplitContainer
    Friend WithEvents dgvAlerts As System.Windows.Forms.DataGridView
    Friend WithEvents artifactName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents createDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents severity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents target As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents source As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents project As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents confidence As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents threatScore As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tblAlertBreakdown As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblTotalNumberofResponses As System.Windows.Forms.Label
    Friend WithEvents flowTotalResponses As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents lblTotalNumberAlerts As System.Windows.Forms.Label
    Friend WithEvents flowAlertBreakdown As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents flowResponseTime As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents lblResponseTime As System.Windows.Forms.Label
    Friend WithEvents endpoint As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Start As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Status As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Hits As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EndPointID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Action As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Review As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents jobName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents jobStatus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents jobRetry As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents jobCancel As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents jobType As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents jobStart As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents jobEnd As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents jobID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents jobResultID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents jobEndpointStatus As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Result As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents btnViewProjectReview As System.Windows.Forms.Button
    Friend WithEvents flowEndpointStatus As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnBackFromEndpointStatus As System.Windows.Forms.Button
    Friend WithEvents lblJobName As System.Windows.Forms.Label
    Friend WithEvents txtSearchEndpointStatus As System.Windows.Forms.TextBox
    Friend WithEvents lblepStatusTotal As System.Windows.Forms.Label
    Friend WithEvents lblepStatusInProgress As System.Windows.Forms.Label
    Friend WithEvents lblepstatusFailed As System.Windows.Forms.Label
    Friend WithEvents lblepstatusSuccessful As System.Windows.Forms.Label
    Friend WithEvents chkRestAPI As System.Windows.Forms.CheckBox
    Friend WithEvents tooltip As System.Windows.Forms.ToolTip
    Friend WithEvents btnLoadDefaultTemplateName As System.Windows.Forms.Button

End Class
