﻿Imports RestSharp
Imports System.Net
Imports System.Security
Imports System.Runtime.InteropServices
Imports FEPRestClient.Models.Response
Imports FEPRestClient.Models
Imports System.Threading
Imports System.Reflection
Imports System.IO
Imports System.Text

Public Class Main
    Public Shared RestClient As New FEPRestClient.Client
    Public Shared RestClientValidLogin As Boolean = False
    Public projsearchmenu As New ContextMenuStrip
    Public jobstatussearchmenu As New ContextMenuStrip

    Public JobRefreshTimer As System.Threading.Timer
    Public JobEndpointRefreshTimer As System.Threading.Timer
    Public AlertsRefreshTimer As System.Threading.Timer

    Public JobsEndpointStatus

    'Delcare Stores for Job Filters/Options
    Public StoreInFiltList
    Public StoreExFiltList
    Public StoreRemSendList
    Public StoreRemExecList
    Public StoreRemDelList
    Public StoreRemKillNameList
    Public StoreRemKillIDList
    'Declare Automation Job
    Public autojobs
    Public xpsbg_listen
    Public panwbg_listen
    'SecureString for API Password
    Public apipass As SecureString
    'Stores ThreadInfo
    Public xps_sim_var As XPS.XPS_Sim
    Public panw_sim_var As PANW.PANW_Sim
    'Self-Signed Cert
    Public sim_selfcert As String = ""
    Public debug_on As Boolean = False
    Public debug_trace As TextWriterTraceListener
    Public debug_fs As FileStream

    Private Sub Main_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If debug_on = True Then
            DebugWriteLine("App Closing")
            Debug.Close()
            Trace.Close()
        End If
    End Sub

    Private Sub Form_Main_Load(sender As Object, e As EventArgs) Handles Me.Load
        If IO.File.Exists("debuglogs.txt") Then
            'New trace
            Dim trace As New TextWriterTraceListener
            'FS Object
            Dim fs As FileStream = New FileStream(My.Application.Info.ProductName & ".log", FileMode.Append, FileAccess.Write)
            'Set writer
            trace.Writer = New StreamWriter(fs)
            'Add listner

            Debug.Listeners.Add(trace)
            Debug.AutoFlush = True
            debug_on = True
            DebugWriteLine("Debugging Enabled")
        End If


        'First Run-Generate default templates
        Me.Text = "FEP Job Runner Version: " & My.Application.Info.Version.ToString
        If My.Settings.firstrun = True Or My.Settings.templatename Is Nothing Then
            'Set templates
            My.Settings.templatename.Clear()
            My.Settings.templatename.Add("coll-evtx")

            'Set Blank Password
            My.Settings.apipassword = EncryptString(ToSecureString(""))

            'Set websitepath Endpoint
            My.Settings.websitepath = "Endpoint"

            'Updates on
            My.Settings.updatecheck = True

            'Turn first run off
            My.Settings.firstrun = False
            My.Settings.Save()
        End If

        'End First Run
        rdoendpoint.Checked = True

        'Set Target to Agent 
        rdoagent.Checked = True
        rdoshare.Checked = False

        'Set PID rdo
        rdoPID.Checked = True

        'Clear status message
        lblJobStatus.Text = ""
        txtStatusSettings.Text = ""

        'Load Settings
        chkbypasscerts.Checked = My.Settings.bypasscert
        txtdefaultcomputer.Text = My.Settings.defaultcomputer
        txtComputerTarget.Text = txtdefaultcomputer.Text
        txtdefaultshare.Text = My.Settings.defaultshare
        txtNetSharePath.Text = txtdefaultshare.Text
        'Check password
        If Not String.IsNullOrWhiteSpace(My.Settings.apipassword) Then
            RestClient.Password = ToInsecureString(DecryptString(My.Settings.apipassword))
            apipass = DecryptString(My.Settings.apipassword)
            txtAPIPass.Text = apipass.ToString
        Else
            apipass = ToSecureString("")
            txtAPIPass.Text = apipass.ToString
        End If
        txtApiUser.Text = My.Settings.apiusername
        RestClient.Username = My.Settings.apiusername
        txtDefaultJobName.Text = My.Settings.jobname
        txtJobName.Text = txtDefaultJobName.Text
        txtServer.Text = My.Settings.webserver
        RestClient.Server = My.Settings.webserver
        txtDefaultProjectName.Text = My.Settings.projectname
        txtProjectName.Text = txtDefaultProjectName.Text
        txtDefaultTemplateName.Items.Clear()
        For Each item In My.Settings.templatename
            txtDefaultTemplateName.Items.Add(item.ToString)
        Next
        txtDefaultTemplateName.Text = My.Settings.templatenameselect
        txtTemplateName.Items.Clear()
        For Each item In My.Settings.templatename
            txtTemplateName.Items.Add(item.ToString)
        Next
        txtTemplateName.Text = My.Settings.templatenameselect

        Dim websitepath As String = My.Settings.websitepath

        If websitepath = "Endpoint" Then
            rdoendpoint.Checked = True
            rdocustom.Checked = False
        Else
            rdocustom.Checked = True
            rdoendpoint.Checked = False
            txtcustomwebaddress.Text = My.Settings.websitepath
        End If

        'Update Check settings
        chkUpdates.Checked = My.Settings.updatecheck

        'Set the job stores
        StoreInFiltList = New List(Of InclusionFilter)
        StoreExFiltList = New List(Of ExclusionFilter)
        StoreRemDelList = New List(Of JobsService.ArrayOfJobOptionsOperationsAgentRemediationEraseJobOptionsOperationsAgentRemediationErase)
        StoreRemExecList = New List(Of JobsService.ArrayOfJobOptionsOperationsAgentRemediationExecuteJobOptionsOperationsAgentRemediationExecute)
        StoreRemSendList = New List(Of JobsService.ArrayOfJobOptionsOperationsAgentRemediationSendFileJobOptionsOperationsAgentRemediationSendFile)
        StoreRemKillNameList = New List(Of String)
        StoreRemKillIDList = New List(Of String)

        If chkUpdates.Checked Then
            Try
                CheckForUpdates(True, chkIncludPreRelease.Checked)
            Catch ex As Exception
                DebugWriteLine(ex.Message)
            End Try
        End If

        tabSubMenu.Height = flowJobInfo.Height + 20
    End Sub

    Private Sub rdoagent_CheckedChanged(sender As Object, e As EventArgs) Handles rdoagent.CheckedChanged
        'Agent Radio
        grpagent.Enabled = True
        grpshare.Enabled = False

    End Sub

    Private Sub rdoshare_CheckedChanged(sender As Object, e As EventArgs) Handles rdoshare.CheckedChanged
        'Share Radio
        grpagent.Enabled = False
        grpshare.Enabled = True

    End Sub

    Private Sub btnSaveSettings_Click(sender As Object, e As EventArgs) Handles btnSaveSettings.Click
        ResetStatusBar()
        DebugWriteLine("Saving Settings")
        'Save Settings to my.settings
        My.Settings.bypasscert = chkbypasscerts.Checked
        My.Settings.defaultcomputer = txtdefaultcomputer.Text
        My.Settings.defaultshare = txtdefaultshare.Text
        If Not My.Settings.apiusername = txtApiUser.Text Then
            My.Settings.apiusername = txtApiUser.Text
            RestClient.Username = txtApiUser.Text
        End If
        'My.Settings.apipassword = txtAPIPass.Text
        'My.Settings.apipassword = EncryptString(ToSecureString(txtAPIPass.Text))
        If Not txtAPIPass.Text = apipass.ToString Then
            Dim ppass = MsgBox("Save New Password?", MsgBoxStyle.YesNo, "Save Password")
            If ppass = MsgBoxResult.Yes Then
                RestClient.Password = txtAPIPass.Text
                If RestClient.IsAuthenticated = True Then
                    RestClient.Logout()
                End If
                My.Settings.apipassword = EncryptString(ToSecureString(txtAPIPass.Text))
                Me.apipass = DecryptString(My.Settings.apipassword)
                txtAPIPass.Text = apipass.ToString

            Else
                txtAPIPass.Text = apipass.ToString
            End If
        End If

        My.Settings.jobname = txtDefaultJobName.Text
        My.Settings.projectname = txtDefaultProjectName.Text
        If Not My.Settings.webserver = txtServer.Text Then
            My.Settings.webserver = txtServer.Text
            RestClient.Server = txtServer.Text
        End If
        My.Settings.templatename.Clear()
        For Each item In txtDefaultTemplateName.Items
            My.Settings.templatename.Add(item.ToString)
        Next
        If txtDefaultTemplateName.SelectedItem Is Nothing Then
            My.Settings.templatenameselect = txtDefaultTemplateName.Text
        Else
            My.Settings.templatenameselect = txtDefaultTemplateName.SelectedItem
        End If


        If rdoendpoint.Checked = True Then
            My.Settings.websitepath = "Endpoint"

        Else
            My.Settings.websitepath = txtcustomwebaddress.Text
        End If

        My.Settings.updatecheck = chkUpdates.Checked

        My.Settings.Save()
        txtStatusSettings.Text = "Settings Saved"
    End Sub


    Private Sub tabSettings_Enter(sender As Object, e As EventArgs) Handles tabSettings.Enter
        'Clear the text when the tab is entered
        If apipass Is Nothing Then
            txtAPIPass.Text = ""
        Else
            txtAPIPass.Text = apipass.ToString
        End If

        txtStatusSettings.Text = ""
    End Sub



    Private Sub btnSaveAsBox_Click(sender As Object, e As EventArgs) Handles btnSaveAsBox.Click
        ResetStatusBar()
        'Save Boxed Job
        'Show the Save File Dialog
        If Not IO.Directory.Exists(My.Application.Info.DirectoryPath & "\BoxedJobs") Then IO.Directory.CreateDirectory(My.Application.Info.DirectoryPath & "\BoxedJobs")

        sfdBox.InitialDirectory = My.Application.Info.DirectoryPath & "\BoxedJobs"
        If sfdBox.ShowDialog() = 1 Then
            Try
                'New Box
                Dim sbox As New BoxedJob

                'Set Box Variables
                sbox.BoxJobName = sfdBox.FileName
                sbox.R1JobName = txtJobName.Text
                sbox.R1Template = txtTemplateName.Text
                sbox.R1Project = txtProjectName.Text

                'Process IDs
                Dim pids() As String = New String() {}
                Dim pidlist As List(Of String) = StoreRemKillIDList
                For Each item In pidlist
                    pids.Add(item)
                Next
                sbox.R1_AR_PIDS = pids

                'Process Names
                Dim processnames() As String = New String() {}
                Dim pnamelist As List(Of String) = StoreRemKillNameList
                For Each item In pnamelist
                    processnames.Add(item)
                Next
                sbox.R1_AR_ProcessNames = processnames

                'Send Options
                Dim ar_send() As FEP_Job_Runner.JobsService.ArrayOfJobOptionsOperationsAgentRemediationSendFileJobOptionsOperationsAgentRemediationSendFile = StoreRemSendList.toarray
                sbox.R1_AR_Send = ar_send

                'Execute Options
                Dim ar_exec() As FEP_Job_Runner.JobsService.ArrayOfJobOptionsOperationsAgentRemediationExecuteJobOptionsOperationsAgentRemediationExecute = StoreRemExecList.toarray
                sbox.R1_AR_Execute = ar_exec

                'Erase Options
                Dim ar_erase() As FEP_Job_Runner.JobsService.ArrayOfJobOptionsOperationsAgentRemediationEraseJobOptionsOperationsAgentRemediationErase = StoreRemDelList.toarray
                sbox.R1_AR_Erase = ar_erase

                'Filters
                sbox.R1Filter = Jobs.BuildFilterJSON(StoreInFiltList, StoreExFiltList)

                'Save Job
                DebugWriteLine("Saving Box Job")
                BoxedJobs.SaveBoxedJob(sfdBox.FileName, sbox)
            Catch ex As Exception
                DebugWriteLine(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnLoadFromBox_Click(sender As Object, e As EventArgs) Handles btnLoadFromBox.Click
        ResetStatusBar()
        ofdBox.ShowDialog()
        Dim fname = ofdBox.FileName

        'If File Exists
        If IO.File.Exists(fname) Then
            Try
                'Clear the controls on every tab, form.
                ClearAllJobOptioons(Me.tabJobInfo.Controls)
                ClearAllJobOptioons(Me.tabFilters.Controls)
                ClearAllJobOptioons(Me.tabInclusionFilter.Controls)
                ClearAllJobOptioons(Me.tabExclusionFilter.Controls)
                ClearAllJobOptioons(Me.tabAgentDelete.Controls)
                ClearAllJobOptioons(Me.tabAgentExecute.Controls)
                ClearAllJobOptioons(Me.TabAgentKill.Controls)
                ClearAllJobOptioons(Me.tabAgentSendFile.Controls)
                StoreInFiltList.clear()
                StoreExFiltList.clear()
                StoreRemDelList.clear()
                StoreRemExecList.clear()
                StoreRemSendList.clear()
                StoreRemKillIDList.clear()
                StoreRemKillNameList.clear()

                'New Box = the file
                Dim box As BoxedJob = BoxedJobs.ParseBoxedJobFromFile(fname)
                txtJobName.Text = box.R1JobName
                txtProjectName.Text = box.R1Project
                txtTemplateName.Text = box.R1Template
                'Get Filters Out

                'New Filter List
                Dim flist As List(Of Object) = Jobs.ParseFilterJSON(box.R1Filter)
                'New Inclusion List
                Dim inlist As New List(Of InclusionFilter)
                'New Exclusion list
                Dim exlist As New List(Of ExclusionFilter)

                inlist = flist(0)
                exlist = flist(1)
                '> 0 filters in list
                If inlist.Count > 0 Then
                    'Inclusion Filter List = Store
                    Dim maininlist As List(Of InclusionFilter) = StoreInFiltList
                    'Add all filters to Store
                    For Each item As InclusionFilter In inlist
                        maininlist.Add(item)
                    Next

                    'Add all filters to UI
                    For Each item As InclusionFilter In maininlist
                        dgvFilters.Rows.Add(False, "Inclusion", item.FilterName)

                    Next
                End If

                '> 0 filters in list
                If exlist.Count > 0 Then
                    'Exclusion Filter List = Store
                    Dim mainexlist As List(Of ExclusionFilter) = StoreExFiltList
                    'Add all filters to Store
                    For Each item As ExclusionFilter In exlist
                        mainexlist.Add(item)
                    Next

                    'Add all filters to UI
                    For Each item As ExclusionFilter In mainexlist
                        dgvFilters.Rows.Add(False, "Exclusion", item.FilterName)
                    Next
                End If

                'Send File Options
                Dim ar_send() As JobsService.ArrayOfJobOptionsOperationsAgentRemediationSendFileJobOptionsOperationsAgentRemediationSendFile
                ar_send = box.R1_AR_Send
                '> 0 send options
                If ar_send.Count > 0 Then
                    'Send option list = Store
                    Dim remsendlst As List(Of JobsService.ArrayOfJobOptionsOperationsAgentRemediationSendFileJobOptionsOperationsAgentRemediationSendFile) = StoreRemSendList
                    'Add all send options to store
                    For Each item In ar_send
                        'Add item to UI
                        Dim nrem = lvRemOptions.Items.Add("Send File")
                        nrem.SubItems.Add(remsendlst.Count + 1)
                        'Add item to Store
                        remsendlst.Add(item)
                    Next
                End If

                'Execute Options
                Dim ar_exec() As JobsService.ArrayOfJobOptionsOperationsAgentRemediationExecuteJobOptionsOperationsAgentRemediationExecute
                ar_exec = box.R1_AR_Execute
                '> 0 Execute options
                If ar_exec.Count > 0 Then
                    'Execute option list = Store
                    Dim remexeclist As List(Of JobsService.ArrayOfJobOptionsOperationsAgentRemediationExecuteJobOptionsOperationsAgentRemediationExecute) = StoreRemExecList
                    'Add all exec optinos to store
                    For Each item In ar_exec
                        'Add item to UI
                        Dim nrem = lvRemOptions.Items.Add("Execute")
                        nrem.SubItems.Add(remexeclist.Count + 1)
                        'Add item to store
                        remexeclist.Add(item)
                    Next
                End If

                'Erase options
                Dim ar_erase() As JobsService.ArrayOfJobOptionsOperationsAgentRemediationEraseJobOptionsOperationsAgentRemediationErase
                ar_erase = box.R1_AR_Erase
                '> 0 Erase Options
                If ar_erase.Count > 0 Then
                    'Erase option list = Store
                    Dim remdelist As List(Of JobsService.ArrayOfJobOptionsOperationsAgentRemediationEraseJobOptionsOperationsAgentRemediationErase) = StoreRemDelList
                    'Add all erase options to store
                    For Each item In ar_erase
                        'Add item to UI
                        Dim nrem = lvRemOptions.Items.Add("Delete File")
                        nrem.SubItems.Add(remdelist.Count + 1)
                        'Add item to store
                        remdelist.Add(item)
                    Next
                End If

                'Kill ID Options
                Dim pids() As String = box.R1_AR_PIDS
                '> 0 ID Options
                If pids.Count > 0 Then
                    'Kill ID list = store
                    Dim rempidlist As List(Of String) = StoreRemKillIDList
                    'Add all kill ids to store
                    For Each item In pids
                        'Add item to UI
                        Dim nrem = lvRemOptions.Items.Add("Kill Process ID")
                        nrem.SubItems.Add(rempidlist.Count + 1)
                        'Add item to store
                        rempidlist.Add(item)
                    Next
                End If

                'Kill Process name Options
                Dim processnames() As String = box.R1_AR_ProcessNames
                '> 0 kill name oprtions
                If processnames.Count > 0 Then
                    'Kill name list = store
                    Dim rempnamelist As List(Of String) = StoreRemKillNameList
                    'Add all kill names to store
                    For Each item In processnames
                        'Add item to UI
                        Dim nrem = lvRemOptions.Items.Add("Kill Process Name")
                        nrem.SubItems.Add(rempnamelist.Count + 1)
                        'Add item to store
                        rempnamelist.Add(item)
                    Next
                End If
                DebugWriteLine("Loaded Box Job")
                'File Doesn't Exists
            Catch ex As Exception
                DebugWriteLine(ex.Message)
            End Try
        Else
            MsgBox("File Doesn't Exist")
        End If

    End Sub
    Private Sub tabJobInfo_Click(sender As Object, e As EventArgs) Handles tabJobInfo.Click
        'Job Info Loaded - Set text boxes to default values from settings
        txtComputerTarget.Text = txtdefaultcomputer.Text
        txtNetSharePath.Text = txtdefaultshare.Text
    End Sub

    Private Sub btnAddRemOption_Click(sender As Object, e As EventArgs) Handles btnAddRemOption.Click
        'Add Remediaton Option to List

        'Select case of the currently active tab
        Select Case tabAgentRemediationSubMenu.SelectedTab.Name
            Case tabAgentSendFile.Name
                If Not String.IsNullOrWhiteSpace(txtremsendsource.Text) And Not String.IsNullOrWhiteSpace(txtremsenddest.Text) Then
                    'Send File Tab
                    'remsenlst = store
                    Dim remsendlst As List(Of JobsService.ArrayOfJobOptionsOperationsAgentRemediationSendFileJobOptionsOperationsAgentRemediationSendFile) = StoreRemSendList
                    'Add new item to UI
                    Dim nrem = lvRemOptions.Items.Add("Send File")
                    nrem.SubItems.Add(remsendlst.Count + 1)
                    'New send option variable
                    Dim nremsend As New JobsService.ArrayOfJobOptionsOperationsAgentRemediationSendFileJobOptionsOperationsAgentRemediationSendFile
                    'Set properties from UI
                    nremsend.FileToSend = txtremsendsource.Text
                    nremsend.RemotePath = txtremsenddest.Text
                    nremsend.OverwriteIfExists = chkremsenddelete.Checked
                    'Add to store
                    remsendlst.Add(nremsend)
                Else
                    MsgBox("Please specify source and destination paths.")
                End If
            Case tabAgentExecute.Name
                If Not String.IsNullOrWhiteSpace(txtremexecpath.Text) Then
                    'Execute Tab
                    'remexeclist = store
                    Dim remexeclist As List(Of JobsService.ArrayOfJobOptionsOperationsAgentRemediationExecuteJobOptionsOperationsAgentRemediationExecute) = StoreRemExecList
                    'Add new item to UI
                    Dim nrem = lvRemOptions.Items.Add("Execute")
                    nrem.SubItems.Add(remexeclist.Count + 1)
                    'New exec opt variable
                    Dim nremexec As New JobsService.ArrayOfJobOptionsOperationsAgentRemediationExecuteJobOptionsOperationsAgentRemediationExecute
                    'Set properties from UI
                    nremexec.Executable = txtremexecpath.Text
                    nremexec.Arguments = txtremexecargs.Text
                    'Add to store
                    remexeclist.Add(nremexec)
                Else
                    MsgBox("Please specify the path of an executable.")
                End If

            Case tabAgentDelete.Name
                If Not String.IsNullOrWhiteSpace(txtremdelfilepath.Text) Then
                    'Delete File Tab
                    'remdellist = Store
                    Dim remdellist As List(Of JobsService.ArrayOfJobOptionsOperationsAgentRemediationEraseJobOptionsOperationsAgentRemediationErase) = StoreRemDelList
                    'Add to UI
                    Dim nrem = lvRemOptions.Items.Add("Delete File")
                    nrem.SubItems.Add(remdellist.Count + 1)
                    'New delete opt variable
                    Dim nremdel As New JobsService.ArrayOfJobOptionsOperationsAgentRemediationEraseJobOptionsOperationsAgentRemediationErase
                    'Set properties from UI
                    nremdel.RemotePath = txtremdelfilepath.Text
                    'Add to store
                    remdellist.Add(nremdel)
                Else
                    MsgBox("Please specify the path of a file to delete.")
                End If

            Case TabAgentKill.Name
                'Kill process tab. We split the name and ids so we check which was set here. (We only allow one per add-radio buttons)
                If Not String.IsNullOrWhiteSpace(txtremkillprocname.Text) Then
                    'Process name is not blank - add
                    'remprocnamelsit = store
                    Dim remprocnamelist As List(Of String) = StoreRemKillNameList
                    'Add to UI
                    Dim nrem = lvRemOptions.Items.Add("Kill Process Name")
                    nrem.SubItems.Add(remprocnamelist.Count + 1)
                    'Add to Store
                    remprocnamelist.Add(txtremkillprocname.Text)
                End If
                If nmbremkillprocid.Value > 0 Then
                    'Process ID is not 0 - add
                    'remprocidlist = store
                    Dim remprocidlist As List(Of String) = StoreRemKillIDList
                    'Add to UI
                    Dim nrem = lvRemOptions.Items.Add("Kill Process ID")
                    nrem.SubItems.Add(remprocidlist.Count + 1)
                    'Add to Store
                    remprocidlist.Add(nmbremkillprocid.Value)
                End If

        End Select
    End Sub

    Private Sub lvRemOptions_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvRemOptions.SelectedIndexChanged
        'Selected filter changed - switch to the relevant tab and load the filter from the store
        'Check if selected items > 0
        If lvRemOptions.SelectedItems.Count > 0 Then
            'Select case of remediation option type
            Select Case lvRemOptions.SelectedItems(0).Text
                Case "Send File"
                    'Send File
                    'Switch to Send File Tab
                    tabAgentRemediationSubMenu.SelectedTab = tabAgentSendFile
                    'sflist = Store
                    Dim sflist As List(Of JobsService.ArrayOfJobOptionsOperationsAgentRemediationSendFileJobOptionsOperationsAgentRemediationSendFile) = StoreRemSendList
                    'sfi = selected index of item
                    Dim sfi = sflist(lvRemOptions.SelectedItems(0).SubItems(1).Text - 1)
                    'Update UI with properties
                    txtremsenddest.Text = sfi.RemotePath
                    txtremsendsource.Text = sfi.FileToSend
                    chkremsenddelete.Checked = sfi.OverwriteIfExists
                    'Focus back on listview
                    lvRemOptions.Focus()
                Case "Delete File"
                    'Delete File
                    'Switch to Delete File tab
                    tabAgentRemediationSubMenu.SelectedTab = tabAgentDelete
                    'dflist = Store
                    Dim dflist As List(Of JobsService.ArrayOfJobOptionsOperationsAgentRemediationEraseJobOptionsOperationsAgentRemediationErase) = StoreRemDelList
                    'dfi = selected index of item
                    Dim dfi = dflist(lvRemOptions.SelectedItems(0).SubItems(1).Text - 1)
                    'Update UI with properties
                    txtremdelfilepath.Text = dfi.RemotePath
                    'Focus back on listview
                    lvRemOptions.Focus()
                Case "Execute"
                    'Execute
                    'Switch to execute tab
                    tabAgentRemediationSubMenu.SelectedTab = tabAgentExecute
                    'xflist = Store
                    Dim xflist As List(Of JobsService.ArrayOfJobOptionsOperationsAgentRemediationExecuteJobOptionsOperationsAgentRemediationExecute) = StoreRemExecList
                    'xfi = selected index of item
                    Dim xfi = xflist(lvRemOptions.SelectedItems(0).SubItems(1).Text - 1)
                    'Update UI with properties
                    txtremexecargs.Text = xfi.Arguments
                    txtremexecpath.Text = xfi.Executable
                    'Focus back on listview
                    lvRemOptions.Focus()
                Case "Kill Process Name"
                    'Kill process name
                    'Switch to Kill Tab
                    tabAgentRemediationSubMenu.SelectedTab = TabAgentKill
                    'kpnamelist = store
                    Dim kpnamelist As List(Of String) = StoreRemKillNameList
                    'knli = selected index of item
                    Dim knli = kpnamelist(lvRemOptions.SelectedItems(0).SubItems(1).Text - 1)
                    'Update UI with properties
                    rdoPName.Checked = True
                    txtremkillprocname.Text = knli
                    nmbremkillprocid.Value = 0
                    'Focus back on listview
                    lvRemOptions.Focus()
                Case "Kill Process ID"
                    'Kill process id
                    'Switch to kill tab
                    tabAgentRemediationSubMenu.SelectedTab = TabAgentKill
                    'kpidlist = store
                    Dim kpidlist As List(Of String) = StoreRemKillIDList
                    'kidli = selected index of item
                    Dim kidli = kpidlist(lvRemOptions.SelectedItems(0).SubItems(1).Text - 1)
                    'Update UI with properties
                    rdoPID.Checked = True
                    nmbremkillprocid.Value = kidli
                    txtremkillprocname.Text = ""
                    'Focus back on listview
                    lvRemOptions.Focus()
            End Select
        End If
    End Sub

    Private Sub btnRemoveRemOption_Click(sender As Object, e As EventArgs) Handles btnRemoveRemOption.Click
        'Remove checked remediation items from listbox
        With lvRemOptions
            '>0 checked items
            If .CheckedItems.Count > 0 Then
                'Iterate backwards from max to min
                For checked As Integer = .CheckedItems.Count - 1 To 0 Step -1
                    'Remove from Store
                    Jobs.RemoveItemFromRemStores(.CheckedItems.Item(checked))

                    'Select case of item remediation type
                    Select Case .CheckedItems.Item(checked).Text
                        Case "Send File"
                            'Send file
                            'Remove from UI
                            .Items.Remove(.CheckedItems(checked))
                            ''''''
                            ''''Reorder remaining items of this type
                            'Count of items
                            Dim scount As Integer = 1
                            'Iterate remediation items 
                            For i = 0 To lvRemOptions.Items.Count - 1
                                'If type is send file
                                If lvRemOptions.Items.Item(i).Text = "Send File" Then
                                    'Change item order
                                    lvRemOptions.Items.Item(i).SubItems(1).Text = scount
                                    '++
                                    scount += 1
                                End If
                            Next

                        Case "Execute"
                            'Execute
                            'Remove from UI
                            .Items.Remove(.CheckedItems(checked))
                            '''''
                            '''Reorder remaining items of this type
                            'Count of items
                            Dim xcount As Integer = 1
                            'Iterate remediation items
                            For i = 0 To lvRemOptions.Items.Count - 1
                                'If type is execute
                                If lvRemOptions.Items.Item(i).Text = "Execute" Then
                                    'Change item order
                                    lvRemOptions.Items.Item(i).SubItems(1).Text = xcount
                                    '++
                                    xcount += 1
                                End If
                            Next

                        Case "Delete File"
                            'Delete
                            'Remove from UI
                            .Items.Remove(.CheckedItems(checked))
                            '''''
                            '''''Reorder remaining items of this type
                            'Count of items
                            Dim dcount As Integer = 1
                            'Iterate remediation items
                            For i = 0 To lvRemOptions.Items.Count - 1
                                'If type is delete file
                                If lvRemOptions.Items.Item(i).Text = "Delete File" Then
                                    'Change item order
                                    lvRemOptions.Items.Item(i).SubItems(1).Text = dcount
                                    '++
                                    dcount += 1
                                End If
                            Next

                        Case "Kill Process Name"
                            'Kill process name
                            'Remove from UI
                            .Items.Remove(.CheckedItems(checked))
                            ''''
                            '''Reorder remaining items of this type
                            ''' Count of items
                            Dim knamecount As Integer = 1
                            'iterate remediation items
                            For i = 0 To lvRemOptions.Items.Count - 1
                                'If type is kill process name
                                If lvRemOptions.Items.Item(i).Text = "Kill Process Name" Then
                                    'Change item order
                                    lvRemOptions.Items.Item(i).SubItems(1).Text = knamecount
                                    '++
                                    knamecount += 1
                                End If
                            Next

                        Case "Kill Process ID"
                            'Kill process ID
                            'Remove from UI
                            .Items.Remove(.CheckedItems(checked))
                            '''''
                            ''Reorder remaining items of this type
                            'Count of items
                            Dim kidcount As Integer = 1
                            'Iterate remediation items
                            For i = 0 To lvRemOptions.Items.Count - 1
                                'If type is kill process id
                                If lvRemOptions.Items.Item(i).Text = "Kill Process ID" Then
                                    'Change item order
                                    lvRemOptions.Items.Item(i).SubItems(1).Text = kidcount
                                    '++
                                    kidcount += 1
                                End If
                            Next
                    End Select
                Next
            End If
        End With
    End Sub


    Private Sub btnSaveRemOptionChange_Click(sender As Object, e As EventArgs) Handles btnSaveRemOptionChange.Click
        'Save remediation option change
        '> 0 selected items
        If lvRemOptions.SelectedItems.Count > 0 Then
            'Select case remediation type
            Select Case lvRemOptions.SelectedItems(0).Text
                Case "Send File"
                    'Send File
                    'sflist = store
                    Dim sflist As List(Of JobsService.ArrayOfJobOptionsOperationsAgentRemediationSendFileJobOptionsOperationsAgentRemediationSendFile) = StoreRemSendList
                    'sfi = selected index of item
                    Dim sfi = sflist(lvRemOptions.SelectedItems(0).SubItems(1).Text - 1)
                    'Update properties
                    sfi.RemotePath = txtremsenddest.Text
                    sfi.FileToSend = txtremsendsource.Text
                    sfi.OverwriteIfExists = chkremsenddelete.Checked
                Case "Delete File"
                    'Delete File
                    'dflist = store
                    Dim dflist As List(Of JobsService.ArrayOfJobOptionsOperationsAgentRemediationEraseJobOptionsOperationsAgentRemediationErase) = StoreRemDelList
                    'dfi = selected index of item
                    Dim dfi = dflist(lvRemOptions.SelectedItems(0).SubItems(1).Text - 1)
                    'Update properties
                    dfi.RemotePath = txtremdelfilepath.Text
                Case "Execute"
                    'Execute
                    'xflist = store
                    Dim xflist As List(Of JobsService.ArrayOfJobOptionsOperationsAgentRemediationExecuteJobOptionsOperationsAgentRemediationExecute) = StoreRemExecList
                    'xfi = selected index of item
                    Dim xfi = xflist(lvRemOptions.SelectedItems(0).SubItems(1).Text - 1)
                    'Update properties
                    xfi.Executable = txtremexecpath.Text
                    xfi.Arguments = txtremexecargs.Text
                Case "Kill Process Name"
                    'Kill process name
                    'kpnamelist = store
                    Dim kpnamelist As List(Of String) = StoreRemKillNameList
                    'knli = selected index of item
                    Dim knli = kpnamelist(lvRemOptions.SelectedItems(0).SubItems(1).Text - 1)
                    'Update properties
                    knli = txtremkillprocname.Text
                Case "Kill Process ID"
                    'Kill process id
                    'kpidlist = store
                    Dim kpidlist As List(Of String) = StoreRemKillIDList
                    'kidli = slected index of item
                    Dim kidli = kpidlist(lvRemOptions.SelectedItems(0).SubItems(1).Text - 1)
                    'Update properties
                    kidli = nmbremkillprocid.Value
            End Select
        End If
    End Sub

    Private Sub rdoPID_CheckedChanged(sender As Object, e As EventArgs) Handles rdoPID.CheckedChanged
        'PID Radio
        txtremkillprocname.Enabled = False
        nmbremkillprocid.Enabled = True
        txtremkillprocname.Text = ""
    End Sub

    Private Sub rdoPName_CheckedChanged(sender As Object, e As EventArgs) Handles rdoPName.CheckedChanged
        'PName Radio
        txtremkillprocname.Enabled = True
        nmbremkillprocid.Enabled = False
        nmbremkillprocid.Value = 0
    End Sub

    Private Sub btn_FEEvent_Click(sender As Object, e As EventArgs) Handles btn_FEEvent.Click
        Try
            ResetStatusBar()
            If Not String.IsNullOrWhiteSpace(txtFETarget.Text) Then
                Dim fevent As FireEye.FireEye_Event = FireEye.GenerateFEEvent(cmbFEAlertType.Text)
                'If the MD5 provided isnt blank, use it. Otherwise it defaults to the FETest MD5.
                If Not String.IsNullOrWhiteSpace(txtFireEyeMalwareMD5.Text) Then
                    fevent.alert.explanation.malwaredetected.malware.md5sum = Me.txtFireEyeMalwareMD5.Text
                End If
                If String.IsNullOrWhiteSpace(txtFireEyeMalwareName.Text) Then
                    fevent.alert.explanation.malwaredetected.malware.name = "Super.Evil.Malware"
                Else
                    fevent.alert.explanation.malwaredetected.malware.name = txtFireEyeMalwareName.Text
                End If
                DebugWriteLine("Sending FEYE Event")
                FireEye.SendEvent(FireEye.FEventtoJson(fevent))
            End If
        Catch ex As Exception
            DebugWriteLine(ex.Message)
        End Try
    End Sub

    Private Sub btnPANWSend_Click(sender As Object, e As EventArgs) Handles btnPANWSend.Click
        Try
            ResetStatusBar()
            If Not String.IsNullOrWhiteSpace(txtPANWTarget.Text) Then
                Dim panwthreat As New PANW.PANWThreat
                panwthreat.P8Destination_IP = txtPANWTarget.Text
                panwthreat.P4Subtype = cmbPANWAlert.Text.ToLower
                If Not String.IsNullOrWhiteSpace(txtPANWMalwareMD5.Text) Then
                    panwthreat.P43Filedigest = txtPANWMalwareMD5.Text
                End If
                If String.IsNullOrWhiteSpace(txtPANWMalwareName.Text) Then
                    panwthreat.P31Miscellaneous = "Super.Evil.Malware.exe"
                Else
                    panwthreat.P31Miscellaneous = txtPANWMalwareName.Text & ".exe"
                End If
                Dim panwtstr As String = PANW.ThreatTOCSV(panwthreat)
                DebugWriteLine("Sending PANW Event")
                PANW.SendEvent(panwtstr)
            End If
        Catch ex As Exception
            DebugWriteLine(ex.Message)
        End Try
    End Sub

    Private Sub tabMenu_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tabMenu.SelectedIndexChanged


    End Sub


    Private Sub tabFireEye_Enter(sender As Object, e As EventArgs) Handles tabFireEye.Enter
        cmbFEAlertType.SelectedIndex = 0
    End Sub

    Private Sub tabPANW_Enter(sender As Object, e As EventArgs) Handles tabPANW.Enter
        lblWildFireURL.Location = New Point(panwPicture.Location.X + 111, panwPicture.Location.Y + 85)
        lblWildFireURL.Text = "https://" & My.Computer.Name & ":" & panw_sim_port.Value
        cmbPANWAlert.SelectedIndex = 0
        txtPANWSim.Text = "The Wildfire Sim simulates Resolution1 queries to Wildfire to get malware reports and kick off validated threatscans. After starting the Wildfire Sim, configure the Resolution1 PANW connector as shown below. If Job Runner isn't running on the R1 server, browse to https://" & My.Computer.Name & ":" & panw_sim_port.Value & " on the server and import the certificate to the Local Machine - Trusted Root Certification Authorities Store."
    End Sub

    Private Sub txtFELink_DoubleClick(sender As Object, e As EventArgs) Handles txtFELink.DoubleClick, txtFELink.Click
        Dim sinfo As New ProcessStartInfo(txtFELink.Text)
        Process.Start(sinfo)
    End Sub

    Private Sub btnShowJSON_Click(sender As Object, e As EventArgs) Handles btnShowJSON.Click
        ResetStatusBar()
        MsgBox("Press Ctrl+C to copy." & vbCrLf & Jobs.BuildFilterJSON(StoreInFiltList, StoreExFiltList))
    End Sub

    Private Sub txtcustomwebaddress_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcustomwebaddress.KeyPress

        If Char.IsLetterOrDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub rdocustom_CheckedChanged(sender As Object, e As EventArgs) Handles rdocustom.CheckedChanged
        If rdocustom.Checked = True Then
            txtcustomwebaddress.Enabled = True
        Else
            txtcustomwebaddress.Enabled = False
        End If
    End Sub

    Private Sub btnXPSSend_Click(sender As Object, e As EventArgs) Handles btnXPSSend.Click
        Try
            Jobs.ResetStatusBar()
            If Not String.IsNullOrWhiteSpace(txtXPSTarget.Text) Then
                Dim xpsThreat As New XPS.XPSThreat
                xpsThreat.Dstaddr = Me.txtXPSTarget.Text
                xpsThreat.HostIp = Me.txtXPSTarget.Text
                xpsThreat.Action = "alert"
                If String.IsNullOrWhiteSpace(txtXPSMalware.Text) Then
                    xpsThreat.MalwareName = "Super.Evil.Malware"
                Else
                    xpsThreat.MalwareName = txtXPSMalware.Text
                End If
                xpsThreat.MalwareType = "Malware"
                xpsThreat.Rule = "Malware Detection Engine"
                xpsThreat.Severity = Me.cmbXPSSeverity.SelectedItem.ToString
                Dim xpststr As String = XPS.XPSThreatTOCSV(xpsThreat)
                If Not xps_sim_var Is Nothing Then
                    xps_sim_var.MalwareMD5 = txtXPSMalwareMD5.Text
                End If
                DebugWriteLine("Sending Network Event")
                XPS.SendEvent(xpststr)
            End If
        Catch Ex As Exception
            DebugWriteLine(Ex.Message)
        End Try
    End Sub



    Private Sub tabXPS_Enter(sender As Object, e As EventArgs) Handles tabXPS.Enter
        lblXPSHostname.Location = New Point(xpsPicture.Location.X + 75, xpsPicture.Location.Y + 65)
        lblXPSHostname.Text = My.Computer.Name & ":" & xps_sim_Port.Value
        cmbXPSSeverity.SelectedItem = "Critical"
        txtXPSSim.Text = "The Network CP Sim simulates Endpoint queries to Network to get malware reports and kick off validated threatscans. After starting the Network CP Sim, configure the FEP Network connector as shown below. If Job Runner isn't running on the FEP server, browse to https://" & My.Computer.Name & ":" & xps_sim_Port.Value & " on the server and import the certificate to the Local Machine - Trusted Root Certification Authorities Store."
    End Sub

    Private Sub btnStartXPSListener_Click(sender As Object, e As EventArgs) Handles btnStartXPSListener.Click
        Select Case btnStartXPSListener.Text
            Case "Start Network CP Sim"
                Try
                    btnStartXPSListener.Text = "Stop Network CP Sim"
                    lbldemoxpsstatus.Text = "Network CP Sim Status: Started"
                    xps_sim_Port.Enabled = False
                    xps_sim_var = New XPS.XPS_Sim
                    DebugWriteLine("Starting Network Sim")
                    xps_sim_var.Start()
                Catch ex As Exception
                    DebugWriteLine(ex.Message)
                End Try
            Case "Stop Network CP Sim"
                Try
                    DebugWriteLine("Stopping Network Sim")
                    xps_sim_var.Stop()
                    btnStartXPSListener.Text = "Start Network CP Sim"
                    lbldemoxpsstatus.Text = "Network CP Sim Status: Not Started"
                    xps_sim_Port.Enabled = True
                Catch ex As Exception
                    DebugWriteLine(ex.Message)
                End Try
        End Select

    End Sub

    Private Sub txtFELink2_Click(sender As Object, e As EventArgs) Handles txtFELink2.Click
        Dim sinfo As New ProcessStartInfo(txtFELink.Text)
        Process.Start(sinfo)
    End Sub


    Private Sub btn_WildfireStart_Click(sender As Object, e As EventArgs) Handles btn_WildfireStart.Click
        Select Case btn_WildfireStart.Text
            Case "Start Wildfire Sim"
                Try
                    btn_WildfireStart.Text = "Stop Wildfire Sim"
                    lblwildfirestatus.Text = "Wildfire Sim Status: Started"
                    panw_sim_port.Enabled = False
                    panw_sim_var = New PANW.PANW_Sim
                    DebugWriteLine("Starting WildFire Sim")
                    panw_sim_var.Start()

                Catch ex As Exception
                    DebugWriteLine(ex.Message)
                End Try
            Case "Stop Wildfire Sim"
                Try
                    DebugWriteLine("Stopping WildFire Sim")
                    panw_sim_var.Stop()
                    btn_WildfireStart.Text = "Start Wildfire Sim"
                    lblwildfirestatus.Text = "Wildfire Sim Status: Not Started"
                    panw_sim_port.Enabled = True

                Catch ex As Exception
                    DebugWriteLine(ex.Message)
                End Try
        End Select

    End Sub


    Private Sub TextBox4_Click(sender As Object, e As EventArgs) Handles txtFireEyeDownload1.Click
        Dim sinfo As New ProcessStartInfo(txtFELink.Text)
        Process.Start(sinfo)
    End Sub

    Private Sub btnUpdateCheck(sender As Object, e As EventArgs) Handles btn_CheckForUpdates.Click
        Try
            CheckForUpdates(False, chkIncludPreRelease.Checked)
        Catch ex As Exception
            DebugWriteLine(ex.Message)
        End Try
    End Sub

    Private Sub CheckForUpdate_About_Click(sender As Object, e As EventArgs) Handles btn_AboutCheckforUpdates.Click
        Try
            CheckForUpdates(False, chkIncludPreRelease.Checked)
        Catch ex As Exception
            DebugWriteLine(ex.Message)
        End Try
    End Sub



    Private Sub tabJobExecution_Enter(sender As Object, e As EventArgs) Handles tabJobExecution.Enter
        If chkRestAPI.Checked Then
            If RestClient.IsAuthenticated = False Then
                FEPAuthenticate()

            End If
            If RestClient.IsAuthenticated Then

                JobRunner_RestFunctions.GetJobTemplates()

                If My.Settings.templatenameselect <> "" Then
                    If txtTemplateName.Items.Contains(My.Settings.templatenameselect) Then
                        txtTemplateName.SelectedItem = My.Settings.templatenameselect
                    Else
                        txtTemplateName.Items.Add(My.Settings.templatenameselect)
                        txtTemplateName.SelectedItem = My.Settings.templatenameselect
                    End If
                Else
                    txtTemplateName.SelectedIndex = 0
                End If

            End If
        Else
            txtTemplateName.Items.Clear()
            txtTemplateName.Items.Add("coll-evtx")
            If My.Settings.templatenameselect <> "" Then
                If txtTemplateName.Items.Contains(My.Settings.templatenameselect) Then
                    txtTemplateName.SelectedItem = My.Settings.templatenameselect
                Else
                    txtTemplateName.Items.Add(My.Settings.templatenameselect)
                    txtTemplateName.SelectedItem = My.Settings.templatenameselect
                End If
            Else

                txtTemplateName.SelectedIndex = 0
            End If
        End If


    End Sub
    Private Delegate Sub RefreshJobTimer(ByVal form As Form)
    Public Sub JobRefreshUp(state As Object)
        If Me.InvokeRequired Then
            Me.Invoke(New RefreshJobTimer(AddressOf JobRefreshUp), Me)
        Else
            JobStatusSearchFacetUpdate()

        End If
    End Sub
    Public Function Create_JobRefreshTimer()
        Dim JobRefreshCall As New System.Threading.TimerCallback(AddressOf JobRefreshUp)
        Return New System.Threading.Timer(JobRefreshCall, Nothing, 10, 10000)
    End Function
    Private Delegate Sub RefreshJobEndpointTimer(ByVal form As Form)
    Public Sub JobEndpointRefreshUp(state As Object)
        If Me.InvokeRequired Then
            Me.Invoke(New RefreshJobTimer(AddressOf JobEndpointRefreshUp), Me)
        Else
            Select Case txtSearchEndpointStatus.Text
                Case ""
                    JobRunner_RestFunctions.GetJobTargets(JobsEndpointStatus)
                Case "Search"
                    JobRunner_RestFunctions.GetJobTargets(JobsEndpointStatus)
                Case Else
                    Dim facsearch As New Facet.FacetSearch
                    facsearch.SearchAny.Add(txtSearchEndpointStatus.Text)
                    JobRunner_RestFunctions.GetJobTargets(JobsEndpointStatus, facsearch)
            End Select

        End If
    End Sub
    Public Function Create_JobEndpointRefreshTimer()
        Dim JobEndpointRefreshCall As New System.Threading.TimerCallback(AddressOf JobEndpointRefreshUp)
        Return New System.Threading.Timer(JobEndpointRefreshCall, Nothing, 10, 10000)
    End Function



    Private Delegate Sub RefreshAlertTimer(ByVal form As Form)
    Public Sub AlertsRefreshUp(state As Object)
        If Me.InvokeRequired Then
            Me.Invoke(New RefreshAlertTimer(AddressOf AlertsRefreshUp), Me)
        Else
            JobRunner_RestFunctions.LoadAlerts()
        End If
    End Sub
    Public Function Create_AlertsRefreshTimer()
        Dim AlertRefreshCall As New System.Threading.TimerCallback(AddressOf AlertsRefreshUp)
        Return New System.Threading.Timer(AlertRefreshCall, Nothing, 10, 10000)
    End Function


    Private Sub tabControlJobsRest_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tabControlJobsRest.SelectedIndexChanged
        Select Case tabControlJobsRest.SelectedTab.Name
            Case tabJobsList.Name
                JobStatusSearchFacetUpdate()

                Me.Width = 830
                JobRefreshTimer = Create_JobRefreshTimer()

            Case tabTasks.Name
                JobRunner_RestFunctions.GetTasks()
                Me.Width = 830
            Case tabProjects.Name
                ProjSearchFacetUpdate()

                Me.Width = 830
            Case tabAlerts.Name
                JobRunner_RestFunctions.LoadAlerts()
                Me.Width = 830
                AlertsRefreshTimer = Create_AlertsRefreshTimer()
            Case tabScriptManagement.Name
                JobRunner_RestFunctions.GetScriptList()
                Me.Width = 830
        End Select


    End Sub


    Private Sub btnBackFromEndpointStatus_Click(sender As Object, e As EventArgs) Handles btnBackFromEndpointStatus.Click
        splitEndpointStatus.SendToBack()
    End Sub


    Private Sub dgvEndpointStatusJobTargets_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEndpointStatusJobTargets.CellClick
        Try
            If e.RowIndex > -1 Then
                Dim id = dgvEndpointStatusJobTargets.Rows.Item(e.RowIndex).Cells(4).Value.ToString
                Dim status = dgvEndpointStatusJobTargets.Rows.Item(e.RowIndex).Cells(2).Value.ToString
                Dim actionbutton = dgvEndpointStatusJobTargets.Rows.Item(e.RowIndex).Cells(5).Value.ToString
                Select Case e.ColumnIndex

                    Case 5 'Cancel
                        If actionbutton = "Cancel" Then
                            Dim cancellist As New List(Of String)
                            cancellist.Add(id)
                            JobRunner_RestFunctions.CancelJobTarget(cancellist)
                            JobRunner_RestFunctions.GetJobTargets(JobsEndpointStatus)
                        End If
                    Case 6 'Review
                        Process.Start("https://" & txtServer.Text & "/" & My.Settings.websitepath & "/#/reviewpage?ShowAgentPivot=false&ShowJobPivot=false&JobTargetResultID=" & id)

                End Select
            End If
        Catch ex As Exception
            DebugWriteLine(ex.Message)
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgvEndpointStatusJobTargets_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEndpointStatusJobTargets.CellContentClick

    End Sub

    Private Sub tabMenu_Selecting(sender As Object, e As TabControlCancelEventArgs) Handles tabMenu.Selecting
        btnSaveSettings_Click(e, e)
        lblJobStatus.Text = ""

        If tabMenu.SelectedTab.Name = tabRESTUI.Name Then
            If RestClient.IsAuthenticated = False Then
                JobRunner_RestFunctions.FEPAuthenticate()
            End If
            If RestClient.IsAuthenticated Then
                JobStatusSearchFacetUpdate()
                JobRefreshTimer = Create_JobRefreshTimer()
                tabControlJobsRest.SelectedTab = tabJobsList
                Me.Width = 830
            End If
        End If
        If tabMenu.SelectedTab.Name = tabJobExecution.Name Then
            tabSubMenu.SelectedTab = tabJobInfo
        End If
    End Sub

    Private Sub btnViewProjectReview_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub txtSearchEndpointStatus_TextChanged(sender As Object, e As EventArgs) Handles txtSearchEndpointStatus.TextChanged

    End Sub
    Private Sub txtSearchEndpointStatus_Enter(sender As Object, e As EventArgs) Handles txtSearchEndpointStatus.Enter
        If txtSearchEndpointStatus.Text = "Search" Then
            txtSearchEndpointStatus.Text = ""
        End If
    End Sub

    Private Sub txtSearchEndpointStatus_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearchEndpointStatus.KeyDown
        Dim x As TextBox = sender
        If e.KeyCode = Keys.Enter Then
            Select Case x.Text
                Case "Search"
                    JobRunner_RestFunctions.GetJobTargets(JobsEndpointStatus)
                Case vbNullString
                    JobRunner_RestFunctions.GetJobTargets(JobsEndpointStatus)
                Case Else
                    Dim facsearch As New Facet.FacetSearch
                    facsearch.SearchAny.Add(x.Text)
                    JobRunner_RestFunctions.GetJobTargets(JobsEndpointStatus, facsearch)
            End Select

        End If
    End Sub



    Private Sub txtSearchEndpointStatus_Leave(sender As Object, e As EventArgs) Handles txtSearchEndpointStatus.Leave
        If txtSearchEndpointStatus.Text = "" Then
            txtSearchEndpointStatus.Text = "Search"
        End If
    End Sub

    Private Sub rdoep_CheckedChanged(sender As Object, e As EventArgs) Handles rdoendpoint.CheckedChanged
        Select Case rdoendpoint.Checked
            Case True
                chkRestAPI.Enabled = True
        End Select
    End Sub

    Private Sub chkRestAPI_CheckedChanged(sender As Object, e As EventArgs) Handles chkRestAPI.CheckedChanged
        Select Case chkRestAPI.Checked
            Case True '----Checked SHOW RESTUI
                Select Case tabMenu.TabPages.Contains(tabRESTUI)
                    Case True
                    Case False
                        tabMenu.TabPages.Insert(1, tabRESTUI)
                End Select
            Case False '---Unchecked HIDE RESTUI
                Select Case tabMenu.TabPages.Contains(tabRESTUI)
                    Case True
                        tabMenu.TabPages.Remove(tabRESTUI)
                        If Not JobRefreshTimer Is Nothing Then
                            JobRefreshTimer.Change(Timeout.Infinite, Timeout.Infinite)
                        End If
                        If Not AlertsRefreshTimer Is Nothing Then
                            AlertsRefreshTimer.Change(Timeout.Infinite, Timeout.Infinite)
                        End If
                    Case False
                        If Not JobRefreshTimer Is Nothing Then
                            JobRefreshTimer.Change(Timeout.Infinite, Timeout.Infinite)
                        End If
                        If Not AlertsRefreshTimer Is Nothing Then
                            AlertsRefreshTimer.Change(Timeout.Infinite, Timeout.Infinite)
                        End If
                End Select
        End Select
    End Sub


    Private Sub btnLoadDefaultTemplateName_Click(sender As Object, e As EventArgs) Handles btnLoadDefaultTemplateName.Click



        If chkRestAPI.Checked = True Then
            JobRunner_RestFunctions.FEPAuthenticate()

            JobRunner_RestFunctions.GetJobTemplates()

            txtDefaultTemplateName.Items.Clear()
            Dim tempitems(txtTemplateName.Items.Count - 1)
            txtTemplateName.Items.CopyTo(tempitems, 0)
            txtDefaultTemplateName.Items.AddRange(tempitems)
            If My.Settings.templatenameselect <> "" Then
                If txtDefaultTemplateName.Items.Contains(My.Settings.templatenameselect) Then
                    txtDefaultTemplateName.SelectedItem = My.Settings.templatenameselect
                Else
                    txtDefaultTemplateName.Items.Add(My.Settings.templatenameselect)
                    txtDefaultTemplateName.SelectedItem = My.Settings.templatenameselect
                End If
            Else
                txtDefaultTemplateName.SelectedIndex = 0
            End If

        Else
            txtDefaultTemplateName.Items.Clear()
            txtDefaultTemplateName.Items.Add("coll-evtx")
            If My.Settings.templatenameselect <> "" Then
                If txtDefaultTemplateName.Items.Contains(My.Settings.templatenameselect) Then
                    txtDefaultTemplateName.SelectedItem = My.Settings.templatenameselect
                Else
                    txtDefaultTemplateName.Items.Add(My.Settings.templatenameselect)
                    txtDefaultTemplateName.SelectedItem = My.Settings.templatenameselect
                End If
            Else
                txtDefaultTemplateName.SelectedIndex = 0
            End If

        End If
    End Sub

   

    Private Sub btnExecute_Click(sender As Object, e As EventArgs) Handles btnExecute.Click
        ResetStatusBar()
        If Not String.IsNullOrWhiteSpace(txtJobName.Text) Then
            If lstComputerTargets.Items.Count > 0 Or lstNetShare.Items.Count > 0 Then
                'Set label color and text
                lblJobStatus.Text = "Submitting Job..."
                'Get Computers
                Dim cnames(lstComputerTargets.Items.Count - 1) As String
                lstComputerTargets.Items.CopyTo(cnames, 0)
                If lstComputerTargets.Items.Count < 1 Then cnames = Jobs.nullstring

                'Get Shares
                Dim snames(lstNetShare.Items.Count - 1) As String
                lstNetShare.Items.CopyTo(snames, 0)
                If lstNetShare.Items.Count < 1 Then snames = Jobs.nullstring

                'API Limitation, choose agent or shares
                If snames.Length >= 1 And cnames.Length >= 1 Then
                    Dim result As DialogResult = Form_AgentorShareDialog.ShowDialog()

                    'Choose Agent
                    If result = DialogResult.OK Then
                        'Null shares
                        snames = Jobs.nullstring

                        'Choose Shares
                    ElseIf result = DialogResult.Cancel Then
                        'Null computers
                        cnames = Jobs.nullstring
                    End If
                End If


                'Generate Inclusion/Exclusion Filters
                Dim filter As String = Jobs.BuildFilterJSON(StoreInFiltList, StoreExFiltList)
                'Dim filter As String = Jobs.CreateFilter

                'Set Job Template
                Dim templatename As String
                If txtTemplateName.Text <> "" Then
                    templatename = txtTemplateName.Text
                Else
                    'If it isn't set use the default
                    templatename = "coll-evtx"
                End If

                'Agent Remediation - Send File
                Dim remediatesendfile() As FEP_Job_Runner.JobsService.ArrayOfJobOptionsOperationsAgentRemediationSendFileJobOptionsOperationsAgentRemediationSendFile = StoreRemSendList.toarray


                'Agent Remediation - Erase File
                Dim remediateerase() As FEP_Job_Runner.JobsService.ArrayOfJobOptionsOperationsAgentRemediationEraseJobOptionsOperationsAgentRemediationErase = StoreRemDelList.toarray


                'Agent Remediation - Execute
                Dim remediateexecute() As FEP_Job_Runner.JobsService.ArrayOfJobOptionsOperationsAgentRemediationExecuteJobOptionsOperationsAgentRemediationExecute = StoreRemExecList.toarray


                'Agent Remediation - Kill by PID
                Dim pids() As String = New String() {}
                Dim pidlist As List(Of String) = StoreRemKillIDList
                For Each item In pidlist
                    pids.Add(item)
                Next


                'Agent Remediation - Kill by Process Name
                Dim processnames() As String = New String() {}
                Dim pnamelist As List(Of String) = StoreRemKillNameList
                For Each item In pnamelist
                    processnames.Add(item)
                Next

                'Kick off the job
                DebugWriteLine("Executing Job")
                Jobs.RunFromTemplateName(txtServer.Text, templatename, txtJobName.Text, txtProjectName.Text, txtApiUser.Text, ToInsecureString(apipass), cnames, snames, filter, pids, processnames, remediatesendfile, remediateexecute, remediateerase)
            Else
                MsgBox("At least one computer or share target must be added.")
            End If
        Else
            MsgBox("Job name required.")
        End If
    End Sub

    Private Sub btnAddComputer_Click(sender As Object, e As EventArgs) Handles btnAddComputer.Click
        'Add hostname to list box
        If Not String.IsNullOrWhiteSpace(txtComputerTarget.Text) Then
            If Not lstComputerTargets.Items.Contains(txtComputerTarget.Text) Then
                lstComputerTargets.Items.Add(txtComputerTarget.Text)
                txtComputerTarget.Text = ""
            End If
        End If
    End Sub

    Private Sub btnRemoveComputer_Click(sender As Object, e As EventArgs) Handles btnRemoveComputer.Click
        'Remove checked items from listbox
        With lstComputerTargets
            If .CheckedItems.Count > 0 Then
                For checked As Integer = .CheckedItems.Count - 1 To 0 Step -1
                    .Items.Remove(.CheckedItems(checked))
                Next
            End If
        End With
    End Sub

    Private Sub btnAddNetShare_Click(sender As Object, e As EventArgs) Handles btnAddNetShare.Click
        'Add path to listbox
        If Not String.IsNullOrWhiteSpace(txtNetSharePath.Text) Then
            If Not lstNetShare.Items.Contains(txtNetSharePath.Text) Then
                lstNetShare.Items.Add(txtNetSharePath.Text)
                txtNetSharePath.Text = ""
            End If
        End If
    End Sub

    Private Sub btnRemoveNetShare_Click(sender As Object, e As EventArgs) Handles btnRemoveNetShare.Click
        'Remove checked items from listbox
        With lstNetShare
            If .CheckedItems.Count > 0 Then
                For checked As Integer = .CheckedItems.Count - 1 To 0 Step -1
                    .Items.Remove(.CheckedItems(checked))
                Next
            End If
        End With
    End Sub

    Private Sub tabPANW_Click(sender As Object, e As EventArgs) Handles tabPANW.Click

    End Sub

    Private Sub txtXPSMalwareMD5_Leave(sender As Object, e As EventArgs) Handles txtXPSMalwareMD5.Leave
        If String.IsNullOrWhiteSpace(txtXPSMalwareMD5.Text) Then
            txtXPSMalwareMD5.Text = "47f9fdc617f8c98a6732be534d8dbe9a"
        End If
    End Sub

    Private Sub txtXPSMalwareMD5_TextChanged(sender As Object, e As EventArgs) Handles txtXPSMalwareMD5.TextChanged

    End Sub

    Private Sub txtPANWMalwareMD5_Leave(sender As Object, e As EventArgs) Handles txtPANWMalwareMD5.Leave
        If String.IsNullOrWhiteSpace(txtPANWMalwareMD5.Text) Then
            txtPANWMalwareMD5.Text = "47f9fdc617f8c98a6732be534d8dbe9a"
        End If
    End Sub

    Private Sub txtPANWMalwareMD5_TextChanged(sender As Object, e As EventArgs) Handles txtPANWMalwareMD5.TextChanged

    End Sub

    Private Sub txtFireEyeMalwareMD5_Leave(sender As Object, e As EventArgs) Handles txtFireEyeMalwareMD5.Leave
        If String.IsNullOrWhiteSpace(txtFireEyeMalwareMD5.Text) Then
            txtFireEyeMalwareMD5.Text = "47f9fdc617f8c98a6732be534d8dbe9a"
        End If
    End Sub

    Private Sub txtFireEyeMalwareMD5_TextChanged(sender As Object, e As EventArgs) Handles txtFireEyeMalwareMD5.TextChanged

    End Sub

    Private Sub panw_sim_port_ValueChanged(sender As Object, e As EventArgs) Handles panw_sim_port.ValueChanged
        lblWildFireURL.Text = "https://" & My.Computer.Name & ":" & panw_sim_port.Value
        txtPANWSim.Text = "The Wildfire Sim simulates Resolution1 queries to Wildfire to get malware reports and kick off validated threatscans. After starting the Wildfire Sim, configure the Resolution1 PANW connector as shown below. If Job Runner isn't running on the R1 server, browse to https://" & My.Computer.Name & ":" & panw_sim_port.Value & " on the server and import the certificate to the Local Machine - Trusted Root Certification Authorities Store."
    End Sub

    Private Sub tabXPS_Click(sender As Object, e As EventArgs) Handles tabXPS.Click

    End Sub

    Private Sub xps_sim_Port_ValueChanged(sender As Object, e As EventArgs) Handles xps_sim_Port.ValueChanged
        lblXPSHostname.Text = My.Computer.Name & ":" & xps_sim_Port.Value
        txtXPSSim.Text = "The Network CP Sim simulates Endpoint queries to Network to get malware reports and kick off validated threatscans. After starting the Network CP Sim, configure the FEP Network connector as shown below. If Job Runner isn't running on the FEP server, browse to https://" & My.Computer.Name & ":" & xps_sim_Port.Value & " on the server and import the certificate to the Local Machine - Trusted Root Certification Authorities Store."
    End Sub

    Private Sub Main_RegionChanged(sender As Object, e As EventArgs) Handles Me.RegionChanged

    End Sub

    Private Sub Main_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Select Case tabSubMenu.SelectedTab.Name
            Case tabAgentRemediation.Name
                tabSubMenu.Width = tableAgentRemediation.Width + 10
                tabSubMenu.Height = tableAgentRemediation.Height + 20
            Case tabFilters.Name
                tabSubMenu.Height = tableFilters.Height + 20
                tabSubMenu.Width = tableFilters.Width + 10
            Case tabJobInfo.Name
                tabSubMenu.Height = flowJobInfo.Height + 20
        End Select

    End Sub

    Private Sub flowJobsAPI_Paint(sender As Object, e As PaintEventArgs) Handles flowJobsAPI.Paint

    End Sub

    Private Sub Main_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd

    End Sub

    Private Sub tabSubMenu_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tabSubMenu.SelectedIndexChanged
        Select Case tabSubMenu.SelectedTab.Name
            Case tabAgentRemediation.Name
                tabSubMenu.Width = tableAgentRemediation.Width + 10
                tabSubMenu.Height = tableAgentRemediation.Height + 20
            Case tabFilters.Name
                tabSubMenu.Height = tableFilters.Height + 20
                tabSubMenu.Width = tableFilters.Width + 10
            Case tabJobInfo.Name
                tabSubMenu.Height = flowJobInfo.Height + 20
        End Select
    End Sub

    Private Sub tabSubMenu_Selecting(sender As Object, e As TabControlCancelEventArgs) Handles tabSubMenu.Selecting
        Select Case tabSubMenu.SelectedTab.Name
            Case tabAgentRemediation.Name
                tabSubMenu.Width = tableAgentRemediation.Width + 10
                tabSubMenu.Height = tableAgentRemediation.Height + 20
            Case tabFilters.Name
                tabSubMenu.Height = tableFilters.Height + 20
                tabSubMenu.Width = tableFilters.Width + 10
            Case tabJobInfo.Name
                tabSubMenu.Height = flowJobInfo.Height + 20
        End Select
    End Sub

    Private Sub btnFilters_AddClick(sender As Object, e As EventArgs) Handles btnFilters_Add.Click

        'Select case of the currently active tab
        Select Case tabFiltersSubMenu.SelectedTab.Name
            Case tabInclusionFilter.Name
                If Not String.IsNullOrWhiteSpace(txtinclfiltername.Text) Then
                    'Inclusion Filter tab
                    Dim inclist As List(Of InclusionFilter) = StoreInFiltList
                    'Check for filtername
                    Dim isthere = JobRunner_Functions.CheckInclusionFilterList(txtinclfiltername.Text)
                    If isthere = -1 Then
                        'add new
                        'Add to UI
                        Dim nfilter = dgvFilters.Rows.Add()
                        dgvFilters.Rows(nfilter).Cells(0).Value = False
                        dgvFilters.Rows(nfilter).Cells(1).Value = "Inclusion"
                        dgvFilters.Rows(nfilter).Cells(2).Value = txtinclfiltername.Text

                        'New inclusion filter
                        Dim nfilt As New InclusionFilter
                        'Set properties
                        nfilt.FilterName = txtinclfiltername.Text
                        nfilt.Extensions = txtinclextensions.Text
                        nfilt.IsKeyWordSearch = rdoinclsimplesearch.Checked
                        nfilt.IsRegexSearch = rdoinclregexsearch.Checked
                        nfilt.IsSearchFilenameOnly = chkinclsearchfilename.Checked
                        nfilt.Keywords = txtinclkeywords.Text
                        nfilt.MD5HashsEntryText = txtinclmd5hash.Text
                        nfilt.PathURLContains = txtinclpathcontains.Text
                        'Add item to store
                        inclist.Add(nfilt)
                        'Add item to UI
                        dgvFilters.Rows(nfilter).Selected = True
                    Else
                        'already exists
                        MsgBox("Filter Name Already Exists.")
                    End If
                End If
            Case tabExclusionFilter.Name
                If Not String.IsNullOrWhiteSpace(txtexclfiltername.Text) Then
                    'Exclusion Filter tab
                    Dim exclist As List(Of ExclusionFilter) = StoreExFiltList
                    'Check for filtername
                    Dim isthere = JobRunner_Functions.CheckExclusionFilterList(txtexclfiltername.Text)
                    If isthere = -1 Then
                        'add new
                        'Add to UI
                        Dim exfilter = dgvFilters.Rows.Add()
                        dgvFilters.Rows(exfilter).Cells(0).Value = False
                        dgvFilters.Rows(exfilter).Cells(1).Value = "Exclusion"
                        dgvFilters.Rows(exfilter).Cells(2).Value = txtexclfiltername.Text
                        'New inclusion filter
                        Dim nfilt As New ExclusionFilter
                        'Set properties
                        nfilt.FilterName = txtexclfiltername.Text
                        nfilt.Extensions = txtexclextensions.Text
                        nfilt.MD5HashsEntryText = txtexclmd5hash.Text
                        nfilt.PathURLContains = txtexclpathcontains.Text
                        'Add item to store
                        exclist.Add(nfilt)
                        'Add item to UI
                        dgvFilters.Rows(exfilter).Selected = True
                    Else
                        'already exists
                        MsgBox("Filter Name Already Exists.")
                    End If
                End If
        End Select
    End Sub

    Private Sub btnFilters_Remove_Click(sender As Object, e As EventArgs) Handles btnFilters_Remove.Click
        'Remove checked filters
        For Each filtrow As DataGridViewRow In Me.dgvFilters.Rows
            If filtrow.Cells(0).Value = True Then
                Select Case filtrow.Cells(1).Value
                    Case "Inclusion"
                        Jobs.RemoveItemFromInclusionStore(filtrow.Cells(2).Value)
                    Case "Exclusion"
                        Jobs.RemoveItemFromExclusionStore(filtrow.Cells(2).Value)
                End Select
                dgvFilters.Rows.Remove(filtrow)
            End If
        Next

    End Sub

    Private Sub btnFilters_Save_Click(sender As Object, e As EventArgs) Handles btnFilters_Save.Click
        'Save filter change
        '> 0 selected items
        If dgvFilters.SelectedRows.Count > 0 Then
            Select Case dgvFilters.SelectedRows(0).Cells(1).Value
                Case "Inclusion"
                    'Save Inclusion Filter Changes
                    'Select case of Filter Name
                    Select Case txtinclfiltername.Text
                        'Matches the lstbox still
                        Case dgvFilters.SelectedRows(0).Cells(2).Value
                            'Inclist = store
                            Dim inclist As List(Of InclusionFilter) = StoreInFiltList
                            'Iterate store
                            For Each nfilt In inclist
                                'If the filtername = selected item
                                If nfilt.FilterName = dgvFilters.SelectedRows(0).Cells(2).Value Then
                                    'Update properties
                                    nfilt.FilterName = txtinclfiltername.Text
                                    nfilt.Extensions = txtinclextensions.Text
                                    nfilt.IsKeyWordSearch = rdoinclsimplesearch.Checked
                                    nfilt.IsRegexSearch = rdoinclregexsearch.Checked
                                    nfilt.IsSearchFilenameOnly = chkinclsearchfilename.Checked
                                    nfilt.Keywords = txtinclkeywords.Text
                                    nfilt.MD5HashsEntryText = txtinclmd5hash.Text
                                    nfilt.PathURLContains = txtinclpathcontains.Text
                                End If
                            Next

                        Case Is <> dgvFilters.SelectedRows(0).Cells(2).Value
                            'The filter name was changed
                            'If the list already contains this name - Don't do anything, show a message
                            Dim isthere = JobRunner_Functions.CheckInclusionFilterList(txtinclfiltername.Text)
                            If isthere > -1 Then
                                MsgBox("Filter Name Already Exists. No Changes Made.")
                            Else
                                'The list doesn't contain this item.
                                'Inclist = Store
                                Dim inclist As List(Of InclusionFilter) = StoreInFiltList
                                Dim cnt = 0
                                'Iterate store
                                For Each nfilt In inclist
                                    'Find current item record
                                    If nfilt.FilterName = dgvFilters.SelectedRows(0).Cells(2).Value Then
                                        'Update properties
                                        nfilt.FilterName = txtinclfiltername.Text
                                        nfilt.Extensions = txtinclextensions.Text
                                        nfilt.IsKeyWordSearch = rdoinclsimplesearch.Checked
                                        nfilt.IsRegexSearch = rdoinclregexsearch.Checked
                                        nfilt.IsSearchFilenameOnly = chkinclsearchfilename.Checked
                                        nfilt.Keywords = txtinclkeywords.Text
                                        nfilt.MD5HashsEntryText = txtinclmd5hash.Text
                                        nfilt.PathURLContains = txtinclpathcontains.Text
                                        'Update name in list
                                        dgvFilters.SelectedRows(0).Cells(2).Value = nfilt.FilterName
                                        'Remove old item from UI
                                        dgvFilters.Rows.Remove(dgvFilters.SelectedRows(0))

                                        'Add new item to UI
                                        Dim x = dgvFilters.Rows.Add(False, "Inclusion", nfilt.FilterName)
                                        dgvFilters.Rows(x).Selected = True

                                    End If
                                    cnt += 1
                                Next
                            End If
                    End Select

                Case "Exclusion"
                    'Save Exclusion Filter Changes
                    'Select case of Filter Name
                    Select Case txtexclfiltername.Text
                        'Matches the lstbox still
                        Case dgvFilters.SelectedRows(0).Cells(2).Value
                            'exclist = store
                            Dim exclist As List(Of ExclusionFilter) = StoreExFiltList
                            'Iterate store
                            For Each nfilt In exclist
                                'If the filtername = selected item
                                If nfilt.FilterName = dgvFilters.SelectedRows(0).Cells(2).Value Then
                                    'Update properties
                                    nfilt.FilterName = txtexclfiltername.Text
                                    nfilt.Extensions = txtexclextensions.Text
                                    nfilt.MD5HashsEntryText = txtexclmd5hash.Text
                                    nfilt.PathURLContains = txtexclpathcontains.Text
                                End If
                            Next

                        Case Is <> dgvFilters.SelectedRows(0).Cells(2).Value
                            'The filter name was changed
                            'If the list already contains this name - Don't do anything, show a message
                            Dim isthere = JobRunner_Functions.CheckExclusionFilterList(txtexclfiltername.Text)
                            If isthere > -1 Then
                                MsgBox("Filter Name Already Exists. No Changes Made.")
                            Else
                                'The list doesn't contain this item.
                                'Exclist = Store
                                Dim exclist As List(Of ExclusionFilter) = StoreExFiltList
                                Dim cnt = 0
                                'Iterate store
                                For Each nfilt In exclist
                                    'Find current item record
                                    If nfilt.FilterName = dgvFilters.SelectedRows(0).Cells(2).Value Then
                                        'Update properties
                                        nfilt.FilterName = txtexclfiltername.Text
                                        nfilt.Extensions = txtexclextensions.Text
                                        nfilt.MD5HashsEntryText = txtexclmd5hash.Text
                                        nfilt.PathURLContains = txtexclpathcontains.Text
                                        'Update name in list
                                        dgvFilters.SelectedRows(0).Cells(2).Value = nfilt.FilterName
                                        'Remove old item from UI
                                        dgvFilters.Rows.Remove(dgvFilters.SelectedRows(0))

                                        'Add new item to UI
                                        Dim x = dgvFilters.Rows.Add(False, "Exclusion", nfilt.FilterName)
                                        dgvFilters.Rows(x).Selected = True

                                    End If
                                    cnt += 1
                                Next
                            End If
                    End Select
            End Select
        End If


    End Sub

    Private Sub dgvFilters_SelectionChanged(sender As Object, e As EventArgs) Handles dgvFilters.SelectionChanged
        'Selected filter changed - switch to the relevant tab and load the filter from the store
        'Check if selected items > 0
        If dgvFilters.SelectedRows.Count > 0 Then
            'Select case of filter type
            Select Case dgvFilters.SelectedRows(0).Cells(1).Value
                Case "Inclusion"
                    tabFiltersSubMenu.SelectedTab = tabInclusionFilter
                    Dim filtitem = JobRunner_Functions.CheckInclusionFilterList(dgvFilters.SelectedRows(0).Cells(2).Value)
                    Dim incllist As List(Of InclusionFilter) = StoreInFiltList
                    Dim getfiltitem = incllist(filtitem)
                    txtinclfiltername.Text = getfiltitem.FilterName
                    txtinclextensions.Text = getfiltitem.Extensions
                    rdoinclsimplesearch.Checked = getfiltitem.IsKeyWordSearch
                    rdoinclregexsearch.Checked = getfiltitem.IsRegexSearch
                    chkinclsearchfilename.Checked = getfiltitem.IsSearchFilenameOnly
                    txtinclkeywords.Text = getfiltitem.Keywords
                    txtinclmd5hash.Text = getfiltitem.MD5HashsEntryText
                    txtinclpathcontains.Text = getfiltitem.PathURLContains
                    dgvFilters.Focus()
                Case "Exclusion"
                    tabFiltersSubMenu.SelectedTab = tabExclusionFilter
                    Dim filtitem = JobRunner_Functions.CheckExclusionFilterList(dgvFilters.SelectedRows(0).Cells(2).Value)
                    Dim excllist As List(Of ExclusionFilter) = StoreExFiltList
                    Dim getfiltitem = excllist(filtitem)
                    txtexclfiltername.Text = getfiltitem.FilterName
                    txtexclextensions.Text = getfiltitem.Extensions
                    txtexclmd5hash.Text = getfiltitem.MD5HashsEntryText
                    txtexclpathcontains.Text = getfiltitem.PathURLContains
                    dgvFilters.Focus()
            End Select
        End If
    End Sub

    Private Sub tabInclusionFilter_Enter(sender As Object, e As EventArgs) Handles tabInclusionFilter.Enter
        tabFiltersSubMenu.Width = tableFilters.Width
    End Sub

    Private Sub tabExclusionFilter_Enter(sender As Object, e As EventArgs) Handles tabExclusionFilter.Enter
        tabFiltersSubMenu.Width = tableFilters.Width
    End Sub

    Private Sub tabExclusionFilter_Resize(sender As Object, e As EventArgs) Handles tabExclusionFilter.Resize

    End Sub

    Private Sub flowPANW_Paint(sender As Object, e As PaintEventArgs) Handles flowPANW.Paint

    End Sub

    Private Sub btnSavePowershell_Click(sender As Object, e As EventArgs) Handles btnSavePowershell.Click
        'Copying the execute code to be used for this to speed dev time

        ResetStatusBar()
        If Not IO.Directory.Exists(My.Application.Info.DirectoryPath & "\PowerShell") Then IO.Directory.CreateDirectory(My.Application.Info.DirectoryPath & "\PowerShell")

        sfdPowerShell.InitialDirectory = My.Application.Info.DirectoryPath & "\PowerShell"
        If sfdPowerShell.ShowDialog() = 1 Then
            Try



                If Not String.IsNullOrWhiteSpace(txtJobName.Text) Then
                    If lstComputerTargets.Items.Count > 0 Or lstNetShare.Items.Count > 0 Then
                        'Set label color and text
                        ' lblJobStatus.Text = "Submitting Job..."
                        'Get Computers
                        Dim cnames(lstComputerTargets.Items.Count - 1) As String
                        lstComputerTargets.Items.CopyTo(cnames, 0)
                        If lstComputerTargets.Items.Count < 1 Then cnames = Jobs.nullstring

                        'Get Shares
                        Dim snames(lstNetShare.Items.Count - 1) As String
                        lstNetShare.Items.CopyTo(snames, 0)
                        If lstNetShare.Items.Count < 1 Then snames = Jobs.nullstring

                        'API Limitation, choose agent or shares
                        If snames.Length >= 1 And cnames.Length >= 1 Then
                            Dim result As DialogResult = Form_AgentorShareDialog.ShowDialog()

                            'Choose Agent
                            If result = DialogResult.OK Then
                                'Null shares
                                snames = Jobs.nullstring

                                'Choose Shares
                            ElseIf result = DialogResult.Cancel Then
                                'Null computers
                                cnames = Jobs.nullstring
                            End If
                        End If


                        'Generate Inclusion/Exclusion Filters
                        Dim filter As String = Jobs.BuildFilterJSON(StoreInFiltList, StoreExFiltList)
                        'Dim filter As String = Jobs.CreateFilter

                        'Set Job Template
                        Dim templatename As String
                        If txtTemplateName.Text <> "" Then
                            templatename = txtTemplateName.Text
                        Else
                            'If it isn't set use the default
                            templatename = "coll-evtx"
                        End If

                        'Agent Remediation - Send File
                        Dim remediatesendfile() As FEP_Job_Runner.JobsService.ArrayOfJobOptionsOperationsAgentRemediationSendFileJobOptionsOperationsAgentRemediationSendFile = StoreRemSendList.toarray
                        For Each item In remediatesendfile
                            Debug.WriteLine(item)
                        Next

                        'Agent Remediation - Erase File
                        Dim remediateerase() As FEP_Job_Runner.JobsService.ArrayOfJobOptionsOperationsAgentRemediationEraseJobOptionsOperationsAgentRemediationErase = StoreRemDelList.toarray


                        'Agent Remediation - Execute
                        Dim remediateexecute() As FEP_Job_Runner.JobsService.ArrayOfJobOptionsOperationsAgentRemediationExecuteJobOptionsOperationsAgentRemediationExecute = StoreRemExecList.toarray


                        'Agent Remediation - Kill by PID
                        Dim pids() As String = New String() {}
                        Dim pidlist As List(Of String) = StoreRemKillIDList
                        For Each item In pidlist
                            pids.Add(item)
                        Next


                        'Agent Remediation - Kill by Process Name
                        Dim processnames() As String = New String() {}
                        Dim pnamelist As List(Of String) = StoreRemKillNameList
                        For Each item In pnamelist
                            processnames.Add(item)
                        Next

                        'Write the PS1 File
                        Dim psfile As System.IO.StreamWriter
                        psfile = My.Computer.FileSystem.OpenTextFileWriter(sfdPowerShell.FileName, False)
                        If chkbypasscerts.Checked = True Then
                            psfile.WriteLine("#Ignore Bad Certs")
                            psfile.WriteLine("[System.Net.ServicePointManager]::ServerCertificateValidationCallback = {$true}")
                        End If
                        psfile.WriteLine("#Service URI")
                        psfile.WriteLine("$Service = New-WebServiceProxy -uri https://" & txtServer.Text & "/" & My.Settings.websitepath & "/services/api/JobsService.asmx?wsdl")
                        psfile.WriteLine("$type = $Service.GetType().Namespace")
                        psfile.WriteLine()
                        psfile.WriteLine("#Main Config")
                        psfile.WriteLine("#----------------------------------------------")
                        psfile.WriteLine("$TemplateName = """ & templatename & """")
                        psfile.WriteLine("$JobName = """ & txtJobName.Text & """")
                        If Not String.IsNullOrWhiteSpace(txtProjectName.Text) Then
                            psfile.WriteLine("$ProjectName = """ & txtProjectName.Text & """")
                        Else
                            psfile.WriteLine("$ProjectName = $null")
                        End If
                        psfile.WriteLine("$APIUsername = """ & txtApiUser.Text & """")
                        psfile.WriteLine("$APIPassword = """ & ToInsecureString(apipass) & """")
                        If cnames.Count > 0 Then
                            psfile.Write("$Computers = """)
                            psfile.Write(String.Join(""",""", cnames))
                            psfile.Write("""")
                            psfile.WriteLine()
                        Else
                            psfile.Write("$Computers = $null")
                        End If
                        If snames.Count > 0 Then
                            psfile.Write("$Shares = """)
                            psfile.Write(String.Join(""",""", snames))
                            psfile.Write("""")
                            psfile.WriteLine()
                        Else
                            psfile.WriteLine("$Shares = $null")
                        End If
                        If pids.Count > 0 Then
                            psfile.Write("$PIDs = """)
                            psfile.Write(String.Join(""",""", pids))
                            psfile.Write("""")
                            psfile.WriteLine()
                        Else
                            psfile.WriteLine("$PIDs = $null")
                        End If
                        If processnames.Count > 0 Then
                            psfile.Write("$ProcessNames = """)
                            psfile.Write(String.Join(""",""", processnames))
                            psfile.Write("""")
                            psfile.WriteLine()
                        Else
                            psfile.WriteLine("$ProcessNames = $null")
                        End If
                        psfile.WriteLine("$moduleID = ""ISModuleArcSight""")
                        psfile.WriteLine("$thirdPartyJobId = ""00000000-0000-0000-0000-000000000000""")
                        psfile.WriteLine("$integrationInfo = ""Job Runner""")
                        psfile.WriteLine("#----------------------------------------------")
                        psfile.WriteLine("#End Main Config")
                        psfile.WriteLine()

                        If remediatesendfile.Count > 0 Then
                            psfile.WriteLine("#SendFileOptions")
                            psfile.WriteLine("$OptionsSendFile = ($type + '.ArrayOfJobOptionsOperationsAgentRemediationSendFileJobOptionsOperationsAgentRemediationSendFile')")
                            psfile.WriteLine("$SendFileOptions = @()")
                            For i = 0 To remediatesendfile.Count - 1
                                psfile.WriteLine("#Start - SendFileOption - " & i)
                                psfile.WriteLine("#----------------------------------------------")
                                psfile.WriteLine("$send" & i & " = New-Object ($OptionsSendFile)")
                                psfile.WriteLine("$send" & i & ".FileToSend = """ & remediatesendfile(i).FileToSend & """")
                                psfile.WriteLine("$send" & i & ".RemotePath = """ & remediatesendfile(i).RemotePath & """")
                                psfile.WriteLine("$send" & i & ".IsRelative = """ & remediatesendfile(i).IsRelative & """")
                                psfile.WriteLine("$send" & i & ".OverwriteIfExists = """ & remediatesendfile(i).OverwriteIfExists & """")
                                psfile.WriteLine("$SendFileOptions += $send" & i)
                                psfile.WriteLine("#----------------------------------------------")
                                psfile.WriteLine("#End - SendFileOption - " & i)
                                psfile.WriteLine()
                            Next
                        Else
                            psfile.WriteLine("$SendFileOptions = $null")
                        End If
                        psfile.WriteLine()
                        If remediateexecute.Count > 0 Then
                            psfile.WriteLine("#ExecuteFileOptions")
                            psfile.WriteLine("$OptionsExecute = ($type + '.ArrayOfJobOptionsOperationsAgentRemediationExecuteJobOptionsOperationsAgentRemediationExecute')")
                            psfile.WriteLine("$ExecuteOptions = @()")
                            For i = 0 To remediateexecute.Count - 1
                                psfile.WriteLine("#Start - ExecuteOption - " & i)
                                psfile.WriteLine("#----------------------------------------------")
                                psfile.WriteLine("$exec" & i & " = New-Object ($OptionsExecute)")
                                psfile.WriteLine("$exec" & i & ".Executable = """ & remediateexecute(i).Executable & """")
                                psfile.WriteLine("$exec" & i & ".Arguments = """ & remediateexecute(i).Arguments & """")
                                psfile.WriteLine("$ExecuteOptions += $exec" & i)
                                psfile.WriteLine("#----------------------------------------------")
                                psfile.WriteLine("#End - ExecuteOption - " & i)
                                psfile.WriteLine()
                            Next
                        Else
                            psfile.WriteLine("$ExecuteOptions = $null")
                        End If
                        psfile.WriteLine()
                        If remediateerase.Count > 0 Then
                            psfile.WriteLine("#EraseFileOptions")
                            psfile.WriteLine("$OptionsErase = ($type + '.ArrayOfJobOptionsOperationsAgentRemediationEraseJobOptionsOperationsAgentRemediationErase')")
                            psfile.WriteLine("$EraseOptions = @()")
                            For i = 0 To remediateerase.Count - 1
                                psfile.WriteLine("#Start - EraseOption - " & i)
                                psfile.WriteLine("#----------------------------------------------")
                                psfile.WriteLine("$erase" & i & " = New-Object ($OptionsErase)")
                                psfile.WriteLine("$erase" & i & ".RemotePath = """ & remediateerase(i).RemotePath & """")
                                psfile.WriteLine("$erase" & i & ".IsRelative = """ & remediateerase(i).IsRelative & """")
                                psfile.WriteLine("$erase" & i & ".Wipe = """ & remediateerase(i).Wipe & """")
                                psfile.WriteLine("$EraseOptions += $erase" & i)
                                psfile.WriteLine("#----------------------------------------------")
                                psfile.WriteLine("#End - EraseOption - " & i)
                                psfile.WriteLine()
                            Next
                        Else
                            psfile.WriteLine("$EraseOptions = $null")
                        End If
                        psfile.WriteLine()
                        psfile.WriteLine("#Execute Job")
                        psfile.WriteLine("$Service.RunJobFromTemplateName($TemplateName, $JobName, $ProjectName, $APIUsername, $APIPassword,")
                        psfile.WriteLine("$Computers, $Shares, $PIDs, $ProcessNames, $SendFileOptions, $ExecuteOptions, $EraseOptions,")

                        If cnames.Count > 0 Then
                            psfile.WriteLine("""" & filter.Replace("""", "'") & """, $null,")
                        ElseIf snames.Count > 0 Then
                            psfile.WriteLine("$null,""" & filter.Replace("""", "'") & """,")
                        Else
                            psfile.WriteLine("$null, $null,")
                        End If

                        psfile.WriteLine("$moduleID, $thirdPartyJobId, $integrationInfo)")

                        psfile.Close()
                        DebugWriteLine("Powershell file written to " & sfdPowerShell.FileName)
                        MsgBox("Powershell file written to " & sfdPowerShell.FileName)
                    Else
                        MsgBox("At least one computer or share target must be added.")
                    End If
                Else
                    MsgBox("Job name required.")
                End If
            Catch ex As Exception
                DebugWriteLine(ex.Message)
            End Try
        End If
    End Sub

    Public Shared Sub projsearchmenu_Click(sender As Object, e As ToolStripItemClickedEventArgs)
        Dim tmpitem = Main.lvProjectFacets.Items.Add(e.ClickedItem.OwnerItem.Text & ":" & e.ClickedItem.Tag)
        tmpitem.tag = e.ClickedItem.OwnerItem.Tag
        ProjSearchFacetUpdate()
    End Sub
    Public Shared Sub projsearchmenu_txtEnter(sender As Object, e As KeyEventArgs)
        Dim x As ToolStripTextBox = sender
        If e.KeyCode = Keys.Enter Then
            Select Case x.Text
                Case "Search"
                Case vbNullString
                Case Else
                    Dim tmpitem = Main.lvProjectFacets.Items.Add("Any:" & x.Text)
                    ProjSearchFacetUpdate()
            End Select
        End If

    End Sub
 
    Public Shared Sub jobsearchmenu_txtEnter(sender As Object, e As KeyEventArgs)
        Dim x As ToolStripTextBox = sender
        If e.KeyCode = Keys.Enter Then
            Select Case x.Text
                Case "Search"
                Case vbNullString
                Case Else
                    Dim tmpitem = Main.lvJobStatusFacets.Items.Add("Any:" & x.Text)
                    JobStatusSearchFacetUpdate()
            End Select
        End If
    End Sub
 

    Public Shared Sub jobsearchmenu_Click(sender As Object, e As ToolStripItemClickedEventArgs)

        Dim tmpitem = Main.lvJobStatusFacets.Items.Add(e.ClickedItem.OwnerItem.Text & ":" & e.ClickedItem.Tag)
        tmpitem.tag = e.ClickedItem.OwnerItem.Tag
        JobStatusSearchFacetUpdate()

    End Sub


    Private Sub tabProjects_Enter(sender As Object, e As EventArgs) Handles tabProjects.Enter
        projsearchmenu = JobRunner_RestFunctions.GetProjectFacets
        lvProjectFacets.ContextMenuStrip = projsearchmenu
    End Sub

    Private Sub tabJobsList_Enter(sender As Object, e As EventArgs) Handles tabJobsList.Enter
        jobstatussearchmenu = JobRunner_RestFunctions.GetJobFacets
        lvJobStatusFacets.ContextMenuStrip = jobstatussearchmenu
    End Sub

    Private Sub chkbypasscerts_CheckedChanged(sender As Object, e As EventArgs) Handles chkbypasscerts.CheckedChanged
        If chkbypasscerts.Checked = True Then
            RestClient.IgnoreSSL = True
        Else
            RestClient.IgnoreSSL = False
        End If

    End Sub

    Private Sub txtAPIPass_Leave(sender As Object, e As EventArgs) Handles txtAPIPass.Leave
        btnSaveSettings_Click(e, e)

    End Sub

    Private Sub txtServer_Leave(sender As Object, e As EventArgs) Handles txtServer.Leave
        btnSaveSettings_Click(e, e)
    End Sub

    Private Sub txtApiUser_Leave(sender As Object, e As EventArgs) Handles txtApiUser.Leave
        btnSaveSettings_Click(e, e)
    End Sub

    Private Sub chkRestAPI_Leave(sender As Object, e As EventArgs) Handles chkRestAPI.Leave
        btnSaveSettings_Click(e, e)
    End Sub

   
 
    Private Sub lvProjectFacets_DoubleClick(sender As Object, e As EventArgs) Handles lvProjectFacets.DoubleClick
        For Each item In lvProjectFacets.SelectedItems
            lvProjectFacets.Items.Remove(item)
        Next
        ProjSearchFacetUpdate()
    End Sub


    Private Sub NewProjectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewProjectToolStripMenuItem.Click
        Dim projectcreate As New Form_CreateEditProject("Create Project", True)
        projectcreate.ShowDialog()
        JobRunner_RestFunctions.GetProjectList()
    End Sub

    Private Sub EditProjectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditProjectToolStripMenuItem.Click
        Dim projectedit As New Form_CreateEditProject("Edit Project", False, dgvProjectList.CurrentRow.Cells(5).Value)
        projectedit.ShowDialog()
        JobRunner_RestFunctions.GetProjectList()
    End Sub

    Private Sub DeleteProjectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteProjectToolStripMenuItem.Click
        If MsgBox("Delete Project " & dgvProjectList.CurrentRow.Cells(0).Value & "?", MsgBoxStyle.YesNoCancel, "Delete Project?") = MsgBoxResult.Yes Then
            JobRunner_RestFunctions.DeleteProject(dgvProjectList.CurrentRow.Cells(5).Value)
        End If
    End Sub

    Private Sub ViewProjectInReviewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewProjectInReviewToolStripMenuItem.Click
        Dim projectid = dgvProjectList.CurrentRow.Cells(5).Value
        Process.Start("https://" & txtServer.Text & "/" & My.Settings.websitepath & "/#/reviewpage?projectid=" & projectid)
    End Sub

  
    Private Sub dgvProjectList_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvProjectList.CellMouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            If Not e.RowIndex = -1 Then
                dgvProjectList.Rows.Item(e.RowIndex).Selected = True
                cms_Project.Show(MousePosition)
            End If
        End If
    End Sub

    
    Private Sub dgvJobsRestJobsList_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvJobsRestJobsList.CellMouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            If Not e.RowIndex = -1 Then
                dgvJobsRestJobsList.Rows.Item(e.RowIndex).Selected = True
                Select Case dgvJobsRestJobsList.Rows.Item(e.RowIndex).Cells("jobType").Value
                    Case "Agent Script"
                        cms_JobStatus.Items("ResultToolStripMenuItem").Enabled = True
                    Case Else
                        cms_JobStatus.Items("ResultToolStripMenuItem").Enabled = True
                End Select

                Select Case dgvJobsRestJobsList.Rows.Item(e.RowIndex).Cells("jobStatus").Value
                    Case "Running"
                        cms_JobStatus.Items("CancelJobToolStripMenuItem").Enabled = True
                    Case Else
                        cms_JobStatus.Items("CancelJobToolStripMenuItem").Enabled = False
                End Select


                cms_JobStatus.Show(MousePosition)
            End If
        End If
    End Sub

   
    Private Sub EndpointStatusToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EndpointStatusToolStripMenuItem.Click

        JobsEndpointStatus = dgvJobsRestJobsList.SelectedRows(0).Cells("jobResultID").Value
        If JobsEndpointStatus <> "" Then
        JobRunner_RestFunctions.GetEndpointStatusCounts(JobsEndpointStatus)
        JobRunner_RestFunctions.GetJobTargets(JobsEndpointStatus)
        JobEndpointRefreshTimer = Create_JobEndpointRefreshTimer()
        splitEndpointStatus.BringToFront()
        End If
    End Sub

    Private Sub ResultToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResultToolStripMenuItem.Click
        Dim resultid = dgvJobsRestJobsList.SelectedRows(0).Cells("jobResultID").Value
        If dgvJobsRestJobsList.SelectedRows(0).Cells("jobType").Value = "Agent Script" Then
            Dim jobresultscript As New Form_ScriptJobResults(resultid)
            jobresultscript.Show()
        Else
            Process.Start("https://" & txtServer.Text & "/endpoint/#/reviewpage?JobResultID=" & resultid & "&ShowAgentPivot=false&ShowJobPivot=false")

        End If
    End Sub

    Private Sub CancelJobToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CancelJobToolStripMenuItem.Click
        Dim resultid = dgvJobsRestJobsList.SelectedRows(0).Cells("jobResultID").Value
        JobRunner_RestFunctions.CancelJob(resultid, True)

    End Sub

    Private Sub RetryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RetryToolStripMenuItem.Click
        Dim jobName = dgvJobsRestJobsList.SelectedRows(0).Cells("jobName").Value
        Dim jobID = dgvJobsRestJobsList.SelectedRows(0).Cells("jobID").Value

        JobRunner_RestFunctions.RetryJob(jobID, jobName & " Retry")
    End Sub

    Private Sub lvJobStatusFacets_DoubleClick(sender As Object, e As EventArgs) Handles lvJobStatusFacets.DoubleClick
        For Each item In lvJobStatusFacets.SelectedItems
            lvJobStatusFacets.Items.Remove(item)
        Next
        JobStatusSearchFacetUpdate()
    End Sub

    Private Sub DownloadToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DownloadToolStripMenuItem.Click
        Process.Start("https://" & txtServer.Text & "/Endpoint/Handlers/ScriptPackageDownload.ashx?PackageId=" & dgvScriptManagementList.SelectedRows(0).Cells("scriptID").Value)
    End Sub

    Private Sub dgvScriptManagementList_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvScriptManagementList.CellMouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            If Not e.RowIndex = -1 Then
                dgvScriptManagementList.Rows.Item(e.RowIndex).Selected = True
                cms_ScriptManage.Show(MousePosition)
            End If
        End If
    End Sub

    Private Sub DownloadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        Dim c = MsgBox("Are you sure you want to delete the script: " & dgvScriptManagementList.SelectedRows(0).Cells("scriptName").Value & "?", MsgBoxStyle.YesNo, "Delete Script?")
        If c = MsgBoxResult.Yes Then
            Dim x = RestClient.Functions.ScriptPackages.DeletePackage(dgvScriptManagementList.SelectedRows(0).Cells("scriptID").Value)
            If x.Success = True Then
                JobRunner_RestFunctions.GetScriptList()
            Else
                MsgBox(x.Error.Message)
            End If
        End If
    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click
        Dim scEdit As New Form_CreateEditScript("Edit Script", False, dgvScriptManagementList.SelectedRows(0).Cells("scriptID").Value)
        scEdit.ShowDialog()
    End Sub

    Private Sub NewScriptMenuItem_Click(sender As Object, e As EventArgs) Handles NewScriptMenuItem.Click
        Dim scCreate As New Form_CreateEditScript("Create Script", True, "")
        scCreate.ShowDialog()
    End Sub


End Class