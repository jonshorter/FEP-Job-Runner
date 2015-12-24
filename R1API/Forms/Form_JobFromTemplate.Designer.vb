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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_JobFromTemplate))
        Me.splitJobFromTemplate = New System.Windows.Forms.SplitContainer()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnJobFromTemplateCancel = New System.Windows.Forms.Button()
        Me.btnJobFromTemplatePrevious = New System.Windows.Forms.Button()
        Me.lblJobFromTemplateMenuText = New System.Windows.Forms.Label()
        Me.btnJobFromTemplateNext = New System.Windows.Forms.Button()
        Me.tabControlJobFromTemplate = New System.Windows.Forms.TabControl()
        Me.tabProject = New System.Windows.Forms.TabPage()
        Me.splitProjects = New System.Windows.Forms.SplitContainer()
        Me.btnNewProject = New System.Windows.Forms.Button()
        Me.txtSearchProject = New System.Windows.Forms.TextBox()
        Me.dgvProjectList = New System.Windows.Forms.DataGridView()
        Me.tabTargets = New System.Windows.Forms.TabPage()
        Me.splitTargetsSelect = New System.Windows.Forms.SplitContainer()
        Me.treeGroups = New System.Windows.Forms.TreeView()
        Me.splitTargetEndpoints = New System.Windows.Forms.SplitContainer()
        Me.txtSearchEndpoint = New System.Windows.Forms.TextBox()
        Me.dgvTargetEndpoints = New System.Windows.Forms.DataGridView()
        Me.tabSchedule = New System.Windows.Forms.TabPage()
        Me.flowSchedule = New System.Windows.Forms.FlowLayoutPanel()
        Me.grpScheduleOptions = New System.Windows.Forms.GroupBox()
        Me.rdoSchedule_Schedule = New System.Windows.Forms.RadioButton()
        Me.rdoSchedule_Immediate = New System.Windows.Forms.RadioButton()
        Me.grpSchedule_StartDate = New System.Windows.Forms.GroupBox()
        Me.dtpScheduleStart = New System.Windows.Forms.DateTimePicker()
        Me.grpRecurrence = New System.Windows.Forms.GroupBox()
        Me.grpRecurrenceEnd = New System.Windows.Forms.GroupBox()
        Me.dtpRecurEndBy = New System.Windows.Forms.DateTimePicker()
        Me.lblRecurEndOccurences = New System.Windows.Forms.Label()
        Me.nmbRecurEndOccurences = New System.Windows.Forms.NumericUpDown()
        Me.rdoRecurEnd_EndBy = New System.Windows.Forms.RadioButton()
        Me.rdoRecurEnd_After = New System.Windows.Forms.RadioButton()
        Me.rdoRecurEnd_NoEnd = New System.Windows.Forms.RadioButton()
        Me.grpRecurrenceStart = New System.Windows.Forms.GroupBox()
        Me.rdoRecurStart_Yearly = New System.Windows.Forms.RadioButton()
        Me.rdoRecurStart_Monthly = New System.Windows.Forms.RadioButton()
        Me.rdoRecurStart_Weekly = New System.Windows.Forms.RadioButton()
        Me.rdoRecurStart_Daily = New System.Windows.Forms.RadioButton()
        Me.rdoRecurStart_Hourly = New System.Windows.Forms.RadioButton()
        Me.rdoRecurStart_Minute = New System.Windows.Forms.RadioButton()
        Me.panel_RecurWeekly = New System.Windows.Forms.Panel()
        Me.chkRecurWeekly_Saturday = New System.Windows.Forms.CheckBox()
        Me.chkRecurWeekly_Friday = New System.Windows.Forms.CheckBox()
        Me.chkRecurWeekly_Thursday = New System.Windows.Forms.CheckBox()
        Me.chkRecurWeekly_Wednesday = New System.Windows.Forms.CheckBox()
        Me.chkRecurWeekly_Tuesday = New System.Windows.Forms.CheckBox()
        Me.chkRecurWeekly_Monday = New System.Windows.Forms.CheckBox()
        Me.chkRecurWeekly_Sunday = New System.Windows.Forms.CheckBox()
        Me.nmbRecurWeekly_Weeks = New System.Windows.Forms.NumericUpDown()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.panel_recurDaily = New System.Windows.Forms.Panel()
        Me.nmb_RecurDays = New System.Windows.Forms.NumericUpDown()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.panel_RecurMinute = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmb_RecurMinutes = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.panel_RecurHourly = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmb_RecurHours = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.panel_RecurYearly = New System.Windows.Forms.Panel()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cmbRecurYear_TheSelectDay = New System.Windows.Forms.ComboBox()
        Me.cmbRecurYear_TheFirstDay = New System.Windows.Forms.ComboBox()
        Me.cmbRecurYear_TheMonth = New System.Windows.Forms.ComboBox()
        Me.cmbRecurYear_EveryMonth = New System.Windows.Forms.ComboBox()
        Me.nmbRecurYear_Day = New System.Windows.Forms.NumericUpDown()
        Me.rdoRecurYear_The = New System.Windows.Forms.RadioButton()
        Me.rdoRecurYear_Every = New System.Windows.Forms.RadioButton()
        Me.panel_RecurMonthly = New System.Windows.Forms.Panel()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.nmbRecurMonth_DayMonth = New System.Windows.Forms.NumericUpDown()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.nmbRecurMonth_TheMonth = New System.Windows.Forms.NumericUpDown()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cmbRecurMonth_TheSelectDay = New System.Windows.Forms.ComboBox()
        Me.cmbRecurMonth_TheFirstDay = New System.Windows.Forms.ComboBox()
        Me.nmbRecurMonth_Day = New System.Windows.Forms.NumericUpDown()
        Me.rdoRecurMonth_The = New System.Windows.Forms.RadioButton()
        Me.rdoRecurMonth_Day = New System.Windows.Forms.RadioButton()
        Me.chkIncrementalCollection = New System.Windows.Forms.CheckBox()
        Me.chkEnableRecurrence = New System.Windows.Forms.CheckBox()
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
        Me.txtThreatCreate = New System.Windows.Forms.TextBox()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpTime = New System.Windows.Forms.DateTimePicker()
        Me.dgvThreatFilters = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CreationDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CreatedBy = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastModDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProjectFolderPath = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProjectID = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.CheckEndpoint = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.EndpointName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IPAddress = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OperatingSystem = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastContact = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.targetID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.splitJobFromTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitJobFromTemplate.Panel1.SuspendLayout()
        Me.splitJobFromTemplate.Panel2.SuspendLayout()
        Me.splitJobFromTemplate.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
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
        Me.grpRecurrence.SuspendLayout()
        Me.grpRecurrenceEnd.SuspendLayout()
        CType(Me.nmbRecurEndOccurences, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpRecurrenceStart.SuspendLayout()
        Me.panel_RecurWeekly.SuspendLayout()
        CType(Me.nmbRecurWeekly_Weeks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_recurDaily.SuspendLayout()
        CType(Me.nmb_RecurDays, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_RecurMinute.SuspendLayout()
        Me.panel_RecurHourly.SuspendLayout()
        Me.panel_RecurYearly.SuspendLayout()
        CType(Me.nmbRecurYear_Day, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_RecurMonthly.SuspendLayout()
        CType(Me.nmbRecurMonth_DayMonth, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nmbRecurMonth_TheMonth, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nmbRecurMonth_Day, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.flowThreatScanAllFilter.SuspendLayout()
        CType(Me.dgvThreatFilters, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.splitJobFromTemplate.Panel1.Controls.Add(Me.FlowLayoutPanel1)
        Me.splitJobFromTemplate.Panel1MinSize = 40
        '
        'splitJobFromTemplate.Panel2
        '
        Me.splitJobFromTemplate.Panel2.Controls.Add(Me.tabControlJobFromTemplate)
        Me.splitJobFromTemplate.Size = New System.Drawing.Size(1030, 633)
        Me.splitJobFromTemplate.SplitterDistance = 40
        Me.splitJobFromTemplate.TabIndex = 0
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoSize = True
        Me.FlowLayoutPanel1.Controls.Add(Me.btnJobFromTemplateCancel)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnJobFromTemplatePrevious)
        Me.FlowLayoutPanel1.Controls.Add(Me.lblJobFromTemplateMenuText)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnJobFromTemplateNext)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1030, 40)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'btnJobFromTemplateCancel
        '
        Me.btnJobFromTemplateCancel.Location = New System.Drawing.Point(3, 3)
        Me.btnJobFromTemplateCancel.Name = "btnJobFromTemplateCancel"
        Me.btnJobFromTemplateCancel.Size = New System.Drawing.Size(85, 35)
        Me.btnJobFromTemplateCancel.TabIndex = 4
        Me.btnJobFromTemplateCancel.Text = "Cancel"
        Me.btnJobFromTemplateCancel.UseVisualStyleBackColor = True
        '
        'btnJobFromTemplatePrevious
        '
        Me.btnJobFromTemplatePrevious.Location = New System.Drawing.Point(94, 3)
        Me.btnJobFromTemplatePrevious.Name = "btnJobFromTemplatePrevious"
        Me.btnJobFromTemplatePrevious.Size = New System.Drawing.Size(85, 35)
        Me.btnJobFromTemplatePrevious.TabIndex = 5
        Me.btnJobFromTemplatePrevious.Text = "Previous"
        Me.btnJobFromTemplatePrevious.UseVisualStyleBackColor = True
        '
        'lblJobFromTemplateMenuText
        '
        Me.lblJobFromTemplateMenuText.AutoSize = True
        Me.lblJobFromTemplateMenuText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJobFromTemplateMenuText.Location = New System.Drawing.Point(185, 0)
        Me.lblJobFromTemplateMenuText.Name = "lblJobFromTemplateMenuText"
        Me.lblJobFromTemplateMenuText.Size = New System.Drawing.Size(288, 25)
        Me.lblJobFromTemplateMenuText.TabIndex = 7
        Me.lblJobFromTemplateMenuText.Text = "Pick the project to store the data"
        '
        'btnJobFromTemplateNext
        '
        Me.btnJobFromTemplateNext.Location = New System.Drawing.Point(479, 3)
        Me.btnJobFromTemplateNext.Name = "btnJobFromTemplateNext"
        Me.btnJobFromTemplateNext.Size = New System.Drawing.Size(85, 35)
        Me.btnJobFromTemplateNext.TabIndex = 0
        Me.btnJobFromTemplateNext.Text = "Next"
        Me.btnJobFromTemplateNext.UseVisualStyleBackColor = True
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
        Me.tabControlJobFromTemplate.Size = New System.Drawing.Size(1030, 589)
        Me.tabControlJobFromTemplate.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight
        Me.tabControlJobFromTemplate.TabIndex = 0
        '
        'tabProject
        '
        Me.tabProject.Controls.Add(Me.splitProjects)
        Me.tabProject.Location = New System.Drawing.Point(4, 28)
        Me.tabProject.Name = "tabProject"
        Me.tabProject.Padding = New System.Windows.Forms.Padding(3)
        Me.tabProject.Size = New System.Drawing.Size(1022, 557)
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
        Me.splitProjects.Size = New System.Drawing.Size(1016, 551)
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
        Me.dgvProjectList.Size = New System.Drawing.Size(1016, 507)
        Me.dgvProjectList.TabIndex = 0
        '
        'tabTargets
        '
        Me.tabTargets.Controls.Add(Me.splitTargetsSelect)
        Me.tabTargets.Location = New System.Drawing.Point(4, 28)
        Me.tabTargets.Name = "tabTargets"
        Me.tabTargets.Padding = New System.Windows.Forms.Padding(3)
        Me.tabTargets.Size = New System.Drawing.Size(1022, 557)
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
        Me.splitTargetsSelect.Size = New System.Drawing.Size(1016, 551)
        Me.splitTargetsSelect.SplitterDistance = 175
        Me.splitTargetsSelect.TabIndex = 0
        '
        'treeGroups
        '
        Me.treeGroups.Dock = System.Windows.Forms.DockStyle.Fill
        Me.treeGroups.Location = New System.Drawing.Point(0, 0)
        Me.treeGroups.Name = "treeGroups"
        Me.treeGroups.Size = New System.Drawing.Size(175, 551)
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
        Me.splitTargetEndpoints.Size = New System.Drawing.Size(837, 551)
        Me.splitTargetEndpoints.SplitterDistance = 40
        Me.splitTargetEndpoints.TabIndex = 2
        '
        'txtSearchEndpoint
        '
        Me.txtSearchEndpoint.AcceptsReturn = True
        Me.txtSearchEndpoint.Location = New System.Drawing.Point(10, 9)
        Me.txtSearchEndpoint.Name = "txtSearchEndpoint"
        Me.txtSearchEndpoint.Size = New System.Drawing.Size(209, 22)
        Me.txtSearchEndpoint.TabIndex = 0
        Me.txtSearchEndpoint.Text = "Search"
        '
        'dgvTargetEndpoints
        '
        Me.dgvTargetEndpoints.AllowUserToAddRows = False
        Me.dgvTargetEndpoints.AllowUserToDeleteRows = False
        Me.dgvTargetEndpoints.AllowUserToResizeRows = False
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
        Me.dgvTargetEndpoints.Size = New System.Drawing.Size(837, 507)
        Me.dgvTargetEndpoints.TabIndex = 0
        '
        'tabSchedule
        '
        Me.tabSchedule.Controls.Add(Me.flowSchedule)
        Me.tabSchedule.Location = New System.Drawing.Point(4, 28)
        Me.tabSchedule.Name = "tabSchedule"
        Me.tabSchedule.Size = New System.Drawing.Size(1022, 557)
        Me.tabSchedule.TabIndex = 2
        Me.tabSchedule.Text = "Schedule"
        Me.tabSchedule.UseVisualStyleBackColor = True
        '
        'flowSchedule
        '
        Me.flowSchedule.Controls.Add(Me.grpScheduleOptions)
        Me.flowSchedule.Controls.Add(Me.grpSchedule_StartDate)
        Me.flowSchedule.Controls.Add(Me.grpRecurrence)
        Me.flowSchedule.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flowSchedule.Location = New System.Drawing.Point(0, 0)
        Me.flowSchedule.Name = "flowSchedule"
        Me.flowSchedule.Size = New System.Drawing.Size(1022, 557)
        Me.flowSchedule.TabIndex = 0
        '
        'grpScheduleOptions
        '
        Me.grpScheduleOptions.AutoSize = True
        Me.grpScheduleOptions.Controls.Add(Me.rdoSchedule_Schedule)
        Me.grpScheduleOptions.Controls.Add(Me.rdoSchedule_Immediate)
        Me.grpScheduleOptions.Location = New System.Drawing.Point(3, 3)
        Me.grpScheduleOptions.Name = "grpScheduleOptions"
        Me.grpScheduleOptions.Size = New System.Drawing.Size(359, 72)
        Me.grpScheduleOptions.TabIndex = 0
        Me.grpScheduleOptions.TabStop = False
        Me.grpScheduleOptions.Text = "Scheduling Options:"
        '
        'rdoSchedule_Schedule
        '
        Me.rdoSchedule_Schedule.AutoSize = True
        Me.rdoSchedule_Schedule.Location = New System.Drawing.Point(192, 30)
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
        Me.rdoSchedule_Immediate.Location = New System.Drawing.Point(13, 30)
        Me.rdoSchedule_Immediate.Name = "rdoSchedule_Immediate"
        Me.rdoSchedule_Immediate.Size = New System.Drawing.Size(158, 21)
        Me.rdoSchedule_Immediate.TabIndex = 0
        Me.rdoSchedule_Immediate.TabStop = True
        Me.rdoSchedule_Immediate.Text = "Immediate Execution"
        Me.rdoSchedule_Immediate.UseVisualStyleBackColor = True
        '
        'grpSchedule_StartDate
        '
        Me.grpSchedule_StartDate.AutoSize = True
        Me.grpSchedule_StartDate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.grpSchedule_StartDate.Controls.Add(Me.dtpScheduleStart)
        Me.flowSchedule.SetFlowBreak(Me.grpSchedule_StartDate, True)
        Me.grpSchedule_StartDate.Location = New System.Drawing.Point(368, 3)
        Me.grpSchedule_StartDate.Name = "grpSchedule_StartDate"
        Me.grpSchedule_StartDate.Size = New System.Drawing.Size(227, 73)
        Me.grpSchedule_StartDate.TabIndex = 1
        Me.grpSchedule_StartDate.TabStop = False
        Me.grpSchedule_StartDate.Text = "Start Date and Time"
        Me.grpSchedule_StartDate.Visible = False
        '
        'dtpScheduleStart
        '
        Me.dtpScheduleStart.CustomFormat = "MM/dd/yyy HH:mm:ss"
        Me.dtpScheduleStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpScheduleStart.Location = New System.Drawing.Point(6, 30)
        Me.dtpScheduleStart.Name = "dtpScheduleStart"
        Me.dtpScheduleStart.Size = New System.Drawing.Size(215, 22)
        Me.dtpScheduleStart.TabIndex = 0
        '
        'grpRecurrence
        '
        Me.grpRecurrence.AutoSize = True
        Me.grpRecurrence.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.grpRecurrence.Controls.Add(Me.grpRecurrenceEnd)
        Me.grpRecurrence.Controls.Add(Me.grpRecurrenceStart)
        Me.grpRecurrence.Controls.Add(Me.chkIncrementalCollection)
        Me.grpRecurrence.Controls.Add(Me.chkEnableRecurrence)
        Me.grpRecurrence.Location = New System.Drawing.Point(3, 82)
        Me.grpRecurrence.Name = "grpRecurrence"
        Me.grpRecurrence.Size = New System.Drawing.Size(622, 400)
        Me.grpRecurrence.TabIndex = 2
        Me.grpRecurrence.TabStop = False
        Me.grpRecurrence.Text = "Recurrence:"
        Me.grpRecurrence.Visible = False
        '
        'grpRecurrenceEnd
        '
        Me.grpRecurrenceEnd.AutoSize = True
        Me.grpRecurrenceEnd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.grpRecurrenceEnd.Controls.Add(Me.dtpRecurEndBy)
        Me.grpRecurrenceEnd.Controls.Add(Me.lblRecurEndOccurences)
        Me.grpRecurrenceEnd.Controls.Add(Me.nmbRecurEndOccurences)
        Me.grpRecurrenceEnd.Controls.Add(Me.rdoRecurEnd_EndBy)
        Me.grpRecurrenceEnd.Controls.Add(Me.rdoRecurEnd_After)
        Me.grpRecurrenceEnd.Controls.Add(Me.rdoRecurEnd_NoEnd)
        Me.grpRecurrenceEnd.Location = New System.Drawing.Point(12, 251)
        Me.grpRecurrenceEnd.Name = "grpRecurrenceEnd"
        Me.grpRecurrenceEnd.Size = New System.Drawing.Size(340, 128)
        Me.grpRecurrenceEnd.TabIndex = 1
        Me.grpRecurrenceEnd.TabStop = False
        Me.grpRecurrenceEnd.Text = "End"
        Me.grpRecurrenceEnd.Visible = False
        '
        'dtpRecurEndBy
        '
        Me.dtpRecurEndBy.CustomFormat = "MM/dd/yyyy HH:mm:ss"
        Me.dtpRecurEndBy.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpRecurEndBy.Location = New System.Drawing.Point(128, 85)
        Me.dtpRecurEndBy.Name = "dtpRecurEndBy"
        Me.dtpRecurEndBy.Size = New System.Drawing.Size(206, 22)
        Me.dtpRecurEndBy.TabIndex = 5
        '
        'lblRecurEndOccurences
        '
        Me.lblRecurEndOccurences.AutoSize = True
        Me.lblRecurEndOccurences.Location = New System.Drawing.Point(237, 57)
        Me.lblRecurEndOccurences.Name = "lblRecurEndOccurences"
        Me.lblRecurEndOccurences.Size = New System.Drawing.Size(91, 17)
        Me.lblRecurEndOccurences.TabIndex = 4
        Me.lblRecurEndOccurences.Text = "occurence(s)"
        '
        'nmbRecurEndOccurences
        '
        Me.nmbRecurEndOccurences.AutoSize = True
        Me.nmbRecurEndOccurences.Location = New System.Drawing.Point(128, 55)
        Me.nmbRecurEndOccurences.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nmbRecurEndOccurences.Name = "nmbRecurEndOccurences"
        Me.nmbRecurEndOccurences.Size = New System.Drawing.Size(96, 22)
        Me.nmbRecurEndOccurences.TabIndex = 3
        Me.nmbRecurEndOccurences.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'rdoRecurEnd_EndBy
        '
        Me.rdoRecurEnd_EndBy.AutoSize = True
        Me.rdoRecurEnd_EndBy.Location = New System.Drawing.Point(16, 85)
        Me.rdoRecurEnd_EndBy.Name = "rdoRecurEnd_EndBy"
        Me.rdoRecurEnd_EndBy.Size = New System.Drawing.Size(73, 21)
        Me.rdoRecurEnd_EndBy.TabIndex = 2
        Me.rdoRecurEnd_EndBy.Text = "End by"
        Me.rdoRecurEnd_EndBy.UseVisualStyleBackColor = True
        '
        'rdoRecurEnd_After
        '
        Me.rdoRecurEnd_After.AutoSize = True
        Me.rdoRecurEnd_After.Checked = True
        Me.rdoRecurEnd_After.Location = New System.Drawing.Point(16, 58)
        Me.rdoRecurEnd_After.Name = "rdoRecurEnd_After"
        Me.rdoRecurEnd_After.Size = New System.Drawing.Size(87, 21)
        Me.rdoRecurEnd_After.TabIndex = 1
        Me.rdoRecurEnd_After.TabStop = True
        Me.rdoRecurEnd_After.Text = "End after"
        Me.rdoRecurEnd_After.UseVisualStyleBackColor = True
        '
        'rdoRecurEnd_NoEnd
        '
        Me.rdoRecurEnd_NoEnd.AutoSize = True
        Me.rdoRecurEnd_NoEnd.Location = New System.Drawing.Point(16, 31)
        Me.rdoRecurEnd_NoEnd.Name = "rdoRecurEnd_NoEnd"
        Me.rdoRecurEnd_NoEnd.Size = New System.Drawing.Size(107, 21)
        Me.rdoRecurEnd_NoEnd.TabIndex = 0
        Me.rdoRecurEnd_NoEnd.Text = "No end date"
        Me.rdoRecurEnd_NoEnd.UseVisualStyleBackColor = True
        '
        'grpRecurrenceStart
        '
        Me.grpRecurrenceStart.Controls.Add(Me.rdoRecurStart_Yearly)
        Me.grpRecurrenceStart.Controls.Add(Me.rdoRecurStart_Monthly)
        Me.grpRecurrenceStart.Controls.Add(Me.rdoRecurStart_Weekly)
        Me.grpRecurrenceStart.Controls.Add(Me.rdoRecurStart_Daily)
        Me.grpRecurrenceStart.Controls.Add(Me.rdoRecurStart_Hourly)
        Me.grpRecurrenceStart.Controls.Add(Me.rdoRecurStart_Minute)
        Me.grpRecurrenceStart.Controls.Add(Me.panel_RecurWeekly)
        Me.grpRecurrenceStart.Controls.Add(Me.panel_recurDaily)
        Me.grpRecurrenceStart.Controls.Add(Me.panel_RecurMinute)
        Me.grpRecurrenceStart.Controls.Add(Me.panel_RecurHourly)
        Me.grpRecurrenceStart.Controls.Add(Me.panel_RecurYearly)
        Me.grpRecurrenceStart.Controls.Add(Me.panel_RecurMonthly)
        Me.grpRecurrenceStart.Location = New System.Drawing.Point(12, 57)
        Me.grpRecurrenceStart.Name = "grpRecurrenceStart"
        Me.grpRecurrenceStart.Size = New System.Drawing.Size(604, 188)
        Me.grpRecurrenceStart.TabIndex = 2
        Me.grpRecurrenceStart.TabStop = False
        Me.grpRecurrenceStart.Text = "Start"
        Me.grpRecurrenceStart.Visible = False
        '
        'rdoRecurStart_Yearly
        '
        Me.rdoRecurStart_Yearly.AutoSize = True
        Me.rdoRecurStart_Yearly.Location = New System.Drawing.Point(6, 156)
        Me.rdoRecurStart_Yearly.Name = "rdoRecurStart_Yearly"
        Me.rdoRecurStart_Yearly.Size = New System.Drawing.Size(69, 21)
        Me.rdoRecurStart_Yearly.TabIndex = 8
        Me.rdoRecurStart_Yearly.Text = "Yearly"
        Me.rdoRecurStart_Yearly.UseVisualStyleBackColor = True
        '
        'rdoRecurStart_Monthly
        '
        Me.rdoRecurStart_Monthly.AutoSize = True
        Me.rdoRecurStart_Monthly.Location = New System.Drawing.Point(6, 129)
        Me.rdoRecurStart_Monthly.Name = "rdoRecurStart_Monthly"
        Me.rdoRecurStart_Monthly.Size = New System.Drawing.Size(78, 21)
        Me.rdoRecurStart_Monthly.TabIndex = 7
        Me.rdoRecurStart_Monthly.Text = "Monthly"
        Me.rdoRecurStart_Monthly.UseVisualStyleBackColor = True
        '
        'rdoRecurStart_Weekly
        '
        Me.rdoRecurStart_Weekly.AutoSize = True
        Me.rdoRecurStart_Weekly.Location = New System.Drawing.Point(6, 102)
        Me.rdoRecurStart_Weekly.Name = "rdoRecurStart_Weekly"
        Me.rdoRecurStart_Weekly.Size = New System.Drawing.Size(75, 21)
        Me.rdoRecurStart_Weekly.TabIndex = 6
        Me.rdoRecurStart_Weekly.Text = "Weekly"
        Me.rdoRecurStart_Weekly.UseVisualStyleBackColor = True
        '
        'rdoRecurStart_Daily
        '
        Me.rdoRecurStart_Daily.AutoSize = True
        Me.rdoRecurStart_Daily.Location = New System.Drawing.Point(7, 75)
        Me.rdoRecurStart_Daily.Name = "rdoRecurStart_Daily"
        Me.rdoRecurStart_Daily.Size = New System.Drawing.Size(60, 21)
        Me.rdoRecurStart_Daily.TabIndex = 5
        Me.rdoRecurStart_Daily.Text = "Daily"
        Me.rdoRecurStart_Daily.UseVisualStyleBackColor = True
        '
        'rdoRecurStart_Hourly
        '
        Me.rdoRecurStart_Hourly.AutoSize = True
        Me.rdoRecurStart_Hourly.Checked = True
        Me.rdoRecurStart_Hourly.Location = New System.Drawing.Point(7, 48)
        Me.rdoRecurStart_Hourly.Name = "rdoRecurStart_Hourly"
        Me.rdoRecurStart_Hourly.Size = New System.Drawing.Size(70, 21)
        Me.rdoRecurStart_Hourly.TabIndex = 4
        Me.rdoRecurStart_Hourly.TabStop = True
        Me.rdoRecurStart_Hourly.Text = "Hourly"
        Me.rdoRecurStart_Hourly.UseVisualStyleBackColor = True
        '
        'rdoRecurStart_Minute
        '
        Me.rdoRecurStart_Minute.AutoSize = True
        Me.rdoRecurStart_Minute.Location = New System.Drawing.Point(7, 21)
        Me.rdoRecurStart_Minute.Name = "rdoRecurStart_Minute"
        Me.rdoRecurStart_Minute.Size = New System.Drawing.Size(71, 21)
        Me.rdoRecurStart_Minute.TabIndex = 3
        Me.rdoRecurStart_Minute.Text = "Minute"
        Me.rdoRecurStart_Minute.UseVisualStyleBackColor = True
        '
        'panel_RecurWeekly
        '
        Me.panel_RecurWeekly.Controls.Add(Me.chkRecurWeekly_Saturday)
        Me.panel_RecurWeekly.Controls.Add(Me.chkRecurWeekly_Friday)
        Me.panel_RecurWeekly.Controls.Add(Me.chkRecurWeekly_Thursday)
        Me.panel_RecurWeekly.Controls.Add(Me.chkRecurWeekly_Wednesday)
        Me.panel_RecurWeekly.Controls.Add(Me.chkRecurWeekly_Tuesday)
        Me.panel_RecurWeekly.Controls.Add(Me.chkRecurWeekly_Monday)
        Me.panel_RecurWeekly.Controls.Add(Me.chkRecurWeekly_Sunday)
        Me.panel_RecurWeekly.Controls.Add(Me.nmbRecurWeekly_Weeks)
        Me.panel_RecurWeekly.Controls.Add(Me.Label12)
        Me.panel_RecurWeekly.Controls.Add(Me.Label13)
        Me.panel_RecurWeekly.Location = New System.Drawing.Point(99, 13)
        Me.panel_RecurWeekly.Name = "panel_RecurWeekly"
        Me.panel_RecurWeekly.Size = New System.Drawing.Size(495, 161)
        Me.panel_RecurWeekly.TabIndex = 0
        Me.panel_RecurWeekly.Visible = False
        '
        'chkRecurWeekly_Saturday
        '
        Me.chkRecurWeekly_Saturday.AutoSize = True
        Me.chkRecurWeekly_Saturday.Location = New System.Drawing.Point(265, 100)
        Me.chkRecurWeekly_Saturday.Name = "chkRecurWeekly_Saturday"
        Me.chkRecurWeekly_Saturday.Size = New System.Drawing.Size(87, 21)
        Me.chkRecurWeekly_Saturday.TabIndex = 10
        Me.chkRecurWeekly_Saturday.Text = "Saturday"
        Me.chkRecurWeekly_Saturday.UseVisualStyleBackColor = True
        '
        'chkRecurWeekly_Friday
        '
        Me.chkRecurWeekly_Friday.AutoSize = True
        Me.chkRecurWeekly_Friday.Location = New System.Drawing.Point(190, 101)
        Me.chkRecurWeekly_Friday.Name = "chkRecurWeekly_Friday"
        Me.chkRecurWeekly_Friday.Size = New System.Drawing.Size(69, 21)
        Me.chkRecurWeekly_Friday.TabIndex = 9
        Me.chkRecurWeekly_Friday.Text = "Friday"
        Me.chkRecurWeekly_Friday.UseVisualStyleBackColor = True
        '
        'chkRecurWeekly_Thursday
        '
        Me.chkRecurWeekly_Thursday.AutoSize = True
        Me.chkRecurWeekly_Thursday.Location = New System.Drawing.Point(94, 101)
        Me.chkRecurWeekly_Thursday.Name = "chkRecurWeekly_Thursday"
        Me.chkRecurWeekly_Thursday.Size = New System.Drawing.Size(90, 21)
        Me.chkRecurWeekly_Thursday.TabIndex = 8
        Me.chkRecurWeekly_Thursday.Text = "Thursday"
        Me.chkRecurWeekly_Thursday.UseVisualStyleBackColor = True
        '
        'chkRecurWeekly_Wednesday
        '
        Me.chkRecurWeekly_Wednesday.AutoSize = True
        Me.chkRecurWeekly_Wednesday.Location = New System.Drawing.Point(310, 71)
        Me.chkRecurWeekly_Wednesday.Name = "chkRecurWeekly_Wednesday"
        Me.chkRecurWeekly_Wednesday.Size = New System.Drawing.Size(105, 21)
        Me.chkRecurWeekly_Wednesday.TabIndex = 7
        Me.chkRecurWeekly_Wednesday.Text = "Wednesday"
        Me.chkRecurWeekly_Wednesday.UseVisualStyleBackColor = True
        '
        'chkRecurWeekly_Tuesday
        '
        Me.chkRecurWeekly_Tuesday.AutoSize = True
        Me.chkRecurWeekly_Tuesday.Location = New System.Drawing.Point(219, 71)
        Me.chkRecurWeekly_Tuesday.Name = "chkRecurWeekly_Tuesday"
        Me.chkRecurWeekly_Tuesday.Size = New System.Drawing.Size(85, 21)
        Me.chkRecurWeekly_Tuesday.TabIndex = 6
        Me.chkRecurWeekly_Tuesday.Text = "Tuesday"
        Me.chkRecurWeekly_Tuesday.UseVisualStyleBackColor = True
        '
        'chkRecurWeekly_Monday
        '
        Me.chkRecurWeekly_Monday.AutoSize = True
        Me.chkRecurWeekly_Monday.Location = New System.Drawing.Point(133, 71)
        Me.chkRecurWeekly_Monday.Name = "chkRecurWeekly_Monday"
        Me.chkRecurWeekly_Monday.Size = New System.Drawing.Size(80, 21)
        Me.chkRecurWeekly_Monday.TabIndex = 5
        Me.chkRecurWeekly_Monday.Text = "Monday"
        Me.chkRecurWeekly_Monday.UseVisualStyleBackColor = True
        '
        'chkRecurWeekly_Sunday
        '
        Me.chkRecurWeekly_Sunday.AutoSize = True
        Me.chkRecurWeekly_Sunday.Location = New System.Drawing.Point(42, 71)
        Me.chkRecurWeekly_Sunday.Name = "chkRecurWeekly_Sunday"
        Me.chkRecurWeekly_Sunday.Size = New System.Drawing.Size(78, 21)
        Me.chkRecurWeekly_Sunday.TabIndex = 4
        Me.chkRecurWeekly_Sunday.Text = "Sunday"
        Me.chkRecurWeekly_Sunday.UseVisualStyleBackColor = True
        '
        'nmbRecurWeekly_Weeks
        '
        Me.nmbRecurWeekly_Weeks.Location = New System.Drawing.Point(135, 32)
        Me.nmbRecurWeekly_Weeks.Maximum = New Decimal(New Integer() {365, 0, 0, 0})
        Me.nmbRecurWeekly_Weeks.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nmbRecurWeekly_Weeks.Name = "nmbRecurWeekly_Weeks"
        Me.nmbRecurWeekly_Weeks.Size = New System.Drawing.Size(92, 22)
        Me.nmbRecurWeekly_Weeks.TabIndex = 3
        Me.nmbRecurWeekly_Weeks.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(243, 34)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(85, 17)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "Week(s) on:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(42, 32)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(85, 17)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Recur every"
        '
        'panel_recurDaily
        '
        Me.panel_recurDaily.Controls.Add(Me.nmb_RecurDays)
        Me.panel_recurDaily.Controls.Add(Me.Label10)
        Me.panel_recurDaily.Controls.Add(Me.Label11)
        Me.panel_recurDaily.Location = New System.Drawing.Point(96, 15)
        Me.panel_recurDaily.Name = "panel_recurDaily"
        Me.panel_recurDaily.Size = New System.Drawing.Size(495, 161)
        Me.panel_recurDaily.TabIndex = 10
        Me.panel_recurDaily.Visible = False
        '
        'nmb_RecurDays
        '
        Me.nmb_RecurDays.Location = New System.Drawing.Point(92, 32)
        Me.nmb_RecurDays.Maximum = New Decimal(New Integer() {365, 0, 0, 0})
        Me.nmb_RecurDays.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nmb_RecurDays.Name = "nmb_RecurDays"
        Me.nmb_RecurDays.Size = New System.Drawing.Size(92, 22)
        Me.nmb_RecurDays.TabIndex = 3
        Me.nmb_RecurDays.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(190, 34)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(50, 17)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Day(s)"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(42, 32)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(44, 17)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Every"
        '
        'panel_RecurMinute
        '
        Me.panel_RecurMinute.Controls.Add(Me.Label7)
        Me.panel_RecurMinute.Controls.Add(Me.cmb_RecurMinutes)
        Me.panel_RecurMinute.Controls.Add(Me.Label6)
        Me.panel_RecurMinute.Location = New System.Drawing.Point(96, 18)
        Me.panel_RecurMinute.Name = "panel_RecurMinute"
        Me.panel_RecurMinute.Size = New System.Drawing.Size(495, 161)
        Me.panel_RecurMinute.TabIndex = 9
        Me.panel_RecurMinute.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(190, 34)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 17)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Minute(s)"
        '
        'cmb_RecurMinutes
        '
        Me.cmb_RecurMinutes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_RecurMinutes.FormattingEnabled = True
        Me.cmb_RecurMinutes.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "10", "12", "15", "20", "30"})
        Me.cmb_RecurMinutes.Location = New System.Drawing.Point(92, 30)
        Me.cmb_RecurMinutes.Name = "cmb_RecurMinutes"
        Me.cmb_RecurMinutes.Size = New System.Drawing.Size(92, 24)
        Me.cmb_RecurMinutes.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(42, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 17)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Every"
        '
        'panel_RecurHourly
        '
        Me.panel_RecurHourly.Controls.Add(Me.Label8)
        Me.panel_RecurHourly.Controls.Add(Me.cmb_RecurHours)
        Me.panel_RecurHourly.Controls.Add(Me.Label9)
        Me.panel_RecurHourly.Location = New System.Drawing.Point(96, 16)
        Me.panel_RecurHourly.Name = "panel_RecurHourly"
        Me.panel_RecurHourly.Size = New System.Drawing.Size(495, 161)
        Me.panel_RecurHourly.TabIndex = 10
        Me.panel_RecurHourly.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(190, 34)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 17)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Hour(s)"
        '
        'cmb_RecurHours
        '
        Me.cmb_RecurHours.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_RecurHours.FormattingEnabled = True
        Me.cmb_RecurHours.Items.AddRange(New Object() {"1", "2", "3", "4", "6", "8", "12"})
        Me.cmb_RecurHours.Location = New System.Drawing.Point(92, 30)
        Me.cmb_RecurHours.Name = "cmb_RecurHours"
        Me.cmb_RecurHours.Size = New System.Drawing.Size(92, 24)
        Me.cmb_RecurHours.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(42, 32)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 17)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Every"
        '
        'panel_RecurYearly
        '
        Me.panel_RecurYearly.Controls.Add(Me.Label16)
        Me.panel_RecurYearly.Controls.Add(Me.cmbRecurYear_TheSelectDay)
        Me.panel_RecurYearly.Controls.Add(Me.cmbRecurYear_TheFirstDay)
        Me.panel_RecurYearly.Controls.Add(Me.cmbRecurYear_TheMonth)
        Me.panel_RecurYearly.Controls.Add(Me.cmbRecurYear_EveryMonth)
        Me.panel_RecurYearly.Controls.Add(Me.nmbRecurYear_Day)
        Me.panel_RecurYearly.Controls.Add(Me.rdoRecurYear_The)
        Me.panel_RecurYearly.Controls.Add(Me.rdoRecurYear_Every)
        Me.panel_RecurYearly.Location = New System.Drawing.Point(96, 12)
        Me.panel_RecurYearly.Name = "panel_RecurYearly"
        Me.panel_RecurYearly.Size = New System.Drawing.Size(495, 161)
        Me.panel_RecurYearly.TabIndex = 13
        Me.panel_RecurYearly.Visible = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(300, 92)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(59, 17)
        Me.Label16.TabIndex = 7
        Me.Label16.Text = "of every"
        '
        'cmbRecurYear_TheSelectDay
        '
        Me.cmbRecurYear_TheSelectDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRecurYear_TheSelectDay.FormattingEnabled = True
        Me.cmbRecurYear_TheSelectDay.Items.AddRange(New Object() {"Day", "Weekday", "Weekend", "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"})
        Me.cmbRecurYear_TheSelectDay.Location = New System.Drawing.Point(196, 89)
        Me.cmbRecurYear_TheSelectDay.Name = "cmbRecurYear_TheSelectDay"
        Me.cmbRecurYear_TheSelectDay.Size = New System.Drawing.Size(103, 24)
        Me.cmbRecurYear_TheSelectDay.TabIndex = 6
        '
        'cmbRecurYear_TheFirstDay
        '
        Me.cmbRecurYear_TheFirstDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRecurYear_TheFirstDay.FormattingEnabled = True
        Me.cmbRecurYear_TheFirstDay.Items.AddRange(New Object() {"First", "Second", "Third", "Fourth"})
        Me.cmbRecurYear_TheFirstDay.Location = New System.Drawing.Point(84, 89)
        Me.cmbRecurYear_TheFirstDay.Name = "cmbRecurYear_TheFirstDay"
        Me.cmbRecurYear_TheFirstDay.Size = New System.Drawing.Size(103, 24)
        Me.cmbRecurYear_TheFirstDay.TabIndex = 5
        '
        'cmbRecurYear_TheMonth
        '
        Me.cmbRecurYear_TheMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRecurYear_TheMonth.FormattingEnabled = True
        Me.cmbRecurYear_TheMonth.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.cmbRecurYear_TheMonth.Location = New System.Drawing.Point(363, 89)
        Me.cmbRecurYear_TheMonth.Name = "cmbRecurYear_TheMonth"
        Me.cmbRecurYear_TheMonth.Size = New System.Drawing.Size(121, 24)
        Me.cmbRecurYear_TheMonth.TabIndex = 4
        '
        'cmbRecurYear_EveryMonth
        '
        Me.cmbRecurYear_EveryMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRecurYear_EveryMonth.FormattingEnabled = True
        Me.cmbRecurYear_EveryMonth.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.cmbRecurYear_EveryMonth.Location = New System.Drawing.Point(173, 30)
        Me.cmbRecurYear_EveryMonth.Name = "cmbRecurYear_EveryMonth"
        Me.cmbRecurYear_EveryMonth.Size = New System.Drawing.Size(121, 24)
        Me.cmbRecurYear_EveryMonth.TabIndex = 3
        '
        'nmbRecurYear_Day
        '
        Me.nmbRecurYear_Day.Location = New System.Drawing.Point(97, 31)
        Me.nmbRecurYear_Day.Maximum = New Decimal(New Integer() {31, 0, 0, 0})
        Me.nmbRecurYear_Day.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nmbRecurYear_Day.Name = "nmbRecurYear_Day"
        Me.nmbRecurYear_Day.Size = New System.Drawing.Size(70, 22)
        Me.nmbRecurYear_Day.TabIndex = 2
        Me.nmbRecurYear_Day.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'rdoRecurYear_The
        '
        Me.rdoRecurYear_The.AutoSize = True
        Me.rdoRecurYear_The.Location = New System.Drawing.Point(24, 90)
        Me.rdoRecurYear_The.Name = "rdoRecurYear_The"
        Me.rdoRecurYear_The.Size = New System.Drawing.Size(54, 21)
        Me.rdoRecurYear_The.TabIndex = 1
        Me.rdoRecurYear_The.Text = "The"
        Me.rdoRecurYear_The.UseVisualStyleBackColor = True
        '
        'rdoRecurYear_Every
        '
        Me.rdoRecurYear_Every.AutoSize = True
        Me.rdoRecurYear_Every.Checked = True
        Me.rdoRecurYear_Every.Location = New System.Drawing.Point(26, 29)
        Me.rdoRecurYear_Every.Name = "rdoRecurYear_Every"
        Me.rdoRecurYear_Every.Size = New System.Drawing.Size(65, 21)
        Me.rdoRecurYear_Every.TabIndex = 0
        Me.rdoRecurYear_Every.TabStop = True
        Me.rdoRecurYear_Every.Text = "Every"
        Me.rdoRecurYear_Every.UseVisualStyleBackColor = True
        '
        'panel_RecurMonthly
        '
        Me.panel_RecurMonthly.Controls.Add(Me.Label18)
        Me.panel_RecurMonthly.Controls.Add(Me.nmbRecurMonth_DayMonth)
        Me.panel_RecurMonthly.Controls.Add(Me.Label17)
        Me.panel_RecurMonthly.Controls.Add(Me.Label15)
        Me.panel_RecurMonthly.Controls.Add(Me.nmbRecurMonth_TheMonth)
        Me.panel_RecurMonthly.Controls.Add(Me.Label14)
        Me.panel_RecurMonthly.Controls.Add(Me.cmbRecurMonth_TheSelectDay)
        Me.panel_RecurMonthly.Controls.Add(Me.cmbRecurMonth_TheFirstDay)
        Me.panel_RecurMonthly.Controls.Add(Me.nmbRecurMonth_Day)
        Me.panel_RecurMonthly.Controls.Add(Me.rdoRecurMonth_The)
        Me.panel_RecurMonthly.Controls.Add(Me.rdoRecurMonth_Day)
        Me.panel_RecurMonthly.Location = New System.Drawing.Point(96, 13)
        Me.panel_RecurMonthly.Name = "panel_RecurMonthly"
        Me.panel_RecurMonthly.Size = New System.Drawing.Size(495, 161)
        Me.panel_RecurMonthly.TabIndex = 12
        Me.panel_RecurMonthly.Visible = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(291, 41)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(64, 17)
        Me.Label18.TabIndex = 20
        Me.Label18.Text = "Month(s)"
        '
        'nmbRecurMonth_DayMonth
        '
        Me.nmbRecurMonth_DayMonth.Location = New System.Drawing.Point(220, 39)
        Me.nmbRecurMonth_DayMonth.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nmbRecurMonth_DayMonth.Name = "nmbRecurMonth_DayMonth"
        Me.nmbRecurMonth_DayMonth.Size = New System.Drawing.Size(65, 22)
        Me.nmbRecurMonth_DayMonth.TabIndex = 19
        Me.nmbRecurMonth_DayMonth.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(155, 41)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(59, 17)
        Me.Label17.TabIndex = 18
        Me.Label17.Text = "of every"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(429, 101)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(64, 17)
        Me.Label15.TabIndex = 17
        Me.Label15.Text = "Month(s)"
        '
        'nmbRecurMonth_TheMonth
        '
        Me.nmbRecurMonth_TheMonth.Location = New System.Drawing.Point(358, 100)
        Me.nmbRecurMonth_TheMonth.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nmbRecurMonth_TheMonth.Name = "nmbRecurMonth_TheMonth"
        Me.nmbRecurMonth_TheMonth.Size = New System.Drawing.Size(65, 22)
        Me.nmbRecurMonth_TheMonth.TabIndex = 16
        Me.nmbRecurMonth_TheMonth.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(293, 101)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(59, 17)
        Me.Label14.TabIndex = 15
        Me.Label14.Text = "of every"
        '
        'cmbRecurMonth_TheSelectDay
        '
        Me.cmbRecurMonth_TheSelectDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRecurMonth_TheSelectDay.FormattingEnabled = True
        Me.cmbRecurMonth_TheSelectDay.Items.AddRange(New Object() {"Day", "Weekday", "Weekend", "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"})
        Me.cmbRecurMonth_TheSelectDay.Location = New System.Drawing.Point(189, 98)
        Me.cmbRecurMonth_TheSelectDay.Name = "cmbRecurMonth_TheSelectDay"
        Me.cmbRecurMonth_TheSelectDay.Size = New System.Drawing.Size(103, 24)
        Me.cmbRecurMonth_TheSelectDay.TabIndex = 14
        '
        'cmbRecurMonth_TheFirstDay
        '
        Me.cmbRecurMonth_TheFirstDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRecurMonth_TheFirstDay.FormattingEnabled = True
        Me.cmbRecurMonth_TheFirstDay.Items.AddRange(New Object() {"First", "Second", "Third", "Fourth"})
        Me.cmbRecurMonth_TheFirstDay.Location = New System.Drawing.Point(77, 98)
        Me.cmbRecurMonth_TheFirstDay.Name = "cmbRecurMonth_TheFirstDay"
        Me.cmbRecurMonth_TheFirstDay.Size = New System.Drawing.Size(103, 24)
        Me.cmbRecurMonth_TheFirstDay.TabIndex = 13
        '
        'nmbRecurMonth_Day
        '
        Me.nmbRecurMonth_Day.Location = New System.Drawing.Point(79, 39)
        Me.nmbRecurMonth_Day.Maximum = New Decimal(New Integer() {31, 0, 0, 0})
        Me.nmbRecurMonth_Day.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nmbRecurMonth_Day.Name = "nmbRecurMonth_Day"
        Me.nmbRecurMonth_Day.Size = New System.Drawing.Size(70, 22)
        Me.nmbRecurMonth_Day.TabIndex = 10
        Me.nmbRecurMonth_Day.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'rdoRecurMonth_The
        '
        Me.rdoRecurMonth_The.AutoSize = True
        Me.rdoRecurMonth_The.Location = New System.Drawing.Point(17, 99)
        Me.rdoRecurMonth_The.Name = "rdoRecurMonth_The"
        Me.rdoRecurMonth_The.Size = New System.Drawing.Size(54, 21)
        Me.rdoRecurMonth_The.TabIndex = 9
        Me.rdoRecurMonth_The.Text = "The"
        Me.rdoRecurMonth_The.UseVisualStyleBackColor = True
        '
        'rdoRecurMonth_Day
        '
        Me.rdoRecurMonth_Day.AutoSize = True
        Me.rdoRecurMonth_Day.Checked = True
        Me.rdoRecurMonth_Day.Location = New System.Drawing.Point(19, 38)
        Me.rdoRecurMonth_Day.Name = "rdoRecurMonth_Day"
        Me.rdoRecurMonth_Day.Size = New System.Drawing.Size(54, 21)
        Me.rdoRecurMonth_Day.TabIndex = 8
        Me.rdoRecurMonth_Day.TabStop = True
        Me.rdoRecurMonth_Day.Text = "Day"
        Me.rdoRecurMonth_Day.UseVisualStyleBackColor = True
        '
        'chkIncrementalCollection
        '
        Me.chkIncrementalCollection.AutoSize = True
        Me.chkIncrementalCollection.Location = New System.Drawing.Point(175, 30)
        Me.chkIncrementalCollection.Name = "chkIncrementalCollection"
        Me.chkIncrementalCollection.Size = New System.Drawing.Size(168, 21)
        Me.chkIncrementalCollection.TabIndex = 1
        Me.chkIncrementalCollection.Text = "Incremental Collection"
        Me.chkIncrementalCollection.UseVisualStyleBackColor = True
        Me.chkIncrementalCollection.Visible = False
        '
        'chkEnableRecurrence
        '
        Me.chkEnableRecurrence.AutoSize = True
        Me.chkEnableRecurrence.Location = New System.Drawing.Point(6, 30)
        Me.chkEnableRecurrence.Name = "chkEnableRecurrence"
        Me.chkEnableRecurrence.Size = New System.Drawing.Size(152, 21)
        Me.chkEnableRecurrence.TabIndex = 0
        Me.chkEnableRecurrence.Text = "Enable Recurrence"
        Me.chkEnableRecurrence.UseVisualStyleBackColor = True
        '
        'tabThreatFilters
        '
        Me.tabThreatFilters.Controls.Add(Me.splitThreatFilters)
        Me.tabThreatFilters.Location = New System.Drawing.Point(4, 28)
        Me.tabThreatFilters.Name = "tabThreatFilters"
        Me.tabThreatFilters.Padding = New System.Windows.Forms.Padding(3)
        Me.tabThreatFilters.Size = New System.Drawing.Size(1022, 557)
        Me.tabThreatFilters.TabIndex = 3
        Me.tabThreatFilters.Text = "Threat Filters"
        Me.tabThreatFilters.UseVisualStyleBackColor = True
        '
        'splitThreatFilters
        '
        Me.splitThreatFilters.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitThreatFilters.IsSplitterFixed = True
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
        Me.splitThreatFilters.Size = New System.Drawing.Size(1016, 551)
        Me.splitThreatFilters.SplitterDistance = 447
        Me.splitThreatFilters.TabIndex = 2
        '
        'splitThreatFilterAdvanced
        '
        Me.splitThreatFilterAdvanced.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitThreatFilterAdvanced.IsSplitterFixed = True
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
        Me.splitThreatFilterAdvanced.Size = New System.Drawing.Size(1016, 447)
        Me.splitThreatFilterAdvanced.SplitterDistance = 40
        Me.splitThreatFilterAdvanced.TabIndex = 4
        '
        'btnThreatFiltersAdvanced
        '
        Me.btnThreatFiltersAdvanced.Location = New System.Drawing.Point(528, 5)
        Me.btnThreatFiltersAdvanced.Name = "btnThreatFiltersAdvanced"
        Me.btnThreatFiltersAdvanced.Size = New System.Drawing.Size(119, 28)
        Me.btnThreatFiltersAdvanced.TabIndex = 2
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
        Me.grpThreatSelection.TabIndex = 1
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
        Me.txtSearchThreatFilters.TabIndex = 0
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
        Me.flowThreatScanOptions.Size = New System.Drawing.Size(1016, 403)
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
        Me.grpThreatScanAdvanced.TabIndex = 0
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
        Me.flowThreatScanArchivesList.TabIndex = 1
        Me.flowThreatScanArchivesList.Visible = False
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
        Me.flowThreatScanAllFilter.TabIndex = 2
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
        'txtThreatCreate
        '
        Me.txtThreatCreate.Location = New System.Drawing.Point(148, 31)
        Me.txtThreatCreate.Name = "txtThreatCreate"
        Me.txtThreatCreate.ReadOnly = True
        Me.txtThreatCreate.Size = New System.Drawing.Size(180, 22)
        Me.txtThreatCreate.TabIndex = 10
        '
        'dtpDate
        '
        Me.dtpDate.CustomFormat = "MM/dd/yyyy"
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDate.Location = New System.Drawing.Point(334, 31)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(115, 22)
        Me.dtpDate.TabIndex = 9
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
        Me.dgvThreatFilters.Size = New System.Drawing.Size(1016, 100)
        Me.dgvThreatFilters.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn1.FillWeight = 20.0!
        Me.DataGridViewTextBoxColumn1.HeaderText = "Project Name"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 203
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 203
        '
        'CreationDate
        '
        Me.CreationDate.FillWeight = 15.0!
        Me.CreationDate.HeaderText = "Creation Date"
        Me.CreationDate.Name = "CreationDate"
        Me.CreationDate.ReadOnly = True
        '
        'CreatedBy
        '
        Me.CreatedBy.FillWeight = 15.0!
        Me.CreatedBy.HeaderText = "Created By"
        Me.CreatedBy.Name = "CreatedBy"
        Me.CreatedBy.ReadOnly = True
        '
        'LastModDate
        '
        Me.LastModDate.FillWeight = 15.0!
        Me.LastModDate.HeaderText = "Last Modified Date"
        Me.LastModDate.Name = "LastModDate"
        Me.LastModDate.ReadOnly = True
        '
        'ProjectFolderPath
        '
        Me.ProjectFolderPath.FillWeight = 15.0!
        Me.ProjectFolderPath.HeaderText = "Project Folder Path"
        Me.ProjectFolderPath.Name = "ProjectFolderPath"
        Me.ProjectFolderPath.ReadOnly = True
        '
        'ProjectID
        '
        Me.ProjectID.FillWeight = 5.0!
        Me.ProjectID.HeaderText = "Project ID"
        Me.ProjectID.Name = "ProjectID"
        Me.ProjectID.ReadOnly = True
        Me.ProjectID.Visible = False
        '
        'Selected
        '
        Me.Selected.FillWeight = 1.0!
        Me.Selected.HeaderText = "Select"
        Me.Selected.MinimumWidth = 32
        Me.Selected.Name = "Selected"
        '
        'FilterName
        '
        Me.FilterName.FillWeight = 23.35574!
        Me.FilterName.HeaderText = "Name"
        Me.FilterName.Name = "FilterName"
        Me.FilterName.ReadOnly = True
        '
        'View
        '
        Me.View.FillWeight = 0.7785247!
        Me.View.HeaderText = "View"
        Me.View.MinimumWidth = 45
        Me.View.Name = "View"
        Me.View.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Description
        '
        Me.Description.FillWeight = 18.0!
        Me.Description.HeaderText = "Description"
        Me.Description.Name = "Description"
        Me.Description.ReadOnly = True
        '
        'Source
        '
        Me.Source.FillWeight = 7.785247!
        Me.Source.HeaderText = "Source"
        Me.Source.Name = "Source"
        Me.Source.ReadOnly = True
        '
        'AuthoredDate
        '
        Me.AuthoredDate.FillWeight = 7.785247!
        Me.AuthoredDate.HeaderText = "Authored Date"
        Me.AuthoredDate.Name = "AuthoredDate"
        Me.AuthoredDate.ReadOnly = True
        '
        'Author
        '
        Me.Author.FillWeight = 7.785247!
        Me.Author.HeaderText = "Authored By"
        Me.Author.Name = "Author"
        Me.Author.ReadOnly = True
        '
        'Type
        '
        Me.Type.FillWeight = 7.785247!
        Me.Type.HeaderText = "Type"
        Me.Type.Name = "Type"
        Me.Type.ReadOnly = True
        '
        'Category
        '
        Me.Category.FillWeight = 7.785247!
        Me.Category.HeaderText = "Category"
        Me.Category.Name = "Category"
        Me.Category.ReadOnly = True
        '
        'Group
        '
        Me.Group.FillWeight = 7.785247!
        Me.Group.HeaderText = "Group"
        Me.Group.Name = "Group"
        Me.Group.ReadOnly = True
        '
        'Tags
        '
        Me.Tags.FillWeight = 7.785247!
        Me.Tags.HeaderText = "Tags"
        Me.Tags.Name = "Tags"
        Me.Tags.ReadOnly = True
        '
        'FilterID
        '
        Me.FilterID.FillWeight = 10.0!
        Me.FilterID.HeaderText = "Filter ID"
        Me.FilterID.Name = "FilterID"
        Me.FilterID.Visible = False
        '
        'CheckEndpoint
        '
        Me.CheckEndpoint.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.CheckEndpoint.FillWeight = 1.0!
        Me.CheckEndpoint.HeaderText = ""
        Me.CheckEndpoint.MinimumWidth = 32
        Me.CheckEndpoint.Name = "CheckEndpoint"
        Me.CheckEndpoint.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CheckEndpoint.Width = 32
        '
        'EndpointName
        '
        Me.EndpointName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.EndpointName.FillWeight = 30.0!
        Me.EndpointName.HeaderText = "Endpoint Name"
        Me.EndpointName.MinimumWidth = 150
        Me.EndpointName.Name = "EndpointName"
        Me.EndpointName.ReadOnly = True
        Me.EndpointName.Width = 150
        '
        'IPAddress
        '
        Me.IPAddress.FillWeight = 10.0!
        Me.IPAddress.HeaderText = "IP Address"
        Me.IPAddress.MinimumWidth = 75
        Me.IPAddress.Name = "IPAddress"
        Me.IPAddress.ReadOnly = True
        '
        'OperatingSystem
        '
        Me.OperatingSystem.FillWeight = 20.0!
        Me.OperatingSystem.HeaderText = "Operating System"
        Me.OperatingSystem.MinimumWidth = 75
        Me.OperatingSystem.Name = "OperatingSystem"
        Me.OperatingSystem.ReadOnly = True
        '
        'LastContact
        '
        Me.LastContact.FillWeight = 10.0!
        Me.LastContact.HeaderText = "Last Contact"
        Me.LastContact.MinimumWidth = 75
        Me.LastContact.Name = "LastContact"
        Me.LastContact.ReadOnly = True
        '
        'targetID
        '
        Me.targetID.FillWeight = 1.0!
        Me.targetID.HeaderText = "TargetID"
        Me.targetID.Name = "targetID"
        Me.targetID.ReadOnly = True
        Me.targetID.Visible = False
        '
        'Form_JobFromTemplate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1030, 633)
        Me.Controls.Add(Me.splitJobFromTemplate)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form_JobFromTemplate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Job From Template"
        Me.splitJobFromTemplate.Panel1.ResumeLayout(False)
        Me.splitJobFromTemplate.Panel1.PerformLayout()
        Me.splitJobFromTemplate.Panel2.ResumeLayout(False)
        CType(Me.splitJobFromTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitJobFromTemplate.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
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
        Me.grpRecurrence.ResumeLayout(False)
        Me.grpRecurrence.PerformLayout()
        Me.grpRecurrenceEnd.ResumeLayout(False)
        Me.grpRecurrenceEnd.PerformLayout()
        CType(Me.nmbRecurEndOccurences, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpRecurrenceStart.ResumeLayout(False)
        Me.grpRecurrenceStart.PerformLayout()
        Me.panel_RecurWeekly.ResumeLayout(False)
        Me.panel_RecurWeekly.PerformLayout()
        CType(Me.nmbRecurWeekly_Weeks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_recurDaily.ResumeLayout(False)
        Me.panel_recurDaily.PerformLayout()
        CType(Me.nmb_RecurDays, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_RecurMinute.ResumeLayout(False)
        Me.panel_RecurMinute.PerformLayout()
        Me.panel_RecurHourly.ResumeLayout(False)
        Me.panel_RecurHourly.PerformLayout()
        Me.panel_RecurYearly.ResumeLayout(False)
        Me.panel_RecurYearly.PerformLayout()
        CType(Me.nmbRecurYear_Day, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_RecurMonthly.ResumeLayout(False)
        Me.panel_RecurMonthly.PerformLayout()
        CType(Me.nmbRecurMonth_DayMonth, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nmbRecurMonth_TheMonth, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nmbRecurMonth_Day, System.ComponentModel.ISupportInitialize).EndInit()
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
        Me.flowThreatScanAllFilter.ResumeLayout(False)
        Me.flowThreatScanAllFilter.PerformLayout()
        CType(Me.dgvThreatFilters, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents splitJobFromTemplate As System.Windows.Forms.SplitContainer
    Friend WithEvents tabControlJobFromTemplate As System.Windows.Forms.TabControl
    Friend WithEvents tabProject As System.Windows.Forms.TabPage
    Friend WithEvents tabTargets As System.Windows.Forms.TabPage
    Friend WithEvents tabSchedule As System.Windows.Forms.TabPage
    Friend WithEvents splitProjects As System.Windows.Forms.SplitContainer
    Friend WithEvents btnNewProject As System.Windows.Forms.Button
    Friend WithEvents txtSearchProject As System.Windows.Forms.TextBox
    Friend WithEvents dgvProjectList As System.Windows.Forms.DataGridView
    Friend WithEvents splitTargetsSelect As System.Windows.Forms.SplitContainer
    Friend WithEvents treeGroups As System.Windows.Forms.TreeView
    Friend WithEvents splitTargetEndpoints As System.Windows.Forms.SplitContainer
    Friend WithEvents txtSearchEndpoint As System.Windows.Forms.TextBox
    Friend WithEvents dgvTargetEndpoints As System.Windows.Forms.DataGridView
    Friend WithEvents flowSchedule As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents grpScheduleOptions As System.Windows.Forms.GroupBox
    Friend WithEvents rdoSchedule_Schedule As System.Windows.Forms.RadioButton
    Friend WithEvents rdoSchedule_Immediate As System.Windows.Forms.RadioButton
    Friend WithEvents tabThreatFilters As System.Windows.Forms.TabPage
    Friend WithEvents splitThreatFilters As System.Windows.Forms.SplitContainer
    Friend WithEvents dgvThreatFilters As System.Windows.Forms.DataGridView
    Friend WithEvents grpSchedule_StartDate As System.Windows.Forms.GroupBox
    Friend WithEvents dtpScheduleStart As System.Windows.Forms.DateTimePicker
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
    Friend WithEvents grpRecurrence As System.Windows.Forms.GroupBox
    Friend WithEvents chkEnableRecurrence As System.Windows.Forms.CheckBox
    Friend WithEvents chkIncrementalCollection As System.Windows.Forms.CheckBox
    Friend WithEvents grpRecurrenceEnd As System.Windows.Forms.GroupBox
    Friend WithEvents grpRecurrenceStart As System.Windows.Forms.GroupBox
    Friend WithEvents rdoRecurEnd_EndBy As System.Windows.Forms.RadioButton
    Friend WithEvents rdoRecurEnd_After As System.Windows.Forms.RadioButton
    Friend WithEvents rdoRecurEnd_NoEnd As System.Windows.Forms.RadioButton
    Friend WithEvents lblRecurEndOccurences As System.Windows.Forms.Label
    Friend WithEvents nmbRecurEndOccurences As System.Windows.Forms.NumericUpDown
    Friend WithEvents dtpRecurEndBy As System.Windows.Forms.DateTimePicker
    Friend WithEvents rdoRecurStart_Yearly As System.Windows.Forms.RadioButton
    Friend WithEvents rdoRecurStart_Monthly As System.Windows.Forms.RadioButton
    Friend WithEvents rdoRecurStart_Weekly As System.Windows.Forms.RadioButton
    Friend WithEvents rdoRecurStart_Daily As System.Windows.Forms.RadioButton
    Friend WithEvents rdoRecurStart_Hourly As System.Windows.Forms.RadioButton
    Friend WithEvents rdoRecurStart_Minute As System.Windows.Forms.RadioButton
    Friend WithEvents panel_RecurHourly As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmb_RecurHours As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents panel_RecurMinute As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmb_RecurMinutes As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents panel_recurDaily As System.Windows.Forms.Panel
    Friend WithEvents nmb_RecurDays As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents panel_RecurMonthly As System.Windows.Forms.Panel
    Friend WithEvents panel_RecurYearly As System.Windows.Forms.Panel
    Friend WithEvents panel_RecurWeekly As System.Windows.Forms.Panel
    Friend WithEvents nmbRecurWeekly_Weeks As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cmbRecurYear_EveryMonth As System.Windows.Forms.ComboBox
    Friend WithEvents nmbRecurYear_Day As System.Windows.Forms.NumericUpDown
    Friend WithEvents rdoRecurYear_The As System.Windows.Forms.RadioButton
    Friend WithEvents rdoRecurYear_Every As System.Windows.Forms.RadioButton
    Friend WithEvents cmbRecurYear_TheMonth As System.Windows.Forms.ComboBox
    Friend WithEvents cmbRecurYear_TheFirstDay As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents cmbRecurYear_TheSelectDay As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cmbRecurMonth_TheSelectDay As System.Windows.Forms.ComboBox
    Friend WithEvents cmbRecurMonth_TheFirstDay As System.Windows.Forms.ComboBox
    Friend WithEvents nmbRecurMonth_Day As System.Windows.Forms.NumericUpDown
    Friend WithEvents rdoRecurMonth_The As System.Windows.Forms.RadioButton
    Friend WithEvents rdoRecurMonth_Day As System.Windows.Forms.RadioButton
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents nmbRecurMonth_DayMonth As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents nmbRecurMonth_TheMonth As System.Windows.Forms.NumericUpDown
    Friend WithEvents chkRecurWeekly_Saturday As System.Windows.Forms.CheckBox
    Friend WithEvents chkRecurWeekly_Friday As System.Windows.Forms.CheckBox
    Friend WithEvents chkRecurWeekly_Thursday As System.Windows.Forms.CheckBox
    Friend WithEvents chkRecurWeekly_Wednesday As System.Windows.Forms.CheckBox
    Friend WithEvents chkRecurWeekly_Tuesday As System.Windows.Forms.CheckBox
    Friend WithEvents chkRecurWeekly_Monday As System.Windows.Forms.CheckBox
    Friend WithEvents chkRecurWeekly_Sunday As System.Windows.Forms.CheckBox
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnJobFromTemplateCancel As System.Windows.Forms.Button
    Friend WithEvents btnJobFromTemplatePrevious As System.Windows.Forms.Button
    Friend WithEvents lblJobFromTemplateMenuText As System.Windows.Forms.Label
    Friend WithEvents btnJobFromTemplateNext As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CreationDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CreatedBy As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastModDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProjectFolderPath As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProjectID As System.Windows.Forms.DataGridViewTextBoxColumn
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
    Friend WithEvents CheckEndpoint As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents EndpointName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IPAddress As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OperatingSystem As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastContact As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents targetID As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
