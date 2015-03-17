

Public Class Main
    Public StoreInFiltList
    Public StoreExFiltList
    Public StoreRemSendList
    Public StoreRemExecList
    Public StoreRemDelList
    Public StoreRemKillNameList
    Public StoreRemKillIDList


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnExecute.Click
        statuslabel.BackColor = Control.DefaultBackColor
        statuslabel.ForeColor = Color.Black
        statuslabel.Text = "Submitting Job..."
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
            Dim result As DialogResult = AgentorShareDialog.ShowDialog()

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

        'Dim remediatesendfile(0) As R1_Job_Runner.JobsService.ArrayOfJobOptionsOperationsAgentRemediationSendFileJobOptionsOperationsAgentRemediationSendFile
        'If txtremsendsource.Text <> "" Then
        '    'Set options
        '    remediatesendfile(0) = New R1_Job_Runner.JobsService.ArrayOfJobOptionsOperationsAgentRemediationSendFileJobOptionsOperationsAgentRemediationSendFile
        '    remediatesendfile(0).FileToSend = txtremsendsource.Text
        '    remediatesendfile(0).IsRelative = True
        '    remediatesendfile(0).RemotePath = txtremsenddest.Text
        '    remediatesendfile(0).OverwriteIfExists = chkremsenddelete.Checked
        'Else
        '    'Blank options - null it 
        '    remediatesendfile = New R1_Job_Runner.JobsService.ArrayOfJobOptionsOperationsAgentRemediationSendFileJobOptionsOperationsAgentRemediationSendFile() {}
        'End If

        'Agent Remediation - Erase File
        Dim remediateerase() As R1_Job_Runner.JobsService.ArrayOfJobOptionsOperationsAgentRemediationEraseJobOptionsOperationsAgentRemediationErase = StoreRemDelList.toarray
        'Dim remediateerase(0) As R1_Job_Runner.JobsService.ArrayOfJobOptionsOperationsAgentRemediationEraseJobOptionsOperationsAgentRemediationErase
        'If txtremdelfilepath.Text <> "" Then
        '    'Set options
        '    remediateerase(0) = New R1_Job_Runner.JobsService.ArrayOfJobOptionsOperationsAgentRemediationEraseJobOptionsOperationsAgentRemediationErase
        '    remediateerase(0).RemotePath = txtremdelfilepath.Text
        'Else
        '    'Blank options - null it
        '    remediateerase = New R1_Job_Runner.JobsService.ArrayOfJobOptionsOperationsAgentRemediationEraseJobOptionsOperationsAgentRemediationErase() {}
        'End If

        'Agent Remediation - Execute
        Dim remediateexecute() As R1_Job_Runner.JobsService.ArrayOfJobOptionsOperationsAgentRemediationExecuteJobOptionsOperationsAgentRemediationExecute = StoreRemExecList.toarray
        'Dim remediateexecute(0) As R1_Job_Runner.JobsService.ArrayOfJobOptionsOperationsAgentRemediationExecuteJobOptionsOperationsAgentRemediationExecute
        'If txtremexecpath.Text <> "" Then
        '    'Set options
        '    remediateexecute(0) = New R1_Job_Runner.JobsService.ArrayOfJobOptionsOperationsAgentRemediationExecuteJobOptionsOperationsAgentRemediationExecute
        '    remediateexecute(0).Executable = txtremexecpath.Text
        '    remediateexecute(0).Arguments = txtremexecargs.Text
        'Else
        '    'Blank options - null it
        '    remediateexecute = New R1_Job_Runner.JobsService.ArrayOfJobOptionsOperationsAgentRemediationExecuteJobOptionsOperationsAgentRemediationExecute() {}
        'End If

        'Agent Remediation - Kill by PID
        Dim pids() As String = New String() {}
        Dim pidlist As List(Of String) = StoreRemKillIDList
        For Each item In pidlist
            pids.Add(item)
        Next
        'If nmbremkillprocid.Value <> 0 Then
        '    'Set pid
        '    pids(0) = New Integer
        '    pids(0) = nmbremkillprocid.Value
        'Else
        '    'Blank options - null it
        '    pids = New String() {}
        'End If


        'Agent Remediation - Kill by Process Name
        Dim processnames() As String = New String() {}
        Dim pnamelist As List(Of String) = StoreRemKillNameList
        For Each item In pnamelist
            processnames.Add(item)
        Next
        'If txtremkillprocname.Text <> "" Then
        '    processnames(0) = New String(txtremkillprocname.Text)
        'Else
        '    'Blank options - null it
        '    processnames = New String() {}
        'End If

        'Kick off the job
        ' Dim jobid = Jobs.RunFromTemplateName(txtServer.Text, templatename, txtJobName.Text, txtProjectName.Text, txtApiUser.Text, txtAPIPass.Text, cnames, snames, filter, pids, processnames, remediatesendfile, remediateexecute, remediateerase)
        Jobs.RunFromTemplateName(txtServer.Text, templatename, txtJobName.Text, txtProjectName.Text, txtApiUser.Text, txtAPIPass.Text, cnames, snames, filter, pids, processnames, remediatesendfile, remediateexecute, remediateerase)


        ''Check if the returned message is a GUID or Error
        'If isGuid(jobid) Then
        '    'GUID - Job submitted successfully
        '    statuslabel.Text = "Job: " & txtJobName.Text & " in Project: " & txtProjectName.Text & " submitted sucessfully. GUID: " & jobid
        '    statuslabel.ForeColor = Color.Black
        'Else
        '    'Error - Something happened
        '    statuslabel.Text = "Error: " & jobid
        '    statuslabel.ForeColor = Color.Red
        '    MsgBox("Error: " & jobid)
        'End If


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

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        'First Run-Generate default templates

        If My.Settings.firstrun = True Then
            'Set templates
            My.Settings.templatename.Clear()
            My.Settings.templatename.Add("coll-evtx")
            My.Settings.templatename.Add("Drop Process by PID")
            My.Settings.templatename.Add("ETM Relative Time Query")
            My.Settings.templatename.Add("EXE-Metadata-Cerb")
            My.Settings.templatename.Add("Lockdown NIC")
            My.Settings.templatename.Add("LockdownEnableNIC")
            My.Settings.templatename.Add("Memory Acquisition")
            My.Settings.templatename.Add("Memory Analysis")
            My.Settings.templatename.Add("Registry-Autostart")
            My.Settings.templatename.Add("Registry-Full")
            My.Settings.templatename.Add("Remediate-Name")
            My.Settings.templatename.Add("Remediate-PID")
            My.Settings.templatename.Add("Small-exes-Cerb")
            My.Settings.templatename.Add("Software Inventory")
            My.Settings.templatename.Add("Vol-Deep")
            My.Settings.templatename.Add("Vol-Deep-Cerb")
            My.Settings.templatename.Add("Vol-Hidden-Cerb")
            My.Settings.templatename.Add("Vol-Hidden-Injected")
            My.Settings.templatename.Add("Vol-Quick")
            My.Settings.templatename.Add("Vol-Quick-Cerb")
            My.Settings.templatename.Add("Vol-Quick-Sched")
            'Turn first run off
            My.Settings.firstrun = False
            My.Settings.Save()
        End If

        'End First Run
        'Hide Boxed Jobs
        Me.tabMenu.TabPages.Remove(tabBoxedJobs)

        'Set Target to Agent 
        rdoagent.Checked = True
        rdoshare.Checked = False

        'Set PID rdo
        rdoPID.Checked = True

        'Clear status message
        statuslabel.Text = ""
        txtStatusSettings.Text = ""

        'Load Settings
        chkbypasscerts.Checked = My.Settings.bypasscert
        txtdefaultcomputer.Text = My.Settings.defaultcomputer
        txtComputerTarget.Text = txtdefaultcomputer.Text
        txtdefaultshare.Text = My.Settings.defaultshare
        txtNetSharePath.Text = txtdefaultshare.Text
        txtAPIPass.Text = My.Settings.apipassword
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
        txtboxtargetcomputer.Text = txtdefaultcomputer.Text

        StoreInFiltList = New List(Of InclusionFilter)
        StoreExFiltList = New List(Of ExclusionFilter)
        StoreRemDelList = New List(Of JobsService.ArrayOfJobOptionsOperationsAgentRemediationEraseJobOptionsOperationsAgentRemediationErase)
        StoreRemExecList = New List(Of JobsService.ArrayOfJobOptionsOperationsAgentRemediationExecuteJobOptionsOperationsAgentRemediationExecute)
        StoreRemSendList = New List(Of JobsService.ArrayOfJobOptionsOperationsAgentRemediationSendFileJobOptionsOperationsAgentRemediationSendFile)
        StoreRemKillNameList = New List(Of String)
        StoreRemKillIDList = New List(Of String)




    End Sub

    Private Sub rdoagent_CheckedChanged(sender As Object, e As EventArgs) Handles rdoagent.CheckedChanged
        'Agent Radio
        grpagent.Enabled = True
        grpshare.Enabled = False
        rdoshare.Checked = False
    End Sub

    Private Sub rdoshare_CheckedChanged(sender As Object, e As EventArgs) Handles rdoshare.CheckedChanged
        'Share Radio
        grpagent.Enabled = False
        grpshare.Enabled = True
        rdoagent.Checked = False
    End Sub

    Private Sub btnSaveSettings_Click(sender As Object, e As EventArgs) Handles btnSaveSettings.Click
        'Save Settings to my.settings
        My.Settings.bypasscert = chkbypasscerts.Checked
        My.Settings.defaultcomputer = txtdefaultcomputer.Text
        My.Settings.defaultshare = txtdefaultshare.Text
        My.Settings.apiusername = txtApiUser.Text
        My.Settings.apipassword = txtAPIPass.Text
        My.Settings.jobname = txtDefaultJobName.Text
        My.Settings.projectname = txtDefaultProjectName.Text
        My.Settings.webserver = txtServer.Text
        My.Settings.templatename.Clear()
        For Each item In txtDefaultTemplateName.Items
            My.Settings.templatename.Add(item.ToString)
        Next
        My.Settings.templatenameselect = txtDefaultTemplateName.Text
        My.Settings.Save()
        txtStatusSettings.Text = "Settings Saved"
    End Sub

   

    Private Sub TabPage1_Enter(sender As Object, e As EventArgs)


    End Sub

 

    Private Sub tabSettings_Enter(sender As Object, e As EventArgs) Handles tabSettings.Enter
        txtStatusSettings.Text = ""
    End Sub

    Private Sub tabBoxedJobs_Enter(sender As Object, e As EventArgs) Handles tabBoxedJobs.Enter
        'Get box jobs into UI
        txtboxtargetcomputer.Text = txtdefaultcomputer.Text
        Dim boxnames As Dictionary(Of String, String) = GetListofBoxedJobs()
        For Each item In boxnames
            lstBoxedJobs.Items.Add(item.Key & "*" & item.Value)
        Next
    End Sub

    Private Sub btnBoxJobCollection1_Click(sender As Object, e As EventArgs) Handles btnBoxJobCollection1.Click
        '  BoxedJobs.SaveBoxedJob()
        'Dim jobid = BoxedJobs.BoxedJob1(txtServer.Text, txtProjectName.Text, txtApiUser.Text, txtAPIPass.Text, txtboxtargetcomputer.Text)
        Dim bxjob As New BoxedJob
        Dim joblocation() As String = lstBoxedJobs.CheckedItems(0).ToString.Split("*")
        Console.WriteLine("Job Loca: " & joblocation(1))
        bxjob = BoxedJobs.ParseBoxedJobFromFile(joblocation(1).ToString)
        If bxjob.BoxJobName = "" Then MsgBox("BAD")
        MsgBox(bxjob.BoxJobName & " - " & bxjob.R1Filter)
        '' Check if the returned message is a GUID or Error
        'If isGuid(jobid) Then
        '    'GUID - Job submitted successfully
        '    txtStatusBoxJob.Text = "Job submitted sucessfully. GUID: " & jobid
        '    txtStatusBoxJob.ForeColor = Color.Black
        'Else
        '    'Error - Something happened
        '    txtStatusBoxJob.Text = "Error: " & jobid
        '    txtStatusBoxJob.ForeColor = Color.Red
        '    MsgBox("Error: " & jobid)
        'End If

    End Sub

  

    Private Sub btnSaveAsBox_Click(sender As Object, e As EventArgs) Handles btnSaveAsBox.Click
        sfdBox.ShowDialog()
        Dim sbox As New BoxedJob
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
        'Dim ar_send(0) As JobsService.ArrayOfJobOptionsOperationsAgentRemediationSendFileJobOptionsOperationsAgentRemediationSendFile
        'Dim ar_send_0 As New JobsService.ArrayOfJobOptionsOperationsAgentRemediationSendFileJobOptionsOperationsAgentRemediationSendFile
        'ar_send_0.RemotePath = txtremsenddest.Text
        'ar_send_0.FileToSend = txtremsendsource.Text
        'ar_send_0.OverwriteIfExists = chkremsenddelete.Checked
        'ar_send(0) = ar_send_0
        sbox.R1_AR_Send = ar_send
        'Execute Options
        Dim ar_exec() As R1_Job_Runner.JobsService.ArrayOfJobOptionsOperationsAgentRemediationExecuteJobOptionsOperationsAgentRemediationExecute = StoreRemExecList.toarray
        'Dim ar_exec(0) As JobsService.ArrayOfJobOptionsOperationsAgentRemediationExecuteJobOptionsOperationsAgentRemediationExecute
        'Dim ar_exec_0 As New JobsService.ArrayOfJobOptionsOperationsAgentRemediationExecuteJobOptionsOperationsAgentRemediationExecute
        'ar_exec_0.Executable = txtremexecpath.Text
        'ar_exec_0.Arguments = txtremexecargs.Text
        'ar_exec(0) = ar_exec_0
        sbox.R1_AR_Execute = ar_exec
        'Erase Options
        Dim ar_erase() As R1_Job_Runner.JobsService.ArrayOfJobOptionsOperationsAgentRemediationEraseJobOptionsOperationsAgentRemediationErase = StoreRemDelList.toarray
        'Dim ar_erase(0) As JobsService.ArrayOfJobOptionsOperationsAgentRemediationEraseJobOptionsOperationsAgentRemediationErase
        'Dim ar_erase_0 As New JobsService.ArrayOfJobOptionsOperationsAgentRemediationEraseJobOptionsOperationsAgentRemediationErase
        'ar_erase_0.RemotePath = txtremdelfilepath.Text
        'ar_erase(0) = ar_erase_0
        sbox.R1_AR_Erase = ar_erase

        'Filters
        sbox.R1Filter = Jobs.BuildFilterJSON(StoreInFiltList, StoreExFiltList)


        BoxedJobs.SaveBoxedJob(sfdBox.FileName, sbox)
        'BoxedJobs.SaveBoxedJob(bname, txtJobName.Text, txtProjectName.Text, txtTemplateName.Text, Jobs.BuildFilterJSON(in1l, ex1l), New JobsService.ArrayOfJobOptionsOperationsAgentRemediationSendFileJobOptionsOperationsAgentRemediationSendFile() {}, New JobsService.ArrayOfJobOptionsOperationsAgentRemediationExecuteJobOptionsOperationsAgentRemediationExecute() {}, New JobsService.ArrayOfJobOptionsOperationsAgentRemediationEraseJobOptionsOperationsAgentRemediationErase() {}, Jobs.nullstring, Jobs.nullstring)
    End Sub
 
    Private Sub btnLoadFromBox_Click(sender As Object, e As EventArgs) Handles btnLoadFromBox.Click
        ofdBox.ShowDialog()
        Dim fname = ofdBox.FileName
        If IO.File.Exists(fname) Then
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


            Dim box As BoxedJob = BoxedJobs.ParseBoxedJobFromFile(fname)
            txtJobName.Text = box.R1JobName
            txtProjectName.Text = box.R1Project
            txtTemplateName.Text = box.R1Template
            Dim flist As List(Of Object) = Jobs.ParseFilterJSON(box.R1Filter)
            Dim inlist As New List(Of InclusionFilter)
            Dim exlist As New List(Of ExclusionFilter)
            inlist = flist(0)
            exlist = flist(1)
            If inlist.Count > 0 Then
          
                'new variable
                Dim maininlist As List(Of InclusionFilter) = StoreInFiltList
                'iterate in filters
                For Each item As InclusionFilter In inlist
                    maininlist.Add(item)
                Next
           
                For Each item As InclusionFilter In maininlist
                    lstboxinclusionfilters.Items.Add(item.FilterName)
                Next
            End If

            If exlist.Count > 0 Then

                Dim mainexlist As List(Of ExclusionFilter) = StoreExFiltList
                For Each item As ExclusionFilter In exlist
                    mainexlist.Add(item)
                Next
         
                For Each item As ExclusionFilter In mainexlist
                    lstboxexclusionfilters.Items.Add(item.FilterName)
                Next
            End If


            Dim ar_send() As JobsService.ArrayOfJobOptionsOperationsAgentRemediationSendFileJobOptionsOperationsAgentRemediationSendFile
            ar_send = box.R1_AR_Send
            If ar_send.Count > 0 Then

                Dim remsendlst As List(Of JobsService.ArrayOfJobOptionsOperationsAgentRemediationSendFileJobOptionsOperationsAgentRemediationSendFile) = StoreRemSendList
                For Each item In ar_send
                    Dim nrem = lvRemOptions.Items.Add("Send File")
                    nrem.SubItems.Add(remsendlst.Count + 1)
                    remsendlst.Add(item)
                Next

            End If

            Dim ar_exec() As JobsService.ArrayOfJobOptionsOperationsAgentRemediationExecuteJobOptionsOperationsAgentRemediationExecute
            ar_exec = box.R1_AR_Execute
            If ar_exec.Count > 0 Then

                Dim remexeclist As List(Of JobsService.ArrayOfJobOptionsOperationsAgentRemediationExecuteJobOptionsOperationsAgentRemediationExecute) = StoreRemExecList
                For Each item In ar_exec
                    Dim nrem = lvRemOptions.Items.Add("Execute")
                    nrem.SubItems.Add(remexeclist.Count + 1)
                    remexeclist.Add(item)
                Next
            End If

            Dim ar_erase() As JobsService.ArrayOfJobOptionsOperationsAgentRemediationEraseJobOptionsOperationsAgentRemediationErase
            ar_erase = box.R1_AR_Erase
            If ar_erase.Count > 0 Then

                Dim remdelist As List(Of JobsService.ArrayOfJobOptionsOperationsAgentRemediationEraseJobOptionsOperationsAgentRemediationErase) = StoreRemDelList
                For Each item In ar_erase
                    Dim nrem = lvRemOptions.Items.Add("Delete File")
                    nrem.SubItems.Add(remdelist.Count + 1)
                    remdelist.Add(item)
                Next
            End If

            Dim pids() As String = box.R1_AR_PIDS
            If pids.Count > 0 Then

                Dim rempidlist As List(Of String) = StoreRemKillIDList
                For Each item In pids
                    Dim nrem = lvRemOptions.Items.Add("Kill Process ID")
                    nrem.SubItems.Add(rempidlist.Count + 1)
                    rempidlist.Add(item)
                Next
            End If

            Dim processnames() As String = box.R1_AR_ProcessNames
            If processnames.Count > 0 Then

                Dim rempnamelist As List(Of String) = StoreRemKillNameList
                For Each item In processnames
                    Dim nrem = lvRemOptions.Items.Add("Kill Process Name")
                    nrem.SubItems.Add(rempnamelist.Count + 1)
                    rempnamelist.Add(item)
                Next
            End If



        Else
            MsgBox("File Doesn't Exist")
        End If




    End Sub



    Private Sub btnAddInclFilterToList_Click(sender As Object, e As EventArgs) Handles btnAddInclFilterToList.Click
        If lstboxinclusionfilters.Items.Contains(txtinclfiltername.Text) Then
            MsgBox("Filter Name Already Exists.")
        Else
            Dim inclist As List(Of InclusionFilter) = StoreInFiltList
            Dim nfilt As New InclusionFilter
            nfilt.FilterName = txtinclfiltername.Text
            nfilt.Extensions = txtinclextensions.Text
            nfilt.IsKeyWordSearch = rdoinclsimplesearch.Checked
            nfilt.IsRegexSearch = rdoinclregexsearch.Checked
            nfilt.IsSearchFilenameOnly = chkinclsearchfilename.Checked
            nfilt.Keywords = txtinclkeywords.Text
            nfilt.MD5HashsEntryText = txtinclmd5hash.Text
            nfilt.PathURLContains = txtinclpathcontains.Text


            inclist.Add(nfilt)
            lstboxinclusionfilters.Items.Add(nfilt.FilterName)
        End If
    End Sub

    Private Sub btnRemoveInclFilterfromList_Click(sender As Object, e As EventArgs) Handles btnRemoveInclFilterfromList.Click
        'Remove checked items from listbox

        With lstboxinclusionfilters
            If .CheckedItems.Count > 0 Then
                Dim inlst As List(Of InclusionFilter) = StoreInFiltList
                For checked As Integer = .CheckedItems.Count - 1 To 0 Step -1

                    Jobs.RemoveItemFromInclusionStore(.CheckedItems(checked))
                    .Items.Remove(.CheckedItems(checked))
                Next
            End If
        End With
    End Sub

    Private Sub lstboxinclusionfilters_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstboxinclusionfilters.SelectedIndexChanged
        Dim inclist As List(Of InclusionFilter) = StoreInFiltList
        For Each item In inclist
            If item.FilterName = lstboxinclusionfilters.SelectedItem Then
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
        Select Case txtinclfiltername.Text
            Case lstboxinclusionfilters.SelectedItem
                Dim inclist As List(Of InclusionFilter) = StoreInFiltList
                For Each nfilt In inclist
                    If nfilt.FilterName = lstboxinclusionfilters.SelectedItem Then
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
                If lstboxinclusionfilters.Items.Contains(txtinclfiltername.Text) Then
                    MsgBox("Filter Name Already Exists. No Changes Made.")
                Else
                    Dim inclist As List(Of InclusionFilter) = StoreInFiltList
                    For Each nfilt In inclist
                        If nfilt.FilterName = lstboxinclusionfilters.SelectedItem Then
                            nfilt.FilterName = txtinclfiltername.Text
                            nfilt.Extensions = txtinclextensions.Text
                            nfilt.IsKeyWordSearch = rdoinclsimplesearch.Checked
                            nfilt.IsRegexSearch = rdoinclregexsearch.Checked
                            nfilt.IsSearchFilenameOnly = chkinclsearchfilename.Checked
                            nfilt.Keywords = txtinclkeywords.Text
                            nfilt.MD5HashsEntryText = txtinclmd5hash.Text
                            nfilt.PathURLContains = txtinclpathcontains.Text
                            lstboxinclusionfilters.SelectedItem = nfilt.FilterName
                            lstboxinclusionfilters.Items.Remove(lstboxinclusionfilters.SelectedItem)
                            lstboxinclusionfilters.Items.Add(nfilt.FilterName)
                        End If
                    Next
                End If
        End Select
     
    End Sub

    Private Sub btnaddexclusionfiltertolist_Click(sender As Object, e As EventArgs) Handles btnaddexclusionfiltertolist.Click
        If lstboxexclusionfilters.Items.Contains(txtexclfiltername.Text) Then
            MsgBox("Filter Name Already Exists.")
        Else
            Dim exclist As List(Of ExclusionFilter) = StoreExFiltList
            Dim nfilt As New ExclusionFilter
            nfilt.FilterName = txtexclfiltername.Text
            nfilt.Extensions = txtexclextensions.Text
            nfilt.MD5HashsEntryText = txtexclmd5hash.Text
            nfilt.PathURLContains = txtexclpathcontains.Text
            exclist.Add(nfilt)
            lstboxexclusionfilters.Items.Add(nfilt.FilterName)
        End If
    End Sub

    Private Sub btnsaveexclusionfilterchanges_Click(sender As Object, e As EventArgs) Handles btnsaveexclusionfilterchanges.Click
         Select txtinclfiltername.Text
            Case lstboxinclusionfilters.SelectedItem

                Dim exclist As List(Of ExclusionFilter) = StoreExFiltList
                For Each nfilt In exclist
                    If nfilt.FilterName = lstboxexclusionfilters.SelectedItem Then
                        nfilt.FilterName = txtexclfiltername.Text
                        nfilt.Extensions = txtexclextensions.Text

                        nfilt.MD5HashsEntryText = txtexclmd5hash.Text
                        nfilt.PathURLContains = txtexclpathcontains.Text
                    End If
                Next
            Case Is <> lstboxinclusionfilters.SelectedItem
                If lstboxinclusionfilters.Items.Contains(txtinclfiltername.Text) Then
                    MsgBox("Filter Name Already Exists. No Changes Made.")
                Else
                    Dim exclist As List(Of ExclusionFilter) = StoreExFiltList
                    For Each nfilt In exclist
                        If nfilt.FilterName = lstboxexclusionfilters.SelectedItem Then
                            nfilt.FilterName = txtexclfiltername.Text
                            nfilt.Extensions = txtexclextensions.Text

                            nfilt.MD5HashsEntryText = txtexclmd5hash.Text
                            nfilt.PathURLContains = txtexclpathcontains.Text
                            lstboxexclusionfilters.SelectedItem = nfilt.FilterName
                            lstboxexclusionfilters.Items.Remove(lstboxexclusionfilters.SelectedItem)
                            lstboxexclusionfilters.Items.Add(nfilt.FilterName)
                        End If
                    Next
                End If
                    End Select
    End Sub

    Private Sub btnremoveexclusionfilterfromlist_Click(sender As Object, e As EventArgs) Handles btnremoveexclusionfilterfromlist.Click
        'Remove checked items from listbox
        With lstboxexclusionfilters
            If .CheckedItems.Count > 0 Then
                For checked As Integer = .CheckedItems.Count - 1 To 0 Step -1
                    Jobs.RemoveItemFromExclusionStore(.CheckedItems(checked))
                    .Items.Remove(.CheckedItems(checked))
                Next
            End If
        End With
    End Sub

    Private Sub lstboxexclusionfilters_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstboxexclusionfilters.SelectedIndexChanged
        Dim exclist As List(Of ExclusionFilter) = StoreExFiltList
        For Each item In exclist
            If item.FilterName = lstboxexclusionfilters.SelectedItem Then
                txtexclfiltername.Text = item.FilterName
                txtexclextensions.Text = item.Extensions
          
                txtexclmd5hash.Text = item.MD5HashsEntryText
                txtexclpathcontains.Text = item.PathURLContains
            End If
        Next
    End Sub

    
    Private Sub tabJobInfo_Click(sender As Object, e As EventArgs) Handles tabJobInfo.Click
        'Set text boxes to default values from settings
        txtComputerTarget.Text = txtdefaultcomputer.Text
        txtNetSharePath.Text = txtdefaultshare.Text
    End Sub

    Private Sub btnAddRemOption_Click(sender As Object, e As EventArgs) Handles btnAddRemOption.Click
        Select Case tabAgentRemediationSubMenu.SelectedTab.Name
            Case tabAgentSendFile.Name
                Dim remsendlst As List(Of JobsService.ArrayOfJobOptionsOperationsAgentRemediationSendFileJobOptionsOperationsAgentRemediationSendFile) = StoreRemSendList
                Dim nrem = lvRemOptions.Items.Add("Send File")
                nrem.SubItems.Add(remsendlst.Count + 1)
                Dim nremsend As New JobsService.ArrayOfJobOptionsOperationsAgentRemediationSendFileJobOptionsOperationsAgentRemediationSendFile
                nremsend.FileToSend = txtremsendsource.Text
                nremsend.RemotePath = txtremsenddest.Text
                nremsend.OverwriteIfExists = chkremsenddelete.Checked
                remsendlst.Add(nremsend)

            Case tabAgentExecute.Name
                Dim remexeclist As List(Of JobsService.ArrayOfJobOptionsOperationsAgentRemediationExecuteJobOptionsOperationsAgentRemediationExecute) = StoreRemExecList
                Dim nrem = lvRemOptions.Items.Add("Execute")
                nrem.SubItems.Add(remexeclist.Count + 1)
                Dim nremexec As New JobsService.ArrayOfJobOptionsOperationsAgentRemediationExecuteJobOptionsOperationsAgentRemediationExecute
                nremexec.Executable = txtremexecpath.Text
                nremexec.Arguments = txtremexecargs.Text
                remexeclist.Add(nremexec)

            Case tabAgentDelete.Name
                Dim remdellist As List(Of JobsService.ArrayOfJobOptionsOperationsAgentRemediationEraseJobOptionsOperationsAgentRemediationErase) = StoreRemDelList
                Dim nrem = lvRemOptions.Items.Add("Delete File")
                nrem.SubItems.Add(remdellist.Count + 1)
                Dim nremdel As New JobsService.ArrayOfJobOptionsOperationsAgentRemediationEraseJobOptionsOperationsAgentRemediationErase
                nremdel.RemotePath = txtremdelfilepath.Text
                remdellist.Add(nremdel)

            Case TabAgentKill.Name
                If txtremkillprocname.Text <> "" Then
                    Dim remprocnamelist As List(Of String) = StoreRemKillNameList
                    Dim nrem = lvRemOptions.Items.Add("Kill Process Name")
                    nrem.SubItems.Add(remprocnamelist.Count + 1)
                    remprocnamelist.Add(txtremkillprocname.Text)
                End If
                If nmbremkillprocid.Value > 0 Then
                    Dim remprocidlist As List(Of String) = StoreRemKillIDList
                    Dim nrem = lvRemOptions.Items.Add("Kill Process ID")
                    nrem.SubItems.Add(remprocidlist.Count + 1)
                    remprocidlist.Add(nmbremkillprocid.Value)
                End If



        End Select
    End Sub

    Private Sub lvRemOptions_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvRemOptions.SelectedIndexChanged
        If lvRemOptions.SelectedItems.Count > 0 Then
            Select Case lvRemOptions.SelectedItems(0).Text

                Case "Send File"
                    tabAgentRemediationSubMenu.SelectedTab = tabAgentSendFile
                    Dim sflist As List(Of JobsService.ArrayOfJobOptionsOperationsAgentRemediationSendFileJobOptionsOperationsAgentRemediationSendFile) = StoreRemSendList
                    Dim sfi = sflist(lvRemOptions.SelectedItems(0).SubItems(1).Text - 1)
                    txtremsenddest.Text = sfi.RemotePath
                    txtremsendsource.Text = sfi.FileToSend
                    chkremsenddelete.Checked = sfi.OverwriteIfExists
                    lvRemOptions.Focus()
                Case "Delete File"
                    tabAgentRemediationSubMenu.SelectedTab = tabAgentDelete
                    Dim dflist As List(Of JobsService.ArrayOfJobOptionsOperationsAgentRemediationEraseJobOptionsOperationsAgentRemediationErase) = StoreRemDelList
                    Dim dfi = dflist(lvRemOptions.SelectedItems(0).SubItems(1).Text - 1)
                    txtremdelfilepath.Text = dfi.RemotePath
                    lvRemOptions.Focus()
                Case "Execute"
                    tabAgentRemediationSubMenu.SelectedTab = tabAgentExecute
                    Dim xflist As List(Of JobsService.ArrayOfJobOptionsOperationsAgentRemediationExecuteJobOptionsOperationsAgentRemediationExecute) = StoreRemExecList
                    Dim xfi = xflist(lvRemOptions.SelectedItems(0).SubItems(1).Text - 1)
                    txtremexecargs.Text = xfi.Arguments
                    txtremexecpath.Text = xfi.Executable
                    lvRemOptions.Focus()
                Case "Kill Process Name"
                    tabAgentRemediationSubMenu.SelectedTab = TabAgentKill
                    Dim kpnamelist As List(Of String) = StoreRemKillNameList
                    Dim knli = kpnamelist(lvRemOptions.SelectedItems(0).SubItems(1).Text - 1)
                    rdoPName.Checked = True
                    txtremkillprocname.Text = knli
                    nmbremkillprocid.Value = 0
                    lvRemOptions.Focus()
                Case "Kill Process ID"
                    tabAgentRemediationSubMenu.SelectedTab = TabAgentKill
                    Dim kpidlist As List(Of String) = StoreRemKillIDList
                    Dim kidli = kpidlist(lvRemOptions.SelectedItems(0).SubItems(1).Text - 1)
                    rdoPID.Checked = True
                    nmbremkillprocid.Value = kidli
                    txtremkillprocname.Text = ""
                    lvRemOptions.Focus()
            End Select




        End If
    End Sub

    Private Sub btnRemoveRemOption_Click(sender As Object, e As EventArgs) Handles btnRemoveRemOption.Click
        'Remove checked items from listbox
        With lvRemOptions
            If .CheckedItems.Count > 0 Then
                For checked As Integer = .CheckedItems.Count - 1 To 0 Step -1
                    'Remove from Store
                    Jobs.RemoveItemFromRemStores(.CheckedItems.Item(checked))
                  
                    Select Case .CheckedItems.Item(checked).Text

                        Case "Send File"
                            .Items.Remove(.CheckedItems(checked))
                            Dim scount As Integer = 1
                            For i = 0 To lvRemOptions.Items.Count - 1
                                If lvRemOptions.Items.Item(i).Text = "Send File" Then
                                    lvRemOptions.Items.Item(i).SubItems(1).Text = scount
                                    scount += 1
                                End If

                            Next

                        Case "Execute"
                            .Items.Remove(.CheckedItems(checked))
                            Dim xcount As Integer = 1
                            For i = 0 To lvRemOptions.Items.Count - 1
                                If lvRemOptions.Items.Item(i).Text = "Execute" Then
                                    lvRemOptions.Items.Item(i).SubItems(1).Text = xcount
                                    xcount += 1
                                End If


                            Next

                        Case "Delete File"
                            .Items.Remove(.CheckedItems(checked))
                            Dim dcount As Integer = 1
                            For i = 0 To lvRemOptions.Items.Count - 1
                                If lvRemOptions.Items.Item(i).Text = "Delete File" Then
                                    lvRemOptions.Items.Item(i).SubItems(1).Text = dcount
                                    dcount += 1
                                End If

                            Next

                        Case "Kill Process Name"
                            .Items.Remove(.CheckedItems(checked))

                            Dim knamecount As Integer = 1
                            For i = 0 To lvRemOptions.Items.Count - 1
                                If lvRemOptions.Items.Item(i).Text = "Kill Process Name" Then
                                    lvRemOptions.Items.Item(i).SubItems(1).Text = knamecount
                                    knamecount += 1
                                End If

                            Next

                        Case "Kill Process ID"

                            .Items.Remove(.CheckedItems(checked))

                            Dim kidcount As Integer = 1
                            For i = 0 To lvRemOptions.Items.Count - 1
                                If lvRemOptions.Items.Item(i).Text = "Kill Process ID" Then
                                    lvRemOptions.Items.Item(i).SubItems(1).Text = kidcount
                                    kidcount += 1
                                End If

                            Next

                        Case Else
                            Console.WriteLine("ELSE CASE")
                    End Select
                  

                Next
            End If
        End With
    End Sub


    Private Sub btnSaveRemOptionChange_Click(sender As Object, e As EventArgs) Handles btnSaveRemOptionChange.Click
        If lvRemOptions.SelectedItems.Count > 0 Then
            Select Case lvRemOptions.SelectedItems(0).Text

                Case "Send File"
                    '  tabAgentRemediationSubMenu.SelectedTab = tabAgentSendFile
                    Dim sflist As List(Of JobsService.ArrayOfJobOptionsOperationsAgentRemediationSendFileJobOptionsOperationsAgentRemediationSendFile) = StoreRemSendList
                    Dim sfi = sflist(lvRemOptions.SelectedItems(0).SubItems(1).Text - 1)
                    sfi.RemotePath = txtremsenddest.Text
                    sfi.FileToSend = txtremsendsource.Text
                    sfi.OverwriteIfExists = chkremsenddelete.Checked
            
                Case "Delete File"
                    'tabAgentRemediationSubMenu.SelectedTab = tabAgentDelete
                    Dim dflist As List(Of JobsService.ArrayOfJobOptionsOperationsAgentRemediationEraseJobOptionsOperationsAgentRemediationErase) = StoreRemDelList
                    Dim dfi = dflist(lvRemOptions.SelectedItems(0).SubItems(1).Text - 1)
                    dfi.RemotePath = txtremdelfilepath.Text

                Case "Execute"
                    ' tabAgentRemediationSubMenu.SelectedTab = tabAgentExecute
                    Dim xflist As List(Of JobsService.ArrayOfJobOptionsOperationsAgentRemediationExecuteJobOptionsOperationsAgentRemediationExecute) = StoreRemExecList
                    Dim xfi = xflist(lvRemOptions.SelectedItems(0).SubItems(1).Text - 1)
                    xfi.Executable = txtremexecpath.Text
                    xfi.Arguments = txtremexecargs.Text
               

                Case "Kill Process Name"
                    '  tabAgentRemediationSubMenu.SelectedTab = TabAgentKill
                    Dim kpnamelist As List(Of String) = StoreRemKillNameList
                    Dim knli = kpnamelist(lvRemOptions.SelectedItems(0).SubItems(1).Text - 1)
                    knli = txtremkillprocname.Text
                  
                Case "Kill Process ID"
                    ' tabAgentRemediationSubMenu.SelectedTab = TabAgentKill
                    Dim kpidlist As List(Of String) = StoreRemKillIDList
                    Dim kidli = kpidlist(lvRemOptions.SelectedItems(0).SubItems(1).Text - 1)
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
End Class
