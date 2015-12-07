Imports System.Net
Imports System.IO
Imports Newtonsoft.Json
Imports System.Text.RegularExpressions

Module JobRunner_Functions
    Public Sub CheckForUpdates(Silent As Boolean)
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
                MsgBox("No Updates Available. Your version is the lastest.", MsgBoxStyle.Information, "No Updates Available")
            End If
        End If

    End Sub

  
End Module
