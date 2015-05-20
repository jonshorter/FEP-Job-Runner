﻿Imports System.Net
Imports System.Text
Imports System.IO
Imports System.Net.Sockets

Module PANW

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
        Public Property P43Filedigest = "943c1eb59d2179a5e6fbef1a4124c154"
        Public Property P44Cloud = "ca-s1.wildfire.paloaltonetworks.com"
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
            Dim PANWPORT As Integer = 514
            Dim bytCommand As Byte() = New Byte() {}
            udpClient.Connect(Main.txtServer.Text, PANWPORT)
            bytCommand = Encoding.ASCII.GetBytes(PANWEvent)
            Dim pRet = udpClient.Send(bytCommand, bytCommand.Length)
            Console.WriteLine("No of bytes sent " & pRet)
            Main.statuslabel.Text = "PANW Syslog Threat Event Sent"
        Catch ex As Exception
            Main.statuslabel.Text = ex.Message
        End Try
    End Sub



    'Public Function ExtractAlertFromSyslog(alert As String, applianceId As String) As ThreatEvent
    '    SyslogMsgParser.CallLogInfo(alert)
    '    Dim num As Integer = Enumerable.Count(Of Char)(DirectCast(Alert, IEnumerable(Of Char)), DirectCast(Function(f) CInt(f) = 44, Func(Of Char, Boolean)))
    '    If num <> 44 Then
    '        SyslogMsgParser.CallLogInfo("Invalid threat log format (commas) " + DirectCast(num, Object))
    '        Return DirectCast(Nothing, ThreatEvent)
    '    Else
    '        Dim strArray As String() = Alert.Split(","c)
    '        If strArray(3).ToUpper() <> "THREAT" Then
    '            SyslogMsgParser.CallLogInfo("Ignoring invalid log type " + strArray(3).ToUpper())
    '            Return DirectCast(Nothing, ThreatEvent)
    '        ElseIf strArray(30).ToUpper() = "ALERT" OrElse strArray(30).ToUpper() = "ALLOW" Then
    '            If Not Me._handler.IsAlertEnabledForThisType(Me._paApplicanceSettings, strArray(4).ToUpper()) Then
    '                SyslogMsgParser.CallLogInfo("Pitching threat that is disabled by config: " + strArray(4).ToUpper())
    '                Return DirectCast(Nothing, ThreatEvent)
    '            ElseIf Not Me._handler.IsAlertSeverityInScopeForThisType(Me._paApplicanceSettings, strArray(4).ToUpper(), strArray(34).ToUpper()) Then
    '                SyslogMsgParser.CallLogInfo("Pitching threat whose sev is out of scope by config: " + strArray(4).ToUpper() + " " + strArray(34).ToUpper())
    '                Return DirectCast(Nothing, ThreatEvent)
    '            Else
    '                Dim threatEvent As New ThreatEvent()
    '                threatEvent.ApplianceId = applianceId
    '                threatEvent.ThreatType = strArray(4).ToUpper()
    '                threatEvent.AlertName = strArray(32)
    '                threatEvent.MalwareName = Me.PrepareMalwarePayloadFileName(strArray(31))
    '                threatEvent.EventId = strArray(22)
    '                threatEvent.Severity = strArray(34).ToUpper()
    '                threatEvent.Action = strArray(30).ToUpper()
    '                threatEvent.Occurred = strArray(6)
    '                threatEvent.UniqueId = strArray(36)
    '                threatEvent.Target = If(Not (strArray(35) = "client-to-server"), strArray(8), strArray(7))
    '                threatEvent.Assessment = threatEvent.ThreatType + " " + threatEvent.Severity
    '                threatEvent.Indicators = DirectCast(Nothing, List(Of ThreatFilterBuilder))
    '                If Me._handler.IsThreatScanEnabledForThisType(Me._paApplicanceSettings, threatEvent.ThreatType) AndAlso strArray(4).ToUpper() = "WILDFIRE" AndAlso strArray(33).ToUpper() = "MALICIOUS" Then
    '                    threatEvent.Indicators = New List(Of ThreatFilterBuilder)()
    '                    Dim fileNameExtenstion As String = Me.GetMalwarePayloadFileNameExtenstion(threatEvent.MalwareName)
    '                    Dim list As List(Of ThreatFilterBuilder) = Me.IncludeWildfireData(strArray(43), Me._paApplicanceSettings.WildFireApiUrl, Me._paApplicanceSettings.WildFireApiKey, fileNameExtenstion)
    '                    If Enumerable.Any(Of ThreatFilterBuilder)(DirectCast(list, IEnumerable(Of ThreatFilterBuilder))) Then
    '                        threatEvent.Indicators.AddRange(DirectCast(list, IEnumerable(Of ThreatFilterBuilder)))
    '                    End If
    '                End If
    '                Return threatEvent
    '            End If
    '        Else
    '            SyslogMsgParser.CallLogInfo("Non-actionable threat in log")
    '            Return DirectCast(Nothing, ThreatEvent)
    '        End If
    '    End If
    'End Function


End Module