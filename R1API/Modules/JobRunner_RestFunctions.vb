Imports R1SimpleRestClient.Models.Job
Imports R1SimpleRestClient.Models.Response

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
            Main.dgvJobsRestJobsList.Rows.Add(New String() {job.Name, job.Status, job.JobType, job.StartDate.ToString, job.EndDate.ToString, job.JobID.ToString})
        Next

    End Sub
End Module
