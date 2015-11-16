Imports System.Net
Imports System.Text
Imports System.IO
Imports System.Net.Sockets

Module XPS

    '<33>Nov 12 11:45:15 xps ,bfb696b3-895c-11e5-a92b-000c2947b169,10.0.1.28,10.0.1.204,alert,Backdoor.Generic.WebShell.fss1,BACKDOOR,Malware Detection Engine,critical,2015-11-12 11:45:15,10.0.1.204
    'if (strArray[4].ToUpper() == "ALERT")
    ' {
    '   ThreatEvent threatEvent = new ThreatEvent()
    '   {
    '     ApplianceId = applianceId,
    '     ThreatType = strArray[6].ToUpper(),
    '     AlertName = strArray[7],
    '     MalwareName = this.PrepareMalwarePayloadFileName(strArray[5]),
    '     EventId = strArray[1],
    '     Severity = strArray[8].ToUpper(),
    '     Action = strArray[4].ToUpper(),
    '     Occurred = strArray[9],
    '     UniqueId = strArray[1],
    '     Target = strArray[10]
    '   };
    Public Class XPSThreat
        Public Property Header = "<33>" & DateTime.Now & " xps"
        Public Property Alertuuid As Guid = Guid.NewGuid
        Public Property Srcaddr As String
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
            Console.WriteLine("No of bytes sent " & pRet)
            Main.statuslabel.Text = "XPS Syslog Threat Event Sent"
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
