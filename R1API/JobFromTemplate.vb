Public Class JobFromTemplate

    Private Sub btnJobFromTemplateCancel_Click(sender As Object, e As EventArgs) Handles btnJobFromTemplateCancel.Click
        Me.Close()
    End Sub

    Private Sub btnJobFromTemplateNext_Click(sender As Object, e As EventArgs) Handles btnJobFromTemplateNext.Click
        Select Case tabControlJobFromTemplate.SelectedTab.Name
            Case tabProject.Name
                tabControlJobFromTemplate.SelectedTab = tabTargets
                lblJobFromTemplateMenuText.Text = "Select the target endpoints"
            Case tabTargets.Name
                lblJobFromTemplateMenuText.Text = "Choose scheduling options"
                btnJobFromTemplateNext.Text = "Start"
                tabControlJobFromTemplate.SelectedTab = tabSchedule
            Case tabSchedule.Name
        End Select
    End Sub

    Private Sub btnJobFromTemplatePrevious_Click(sender As Object, e As EventArgs) Handles btnJobFromTemplatePrevious.Click
        Select Case tabControlJobFromTemplate.SelectedTab.Name
            Case tabProject.Name
                
            Case tabTargets.Name
                tabControlJobFromTemplate.SelectedTab = tabProject
                lblJobFromTemplateMenuText.Text = "Pick the project to store the data"

            Case tabSchedule.Name
                tabControlJobFromTemplate.SelectedTab = tabTargets
                lblJobFromTemplateMenuText.Text = "Select the target endpoints"
                btnJobFromTemplateNext.Text = "Next"
        End Select
    End Sub

    Private Sub splitProjects_Panel1_Paint(sender As Object, e As PaintEventArgs) Handles splitProjects.Panel1.Paint

    End Sub

    Private Sub btnNewProject_Click(sender As Object, e As EventArgs) Handles btnNewProject.Click
        Dim projectcreate As New CreateEditProject("Create Project", True)
        projectcreate.ShowDialog()
        JobRunner_RestFunctions.GetProjectList("")
    End Sub

    Private Sub txtSearchProject_TextChanged(sender As Object, e As EventArgs) Handles txtSearchProject.TextChanged

    End Sub
    Private Sub txtSearchProject_Enter(sender As Object, e As EventArgs) Handles txtSearchProject.Enter
        If txtSearchProject.Text = "Search" Then
            txtSearchProject.Text = ""
        End If
    End Sub

    Private Sub txtSearchProject_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearchProject.KeyDown

        If e.KeyCode = Keys.Enter Then
            JobRunner_RestFunctions.GetProjectList(txtSearchProject.Text)
        End If
    End Sub



    Private Sub txtSearchProject_Leave(sender As Object, e As EventArgs) Handles txtSearchProject.Leave
        If txtSearchProject.Text = "" Then
            txtSearchProject.Text = "Search"
        End If
    End Sub

    Private Sub splitJobFromTemplate_SplitterMoved(sender As Object, e As SplitterEventArgs) Handles splitJobFromTemplate.SplitterMoved

    End Sub
End Class