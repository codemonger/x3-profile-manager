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

Module file_manager
    '================================================= STRING CONSTANTS
    ' file system strings
    Public Const EGOSOFT_DIRECTORY As String = "Egosoft"
    Public Const PROFILE_MANAGER_DIRECTORY As String = "ProfileStore"
    Public Const BACKUP_DIRECTORY As String = ".backup"
    Public Const ACTIVE_PROFILE_FILENAME As String = ".profile"

    '================================================= DATA VARIABLES
    ' file system data
    Public fsMyDocumentsDirectory As String
    Public fsEgosoftDirectory As String

    Public Sub initializeFileSystem()
        ' initialize file system data
        fsMyDocumentsDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        fsEgosoftDirectory = fsMyDocumentsDirectory & "\" & EGOSOFT_DIRECTORY
    End Sub

    Public Function fsIsEditionInstalled(editionId As Integer) As Boolean
        If (editionId = -1) Then
            fsIsEditionInstalled = False
        Else
            fsIsEditionInstalled = My.Computer.FileSystem.DirectoryExists(fsEgosoftDirectory & "\" & uiEditionDetail(editionId, EDITION_DIRECTORY_INDEX))
        End If
    End Function

    Public Sub fsLoadProfileDataForEdition(editionId As Integer)
        Dim count As Integer = 0
        Dim editionPath As String = fsGetPathToEdition(editionId)
        Dim storePath As String = editionPath & "\" & PROFILE_MANAGER_DIRECTORY
        If editionId > -1 And My.Computer.FileSystem.DirectoryExists(storePath) Then
            Dim storeDirInfo As System.IO.DirectoryInfo = My.Computer.FileSystem.GetDirectoryInfo(storePath)
            For Each path In storeDirInfo.EnumerateDirectories
                uiAddProfile(path.Name, frmMain, PROFILE_LOAD_ACTION)
                count += 1
            Next
            ' load the active profile
            fsLoadActiveProfileForEdition(editionId)
            uiProfilesLoaded(count)
        End If
    End Sub

    Public Sub fsLoadActiveProfileForEdition(editionId As Integer)
        ' loading
        Dim editionPath As String = fsGetPathToEdition(editionId)
        Dim activeProfileFullFilename As String = editionPath & "\" & PROFILE_MANAGER_DIRECTORY & "\" & ACTIVE_PROFILE_FILENAME
        If My.Computer.FileSystem.FileExists(activeProfileFullFilename) Then
            Dim profileName As String = My.Computer.FileSystem.ReadAllText(activeProfileFullFilename).Trim
            frmMain.stsProfileLabel.Text = profileName
            uiEditionDetail(editionId, EDITION_ACTIVE_PROFILE_INDEX) = profileName
        Else
            frmMain.stsProfileLabel.Text = ""
            MsgBox(CHOOSE_PROFILE_TO_ACTIVATE_MSG, MsgBoxStyle.Exclamation, CHOOSE_PROFILE_TO_ACTIVATE_TITLE)
        End If
    End Sub

    Public Function fsGetPathToEdition(editionId As Integer) As String
        fsGetPathToEdition = fsEgosoftDirectory & "\" & uiEditionDetail(editionId, EDITION_DIRECTORY_INDEX)
    End Function

    Public Sub fsCreateProfileManagerOnEdition(editionId As Integer)
        Dim path As String = fsGetPathToEdition(editionId) & "\" & PROFILE_MANAGER_DIRECTORY
        If Not My.Computer.FileSystem.DirectoryExists(path) Then
            My.Computer.FileSystem.CreateDirectory(path)
        End If
    End Sub

    Public Sub fsAddProfileToEdition(profileName As String, editionId As Integer)
        Dim path As String = fsGetPathToEdition(editionId) & "\" & PROFILE_MANAGER_DIRECTORY & "\" & profileName
        If Not My.Computer.FileSystem.DirectoryExists(path) Then
            My.Computer.FileSystem.CreateDirectory(path)
        End If
    End Sub

    Public Sub fsDestructiveDeleteProfileFromEdition(profileName As String, editionId As Integer)
        Dim editionPath As String = fsGetPathToEdition(editionId)
        Dim profilePath As String = editionPath & "\" & PROFILE_MANAGER_DIRECTORY & "\" & profileName
        If My.Computer.FileSystem.DirectoryExists(profilePath) Then
            ' delete the profile from profile store
            My.Computer.FileSystem.DeleteDirectory(profilePath, FileIO.DeleteDirectoryOption.DeleteAllContents)
        End If
    End Sub

    Private Sub fsDeleteCurrentlyActiveProfile(editionPath As String)
        ' delete the current profile
        Dim currentDirInfo As System.IO.DirectoryInfo = My.Computer.FileSystem.GetDirectoryInfo(editionPath)
        For Each path In currentDirInfo.EnumerateDirectories
            If Not path.Name = PROFILE_MANAGER_DIRECTORY Then
                My.Computer.FileSystem.DeleteDirectory(path.FullName, FileIO.DeleteDirectoryOption.DeleteAllContents)
            End If
        Next
        For Each file In currentDirInfo.EnumerateFiles
            My.Computer.FileSystem.DeleteFile(file.FullName)
        Next
    End Sub

    Public Sub fsActivateProfile(profileName As String, editionId As Integer)
        Dim editionPath As String = fsGetPathToEdition(editionId)
        Dim profileManagerPath As String = editionPath & "\" & PROFILE_MANAGER_DIRECTORY
        Dim newProfilePath As String = profileManagerPath & "\" & profileName
        Dim oldProfileName As String = uiEditionDetail(editionId, EDITION_ACTIVE_PROFILE_INDEX)
        Dim oldProfilePath As String = profileManagerPath & "\" & oldProfileName
        If My.Computer.FileSystem.DirectoryExists(oldProfilePath) Then
            ' delete the prior version of the old profile
            fsDeleteProfileFromProfileStore(oldProfilePath)
            ' copy old profile to profile store
            fsCopyCurrentProfileToProfileStore(editionPath, oldProfilePath)
            fsDeleteCurrentlyActiveProfile(editionPath)
        End If
        fsCopyStoredProfileToCurrent(newProfilePath, editionPath)
        ' mark active profile name
        fsSetActiveProfileName(profileName, editionId)
    End Sub

    Public Sub fsSetActiveProfileName(profileName As String, editionId As Integer)
        Dim editionPath As String = fsGetPathToEdition(editionId)
        Dim activeProfileFullFilename As String = editionPath & "\" & PROFILE_MANAGER_DIRECTORY & "\" & ACTIVE_PROFILE_FILENAME
        If My.Computer.FileSystem.FileExists(activeProfileFullFilename) Then
            My.Computer.FileSystem.DeleteFile(activeProfileFullFilename)
        End If
        My.Computer.FileSystem.WriteAllText(activeProfileFullFilename, profileName, True)
        uiEditionDetail(editionId, EDITION_ACTIVE_PROFILE_INDEX) = profileName
    End Sub

    Public Sub fsBackupProfile(profileName As String, editionId As Integer)
        ' copy profile to backup location
        Dim profilePath As String = fsGetPathToEdition(editionId) & "\" & PROFILE_MANAGER_DIRECTORY & "\" & profileName
        If My.Computer.FileSystem.DirectoryExists(profilePath) Then
            Dim profileBackupPath As String = profilePath & "\" & BACKUP_DIRECTORY
            If My.Computer.FileSystem.DirectoryExists(profileBackupPath) Then
                ' delete the current backup of the profile
                My.Computer.FileSystem.DeleteDirectory(profileBackupPath, FileIO.DeleteDirectoryOption.DeleteAllContents)
            End If
            If uiEditionDetail(editionId, EDITION_ACTIVE_PROFILE_INDEX) = profileName Then
                ' the profile to backup is the active profile
                ' copy old profile to profile store
                fsDeleteProfileFromProfileStore(profilePath)
                fsCopyCurrentProfileToProfileStore(fsGetPathToEdition(editionId), profilePath)
            End If
            ' copy the profile in profile store to backup
            Dim profileDirInfo As System.IO.DirectoryInfo = My.Computer.FileSystem.GetDirectoryInfo(profilePath)
            For Each path In profileDirInfo.EnumerateDirectories
                If Not path.Name = BACKUP_DIRECTORY Then
                    My.Computer.FileSystem.CopyDirectory(path.FullName, profileBackupPath & "\" & path.Name)
                End If
            Next
            For Each file In profileDirInfo.EnumerateFiles
                My.Computer.FileSystem.CopyFile(file.FullName, profileBackupPath & "\" & file.Name)
            Next
        Else
            MsgBox(uiGetProfileDoesNotExistMessage(profileName, editionId), MsgBoxStyle.Exclamation)
        End If
    End Sub

    Public Sub fsRestoreProfile(profileName As String, editionId As Integer)
        ' restore profile from backup location
        Dim editionPath As String = fsGetPathToEdition(editionId)
        Dim profilePath As String = editionPath & "\" & PROFILE_MANAGER_DIRECTORY & "\" & profileName
        fsDeleteProfileFromProfileStore(profilePath)
        ' copy the backed up profile to the profile store
        Dim profileBackupDirInfo As System.IO.DirectoryInfo = My.Computer.FileSystem.GetDirectoryInfo(profilePath & "\" & BACKUP_DIRECTORY)
        For Each path In profileBackupDirInfo.EnumerateDirectories
            My.Computer.FileSystem.CopyDirectory(path.FullName, profilePath & "\" & path.Name)
        Next
        For Each file In profileBackupDirInfo.EnumerateFiles
            My.Computer.FileSystem.CopyFile(file.FullName, profilePath & "\" & file.Name)
        Next
        If profileName = uiEditionDetail(editionId, EDITION_ACTIVE_PROFILE_INDEX) Then
            ' the profile to restore is also the active profile
            fsDeleteCurrentlyActiveProfile(editionPath)
            fsCopyStoredProfileToCurrent(profilePath, editionPath)
        End If
    End Sub

    Private Sub fsDeleteProfileFromProfileStore(profilePath As String)
        ' delete the profile in the profile store
        Dim profileDirInfo As System.IO.DirectoryInfo = My.Computer.FileSystem.GetDirectoryInfo(profilePath)
        For Each path In profileDirInfo.EnumerateDirectories
            If Not path.Name = BACKUP_DIRECTORY Then
                My.Computer.FileSystem.DeleteDirectory(path.FullName, FileIO.DeleteDirectoryOption.DeleteAllContents)
            End If
        Next
        For Each file In profileDirInfo.EnumerateFiles
            My.Computer.FileSystem.DeleteFile(file.FullName)
        Next
    End Sub

    Private Sub fsCopyStoredProfileToCurrent(profilePath As String, editionPath As String)
        ' copy profile in the profile store to current profile
        Dim storedProfileDirInfo As System.IO.DirectoryInfo = My.Computer.FileSystem.GetDirectoryInfo(profilePath)
        For Each path In storedProfileDirInfo.EnumerateDirectories
            If Not path.Name = BACKUP_DIRECTORY Then
                My.Computer.FileSystem.CopyDirectory(path.FullName, editionPath & "\" & path.Name)
            End If
        Next
        For Each file In storedProfileDirInfo.EnumerateFiles
            My.Computer.FileSystem.CopyFile(file.FullName, editionPath & "\" & file.Name)
        Next
    End Sub

    Private Sub fsCopyCurrentProfileToProfileStore(editionPath As String, profilePath As String)
        ' copy the current profile to the profile store
        Dim currentDirInfo As System.IO.DirectoryInfo = My.Computer.FileSystem.GetDirectoryInfo(editionPath)
        For Each path In currentDirInfo.EnumerateDirectories
            If Not path.Name = PROFILE_MANAGER_DIRECTORY Then
                My.Computer.FileSystem.CopyDirectory(path.FullName, profilePath & "\" & path.Name)
            End If
        Next
        For Each file In currentDirInfo.EnumerateFiles
            My.Computer.FileSystem.CopyFile(file.FullName, profilePath & "\" & file.Name)
        Next
    End Sub

End Module
