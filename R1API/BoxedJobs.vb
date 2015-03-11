Imports Newtonsoft.Json
Imports System.Runtime.CompilerServices
Imports R1API.JobsService
Imports Newtonsoft.Json.Linq

Module BoxedJobs

    Public Class BoxedJob
        Public BoxJobName As String
        Public R1JobName As String
        Public R1Project As String
        Public R1Template As String
        Public R1Filter As String
        Public R1_AR_Send() As JobsService.ArrayOfJobOptionsOperationsAgentRemediationSendFileJobOptionsOperationsAgentRemediationSendFile
        Public R1_AR_Execute() As JobsService.ArrayOfJobOptionsOperationsAgentRemediationExecuteJobOptionsOperationsAgentRemediationExecute
        Public R1_AR_Erase() As JobsService.ArrayOfJobOptionsOperationsAgentRemediationEraseJobOptionsOperationsAgentRemediationErase
        Public R1_AR_PIDS() As String
        Public R1_AR_ProcessNames() As String


    End Class

    Public Function BoxedJob1(ByVal Server As String, ByVal Project As String, ByVal apiUser As String, ByVal apiPass As String, ByVal target As String)

        Dim ar_sf(1) As JobsService.ArrayOfJobOptionsOperationsAgentRemediationSendFileJobOptionsOperationsAgentRemediationSendFile
        Dim ar_ef(1) As JobsService.ArrayOfJobOptionsOperationsAgentRemediationEraseJobOptionsOperationsAgentRemediationErase
        Dim ar_ex(1) As JobsService.ArrayOfJobOptionsOperationsAgentRemediationExecuteJobOptionsOperationsAgentRemediationExecute

        Dim ar_pids(1) As String
        Dim ar_pnames(1) As String

        Dim templatename = "coll-evtx"
        '  Dim templatename = "Remediate-PID"

        ar_sf(0) = New JobsService.ArrayOfJobOptionsOperationsAgentRemediationSendFileJobOptionsOperationsAgentRemediationSendFile
        ar_sf(1) = New JobsService.ArrayOfJobOptionsOperationsAgentRemediationSendFileJobOptionsOperationsAgentRemediationSendFile
        ar_ef(0) = New JobsService.ArrayOfJobOptionsOperationsAgentRemediationEraseJobOptionsOperationsAgentRemediationErase
        ar_ef(1) = New JobsService.ArrayOfJobOptionsOperationsAgentRemediationEraseJobOptionsOperationsAgentRemediationErase
        ar_ex(0) = New JobsService.ArrayOfJobOptionsOperationsAgentRemediationExecuteJobOptionsOperationsAgentRemediationExecute
        ar_ex(1) = New JobsService.ArrayOfJobOptionsOperationsAgentRemediationExecuteJobOptionsOperationsAgentRemediationExecute


        ' Dim ar_sf0 As New R1API.JobsService.ArrayOfJobOptionsOperationsAgentRemediationSendFileJobOptionsOperationsAgentRemediationSendFile
        ar_sf(0).FileToSend = "\\testing\share1\1.pid"
        ar_sf(0).RemotePath = "c:\test\1.pid"
        ar_sf(0).IsRelative = vbNull
        ar_sf(0).OverwriteIfExists = vbNull
        ar_sf(1).FileToSend = "\\what\share\2.pid"
        ar_sf(1).RemotePath = "c:\test2\2.pid"
        'set

        ar_ef(0).RemotePath = "\\test\share\text.pdf"
        ar_ef(1).RemotePath = "\\test\remote2\text2.psd"

        ar_ex(0).Executable = "\\test\remote2.text2.psd"
        ar_ex(1).Executable = "\\test\remote3.text5.pst"

        ar_pids(0) = "100"
        ar_pids(1) = "250"

        ar_pnames(0) = "explorer.exe"
        ar_pnames(1) = "calc.exe"

        ' ar_sf = New AgentRemediation_SendFile() {}
        'ar_ef = New JobsService.ArrayOfJobOptionsOperationsAgentRemediationEraseJobOptionsOperationsAgentRemediationErase() {}
        'ar_ex = New JobsService.ArrayOfJobOptionsOperationsAgentRemediationExecuteJobOptionsOperationsAgentRemediationExecute() {}

        ' remediatesendfile = New R1API.JobsService.ArrayOfJobOptionsOperationsAgentRemediationSendFileJobOptionsOperationsAgentRemediationSendFile() {}

        Dim cnames(0) As String
        cnames(0) = target

        Dim snames() As String
        snames = Jobs.nullstring
        ' ar_pids = Jobs.nullstring
        ' ar_pnames = Jobs.nullstring

        'job 1 filter opts
        Dim inclfilter As New InclusionFilter
        inclfilter.FilterName = "Collection1 Test"
        inclfilter.Extensions = "txt"
        inclfilter.PathURLContains = "Users"
        Dim inclfilter2 As New InclusionFilter
        inclfilter2.FilterName = "Collection2 Test"
        inclfilter2.Extensions = "doc"
        inclfilter2.PathURLContains = "Users"

        Dim exclfilter As New ExclusionFilter
        exclfilter.FilterName = "Ignore 1"
        exclfilter.Extensions = "exe"

        Dim exclfilter2 As New ExclusionFilter
        exclfilter2.FilterName = "Ignore 2"
        exclfilter2.Extensions = "dll"

        Dim incllist As New List(Of InclusionFilter)
        incllist.Add(inclfilter)
        incllist.Add(inclfilter2)

        Dim excllist As New List(Of ExclusionFilter)
        excllist.Add(exclfilter)
        excllist.Add(exclfilter2)

        'Generate Inclusion/Exclusion Filters
        Dim filter As String = Jobs.BuildFilterJSON(incllist, excllist)

        'Kick off the job
        '  Dim jobid = Jobs.RunFromTemplateName(Server, templatename, "Collection1 Test", Project, apiUser, apiPass, cnames, snames, filter, ar_pids, ar_pnames, ar_sf, ar_ex, ar_ef)
        Dim jobid = SaveBoxedJob("Box Job 1", "Test Save Box", Project, templatename, filter, ar_sf, ar_ex, ar_ef, ar_pids, ar_pnames)



        Return jobid

    End Function
    <Extension()> _
    Public Sub Add(Of T)(ByRef arr As T(), item As T)
        Array.Resize(arr, arr.Length + 1)
        arr(arr.Length - 1) = item
    End Sub

    Public Function GetListofBoxedJobs()
        Dim boxnames As New Dictionary(Of String, String)
        'enumerate files and load box job names
        For Each file In IO.Directory.EnumerateFiles(My.Application.Info.DirectoryPath & "\BoxedJobs", "*.json")
            'create stream reader
            Dim jsonsr As New System.IO.StreamReader(file)
            'create json text reader
            Dim jtr As New JsonTextReader(jsonsr)
            'read the file to a new json object
            Dim jsonbox As JObject = DirectCast(JToken.ReadFrom(jtr), JObject)
            boxnames.Add(jsonbox.GetValue("BoxedJobName"), file)

        Next
        Return boxnames
    End Function


    Public Function ParseBoxedJobFromFile(ByVal BoxJobFilePath As String) As BoxedJob
        If Not System.IO.File.Exists(BoxJobFilePath) Then
            Return New BoxedJob
        Else
            'create stream reader
            Dim jsonsr As New System.IO.StreamReader(BoxJobFilePath)
            'create json text reader
            Dim jtr As New JsonTextReader(jsonsr)
            'read the file to a new json object
            Dim jsonbox As JObject = DirectCast(JToken.ReadFrom(jtr), JObject)
            Dim ReturnBox As New BoxedJob
            ReturnBox.BoxJobName = jsonbox.GetValue("BoxedJobName")
            ReturnBox.R1JobName = jsonbox.GetValue("R1JobName")
            ReturnBox.R1Project = jsonbox.GetValue("R1Project")
            ReturnBox.R1Template = jsonbox.GetValue("R1Template")
            ReturnBox.R1Filter = jsonbox.GetValue("R1Filter").ToString
            ReturnBox.R1_AR_PIDS = JsonConvert.DeserializeObject(Of String())(jsonbox.GetValue("R1_AR_PIDs").ToString)
            ReturnBox.R1_AR_ProcessNames = JsonConvert.DeserializeObject(Of String())(jsonbox.GetValue("R1_AR_ProcessNames").ToString)
            ReturnBox.R1_AR_Send = JsonConvert.DeserializeObject(Of ArrayOfJobOptionsOperationsAgentRemediationSendFileJobOptionsOperationsAgentRemediationSendFile())(jsonbox.GetValue("R1_AR_Send").ToString)
            ReturnBox.R1_AR_Execute = JsonConvert.DeserializeObject(Of ArrayOfJobOptionsOperationsAgentRemediationExecuteJobOptionsOperationsAgentRemediationExecute())(jsonbox.GetValue("R1_AR_Execute").ToString)
            ReturnBox.R1_AR_Erase = JsonConvert.DeserializeObject(Of ArrayOfJobOptionsOperationsAgentRemediationEraseJobOptionsOperationsAgentRemediationErase())(jsonbox.GetValue("R1_AR_Erase").ToString)

            Return ReturnBox
        End If
          
    End Function

    Public Function SaveBoxedJob(ByVal BoxJobName As String, ByVal R1JobName As String, ByVal R1Project As String, ByVal R1Template As String, ByVal R1Filter As String, ByVal R1_AR_Send() As JobsService.ArrayOfJobOptionsOperationsAgentRemediationSendFileJobOptionsOperationsAgentRemediationSendFile, ByVal R1_AR_Execute() As JobsService.ArrayOfJobOptionsOperationsAgentRemediationExecuteJobOptionsOperationsAgentRemediationExecute, ByVal R1_AR_Erase() As JobsService.ArrayOfJobOptionsOperationsAgentRemediationEraseJobOptionsOperationsAgentRemediationErase, ByVal R1_AR_PIDS() As String, ByVal R1_AR_ProcessNames() As String)

        Try
            'Create StringWriter for use with JSONTextWriter
            If Not System.IO.Directory.Exists(My.Application.Info.DirectoryPath & "\BoxedJobs") Then IO.Directory.CreateDirectory(My.Application.Info.DirectoryPath & "\BoxedJobs")
            Dim jsonsw As New System.IO.StreamWriter(My.Application.Info.DirectoryPath & "\BoxedJobs\" & BoxJobName & ".json", False)

            'Create JsonTextWriter
            Dim jsonstr As New JsonTextWriter(jsonsw)
            'Json Start
            jsonstr.WriteStartObject()

            'BoxedJobName
            jsonstr.WritePropertyName("BoxedJobName")
            jsonstr.WriteValue(BoxJobName)

            'R1 Job Name
            jsonstr.WritePropertyName("R1JobName")
            jsonstr.WriteValue(R1JobName)

            'R1 Project
            jsonstr.WritePropertyName("R1Project")
            jsonstr.WriteValue(R1Project)

            'R1 Template    
            jsonstr.WritePropertyName("R1Template")
            jsonstr.WriteValue(R1Template)

            'R1 Filter
            jsonstr.WritePropertyName("R1Filter")
            jsonstr.WriteRawValue(R1Filter)


            'R1 AR-SendFile
            jsonstr.WritePropertyName("R1_AR_Send")
            jsonstr.WriteRawValue(JsonConvert.SerializeObject(R1_AR_Send))


            'R1 AR-Execute
            jsonstr.WritePropertyName("R1_AR_Execute")
            jsonstr.WriteRawValue(JsonConvert.SerializeObject(R1_AR_Execute))

            'R1 AR-EraseFile
            jsonstr.WritePropertyName("R1_AR_Erase")
            jsonstr.WriteRawValue(JsonConvert.SerializeObject(R1_AR_Erase))

            'R1 AR-PIDs
            jsonstr.WritePropertyName("R1_AR_PIDs")
            jsonstr.WriteRawValue(JsonConvert.SerializeObject(R1_AR_PIDS))

            'R1 AR-ProcessNames
            jsonstr.WritePropertyName("R1_AR_ProcessNames")
            jsonstr.WriteRawValue(JsonConvert.SerializeObject(R1_AR_ProcessNames))

            'Json End
            jsonstr.WriteEndObject()
            'Close Writer
            jsonsw.Close()

        Catch ex As Exception
            Return 0
        End Try
        Return 1
    End Function



    Public Function SaveBoxedJob(ByVal BoxedJob As BoxedJob)
        Try
            'Create StringWriter for use with JSONTextWriter
            If Not System.IO.Directory.Exists(My.Application.Info.DirectoryPath & "\BoxedJobs") Then IO.Directory.CreateDirectory(My.Application.Info.DirectoryPath & "\BoxedJobs")
            Dim jsonsw As New System.IO.StreamWriter(My.Application.Info.DirectoryPath & "\BoxedJobs\" & BoxedJob.BoxJobName & ".json", False)

            'Create JsonTextWriter
            Dim jsonstr As New JsonTextWriter(jsonsw)
            'Json Start
            jsonstr.WriteStartObject()


            'BoxedJobName
            jsonstr.WritePropertyName("BoxedJobName")
            jsonstr.WriteValue(BoxedJob.BoxJobName)

            'R1 Job Name
            jsonstr.WritePropertyName("R1JobName")
            jsonstr.WriteValue(BoxedJob.R1JobName)

            'R1 Project
            jsonstr.WritePropertyName("R1Project")
            jsonstr.WriteValue(BoxedJob.R1Project)

            'R1 Template    
            jsonstr.WritePropertyName("R1Template")
            jsonstr.WriteValue(BoxedJob.R1Template)

            'R1 Filter
            jsonstr.WritePropertyName("R1Filter")
            jsonstr.WriteRawValue(BoxedJob.R1Filter)


            'R1 AR-SendFile
            jsonstr.WritePropertyName("R1_AR_Send")
            jsonstr.WriteRawValue(JsonConvert.SerializeObject(BoxedJob.R1_AR_Send))


            'R1 AR-Execute
            jsonstr.WritePropertyName("R1_AR_Execute")
            jsonstr.WriteRawValue(JsonConvert.SerializeObject(BoxedJob.R1_AR_Execute))

            'R1 AR-EraseFile
            jsonstr.WritePropertyName("R1_AR_Erase")
            jsonstr.WriteRawValue(JsonConvert.SerializeObject(BoxedJob.R1_AR_Erase))

            'R1 AR-PIDs
            jsonstr.WritePropertyName("R1_AR_PIDs")
            jsonstr.WriteRawValue(JsonConvert.SerializeObject(BoxedJob.R1_AR_PIDS))

            'R1 AR-ProcessNames
            jsonstr.WritePropertyName("R1_AR_ProcessNames")
            jsonstr.WriteRawValue(JsonConvert.SerializeObject(BoxedJob.R1_AR_ProcessNames))

            'Json End
            jsonstr.WriteEndObject()
            'Close Writer
            jsonsw.Close()

        Catch ex As Exception
            Return 0
        End Try
        Return 1
    End Function





End Module
