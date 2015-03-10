

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
        Dim remediatesendfile(0) As R1API.JobsService.ArrayOfJobOptionsOperationsAgentRemediationSendFileJobOptionsOperationsAgentRemediationSendFile
        If txtremsendsource.Text <> "" Then
            'Set options
            remediatesendfile(0) = New R1API.JobsService.ArrayOfJobOptionsOperationsAgentRemediationSendFileJobOptionsOperationsAgentRemediationSendFile
            remediatesendfile(0).FileToSend = txtremsendsource.Text
            remediatesendfile(0).IsRelative = True
            remediatesendfile(0).RemotePath = txtremsenddest.Text
            remediatesendfile(0).OverwriteIfExists = chkremsenddelete.Checked
        Else
            'Blank options - null it 
            remediatesendfile = New R1API.JobsService.ArrayOfJobOptionsOperationsAgentRemediationSendFileJobOptionsOperationsAgentRemediationSendFile() {}
        End If

        'Agent Remediation - Erase File
        Dim remediateerase(0) As R1API.JobsService.ArrayOfJobOptionsOperationsAgentRemediationEraseJobOptionsOperationsAgentRemediationErase
        If txtremdelfilepath.Text <> "" Then
            'Set options
            remediateerase(0) = New R1API.JobsService.ArrayOfJobOptionsOperationsAgentRemediationEraseJobOptionsOperationsAgentRemediationErase
            remediateerase(0).RemotePath = txtremdelfilepath.Text
        Else
            'Blank options - null it
            remediateerase = New R1API.JobsService.ArrayOfJobOptionsOperationsAgentRemediationEraseJobOptionsOperationsAgentRemediationErase() {}
        End If

        'Agent Remediation - Execute
        Dim remediateexecute(0) As R1API.JobsService.ArrayOfJobOptionsOperationsAgentRemediationExecuteJobOptionsOperationsAgentRemediationExecute
        If txtremexecpath.Text <> "" Then
            'Set options
            remediateexecute(0) = New R1API.JobsService.ArrayOfJobOptionsOperationsAgentRemediationExecuteJobOptionsOperationsAgentRemediationExecute
            remediateexecute(0).Executable = txtremexecpath.Text
            remediateexecute(0).Arguments = txtremexecargs.Text
        Else
            'Blank options - null it
            remediateexecute = New R1API.JobsService.ArrayOfJobOptionsOperationsAgentRemediationExecuteJobOptionsOperationsAgentRemediationExecute() {}
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
            txtStatusBox.Text = "Job: " & txtDefaultJobName.Text & " in Project: " & txtDefaultProjectName.Text & " submitted sucessfully. GUID: " & jobid
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
        txtComputerTarget.Text = txtdefaultcomputer.Text
        txtNetSharePath.Text = txtdefaultshare.Text

    End Sub

 

    Private Sub tabSettings_Enter(sender As Object, e As EventArgs) Handles tabSettings.Enter
        txtStatusSettings.Text = ""
    End Sub

    Private Sub tabBoxedJobs_Enter(sender As Object, e As EventArgs) Handles tabBoxedJobs.Enter
        txtboxtargetcomputer.Text = txtdefaultcomputer.Text
        Dim boxnames As List(Of String) = GetListofBoxedJobs()
        For Each item In boxnames
            lstBoxedJobs.Items.Add(item)
        Next
    End Sub

    Private Sub btnBoxJobCollection1_Click(sender As Object, e As EventArgs) Handles btnBoxJobCollection1.Click
        '  BoxedJobs.SaveBoxedJob()
        Dim jobid = BoxedJobs.BoxedJob1(txtServer.Text, txtProjectName.Text, txtApiUser.Text, txtAPIPass.Text, txtboxtargetcomputer.Text)
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
End Class
