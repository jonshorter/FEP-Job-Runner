Imports System.Reflection

Public Class Form_CreateEditScript

    Private Property EditScriptID As String
    Private Property NewScriptFiles As New List(Of String)
    Private Property EditScriptPackage As New FEPRestClient.Models.Scripts.ScriptPackageDetail
    Public Sub New(ByVal title As String, ByVal CreateMode As Boolean, Optional ScriptID As String = "")
        InitializeComponent()

        Me.Text = title

        If CreateMode = True Then
            btnCreateEdit.Text = "Create"
            txtScriptName.Text = ""
            txtScriptDelimiter.Text = ","
            lbScriptPlatforms.Items.Add("Windows 32", False)
            lbScriptPlatforms.Items.Add("Windows 64", False)
            lbScriptPlatforms.Items.Add("Linux 32", False)
            lbScriptPlatforms.Items.Add("Linux 64", False)
            lbScriptPlatforms.Items.Add("OS X", False)
            lbScriptPlatforms.Items.Add("Solaris", False)
            lbScriptPlatforms.Items.Add("AIX", False)

        Else
            btnCreateEdit.Text = "Edit"
            EditScriptPackage = Main.RestClient.Functions.ScriptPackages.GetScriptPackage(ScriptID).Data

            EditScriptID = ScriptID
            txtScriptName.Text = EditScriptPackage.name
            txtScriptCommands.Text = EditScriptPackage.command
            txtScriptDelimiter.Text = EditScriptPackage.resultDelimiter
            txtScriptPassword.Text = EditScriptPackage.impersonationPassword
            txtScriptUsername.Text = EditScriptPackage.impersonationUser
            txtScriptTags.Text = EditScriptPackage.tags
            nmbScriptTimeout.Value = EditScriptPackage.timeoutSeconds
            If Not EditScriptPackage.resultColumns Is Nothing Then
                For Each item In EditScriptPackage.resultColumns
                    lbScriptFields.Items.Add(item)
                Next
            End If
            If Not EditScriptPackage.scriptPackageFiles Is Nothing Then
                For Each item In EditScriptPackage.scriptPackageFiles
                    lbScriptFiles.Items.Add(item.fileName)
                Next
            End If
            
            lbScriptPlatforms.Items.Add("Windows 32", EditScriptPackage.platforms.windows32)
            lbScriptPlatforms.Items.Add("Windows 64", EditScriptPackage.platforms.windows64)
            lbScriptPlatforms.Items.Add("Linux 32", EditScriptPackage.platforms.linux32)
            lbScriptPlatforms.Items.Add("Linux 64", EditScriptPackage.platforms.linux64)
            lbScriptPlatforms.Items.Add("OS X", EditScriptPackage.platforms.osx)
            lbScriptPlatforms.Items.Add("Solaris", EditScriptPackage.platforms.solaris)
            lbScriptPlatforms.Items.Add("AIX", EditScriptPackage.platforms.aix)

        End If

    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
        Close()
    End Sub

    Private Sub CreateEditScript_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason <> CloseReason.WindowsShutDown Or e.CloseReason <> CloseReason.ApplicationExitCall Then
            If bgwCreateScript.IsBusy Then
                e.Cancel = True
            End If
        End If

    End Sub

   

    Private Sub bgwEditScript_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgwEditScript.RunWorkerCompleted
        progressBar.MarqueeAnimationSpeed = 0
        If e.Result = "Success" Then
            Me.Close()
        Else
            progressBar.Style = ProgressBarStyle.Blocks
            lblStatus.Visible = False
            tableScript.Enabled = True

        End If
    End Sub
    Private Sub bgwCreateProject_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgwCreateScript.RunWorkerCompleted
        progressBar.MarqueeAnimationSpeed = 0
        If e.Result = "Success" Then
            Me.Close()
        Else
            progressBar.Style = ProgressBarStyle.Blocks
            lblStatus.Visible = False
            tableScript.Enabled = True
        End If
    End Sub

    Private Sub btnCreateEdit_Click(sender As Object, e As EventArgs) Handles btnCreateEdit.Click
        Select btnCreateEdit.Text
            Case "Create"
                lblStatus.Text = "Creating Script...."
                lblStatus.Visible = True
                progressBar.MarqueeAnimationSpeed = 20
                progressBar.Style = ProgressBarStyle.Marquee
                tableScript.Enabled = False
                btnCreateEdit.Enabled = False
                bgwCreateScript.RunWorkerAsync()

            Case "Edit"
                lblStatus.Text = "Editing Script...."
                lblStatus.Visible = True
                progressBar.MarqueeAnimationSpeed = 20
                progressBar.Style = ProgressBarStyle.Marquee
                tableScript.Enabled = False
                btnCreateEdit.Enabled = False
                bgwEditScript.RunWorkerAsync()

        End Select
    End Sub


    Private Sub btnScriptFileBrowse_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub RemoveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveToolStripMenuItem.Click
        Dim removeitem As String = ""
        For Each item In NewScriptFiles
            If IO.Path.GetFileName(item) = lbScriptFiles.SelectedItem Then
                removeitem = item
            End If
        Next
        NewScriptFiles.Remove(removeitem)
        lbScriptFiles.Items.Remove(lbScriptFiles.SelectedItem)

    End Sub

    Private Sub lbScriptFiles_MouseDown(sender As Object, e As MouseEventArgs) Handles lbScriptFiles.MouseDown, lbScriptFiles.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            If lbScriptFiles.Items.Count > 0 Then
                lbScriptFiles.SelectedIndex = lbScriptFiles.IndexFromPoint(e.X, e.Y)
                cms_Files.Show(MousePosition)
            End If
        End If

    End Sub

    Private Sub bgwCreateScript_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgwCreateScript.DoWork
        Dim newscript As New FEPRestClient.Models.Scripts.ScriptPackageDetail
        newscript.name = txtScriptName.Text
        newscript.command = txtScriptCommands.Text
        newscript.timeoutSeconds = nmbScriptTimeout.Value
        newscript.impersonationUser = txtScriptUsername.Text
        newscript.impersonationPassword = txtScriptPassword.Text
        newscript.resultDelimiter = txtScriptDelimiter.Text
        newscript.tags = txtScriptTags.Text

        For i = 0 To lbScriptPlatforms.CheckedItems.Count - 1
            Select Case lbScriptPlatforms.CheckedItems(i)
                Case "Windows 32"
                    newscript.platforms.windows32 = True
                Case "Windows 64"
                    newscript.platforms.windows64 = True
                Case "Linux 32"
                    newscript.platforms.linux32 = True
                Case "Linux 64"
                    newscript.platforms.linux64 = True
                Case "OS X"
                    newscript.platforms.osx = True
                Case "Solaris"
                    newscript.platforms.solaris = True
                Case "AIX"
                    newscript.platforms.aix = True
            End Select
        Next

        For Each item In lbScriptFields.Items
            newscript.resultColumns.Add(item)
        Next

        For Each item In NewScriptFiles
            Dim newscriptfileadd As New FEPRestClient.Models.Scripts.ScriptPackageFileDetail
            newscriptfileadd.fileName = IO.Path.GetFileName(item)
            newscript.scriptPackageFiles.Add(newscriptfileadd)
        Next

        Dim x = Main.RestClient.Functions.ScriptPackages.CreateUpdate(newscript)
        If x.Success = True Then
            If NewScriptFiles.Count > 0 Then
                Dim y = Main.RestClient.Functions.ScriptPackages.PackageFileUpload(NewScriptFiles, x.Data)
            End If
            Dim z = Main.RestClient.Functions.ScriptPackages.PackageChangeComplete(x.Data, False)
            If z.Success = True Then
                MsgBox("Complete")
                e.Result = "Success"
            Else
                MsgBox(z.Error.Message)
                e.Result = "Fail"
            End If
        End If
    End Sub

    Private Sub bgwEditScript_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgwEditScript.DoWork
        Dim newscript As New FEPRestClient.Models.Scripts.ScriptPackageDetail
        newscript.id = EditScriptPackage.id
        newscript.name = txtScriptName.Text
        newscript.command = txtScriptCommands.Text
        newscript.timeoutSeconds = nmbScriptTimeout.Value
        newscript.impersonationUser = txtScriptUsername.Text
        newscript.impersonationPassword = txtScriptPassword.Text
        newscript.resultDelimiter = txtScriptDelimiter.Text
        newscript.tags = txtScriptTags.Text

        For i = 0 To lbScriptPlatforms.CheckedItems.Count - 1
            Select Case lbScriptPlatforms.CheckedItems(i)
                Case "Windows 32"
                    newscript.platforms.windows32 = True
                Case "Windows 64"
                    newscript.platforms.windows64 = True
                Case "Linux 32"
                    newscript.platforms.linux32 = True
                Case "Linux 64"
                    newscript.platforms.linux64 = True
                Case "OS X"
                    newscript.platforms.osx = True
                Case "Solaris"
                    newscript.platforms.solaris = True
                Case "AIX"
                    newscript.platforms.aix = True
            End Select
        Next

        For Each item In lbScriptFields.Items
            newscript.resultColumns.Add(item)
        Next

        Dim RemovedFiles As New List(Of String)
        For Each file As FEPRestClient.Models.Scripts.ScriptPackageFileDetail In EditScriptPackage.scriptPackageFiles
            If Not lbScriptFiles.Items.Contains(file.fileName) Then
                RemovedFiles.Add(file.fileID)
            Else
                newscript.scriptPackageFiles.Add(file)
            End If
        Next

        For Each item In NewScriptFiles
            Dim newscriptfileadd As New FEPRestClient.Models.Scripts.ScriptPackageFileDetail
            newscriptfileadd.fileName = IO.Path.GetFileName(item)
            newscript.scriptPackageFiles.Add(newscriptfileadd)
        Next

        Dim x = Main.RestClient.Functions.ScriptPackages.CreateUpdate(newscript)
        If x.Success = True Then
            If NewScriptFiles.Count > 0 Then
                Dim y = Main.RestClient.Functions.ScriptPackages.PackageFileUpload(NewScriptFiles, x.Data)
            End If
            Dim z = Main.RestClient.Functions.ScriptPackages.PackageChangeComplete(x.Data, True, RemovedFiles)
            If z.Success = True Then
                MsgBox("Complete")
                e.Result = "Success"
            Else
                MsgBox(z.Error.Message)
                e.Result = "Fail"
            End If
        End If
    End Sub


 
    Private Sub AddStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AddStripMenuItem1.Click
        Dim ofd = ofdScriptFiles.ShowDialog()
        If ofd = Windows.Forms.DialogResult.OK Then
            For Each file In ofdScriptFiles.FileNames
                NewScriptFiles.Add(file)
                lbScriptFiles.Items.Add(IO.Path.GetFileName(file))
            Next
            If txtScriptCommands.Text = "" Then
                txtScriptCommands.Text = lbScriptFiles.Items(0)
            End If
        End If
    End Sub

    Private Sub AddFieldToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AddFieldToolStripMenuItem1.Click
        Dim newfield = InputBox("Field Name:", "New Field")
        If Not newfield = vbNullString Then
            lbScriptFields.Items.Add(newfield)
        End If
    End Sub

    Private Sub RemoveFieldToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles RemoveFieldToolStripMenuItem2.Click
        If lbScriptFields.SelectedItems.Count > 0 Then
            lbScriptFields.Items.Remove(lbScriptFields.SelectedItem)
        End If

    End Sub

    Private Sub lbScriptFields_MouseDown(sender As Object, e As MouseEventArgs) Handles lbScriptFields.MouseDown, lbScriptFields.MouseClick
        lbScriptFields.DoDragDrop(lbScriptFields.Text, DragDropEffects.All)
        If e.Button = Windows.Forms.MouseButtons.Right Then
            If lbScriptFields.Items.Count > 0 Then
                lbScriptFields.SelectedIndex = lbScriptFields.IndexFromPoint(e.X, e.Y)
                cms_Fields.Show(MousePosition)
            End If
        End If
    End Sub

    Private Sub lbScriptFields_DragDrop(sender As Object, e As DragEventArgs) Handles lbScriptFields.DragDrop
        lbScriptFields.Items.Insert(lbScriptFields.IndexFromPoint(lbScriptFields.PointToClient(New Point(e.X, e.Y))), e.Data.GetData(DataFormats.Text))
        lbScriptFields.Items.RemoveAt(lbScriptFields.SelectedIndex)
    End Sub

    Private Sub lbScriptFields_DragOver(sender As Object, e As DragEventArgs) Handles lbScriptFields.DragOver
        e.Effect = DragDropEffects.Move
    End Sub
End Class