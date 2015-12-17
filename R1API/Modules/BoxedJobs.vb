Imports Newtonsoft.Json
Imports System.Runtime.CompilerServices
Imports R1_Job_Runner.JobsService
Imports Newtonsoft.Json.Linq

Module BoxedJobs

    Public Class BoxedJob
        'Boxed job declaration of properties
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

    'Allows adding to arrays / objects
    <Extension()> _
    Public Sub Add(Of T)(ByRef arr As T(), item As T)
        Array.Resize(arr, arr.Length + 1)
        arr(arr.Length - 1) = item
    End Sub

    Public Function GetListofBoxedJobs()
        Dim boxnames As New Dictionary(Of String, String)
        'enumerate files and load box job names
        If Not IO.Directory.Exists(My.Application.Info.DirectoryPath & "\BoxedJobs") Then IO.Directory.CreateDirectory(My.Application.Info.DirectoryPath & "\BoxedJobs")
        For Each file In IO.Directory.EnumerateFiles(My.Application.Info.DirectoryPath & "\BoxedJobs", "*.json")
            'create stream reader
            Dim jsonsr As New System.IO.StreamReader(file)
            'create json text reader
            Dim jtr As New JsonTextReader(jsonsr)
            'read the file to a new json object
            Dim jsonbox As JObject = DirectCast(JToken.ReadFrom(jtr), JObject)
            boxnames.Add(jsonbox.GetValue("R1JobName"), file)
            jtr.Close()
            jsonsr.Close()
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
            jtr.Close()
            jsonsr.Close()
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
            jsonstr.Close()
            'Close Writer
            jsonsw.Close()

        Catch ex As Exception
            Return 0
        End Try
        Return 1
    End Function



    Public Function SaveBoxedJob(ByVal filepath As String, ByVal BoxedJob As BoxedJob)
        Try
            'Create StringWriter for use with JSONTextWriter
            If Not System.IO.Directory.Exists(My.Application.Info.DirectoryPath & "\BoxedJobs") Then IO.Directory.CreateDirectory(My.Application.Info.DirectoryPath & "\BoxedJobs")
            Dim jsonsw As New System.IO.StreamWriter(filepath, False)
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
            jsonstr.Close()
            'Close Writer
            jsonsw.Close()

        Catch ex As Exception
            Return 0
        End Try
        Return 1
    End Function

End Module
