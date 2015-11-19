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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtcustomwebaddress = New System.Windows.Forms.TextBox()
        Me.rdocustom = New System.Windows.Forms.RadioButton()
        Me.rdor1 = New System.Windows.Forms.RadioButton()
        Me.rdoadgmap = New System.Windows.Forms.RadioButton()
        Me.grpOptDefSet = New System.Windows.Forms.GroupBox()
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
        Me.tabJobExecution = New System.Windows.Forms.TabPage()
        Me.lblJobStatus = New System.Windows.Forms.Label()
        Me.btnShowJSON = New System.Windows.Forms.Button()
        Me.btnLoadFromBox = New System.Windows.Forms.Button()
        Me.btnSaveAsBox = New System.Windows.Forms.Button()
        Me.tabFireEye = New System.Windows.Forms.TabPage()
        Me.lblFEStatus = New System.Windows.Forms.Label()
        Me.txtFELink = New System.Windows.Forms.TextBox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.cmbFEAlertType = New System.Windows.Forms.ComboBox()
        Me.txtFETarget = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.btn_FEEvent = New System.Windows.Forms.Button()
        Me.tabPANW = New System.Windows.Forms.TabPage()
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ofdBox = New System.Windows.Forms.OpenFileDialog()
        Me.sfdBox = New System.Windows.Forms.SaveFileDialog()
        Me.bgwork_xpslisten = New System.ComponentModel.BackgroundWorker()
        Me.bgwork_panwlisten = New System.ComponentModel.BackgroundWorker()
        Me.GroupBox4.SuspendLayout()
        Me.grpReqSet.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.grpOptDefSet.SuspendLayout()
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
        Me.btnExecute.Location = New System.Drawing.Point(543, 491)
        Me.btnExecute.Name = "btnExecute"
        Me.btnExecute.Size = New System.Drawing.Size(75, 23)
        Me.btnExecute.TabIndex = 0
        Me.btnExecute.Text = "Execute Job"
        Me.btnExecute.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Default Job Name:"
        '
        'txtDefaultJobName
        '
        Me.txtDefaultJobName.Location = New System.Drawing.Point(130, 19)
        Me.txtDefaultJobName.Name = "txtDefaultJobName"
        Me.txtDefaultJobName.Size = New System.Drawing.Size(235, 20)
        Me.txtDefaultJobName.TabIndex = 8
        '
        'txtDefaultProjectName
        '
        Me.txtDefaultProjectName.Location = New System.Drawing.Point(130, 45)
        Me.txtDefaultProjectName.Name = "txtDefaultProjectName"
        Me.txtDefaultProjectName.Size = New System.Drawing.Size(235, 20)
        Me.txtDefaultProjectName.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Default Project Name:"
        '
        'txtApiUser
        '
        Me.txtApiUser.Location = New System.Drawing.Point(131, 46)
        Me.txtApiUser.Name = "txtApiUser"
        Me.txtApiUser.Size = New System.Drawing.Size(234, 20)
        Me.txtApiUser.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "API Username*:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 75)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "API Password*:"
        '
        'txtAPIPass
        '
        Me.txtAPIPass.Location = New System.Drawing.Point(131, 72)
        Me.txtAPIPass.Name = "txtAPIPass"
        Me.txtAPIPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtAPIPass.Size = New System.Drawing.Size(235, 20)
        Me.txtAPIPass.TabIndex = 14
        '
        'txtServer
        '
        Me.txtServer.Location = New System.Drawing.Point(131, 20)
        Me.txtServer.Name = "txtServer"
        Me.txtServer.Size = New System.Drawing.Size(235, 20)
        Me.txtServer.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 23)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(122, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Web Server Hostname*:"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.grpReqSet)
        Me.GroupBox4.Controls.Add(Me.grpOptDefSet)
        Me.GroupBox4.Controls.Add(Me.txtStatusSettings)
        Me.GroupBox4.Controls.Add(Me.btnSaveSettings)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 7)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(616, 494)
        Me.GroupBox4.TabIndex = 19
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Settings"
        '
        'grpReqSet
        '
        Me.grpReqSet.Controls.Add(Me.GroupBox2)
        Me.grpReqSet.Controls.Add(Me.Label7)
        Me.grpReqSet.Controls.Add(Me.Label4)
        Me.grpReqSet.Controls.Add(Me.Label5)
        Me.grpReqSet.Controls.Add(Me.txtApiUser)
        Me.grpReqSet.Controls.Add(Me.txtServer)
        Me.grpReqSet.Controls.Add(Me.txtAPIPass)
        Me.grpReqSet.Location = New System.Drawing.Point(6, 19)
        Me.grpReqSet.Name = "grpReqSet"
        Me.grpReqSet.Size = New System.Drawing.Size(604, 100)
        Me.grpReqSet.TabIndex = 29
        Me.grpReqSet.TabStop = False
        Me.grpReqSet.Text = "Required Settings"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtcustomwebaddress)
        Me.GroupBox2.Controls.Add(Me.rdocustom)
        Me.GroupBox2.Controls.Add(Me.rdor1)
        Me.GroupBox2.Controls.Add(Me.rdoadgmap)
        Me.GroupBox2.Location = New System.Drawing.Point(420, 10)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(178, 90)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Website Address:"
        '
        'txtcustomwebaddress
        '
        Me.txtcustomwebaddress.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcustomwebaddress.Enabled = False
        Me.txtcustomwebaddress.Location = New System.Drawing.Point(23, 64)
        Me.txtcustomwebaddress.Name = "txtcustomwebaddress"
        Me.txtcustomwebaddress.Size = New System.Drawing.Size(149, 20)
        Me.txtcustomwebaddress.TabIndex = 21
        '
        'rdocustom
        '
        Me.rdocustom.AutoSize = True
        Me.rdocustom.Location = New System.Drawing.Point(6, 67)
        Me.rdocustom.Name = "rdocustom"
        Me.rdocustom.Size = New System.Drawing.Size(14, 13)
        Me.rdocustom.TabIndex = 20
        Me.rdocustom.TabStop = True
        Me.rdocustom.UseVisualStyleBackColor = True
        '
        'rdor1
        '
        Me.rdor1.AutoSize = True
        Me.rdor1.Location = New System.Drawing.Point(6, 43)
        Me.rdor1.Name = "rdor1"
        Me.rdor1.Size = New System.Drawing.Size(39, 17)
        Me.rdor1.TabIndex = 19
        Me.rdor1.TabStop = True
        Me.rdor1.Text = "R1"
        Me.rdor1.UseVisualStyleBackColor = True
        '
        'rdoadgmap
        '
        Me.rdoadgmap.AutoSize = True
        Me.rdoadgmap.Checked = True
        Me.rdoadgmap.Location = New System.Drawing.Point(6, 19)
        Me.rdoadgmap.Name = "rdoadgmap"
        Me.rdoadgmap.Size = New System.Drawing.Size(98, 17)
        Me.rdoadgmap.TabIndex = 18
        Me.rdoadgmap.TabStop = True
        Me.rdoadgmap.Text = "ADG.Map.Web"
        Me.rdoadgmap.UseVisualStyleBackColor = True
        '
        'grpOptDefSet
        '
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
        Me.grpOptDefSet.Location = New System.Drawing.Point(6, 125)
        Me.grpOptDefSet.Name = "grpOptDefSet"
        Me.grpOptDefSet.Size = New System.Drawing.Size(604, 150)
        Me.grpOptDefSet.TabIndex = 28
        Me.grpOptDefSet.TabStop = False
        Me.grpOptDefSet.Text = "Optional Default Settings"
        '
        'chkbypasscerts
        '
        Me.chkbypasscerts.AutoSize = True
        Me.chkbypasscerts.Location = New System.Drawing.Point(420, 19)
        Me.chkbypasscerts.Name = "chkbypasscerts"
        Me.chkbypasscerts.Size = New System.Drawing.Size(145, 17)
        Me.chkbypasscerts.TabIndex = 26
        Me.chkbypasscerts.Text = "ByPass Invalid Certificate"
        Me.chkbypasscerts.UseVisualStyleBackColor = True
        '
        'txtdefaultshare
        '
        Me.txtdefaultshare.Location = New System.Drawing.Point(130, 97)
        Me.txtdefaultshare.Name = "txtdefaultshare"
        Me.txtdefaultshare.Size = New System.Drawing.Size(235, 20)
        Me.txtdefaultshare.TabIndex = 24
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(6, 100)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(106, 13)
        Me.Label29.TabIndex = 25
        Me.Label29.Text = "Default Share Name:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(7, 126)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(122, 13)
        Me.Label14.TabIndex = 19
        Me.Label14.Text = "Default Template Name:"
        '
        'txtdefaultcomputer
        '
        Me.txtdefaultcomputer.Location = New System.Drawing.Point(130, 71)
        Me.txtdefaultcomputer.Name = "txtdefaultcomputer"
        Me.txtdefaultcomputer.Size = New System.Drawing.Size(235, 20)
        Me.txtdefaultcomputer.TabIndex = 22
        '
        'txtDefaultTemplateName
        '
        Me.txtDefaultTemplateName.FormattingEnabled = True
        Me.txtDefaultTemplateName.Items.AddRange(New Object() {"coll-evtx", "Drop Process by PID", "ETM Relative Time Query", "EXE-Metadata-Cerb", "Lockdown NIC", "LockdownEnableNIC", "Memory Acquisition", "Memory Analysis", "Registry-Autostart", "Registry-Full", "Remediate-Name", "Remediate-PID", "Small-exes-Cerb", "Software Inventory", "Vol-Deep", "Vol-Deep-Cerb", "Vol-Hidden-Cerb", "Vol-Hidden-Injected", "Vol-Quick", "Vol-Quick-Cerb", "Vol-Quick-Sched"})
        Me.txtDefaultTemplateName.Location = New System.Drawing.Point(130, 123)
        Me.txtDefaultTemplateName.Name = "txtDefaultTemplateName"
        Me.txtDefaultTemplateName.Size = New System.Drawing.Size(235, 21)
        Me.txtDefaultTemplateName.TabIndex = 20
        Me.txtDefaultTemplateName.Text = "coll-evtx"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(6, 74)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(123, 13)
        Me.Label28.TabIndex = 23
        Me.Label28.Text = "Default Computer Name:"
        '
        'txtStatusSettings
        '
        Me.txtStatusSettings.BackColor = System.Drawing.SystemColors.Control
        Me.txtStatusSettings.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtStatusSettings.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStatusSettings.Location = New System.Drawing.Point(6, 284)
        Me.txtStatusSettings.Name = "txtStatusSettings"
        Me.txtStatusSettings.ReadOnly = True
        Me.txtStatusSettings.Size = New System.Drawing.Size(482, 16)
        Me.txtStatusSettings.TabIndex = 27
        Me.txtStatusSettings.Text = "Status"
        '
        'btnSaveSettings
        '
        Me.btnSaveSettings.Location = New System.Drawing.Point(514, 281)
        Me.btnSaveSettings.Name = "btnSaveSettings"
        Me.btnSaveSettings.Size = New System.Drawing.Size(96, 23)
        Me.btnSaveSettings.TabIndex = 21
        Me.btnSaveSettings.Text = "Save Settings"
        Me.btnSaveSettings.UseVisualStyleBackColor = True
        '
        'tabSubMenu
        '
        Me.tabSubMenu.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.tabSubMenu.Controls.Add(Me.tabJobInfo)
        Me.tabSubMenu.Controls.Add(Me.tabFilters)
        Me.tabSubMenu.Controls.Add(Me.tabAgentRemediation)
        Me.tabSubMenu.Location = New System.Drawing.Point(6, 6)
        Me.tabSubMenu.Name = "tabSubMenu"
        Me.tabSubMenu.SelectedIndex = 0
        Me.tabSubMenu.Size = New System.Drawing.Size(616, 479)
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
        Me.tabJobInfo.Location = New System.Drawing.Point(4, 25)
        Me.tabJobInfo.Name = "tabJobInfo"
        Me.tabJobInfo.Size = New System.Drawing.Size(608, 450)
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
        Me.GroupBox1.Location = New System.Drawing.Point(3, 89)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(602, 221)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Job Targets"
        '
        'rdoagent
        '
        Me.rdoagent.AutoSize = True
        Me.rdoagent.Checked = True
        Me.rdoagent.Location = New System.Drawing.Point(6, 19)
        Me.rdoagent.Name = "rdoagent"
        Me.rdoagent.Size = New System.Drawing.Size(98, 17)
        Me.rdoagent.TabIndex = 12
        Me.rdoagent.TabStop = True
        Me.rdoagent.Text = "Agent Endpoint"
        Me.rdoagent.UseVisualStyleBackColor = True
        '
        'rdoshare
        '
        Me.rdoshare.AutoSize = True
        Me.rdoshare.Location = New System.Drawing.Point(241, 19)
        Me.rdoshare.Name = "rdoshare"
        Me.rdoshare.Size = New System.Drawing.Size(96, 17)
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
        Me.grpshare.Location = New System.Drawing.Point(234, 40)
        Me.grpshare.Name = "grpshare"
        Me.grpshare.Size = New System.Drawing.Size(360, 161)
        Me.grpshare.TabIndex = 11
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
        'grpagent
        '
        Me.grpagent.Controls.Add(Me.Label1)
        Me.grpagent.Controls.Add(Me.lstComputerTargets)
        Me.grpagent.Controls.Add(Me.txtComputerTarget)
        Me.grpagent.Controls.Add(Me.btnAddComputer)
        Me.grpagent.Controls.Add(Me.btnRemoveComputer)
        Me.grpagent.Location = New System.Drawing.Point(5, 40)
        Me.grpagent.Name = "grpagent"
        Me.grpagent.Size = New System.Drawing.Size(219, 161)
        Me.grpagent.TabIndex = 10
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
        'tabFilters
        '
        Me.tabFilters.Controls.Add(Me.tabFiltersSubMenu)
        Me.tabFilters.Location = New System.Drawing.Point(4, 25)
        Me.tabFilters.Name = "tabFilters"
        Me.tabFilters.Padding = New System.Windows.Forms.Padding(3)
        Me.tabFilters.Size = New System.Drawing.Size(608, 450)
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
        Me.tabFiltersSubMenu.Size = New System.Drawing.Size(602, 444)
        Me.tabFiltersSubMenu.TabIndex = 0
        '
        'tabInclusionFilter
        '
        Me.tabInclusionFilter.Controls.Add(Me.splitInclusion)
        Me.tabInclusionFilter.Location = New System.Drawing.Point(4, 22)
        Me.tabInclusionFilter.Name = "tabInclusionFilter"
        Me.tabInclusionFilter.Padding = New System.Windows.Forms.Padding(3)
        Me.tabInclusionFilter.Size = New System.Drawing.Size(594, 418)
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
        Me.splitInclusion.Location = New System.Drawing.Point(3, 3)
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
        Me.splitInclusion.Size = New System.Drawing.Size(588, 412)
        Me.splitInclusion.SplitterDistance = 216
        Me.splitInclusion.SplitterWidth = 8
        Me.splitInclusion.TabIndex = 14
        '
        'txtinclkeywords
        '
        Me.txtinclkeywords.Location = New System.Drawing.Point(241, 97)
        Me.txtinclkeywords.Multiline = True
        Me.txtinclkeywords.Name = "txtinclkeywords"
        Me.txtinclkeywords.Size = New System.Drawing.Size(333, 105)
        Me.txtinclkeywords.TabIndex = 2
        '
        'rdoinclregexsearch
        '
        Me.rdoinclregexsearch.AutoSize = True
        Me.rdoinclregexsearch.Location = New System.Drawing.Point(352, 61)
        Me.rdoinclregexsearch.Name = "rdoinclregexsearch"
        Me.rdoinclregexsearch.Size = New System.Drawing.Size(94, 17)
        Me.rdoinclregexsearch.TabIndex = 13
        Me.rdoinclregexsearch.Text = "RegEx Search"
        Me.rdoinclregexsearch.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(10, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Filter Name:"
        '
        'rdoinclsimplesearch
        '
        Me.rdoinclsimplesearch.AutoSize = True
        Me.rdoinclsimplesearch.Checked = True
        Me.rdoinclsimplesearch.Location = New System.Drawing.Point(242, 61)
        Me.rdoinclsimplesearch.Name = "rdoinclsimplesearch"
        Me.rdoinclsimplesearch.Size = New System.Drawing.Size(93, 17)
        Me.rdoinclsimplesearch.TabIndex = 12
        Me.rdoinclsimplesearch.TabStop = True
        Me.rdoinclsimplesearch.Text = "Simple Search"
        Me.rdoinclsimplesearch.UseVisualStyleBackColor = True
        '
        'txtinclfiltername
        '
        Me.txtinclfiltername.Location = New System.Drawing.Point(92, 6)
        Me.txtinclfiltername.Name = "txtinclfiltername"
        Me.txtinclfiltername.Size = New System.Drawing.Size(185, 20)
        Me.txtinclfiltername.TabIndex = 1
        '
        'chkinclsearchfilename
        '
        Me.chkinclsearchfilename.AutoSize = True
        Me.chkinclsearchfilename.Location = New System.Drawing.Point(457, 62)
        Me.chkinclsearchfilename.Name = "chkinclsearchfilename"
        Me.chkinclsearchfilename.Size = New System.Drawing.Size(131, 17)
        Me.chkinclsearchfilename.TabIndex = 10
        Me.chkinclsearchfilename.Text = "Search FileName Only"
        Me.chkinclsearchfilename.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(239, 81)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 13)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Keywords:"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(10, 81)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(61, 13)
        Me.Label23.TabIndex = 9
        Me.Label23.Text = "MD5 Hash:"
        '
        'txtinclpathcontains
        '
        Me.txtinclpathcontains.Location = New System.Drawing.Point(92, 36)
        Me.txtinclpathcontains.Multiline = True
        Me.txtinclpathcontains.Name = "txtinclpathcontains"
        Me.txtinclpathcontains.Size = New System.Drawing.Size(482, 20)
        Me.txtinclpathcontains.TabIndex = 4
        '
        'txtinclmd5hash
        '
        Me.txtinclmd5hash.Location = New System.Drawing.Point(8, 97)
        Me.txtinclmd5hash.Multiline = True
        Me.txtinclmd5hash.Name = "txtinclmd5hash"
        Me.txtinclmd5hash.Size = New System.Drawing.Size(227, 105)
        Me.txtinclmd5hash.TabIndex = 8
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(10, 39)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(76, 13)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Path Contains:"
        '
        'txtinclextensions
        '
        Me.txtinclextensions.Location = New System.Drawing.Point(350, 6)
        Me.txtinclextensions.Name = "txtinclextensions"
        Me.txtinclextensions.Size = New System.Drawing.Size(224, 20)
        Me.txtinclextensions.TabIndex = 7
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(283, 9)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(61, 13)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "Extensions:"
        '
        'btnSaveIncFilterChanges
        '
        Me.btnSaveIncFilterChanges.Location = New System.Drawing.Point(260, 3)
        Me.btnSaveIncFilterChanges.Name = "btnSaveIncFilterChanges"
        Me.btnSaveIncFilterChanges.Size = New System.Drawing.Size(75, 23)
        Me.btnSaveIncFilterChanges.TabIndex = 5
        Me.btnSaveIncFilterChanges.Text = "Save"
        Me.btnSaveIncFilterChanges.UseVisualStyleBackColor = True
        '
        'lstboxinclusionfilters
        '
        Me.lstboxinclusionfilters.FormattingEnabled = True
        Me.lstboxinclusionfilters.Location = New System.Drawing.Point(3, 59)
        Me.lstboxinclusionfilters.Name = "lstboxinclusionfilters"
        Me.lstboxinclusionfilters.Size = New System.Drawing.Size(581, 124)
        Me.lstboxinclusionfilters.TabIndex = 4
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(5, 43)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(37, 13)
        Me.Label31.TabIndex = 3
        Me.Label31.Text = "Filters:"
        '
        'btnRemoveInclFilterfromList
        '
        Me.btnRemoveInclFilterfromList.Location = New System.Drawing.Point(512, 3)
        Me.btnRemoveInclFilterfromList.Name = "btnRemoveInclFilterfromList"
        Me.btnRemoveInclFilterfromList.Size = New System.Drawing.Size(75, 23)
        Me.btnRemoveInclFilterfromList.TabIndex = 1
        Me.btnRemoveInclFilterfromList.Text = "Remove"
        Me.btnRemoveInclFilterfromList.UseVisualStyleBackColor = True
        '
        'btnAddInclFilterToList
        '
        Me.btnAddInclFilterToList.Location = New System.Drawing.Point(3, 3)
        Me.btnAddInclFilterToList.Name = "btnAddInclFilterToList"
        Me.btnAddInclFilterToList.Size = New System.Drawing.Size(75, 23)
        Me.btnAddInclFilterToList.TabIndex = 0
        Me.btnAddInclFilterToList.Text = "Add"
        Me.btnAddInclFilterToList.UseVisualStyleBackColor = True
        '
        'tabExclusionFilter
        '
        Me.tabExclusionFilter.Controls.Add(Me.SplitExclusion)
        Me.tabExclusionFilter.Location = New System.Drawing.Point(4, 22)
        Me.tabExclusionFilter.Name = "tabExclusionFilter"
        Me.tabExclusionFilter.Padding = New System.Windows.Forms.Padding(3)
        Me.tabExclusionFilter.Size = New System.Drawing.Size(594, 418)
        Me.tabExclusionFilter.TabIndex = 1
        Me.tabExclusionFilter.Text = "Exclusion"
        Me.tabExclusionFilter.UseVisualStyleBackColor = True
        '
        'SplitExclusion
        '
        Me.SplitExclusion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitExclusion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitExclusion.IsSplitterFixed = True
        Me.SplitExclusion.Location = New System.Drawing.Point(3, 3)
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
        Me.SplitExclusion.Size = New System.Drawing.Size(588, 412)
        Me.SplitExclusion.SplitterDistance = 216
        Me.SplitExclusion.SplitterWidth = 8
        Me.SplitExclusion.TabIndex = 18
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(10, 9)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(63, 13)
        Me.Label15.TabIndex = 8
        Me.Label15.Text = "Filter Name:"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(10, 81)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(61, 13)
        Me.Label24.TabIndex = 17
        Me.Label24.Text = "MD5 Hash:"
        '
        'txtexclfiltername
        '
        Me.txtexclfiltername.Location = New System.Drawing.Point(92, 6)
        Me.txtexclfiltername.Name = "txtexclfiltername"
        Me.txtexclfiltername.Size = New System.Drawing.Size(185, 20)
        Me.txtexclfiltername.TabIndex = 9
        '
        'txtexclmd5hash
        '
        Me.txtexclmd5hash.Location = New System.Drawing.Point(8, 97)
        Me.txtexclmd5hash.Multiline = True
        Me.txtexclmd5hash.Name = "txtexclmd5hash"
        Me.txtexclmd5hash.Size = New System.Drawing.Size(227, 105)
        Me.txtexclmd5hash.TabIndex = 16
        '
        'txtexclpathcontains
        '
        Me.txtexclpathcontains.Location = New System.Drawing.Point(92, 36)
        Me.txtexclpathcontains.Multiline = True
        Me.txtexclpathcontains.Name = "txtexclpathcontains"
        Me.txtexclpathcontains.Size = New System.Drawing.Size(482, 20)
        Me.txtexclpathcontains.TabIndex = 12
        '
        'txtexclextensions
        '
        Me.txtexclextensions.Location = New System.Drawing.Point(350, 6)
        Me.txtexclextensions.Name = "txtexclextensions"
        Me.txtexclextensions.Size = New System.Drawing.Size(224, 20)
        Me.txtexclextensions.TabIndex = 15
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(10, 39)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(76, 13)
        Me.Label13.TabIndex = 13
        Me.Label13.Text = "Path Contains:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(283, 9)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(61, 13)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "Extensions:"
        '
        'btnsaveexclusionfilterchanges
        '
        Me.btnsaveexclusionfilterchanges.Location = New System.Drawing.Point(260, 3)
        Me.btnsaveexclusionfilterchanges.Name = "btnsaveexclusionfilterchanges"
        Me.btnsaveexclusionfilterchanges.Size = New System.Drawing.Size(75, 23)
        Me.btnsaveexclusionfilterchanges.TabIndex = 10
        Me.btnsaveexclusionfilterchanges.Text = "Save"
        Me.btnsaveexclusionfilterchanges.UseVisualStyleBackColor = True
        '
        'lstboxexclusionfilters
        '
        Me.lstboxexclusionfilters.FormattingEnabled = True
        Me.lstboxexclusionfilters.Location = New System.Drawing.Point(3, 59)
        Me.lstboxexclusionfilters.Name = "lstboxexclusionfilters"
        Me.lstboxexclusionfilters.Size = New System.Drawing.Size(581, 124)
        Me.lstboxexclusionfilters.TabIndex = 9
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(5, 43)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(37, 13)
        Me.Label32.TabIndex = 8
        Me.Label32.Text = "Filters:"
        '
        'btnremoveexclusionfilterfromlist
        '
        Me.btnremoveexclusionfilterfromlist.Location = New System.Drawing.Point(512, 3)
        Me.btnremoveexclusionfilterfromlist.Name = "btnremoveexclusionfilterfromlist"
        Me.btnremoveexclusionfilterfromlist.Size = New System.Drawing.Size(75, 23)
        Me.btnremoveexclusionfilterfromlist.TabIndex = 7
        Me.btnremoveexclusionfilterfromlist.Text = "Remove"
        Me.btnremoveexclusionfilterfromlist.UseVisualStyleBackColor = True
        '
        'btnaddexclusionfiltertolist
        '
        Me.btnaddexclusionfiltertolist.Location = New System.Drawing.Point(3, 3)
        Me.btnaddexclusionfiltertolist.Name = "btnaddexclusionfiltertolist"
        Me.btnaddexclusionfiltertolist.Size = New System.Drawing.Size(75, 23)
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
        Me.tabAgentRemediation.Location = New System.Drawing.Point(4, 25)
        Me.tabAgentRemediation.Name = "tabAgentRemediation"
        Me.tabAgentRemediation.Size = New System.Drawing.Size(608, 450)
        Me.tabAgentRemediation.TabIndex = 2
        Me.tabAgentRemediation.Text = "Agent Remediation"
        Me.tabAgentRemediation.UseVisualStyleBackColor = True
        '
        'btnSaveRemOptionChange
        '
        Me.btnSaveRemOptionChange.Location = New System.Drawing.Point(269, 290)
        Me.btnSaveRemOptionChange.Name = "btnSaveRemOptionChange"
        Me.btnSaveRemOptionChange.Size = New System.Drawing.Size(75, 23)
        Me.btnSaveRemOptionChange.TabIndex = 4
        Me.btnSaveRemOptionChange.Text = "Save"
        Me.btnSaveRemOptionChange.UseVisualStyleBackColor = True
        '
        'btnRemoveRemOption
        '
        Me.btnRemoveRemOption.Location = New System.Drawing.Point(529, 290)
        Me.btnRemoveRemOption.Name = "btnRemoveRemOption"
        Me.btnRemoveRemOption.Size = New System.Drawing.Size(75, 23)
        Me.btnRemoveRemOption.TabIndex = 3
        Me.btnRemoveRemOption.Text = "Remove"
        Me.btnRemoveRemOption.UseVisualStyleBackColor = True
        '
        'btnAddRemOption
        '
        Me.btnAddRemOption.Location = New System.Drawing.Point(4, 290)
        Me.btnAddRemOption.Name = "btnAddRemOption"
        Me.btnAddRemOption.Size = New System.Drawing.Size(75, 23)
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
        Me.lvRemOptions.Location = New System.Drawing.Point(4, 319)
        Me.lvRemOptions.MultiSelect = False
        Me.lvRemOptions.Name = "lvRemOptions"
        Me.lvRemOptions.Size = New System.Drawing.Size(600, 128)
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
        Me.tabAgentRemediationSubMenu.Name = "tabAgentRemediationSubMenu"
        Me.tabAgentRemediationSubMenu.SelectedIndex = 0
        Me.tabAgentRemediationSubMenu.Size = New System.Drawing.Size(608, 279)
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
        Me.tabAgentSendFile.Size = New System.Drawing.Size(600, 253)
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
        Me.tabAgentExecute.Size = New System.Drawing.Size(600, 253)
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
        Me.tabAgentDelete.Size = New System.Drawing.Size(600, 253)
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
        Me.TabAgentKill.Controls.Add(Me.rdoPName)
        Me.TabAgentKill.Controls.Add(Me.rdoPID)
        Me.TabAgentKill.Controls.Add(Me.txtremkillprocname)
        Me.TabAgentKill.Controls.Add(Me.Label22)
        Me.TabAgentKill.Controls.Add(Me.nmbremkillprocid)
        Me.TabAgentKill.Controls.Add(Me.Label21)
        Me.TabAgentKill.Location = New System.Drawing.Point(4, 22)
        Me.TabAgentKill.Name = "TabAgentKill"
        Me.TabAgentKill.Size = New System.Drawing.Size(600, 253)
        Me.TabAgentKill.TabIndex = 3
        Me.TabAgentKill.Text = "Kill Process"
        Me.TabAgentKill.UseVisualStyleBackColor = True
        '
        'rdoPName
        '
        Me.rdoPName.AutoSize = True
        Me.rdoPName.Location = New System.Drawing.Point(160, 15)
        Me.rdoPName.Name = "rdoPName"
        Me.rdoPName.Size = New System.Drawing.Size(94, 17)
        Me.rdoPName.TabIndex = 17
        Me.rdoPName.TabStop = True
        Me.rdoPName.Text = "Process Name"
        Me.rdoPName.UseVisualStyleBackColor = True
        '
        'rdoPID
        '
        Me.rdoPID.AutoSize = True
        Me.rdoPID.Location = New System.Drawing.Point(14, 15)
        Me.rdoPID.Name = "rdoPID"
        Me.rdoPID.Size = New System.Drawing.Size(77, 17)
        Me.rdoPID.TabIndex = 16
        Me.rdoPID.TabStop = True
        Me.rdoPID.Text = "Process ID"
        Me.rdoPID.UseVisualStyleBackColor = True
        '
        'txtremkillprocname
        '
        Me.txtremkillprocname.Location = New System.Drawing.Point(94, 79)
        Me.txtremkillprocname.Name = "txtremkillprocname"
        Me.txtremkillprocname.Size = New System.Drawing.Size(235, 20)
        Me.txtremkillprocname.TabIndex = 14
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(11, 82)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(79, 13)
        Me.Label22.TabIndex = 15
        Me.Label22.Text = "Process Name:"
        '
        'nmbremkillprocid
        '
        Me.nmbremkillprocid.Location = New System.Drawing.Point(94, 53)
        Me.nmbremkillprocid.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.nmbremkillprocid.Name = "nmbremkillprocid"
        Me.nmbremkillprocid.Size = New System.Drawing.Size(76, 20)
        Me.nmbremkillprocid.TabIndex = 13
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(11, 55)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(77, 13)
        Me.Label21.TabIndex = 12
        Me.Label21.Text = "By Process ID:"
        '
        'tabMenu
        '
        Me.tabMenu.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.tabMenu.Controls.Add(Me.tabSettings)
        Me.tabMenu.Controls.Add(Me.tabJobExecution)
        Me.tabMenu.Controls.Add(Me.tabFireEye)
        Me.tabMenu.Controls.Add(Me.tabPANW)
        Me.tabMenu.Controls.Add(Me.tabXPS)
        Me.tabMenu.Controls.Add(Me.tabAbout)
        Me.tabMenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabMenu.Location = New System.Drawing.Point(0, 0)
        Me.tabMenu.Name = "tabMenu"
        Me.tabMenu.SelectedIndex = 0
        Me.tabMenu.Size = New System.Drawing.Size(636, 595)
        Me.tabMenu.TabIndex = 21
        '
        'tabSettings
        '
        Me.tabSettings.Controls.Add(Me.GroupBox4)
        Me.tabSettings.Location = New System.Drawing.Point(4, 25)
        Me.tabSettings.Name = "tabSettings"
        Me.tabSettings.Padding = New System.Windows.Forms.Padding(3)
        Me.tabSettings.Size = New System.Drawing.Size(628, 566)
        Me.tabSettings.TabIndex = 1
        Me.tabSettings.Text = "Settings"
        Me.tabSettings.UseVisualStyleBackColor = True
        '
        'tabJobExecution
        '
        Me.tabJobExecution.Controls.Add(Me.lblJobStatus)
        Me.tabJobExecution.Controls.Add(Me.btnShowJSON)
        Me.tabJobExecution.Controls.Add(Me.btnLoadFromBox)
        Me.tabJobExecution.Controls.Add(Me.btnSaveAsBox)
        Me.tabJobExecution.Controls.Add(Me.btnExecute)
        Me.tabJobExecution.Controls.Add(Me.tabSubMenu)
        Me.tabJobExecution.Location = New System.Drawing.Point(4, 25)
        Me.tabJobExecution.Name = "tabJobExecution"
        Me.tabJobExecution.Padding = New System.Windows.Forms.Padding(3)
        Me.tabJobExecution.Size = New System.Drawing.Size(628, 566)
        Me.tabJobExecution.TabIndex = 0
        Me.tabJobExecution.Text = "Job Execution"
        Me.tabJobExecution.UseVisualStyleBackColor = True
        '
        'lblJobStatus
        '
        Me.lblJobStatus.AutoSize = True
        Me.lblJobStatus.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblJobStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJobStatus.Location = New System.Drawing.Point(3, 547)
        Me.lblJobStatus.MaximumSize = New System.Drawing.Size(500, 0)
        Me.lblJobStatus.MinimumSize = New System.Drawing.Size(500, 0)
        Me.lblJobStatus.Name = "lblJobStatus"
        Me.lblJobStatus.Size = New System.Drawing.Size(500, 16)
        Me.lblJobStatus.TabIndex = 33
        Me.lblJobStatus.Text = "lblJobStatus"
        '
        'btnShowJSON
        '
        Me.btnShowJSON.Location = New System.Drawing.Point(210, 491)
        Me.btnShowJSON.Name = "btnShowJSON"
        Me.btnShowJSON.Size = New System.Drawing.Size(75, 23)
        Me.btnShowJSON.TabIndex = 23
        Me.btnShowJSON.Text = "Show JSON"
        Me.btnShowJSON.UseVisualStyleBackColor = True
        '
        'btnLoadFromBox
        '
        Me.btnLoadFromBox.Location = New System.Drawing.Point(319, 491)
        Me.btnLoadFromBox.Name = "btnLoadFromBox"
        Me.btnLoadFromBox.Size = New System.Drawing.Size(90, 23)
        Me.btnLoadFromBox.TabIndex = 22
        Me.btnLoadFromBox.Text = "Load From Box"
        Me.btnLoadFromBox.UseVisualStyleBackColor = True
        '
        'btnSaveAsBox
        '
        Me.btnSaveAsBox.Location = New System.Drawing.Point(436, 491)
        Me.btnSaveAsBox.Name = "btnSaveAsBox"
        Me.btnSaveAsBox.Size = New System.Drawing.Size(75, 23)
        Me.btnSaveAsBox.TabIndex = 21
        Me.btnSaveAsBox.Text = "Save as Box"
        Me.btnSaveAsBox.UseVisualStyleBackColor = True
        '
        'tabFireEye
        '
        Me.tabFireEye.Controls.Add(Me.lblFEStatus)
        Me.tabFireEye.Controls.Add(Me.txtFELink)
        Me.tabFireEye.Controls.Add(Me.Label37)
        Me.tabFireEye.Controls.Add(Me.Label34)
        Me.tabFireEye.Controls.Add(Me.cmbFEAlertType)
        Me.tabFireEye.Controls.Add(Me.txtFETarget)
        Me.tabFireEye.Controls.Add(Me.Label33)
        Me.tabFireEye.Controls.Add(Me.btn_FEEvent)
        Me.tabFireEye.Location = New System.Drawing.Point(4, 25)
        Me.tabFireEye.Name = "tabFireEye"
        Me.tabFireEye.Padding = New System.Windows.Forms.Padding(3)
        Me.tabFireEye.Size = New System.Drawing.Size(628, 566)
        Me.tabFireEye.TabIndex = 4
        Me.tabFireEye.Text = "FireEye"
        Me.tabFireEye.UseVisualStyleBackColor = True
        '
        'lblFEStatus
        '
        Me.lblFEStatus.AutoSize = True
        Me.lblFEStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFEStatus.Location = New System.Drawing.Point(42, 104)
        Me.lblFEStatus.Name = "lblFEStatus"
        Me.lblFEStatus.Size = New System.Drawing.Size(76, 16)
        Me.lblFEStatus.TabIndex = 32
        Me.lblFEStatus.Text = "lblFEStatus"
        '
        'txtFELink
        '
        Me.txtFELink.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFELink.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtFELink.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFELink.Location = New System.Drawing.Point(25, 173)
        Me.txtFELink.Name = "txtFELink"
        Me.txtFELink.ReadOnly = True
        Me.txtFELink.Size = New System.Drawing.Size(540, 16)
        Me.txtFELink.TabIndex = 7
        Me.txtFELink.TabStop = False
        Me.txtFELink.Text = "http://fedeploycheck.fireeye.com/appliance-test/test-infection.exe"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(22, 146)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(543, 15)
        Me.Label37.TabIndex = 6
        Me.Label37.Text = "To generate a verified hit from a test FireEye ThreatScan download the following " & _
    "EXE to your target."
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(42, 44)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(58, 13)
        Me.Label34.TabIndex = 5
        Me.Label34.Text = "Alert Type:"
        '
        'cmbFEAlertType
        '
        Me.cmbFEAlertType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFEAlertType.FormattingEnabled = True
        Me.cmbFEAlertType.Items.AddRange(New Object() {"malware-object", "malware-callback", "web-infection", "domain-match", "infection-match"})
        Me.cmbFEAlertType.Location = New System.Drawing.Point(106, 41)
        Me.cmbFEAlertType.Name = "cmbFEAlertType"
        Me.cmbFEAlertType.Size = New System.Drawing.Size(176, 21)
        Me.cmbFEAlertType.TabIndex = 4
        '
        'txtFETarget
        '
        Me.txtFETarget.Location = New System.Drawing.Point(106, 15)
        Me.txtFETarget.Name = "txtFETarget"
        Me.txtFETarget.Size = New System.Drawing.Size(176, 20)
        Me.txtFETarget.TabIndex = 3
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(8, 18)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(92, 13)
        Me.Label33.TabIndex = 2
        Me.Label33.Text = "Target Hostname:"
        '
        'btn_FEEvent
        '
        Me.btn_FEEvent.Location = New System.Drawing.Point(106, 68)
        Me.btn_FEEvent.Name = "btn_FEEvent"
        Me.btn_FEEvent.Size = New System.Drawing.Size(117, 23)
        Me.btn_FEEvent.TabIndex = 0
        Me.btn_FEEvent.Text = "Send FireEye Event"
        Me.btn_FEEvent.UseVisualStyleBackColor = True
        '
        'tabPANW
        '
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
        Me.tabPANW.Location = New System.Drawing.Point(4, 25)
        Me.tabPANW.Name = "tabPANW"
        Me.tabPANW.Size = New System.Drawing.Size(628, 566)
        Me.tabPANW.TabIndex = 5
        Me.tabPANW.Text = "PANW"
        Me.tabPANW.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(44, 311)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(516, 147)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 35
        Me.PictureBox2.TabStop = False
        '
        'txtPANWSim
        '
        Me.txtPANWSim.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPANWSim.Location = New System.Drawing.Point(354, 122)
        Me.txtPANWSim.Multiline = True
        Me.txtPANWSim.Name = "txtPANWSim"
        Me.txtPANWSim.ReadOnly = True
        Me.txtPANWSim.Size = New System.Drawing.Size(204, 187)
        Me.txtPANWSim.TabIndex = 34
        Me.txtPANWSim.Text = resources.GetString("txtPANWSim.Text")
        '
        'TextBox4
        '
        Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(28, 219)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(320, 13)
        Me.TextBox4.TabIndex = 33
        Me.TextBox4.TabStop = False
        Me.TextBox4.Text = "http://fedeploycheck.fireeye.com/appliance-test/test-infection.exe"
        '
        'Label45
        '
        Me.Label45.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.Location = New System.Drawing.Point(32, 178)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(300, 38)
        Me.Label45.TabIndex = 32
        Me.Label45.Text = "To generate a verified hit from a test PANW" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " ThreatScan download the following E" & _
    "XE to your target." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblPANWStatus
        '
        Me.lblPANWStatus.AutoSize = True
        Me.lblPANWStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPANWStatus.Location = New System.Drawing.Point(42, 134)
        Me.lblPANWStatus.Name = "lblPANWStatus"
        Me.lblPANWStatus.Size = New System.Drawing.Size(100, 16)
        Me.lblPANWStatus.TabIndex = 31
        Me.lblPANWStatus.Text = "lblPANWStatus"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.panw_sim_port)
        Me.GroupBox5.Controls.Add(Me.Label44)
        Me.GroupBox5.Controls.Add(Me.lblwildfirestatus)
        Me.GroupBox5.Controls.Add(Me.btn_WildfireStart)
        Me.GroupBox5.Location = New System.Drawing.Point(356, 14)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(204, 102)
        Me.GroupBox5.TabIndex = 24
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "PANW Wildfire Sim"
        '
        'panw_sim_port
        '
        Me.panw_sim_port.Location = New System.Drawing.Point(102, 23)
        Me.panw_sim_port.Maximum = New Decimal(New Integer() {65535, 0, 0, 0})
        Me.panw_sim_port.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.panw_sim_port.Name = "panw_sim_port"
        Me.panw_sim_port.Size = New System.Drawing.Size(96, 20)
        Me.panw_sim_port.TabIndex = 24
        Me.panw_sim_port.Value = New Decimal(New Integer() {8449, 0, 0, 0})
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Location = New System.Drawing.Point(6, 25)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(87, 13)
        Me.Label44.TabIndex = 23
        Me.Label44.Text = "Wildfire Sim Port:"
        '
        'lblwildfirestatus
        '
        Me.lblwildfirestatus.AutoSize = True
        Me.lblwildfirestatus.Location = New System.Drawing.Point(18, 82)
        Me.lblwildfirestatus.Name = "lblwildfirestatus"
        Me.lblwildfirestatus.Size = New System.Drawing.Size(155, 13)
        Me.lblwildfirestatus.TabIndex = 22
        Me.lblwildfirestatus.Text = "Wildfire Sim Status: Not Started"
        '
        'btn_WildfireStart
        '
        Me.btn_WildfireStart.Location = New System.Drawing.Point(32, 51)
        Me.btn_WildfireStart.Name = "btn_WildfireStart"
        Me.btn_WildfireStart.Size = New System.Drawing.Size(131, 23)
        Me.btn_WildfireStart.TabIndex = 21
        Me.btn_WildfireStart.Text = "Start Wildfire Sim"
        Me.btn_WildfireStart.UseVisualStyleBackColor = True
        '
        'panwPort
        '
        Me.panwPort.Location = New System.Drawing.Point(130, 16)
        Me.panwPort.Maximum = New Decimal(New Integer() {65535, 0, 0, 0})
        Me.panwPort.Name = "panwPort"
        Me.panwPort.Size = New System.Drawing.Size(120, 20)
        Me.panwPort.TabIndex = 11
        Me.panwPort.Value = New Decimal(New Integer() {514, 0, 0, 0})
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(8, 18)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(122, 13)
        Me.Label30.TabIndex = 10
        Me.Label30.Text = "R1 PANW Listener Port:"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(42, 70)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(58, 13)
        Me.Label35.TabIndex = 9
        Me.Label35.Text = "Alert Type:"
        '
        'cmbPANWAlert
        '
        Me.cmbPANWAlert.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPANWAlert.FormattingEnabled = True
        Me.cmbPANWAlert.Items.AddRange(New Object() {"WILDFIRE", "VIRUS", "FILE", "FLOOD", "URL"})
        Me.cmbPANWAlert.Location = New System.Drawing.Point(130, 67)
        Me.cmbPANWAlert.Name = "cmbPANWAlert"
        Me.cmbPANWAlert.Size = New System.Drawing.Size(176, 21)
        Me.cmbPANWAlert.TabIndex = 8
        '
        'txtPANWTarget
        '
        Me.txtPANWTarget.Location = New System.Drawing.Point(130, 41)
        Me.txtPANWTarget.Name = "txtPANWTarget"
        Me.txtPANWTarget.Size = New System.Drawing.Size(176, 20)
        Me.txtPANWTarget.TabIndex = 7
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(8, 44)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(92, 13)
        Me.Label36.TabIndex = 6
        Me.Label36.Text = "Target Hostname:"
        '
        'btnPANWSend
        '
        Me.btnPANWSend.Location = New System.Drawing.Point(130, 94)
        Me.btnPANWSend.Name = "btnPANWSend"
        Me.btnPANWSend.Size = New System.Drawing.Size(139, 23)
        Me.btnPANWSend.TabIndex = 0
        Me.btnPANWSend.Text = "Send PANW SysLog Alert"
        Me.btnPANWSend.UseVisualStyleBackColor = True
        '
        'tabXPS
        '
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
        Me.tabXPS.Location = New System.Drawing.Point(4, 25)
        Me.tabXPS.Name = "tabXPS"
        Me.tabXPS.Padding = New System.Windows.Forms.Padding(3)
        Me.tabXPS.Size = New System.Drawing.Size(628, 566)
        Me.tabXPS.TabIndex = 6
        Me.tabXPS.Text = "XPS"
        Me.tabXPS.UseVisualStyleBackColor = True
        '
        'lblXPSStatus
        '
        Me.lblXPSStatus.AutoSize = True
        Me.lblXPSStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblXPSStatus.Location = New System.Drawing.Point(33, 154)
        Me.lblXPSStatus.Name = "lblXPSStatus"
        Me.lblXPSStatus.Size = New System.Drawing.Size(85, 16)
        Me.lblXPSStatus.TabIndex = 30
        Me.lblXPSStatus.Text = "lblXPSStatus"
        '
        'txtXPSMalware
        '
        Me.txtXPSMalware.Location = New System.Drawing.Point(130, 96)
        Me.txtXPSMalware.Name = "txtXPSMalware"
        Me.txtXPSMalware.Size = New System.Drawing.Size(176, 20)
        Me.txtXPSMalware.TabIndex = 29
        Me.txtXPSMalware.Text = "Super.Evil.Malware"
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Location = New System.Drawing.Point(33, 99)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(81, 13)
        Me.Label42.TabIndex = 28
        Me.Label42.Text = "Malware Name:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(57, 315)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(502, 168)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 27
        Me.PictureBox1.TabStop = False
        '
        'txtXPSSIM
        '
        Me.txtXPSSIM.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtXPSSIM.Location = New System.Drawing.Point(355, 122)
        Me.txtXPSSIM.Multiline = True
        Me.txtXPSSIM.Name = "txtXPSSIM"
        Me.txtXPSSIM.ReadOnly = True
        Me.txtXPSSIM.Size = New System.Drawing.Size(204, 187)
        Me.txtXPSSIM.TabIndex = 26
        Me.txtXPSSIM.Text = resources.GetString("txtXPSSIM.Text")
        '
        'txtFELink2
        '
        Me.txtFELink2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFELink2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtFELink2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFELink2.Location = New System.Drawing.Point(29, 223)
        Me.txtFELink2.Name = "txtFELink2"
        Me.txtFELink2.ReadOnly = True
        Me.txtFELink2.Size = New System.Drawing.Size(320, 13)
        Me.txtFELink2.TabIndex = 25
        Me.txtFELink2.TabStop = False
        Me.txtFELink2.Text = "http://fedeploycheck.fireeye.com/appliance-test/test-infection.exe"
        '
        'Label39
        '
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.Location = New System.Drawing.Point(33, 182)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(300, 38)
        Me.Label39.TabIndex = 24
        Me.Label39.Text = "To generate a verified hit from a test XPS ThreatScan download the following EXE " & _
    "to your target." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.xps_sim_Port)
        Me.GroupBox3.Controls.Add(Me.Label43)
        Me.GroupBox3.Controls.Add(Me.lbldemoxpsstatus)
        Me.GroupBox3.Controls.Add(Me.btnStartXPSListener)
        Me.GroupBox3.Location = New System.Drawing.Point(355, 14)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(204, 102)
        Me.GroupBox3.TabIndex = 23
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "XPS CP Sim"
        '
        'xps_sim_Port
        '
        Me.xps_sim_Port.Location = New System.Drawing.Point(102, 23)
        Me.xps_sim_Port.Maximum = New Decimal(New Integer() {65535, 0, 0, 0})
        Me.xps_sim_Port.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.xps_sim_Port.Name = "xps_sim_Port"
        Me.xps_sim_Port.Size = New System.Drawing.Size(96, 20)
        Me.xps_sim_Port.TabIndex = 24
        Me.xps_sim_Port.Value = New Decimal(New Integer() {8448, 0, 0, 0})
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Location = New System.Drawing.Point(6, 25)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(90, 13)
        Me.Label43.TabIndex = 23
        Me.Label43.Text = "XPS CP Sim Port:"
        '
        'lbldemoxpsstatus
        '
        Me.lbldemoxpsstatus.AutoSize = True
        Me.lbldemoxpsstatus.Location = New System.Drawing.Point(18, 82)
        Me.lbldemoxpsstatus.Name = "lbldemoxpsstatus"
        Me.lbldemoxpsstatus.Size = New System.Drawing.Size(158, 13)
        Me.lbldemoxpsstatus.TabIndex = 22
        Me.lbldemoxpsstatus.Text = "XPS CP Sim Status: Not Started"
        '
        'btnStartXPSListener
        '
        Me.btnStartXPSListener.Location = New System.Drawing.Point(32, 51)
        Me.btnStartXPSListener.Name = "btnStartXPSListener"
        Me.btnStartXPSListener.Size = New System.Drawing.Size(131, 23)
        Me.btnStartXPSListener.TabIndex = 21
        Me.btnStartXPSListener.Text = "Start XPS CP Sim"
        Me.btnStartXPSListener.UseVisualStyleBackColor = True
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Location = New System.Drawing.Point(70, 70)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(48, 13)
        Me.Label41.TabIndex = 20
        Me.Label41.Text = "Severity:"
        '
        'cmbXPSSeverity
        '
        Me.cmbXPSSeverity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbXPSSeverity.FormattingEnabled = True
        Me.cmbXPSSeverity.Items.AddRange(New Object() {"Low", "Medium", "High", "Critical"})
        Me.cmbXPSSeverity.Location = New System.Drawing.Point(130, 67)
        Me.cmbXPSSeverity.Name = "cmbXPSSeverity"
        Me.cmbXPSSeverity.Size = New System.Drawing.Size(176, 21)
        Me.cmbXPSSeverity.TabIndex = 19
        '
        'xpsPort
        '
        Me.xpsPort.Location = New System.Drawing.Point(130, 16)
        Me.xpsPort.Maximum = New Decimal(New Integer() {65535, 0, 0, 0})
        Me.xpsPort.Name = "xpsPort"
        Me.xpsPort.Size = New System.Drawing.Size(120, 20)
        Me.xpsPort.TabIndex = 18
        Me.xpsPort.Value = New Decimal(New Integer() {514, 0, 0, 0})
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(8, 18)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(110, 13)
        Me.Label38.TabIndex = 17
        Me.Label38.Text = "R1 XPS Listener Port:"
        '
        'txtXPSTarget
        '
        Me.txtXPSTarget.Location = New System.Drawing.Point(130, 41)
        Me.txtXPSTarget.Name = "txtXPSTarget"
        Me.txtXPSTarget.Size = New System.Drawing.Size(176, 20)
        Me.txtXPSTarget.TabIndex = 14
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(26, 44)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(92, 13)
        Me.Label40.TabIndex = 13
        Me.Label40.Text = "Target Hostname:"
        '
        'btnXPSSend
        '
        Me.btnXPSSend.Location = New System.Drawing.Point(130, 122)
        Me.btnXPSSend.Name = "btnXPSSend"
        Me.btnXPSSend.Size = New System.Drawing.Size(139, 23)
        Me.btnXPSSend.TabIndex = 12
        Me.btnXPSSend.Text = "Send XPS SysLog Alert"
        Me.btnXPSSend.UseVisualStyleBackColor = True
        '
        'tabAbout
        '
        Me.tabAbout.Controls.Add(Me.TextBox1)
        Me.tabAbout.Location = New System.Drawing.Point(4, 25)
        Me.tabAbout.Name = "tabAbout"
        Me.tabAbout.Size = New System.Drawing.Size(628, 566)
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
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(628, 566)
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
        'bgwork_xpslisten
        '
        Me.bgwork_xpslisten.WorkerReportsProgress = True
        Me.bgwork_xpslisten.WorkerSupportsCancellation = True
        '
        'bgwork_panwlisten
        '
        Me.bgwork_panwlisten.WorkerReportsProgress = True
        Me.bgwork_panwlisten.WorkerSupportsCancellation = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(636, 595)
        Me.Controls.Add(Me.tabMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
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
    Friend WithEvents bgwork_xpslisten As System.ComponentModel.BackgroundWorker
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
    Friend WithEvents bgwork_panwlisten As System.ComponentModel.BackgroundWorker
    Friend WithEvents lblXPSStatus As System.Windows.Forms.Label
    Friend WithEvents lblPANWStatus As System.Windows.Forms.Label
    Friend WithEvents lblFEStatus As System.Windows.Forms.Label
    Friend WithEvents lblJobStatus As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents txtPANWSim As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label45 As System.Windows.Forms.Label

End Class
