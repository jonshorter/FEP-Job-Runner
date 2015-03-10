Module BoxedJobs

    Public Function BoxedJob1(ByVal Server As String, ByVal Project As String, ByVal apiUser As String, ByVal apiPass As String, ByVal target As String)

        Dim ar_sf() As AgentRemediation_SendFile
        Dim ar_ef() As AgentRemediation_Erase
        Dim ar_ex() As AgentRemediation_Execute
    
        Dim ar_pids() As String
        Dim ar_pnames() As String

        Dim templatename = "coll-evtx"

        ar_sf = New AgentRemediation_SendFile() {}
        ar_ef = New AgentRemediation_Erase() {}
        ar_ex = New AgentRemediation_Execute() {}

        ' remediatesendfile = New R1API.JobsService.ArrayOfJobOptionsOperationsAgentRemediationSendFileJobOptionsOperationsAgentRemediationSendFile() {}

        Dim cnames(0) As String
        cnames(0) = target

        Dim snames() As String
        snames = Jobs.nullstring
        ar_pids = Jobs.nullstring
        ar_pnames = Jobs.nullstring

        'job 1 filter opts
        Dim inclfilter As New InclFilter
        inclfilter.FilterName = "Collection1 Test"
        inclfilter.Extensions = "txt"
        inclfilter.PathURLContains = "Users"

        Dim exclfilter As New ExclFilter

        'Generate Inclusion/Exclusion Filters
        Dim filter As String = Jobs.BuildFilterJSON(inclfilter, exclfilter)


        'Kick off the job
        Dim jobid = Jobs.RunFromTemplateName(Server, templatename, "Collection1 Test", Project, apiUser, apiPass, cnames, snames, filter, ar_pids, ar_pnames, ar_sf, ar_ex, ar_ef)


     

        Return jobid

    End Function
End Module
