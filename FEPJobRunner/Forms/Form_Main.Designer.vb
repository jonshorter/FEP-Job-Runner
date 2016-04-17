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
        Me.grpSettings = New System.Windows.Forms.GroupBox()
        Me.flowSettings = New System.Windows.Forms.FlowLayoutPanel()
        Me.grpReqSettings = New System.Windows.Forms.GroupBox()
        Me.tableSettingRequired = New System.Windows.Forms.TableLayoutPanel()
        Me.chkRestAPI = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtcustomwebaddress = New System.Windows.Forms.TextBox()
        Me.rdocustom = New System.Windows.Forms.RadioButton()
        Me.rdoendpoint = New System.Windows.Forms.RadioButton()
        Me.grpOptDefSet = New System.Windows.Forms.GroupBox()
        Me.tableSettingOptional = New System.Windows.Forms.TableLayoutPanel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtdefaultshare = New System.Windows.Forms.TextBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.chkIncludPreRelease = New System.Windows.Forms.CheckBox()
        Me.chkUpdates = New System.Windows.Forms.CheckBox()
        Me.btn_CheckForUpdates = New System.Windows.Forms.Button()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.txtdefaultcomputer = New System.Windows.Forms.TextBox()
        Me.chkbypasscerts = New System.Windows.Forms.CheckBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.btnLoadDefaultTemplateName = New System.Windows.Forms.Button()
        Me.txtDefaultTemplateName = New System.Windows.Forms.ComboBox()
        Me.tableSettingSave = New System.Windows.Forms.TableLayoutPanel()
        Me.btnSaveSettings = New System.Windows.Forms.Button()
        Me.txtStatusSettings = New System.Windows.Forms.TextBox()
        Me.tabSubMenu = New System.Windows.Forms.TabControl()
        Me.tabJobInfo = New System.Windows.Forms.TabPage()
        Me.flowJobInfo = New System.Windows.Forms.FlowLayoutPanel()
        Me.tableJobInfo = New System.Windows.Forms.TableLayoutPanel()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txtTemplateName = New System.Windows.Forms.ComboBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtProjectName = New System.Windows.Forms.TextBox()
        Me.txtJobName = New System.Windows.Forms.TextBox()
        Me.tableJobInfoTarget = New System.Windows.Forms.TableLayoutPanel()
        Me.grpJobTargetSelect = New System.Windows.Forms.GroupBox()
        Me.rdoagent = New System.Windows.Forms.RadioButton()
        Me.rdoshare = New System.Windows.Forms.RadioButton()
        Me.grpshare = New System.Windows.Forms.GroupBox()
        Me.tableNetworkShares = New System.Windows.Forms.TableLayoutPanel()
        Me.btnRemoveNetShare = New System.Windows.Forms.Button()
        Me.lstNetShare = New System.Windows.Forms.CheckedListBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnAddNetShare = New System.Windows.Forms.Button()
        Me.txtNetSharePath = New System.Windows.Forms.TextBox()
        Me.grpagent = New System.Windows.Forms.GroupBox()
        Me.tableComputerTargets = New System.Windows.Forms.TableLayoutPanel()
        Me.btnRemoveComputer = New System.Windows.Forms.Button()
        Me.lstComputerTargets = New System.Windows.Forms.CheckedListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAddComputer = New System.Windows.Forms.Button()
        Me.txtComputerTarget = New System.Windows.Forms.TextBox()
        Me.tabFilters = New System.Windows.Forms.TabPage()
        Me.tableFilters = New System.Windows.Forms.TableLayoutPanel()
        Me.tabFiltersSubMenu = New System.Windows.Forms.TabControl()
        Me.tabInclusionFilter = New System.Windows.Forms.TabPage()
        Me.tableInclusionFilters = New System.Windows.Forms.TableLayoutPanel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtinclkeywords = New System.Windows.Forms.TextBox()
        Me.txtinclfiltername = New System.Windows.Forms.TextBox()
        Me.txtinclmd5hash = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtinclextensions = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtinclpathcontains = New System.Windows.Forms.TextBox()
        Me.chkinclsearchfilename = New System.Windows.Forms.CheckBox()
        Me.rdoinclregexsearch = New System.Windows.Forms.RadioButton()
        Me.rdoinclsimplesearch = New System.Windows.Forms.RadioButton()
        Me.tabExclusionFilter = New System.Windows.Forms.TabPage()
        Me.tableExclusionFilters = New System.Windows.Forms.TableLayoutPanel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtexclmd5hash = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtexclfiltername = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtexclpathcontains = New System.Windows.Forms.TextBox()
        Me.txtexclextensions = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnFilters_Remove = New System.Windows.Forms.Button()
        Me.btnFilters_Save = New System.Windows.Forms.Button()
        Me.btnFilters_Add = New System.Windows.Forms.Button()
        Me.dgvFilters = New System.Windows.Forms.DataGridView()
        Me.colFilterCheck = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.col_FilterType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFilterName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tabAgentRemediation = New System.Windows.Forms.TabPage()
        Me.tableAgentRemediation = New System.Windows.Forms.TableLayoutPanel()
        Me.lvRemOptions = New System.Windows.Forms.ListView()
        Me.colRemType = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colitem = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnRemoveRemOption = New System.Windows.Forms.Button()
        Me.btnSaveRemOptionChange = New System.Windows.Forms.Button()
        Me.btnAddRemOption = New System.Windows.Forms.Button()
        Me.tabAgentRemediationSubMenu = New System.Windows.Forms.TabControl()
        Me.tabAgentSendFile = New System.Windows.Forms.TabPage()
        Me.tableARSendFile = New System.Windows.Forms.TableLayoutPanel()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.chkremsendexecute = New System.Windows.Forms.CheckBox()
        Me.txtremsendsource = New System.Windows.Forms.TextBox()
        Me.chkremsenddelete = New System.Windows.Forms.CheckBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtremsenddest = New System.Windows.Forms.TextBox()
        Me.tabAgentExecute = New System.Windows.Forms.TabPage()
        Me.tableARExecute = New System.Windows.Forms.TableLayoutPanel()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtremexecargs = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtremexecpath = New System.Windows.Forms.TextBox()
        Me.tabAgentDelete = New System.Windows.Forms.TabPage()
        Me.tableARDelete = New System.Windows.Forms.TableLayoutPanel()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtremdelfilepath = New System.Windows.Forms.TextBox()
        Me.TabAgentKill = New System.Windows.Forms.TabPage()
        Me.tableARKill = New System.Windows.Forms.TableLayoutPanel()
        Me.grpARKill = New System.Windows.Forms.GroupBox()
        Me.rdoPName = New System.Windows.Forms.RadioButton()
        Me.rdoPID = New System.Windows.Forms.RadioButton()
        Me.txtremkillprocname = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.nmbremkillprocid = New System.Windows.Forms.NumericUpDown()
        Me.tabMenu = New System.Windows.Forms.TabControl()
        Me.tabSettings = New System.Windows.Forms.TabPage()
        Me.tabRESTUI = New System.Windows.Forms.TabPage()
        Me.tabControlJobsRest = New System.Windows.Forms.TabControl()
        Me.tabTasks = New System.Windows.Forms.TabPage()
        Me.flowTasks = New System.Windows.Forms.FlowLayoutPanel()
        Me.tabProjects = New System.Windows.Forms.TabPage()
        Me.splitProjects = New System.Windows.Forms.SplitContainer()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.lvProjectFacets = New System.Windows.Forms.ListView()
        Me.dgvProjectList = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CreationDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CreatedBy = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastModDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProjectFolderPath = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProjectID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tabJobsList = New System.Windows.Forms.TabPage()
        Me.splitJobsRestJobs = New System.Windows.Forms.SplitContainer()
        Me.dgvJobsRestJobsList = New System.Windows.Forms.DataGridView()
        Me.jobName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jobStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jobType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jobStart = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jobEnd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jobID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jobResultID = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.flowJobsAPI = New System.Windows.Forms.FlowLayoutPanel()
        Me.tableJobExecute = New System.Windows.Forms.TableLayoutPanel()
        Me.btnShowJSON = New System.Windows.Forms.Button()
        Me.lblJobStatus = New System.Windows.Forms.Label()
        Me.btnLoadFromBox = New System.Windows.Forms.Button()
        Me.btnSaveAsBox = New System.Windows.Forms.Button()
        Me.btnSavePowershell = New System.Windows.Forms.Button()
        Me.tabFireEye = New System.Windows.Forms.TabPage()
        Me.flowFireEye = New System.Windows.Forms.FlowLayoutPanel()
        Me.tableFireEye = New System.Windows.Forms.TableLayoutPanel()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.txtFireEyeMalwareMD5 = New System.Windows.Forms.TextBox()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.txtFETarget = New System.Windows.Forms.TextBox()
        Me.btn_FEEvent = New System.Windows.Forms.Button()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.cmbFEAlertType = New System.Windows.Forms.ComboBox()
        Me.txtFireEyeMalwareName = New System.Windows.Forms.TextBox()
        Me.lblFEStatus = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.txtFELink = New System.Windows.Forms.TextBox()
        Me.tabPANW = New System.Windows.Forms.TabPage()
        Me.flowPANW = New System.Windows.Forms.FlowLayoutPanel()
        Me.tablePANWSendAlert = New System.Windows.Forms.TableLayoutPanel()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.txtPANWMalwareMD5 = New System.Windows.Forms.TextBox()
        Me.txtPANWMalwareName = New System.Windows.Forms.TextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.panwPort = New System.Windows.Forms.NumericUpDown()
        Me.btnPANWSend = New System.Windows.Forms.Button()
        Me.txtPANWTarget = New System.Windows.Forms.TextBox()
        Me.cmbPANWAlert = New System.Windows.Forms.ComboBox()
        Me.lblPANWStatus = New System.Windows.Forms.Label()
        Me.grpWildFireSim = New System.Windows.Forms.GroupBox()
        Me.panw_sim_port = New System.Windows.Forms.NumericUpDown()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.lblwildfirestatus = New System.Windows.Forms.Label()
        Me.btn_WildfireStart = New System.Windows.Forms.Button()
        Me.tablePANWBottom = New System.Windows.Forms.TableLayoutPanel()
        Me.grpWildFirePicture = New System.Windows.Forms.GroupBox()
        Me.lblWildFireURL = New System.Windows.Forms.Label()
        Me.panwPicture = New System.Windows.Forms.PictureBox()
        Me.txtFireEyeDownload1 = New System.Windows.Forms.TextBox()
        Me.lblPANWHitInstruction = New System.Windows.Forms.Label()
        Me.txtPANWSim = New System.Windows.Forms.Label()
        Me.tabXPS = New System.Windows.Forms.TabPage()
        Me.flowXPS = New System.Windows.Forms.FlowLayoutPanel()
        Me.tableXPSGrid = New System.Windows.Forms.TableLayoutPanel()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.xpsPort = New System.Windows.Forms.NumericUpDown()
        Me.txtXPSMalwareMD5 = New System.Windows.Forms.TextBox()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.btnXPSSend = New System.Windows.Forms.Button()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.txtXPSTarget = New System.Windows.Forms.TextBox()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.txtXPSMalware = New System.Windows.Forms.TextBox()
        Me.cmbXPSSeverity = New System.Windows.Forms.ComboBox()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.lblXPSStatus = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.xps_sim_Port = New System.Windows.Forms.NumericUpDown()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.lbldemoxpsstatus = New System.Windows.Forms.Label()
        Me.btnStartXPSListener = New System.Windows.Forms.Button()
        Me.tableXPSTextPic = New System.Windows.Forms.TableLayoutPanel()
        Me.txtXPSSim = New System.Windows.Forms.Label()
        Me.grpXPSPicture = New System.Windows.Forms.GroupBox()
        Me.lblXPSHostname = New System.Windows.Forms.Label()
        Me.xpsPicture = New System.Windows.Forms.PictureBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.txtFELink2 = New System.Windows.Forms.TextBox()
        Me.tabAbout = New System.Windows.Forms.TabPage()
        Me.flowAbout = New System.Windows.Forms.FlowLayoutPanel()
        Me.lbltxtAbout = New System.Windows.Forms.Label()
        Me.btn_AboutCheckforUpdates = New System.Windows.Forms.Button()
        Me.cms_Project = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.NewProjectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditProjectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteProjectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewProjectInReviewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ofdBox = New System.Windows.Forms.OpenFileDialog()
        Me.sfdBox = New System.Windows.Forms.SaveFileDialog()
        Me.tooltip = New System.Windows.Forms.ToolTip(Me.components)
        Me.sfdPowerShell = New System.Windows.Forms.SaveFileDialog()
        Me.cms_JobStatus = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EndpointStatusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResultToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.RetryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CancelJobToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.lvJobStatusFacets = New System.Windows.Forms.ListView()
        Me.grpSettings.SuspendLayout()
        Me.flowSettings.SuspendLayout()
        Me.grpReqSettings.SuspendLayout()
        Me.tableSettingRequired.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.grpOptDefSet.SuspendLayout()
        Me.tableSettingOptional.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.tableSettingSave.SuspendLayout()
        Me.tabSubMenu.SuspendLayout()
        Me.tabJobInfo.SuspendLayout()
        Me.flowJobInfo.SuspendLayout()
        Me.tableJobInfo.SuspendLayout()
        Me.tableJobInfoTarget.SuspendLayout()
        Me.grpJobTargetSelect.SuspendLayout()
        Me.grpshare.SuspendLayout()
        Me.tableNetworkShares.SuspendLayout()
        Me.grpagent.SuspendLayout()
        Me.tableComputerTargets.SuspendLayout()
        Me.tabFilters.SuspendLayout()
        Me.tableFilters.SuspendLayout()
        Me.tabFiltersSubMenu.SuspendLayout()
        Me.tabInclusionFilter.SuspendLayout()
        Me.tableInclusionFilters.SuspendLayout()
        Me.tabExclusionFilter.SuspendLayout()
        Me.tableExclusionFilters.SuspendLayout()
        CType(Me.dgvFilters, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabAgentRemediation.SuspendLayout()
        Me.tableAgentRemediation.SuspendLayout()
        Me.tabAgentRemediationSubMenu.SuspendLayout()
        Me.tabAgentSendFile.SuspendLayout()
        Me.tableARSendFile.SuspendLayout()
        Me.tabAgentExecute.SuspendLayout()
        Me.tableARExecute.SuspendLayout()
        Me.tabAgentDelete.SuspendLayout()
        Me.tableARDelete.SuspendLayout()
        Me.TabAgentKill.SuspendLayout()
        Me.tableARKill.SuspendLayout()
        Me.grpARKill.SuspendLayout()
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
        Me.flowJobsAPI.SuspendLayout()
        Me.tableJobExecute.SuspendLayout()
        Me.tabFireEye.SuspendLayout()
        Me.flowFireEye.SuspendLayout()
        Me.tableFireEye.SuspendLayout()
        Me.tabPANW.SuspendLayout()
        Me.flowPANW.SuspendLayout()
        Me.tablePANWSendAlert.SuspendLayout()
        CType(Me.panwPort, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpWildFireSim.SuspendLayout()
        CType(Me.panw_sim_port, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tablePANWBottom.SuspendLayout()
        Me.grpWildFirePicture.SuspendLayout()
        CType(Me.panwPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabXPS.SuspendLayout()
        Me.flowXPS.SuspendLayout()
        Me.tableXPSGrid.SuspendLayout()
        CType(Me.xpsPort, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.xps_sim_Port, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tableXPSTextPic.SuspendLayout()
        Me.grpXPSPicture.SuspendLayout()
        CType(Me.xpsPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabAbout.SuspendLayout()
        Me.flowAbout.SuspendLayout()
        Me.cms_Project.SuspendLayout()
        Me.cms_JobStatus.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExecute
        '
        Me.btnExecute.Location = New System.Drawing.Point(564, 8)
        Me.btnExecute.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExecute.Name = "btnExecute"
        Me.btnExecute.Size = New System.Drawing.Size(100, 28)
        Me.btnExecute.TabIndex = 0
        Me.btnExecute.TabStop = False
        Me.btnExecute.Text = "Execute Job"
        Me.btnExecute.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 0)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Default Job Name:"
        '
        'txtDefaultJobName
        '
        Me.txtDefaultJobName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtDefaultJobName.Location = New System.Drawing.Point(175, 4)
        Me.txtDefaultJobName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDefaultJobName.Name = "txtDefaultJobName"
        Me.txtDefaultJobName.Size = New System.Drawing.Size(219, 22)
        Me.txtDefaultJobName.TabIndex = 0
        '
        'txtDefaultProjectName
        '
        Me.txtDefaultProjectName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtDefaultProjectName.Location = New System.Drawing.Point(175, 34)
        Me.txtDefaultProjectName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDefaultProjectName.Name = "txtDefaultProjectName"
        Me.txtDefaultProjectName.Size = New System.Drawing.Size(219, 22)
        Me.txtDefaultProjectName.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 30)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(146, 17)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Default Project Name:"
        '
        'txtApiUser
        '
        Me.txtApiUser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtApiUser.Location = New System.Drawing.Point(172, 34)
        Me.txtApiUser.Margin = New System.Windows.Forms.Padding(4)
        Me.txtApiUser.Name = "txtApiUser"
        Me.txtApiUser.Size = New System.Drawing.Size(219, 22)
        Me.txtApiUser.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(4, 30)
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
        Me.Label5.Location = New System.Drawing.Point(4, 60)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 17)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "API Password*:"
        Me.tooltip.SetToolTip(Me.Label5, "The password for the user.")
        '
        'txtAPIPass
        '
        Me.txtAPIPass.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtAPIPass.Location = New System.Drawing.Point(172, 64)
        Me.txtAPIPass.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAPIPass.Name = "txtAPIPass"
        Me.txtAPIPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtAPIPass.Size = New System.Drawing.Size(219, 22)
        Me.txtAPIPass.TabIndex = 2
        '
        'txtServer
        '
        Me.txtServer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtServer.Location = New System.Drawing.Point(172, 4)
        Me.txtServer.Margin = New System.Windows.Forms.Padding(4)
        Me.txtServer.Name = "txtServer"
        Me.txtServer.Size = New System.Drawing.Size(219, 22)
        Me.txtServer.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(4, 0)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(160, 17)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Web Server Hostname*:"
        Me.tooltip.SetToolTip(Me.Label7, "The webserver hostname where R1 resides.")
        '
        'grpSettings
        '
        Me.grpSettings.AutoSize = True
        Me.grpSettings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.grpSettings.Controls.Add(Me.flowSettings)
        Me.grpSettings.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpSettings.Location = New System.Drawing.Point(4, 4)
        Me.grpSettings.Margin = New System.Windows.Forms.Padding(4)
        Me.grpSettings.Name = "grpSettings"
        Me.grpSettings.Padding = New System.Windows.Forms.Padding(4)
        Me.grpSettings.Size = New System.Drawing.Size(742, 688)
        Me.grpSettings.TabIndex = 0
        Me.grpSettings.TabStop = False
        Me.grpSettings.Text = "Settings"
        '
        'flowSettings
        '
        Me.flowSettings.AutoSize = True
        Me.flowSettings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.flowSettings.Controls.Add(Me.grpReqSettings)
        Me.flowSettings.Controls.Add(Me.grpOptDefSet)
        Me.flowSettings.Controls.Add(Me.tableSettingSave)
        Me.flowSettings.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flowSettings.Location = New System.Drawing.Point(4, 19)
        Me.flowSettings.Name = "flowSettings"
        Me.flowSettings.Size = New System.Drawing.Size(734, 665)
        Me.flowSettings.TabIndex = 0
        '
        'grpReqSettings
        '
        Me.grpReqSettings.AutoSize = True
        Me.grpReqSettings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.grpReqSettings.Controls.Add(Me.tableSettingRequired)
        Me.flowSettings.SetFlowBreak(Me.grpReqSettings, True)
        Me.grpReqSettings.Location = New System.Drawing.Point(3, 3)
        Me.grpReqSettings.Name = "grpReqSettings"
        Me.grpReqSettings.Size = New System.Drawing.Size(646, 138)
        Me.grpReqSettings.TabIndex = 1
        Me.grpReqSettings.TabStop = False
        Me.grpReqSettings.Text = "Required Settings"
        '
        'tableSettingRequired
        '
        Me.tableSettingRequired.AutoSize = True
        Me.tableSettingRequired.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tableSettingRequired.ColumnCount = 3
        Me.tableSettingRequired.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tableSettingRequired.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tableSettingRequired.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tableSettingRequired.Controls.Add(Me.chkRestAPI, 2, 3)
        Me.tableSettingRequired.Controls.Add(Me.Label7, 0, 0)
        Me.tableSettingRequired.Controls.Add(Me.GroupBox2, 2, 0)
        Me.tableSettingRequired.Controls.Add(Me.txtServer, 1, 0)
        Me.tableSettingRequired.Controls.Add(Me.txtAPIPass, 1, 2)
        Me.tableSettingRequired.Controls.Add(Me.Label5, 0, 2)
        Me.tableSettingRequired.Controls.Add(Me.Label4, 0, 1)
        Me.tableSettingRequired.Controls.Add(Me.txtApiUser, 1, 1)
        Me.tableSettingRequired.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tableSettingRequired.Location = New System.Drawing.Point(3, 18)
        Me.tableSettingRequired.Name = "tableSettingRequired"
        Me.tableSettingRequired.RowCount = 4
        Me.tableSettingRequired.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableSettingRequired.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableSettingRequired.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableSettingRequired.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableSettingRequired.Size = New System.Drawing.Size(640, 117)
        Me.tableSettingRequired.TabIndex = 0
        '
        'chkRestAPI
        '
        Me.chkRestAPI.AutoSize = True
        Me.chkRestAPI.Checked = True
        Me.chkRestAPI.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkRestAPI.Location = New System.Drawing.Point(398, 93)
        Me.chkRestAPI.Name = "chkRestAPI"
        Me.chkRestAPI.Size = New System.Drawing.Size(170, 21)
        Me.chkRestAPI.TabIndex = 4
        Me.chkRestAPI.Text = "Enable RestAPI (6.0+)"
        Me.tooltip.SetToolTip(Me.chkRestAPI, "Enable the Rest API. This is only supported in FEP 6 and up.")
        Me.chkRestAPI.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtcustomwebaddress)
        Me.GroupBox2.Controls.Add(Me.rdocustom)
        Me.GroupBox2.Controls.Add(Me.rdoendpoint)
        Me.GroupBox2.Location = New System.Drawing.Point(399, 4)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.tableSettingRequired.SetRowSpan(Me.GroupBox2, 3)
        Me.GroupBox2.Size = New System.Drawing.Size(237, 52)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Website Address:"
        Me.tooltip.SetToolTip(Me.GroupBox2, "Select the trailing website address. 5.8 and up use R1.")
        '
        'txtcustomwebaddress
        '
        Me.txtcustomwebaddress.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcustomwebaddress.Enabled = False
        Me.txtcustomwebaddress.Location = New System.Drawing.Point(31, 57)
        Me.txtcustomwebaddress.Margin = New System.Windows.Forms.Padding(4)
        Me.txtcustomwebaddress.Name = "txtcustomwebaddress"
        Me.txtcustomwebaddress.Size = New System.Drawing.Size(197, 22)
        Me.txtcustomwebaddress.TabIndex = 21
        Me.txtcustomwebaddress.Visible = False
        '
        'rdocustom
        '
        Me.rdocustom.AutoSize = True
        Me.rdocustom.Location = New System.Drawing.Point(8, 60)
        Me.rdocustom.Margin = New System.Windows.Forms.Padding(4)
        Me.rdocustom.Name = "rdocustom"
        Me.rdocustom.Size = New System.Drawing.Size(17, 16)
        Me.rdocustom.TabIndex = 20
        Me.rdocustom.TabStop = True
        Me.tooltip.SetToolTip(Me.rdocustom, "Specify a custom website path.")
        Me.rdocustom.UseVisualStyleBackColor = True
        Me.rdocustom.Visible = False
        '
        'rdoendpoint
        '
        Me.rdoendpoint.AutoSize = True
        Me.rdoendpoint.Checked = True
        Me.rdoendpoint.Location = New System.Drawing.Point(8, 31)
        Me.rdoendpoint.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoendpoint.Name = "rdoendpoint"
        Me.rdoendpoint.Size = New System.Drawing.Size(85, 21)
        Me.rdoendpoint.TabIndex = 0
        Me.rdoendpoint.TabStop = True
        Me.rdoendpoint.Text = "Endpoint"
        Me.tooltip.SetToolTip(Me.rdoendpoint, "Default for 5.8 and up.")
        Me.rdoendpoint.UseVisualStyleBackColor = True
        '
        'grpOptDefSet
        '
        Me.grpOptDefSet.AutoSize = True
        Me.grpOptDefSet.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.grpOptDefSet.Controls.Add(Me.tableSettingOptional)
        Me.flowSettings.SetFlowBreak(Me.grpOptDefSet, True)
        Me.grpOptDefSet.Location = New System.Drawing.Point(4, 148)
        Me.grpOptDefSet.Margin = New System.Windows.Forms.Padding(4)
        Me.grpOptDefSet.Name = "grpOptDefSet"
        Me.grpOptDefSet.Padding = New System.Windows.Forms.Padding(4)
        Me.grpOptDefSet.Size = New System.Drawing.Size(676, 214)
        Me.grpOptDefSet.TabIndex = 2
        Me.grpOptDefSet.TabStop = False
        Me.grpOptDefSet.Text = "Optional Default Settings"
        '
        'tableSettingOptional
        '
        Me.tableSettingOptional.AutoSize = True
        Me.tableSettingOptional.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tableSettingOptional.ColumnCount = 4
        Me.tableSettingOptional.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tableSettingOptional.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tableSettingOptional.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tableSettingOptional.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tableSettingOptional.Controls.Add(Me.Label2, 0, 0)
        Me.tableSettingOptional.Controls.Add(Me.Label14, 0, 4)
        Me.tableSettingOptional.Controls.Add(Me.txtdefaultshare, 1, 3)
        Me.tableSettingOptional.Controls.Add(Me.GroupBox6, 3, 1)
        Me.tableSettingOptional.Controls.Add(Me.Label29, 0, 3)
        Me.tableSettingOptional.Controls.Add(Me.txtDefaultJobName, 1, 0)
        Me.tableSettingOptional.Controls.Add(Me.txtDefaultProjectName, 1, 1)
        Me.tableSettingOptional.Controls.Add(Me.txtdefaultcomputer, 1, 2)
        Me.tableSettingOptional.Controls.Add(Me.Label3, 0, 1)
        Me.tableSettingOptional.Controls.Add(Me.chkbypasscerts, 3, 0)
        Me.tableSettingOptional.Controls.Add(Me.Label28, 0, 2)
        Me.tableSettingOptional.Controls.Add(Me.btnLoadDefaultTemplateName, 2, 4)
        Me.tableSettingOptional.Controls.Add(Me.txtDefaultTemplateName, 1, 4)
        Me.tableSettingOptional.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tableSettingOptional.Location = New System.Drawing.Point(4, 19)
        Me.tableSettingOptional.Name = "tableSettingOptional"
        Me.tableSettingOptional.RowCount = 5
        Me.tableSettingOptional.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableSettingOptional.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableSettingOptional.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableSettingOptional.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableSettingOptional.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableSettingOptional.Size = New System.Drawing.Size(668, 191)
        Me.tableSettingOptional.TabIndex = 0
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(4, 159)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(161, 17)
        Me.Label14.TabIndex = 19
        Me.Label14.Text = "Default Template Name:"
        '
        'txtdefaultshare
        '
        Me.txtdefaultshare.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtdefaultshare.Location = New System.Drawing.Point(175, 94)
        Me.txtdefaultshare.Margin = New System.Windows.Forms.Padding(4)
        Me.txtdefaultshare.Name = "txtdefaultshare"
        Me.txtdefaultshare.Size = New System.Drawing.Size(219, 22)
        Me.txtdefaultshare.TabIndex = 3
        '
        'GroupBox6
        '
        Me.GroupBox6.AutoSize = True
        Me.GroupBox6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox6.Controls.Add(Me.chkIncludPreRelease)
        Me.GroupBox6.Controls.Add(Me.chkUpdates)
        Me.GroupBox6.Controls.Add(Me.btn_CheckForUpdates)
        Me.GroupBox6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox6.Location = New System.Drawing.Point(445, 33)
        Me.GroupBox6.Name = "GroupBox6"
        Me.tableSettingOptional.SetRowSpan(Me.GroupBox6, 3)
        Me.GroupBox6.Size = New System.Drawing.Size(220, 123)
        Me.GroupBox6.TabIndex = 7
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Updates"
        '
        'chkIncludPreRelease
        '
        Me.chkIncludPreRelease.AutoSize = True
        Me.chkIncludPreRelease.Location = New System.Drawing.Point(6, 43)
        Me.chkIncludPreRelease.Name = "chkIncludPreRelease"
        Me.chkIncludPreRelease.Size = New System.Drawing.Size(158, 21)
        Me.chkIncludPreRelease.TabIndex = 28
        Me.chkIncludPreRelease.Text = "Include Pre-Release"
        Me.tooltip.SetToolTip(Me.chkIncludPreRelease, "Check for pre-releases")
        Me.chkIncludPreRelease.UseVisualStyleBackColor = True
        '
        'chkUpdates
        '
        Me.chkUpdates.AutoSize = True
        Me.chkUpdates.Location = New System.Drawing.Point(6, 21)
        Me.chkUpdates.Name = "chkUpdates"
        Me.chkUpdates.Size = New System.Drawing.Size(208, 21)
        Me.chkUpdates.TabIndex = 0
        Me.chkUpdates.Text = "Check For Updates On Start"
        Me.tooltip.SetToolTip(Me.chkUpdates, "Check for updates to Job Runner on start.")
        Me.chkUpdates.UseVisualStyleBackColor = True
        '
        'btn_CheckForUpdates
        '
        Me.btn_CheckForUpdates.Location = New System.Drawing.Point(6, 70)
        Me.btn_CheckForUpdates.Name = "btn_CheckForUpdates"
        Me.btn_CheckForUpdates.Size = New System.Drawing.Size(149, 32)
        Me.btn_CheckForUpdates.TabIndex = 0
        Me.btn_CheckForUpdates.Text = "Check for Updates"
        Me.btn_CheckForUpdates.UseVisualStyleBackColor = True
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(4, 90)
        Me.Label29.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(140, 17)
        Me.Label29.TabIndex = 25
        Me.Label29.Text = "Default Share Name:"
        '
        'txtdefaultcomputer
        '
        Me.txtdefaultcomputer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtdefaultcomputer.Location = New System.Drawing.Point(175, 64)
        Me.txtdefaultcomputer.Margin = New System.Windows.Forms.Padding(4)
        Me.txtdefaultcomputer.Name = "txtdefaultcomputer"
        Me.txtdefaultcomputer.Size = New System.Drawing.Size(219, 22)
        Me.txtdefaultcomputer.TabIndex = 2
        '
        'chkbypasscerts
        '
        Me.chkbypasscerts.AutoSize = True
        Me.chkbypasscerts.Location = New System.Drawing.Point(446, 4)
        Me.chkbypasscerts.Margin = New System.Windows.Forms.Padding(4)
        Me.chkbypasscerts.Name = "chkbypasscerts"
        Me.chkbypasscerts.Size = New System.Drawing.Size(188, 21)
        Me.chkbypasscerts.TabIndex = 6
        Me.chkbypasscerts.Text = "ByPass Invalid Certificate"
        Me.tooltip.SetToolTip(Me.chkbypasscerts, "Warning! Allows Job Runner to ignore invalid Website certificates, such as self-s" & _
        "igned certificates.. ")
        Me.chkbypasscerts.UseVisualStyleBackColor = True
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(4, 60)
        Me.Label28.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(163, 17)
        Me.Label28.TabIndex = 23
        Me.Label28.Text = "Default Computer Name:"
        '
        'btnLoadDefaultTemplateName
        '
        Me.btnLoadDefaultTemplateName.Location = New System.Drawing.Point(401, 162)
        Me.btnLoadDefaultTemplateName.Name = "btnLoadDefaultTemplateName"
        Me.btnLoadDefaultTemplateName.Size = New System.Drawing.Size(38, 23)
        Me.btnLoadDefaultTemplateName.TabIndex = 4
        Me.btnLoadDefaultTemplateName.Text = "..."
        Me.btnLoadDefaultTemplateName.UseVisualStyleBackColor = True
        '
        'txtDefaultTemplateName
        '
        Me.txtDefaultTemplateName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtDefaultTemplateName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtDefaultTemplateName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtDefaultTemplateName.DropDownWidth = 375
        Me.txtDefaultTemplateName.Items.AddRange(New Object() {"coll-evtx"})
        Me.txtDefaultTemplateName.Location = New System.Drawing.Point(175, 163)
        Me.txtDefaultTemplateName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDefaultTemplateName.Name = "txtDefaultTemplateName"
        Me.txtDefaultTemplateName.Size = New System.Drawing.Size(219, 24)
        Me.txtDefaultTemplateName.TabIndex = 5
        Me.txtDefaultTemplateName.Text = "coll-evtx"
        '
        'tableSettingSave
        '
        Me.tableSettingSave.AutoSize = True
        Me.tableSettingSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tableSettingSave.ColumnCount = 2
        Me.tableSettingSave.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tableSettingSave.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tableSettingSave.Controls.Add(Me.btnSaveSettings, 1, 0)
        Me.tableSettingSave.Controls.Add(Me.txtStatusSettings, 0, 0)
        Me.tableSettingSave.Location = New System.Drawing.Point(3, 369)
        Me.tableSettingSave.Name = "tableSettingSave"
        Me.tableSettingSave.RowCount = 1
        Me.tableSettingSave.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableSettingSave.Size = New System.Drawing.Size(693, 36)
        Me.tableSettingSave.TabIndex = 3
        '
        'btnSaveSettings
        '
        Me.btnSaveSettings.Location = New System.Drawing.Point(561, 4)
        Me.btnSaveSettings.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSaveSettings.Name = "btnSaveSettings"
        Me.btnSaveSettings.Size = New System.Drawing.Size(128, 28)
        Me.btnSaveSettings.TabIndex = 0
        Me.btnSaveSettings.Text = "Save Settings"
        Me.btnSaveSettings.UseVisualStyleBackColor = True
        '
        'txtStatusSettings
        '
        Me.txtStatusSettings.BackColor = System.Drawing.SystemColors.Control
        Me.txtStatusSettings.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtStatusSettings.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStatusSettings.Location = New System.Drawing.Point(4, 4)
        Me.txtStatusSettings.Margin = New System.Windows.Forms.Padding(4)
        Me.txtStatusSettings.Name = "txtStatusSettings"
        Me.txtStatusSettings.ReadOnly = True
        Me.txtStatusSettings.Size = New System.Drawing.Size(549, 19)
        Me.txtStatusSettings.TabIndex = 0
        Me.txtStatusSettings.TabStop = False
        Me.txtStatusSettings.Text = "Status"
        '
        'tabSubMenu
        '
        Me.tabSubMenu.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.tabSubMenu.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.tabSubMenu.Controls.Add(Me.tabJobInfo)
        Me.tabSubMenu.Controls.Add(Me.tabFilters)
        Me.tabSubMenu.Controls.Add(Me.tabAgentRemediation)
        Me.flowJobsAPI.SetFlowBreak(Me.tabSubMenu, True)
        Me.tabSubMenu.Location = New System.Drawing.Point(4, 4)
        Me.tabSubMenu.Margin = New System.Windows.Forms.Padding(4)
        Me.tabSubMenu.Name = "tabSubMenu"
        Me.tabSubMenu.SelectedIndex = 0
        Me.tabSubMenu.Size = New System.Drawing.Size(738, 610)
        Me.tabSubMenu.TabIndex = 0
        '
        'tabJobInfo
        '
        Me.tabJobInfo.Controls.Add(Me.flowJobInfo)
        Me.tabJobInfo.Location = New System.Drawing.Point(4, 28)
        Me.tabJobInfo.Margin = New System.Windows.Forms.Padding(4)
        Me.tabJobInfo.Name = "tabJobInfo"
        Me.tabJobInfo.Size = New System.Drawing.Size(730, 578)
        Me.tabJobInfo.TabIndex = 3
        Me.tabJobInfo.Text = "Job Information"
        Me.tabJobInfo.UseVisualStyleBackColor = True
        '
        'flowJobInfo
        '
        Me.flowJobInfo.AutoSize = True
        Me.flowJobInfo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.flowJobInfo.Controls.Add(Me.tableJobInfo)
        Me.flowJobInfo.Controls.Add(Me.tableJobInfoTarget)
        Me.flowJobInfo.Dock = System.Windows.Forms.DockStyle.Top
        Me.flowJobInfo.Location = New System.Drawing.Point(0, 0)
        Me.flowJobInfo.Name = "flowJobInfo"
        Me.flowJobInfo.Size = New System.Drawing.Size(730, 375)
        Me.flowJobInfo.TabIndex = 0
        '
        'tableJobInfo
        '
        Me.tableJobInfo.AutoSize = True
        Me.tableJobInfo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tableJobInfo.ColumnCount = 2
        Me.tableJobInfo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tableJobInfo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tableJobInfo.Controls.Add(Me.Label26, 0, 0)
        Me.tableJobInfo.Controls.Add(Me.Label27, 0, 1)
        Me.tableJobInfo.Controls.Add(Me.txtTemplateName, 1, 2)
        Me.tableJobInfo.Controls.Add(Me.Label25, 0, 2)
        Me.tableJobInfo.Controls.Add(Me.txtProjectName, 1, 1)
        Me.tableJobInfo.Controls.Add(Me.txtJobName, 1, 0)
        Me.flowJobInfo.SetFlowBreak(Me.tableJobInfo, True)
        Me.tableJobInfo.Location = New System.Drawing.Point(3, 3)
        Me.tableJobInfo.Name = "tableJobInfo"
        Me.tableJobInfo.RowCount = 3
        Me.tableJobInfo.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableJobInfo.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableJobInfo.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableJobInfo.Size = New System.Drawing.Size(348, 92)
        Me.tableJobInfo.TabIndex = 0
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(4, 0)
        Me.Label26.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(81, 17)
        Me.Label26.TabIndex = 21
        Me.Label26.Text = "Job Name*:"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(4, 30)
        Me.Label27.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(97, 17)
        Me.Label27.TabIndex = 24
        Me.Label27.Text = "Project Name:"
        '
        'txtTemplateName
        '
        Me.txtTemplateName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtTemplateName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtTemplateName.DropDownWidth = 375
        Me.txtTemplateName.FormattingEnabled = True
        Me.txtTemplateName.Items.AddRange(New Object() {"coll-evtx", "Drop Process by PID", "ETM Relative Time Query", "EXE-Metadata-Cerb", "Lockdown NIC", "LockdownEnableNIC", "Memory Acquisition", "Memory Analysis", "Registry-Autostart", "Registry-Full", "Remediate-Name", "Remediate-PID", "Small-exes-Cerb", "Software Inventory", "Vol-Deep", "Vol-Deep-Cerb", "Vol-Hidden-Cerb", "Vol-Hidden-Injected", "Vol-Quick", "Vol-Quick-Cerb", "Vol-Quick-Sched"})
        Me.txtTemplateName.Location = New System.Drawing.Point(124, 64)
        Me.txtTemplateName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTemplateName.Name = "txtTemplateName"
        Me.txtTemplateName.Size = New System.Drawing.Size(220, 24)
        Me.txtTemplateName.Sorted = True
        Me.txtTemplateName.TabIndex = 2
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(4, 60)
        Me.Label25.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(112, 17)
        Me.Label25.TabIndex = 25
        Me.Label25.Text = "Template Name:"
        '
        'txtProjectName
        '
        Me.txtProjectName.Location = New System.Drawing.Point(124, 34)
        Me.txtProjectName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtProjectName.Name = "txtProjectName"
        Me.txtProjectName.Size = New System.Drawing.Size(220, 22)
        Me.txtProjectName.TabIndex = 1
        '
        'txtJobName
        '
        Me.txtJobName.Location = New System.Drawing.Point(124, 4)
        Me.txtJobName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtJobName.Name = "txtJobName"
        Me.txtJobName.Size = New System.Drawing.Size(220, 22)
        Me.txtJobName.TabIndex = 0
        '
        'tableJobInfoTarget
        '
        Me.tableJobInfoTarget.AutoSize = True
        Me.tableJobInfoTarget.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tableJobInfoTarget.ColumnCount = 2
        Me.tableJobInfoTarget.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tableJobInfoTarget.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tableJobInfoTarget.Controls.Add(Me.grpJobTargetSelect, 0, 0)
        Me.tableJobInfoTarget.Controls.Add(Me.grpshare, 1, 1)
        Me.tableJobInfoTarget.Controls.Add(Me.grpagent, 0, 1)
        Me.tableJobInfoTarget.Location = New System.Drawing.Point(3, 101)
        Me.tableJobInfoTarget.Name = "tableJobInfoTarget"
        Me.tableJobInfoTarget.RowCount = 2
        Me.tableJobInfoTarget.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableJobInfoTarget.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableJobInfoTarget.Size = New System.Drawing.Size(673, 271)
        Me.tableJobInfoTarget.TabIndex = 1
        '
        'grpJobTargetSelect
        '
        Me.grpJobTargetSelect.AutoSize = True
        Me.grpJobTargetSelect.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tableJobInfoTarget.SetColumnSpan(Me.grpJobTargetSelect, 2)
        Me.grpJobTargetSelect.Controls.Add(Me.rdoagent)
        Me.grpJobTargetSelect.Controls.Add(Me.rdoshare)
        Me.grpJobTargetSelect.Dock = System.Windows.Forms.DockStyle.Top
        Me.grpJobTargetSelect.Location = New System.Drawing.Point(4, 4)
        Me.grpJobTargetSelect.Margin = New System.Windows.Forms.Padding(4)
        Me.grpJobTargetSelect.Name = "grpJobTargetSelect"
        Me.grpJobTargetSelect.Padding = New System.Windows.Forms.Padding(4)
        Me.grpJobTargetSelect.Size = New System.Drawing.Size(665, 67)
        Me.grpJobTargetSelect.TabIndex = 0
        Me.grpJobTargetSelect.TabStop = False
        Me.grpJobTargetSelect.Text = "Job Targets"
        '
        'rdoagent
        '
        Me.rdoagent.AutoSize = True
        Me.rdoagent.Checked = True
        Me.rdoagent.Location = New System.Drawing.Point(8, 23)
        Me.rdoagent.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoagent.Name = "rdoagent"
        Me.rdoagent.Size = New System.Drawing.Size(126, 21)
        Me.rdoagent.TabIndex = 0
        Me.rdoagent.TabStop = True
        Me.rdoagent.Text = "Agent Endpoint"
        Me.rdoagent.UseVisualStyleBackColor = True
        '
        'rdoshare
        '
        Me.rdoshare.AutoSize = True
        Me.rdoshare.Location = New System.Drawing.Point(300, 23)
        Me.rdoshare.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoshare.Name = "rdoshare"
        Me.rdoshare.Size = New System.Drawing.Size(122, 21)
        Me.rdoshare.TabIndex = 13
        Me.rdoshare.Text = "Network Share"
        Me.rdoshare.UseVisualStyleBackColor = True
        '
        'grpshare
        '
        Me.grpshare.Controls.Add(Me.tableNetworkShares)
        Me.grpshare.Location = New System.Drawing.Point(304, 79)
        Me.grpshare.Margin = New System.Windows.Forms.Padding(4)
        Me.grpshare.Name = "grpshare"
        Me.grpshare.Padding = New System.Windows.Forms.Padding(4)
        Me.grpshare.Size = New System.Drawing.Size(365, 188)
        Me.grpshare.TabIndex = 11
        Me.grpshare.TabStop = False
        Me.grpshare.Text = "Network Shares"
        '
        'tableNetworkShares
        '
        Me.tableNetworkShares.AutoSize = True
        Me.tableNetworkShares.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tableNetworkShares.ColumnCount = 2
        Me.tableNetworkShares.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tableNetworkShares.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tableNetworkShares.Controls.Add(Me.btnRemoveNetShare, 1, 2)
        Me.tableNetworkShares.Controls.Add(Me.lstNetShare, 0, 2)
        Me.tableNetworkShares.Controls.Add(Me.Label6, 0, 0)
        Me.tableNetworkShares.Controls.Add(Me.btnAddNetShare, 1, 1)
        Me.tableNetworkShares.Controls.Add(Me.txtNetSharePath, 0, 1)
        Me.tableNetworkShares.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tableNetworkShares.Location = New System.Drawing.Point(4, 19)
        Me.tableNetworkShares.Name = "tableNetworkShares"
        Me.tableNetworkShares.RowCount = 3
        Me.tableNetworkShares.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableNetworkShares.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableNetworkShares.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableNetworkShares.Size = New System.Drawing.Size(357, 165)
        Me.tableNetworkShares.TabIndex = 28
        '
        'btnRemoveNetShare
        '
        Me.btnRemoveNetShare.Location = New System.Drawing.Point(208, 57)
        Me.btnRemoveNetShare.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRemoveNetShare.Name = "btnRemoveNetShare"
        Me.btnRemoveNetShare.Size = New System.Drawing.Size(100, 28)
        Me.btnRemoveNetShare.TabIndex = 3
        Me.btnRemoveNetShare.TabStop = False
        Me.btnRemoveNetShare.Text = "Remove"
        Me.btnRemoveNetShare.UseVisualStyleBackColor = True
        '
        'lstNetShare
        '
        Me.lstNetShare.FormattingEnabled = True
        Me.lstNetShare.Location = New System.Drawing.Point(4, 57)
        Me.lstNetShare.Margin = New System.Windows.Forms.Padding(4)
        Me.lstNetShare.Name = "lstNetShare"
        Me.lstNetShare.Size = New System.Drawing.Size(196, 106)
        Me.lstNetShare.TabIndex = 4
        Me.lstNetShare.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(4, 0)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 17)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Path:"
        '
        'btnAddNetShare
        '
        Me.btnAddNetShare.Location = New System.Drawing.Point(208, 21)
        Me.btnAddNetShare.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAddNetShare.Name = "btnAddNetShare"
        Me.btnAddNetShare.Size = New System.Drawing.Size(100, 28)
        Me.btnAddNetShare.TabIndex = 2
        Me.btnAddNetShare.Text = "Add Computer"
        Me.btnAddNetShare.UseVisualStyleBackColor = True
        '
        'txtNetSharePath
        '
        Me.txtNetSharePath.Location = New System.Drawing.Point(4, 21)
        Me.txtNetSharePath.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNetSharePath.Name = "txtNetSharePath"
        Me.txtNetSharePath.Size = New System.Drawing.Size(196, 22)
        Me.txtNetSharePath.TabIndex = 5
        '
        'grpagent
        '
        Me.grpagent.Controls.Add(Me.tableComputerTargets)
        Me.grpagent.Location = New System.Drawing.Point(4, 79)
        Me.grpagent.Margin = New System.Windows.Forms.Padding(4)
        Me.grpagent.Name = "grpagent"
        Me.grpagent.Padding = New System.Windows.Forms.Padding(4)
        Me.grpagent.Size = New System.Drawing.Size(292, 188)
        Me.grpagent.TabIndex = 1
        Me.grpagent.TabStop = False
        Me.grpagent.Text = "Computer Targets"
        '
        'tableComputerTargets
        '
        Me.tableComputerTargets.AutoSize = True
        Me.tableComputerTargets.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tableComputerTargets.ColumnCount = 2
        Me.tableComputerTargets.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tableComputerTargets.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tableComputerTargets.Controls.Add(Me.btnRemoveComputer, 1, 2)
        Me.tableComputerTargets.Controls.Add(Me.lstComputerTargets, 0, 2)
        Me.tableComputerTargets.Controls.Add(Me.Label1, 0, 0)
        Me.tableComputerTargets.Controls.Add(Me.btnAddComputer, 1, 1)
        Me.tableComputerTargets.Controls.Add(Me.txtComputerTarget, 0, 1)
        Me.tableComputerTargets.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tableComputerTargets.Location = New System.Drawing.Point(4, 19)
        Me.tableComputerTargets.Name = "tableComputerTargets"
        Me.tableComputerTargets.RowCount = 3
        Me.tableComputerTargets.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableComputerTargets.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableComputerTargets.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableComputerTargets.Size = New System.Drawing.Size(284, 165)
        Me.tableComputerTargets.TabIndex = 28
        '
        'btnRemoveComputer
        '
        Me.btnRemoveComputer.Location = New System.Drawing.Point(171, 57)
        Me.btnRemoveComputer.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRemoveComputer.Name = "btnRemoveComputer"
        Me.btnRemoveComputer.Size = New System.Drawing.Size(100, 28)
        Me.btnRemoveComputer.TabIndex = 3
        Me.btnRemoveComputer.TabStop = False
        Me.btnRemoveComputer.Text = "Remove"
        Me.btnRemoveComputer.UseVisualStyleBackColor = True
        '
        'lstComputerTargets
        '
        Me.lstComputerTargets.FormattingEnabled = True
        Me.lstComputerTargets.Location = New System.Drawing.Point(4, 57)
        Me.lstComputerTargets.Margin = New System.Windows.Forms.Padding(4)
        Me.lstComputerTargets.Name = "lstComputerTargets"
        Me.lstComputerTargets.Size = New System.Drawing.Size(159, 106)
        Me.lstComputerTargets.TabIndex = 4
        Me.lstComputerTargets.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 17)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Hostname:"
        '
        'btnAddComputer
        '
        Me.btnAddComputer.Location = New System.Drawing.Point(171, 21)
        Me.btnAddComputer.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAddComputer.Name = "btnAddComputer"
        Me.btnAddComputer.Size = New System.Drawing.Size(100, 28)
        Me.btnAddComputer.TabIndex = 1
        Me.btnAddComputer.Text = "Add Computer"
        Me.btnAddComputer.UseVisualStyleBackColor = True
        '
        'txtComputerTarget
        '
        Me.txtComputerTarget.Location = New System.Drawing.Point(4, 21)
        Me.txtComputerTarget.Margin = New System.Windows.Forms.Padding(4)
        Me.txtComputerTarget.Name = "txtComputerTarget"
        Me.txtComputerTarget.Size = New System.Drawing.Size(159, 22)
        Me.txtComputerTarget.TabIndex = 0
        '
        'tabFilters
        '
        Me.tabFilters.Controls.Add(Me.tableFilters)
        Me.tabFilters.Location = New System.Drawing.Point(4, 28)
        Me.tabFilters.Margin = New System.Windows.Forms.Padding(4)
        Me.tabFilters.Name = "tabFilters"
        Me.tabFilters.Padding = New System.Windows.Forms.Padding(4)
        Me.tabFilters.Size = New System.Drawing.Size(730, 578)
        Me.tabFilters.TabIndex = 1
        Me.tabFilters.Text = "Filters"
        Me.tabFilters.UseVisualStyleBackColor = True
        '
        'tableFilters
        '
        Me.tableFilters.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tableFilters.ColumnCount = 3
        Me.tableFilters.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tableFilters.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tableFilters.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tableFilters.Controls.Add(Me.tabFiltersSubMenu, 0, 0)
        Me.tableFilters.Controls.Add(Me.btnFilters_Remove, 2, 1)
        Me.tableFilters.Controls.Add(Me.btnFilters_Save, 1, 1)
        Me.tableFilters.Controls.Add(Me.btnFilters_Add, 0, 1)
        Me.tableFilters.Controls.Add(Me.dgvFilters, 0, 2)
        Me.tableFilters.Location = New System.Drawing.Point(3, 3)
        Me.tableFilters.Name = "tableFilters"
        Me.tableFilters.RowCount = 3
        Me.tableFilters.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableFilters.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableFilters.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableFilters.Size = New System.Drawing.Size(721, 570)
        Me.tableFilters.TabIndex = 1
        '
        'tabFiltersSubMenu
        '
        Me.tableFilters.SetColumnSpan(Me.tabFiltersSubMenu, 3)
        Me.tabFiltersSubMenu.Controls.Add(Me.tabInclusionFilter)
        Me.tabFiltersSubMenu.Controls.Add(Me.tabExclusionFilter)
        Me.tabFiltersSubMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.tabFiltersSubMenu.Location = New System.Drawing.Point(4, 4)
        Me.tabFiltersSubMenu.Margin = New System.Windows.Forms.Padding(4)
        Me.tabFiltersSubMenu.Name = "tabFiltersSubMenu"
        Me.tabFiltersSubMenu.SelectedIndex = 0
        Me.tabFiltersSubMenu.Size = New System.Drawing.Size(717, 340)
        Me.tabFiltersSubMenu.TabIndex = 0
        '
        'tabInclusionFilter
        '
        Me.tabInclusionFilter.Controls.Add(Me.tableInclusionFilters)
        Me.tabInclusionFilter.Location = New System.Drawing.Point(4, 25)
        Me.tabInclusionFilter.Margin = New System.Windows.Forms.Padding(4)
        Me.tabInclusionFilter.Name = "tabInclusionFilter"
        Me.tabInclusionFilter.Padding = New System.Windows.Forms.Padding(4)
        Me.tabInclusionFilter.Size = New System.Drawing.Size(709, 311)
        Me.tabInclusionFilter.TabIndex = 0
        Me.tabInclusionFilter.Text = "Inclusion"
        Me.tabInclusionFilter.UseVisualStyleBackColor = True
        '
        'tableInclusionFilters
        '
        Me.tableInclusionFilters.AutoSize = True
        Me.tableInclusionFilters.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tableInclusionFilters.ColumnCount = 4
        Me.tableInclusionFilters.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tableInclusionFilters.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tableInclusionFilters.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tableInclusionFilters.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tableInclusionFilters.Controls.Add(Me.Label8, 0, 0)
        Me.tableInclusionFilters.Controls.Add(Me.txtinclkeywords, 2, 4)
        Me.tableInclusionFilters.Controls.Add(Me.txtinclfiltername, 1, 0)
        Me.tableInclusionFilters.Controls.Add(Me.txtinclmd5hash, 0, 4)
        Me.tableInclusionFilters.Controls.Add(Me.Label9, 2, 3)
        Me.tableInclusionFilters.Controls.Add(Me.Label23, 1, 3)
        Me.tableInclusionFilters.Controls.Add(Me.Label11, 2, 0)
        Me.tableInclusionFilters.Controls.Add(Me.txtinclextensions, 3, 0)
        Me.tableInclusionFilters.Controls.Add(Me.Label10, 0, 1)
        Me.tableInclusionFilters.Controls.Add(Me.txtinclpathcontains, 1, 1)
        Me.tableInclusionFilters.Controls.Add(Me.chkinclsearchfilename, 3, 3)
        Me.tableInclusionFilters.Controls.Add(Me.rdoinclregexsearch, 3, 2)
        Me.tableInclusionFilters.Controls.Add(Me.rdoinclsimplesearch, 2, 2)
        Me.tableInclusionFilters.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tableInclusionFilters.Location = New System.Drawing.Point(4, 4)
        Me.tableInclusionFilters.Name = "tableInclusionFilters"
        Me.tableInclusionFilters.RowCount = 5
        Me.tableInclusionFilters.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableInclusionFilters.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableInclusionFilters.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableInclusionFilters.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableInclusionFilters.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableInclusionFilters.Size = New System.Drawing.Size(701, 303)
        Me.tableInclusionFilters.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(4, 0)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 17)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Filter Name:"
        '
        'txtinclkeywords
        '
        Me.tableInclusionFilters.SetColumnSpan(Me.txtinclkeywords, 2)
        Me.txtinclkeywords.Location = New System.Drawing.Point(365, 124)
        Me.txtinclkeywords.Margin = New System.Windows.Forms.Padding(4)
        Me.txtinclkeywords.Multiline = True
        Me.txtinclkeywords.Name = "txtinclkeywords"
        Me.txtinclkeywords.Size = New System.Drawing.Size(316, 175)
        Me.txtinclkeywords.TabIndex = 6
        '
        'txtinclfiltername
        '
        Me.txtinclfiltername.Location = New System.Drawing.Point(112, 4)
        Me.txtinclfiltername.Margin = New System.Windows.Forms.Padding(4)
        Me.txtinclfiltername.Name = "txtinclfiltername"
        Me.txtinclfiltername.Size = New System.Drawing.Size(245, 22)
        Me.txtinclfiltername.TabIndex = 0
        '
        'txtinclmd5hash
        '
        Me.tableInclusionFilters.SetColumnSpan(Me.txtinclmd5hash, 2)
        Me.txtinclmd5hash.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtinclmd5hash.Location = New System.Drawing.Point(4, 124)
        Me.txtinclmd5hash.Margin = New System.Windows.Forms.Padding(4)
        Me.txtinclmd5hash.Multiline = True
        Me.txtinclmd5hash.Name = "txtinclmd5hash"
        Me.txtinclmd5hash.Size = New System.Drawing.Size(353, 175)
        Me.txtinclmd5hash.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(365, 91)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 17)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Keywords:"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(112, 91)
        Me.Label23.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(78, 17)
        Me.Label23.TabIndex = 9
        Me.Label23.Text = "MD5 Hash:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(365, 0)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 17)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "Extensions:"
        '
        'txtinclextensions
        '
        Me.txtinclextensions.Location = New System.Drawing.Point(493, 4)
        Me.txtinclextensions.Margin = New System.Windows.Forms.Padding(4)
        Me.txtinclextensions.Name = "txtinclextensions"
        Me.txtinclextensions.Size = New System.Drawing.Size(188, 22)
        Me.txtinclextensions.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(4, 30)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(100, 17)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Path Contains:"
        '
        'txtinclpathcontains
        '
        Me.tableInclusionFilters.SetColumnSpan(Me.txtinclpathcontains, 3)
        Me.txtinclpathcontains.Location = New System.Drawing.Point(112, 34)
        Me.txtinclpathcontains.Margin = New System.Windows.Forms.Padding(4)
        Me.txtinclpathcontains.Multiline = True
        Me.txtinclpathcontains.Name = "txtinclpathcontains"
        Me.txtinclpathcontains.Size = New System.Drawing.Size(569, 24)
        Me.txtinclpathcontains.TabIndex = 2
        '
        'chkinclsearchfilename
        '
        Me.chkinclsearchfilename.AutoSize = True
        Me.chkinclsearchfilename.Location = New System.Drawing.Point(493, 95)
        Me.chkinclsearchfilename.Margin = New System.Windows.Forms.Padding(4)
        Me.chkinclsearchfilename.Name = "chkinclsearchfilename"
        Me.chkinclsearchfilename.Size = New System.Drawing.Size(171, 21)
        Me.chkinclsearchfilename.TabIndex = 5
        Me.chkinclsearchfilename.Text = "Search FileName Only"
        Me.chkinclsearchfilename.UseVisualStyleBackColor = True
        '
        'rdoinclregexsearch
        '
        Me.rdoinclregexsearch.AutoSize = True
        Me.rdoinclregexsearch.Location = New System.Drawing.Point(493, 66)
        Me.rdoinclregexsearch.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoinclregexsearch.Name = "rdoinclregexsearch"
        Me.rdoinclregexsearch.Size = New System.Drawing.Size(119, 21)
        Me.rdoinclregexsearch.TabIndex = 13
        Me.rdoinclregexsearch.Text = "RegEx Search"
        Me.rdoinclregexsearch.UseVisualStyleBackColor = True
        '
        'rdoinclsimplesearch
        '
        Me.rdoinclsimplesearch.AutoSize = True
        Me.rdoinclsimplesearch.Checked = True
        Me.rdoinclsimplesearch.Location = New System.Drawing.Point(365, 66)
        Me.rdoinclsimplesearch.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoinclsimplesearch.Name = "rdoinclsimplesearch"
        Me.rdoinclsimplesearch.Size = New System.Drawing.Size(120, 21)
        Me.rdoinclsimplesearch.TabIndex = 4
        Me.rdoinclsimplesearch.TabStop = True
        Me.rdoinclsimplesearch.Text = "Simple Search"
        Me.rdoinclsimplesearch.UseVisualStyleBackColor = True
        '
        'tabExclusionFilter
        '
        Me.tabExclusionFilter.Controls.Add(Me.tableExclusionFilters)
        Me.tabExclusionFilter.Location = New System.Drawing.Point(4, 25)
        Me.tabExclusionFilter.Margin = New System.Windows.Forms.Padding(4)
        Me.tabExclusionFilter.Name = "tabExclusionFilter"
        Me.tabExclusionFilter.Padding = New System.Windows.Forms.Padding(4)
        Me.tabExclusionFilter.Size = New System.Drawing.Size(709, 311)
        Me.tabExclusionFilter.TabIndex = 1
        Me.tabExclusionFilter.Text = "Exclusion"
        Me.tabExclusionFilter.UseVisualStyleBackColor = True
        '
        'tableExclusionFilters
        '
        Me.tableExclusionFilters.AutoSize = True
        Me.tableExclusionFilters.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tableExclusionFilters.ColumnCount = 4
        Me.tableExclusionFilters.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tableExclusionFilters.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tableExclusionFilters.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tableExclusionFilters.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tableExclusionFilters.Controls.Add(Me.Label15, 0, 0)
        Me.tableExclusionFilters.Controls.Add(Me.txtexclmd5hash, 0, 3)
        Me.tableExclusionFilters.Controls.Add(Me.Label24, 1, 2)
        Me.tableExclusionFilters.Controls.Add(Me.txtexclfiltername, 1, 0)
        Me.tableExclusionFilters.Controls.Add(Me.Label12, 2, 0)
        Me.tableExclusionFilters.Controls.Add(Me.txtexclpathcontains, 1, 1)
        Me.tableExclusionFilters.Controls.Add(Me.txtexclextensions, 3, 0)
        Me.tableExclusionFilters.Controls.Add(Me.Label13, 0, 1)
        Me.tableExclusionFilters.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tableExclusionFilters.Location = New System.Drawing.Point(4, 4)
        Me.tableExclusionFilters.Name = "tableExclusionFilters"
        Me.tableExclusionFilters.RowCount = 4
        Me.tableExclusionFilters.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableExclusionFilters.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableExclusionFilters.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableExclusionFilters.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableExclusionFilters.Size = New System.Drawing.Size(701, 303)
        Me.tableExclusionFilters.TabIndex = 18
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(4, 0)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(84, 17)
        Me.Label15.TabIndex = 8
        Me.Label15.Text = "Filter Name:"
        '
        'txtexclmd5hash
        '
        Me.tableExclusionFilters.SetColumnSpan(Me.txtexclmd5hash, 2)
        Me.txtexclmd5hash.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtexclmd5hash.Location = New System.Drawing.Point(4, 83)
        Me.txtexclmd5hash.Margin = New System.Windows.Forms.Padding(4)
        Me.txtexclmd5hash.Multiline = True
        Me.txtexclmd5hash.Name = "txtexclmd5hash"
        Me.txtexclmd5hash.Size = New System.Drawing.Size(353, 216)
        Me.txtexclmd5hash.TabIndex = 3
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(112, 62)
        Me.Label24.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(78, 17)
        Me.Label24.TabIndex = 17
        Me.Label24.Text = "MD5 Hash:"
        '
        'txtexclfiltername
        '
        Me.txtexclfiltername.Location = New System.Drawing.Point(112, 4)
        Me.txtexclfiltername.Margin = New System.Windows.Forms.Padding(4)
        Me.txtexclfiltername.Name = "txtexclfiltername"
        Me.txtexclfiltername.Size = New System.Drawing.Size(245, 22)
        Me.txtexclfiltername.TabIndex = 0
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(365, 0)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(80, 17)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "Extensions:"
        '
        'txtexclpathcontains
        '
        Me.tableExclusionFilters.SetColumnSpan(Me.txtexclpathcontains, 3)
        Me.txtexclpathcontains.Location = New System.Drawing.Point(112, 34)
        Me.txtexclpathcontains.Margin = New System.Windows.Forms.Padding(4)
        Me.txtexclpathcontains.Multiline = True
        Me.txtexclpathcontains.Name = "txtexclpathcontains"
        Me.txtexclpathcontains.Size = New System.Drawing.Size(585, 24)
        Me.txtexclpathcontains.TabIndex = 2
        '
        'txtexclextensions
        '
        Me.txtexclextensions.Location = New System.Drawing.Point(453, 4)
        Me.txtexclextensions.Margin = New System.Windows.Forms.Padding(4)
        Me.txtexclextensions.Name = "txtexclextensions"
        Me.txtexclextensions.Size = New System.Drawing.Size(244, 22)
        Me.txtexclextensions.TabIndex = 1
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(4, 30)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(100, 17)
        Me.Label13.TabIndex = 13
        Me.Label13.Text = "Path Contains:"
        '
        'btnFilters_Remove
        '
        Me.btnFilters_Remove.Location = New System.Drawing.Point(220, 352)
        Me.btnFilters_Remove.Margin = New System.Windows.Forms.Padding(4)
        Me.btnFilters_Remove.Name = "btnFilters_Remove"
        Me.btnFilters_Remove.Size = New System.Drawing.Size(100, 28)
        Me.btnFilters_Remove.TabIndex = 5
        Me.btnFilters_Remove.TabStop = False
        Me.btnFilters_Remove.Text = "Remove"
        Me.btnFilters_Remove.UseVisualStyleBackColor = True
        '
        'btnFilters_Save
        '
        Me.btnFilters_Save.Location = New System.Drawing.Point(112, 352)
        Me.btnFilters_Save.Margin = New System.Windows.Forms.Padding(4)
        Me.btnFilters_Save.Name = "btnFilters_Save"
        Me.btnFilters_Save.Size = New System.Drawing.Size(100, 28)
        Me.btnFilters_Save.TabIndex = 5
        Me.btnFilters_Save.TabStop = False
        Me.btnFilters_Save.Text = "Save"
        Me.btnFilters_Save.UseVisualStyleBackColor = True
        '
        'btnFilters_Add
        '
        Me.btnFilters_Add.Location = New System.Drawing.Point(4, 352)
        Me.btnFilters_Add.Margin = New System.Windows.Forms.Padding(4)
        Me.btnFilters_Add.Name = "btnFilters_Add"
        Me.btnFilters_Add.Size = New System.Drawing.Size(100, 28)
        Me.btnFilters_Add.TabIndex = 1
        Me.btnFilters_Add.Text = "Add"
        Me.btnFilters_Add.UseVisualStyleBackColor = True
        '
        'dgvFilters
        '
        Me.dgvFilters.AllowUserToAddRows = False
        Me.dgvFilters.AllowUserToDeleteRows = False
        Me.dgvFilters.AllowUserToResizeRows = False
        Me.dgvFilters.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvFilters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFilters.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colFilterCheck, Me.col_FilterType, Me.colFilterName})
        Me.tableFilters.SetColumnSpan(Me.dgvFilters, 3)
        Me.dgvFilters.Location = New System.Drawing.Point(3, 387)
        Me.dgvFilters.MultiSelect = False
        Me.dgvFilters.Name = "dgvFilters"
        Me.dgvFilters.RowHeadersVisible = False
        Me.dgvFilters.RowTemplate.Height = 24
        Me.dgvFilters.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvFilters.Size = New System.Drawing.Size(714, 174)
        Me.dgvFilters.TabIndex = 6
        '
        'colFilterCheck
        '
        Me.colFilterCheck.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.colFilterCheck.HeaderText = "Select"
        Me.colFilterCheck.Name = "colFilterCheck"
        Me.colFilterCheck.Width = 53
        '
        'col_FilterType
        '
        Me.col_FilterType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.col_FilterType.HeaderText = "Type"
        Me.col_FilterType.Name = "col_FilterType"
        Me.col_FilterType.ReadOnly = True
        Me.col_FilterType.Width = 65
        '
        'colFilterName
        '
        Me.colFilterName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colFilterName.HeaderText = "Filter Name"
        Me.colFilterName.Name = "colFilterName"
        Me.colFilterName.ReadOnly = True
        '
        'tabAgentRemediation
        '
        Me.tabAgentRemediation.Controls.Add(Me.tableAgentRemediation)
        Me.tabAgentRemediation.Location = New System.Drawing.Point(4, 28)
        Me.tabAgentRemediation.Margin = New System.Windows.Forms.Padding(4)
        Me.tabAgentRemediation.Name = "tabAgentRemediation"
        Me.tabAgentRemediation.Size = New System.Drawing.Size(730, 578)
        Me.tabAgentRemediation.TabIndex = 2
        Me.tabAgentRemediation.Text = "Agent Remediation"
        Me.tabAgentRemediation.UseVisualStyleBackColor = True
        '
        'tableAgentRemediation
        '
        Me.tableAgentRemediation.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tableAgentRemediation.AutoSize = True
        Me.tableAgentRemediation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tableAgentRemediation.ColumnCount = 3
        Me.tableAgentRemediation.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tableAgentRemediation.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tableAgentRemediation.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tableAgentRemediation.Controls.Add(Me.lvRemOptions, 0, 2)
        Me.tableAgentRemediation.Controls.Add(Me.btnRemoveRemOption, 2, 1)
        Me.tableAgentRemediation.Controls.Add(Me.btnSaveRemOptionChange, 1, 1)
        Me.tableAgentRemediation.Controls.Add(Me.btnAddRemOption, 0, 1)
        Me.tableAgentRemediation.Controls.Add(Me.tabAgentRemediationSubMenu, 0, 0)
        Me.tableAgentRemediation.Location = New System.Drawing.Point(7, 3)
        Me.tableAgentRemediation.MinimumSize = New System.Drawing.Size(0, 375)
        Me.tableAgentRemediation.Name = "tableAgentRemediation"
        Me.tableAgentRemediation.RowCount = 3
        Me.tableAgentRemediation.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableAgentRemediation.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableAgentRemediation.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableAgentRemediation.Size = New System.Drawing.Size(669, 375)
        Me.tableAgentRemediation.TabIndex = 5
        '
        'lvRemOptions
        '
        Me.lvRemOptions.CheckBoxes = True
        Me.lvRemOptions.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colRemType, Me.colitem})
        Me.tableAgentRemediation.SetColumnSpan(Me.lvRemOptions, 3)
        Me.lvRemOptions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvRemOptions.FullRowSelect = True
        Me.lvRemOptions.GridLines = True
        Me.lvRemOptions.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvRemOptions.Location = New System.Drawing.Point(4, 205)
        Me.lvRemOptions.Margin = New System.Windows.Forms.Padding(4)
        Me.lvRemOptions.MultiSelect = False
        Me.lvRemOptions.Name = "lvRemOptions"
        Me.lvRemOptions.ShowGroups = False
        Me.lvRemOptions.Size = New System.Drawing.Size(661, 166)
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
        Me.colitem.Width = 50
        '
        'btnRemoveRemOption
        '
        Me.btnRemoveRemOption.Location = New System.Drawing.Point(220, 169)
        Me.btnRemoveRemOption.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRemoveRemOption.Name = "btnRemoveRemOption"
        Me.btnRemoveRemOption.Size = New System.Drawing.Size(100, 28)
        Me.btnRemoveRemOption.TabIndex = 3
        Me.btnRemoveRemOption.Text = "Remove"
        Me.btnRemoveRemOption.UseVisualStyleBackColor = True
        '
        'btnSaveRemOptionChange
        '
        Me.btnSaveRemOptionChange.Location = New System.Drawing.Point(112, 169)
        Me.btnSaveRemOptionChange.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSaveRemOptionChange.Name = "btnSaveRemOptionChange"
        Me.btnSaveRemOptionChange.Size = New System.Drawing.Size(100, 28)
        Me.btnSaveRemOptionChange.TabIndex = 4
        Me.btnSaveRemOptionChange.Text = "Save"
        Me.btnSaveRemOptionChange.UseVisualStyleBackColor = True
        '
        'btnAddRemOption
        '
        Me.btnAddRemOption.Location = New System.Drawing.Point(4, 169)
        Me.btnAddRemOption.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAddRemOption.Name = "btnAddRemOption"
        Me.btnAddRemOption.Size = New System.Drawing.Size(100, 28)
        Me.btnAddRemOption.TabIndex = 0
        Me.btnAddRemOption.Text = "Add"
        Me.btnAddRemOption.UseVisualStyleBackColor = True
        '
        'tabAgentRemediationSubMenu
        '
        Me.tabAgentRemediationSubMenu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tableAgentRemediation.SetColumnSpan(Me.tabAgentRemediationSubMenu, 3)
        Me.tabAgentRemediationSubMenu.Controls.Add(Me.tabAgentSendFile)
        Me.tabAgentRemediationSubMenu.Controls.Add(Me.tabAgentExecute)
        Me.tabAgentRemediationSubMenu.Controls.Add(Me.tabAgentDelete)
        Me.tabAgentRemediationSubMenu.Controls.Add(Me.TabAgentKill)
        Me.tabAgentRemediationSubMenu.Location = New System.Drawing.Point(4, 4)
        Me.tabAgentRemediationSubMenu.Margin = New System.Windows.Forms.Padding(4)
        Me.tabAgentRemediationSubMenu.Name = "tabAgentRemediationSubMenu"
        Me.tabAgentRemediationSubMenu.SelectedIndex = 0
        Me.tabAgentRemediationSubMenu.Size = New System.Drawing.Size(661, 157)
        Me.tabAgentRemediationSubMenu.TabIndex = 0
        '
        'tabAgentSendFile
        '
        Me.tabAgentSendFile.Controls.Add(Me.tableARSendFile)
        Me.tabAgentSendFile.Location = New System.Drawing.Point(4, 25)
        Me.tabAgentSendFile.Margin = New System.Windows.Forms.Padding(4)
        Me.tabAgentSendFile.Name = "tabAgentSendFile"
        Me.tabAgentSendFile.Padding = New System.Windows.Forms.Padding(4)
        Me.tabAgentSendFile.Size = New System.Drawing.Size(653, 128)
        Me.tabAgentSendFile.TabIndex = 0
        Me.tabAgentSendFile.Text = "Send File"
        Me.tabAgentSendFile.UseVisualStyleBackColor = True
        '
        'tableARSendFile
        '
        Me.tableARSendFile.AutoSize = True
        Me.tableARSendFile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tableARSendFile.ColumnCount = 2
        Me.tableARSendFile.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tableARSendFile.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tableARSendFile.Controls.Add(Me.Label16, 0, 0)
        Me.tableARSendFile.Controls.Add(Me.chkremsendexecute, 1, 2)
        Me.tableARSendFile.Controls.Add(Me.txtremsendsource, 1, 0)
        Me.tableARSendFile.Controls.Add(Me.chkremsenddelete, 0, 2)
        Me.tableARSendFile.Controls.Add(Me.Label17, 0, 1)
        Me.tableARSendFile.Controls.Add(Me.txtremsenddest, 1, 1)
        Me.tableARSendFile.Dock = System.Windows.Forms.DockStyle.Left
        Me.tableARSendFile.Location = New System.Drawing.Point(4, 4)
        Me.tableARSendFile.Name = "tableARSendFile"
        Me.tableARSendFile.RowCount = 3
        Me.tableARSendFile.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableARSendFile.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableARSendFile.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableARSendFile.Size = New System.Drawing.Size(475, 120)
        Me.tableARSendFile.TabIndex = 25
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(4, 0)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(125, 17)
        Me.Label16.TabIndex = 21
        Me.Label16.Text = "Source File Path*: "
        '
        'chkremsendexecute
        '
        Me.chkremsendexecute.AutoSize = True
        Me.chkremsendexecute.Location = New System.Drawing.Point(159, 64)
        Me.chkremsendexecute.Margin = New System.Windows.Forms.Padding(4)
        Me.chkremsendexecute.Name = "chkremsendexecute"
        Me.chkremsendexecute.Size = New System.Drawing.Size(80, 21)
        Me.chkremsendexecute.TabIndex = 2
        Me.chkremsendexecute.Text = "Execute"
        Me.chkremsendexecute.UseVisualStyleBackColor = True
        Me.chkremsendexecute.Visible = False
        '
        'txtremsendsource
        '
        Me.txtremsendsource.Location = New System.Drawing.Point(159, 4)
        Me.txtremsendsource.Margin = New System.Windows.Forms.Padding(4)
        Me.txtremsendsource.Name = "txtremsendsource"
        Me.txtremsendsource.Size = New System.Drawing.Size(312, 22)
        Me.txtremsendsource.TabIndex = 0
        '
        'chkremsenddelete
        '
        Me.chkremsenddelete.AutoSize = True
        Me.chkremsenddelete.Location = New System.Drawing.Point(4, 64)
        Me.chkremsenddelete.Margin = New System.Windows.Forms.Padding(4)
        Me.chkremsenddelete.Name = "chkremsenddelete"
        Me.chkremsenddelete.Size = New System.Drawing.Size(97, 21)
        Me.chkremsenddelete.TabIndex = 24
        Me.chkremsenddelete.Text = "Delete File"
        Me.chkremsenddelete.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(4, 30)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(147, 17)
        Me.Label17.TabIndex = 23
        Me.Label17.Text = "Destination File Path*:"
        '
        'txtremsenddest
        '
        Me.txtremsenddest.Location = New System.Drawing.Point(159, 34)
        Me.txtremsenddest.Margin = New System.Windows.Forms.Padding(4)
        Me.txtremsenddest.Name = "txtremsenddest"
        Me.txtremsenddest.Size = New System.Drawing.Size(312, 22)
        Me.txtremsenddest.TabIndex = 1
        '
        'tabAgentExecute
        '
        Me.tabAgentExecute.Controls.Add(Me.tableARExecute)
        Me.tabAgentExecute.Location = New System.Drawing.Point(4, 25)
        Me.tabAgentExecute.Margin = New System.Windows.Forms.Padding(4)
        Me.tabAgentExecute.Name = "tabAgentExecute"
        Me.tabAgentExecute.Padding = New System.Windows.Forms.Padding(4)
        Me.tabAgentExecute.Size = New System.Drawing.Size(653, 128)
        Me.tabAgentExecute.TabIndex = 1
        Me.tabAgentExecute.Text = "Execute"
        Me.tabAgentExecute.UseVisualStyleBackColor = True
        '
        'tableARExecute
        '
        Me.tableARExecute.AutoSize = True
        Me.tableARExecute.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tableARExecute.ColumnCount = 2
        Me.tableARExecute.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tableARExecute.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tableARExecute.Controls.Add(Me.Label18, 0, 0)
        Me.tableARExecute.Controls.Add(Me.txtremexecargs, 1, 1)
        Me.tableARExecute.Controls.Add(Me.Label19, 0, 1)
        Me.tableARExecute.Controls.Add(Me.txtremexecpath, 1, 0)
        Me.tableARExecute.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tableARExecute.Location = New System.Drawing.Point(4, 4)
        Me.tableARExecute.Name = "tableARExecute"
        Me.tableARExecute.RowCount = 2
        Me.tableARExecute.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableARExecute.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableARExecute.Size = New System.Drawing.Size(645, 120)
        Me.tableARExecute.TabIndex = 26
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(4, 0)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(118, 17)
        Me.Label18.TabIndex = 23
        Me.Label18.Text = "Target File Path*:"
        '
        'txtremexecargs
        '
        Me.txtremexecargs.Location = New System.Drawing.Point(130, 34)
        Me.txtremexecargs.Margin = New System.Windows.Forms.Padding(4)
        Me.txtremexecargs.Name = "txtremexecargs"
        Me.txtremexecargs.Size = New System.Drawing.Size(312, 22)
        Me.txtremexecargs.TabIndex = 1
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(4, 30)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(80, 17)
        Me.Label19.TabIndex = 25
        Me.Label19.Text = "Arguments:"
        '
        'txtremexecpath
        '
        Me.txtremexecpath.Location = New System.Drawing.Point(130, 4)
        Me.txtremexecpath.Margin = New System.Windows.Forms.Padding(4)
        Me.txtremexecpath.Name = "txtremexecpath"
        Me.txtremexecpath.Size = New System.Drawing.Size(312, 22)
        Me.txtremexecpath.TabIndex = 0
        '
        'tabAgentDelete
        '
        Me.tabAgentDelete.Controls.Add(Me.tableARDelete)
        Me.tabAgentDelete.Location = New System.Drawing.Point(4, 25)
        Me.tabAgentDelete.Margin = New System.Windows.Forms.Padding(4)
        Me.tabAgentDelete.Name = "tabAgentDelete"
        Me.tabAgentDelete.Size = New System.Drawing.Size(653, 128)
        Me.tabAgentDelete.TabIndex = 2
        Me.tabAgentDelete.Text = "Delete File"
        Me.tabAgentDelete.UseVisualStyleBackColor = True
        '
        'tableARDelete
        '
        Me.tableARDelete.AutoSize = True
        Me.tableARDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tableARDelete.ColumnCount = 2
        Me.tableARDelete.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tableARDelete.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tableARDelete.Controls.Add(Me.Label20, 0, 0)
        Me.tableARDelete.Controls.Add(Me.txtremdelfilepath, 1, 0)
        Me.tableARDelete.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tableARDelete.Location = New System.Drawing.Point(0, 0)
        Me.tableARDelete.Name = "tableARDelete"
        Me.tableARDelete.RowCount = 2
        Me.tableARDelete.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableARDelete.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableARDelete.Size = New System.Drawing.Size(653, 128)
        Me.tableARDelete.TabIndex = 26
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(4, 0)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Padding = New System.Windows.Forms.Padding(4, 4, 0, 0)
        Me.Label20.Size = New System.Drawing.Size(122, 21)
        Me.Label20.TabIndex = 25
        Me.Label20.Text = "Target File Path*:"
        '
        'txtremdelfilepath
        '
        Me.txtremdelfilepath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtremdelfilepath.Location = New System.Drawing.Point(134, 4)
        Me.txtremdelfilepath.Margin = New System.Windows.Forms.Padding(4)
        Me.txtremdelfilepath.Name = "txtremdelfilepath"
        Me.txtremdelfilepath.Size = New System.Drawing.Size(312, 22)
        Me.txtremdelfilepath.TabIndex = 0
        '
        'TabAgentKill
        '
        Me.TabAgentKill.Controls.Add(Me.tableARKill)
        Me.TabAgentKill.Location = New System.Drawing.Point(4, 25)
        Me.TabAgentKill.Margin = New System.Windows.Forms.Padding(4)
        Me.TabAgentKill.Name = "TabAgentKill"
        Me.TabAgentKill.Size = New System.Drawing.Size(653, 128)
        Me.TabAgentKill.TabIndex = 3
        Me.TabAgentKill.Text = "Kill Process"
        Me.TabAgentKill.UseVisualStyleBackColor = True
        '
        'tableARKill
        '
        Me.tableARKill.AutoSize = True
        Me.tableARKill.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tableARKill.ColumnCount = 2
        Me.tableARKill.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tableARKill.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tableARKill.Controls.Add(Me.grpARKill, 0, 0)
        Me.tableARKill.Controls.Add(Me.txtremkillprocname, 1, 2)
        Me.tableARKill.Controls.Add(Me.Label21, 0, 1)
        Me.tableARKill.Controls.Add(Me.Label22, 0, 2)
        Me.tableARKill.Controls.Add(Me.nmbremkillprocid, 1, 1)
        Me.tableARKill.Location = New System.Drawing.Point(0, 0)
        Me.tableARKill.Name = "tableARKill"
        Me.tableARKill.RowCount = 3
        Me.tableARKill.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableARKill.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableARKill.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableARKill.Size = New System.Drawing.Size(432, 116)
        Me.tableARKill.TabIndex = 20
        '
        'grpARKill
        '
        Me.tableARKill.SetColumnSpan(Me.grpARKill, 2)
        Me.grpARKill.Controls.Add(Me.rdoPName)
        Me.grpARKill.Controls.Add(Me.rdoPID)
        Me.grpARKill.Location = New System.Drawing.Point(3, 3)
        Me.grpARKill.Name = "grpARKill"
        Me.grpARKill.Size = New System.Drawing.Size(267, 50)
        Me.grpARKill.TabIndex = 19
        Me.grpARKill.TabStop = False
        Me.grpARKill.Text = "Target"
        '
        'rdoPName
        '
        Me.rdoPName.AutoSize = True
        Me.rdoPName.Location = New System.Drawing.Point(139, 22)
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
        Me.rdoPID.Location = New System.Drawing.Point(7, 22)
        Me.rdoPID.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoPID.Name = "rdoPID"
        Me.rdoPID.Size = New System.Drawing.Size(97, 21)
        Me.rdoPID.TabIndex = 0
        Me.rdoPID.TabStop = True
        Me.rdoPID.Text = "Process ID"
        Me.rdoPID.UseVisualStyleBackColor = True
        '
        'txtremkillprocname
        '
        Me.txtremkillprocname.Location = New System.Drawing.Point(116, 90)
        Me.txtremkillprocname.Margin = New System.Windows.Forms.Padding(4)
        Me.txtremkillprocname.Name = "txtremkillprocname"
        Me.txtremkillprocname.Size = New System.Drawing.Size(312, 22)
        Me.txtremkillprocname.TabIndex = 2
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(4, 56)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(100, 17)
        Me.Label21.TabIndex = 12
        Me.Label21.Text = "By Process ID:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(4, 86)
        Me.Label22.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(104, 17)
        Me.Label22.TabIndex = 15
        Me.Label22.Text = "Process Name:"
        '
        'nmbremkillprocid
        '
        Me.nmbremkillprocid.Location = New System.Drawing.Point(116, 60)
        Me.nmbremkillprocid.Margin = New System.Windows.Forms.Padding(4)
        Me.nmbremkillprocid.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.nmbremkillprocid.Name = "nmbremkillprocid"
        Me.nmbremkillprocid.Size = New System.Drawing.Size(101, 22)
        Me.nmbremkillprocid.TabIndex = 1
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
        Me.tabMenu.Size = New System.Drawing.Size(758, 728)
        Me.tabMenu.TabIndex = 0
        '
        'tabSettings
        '
        Me.tabSettings.Controls.Add(Me.grpSettings)
        Me.tabSettings.Location = New System.Drawing.Point(4, 28)
        Me.tabSettings.Margin = New System.Windows.Forms.Padding(4)
        Me.tabSettings.Name = "tabSettings"
        Me.tabSettings.Padding = New System.Windows.Forms.Padding(4)
        Me.tabSettings.Size = New System.Drawing.Size(750, 696)
        Me.tabSettings.TabIndex = 1
        Me.tabSettings.Text = "Settings"
        Me.tabSettings.UseVisualStyleBackColor = True
        '
        'tabRESTUI
        '
        Me.tabRESTUI.Controls.Add(Me.tabControlJobsRest)
        Me.tabRESTUI.Location = New System.Drawing.Point(4, 28)
        Me.tabRESTUI.Name = "tabRESTUI"
        Me.tabRESTUI.Size = New System.Drawing.Size(750, 696)
        Me.tabRESTUI.TabIndex = 7
        Me.tabRESTUI.Text = "REST UI"
        Me.tabRESTUI.UseVisualStyleBackColor = True
        '
        'tabControlJobsRest
        '
        Me.tabControlJobsRest.Controls.Add(Me.tabTasks)
        Me.tabControlJobsRest.Controls.Add(Me.tabProjects)
        Me.tabControlJobsRest.Controls.Add(Me.tabJobsList)
        Me.tabControlJobsRest.Controls.Add(Me.tabAlerts)
        Me.tabControlJobsRest.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabControlJobsRest.Location = New System.Drawing.Point(0, 0)
        Me.tabControlJobsRest.Name = "tabControlJobsRest"
        Me.tabControlJobsRest.SelectedIndex = 0
        Me.tabControlJobsRest.Size = New System.Drawing.Size(750, 696)
        Me.tabControlJobsRest.TabIndex = 0
        '
        'tabTasks
        '
        Me.tabTasks.Controls.Add(Me.flowTasks)
        Me.tabTasks.Location = New System.Drawing.Point(4, 25)
        Me.tabTasks.Name = "tabTasks"
        Me.tabTasks.Size = New System.Drawing.Size(742, 667)
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
        Me.flowTasks.Size = New System.Drawing.Size(742, 667)
        Me.flowTasks.TabIndex = 0
        '
        'tabProjects
        '
        Me.tabProjects.Controls.Add(Me.splitProjects)
        Me.tabProjects.Location = New System.Drawing.Point(4, 25)
        Me.tabProjects.Name = "tabProjects"
        Me.tabProjects.Padding = New System.Windows.Forms.Padding(3)
        Me.tabProjects.Size = New System.Drawing.Size(742, 667)
        Me.tabProjects.TabIndex = 1
        Me.tabProjects.Text = "Projects"
        Me.tabProjects.UseVisualStyleBackColor = True
        '
        'splitProjects
        '
        Me.splitProjects.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitProjects.Location = New System.Drawing.Point(3, 3)
        Me.splitProjects.Name = "splitProjects"
        Me.splitProjects.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'splitProjects.Panel1
        '
        Me.splitProjects.Panel1.Controls.Add(Me.Label31)
        Me.splitProjects.Panel1.Controls.Add(Me.lvProjectFacets)
        '
        'splitProjects.Panel2
        '
        Me.splitProjects.Panel2.Controls.Add(Me.dgvProjectList)
        Me.splitProjects.Size = New System.Drawing.Size(736, 661)
        Me.splitProjects.SplitterDistance = 55
        Me.splitProjects.TabIndex = 0
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(3, 9)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(43, 17)
        Me.Label31.TabIndex = 7
        Me.Label31.Text = "Filter:"
        '
        'lvProjectFacets
        '
        Me.lvProjectFacets.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvProjectFacets.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvProjectFacets.GridLines = True
        Me.lvProjectFacets.Location = New System.Drawing.Point(52, 3)
        Me.lvProjectFacets.MultiSelect = False
        Me.lvProjectFacets.Name = "lvProjectFacets"
        Me.lvProjectFacets.Size = New System.Drawing.Size(681, 49)
        Me.lvProjectFacets.TabIndex = 6
        Me.lvProjectFacets.UseCompatibleStateImageBehavior = False
        Me.lvProjectFacets.View = System.Windows.Forms.View.List
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
        Me.dgvProjectList.Size = New System.Drawing.Size(736, 602)
        Me.dgvProjectList.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn1.FillWeight = 99.0!
        Me.DataGridViewTextBoxColumn1.HeaderText = "Project Name"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 108
        '
        'CreationDate
        '
        Me.CreationDate.FillWeight = 10.0!
        Me.CreationDate.HeaderText = "Creation Date"
        Me.CreationDate.Name = "CreationDate"
        Me.CreationDate.ReadOnly = True
        '
        'CreatedBy
        '
        Me.CreatedBy.FillWeight = 10.0!
        Me.CreatedBy.HeaderText = "Created By"
        Me.CreatedBy.Name = "CreatedBy"
        Me.CreatedBy.ReadOnly = True
        '
        'LastModDate
        '
        Me.LastModDate.FillWeight = 10.0!
        Me.LastModDate.HeaderText = "Last Modified Date"
        Me.LastModDate.Name = "LastModDate"
        Me.LastModDate.ReadOnly = True
        '
        'ProjectFolderPath
        '
        Me.ProjectFolderPath.FillWeight = 10.0!
        Me.ProjectFolderPath.HeaderText = "Project Folder Path"
        Me.ProjectFolderPath.Name = "ProjectFolderPath"
        Me.ProjectFolderPath.ReadOnly = True
        '
        'ProjectID
        '
        Me.ProjectID.FillWeight = 1.0!
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
        Me.tabJobsList.Size = New System.Drawing.Size(742, 667)
        Me.tabJobsList.TabIndex = 0
        Me.tabJobsList.Text = "Job Status"
        Me.tabJobsList.UseVisualStyleBackColor = True
        '
        'splitJobsRestJobs
        '
        Me.splitJobsRestJobs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitJobsRestJobs.Location = New System.Drawing.Point(3, 3)
        Me.splitJobsRestJobs.Name = "splitJobsRestJobs"
        Me.splitJobsRestJobs.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'splitJobsRestJobs.Panel1
        '
        Me.splitJobsRestJobs.Panel1.Controls.Add(Me.Label32)
        Me.splitJobsRestJobs.Panel1.Controls.Add(Me.lvJobStatusFacets)
        '
        'splitJobsRestJobs.Panel2
        '
        Me.splitJobsRestJobs.Panel2.Controls.Add(Me.dgvJobsRestJobsList)
        Me.splitJobsRestJobs.Size = New System.Drawing.Size(736, 661)
        Me.splitJobsRestJobs.SplitterDistance = 57
        Me.splitJobsRestJobs.TabIndex = 2
        '
        'dgvJobsRestJobsList
        '
        Me.dgvJobsRestJobsList.AllowUserToAddRows = False
        Me.dgvJobsRestJobsList.AllowUserToDeleteRows = False
        Me.dgvJobsRestJobsList.AllowUserToResizeRows = False
        Me.dgvJobsRestJobsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvJobsRestJobsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvJobsRestJobsList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.jobName, Me.jobStatus, Me.jobType, Me.jobStart, Me.jobEnd, Me.jobID, Me.jobResultID})
        Me.dgvJobsRestJobsList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvJobsRestJobsList.Location = New System.Drawing.Point(0, 0)
        Me.dgvJobsRestJobsList.MultiSelect = False
        Me.dgvJobsRestJobsList.Name = "dgvJobsRestJobsList"
        Me.dgvJobsRestJobsList.ReadOnly = True
        Me.dgvJobsRestJobsList.RowHeadersVisible = False
        Me.dgvJobsRestJobsList.RowTemplate.Height = 24
        Me.dgvJobsRestJobsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvJobsRestJobsList.Size = New System.Drawing.Size(736, 600)
        Me.dgvJobsRestJobsList.TabIndex = 0
        '
        'jobName
        '
        Me.jobName.FillWeight = 40.0!
        Me.jobName.HeaderText = "Name"
        Me.jobName.MinimumWidth = 117
        Me.jobName.Name = "jobName"
        Me.jobName.ReadOnly = True
        '
        'jobStatus
        '
        Me.jobStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.jobStatus.FillWeight = 5.0!
        Me.jobStatus.HeaderText = "Status"
        Me.jobStatus.Name = "jobStatus"
        Me.jobStatus.ReadOnly = True
        Me.jobStatus.Width = 73
        '
        'jobType
        '
        Me.jobType.FillWeight = 5.0!
        Me.jobType.HeaderText = "Type"
        Me.jobType.MinimumWidth = 40
        Me.jobType.Name = "jobType"
        Me.jobType.ReadOnly = True
        '
        'jobStart
        '
        Me.jobStart.FillWeight = 5.0!
        Me.jobStart.HeaderText = "Start"
        Me.jobStart.MinimumWidth = 40
        Me.jobStart.Name = "jobStart"
        Me.jobStart.ReadOnly = True
        '
        'jobEnd
        '
        Me.jobEnd.DividerWidth = 5
        Me.jobEnd.FillWeight = 5.0!
        Me.jobEnd.HeaderText = "End"
        Me.jobEnd.MinimumWidth = 40
        Me.jobEnd.Name = "jobEnd"
        Me.jobEnd.ReadOnly = True
        '
        'jobID
        '
        Me.jobID.FillWeight = 5.0!
        Me.jobID.HeaderText = "jobID"
        Me.jobID.Name = "jobID"
        Me.jobID.ReadOnly = True
        Me.jobID.Visible = False
        '
        'jobResultID
        '
        Me.jobResultID.FillWeight = 5.0!
        Me.jobResultID.HeaderText = "ResultID"
        Me.jobResultID.Name = "jobResultID"
        Me.jobResultID.ReadOnly = True
        Me.jobResultID.Visible = False
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
        Me.splitEndpointStatus.Size = New System.Drawing.Size(736, 661)
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
        Me.flowEndpointStatus.Size = New System.Drawing.Size(736, 90)
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
        Me.dgvEndpointStatusJobTargets.Size = New System.Drawing.Size(736, 567)
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
        Me.tabAlerts.Size = New System.Drawing.Size(742, 667)
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
        Me.splitAlerts.Size = New System.Drawing.Size(742, 667)
        Me.splitAlerts.SplitterDistance = 274
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
        Me.dgvAlerts.Size = New System.Drawing.Size(742, 274)
        Me.dgvAlerts.TabIndex = 0
        '
        'artifactName
        '
        Me.artifactName.FillWeight = 35.0!
        Me.artifactName.HeaderText = "Name"
        Me.artifactName.MinimumWidth = 175
        Me.artifactName.Name = "artifactName"
        Me.artifactName.ReadOnly = True
        '
        'createDate
        '
        Me.createDate.FillWeight = 5.0!
        Me.createDate.HeaderText = "Date"
        Me.createDate.MinimumWidth = 50
        Me.createDate.Name = "createDate"
        Me.createDate.ReadOnly = True
        '
        'severity
        '
        Me.severity.FillWeight = 5.0!
        Me.severity.HeaderText = "Severity"
        Me.severity.MinimumWidth = 50
        Me.severity.Name = "severity"
        Me.severity.ReadOnly = True
        '
        'target
        '
        Me.target.FillWeight = 20.0!
        Me.target.HeaderText = "Target"
        Me.target.MinimumWidth = 70
        Me.target.Name = "target"
        Me.target.ReadOnly = True
        '
        'source
        '
        Me.source.FillWeight = 15.0!
        Me.source.HeaderText = "Source"
        Me.source.MinimumWidth = 70
        Me.source.Name = "source"
        Me.source.ReadOnly = True
        '
        'project
        '
        Me.project.FillWeight = 15.0!
        Me.project.HeaderText = "Project"
        Me.project.MinimumWidth = 50
        Me.project.Name = "project"
        Me.project.ReadOnly = True
        '
        'confidence
        '
        Me.confidence.FillWeight = 10.0!
        Me.confidence.HeaderText = "Confidence"
        Me.confidence.MinimumWidth = 40
        Me.confidence.Name = "confidence"
        Me.confidence.ReadOnly = True
        '
        'threatScore
        '
        Me.threatScore.FillWeight = 10.0!
        Me.threatScore.HeaderText = "Threat Score"
        Me.threatScore.MinimumWidth = 40
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
        Me.tblAlertBreakdown.Size = New System.Drawing.Size(742, 389)
        Me.tblAlertBreakdown.TabIndex = 4
        '
        'flowResponseTime
        '
        Me.flowResponseTime.AutoSize = True
        Me.flowResponseTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.flowResponseTime.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flowResponseTime.Location = New System.Drawing.Point(213, 261)
        Me.flowResponseTime.Name = "flowResponseTime"
        Me.flowResponseTime.Size = New System.Drawing.Size(526, 125)
        Me.flowResponseTime.TabIndex = 10
        '
        'lblResponseTime
        '
        Me.lblResponseTime.AutoSize = True
        Me.lblResponseTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblResponseTime.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblResponseTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResponseTime.Location = New System.Drawing.Point(3, 258)
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
        Me.lblTotalNumberofResponses.Size = New System.Drawing.Size(204, 129)
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
        Me.flowTotalResponses.Size = New System.Drawing.Size(526, 123)
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
        Me.flowAlertBreakdown.Size = New System.Drawing.Size(526, 123)
        Me.flowAlertBreakdown.TabIndex = 4
        '
        'tabJobExecution
        '
        Me.tabJobExecution.Controls.Add(Me.flowJobsAPI)
        Me.tabJobExecution.Location = New System.Drawing.Point(4, 28)
        Me.tabJobExecution.Margin = New System.Windows.Forms.Padding(4)
        Me.tabJobExecution.Name = "tabJobExecution"
        Me.tabJobExecution.Padding = New System.Windows.Forms.Padding(4)
        Me.tabJobExecution.Size = New System.Drawing.Size(750, 696)
        Me.tabJobExecution.TabIndex = 0
        Me.tabJobExecution.Text = "JobsAPI Execution"
        Me.tabJobExecution.UseVisualStyleBackColor = True
        '
        'flowJobsAPI
        '
        Me.flowJobsAPI.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.flowJobsAPI.Controls.Add(Me.tabSubMenu)
        Me.flowJobsAPI.Controls.Add(Me.tableJobExecute)
        Me.flowJobsAPI.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flowJobsAPI.Location = New System.Drawing.Point(4, 4)
        Me.flowJobsAPI.Name = "flowJobsAPI"
        Me.flowJobsAPI.Size = New System.Drawing.Size(742, 688)
        Me.flowJobsAPI.TabIndex = 35
        '
        'tableJobExecute
        '
        Me.tableJobExecute.AutoSize = True
        Me.tableJobExecute.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tableJobExecute.ColumnCount = 5
        Me.tableJobExecute.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tableJobExecute.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tableJobExecute.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tableJobExecute.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tableJobExecute.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tableJobExecute.Controls.Add(Me.btnShowJSON, 0, 0)
        Me.tableJobExecute.Controls.Add(Me.lblJobStatus, 0, 1)
        Me.tableJobExecute.Controls.Add(Me.btnLoadFromBox, 1, 0)
        Me.tableJobExecute.Controls.Add(Me.btnExecute, 4, 0)
        Me.tableJobExecute.Controls.Add(Me.btnSaveAsBox, 2, 0)
        Me.tableJobExecute.Controls.Add(Me.btnSavePowershell, 3, 0)
        Me.tableJobExecute.Location = New System.Drawing.Point(3, 621)
        Me.tableJobExecute.Name = "tableJobExecute"
        Me.tableJobExecute.Padding = New System.Windows.Forms.Padding(4)
        Me.tableJobExecute.RowCount = 2
        Me.tableJobExecute.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableJobExecute.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tableJobExecute.Size = New System.Drawing.Size(672, 64)
        Me.tableJobExecute.TabIndex = 34
        '
        'btnShowJSON
        '
        Me.btnShowJSON.Location = New System.Drawing.Point(8, 8)
        Me.btnShowJSON.Margin = New System.Windows.Forms.Padding(4)
        Me.btnShowJSON.Name = "btnShowJSON"
        Me.btnShowJSON.Size = New System.Drawing.Size(154, 28)
        Me.btnShowJSON.TabIndex = 23
        Me.btnShowJSON.TabStop = False
        Me.btnShowJSON.Text = "Show Filter JSON"
        Me.btnShowJSON.UseVisualStyleBackColor = True
        '
        'lblJobStatus
        '
        Me.lblJobStatus.AutoSize = True
        Me.tableJobExecute.SetColumnSpan(Me.lblJobStatus, 5)
        Me.lblJobStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJobStatus.Location = New System.Drawing.Point(8, 40)
        Me.lblJobStatus.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblJobStatus.MaximumSize = New System.Drawing.Size(688, 0)
        Me.lblJobStatus.MinimumSize = New System.Drawing.Size(400, 0)
        Me.lblJobStatus.Name = "lblJobStatus"
        Me.lblJobStatus.Size = New System.Drawing.Size(400, 20)
        Me.lblJobStatus.TabIndex = 33
        Me.lblJobStatus.Text = "lblJobStatus"
        '
        'btnLoadFromBox
        '
        Me.btnLoadFromBox.Location = New System.Drawing.Point(170, 8)
        Me.btnLoadFromBox.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLoadFromBox.Name = "btnLoadFromBox"
        Me.btnLoadFromBox.Size = New System.Drawing.Size(120, 28)
        Me.btnLoadFromBox.TabIndex = 22
        Me.btnLoadFromBox.TabStop = False
        Me.btnLoadFromBox.Text = "Load From Box"
        Me.btnLoadFromBox.UseVisualStyleBackColor = True
        '
        'btnSaveAsBox
        '
        Me.btnSaveAsBox.Location = New System.Drawing.Point(298, 8)
        Me.btnSaveAsBox.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSaveAsBox.Name = "btnSaveAsBox"
        Me.btnSaveAsBox.Size = New System.Drawing.Size(100, 28)
        Me.btnSaveAsBox.TabIndex = 21
        Me.btnSaveAsBox.TabStop = False
        Me.btnSaveAsBox.Text = "Save as Box"
        Me.btnSaveAsBox.UseVisualStyleBackColor = True
        '
        'btnSavePowershell
        '
        Me.btnSavePowershell.Location = New System.Drawing.Point(405, 7)
        Me.btnSavePowershell.Name = "btnSavePowershell"
        Me.btnSavePowershell.Size = New System.Drawing.Size(152, 28)
        Me.btnSavePowershell.TabIndex = 35
        Me.btnSavePowershell.Text = "Save Powershell"
        Me.btnSavePowershell.UseVisualStyleBackColor = True
        '
        'tabFireEye
        '
        Me.tabFireEye.Controls.Add(Me.flowFireEye)
        Me.tabFireEye.Location = New System.Drawing.Point(4, 28)
        Me.tabFireEye.Margin = New System.Windows.Forms.Padding(4)
        Me.tabFireEye.Name = "tabFireEye"
        Me.tabFireEye.Padding = New System.Windows.Forms.Padding(4)
        Me.tabFireEye.Size = New System.Drawing.Size(750, 696)
        Me.tabFireEye.TabIndex = 4
        Me.tabFireEye.Text = "FireEye"
        Me.tabFireEye.UseVisualStyleBackColor = True
        '
        'flowFireEye
        '
        Me.flowFireEye.AutoSize = True
        Me.flowFireEye.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.flowFireEye.Controls.Add(Me.tableFireEye)
        Me.flowFireEye.Controls.Add(Me.lblFEStatus)
        Me.flowFireEye.Controls.Add(Me.Label37)
        Me.flowFireEye.Controls.Add(Me.txtFELink)
        Me.flowFireEye.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flowFireEye.Location = New System.Drawing.Point(4, 4)
        Me.flowFireEye.Name = "flowFireEye"
        Me.flowFireEye.Size = New System.Drawing.Size(742, 688)
        Me.flowFireEye.TabIndex = 43
        '
        'tableFireEye
        '
        Me.tableFireEye.AutoSize = True
        Me.tableFireEye.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tableFireEye.ColumnCount = 2
        Me.tableFireEye.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tableFireEye.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableFireEye.Controls.Add(Me.Label33, 0, 0)
        Me.tableFireEye.Controls.Add(Me.txtFireEyeMalwareMD5, 1, 3)
        Me.tableFireEye.Controls.Add(Me.Label47, 0, 3)
        Me.tableFireEye.Controls.Add(Me.txtFETarget, 1, 0)
        Me.tableFireEye.Controls.Add(Me.btn_FEEvent, 1, 4)
        Me.tableFireEye.Controls.Add(Me.Label50, 0, 2)
        Me.tableFireEye.Controls.Add(Me.Label34, 0, 1)
        Me.tableFireEye.Controls.Add(Me.cmbFEAlertType, 1, 1)
        Me.tableFireEye.Controls.Add(Me.txtFireEyeMalwareName, 1, 2)
        Me.tableFireEye.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flowFireEye.SetFlowBreak(Me.tableFireEye, True)
        Me.tableFireEye.Location = New System.Drawing.Point(3, 3)
        Me.tableFireEye.Name = "tableFireEye"
        Me.tableFireEye.RowCount = 5
        Me.tableFireEye.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableFireEye.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableFireEye.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableFireEye.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableFireEye.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableFireEye.Size = New System.Drawing.Size(402, 158)
        Me.tableFireEye.TabIndex = 42
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(4, 0)
        Me.Label33.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(122, 17)
        Me.Label33.TabIndex = 2
        Me.Label33.Text = "Target Hostname:"
        '
        'txtFireEyeMalwareMD5
        '
        Me.txtFireEyeMalwareMD5.Location = New System.Drawing.Point(134, 96)
        Me.txtFireEyeMalwareMD5.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFireEyeMalwareMD5.Name = "txtFireEyeMalwareMD5"
        Me.txtFireEyeMalwareMD5.Size = New System.Drawing.Size(264, 22)
        Me.txtFireEyeMalwareMD5.TabIndex = 3
        Me.txtFireEyeMalwareMD5.Text = "47f9fdc617f8c98a6732be534d8dbe9a"
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Location = New System.Drawing.Point(4, 92)
        Me.Label47.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(97, 17)
        Me.Label47.TabIndex = 33
        Me.Label47.Text = "Malware MD5:"
        '
        'txtFETarget
        '
        Me.txtFETarget.Location = New System.Drawing.Point(134, 4)
        Me.txtFETarget.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFETarget.Name = "txtFETarget"
        Me.txtFETarget.Size = New System.Drawing.Size(264, 22)
        Me.txtFETarget.TabIndex = 0
        '
        'btn_FEEvent
        '
        Me.btn_FEEvent.Location = New System.Drawing.Point(134, 126)
        Me.btn_FEEvent.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_FEEvent.Name = "btn_FEEvent"
        Me.btn_FEEvent.Size = New System.Drawing.Size(156, 28)
        Me.btn_FEEvent.TabIndex = 4
        Me.btn_FEEvent.Text = "Send FireEye Event"
        Me.btn_FEEvent.UseVisualStyleBackColor = True
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Location = New System.Drawing.Point(4, 62)
        Me.Label50.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(105, 17)
        Me.Label50.TabIndex = 41
        Me.Label50.Text = "Malware Name:"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(4, 30)
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
        Me.cmbFEAlertType.Location = New System.Drawing.Point(134, 34)
        Me.cmbFEAlertType.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbFEAlertType.Name = "cmbFEAlertType"
        Me.cmbFEAlertType.Size = New System.Drawing.Size(264, 24)
        Me.cmbFEAlertType.TabIndex = 1
        '
        'txtFireEyeMalwareName
        '
        Me.txtFireEyeMalwareName.Location = New System.Drawing.Point(134, 66)
        Me.txtFireEyeMalwareName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFireEyeMalwareName.Name = "txtFireEyeMalwareName"
        Me.txtFireEyeMalwareName.Size = New System.Drawing.Size(264, 22)
        Me.txtFireEyeMalwareName.TabIndex = 2
        Me.txtFireEyeMalwareName.Text = "Super.Evil.Malware"
        '
        'lblFEStatus
        '
        Me.lblFEStatus.AutoSize = True
        Me.flowFireEye.SetFlowBreak(Me.lblFEStatus, True)
        Me.lblFEStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFEStatus.Location = New System.Drawing.Point(4, 164)
        Me.lblFEStatus.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFEStatus.Name = "lblFEStatus"
        Me.lblFEStatus.Size = New System.Drawing.Size(95, 20)
        Me.lblFEStatus.TabIndex = 32
        Me.lblFEStatus.Text = "lblFEStatus"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.flowFireEye.SetFlowBreak(Me.Label37, True)
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(4, 184)
        Me.Label37.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(731, 36)
        Me.Label37.TabIndex = 6
        Me.Label37.Text = "To generate a verified hit from a test FireEye ThreatScan download the following " & _
    "EXE to your target, or enter a Custom MD5 Hash above." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtFELink
        '
        Me.txtFELink.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFELink.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtFELink.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFELink.Location = New System.Drawing.Point(4, 224)
        Me.txtFELink.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFELink.Name = "txtFELink"
        Me.txtFELink.ReadOnly = True
        Me.txtFELink.Size = New System.Drawing.Size(720, 19)
        Me.txtFELink.TabIndex = 7
        Me.txtFELink.TabStop = False
        Me.txtFELink.Text = "http://fedeploycheck.fireeye.com/appliance-test/test-infection.exe"
        '
        'tabPANW
        '
        Me.tabPANW.Controls.Add(Me.flowPANW)
        Me.tabPANW.Location = New System.Drawing.Point(4, 28)
        Me.tabPANW.Margin = New System.Windows.Forms.Padding(4)
        Me.tabPANW.Name = "tabPANW"
        Me.tabPANW.Size = New System.Drawing.Size(750, 696)
        Me.tabPANW.TabIndex = 5
        Me.tabPANW.Text = "PANW"
        Me.tabPANW.UseVisualStyleBackColor = True
        '
        'flowPANW
        '
        Me.flowPANW.AutoSize = True
        Me.flowPANW.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.flowPANW.Controls.Add(Me.tablePANWSendAlert)
        Me.flowPANW.Controls.Add(Me.grpWildFireSim)
        Me.flowPANW.Controls.Add(Me.tablePANWBottom)
        Me.flowPANW.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flowPANW.Location = New System.Drawing.Point(0, 0)
        Me.flowPANW.Name = "flowPANW"
        Me.flowPANW.Size = New System.Drawing.Size(750, 696)
        Me.flowPANW.TabIndex = 41
        '
        'tablePANWSendAlert
        '
        Me.tablePANWSendAlert.AutoSize = True
        Me.tablePANWSendAlert.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tablePANWSendAlert.ColumnCount = 2
        Me.tablePANWSendAlert.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tablePANWSendAlert.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tablePANWSendAlert.Controls.Add(Me.Label30, 0, 0)
        Me.tablePANWSendAlert.Controls.Add(Me.Label36, 0, 1)
        Me.tablePANWSendAlert.Controls.Add(Me.txtPANWMalwareMD5, 1, 4)
        Me.tablePANWSendAlert.Controls.Add(Me.txtPANWMalwareName, 1, 3)
        Me.tablePANWSendAlert.Controls.Add(Me.Label35, 0, 2)
        Me.tablePANWSendAlert.Controls.Add(Me.Label49, 0, 3)
        Me.tablePANWSendAlert.Controls.Add(Me.Label48, 0, 4)
        Me.tablePANWSendAlert.Controls.Add(Me.panwPort, 1, 0)
        Me.tablePANWSendAlert.Controls.Add(Me.btnPANWSend, 1, 5)
        Me.tablePANWSendAlert.Controls.Add(Me.txtPANWTarget, 1, 1)
        Me.tablePANWSendAlert.Controls.Add(Me.cmbPANWAlert, 1, 2)
        Me.tablePANWSendAlert.Controls.Add(Me.lblPANWStatus, 1, 6)
        Me.tablePANWSendAlert.Location = New System.Drawing.Point(3, 3)
        Me.tablePANWSendAlert.Name = "tablePANWSendAlert"
        Me.tablePANWSendAlert.RowCount = 7
        Me.tablePANWSendAlert.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tablePANWSendAlert.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tablePANWSendAlert.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tablePANWSendAlert.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tablePANWSendAlert.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tablePANWSendAlert.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tablePANWSendAlert.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tablePANWSendAlert.Size = New System.Drawing.Size(417, 204)
        Me.tablePANWSendAlert.TabIndex = 0
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(4, 0)
        Me.Label30.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(168, 17)
        Me.Label30.TabIndex = 10
        Me.Label30.Text = "FEP PANW Listener Port:"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(4, 30)
        Me.Label36.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(122, 17)
        Me.Label36.TabIndex = 6
        Me.Label36.Text = "Target Hostname:"
        '
        'txtPANWMalwareMD5
        '
        Me.txtPANWMalwareMD5.Location = New System.Drawing.Point(180, 126)
        Me.txtPANWMalwareMD5.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPANWMalwareMD5.Name = "txtPANWMalwareMD5"
        Me.txtPANWMalwareMD5.Size = New System.Drawing.Size(233, 22)
        Me.txtPANWMalwareMD5.TabIndex = 4
        Me.txtPANWMalwareMD5.Text = "47f9fdc617f8c98a6732be534d8dbe9a"
        '
        'txtPANWMalwareName
        '
        Me.txtPANWMalwareName.Location = New System.Drawing.Point(180, 96)
        Me.txtPANWMalwareName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPANWMalwareName.Name = "txtPANWMalwareName"
        Me.txtPANWMalwareName.Size = New System.Drawing.Size(233, 22)
        Me.txtPANWMalwareName.TabIndex = 3
        Me.txtPANWMalwareName.Text = "Super.Evil.Malware"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(4, 60)
        Me.Label35.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(77, 17)
        Me.Label35.TabIndex = 9
        Me.Label35.Text = "Alert Type:"
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Location = New System.Drawing.Point(4, 92)
        Me.Label49.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(105, 17)
        Me.Label49.TabIndex = 39
        Me.Label49.Text = "Malware Name:"
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Location = New System.Drawing.Point(4, 122)
        Me.Label48.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(97, 17)
        Me.Label48.TabIndex = 37
        Me.Label48.Text = "Malware MD5:"
        '
        'panwPort
        '
        Me.panwPort.Location = New System.Drawing.Point(180, 4)
        Me.panwPort.Margin = New System.Windows.Forms.Padding(4)
        Me.panwPort.Maximum = New Decimal(New Integer() {65535, 0, 0, 0})
        Me.panwPort.Name = "panwPort"
        Me.panwPort.Size = New System.Drawing.Size(160, 22)
        Me.panwPort.TabIndex = 0
        Me.panwPort.Value = New Decimal(New Integer() {514, 0, 0, 0})
        '
        'btnPANWSend
        '
        Me.btnPANWSend.AutoSize = True
        Me.btnPANWSend.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnPANWSend.Location = New System.Drawing.Point(180, 156)
        Me.btnPANWSend.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPANWSend.Name = "btnPANWSend"
        Me.btnPANWSend.Size = New System.Drawing.Size(180, 27)
        Me.btnPANWSend.TabIndex = 5
        Me.btnPANWSend.Text = "Send PANW SysLog Alert"
        Me.btnPANWSend.UseVisualStyleBackColor = True
        '
        'txtPANWTarget
        '
        Me.txtPANWTarget.Location = New System.Drawing.Point(180, 34)
        Me.txtPANWTarget.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPANWTarget.Name = "txtPANWTarget"
        Me.txtPANWTarget.Size = New System.Drawing.Size(233, 22)
        Me.txtPANWTarget.TabIndex = 1
        '
        'cmbPANWAlert
        '
        Me.cmbPANWAlert.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbPANWAlert.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbPANWAlert.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPANWAlert.FormattingEnabled = True
        Me.cmbPANWAlert.Items.AddRange(New Object() {"WILDFIRE", "VIRUS", "FILE", "FLOOD", "URL"})
        Me.cmbPANWAlert.Location = New System.Drawing.Point(180, 64)
        Me.cmbPANWAlert.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbPANWAlert.Name = "cmbPANWAlert"
        Me.cmbPANWAlert.Size = New System.Drawing.Size(233, 24)
        Me.cmbPANWAlert.TabIndex = 2
        '
        'lblPANWStatus
        '
        Me.lblPANWStatus.AutoSize = True
        Me.lblPANWStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPANWStatus.Location = New System.Drawing.Point(180, 187)
        Me.lblPANWStatus.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPANWStatus.Name = "lblPANWStatus"
        Me.lblPANWStatus.Size = New System.Drawing.Size(103, 17)
        Me.lblPANWStatus.TabIndex = 31
        Me.lblPANWStatus.Text = "lblPANWStatus"
        '
        'grpWildFireSim
        '
        Me.grpWildFireSim.AutoSize = True
        Me.grpWildFireSim.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.grpWildFireSim.Controls.Add(Me.panw_sim_port)
        Me.grpWildFireSim.Controls.Add(Me.Label44)
        Me.grpWildFireSim.Controls.Add(Me.lblwildfirestatus)
        Me.grpWildFireSim.Controls.Add(Me.btn_WildfireStart)
        Me.flowPANW.SetFlowBreak(Me.grpWildFireSim, True)
        Me.grpWildFireSim.Location = New System.Drawing.Point(427, 4)
        Me.grpWildFireSim.Margin = New System.Windows.Forms.Padding(4)
        Me.grpWildFireSim.Name = "grpWildFireSim"
        Me.grpWildFireSim.Padding = New System.Windows.Forms.Padding(4)
        Me.grpWildFireSim.Size = New System.Drawing.Size(272, 137)
        Me.grpWildFireSim.TabIndex = 24
        Me.grpWildFireSim.TabStop = False
        Me.grpWildFireSim.Text = "PANW Wildfire Sim"
        '
        'panw_sim_port
        '
        Me.panw_sim_port.Location = New System.Drawing.Point(136, 28)
        Me.panw_sim_port.Margin = New System.Windows.Forms.Padding(4)
        Me.panw_sim_port.Maximum = New Decimal(New Integer() {65535, 0, 0, 0})
        Me.panw_sim_port.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.panw_sim_port.Name = "panw_sim_port"
        Me.panw_sim_port.Size = New System.Drawing.Size(128, 22)
        Me.panw_sim_port.TabIndex = 0
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
        Me.btn_WildfireStart.TabIndex = 1
        Me.btn_WildfireStart.Text = "Start Wildfire Sim"
        Me.btn_WildfireStart.UseVisualStyleBackColor = True
        '
        'tablePANWBottom
        '
        Me.tablePANWBottom.AutoSize = True
        Me.tablePANWBottom.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tablePANWBottom.ColumnCount = 1
        Me.tablePANWBottom.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tablePANWBottom.Controls.Add(Me.grpWildFirePicture, 0, 1)
        Me.tablePANWBottom.Controls.Add(Me.txtFireEyeDownload1, 0, 3)
        Me.tablePANWBottom.Controls.Add(Me.lblPANWHitInstruction, 0, 2)
        Me.tablePANWBottom.Controls.Add(Me.txtPANWSim, 0, 0)
        Me.tablePANWBottom.Location = New System.Drawing.Point(3, 213)
        Me.tablePANWBottom.Name = "tablePANWBottom"
        Me.tablePANWBottom.RowCount = 4
        Me.tablePANWBottom.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tablePANWBottom.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tablePANWBottom.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tablePANWBottom.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tablePANWBottom.Size = New System.Drawing.Size(707, 270)
        Me.tablePANWBottom.TabIndex = 43
        '
        'grpWildFirePicture
        '
        Me.grpWildFirePicture.AutoSize = True
        Me.grpWildFirePicture.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.grpWildFirePicture.Controls.Add(Me.lblWildFireURL)
        Me.grpWildFirePicture.Controls.Add(Me.panwPicture)
        Me.grpWildFirePicture.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpWildFirePicture.Location = New System.Drawing.Point(3, 23)
        Me.grpWildFirePicture.Name = "grpWildFirePicture"
        Me.grpWildFirePicture.Size = New System.Drawing.Size(701, 187)
        Me.grpWildFirePicture.TabIndex = 41
        Me.grpWildFirePicture.TabStop = False
        '
        'lblWildFireURL
        '
        Me.lblWildFireURL.AutoSize = True
        Me.lblWildFireURL.BackColor = System.Drawing.Color.White
        Me.lblWildFireURL.Location = New System.Drawing.Point(113, 103)
        Me.lblWildFireURL.MinimumSize = New System.Drawing.Size(367, 0)
        Me.lblWildFireURL.Name = "lblWildFireURL"
        Me.lblWildFireURL.Size = New System.Drawing.Size(367, 17)
        Me.lblWildFireURL.TabIndex = 40
        Me.lblWildFireURL.Text = "https://wildfire:8449"
        '
        'panwPicture
        '
        Me.panwPicture.Image = CType(resources.GetObject("panwPicture.Image"), System.Drawing.Image)
        Me.panwPicture.Location = New System.Drawing.Point(3, 18)
        Me.panwPicture.Margin = New System.Windows.Forms.Padding(4)
        Me.panwPicture.Name = "panwPicture"
        Me.panwPicture.Size = New System.Drawing.Size(516, 147)
        Me.panwPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.panwPicture.TabIndex = 35
        Me.panwPicture.TabStop = False
        '
        'txtFireEyeDownload1
        '
        Me.txtFireEyeDownload1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFireEyeDownload1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtFireEyeDownload1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtFireEyeDownload1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFireEyeDownload1.Location = New System.Drawing.Point(4, 251)
        Me.txtFireEyeDownload1.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFireEyeDownload1.Name = "txtFireEyeDownload1"
        Me.txtFireEyeDownload1.ReadOnly = True
        Me.txtFireEyeDownload1.Size = New System.Drawing.Size(699, 15)
        Me.txtFireEyeDownload1.TabIndex = 33
        Me.txtFireEyeDownload1.TabStop = False
        Me.txtFireEyeDownload1.Text = "http://fedeploycheck.fireeye.com/appliance-test/test-infection.exe"
        '
        'lblPANWHitInstruction
        '
        Me.lblPANWHitInstruction.AutoSize = True
        Me.lblPANWHitInstruction.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblPANWHitInstruction.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPANWHitInstruction.Location = New System.Drawing.Point(4, 213)
        Me.lblPANWHitInstruction.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPANWHitInstruction.MaximumSize = New System.Drawing.Size(700, 0)
        Me.lblPANWHitInstruction.Name = "lblPANWHitInstruction"
        Me.lblPANWHitInstruction.Size = New System.Drawing.Size(699, 34)
        Me.lblPANWHitInstruction.TabIndex = 32
        Me.lblPANWHitInstruction.Text = "To generate a verified hit from a test PANW ThreatScan download the following EXE" & _
    " to your target, or enter a custom MD5 Hash above."
        '
        'txtPANWSim
        '
        Me.txtPANWSim.AutoSize = True
        Me.txtPANWSim.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtPANWSim.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPANWSim.Location = New System.Drawing.Point(3, 0)
        Me.txtPANWSim.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.txtPANWSim.MaximumSize = New System.Drawing.Size(700, 0)
        Me.txtPANWSim.Name = "txtPANWSim"
        Me.txtPANWSim.Size = New System.Drawing.Size(700, 17)
        Me.txtPANWSim.TabIndex = 24
        Me.txtPANWSim.Text = "PANW Text. Set at runtime"
        '
        'tabXPS
        '
        Me.tabXPS.Controls.Add(Me.flowXPS)
        Me.tabXPS.Location = New System.Drawing.Point(4, 28)
        Me.tabXPS.Margin = New System.Windows.Forms.Padding(4)
        Me.tabXPS.Name = "tabXPS"
        Me.tabXPS.Padding = New System.Windows.Forms.Padding(4)
        Me.tabXPS.Size = New System.Drawing.Size(750, 696)
        Me.tabXPS.TabIndex = 6
        Me.tabXPS.Text = "Fidelis Network"
        Me.tabXPS.UseVisualStyleBackColor = True
        '
        'flowXPS
        '
        Me.flowXPS.AutoSize = True
        Me.flowXPS.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.flowXPS.Controls.Add(Me.tableXPSGrid)
        Me.flowXPS.Controls.Add(Me.GroupBox3)
        Me.flowXPS.Controls.Add(Me.tableXPSTextPic)
        Me.flowXPS.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flowXPS.Location = New System.Drawing.Point(4, 4)
        Me.flowXPS.Name = "flowXPS"
        Me.flowXPS.Size = New System.Drawing.Size(742, 688)
        Me.flowXPS.TabIndex = 45
        '
        'tableXPSGrid
        '
        Me.tableXPSGrid.AutoSize = True
        Me.tableXPSGrid.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tableXPSGrid.ColumnCount = 2
        Me.tableXPSGrid.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tableXPSGrid.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableXPSGrid.Controls.Add(Me.Label38, 0, 0)
        Me.tableXPSGrid.Controls.Add(Me.xpsPort, 1, 0)
        Me.tableXPSGrid.Controls.Add(Me.txtXPSMalwareMD5, 1, 4)
        Me.tableXPSGrid.Controls.Add(Me.Label40, 0, 1)
        Me.tableXPSGrid.Controls.Add(Me.btnXPSSend, 1, 5)
        Me.tableXPSGrid.Controls.Add(Me.Label46, 0, 4)
        Me.tableXPSGrid.Controls.Add(Me.txtXPSTarget, 1, 1)
        Me.tableXPSGrid.Controls.Add(Me.Label41, 0, 2)
        Me.tableXPSGrid.Controls.Add(Me.txtXPSMalware, 1, 3)
        Me.tableXPSGrid.Controls.Add(Me.cmbXPSSeverity, 1, 2)
        Me.tableXPSGrid.Controls.Add(Me.Label42, 0, 3)
        Me.tableXPSGrid.Controls.Add(Me.lblXPSStatus, 1, 6)
        Me.tableXPSGrid.Location = New System.Drawing.Point(3, 3)
        Me.tableXPSGrid.Name = "tableXPSGrid"
        Me.tableXPSGrid.RowCount = 7
        Me.tableXPSGrid.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableXPSGrid.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableXPSGrid.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableXPSGrid.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableXPSGrid.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableXPSGrid.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableXPSGrid.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableXPSGrid.Size = New System.Drawing.Size(427, 205)
        Me.tableXPSGrid.TabIndex = 0
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(4, 0)
        Me.Label38.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(178, 17)
        Me.Label38.TabIndex = 17
        Me.Label38.Text = "FEP Network Listener Port:"
        '
        'xpsPort
        '
        Me.xpsPort.Location = New System.Drawing.Point(190, 4)
        Me.xpsPort.Margin = New System.Windows.Forms.Padding(4)
        Me.xpsPort.Maximum = New Decimal(New Integer() {65535, 0, 0, 0})
        Me.xpsPort.Name = "xpsPort"
        Me.xpsPort.Size = New System.Drawing.Size(160, 22)
        Me.xpsPort.TabIndex = 0
        Me.xpsPort.Value = New Decimal(New Integer() {514, 0, 0, 0})
        '
        'txtXPSMalwareMD5
        '
        Me.txtXPSMalwareMD5.Location = New System.Drawing.Point(190, 126)
        Me.txtXPSMalwareMD5.Margin = New System.Windows.Forms.Padding(4)
        Me.txtXPSMalwareMD5.Name = "txtXPSMalwareMD5"
        Me.txtXPSMalwareMD5.Size = New System.Drawing.Size(233, 22)
        Me.txtXPSMalwareMD5.TabIndex = 4
        Me.txtXPSMalwareMD5.Text = "47f9fdc617f8c98a6732be534d8dbe9a"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(4, 30)
        Me.Label40.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(122, 17)
        Me.Label40.TabIndex = 13
        Me.Label40.Text = "Target Hostname:"
        '
        'btnXPSSend
        '
        Me.btnXPSSend.Location = New System.Drawing.Point(190, 156)
        Me.btnXPSSend.Margin = New System.Windows.Forms.Padding(4)
        Me.btnXPSSend.Name = "btnXPSSend"
        Me.btnXPSSend.Size = New System.Drawing.Size(207, 28)
        Me.btnXPSSend.TabIndex = 5
        Me.btnXPSSend.Text = "Send Network SysLog Alert"
        Me.btnXPSSend.UseVisualStyleBackColor = True
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Location = New System.Drawing.Point(4, 122)
        Me.Label46.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(97, 17)
        Me.Label46.TabIndex = 31
        Me.Label46.Text = "Malware MD5:"
        '
        'txtXPSTarget
        '
        Me.txtXPSTarget.Location = New System.Drawing.Point(190, 34)
        Me.txtXPSTarget.Margin = New System.Windows.Forms.Padding(4)
        Me.txtXPSTarget.Name = "txtXPSTarget"
        Me.txtXPSTarget.Size = New System.Drawing.Size(233, 22)
        Me.txtXPSTarget.TabIndex = 1
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Location = New System.Drawing.Point(4, 60)
        Me.Label41.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(63, 17)
        Me.Label41.TabIndex = 20
        Me.Label41.Text = "Severity:"
        '
        'txtXPSMalware
        '
        Me.txtXPSMalware.Location = New System.Drawing.Point(190, 96)
        Me.txtXPSMalware.Margin = New System.Windows.Forms.Padding(4)
        Me.txtXPSMalware.Name = "txtXPSMalware"
        Me.txtXPSMalware.Size = New System.Drawing.Size(233, 22)
        Me.txtXPSMalware.TabIndex = 3
        Me.txtXPSMalware.Text = "Super.Evil.Malware"
        '
        'cmbXPSSeverity
        '
        Me.cmbXPSSeverity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbXPSSeverity.FormattingEnabled = True
        Me.cmbXPSSeverity.Items.AddRange(New Object() {"Low", "Medium", "High", "Critical"})
        Me.cmbXPSSeverity.Location = New System.Drawing.Point(190, 64)
        Me.cmbXPSSeverity.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbXPSSeverity.Name = "cmbXPSSeverity"
        Me.cmbXPSSeverity.Size = New System.Drawing.Size(233, 24)
        Me.cmbXPSSeverity.TabIndex = 2
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Location = New System.Drawing.Point(4, 92)
        Me.Label42.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(105, 17)
        Me.Label42.TabIndex = 28
        Me.Label42.Text = "Malware Name:"
        '
        'lblXPSStatus
        '
        Me.lblXPSStatus.AutoSize = True
        Me.lblXPSStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblXPSStatus.Location = New System.Drawing.Point(190, 188)
        Me.lblXPSStatus.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblXPSStatus.Name = "lblXPSStatus"
        Me.lblXPSStatus.Size = New System.Drawing.Size(89, 17)
        Me.lblXPSStatus.TabIndex = 30
        Me.lblXPSStatus.Text = "lblXPSStatus"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.xps_sim_Port)
        Me.GroupBox3.Controls.Add(Me.Label43)
        Me.GroupBox3.Controls.Add(Me.lbldemoxpsstatus)
        Me.GroupBox3.Controls.Add(Me.btnStartXPSListener)
        Me.flowXPS.SetFlowBreak(Me.GroupBox3, True)
        Me.GroupBox3.Location = New System.Drawing.Point(437, 4)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(272, 126)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Network CP Sim"
        '
        'xps_sim_Port
        '
        Me.xps_sim_Port.Location = New System.Drawing.Point(158, 28)
        Me.xps_sim_Port.Margin = New System.Windows.Forms.Padding(4)
        Me.xps_sim_Port.Maximum = New Decimal(New Integer() {65535, 0, 0, 0})
        Me.xps_sim_Port.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.xps_sim_Port.Name = "xps_sim_Port"
        Me.xps_sim_Port.Size = New System.Drawing.Size(106, 22)
        Me.xps_sim_Port.TabIndex = 0
        Me.xps_sim_Port.Value = New Decimal(New Integer() {8448, 0, 0, 0})
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Location = New System.Drawing.Point(8, 31)
        Me.Label43.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(142, 17)
        Me.Label43.TabIndex = 23
        Me.Label43.Text = "Network CP Sim Port:"
        '
        'lbldemoxpsstatus
        '
        Me.lbldemoxpsstatus.AutoSize = True
        Me.lbldemoxpsstatus.Location = New System.Drawing.Point(24, 101)
        Me.lbldemoxpsstatus.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbldemoxpsstatus.Name = "lbldemoxpsstatus"
        Me.lbldemoxpsstatus.Size = New System.Drawing.Size(232, 17)
        Me.lbldemoxpsstatus.TabIndex = 22
        Me.lbldemoxpsstatus.Text = "Network CP Sim Status: Not Started"
        '
        'btnStartXPSListener
        '
        Me.btnStartXPSListener.Location = New System.Drawing.Point(43, 63)
        Me.btnStartXPSListener.Margin = New System.Windows.Forms.Padding(4)
        Me.btnStartXPSListener.Name = "btnStartXPSListener"
        Me.btnStartXPSListener.Size = New System.Drawing.Size(175, 28)
        Me.btnStartXPSListener.TabIndex = 1
        Me.btnStartXPSListener.Text = "Start Network CP Sim"
        Me.btnStartXPSListener.UseVisualStyleBackColor = True
        '
        'tableXPSTextPic
        '
        Me.tableXPSTextPic.AutoSize = True
        Me.tableXPSTextPic.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tableXPSTextPic.ColumnCount = 1
        Me.tableXPSTextPic.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tableXPSTextPic.Controls.Add(Me.txtXPSSim, 0, 0)
        Me.tableXPSTextPic.Controls.Add(Me.grpXPSPicture, 0, 1)
        Me.tableXPSTextPic.Controls.Add(Me.Label39, 0, 2)
        Me.tableXPSTextPic.Controls.Add(Me.txtFELink2, 0, 3)
        Me.tableXPSTextPic.Location = New System.Drawing.Point(3, 214)
        Me.tableXPSTextPic.Name = "tableXPSTextPic"
        Me.tableXPSTextPic.RowCount = 4
        Me.tableXPSTextPic.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableXPSTextPic.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableXPSTextPic.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableXPSTextPic.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableXPSTextPic.Size = New System.Drawing.Size(707, 341)
        Me.tableXPSTextPic.TabIndex = 43
        '
        'txtXPSSim
        '
        Me.txtXPSSim.AutoSize = True
        Me.txtXPSSim.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtXPSSim.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtXPSSim.Location = New System.Drawing.Point(3, 0)
        Me.txtXPSSim.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.txtXPSSim.MaximumSize = New System.Drawing.Size(700, 0)
        Me.txtXPSSim.Name = "txtXPSSim"
        Me.txtXPSSim.Size = New System.Drawing.Size(700, 17)
        Me.txtXPSSim.TabIndex = 43
        Me.txtXPSSim.Text = "XPS Text. Set at runtime."
        '
        'grpXPSPicture
        '
        Me.grpXPSPicture.AutoSize = True
        Me.grpXPSPicture.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.grpXPSPicture.Controls.Add(Me.lblXPSHostname)
        Me.grpXPSPicture.Controls.Add(Me.xpsPicture)
        Me.grpXPSPicture.Location = New System.Drawing.Point(3, 23)
        Me.grpXPSPicture.Name = "grpXPSPicture"
        Me.grpXPSPicture.Size = New System.Drawing.Size(449, 257)
        Me.grpXPSPicture.TabIndex = 42
        Me.grpXPSPicture.TabStop = False
        '
        'lblXPSHostname
        '
        Me.lblXPSHostname.AutoSize = True
        Me.lblXPSHostname.BackColor = System.Drawing.Color.White
        Me.lblXPSHostname.Location = New System.Drawing.Point(76, 81)
        Me.lblXPSHostname.MinimumSize = New System.Drawing.Size(367, 0)
        Me.lblXPSHostname.Name = "lblXPSHostname"
        Me.lblXPSHostname.Size = New System.Drawing.Size(367, 17)
        Me.lblXPSHostname.TabIndex = 41
        Me.lblXPSHostname.Text = "xps:8448"
        '
        'xpsPicture
        '
        Me.xpsPicture.Dock = System.Windows.Forms.DockStyle.Fill
        Me.xpsPicture.Image = CType(resources.GetObject("xpsPicture.Image"), System.Drawing.Image)
        Me.xpsPicture.Location = New System.Drawing.Point(3, 18)
        Me.xpsPicture.Margin = New System.Windows.Forms.Padding(4)
        Me.xpsPicture.Name = "xpsPicture"
        Me.xpsPicture.Size = New System.Drawing.Size(443, 236)
        Me.xpsPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.xpsPicture.TabIndex = 27
        Me.xpsPicture.TabStop = False
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.Location = New System.Drawing.Point(4, 283)
        Me.Label39.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label39.MaximumSize = New System.Drawing.Size(700, 0)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(687, 34)
        Me.Label39.TabIndex = 24
        Me.Label39.Text = "To generate a verified hit from a test XPS ThreatScan download the following EXE " & _
    "to your target, or enter a custom MD5 hash above."
        '
        'txtFELink2
        '
        Me.txtFELink2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFELink2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtFELink2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtFELink2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFELink2.Location = New System.Drawing.Point(4, 321)
        Me.txtFELink2.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFELink2.Name = "txtFELink2"
        Me.txtFELink2.ReadOnly = True
        Me.txtFELink2.Size = New System.Drawing.Size(699, 16)
        Me.txtFELink2.TabIndex = 25
        Me.txtFELink2.TabStop = False
        Me.txtFELink2.Text = "http://fedeploycheck.fireeye.com/appliance-test/test-infection.exe"
        '
        'tabAbout
        '
        Me.tabAbout.Controls.Add(Me.flowAbout)
        Me.tabAbout.Location = New System.Drawing.Point(4, 28)
        Me.tabAbout.Margin = New System.Windows.Forms.Padding(4)
        Me.tabAbout.Name = "tabAbout"
        Me.tabAbout.Size = New System.Drawing.Size(750, 696)
        Me.tabAbout.TabIndex = 3
        Me.tabAbout.Text = "About"
        Me.tabAbout.UseVisualStyleBackColor = True
        '
        'flowAbout
        '
        Me.flowAbout.AutoSize = True
        Me.flowAbout.Controls.Add(Me.lbltxtAbout)
        Me.flowAbout.Controls.Add(Me.btn_AboutCheckforUpdates)
        Me.flowAbout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flowAbout.Location = New System.Drawing.Point(0, 0)
        Me.flowAbout.Name = "flowAbout"
        Me.flowAbout.Size = New System.Drawing.Size(750, 696)
        Me.flowAbout.TabIndex = 1
        '
        'lbltxtAbout
        '
        Me.lbltxtAbout.AutoSize = True
        Me.flowAbout.SetFlowBreak(Me.lbltxtAbout, True)
        Me.lbltxtAbout.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltxtAbout.Location = New System.Drawing.Point(3, 0)
        Me.lbltxtAbout.Name = "lbltxtAbout"
        Me.lbltxtAbout.Size = New System.Drawing.Size(733, 234)
        Me.lbltxtAbout.TabIndex = 1
        Me.lbltxtAbout.Text = resources.GetString("lbltxtAbout.Text")
        '
        'btn_AboutCheckforUpdates
        '
        Me.btn_AboutCheckforUpdates.Location = New System.Drawing.Point(3, 237)
        Me.btn_AboutCheckforUpdates.Name = "btn_AboutCheckforUpdates"
        Me.btn_AboutCheckforUpdates.Size = New System.Drawing.Size(149, 32)
        Me.btn_AboutCheckforUpdates.TabIndex = 0
        Me.btn_AboutCheckforUpdates.Text = "Check for Updates"
        Me.btn_AboutCheckforUpdates.UseVisualStyleBackColor = True
        '
        'cms_Project
        '
        Me.cms_Project.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cms_Project.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewProjectToolStripMenuItem, Me.EditProjectToolStripMenuItem, Me.DeleteProjectToolStripMenuItem, Me.ViewProjectInReviewToolStripMenuItem})
        Me.cms_Project.Name = "cms_Project"
        Me.cms_Project.Size = New System.Drawing.Size(178, 100)
        '
        'NewProjectToolStripMenuItem
        '
        Me.NewProjectToolStripMenuItem.Name = "NewProjectToolStripMenuItem"
        Me.NewProjectToolStripMenuItem.Size = New System.Drawing.Size(177, 24)
        Me.NewProjectToolStripMenuItem.Text = "New Project"
        '
        'EditProjectToolStripMenuItem
        '
        Me.EditProjectToolStripMenuItem.Name = "EditProjectToolStripMenuItem"
        Me.EditProjectToolStripMenuItem.Size = New System.Drawing.Size(177, 24)
        Me.EditProjectToolStripMenuItem.Text = "Edit Project"
        '
        'DeleteProjectToolStripMenuItem
        '
        Me.DeleteProjectToolStripMenuItem.Name = "DeleteProjectToolStripMenuItem"
        Me.DeleteProjectToolStripMenuItem.Size = New System.Drawing.Size(177, 24)
        Me.DeleteProjectToolStripMenuItem.Text = "Delete Project"
        '
        'ViewProjectInReviewToolStripMenuItem
        '
        Me.ViewProjectInReviewToolStripMenuItem.Name = "ViewProjectInReviewToolStripMenuItem"
        Me.ViewProjectInReviewToolStripMenuItem.Size = New System.Drawing.Size(177, 24)
        Me.ViewProjectInReviewToolStripMenuItem.Text = "View in Review"
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
        'sfdPowerShell
        '
        Me.sfdPowerShell.DefaultExt = "ps1"
        Me.sfdPowerShell.Filter = "Powershell Files|*.ps1"
        Me.sfdPowerShell.InitialDirectory = "My.Application.Info.DirectoryPath & ""\Powershell"""
        '
        'cms_JobStatus
        '
        Me.cms_JobStatus.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cms_JobStatus.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EndpointStatusToolStripMenuItem, Me.ResultToolStripMenuItem, Me.ToolStripSeparator1, Me.RetryToolStripMenuItem, Me.CancelJobToolStripMenuItem})
        Me.cms_JobStatus.Name = "cms_JobStatus"
        Me.cms_JobStatus.Size = New System.Drawing.Size(183, 106)
        '
        'EndpointStatusToolStripMenuItem
        '
        Me.EndpointStatusToolStripMenuItem.Name = "EndpointStatusToolStripMenuItem"
        Me.EndpointStatusToolStripMenuItem.Size = New System.Drawing.Size(182, 24)
        Me.EndpointStatusToolStripMenuItem.Text = "Endpoint Status"
        '
        'ResultToolStripMenuItem
        '
        Me.ResultToolStripMenuItem.Name = "ResultToolStripMenuItem"
        Me.ResultToolStripMenuItem.Size = New System.Drawing.Size(182, 24)
        Me.ResultToolStripMenuItem.Text = "Result"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(179, 6)
        '
        'RetryToolStripMenuItem
        '
        Me.RetryToolStripMenuItem.Name = "RetryToolStripMenuItem"
        Me.RetryToolStripMenuItem.Size = New System.Drawing.Size(182, 24)
        Me.RetryToolStripMenuItem.Text = "Retry"
        '
        'CancelJobToolStripMenuItem
        '
        Me.CancelJobToolStripMenuItem.Name = "CancelJobToolStripMenuItem"
        Me.CancelJobToolStripMenuItem.Size = New System.Drawing.Size(182, 24)
        Me.CancelJobToolStripMenuItem.Text = "Cancel"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(3, 9)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(43, 17)
        Me.Label32.TabIndex = 9
        Me.Label32.Text = "Filter:"
        '
        'lvJobStatusFacets
        '
        Me.lvJobStatusFacets.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvJobStatusFacets.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvJobStatusFacets.GridLines = True
        Me.lvJobStatusFacets.Location = New System.Drawing.Point(52, 3)
        Me.lvJobStatusFacets.MultiSelect = False
        Me.lvJobStatusFacets.Name = "lvJobStatusFacets"
        Me.lvJobStatusFacets.Size = New System.Drawing.Size(681, 49)
        Me.lvJobStatusFacets.TabIndex = 8
        Me.lvJobStatusFacets.UseCompatibleStateImageBehavior = False
        Me.lvJobStatusFacets.View = System.Windows.Forms.View.List
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(758, 728)
        Me.Controls.Add(Me.tabMenu)
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(776, 775)
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FEP Job Runner Version:"
        Me.grpSettings.ResumeLayout(False)
        Me.grpSettings.PerformLayout()
        Me.flowSettings.ResumeLayout(False)
        Me.flowSettings.PerformLayout()
        Me.grpReqSettings.ResumeLayout(False)
        Me.grpReqSettings.PerformLayout()
        Me.tableSettingRequired.ResumeLayout(False)
        Me.tableSettingRequired.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.grpOptDefSet.ResumeLayout(False)
        Me.grpOptDefSet.PerformLayout()
        Me.tableSettingOptional.ResumeLayout(False)
        Me.tableSettingOptional.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.tableSettingSave.ResumeLayout(False)
        Me.tableSettingSave.PerformLayout()
        Me.tabSubMenu.ResumeLayout(False)
        Me.tabJobInfo.ResumeLayout(False)
        Me.tabJobInfo.PerformLayout()
        Me.flowJobInfo.ResumeLayout(False)
        Me.flowJobInfo.PerformLayout()
        Me.tableJobInfo.ResumeLayout(False)
        Me.tableJobInfo.PerformLayout()
        Me.tableJobInfoTarget.ResumeLayout(False)
        Me.tableJobInfoTarget.PerformLayout()
        Me.grpJobTargetSelect.ResumeLayout(False)
        Me.grpJobTargetSelect.PerformLayout()
        Me.grpshare.ResumeLayout(False)
        Me.grpshare.PerformLayout()
        Me.tableNetworkShares.ResumeLayout(False)
        Me.tableNetworkShares.PerformLayout()
        Me.grpagent.ResumeLayout(False)
        Me.grpagent.PerformLayout()
        Me.tableComputerTargets.ResumeLayout(False)
        Me.tableComputerTargets.PerformLayout()
        Me.tabFilters.ResumeLayout(False)
        Me.tableFilters.ResumeLayout(False)
        Me.tabFiltersSubMenu.ResumeLayout(False)
        Me.tabInclusionFilter.ResumeLayout(False)
        Me.tabInclusionFilter.PerformLayout()
        Me.tableInclusionFilters.ResumeLayout(False)
        Me.tableInclusionFilters.PerformLayout()
        Me.tabExclusionFilter.ResumeLayout(False)
        Me.tabExclusionFilter.PerformLayout()
        Me.tableExclusionFilters.ResumeLayout(False)
        Me.tableExclusionFilters.PerformLayout()
        CType(Me.dgvFilters, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabAgentRemediation.ResumeLayout(False)
        Me.tabAgentRemediation.PerformLayout()
        Me.tableAgentRemediation.ResumeLayout(False)
        Me.tabAgentRemediationSubMenu.ResumeLayout(False)
        Me.tabAgentSendFile.ResumeLayout(False)
        Me.tabAgentSendFile.PerformLayout()
        Me.tableARSendFile.ResumeLayout(False)
        Me.tableARSendFile.PerformLayout()
        Me.tabAgentExecute.ResumeLayout(False)
        Me.tabAgentExecute.PerformLayout()
        Me.tableARExecute.ResumeLayout(False)
        Me.tableARExecute.PerformLayout()
        Me.tabAgentDelete.ResumeLayout(False)
        Me.tabAgentDelete.PerformLayout()
        Me.tableARDelete.ResumeLayout(False)
        Me.tableARDelete.PerformLayout()
        Me.TabAgentKill.ResumeLayout(False)
        Me.TabAgentKill.PerformLayout()
        Me.tableARKill.ResumeLayout(False)
        Me.tableARKill.PerformLayout()
        Me.grpARKill.ResumeLayout(False)
        Me.grpARKill.PerformLayout()
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
        Me.flowJobsAPI.ResumeLayout(False)
        Me.flowJobsAPI.PerformLayout()
        Me.tableJobExecute.ResumeLayout(False)
        Me.tableJobExecute.PerformLayout()
        Me.tabFireEye.ResumeLayout(False)
        Me.tabFireEye.PerformLayout()
        Me.flowFireEye.ResumeLayout(False)
        Me.flowFireEye.PerformLayout()
        Me.tableFireEye.ResumeLayout(False)
        Me.tableFireEye.PerformLayout()
        Me.tabPANW.ResumeLayout(False)
        Me.tabPANW.PerformLayout()
        Me.flowPANW.ResumeLayout(False)
        Me.flowPANW.PerformLayout()
        Me.tablePANWSendAlert.ResumeLayout(False)
        Me.tablePANWSendAlert.PerformLayout()
        CType(Me.panwPort, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpWildFireSim.ResumeLayout(False)
        Me.grpWildFireSim.PerformLayout()
        CType(Me.panw_sim_port, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tablePANWBottom.ResumeLayout(False)
        Me.tablePANWBottom.PerformLayout()
        Me.grpWildFirePicture.ResumeLayout(False)
        Me.grpWildFirePicture.PerformLayout()
        CType(Me.panwPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabXPS.ResumeLayout(False)
        Me.tabXPS.PerformLayout()
        Me.flowXPS.ResumeLayout(False)
        Me.flowXPS.PerformLayout()
        Me.tableXPSGrid.ResumeLayout(False)
        Me.tableXPSGrid.PerformLayout()
        CType(Me.xpsPort, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.xps_sim_Port, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tableXPSTextPic.ResumeLayout(False)
        Me.tableXPSTextPic.PerformLayout()
        Me.grpXPSPicture.ResumeLayout(False)
        Me.grpXPSPicture.PerformLayout()
        CType(Me.xpsPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabAbout.ResumeLayout(False)
        Me.tabAbout.PerformLayout()
        Me.flowAbout.ResumeLayout(False)
        Me.flowAbout.PerformLayout()
        Me.cms_Project.ResumeLayout(False)
        Me.cms_JobStatus.ResumeLayout(False)
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
    Friend WithEvents grpSettings As System.Windows.Forms.GroupBox
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
    Friend WithEvents txtStatusSettings As System.Windows.Forms.TextBox
    Friend WithEvents btnSaveAsBox As System.Windows.Forms.Button
    Friend WithEvents btnLoadFromBox As System.Windows.Forms.Button
    Friend WithEvents ofdBox As System.Windows.Forms.OpenFileDialog
    Friend WithEvents sfdBox As System.Windows.Forms.SaveFileDialog
    Friend WithEvents grpJobTargetSelect As System.Windows.Forms.GroupBox
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
    Friend WithEvents grpOptDefSet As System.Windows.Forms.GroupBox
    Friend WithEvents btnShowJSON As System.Windows.Forms.Button
    Friend WithEvents rdoendpoint As System.Windows.Forms.RadioButton
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
    Friend WithEvents xpsPicture As System.Windows.Forms.PictureBox
    Friend WithEvents txtXPSMalware As System.Windows.Forms.TextBox
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents xps_sim_Port As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents grpWildFireSim As System.Windows.Forms.GroupBox
    Friend WithEvents panw_sim_port As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents lblwildfirestatus As System.Windows.Forms.Label
    Friend WithEvents btn_WildfireStart As System.Windows.Forms.Button
    Friend WithEvents lblXPSStatus As System.Windows.Forms.Label
    Friend WithEvents lblPANWStatus As System.Windows.Forms.Label
    Friend WithEvents lblFEStatus As System.Windows.Forms.Label
    Friend WithEvents lblJobStatus As System.Windows.Forms.Label
    Friend WithEvents panwPicture As System.Windows.Forms.PictureBox
    Friend WithEvents txtFireEyeDownload1 As System.Windows.Forms.TextBox
    Friend WithEvents lblPANWHitInstruction As System.Windows.Forms.Label
    Friend WithEvents txtXPSMalwareMD5 As System.Windows.Forms.TextBox
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents txtFireEyeMalwareMD5 As System.Windows.Forms.TextBox
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents txtPANWMalwareMD5 As System.Windows.Forms.TextBox
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents btn_AboutCheckforUpdates As System.Windows.Forms.Button
    Friend WithEvents tabRESTUI As System.Windows.Forms.TabPage
    Friend WithEvents tabControlJobsRest As System.Windows.Forms.TabControl
    Friend WithEvents tabJobsList As System.Windows.Forms.TabPage
    Friend WithEvents splitJobsRestJobs As System.Windows.Forms.SplitContainer
    Friend WithEvents dgvJobsRestJobsList As System.Windows.Forms.DataGridView
    Friend WithEvents splitEndpointStatus As System.Windows.Forms.SplitContainer
    Friend WithEvents dgvEndpointStatusJobTargets As System.Windows.Forms.DataGridView
    Friend WithEvents tabTasks As System.Windows.Forms.TabPage
    Friend WithEvents tabProjects As System.Windows.Forms.TabPage
    Friend WithEvents splitProjects As System.Windows.Forms.SplitContainer
    Friend WithEvents dgvProjectList As System.Windows.Forms.DataGridView
    Friend WithEvents tabAlerts As System.Windows.Forms.TabPage
    Friend WithEvents flowTasks As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents splitAlerts As System.Windows.Forms.SplitContainer
    Friend WithEvents dgvAlerts As System.Windows.Forms.DataGridView
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
    Friend WithEvents txtPANWMalwareName As System.Windows.Forms.TextBox
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents txtFireEyeMalwareName As System.Windows.Forms.TextBox
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents lblWildFireURL As System.Windows.Forms.Label
    Friend WithEvents lblXPSHostname As System.Windows.Forms.Label
    Friend WithEvents flowFireEye As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents tableFireEye As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents flowAbout As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents lbltxtAbout As System.Windows.Forms.Label
    Friend WithEvents flowPANW As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents tablePANWSendAlert As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents grpWildFirePicture As System.Windows.Forms.GroupBox
    Friend WithEvents txtPANWSim As System.Windows.Forms.Label
    Friend WithEvents tablePANWBottom As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tableXPSTextPic As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents txtXPSSim As System.Windows.Forms.Label
    Friend WithEvents grpXPSPicture As System.Windows.Forms.GroupBox
    Friend WithEvents tableXPSGrid As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents flowXPS As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents tableJobInfo As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tableJobExecute As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents flowJobsAPI As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents flowJobInfo As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents tableAgentRemediation As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tableARSendFile As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tableARExecute As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tableARDelete As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tableARKill As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents grpARKill As System.Windows.Forms.GroupBox
    Friend WithEvents tableInclusionFilters As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tableExclusionFilters As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tableFilters As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnFilters_Remove As System.Windows.Forms.Button
    Friend WithEvents btnFilters_Save As System.Windows.Forms.Button
    Friend WithEvents btnFilters_Add As System.Windows.Forms.Button
    Friend WithEvents dgvFilters As System.Windows.Forms.DataGridView
    Friend WithEvents colFilterCheck As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents col_FilterType As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colFilterName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents flowSettings As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents grpReqSettings As System.Windows.Forms.GroupBox
    Friend WithEvents tableSettingRequired As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tableSettingOptional As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents chkIncludPreRelease As System.Windows.Forms.CheckBox
    Friend WithEvents chkUpdates As System.Windows.Forms.CheckBox
    Friend WithEvents btn_CheckForUpdates As System.Windows.Forms.Button
    Friend WithEvents chkbypasscerts As System.Windows.Forms.CheckBox
    Friend WithEvents btnLoadDefaultTemplateName As System.Windows.Forms.Button
    Friend WithEvents tableSettingSave As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tableComputerTargets As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tableNetworkShares As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tableJobInfoTarget As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CreationDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CreatedBy As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastModDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProjectFolderPath As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProjectID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents artifactName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents createDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents severity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents target As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents source As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents project As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents confidence As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents threatScore As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnSavePowershell As System.Windows.Forms.Button
    Friend WithEvents sfdPowerShell As System.Windows.Forms.SaveFileDialog
    Friend WithEvents lvProjectFacets As System.Windows.Forms.ListView
    Friend WithEvents cms_Project As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents NewProjectToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditProjectToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteProjectToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewProjectInReviewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents cms_JobStatus As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EndpointStatusToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ResultToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RetryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CancelJobToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents jobName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents jobStatus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents jobType As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents jobStart As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents jobEnd As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents jobID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents jobResultID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents lvJobStatusFacets As System.Windows.Forms.ListView

End Class
