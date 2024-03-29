﻿Imports FEPRestClient.Models.Job
Imports FEPRestClient.Models.Templates
Imports FEPRestClient.Models.Response
Imports FEPRestClient.Models
Imports System.Text
Imports System.Globalization

Public Class Form_JobFromTemplate
    Public Property JobTemplateID As String
    Public Property SelectedProjectID As String
    Private Property NewJobTargets As New List(Of String)
    Private Property CurrentTabName As String
    Private Property TemplateInfo As TemplateInformation
    Private Property SelectedThreatFilters As New List(Of Integer)
    Private Property RecurStart As String = ""

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
                    treeGroups.SelectedNode = treeGroups.Nodes.Item(0)
                    JobRunner_RestFunctions.GetGroupComputer_JobFromTemplate(treeGroups.SelectedNode.Tag)
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
                       
                        '----------------------------Threat Scan Job
                        If TemplateInfo.jobType = 16 Then
                            Dim job As New JobFromTemplate
                            job.ComputerTargets = NewJobTargets
                            job.ProjectId = SelectedProjectID
                            job.TemplateId = JobTemplateID
                            '------------Submit Job From Template Dont Execute
                            Dim tsjob As ApiResponse(Of String) = JobRunner_RestFunctions.CreateFromTemplate(job, False)
                            '-------------Define TS Options
                            Dim tsoptions As New ThreatScanJobOptions
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

                            '---------------Set TS Options on Job
                            JobRunner_RestFunctions.SetThreatScanOptions(tsjob.Data, tsoptions)
                            '--------------Execute
                            JobRunner_RestFunctions.GetSetJobStatus(tsjob.Data, Enums.JobAction.Execute)


                            Me.Close()
                            Main.tabControlJobsRest.SelectedTab = Main.tabJobsList
                        Else

                            '------------------------------Normal Job                       
                            Dim job As New JobFromTemplate
                            job.ComputerTargets = NewJobTargets
                            job.ProjectId = SelectedProjectID
                            job.TemplateId = JobTemplateID
                            '-------------- Execute
                        
                                JobRunner_RestFunctions.CreateFromTemplate(job, True)


                            Me.Close()
                            Main.tabControlJobsRest.SelectedTab = Main.tabJobsList
                        End If
                    Else
                        '------------------No Targets
                        MsgBox("No job targets have been selected. Please go to the previous section and select targets.", MsgBoxStyle.Exclamation, "No Targets Selected")
                        CurrentTabName = tabTargets.Name
                        btnJobFromTemplateNext.Text = "Next"
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

    Private _IsSelectAllChecked As Boolean

    Private Sub AddSelectAllCheckBox(ByVal theDataGridView As DataGridView)
        Dim cbx As New CheckBox
        cbx.Name = "SelectAll"
        cbx.Checked = True
        'The box size
        cbx.Size = New Size(16, 16)
        Dim rect As Rectangle
        rect = theDataGridView.GetCellDisplayRectangle(0, -1, True)
        'Put CheckBox  in the middle-center of the column header.
        cbx.Location = New System.Drawing.Point(rect.Location.X + theDataGridView.Columns(0).Width / 2.4, rect.Location.Y + 5)
        cbx.BackColor = Color.White
        cbx.ForeColor = Color.Black
        theDataGridView.Controls.Add(cbx)

        'Handle header CheckBox check/uncheck function
        AddHandler cbx.Click, AddressOf HeaderCheckBox_Click
        'When any CheckBox value in the DataGridViewRows changed,
        'check/uncheck the header CheckBox accordingly.
        AddHandler theDataGridView.CellValueChanged, AddressOf DataGridView_CellChecked
        'This event handler is necessary to commit new CheckBox cell value right after
        'user clicks the CheckBox.
        'Without it, CellValueChanged event occurs until the CheckBox cell lose focus
        'which means the header CheckBox won't display corresponding checked state instantly when user
        'clicks any one of the CheckBoxes.
        AddHandler theDataGridView.CurrentCellDirtyStateChanged, AddressOf DataGridView_CurrentCellDirtyStateChanged
    End Sub

    Private Sub HeaderCheckBox_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me._IsSelectAllChecked = True

        Dim cbx As CheckBox
        cbx = DirectCast(sender, CheckBox)
        Dim theDataGridView As DataGridView = cbx.Parent

        For Each row As DataGridViewRow In theDataGridView.Rows
            row.Cells(0).Value = cbx.Checked
        Next

        theDataGridView.EndEdit()

        Me._IsSelectAllChecked = False
    End Sub
    Private Sub DataGridView_CellChecked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        Dim dataGridView As DataGridView = DirectCast(sender, DataGridView)
        If Not Me._IsSelectAllChecked Then
            If dataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = False Then
                'When any single CheckBox is unchecked, uncheck the header CheckBox.
                DirectCast(dataGridView.Controls.Item("SelectAll"), CheckBox).Checked = False
            Else
                'When any single CheckBox is checked, loop through all CheckBoxes to determine
                'if the header CheckBox needs to be unchecked.
                Dim isAllChecked As Boolean = True
                For Each row As DataGridViewRow In dataGridView.Rows
                    If row.Cells(0).Value = False Then
                        isAllChecked = False
                        Exit For
                    End If
                Next
                DirectCast(dataGridView.Controls.Item("SelectAll"), CheckBox).Checked = isAllChecked
            End If
        End If
    End Sub
    'The CurrentCellDirtyStateChanged event happens after user change the cell value,
    'before the cell lose focus and CellValueChanged event.
    Private Sub DataGridView_CurrentCellDirtyStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim dataGridView As DataGridView = DirectCast(sender, DataGridView)
        If TypeOf dataGridView.CurrentCell Is DataGridViewCheckBoxCell Then
            'When the value changed cell is DataGridViewCheckBoxCell, commit the change
            'to invoke the CellValueChanged event.
            dataGridView.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub

    Private Sub splitProjects_Panel1_Paint(sender As Object, e As PaintEventArgs) Handles splitProjects.Panel1.Paint, splitTargetEndpoints.Panel1.Paint, splitThreatFilters.Panel1.Paint

    End Sub

    Private Sub btnNewProject_Click(sender As Object, e As EventArgs) Handles btnNewProject.Click
        Dim projectcreate As New Form_CreateEditProject("Create Project", True)
        projectcreate.ShowDialog()
        JobRunner_RestFunctions.GetProjectList_JobFromTemplate()
    End Sub

    Private Sub txtSearchProject_TextChanged(sender As Object, e As EventArgs) Handles txtSearchProject.TextChanged

    End Sub
    Private Sub txtSearchProject_Enter(sender As Object, e As EventArgs) Handles txtSearchProject.Enter
        If txtSearchProject.Text = "Search" Then
            txtSearchProject.Text = ""
        End If
    End Sub

    Private Sub txtSearchProject_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearchProject.KeyDown
        Dim x As TextBox = sender
        If e.KeyCode = Keys.Enter Then
            Select Case x.Text
                Case "Search"
                    JobRunner_RestFunctions.GetProjectList_JobFromTemplate()
                Case vbNullString
                    JobRunner_RestFunctions.GetProjectList_JobFromTemplate()
                Case Else
                    Dim facsearch As New Facet.FacetSearch
                    facsearch.SearchAny.Add(x.Text)
                    JobRunner_RestFunctions.GetProjectList_JobFromTemplate(facsearch)
            End Select

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
        'Add Select Box
        AddSelectAllCheckBox(dgvTargetEndpoints)


        tabControlJobFromTemplate.TabPages.Remove(tabThreatFilters)
        TemplateInfo = JobRunner_RestFunctions.GetTemplateInfo(JobTemplateID).Data
        JobRunner_RestFunctions.GetProjectList_JobFromTemplate()
        tabControlJobFromTemplate.SelectedTab = tabProject
        CurrentTabName = tabControlJobFromTemplate.SelectedTab.Name

        chkEnableRecurrence.Checked = False
        rdoRecurStart_Hourly.Checked = True
        RecurStart = rdoRecurStart_Hourly.Name
        panel_RecurHourly.Visible = True
        cmb_RecurHours.SelectedItem = "1"
        cmb_RecurMinutes.SelectedItem = "1"
        nmb_RecurDays.Value = 1
        cmbRecurYear_EveryMonth.SelectedItem = "January"
        cmbRecurYear_TheFirstDay.SelectedItem = "First"
        cmbRecurYear_TheMonth.SelectedItem = "January"
        cmbRecurYear_TheSelectDay.SelectedItem = "Day"
        cmbRecurMonth_TheFirstDay.SelectedItem = "First"
        cmbRecurMonth_TheSelectDay.SelectedItem = "Day"

        'Check for threatscan
        If TemplateInfo.jobType = 16 Then
            tabControlJobFromTemplate.TabPages.Insert(1, tabThreatFilters)
            chkIncrementalCollection.Visible = True
            splitThreatFilterAdvanced.Panel2Collapsed = True
            splitThreatFilters.Size = New Size(1016, 469)
            splitThreatFilterAdvanced.Size = New Size(1000, 45)
            splitThreatFilterAdvanced.SplitterDistance = 40
            splitThreatFilters.SplitterDistance = 45

            'Build Advanced Checkboxes
            Dim TSArchive As Array = System.Enum.GetNames(GetType(Enums.ThreatScanArchives))
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
        Dim x As TextBox = sender
        If e.KeyCode = Keys.Enter Then
            Dim treegroup As String = ""
            If Not treeGroups.SelectedNode Is Nothing Then
                treegroup = treeGroups.SelectedNode.Tag
            Else
                treegroup = "00000000-0000-0000-0000-000000000000"
            End If
            Select Case x.Text
                Case "Search"

                    JobRunner_RestFunctions.GetGroupComputer_JobFromTemplate(treegroup, , )
                Case vbNullString
                    JobRunner_RestFunctions.GetGroupComputer_JobFromTemplate(treegroup, , )
                Case Else
                    Dim facsearch As New Facet.FacetSearch
                    facsearch.SearchAny.Add(x.Text)
                    JobRunner_RestFunctions.GetGroupComputer_JobFromTemplate(treegroup, , , facsearch)
            End Select
        End If
    End Sub



    Private Sub txtSearchEndpoint_Leave(sender As Object, e As EventArgs) Handles txtSearchEndpoint.Leave
        If txtSearchEndpoint.Text = "" Then
            txtSearchEndpoint.Text = "Search"
        End If
    End Sub

    Private Sub Form_JobFromTemplate_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        splitProjects.SplitterDistance = 40
        splitTargetEndpoints.SplitterDistance = 40
        Select Case splitThreatFilterAdvanced.Panel2Collapsed
            Case False
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
            Case True
                splitThreatFilterAdvanced.Panel2Collapsed = True
                splitThreatFilterAdvanced.Size = New Size(1000, 45)
                splitThreatFilterAdvanced.SplitterDistance = 40
                splitThreatFilters.Size = New Size(1000, 469)
                splitThreatFilters.SplitterDistance = 45
                flowThreatScanAllFilter.Visible = False
        End Select

    End Sub


    Private Sub JobFromTemplate_Shown(sender As Object, e As EventArgs) Handles Me.Shown

    End Sub

    Private Sub txtSearchThreatFilters_TextChanged(sender As Object, e As EventArgs)

    End Sub


    Private Sub txtSearchThreatFilters_Enter(sender As Object, e As EventArgs) Handles txtSearchThreatFilters.Enter
        If txtSearchThreatFilters.Text = "Search" Then
            txtSearchThreatFilters.Text = ""
        End If
    End Sub

    Private Sub txtSearchThreatFilters_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearchThreatFilters.KeyDown

        If e.KeyCode = Keys.Enter Then
            JobRunner_RestFunctions.GetThreatFilterList_JobFromTemplate(txtSearchThreatFilters.Text)
        End If
    End Sub



    Private Sub txtSearchThreatFilters_Leave(sender As Object, e As EventArgs) Handles txtSearchThreatFilters.Leave
        If txtSearchThreatFilters.Text = "" Then
            txtSearchThreatFilters.Text = "Search"
        End If
    End Sub

    Private Sub dgvThreatFilters_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvThreatFilters.CellContentClick

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles dtpScheduleStart.ValueChanged

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
        txtThreatCreate.Text = dtpDate.Value.ToShortDateString & " " & dtpTime.Value.ToShortTimeString
    End Sub

    Private Sub dtpTime_ValueChanged(sender As Object, e As EventArgs) Handles dtpTime.ValueChanged
        txtThreatCreate.Text = dtpDate.Value.ToShortDateString & " " & dtpTime.Value.ToShortTimeString
    End Sub

    Private Sub rdoSchedule_Schedule_CheckedChanged(sender As Object, e As EventArgs) Handles rdoSchedule_Schedule.CheckedChanged
        Select Case rdoSchedule_Schedule.Checked
            Case True
                grpSchedule_StartDate.Visible = True
                grpRecurrence.Visible = True
            Case False
                grpSchedule_StartDate.Visible = False
                grpRecurrence.Visible = False
        End Select
    End Sub

    Private Sub rdoRecurEnd_NoEnd_CheckedChanged(sender As Object, e As EventArgs) Handles rdoRecurEnd_NoEnd.CheckedChanged
        Select Case rdoRecurEnd_NoEnd.Checked
            Case True
                dtpRecurEndBy.Visible = False
                nmbRecurEndOccurences.Visible = False
                lblRecurEndOccurences.Visible = False
        End Select
    End Sub

    Private Sub rdoRecurEnd_After_CheckedChanged(sender As Object, e As EventArgs) Handles rdoRecurEnd_After.CheckedChanged
        Select Case rdoRecurEnd_After.Checked
            Case True
                dtpRecurEndBy.Visible = False
                nmbRecurEndOccurences.Visible = True
                lblRecurEndOccurences.Visible = True
        End Select
    End Sub

    Private Sub rdoRecurEnd_EndBy_CheckedChanged(sender As Object, e As EventArgs) Handles rdoRecurEnd_EndBy.CheckedChanged
        Select Case rdoRecurEnd_EndBy.Checked
            Case True
                dtpRecurEndBy.Visible = True
                nmbRecurEndOccurences.Visible = False
                lblRecurEndOccurences.Visible = False
        End Select
    End Sub

    Private Sub rdoRecurStart_Minute_CheckedChanged(sender As Object, e As EventArgs) Handles rdoRecurStart_Minute.CheckedChanged
        Select Case rdoRecurStart_Minute.Checked
            Case True
                panel_RecurMinute.Visible = True
                RecurStart = rdoRecurStart_Minute.Name
                panel_RecurHourly.Visible = False
                panel_recurDaily.Visible = False
                panel_RecurWeekly.Visible = False
                panel_RecurMonthly.Visible = False
                panel_RecurYearly.Visible = False
        End Select
    End Sub

    Private Sub rdoRecurStart_Hourly_CheckedChanged(sender As Object, e As EventArgs) Handles rdoRecurStart_Hourly.CheckedChanged
        Select Case rdoRecurStart_Hourly.Checked
            Case True
                panel_RecurMinute.Visible = False
                panel_RecurHourly.Visible = True
                RecurStart = rdoRecurStart_Hourly.Name
                panel_recurDaily.Visible = False
                panel_RecurWeekly.Visible = False
                panel_RecurMonthly.Visible = False
                panel_RecurYearly.Visible = False
        End Select
    End Sub

    Private Sub rdoRecurStart_Daily_CheckedChanged(sender As Object, e As EventArgs) Handles rdoRecurStart_Daily.CheckedChanged
        Select Case rdoRecurStart_Daily.Checked
            Case True
                panel_RecurMinute.Visible = False
                panel_RecurHourly.Visible = False
                panel_recurDaily.Visible = True
                RecurStart = rdoRecurStart_Daily.Name
                panel_RecurWeekly.Visible = False
                panel_RecurMonthly.Visible = False
                panel_RecurYearly.Visible = False
        End Select
    End Sub

    Private Sub rdoRecurStart_Weekly_CheckedChanged(sender As Object, e As EventArgs) Handles rdoRecurStart_Weekly.CheckedChanged
        Select Case rdoRecurStart_Weekly.Checked
            Case True
                panel_RecurMinute.Visible = False
                panel_RecurHourly.Visible = False
                panel_recurDaily.Visible = False
                panel_RecurWeekly.Visible = True
                RecurStart = rdoRecurStart_Weekly.Name
                panel_RecurMonthly.Visible = False
                panel_RecurYearly.Visible = False
        End Select
    End Sub

    Private Sub rdoRecurStart_Monthly_CheckedChanged(sender As Object, e As EventArgs) Handles rdoRecurStart_Monthly.CheckedChanged
        Select Case rdoRecurStart_Monthly.Checked
            Case True
                panel_RecurMinute.Visible = False
                panel_RecurHourly.Visible = False
                panel_recurDaily.Visible = False
                panel_RecurWeekly.Visible = False
                panel_RecurMonthly.Visible = True
                RecurStart = rdoRecurStart_Monthly.Name
                panel_RecurYearly.Visible = False
        End Select
    End Sub

    Private Sub rdoRecurStart_Yearly_CheckedChanged(sender As Object, e As EventArgs) Handles rdoRecurStart_Yearly.CheckedChanged
        Select Case rdoRecurStart_Yearly.Checked
            Case True
                panel_RecurMinute.Visible = False
                panel_RecurHourly.Visible = False
                panel_recurDaily.Visible = False
                panel_RecurWeekly.Visible = False
                panel_RecurMonthly.Visible = False
                panel_RecurYearly.Visible = True
                RecurStart = rdoRecurStart_Yearly.Name
        End Select
    End Sub

    Private Sub chkEnableRecurrence_CheckedChanged(sender As Object, e As EventArgs) Handles chkEnableRecurrence.CheckedChanged
        Select Case chkEnableRecurrence.Checked
            Case True
                grpRecurrenceStart.Visible = True
                grpRecurrenceEnd.Visible = True
            Case False
                grpRecurrenceStart.Visible = False
                grpRecurrenceEnd.Visible = False
        End Select
    End Sub


    Private Sub dgvTargetEndpoints_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTargetEndpoints.CellContentClick

    End Sub
End Class