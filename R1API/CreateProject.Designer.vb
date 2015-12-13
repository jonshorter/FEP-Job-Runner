<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateProject
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
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.flowCreateProject = New System.Windows.Forms.FlowLayoutPanel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtNewProjectName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNewProjectDescription = New System.Windows.Forms.TextBox()
        Me.chkEnableThreatBridge = New System.Windows.Forms.CheckBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.panelProjectCreateLoading = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.progressCreateProject = New System.Windows.Forms.ProgressBar()
        Me.bgwCreateProject = New System.ComponentModel.BackgroundWorker()
        Me.flowCreateProject.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.panelProjectCreateLoading.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(9, 7)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(103, 38)
        Me.btnCancel.TabIndex = 0
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnCreate
        '
        Me.btnCreate.Location = New System.Drawing.Point(239, 7)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(103, 38)
        Me.btnCreate.TabIndex = 1
        Me.btnCreate.Text = "Create"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.MaximumSize = New System.Drawing.Size(500, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Project Name: "
        '
        'flowCreateProject
        '
        Me.flowCreateProject.AutoSize = True
        Me.flowCreateProject.Controls.Add(Me.TableLayoutPanel1)
        Me.flowCreateProject.Controls.Add(Me.chkEnableThreatBridge)
        Me.flowCreateProject.Controls.Add(Me.Panel1)
        Me.flowCreateProject.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flowCreateProject.Location = New System.Drawing.Point(0, 0)
        Me.flowCreateProject.MaximumSize = New System.Drawing.Size(500, 0)
        Me.flowCreateProject.Name = "flowCreateProject"
        Me.flowCreateProject.Size = New System.Drawing.Size(357, 200)
        Me.flowCreateProject.TabIndex = 5
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.49351!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.50649!))
        Me.TableLayoutPanel1.Controls.Add(Me.txtNewProjectName, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtNewProjectDescription, 1, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(350, 112)
        Me.TableLayoutPanel1.TabIndex = 6
        '
        'txtNewProjectName
        '
        Me.txtNewProjectName.Location = New System.Drawing.Point(113, 3)
        Me.txtNewProjectName.Name = "txtNewProjectName"
        Me.txtNewProjectName.Size = New System.Drawing.Size(234, 22)
        Me.txtNewProjectName.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Description: "
        '
        'txtNewProjectDescription
        '
        Me.txtNewProjectDescription.Location = New System.Drawing.Point(113, 35)
        Me.txtNewProjectDescription.Multiline = True
        Me.txtNewProjectDescription.Name = "txtNewProjectDescription"
        Me.txtNewProjectDescription.Size = New System.Drawing.Size(234, 69)
        Me.txtNewProjectDescription.TabIndex = 6
        '
        'chkEnableThreatBridge
        '
        Me.chkEnableThreatBridge.AutoSize = True
        Me.chkEnableThreatBridge.Location = New System.Drawing.Point(3, 121)
        Me.chkEnableThreatBridge.Name = "chkEnableThreatBridge"
        Me.chkEnableThreatBridge.Size = New System.Drawing.Size(213, 21)
        Me.chkEnableThreatBridge.TabIndex = 7
        Me.chkEnableThreatBridge.Text = "Enable ThreatBridge Alerting"
        Me.chkEnableThreatBridge.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Controls.Add(Me.btnCreate)
        Me.Panel1.Location = New System.Drawing.Point(3, 148)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(350, 49)
        Me.Panel1.TabIndex = 3
        '
        'panelProjectCreateLoading
        '
        Me.panelProjectCreateLoading.Controls.Add(Me.Label3)
        Me.panelProjectCreateLoading.Controls.Add(Me.progressCreateProject)
        Me.panelProjectCreateLoading.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelProjectCreateLoading.Location = New System.Drawing.Point(0, 0)
        Me.panelProjectCreateLoading.Name = "panelProjectCreateLoading"
        Me.panelProjectCreateLoading.Size = New System.Drawing.Size(357, 200)
        Me.panelProjectCreateLoading.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(50, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(259, 32)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Creating Project....."
        '
        'progressCreateProject
        '
        Me.progressCreateProject.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.progressCreateProject.Location = New System.Drawing.Point(0, 177)
        Me.progressCreateProject.Name = "progressCreateProject"
        Me.progressCreateProject.Size = New System.Drawing.Size(357, 23)
        Me.progressCreateProject.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.progressCreateProject.TabIndex = 0
        '
        'bgwCreateProject
        '
        '
        'CreateProject
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(357, 200)
        Me.Controls.Add(Me.flowCreateProject)
        Me.Controls.Add(Me.panelProjectCreateLoading)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CreateProject"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Create Project"
        Me.flowCreateProject.ResumeLayout(False)
        Me.flowCreateProject.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.panelProjectCreateLoading.ResumeLayout(False)
        Me.panelProjectCreateLoading.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnCreate As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents flowCreateProject As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents txtNewProjectName As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents chkEnableThreatBridge As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNewProjectDescription As System.Windows.Forms.TextBox
    Friend WithEvents panelProjectCreateLoading As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents progressCreateProject As System.Windows.Forms.ProgressBar
    Friend WithEvents bgwCreateProject As System.ComponentModel.BackgroundWorker
End Class
