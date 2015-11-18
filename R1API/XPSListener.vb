Imports System.Security.Cryptography.X509Certificates
Imports System.IO
Imports System.Net
Imports System.Globalization
Module XPSListener

    Public Sub GenKey()

        IO.File.WriteAllBytes("xps_listen_certificate.pfx", My.Resources.r1_job_runner_combined)

        Dim certload As New X509Certificate2

        certload.Import("xps_listen_certificate.pfx", "", X509KeyStorageFlags.MachineKeySet)

   
        Debug.WriteLine("Cert Hash:" & certload.GetCertHashString)
        Dim xstore As New X509Store(StoreName.My, StoreLocation.LocalMachine)
        xstore.Open(OpenFlags.ReadWrite)
        xstore.Add(certload)
        xstore.Close()
        Dim appguid As String = New Guid(CType(Main.GetType.Assembly.GetCustomAttributes(GetType(Runtime.InteropServices.GuidAttribute), False)(0), Runtime.InteropServices.GuidAttribute).Value).ToString
        Dim netshproc As New Process
        Debug.WriteLine("netsh http add sslcert ipport=0.0.0.0:8448 certhash=" & certload.GetCertHashString & " appid={" & appguid & "}")
        Dim netshprocStartInfo As New ProcessStartInfo("cmd.exe", "/c netsh http add sslcert ipport=0.0.0.0:8448 certhash=" & certload.GetCertHashString & " appid={" & appguid & "}")
        netshprocStartInfo.WindowStyle = ProcessWindowStyle.Hidden
        netshprocStartInfo.UseShellExecute = False
        netshprocStartInfo.RedirectStandardError = True
        netshprocStartInfo.RedirectStandardOutput = True
        netshproc.StartInfo = netshprocStartInfo
        Debug.WriteLine("Running commands")
        netshproc.Start()
        Dim netshreader As IO.StreamReader = netshproc.StandardOutput
        Debug.WriteLine(netshreader.ReadToEnd)

    End Sub

    Public Sub EndListener()
        Dim appguid As String = New Guid(CType(Main.GetType.Assembly.GetCustomAttributes(GetType(Runtime.InteropServices.GuidAttribute), False)(0), Runtime.InteropServices.GuidAttribute).Value).ToString
        Dim netshproc As New Process
        Debug.WriteLine("netsh http delete sslcert ipport=0.0.0.0:8448")
        Dim netshprocStartInfo As New ProcessStartInfo("cmd.exe", "/c netsh http delete sslcert ipport=0.0.0.0:8448")
        netshprocStartInfo.WindowStyle = ProcessWindowStyle.Hidden
        netshprocStartInfo.UseShellExecute = False
        netshprocStartInfo.RedirectStandardError = True
        netshprocStartInfo.RedirectStandardOutput = True
        netshproc.StartInfo = netshprocStartInfo
        Debug.WriteLine("Running commands")
        netshproc.Start()
        Dim netshreader As IO.StreamReader = netshproc.StandardOutput
        Debug.WriteLine(netshreader.ReadToEnd)
    End Sub

    Public Function CreatePrefixes()

        Dim prefixes(0) As String
        prefixes(0) = "https://*:8448/query/"
        'ProcessRequests(prefixes)
        Return prefixes
    End Function

    Public Function CreateListener(ByVal prefixes)
  
        ' URI prefixes are required,
        If prefixes Is Nothing OrElse prefixes.Length = 0 Then
            Throw New ArgumentException("prefixes")
        End If

        ' Create a listener and add the prefixes.
        Dim listener As System.Net.HttpListener = _
            New System.Net.HttpListener()
        For Each s As String In prefixes
            listener.Prefixes.Add(s)

        Next
        Return listener
    End Function

    Private Sub ProcessRequests(ByVal prefixes() As String)
        If Not System.Net.HttpListener.IsSupported Then
            Console.WriteLine( _
                "Windows XP SP2, Server 2003, or higher is required to " & _
                "use the HttpListener class.")
            Exit Sub
        End If
        ' URI prefixes are required,
        If prefixes Is Nothing OrElse prefixes.Length = 0 Then
            Throw New ArgumentException("prefixes")
        End If

        ' Create a listener and add the prefixes.
        Dim listener As System.Net.HttpListener = _
            New System.Net.HttpListener()
        For Each s As String In prefixes
            listener.Prefixes.Add(s)

        Next


        Try
            ' Start the listener to begin listening for requests.
            listener.Start()
            Console.WriteLine("Listening...")

            ' Set the number of requests this application will handle.
            Dim numRequestsToBeHandled As Integer = 100

            For i As Integer = 0 To numRequestsToBeHandled

                Dim response As HttpListenerResponse = Nothing
                Try
                    Dim responseString As String = ""
                    Dim buffer() As Byte
                    Dim output As System.IO.Stream
                    ' Note: GetContext blocks while waiting for a request.
                    Dim context As HttpListenerContext = listener.GetContext()
                    Debug.WriteLine(context.Request.QueryString.Item(context.Request.QueryString.Count - 1))
                    Debug.WriteLine(context.Request.QueryString.Item(context.Request.QueryString.Count - 2))
                    If context.Request.QueryString.Item(context.Request.QueryString.Count - 1) = context.Request.QueryString.Item(context.Request.QueryString.Count - 2) Then
                        response = context.Response
                        response.StatusCode = 400
                        response.StatusDescription = "ERROR"
                        responseString = "Access Denied"
                        buffer = System.Text.Encoding.UTF8.GetBytes(responseString)
                        response.ContentLength64 = buffer.Length
                        output = response.OutputStream
                        output.Write(buffer, 0, buffer.Length)

                    Else
                        ' Create the response.
                        response = context.Response
                        ' responseString = My.Resources.analysis.ToString
                        '"<html>Could not retrieve JSON report data </html>"
                        ' buffer = System.Text.Encoding.UTF8.GetBytes(responseString)
                        ' response.ContentLength64 = buffer.Length
                        IO.File.WriteAllBytes("analysis.json", My.Resources.analysis)
                        Debug.WriteLine(IO.File.ReadAllText("analysis.json"))
                        buffer = System.Text.Encoding.UTF8.GetBytes(IO.File.ReadAllText("analysis.json"))
                        response.ContentLength64 = buffer.Length
                        output = response.OutputStream
                        output.Write(buffer, 0, buffer.Length)
                    End If

                Catch ex As HttpListenerException
                    Console.WriteLine(ex.Message)
                Finally
                    If response IsNot Nothing Then
                        response.Close()
                    End If
                End Try
            Next
        Catch ex As HttpListenerException
            Console.WriteLine(ex.Message)
        Finally
            ' Stop listening for requests.
            listener.Close()
            Console.WriteLine("Done Listening...")
        End Try
    End Sub
End Module
