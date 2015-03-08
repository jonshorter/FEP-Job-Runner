
Imports System.Net
Imports System.IO
Imports System.Text
Imports System.Xml
Imports Newtonsoft.Json
Imports System
Imports System.Security.Cryptography.X509Certificates
Imports System.Net.Security
Imports System.Text.RegularExpressions

Module Jobs
    'Null String 
    Public nullstring() As String = New String() {}


    Public Class InclFilter
        'Inclusion Filter Class - All options available in an inclusion filter
        Public FilterName As String
        Public PathURLContains As String
        Public Extensions As String
        Public IsKeyWordSearch As Boolean
        Public Keywords As String
        Public MD5HashsEntryText As String
        Public IsSearchFilenameOnly As Boolean
        Public IsRegexSearch As Boolean
    End Class

    Public Class ExclFilter
        'Exclusion Filter Class - All options available in an inclusion filter
        Public FilterName As String
        Public PathURLContains As String
        Public Extensions As String
        Public MD5HashsEntryText As String
    End Class



    Public Function CreateFilter()
        'The API wants a combined JSON for the filter that includes all options for
        'both the Inclusion and Exclusion filter in one.
        'This returns a JSON
        '-------------------------------
        'Make a new inclusion filter based on the class and set the variables based on the Form
        Dim inclfilter As New InclFilter
        If Main.txtinclfiltername.Text <> "" Then inclfilter.FilterName = Main.txtinclfiltername.Text
        If Main.txtinclkeywords.Text <> "" Then
            If Main.rdoinclsimplesearch.Checked Then inclfilter.IsKeyWordSearch = Main.rdoinclsimplesearch.Checked
            If Main.rdoinclregexsearch.Checked Then inclfilter.IsRegexSearch = Main.rdoinclregexsearch.Checked
            If Main.chkinclsearchfilename.Checked Then inclfilter.IsSearchFilenameOnly = Main.chkinclsearchfilename.Checked
            inclfilter.Keywords = Main.txtinclkeywords.Text
        End If
        If Main.txtinclmd5hash.Text <> "" Then inclfilter.MD5HashsEntryText = Main.txtinclmd5hash.Text
        If Main.txtinclextensions.Text <> "" Then inclfilter.Extensions = Main.txtinclextensions.Text
        If Main.txtinclpathcontains.Text <> "" Then inclfilter.PathURLContains = Main.txtinclpathcontains.Text

        'Make a new exclusion filter based on the class and set the variables based on the Form
        Dim exclfilter As New ExclFilter
        If Main.txtexclfiltername.Text <> "" Then exclfilter.FilterName = Main.txtexclfiltername.Text
        If Main.txtexclextensions.Text <> "" Then exclfilter.Extensions = Main.txtexclextensions.Text
        If Main.txtexclpathcontains.Text <> "" Then exclfilter.PathURLContains = Main.txtexclpathcontains.Text
        If Main.txtexclmd5hash.Text <> "" Then exclfilter.MD5HashsEntryText = Main.txtexclmd5hash.Text

        'If both inclusion and exclusion filters have a name create the JSON
        If inclfilter.FilterName <> "" Or exclfilter.FilterName <> "" Then
            'Create StringWriter for use with JSONTextWriter
            Dim jsonsw As New System.IO.StringWriter
            'Create JsonTextWriter
            Dim jsonstr As New JsonTextWriter(jsonsw)
            'Json Start
            jsonstr.WriteStartObject()
            'If the inclusion filter has a name, generate the JSON
            If inclfilter.FilterName <> "" Then
                'JSON Property
                jsonstr.WritePropertyName("InclusionFilters")
                'Array
                jsonstr.WriteStartArray()
                'We are serializing the inclusion filter class into JSON. So we WriteRaw so it doesn't try to serialize it twice.
                jsonstr.WriteRaw(JsonConvert.SerializeObject(inclfilter))
                'End Array
                jsonstr.WriteEndArray()
            End If
            'If the exclusion filter has a name, generate the JSON
            If exclfilter.FilterName <> "" Then
                'JSON Property
                jsonstr.WritePropertyName("ExclusionFilters")
                'Array
                jsonstr.WriteStartArray()
                'We are serializing the exclusion filter class into JSON. So we WriteRaw so it doesn't try to serialize it twice.
                jsonstr.WriteRaw(JsonConvert.SerializeObject(exclfilter))
                'End Array
                jsonstr.WriteEndArray()
            End If
            'Json End
            jsonstr.WriteEndObject()
            'Close the json writer
            jsonstr.Close()
            'Return the JSON
            Return jsonsw.ToString
            jsonsw.Close()
        Else
            'Neither filters have a name, return a blank "No Filter"
            Return ""
        End If

    End Function

    Public Function RunFromTemplateName(ByVal srvname As String, ByVal templatename As String, ByVal JobName As String, ByVal ProjectName As String, ByVal APIUser As String, ByVal APIPass As String, ByVal cnames() As String, ByVal snames() As String, ByVal filter As String, ByVal pids() As String, ByVal processnames() As String, ByVal remediatesendfile() As R1API.JobsService.ArrayOfJobOptionsOperationsAgentRemediationSendFileJobOptionsOperationsAgentRemediationSendFile, ByVal remediateexecute() As R1API.JobsService.ArrayOfJobOptionsOperationsAgentRemediationExecuteJobOptionsOperationsAgentRemediationExecute, ByVal remediateerase() As R1API.JobsService.ArrayOfJobOptionsOperationsAgentRemediationEraseJobOptionsOperationsAgentRemediationErase)
        'Submit a job via the API
        Try

            If Main.chkbypasscerts.Checked Then
                'Ignore self-signed / bad certificates
                ServicePointManager.ServerCertificateValidationCallback = AddressOf ValidateRemoteCertificate
            End If


            'Create a new job request
            Dim js As New JobsService.RunJobFromTemplateNameRequest(templatename, JobName, ProjectName, APIUser, APIPass, cnames, snames, pids, processnames, remediatesendfile, remediateexecute, remediateerase, filter, filter, "ISModuleArcSight", "6732A1F0-7FAC-4D25-AACB-3BD0B8E8D146", "Module specific string")

            'Set servername
            Dim servername As New System.ServiceModel.EndpointAddress("https://" & srvname & "/adg.map.web/services/api/JobsService.asmx")
            'Create a new soap client
            Dim jsserv As New JobsService.JobsServiceSoapClient
            'Set address
            jsserv.Endpoint.Address = servername
            'Open the connection
            jsserv.Open()

            'Create a new job response (output)
            Dim out As New JobsService.RunJobFromTemplateNameResponse
            'Submit the job and receive response into out
            out = jsserv.RunJobFromTemplateName(js)

            'Return the result
            Return out.RunJobFromTemplateNameResult.ToString
        Catch noend As System.ServiceModel.EndpointNotFoundException
            'No endpoint found exception (bad servername/wrong server)
            Return "There was no endpoint listening at " & srvname & "."
        Catch noname As System.ServiceModel.FaultException
            If noname.Message.Contains("computerNames or shareName must be provided") Then
                Return "A job target must be specificed. Computer or Network Share."
            ElseIf noname.Message.Contains("Bad username or password") Then
                Return "Bad API Username or Password!"
            ElseIf noname.Message.Contains("Unable to retrieve template") Then
                Return noname.Message.Replace("Server was unable to process request. --->", "").ToString
            ElseIf noname.Message.Contains("Invalid Project Name") Then
                Return noname.Message.Replace("Server was unable to process request. --->", "").ToString
            Else
                Return noname.Message
            End If

        Catch Ex As Exception
            'Catch anything else
            Return Ex.Message
        End Try
    End Function

    Public Function ValidateRemoteCertificate(ByVal sender As Object, ByVal certificate As X509Certificate, ByVal chain As X509Chain, ByVal sslPolicyErrors As SslPolicyErrors) As Boolean
        Return True
    End Function

    Public Function isGuid(ByVal input As String)
        'Use RegEx to make sure the input is a GUID
        Dim test As Regex = New Regex("^(\{){0,1}[0-9a-fA-F]{8}\-" & _
                     "[0-9a-fA-F]{4}\-[0-9a-fA-F]{4}\-[0-9a-fA-F]{4}\-" & _
                     "[0-9a-fA-F]{12}(\}){0,1}$", RegexOptions.Compiled)
        'Return result
        Return test.IsMatch(input)
    End Function

End Module
