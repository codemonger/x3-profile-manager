<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInitEdition
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInitEdition))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblConfiguration = New System.Windows.Forms.Label()
        Me.lblWarningDesc = New System.Windows.Forms.Label()
        Me.txtProfileName = New System.Windows.Forms.TextBox()
        Me.btnOK = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lblConfiguration
        '
        Me.lblConfiguration.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblConfiguration.AutoSize = True
        Me.lblConfiguration.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConfiguration.Location = New System.Drawing.Point(307, 12)
        Me.lblConfiguration.Name = "lblConfiguration"
        Me.lblConfiguration.Size = New System.Drawing.Size(95, 13)
        Me.lblConfiguration.TabIndex = 1
        Me.lblConfiguration.Text = "lblConfiguration"
        Me.lblConfiguration.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblWarningDesc
        '
        Me.lblWarningDesc.AutoSize = True
        Me.lblWarningDesc.Location = New System.Drawing.Point(78, 44)
        Me.lblWarningDesc.MaximumSize = New System.Drawing.Size(300, 0)
        Me.lblWarningDesc.Name = "lblWarningDesc"
        Me.lblWarningDesc.Size = New System.Drawing.Size(82, 13)
        Me.lblWarningDesc.TabIndex = 2
        Me.lblWarningDesc.Text = "lblWarningDesc"
        '
        'txtProfileName
        '
        Me.txtProfileName.Location = New System.Drawing.Point(81, 160)
        Me.txtProfileName.MaxLength = 64
        Me.txtProfileName.Name = "txtProfileName"
        Me.txtProfileName.Size = New System.Drawing.Size(156, 20)
        Me.txtProfileName.TabIndex = 3
        Me.txtProfileName.Text = "txtProfileName"
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(310, 160)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 4
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'frmInitEdition
        '
        Me.AcceptButton = Me.btnOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(414, 198)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.txtProfileName)
        Me.Controls.Add(Me.lblWarningDesc)
        Me.Controls.Add(Me.lblConfiguration)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmInitEdition"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Uninitialized Edition"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblConfiguration As System.Windows.Forms.Label
    Friend WithEvents lblWarningDesc As System.Windows.Forms.Label
    Friend WithEvents txtProfileName As System.Windows.Forms.TextBox
    Friend WithEvents btnOK As System.Windows.Forms.Button
End Class
