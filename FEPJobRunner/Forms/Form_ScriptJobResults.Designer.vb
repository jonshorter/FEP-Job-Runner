<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_ScriptJobResults
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_ScriptJobResults))
        Me.tableResults = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lvScriptJobResultsFacet = New System.Windows.Forms.ListView()
        Me.dgvScriptJobResults = New System.Windows.Forms.DataGridView()
        Me.cms_Output = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SaveToCSVToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.sfd_CSV = New System.Windows.Forms.SaveFileDialog()
        Me.tableResults.SuspendLayout()
        CType(Me.dgvScriptJobResults, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cms_Output.SuspendLayout()
        Me.SuspendLayout()
        '
        'tableResults
        '
        Me.tableResults.ColumnCount = 2
        Me.tableResults.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tableResults.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tableResults.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tableResults.Controls.Add(Me.lvScriptJobResultsFacet, 1, 0)
        Me.tableResults.Controls.Add(Me.Label1, 0, 0)
        Me.tableResults.Controls.Add(Me.dgvScriptJobResults, 0, 1)
        Me.tableResults.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tableResults.Location = New System.Drawing.Point(0, 0)
        Me.tableResults.Name = "tableResults"
        Me.tableResults.RowCount = 2
        Me.tableResults.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.738717!))
        Me.tableResults.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.26128!))
        Me.tableResults.Size = New System.Drawing.Size(829, 428)
        Me.tableResults.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Filters:"
        '
        'lvScriptJobResultsFacet
        '
        Me.lvScriptJobResultsFacet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvScriptJobResultsFacet.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvScriptJobResultsFacet.GridLines = True
        Me.lvScriptJobResultsFacet.Location = New System.Drawing.Point(59, 3)
        Me.lvScriptJobResultsFacet.MinimumSize = New System.Drawing.Size(0, 35)
        Me.lvScriptJobResultsFacet.MultiSelect = False
        Me.lvScriptJobResultsFacet.Name = "lvScriptJobResultsFacet"
        Me.lvScriptJobResultsFacet.Size = New System.Drawing.Size(773, 35)
        Me.lvScriptJobResultsFacet.TabIndex = 7
        Me.lvScriptJobResultsFacet.UseCompatibleStateImageBehavior = False
        Me.lvScriptJobResultsFacet.View = System.Windows.Forms.View.List
        '
        'dgvScriptJobResults
        '
        Me.dgvScriptJobResults.AllowUserToAddRows = False
        Me.dgvScriptJobResults.AllowUserToDeleteRows = False
        Me.dgvScriptJobResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvScriptJobResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tableResults.SetColumnSpan(Me.dgvScriptJobResults, 2)
        Me.dgvScriptJobResults.ContextMenuStrip = Me.cms_Output
        Me.dgvScriptJobResults.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvScriptJobResults.Location = New System.Drawing.Point(3, 44)
        Me.dgvScriptJobResults.Name = "dgvScriptJobResults"
        Me.dgvScriptJobResults.ReadOnly = True
        Me.dgvScriptJobResults.RowHeadersVisible = False
        Me.dgvScriptJobResults.RowTemplate.Height = 24
        Me.dgvScriptJobResults.Size = New System.Drawing.Size(829, 381)
        Me.dgvScriptJobResults.TabIndex = 8
        '
        'cms_Output
        '
        Me.cms_Output.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cms_Output.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToCSVToolStripMenuItem})
        Me.cms_Output.Name = "cms_Output"
        Me.cms_Output.Size = New System.Drawing.Size(158, 28)
        '
        'SaveToCSVToolStripMenuItem
        '
        Me.SaveToCSVToolStripMenuItem.Name = "SaveToCSVToolStripMenuItem"
        Me.SaveToCSVToolStripMenuItem.Size = New System.Drawing.Size(157, 24)
        Me.SaveToCSVToolStripMenuItem.Text = "Save to CSV"
        '
        'sfd_CSV
        '
        Me.sfd_CSV.Filter = "*.csv | CSV"
        '
        'Form_ScriptJobResults
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(829, 428)
        Me.Controls.Add(Me.tableResults)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form_ScriptJobResults"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Script Job Results"
        Me.tableResults.ResumeLayout(False)
        Me.tableResults.PerformLayout()
        CType(Me.dgvScriptJobResults, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cms_Output.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tableResults As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lvScriptJobResultsFacet As System.Windows.Forms.ListView
    Friend WithEvents dgvScriptJobResults As System.Windows.Forms.DataGridView
    Friend WithEvents cms_Output As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents SaveToCSVToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents sfd_CSV As System.Windows.Forms.SaveFileDialog
End Class
