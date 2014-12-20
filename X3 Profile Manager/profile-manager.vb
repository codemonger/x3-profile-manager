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

Module profile_manager

    '================================================= INTEGER CONSTANTS
    ' frmMain size dimensions
    Public Const MIN_HEIGHT_MAIN_FORM As Integer = 90
    Public Const MAX_HEIGHT_MAIN_FORM As Integer = 373
    Public Const MIN_WIDTH_MAIN_FORM As Integer = 441
    Public Const MAX_WIDTH_MAIN_FORM As Integer = 670
    ' editionDetail indices
    Public Const EDITION_TITLE_INDEX As Integer = 0
    Public Const EDITION_DIRECTORY_INDEX As Integer = 1
    Public Const EDITION_ACTIVE_PROFILE_INDEX As Integer = 2
    ' tabControlDetail indices
    Public Const TAB_CONTROL_LABEL_INDEX As Integer = 0
    Public Const TAB_CONTROL_DIGIT_ACTIVATE As Integer = 0
    Public Const TAB_CONTROL_DIGIT_PROFILES As Integer = 1
    Public Const TAB_CONTROL_DIGIT_TOOLS As Integer = 2

    '================================================= STRING CONSTANTS
    ' user interface strings
    Public PROFILE_CHARACTERS_ALLOWED() As Char = " ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz".ToCharArray
    Public Const CONFIG_DESCRIPTION As String = " is able to manage multiple X3 editions. Choose the X3 edition from the drop-down box below to manage its profiles."
    Public Const DELETE_PROFILE_TITLE_MSG As String = "Confirm Delete Operation"
    Public Const DELETE_PROFILE_PREMSG As String = "You are about to delete '{0}'s profile! All data associated with this profile will be destroyed. This cannot be undone!"
    Public Const PROFILE_DOES_NOT_EXIST_PREMSG As String = "The profile, '{0}' does not exist in your X3:{1} profiles."
    Public Const EDITION_SELECTED_MSG As String = "X3 Edition selected"
    Public Const UI_LBL_ACTIVATE_DESC_TEXT As String = "Choose a profile to Activate:"
    Public Const UNINTIALIZED_EDITION_DESC_MSG As String = "The X3 edition you have selected has not been initialized by Profile Manager.  Please supply a name for the current profile."
    Public Const CHOOSE_PROFILE_TO_ACTIVATE_MSG As String = "Please activate a profile."
    Public Const CHOOSE_PROFILE_TO_ACTIVATE_TITLE As String = "Active Profile Deleted"
    Public Const PROFILE_DELETED_MSG As String = "Profile deleted!"
    Public Const RESTORE_PROFILE_PROMPT_MSG As String = "This operation will irreversibly overwrite the contents of the selected profile with the contents of the backup of that profile! Are you sure you want to restore the backup of the selected profile?"
    Public Const RESTORE_PROFILE_PROMPT_TITLE As String = "Overwrite Profile"
    Public Const RESTORE_BACKUP_MISSING_MSG As String = "No backup exists for profile '"
    Public Const DELETE_ACTIVE_PROFILE_MSG As String = "This profile is currently the active profile for this edition and cannot be deleted.  Activate a different profile and retry."
    Public Const INITIALIZED_MSG As String = "Initialized"
    Public Const VALID_X3_INSTALL_MSG As String = "Found valid X3 installation"
    Public Const INVALID_X3_INSTALL_MSG As String = "Not a valid X3 installation"
    Public Const PROFILE_ADD_ACTION As String = "Added"
    Public Const PROFILE_LOAD_ACTION As String = "Loaded"
    Public Const PROFILE_DELETE_ACTION As String = "deleted"
    Public Const PROFILE_BACKUP_COMPLETE_MSG As String = "Completed backup for profile '"
    Public Const PROFILE_RESTORE_COMPLETE_MSG As String = "Completed restoration of profile '"
    ' tabControlDetail labels for frmMain.tabctlPanels
    Public Const TAB_CONTROL_LABEL_ACTIVATE As String = "Activate"
    Public Const TAB_CONTROL_LABEL_PROFILES As String = "Profiles"
    Public Const TAB_CONTROL_LABEL_TOOLS As String = "Tools"

    Public uiEditionDetail(3, 2)
    Public uiTabControlDetail(2)

    Public Sub initializeApplication()
        uiEditionDetail(0, EDITION_TITLE_INDEX) = "Reunion"
        uiEditionDetail(1, EDITION_TITLE_INDEX) = "Terran Conflict"
        uiEditionDetail(2, EDITION_TITLE_INDEX) = "Albion Prelude"
        uiEditionDetail(3, EDITION_TITLE_INDEX) = "Playable Demo"
        uiEditionDetail(0, EDITION_DIRECTORY_INDEX) = "X3"
        uiEditionDetail(1, EDITION_DIRECTORY_INDEX) = "X3TC"
        uiEditionDetail(2, EDITION_DIRECTORY_INDEX) = "X3AP"
        uiEditionDetail(3, EDITION_DIRECTORY_INDEX) = "X3PDemo"
        uiTabControlDetail(TAB_CONTROL_DIGIT_ACTIVATE) = TAB_CONTROL_LABEL_ACTIVATE
        uiTabControlDetail(TAB_CONTROL_DIGIT_PROFILES) = TAB_CONTROL_LABEL_PROFILES
        uiTabControlDetail(TAB_CONTROL_DIGIT_TOOLS) = TAB_CONTROL_LABEL_TOOLS

        initializeFileSystem()
    End Sub

    Public Sub uiClearProfiles(form As frmMain)
        With form
            .lstActProfiles.Items.Clear()
            .lstProfiles.Items.Clear()
            .lstToolsProfiles.Items.Clear()
        End With
    End Sub

    Public Function uiGetDeleteProfileMessage(name As String) As String
        Dim deleteMsg As New System.Text.StringBuilder
        Dim index As Integer = DELETE_PROFILE_PREMSG.IndexOf("{0}")
        deleteMsg.Append(DELETE_PROFILE_PREMSG.Substring(0, index - 1))
        deleteMsg.Append(name)
        deleteMsg.Append(DELETE_PROFILE_PREMSG.Substring(index + 3))
        uiGetDeleteProfileMessage = deleteMsg.ToString
    End Function

    Public Function uiGetProfileDoesNotExistMessage(name As String, editionId As Integer) As String
        Dim unexistMsg As New System.Text.StringBuilder
        Dim indexA As Integer = PROFILE_DOES_NOT_EXIST_PREMSG.IndexOf("{0}")
        unexistMsg.Append(PROFILE_DOES_NOT_EXIST_PREMSG.Substring(0, indexA - 1))
        unexistMsg.Append(name)
        Dim indexB As Integer = DELETE_PROFILE_PREMSG.IndexOf("{1}")
        unexistMsg.Append(PROFILE_DOES_NOT_EXIST_PREMSG.Substring(indexA + 3, indexB))
        unexistMsg.Append(uiEditionDetail(editionId, EDITION_TITLE_INDEX))
        unexistMsg.Append(PROFILE_DOES_NOT_EXIST_PREMSG.Substring(indexB + 3))
        uiGetProfileDoesNotExistMessage = unexistMsg.ToString
    End Function

    Public Sub uiAddProfile(profileName As String, form As frmMain, action As String)
        With form
            .lstActProfiles.Items.Add(profileName)
            .lstToolsProfiles.Items.Add(profileName)
            .lstProfiles.Items.Add(profileName)
            .txtProfileName.Text = ""
            .stsMainLabel.Text = action & " Profile '" & profileName & "'"
        End With
    End Sub

    Public Sub uiDeleteProfile(profileName As String, form As frmMain, action As String)
        Dim editionId As String = My.Settings.LastEdition
        With form
            .stsMainLabel.Text = "Profile '" & profileName & "' " & action
            .lstToolsProfiles.Items.Remove(profileName)
            .lstProfiles.Items.Remove(profileName)
            .lstActProfiles.Items.Remove(profileName)
            If uiEditionDetail(editionId, EDITION_ACTIVE_PROFILE_INDEX) = profileName Then
                ' the profile to delete is the active profile
                uiEditionDetail(editionId, EDITION_ACTIVE_PROFILE_INDEX) = Nothing
                .stsProfileLabel.Text = ""
                .tabctlPanels.SelectedIndex = TAB_CONTROL_DIGIT_ACTIVATE
                MsgBox(CHOOSE_PROFILE_TO_ACTIVATE_MSG, MsgBoxStyle.Exclamation, CHOOSE_PROFILE_TO_ACTIVATE_TITLE)
            End If
        End With
    End Sub

    Public Sub uiSetTabPanel(form As frmMain)
        If Not uiEditionHasProfiles(form) Then
            form.tabctlPanels.SelectedIndex = TAB_CONTROL_DIGIT_PROFILES
        Else
            form.tabctlPanels.SelectedIndex = TAB_CONTROL_DIGIT_ACTIVATE
        End If
    End Sub

    Public Function uiIsValidProfileName(profileName As String) As Boolean
        uiIsValidProfileName = profileName.Length >= 3
    End Function

    Public Function uiEditionHasProfiles(form As frmMain) As Boolean
        ' result only valid after profiles have been loaded
        uiEditionHasProfiles = form.lstProfiles.Items.Count > 0
    End Function

    Public Sub uiProfilesLoaded(count As Integer)
        frmMain.stsMainLabel.Text = "Loaded " & count & " profiles"
    End Sub

End Module
