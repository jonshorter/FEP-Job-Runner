
Imports System.Net
Imports System.IO
Imports System.Text
Imports System.Xml
Imports Newtonsoft.Json
Imports System
Imports System.Security.Cryptography.X509Certificates
Imports System.Net.Security
Imports System.Text.RegularExpressions
Imports Newtonsoft.Json.Linq
Module Jobs
    'Null String 
    Public nullstring() As String = New String() {}
    Public Class InclusionFilter
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

    Public Class ExclusionFilter
        'Exclusion Filter Class - All options available in an inclusion filter
        Public FilterName As String
        Public PathURLContains As String
        Public Extensions As String
        Public MD5HashsEntryText As String
    End Class

    Public Function ParseFilterJSON(ByVal JSON As String)
        Dim jsonfilter As JObject = JsonConvert.DeserializeObject(JSON)
        'Get All Inclusion Filters
        Dim InList As New List(Of InclusionFilter)
        Dim inob As New JArray
        'Find InclusionFilters
        If jsonfilter.TryGetValue("InclusionFilters", inob) = True Then
            'Read the items into an array
            Dim infilt() As InclusionFilter = JsonConvert.DeserializeObject(Of InclusionFilter())(jsonfilter.GetValue("InclusionFilters").ToString)
            'For each item in the array add to our list of filters
            For Each item In infilt
                InList.Add(item)
            Next
        Else
        End If
        'Get All Exclusion Filters
        Dim ExList As New List(Of ExclusionFilter)
        'Find exclusion filters
        If jsonfilter.TryGetValue("ExclusionFilters", inob) = True Then
            'Read the items into an array
            Dim exfilt() As ExclusionFilter = JsonConvert.DeserializeObject(Of ExclusionFilter())(jsonfilter.GetValue("ExclusionFilters").ToString)
            'For each item in the array add to our list of filters
            For Each item In exfilt
                ExList.Add(item)
            Next
        Else
        End If
        'New list of filters
        Dim FList As New List(Of Object)
        'Add inclusion
        FList.Add(InList)
        'Add Exclusion
        FList.Add(ExList)
        'Return
        Return FList
    End Function

    Public Function BuildFilterJSON(ByVal InFilterList As List(Of Jobs.InclusionFilter), ByVal ExFilterList As List(Of Jobs.ExclusionFilter))

        'Create StringWriter for use with JSONTextWriter
        Dim jsonsw As New System.IO.StringWriter
        'Create JsonTextWriter
        Dim jsonstr As New JsonTextWriter(jsonsw)
        'Json Start
        jsonstr.WriteStartObject()
        'If there are inclusion filters add them
        If InFilterList.Count > 0 Then
            'JSON Property
            jsonstr.WritePropertyName("InclusionFilters")
            'Array
            jsonstr.WriteStartArray()
            'Iterate all inclusion filters in the list
            For Each item As InclusionFilter In InFilterList
                'If the filter name isn't blank, add it
                If item.FilterName <> "" Then
                    'We are serializing the inclusion filter class into JSON. So we WriteRaw so it doesn't try to serialize it twice.
                    jsonstr.WriteRawValue(JsonConvert.SerializeObject(item))
                    'End Array
                End If
            Next
            'Write ending
            jsonstr.WriteEndArray()
        End If
        'If there are exclusion filters add them
        If ExFilterList.Count > 0 Then
            'JSON Property
            jsonstr.WritePropertyName("ExclusionFilters")
            'Array
            jsonstr.WriteStartArray()
            'Iterate all exclusion filters in the list
            For Each item As ExclusionFilter In ExFilterList
                'If the filter name isn't blank, add it
                If item.FilterName <> "" Then
                    'We are serializing the exclusion filter class into JSON. So we WriteRaw so it doesn't try to serialize it twice.
                    jsonstr.WriteRawValue(JsonConvert.SerializeObject(item))
                    'End Array
                End If
            Next
            'Write ending
            jsonstr.WriteEndArray()
        End If
        'Json End
        jsonstr.WriteEndObject()
        'Close the json writer
        jsonstr.Close()
        'Return the JSON
        Return jsonsw.ToString
        jsonsw.Close()
    End Function
    Public Function CreateFilter()
        'This is outdated, we use the BuildFilterJSON Now.


        'The API wants a combined JSON for the filter that includes all options for
        'both the Inclusion and Exclusion filter in one.
        'This returns a JSON
        '-------------------------------
        'Make a new inclusion filter based on the class and set the variables based on the Form

        Dim inclfilter As New InclusionFilter
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
        Dim exclfilter As New ExclusionFilter
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

    Private Sub JobSubCallBack(ByVal send As Object, ByVal e As JobsService.RunJobFromTemplateNameCompletedEventArgs)
        'Receives the Async Job Completed Event

        'If no errors, then update the status as Job submitted + GUID
        If e.Error Is Nothing Then
            Main.statuslabel.Text = "Job Submitted: " & e.Result.RunJobFromTemplateNameResult.ToString

          
        Else
            'Errors!
            'Set the status label to draw attention
            Main.statuslabel.BackColor = Color.DarkRed
            Main.statuslabel.ForeColor = Color.White

            Select Case True
                'Invalid server
                Case e.Error.Message.Contains("There was no endpoint listening")
                    Main.statuslabel.Text = "Invalid Server Name or Address"
                    'Job Target Required
                Case e.Error.Message.Contains("computerNames or shareName must be provided")
                    Main.statuslabel.Text = "A job target must be specificed. Computer or Network Share."
                    'Bad API Username/Pass
                Case e.Error.Message.Contains("Bad username or password")
                    Main.statuslabel.Text = "Bad API Username or Password!"
                    'Can't find job template
                Case e.Error.Message.Contains("Unable to retrieve template")
                    Main.statuslabel.Text = e.Error.Message.Replace("Server was unable to process request. --->", "").ToString
                    'Bad project name
                Case e.Error.Message.Contains("Invalid Project Name")
                    Main.statuslabel.Text = e.Error.Message.Replace("Server was unable to process request. --->", "").ToString
                    'Script on job completion error
                Case e.Error.Message.Contains("ScriptFileName,ImpersonationUsername and  ImpersonationPassword are Required")
                    Main.statuslabel.Text = e.Error.Message.Replace("Server was unable to process request. --->", "").ToString
                    'Catch others - display error
                Case Else
                    Main.statuslabel.Text = e.Error.Message.Replace("Server was unable to process request. --->", "").ToString
            End Select


        End If
    End Sub
    Public Sub ResetStatusBar()
        Main.statuslabel.Text = ""
        Main.statuslabel.BackColor = Control.DefaultBackColor
        Main.statuslabel.ForeColor = Color.Black
    End Sub
    Public Sub RunFromTemplateName(ByVal srvname As String, ByVal templatename As String, ByVal JobName As String, ByVal ProjectName As String, ByVal APIUser As String, ByVal APIPass As String, ByVal cnames() As String, ByVal snames() As String, ByVal filter As String, ByVal pids() As String, ByVal processnames() As String, ByVal remediatesendfile() As R1_Job_Runner.JobsService.ArrayOfJobOptionsOperationsAgentRemediationSendFileJobOptionsOperationsAgentRemediationSendFile, ByVal remediateexecute() As R1_Job_Runner.JobsService.ArrayOfJobOptionsOperationsAgentRemediationExecuteJobOptionsOperationsAgentRemediationExecute, ByVal remediateerase() As R1_Job_Runner.JobsService.ArrayOfJobOptionsOperationsAgentRemediationEraseJobOptionsOperationsAgentRemediationErase)
        'Submit a job via the API

        If Main.chkbypasscerts.Checked Then
            'Ignore self-signed / bad certificates
            ServicePointManager.ServerCertificateValidationCallback = AddressOf ValidateRemoteCertificate
        End If

        'Create a new job request
        Dim js As New JobsService.RunJobFromTemplateNameRequest(templatename, JobName, ProjectName, APIUser, APIPass, cnames, snames, pids, processnames, remediatesendfile, remediateexecute, remediateerase, filter, filter, "ISModuleArcSight", "6732A1F0-7FAC-4D25-AACB-3BD0B8E8D146", "Module specific string")

        'Jobs Service Binding
        Dim JobsServiceBinding As New System.ServiceModel.BasicHttpBinding(ServiceModel.BasicHttpSecurityMode.Transport)
        JobsServiceBinding.Name = "JobsServiceSoap"
        'Set servername

        Dim endpointaddress As String = ""
        If Main.rdoversion55.Checked = True Then
            endpointaddress = "https://" & srvname & "/adg.map.web/services/api/JobsService.asmx"
        Else
            endpointaddress = "https://" & srvname & "/r1/services/api/JobsService.asmx"
        End If

        Dim servername As New System.ServiceModel.EndpointAddress(endpointaddress)


        'Create a new soap client
        Dim jsserv As New JobsService.JobsServiceSoapClient(JobsServiceBinding, servername)
        'Set address
        jsserv.Endpoint.Address = servername
        'Open the connection
        jsserv.Open()

        'Make a handler for the Async job
        AddHandler jsserv.RunJobFromTemplateNameCompleted, AddressOf JobSubCallBack

        'Run the job asynchronously
        jsserv.RunJobFromTemplateNameAsync(js)

    End Sub

    Public Function ValidateRemoteCertificate(ByVal sender As Object, ByVal certificate As X509Certificate, ByVal chain As X509Chain, ByVal sslPolicyErrors As SslPolicyErrors) As Boolean
        'Return that the cert checked out A-Ok.
        Return True
    End Function

    Public Function isGuid(ByVal input As String)
        'Was used to verify GUIDs returned. Not used with Async.
        'Use RegEx to make sure the input is a GUID
        Dim test As Regex = New Regex("^(\{){0,1}[0-9a-fA-F]{8}\-" & _
                     "[0-9a-fA-F]{4}\-[0-9a-fA-F]{4}\-[0-9a-fA-F]{4}\-" & _
                     "[0-9a-fA-F]{12}(\}){0,1}$", RegexOptions.Compiled)
        'Return result
        Return test.IsMatch(input)
    End Function

    Public Sub ClearAllJobOptioons(ByVal controls As System.Windows.Forms.Control.ControlCollection)
        'Clear each control - used when loading boxes so we don't have remnants/stale data
        For Each ctrl As Control In controls
            Console.WriteLine("Control: " & ctrl.Name)
            If TypeOf (ctrl) Is TextBox Then
                CType(ctrl, TextBox).Text = String.Empty
            ElseIf TypeOf (ctrl) Is NumericUpDown Then
                CType(ctrl, NumericUpDown).Value = 0
            ElseIf TypeOf (ctrl) Is CheckBox Then
                CType(ctrl, CheckBox).Checked = False
            ElseIf TypeOf (ctrl) Is CheckedListBox Then
                CType(ctrl, CheckedListBox).Items.Clear()
            End If
        Next
    End Sub

    Public Sub RemoveItemFromInclusionStore(ByVal FilterName As String)
        'Remove an item from the inclusion list store
        'inclist = store
        Dim inclist As List(Of InclusionFilter) = Main.StoreInFiltList
        'incx "note"
        Dim incx As Integer
        'Iterate items in store
        For i = 0 To inclist.Count - 1
            'item as inclusion filter at index
            Dim tinfil As InclusionFilter = inclist(i)
            'Match filter name
            If tinfil.FilterName = FilterName Then
                'Make a note
                incx = i
            End If
        Next
        'Remove that item
        inclist.RemoveAt(incx)
    End Sub
    Public Sub RemoveItemFromExclusionStore(ByVal FilterName As String)
        'Remove an item from the exclusion list store
        'exclist = store
        Dim exclist As List(Of ExclusionFilter) = Main.StoreExFiltList
        'excx "note"
        Dim excx As Integer
        'Iterate items in store
        For i = 0 To exclist.Count - 1
            'item as exclusion filter at index
            Dim texfil As ExclusionFilter = exclist(i)
            'Match filter name
            If texfil.FilterName = FilterName Then
                'Make a note
                excx = i
            End If
        Next
        'Remove that item
        exclist.RemoveAt(excx)
    End Sub

    Public Sub RemoveItemFromRemStores(ByVal Item As ListViewItem)
        'Remove item from the remediation option stores as listviewitem

        'Select remediation type 
        Select Case Item.Text
            Case "Send File"
                'Send File
                'sflist = store
                Dim sflist As List(Of JobsService.ArrayOfJobOptionsOperationsAgentRemediationSendFileJobOptionsOperationsAgentRemediationSendFile) = Main.StoreRemSendList
                'remove item from store at index
                sflist.RemoveAt(Item.SubItems(1).Text - 1)
            Case "Execute"
                'Execute
                'xflist = Store
                Dim xflist As List(Of JobsService.ArrayOfJobOptionsOperationsAgentRemediationExecuteJobOptionsOperationsAgentRemediationExecute) = Main.StoreRemExecList
                'remove item from store at index
                xflist.RemoveAt(Item.SubItems(1).Text - 1)
            Case "Delete File"
                'Delete File
                'dflist = Store
                Dim dflist As List(Of JobsService.ArrayOfJobOptionsOperationsAgentRemediationEraseJobOptionsOperationsAgentRemediationErase) = Main.StoreRemDelList
                'remove item from store at index
                dflist.RemoveAt(Item.SubItems(1).Text - 1)
            Case "Kill Process Name"
                'Kill process name
                'kpnamelist = store
                Dim kpnamelist As List(Of String) = Main.StoreRemKillNameList
                'remove item from store at index
                kpnamelist.RemoveAt(Item.SubItems(1).Text - 1)
            Case "Kill Process ID"
                'Kill process id
                'kpidlist = store
                Dim kpidlist As List(Of String) = Main.StoreRemKillIDList
                'remove item from store at index
                kpidlist.RemoveAt(Item.SubItems(1).Text - 1)
        End Select
    End Sub
End Module
