Imports System.Reflection

Public Class Form_CreateEditScript

    Private Property EditScriptID As String
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
            Dim script = Main.RestClient.Functions.ScriptPackages.GetScriptPackage(ScriptID)

            EditScriptID = ScriptID
            txtScriptName.Text = script.Data.name
            txtScriptCommands.Text = script.Data.command
            txtScriptDelimiter.Text = script.Data.resultDelimiter
            txtScriptPassword.Text = script.Data.impersonationPassword
            txtScriptUsername.Text = script.Data.impersonationUser
            txtScriptTags.Text = script.Data.tags
            nmbScriptTimeout.Value = script.Data.timeoutSeconds
            For Each item In script.Data.resultColumns
                lbScriptFields.Items.Add(item)
            Next
            For Each item In script.Data.scriptPackageFiles
                lbScriptFiles.Items.Add(item.fileName)
            Next
            lbScriptPlatforms.Items.Add("Windows 32", script.Data.platforms.windows32)
            lbScriptPlatforms.Items.Add("Windows 64", script.Data.platforms.windows64)
            lbScriptPlatforms.Items.Add("Linux 32", script.Data.platforms.linux32)
            lbScriptPlatforms.Items.Add("Linux 64", script.Data.platforms.linux64)
            lbScriptPlatforms.Items.Add("OS X", script.Data.platforms.osx)
            lbScriptPlatforms.Items.Add("Solaris", script.Data.platforms.solaris)
            lbScriptPlatforms.Items.Add("AIX", script.Data.platforms.aix)

        End If

    End Sub


    Private Sub Create_Click(sender As Object, e As EventArgs)
        'Select Case btnCreateEdit.Text
        '    Case "Create"
        '        lblWaitText.Text = "Creating Script...."
        '        progressCreateProject.MarqueeAnimationSpeed = 20
        '        progressCreateProject.Style = ProgressBarStyle.Marquee
        '        panelProjectCreateLoading.BringToFront()
        '        Me.Refresh()
        '        bgwCreateProject.RunWorkerAsync()
        '    Case "Edit"
        '        lblWaitText.Text = "Editing Script...."
        '        progressCreateProject.MarqueeAnimationSpeed = 20
        '        progressCreateProject.Style = ProgressBarStyle.Marquee
        '        panelProjectCreateLoading.BringToFront()
        '       Me.Refresh()
        '        bgwEditProject.RunWorkerAsync()
        'End Select



    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
        Close()
    End Sub

 

    '   Private Sub bgwCreateProject_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgwCreateProject.DoWork, bgwCreateScript.DoWork
    'JobRunner_RestFunctions.CreateProject(txtNewProjectName.Text, txtNewProjectDescription.Text, chkEnableThreatBridge.Checked)
    'End Sub

  

    Private Sub CreateProject_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason <> CloseReason.WindowsShutDown Or e.CloseReason <> CloseReason.ApplicationExitCall Then
            If bgwCreateScript.IsBusy Then
                e.Cancel = True
            End If
        End If

    End Sub


    '  Private Sub bgwEditProject_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgwEditProject.DoWork, bgwEditScript.DoWork
    '    JobRunner_RestFunctions.EditProject(EditProjectID, txtNewProjectName.Text, txtNewProjectDescription.Text, chkEnableThreatBridge.Checked)

    'End Sub

    Private Sub bgwEditScript_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgwEditScript.RunWorkerCompleted
        progressBar.MarqueeAnimationSpeed = 0
        Me.Close()
    End Sub
    Private Sub bgwCreateProject_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgwCreateScript.RunWorkerCompleted
        progressBar.MarqueeAnimationSpeed = 0
        Me.Close()
    End Sub
End Class