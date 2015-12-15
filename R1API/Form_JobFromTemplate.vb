Imports R1SimpleRestClient.Models.Job
Imports R1SimpleRestClient.Models.Templates
Imports R1SimpleRestClient.Models.Response
Imports R1SimpleRestClient.Models
Imports System.Text

Public Class Form_JobFromTemplate
    Public Property JobTemplateID As String
    Public Property SelectedProjectID As String
    Private Property NewJobTargets As New List(Of String)
    Private Property CurrentTabName As String
    Private Property TemplateInfo As TemplateInformation
    Private Property SelectedThreatFilters As New List(Of Integer)

    Private Sub btnJobFromTemplateCancel_Click(sender As Object, e As EventArgs) Handles btnJobFromTemplateCancel.Click
        Me.Close()
    End Sub

    Private Sub btnJobFromTemplateNext_Click(sender As Object, e As EventArgs) Handles btnJobFromTemplateNext.Click
        Select Case tabControlJobFromTemplate.SelectedTab.Name
            Case tabProject.Name
                If tabControlJobFromTemplate.TabPages.Contains(tabThreatFilters) Then
                    SelectedProjectID = dgvProjectList.SelectedRows(0).Cells(5).Value
                    CurrentTabName = tabThreatFilters.Name
                    tabControlJobFromTemplate.SelectedTab = tabThreatFilters
                    lblJobFromTemplateMenuText.Text = "Select the IOCs for the scan"
                    JobRunner_RestFunctions.GetThreatFilterList_JobFromTemplate("")
                Else
                    SelectedProjectID = dgvProjectList.SelectedRows(0).Cells(5).Value
                    CurrentTabName = tabTargets.Name
                    tabControlJobFromTemplate.SelectedTab = tabTargets
                    GetGroups_JobFromTemplate()
                    lblJobFromTemplateMenuText.Text = "Select the target endpoints"

                End If

            Case tabThreatFilters.Name
                CurrentTabName = tabTargets.Name
                tabControlJobFromTemplate.SelectedTab = tabTargets
                GetGroups_JobFromTemplate()
                lblJobFromTemplateMenuText.Text = "Select the target endpoints"
                SelectedThreatFilters.Clear()
                For Each item As DataGridViewRow In dgvThreatFilters.Rows
                    If item.Cells(0).Value = True Then
                        SelectedThreatFilters.Add(item.Cells(11).Value)
                    End If
                Next

            Case tabTargets.Name
                NewJobTargets.Clear()
                For Each item As DataGridViewRow In dgvTargetEndpoints.Rows
                    If item.Cells(0).Value = True Then
                        NewJobTargets.Add(item.Cells(5).Value)
                    End If
                Next
                lblJobFromTemplateMenuText.Text = "Choose scheduling options"
                btnJobFromTemplateNext.Text = "Start"
                CurrentTabName = tabSchedule.Name
                tabControlJobFromTemplate.SelectedTab = tabSchedule
            Case tabSchedule.Name
                If btnJobFromTemplateNext.Text = "Start" Then
                    If NewJobTargets.Count > 0 Then
                        If TemplateInfo.jobType = 16 Then
                            Dim job As New R1SimpleRestClient.Models.Job2.JobFromTemplate
                            job.ComputerTargets = NewJobTargets
                            job.ProjectId = SelectedProjectID
                            job.TemplateId = JobTemplateID
                            Dim tsjob As ApiResponse(Of String) = JobRunner_RestFunctions.CreateFromTemplate(job, False)
                            Dim tsoptions As New Job2.ThreatScanJobOptions
                            If rdoIOCAll.Checked Then
                                tsoptions.threatScanSelection = 0
                                If String.IsNullOrWhiteSpace(txtThreatAuthor.Text) Then tsoptions.authoredByFilter = txtThreatAuthor.Text
                                If String.IsNullOrWhiteSpace(txtThreatCategory.Text) Then tsoptions.categoryFilter = txtThreatCategory.Text
                                If String.IsNullOrWhiteSpace(txtThreatGroup.Text) Then tsoptions.groupFilter = txtThreatGroup.Text
                                If String.IsNullOrWhiteSpace(txtThreatSource.Text) Then tsoptions.sourceFilter = txtThreatSource.Text
                                If String.IsNullOrWhiteSpace(txtThreatCreate.Text) Then tsoptions.initialCreationDateFilter = txtThreatCreate.Text
                            Else
                                tsoptions.threatScanSelection = 1
                                tsoptions.threatFilters = SelectedThreatFilters.ToArray
                            End If
                            If chkThreatScanArchives.Checked = True Then
                                tsoptions.enableArchiveDrillDown = chkThreatScanArchives.Checked
                                Dim archivestring As New List(Of String)
                                For Each CheckBox As CheckBox In flowThreatScanArchivesList.Controls
                                    If CheckBox.Checked Then
                                        archivestring.Add(CheckBox.Text)
                                    End If
                                Next
                                tsoptions.archiveDrillDownExtensions = String.Join(",", archivestring.ToArray)
                            Else
                                tsoptions.enableArchiveDrillDown = chkThreatScanArchives.Checked
                                tsoptions.archiveDrillDownExtensions = "zip,gzip,tar,jar,tgz,rar,gz,bz2,7z,msg,pdf,pst"
                            End If

                            tsoptions.disableHashing = chkDisableFileHashing.Checked
                            If chkPerformStringSearch.Checked Then
                                tsoptions.disableStringContentSearch = False
                            Else
                                tsoptions.disableStringContentSearch = True
                            End If


                            If chkFileHashDisableLarger.Checked = True Then
                                tsoptions.enableIgnoreIOCFileSize = chkFileHashDisableLarger.Checked
                                Select Case cmbFileHash.Text
                                    Case "MB"
                                        tsoptions.ignoreIOCFileSizeBytes = txtHashSize.Text * (1024 ^ 2)
                                    Case "KB"
                                        tsoptions.ignoreIOCFileSizeBytes = txtHashSize.Text * (1024 ^ 1)
                                End Select
                            End If

                            If chkDisableFileHashYaraLarger.Checked = True Then
                                tsoptions.enableIgnoreYARAFileSize = chkDisableFileHashYaraLarger.Checked
                                Select Case cmbYARAFileHash.Text
                                    Case "MB"
                                        tsoptions.ignoreYARAFileSizeBytes = txtYARAHashSize.Text * (1024 ^ 2)
                                    Case "KB"
                                        tsoptions.ignoreYARAFileSizeBytes = txtYARAHashSize.Text * (1024 ^ 1)
                                End Select
                            End If


                            JobRunner_RestFunctions.SetThreatScanOptions(tsjob.Data, tsoptions)
                            JobRunner_RestFunctions.GetSetJobStatus(tsjob.Data, Enums.JobAction.Execute)
                            Me.Close()
                            Main.tabControlJobsRest.SelectedTab = Main.tabJobsList
                        Else
                            Dim job As New R1SimpleRestClient.Models.Job2.JobFromTemplate
                            job.ComputerTargets = NewJobTargets
                            job.ProjectId = SelectedProjectID
                            job.TemplateId = JobTemplateID
                            JobRunner_RestFunctions.CreateFromTemplate(job, True)
                            Me.Close()
                            Main.tabControlJobsRest.SelectedTab = Main.tabJobsList
                        End If
                        Else
                            MsgBox("No job targets have been selected. Please go to the previous section and select targets.", MsgBoxStyle.Exclamation, "No Targets Selected")
                            CurrentTabName = tabTargets.Name
                            tabControlJobFromTemplate.SelectedTab = tabTargets
                        End If
                End If

        End Select
    End Sub

    Private Sub btnJobFromTemplatePrevious_Click(sender As Object, e As EventArgs) Handles btnJobFromTemplatePrevious.Click
        Select Case tabControlJobFromTemplate.SelectedTab.Name
            Case tabProject.Name
                If tabControlJobFromTemplate.TabPages.Contains(tabThreatFilters) Then

                Else

                End If

            Case tabThreatFilters.Name
                CurrentTabName = tabProject.Name
                tabControlJobFromTemplate.SelectedTab = tabProject
                lblJobFromTemplateMenuText.Text = "Pick the project to store the data"

            Case tabTargets.Name
                If tabControlJobFromTemplate.TabPages.Contains(tabThreatFilters) Then
                    CurrentTabName = tabThreatFilters.Name
                    tabControlJobFromTemplate.SelectedTab = tabThreatFilters
                    lblJobFromTemplateMenuText.Text = "Select the IOCs for the scan"
                    JobRunner_RestFunctions.GetThreatFilterList_JobFromTemplate()
                Else
                    CurrentTabName = tabProject.Name
                    tabControlJobFromTemplate.SelectedTab = tabProject
                    lblJobFromTemplateMenuText.Text = "Pick the project to store the data"
                End If




            Case tabSchedule.Name
                CurrentTabName = tabTargets.Name
                tabControlJobFromTemplate.SelectedTab = tabTargets

                lblJobFromTemplateMenuText.Text = "Select the target endpoints"
                btnJobFromTemplateNext.Text = "Next"

        End Select
    End Sub

    Private Sub splitThreatFilters_GotFocus(sender As Object, e As EventArgs) Handles splitThreatFilters.GotFocus

    End Sub

    Private Sub splitProjects_Panel1_Paint(sender As Object, e As PaintEventArgs) Handles splitProjects.Panel1.Paint, splitTargetEndpoints.Panel1.Paint, splitThreatFilters.Panel1.Paint

    End Sub

    Private Sub btnNewProject_Click(sender As Object, e As EventArgs) Handles btnNewProject.Click
        Dim projectcreate As New Form_CreateEditProject("Create Project", True)
        projectcreate.ShowDialog()
        JobRunner_RestFunctions.GetProjectList_JobFromTemplate("")
    End Sub

    Private Sub txtSearchProject_TextChanged(sender As Object, e As EventArgs) Handles txtSearchProject.TextChanged

    End Sub
    Private Sub txtSearchProject_Enter(sender As Object, e As EventArgs) Handles txtSearchProject.Enter
        If txtSearchProject.Text = "Search" Then
            txtSearchProject.Text = ""
        End If
    End Sub

    Private Sub txtSearchProject_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearchProject.KeyDown

        If e.KeyCode = Keys.Enter Then
            JobRunner_RestFunctions.GetProjectList_JobFromTemplate(txtSearchProject.Text)
        End If
    End Sub



    Private Sub txtSearchProject_Leave(sender As Object, e As EventArgs) Handles txtSearchProject.Leave
        If txtSearchProject.Text = "" Then
            txtSearchProject.Text = "Search"
        End If
    End Sub

    Private Sub splitJobFromTemplate_SplitterMoved(sender As Object, e As SplitterEventArgs) Handles splitJobFromTemplate.SplitterMoved

    End Sub

    Private Sub JobFromTemplate_Enter(sender As Object, e As EventArgs) Handles Me.Enter

    End Sub

    Private Sub JobFromTemplate_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub

    Private Sub JobFromTemplate_Load(sender As Object, e As EventArgs) Handles Me.Load
        tabControlJobFromTemplate.TabPages.Remove(tabThreatFilters)
        TemplateInfo = JobRunner_RestFunctions.GetTemplateInfo(JobTemplateID).Data
        JobRunner_RestFunctions.GetProjectList_JobFromTemplate("")
        tabControlJobFromTemplate.SelectedTab = tabProject
        CurrentTabName = tabControlJobFromTemplate.SelectedTab.Name

        'Check for threatscan
        If TemplateInfo.jobType = 16 Then
            tabControlJobFromTemplate.TabPages.Insert(1, tabThreatFilters)

            splitThreatFilterAdvanced.Panel2Collapsed = True
            splitThreatFilters.Size = New Size(1016, 469)
            splitThreatFilterAdvanced.Size = New Size(1000, 45)
            splitThreatFilterAdvanced.SplitterDistance = 40
            splitThreatFilters.SplitterDistance = 45

            'Build Advanced Checkboxes
            Dim TSArchive As Array = System.Enum.GetNames(GetType(Job2.ThreatScanArchives))
            For Each item In TSArchive
                Dim chkitem As New CheckBox
                chkitem.Name = item
                If item = "SevenZip" Then
                    chkitem.Text = "7Z"
                Else
                    chkitem.Text = item
                End If

                chkitem.Parent = flowThreatScanArchivesList
            Next
        End If

    End Sub




    Private Sub tabControlJobFromTemplate_Selecting(sender As Object, e As TabControlCancelEventArgs) Handles tabControlJobFromTemplate.Selecting
        If Not tabControlJobFromTemplate.SelectedTab.Name = CurrentTabName Then
            e.Cancel = True
        End If
    End Sub



    Private Sub treeGroups_NodeMouseClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles treeGroups.NodeMouseClick
        GetGroupComputer_JobFromTemplate(e.Node.Tag)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtSearchEndpoint.TextChanged

    End Sub

    Private Sub txtSearchEndpoint_Enter(sender As Object, e As EventArgs) Handles txtSearchEndpoint.Enter
        If txtSearchEndpoint.Text = "Search" Then
            txtSearchEndpoint.Text = ""
        End If
    End Sub

    Private Sub txtSearchEndpoint_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearchEndpoint.KeyDown

        If e.KeyCode = Keys.Enter Then
            JobRunner_RestFunctions.GetGroupComputer_JobFromTemplate(treeGroups.SelectedNode.Tag, , , txtSearchEndpoint.Text)
        End If
    End Sub



    Private Sub txtSearchEndpoint_Leave(sender As Object, e As EventArgs) Handles txtSearchEndpoint.Leave
        If txtSearchEndpoint.Text = "" Then
            txtSearchEndpoint.Text = "Search"
        End If
    End Sub


    Private Sub JobFromTemplate_Shown(sender As Object, e As EventArgs) Handles Me.Shown

    End Sub

    Private Sub txtSearchThreatFilters_TextChanged(sender As Object, e As EventArgs)

    End Sub


    Private Sub txtSearchThreatFilters_Enter(sender As Object, e As EventArgs)
        If txtSearchThreatFilters.Text = "Search" Then
            txtSearchThreatFilters.Text = ""
        End If
    End Sub

    Private Sub txtSearchThreatFilters_KeyDown(sender As Object, e As KeyEventArgs)

        If e.KeyCode = Keys.Enter Then
            JobRunner_RestFunctions.GetThreatFilterList_JobFromTemplate(txtSearchThreatFilters.Text)
        End If
    End Sub



    Private Sub txtSearchThreatFilters_Leave(sender As Object, e As EventArgs)
        If txtSearchThreatFilters.Text = "" Then
            txtSearchThreatFilters.Text = "Search"
        End If
    End Sub

    Private Sub dgvThreatFilters_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvThreatFilters.CellContentClick

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub rdoIOCAll_CheckedChanged(sender As Object, e As EventArgs) Handles rdoIOCAll.CheckedChanged
        If rdoIOCAll.Checked = True Then
            dgvThreatFilters.Enabled = False
            dgvThreatFilters.ForeColor = Color.Gray
            flowThreatScanAllFilter.Visible = True
            If splitThreatFilters.SplitterDistance > 60 Then
                If flowThreatScanArchivesList.Visible = True Then
                    splitThreatFilters.SplitterDistance = 45 + grpThreatScanAdvanced.Height + flowThreatScanAllFilter.Height + flowThreatScanArchivesList.Height
                Else
                    splitThreatFilters.SplitterDistance = 45 + grpThreatScanAdvanced.Height + flowThreatScanAllFilter.Height
                End If
            End If

        Else
            dgvThreatFilters.Enabled = True
            dgvThreatFilters.ForeColor = Control.DefaultForeColor
            flowThreatScanAllFilter.Visible = False
            If splitThreatFilters.SplitterDistance > 60 Then
                If flowThreatScanArchivesList.Visible = True Then
                    splitThreatFilters.SplitterDistance = 45 + grpThreatScanAdvanced.Height + flowThreatScanArchivesList.Height
                Else
                    splitThreatFilters.SplitterDistance = 45 + grpThreatScanAdvanced.Height
                End If
            End If


        End If

    End Sub

    Private Sub btnThreatFiltersAdvanced_Click(sender As Object, e As EventArgs) Handles btnThreatFiltersAdvanced.Click
        Select Case splitThreatFilterAdvanced.Panel2Collapsed
            Case True
                splitThreatFilterAdvanced.Panel2Collapsed = False
                splitThreatFilterAdvanced.Size = New Size(1000, 240)
                splitThreatFilterAdvanced.SplitterDistance = 40
                splitThreatFilters.Size = New Size(1000, 469)

                If rdoIOCAll.Checked = True Then
                    flowThreatScanAllFilter.Visible = True
                    If chkThreatScanArchives.Checked Then
                        splitThreatFilters.SplitterDistance = 45 + grpThreatScanAdvanced.Height + flowThreatScanAllFilter.Height + flowThreatScanArchivesList.Height
                    Else
                        splitThreatFilters.SplitterDistance = 45 + grpThreatScanAdvanced.Height + flowThreatScanAllFilter.Height
                    End If
                Else
                    flowThreatScanAllFilter.Visible = False
                    If chkThreatScanArchives.Checked Then
                        splitThreatFilters.SplitterDistance = 45 + grpThreatScanAdvanced.Height + flowThreatScanArchivesList.Height
                    Else
                        splitThreatFilters.SplitterDistance = 45 + grpThreatScanAdvanced.Height
                    End If
                End If
            Case False
                splitThreatFilterAdvanced.Panel2Collapsed = True
                splitThreatFilterAdvanced.Size = New Size(1000, 45)
                splitThreatFilterAdvanced.SplitterDistance = 40
                splitThreatFilters.Size = New Size(1000, 469)
                splitThreatFilters.SplitterDistance = 45
                flowThreatScanAllFilter.Visible = False
        End Select

    End Sub
    Dim BACKSPACE As Boolean
    Private Sub txtHashSize_KeyDown(sender As Object, e As KeyEventArgs) Handles txtHashSize.KeyDown

        If e.KeyCode = Keys.Back Then
            BACKSPACE = True
        Else
            BACKSPACE = False
        End If
    End Sub

    Private Sub txtHashSize_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHashSize.KeyPress
        If BACKSPACE = False Then
            If Char.IsDigit(e.KeyChar) = False Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtHashSize_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtYARAHashSize_KeyDown(sender As Object, e As KeyEventArgs) Handles txtYARAHashSize.KeyDown
        If e.KeyCode = Keys.Back Then
            BACKSPACE = True
        Else
            BACKSPACE = False
        End If
    End Sub

    Private Sub txtYARAHashSize_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtYARAHashSize.KeyPress
        If BACKSPACE = False Then
            If Char.IsDigit(e.KeyChar) = False Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtYARAHashSize_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub chkDisableFileHashing_CheckedChanged(sender As Object, e As EventArgs) Handles chkDisableFileHashing.CheckedChanged
        Select Case chkDisableFileHashing.Checked
            Case True
                chkFileHashDisableLarger.Enabled = True

            Case False
                chkFileHashDisableLarger.Enabled = False
                chkFileHashDisableLarger.Checked = False

        End Select
    End Sub

    Private Sub chkFileHashDisableLarger_CheckedChanged(sender As Object, e As EventArgs) Handles chkFileHashDisableLarger.CheckedChanged
        Select Case chkFileHashDisableLarger.Checked

            Case True
                txtHashSize.Enabled = True
                cmbFileHash.Enabled = True
                cmbFileHash.SelectedItem = "MB"
            Case False
                txtHashSize.Enabled = False
                cmbFileHash.Enabled = False
        End Select
    End Sub

    Private Sub chkDisableFileHashYaraLarger_CheckedChanged(sender As Object, e As EventArgs) Handles chkDisableFileHashYaraLarger.CheckedChanged
        Select Case chkDisableFileHashYaraLarger.Checked
            Case True
                txtYARAHashSize.Enabled = True
                cmbYARAFileHash.Enabled = True
                cmbYARAFileHash.SelectedItem = "MB"
            Case False
                txtYARAHashSize.Enabled = False
                cmbYARAFileHash.Enabled = False
        End Select
    End Sub

    Private Sub chkThreatScanArchives_CheckedChanged(sender As Object, e As EventArgs) Handles chkThreatScanArchives.CheckedChanged
        Select Case chkThreatScanArchives.Checked
            Case True
                If flowThreatScanAllFilter.Visible = True Then
                    flowThreatScanArchivesList.Visible = True
                    splitThreatFilters.SplitterDistance = 45 + grpThreatScanAdvanced.Height + flowThreatScanAllFilter.Height + flowThreatScanArchivesList.Height
                Else
                    flowThreatScanArchivesList.Visible = True
                    splitThreatFilters.SplitterDistance = 45 + grpThreatScanAdvanced.Height + flowThreatScanArchivesList.Height
                End If
            Case False
                If flowThreatScanAllFilter.Visible = True Then
                    flowThreatScanArchivesList.Visible = False
                    splitThreatFilters.SplitterDistance = 45 + grpThreatScanAdvanced.Height + flowThreatScanAllFilter.Height
                Else
                    flowThreatScanArchivesList.Visible = False
                    splitThreatFilters.SplitterDistance = 45 + grpThreatScanAdvanced.Height
                End If
        End Select
    End Sub


    Private Sub chkFileHashDisableLarger_CheckedChanged_1(sender As Object, e As EventArgs) Handles chkFileHashDisableLarger.CheckedChanged

    End Sub

    Private Sub chkDisableFileHashing_CheckedChanged_1(sender As Object, e As EventArgs) Handles chkDisableFileHashing.CheckedChanged

    End Sub

    Private Sub rdoIOCSelected_CheckedChanged(sender As Object, e As EventArgs) Handles rdoIOCSelected.CheckedChanged

    End Sub

    Private Sub dtpThreatCreateDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpDate.ValueChanged
        txtThreatCreate.Text = dtpDate.Value & " " & dtpTime.Value
    End Sub

    Private Sub dtpTime_ValueChanged(sender As Object, e As EventArgs) Handles dtpTime.ValueChanged
        txtThreatCreate.Text = dtpDate.Value & " " & dtpTime.Value
    End Sub
End Class