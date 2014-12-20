<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConfigure
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConfigure))
        Me.lblConfigDescription = New System.Windows.Forms.Label()
        Me.pnlConfigure = New System.Windows.Forms.Panel()
        Me.pctVerifyStatus = New System.Windows.Forms.PictureBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnVerify = New System.Windows.Forms.Button()
        Me.btnAcceptEdition = New System.Windows.Forms.Button()
        Me.cmbEdition = New System.Windows.Forms.ComboBox()
        Me.lblEdition = New System.Windows.Forms.Label()
        Me.pctCheckmark = New System.Windows.Forms.PictureBox()
        Me.pctInvalid = New System.Windows.Forms.PictureBox()
        Me.pnlConfigure.SuspendLayout()
        CType(Me.pctVerifyStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctCheckmark, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctInvalid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblConfigDescription
        '
        Me.lblConfigDescription.AutoSize = True
        Me.lblConfigDescription.Location = New System.Drawing.Point(12, 9)
        Me.lblConfigDescription.MaximumSize = New System.Drawing.Size(358, 0)
        Me.lblConfigDescription.Name = "lblConfigDescription"
        Me.lblConfigDescription.Size = New System.Drawing.Size(100, 13)
        Me.lblConfigDescription.TabIndex = 3
        Me.lblConfigDescription.Text = "lblConfigDescription"
        '
        'pnlConfigure
        '
        Me.pnlConfigure.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlConfigure.Controls.Add(Me.pctInvalid)
        Me.pnlConfigure.Controls.Add(Me.pctCheckmark)
        Me.pnlConfigure.Controls.Add(Me.pctVerifyStatus)
        Me.pnlConfigure.Controls.Add(Me.btnCancel)
        Me.pnlConfigure.Controls.Add(Me.btnVerify)
        Me.pnlConfigure.Controls.Add(Me.btnAcceptEdition)
        Me.pnlConfigure.Controls.Add(Me.cmbEdition)
        Me.pnlConfigure.Controls.Add(Me.lblEdition)
        Me.pnlConfigure.Location = New System.Drawing.Point(12, 44)
        Me.pnlConfigure.Name = "pnlConfigure"
        Me.pnlConfigure.Size = New System.Drawing.Size(358, 171)
        Me.pnlConfigure.TabIndex = 2
        '
        'pctVerifyStatus
        '
        Me.pctVerifyStatus.Image = CType(resources.GetObject("pctVerifyStatus.Image"), System.Drawing.Image)
        Me.pctVerifyStatus.Location = New System.Drawing.Point(311, 31)
        Me.pctVerifyStatus.Name = "pctVerifyStatus"
        Me.pctVerifyStatus.Size = New System.Drawing.Size(16, 17)
        Me.pctVerifyStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pctVerifyStatus.TabIndex = 4
        Me.pctVerifyStatus.TabStop = False
        Me.pctVerifyStatus.Visible = False
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(181, 129)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 6
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnVerify
        '
        Me.btnVerify.Location = New System.Drawing.Point(225, 31)
        Me.btnVerify.Name = "btnVerify"
        Me.btnVerify.Size = New System.Drawing.Size(70, 23)
        Me.btnVerify.TabIndex = 5
        Me.btnVerify.Text = "Verify"
        Me.btnVerify.UseVisualStyleBackColor = True
        '
        'btnAcceptEdition
        '
        Me.btnAcceptEdition.Location = New System.Drawing.Point(262, 129)
        Me.btnAcceptEdition.Name = "btnAcceptEdition"
        Me.btnAcceptEdition.Size = New System.Drawing.Size(75, 23)
        Me.btnAcceptEdition.TabIndex = 4
        Me.btnAcceptEdition.Text = "Accept"
        Me.btnAcceptEdition.UseVisualStyleBackColor = True
        '
        'cmbEdition
        '
        Me.cmbEdition.FormattingEnabled = True
        Me.cmbEdition.Location = New System.Drawing.Point(18, 31)
        Me.cmbEdition.Name = "cmbEdition"
        Me.cmbEdition.Size = New System.Drawing.Size(201, 21)
        Me.cmbEdition.TabIndex = 3
        '
        'lblEdition
        '
        Me.lblEdition.AutoSize = True
        Me.lblEdition.Location = New System.Drawing.Point(15, 15)
        Me.lblEdition.Name = "lblEdition"
        Me.lblEdition.Size = New System.Drawing.Size(78, 13)
        Me.lblEdition.TabIndex = 2
        Me.lblEdition.Text = "Choose Edition"
        '
        'pctCheckmark
        '
        Me.pctCheckmark.Image = CType(resources.GetObject("pctCheckmark.Image"), System.Drawing.Image)
        Me.pctCheckmark.Location = New System.Drawing.Point(18, 78)
        Me.pctCheckmark.Name = "pctCheckmark"
        Me.pctCheckmark.Size = New System.Drawing.Size(16, 17)
        Me.pctCheckmark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pctCheckmark.TabIndex = 7
        Me.pctCheckmark.TabStop = False
        Me.pctCheckmark.Visible = False
        '
        'pctInvalid
        '
        Me.pctInvalid.Image = CType(resources.GetObject("pctInvalid.Image"), System.Drawing.Image)
        Me.pctInvalid.Location = New System.Drawing.Point(40, 78)
        Me.pctInvalid.Name = "pctInvalid"
        Me.pctInvalid.Size = New System.Drawing.Size(16, 21)
        Me.pctInvalid.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pctInvalid.TabIndex = 8
        Me.pctInvalid.TabStop = False
        Me.pctInvalid.Visible = False
        '
        'frmConfigure
        '
        Me.AcceptButton = Me.btnAcceptEdition
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(382, 227)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblConfigDescription)
        Me.Controls.Add(Me.pnlConfigure)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmConfigure"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Configure X3 Profile Manager"
        Me.pnlConfigure.ResumeLayout(False)
        Me.pnlConfigure.PerformLayout()
        CType(Me.pctVerifyStatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctCheckmark, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctInvalid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblConfigDescription As System.Windows.Forms.Label
    Friend WithEvents pnlConfigure As System.Windows.Forms.Panel
    Friend WithEvents btnVerify As System.Windows.Forms.Button
    Friend WithEvents btnAcceptEdition As System.Windows.Forms.Button
    Friend WithEvents cmbEdition As System.Windows.Forms.ComboBox
    Friend WithEvents lblEdition As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents pctVerifyStatus As System.Windows.Forms.PictureBox
    Friend WithEvents pctCheckmark As System.Windows.Forms.PictureBox
    Friend WithEvents pctInvalid As System.Windows.Forms.PictureBox
End Class
