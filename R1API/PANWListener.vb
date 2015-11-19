Imports System.Security.Cryptography.X509Certificates
Imports System.IO
Imports System.Net
Imports System.Globalization
Module PANWListener

    Public Sub GenKey()
        Try
            IO.File.WriteAllBytes("panw_listen_certificate.pfx", My.Resources.panw_listen_certificate)

            Dim certload As New X509Certificate2

            certload.Import("panw_listen_certificate.pfx", "", X509KeyStorageFlags.MachineKeySet)

            IO.File.Delete("panw_listen_certificate.pfx")

            Debug.WriteLine("Cert Hash:" & certload.GetCertHashString)
            Dim xstore As New X509Store(StoreName.My, StoreLocation.LocalMachine)
            xstore.Open(OpenFlags.ReadWrite)
            xstore.Add(certload)
            xstore.Close()
            Dim appguid As String = New Guid(CType(Main.GetType.Assembly.GetCustomAttributes(GetType(Runtime.InteropServices.GuidAttribute), False)(0), Runtime.InteropServices.GuidAttribute).Value).ToString
            Dim netshproc As New Process
            Debug.WriteLine("netsh http add sslcert ipport=0.0.0.0:" & Main.panw_sim_port.Value & " certhash=" & certload.GetCertHashString & " appid={" & appguid & "}")
            Dim netshprocStartInfo As New ProcessStartInfo("cmd.exe", "/c netsh http add sslcert ipport=0.0.0.0:" & Main.panw_sim_port.Value & " certhash=" & certload.GetCertHashString & " appid={" & appguid & "}")
            netshprocStartInfo.WindowStyle = ProcessWindowStyle.Hidden
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

    Public Sub EndListener()
        Try
            Dim appguid As String = New Guid(CType(Main.GetType.Assembly.GetCustomAttributes(GetType(Runtime.InteropServices.GuidAttribute), False)(0), Runtime.InteropServices.GuidAttribute).Value).ToString
            Dim netshproc As New Process
            Debug.WriteLine("netsh http delete sslcert ipport=0.0.0.0:" & Main.panw_sim_port.Value)
            Dim netshprocStartInfo As New ProcessStartInfo("cmd.exe", "/c netsh http delete sslcert ipport=0.0.0.0:" & Main.panw_sim_port.Value)
            netshprocStartInfo.WindowStyle = ProcessWindowStyle.Hidden
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

    Public Function CreatePrefixes(ByVal Port)

        Dim prefixes(0) As String
        prefixes(0) = "https://*:" & Port & "/"
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


End Module
