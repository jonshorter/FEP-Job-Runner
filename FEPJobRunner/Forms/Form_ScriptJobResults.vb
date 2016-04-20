Imports Newtonsoft

Public Class Form_ScriptJobResults
    Private JobResultID As String
    Private Sub ToCSV(ByVal filename As String)
        Dim headers = (From header As DataGridViewColumn In dgvScriptJobResults.Columns.Cast(Of DataGridViewColumn)() _
              Select header.HeaderText).ToArray
        Dim rows = From row As DataGridViewRow In dgvScriptJobResults.Rows.Cast(Of DataGridViewRow)() _
                   Where Not row.IsNewRow _
                   Select Array.ConvertAll(row.Cells.Cast(Of DataGridViewCell).ToArray, Function(c) If(c.Value IsNot Nothing, c.Value.ToString, ""))
        Using sw As New IO.StreamWriter(filename)
            sw.WriteLine(String.Join(",", headers))
            For Each r In rows
                sw.WriteLine(String.Join(",", r))
            Next
        End Using
    End Sub
    Private Sub Form_ScriptJobResults_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim jobtargets = Main.RestClient.Functions.Job.GetJobTargets(JobResultID, 0, 1)
        If jobtargets.Success = True Then
            Me.Text = "Results for Job: " & jobtargets.Data.jobName
        End If
        Dim resultcolumns = Main.RestClient.Functions.ScriptPackages.GetFieldsByJobResult(JobResultID)
        If resultcolumns.Success = True Then
            dgvScriptJobResults.Columns.Add("_EndpointName", "Endpoint Name")
            For Each item In resultcolumns.Data
                dgvScriptJobResults.Columns.Add(item, item)
            Next
        End If
        Dim results = Main.RestClient.Functions.Job.GetJobResults(JobResultID)
        If results.Success = True Then
            For Each item In results.Data.hits.Hits
                Dim newrow = dgvScriptJobResults.Rows.Add
                Dim hitdata As Json.Linq.JObject = item._source
                Dim hitarray As New ArrayList
                For Each keyval In hitdata
                    If keyval.Key.StartsWith("_") Then
                        If keyval.Key = "_EndpointName" Then
                            dgvScriptJobResults.Rows(newrow).Cells("_EndpointName").Value = keyval.Value
                        End If
                    Else
                        dgvScriptJobResults.Rows(newrow).Cells(keyval.Key).Value = keyval.Value
                    End If
                Next

            Next
        End If
    End Sub

    Public Sub New(ByVal JobResultId As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.JobResultID = JobResultId
    End Sub

    Private Sub SaveToCSVToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToCSVToolStripMenuItem.Click
        Dim x = sfd_CSV.ShowDialog()
        If x = Windows.Forms.DialogResult.OK Then
            ToCSV(sfd_CSV.FileName)
        End If
    End Sub
End Class