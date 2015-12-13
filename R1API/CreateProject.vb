Public Class CreateProject

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Create_Click(sender As Object, e As EventArgs) Handles btnCreate.Click

        '   DialogResult = Windows.Forms.DialogResult.OK
        progressCreateProject.MarqueeAnimationSpeed = 20
        progressCreateProject.Style = ProgressBarStyle.Marquee
        panelProjectCreateLoading.BringToFront()
        Me.Refresh()
        Dim r1rest As New R1SimpleRestClient.R1SimpleRestClient
        If Main.auth.Data.Message <> "Authenticated" Then
            Main.auth = r1rest.AuthenticateWithR1(Main.txtServer.Text, Main.txtApiUser.Text, ToInsecureString(Main.apipass))
        End If
        Dim api As New List(Of Object)
        api.Add(Main.txtServer.Text)
        api.Add(Main.auth)

        bgwCreateProject.RunWorkerAsync(api)



    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        DialogResult = Windows.Forms.DialogResult.Cancel

        Close()
    End Sub

    Private Sub FlowLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles flowCreateProject.Paint

    End Sub

    Private Sub bgwCreateProject_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgwCreateProject.DoWork
        JobRunner_RestFunctions.CreateProject(txtNewProjectName.Text, txtNewProjectDescription.Text, chkEnableThreatBridge.Checked, e.Argument(0), e.Argument(1))
    End Sub

    Private Sub bgwCreateProject_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgwCreateProject.RunWorkerCompleted
        progressCreateProject.MarqueeAnimationSpeed = 0
        flowCreateProject.BringToFront()

        Me.Close()
    End Sub

    Private Sub CreateProject_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason <> CloseReason.WindowsShutDown Or e.CloseReason <> CloseReason.ApplicationExitCall Then
            If bgwCreateProject.IsBusy Then
                e.Cancel = True
            End If
        End If

    End Sub

    Private Sub CreateProject_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNewProjectDescription.Text = ""
        txtNewProjectName.Text = ""
        chkEnableThreatBridge.Checked = False
    End Sub
End Class