﻿Imports System.Net
Imports System.Security
Imports System.Runtime.InteropServices
Imports R1SimpleRestClient.Models.Response


Public Class Main

    Public auth As New R1SimpleRestClient.Models.Response.AuthToken

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




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnExecute.Click
        ResetStatusBar()
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
        Dim remediatesendfile() As R1_Job_Runner.JobsService.ArrayOfJobOptionsOperationsAgentRemediationSendFileJobOptionsOperationsAgentRemediationSendFile = StoreRemSendList.toarray


        'Agent Remediation - Erase File
        Dim remediateerase() As R1_Job_Runner.JobsService.ArrayOfJobOptionsOperationsAgentRemediationEraseJobOptionsOperationsAgentRemediationErase = StoreRemDelList.toarray


        'Agent Remediation - Execute
        Dim remediateexecute() As R1_Job_Runner.JobsService.ArrayOfJobOptionsOperationsAgentRemediationExecuteJobOptionsOperationsAgentRemediationExecute = StoreRemExecList.toarray


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
        Jobs.RunFromTemplateName(txtServer.Text, templatename, txtJobName.Text, txtProjectName.Text, txtApiUser.Text, ToInsecureString(apipass), cnames, snames, filter, pids, processnames, remediatesendfile, remediateexecute, remediateerase)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnAddComputer.Click
        'Add hostname to list box
        If txtComputerTarget.Text <> "" Then
            lstComputerTargets.Items.Add(txtComputerTarget.Text)
            txtComputerTarget.Text = ""
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnRemoveComputer.Click
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
        If txtNetSharePath.Text <> "" Then
            lstNetShare.Items.Add(txtNetSharePath.Text)
            txtNetSharePath.Text = ""
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

    Private Sub Main_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        'Try
        '    IO.File.Delete("Newtonsoft.Json.dll")
        'Catch ex As Exception
        '    Debug.WriteLine(ex.Message)
        'End Try
    End Sub



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            'Put JSON.Newtonsoft Down
            Dim b As Byte() = My.Resources.Newtonsoft_Json
            IO.File.WriteAllBytes("Newtonsoft.Json.dll", b)
        Catch ex As Exception
        End Try


        'First Run-Generate default templates
        Me.Text = "R1 Job Runner Version: " & My.Application.Info.Version.ToString
        If My.Settings.firstrun = True Or My.Settings.templatename Is Nothing Then
            'Set templates
            My.Settings.templatename.Clear()
            My.Settings.templatename.Add("coll-evtx")


            'Set Blank Password
            My.Settings.apipassword = EncryptString(ToSecureString(""))

            'Updates on
            My.Settings.updatecheck = True


            'Turn first run off
            My.Settings.firstrun = False
            My.Settings.Save()
        End If

        'End First Run



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
        If Not String.IsNullOrWhiteSpace(My.Settings.apipassword) Then
            apipass = DecryptString(My.Settings.apipassword)
            txtAPIPass.Text = apipass.ToString
        Else
            apipass = ToSecureString("")
            txtAPIPass.Text = apipass.ToString
        End If
        txtApiUser.Text = My.Settings.apiusername
        txtDefaultJobName.Text = My.Settings.jobname
        txtJobName.Text = txtDefaultJobName.Text
        txtServer.Text = My.Settings.webserver
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
        If websitepath = "ADG.Map.Web" Then
            rdoadgmap.Checked = True
            rdor1.Checked = False
            rdocustom.Checked = False
        ElseIf websitepath = "R1" Then
            rdoadgmap.Checked = False
            rdor1.Checked = True
            rdocustom.Checked = False
        Else
            rdocustom.Checked = True
            rdor1.Checked = False
            rdoadgmap.Checked = False
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
                CheckForUpdates(True)
            Catch ex As Exception
            End Try
        End If
        Me.auth = New R1SimpleRestClient.Models.Response.AuthToken

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

        'Save Settings to my.settings
        My.Settings.bypasscert = chkbypasscerts.Checked
        My.Settings.defaultcomputer = txtdefaultcomputer.Text
        My.Settings.defaultshare = txtdefaultshare.Text
        If Not My.Settings.apiusername = txtApiUser.Text Then
            My.Settings.apiusername = txtApiUser.Text
            Me.auth = New AuthToken
        End If
        'My.Settings.apipassword = txtAPIPass.Text
        'My.Settings.apipassword = EncryptString(ToSecureString(txtAPIPass.Text))
        If Not txtAPIPass.Text = apipass.ToString Then
            Dim ppass = MsgBox("Save New Password?", MsgBoxStyle.YesNo, "Save Password")
            If ppass = MsgBoxResult.Yes Then
                My.Settings.apipassword = EncryptString(ToSecureString(txtAPIPass.Text))
                Me.apipass = DecryptString(My.Settings.apipassword)
                txtAPIPass.Text = apipass.ToString
                Me.auth = New AuthToken
            Else
                txtAPIPass.Text = apipass.ToString
            End If
        End If
        My.Settings.jobname = txtDefaultJobName.Text
        My.Settings.projectname = txtDefaultProjectName.Text
        If Not My.Settings.webserver = txtServer.Text Then
            My.Settings.webserver = txtServer.Text
            Me.auth = New AuthToken
        End If
        My.Settings.templatename.Clear()
        For Each item In txtDefaultTemplateName.Items
            My.Settings.templatename.Add(item.ToString)
        Next
        My.Settings.templatenameselect = txtDefaultTemplateName.Text
        If rdoadgmap.Checked = True Then
            My.Settings.websitepath = "ADG.Map.Web"
        ElseIf rdor1.Checked = True Then
            My.Settings.websitepath = "R1"
        Else
            My.Settings.websitepath = txtcustomwebaddress.Text
        End If

        My.Settings.updatecheck = chkUpdates.Checked

        My.Settings.Save()
        txtStatusSettings.Text = "Settings Saved"
    End Sub


    Private Sub tabSettings_Enter(sender As Object, e As EventArgs) Handles tabSettings.Enter
        'Clear the text when the tab is entered
        txtAPIPass.Text = apipass.ToString
        txtStatusSettings.Text = ""
    End Sub



    Private Sub btnSaveAsBox_Click(sender As Object, e As EventArgs) Handles btnSaveAsBox.Click
        ResetStatusBar()
        'Save Boxed Job
        'Show the Save File Dialog
        sfdBox.InitialDirectory = My.Application.Info.DirectoryPath & "\BoxedJobs"
        If sfdBox.ShowDialog() = 1 Then
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
            Dim ar_send() As R1_Job_Runner.JobsService.ArrayOfJobOptionsOperationsAgentRemediationSendFileJobOptionsOperationsAgentRemediationSendFile = StoreRemSendList.toarray
            sbox.R1_AR_Send = ar_send

            'Execute Options
            Dim ar_exec() As R1_Job_Runner.JobsService.ArrayOfJobOptionsOperationsAgentRemediationExecuteJobOptionsOperationsAgentRemediationExecute = StoreRemExecList.toarray
            sbox.R1_AR_Execute = ar_exec

            'Erase Options
            Dim ar_erase() As R1_Job_Runner.JobsService.ArrayOfJobOptionsOperationsAgentRemediationEraseJobOptionsOperationsAgentRemediationErase = StoreRemDelList.toarray
            sbox.R1_AR_Erase = ar_erase

            'Filters
            sbox.R1Filter = Jobs.BuildFilterJSON(StoreInFiltList, StoreExFiltList)

            'Save Job
            BoxedJobs.SaveBoxedJob(sfdBox.FileName, sbox)
        End If
    End Sub

    Private Sub btnLoadFromBox_Click(sender As Object, e As EventArgs) Handles btnLoadFromBox.Click
        ResetStatusBar()
        ofdBox.ShowDialog()
        Dim fname = ofdBox.FileName

        'If File Exists
        If IO.File.Exists(fname) Then
            'Clear the controls on every tab, form.
            ClearAllJobOptioons(Me.tabJobInfo.Controls)
            ClearAllJobOptioons(Me.tabFilters.Controls)
            ClearAllJobOptioons(Me.tabInclusionFilter.Controls)
            ClearAllJobOptioons(Me.tabExclusionFilter.Controls)
            ClearAllJobOptioons(Me.tabAgentDelete.Controls)
            ClearAllJobOptioons(Me.tabAgentExecute.Controls)
            ClearAllJobOptioons(Me.TabAgentKill.Controls)
            ClearAllJobOptioons(Me.tabAgentSendFile.Controls)
            ClearAllJobOptioons(Me.splitInclusion.Panel1.Controls)
            ClearAllJobOptioons(Me.splitInclusion.Panel2.Controls)
            ClearAllJobOptioons(Me.SplitExclusion.Panel1.Controls)
            ClearAllJobOptioons(Me.SplitExclusion.Panel2.Controls)
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
                    lstboxinclusionfilters.Items.Add(item.FilterName)
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
                    lstboxexclusionfilters.Items.Add(item.FilterName)
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

            'File Doesn't Exists
        Else
            MsgBox("File Doesn't Exist")
        End If

    End Sub

    Private Sub btnAddInclFilterToList_Click(sender As Object, e As EventArgs) Handles btnAddInclFilterToList.Click
        'Add inclusion filter to list
        'If name already exists
        If lstboxinclusionfilters.Items.Contains(txtinclfiltername.Text) Then
            MsgBox("Filter Name Already Exists.")
        Else
            'Name doesn't exists
            'Inclist = Store
            Dim inclist As List(Of InclusionFilter) = StoreInFiltList
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
            lstboxinclusionfilters.Items.Add(nfilt.FilterName)
        End If
    End Sub

    Private Sub btnRemoveInclFilterfromList_Click(sender As Object, e As EventArgs) Handles btnRemoveInclFilterfromList.Click
        'Remove checked inclusion filter items from listbox
        With lstboxinclusionfilters
            '> 0 items checked
            If .CheckedItems.Count > 0 Then
                'inlst = Store
                Dim inlst As List(Of InclusionFilter) = StoreInFiltList
                'Iterate backwards max to min
                For checked As Integer = .CheckedItems.Count - 1 To 0 Step -1
                    'Remove from Store
                    Jobs.RemoveItemFromInclusionStore(.CheckedItems(checked))
                    'Remove from UI
                    .Items.Remove(.CheckedItems(checked))
                Next
            End If
        End With
    End Sub

    Private Sub lstboxinclusionfilters_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstboxinclusionfilters.SelectedIndexChanged
        'Load the selected filter to the UI

        'inclist = Store
        Dim inclist As List(Of InclusionFilter) = StoreInFiltList
        'Iterate store
        For Each item In inclist
            'Match the name - this should be unique
            If item.FilterName = lstboxinclusionfilters.SelectedItem Then
                'Matched! - Set the controls to the filter
                txtinclfiltername.Text = item.FilterName
                txtinclextensions.Text = item.Extensions
                rdoinclsimplesearch.Checked = item.IsKeyWordSearch
                rdoinclregexsearch.Checked = item.IsRegexSearch
                chkinclsearchfilename.Checked = item.IsSearchFilenameOnly
                txtinclkeywords.Text = item.Keywords
                txtinclmd5hash.Text = item.MD5HashsEntryText
                txtinclpathcontains.Text = item.PathURLContains
            End If
        Next
    End Sub

    Private Sub btnSaveIncFilterChanges_Click(sender As Object, e As EventArgs) Handles btnSaveIncFilterChanges.Click
        'Save Inclusion Filter Changes

        'Select case of Filter Name
        Select Case txtinclfiltername.Text
            'Matches the lstbox still
            Case lstboxinclusionfilters.SelectedItem
                'Inclist = store
                Dim inclist As List(Of InclusionFilter) = StoreInFiltList
                'Iterate store
                For Each nfilt In inclist
                    'If the filtername = selected item
                    If nfilt.FilterName = lstboxinclusionfilters.SelectedItem Then
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

            Case Is <> lstboxinclusionfilters.SelectedItem
                'The filter name was changed
                'If the list already contains this name - Don't do anything, show a message
                If lstboxinclusionfilters.Items.Contains(txtinclfiltername.Text) Then
                    MsgBox("Filter Name Already Exists. No Changes Made.")
                Else
                    'The list doesn't contain this item.
                    'Inclist = Store
                    Dim inclist As List(Of InclusionFilter) = StoreInFiltList
                    'Iterate store
                    For Each nfilt In inclist
                        'Find current item record
                        If nfilt.FilterName = lstboxinclusionfilters.SelectedItem Then
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
                            lstboxinclusionfilters.SelectedItem = nfilt.FilterName
                            'Remove old item from UI
                            lstboxinclusionfilters.Items.Remove(lstboxinclusionfilters.SelectedItem)
                            'Add new item to UI
                            lstboxinclusionfilters.Items.Add(nfilt.FilterName)
                        End If
                    Next
                End If
        End Select

    End Sub

    Private Sub btnaddexclusionfiltertolist_Click(sender As Object, e As EventArgs) Handles btnaddexclusionfiltertolist.Click
        'Add exclusion filter to listbox
        'Check if the name is already in the list
        If lstboxexclusionfilters.Items.Contains(txtexclfiltername.Text) Then
            'Already exists. Display message stop.
            MsgBox("Filter Name Already Exists.")
        Else
            'Doesn't exist
            'exclist = Store
            Dim exclist As List(Of ExclusionFilter) = StoreExFiltList
            'New Exclusion Filter
            Dim nfilt As New ExclusionFilter
            'Set Properties
            nfilt.FilterName = txtexclfiltername.Text
            nfilt.Extensions = txtexclextensions.Text
            nfilt.MD5HashsEntryText = txtexclmd5hash.Text
            nfilt.PathURLContains = txtexclpathcontains.Text
            'Add to Store
            exclist.Add(nfilt)
            'Add to UI
            lstboxexclusionfilters.Items.Add(nfilt.FilterName)
        End If
    End Sub

    Private Sub btnsaveexclusionfilterchanges_Click(sender As Object, e As EventArgs) Handles btnsaveexclusionfilterchanges.Click
        'Save exclusion filter changes

        'Select case of filter name
        Select Case txtinclfiltername.Text
            Case lstboxinclusionfilters.SelectedItem
                'No change to the filter name
                'exclist = store
                Dim exclist As List(Of ExclusionFilter) = StoreExFiltList
                'iterate store
                For Each nfilt In exclist
                    'Find item that matches filter name
                    If nfilt.FilterName = lstboxexclusionfilters.SelectedItem Then
                        'Update properties
                        nfilt.FilterName = txtexclfiltername.Text
                        nfilt.Extensions = txtexclextensions.Text
                        nfilt.MD5HashsEntryText = txtexclmd5hash.Text
                        nfilt.PathURLContains = txtexclpathcontains.Text
                    End If
                Next
            Case Is <> lstboxinclusionfilters.SelectedItem
                'The filter name was updated
                'Check if the filter name already exists
                If lstboxinclusionfilters.Items.Contains(txtinclfiltername.Text) Then
                    'It does...Display message.
                    MsgBox("Filter Name Already Exists. No Changes Made.")
                Else
                    'It doesn't exist
                    'exclist = store
                    Dim exclist As List(Of ExclusionFilter) = StoreExFiltList
                    'Iterate store
                    For Each nfilt In exclist
                        'Find item that matches old filter name
                        If nfilt.FilterName = lstboxexclusionfilters.SelectedItem Then
                            'Update properties
                            nfilt.FilterName = txtexclfiltername.Text
                            nfilt.Extensions = txtexclextensions.Text
                            nfilt.MD5HashsEntryText = txtexclmd5hash.Text
                            nfilt.PathURLContains = txtexclpathcontains.Text
                            'Update name in list
                            lstboxexclusionfilters.SelectedItem = nfilt.FilterName
                            'Remove old filter
                            lstboxexclusionfilters.Items.Remove(lstboxexclusionfilters.SelectedItem)
                            'Add updated filter
                            lstboxexclusionfilters.Items.Add(nfilt.FilterName)
                        End If
                    Next
                End If
        End Select
    End Sub

    Private Sub btnremoveexclusionfilterfromlist_Click(sender As Object, e As EventArgs) Handles btnremoveexclusionfilterfromlist.Click
        'Remove checked items from listbox
        With lstboxexclusionfilters
            '> 0 items checked
            If .CheckedItems.Count > 0 Then
                'Iterate backwards from max to min
                For checked As Integer = .CheckedItems.Count - 1 To 0 Step -1
                    'Remove item from store
                    Jobs.RemoveItemFromExclusionStore(.CheckedItems(checked))
                    'Remove item from UI
                    .Items.Remove(.CheckedItems(checked))
                Next
            End If
        End With
    End Sub

    Private Sub lstboxexclusionfilters_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstboxexclusionfilters.SelectedIndexChanged
        'Load the selected exclusion filter to the UI
        'exclist = Store
        Dim exclist As List(Of ExclusionFilter) = StoreExFiltList
        'Iterate store
        For Each item In exclist
            'Filtername matches
            If item.FilterName = lstboxexclusionfilters.SelectedItem Then
                'Load properties to UI
                txtexclfiltername.Text = item.FilterName
                txtexclextensions.Text = item.Extensions
                txtexclmd5hash.Text = item.MD5HashsEntryText
                txtexclpathcontains.Text = item.PathURLContains
            End If
        Next
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

            Case tabAgentExecute.Name
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

            Case tabAgentDelete.Name
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

            Case TabAgentKill.Name
                'Kill process tab. We split the name and ids so we check which was set here. (We only allow one per add-radio buttons)
                If txtremkillprocname.Text <> "" Then
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
            Dim fevent As FireEye.FireEye_Event = FireEye.GenerateFEEvent(cmbFEAlertType.Text)
            'If the MD5 provided isnt blank, use it. Otherwise it defaults to the FETest MD5.
            If Not String.IsNullOrWhiteSpace(txtFireEyeMalwareMD5.Text) Then
                fevent.alert.explanation.malwaredetected.malware.md5sum = Me.txtFireEyeMalwareMD5.Text
            End If
            FireEye.SendEvent(FireEye.FEventtoJson(fevent))
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        End Try
    End Sub

    Private Sub btnPANWSend_Click(sender As Object, e As EventArgs) Handles btnPANWSend.Click
        Try
            ResetStatusBar()
            Dim panwthreat As New PANW.PANWThreat
            panwthreat.P8Destination_IP = txtPANWTarget.Text
            panwthreat.P4Subtype = cmbPANWAlert.Text.ToLower
            If Not String.IsNullOrWhiteSpace(txtPANWMalwareMD5.Text) Then
                panwthreat.P43Filedigest = txtPANWMalwareMD5.Text
            End If
            Dim panwtstr As String = PANW.ThreatTOCSV(panwthreat)
            PANW.SendEvent(panwtstr)
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        End Try
    End Sub

    Private Sub tabMenu_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tabMenu.SelectedIndexChanged

     
    End Sub


    Private Sub tabFireEye_Enter(sender As Object, e As EventArgs) Handles tabFireEye.Enter
        cmbFEAlertType.SelectedIndex = 0
    End Sub

    Private Sub tabPANW_Enter(sender As Object, e As EventArgs) Handles tabPANW.Enter
        cmbPANWAlert.SelectedIndex = 0
        Dim panwsimtxt As String = "The Wildfire Sim simulates R1 queries to Wildfire to get malware reports and kick off validated threatscans. The Wildfire Sim defaults to port 8449, and requires elevated privileges to place an SSL certificate in the keystore for https communication. After starting the Wildfire Sim, configure the R1 XPS connector to point to https://" & My.Computer.Name & ":8449. The Wildfire Sim will accept any API Key."
        txtPANWSim.Text = panwsimtxt
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

            XPS.SendEvent(xpststr)

        Catch Ex As Exception
            Debug.WriteLine(Ex.Message)
        End Try
    End Sub



    Private Sub tabXPS_Enter(sender As Object, e As EventArgs) Handles tabXPS.Enter
        cmbXPSSeverity.SelectedItem = "Critical"
        Dim xpsimtxt As String = "The XPS CP Sim simulates R1 queries to XPS to get malware reports and kick off validated threatscans. The XPS CP Sim defaults to port 8448, and requires elevated privileges to place an SSL certificate in the keystore for https communication. After starting the XPS CP Sim, configure the R1 XPS connector to point to " & My.Computer.Name & ":8448. The XPS CP Sim will accept any username/password combination as long as they are not the same."
        txtXPSSIM.Text = xpsimtxt
    End Sub

    Private Sub btnStartXPSListener_Click(sender As Object, e As EventArgs) Handles btnStartXPSListener.Click
        Select Case btnStartXPSListener.Text
            Case "Start XPS CP Sim"
                Try
                    btnStartXPSListener.Text = "Stop XPS CP Sim"
                    lbldemoxpsstatus.Text = "XPS CP Sim Status: Started"
                    xps_sim_Port.Enabled = False
                    xps_sim_var = New XPS.XPS_Sim
                    xps_sim_var.Start()
                Catch ex As Exception
                    Debug.WriteLine(ex.Message)
                End Try
            Case "Stop XPS CP Sim"
                Try
                    xps_sim_var.Stop()
                    btnStartXPSListener.Text = "Start XPS CP Sim"
                    lbldemoxpsstatus.Text = "XPS CP Sim Status: Not Started"
                    xps_sim_Port.Enabled = True
                Catch ex As Exception
                    Debug.WriteLine(ex.Message)
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
                    panw_sim_var.Start()
                Catch ex As Exception
                    Debug.WriteLine(ex.Message)
                End Try
            Case "Stop Wildfire Sim"
                Try
                    panw_sim_var.Stop()
                    btn_WildfireStart.Text = "Start Wildfire Sim"
                    lblwildfirestatus.Text = "Wildfire Sim Status: Not Started"
                    panw_sim_port.Enabled = True

                Catch ex As Exception
                    Debug.WriteLine(ex.Message)
                End Try
        End Select

    End Sub


    Private Sub TextBox4_Click(sender As Object, e As EventArgs) Handles TextBox4.Click
        Dim sinfo As New ProcessStartInfo(txtFELink.Text)
        Process.Start(sinfo)
    End Sub

    Private Sub btnUpdateCheck(sender As Object, e As EventArgs) Handles btn_CheckForUpdates.Click
        Try
            CheckForUpdates(False)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            CheckForUpdates(False)
        Catch ex As Exception
        End Try
    End Sub



    Private Sub tabJobExecution_Enter(sender As Object, e As EventArgs) Handles tabJobExecution.Enter

        Dim authobj = JobRunner_RestFunctions.R1Auth
        If authobj.Data.Message = "Authenticated" Then

            JobRunner_RestFunctions.GetJobTemplates()

        Else
            MsgBox(authobj.Data.Message)
            tabMenu.SelectedTab = tabSettings
        End If


    End Sub



    Private Sub txtJobsSearch_Enter(sender As Object, e As EventArgs) Handles txtJobsSearch.Enter
        If txtJobsSearch.Text = "Search" Then
            txtJobsSearch.Text = ""
        End If
    End Sub





    Private Sub txtJobsSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtJobsSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            JobRunner_RestFunctions.GetJobList(txtJobsSearch.Text)
        End If
    End Sub


    Private Sub txtJobsSearch_Leave(sender As Object, e As EventArgs) Handles txtJobsSearch.Leave
        If txtJobsSearch.Text = "" Then
            txtJobsSearch.Text = "Search"
        End If
    End Sub



    Private Sub dgvJobsRestJobsList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvJobsRestJobsList.CellClick
        Try
            If e.RowIndex > -1 Then
                Dim jobname = dgvJobsRestJobsList.Rows.Item(e.RowIndex).Cells(0).Value.ToString
                Dim jobid = dgvJobsRestJobsList.Rows.Item(e.RowIndex).Cells(7).Value.ToString
                Dim resultid = dgvJobsRestJobsList.Rows.Item(e.RowIndex).Cells(8).Value.ToString
                Select Case e.ColumnIndex

                    Case 2 'Retry
                        JobRunner_RestFunctions.RetryJob(jobid, jobname & " Retry")

                    Case 3 'Cancel
                        If dgvJobsRestJobsList.Rows.Item(e.RowIndex).Cells(3).Value.ToString = "Cancel" Then
                            JobRunner_RestFunctions.CancelJob(resultid, True)
                        End If

                    Case 9 'EndPoint Status
                        JobsEndpointStatus = resultid
                        If JobsEndpointStatus <> "" Then
                            JobRunner_RestFunctions.GetEndpointStatusCounts(JobsEndpointStatus)
                            JobRunner_RestFunctions.GetJobTargets(JobsEndpointStatus)
                            splitEndpointStatus.BringToFront()
                        End If


                    Case 10 'Result
                        Process.Start("https://" & txtServer.Text & "/r1/#/reviewpage?JobResultID=" & resultid & "&ShowAgentPivot=false&ShowJobPivot=false")
                   
                End Select
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub tabControlJobsRest_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tabControlJobsRest.SelectedIndexChanged
        Select Case tabControlJobsRest.SelectedTab.Name
            Case tabJobsList.Name
                JobRunner_RestFunctions.GetJobList("")

            Case tabTasks.Name
                JobRunner_RestFunctions.GetTasks()

            Case tabProjects.Name
                JobRunner_RestFunctions.GetProjectList("")

            Case tabAlerts.Name
                JobRunner_RestFunctions.LoadAlerts()

        End Select


    End Sub


    Private Sub btnBackFromEndpointStatus_Click(sender As Object, e As EventArgs) Handles btnBackFromEndpointStatus.Click
        splitEndpointStatus.SendToBack()
    End Sub



    Private Sub txtSearchProject_Enter(sender As Object, e As EventArgs) Handles txtSearchProject.Enter
        If txtSearchProject.Text = "Search" Then
            txtSearchProject.Text = ""
        End If
    End Sub

    Private Sub txtSearchProject_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearchProject.KeyDown

        If e.KeyCode = Keys.Enter Then
            JobRunner_RestFunctions.GetProjectList(txtSearchProject.Text)
        End If
    End Sub



    Private Sub txtSearchProject_Leave(sender As Object, e As EventArgs) Handles txtSearchProject.Leave
        If txtSearchProject.Text = "" Then
            txtSearchProject.Text = "Search"
        End If
    End Sub



    Private Sub btnNewProject_Click(sender As Object, e As EventArgs) Handles btnNewProject.Click
        Dim projectcreate As New Form_CreateEditProject("Create Project", True)
        projectcreate.ShowDialog()
        JobRunner_RestFunctions.GetProjectList("")
    End Sub



    Private Sub btnEditProject_Click(sender As Object, e As EventArgs) Handles btnEditProject.Click
        Dim projectedit As New Form_CreateEditProject("Edit Project", False, dgvProjectList.CurrentRow.Cells(5).Value)
        projectedit.ShowDialog()
        JobRunner_RestFunctions.GetProjectList("")
    End Sub

    Private Sub btnDeleteProject_Click(sender As Object, e As EventArgs) Handles btnDeleteProject.Click
        If MsgBox("Delete Project " & dgvProjectList.CurrentRow.Cells(0).Value & "?", MsgBoxStyle.YesNoCancel, "Delete Project?") = MsgBoxResult.Yes Then
            JobRunner_RestFunctions.DeleteProject(dgvProjectList.CurrentRow.Cells(5).Value)
        End If
    End Sub


    Private Sub dgvJobsRestJobsList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvJobsRestJobsList.CellContentClick

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
                        Process.Start("https://" & txtServer.Text & "/r1/#/reviewpage?ShowAgentPivot=false&ShowJobPivot=false&JobTargetResultID=" & id)

                End Select
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgvEndpointStatusJobTargets_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEndpointStatusJobTargets.CellContentClick

    End Sub

    Private Sub tabMenu_Selecting(sender As Object, e As TabControlCancelEventArgs) Handles tabMenu.Selecting
        btnSaveSettings_Click(e, e)
        lblJobStatus.Text = ""

        If tabMenu.SelectedTab.Name = tabRESTUI.Name Then
            Dim authobj = JobRunner_RestFunctions.R1Auth
            If authobj.Data.Message = "Authenticated" Then

                JobRunner_RestFunctions.GetJobList("")
                tabControlJobsRest.SelectedTab = tabJobsList
            Else
                MsgBox(authobj.Data.Message)
                tabMenu.SelectedTab = tabSettings
            End If
        End If
    End Sub

    Private Sub btnViewProjectReview_Click(sender As Object, e As EventArgs) Handles btnViewProjectReview.Click
        Dim projectid = dgvProjectList.CurrentRow.Cells(5).Value
        Process.Start("https://" & txtServer.Text & "/R1/#/reviewpage?projectid=" & projectid)
    End Sub

    Private Sub txtSearchEndpointStatus_TextChanged(sender As Object, e As EventArgs) Handles txtSearchEndpointStatus.TextChanged

    End Sub
    Private Sub txtSearchEndpointStatus_Enter(sender As Object, e As EventArgs) Handles txtSearchEndpointStatus.Enter
        If txtSearchEndpointStatus.Text = "Search" Then
            txtSearchEndpointStatus.Text = ""
        End If
    End Sub

    Private Sub txtSearchEndpointStatus_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearchEndpointStatus.KeyDown

        If e.KeyCode = Keys.Enter Then
            JobRunner_RestFunctions.GetJobTargets(JobsEndpointStatus, txtSearchEndpointStatus.Text)
        End If
    End Sub



    Private Sub txtSearchEndpointStatus_Leave(sender As Object, e As EventArgs) Handles txtSearchEndpointStatus.Leave
        If txtSearchEndpointStatus.Text = "" Then
            txtSearchEndpointStatus.Text = "Search"
        End If
    End Sub
End Class
