Imports System.Net
Imports System.Text
Imports System.IO
Imports System.Net.Sockets
Imports System.Xml.Serialization

Public Module PANW

    Public Class PANWThreat
        'Possible Date
        Public Property P0FUTURE1 = ""
        Public Property P1Receive_Time = DateTime.UtcNow
        Public Property P2Serial_Number = "001701001477"
        '3 - Used by R1, must be THREAT
        Public Property P3Type = "THREAT"
        '4 - Used by R1, "VIRUS, FILE, FLOOD, URL
        Public Property P4Subtype = "wildfire"
        Public Property P5FUTURE2 = ""
        '6 - Occured
        Public Property P6Generated_Time = DateTime.UtcNow
        Public Property P7Source_IP = Dns.GetHostByName(My.Computer.Name).AddressList(0)
        Public Property P8Destination_IP = "10.0.1.5"
        Public Property P9NAT_Source_IP = "0.0.0.0"
        '10
        Public Property P10NAT_Destination_IP = "0.0.0.0"
        Public Property P11Rule_Name = "Tap_rule"
        Public Property P12Source_User = ""
        Public Property P13Destination_User = "enterprise\user"
        Public Property P14Application = "flash"
        Public Property P15Virtual_System = "vsys1"
        Public Property P16Source_Zone = "Tap_Internal"
        Public Property P17Destination_Zone = "Tap_Internal"
        Public Property P18Ingress_Interface = "ethernet1/4"
        Public Property P19Egress_Interface = "ethernet1/4"
        '20
        Public Property P20Log_Forwarding_Profile = "Syslog_Server"
        'Possible Date
        Public Property P21FUTURE3 = ""
        '22- Event ID
        Public Property P22Session_ID = "263310"
        Public Property P23Repeat_Count = "1"
        Public Property P24Source_Port = "80"
        Public Property P25Destination_Port = "53030"
        Public Property P26NAT_Source_Port = "0"
        Public Property P27NAT_Destination_Port = "0"
        Public Property P28Flags = "0x0"
        Public Property P29Protocol = "tcp"
        '30 - Used by R1, Not "ALERT" or "ALLOW"
        Public Property P30Action = "ALERT"
        '31 - Malware Name / URL
        Public Property P31Miscellaneous = "test-infection.exe"
        '32 - Alert Name / NUMBERS
        Public Property P32Threat_ID = "Executable File(34564)"
        '33 - "MALICIOUS"
        Public Property P33Category = "MALICIOUS"
        '34 - Used by R1, "CRITICAL"
        Public Property P34Severity = "CRITICAL"
        '35 - "client-to-server=0"
        Public Property P35Direction = "server-to-client"
        '36 - Unique ID
        Public Property P36Sequence_Number = "10092158769"
        Public Property P37Action_Flags = "0x0"
        Public Property P38Source_Location = "US"
        Public Property P39Destination_Location = "10.0.0.0-10.255.255.255"
        '40
        Public Property P40FUTURE4 = ""
        Public Property P41Content_Type = ""
        Public Property P42PCAP_ID = ""
        '43 MD5
        Public Property P43Filedigest = "47f9fdc617f8c98a6732be534d8dbe9a"
        Public Property P44Cloud = "wildfire.paloaltonetworks.com"
    End Class

    Public Function ThreatTOCSV(threat As PANWThreat) As String
        Const separator As Char = ","c
        Dim sb As New StringBuilder

        'Get the data elements
        Dim threatfields = GetType(PANWThreat).GetProperties()


        For Each field In threatfields
            Select Case field.Name
                Case "P44Cloud"
                    Dim value As String = Convert.ToString(field.GetValue(threat))
                    sb.Append(value)

                Case Else
                    Dim value As String = Convert.ToString(field.GetValue(threat))
                    sb.Append(value)
                    '... followed by the separator
                    sb.Append(separator)
            End Select

        Next

        Return sb.ToString()
    End Function


    Public Sub SendEvent(PANWEvent As String)
        Try
            Dim udpClient As New UdpClient
            Dim PANWPORT As Integer = Main.panwPort.Value
            Dim bytCommand As Byte() = New Byte() {}
            udpClient.Connect(Main.txtServer.Text, PANWPORT)
            bytCommand = Encoding.ASCII.GetBytes(PANWEvent)
            Dim pRet = udpClient.Send(bytCommand, bytCommand.Length)
            Console.WriteLine("No of bytes sent " & pRet)
            Main.lblPANWStatus.Text = "PANW Syslog Threat Event Sent"
        Catch ex As Exception
            Main.lblPANWStatus.Text = ex.Message
            Debug.WriteLine(ex.Message)
        End Try
    End Sub

    Public Class wildfire
        Public Property version As String = "2.0"
        Public Property file_info As New wildfire_fileinfo
        Public Property task_info As New wildfire_taskinfo
    End Class
    Public Class wildfire_fileinfo
        Public Property sha1 As String = ""
        Public Property sha256 As String = ""
        Public Property md5 As String = "47f9fdc617f8c98a6732be534d8dbe9a"
        Public Property filetype As String = "PE"
        Public Property size As Integer = 28672
        Public Property malware As String = "yes"
    End Class
    Public Class wildfire_taskinfo
        Public Property report As New wildfire_taskinfo_report
    End Class

    Public Class wildfire_taskinfo_report
        Public Property version As String = "0.1"
        Public Property task As String = "71286573"
        Public Property sha256 As String = ""
        Public Property md5 As String = "47f9fdc617f8c98a6732be534d8dbe9a"
        Public Property malware As String = "yes"
        Public Property summary As New wildfire_taskinfo_report_summary
        Public Property process As New wildfire_taskinfo_report_process
        Public Property file
        Public Property registry
        Public Property network As New wildfire_taskinfo_report_network
    End Class
    Public Class wildfire_taskinfo_report_summary
        Public Property entry As String = "Spawned new processess"
    End Class
    Public Class wildfire_taskinfo_report_process
        Public Property process_created As String = ""
        Public Property process_created_child_pid As String = ""
        Public Property process_created_child_process_image As String = ""
        Public Property process_created_parent_pid As String = ""
        Public Property process_created_parent_process_image As String = ""
        Public Property process_terminated As String = ""
        Public Property process_terminated_child_pid As String = ""
        Public Property process_terminated_child_process_image As String = ""
        Public Property process_terminated_parent_pid As String = ""
        Public Property process_terminated_parent_process_image As String = ""
    End Class
    Public Class wildfire_taskinfo_report_network
        Public Property tcpconnection As String = ""
        Public Property tcpconnection_ip As String = ""
        Public Property tcpconnection_pid As String = ""
        Public Property tcpconnection_port As String = ""
        Public Property tcpconnection_process_image As String = ""
        Public Property dns As String = ""
        Public Property dns_query As String = ""
        Public Property dns_type As String = ""
        Public Property url As String = ""
        Public Property url_host As String = ""
        Public Property url_method As String = ""
        Public Property url_uri As String = ""
        Public Property url_user_agent As String = ""
    End Class
    Public Function GeneratePANWResponse(ByVal CustomMD5 As String)
        'Create a new default event
        Dim panw_response As New wildfire

        panw_response.file_info.md5 = CustomMD5
        panw_response.task_info.report.md5 = CustomMD5

        Return panw_response
    End Function

    Public Function PANWResponseToXML(ByVal PANWResponse As wildfire)
        'Convert to JSON from FEEvent
        Dim xstr As String
        Dim xser As New XmlSerializer(GetType(PANW.wildfire))

        Using txtWriter As New StringWriter
            Using xWriter As Xml.XmlWriter = Xml.XmlWriter.Create(txtWriter)
                xser.Serialize(xWriter, PANWResponse)
            End Using
            xstr = txtWriter.ToString
        End Using

        'Fix messed up headers
        xstr = xstr.Replace("tcpconnection", "tcp-connection")



        Return xstr
    End Function

End Module
