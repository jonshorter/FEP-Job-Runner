Imports System.Net
Imports System.Text
Imports System.IO
Imports System.Net.Sockets
Imports Newtonsoft.Json
Imports System.Security.Cryptography.X509Certificates

Public Module XPS

    '<33>Nov 12 11:45:15 xps ,bfb696b3-895c-11e5-a92b-000c2947b169,10.0.1.28,10.0.1.204,alert,Backdoor.Generic.WebShell.fss1,BACKDOOR,Malware Detection Engine,critical,2015-11-12 11:45:15,10.0.1.204

    Public Class XPSThreat

        'Public Property Header = "<33>" & DateTime.Now & " xps"
        Public Property Header = "<33>" & DateTime.Now & " " & Dns.GetHostByName(My.Computer.Name).HostName.ToString
        Public Property Alertuuid As Guid = Guid.NewGuid
        Public Property Srcaddr As String = Dns.GetHostByName(My.Computer.Name).AddressList(0).ToString
        Public Property Dstaddr As String
        Public Property Action As String
        Public Property MalwareName As String
        Public Property MalwareType As String
        Public Property Rule As String
        Public Property Severity As String
        Public Property Time As DateTime = Now
        Public Property HostIp As String


    End Class

    Public Function XPSThreatTOCSV(threat As XPSThreat) As String
        Const separator As Char = ","c
        Dim sb As New StringBuilder

        'Get the data elements
        Dim threatfields = GetType(XPSThreat).GetProperties()


        For Each field In threatfields

            Dim value As String = Convert.ToString(field.GetValue(threat))
            Select Case field.Name
                '  Case "Time"
                '     sb.Append(Format("yyyy-mm-dd HH:mm:ss tt", value))
                Case Else
                    sb.Append(value)
            End Select

            '... followed by the separator...unless it is HostIP (last item)

            If Not field.Name = "HostIp" Then sb.Append(separator)


        Next

        Return sb.ToString()
    End Function


    Public Sub SendEvent(XPSEvent As String)
        Try
            Dim udpClient As New UdpClient
            Dim XPSPort As Integer = Main.xpsPort.Value
            Dim bytCommand As Byte() = New Byte() {}
            udpClient.Connect(Main.txtServer.Text, XPSPort)
            bytCommand = Encoding.ASCII.GetBytes(XPSEvent)
            Dim pRet = udpClient.Send(bytCommand, bytCommand.Length)
            ' Console.WriteLine("No of bytes sent " & pRet)
            Debug.WriteLine("XPS SysLog Event Sent")
            Main.lblXPSStatus.Text = "XPS Syslog Malware Event Sent"

        Catch ex As Exception
            Main.lblXPSStatus.Text = ex.Message
        End Try

    End Sub

    Public Class XPSAlert
        Public metadata As New XPSAlert_Metadata
        Public warnings As New XPSAlert_Warnings
        Public iocs As New XPSAlert_Iocs
        Public dynamic As New XPSAlert_Dynamic
        Public network As New XPSAlert_Network
        Public artifacts As New XPSAlert_Artifacts
        Public disk As New XPSAlert_Disk
        Public annotations As New XPSAlert_Annotations
        Public version As Integer = 2
    End Class

    Public Class XPSAlert_Metadata
        Public general_details As New XPSAlert_Metadata_GeneralDetails
        Public sandcastle_env As New XPSAlert_Metadata_Sandcastle
        Public malware_desc As New List(Of XPSAlert_Metadata_MalwareDesc)
    End Class

    Public Class XPSAlert_Metadata_GeneralDetails
        Public sandbox_version As String = "pilot-d"
        Public report_created As Long = 1445331205
        Public sandbox_id As String = "phl-work-19"
    End Class

    Public Class XPSAlert_Metadata_Sandcastle
        Public analysis_end As Long = 1445331205
        Public analysis_start As Long = 1445330785
        Public run_time As Integer = 420
        Public sample_executed As Long = 1445330855
        Public sandcastle As String = "3.4.8.7553.e23eb1d-1"
        Public current_os As String = "2600.xpsp.080413-2111"
        Public controlsubject As String = "winxp-x86-amd-2015.09.22"
        Public vm_id As String = "7cbe1d148cfd346d8b8b246ce47f17b1"
        Public vm As String = "winxp-x86"

    End Class
    Public Class XPSAlert_Metadata_MalwareDesc
        Public filename As String = "0026019878.exe"
        Public size As Long = 28672
        Public md5 As String = "47f9fdc617f8c98a6732be534d8dbe9a"
        Public sha1 As String = "x"
        Public sha256 As String = "x"
        Public magic As String = "PE32 executable (console) Intel 80386, for MS Windows"
        Public type As String = "exe"
    End Class

    Public Class XPSAlert_Warnings
        Public Property code As String
        Public Property title As String
        Public Property description As String
        Public Property data As Object()
    End Class

    Public Class XPSAlert_Iocs
        Public Property category As String()
        Public Property hits As Integer
        Public Property severity As Integer
        Public Property title As String
        Public Property data As Datum()
        Public Property tags As String()
        Public Property truncated As Boolean
        Public Property confidence As Integer
        Public Property ioc As String
        Public Property description As String
    End Class
    Public Class Datum
        Public Property Query_Data As String
        Public Property Query_ID As Integer
        Public Property Answer_Type As String
        Public Property Answer_Data As String
        Public Property TTL As Integer
    End Class
    Public Class XPSAlert_Dynamic
        Public Property processes As List(Of XPSAlert_Dynamic_Process)

    End Class
    Public Class XPSAlert_Dynamic_Process
        Public Property registry_keys_read As Object()
        Public Property pid As Integer
        Public Property kpid As String
        Public Property runtime_dlls As Object()
        Public Property files_deleted As Object()
        Public Property mutants_created As Object()
        Public Property files_created As Object()
        Public Property sockets_accepted As Object()
        Public Property errors As Object()
        Public Property monitored As Boolean
        Public Property registry_keys_deleted As Object()
        Public Property mutants_opened As Object()
        Public Property memory As Memory()
        Public Property [new] As Boolean
        Public Property ppid As Object
        Public Property proc As Boolean
        Public Property registry_keys_opened As Object()
        Public Property parent As Object
        Public Property startup_info As StartupInfo
        Public Property process_name As String
        Public Property sockets_bound As Object()
        Public Property sockets_connected As Object()
        Public Property threads As Object()
        Public Property startup_dlls As Object()
        Public Property analyzed_because As String
        Public Property files_modified As Object()
        Public Property registry_keys_created As Object()
        Public Property children As Object()
        Public Property registry_keys_modified As Object()
        Public Property sockets_listening As Object()
        Public Property files_read As Object()
        Public Property time As Object
    End Class
    Public Class Entry
        Public Property size As String
        Public Property base_address As String
    End Class
    Public Class StartupInfo
        Public Property shell_info As String
        Public Property desktop_info As String
        Public Property current_directory As String
        Public Property command_line As String
        Public Property upid As Integer
        Public Property uthread As Integer
        Public Property image_pathname As String
        Public Property dll_path As String
        Public Property runtime_data As String
        Public Property tid As String
        Public Property window_title As String
    End Class
    Public Class Memory
        Public Property protect As String()
        Public Property process As Object
        Public Property allocation_type As String()
        Public Property entry As Entry()
        Public Property zero_bits As Integer
        Public Property process_handle As String
    End Class
    Public Class XPSAlert_Network
        Public Property network As List(Of network_item)
    End Class
    Public Class network_item
        Public Property protocol As String
        Public Property packets As Integer
        Public Property bytes As Integer
        Public Property ts_begin As Double
        Public Property ts_end As Double
        Public Property src As String
        Public Property src_port As Integer
        Public Property dst As String
        Public Property dst_port As Integer
        Public Property transport As String
        Public Property decoded As Object
    End Class

    Public Class XPSAlert_Artifacts
        Public Property artifacts As List(Of artifact_item)
    End Class
    Public Class artifact_item
        Public Property origin As String = "submitted"
        Public Property path As String = ""
        Public Property magictype As String = "PE32 executable (console) Intel 80386, for MS Windows"
        Public Property mimetype As String = "application/x-dosexec; charset=binary"
        Public Property type As String = "exe"
        Public Property antivirus As Antivirus
        Public Property createdtime As Double = 1445331204.8384709
        Public Property size As Integer = 28672
        Public Property sha1 As String = ""
        Public Property md5 As String = "47f9fdc617f8c98a6732be534d8dbe9a"
        Public Property sha256 As String = ""
        Public Property forensics As Forensics
        Public Property relation As Relation
        Public Property read_by As Object()
        Public Property created_by As Object()
        Public Property modified_by As Object()
        Public Property executed_from As Object()
    End Class
    Public Class Antivirus
    End Class

    Public Class Forensics
    End Class

    Public Class Relation
    End Class
    Public Class XPSAlert_Disk
        Public Property mbr As Mbr
        Public Property partition_tables As PartitionTables
    End Class
    Public Class PartitionTables
        Public Property orig As Orig()
        Public Property curr As Curr()
        Public Property changed As Boolean
        Public Property changes As Changes
    End Class
    Public Class Orig
        Public Property start As Integer
        Public Property type As Integer
        Public Property size As Integer
    End Class
    Public Class Hashes
        Public Property orig As Orig
        Public Property curr As Curr
    End Class

    Public Class Contents
        Public Property orig As String
        Public Property curr As String
    End Class

    Public Class Mbr
        Public Property hashes As Hashes
        Public Property contents As Contents
        Public Property changed As Boolean
    End Class
    Public Class Curr
        Public Property start As Integer
        Public Property type As Integer
        Public Property size As Integer
    End Class

    Public Class Changes
    End Class
    Public Class XPSAlert_Annotations
        Public Property network As List(Of XPSAlert_Annotations_NetworkItem)
    End Class
    Public Class XPSAlert_Annotations_NetworkItem
        Public Property city As Object
        Public Property country As Object
        Public Property region As Object
        Public Property ts As Double
        Public Property org As Object
        Public Property reversedns As Object
        Public Property asn As Object
        Public Property tg_structured As Boolean
    End Class

    Public Function GenerateXPS_MDE_Response(ByVal CustomMD5 As String)
        'Create a new default event
        Dim xps_event As New XPSAlert
        Dim malware As New XPSAlert_Metadata_MalwareDesc
        xps_event.metadata.malware_desc.Add(malware)
        xps_event.metadata.malware_desc(0).md5 = CustomMD5
        Return xps_event
    End Function

    Public Function XPS_MDE_Response_ToJSON(ByVal XPSAlert As XPS.XPSAlert)
        'Convert to JSON from FEEvent
        Dim jstr As String = JsonConvert.SerializeObject(XPSAlert)

        'Fix messed up headers
        jstr = jstr.Replace("magictype", "magic-type")
        jstr = jstr.Replace("mimetype", "mime-type")
        jstr = jstr.Replace("createdtime", "created-time")
        jstr = jstr.Replace("reversedns", "reverse-dns")

        'Return JSON STring
        Return jstr
    End Function


    Public Class XPS_Sim
        Public prefix As String = "https://*:" & Main.xps_sim_Port.Value & "/"
        Public listener As HttpListener = New HttpListener
        Public certhash As String = ""
        Public Property MalwareMD5 As String


        Public Sub Start()
            CertLoad()
            AssociateCertToListener(Main.sim_selfcert)
            listener.Prefixes.Add(prefix)
            listener.Start()
            listener.BeginGetContext(AddressOf Sim_Respond, listener)
            Debug.WriteLine("XPS Sim Listening " & prefix)

        End Sub
        Public Sub [Stop]()
            listener.Stop()
            DeAssociateCertToListener()
        End Sub

        Public Sub Sim_Respond(ByVal ar As IAsyncResult)
            If listener.IsListening Then
                Dim response As HttpListenerResponse
                Dim context = listener.EndGetContext(ar)
                listener.BeginGetContext(AddressOf Sim_Respond, listener)
                Try
                    Dim responseString As String = ""
                    Dim buffer() As Byte
                    Dim output As System.IO.Stream
                    ' Note: GetContext blocks while waiting for a request.

                    If context.Request.QueryString.Count < 2 Then
                        If context.Request.QueryString.Count = 0 Then
                            'General browse no parameters....respond gracefully
                            response = context.Response
                            response.StatusCode = 200
                            response.StatusDescription = "Success"
                            responseString = "<html><body>R1JobRunner - XPS CP Sim </br> LISTENING!!</body></html>"
                            buffer = System.Text.Encoding.UTF8.GetBytes(responseString)
                            response.ContentLength64 = buffer.Length
                            output = response.OutputStream
                            output.Write(buffer, 0, buffer.Length)
                            Debug.WriteLine("XPS General Website")
                        Else
                            'Check for stop command and END
                            If context.Request.QueryString.Item(context.Request.QueryString.Count - 1) = "STOP" Then
                                Debug.WriteLine("XPS STOP")
                                response = context.Response
                                response.StatusCode = 200
                                response.StatusDescription = "STOP"
                                responseString = "STOP"
                                buffer = System.Text.Encoding.UTF8.GetBytes(responseString)
                                response.ContentLength64 = buffer.Length
                                output = response.OutputStream
                                output.Write(buffer, 0, buffer.Length)
                                [Stop]()
                            End If
                        End If
                    Else
                        'Response for initial Auth query
                        If context.Request.QueryString.Item(context.Request.QueryString.Count - 1) = context.Request.QueryString.Item(context.Request.QueryString.Count - 2) Then
                            response = context.Response
                            response.StatusCode = 400
                            response.StatusDescription = "ERROR"
                            responseString = "Access Denied"
                            buffer = System.Text.Encoding.UTF8.GetBytes(responseString)
                            response.ContentLength64 = buffer.Length
                            output = response.OutputStream
                            output.Write(buffer, 0, buffer.Length)
                            Debug.WriteLine("XPS Auth Request")
                        Else
                            'Response for report query
                            response = context.Response
                            If Not String.IsNullOrWhiteSpace(Me.MalwareMD5) Then
                                'Use Specified MD5
                                buffer = System.Text.Encoding.UTF8.GetBytes(XPS.XPS_MDE_Response_ToJSON(XPS.GenerateXPS_MDE_Response(Me.MalwareMD5)))
                                Debug.WriteLine("XPS Response with Custom MD5")
                            Else
                                'Else use FETest MD5
                                buffer = System.Text.Encoding.UTF8.GetBytes(XPS.XPS_MDE_Response_ToJSON(XPS.GenerateXPS_MDE_Response("47f9fdc617f8c98a6732be534d8dbe9a")))
                                Debug.WriteLine("XPS Response with FE MD5")
                            End If
                            response.ContentLength64 = buffer.Length
                            output = response.OutputStream
                            output.Write(buffer, 0, buffer.Length)
                        End If

                    End If

                Catch ex As HttpListenerException
                    Console.WriteLine(ex.Message)
                Finally

                End Try
            End If
        End Sub
        Private Sub CertLoad()
            Dim selfcertmy = JobRunner_Functions.CheckMyStoreForSelfSigned
            Dim selfcertroot = JobRunner_Functions.CheckRootStoreForSelfSigned
            If selfcertmy.Count > 0 Then
                Select Case selfcertroot.Count
                    Case 0
                        JobRunner_Functions.MoveSelfFromMyToRoot(selfcertmy(0))
                        Main.sim_selfcert = selfcertmy(0)
                        Debug.WriteLine("My Exists, Moving to Root")
                    Case 1
                        If selfcertmy(0) = selfcertroot(0) Then
                            Main.sim_selfcert = selfcertroot(0)
                            Debug.WriteLine("My = Root, Using")
                        Else
                            JobRunner_Functions.DeleteRootSelfSigned(selfcertroot(0))
                            JobRunner_Functions.MoveSelfFromMyToRoot(selfcertmy(0))
                            Main.sim_selfcert = selfcertmy(0)
                            Debug.WriteLine("My <> Root. Deleting and Moving")
                        End If
                    Case Else
                        'Just use 0 in root
                        Main.sim_selfcert = selfcertroot(0)
                        Debug.WriteLine("Using Root 0")
                End Select
            Else
                Dim selfcert = JobRunner_Functions.CreateSelfInMy()
                JobRunner_Functions.MoveSelfFromMyToRoot(selfcert.GetCertHashString)
                Main.sim_selfcert = selfcert.GetCertHashString
                Debug.WriteLine("No Certs. Creating and Using New")
            End If
        End Sub

        Private Sub AssociateCertToListener(ByVal certhash As String)
            Try
                Dim appguid As String = New Guid(CType(Main.GetType.Assembly.GetCustomAttributes(GetType(Runtime.InteropServices.GuidAttribute), False)(0), Runtime.InteropServices.GuidAttribute).Value).ToString
                Dim netshproc As New Process
                Debug.WriteLine("netsh http add sslcert ipport=0.0.0.0:" & Main.xps_sim_Port.Value & " certhash=" & certhash & " appid={" & appguid & "}")
                Dim netshprocStartInfo As New ProcessStartInfo("cmd.exe", "/c netsh http add sslcert ipport=0.0.0.0:" & Main.xps_sim_Port.Value & " certhash=" & certhash & " appid={" & appguid & "}")
                netshprocStartInfo.WindowStyle = ProcessWindowStyle.Hidden
                netshprocStartInfo.CreateNoWindow = True
                netshprocStartInfo.UseShellExecute = False
                netshprocStartInfo.RedirectStandardError = True
                netshprocStartInfo.RedirectStandardOutput = True
                netshproc.StartInfo = netshprocStartInfo
                Debug.WriteLine("Running commands")
                netshproc.Start()
                Dim netshreader As IO.StreamReader = netshproc.StandardOutput
                Debug.WriteLine(netshreader.ReadToEnd)
            Catch ex As Exception
                Debug.WriteLine(ex.Message)
            End Try
        End Sub

        Private Sub DeAssociateCertToListener()
            Try
                Dim appguid As String = New Guid(CType(Main.GetType.Assembly.GetCustomAttributes(GetType(Runtime.InteropServices.GuidAttribute), False)(0), Runtime.InteropServices.GuidAttribute).Value).ToString
                Dim netshproc As New Process
                Debug.WriteLine("netsh http delete sslcert ipport=0.0.0.0:" & Main.xps_sim_Port.Value)
                Dim netshprocStartInfo As New ProcessStartInfo("cmd.exe", "/c netsh http delete sslcert ipport=0.0.0.0:" & Main.xps_sim_Port.Value)
                netshprocStartInfo.WindowStyle = ProcessWindowStyle.Hidden
                netshprocStartInfo.UseShellExecute = False
                netshprocStartInfo.CreateNoWindow = True
                netshprocStartInfo.RedirectStandardError = True
                netshprocStartInfo.RedirectStandardOutput = True
                netshproc.StartInfo = netshprocStartInfo
                Debug.WriteLine("Running commands")
                netshproc.Start()
                Dim netshreader As IO.StreamReader = netshproc.StandardOutput
                Debug.WriteLine(netshreader.ReadToEnd)
            Catch ex As Exception
                Debug.WriteLine(ex.Message)
            End Try
        End Sub
    End Class

End Module
