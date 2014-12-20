Public Class frmConfigure

    Private Sub frmConfigure_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i As Integer = 0 To uiEditionDetail.GetUpperBound(0)
            cmbEdition.Items.Add(uiEditionDetail(i, EDITION_TITLE_INDEX))
        Next i
        btnAcceptEdition.Enabled = False
        pctVerifyStatus.Visible = False
        btnVerify.Enabled = False
        lblConfigDescription.Text = My.Application.Info.ProductName + CONFIG_DESCRIPTION
    End Sub

    Private Sub btnAcceptEdition_Click(sender As Object, e As EventArgs) Handles btnAcceptEdition.Click
        Dim editionId As Integer
        editionId = cmbEdition.SelectedIndex
        uiClearProfiles(frmMain)
        fsCreateProfileManagerOnEdition(editionId)
        fsLoadProfileDataForEdition(editionId)
        With frmMain
            .stsMainLabel.Text = EDITION_SELECTED_MSG
            .tabctlPanels.Enabled = True
            .Height = MAX_HEIGHT_MAIN_FORM
            .stsConfigurationLabel.Text = uiEditionDetail(editionId, EDITION_TITLE_INDEX)
            .stsConfigurationLabel.Visible = True
        End With
        My.Settings.LastEdition = editionId
        uiSetTabPanel(frmMain)
        If Not uiEditionHasProfiles(frmMain) Then
            frmInitEdition.ShowDialog(Me)
        End If
        Me.Dispose()
    End Sub

    Private Sub cmbEdition_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEdition.SelectedIndexChanged
        btnVerify.Enabled = cmbEdition.SelectedIndex <> -1
        pctVerifyStatus.Visible = False
        btnAcceptEdition.Enabled = False
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Dispose()
    End Sub

    Private Sub btnVerify_Click(sender As Object, e As EventArgs) Handles btnVerify.Click
        If cmbEdition.SelectedIndex <> -1 Then
            If fsIsEditionInstalled(cmbEdition.SelectedIndex) Then
                pctVerifyStatus.Image = pctCheckmark.Image
                btnAcceptEdition.Enabled = True
                frmMain.stsMainLabel.Text = VALID_X3_INSTALL_MSG
            Else
                pctVerifyStatus.Image = pctInvalid.Image
                frmMain.stsMainLabel.Text = INVALID_X3_INSTALL_MSG
            End If
            pctVerifyStatus.Visible = True
        End If
    End Sub

End Class