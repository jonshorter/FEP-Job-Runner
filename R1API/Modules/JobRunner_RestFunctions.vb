Imports R1SimpleRestClient.Models.Job
Imports R1SimpleRestClient.Models.Response
Imports R1SimpleRestClient.Models.Project
Imports R1SimpleRestClient.Models.Templates
Imports System.Security

Module JobRunner_RestFunctions
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

                Main.dgvEndpointStatusJobTargets.Rows.Add(New String() {target.name, target.startDate, target.status, target.hits, "Action"})
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
                Main.dgvProjectList.Rows.Add(New String() {project.Name, project.CreatedDate, project.CreatedByUsername, project.ModifiedDate, project.FtkCaseFolderPath})
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
                Dim lsttemplate As New ListBox
                lsttemplate.Parent = grp
                lsttemplate.Dock = DockStyle.Fill
                For Each Template In category.templates
                    lsttemplate.Items.Add(Template.name)
                Next
            Next

            Main.flowTasks.Refresh()
         
        Catch ex As Exception
        End Try
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

End Module
