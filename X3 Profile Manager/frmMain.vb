'    X3 Profile Manager - manages 1 or more profiles for Egosoft X3 Universe of software games
'    Copyright (C) 2014  Token Software
'
'    This program is free software: you can redistribute it and/or modify
'    it under the terms of the GNU General Public License as published by
'    the Free Software Foundation, either version 3 of the License, or
'    (at your option) any later version.
'
'    This program is distributed in the hope that it will be useful,
'    but WITHOUT ANY WARRANTY; without even the implied warranty of
'    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
'    GNU General Public License for more details.
'
'    You should have received a copy of the GNU General Public License
'    along with this program.  If not, see <http://www.gnu.org/licenses/>.

Public Class frmMain

    Private destructable As Boolean
    Private recentlyDestructable As Boolean
    Private lastText As String

    Private Sub txtProfileName_TextChanged(sender As Object, e As EventArgs) Handles txtProfileName.TextChanged
        If txtProfileName.Text.Length = 0 Then
            lastText = ""
        Else
            If txtProfileName.Text.IndexOfAny(PROFILE_CHARACTERS_ALLOWED) = -1 Then
                txtProfileName.Text = lastText
            Else
                lastText = txtProfileName.Text
            End If
        End If
        btnAdd.Enabled = uiIsValidProfileName(txtProfileName.Text)
    End Sub

    Private Sub lstActProfiles_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstActProfiles.SelectedIndexChanged
        Dim selected As Integer = lstActProfiles.SelectedIndex
        btnActivate.Enabled = selected >= 0 AndAlso lstActProfiles.Items.Item(selected) <> uiEditionDetail(My.Settings.LastEdition, EDITION_ACTIVE_PROFILE_INDEX)
    End Sub

    Private Sub lstToolsProfiles_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstToolsProfiles.SelectedIndexChanged
        If recentlyDestructable Then
            chkEnableDestructor.Checked = False
            destructable = False
        End If
        btnBackup.Enabled = lstToolsProfiles.SelectedIndex >= 0
        btnRestore.Enabled = lstToolsProfiles.SelectedIndex >= 0 And destructable
        btnDelete.Enabled = lstToolsProfiles.SelectedIndex >= 0 And destructable
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim profileName As String
        profileName = txtProfileName.Text
        If (uiIsValidProfileName(profileName)) Then
            uiAddProfile(profileName, Me, PROFILE_ADD_ACTION)
            fsAddProfileToEdition(profileName, My.Settings.LastEdition)
        End If
    End Sub

    Private Sub chkEnableDestructor_CheckedChanged(sender As Object, e As EventArgs) Handles chkEnableDestructor.CheckedChanged
        destructable = chkEnableDestructor.Checked
        btnDelete.Enabled = destructable And lstToolsProfiles.SelectedIndex >= 0
        btnRestore.Enabled = destructable And lstToolsProfiles.SelectedIndex >= 0
        recentlyDestructable = True
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim profileName As String = lstToolsProfiles.Items.Item(lstToolsProfiles.SelectedIndex)
        Dim editionId As String = My.Settings.LastEdition
        If profileName = uiEditionDetail(editionId, EDITION_ACTIVE_PROFILE_INDEX) Then
            ' the profile to delete is also the active profile... and cannot be deleted
            MsgBox(DELETE_ACTIVE_PROFILE_MSG, MsgBoxStyle.Critical)
        Else
            If (MsgBox(uiGetDeleteProfileMessage(profileName),
                       MsgBoxStyle.Critical + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, DELETE_PROFILE_TITLE_MSG) = MsgBoxResult.Yes) Then
                fsDestructiveDeleteProfileFromEdition(profileName, editionId)
                uiDeleteProfile(profileName, Me, PROFILE_DELETE_ACTION)
            End If
        End If
        destructable = False
        recentlyDestructable = False
        chkEnableDestructor.Checked = False
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initializeApplication()
        Dim editionId As Integer = My.Settings.LastEdition
        With Me
            For i As Integer = 0 To tabctlPanels.TabPages.Count - 1
                .tabctlPanels.TabPages.Item(i).Text = uiTabControlDetail(i)
            Next i
            .stsProfileLabel.Text = ""
            .stsMainLabel.Text = INITIALIZED_MSG
            .lblActivateDesc.Text = UI_LBL_ACTIVATE_DESC_TEXT
            .txtProfileName.Text = ""
            .btnBackup.Enabled = False
            .btnRestore.Enabled = False
            .btnDelete.Enabled = False
            destructable = False
            recentlyDestructable = False
        End With
        If editionId >= 0 And fsIsEditionInstalled(editionId) Then
            stsConfigurationLabel.Text = uiEditionDetail(editionId, EDITION_TITLE_INDEX)
            tabctlPanels.Enabled = True
            stsConfigurationLabel.Visible = True
            Me.Height = MAX_HEIGHT_MAIN_FORM
            fsLoadProfileDataForEdition(editionId)
        Else
            stsConfigurationLabel.Text = ""
            tabctlPanels.Enabled = False
            stsConfigurationLabel.Visible = False
            My.Settings.LastEdition = -1
            Me.Height = MIN_HEIGHT_MAIN_FORM
        End If
        uiSetTabPanel(Me)
    End Sub

    Private Sub mnuAbout_Click(sender As Object, e As EventArgs) Handles mnuAbout.Click
        frmAbout.Show()
    End Sub

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub mnuConfigure_Click(sender As Object, e As EventArgs) Handles mnuConfigure.Click
        frmConfigure.Show()
    End Sub

    Private Sub btnActivate_Click(sender As Object, e As EventArgs) Handles btnActivate.Click
        Dim profileId As Integer = lstActProfiles.SelectedIndex
        Dim profileName As String = lstActProfiles.Items.Item(profileId)
        Dim editionId As Integer = My.Settings.LastEdition
        fsActivateProfile(profileName, editionId)
        stsProfileLabel.Text = profileName
        stsMainLabel.Text = "Activated profile '" & profileName & "'"
        uiEditionDetail(editionId, EDITION_ACTIVE_PROFILE_INDEX) = profileName
        btnActivate.Enabled = False
    End Sub

    Private Sub btnBackup_Click(sender As Object, e As EventArgs) Handles btnBackup.Click
        If lstToolsProfiles.SelectedIndex >= 0 Then
            Dim profileName As String = lstToolsProfiles.Items.Item(lstToolsProfiles.SelectedIndex)
            fsBackupProfile(profileName, My.Settings.LastEdition)
            stsMainLabel.Text = "Profile '" & profileName & "' backed up"
            MsgBox(PROFILE_BACKUP_COMPLETE_MSG & profileName & "'.", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub btnRestore_Click(sender As Object, e As EventArgs) Handles btnRestore.Click
        Dim profileName As String = lstToolsProfiles.Items.Item(lstToolsProfiles.SelectedIndex)
        Dim editionId As Integer = My.Settings.LastEdition
        Dim profilePath As String = fsGetPathToEdition(editionId) & "\" & PROFILE_MANAGER_DIRECTORY & "\" & profileName
        If My.Computer.FileSystem.DirectoryExists(profilePath & "\" & BACKUP_DIRECTORY) Then
            If MsgBox(RESTORE_PROFILE_PROMPT_MSG, MsgBoxStyle.Critical + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, RESTORE_PROFILE_PROMPT_TITLE) = MsgBoxResult.Yes Then
                fsRestoreProfile(profileName, editionId)
                stsMainLabel.Text = "Profile '" & profileName & "' restored"
                MsgBox(PROFILE_RESTORE_COMPLETE_MSG & profileName & "'.", MsgBoxStyle.Information)
            End If
        Else
            MsgBox(RESTORE_BACKUP_MISSING_MSG & profileName & "'!", MsgBoxStyle.Exclamation)
        End If
        chkEnableDestructor.Checked = False
    End Sub
End Class
