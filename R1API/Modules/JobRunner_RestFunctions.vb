Imports R1SimpleRestClient.Models.Job
Imports R1SimpleRestClient.Models.Response
Imports R1SimpleRestClient.Models.Project
Imports R1SimpleRestClient.Models.Templates
Imports System.Security
Imports R1SimpleRestClient.Models.Alert

Module JobRunner_RestFunctions
    Public Function R1Auth() As AuthToken

        If Main.auth.Data.Message <> "Authenticated" Then
            Dim r1rest As New R1SimpleRestClient.R1SimpleRestClient
            Dim newauth = r1rest.AuthenticateWithR1(Main.txtServer.Text, Main.txtApiUser.Text, ToInsecureString(Main.apipass))
            Main.auth = newauth
            Return newauth
        Else
            Return Main.auth
        End If

    End Function

    Public Sub GetJobTemplates()
        Dim r1rest As New R1SimpleRestClient.R1SimpleRestClient
        If Main.auth.Data.Message <> "Authenticated" Then
            Main.auth = r1rest.AuthenticateWithR1(Main.txtServer.Text, Main.txtApiUser.Text, ToInsecureString(Main.apipass))
        End If
        Dim templates = r1rest.Functions.Templates.GetTemplates(Main.auth, Main.txtServer.Text)
        Main.txtTemplateName.Items.Clear()
        For Each template In templates.Data
            If template.isSystemJob = False Then
                Main.txtTemplateName.Items.Add(template.name)
            End If
        Next

    End Sub

    Public Function GetTemplateInfo(ByVal templateid As String) As ApiResponse(Of TemplateInformation)
        Dim r1rest As New R1SimpleRestClient.R1SimpleRestClient
        If Main.auth.Data.Message <> "Authenticated" Then
            Main.auth = r1rest.AuthenticateWithR1(Main.txtServer.Text, Main.txtApiUser.Text, ToInsecureString(Main.apipass))
        End If
        Return r1rest.Functions.Templates.GetTemplate(Main.auth, Main.txtServer.Text, templateid)


    End Function

    Public Sub GetJobList(Optional Search As String = "")
        Try
            Dim r1rest As New R1SimpleRestClient.R1SimpleRestClient
            If Main.auth.Data.Message <> "Authenticated" Then
                Main.auth = r1rest.AuthenticateWithR1(Main.txtServer.Text, Main.txtApiUser.Text, ToInsecureString(Main.apipass))
            End If
            Dim jobslist As ApiResponse(Of JobData)
            If Not Search = "" Or Search = "Search" Then
                jobslist = r1rest.Functions.Job.GetAllJobs(Main.auth, Main.txtServer.Text, , , , Search)
            Else
                jobslist = r1rest.Functions.Job.GetAllJobs(Main.auth, Main.txtServer.Text)
            End If

            Main.dgvJobsRestJobsList.Rows.Clear()

            For Each job As JobInfo In jobslist.Data.jobs
                Dim CancelStatus
                If job.Status = "Running" Then
                    CancelStatus = "Cancel"
                Else
                    CancelStatus = ""
                End If
                Main.dgvJobsRestJobsList.Rows.Add(New String() {job.Name, job.Status, "Retry", CancelStatus, job.JobType, job.StartDate.ToString, job.EndDate.ToString, job.JobID.ToString, job.ResultID.ToString, "Status"})
            Next
        Catch ex As Exception
        End Try
    End Sub

    Public Sub RetryJob(ByVal JobID As String, ByVal NewJobName As String)
        Try
            Dim r1rest As New R1SimpleRestClient.R1SimpleRestClient
            If Main.auth.Data.Message <> "Authenticated" Then
                Main.auth = r1rest.AuthenticateWithR1(Main.txtServer.Text, Main.txtApiUser.Text, ToInsecureString(Main.apipass))
            End If
            Dim ResubmitJob As New R1SimpleRestClient.Models.Job2.ResubmitJobOptions
            ResubmitJob.JobID = JobID
            ResubmitJob.NewJobName = NewJobName
            ResubmitJob.ResubmissionType = R1SimpleRestClient.Models.Job2.ResubmitType.All
            Dim job = r1rest.Functions.Job.ResubmitJob(Main.auth, Main.txtServer.Text, ResubmitJob)
            GetJobList()
        Catch ex As Exception
        End Try
    End Sub

    Public Sub CancelJob(ByVal JobResultID As String, ByVal CancelSchedule As Boolean)
        Try
            Dim r1rest As New R1SimpleRestClient.R1SimpleRestClient
            If Main.auth.Data.Message <> "Authenticated" Then
                Main.auth = r1rest.AuthenticateWithR1(Main.txtServer.Text, Main.txtApiUser.Text, ToInsecureString(Main.apipass))
            End If
            Dim job = r1rest.Functions.Job.CancelJobResult(Main.auth, Main.txtServer.Text, JobResultID, CancelSchedule)
            GetJobList()
        Catch ex As Exception
        End Try
    End Sub

    Public Sub CancelJobTarget(ByVal JobTargetResultID As List(Of String))
        Try
            Dim r1rest As New R1SimpleRestClient.R1SimpleRestClient
            If Main.auth.Data.Message <> "Authenticated" Then
                Main.auth = r1rest.AuthenticateWithR1(Main.txtServer.Text, Main.txtApiUser.Text, ToInsecureString(Main.apipass))
            End If
            Dim job = r1rest.Functions.Job.CancelJobTargetResults(Main.auth, Main.txtServer.Text, JobTargetResultID)

        Catch ex As Exception
        End Try
    End Sub



    Public Sub DeleteProject(ByVal ProjectID As String)
        Try
            Dim r1rest As New R1SimpleRestClient.R1SimpleRestClient
            If Main.auth.Data.Message <> "Authenticated" Then
                Main.auth = r1rest.AuthenticateWithR1(Main.txtServer.Text, Main.txtApiUser.Text, ToInsecureString(Main.apipass))
            End If
            Dim job = r1rest.Functions.Project.DeleteProject(Main.auth, Main.txtServer.Text, ProjectID)
            GetProjectList("")
        Catch ex As Exception
        End Try
    End Sub

    Public Sub GetEndpointStatusCounts(ByVal JobResultID As String)
        Try
            Dim r1rest As New R1SimpleRestClient.R1SimpleRestClient
            If Main.auth.Data.Message <> "Authenticated" Then
                Main.auth = r1rest.AuthenticateWithR1(Main.txtServer.Text, Main.txtApiUser.Text, ToInsecureString(Main.apipass))
            End If
            Dim job = r1rest.Functions.Job.GetJobStatusCounts(Main.auth, Main.txtServer.Text, JobResultID)
            Main.lblepStatusTotal.Text = "Total: " & job.Data.totalCount
            Main.lblepStatusInProgress.Text = "In Progress: " & job.Data.runningCount
            Main.lblepstatusFailed.Text = "Failed: " & job.Data.failedCount
            Main.lblepstatusSuccessful.Text = "Successful: " & job.Data.completedCount
        Catch ex As Exception
        End Try
    End Sub


    Public Sub GetJobTargets(ByVal JobResultID As String)
        Try
            Dim r1rest As New R1SimpleRestClient.R1SimpleRestClient
            If Main.auth.Data.Message <> "Authenticated" Then
                Main.auth = r1rest.AuthenticateWithR1(Main.txtServer.Text, Main.txtApiUser.Text, ToInsecureString(Main.apipass))
            End If
            Dim jobtargets = r1rest.Functions.Job.GetJobTargets(Main.auth, Main.txtServer.Text, JobResultID)
            Main.dgvEndpointStatusJobTargets.Rows.Clear()

            For Each target In jobtargets.Data.targets
                Dim actionstatus As String = "Cancel"
                If target.status = "Cancelled" Or target.status = "Cancelling" Or target.status = "Completed" Or target.status = "Failed" Then
                    actionstatus = ""
                End If
                Dim targetrow = Main.dgvEndpointStatusJobTargets.Rows.Add(New String() {target.name, target.startDate, target.status, target.hits, target.jobTargetResultId, actionstatus, "Review"})

            Next
        Catch ex As Exception
        End Try
    End Sub

    Public Sub GetProjectList(Optional Search As String = "")
        Try
            Dim r1rest As New R1SimpleRestClient.R1SimpleRestClient
            If Main.auth.Data.Message <> "Authenticated" Then
                Main.auth = r1rest.AuthenticateWithR1(Main.txtServer.Text, Main.txtApiUser.Text, ToInsecureString(Main.apipass))
            End If
            Dim projectlist As ApiResponse(Of List(Of ProjectPresenter))
            If Not Search = "" Or Search = "Search" Then
                projectlist = r1rest.Functions.Project.GetProjectList(Main.auth, Main.txtServer.Text, Search)
            Else
                projectlist = r1rest.Functions.Project.GetProjectList(Main.auth, Main.txtServer.Text)
            End If

            Main.dgvProjectList.Rows.Clear()

            For Each project As ProjectPresenter In projectlist.Data
                Main.dgvProjectList.Rows.Add(New String() {project.Name, project.CreatedDate, project.CreatedByUsername, project.ModifiedDate, project.FtkCaseFolderPath, project.ProjectId})
            Next
        Catch ex As Exception
        End Try
    End Sub

    Public Sub GetProjectList_JobFromTemplate(Optional Search As String = "")
        Try
            Dim r1rest As New R1SimpleRestClient.R1SimpleRestClient
            If Main.auth.Data.Message <> "Authenticated" Then
                Main.auth = r1rest.AuthenticateWithR1(Main.txtServer.Text, Main.txtApiUser.Text, ToInsecureString(Main.apipass))
            End If
            Dim projectlist As ApiResponse(Of List(Of ProjectPresenter))
            If Not Search = "" Or Search = "Search" Then
                projectlist = r1rest.Functions.Project.GetProjectList(Main.auth, Main.txtServer.Text, Search)
            Else
                projectlist = r1rest.Functions.Project.GetProjectList(Main.auth, Main.txtServer.Text)
            End If

            JobFromTemplate.dgvProjectList.Rows.Clear()

            For Each project As ProjectPresenter In projectlist.Data
                JobFromTemplate.dgvProjectList.Rows.Add(New String() {project.Name, project.CreatedDate, project.CreatedByUsername, project.ModifiedDate, project.FtkCaseFolderPath, project.ProjectId})
            Next
        Catch ex As Exception
        End Try
    End Sub

    Public Sub GetTasks()
        Try
            Dim r1rest As New R1SimpleRestClient.R1SimpleRestClient
            If Main.auth.Data.Message <> "Authenticated" Then
                Main.auth = r1rest.AuthenticateWithR1(Main.txtServer.Text, Main.txtApiUser.Text, ToInsecureString(Main.apipass))
            End If
            Dim categories As ApiResponse(Of List(Of Categories))

            categories = r1rest.Functions.Templates.GetCategories(Main.auth, Main.txtServer.Text)

            Main.flowTasks.Controls.Clear()

            For Each category As Categories In categories.Data
                Dim grp As New GroupBox
                grp.Text = category.name
                grp.Parent = Main.flowTasks
                grp.MinimumSize = New Size(250, 100)
                grp.MaximumSize = New Size(450, 350)
                grp.AutoSize = False
                grp.AutoSizeMode = AutoSizeMode.GrowAndShrink
                grp.Size = New Size(275, 175)
                Dim lsttemplate As New ListView
                AddHandler lsttemplate.DoubleClick, AddressOf TaskItemDo
                lsttemplate.MultiSelect = False
                lsttemplate.Parent = grp
                lsttemplate.Dock = DockStyle.Fill
                lsttemplate.AutoSize = False
                lsttemplate.Size = New Size(375, 325)
                lsttemplate.View = View.Details

                Dim col1 = lsttemplate.Columns.Add("Template Name")
                col1.AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent)
                col1.Width = 375
                For Each Template In category.templates
                    Dim item = lsttemplate.Items.Add(Template.name)
                    item.Tag = Template.templateId
                Next
            Next

            Main.flowTasks.Refresh()

        Catch ex As Exception
        End Try
    End Sub

    Public Sub TaskItemDo(ByVal sender As ListView, ByVal e As System.EventArgs)
        If sender.SelectedItems.Count > 0 Then

            JobFromTemplate.JobTemplateID = sender.SelectedItems(0).Tag
            JobFromTemplate.ShowDialog()

        End If
    End Sub

    Public Sub CreateProject(ByVal Name As String, ByVal Description As String, ByVal TBCheck As Boolean, ByVal Server As String, ByVal auth As AuthToken)
        Try
            Dim r1rest As New R1SimpleRestClient.R1SimpleRestClient

            Dim proj As New SimpleNewProject
            proj.name = Name
            proj.description = Description
            proj.feedCheckingEnabled = TBCheck
            proj.processingMode = R1SimpleRestClient.Models.Enums.ProcessModeEnum.Security
            proj.ftkCaseFolderPath = r1rest.Functions.Configuration.GetDefaultProjectsPath(auth, Server).Data
            proj.responsiveFilePath = r1rest.Functions.Configuration.GetDefaultJobDataPath(auth, Server).Data

            Dim project = r1rest.Functions.Project.CreateProjectSimple(auth, Server, proj)

        Catch ex As Exception
        End Try
    End Sub


    Public Sub EditProject(ByVal ProjectID As String, ByVal Name As String, ByVal Description As String, ByVal TBCheck As Boolean, ByVal Server As String, ByVal auth As AuthToken)
        Try
            Dim r1rest As New R1SimpleRestClient.R1SimpleRestClient

            Dim proj As New ProjectPresenter
            proj.ProjectId = ProjectID
            proj.Name = Name
            proj.Description = Description
            proj.FeedCheckingEnabled = TBCheck
            'proj.FtkCaseFolderPath = r1rest.Functions.Configuration.GetDefaultProjectsPath(auth, Server).Data
            'proj.responsiveFilePath = r1rest.Functions.Configuration.GetDefaultJobDataPath(auth, Server).Data

            Dim project = r1rest.Functions.Project.UpdateProject(auth, Server, proj)

        Catch ex As Exception
        End Try
    End Sub

    Public Function GetProjectDetails(ByVal ProjectID As String, ByVal Server As String, ByVal auth As AuthToken) As ApiResponse(Of ProjectPresenter)
        Dim r1rest As New R1SimpleRestClient.R1SimpleRestClient
        Return r1rest.Functions.Project.GetProjectDetails(auth, Server, ProjectID)
    End Function

    Public Sub GetGroups_JobFromTemplate()
        JobFromTemplate.treeGroups.Nodes.Clear()
        Dim rc As New R1SimpleRestClient.R1SimpleRestClient
        Dim groups As R1SimpleRestClient.Models.Groups = rc.Functions.Groups.GetGroups(Main.auth, Main.txtServer.Text).Data
        Dim topnode As TreeNode = JobFromTemplate.treeGroups.Nodes.Add(groups.name)
        topnode.Name = groups.name
        topnode.Tag = groups.id
        For Each group In groups.children
            Dim x As TreeNode = topnode.Nodes.Add(group.name)
            x.Name = group.name
            x.Tag = group.id
            GetAllChildrenGroups(x.Name, group)
        Next
    End Sub

    Private Sub GetAllChildrenGroups(parent As String, children As R1SimpleRestClient.Models.Groups)
        Dim subnode() As TreeNode = JobFromTemplate.treeGroups.Nodes.Find(parent, True)
        If subnode.Count > 0 Then
            For Each subgroup In children.children
                Dim y As TreeNode = subnode(0).Nodes.Add(subgroup.name)
                y.Name = subgroup.name
                y.Tag = subgroup.id
                GetAllChildrenGroups(y.Name, subgroup)
            Next
        End If
    End Sub


    Public Sub GetGroupComputer_JobFromTemplate(ByVal GroupID As String, Optional count As Integer = 100, Optional start As Integer = 0, Optional Search As String = "")
        Try
            Dim r1rest As New R1SimpleRestClient.R1SimpleRestClient
            If Main.auth.Data.Message <> "Authenticated" Then
                Main.auth = r1rest.AuthenticateWithR1(Main.txtServer.Text, Main.txtApiUser.Text, ToInsecureString(Main.apipass))
            End If
            Dim endpoints = r1rest.Functions.Computers.GetGroupComputers(Main.auth, Main.txtServer.Text, GroupID, count, start, Search)
            JobFromTemplate.dgvTargetEndpoints.Rows.Clear()
            For Each endpoint In endpoints.Data.computers
                JobFromTemplate.dgvTargetEndpoints.Rows.Add(New String() {False, endpoint.computerName, endpoint.ipAddressLastContacted, endpoint.agentOS, endpoint.agentLastContacted, endpoint.computerId})
            Next
        Catch ex As Exception
        End Try
    End Sub

    Public Sub CreateFromTemplate(ByVal Job As R1SimpleRestClient.Models.Job2.JobFromTemplate)
        Try
            Dim r1rest As New R1SimpleRestClient.R1SimpleRestClient
            If Main.auth.Data.Message <> "Authenticated" Then
                Main.auth = r1rest.AuthenticateWithR1(Main.txtServer.Text, Main.txtApiUser.Text, ToInsecureString(Main.apipass))
            End If
            r1rest.Functions.Job.CreateJobFromTemplate(Main.auth, Main.txtServer.Text, Job, True)

        Catch ex As Exception
        End Try
    End Sub

    Public Sub LoadAlerts()
        Try
            Dim r1rest As New R1SimpleRestClient.R1SimpleRestClient
            If Main.auth.Data.Message <> "Authenticated" Then
                Main.auth = r1rest.AuthenticateWithR1(Main.txtServer.Text, Main.txtApiUser.Text, ToInsecureString(Main.apipass))
            End If

            Dim Alerts As AlertsWithCounts = r1rest.Functions.Alert.GetAlertsWithCounts(Main.auth, Main.txtServer.Text)
            Main.dgvAlerts.Rows.Clear()
            Main.flowAlertBreakdown.Controls.Clear()
            Main.flowResponseTime.Controls.Clear()
            Main.flowTotalResponses.Controls.Clear()

            For Each alert As AlertDataDetails In Alerts.entities
                Main.dgvAlerts.Rows.Add(New String() {alert.artifactName, alert.createDate, alert.severity, alert.target, alert.source, alert.caseName, alert.confidence, alert.virusTotalMax})
            Next


            Dim alertSrcBreakdowns As List(Of AlertSourceBreakdownResult) = r1rest.Functions.Alert.GetAlertSourceBreakdown(Main.auth, Main.txtServer.Text)
            Dim totalcount As Integer = 0
            For Each alertSrc As AlertSourceBreakdownResult In alertSrcBreakdowns
                Dim alertlabel As New Label
                alertlabel.Parent = Main.flowAlertBreakdown
                alertlabel.AutoSize = True
                alertlabel.Dock = DockStyle.Fill
                alertlabel.Font = New Font(alertlabel.Font.FontFamily, 11)
                alertlabel.Text = alertSrc.Count & "  (" & alertSrc.Percent & "%)" & vbCrLf & alertSrc.Name
                totalcount += alertSrc.Count
            Next
            Main.lblTotalNumberAlerts.Text = "Total Number of Alerts: " & totalcount


            Main.lblTotalNumberofResponses.Text = "Total Number of Responses: " & r1rest.Functions.Alert.GetTotalResponses(Main.auth, Main.txtServer.Text)
            Dim responselabel As New Label
            responselabel.Parent = Main.flowTotalResponses
            responselabel.AutoSize = True
            responselabel.Dock = DockStyle.Fill
            responselabel.Font = New Font(responselabel.Font.FontFamily, 11)
            responselabel.Text = r1rest.Functions.Alert.GetTotalAutomatedResponses(Main.auth, Main.txtServer.Text) & vbCrLf & "Automated Responses"



            Dim meantime As List(Of MeanTimeStatistics) = r1rest.Functions.Alert.GetMeanTimeStatistics(Main.auth, Main.txtServer.Text)
            If meantime.Count > 0 Then
                Dim timelabel As New Label
                timelabel.Parent = Main.flowResponseTime
                timelabel.AutoSize = True
                timelabel.Dock = DockStyle.Fill
                timelabel.Font = New Font(responselabel.Font.FontFamily, 11)
                timelabel.Text = meantime(0).meanTime & vbCrLf & "Mean Time"
            Else

            End If


        Catch ex As Exception
        End Try

    End Sub

End Module
