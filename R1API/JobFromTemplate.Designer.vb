<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class JobFromTemplate
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.splitJobFromTemplate = New System.Windows.Forms.SplitContainer()
        Me.lblJobFromTemplateMenuText = New System.Windows.Forms.Label()
        Me.btnJobFromTemplateNext = New System.Windows.Forms.Button()
        Me.btnJobFromTemplatePrevious = New System.Windows.Forms.Button()
        Me.btnJobFromTemplateCancel = New System.Windows.Forms.Button()
        Me.tabControlJobFromTemplate = New System.Windows.Forms.TabControl()
        Me.tabProject = New System.Windows.Forms.TabPage()
        Me.splitProjects = New System.Windows.Forms.SplitContainer()
        Me.btnNewProject = New System.Windows.Forms.Button()
        Me.txtSearchProject = New System.Windows.Forms.TextBox()
        Me.dgvProjectList = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CreationDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CreatedBy = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastModDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProjectFolderPath = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProjectID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tabTargets = New System.Windows.Forms.TabPage()
        Me.tabSchedule = New System.Windows.Forms.TabPage()
        CType(Me.splitJobFromTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitJobFromTemplate.Panel1.SuspendLayout()
        Me.splitJobFromTemplate.Panel2.SuspendLayout()
        Me.splitJobFromTemplate.SuspendLayout()
        Me.tabControlJobFromTemplate.SuspendLayout()
        Me.tabProject.SuspendLayout()
        CType(Me.splitProjects, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitProjects.Panel1.SuspendLayout()
        Me.splitProjects.Panel2.SuspendLayout()
        Me.splitProjects.SuspendLayout()
        CType(Me.dgvProjectList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'splitJobFromTemplate
        '
        Me.splitJobFromTemplate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitJobFromTemplate.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.splitJobFromTemplate.IsSplitterFixed = True
        Me.splitJobFromTemplate.Location = New System.Drawing.Point(0, 0)
        Me.splitJobFromTemplate.Name = "splitJobFromTemplate"
        Me.splitJobFromTemplate.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'splitJobFromTemplate.Panel1
        '
        Me.splitJobFromTemplate.Panel1.Controls.Add(Me.lblJobFromTemplateMenuText)
        Me.splitJobFromTemplate.Panel1.Controls.Add(Me.btnJobFromTemplateNext)
        Me.splitJobFromTemplate.Panel1.Controls.Add(Me.btnJobFromTemplatePrevious)
        Me.splitJobFromTemplate.Panel1.Controls.Add(Me.btnJobFromTemplateCancel)
        Me.splitJobFromTemplate.Panel1MinSize = 50
        '
        'splitJobFromTemplate.Panel2
        '
        Me.splitJobFromTemplate.Panel2.Controls.Add(Me.tabControlJobFromTemplate)
        Me.splitJobFromTemplate.Size = New System.Drawing.Size(820, 561)
        Me.splitJobFromTemplate.TabIndex = 0
        '
        'lblJobFromTemplateMenuText
        '
        Me.lblJobFromTemplateMenuText.AutoSize = True
        Me.lblJobFromTemplateMenuText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJobFromTemplateMenuText.Location = New System.Drawing.Point(194, 10)
        Me.lblJobFromTemplateMenuText.Name = "lblJobFromTemplateMenuText"
        Me.lblJobFromTemplateMenuText.Size = New System.Drawing.Size(288, 25)
        Me.lblJobFromTemplateMenuText.TabIndex = 3
        Me.lblJobFromTemplateMenuText.Text = "Pick the project to store the data"
        '
        'btnJobFromTemplateNext
        '
        Me.btnJobFromTemplateNext.Location = New System.Drawing.Point(677, 12)
        Me.btnJobFromTemplateNext.Name = "btnJobFromTemplateNext"
        Me.btnJobFromTemplateNext.Size = New System.Drawing.Size(75, 23)
        Me.btnJobFromTemplateNext.TabIndex = 2
        Me.btnJobFromTemplateNext.Text = "Next"
        Me.btnJobFromTemplateNext.UseVisualStyleBackColor = True
        '
        'btnJobFromTemplatePrevious
        '
        Me.btnJobFromTemplatePrevious.Location = New System.Drawing.Point(103, 12)
        Me.btnJobFromTemplatePrevious.Name = "btnJobFromTemplatePrevious"
        Me.btnJobFromTemplatePrevious.Size = New System.Drawing.Size(75, 23)
        Me.btnJobFromTemplatePrevious.TabIndex = 1
        Me.btnJobFromTemplatePrevious.Text = "Previous"
        Me.btnJobFromTemplatePrevious.UseVisualStyleBackColor = True
        '
        'btnJobFromTemplateCancel
        '
        Me.btnJobFromTemplateCancel.Location = New System.Drawing.Point(12, 12)
        Me.btnJobFromTemplateCancel.Name = "btnJobFromTemplateCancel"
        Me.btnJobFromTemplateCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnJobFromTemplateCancel.TabIndex = 0
        Me.btnJobFromTemplateCancel.Text = "Cancel"
        Me.btnJobFromTemplateCancel.UseVisualStyleBackColor = True
        '
        'tabControlJobFromTemplate
        '
        Me.tabControlJobFromTemplate.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.tabControlJobFromTemplate.Controls.Add(Me.tabProject)
        Me.tabControlJobFromTemplate.Controls.Add(Me.tabTargets)
        Me.tabControlJobFromTemplate.Controls.Add(Me.tabSchedule)
        Me.tabControlJobFromTemplate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabControlJobFromTemplate.Location = New System.Drawing.Point(0, 0)
        Me.tabControlJobFromTemplate.Multiline = True
        Me.tabControlJobFromTemplate.Name = "tabControlJobFromTemplate"
        Me.tabControlJobFromTemplate.SelectedIndex = 0
        Me.tabControlJobFromTemplate.Size = New System.Drawing.Size(820, 507)
        Me.tabControlJobFromTemplate.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight
        Me.tabControlJobFromTemplate.TabIndex = 0
        '
        'tabProject
        '
        Me.tabProject.Controls.Add(Me.splitProjects)
        Me.tabProject.Location = New System.Drawing.Point(4, 28)
        Me.tabProject.Name = "tabProject"
        Me.tabProject.Padding = New System.Windows.Forms.Padding(3)
        Me.tabProject.Size = New System.Drawing.Size(812, 475)
        Me.tabProject.TabIndex = 0
        Me.tabProject.Text = "Project"
        Me.tabProject.UseVisualStyleBackColor = True
        '
        'splitProjects
        '
        Me.splitProjects.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitProjects.IsSplitterFixed = True
        Me.splitProjects.Location = New System.Drawing.Point(3, 3)
        Me.splitProjects.Name = "splitProjects"
        Me.splitProjects.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'splitProjects.Panel1
        '
        Me.splitProjects.Panel1.Controls.Add(Me.btnNewProject)
        Me.splitProjects.Panel1.Controls.Add(Me.txtSearchProject)
        Me.splitProjects.Panel1MinSize = 40
        '
        'splitProjects.Panel2
        '
        Me.splitProjects.Panel2.Controls.Add(Me.dgvProjectList)
        Me.splitProjects.Size = New System.Drawing.Size(806, 469)
        Me.splitProjects.SplitterDistance = 40
        Me.splitProjects.TabIndex = 1
        '
        'btnNewProject
        '
        Me.btnNewProject.AutoSize = True
        Me.btnNewProject.Location = New System.Drawing.Point(9, 6)
        Me.btnNewProject.Name = "btnNewProject"
        Me.btnNewProject.Size = New System.Drawing.Size(50, 27)
        Me.btnNewProject.TabIndex = 2
        Me.btnNewProject.Text = "New"
        Me.btnNewProject.UseVisualStyleBackColor = True
        '
        'txtSearchProject
        '
        Me.txtSearchProject.AcceptsReturn = True
        Me.txtSearchProject.Location = New System.Drawing.Point(65, 8)
        Me.txtSearchProject.Name = "txtSearchProject"
        Me.txtSearchProject.Size = New System.Drawing.Size(209, 22)
        Me.txtSearchProject.TabIndex = 1
        Me.txtSearchProject.Text = "Search"
        '
        'dgvProjectList
        '
        Me.dgvProjectList.AllowUserToAddRows = False
        Me.dgvProjectList.AllowUserToDeleteRows = False
        Me.dgvProjectList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvProjectList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProjectList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.CreationDate, Me.CreatedBy, Me.LastModDate, Me.ProjectFolderPath, Me.ProjectID})
        Me.dgvProjectList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvProjectList.Location = New System.Drawing.Point(0, 0)
        Me.dgvProjectList.MultiSelect = False
        Me.dgvProjectList.Name = "dgvProjectList"
        Me.dgvProjectList.ReadOnly = True
        Me.dgvProjectList.RowHeadersVisible = False
        Me.dgvProjectList.RowTemplate.Height = 24
        Me.dgvProjectList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProjectList.Size = New System.Drawing.Size(806, 425)
        Me.dgvProjectList.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Project Name"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'CreationDate
        '
        Me.CreationDate.HeaderText = "Creation Date"
        Me.CreationDate.Name = "CreationDate"
        Me.CreationDate.ReadOnly = True
        '
        'CreatedBy
        '
        Me.CreatedBy.HeaderText = "Created By"
        Me.CreatedBy.Name = "CreatedBy"
        Me.CreatedBy.ReadOnly = True
        '
        'LastModDate
        '
        Me.LastModDate.HeaderText = "Last Modified Date"
        Me.LastModDate.Name = "LastModDate"
        Me.LastModDate.ReadOnly = True
        '
        'ProjectFolderPath
        '
        Me.ProjectFolderPath.HeaderText = "Project Folder Path"
        Me.ProjectFolderPath.Name = "ProjectFolderPath"
        Me.ProjectFolderPath.ReadOnly = True
        '
        'ProjectID
        '
        Me.ProjectID.HeaderText = "Project ID"
        Me.ProjectID.Name = "ProjectID"
        Me.ProjectID.ReadOnly = True
        Me.ProjectID.Visible = False
        '
        'tabTargets
        '
        Me.tabTargets.Location = New System.Drawing.Point(4, 28)
        Me.tabTargets.Name = "tabTargets"
        Me.tabTargets.Padding = New System.Windows.Forms.Padding(3)
        Me.tabTargets.Size = New System.Drawing.Size(812, 475)
        Me.tabTargets.TabIndex = 1
        Me.tabTargets.Text = "Targets"
        Me.tabTargets.UseVisualStyleBackColor = True
        '
        'tabSchedule
        '
        Me.tabSchedule.Location = New System.Drawing.Point(4, 28)
        Me.tabSchedule.Name = "tabSchedule"
        Me.tabSchedule.Size = New System.Drawing.Size(812, 475)
        Me.tabSchedule.TabIndex = 2
        Me.tabSchedule.Text = "Schedule"
        Me.tabSchedule.UseVisualStyleBackColor = True
        '
        'JobFromTemplate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(820, 561)
        Me.Controls.Add(Me.splitJobFromTemplate)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "JobFromTemplate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Job From Template"
        Me.splitJobFromTemplate.Panel1.ResumeLayout(False)
        Me.splitJobFromTemplate.Panel1.PerformLayout()
        Me.splitJobFromTemplate.Panel2.ResumeLayout(False)
        CType(Me.splitJobFromTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitJobFromTemplate.ResumeLayout(False)
        Me.tabControlJobFromTemplate.ResumeLayout(False)
        Me.tabProject.ResumeLayout(False)
        Me.splitProjects.Panel1.ResumeLayout(False)
        Me.splitProjects.Panel1.PerformLayout()
        Me.splitProjects.Panel2.ResumeLayout(False)
        CType(Me.splitProjects, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitProjects.ResumeLayout(False)
        CType(Me.dgvProjectList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents splitJobFromTemplate As System.Windows.Forms.SplitContainer
    Friend WithEvents btnJobFromTemplateCancel As System.Windows.Forms.Button
    Friend WithEvents lblJobFromTemplateMenuText As System.Windows.Forms.Label
    Friend WithEvents btnJobFromTemplateNext As System.Windows.Forms.Button
    Friend WithEvents btnJobFromTemplatePrevious As System.Windows.Forms.Button
    Friend WithEvents tabControlJobFromTemplate As System.Windows.Forms.TabControl
    Friend WithEvents tabProject As System.Windows.Forms.TabPage
    Friend WithEvents tabTargets As System.Windows.Forms.TabPage
    Friend WithEvents tabSchedule As System.Windows.Forms.TabPage
    Friend WithEvents splitProjects As System.Windows.Forms.SplitContainer
    Friend WithEvents btnNewProject As System.Windows.Forms.Button
    Friend WithEvents txtSearchProject As System.Windows.Forms.TextBox
    Friend WithEvents dgvProjectList As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CreationDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CreatedBy As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastModDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProjectFolderPath As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProjectID As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
