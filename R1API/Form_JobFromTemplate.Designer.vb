<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_JobFromTemplate
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
        Me.splitJobFromTemplate = New System.Windows.Forms.SplitContainer()
        Me.lblJobFromTemplateMenuText = New System.Windows.Forms.Label()
        Me.btnJobFromTemplateNext = New System.Windows.Forms.Button()
        Me.btnJobFromTemplatePrevious = New System.Windows.Forms.Button()
        Me.btnJobFromTemplateCancel = New System.Windows.Forms.Button()
        Me.tabControlJobFromTemplate = New System.Windows.Forms.TabControl()
        Me.tabProject = New System.Windows.Forms.TabPage()
        Me.splitProjects = New System.Windows.Forms.SplitContainer()
        Me.btnNewProject = New System.Windows.Forms.Button()
        Me.txtSearchProject = New System.Windows.Forms.TextBox()
        Me.dgvProjectList = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CreationDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CreatedBy = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastModDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProjectFolderPath = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProjectID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tabTargets = New System.Windows.Forms.TabPage()
        Me.splitTargetsSelect = New System.Windows.Forms.SplitContainer()
        Me.treeGroups = New System.Windows.Forms.TreeView()
        Me.splitTargetEndpoints = New System.Windows.Forms.SplitContainer()
        Me.txtSearchEndpoint = New System.Windows.Forms.TextBox()
        Me.dgvTargetEndpoints = New System.Windows.Forms.DataGridView()
        Me.CheckEndpoint = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.EndpointName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IPAddress = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OperatingSystem = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastContact = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.targetID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tabSchedule = New System.Windows.Forms.TabPage()
        Me.flowSchedule = New System.Windows.Forms.FlowLayoutPanel()
        Me.grpScheduleOptions = New System.Windows.Forms.GroupBox()
        Me.rdoSchedule_Schedule = New System.Windows.Forms.RadioButton()
        Me.rdoSchedule_Immediate = New System.Windows.Forms.RadioButton()
        Me.grpSchedule_StartDate = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.tabThreatFilters = New System.Windows.Forms.TabPage()
        Me.splitThreatFilters = New System.Windows.Forms.SplitContainer()
        Me.splitThreatFilterAdvanced = New System.Windows.Forms.SplitContainer()
        Me.btnThreatFiltersAdvanced = New System.Windows.Forms.Button()
        Me.grpThreatSelection = New System.Windows.Forms.GroupBox()
        Me.rdoIOCSelected = New System.Windows.Forms.RadioButton()
        Me.rdoIOCAll = New System.Windows.Forms.RadioButton()
        Me.txtSearchThreatFilters = New System.Windows.Forms.TextBox()
        Me.flowThreatScanOptions = New System.Windows.Forms.FlowLayoutPanel()
        Me.grpThreatScanAdvanced = New System.Windows.Forms.GroupBox()
        Me.cmbYARAFileHash = New System.Windows.Forms.ComboBox()
        Me.cmbFileHash = New System.Windows.Forms.ComboBox()
        Me.txtYARAHashSize = New System.Windows.Forms.TextBox()
        Me.txtHashSize = New System.Windows.Forms.TextBox()
        Me.chkThreatScanArchives = New System.Windows.Forms.CheckBox()
        Me.chkDisableFileHashYaraLarger = New System.Windows.Forms.CheckBox()
        Me.chkPerformStringSearch = New System.Windows.Forms.CheckBox()
        Me.chkFileHashDisableLarger = New System.Windows.Forms.CheckBox()
        Me.chkDisableFileHashing = New System.Windows.Forms.CheckBox()
        Me.flowThreatScanArchivesList = New System.Windows.Forms.FlowLayoutPanel()
        Me.dgvThreatFilters = New System.Windows.Forms.DataGridView()
        Me.Selected = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.FilterName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.View = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Source = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AuthoredDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Author = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Category = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Group = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tags = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FilterID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.flowThreatScanAllFilter = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtThreatAuthor = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtThreatCategory = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtThreatGroup = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtThreatSource = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.txtThreatCreate = New System.Windows.Forms.TextBox()
        Me.dtpTime = New System.Windows.Forms.DateTimePicker()
        CType(Me.splitJobFromTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitJobFromTemplate.Panel1.SuspendLayout()
        Me.splitJobFromTemplate.Panel2.SuspendLayout()
        Me.splitJobFromTemplate.SuspendLayout()
        Me.tabControlJobFromTemplate.SuspendLayout()
        Me.tabProject.SuspendLayout()
        CType(Me.splitProjects, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitProjects.Panel1.SuspendLayout()
        Me.splitProjects.Panel2.SuspendLayout()
        Me.splitProjects.SuspendLayout()
        CType(Me.dgvProjectList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabTargets.SuspendLayout()
        CType(Me.splitTargetsSelect, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitTargetsSelect.Panel1.SuspendLayout()
        Me.splitTargetsSelect.Panel2.SuspendLayout()
        Me.splitTargetsSelect.SuspendLayout()
        CType(Me.splitTargetEndpoints, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitTargetEndpoints.Panel1.SuspendLayout()
        Me.splitTargetEndpoints.Panel2.SuspendLayout()
        Me.splitTargetEndpoints.SuspendLayout()
        CType(Me.dgvTargetEndpoints, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabSchedule.SuspendLayout()
        Me.flowSchedule.SuspendLayout()
        Me.grpScheduleOptions.SuspendLayout()
        Me.grpSchedule_StartDate.SuspendLayout()
        Me.tabThreatFilters.SuspendLayout()
        CType(Me.splitThreatFilters, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitThreatFilters.Panel1.SuspendLayout()
        Me.splitThreatFilters.Panel2.SuspendLayout()
        Me.splitThreatFilters.SuspendLayout()
        CType(Me.splitThreatFilterAdvanced, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitThreatFilterAdvanced.Panel1.SuspendLayout()
        Me.splitThreatFilterAdvanced.Panel2.SuspendLayout()
        Me.splitThreatFilterAdvanced.SuspendLayout()
        Me.grpThreatSelection.SuspendLayout()
        Me.flowThreatScanOptions.SuspendLayout()
        Me.grpThreatScanAdvanced.SuspendLayout()
        CType(Me.dgvThreatFilters, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.flowThreatScanAllFilter.SuspendLayout()
        Me.SuspendLayout()
        '
        'splitJobFromTemplate
        '
        Me.splitJobFromTemplate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitJobFromTemplate.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.splitJobFromTemplate.IsSplitterFixed = True
        Me.splitJobFromTemplate.Location = New System.Drawing.Point(0, 0)
        Me.splitJobFromTemplate.Name = "splitJobFromTemplate"
        Me.splitJobFromTemplate.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'splitJobFromTemplate.Panel1
        '
        Me.splitJobFromTemplate.Panel1.Controls.Add(Me.lblJobFromTemplateMenuText)
        Me.splitJobFromTemplate.Panel1.Controls.Add(Me.btnJobFromTemplateNext)
        Me.splitJobFromTemplate.Panel1.Controls.Add(Me.btnJobFromTemplatePrevious)
        Me.splitJobFromTemplate.Panel1.Controls.Add(Me.btnJobFromTemplateCancel)
        Me.splitJobFromTemplate.Panel1MinSize = 50
        '
        'splitJobFromTemplate.Panel2
        '
        Me.splitJobFromTemplate.Panel2.Controls.Add(Me.tabControlJobFromTemplate)
        Me.splitJobFromTemplate.Size = New System.Drawing.Size(1030, 561)
        Me.splitJobFromTemplate.TabIndex = 0
        '
        'lblJobFromTemplateMenuText
        '
        Me.lblJobFromTemplateMenuText.AutoSize = True
        Me.lblJobFromTemplateMenuText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJobFromTemplateMenuText.Location = New System.Drawing.Point(194, 10)
        Me.lblJobFromTemplateMenuText.Name = "lblJobFromTemplateMenuText"
        Me.lblJobFromTemplateMenuText.Size = New System.Drawing.Size(288, 25)
        Me.lblJobFromTemplateMenuText.TabIndex = 3
        Me.lblJobFromTemplateMenuText.Text = "Pick the project to store the data"
        '
        'btnJobFromTemplateNext
        '
        Me.btnJobFromTemplateNext.Location = New System.Drawing.Point(677, 12)
        Me.btnJobFromTemplateNext.Name = "btnJobFromTemplateNext"
        Me.btnJobFromTemplateNext.Size = New System.Drawing.Size(75, 23)
        Me.btnJobFromTemplateNext.TabIndex = 2
        Me.btnJobFromTemplateNext.Text = "Next"
        Me.btnJobFromTemplateNext.UseVisualStyleBackColor = True
        '
        'btnJobFromTemplatePrevious
        '
        Me.btnJobFromTemplatePrevious.Location = New System.Drawing.Point(103, 12)
        Me.btnJobFromTemplatePrevious.Name = "btnJobFromTemplatePrevious"
        Me.btnJobFromTemplatePrevious.Size = New System.Drawing.Size(75, 23)
        Me.btnJobFromTemplatePrevious.TabIndex = 1
        Me.btnJobFromTemplatePrevious.Text = "Previous"
        Me.btnJobFromTemplatePrevious.UseVisualStyleBackColor = True
        '
        'btnJobFromTemplateCancel
        '
        Me.btnJobFromTemplateCancel.Location = New System.Drawing.Point(12, 12)
        Me.btnJobFromTemplateCancel.Name = "btnJobFromTemplateCancel"
        Me.btnJobFromTemplateCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnJobFromTemplateCancel.TabIndex = 0
        Me.btnJobFromTemplateCancel.Text = "Cancel"
        Me.btnJobFromTemplateCancel.UseVisualStyleBackColor = True
        '
        'tabControlJobFromTemplate
        '
        Me.tabControlJobFromTemplate.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.tabControlJobFromTemplate.Controls.Add(Me.tabProject)
        Me.tabControlJobFromTemplate.Controls.Add(Me.tabTargets)
        Me.tabControlJobFromTemplate.Controls.Add(Me.tabSchedule)
        Me.tabControlJobFromTemplate.Controls.Add(Me.tabThreatFilters)
        Me.tabControlJobFromTemplate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabControlJobFromTemplate.Location = New System.Drawing.Point(0, 0)
        Me.tabControlJobFromTemplate.Multiline = True
        Me.tabControlJobFromTemplate.Name = "tabControlJobFromTemplate"
        Me.tabControlJobFromTemplate.SelectedIndex = 0
        Me.tabControlJobFromTemplate.Size = New System.Drawing.Size(1030, 507)
        Me.tabControlJobFromTemplate.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight
        Me.tabControlJobFromTemplate.TabIndex = 0
        '
        'tabProject
        '
        Me.tabProject.Controls.Add(Me.splitProjects)
        Me.tabProject.Location = New System.Drawing.Point(4, 28)
        Me.tabProject.Name = "tabProject"
        Me.tabProject.Padding = New System.Windows.Forms.Padding(3)
        Me.tabProject.Size = New System.Drawing.Size(1022, 475)
        Me.tabProject.TabIndex = 0
        Me.tabProject.Text = "Project"
        Me.tabProject.UseVisualStyleBackColor = True
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
        Me.splitProjects.Panel1.Controls.Add(Me.btnNewProject)
        Me.splitProjects.Panel1.Controls.Add(Me.txtSearchProject)
        Me.splitProjects.Panel1MinSize = 40
        '
        'splitProjects.Panel2
        '
        Me.splitProjects.Panel2.Controls.Add(Me.dgvProjectList)
        Me.splitProjects.Size = New System.Drawing.Size(1016, 469)
        Me.splitProjects.SplitterDistance = 40
        Me.splitProjects.TabIndex = 1
        '
        'btnNewProject
        '
        Me.btnNewProject.AutoSize = True
        Me.btnNewProject.Location = New System.Drawing.Point(9, 6)
        Me.btnNewProject.Name = "btnNewProject"
        Me.btnNewProject.Size = New System.Drawing.Size(50, 27)
        Me.btnNewProject.TabIndex = 2
        Me.btnNewProject.Text = "New"
        Me.btnNewProject.UseVisualStyleBackColor = True
        '
        'txtSearchProject
        '
        Me.txtSearchProject.AcceptsReturn = True
        Me.txtSearchProject.Location = New System.Drawing.Point(65, 8)
        Me.txtSearchProject.Name = "txtSearchProject"
        Me.txtSearchProject.Size = New System.Drawing.Size(209, 22)
        Me.txtSearchProject.TabIndex = 1
        Me.txtSearchProject.Text = "Search"
        '
        'dgvProjectList
        '
        Me.dgvProjectList.AllowUserToAddRows = False
        Me.dgvProjectList.AllowUserToDeleteRows = False
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
        Me.dgvProjectList.Size = New System.Drawing.Size(1016, 425)
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
        'tabTargets
        '
        Me.tabTargets.Controls.Add(Me.splitTargetsSelect)
        Me.tabTargets.Location = New System.Drawing.Point(4, 28)
        Me.tabTargets.Name = "tabTargets"
        Me.tabTargets.Padding = New System.Windows.Forms.Padding(3)
        Me.tabTargets.Size = New System.Drawing.Size(1022, 475)
        Me.tabTargets.TabIndex = 1
        Me.tabTargets.Text = "Targets"
        Me.tabTargets.UseVisualStyleBackColor = True
        '
        'splitTargetsSelect
        '
        Me.splitTargetsSelect.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitTargetsSelect.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.splitTargetsSelect.IsSplitterFixed = True
        Me.splitTargetsSelect.Location = New System.Drawing.Point(3, 3)
        Me.splitTargetsSelect.Name = "splitTargetsSelect"
        '
        'splitTargetsSelect.Panel1
        '
        Me.splitTargetsSelect.Panel1.AutoScroll = True
        Me.splitTargetsSelect.Panel1.Controls.Add(Me.treeGroups)
        Me.splitTargetsSelect.Panel1MinSize = 175
        '
        'splitTargetsSelect.Panel2
        '
        Me.splitTargetsSelect.Panel2.Controls.Add(Me.splitTargetEndpoints)
        Me.splitTargetsSelect.Size = New System.Drawing.Size(1016, 469)
        Me.splitTargetsSelect.SplitterDistance = 175
        Me.splitTargetsSelect.TabIndex = 0
        '
        'treeGroups
        '
        Me.treeGroups.Dock = System.Windows.Forms.DockStyle.Fill
        Me.treeGroups.Location = New System.Drawing.Point(0, 0)
        Me.treeGroups.Name = "treeGroups"
        Me.treeGroups.Size = New System.Drawing.Size(175, 469)
        Me.treeGroups.TabIndex = 0
        '
        'splitTargetEndpoints
        '
        Me.splitTargetEndpoints.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitTargetEndpoints.IsSplitterFixed = True
        Me.splitTargetEndpoints.Location = New System.Drawing.Point(0, 0)
        Me.splitTargetEndpoints.Name = "splitTargetEndpoints"
        Me.splitTargetEndpoints.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'splitTargetEndpoints.Panel1
        '
        Me.splitTargetEndpoints.Panel1.Controls.Add(Me.txtSearchEndpoint)
        Me.splitTargetEndpoints.Panel1MinSize = 40
        '
        'splitTargetEndpoints.Panel2
        '
        Me.splitTargetEndpoints.Panel2.Controls.Add(Me.dgvTargetEndpoints)
        Me.splitTargetEndpoints.Size = New System.Drawing.Size(837, 469)
        Me.splitTargetEndpoints.SplitterDistance = 40
        Me.splitTargetEndpoints.TabIndex = 2
        '
        'txtSearchEndpoint
        '
        Me.txtSearchEndpoint.AcceptsReturn = True
        Me.txtSearchEndpoint.Location = New System.Drawing.Point(10, 9)
        Me.txtSearchEndpoint.Name = "txtSearchEndpoint"
        Me.txtSearchEndpoint.Size = New System.Drawing.Size(209, 22)
        Me.txtSearchEndpoint.TabIndex = 1
        Me.txtSearchEndpoint.Text = "Search"
        '
        'dgvTargetEndpoints
        '
        Me.dgvTargetEndpoints.AllowUserToAddRows = False
        Me.dgvTargetEndpoints.AllowUserToDeleteRows = False
        Me.dgvTargetEndpoints.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvTargetEndpoints.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTargetEndpoints.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CheckEndpoint, Me.EndpointName, Me.IPAddress, Me.OperatingSystem, Me.LastContact, Me.targetID})
        Me.dgvTargetEndpoints.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvTargetEndpoints.Location = New System.Drawing.Point(0, 0)
        Me.dgvTargetEndpoints.MultiSelect = False
        Me.dgvTargetEndpoints.Name = "dgvTargetEndpoints"
        Me.dgvTargetEndpoints.RowHeadersVisible = False
        Me.dgvTargetEndpoints.RowTemplate.Height = 24
        Me.dgvTargetEndpoints.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTargetEndpoints.Size = New System.Drawing.Size(837, 425)
        Me.dgvTargetEndpoints.TabIndex = 1
        '
        'CheckEndpoint
        '
        Me.CheckEndpoint.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.CheckEndpoint.FillWeight = 1.0!
        Me.CheckEndpoint.HeaderText = "Select"
        Me.CheckEndpoint.Name = "CheckEndpoint"
        Me.CheckEndpoint.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CheckEndpoint.Width = 63
        '
        'EndpointName
        '
        Me.EndpointName.FillWeight = 112.3096!
        Me.EndpointName.HeaderText = "Endpoint Name"
        Me.EndpointName.Name = "EndpointName"
        Me.EndpointName.ReadOnly = True
        '
        'IPAddress
        '
        Me.IPAddress.FillWeight = 112.3096!
        Me.IPAddress.HeaderText = "IP Address"
        Me.IPAddress.Name = "IPAddress"
        Me.IPAddress.ReadOnly = True
        '
        'OperatingSystem
        '
        Me.OperatingSystem.FillWeight = 112.3096!
        Me.OperatingSystem.HeaderText = "Operating System"
        Me.OperatingSystem.Name = "OperatingSystem"
        Me.OperatingSystem.ReadOnly = True
        '
        'LastContact
        '
        Me.LastContact.FillWeight = 112.3096!
        Me.LastContact.HeaderText = "Last Contact"
        Me.LastContact.Name = "LastContact"
        Me.LastContact.ReadOnly = True
        '
        'targetID
        '
        Me.targetID.HeaderText = "TargetID"
        Me.targetID.Name = "targetID"
        Me.targetID.ReadOnly = True
        Me.targetID.Visible = False
        '
        'tabSchedule
        '
        Me.tabSchedule.Controls.Add(Me.flowSchedule)
        Me.tabSchedule.Location = New System.Drawing.Point(4, 28)
        Me.tabSchedule.Name = "tabSchedule"
        Me.tabSchedule.Size = New System.Drawing.Size(1022, 475)
        Me.tabSchedule.TabIndex = 2
        Me.tabSchedule.Text = "Schedule"
        Me.tabSchedule.UseVisualStyleBackColor = True
        '
        'flowSchedule
        '
        Me.flowSchedule.Controls.Add(Me.grpScheduleOptions)
        Me.flowSchedule.Controls.Add(Me.grpSchedule_StartDate)
        Me.flowSchedule.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flowSchedule.Location = New System.Drawing.Point(0, 0)
        Me.flowSchedule.Name = "flowSchedule"
        Me.flowSchedule.Size = New System.Drawing.Size(1022, 475)
        Me.flowSchedule.TabIndex = 0
        '
        'grpScheduleOptions
        '
        Me.grpScheduleOptions.AutoSize = True
        Me.grpScheduleOptions.Controls.Add(Me.rdoSchedule_Schedule)
        Me.grpScheduleOptions.Controls.Add(Me.rdoSchedule_Immediate)
        Me.flowSchedule.SetFlowBreak(Me.grpScheduleOptions, True)
        Me.grpScheduleOptions.Location = New System.Drawing.Point(3, 3)
        Me.grpScheduleOptions.Name = "grpScheduleOptions"
        Me.grpScheduleOptions.Size = New System.Drawing.Size(458, 87)
        Me.grpScheduleOptions.TabIndex = 0
        Me.grpScheduleOptions.TabStop = False
        Me.grpScheduleOptions.Text = "Scheduling Options:"
        '
        'rdoSchedule_Schedule
        '
        Me.rdoSchedule_Schedule.AutoSize = True
        Me.rdoSchedule_Schedule.Location = New System.Drawing.Point(291, 45)
        Me.rdoSchedule_Schedule.Name = "rdoSchedule_Schedule"
        Me.rdoSchedule_Schedule.Size = New System.Drawing.Size(161, 21)
        Me.rdoSchedule_Schedule.TabIndex = 1
        Me.rdoSchedule_Schedule.TabStop = True
        Me.rdoSchedule_Schedule.Text = "Scheduled Execution"
        Me.rdoSchedule_Schedule.UseVisualStyleBackColor = True
        '
        'rdoSchedule_Immediate
        '
        Me.rdoSchedule_Immediate.AutoSize = True
        Me.rdoSchedule_Immediate.Checked = True
        Me.rdoSchedule_Immediate.Location = New System.Drawing.Point(40, 45)
        Me.rdoSchedule_Immediate.Name = "rdoSchedule_Immediate"
        Me.rdoSchedule_Immediate.Size = New System.Drawing.Size(158, 21)
        Me.rdoSchedule_Immediate.TabIndex = 0
        Me.rdoSchedule_Immediate.TabStop = True
        Me.rdoSchedule_Immediate.Text = "Immediate Execution"
        Me.rdoSchedule_Immediate.UseVisualStyleBackColor = True
        '
        'grpSchedule_StartDate
        '
        Me.grpSchedule_StartDate.Controls.Add(Me.DateTimePicker1)
        Me.grpSchedule_StartDate.Location = New System.Drawing.Point(3, 96)
        Me.grpSchedule_StartDate.Name = "grpSchedule_StartDate"
        Me.grpSchedule_StartDate.Size = New System.Drawing.Size(458, 83)
        Me.grpSchedule_StartDate.TabIndex = 1
        Me.grpSchedule_StartDate.TabStop = False
        Me.grpSchedule_StartDate.Text = "Start Date and Time"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DateTimePicker1.Location = New System.Drawing.Point(6, 30)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(259, 22)
        Me.DateTimePicker1.TabIndex = 0
        '
        'tabThreatFilters
        '
        Me.tabThreatFilters.Controls.Add(Me.splitThreatFilters)
        Me.tabThreatFilters.Location = New System.Drawing.Point(4, 28)
        Me.tabThreatFilters.Name = "tabThreatFilters"
        Me.tabThreatFilters.Padding = New System.Windows.Forms.Padding(3)
        Me.tabThreatFilters.Size = New System.Drawing.Size(1022, 475)
        Me.tabThreatFilters.TabIndex = 3
        Me.tabThreatFilters.Text = "Threat Filters"
        Me.tabThreatFilters.UseVisualStyleBackColor = True
        '
        'splitThreatFilters
        '
        Me.splitThreatFilters.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitThreatFilters.Location = New System.Drawing.Point(3, 3)
        Me.splitThreatFilters.MinimumSize = New System.Drawing.Size(1016, 469)
        Me.splitThreatFilters.Name = "splitThreatFilters"
        Me.splitThreatFilters.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'splitThreatFilters.Panel1
        '
        Me.splitThreatFilters.Panel1.Controls.Add(Me.splitThreatFilterAdvanced)
        Me.splitThreatFilters.Panel1MinSize = 40
        '
        'splitThreatFilters.Panel2
        '
        Me.splitThreatFilters.Panel2.Controls.Add(Me.dgvThreatFilters)
        Me.splitThreatFilters.Size = New System.Drawing.Size(1016, 469)
        Me.splitThreatFilters.SplitterDistance = 380
        Me.splitThreatFilters.TabIndex = 2
        '
        'splitThreatFilterAdvanced
        '
        Me.splitThreatFilterAdvanced.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitThreatFilterAdvanced.Location = New System.Drawing.Point(0, 0)
        Me.splitThreatFilterAdvanced.MinimumSize = New System.Drawing.Size(1016, 266)
        Me.splitThreatFilterAdvanced.Name = "splitThreatFilterAdvanced"
        Me.splitThreatFilterAdvanced.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'splitThreatFilterAdvanced.Panel1
        '
        Me.splitThreatFilterAdvanced.Panel1.Controls.Add(Me.btnThreatFiltersAdvanced)
        Me.splitThreatFilterAdvanced.Panel1.Controls.Add(Me.grpThreatSelection)
        Me.splitThreatFilterAdvanced.Panel1.Controls.Add(Me.txtSearchThreatFilters)
        Me.splitThreatFilterAdvanced.Panel1MinSize = 40
        '
        'splitThreatFilterAdvanced.Panel2
        '
        Me.splitThreatFilterAdvanced.Panel2.Controls.Add(Me.flowThreatScanOptions)
        Me.splitThreatFilterAdvanced.Size = New System.Drawing.Size(1016, 380)
        Me.splitThreatFilterAdvanced.SplitterDistance = 62
        Me.splitThreatFilterAdvanced.TabIndex = 4
        '
        'btnThreatFiltersAdvanced
        '
        Me.btnThreatFiltersAdvanced.Location = New System.Drawing.Point(528, 5)
        Me.btnThreatFiltersAdvanced.Name = "btnThreatFiltersAdvanced"
        Me.btnThreatFiltersAdvanced.Size = New System.Drawing.Size(119, 28)
        Me.btnThreatFiltersAdvanced.TabIndex = 6
        Me.btnThreatFiltersAdvanced.Text = "Advanced"
        Me.btnThreatFiltersAdvanced.UseVisualStyleBackColor = True
        '
        'grpThreatSelection
        '
        Me.grpThreatSelection.Controls.Add(Me.rdoIOCSelected)
        Me.grpThreatSelection.Controls.Add(Me.rdoIOCAll)
        Me.grpThreatSelection.Location = New System.Drawing.Point(269, -1)
        Me.grpThreatSelection.Name = "grpThreatSelection"
        Me.grpThreatSelection.Size = New System.Drawing.Size(234, 35)
        Me.grpThreatSelection.TabIndex = 5
        Me.grpThreatSelection.TabStop = False
        '
        'rdoIOCSelected
        '
        Me.rdoIOCSelected.AutoSize = True
        Me.rdoIOCSelected.Location = New System.Drawing.Point(110, 7)
        Me.rdoIOCSelected.Name = "rdoIOCSelected"
        Me.rdoIOCSelected.Size = New System.Drawing.Size(118, 21)
        Me.rdoIOCSelected.TabIndex = 1
        Me.rdoIOCSelected.Text = "Selected IOCs"
        Me.rdoIOCSelected.UseVisualStyleBackColor = True
        '
        'rdoIOCAll
        '
        Me.rdoIOCAll.AutoSize = True
        Me.rdoIOCAll.Checked = True
        Me.rdoIOCAll.Location = New System.Drawing.Point(6, 7)
        Me.rdoIOCAll.Name = "rdoIOCAll"
        Me.rdoIOCAll.Size = New System.Drawing.Size(78, 21)
        Me.rdoIOCAll.TabIndex = 0
        Me.rdoIOCAll.TabStop = True
        Me.rdoIOCAll.Text = "All IOCs"
        Me.rdoIOCAll.UseVisualStyleBackColor = True
        '
        'txtSearchThreatFilters
        '
        Me.txtSearchThreatFilters.AcceptsReturn = True
        Me.txtSearchThreatFilters.Location = New System.Drawing.Point(33, 5)
        Me.txtSearchThreatFilters.Name = "txtSearchThreatFilters"
        Me.txtSearchThreatFilters.Size = New System.Drawing.Size(209, 22)
        Me.txtSearchThreatFilters.TabIndex = 4
        Me.txtSearchThreatFilters.Text = "Search"
        '
        'flowThreatScanOptions
        '
        Me.flowThreatScanOptions.Controls.Add(Me.grpThreatScanAdvanced)
        Me.flowThreatScanOptions.Controls.Add(Me.flowThreatScanArchivesList)
        Me.flowThreatScanOptions.Controls.Add(Me.flowThreatScanAllFilter)
        Me.flowThreatScanOptions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flowThreatScanOptions.Location = New System.Drawing.Point(0, 0)
        Me.flowThreatScanOptions.Name = "flowThreatScanOptions"
        Me.flowThreatScanOptions.Size = New System.Drawing.Size(1016, 314)
        Me.flowThreatScanOptions.TabIndex = 0
        '
        'grpThreatScanAdvanced
        '
        Me.grpThreatScanAdvanced.Controls.Add(Me.cmbYARAFileHash)
        Me.grpThreatScanAdvanced.Controls.Add(Me.cmbFileHash)
        Me.grpThreatScanAdvanced.Controls.Add(Me.txtYARAHashSize)
        Me.grpThreatScanAdvanced.Controls.Add(Me.txtHashSize)
        Me.grpThreatScanAdvanced.Controls.Add(Me.chkThreatScanArchives)
        Me.grpThreatScanAdvanced.Controls.Add(Me.chkDisableFileHashYaraLarger)
        Me.grpThreatScanAdvanced.Controls.Add(Me.chkPerformStringSearch)
        Me.grpThreatScanAdvanced.Controls.Add(Me.chkFileHashDisableLarger)
        Me.grpThreatScanAdvanced.Controls.Add(Me.chkDisableFileHashing)
        Me.flowThreatScanOptions.SetFlowBreak(Me.grpThreatScanAdvanced, True)
        Me.grpThreatScanAdvanced.Location = New System.Drawing.Point(3, 3)
        Me.grpThreatScanAdvanced.Name = "grpThreatScanAdvanced"
        Me.grpThreatScanAdvanced.Size = New System.Drawing.Size(997, 92)
        Me.grpThreatScanAdvanced.TabIndex = 1
        Me.grpThreatScanAdvanced.TabStop = False
        Me.grpThreatScanAdvanced.Text = "Threat Scan Options"
        '
        'cmbYARAFileHash
        '
        Me.cmbYARAFileHash.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbYARAFileHash.Enabled = False
        Me.cmbYARAFileHash.FormattingEnabled = True
        Me.cmbYARAFileHash.Items.AddRange(New Object() {"KB", "MB"})
        Me.cmbYARAFileHash.Location = New System.Drawing.Point(648, 55)
        Me.cmbYARAFileHash.Name = "cmbYARAFileHash"
        Me.cmbYARAFileHash.Size = New System.Drawing.Size(72, 24)
        Me.cmbYARAFileHash.TabIndex = 8
        '
        'cmbFileHash
        '
        Me.cmbFileHash.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFileHash.Enabled = False
        Me.cmbFileHash.FormattingEnabled = True
        Me.cmbFileHash.Items.AddRange(New Object() {"KB", "MB"})
        Me.cmbFileHash.Location = New System.Drawing.Point(648, 17)
        Me.cmbFileHash.Name = "cmbFileHash"
        Me.cmbFileHash.Size = New System.Drawing.Size(72, 24)
        Me.cmbFileHash.TabIndex = 7
        '
        'txtYARAHashSize
        '
        Me.txtYARAHashSize.Enabled = False
        Me.txtYARAHashSize.Location = New System.Drawing.Point(571, 55)
        Me.txtYARAHashSize.Name = "txtYARAHashSize"
        Me.txtYARAHashSize.ShortcutsEnabled = False
        Me.txtYARAHashSize.Size = New System.Drawing.Size(71, 22)
        Me.txtYARAHashSize.TabIndex = 6
        '
        'txtHashSize
        '
        Me.txtHashSize.Enabled = False
        Me.txtHashSize.Location = New System.Drawing.Point(571, 19)
        Me.txtHashSize.Name = "txtHashSize"
        Me.txtHashSize.ShortcutsEnabled = False
        Me.txtHashSize.Size = New System.Drawing.Size(71, 22)
        Me.txtHashSize.TabIndex = 5
        '
        'chkThreatScanArchives
        '
        Me.chkThreatScanArchives.AutoSize = True
        Me.chkThreatScanArchives.Location = New System.Drawing.Point(6, 57)
        Me.chkThreatScanArchives.Name = "chkThreatScanArchives"
        Me.chkThreatScanArchives.Size = New System.Drawing.Size(276, 21)
        Me.chkThreatScanArchives.TabIndex = 4
        Me.chkThreatScanArchives.Text = "Examine files in archives (.zip, .tar, etc)"
        Me.chkThreatScanArchives.UseVisualStyleBackColor = True
        '
        'chkDisableFileHashYaraLarger
        '
        Me.chkDisableFileHashYaraLarger.AutoSize = True
        Me.chkDisableFileHashYaraLarger.Location = New System.Drawing.Point(331, 57)
        Me.chkDisableFileHashYaraLarger.Name = "chkDisableFileHashYaraLarger"
        Me.chkDisableFileHashYaraLarger.Size = New System.Drawing.Size(249, 21)
        Me.chkDisableFileHashYaraLarger.TabIndex = 3
        Me.chkDisableFileHashYaraLarger.Text = "Disable YARA for files larger than: "
        Me.chkDisableFileHashYaraLarger.UseVisualStyleBackColor = True
        '
        'chkPerformStringSearch
        '
        Me.chkPerformStringSearch.AutoSize = True
        Me.chkPerformStringSearch.Checked = True
        Me.chkPerformStringSearch.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkPerformStringSearch.Location = New System.Drawing.Point(768, 12)
        Me.chkPerformStringSearch.Name = "chkPerformStringSearch"
        Me.chkPerformStringSearch.Size = New System.Drawing.Size(223, 21)
        Me.chkPerformStringSearch.TabIndex = 2
        Me.chkPerformStringSearch.Text = "Perform String Content Search"
        Me.chkPerformStringSearch.UseVisualStyleBackColor = True
        '
        'chkFileHashDisableLarger
        '
        Me.chkFileHashDisableLarger.AutoSize = True
        Me.chkFileHashDisableLarger.Enabled = False
        Me.chkFileHashDisableLarger.Location = New System.Drawing.Point(331, 21)
        Me.chkFileHashDisableLarger.Name = "chkFileHashDisableLarger"
        Me.chkFileHashDisableLarger.Size = New System.Drawing.Size(234, 21)
        Me.chkFileHashDisableLarger.TabIndex = 1
        Me.chkFileHashDisableLarger.Text = "Disable only for files larger than:"
        Me.chkFileHashDisableLarger.UseVisualStyleBackColor = True
        '
        'chkDisableFileHashing
        '
        Me.chkDisableFileHashing.AutoSize = True
        Me.chkDisableFileHashing.Location = New System.Drawing.Point(6, 21)
        Me.chkDisableFileHashing.Name = "chkDisableFileHashing"
        Me.chkDisableFileHashing.Size = New System.Drawing.Size(159, 21)
        Me.chkDisableFileHashing.TabIndex = 0
        Me.chkDisableFileHashing.Text = "Disable File Hashing"
        Me.chkDisableFileHashing.UseVisualStyleBackColor = True
        '
        'flowThreatScanArchivesList
        '
        Me.flowThreatScanArchivesList.AutoScroll = True
        Me.flowThreatScanArchivesList.AutoSize = True
        Me.flowThreatScanArchivesList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flowThreatScanOptions.SetFlowBreak(Me.flowThreatScanArchivesList, True)
        Me.flowThreatScanArchivesList.Location = New System.Drawing.Point(3, 101)
        Me.flowThreatScanArchivesList.MinimumSize = New System.Drawing.Size(1000, 100)
        Me.flowThreatScanArchivesList.Name = "flowThreatScanArchivesList"
        Me.flowThreatScanArchivesList.Size = New System.Drawing.Size(1000, 100)
        Me.flowThreatScanArchivesList.TabIndex = 2
        Me.flowThreatScanArchivesList.Visible = False
        '
        'dgvThreatFilters
        '
        Me.dgvThreatFilters.AllowUserToAddRows = False
        Me.dgvThreatFilters.AllowUserToDeleteRows = False
        Me.dgvThreatFilters.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvThreatFilters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvThreatFilters.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Selected, Me.FilterName, Me.View, Me.Description, Me.Source, Me.AuthoredDate, Me.Author, Me.Type, Me.Category, Me.Group, Me.Tags, Me.FilterID})
        Me.dgvThreatFilters.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvThreatFilters.Location = New System.Drawing.Point(0, 0)
        Me.dgvThreatFilters.MultiSelect = False
        Me.dgvThreatFilters.Name = "dgvThreatFilters"
        Me.dgvThreatFilters.RowHeadersVisible = False
        Me.dgvThreatFilters.RowTemplate.Height = 24
        Me.dgvThreatFilters.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvThreatFilters.Size = New System.Drawing.Size(1016, 85)
        Me.dgvThreatFilters.TabIndex = 1
        '
        'Selected
        '
        Me.Selected.FillWeight = 71.43088!
        Me.Selected.HeaderText = "Select"
        Me.Selected.Name = "Selected"
        '
        'FilterName
        '
        Me.FilterName.FillWeight = 71.43088!
        Me.FilterName.HeaderText = "Name"
        Me.FilterName.Name = "FilterName"
        Me.FilterName.ReadOnly = True
        '
        'View
        '
        Me.View.FillWeight = 1.0!
        Me.View.HeaderText = "View"
        Me.View.MinimumWidth = 45
        Me.View.Name = "View"
        Me.View.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Description
        '
        Me.Description.FillWeight = 71.43088!
        Me.Description.HeaderText = "Description"
        Me.Description.Name = "Description"
        Me.Description.ReadOnly = True
        '
        'Source
        '
        Me.Source.FillWeight = 71.43088!
        Me.Source.HeaderText = "Source"
        Me.Source.Name = "Source"
        Me.Source.ReadOnly = True
        '
        'AuthoredDate
        '
        Me.AuthoredDate.FillWeight = 71.43088!
        Me.AuthoredDate.HeaderText = "Authored Date"
        Me.AuthoredDate.Name = "AuthoredDate"
        Me.AuthoredDate.ReadOnly = True
        '
        'Author
        '
        Me.Author.FillWeight = 71.43088!
        Me.Author.HeaderText = "Authored By"
        Me.Author.Name = "Author"
        Me.Author.ReadOnly = True
        '
        'Type
        '
        Me.Type.FillWeight = 71.43088!
        Me.Type.HeaderText = "Type"
        Me.Type.Name = "Type"
        Me.Type.ReadOnly = True
        '
        'Category
        '
        Me.Category.FillWeight = 71.43088!
        Me.Category.HeaderText = "Category"
        Me.Category.Name = "Category"
        Me.Category.ReadOnly = True
        '
        'Group
        '
        Me.Group.FillWeight = 71.43088!
        Me.Group.HeaderText = "Group"
        Me.Group.Name = "Group"
        Me.Group.ReadOnly = True
        '
        'Tags
        '
        Me.Tags.FillWeight = 71.43088!
        Me.Tags.HeaderText = "Tags"
        Me.Tags.Name = "Tags"
        Me.Tags.ReadOnly = True
        '
        'FilterID
        '
        Me.FilterID.HeaderText = "Filter ID"
        Me.FilterID.Name = "FilterID"
        Me.FilterID.Visible = False
        '
        'flowThreatScanAllFilter
        '
        Me.flowThreatScanAllFilter.AutoScroll = True
        Me.flowThreatScanAllFilter.AutoSize = True
        Me.flowThreatScanAllFilter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.flowThreatScanAllFilter.Controls.Add(Me.Label1)
        Me.flowThreatScanAllFilter.Controls.Add(Me.txtThreatAuthor)
        Me.flowThreatScanAllFilter.Controls.Add(Me.Label2)
        Me.flowThreatScanAllFilter.Controls.Add(Me.txtThreatCategory)
        Me.flowThreatScanAllFilter.Controls.Add(Me.Label3)
        Me.flowThreatScanAllFilter.Controls.Add(Me.txtThreatGroup)
        Me.flowThreatScanAllFilter.Controls.Add(Me.Label4)
        Me.flowThreatScanAllFilter.Controls.Add(Me.txtThreatSource)
        Me.flowThreatScanAllFilter.Controls.Add(Me.Label5)
        Me.flowThreatScanAllFilter.Controls.Add(Me.txtThreatCreate)
        Me.flowThreatScanAllFilter.Controls.Add(Me.dtpDate)
        Me.flowThreatScanAllFilter.Controls.Add(Me.dtpTime)
        Me.flowThreatScanAllFilter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flowThreatScanAllFilter.Location = New System.Drawing.Point(3, 207)
        Me.flowThreatScanAllFilter.MinimumSize = New System.Drawing.Size(1000, 100)
        Me.flowThreatScanAllFilter.Name = "flowThreatScanAllFilter"
        Me.flowThreatScanAllFilter.Size = New System.Drawing.Size(1000, 100)
        Me.flowThreatScanAllFilter.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Authored By:"
        '
        'txtThreatAuthor
        '
        Me.txtThreatAuthor.Location = New System.Drawing.Point(99, 3)
        Me.txtThreatAuthor.Name = "txtThreatAuthor"
        Me.txtThreatAuthor.Size = New System.Drawing.Size(140, 22)
        Me.txtThreatAuthor.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(245, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Category:"
        '
        'txtThreatCategory
        '
        Me.txtThreatCategory.Location = New System.Drawing.Point(320, 3)
        Me.txtThreatCategory.Name = "txtThreatCategory"
        Me.txtThreatCategory.Size = New System.Drawing.Size(140, 22)
        Me.txtThreatCategory.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(466, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Group:"
        '
        'txtThreatGroup
        '
        Me.txtThreatGroup.Location = New System.Drawing.Point(524, 3)
        Me.txtThreatGroup.Name = "txtThreatGroup"
        Me.txtThreatGroup.Size = New System.Drawing.Size(140, 22)
        Me.txtThreatGroup.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(670, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Source:"
        '
        'txtThreatSource
        '
        Me.flowThreatScanAllFilter.SetFlowBreak(Me.txtThreatSource, True)
        Me.txtThreatSource.Location = New System.Drawing.Point(733, 3)
        Me.txtThreatSource.Name = "txtThreatSource"
        Me.txtThreatSource.Size = New System.Drawing.Size(140, 22)
        Me.txtThreatSource.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(139, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Earliest Create Date:"
        '
        'dtpDate
        '
        Me.dtpDate.CustomFormat = "X"
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDate.Location = New System.Drawing.Point(334, 31)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(115, 22)
        Me.dtpDate.TabIndex = 9
        '
        'txtThreatCreate
        '
        Me.txtThreatCreate.Location = New System.Drawing.Point(148, 31)
        Me.txtThreatCreate.Name = "txtThreatCreate"
        Me.txtThreatCreate.ReadOnly = True
        Me.txtThreatCreate.Size = New System.Drawing.Size(180, 22)
        Me.txtThreatCreate.TabIndex = 10
        '
        'dtpTime
        '
        Me.dtpTime.CustomFormat = "X"
        Me.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpTime.Location = New System.Drawing.Point(455, 31)
        Me.dtpTime.Name = "dtpTime"
        Me.dtpTime.ShowUpDown = True
        Me.dtpTime.Size = New System.Drawing.Size(119, 22)
        Me.dtpTime.TabIndex = 11
        '
        'Form_JobFromTemplate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1030, 561)
        Me.Controls.Add(Me.splitJobFromTemplate)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_JobFromTemplate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Job From Template"
        Me.splitJobFromTemplate.Panel1.ResumeLayout(False)
        Me.splitJobFromTemplate.Panel1.PerformLayout()
        Me.splitJobFromTemplate.Panel2.ResumeLayout(False)
        CType(Me.splitJobFromTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitJobFromTemplate.ResumeLayout(False)
        Me.tabControlJobFromTemplate.ResumeLayout(False)
        Me.tabProject.ResumeLayout(False)
        Me.splitProjects.Panel1.ResumeLayout(False)
        Me.splitProjects.Panel1.PerformLayout()
        Me.splitProjects.Panel2.ResumeLayout(False)
        CType(Me.splitProjects, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitProjects.ResumeLayout(False)
        CType(Me.dgvProjectList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabTargets.ResumeLayout(False)
        Me.splitTargetsSelect.Panel1.ResumeLayout(False)
        Me.splitTargetsSelect.Panel2.ResumeLayout(False)
        CType(Me.splitTargetsSelect, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitTargetsSelect.ResumeLayout(False)
        Me.splitTargetEndpoints.Panel1.ResumeLayout(False)
        Me.splitTargetEndpoints.Panel1.PerformLayout()
        Me.splitTargetEndpoints.Panel2.ResumeLayout(False)
        CType(Me.splitTargetEndpoints, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitTargetEndpoints.ResumeLayout(False)
        CType(Me.dgvTargetEndpoints, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabSchedule.ResumeLayout(False)
        Me.flowSchedule.ResumeLayout(False)
        Me.flowSchedule.PerformLayout()
        Me.grpScheduleOptions.ResumeLayout(False)
        Me.grpScheduleOptions.PerformLayout()
        Me.grpSchedule_StartDate.ResumeLayout(False)
        Me.tabThreatFilters.ResumeLayout(False)
        Me.splitThreatFilters.Panel1.ResumeLayout(False)
        Me.splitThreatFilters.Panel2.ResumeLayout(False)
        CType(Me.splitThreatFilters, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitThreatFilters.ResumeLayout(False)
        Me.splitThreatFilterAdvanced.Panel1.ResumeLayout(False)
        Me.splitThreatFilterAdvanced.Panel1.PerformLayout()
        Me.splitThreatFilterAdvanced.Panel2.ResumeLayout(False)
        CType(Me.splitThreatFilterAdvanced, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitThreatFilterAdvanced.ResumeLayout(False)
        Me.grpThreatSelection.ResumeLayout(False)
        Me.grpThreatSelection.PerformLayout()
        Me.flowThreatScanOptions.ResumeLayout(False)
        Me.flowThreatScanOptions.PerformLayout()
        Me.grpThreatScanAdvanced.ResumeLayout(False)
        Me.grpThreatScanAdvanced.PerformLayout()
        CType(Me.dgvThreatFilters, System.ComponentModel.ISupportInitialize).EndInit()
        Me.flowThreatScanAllFilter.ResumeLayout(False)
        Me.flowThreatScanAllFilter.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents splitJobFromTemplate As System.Windows.Forms.SplitContainer
    Friend WithEvents btnJobFromTemplateCancel As System.Windows.Forms.Button
    Friend WithEvents lblJobFromTemplateMenuText As System.Windows.Forms.Label
    Friend WithEvents btnJobFromTemplateNext As System.Windows.Forms.Button
    Friend WithEvents btnJobFromTemplatePrevious As System.Windows.Forms.Button
    Friend WithEvents tabControlJobFromTemplate As System.Windows.Forms.TabControl
    Friend WithEvents tabProject As System.Windows.Forms.TabPage
    Friend WithEvents tabTargets As System.Windows.Forms.TabPage
    Friend WithEvents tabSchedule As System.Windows.Forms.TabPage
    Friend WithEvents splitProjects As System.Windows.Forms.SplitContainer
    Friend WithEvents btnNewProject As System.Windows.Forms.Button
    Friend WithEvents txtSearchProject As System.Windows.Forms.TextBox
    Friend WithEvents dgvProjectList As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CreationDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CreatedBy As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastModDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProjectFolderPath As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProjectID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents splitTargetsSelect As System.Windows.Forms.SplitContainer
    Friend WithEvents treeGroups As System.Windows.Forms.TreeView
    Friend WithEvents splitTargetEndpoints As System.Windows.Forms.SplitContainer
    Friend WithEvents txtSearchEndpoint As System.Windows.Forms.TextBox
    Friend WithEvents dgvTargetEndpoints As System.Windows.Forms.DataGridView
    Friend WithEvents CheckEndpoint As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents EndpointName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IPAddress As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OperatingSystem As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastContact As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents targetID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents flowSchedule As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents grpScheduleOptions As System.Windows.Forms.GroupBox
    Friend WithEvents rdoSchedule_Schedule As System.Windows.Forms.RadioButton
    Friend WithEvents rdoSchedule_Immediate As System.Windows.Forms.RadioButton
    Friend WithEvents tabThreatFilters As System.Windows.Forms.TabPage
    Friend WithEvents splitThreatFilters As System.Windows.Forms.SplitContainer
    Friend WithEvents dgvThreatFilters As System.Windows.Forms.DataGridView
    Friend WithEvents Selected As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents FilterName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents View As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Description As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Source As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AuthoredDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Author As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Type As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Category As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Group As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tags As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FilterID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grpSchedule_StartDate As System.Windows.Forms.GroupBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents splitThreatFilterAdvanced As System.Windows.Forms.SplitContainer
    Friend WithEvents btnThreatFiltersAdvanced As System.Windows.Forms.Button
    Friend WithEvents grpThreatSelection As System.Windows.Forms.GroupBox
    Friend WithEvents rdoIOCSelected As System.Windows.Forms.RadioButton
    Friend WithEvents rdoIOCAll As System.Windows.Forms.RadioButton
    Friend WithEvents txtSearchThreatFilters As System.Windows.Forms.TextBox
    Friend WithEvents flowThreatScanOptions As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents grpThreatScanAdvanced As System.Windows.Forms.GroupBox
    Friend WithEvents cmbYARAFileHash As System.Windows.Forms.ComboBox
    Friend WithEvents cmbFileHash As System.Windows.Forms.ComboBox
    Friend WithEvents txtYARAHashSize As System.Windows.Forms.TextBox
    Friend WithEvents txtHashSize As System.Windows.Forms.TextBox
    Friend WithEvents chkThreatScanArchives As System.Windows.Forms.CheckBox
    Friend WithEvents chkDisableFileHashYaraLarger As System.Windows.Forms.CheckBox
    Friend WithEvents chkPerformStringSearch As System.Windows.Forms.CheckBox
    Friend WithEvents chkFileHashDisableLarger As System.Windows.Forms.CheckBox
    Friend WithEvents chkDisableFileHashing As System.Windows.Forms.CheckBox
    Friend WithEvents flowThreatScanArchivesList As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents flowThreatScanAllFilter As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtThreatAuthor As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtThreatCategory As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtThreatGroup As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtThreatSource As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtThreatCreate As System.Windows.Forms.TextBox
    Friend WithEvents dtpTime As System.Windows.Forms.DateTimePicker
End Class
