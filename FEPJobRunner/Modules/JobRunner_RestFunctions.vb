Imports FEPRestClient.Models.Job
Imports FEPRestClient.Models.Response
Imports FEPRestClient.Models.Project
Imports FEPRestClient.Models.Templates
Imports System.Security
Imports FEPRestClient.Models.Alert
Imports FEPRestClient.Models.ThreatFilters
Imports FEPRestClient.Models.Enums
Imports FEPRestClient.Models

Module JobRunner_RestFunctions


    Public Sub GetJobTemplates()

        If Main.RestClient.IsAuthenticated = False Then
            Main.RestClient.Authenticate()
        End If

        Dim templates = Main.RestClient.Functions.Templates.GetTemplates()
        Main.txtTemplateName.Items.Clear()
        For Each template In templates.Data
            If template.isSystemJob = False Then
                Main.txtTemplateName.Items.Add(template.name)
            End If
        Next

    End Sub

    Public Function GetProjectFacets()

        If Main.RestClient.IsAuthenticated = False Then
            Main.RestClient.Authenticate()
        End If

        Dim facets = Main.RestClient.Functions.Project.GetProjectFacets()
        Dim cmenu As New ContextMenuStrip


        For Each facet In facets.Data
            Dim mitem As New ToolStripMenuItem(facet.Label)
            mitem.Tag = facet.Key
            AddHandler mitem.DropDownItemClicked, AddressOf Main.projsearchmenu_Click

            If facet.TotalOptions > 0 Then
                For Each opt In facet.Options
                    Dim optitem As New ToolStripMenuItem(opt.Label)
                    optitem.Tag = opt.Key
                    mitem.DropDownItems.Add(optitem)
                Next
            End If
            cmenu.Items.Add(mitem)
        Next
        Dim citem As New ToolStripTextBox("Search")
        citem.Text = "Search"
        citem.Tag = "Search"
        AddHandler citem.KeyDown, AddressOf Main.projsearchmenu_txtEnter

        cmenu.Items.Add(citem)

        Return cmenu

    End Function

    Public Function GetJobFacets()

        If Main.RestClient.IsAuthenticated = False Then
            Main.RestClient.Authenticate()
        End If

        Dim facets = Main.RestClient.Functions.Job.GetJobResultsFacets
        Dim cmenu As New ContextMenuStrip


        For Each facet In facets.Data
            Dim mitem As New ToolStripMenuItem(facet.Label)
            mitem.Tag = facet.Key
            AddHandler mitem.DropDownItemClicked, AddressOf Main.jobsearchmenu_Click

            If facet.TotalOptions > 0 Then
                For Each opt In facet.Options
                    Dim optitem As New ToolStripMenuItem(opt.Label)
                    optitem.Tag = opt.Key
                    mitem.DropDownItems.Add(optitem)
                Next
            End If
            cmenu.Items.Add(mitem)
        Next
        Dim citem As New ToolStripTextBox("Search")
        citem.Text = "Search"
        citem.Tag = "Search"
        AddHandler citem.KeyDown, AddressOf Main.jobsearchmenu_txtEnter

        cmenu.Items.Add(citem)

        Return cmenu

    End Function

    Public Function GetTemplateInfo(ByVal templateid As String) As ApiResponse(Of TemplateInformation)

        If Main.RestClient.IsAuthenticated = False Then
            Main.RestClient.Authenticate()
        End If
        Return Main.RestClient.Functions.Templates.GetTemplate(templateid)


    End Function

    Public Sub GetJobList(Optional Search As FEPRestClient.Models.FacetSearch = Nothing)
        Try
            If Main.RestClient.IsAuthenticated = False Then
                Main.RestClient.Authenticate()
            End If
            Dim jobslist As ApiResponse(Of JobData)
            If Not Search Is Nothing Then
                jobslist = Main.RestClient.Functions.Job.GetAllJobs(, 90000, , Search)
            Else
                jobslist = Main.RestClient.Functions.Job.GetAllJobs(, 90000)
            End If

            Main.dgvJobsRestJobsList.Rows.Clear()

            For Each job As JobInfo In jobslist.Data.jobs
                Dim CancelStatus
                If job.Status = "Running" Then
                    CancelStatus = "Cancel"
                Else
                    CancelStatus = ""
                End If
                Main.dgvJobsRestJobsList.Rows.Add(New String() {job.Name, job.Status, "Retry", CancelStatus, job.JobType, job.StartDate.ToString, job.EndDate.ToString, job.JobID.ToString, job.ResultID.ToString, "Status", "Result"})
            Next
        Catch ex As Exception
            DebugWriteLine(ex.Message)
        End Try
    End Sub

    Public Sub RetryJob(ByVal JobID As String, ByVal NewJobName As String)
        Try
            If Main.RestClient.IsAuthenticated = False Then
                Main.RestClient.Authenticate()
            End If
            Dim ResubmitJob As New FEPRestClient.Models.Job2.ResubmitJobOptions
            ResubmitJob.JobID = JobID
            ResubmitJob.NewJobName = NewJobName
            ResubmitJob.ResubmissionType = FEPRestClient.Models.Job2.ResubmitType.All
            Dim job = Main.RestClient.Functions.Job.ResubmitJob(ResubmitJob)
            GetJobList()
        Catch ex As Exception
            DebugWriteLine(ex.Message)
        End Try
    End Sub

    Public Sub CancelJob(ByVal JobResultID As String, ByVal CancelSchedule As Boolean)
        Try
            If Main.RestClient.IsAuthenticated = False Then
                Main.RestClient.Authenticate()
            End If
            Dim job = Main.RestClient.Functions.Job.CancelJobResult(JobResultID, CancelSchedule)
            GetJobList()
        Catch ex As Exception
            DebugWriteLine(ex.Message)
        End Try
    End Sub

    Public Sub CancelJobTarget(ByVal JobTargetResultID As List(Of String))
        Try
            If Main.RestClient.IsAuthenticated = False Then
                Main.RestClient.Authenticate()
            End If
            Dim job = Main.RestClient.Functions.Job.CancelJobTargetResults(JobTargetResultID)

        Catch ex As Exception
            DebugWriteLine(ex.Message)
        End Try
    End Sub



    Public Sub DeleteProject(ByVal ProjectID As String)
        Try
           If Main.RestClient.IsAuthenticated = False Then
                Main.RestClient.Authenticate()
            End If
            Dim job = Main.RestClient.Functions.Project.DeleteProject(ProjectID)
            GetProjectList()
        Catch ex As Exception
            DebugWriteLine(ex.Message)
        End Try
    End Sub

    Public Sub GetEndpointStatusCounts(ByVal JobResultID As String)
        Try
   If Main.RestClient.IsAuthenticated = False Then
                Main.RestClient.Authenticate()
            End If
            Dim job = Main.RestClient.Functions.Job.GetJobStatusCounts(JobResultID)
            Main.lblepStatusTotal.Text = "Total: " & job.Data.totalCount
            Main.lblepStatusInProgress.Text = "In Progress: " & job.Data.runningCount
            Main.lblepstatusFailed.Text = "Failed: " & job.Data.failedCount
            Main.lblepstatusSuccessful.Text = "Successful: " & job.Data.completedCount
        Catch ex As Exception
            DebugWriteLine(ex.Message)
        End Try
    End Sub


    Public Sub GetJobTargets(ByVal JobResultID As String, Optional Search As String = "")
        Try
         If Main.RestClient.IsAuthenticated = False Then
                Main.RestClient.Authenticate()
            End If
            Dim jobtargets = Main.RestClient.Functions.Job.GetJobTargets(JobResultID, , , , Search)
            Main.dgvEndpointStatusJobTargets.Rows.Clear()
            Main.lblJobName.Text = jobtargets.Data.jobName
            For Each target In jobtargets.Data.targets
                Dim actionstatus As String = "Cancel"
                If target.status = "Cancelled" Or target.status = "Cancelling" Or target.status = "Completed" Or target.status = "Failed" Then
                    actionstatus = ""
                End If
                Dim targetrow = Main.dgvEndpointStatusJobTargets.Rows.Add(New String() {target.name, target.startDate, target.status, target.hits, target.jobTargetResultId, actionstatus, "Review"})

            Next
        Catch ex As Exception
            DebugWriteLine(ex.Message)
        End Try
    End Sub

    Public Sub GetProjectList(Optional Search As FEPRestClient.Models.FacetSearch = Nothing)
        Try
            If Main.RestClient.IsAuthenticated = False Then
                Main.RestClient.Authenticate()
            End If
            Dim projectlist As ApiResponse(Of List(Of ProjectPresenter))
            If Not Search Is Nothing Then
                projectlist = Main.RestClient.Functions.Project.GetProjectList(Search)
            Else
                projectlist = Main.RestClient.Functions.Project.GetProjectList()
            End If

            Main.dgvProjectList.Rows.Clear()

            For Each project As ProjectPresenter In projectlist.Data
                Main.dgvProjectList.Rows.Add(New String() {project.Name, project.CreatedDate, project.CreatedByUsername, project.ModifiedDate, project.FtkCaseFolderPath, project.ProjectId})
            Next
        Catch ex As Exception
            DebugWriteLine(ex.Message)
        End Try
    End Sub

    Public Sub GetProjectList_JobFromTemplate(Optional Search As String = "")
        Try
              If Main.RestClient.IsAuthenticated = False Then
                Main.RestClient.Authenticate()
            End If
            Dim projectlist As ApiResponse(Of List(Of ProjectPresenter))
            If Not Search = "" Or Search = "Search" Then
                projectlist = Main.RestClient.Functions.Project.GetProjectList()
            Else
                projectlist = Main.RestClient.Functions.Project.GetProjectList()
            End If

            Form_JobFromTemplate.dgvProjectList.Rows.Clear()

            For Each project As ProjectPresenter In projectlist.Data
                Form_JobFromTemplate.dgvProjectList.Rows.Add(New String() {project.Name, project.CreatedDate, project.CreatedByUsername, project.ModifiedDate, project.FtkCaseFolderPath, project.ProjectId})
            Next
        Catch ex As Exception
            DebugWriteLine(ex.Message)
        End Try
    End Sub

    Public Sub GetThreatFilterList_JobFromTemplate(Optional Search As String = "")
        Try
              If Main.RestClient.IsAuthenticated = False Then
                Main.RestClient.Authenticate()
            End If
            Dim threatfilterlist As ApiResponse(Of List(Of ThreatFilterInfo))

            If String.IsNullOrWhiteSpace(Search) Or Search = "" Or Search = "Search" Then
                threatfilterlist = Main.RestClient.Functions.ThreatFilters.GetThreatFilters(1, 50)
            Else
                Dim srch As String = "(FilterName.Contains(""" & Search & """)) OR (Description.Contains(""" & Search & """)) OR (Source.Contains(""" & Search & _
                                 """)) OR (AuthoredBy.Contains(""" & Search & """)) OR (Category.Contains(""" & Search & """)) OR (Groups.Contains(""" & Search & """)) OR (Tags.Contains(""" & Search & """))"
                threatfilterlist = Main.RestClient.Functions.ThreatFilters.GetThreatFilters(1, 50, srch)
            End If



            Form_JobFromTemplate.dgvThreatFilters.Rows.Clear()
            If threatfilterlist.Data.Count > 0 Then
                For Each tfilter In threatfilterlist.Data
                    Form_JobFromTemplate.dgvThreatFilters.Rows.Add(New String() {False, tfilter.Name, "View", tfilter.Description, tfilter.Source, tfilter.AuthoredDate, tfilter.AuthoredBy, tfilter.FilterType.ToString, tfilter.Category, tfilter.Groups, tfilter.Tags, tfilter.FilterId})
                Next
            End If
        Catch ex As Exception
            DebugWriteLine(ex.Message)
        End Try
    End Sub

    Public Sub GetTasks()
        Try
           If Main.RestClient.IsAuthenticated = False Then
                Main.RestClient.Authenticate()
            End If
            Dim categories As ApiResponse(Of List(Of Categories))

            categories = Main.RestClient.Functions.Templates.GetCategories()

            Main.flowTasks.Controls.Clear()

            For Each category As Categories In categories.Data
                Dim grp As New GroupBox
                grp.Text = category.name
                grp.Parent = Main.flowTasks
                grp.MinimumSize = New Size(300, 175)
                grp.MaximumSize = New Size((Main.flowTasks.Width / 2), 200)
                grp.AutoSize = True
                grp.AutoSizeMode = AutoSizeMode.GrowOnly
                ' grp.Size = New Size((Main.flowTasks.Width / 2) - 10, 175)
                Dim lsttemplate As New ListView
                AddHandler lsttemplate.DoubleClick, AddressOf TaskItemDo
                lsttemplate.MultiSelect = False
                lsttemplate.HeaderStyle = ColumnHeaderStyle.None
                lsttemplate.Dock = DockStyle.Fill
                lsttemplate.AutoSize = True
                ' lsttemplate.Size = New Size(375, 325)
                lsttemplate.View = View.Details
                lsttemplate.FullRowSelect = True
                Dim col1 = lsttemplate.Columns.Add("")
                ' col1.Width = 375
                For Each Template In category.templates
                    Dim item = lsttemplate.Items.Add(Template.name)
                    item.Tag = Template.templateId
                Next
                col1.AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent)
                lsttemplate.Parent = grp

            Next

            Main.flowTasks.Refresh()

        Catch ex As Exception
            DebugWriteLine(ex.Message)
        End Try
    End Sub

    Public Sub TaskItemDo(ByVal sender As ListView, ByVal e As System.EventArgs)
        If sender.SelectedItems.Count > 0 Then

            Form_JobFromTemplate.JobTemplateID = sender.SelectedItems(0).Tag
            Form_JobFromTemplate.ShowDialog()

        End If
    End Sub

    Public Sub CreateProject(ByVal Name As String, ByVal Description As String, ByVal TBCheck As Boolean, ByVal Server As String, ByVal auth As AuthToken)
        Try
            If Main.RestClient.IsAuthenticated = False Then
                Main.RestClient.Authenticate()
            End If

            Dim proj As New SimpleNewProject
            proj.name = Name
            proj.description = Description
            proj.feedCheckingEnabled = TBCheck
            proj.processingMode = FEPRestClient.Models.Enums.ProcessModeEnum.Security
            proj.ftkCaseFolderPath = Main.RestClient.Functions.Configuration.GetDefaultProjectsPath().Data
            proj.responsiveFilePath = Main.RestClient.Functions.Configuration.GetDefaultJobDataPath().Data

            Dim project = Main.RestClient.Functions.Project.CreateProjectSimple(proj)

        Catch ex As Exception
            DebugWriteLine(ex.Message)
        End Try
    End Sub


    Public Sub EditProject(ByVal ProjectID As String, ByVal Name As String, ByVal Description As String, ByVal TBCheck As Boolean, ByVal Server As String, ByVal auth As AuthToken)
        Try
            If Main.RestClient.IsAuthenticated = False Then
                Main.RestClient.Authenticate()
            End If
            Dim proj As New ProjectPresenter
            proj.ProjectId = ProjectID
            proj.Name = Name
            proj.Description = Description
            proj.FeedCheckingEnabled = TBCheck
            'proj.FtkCaseFolderPath = Main.RestClient.Functions.Configuration.GetDefaultProjectsPath(auth, Server).Data
            'proj.responsiveFilePath = Main.RestClient.Functions.Configuration.GetDefaultJobDataPath(auth, Server).Data

            Dim project = Main.RestClient.Functions.Project.UpdateProject(proj)

        Catch ex As Exception
            DebugWriteLine(ex.Message)
        End Try
    End Sub

    Public Function GetProjectDetails(ByVal ProjectID As String) As ApiResponse(Of ProjectPresenter)
        If Main.RestClient.IsAuthenticated = False Then
            Main.RestClient.Authenticate()
        End If
        Return Main.RestClient.Functions.Project.GetProjectDetails(ProjectID)
    End Function

    Public Sub GetGroups_JobFromTemplate()
        Form_JobFromTemplate.treeGroups.Nodes.Clear()
        If Main.RestClient.IsAuthenticated = False Then
            Main.RestClient.Authenticate()
        End If
        Dim groups As FEPRestClient.Models.Groups = Main.RestClient.Functions.Groups.GetGroups().Data
        Dim topnode As TreeNode = Form_JobFromTemplate.treeGroups.Nodes.Add(groups.name)
        topnode.Name = groups.name
        topnode.Tag = groups.id
        For Each group In groups.children
            Dim x As TreeNode = topnode.Nodes.Add(group.name)
            x.Name = group.name
            x.Tag = group.id
            GetAllChildrenGroups(x.Name, group)
        Next
    End Sub

    Private Sub GetAllChildrenGroups(parent As String, children As FEPRestClient.Models.Groups)
        Dim subnode() As TreeNode = Form_JobFromTemplate.treeGroups.Nodes.Find(parent, True)
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
         If Main.RestClient.IsAuthenticated = False Then
                Main.RestClient.Authenticate()
            End If
            Dim endpoints = Main.RestClient.Functions.Computers.GetGroupComputers(GroupID, count, start, Search)

            Form_JobFromTemplate.dgvTargetEndpoints.Rows.Clear()
            For Each endpoint In endpoints.Data.computers
                Form_JobFromTemplate.dgvTargetEndpoints.Rows.Add(New String() {True, endpoint.computerName, endpoint.ipAddressLastContacted, endpoint.agentOS, endpoint.agentLastContacted, endpoint.computerId})
            Next
        Catch ex As Exception
            DebugWriteLine(ex.Message)
        End Try
    End Sub

    Public Function CreateFromTemplate(ByVal Job As FEPRestClient.Models.Job2.JobFromTemplate, ByVal Execute As Boolean)
        Try
             If Main.RestClient.IsAuthenticated = False Then
                Main.RestClient.Authenticate()
            End If
            Return Main.RestClient.Functions.Job.CreateJobFromTemplate(Job, Execute)

        Catch ex As Exception
            DebugWriteLine(ex.Message)
            Return ex.Message
        End Try
    End Function

    Public Function GetSetJobStatus(ByVal JobID As String, ByVal Status As JobAction)
        Try
        If Main.RestClient.IsAuthenticated = False Then
                Main.RestClient.Authenticate()
            End If
            Return Main.RestClient.Functions.Job.GetSetJobStatus(JobID, Status)

        Catch ex As Exception
            DebugWriteLine(ex.Message)
            Return ex.Message
        End Try
    End Function

    Public Function SetThreatScanOptions(ByVal JobID As String, ByVal Options As Job2.ThreatScanJobOptions)
        Try
        If Main.RestClient.IsAuthenticated = False Then
                Main.RestClient.Authenticate()
            End If
            Return Main.RestClient.Functions.Job.ThreatScanOptioms(JobID, Options)

        Catch ex As Exception
            DebugWriteLine(ex.Message)
            Return ex.Message
        End Try
    End Function

    Public Function SetJobSchedule(ByVal JobID As String, ByVal IsIncremental As Boolean, ByVal Schedule As Job2.SchedulerEventCore)
        Try
            If Main.RestClient.IsAuthenticated = False Then
                Main.RestClient.Authenticate()
            End If
            Return Main.RestClient.Functions.Job.SetJobSchedule(JobID, IsIncremental, Schedule)

        Catch ex As Exception
            DebugWriteLine(ex.Message)
            Return ex.Message
        End Try
    End Function

    Public Sub LoadAlerts()
        Try
    If Main.RestClient.IsAuthenticated = False Then
                Main.RestClient.Authenticate()
            End If
            Dim Alerts As AlertsWithCounts = Main.RestClient.Functions.Alert.GetAlertsWithCounts()
            Main.dgvAlerts.Rows.Clear()
            Main.flowAlertBreakdown.Controls.Clear()
            Main.flowResponseTime.Controls.Clear()
            Main.flowTotalResponses.Controls.Clear()

            For Each alert As AlertDataDetails In Alerts.entities
                Main.dgvAlerts.Rows.Add(New String() {alert.artifactName, alert.createDate, alert.severity, alert.target, alert.source, alert.caseName, alert.confidence, alert.virusTotalMax})
            Next



            Dim responsecount = Main.RestClient.Functions.Alert.GetTotalResponses()
            Main.lblTotalNumberofResponses.Text = "Total Number of Responses: " & responsecount
            Dim autoresponselabel As New Label
            autoresponselabel.Parent = Main.flowTotalResponses
            autoresponselabel.AutoSize = True
            autoresponselabel.Dock = DockStyle.Fill
            autoresponselabel.Font = New Font(autoresponselabel.Font.FontFamily, 11)
            Dim autoresponsecount = Main.RestClient.Functions.Alert.GetTotalAutomatedResponses()
            autoresponselabel.Text = autoresponsecount & vbCrLf & "Automated Responses"
            Dim manualresponselabel As New Label
            manualresponselabel.Parent = Main.flowTotalResponses
            manualresponselabel.AutoSize = True
            manualresponselabel.Dock = DockStyle.Fill
            manualresponselabel.Font = New Font(manualresponselabel.Font.FontFamily, 11)
            manualresponselabel.Text = responsecount - autoresponsecount & vbCrLf & "Manual Responses"

            Dim alertSrcBreakdowns As List(Of AlertSourceBreakdownResult) = Main.RestClient.Functions.Alert.GetAlertSourceBreakdown()
            Dim totalcount As Integer = 0
            Dim proactivecount As Integer = 0

            For Each alertSrc As AlertSourceBreakdownResult In alertSrcBreakdowns
                Dim alertlabel As New Label
                alertlabel.Parent = Main.flowAlertBreakdown
                alertlabel.AutoSize = True
                alertlabel.Dock = DockStyle.Fill
                alertlabel.Font = New Font(alertlabel.Font.FontFamily, 11)
                alertlabel.Text = alertSrc.Count & "  (" & alertSrc.Percent & "%)" & vbCrLf & alertSrc.Name
                totalcount += alertSrc.Count
                If alertSrc.Name.Contains("Validated") Then
                    proactivecount += alertSrc.Count
                End If
            Next
            Main.lblTotalNumberAlerts.Text = "Total Number of Alerts: " & totalcount
            Dim proactivehunt As New Label
            proactivehunt.Parent = Main.flowTotalResponses
            proactivehunt.AutoSize = True
            proactivehunt.Dock = DockStyle.Fill
            proactivehunt.Font = New Font(manualresponselabel.Font.FontFamily, 11)
            proactivehunt.Text = proactivecount & vbCrLf & "Proactive Hunting Validation Count"

            Dim meantime As List(Of MeanTimeStatistics) = Main.RestClient.Functions.Alert.GetMeanTimeStatistics()
            If meantime.Count > 0 Then
                For Each time In meantime
                    Dim timelabel As New Label
                    timelabel.Parent = Main.flowResponseTime
                    timelabel.AutoSize = True
                    timelabel.Dock = DockStyle.Fill
                    timelabel.Font = New Font(timelabel.Font.FontFamily, 11)
                    Select Case time.responseTimeType
                        Case MeanResponseTimeType.MeanTimeToRemediate
                            timelabel.Text = time.meanTime & vbCrLf & "Average Time to Remediate"
                        Case MeanResponseTimeType.MeanTimeToResolve
                            timelabel.Text = time.meanTime & vbCrLf & "Average Time to Resolve"
                        Case MeanResponseTimeType.MeanTimeToResponse
                            timelabel.Text = time.meanTime & vbCrLf & "Average Time to Reponse"
                        Case MeanResponseTimeType.MeanTimeToValidate
                            timelabel.Text = time.meanTime & vbCrLf & "Average Time to Validate"
                    End Select

                Next

            Else

            End If


        Catch ex As Exception
            DebugWriteLine(ex.Message)
        End Try

    End Sub

End Module
