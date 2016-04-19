<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_CreateEditScript
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_CreateEditScript))
        Me.bgwCreateScript = New System.ComponentModel.BackgroundWorker()
        Me.bgwEditScript = New System.ComponentModel.BackgroundWorker()
        Me.panelControls = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnCreateEdit = New System.Windows.Forms.Button()
        Me.tableScript = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtScriptName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lbScriptFiles = New System.Windows.Forms.ListBox()
        Me.txtScriptCommands = New System.Windows.Forms.TextBox()
        Me.txtScriptUsername = New System.Windows.Forms.TextBox()
        Me.txtScriptPassword = New System.Windows.Forms.TextBox()
        Me.nmbScriptTimeout = New System.Windows.Forms.NumericUpDown()
        Me.lbScriptFields = New System.Windows.Forms.ListBox()
        Me.txtScriptTags = New System.Windows.Forms.TextBox()
        Me.txtScriptDelimiter = New System.Windows.Forms.TextBox()
        Me.lbScriptPlatforms = New System.Windows.Forms.CheckedListBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.progressBar = New System.Windows.Forms.ProgressBar()
        Me.panelControls.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.tableScript.SuspendLayout()
        CType(Me.nmbScriptTimeout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bgwCreateScript
        '
        '
        'bgwEditScript
        '
        '
        'panelControls
        '
        Me.panelControls.Controls.Add(Me.Panel1)
        Me.panelControls.Controls.Add(Me.tableScript)
        Me.panelControls.Controls.Add(Me.lblStatus)
        Me.panelControls.Controls.Add(Me.progressBar)
        Me.panelControls.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelControls.Location = New System.Drawing.Point(0, 0)
        Me.panelControls.Name = "panelControls"
        Me.panelControls.Size = New System.Drawing.Size(1116, 452)
        Me.panelControls.TabIndex = 9
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Controls.Add(Me.btnCreateEdit)
        Me.Panel1.Location = New System.Drawing.Point(677, 374)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(427, 49)
        Me.Panel1.TabIndex = 3
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
        'btnCreateEdit
        '
        Me.btnCreateEdit.Location = New System.Drawing.Point(318, 7)
        Me.btnCreateEdit.Name = "btnCreateEdit"
        Me.btnCreateEdit.Size = New System.Drawing.Size(103, 38)
        Me.btnCreateEdit.TabIndex = 1
        Me.btnCreateEdit.Text = "Create"
        Me.btnCreateEdit.UseVisualStyleBackColor = True
        '
        'tableScript
        '
        Me.tableScript.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tableScript.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tableScript.ColumnCount = 4
        Me.tableScript.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tableScript.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tableScript.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tableScript.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tableScript.Controls.Add(Me.Label1, 0, 0)
        Me.tableScript.Controls.Add(Me.txtScriptName, 1, 0)
        Me.tableScript.Controls.Add(Me.Label2, 0, 1)
        Me.tableScript.Controls.Add(Me.Label3, 2, 1)
        Me.tableScript.Controls.Add(Me.Label4, 0, 2)
        Me.tableScript.Controls.Add(Me.Label5, 2, 2)
        Me.tableScript.Controls.Add(Me.Label6, 0, 3)
        Me.tableScript.Controls.Add(Me.Label7, 0, 4)
        Me.tableScript.Controls.Add(Me.Label8, 0, 5)
        Me.tableScript.Controls.Add(Me.Label9, 2, 3)
        Me.tableScript.Controls.Add(Me.Label10, 2, 5)
        Me.tableScript.Controls.Add(Me.lbScriptFiles, 1, 1)
        Me.tableScript.Controls.Add(Me.txtScriptCommands, 1, 2)
        Me.tableScript.Controls.Add(Me.txtScriptUsername, 1, 3)
        Me.tableScript.Controls.Add(Me.txtScriptPassword, 1, 4)
        Me.tableScript.Controls.Add(Me.nmbScriptTimeout, 1, 5)
        Me.tableScript.Controls.Add(Me.lbScriptFields, 3, 2)
        Me.tableScript.Controls.Add(Me.txtScriptTags, 3, 3)
        Me.tableScript.Controls.Add(Me.txtScriptDelimiter, 3, 5)
        Me.tableScript.Controls.Add(Me.lbScriptPlatforms, 3, 1)
        Me.tableScript.Location = New System.Drawing.Point(3, 3)
        Me.tableScript.Name = "tableScript"
        Me.tableScript.RowCount = 6
        Me.tableScript.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableScript.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tableScript.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tableScript.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableScript.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableScript.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableScript.Size = New System.Drawing.Size(1101, 333)
        Me.tableScript.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name"
        '
        'txtScriptName
        '
        Me.txtScriptName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtScriptName.Location = New System.Drawing.Point(137, 3)
        Me.txtScriptName.Name = "txtScriptName"
        Me.txtScriptName.Size = New System.Drawing.Size(421, 22)
        Me.txtScriptName.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Files"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(564, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Platforms"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Commands"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(564, 138)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 17)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Fields"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 248)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 17)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Username"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 276)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 17)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Password"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 304)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(128, 17)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Timeout (Seconds)"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(564, 248)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 17)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Tags"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(564, 304)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(107, 17)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Result Delimiter"
        '
        'lbScriptFiles
        '
        Me.lbScriptFiles.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbScriptFiles.FormattingEnabled = True
        Me.lbScriptFiles.ItemHeight = 16
        Me.lbScriptFiles.Location = New System.Drawing.Point(137, 31)
        Me.lbScriptFiles.Name = "lbScriptFiles"
        Me.lbScriptFiles.Size = New System.Drawing.Size(421, 100)
        Me.lbScriptFiles.TabIndex = 11
        '
        'txtScriptCommands
        '
        Me.txtScriptCommands.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtScriptCommands.Location = New System.Drawing.Point(137, 141)
        Me.txtScriptCommands.Multiline = True
        Me.txtScriptCommands.Name = "txtScriptCommands"
        Me.txtScriptCommands.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtScriptCommands.Size = New System.Drawing.Size(421, 104)
        Me.txtScriptCommands.TabIndex = 12
        '
        'txtScriptUsername
        '
        Me.txtScriptUsername.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtScriptUsername.Location = New System.Drawing.Point(137, 251)
        Me.txtScriptUsername.Name = "txtScriptUsername"
        Me.txtScriptUsername.Size = New System.Drawing.Size(421, 22)
        Me.txtScriptUsername.TabIndex = 13
        '
        'txtScriptPassword
        '
        Me.txtScriptPassword.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtScriptPassword.Location = New System.Drawing.Point(137, 279)
        Me.txtScriptPassword.Name = "txtScriptPassword"
        Me.txtScriptPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtScriptPassword.Size = New System.Drawing.Size(421, 22)
        Me.txtScriptPassword.TabIndex = 14
        '
        'nmbScriptTimeout
        '
        Me.nmbScriptTimeout.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nmbScriptTimeout.Location = New System.Drawing.Point(137, 307)
        Me.nmbScriptTimeout.Name = "nmbScriptTimeout"
        Me.nmbScriptTimeout.Size = New System.Drawing.Size(421, 22)
        Me.nmbScriptTimeout.TabIndex = 15
        Me.nmbScriptTimeout.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbScriptFields
        '
        Me.lbScriptFields.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbScriptFields.FormattingEnabled = True
        Me.lbScriptFields.ItemHeight = 16
        Me.lbScriptFields.Location = New System.Drawing.Point(677, 141)
        Me.lbScriptFields.Name = "lbScriptFields"
        Me.lbScriptFields.Size = New System.Drawing.Size(421, 100)
        Me.lbScriptFields.TabIndex = 17
        '
        'txtScriptTags
        '
        Me.txtScriptTags.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtScriptTags.Location = New System.Drawing.Point(677, 251)
        Me.txtScriptTags.Multiline = True
        Me.txtScriptTags.Name = "txtScriptTags"
        Me.tableScript.SetRowSpan(Me.txtScriptTags, 2)
        Me.txtScriptTags.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtScriptTags.Size = New System.Drawing.Size(421, 50)
        Me.txtScriptTags.TabIndex = 18
        '
        'txtScriptDelimiter
        '
        Me.txtScriptDelimiter.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtScriptDelimiter.Location = New System.Drawing.Point(677, 307)
        Me.txtScriptDelimiter.Name = "txtScriptDelimiter"
        Me.txtScriptDelimiter.Size = New System.Drawing.Size(421, 22)
        Me.txtScriptDelimiter.TabIndex = 19
        '
        'lbScriptPlatforms
        '
        Me.lbScriptPlatforms.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbScriptPlatforms.FormattingEnabled = True
        Me.lbScriptPlatforms.Location = New System.Drawing.Point(677, 31)
        Me.lbScriptPlatforms.Name = "lbScriptPlatforms"
        Me.lbScriptPlatforms.Size = New System.Drawing.Size(421, 89)
        Me.lbScriptPlatforms.TabIndex = 20
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(232, 365)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(227, 32)
        Me.lblStatus.TabIndex = 1
        Me.lblStatus.Text = "Creating Script..."
        Me.lblStatus.Visible = False
        '
        'progressBar
        '
        Me.progressBar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.progressBar.Location = New System.Drawing.Point(0, 429)
        Me.progressBar.Name = "progressBar"
        Me.progressBar.Size = New System.Drawing.Size(1116, 23)
        Me.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.progressBar.TabIndex = 0
        '
        'Form_CreateEditScript
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1116, 452)
        Me.Controls.Add(Me.panelControls)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_CreateEditScript"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Create/Edit Script"
        Me.panelControls.ResumeLayout(False)
        Me.panelControls.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.tableScript.ResumeLayout(False)
        Me.tableScript.PerformLayout()
        CType(Me.nmbScriptTimeout, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bgwCreateScript As System.ComponentModel.BackgroundWorker
    Friend WithEvents bgwEditScript As System.ComponentModel.BackgroundWorker
    Friend WithEvents panelControls As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnCreateEdit As System.Windows.Forms.Button
    Friend WithEvents tableScript As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtScriptName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lbScriptFiles As System.Windows.Forms.ListBox
    Friend WithEvents txtScriptCommands As System.Windows.Forms.TextBox
    Friend WithEvents txtScriptUsername As System.Windows.Forms.TextBox
    Friend WithEvents txtScriptPassword As System.Windows.Forms.TextBox
    Friend WithEvents nmbScriptTimeout As System.Windows.Forms.NumericUpDown
    Friend WithEvents lbScriptFields As System.Windows.Forms.ListBox
    Friend WithEvents txtScriptTags As System.Windows.Forms.TextBox
    Friend WithEvents txtScriptDelimiter As System.Windows.Forms.TextBox
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents progressBar As System.Windows.Forms.ProgressBar
    Friend WithEvents lbScriptPlatforms As System.Windows.Forms.CheckedListBox
End Class
