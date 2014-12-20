<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.tabctlPanels = New System.Windows.Forms.TabControl()
        Me.tabActivate = New System.Windows.Forms.TabPage()
        Me.lblActivateDesc = New System.Windows.Forms.Label()
        Me.btnActivate = New System.Windows.Forms.Button()
        Me.lblActProfiles = New System.Windows.Forms.Label()
        Me.lstActProfiles = New System.Windows.Forms.ListBox()
        Me.tabProfiles = New System.Windows.Forms.TabPage()
        Me.lblProfiles = New System.Windows.Forms.Label()
        Me.lstProfiles = New System.Windows.Forms.ListBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lblProfileName = New System.Windows.Forms.Label()
        Me.txtProfileName = New System.Windows.Forms.TextBox()
        Me.tabTools = New System.Windows.Forms.TabPage()
        Me.btnRestore = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.chkEnableDestructor = New System.Windows.Forms.CheckBox()
        Me.btnBackup = New System.Windows.Forms.Button()
        Me.lblToolsProfiles = New System.Windows.Forms.Label()
        Me.lstToolsProfiles = New System.Windows.Forms.ListBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuConfigure = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.stsMain = New System.Windows.Forms.StatusStrip()
        Me.stsMainLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stsProfileLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stsConfigurationLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tabctlPanels.SuspendLayout()
        Me.tabActivate.SuspendLayout()
        Me.tabProfiles.SuspendLayout()
        Me.tabTools.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.stsMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabctlPanels
        '
        Me.tabctlPanels.Controls.Add(Me.tabActivate)
        Me.tabctlPanels.Controls.Add(Me.tabProfiles)
        Me.tabctlPanels.Controls.Add(Me.tabTools)
        Me.tabctlPanels.Location = New System.Drawing.Point(12, 40)
        Me.tabctlPanels.Name = "tabctlPanels"
        Me.tabctlPanels.SelectedIndex = 0
        Me.tabctlPanels.Size = New System.Drawing.Size(403, 258)
        Me.tabctlPanels.TabIndex = 0
        '
        'tabActivate
        '
        Me.tabActivate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.tabActivate.Controls.Add(Me.lblActivateDesc)
        Me.tabActivate.Controls.Add(Me.btnActivate)
        Me.tabActivate.Controls.Add(Me.lblActProfiles)
        Me.tabActivate.Controls.Add(Me.lstActProfiles)
        Me.tabActivate.Location = New System.Drawing.Point(4, 22)
        Me.tabActivate.Name = "tabActivate"
        Me.tabActivate.Padding = New System.Windows.Forms.Padding(3)
        Me.tabActivate.Size = New System.Drawing.Size(395, 232)
        Me.tabActivate.TabIndex = 1
        Me.tabActivate.Text = "tabActivate"
        Me.tabActivate.UseVisualStyleBackColor = True
        '
        'lblActivateDesc
        '
        Me.lblActivateDesc.AutoSize = True
        Me.lblActivateDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActivateDesc.Location = New System.Drawing.Point(7, 7)
        Me.lblActivateDesc.Name = "lblActivateDesc"
        Me.lblActivateDesc.Size = New System.Drawing.Size(96, 13)
        Me.lblActivateDesc.TabIndex = 14
        Me.lblActivateDesc.Text = "lblActivateDesc"
        '
        'btnActivate
        '
        Me.btnActivate.Enabled = False
        Me.btnActivate.Location = New System.Drawing.Point(261, 117)
        Me.btnActivate.Name = "btnActivate"
        Me.btnActivate.Size = New System.Drawing.Size(75, 23)
        Me.btnActivate.TabIndex = 11
        Me.btnActivate.Text = "Activate"
        Me.btnActivate.UseVisualStyleBackColor = True
        '
        'lblActProfiles
        '
        Me.lblActProfiles.AutoSize = True
        Me.lblActProfiles.Location = New System.Drawing.Point(16, 36)
        Me.lblActProfiles.Name = "lblActProfiles"
        Me.lblActProfiles.Size = New System.Drawing.Size(41, 13)
        Me.lblActProfiles.TabIndex = 10
        Me.lblActProfiles.Text = "Profiles"
        '
        'lstActProfiles
        '
        Me.lstActProfiles.FormattingEnabled = True
        Me.lstActProfiles.Location = New System.Drawing.Point(19, 51)
        Me.lstActProfiles.Name = "lstActProfiles"
        Me.lstActProfiles.Size = New System.Drawing.Size(190, 160)
        Me.lstActProfiles.TabIndex = 9
        '
        'tabProfiles
        '
        Me.tabProfiles.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.tabProfiles.Controls.Add(Me.lblProfiles)
        Me.tabProfiles.Controls.Add(Me.lstProfiles)
        Me.tabProfiles.Controls.Add(Me.btnAdd)
        Me.tabProfiles.Controls.Add(Me.lblProfileName)
        Me.tabProfiles.Controls.Add(Me.txtProfileName)
        Me.tabProfiles.Location = New System.Drawing.Point(4, 22)
        Me.tabProfiles.Name = "tabProfiles"
        Me.tabProfiles.Padding = New System.Windows.Forms.Padding(3)
        Me.tabProfiles.Size = New System.Drawing.Size(395, 232)
        Me.tabProfiles.TabIndex = 0
        Me.tabProfiles.Text = "tabProfiles"
        Me.tabProfiles.UseVisualStyleBackColor = True
        '
        'lblProfiles
        '
        Me.lblProfiles.AutoSize = True
        Me.lblProfiles.Location = New System.Drawing.Point(192, 13)
        Me.lblProfiles.Name = "lblProfiles"
        Me.lblProfiles.Size = New System.Drawing.Size(41, 13)
        Me.lblProfiles.TabIndex = 6
        Me.lblProfiles.Text = "Profiles"
        '
        'lstProfiles
        '
        Me.lstProfiles.FormattingEnabled = True
        Me.lstProfiles.Location = New System.Drawing.Point(195, 28)
        Me.lstProfiles.Name = "lstProfiles"
        Me.lstProfiles.Size = New System.Drawing.Size(190, 160)
        Me.lstProfiles.TabIndex = 3
        '
        'btnAdd
        '
        Me.btnAdd.Enabled = False
        Me.btnAdd.Location = New System.Drawing.Point(94, 55)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 2
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'lblProfileName
        '
        Me.lblProfileName.AutoSize = True
        Me.lblProfileName.Location = New System.Drawing.Point(6, 13)
        Me.lblProfileName.Name = "lblProfileName"
        Me.lblProfileName.Size = New System.Drawing.Size(92, 13)
        Me.lblProfileName.TabIndex = 0
        Me.lblProfileName.Text = "New Profile Name"
        '
        'txtProfileName
        '
        Me.txtProfileName.Location = New System.Drawing.Point(6, 29)
        Me.txtProfileName.MaxLength = 32
        Me.txtProfileName.Name = "txtProfileName"
        Me.txtProfileName.Size = New System.Drawing.Size(163, 20)
        Me.txtProfileName.TabIndex = 1
        Me.txtProfileName.Text = "txtProfileName"
        '
        'tabTools
        '
        Me.tabTools.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.tabTools.Controls.Add(Me.btnRestore)
        Me.tabTools.Controls.Add(Me.btnDelete)
        Me.tabTools.Controls.Add(Me.chkEnableDestructor)
        Me.tabTools.Controls.Add(Me.btnBackup)
        Me.tabTools.Controls.Add(Me.lblToolsProfiles)
        Me.tabTools.Controls.Add(Me.lstToolsProfiles)
        Me.tabTools.Location = New System.Drawing.Point(4, 22)
        Me.tabTools.Name = "tabTools"
        Me.tabTools.Size = New System.Drawing.Size(395, 232)
        Me.tabTools.TabIndex = 2
        Me.tabTools.Text = "tabTools"
        Me.tabTools.UseVisualStyleBackColor = True
        '
        'btnRestore
        '
        Me.btnRestore.Location = New System.Drawing.Point(262, 167)
        Me.btnRestore.Name = "btnRestore"
        Me.btnRestore.Size = New System.Drawing.Size(75, 23)
        Me.btnRestore.TabIndex = 12
        Me.btnRestore.Text = "Restore"
        Me.btnRestore.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Enabled = False
        Me.btnDelete.Location = New System.Drawing.Point(262, 202)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 11
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'chkEnableDestructor
        '
        Me.chkEnableDestructor.AutoSize = True
        Me.chkEnableDestructor.Location = New System.Drawing.Point(17, 206)
        Me.chkEnableDestructor.Name = "chkEnableDestructor"
        Me.chkEnableDestructor.Size = New System.Drawing.Size(191, 17)
        Me.chkEnableDestructor.TabIndex = 10
        Me.chkEnableDestructor.Text = "Enable destructive profile functions"
        Me.chkEnableDestructor.UseVisualStyleBackColor = True
        '
        'btnBackup
        '
        Me.btnBackup.Enabled = False
        Me.btnBackup.Location = New System.Drawing.Point(262, 30)
        Me.btnBackup.Name = "btnBackup"
        Me.btnBackup.Size = New System.Drawing.Size(75, 23)
        Me.btnBackup.TabIndex = 9
        Me.btnBackup.Text = "Backup"
        Me.btnBackup.UseVisualStyleBackColor = True
        '
        'lblToolsProfiles
        '
        Me.lblToolsProfiles.AutoSize = True
        Me.lblToolsProfiles.Location = New System.Drawing.Point(14, 15)
        Me.lblToolsProfiles.Name = "lblToolsProfiles"
        Me.lblToolsProfiles.Size = New System.Drawing.Size(41, 13)
        Me.lblToolsProfiles.TabIndex = 8
        Me.lblToolsProfiles.Text = "Profiles"
        '
        'lstToolsProfiles
        '
        Me.lstToolsProfiles.FormattingEnabled = True
        Me.lstToolsProfiles.Location = New System.Drawing.Point(17, 30)
        Me.lstToolsProfiles.Name = "lstToolsProfiles"
        Me.lstToolsProfiles.Size = New System.Drawing.Size(190, 160)
        Me.lstToolsProfiles.TabIndex = 7
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuConfigure, Me.mnuAbout})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(425, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuConfigure
        '
        Me.mnuConfigure.Name = "mnuConfigure"
        Me.mnuConfigure.Size = New System.Drawing.Size(72, 20)
        Me.mnuConfigure.Text = "Configure"
        '
        'mnuAbout
        '
        Me.mnuAbout.Name = "mnuAbout"
        Me.mnuAbout.Size = New System.Drawing.Size(52, 20)
        Me.mnuAbout.Text = "About"
        '
        'stsMain
        '
        Me.stsMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.stsMainLabel, Me.stsProfileLabel, Me.stsConfigurationLabel})
        Me.stsMain.Location = New System.Drawing.Point(0, 312)
        Me.stsMain.Name = "stsMain"
        Me.stsMain.Size = New System.Drawing.Size(425, 22)
        Me.stsMain.SizingGrip = False
        Me.stsMain.TabIndex = 2
        '
        'stsMainLabel
        '
        Me.stsMainLabel.AutoSize = False
        Me.stsMainLabel.Name = "stsMainLabel"
        Me.stsMainLabel.Size = New System.Drawing.Size(200, 17)
        Me.stsMainLabel.Spring = True
        Me.stsMainLabel.Text = "stsMainLabel"
        Me.stsMainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'stsProfileLabel
        '
        Me.stsProfileLabel.Name = "stsProfileLabel"
        Me.stsProfileLabel.Size = New System.Drawing.Size(83, 17)
        Me.stsProfileLabel.Text = "stsProfileLabel"
        '
        'stsConfigurationLabel
        '
        Me.stsConfigurationLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.stsConfigurationLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.stsConfigurationLabel.Name = "stsConfigurationLabel"
        Me.stsConfigurationLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.stsConfigurationLabel.Size = New System.Drawing.Size(127, 17)
        Me.stsConfigurationLabel.Text = "stsConfigurationLabel"
        Me.stsConfigurationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(425, 334)
        Me.Controls.Add(Me.stsMain)
        Me.Controls.Add(Me.tabctlPanels)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "X3 Profile Manager"
        Me.tabctlPanels.ResumeLayout(False)
        Me.tabActivate.ResumeLayout(False)
        Me.tabActivate.PerformLayout()
        Me.tabProfiles.ResumeLayout(False)
        Me.tabProfiles.PerformLayout()
        Me.tabTools.ResumeLayout(False)
        Me.tabTools.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.stsMain.ResumeLayout(False)
        Me.stsMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tabctlPanels As System.Windows.Forms.TabControl
    Friend WithEvents tabProfiles As System.Windows.Forms.TabPage
    Friend WithEvents tabActivate As System.Windows.Forms.TabPage
    Friend WithEvents tabTools As System.Windows.Forms.TabPage
    Friend WithEvents lblProfileName As System.Windows.Forms.Label
    Friend WithEvents txtProfileName As System.Windows.Forms.TextBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents lstProfiles As System.Windows.Forms.ListBox
    Friend WithEvents lblProfiles As System.Windows.Forms.Label
    Friend WithEvents lblToolsProfiles As System.Windows.Forms.Label
    Friend WithEvents lstToolsProfiles As System.Windows.Forms.ListBox
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents chkEnableDestructor As System.Windows.Forms.CheckBox
    Friend WithEvents btnBackup As System.Windows.Forms.Button
    Friend WithEvents btnActivate As System.Windows.Forms.Button
    Friend WithEvents lblActProfiles As System.Windows.Forms.Label
    Friend WithEvents lstActProfiles As System.Windows.Forms.ListBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuAbout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents stsMain As System.Windows.Forms.StatusStrip
    Friend WithEvents stsMainLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents mnuConfigure As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblActivateDesc As System.Windows.Forms.Label
    Friend WithEvents stsConfigurationLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents stsProfileLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents btnRestore As System.Windows.Forms.Button

End Class
