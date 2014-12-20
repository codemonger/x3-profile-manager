Public Class frmInitEdition

    Private lastText As String

    Private Sub frmInitEdition_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblConfiguration.Text = uiEditionDetail(My.Settings.LastEdition, EDITION_TITLE_INDEX)
        lblWarningDesc.Text = UNINTIALIZED_EDITION_DESC_MSG
        lastText = ""
        btnOK.Enabled = False
        txtProfileName.Text = ""
    End Sub

    Private Sub txtProfileName_TextChanged(sender As Object, e As EventArgs) Handles txtProfileName.TextChanged
        If txtProfileName.Text.Length = 0 Then
            lastText = ""
        Else
            If txtProfileName.Text.IndexOfAny(PROFILE_CHARACTERS_ALLOWED) = -1 Then
                txtProfileName.Text = lastText
            Else
                lastText = txtProfileName.Text
            End If
            btnOK.Enabled = uiIsValidProfileName(txtProfileName.Text)
        End If
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Dim editionId As Integer = My.Settings.LastEdition
        Dim profileName As String = txtProfileName.Text
        uiAddProfile(profileName, frmMain, PROFILE_ADD_ACTION)
        fsAddProfileToEdition(txtProfileName.Text, editionId)
        frmMain.stsProfileLabel.Text = profileName
        fsSetActiveProfileName(profileName, editionId)
        Me.Dispose()
    End Sub
End Class