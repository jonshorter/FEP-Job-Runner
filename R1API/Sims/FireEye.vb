Imports System.Net
Imports System.Text
Imports System.Collections.Specialized
Imports System.IO
Imports Newtonsoft.Json

Module FireEye
    Public Class Src
        Public Property ip As String
        Public Property vlan As String
        Public Property port As String
    End Class

    Public Class Malware
        Public Property httpheader As String
        Public Property name As String
        Public Property downloadedat As New DateTime
        Public Property origid As String
        Public Property md5sum As String
        Public Property executedat As New DateTime
        Public Property application As String
        Public Property sid As String
        Public Property type As String
        Public Property original As String
        Public Property stype As String
    End Class

    Public Class MalwareDetected
        Public Property malware As New Malware
    End Class

    Public Class Explanation
        Public Property malwaredetected As New MalwareDetected
        Public Property protocol As String
        Public Property analysis As String
    End Class

    Public Class Dst
        Public Property ip As String
        Public Property port As String
    End Class

    Public Class Alert
        Public Property src As New Src
        Public Property severity As String
        Public Property alerturl As String
        Public Property explanation As New Explanation
        Public Property occurred As New DateTime
        Public Property id As String
        Public Property action As String
        Public Property dst As New Dst
        Public Property name As String
    End Class

    Public Class FireEye_Event
        Public Property msg As String
        Public Property product As String
        Public Property version As String
        Public Property appliance As String
        Public Property alert As New Alert
    End Class

    Public Function GenerateFEEvent(ByVal Type As String)
        'Create a new default event
        Dim fe_event As New FireEye_Event
        fe_event.msg = "Normal"
        fe_event.product = "Web MPS"
        fe_event.appliance = "fireeye.local"
        fe_event.version = "7.1.0.180577"
        fe_event.alert.src.ip = Main.txtFETarget.Text
        fe_event.alert.src.vlan = "0"
        fe_event.alert.src.port = "1265"
        fe_event.alert.severity = "majr"
        fe_event.alert.alerturl = "https://fireeye.adlab.local/event_stream/events_for_bot?ma_id=958"
        fe_event.alert.explanation.malwaredetected.malware.httpheader = "GET /appliance-test/test-infection.exe HTTP/1.0User-Agent: Wget/1.10.2Accept: */*Host: fedeploycheck.fireeye.comConnection: Keep-Alive"
        fe_event.alert.explanation.malwaredetected.malware.name = "FETestEvent - " & Type
        fe_event.alert.explanation.malwaredetected.malware.downloadedat = DateTime.UtcNow
        fe_event.alert.explanation.malwaredetected.malware.origid = "385"
        fe_event.alert.explanation.malwaredetected.malware.md5sum = "47f9fdc617f8c98a6732be534d8dbe9a"
        fe_event.alert.explanation.malwaredetected.malware.executedat = DateTime.UtcNow
        fe_event.alert.explanation.malwaredetected.malware.application = "Windows Explorer"
        fe_event.alert.explanation.malwaredetected.malware.sid = "385"
        fe_event.alert.explanation.malwaredetected.malware.type = "exe"
        fe_event.alert.explanation.malwaredetected.malware.original = "test-infection.exe"
        fe_event.alert.explanation.malwaredetected.malware.stype = "duplicate-md5sum"
        fe_event.alert.explanation.protocol = "tcp"
        fe_event.alert.explanation.analysis = "binary"
        fe_event.alert.occurred = DateTime.UtcNow
        fe_event.alert.id = "958"
        fe_event.alert.action = "notified"
        fe_event.alert.dst.ip = "199.16.197.6"
        fe_event.alert.dst.port = "80"
        fe_event.alert.name = Type
        Return fe_event
    End Function
    Public Function FEventtoJson(ByVal FEEvent As FireEye.FireEye_Event)
        'Convert to JSON from FEEvent
        Dim jstr As String = JsonConvert.SerializeObject(FEEvent)
        'Fix messed up headers
        jstr = jstr.Replace("httpheader", "http-header")
        jstr = jstr.Replace("downloadedat", "downloaded-at")
        jstr = jstr.Replace("executedat", "executed-at")
        jstr = jstr.Replace("malwaredetected", "malware-detected")
        jstr = jstr.Replace("alerturl", "alert-url")
        'Return JSON STring
        Return jstr
    End Function


    Public Sub SendEvent(JSON As String, Optional showResult As Boolean = False)
        Try
            If Main.chkbypasscerts.Checked Then
                'Ignore self-signed / bad certificates
                ServicePointManager.ServerCertificateValidationCallback = AddressOf ValidateRemoteCertificate

            End If

            'New web request = 3rdParty/FireEye

            Dim request As HttpWebRequest

            request = HttpWebRequest.Create("https://" & Main.txtServer.Text & "/" & My.Settings.websitepath & "/ThirdPartyIntegration/ThirdPartyIntegrationHandler/FireEye")
         
            '    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12

            request.ContentType = "text/json"
            request.Method = "POST"
            request.Accept = "text/json"
            'Set basic auth details
            Dim credsend As String = "Basic " + Convert.ToBase64String(Encoding.UTF8.GetBytes(Main.txtApiUser.Text & ":" & ToInsecureString(Main.apipass)))
            request.Headers.Add("Authorization", credsend)
            'Send request
            Using sw As New StreamWriter(request.GetRequestStream)
                sw.Write(JSON)
                sw.Close()
            End Using
            'Get response


            Dim response As WebResponse = request.GetResponse()

            Using sr As New StreamReader(response.GetResponseStream)
                Dim rstring As String = sr.ReadToEnd
                If rstring = "" Then
                    Main.lblFEStatus.Text = "FireEye Event Submitted"
                    DebugWriteLine("FireEye Event Submitted")
                Else
                    Main.lblFEStatus.Text = "Error Submitting FireEye Event"
                End If
            End Using
        Catch we As System.Net.WebException
            Main.lblFEStatus.Text = we.Message

        Catch ex As Exception
            Main.lblFEStatus.Text = ex.Message


        End Try


    End Sub
End Module
