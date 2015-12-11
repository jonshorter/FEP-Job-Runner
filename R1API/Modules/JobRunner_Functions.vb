Imports System.Net
Imports System.IO
Imports Newtonsoft.Json
Imports System.Text.RegularExpressions
Imports System.Security.Cryptography.X509Certificates
Imports R1SimpleRestClient

Module JobRunner_Functions






    Public Sub CheckForUpdates(Silent As Boolean)
        Try
            Dim updateclient As New WebClient
            Dim pageHTML As String
            Dim responseData As Byte()
            updateclient.Headers.Add("User-Agent", "R1-Job-Runner")
            responseData = updateclient.DownloadData("https://api.github.com/repos/bmartin5692/R1-Job-Runner/releases/latest")
            pageHTML = System.Text.Encoding.ASCII.GetString(responseData)
            Dim releaseInfo = Newtonsoft.Json.JsonConvert.DeserializeObject(pageHTML)

            Dim version As String = ""
            Dim description As String = ""
            Dim link As String = ""

            For Each item As Linq.JProperty In releaseInfo
                Select Case item.Name
                    Case "tag_name"
                        version = item.Value
                    Case "body"
                        description = item.Value
                        If description.Contains("![image]") Then
                            Dim pattern As String = "!\[image\]\(.*\)"
                            Dim replacement As String = ""
                            Dim rgx As New Regex(pattern)
                            description = rgx.Replace(description, replacement)

                        End If

                    Case "assets"
                        For Each subitem As Linq.JObject In item.Value
                            For Each subsubitem In subitem
                                Select Case subsubitem.Key
                                    Case "browser_download_url"
                                        Dim url As String = subsubitem.Value
                                        If url.Contains("R1_Job_Runner.exe") Then
                                            link = url
                                        End If

                                End Select
                            Next
                        Next
                End Select
            Next

            Dim appver = "v" & My.Application.Info.Version.ToString
            If appver < version Then

                Dim maintext = "Version " & version & " is now available." & vbCrLf & "---------------" & vbCrLf & _
                        description & vbCrLf & "---------------" & vbCrLf
                Dim updatedialog As New UpdateDialog(maintext, "New Version Available", link)
                Dim result = updatedialog.ShowDialog
            Else
                If Not Silent = True Then
                    MsgBox("No Updates Available. Your version is the latest.", MsgBoxStyle.Information, "No Updates Available")
                End If
            End If
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        End Try
    End Sub

    Public Function CheckRootStoreForSelfSigned() As List(Of String)
        Dim fndhashes As New List(Of String)
        Dim xstore As New X509Store(StoreName.Root, StoreLocation.LocalMachine)
        xstore.Open(OpenFlags.ReadWrite)
        For Each cert As X509Certificate2 In xstore.Certificates
            If cert.Subject = "CN=" & My.Computer.Name Then
                Debug.WriteLine("Found Self-Signed In Root Store")
                fndhashes.Add(cert.GetCertHashString)
            End If
        Next
        xstore.Close()
        Return fndhashes
    End Function
    Public Function CheckMyStoreForSelfSigned() As List(Of String)
        Dim fndhashes As New List(Of String)
        Dim xstore As New X509Store(StoreName.My, StoreLocation.LocalMachine)
        xstore.Open(OpenFlags.ReadWrite)
        For Each cert As X509Certificate2 In xstore.Certificates
            If cert.Subject = "CN=" & My.Computer.Name Then
                Debug.WriteLine("Found Self-Signed In My Store")
                fndhashes.Add(cert.GetCertHashString)
            End If
        Next
        xstore.Close()
        Return fndhashes
    End Function

    Public Sub MoveSelfFromMyToRoot(ByVal certhash As String)
        Dim mystore As New X509Store(StoreName.My, StoreLocation.LocalMachine)
        mystore.Open(OpenFlags.ReadWrite)
        For Each cert As X509Certificate2 In mystore.Certificates
            If cert.GetCertHashString = certhash Then
                Debug.WriteLine("Found Self-Signed In My Store and Moving to Root")
                Dim rootstore As New X509Store(StoreName.Root, StoreLocation.LocalMachine)
                rootstore.Open(OpenFlags.ReadWrite)
                rootstore.Add(cert)
                rootstore.Close()
            End If
        Next
        mystore.Close()
    End Sub

    Public Function CreateSelfInMy() As X509Certificate2
        Dim cn As String = "CN=" & My.Computer.Name
        Dim self = CertificateCreator.CreateSelfSignCertificate(New X500DistinguishedName(cn), Date.Now, Date.Now.AddYears(2))
        Return self
    End Function



    Public Sub DeleteMySelfSigned(ByVal certhash As String)
        Dim xstore As New X509Store(StoreName.My, StoreLocation.LocalMachine)
        xstore.Open(OpenFlags.ReadWrite)
        For Each cert As X509Certificate2 In xstore.Certificates
            If cert.GetCertHashString = certhash Then
                Debug.WriteLine("Found Self-Signed In My Store and Removing")
                xstore.Remove(cert)
            End If
        Next
        xstore.Close()
    End Sub
    Public Sub DeleteRootSelfSigned(ByVal certhash As String)
        Dim xstore As New X509Store(StoreName.Root, StoreLocation.LocalMachine)
        xstore.Open(OpenFlags.ReadWrite)
        For Each cert As X509Certificate2 In xstore.Certificates
            If cert.GetCertHashString = certhash Then
                Debug.WriteLine("Found Self-Signed In Root Store and Removing")
                xstore.Remove(cert)
            End If
        Next
        xstore.Close()
    End Sub
End Module
