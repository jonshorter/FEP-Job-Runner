Imports System.Net
Imports System.Text
Imports System.IO
Imports System.Net.Sockets

Module XPS

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
            Console.WriteLine("No of bytes sent " & pRet)
            Main.lblXPSStatus.Text = "XPS Syslog Malware Event Sent"

        Catch ex As Exception
            Main.lblXPSStatus.Text = ex.Message
        End Try

    End Sub



End Module
