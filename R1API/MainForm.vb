

Public Class Main

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnExecute.Click
        txtStatusBox.Text = "Submitting Job..."
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
        Dim filter As String = Jobs.CreateFilter

        'Set Job Template
        Dim templatename As String
        If txtTemplateName.Text <> "" Then
            templatename = txtTemplateName.Text
        Else
            'If it isn't set use the default
            templatename = "coll-evtx"
        End If

        'Agent Remediation - Send File
        Dim remediatesendfile(0) As R1_Job_Runner.JobsService.ArrayOfJobOptionsOperationsAgentRemediationSendFileJobOptionsOperationsAgentRemediationSendFile
        If txtremsendsource.Text <> "" Then
            'Set options
            remediatesendfile(0) = New R1_Job_Runner.JobsService.ArrayOfJobOptionsOperationsAgentRemediationSendFileJobOptionsOperationsAgentRemediationSendFile
            remediatesendfile(0).FileToSend = txtremsendsource.Text
            remediatesendfile(0).IsRelative = True
            remediatesendfile(0).RemotePath = txtremsenddest.Text
            remediatesendfile(0).OverwriteIfExists = chkremsenddelete.Checked
        Else
            'Blank options - null it 
            remediatesendfile = New R1_Job_Runner.JobsService.ArrayOfJobOptionsOperationsAgentRemediationSendFileJobOptionsOperationsAgentRemediationSendFile() {}
        End If

        'Agent Remediation - Erase File
        Dim remediateerase(0) As R1_Job_Runner.JobsService.ArrayOfJobOptionsOperationsAgentRemediationEraseJobOptionsOperationsAgentRemediationErase
        If txtremdelfilepath.Text <> "" Then
            'Set options
            remediateerase(0) = New R1_Job_Runner.JobsService.ArrayOfJobOptionsOperationsAgentRemediationEraseJobOptionsOperationsAgentRemediationErase
            remediateerase(0).RemotePath = txtremdelfilepath.Text
        Else
            'Blank options - null it
            remediateerase = New R1_Job_Runner.JobsService.ArrayOfJobOptionsOperationsAgentRemediationEraseJobOptionsOperationsAgentRemediationErase() {}
        End If

        'Agent Remediation - Execute
        Dim remediateexecute(0) As R1_Job_Runner.JobsService.ArrayOfJobOptionsOperationsAgentRemediationExecuteJobOptionsOperationsAgentRemediationExecute
        If txtremexecpath.Text <> "" Then
            'Set options
            remediateexecute(0) = New R1_Job_Runner.JobsService.ArrayOfJobOptionsOperationsAgentRemediationExecuteJobOptionsOperationsAgentRemediationExecute
            remediateexecute(0).Executable = txtremexecpath.Text
            remediateexecute(0).Arguments = txtremexecargs.Text
        Else
            'Blank options - null it
            remediateexecute = New R1_Job_Runner.JobsService.ArrayOfJobOptionsOperationsAgentRemediationExecuteJobOptionsOperationsAgentRemediationExecute() {}
        End If

        'Agent Remediation - Kill by PID
        Dim pids() As String = New String() {}
        If nmbremkillprocid.Value <> 0 Then
            'Set pid
            pids(0) = New Integer
            pids(0) = nmbremkillprocid.Value
        Else
            'Blank options - null it
            pids = New String() {}
        End If


        'Agent Remediation - Kill by Process Name
        Dim processnames() As String = New String() {}
        If txtremkillprocname.Text <> "" Then
            processnames(0) = New String(txtremkillprocname.Text)
        Else
            'Blank options - null it
            processnames = New String() {}
        End If

        'Kick off the job
        Dim jobid = Jobs.RunFromTemplateName(txtServer.Text, templatename, txtJobName.Text, txtProjectName.Text, txtApiUser.Text, txtAPIPass.Text, cnames, snames, filter, pids, processnames, remediatesendfile, remediateexecute, remediateerase)


        'Check if the returned message is a GUID or Error
        If isGuid(jobid) Then
            'GUID - Job submitted successfully
            txtStatusBox.Text = "Job: " & txtJobName.Text & " in Project: " & txtProjectName.Text & " submitted sucessfully. GUID: " & jobid
            txtStatusBox.ForeColor = Color.Black
        Else
            'Error - Something happened
            txtStatusBox.Text = "Error: " & jobid
            txtStatusBox.ForeColor = Color.Red
            MsgBox("Error: " & jobid)
        End If


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
            My.Settings.templatename.Add("Registry -Autostart")
            My.Settings.templatename.Add("Registry -Full")
            My.Settings.templatename.Add("Remediate -Name")
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
        'Clear status message
        txtStatusBox.Text = ""
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

   

    Private Sub TabPage1_Enter(sender As Object, e As EventArgs) Handles tabTargets.Enter
        'Set text boxes to default values from settings
        txtComputerTarget.Text = txtdefaultcomputer.Text
        txtNetSharePath.Text = txtdefaultshare.Text

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

    Private Sub tabBoxedJobs_Click(sender As Object, e As EventArgs) Handles tabBoxedJobs.Click

    End Sub

    Private Sub btnSaveAsBox_Click(sender As Object, e As EventArgs) Handles btnSaveAsBox.Click
        sfdBox.ShowDialog()
        Dim sbox As New BoxedJob
        sbox.BoxJobName = sfdBox.FileName
        sbox.R1JobName = txtJobName.Text
        sbox.R1Template = txtTemplateName.Text
        sbox.R1Project = txtProjectName.Text
        'Process IDs
        Dim pids(0) As String
        pids(0) = nmbremkillprocid.Value
        sbox.R1_AR_PIDS = pids
        'Process Names
        Dim pnames(0) As String
        pnames(0) = txtremkillprocname.Text
        sbox.R1_AR_ProcessNames = pnames
        'Send Options
        Dim ar_send(0) As JobsService.ArrayOfJobOptionsOperationsAgentRemediationSendFileJobOptionsOperationsAgentRemediationSendFile
        Dim ar_send_0 As New JobsService.ArrayOfJobOptionsOperationsAgentRemediationSendFileJobOptionsOperationsAgentRemediationSendFile
        ar_send_0.RemotePath = txtremsenddest.Text
        ar_send_0.FileToSend = txtremsendsource.Text
        ar_send_0.OverwriteIfExists = chkremsenddelete.Checked
        ar_send(0) = ar_send_0
        sbox.R1_AR_Send = ar_send
        'Execute Options
        Dim ar_exec(0) As JobsService.ArrayOfJobOptionsOperationsAgentRemediationExecuteJobOptionsOperationsAgentRemediationExecute
        Dim ar_exec_0 As New JobsService.ArrayOfJobOptionsOperationsAgentRemediationExecuteJobOptionsOperationsAgentRemediationExecute
        ar_exec_0.Executable = txtremexecpath.Text
        ar_exec_0.Arguments = txtremexecargs.Text
        ar_exec(0) = ar_exec_0
        sbox.R1_AR_Execute = ar_exec
        'Erase Options
        Dim ar_erase(0) As JobsService.ArrayOfJobOptionsOperationsAgentRemediationEraseJobOptionsOperationsAgentRemediationErase
        Dim ar_erase_0 As New JobsService.ArrayOfJobOptionsOperationsAgentRemediationEraseJobOptionsOperationsAgentRemediationErase
        ar_erase_0.RemotePath = txtremdelfilepath.Text
        ar_erase(0) = ar_erase_0
        sbox.R1_AR_Erase = ar_erase

        'Filters

        'Inclusion 1
        Dim in1 As New InclusionFilter
        Dim in1l As New List(Of InclusionFilter)
        in1.FilterName = txtinclfiltername.Text
        in1.Extensions = txtinclextensions.Text
        in1.IsKeyWordSearch = rdoinclsimplesearch.Checked
        in1.IsRegexSearch = rdoinclregexsearch.Checked
        in1.IsSearchFilenameOnly = chkinclsearchfilename.Checked
        in1.Keywords = txtinclkeywords.Text
        in1.MD5HashsEntryText = txtinclmd5hash.Text
        in1.PathURLContains = txtinclpathcontains.Text

        in1l.Add(in1)

        'Exclusion 1
        Dim ex1 As New ExclusionFilter
        Dim ex1l As New List(Of ExclusionFilter)
        ex1.FilterName = txtexclfiltername.Text
        ex1.Extensions = txtexclextensions.Text
        ex1.MD5HashsEntryText = txtexclmd5hash.Text
        ex1.PathURLContains = txtexclpathcontains.Text

        ex1l.Add(ex1)


        sbox.R1Filter = Jobs.BuildFilterJSON(in1l, ex1l)
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
                txtinclfiltername.Text = inlist.Item(0).FilterName
                txtinclextensions.Text = inlist.Item(0).Extensions
                txtinclkeywords.Text = inlist.Item(0).Keywords
                txtinclmd5hash.Text = inlist.Item(0).MD5HashsEntryText
                txtinclpathcontains.Text = inlist(0).PathURLContains
                chkinclsearchfilename.Checked = inlist.Item(0).IsSearchFilenameOnly
                rdoinclregexsearch.Checked = inlist.Item(0).IsRegexSearch
                rdoinclsimplesearch.Checked = inlist.Item(0).IsKeyWordSearch
            End If

            If exlist.Count > 0 Then
                txtexclextensions.Text = exlist(0).Extensions
                txtexclfiltername.Text = exlist(0).FilterName
                txtexclmd5hash.Text = exlist(0).MD5HashsEntryText
                txtexclpathcontains.Text = exlist(0).PathURLContains
            End If


            Dim ar_send() As JobsService.ArrayOfJobOptionsOperationsAgentRemediationSendFileJobOptionsOperationsAgentRemediationSendFile
            ar_send = box.R1_AR_Send
            If ar_send.Count > 0 Then
                txtremsenddest.Text = ar_send(0).RemotePath
                txtremsendsource.Text = ar_send(0).FileToSend
                chkremsenddelete.Checked = ar_send(0).OverwriteIfExists
            End If

            Dim ar_exec() As JobsService.ArrayOfJobOptionsOperationsAgentRemediationExecuteJobOptionsOperationsAgentRemediationExecute
            ar_exec = box.R1_AR_Execute
            If ar_exec.Count > 0 Then
                txtremexecargs.Text = ar_exec(0).Arguments
                txtremexecpath.Text = ar_exec(0).Executable
            End If

            Dim ar_erase() As JobsService.ArrayOfJobOptionsOperationsAgentRemediationEraseJobOptionsOperationsAgentRemediationErase
            ar_erase = box.R1_AR_Erase
            If ar_erase.Count > 0 Then
                txtremdelfilepath.Text = ar_erase(0).RemotePath
            End If

            Dim pids() As String = box.R1_AR_PIDS
            If pids.Count > 0 Then
                nmbremkillprocid.Value = pids(0)
            End If

            Dim processnames() As String = box.R1_AR_ProcessNames
            If processnames.Count > 0 Then
                txtremkillprocname.Text = processnames(0)
            End If



        Else
            MsgBox("File Doesn't Exist")
        End If




    End Sub
End Class
