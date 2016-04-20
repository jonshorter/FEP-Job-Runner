Imports System.Net
Imports System.IO
Imports Newtonsoft.Json
Imports System.Text.RegularExpressions
Imports System.Security.Cryptography.X509Certificates
Imports FEPRestClient
Imports RestSharp
Imports FEPRestClient.Models

Module JobRunner_Functions

    Public Sub CheckForUpdates(ByVal Silent As Boolean, ByVal PreRelease As Boolean)
        DebugWriteLine("Checking for Updates")
        Try
            Dim rest As New RestSharp.RestClient("https://api.github.com/repos/bmartin5692/FEP-Job-Runner/releases")
            Dim request = New RestSharp.RestRequest("latest", RestSharp.Method.GET)
            request.RequestFormat = DataFormat.Json
            request.JsonSerializer = New RestSharpJsonNetSerializer
            Dim response As RestSharp.RestResponse = rest.Execute(request)
            Dim latestrelease = JsonConvert.DeserializeObject(Of JobRunner_Models.GitHubRelease)(response.Content)

            request = New RestSharp.RestRequest("", RestSharp.Method.GET)
            request.RequestFormat = DataFormat.Json
            request.JsonSerializer = New RestSharpJsonNetSerializer
            response = rest.Execute(request)
            Dim allreleases = JsonConvert.DeserializeObject(Of List(Of JobRunner_Models.GitHubRelease))(response.Content)

            Dim prereleases As New List(Of JobRunner_Models.GitHubRelease)
            For Each release In allreleases
                If release.prerelease = True Then
                    If release.tag_name > latestrelease.tag_name Then
                        prereleases.Add(release)
                    End If
                End If
            Next

            Dim newrelease As New JobRunner_Models.GitHubRelease
            Dim newrelease_description As String = ""
            Dim newrelease_link As String = ""
            Dim newrelease_IsPre As Boolean = False
            If PreRelease = True Then
                Select Case prereleases.Count
                    Case 0
                        newrelease = latestrelease
                        newrelease_IsPre = False
                    Case 1
                        newrelease = prereleases(0)
                        newrelease_IsPre = True
                    Case Else
                        Dim prever = prereleases(0).tag_name
                        For Each release In prereleases
                            If release.tag_name >= prever Then
                                newrelease = release
                                newrelease_IsPre = True
                            End If
                        Next
                End Select
            Else
                newrelease = latestrelease
                newrelease_IsPre = False
            End If
            newrelease_description = newrelease.body
            If newrelease_description.Contains("![image]") Then '--------Remove images
                Dim pattern As String = "!\[image\]\(.*\)"
                Dim replacement As String = ""
                Dim rgx As New Regex(pattern)
                newrelease_description = rgx.Replace(newrelease_description, replacement)
            End If
            For Each asset In newrelease.assets
                If asset.browser_download_url.Contains("FEP_Job_Runner") Then
                    newrelease_link = asset.browser_download_url
                End If
            Next

            If Not String.IsNullOrWhiteSpace(newrelease_link) Then
                Dim appver = "v" & My.Application.Info.Version.ToString
                If appver < newrelease.tag_name Then
                    Dim maintext As String = ""
                    Select Case newrelease_IsPre
                        Case True
                            maintext = "Pre-Release Version " & newrelease.tag_name & " is now available." & vbCrLf & "---------------" & vbCrLf & _
                                                    newrelease_description & vbCrLf & "---------------" & vbCrLf
                        Case False
                            maintext = "Version " & newrelease.tag_name & " is now available." & vbCrLf & "---------------" & vbCrLf & _
                                                    newrelease_description & vbCrLf & "---------------" & vbCrLf
                    End Select
                    Dim updatedialog As New Form_UpdateDialog(maintext, "New Version Available", newrelease_link)
                    Dim result = updatedialog.ShowDialog
                Else
                    If Not Silent = True Then
                        MsgBox("No Updates Available. Your have the latest version available.", MsgBoxStyle.Information, "No Updates Available")
                    End If
                End If
            Else
                'There may be releases, but they don't include FEP_Job_Runner executable attached.
                If Not Silent = True Then
                    MsgBox("No Updates Available. Your have the latest version available.", MsgBoxStyle.Information, "No Updates Available")
                End If
            End If

        Catch ex As Exception
            DebugWriteLine(ex.Message)
        End Try
    End Sub
    Public Sub DebugWriteLine(ByVal Text As String)
        Debug.WriteLine(DateTime.UtcNow & " - " & Text)
    End Sub


    Public Function CheckInclusionFilterList(ByVal FilterName As String) As Integer
        DebugWriteLine("Check Inclusion Filter List")
        Dim inclist As List(Of InclusionFilter) = Main.StoreInFiltList
        Dim retvalue As Integer = -1
        Dim cnt As Integer = 0
        'Iterate store
        For Each nfilt In inclist
            'If the filtername = selected item
            If nfilt.FilterName = FilterName Then
                retvalue = cnt
            End If
            cnt += 1
        Next
        Return retvalue
    End Function

    Public Function CheckExclusionFilterList(ByVal FilterName As String) As Integer
        DebugWriteLine("Check Exclusion Filter List")
        Dim exclist As List(Of ExclusionFilter) = Main.StoreExFiltList
        Dim retvalue As Integer = -1
        Dim cnt As Integer = 0
        'Iterate store
        For Each efilt In exclist
            'If the filtername = selected item
            If efilt.FilterName = FilterName Then
                retvalue = cnt
            End If
            cnt += 1
        Next
        Return retvalue
    End Function

    Public Function GetCheckedFilters()
        DebugWriteLine("GetCheckedFilters")
        Dim checkedlist As New List(Of Integer)
        For Each item As DataGridViewRow In Main.dgvFilters.Rows
            If item.Cells(0).Value = True Then
                checkedlist.Add(item.Index)
            End If
        Next
        Return checkedlist
    End Function

    Public Function CheckRootStoreForSelfSigned() As List(Of String)
        Dim fndhashes As New List(Of String)
        Dim xstore As New X509Store(StoreName.Root, StoreLocation.LocalMachine)
        xstore.Open(OpenFlags.ReadWrite)
        For Each cert As X509Certificate2 In xstore.Certificates
            If cert.Subject = "CN=" & My.Computer.Name Then
                DebugWriteLine("Found Self-Signed In Root Store")
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
                DebugWriteLine("Found Self-Signed In My Store")
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
                DebugWriteLine("Found Self-Signed In My Store and Moving to Root")
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
                DebugWriteLine("Found Self-Signed In My Store and Removing")
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
                DebugWriteLine("Found Self-Signed In Root Store and Removing")
                xstore.Remove(cert)
            End If
        Next
        xstore.Close()
    End Sub
    Public Sub JobStatusSearchFacetUpdate()
        If Main.lvJobStatusFacets.Items.Count > 0 Then
            Dim facsearch As New Facet.FacetSearch
            For Each item As ListViewItem In Main.lvJobStatusFacets.Items
                Select Case Split(item.Text, ":")(0)
                    Case "Any"
                        facsearch.SearchAny.Add(Split(item.Text, ":")(1))

                    Case Else
                        Dim facsearchfield As New Facet.FacetSearchFields
                        If Not facsearch.SearchFields.Count = 0 Then
                            Dim found = facsearch.SearchFields.Find(Function(srch As Facet.FacetSearchFields)
                                                                        Return srch.FieldName = item.Tag
                                                                    End Function)
                            If Not found Is Nothing Then
                                found.Values.Add(Split(item.Text, ":")(1))
                            Else
                                facsearchfield.FieldName = item.Tag
                                facsearchfield.Values.Add(Split(item.Text, ":")(1))
                                facsearch.SearchFields.Add(facsearchfield)
                            End If
                        Else
                            facsearchfield.FieldName = item.Tag
                            facsearchfield.Values.Add(Split(item.Text, ":")(1))
                            facsearch.SearchFields.Add(facsearchfield)
                        End If
                End Select
            Next
            JobRunner_RestFunctions.GetJobList(facsearch)
        Else
            JobRunner_RestFunctions.GetJobList()
        End If
    End Sub
    Public Sub ProjSearchFacetUpdate()
        If Main.lvProjectFacets.Items.Count > 0 Then
            Dim facsearch As New Facet.FacetSearch
            For Each item As ListViewItem In Main.lvProjectFacets.Items
                Select Case Split(item.Text, ":")(0)
                    Case "Any"
                        facsearch.SearchAny.Add(Split(item.Text, ":")(1))

                    Case Else
                        Dim facsearchfield As New Facet.FacetSearchFields
                        If Not facsearch.SearchFields.Count = 0 Then
                            Dim found = facsearch.SearchFields.Find(Function(srch As Facet.FacetSearchFields)
                                                                        Return srch.FieldName = item.Tag
                                                                    End Function)
                            If Not found Is Nothing Then
                                found.Values.Add(Split(item.Text, ":")(1))
                            Else
                                facsearchfield.FieldName = item.Tag
                                facsearchfield.Values.Add(Split(item.Text, ":")(1))
                                facsearch.SearchFields.Add(facsearchfield)
                            End If
                        Else
                            facsearchfield.FieldName = item.Tag
                            facsearchfield.Values.Add(Split(item.Text, ":")(1))
                            facsearch.SearchFields.Add(facsearchfield)
                        End If
                End Select
            Next
            JobRunner_RestFunctions.GetProjectList(facsearch)
        Else
            JobRunner_RestFunctions.GetProjectList()
        End If
    End Sub

End Module
