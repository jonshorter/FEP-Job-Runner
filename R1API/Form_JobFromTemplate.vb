Imports R1SimpleRestClient.Models.Job
Imports R1SimpleRestClient.Models.Templates
Imports R1SimpleRestClient.Models.Response
Imports R1SimpleRestClient.Models

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
                            tsoptions.threatScanSelection = 1
                            tsoptions.enableArchiveDrillDown = False
                            tsoptions.archiveDrillDownExtensions = "zip,gzip,tar,jar,tgz,rar,gz,bz2,7z,msg,pdf,pst"
                            tsoptions.enableIgnoreIOCFileSize = False
                            tsoptions.enableIgnoreYARAFileSize = True
                            tsoptions.disableHashing = False
                            tsoptions.disableStringContentSearch = False
                            tsoptions.threatFilters = SelectedThreatFilters.ToArray


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

    Private Sub txtSearchThreatFilters_TextChanged(sender As Object, e As EventArgs) Handles txtSearchThreatFilters.TextChanged

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
End Class