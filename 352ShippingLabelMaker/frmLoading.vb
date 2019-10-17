Imports System.IO
Public Class frmLoading
    'Public configstatus As Boolean = False
    Public partStyle As String = My.Settings.partStyle
    'Public configfile As String = homeFolder & csvFile
    'Public errormessage As String = ""


    Private Sub frmLoading_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Throw New Exception("Software was restarted")

        Catch ex As Exception
            LogError(ex)
        End Try
        'lets do some cleanup on the updater files
        ' Check if the temporary backup file exists.
        If System.IO.File.Exists("~352ShippingLabelMakerUpdater.exe") = False Then
            'If Non-existant -> Do Nothing
        Else
            Try
                'Delete the old updated renamed file IF it exists. (this is no longer needed)
                My.Computer.FileSystem.DeleteFile("~352ShippingLabelMakerUpdater.exe")
            Catch ex As Exception
                LogError(ex)
                End Try
            End If


        'MsgBox(homeFolder & csvFile)

        'Dim errormessage As String = "There seems to be a problem locating the configuration file" & vbLf &
        '                    "This is caused by one of the following conditions." & vbLf & vbLf &
        '                    "1: Most Likley the network drive is down for some reason." & vbLf &
        '                    "2: Unlikley case but possible: A folder in the path has been renamed accidentally" & vbLf &
        '                    "(" & homeFolder & csvFile & ")" & vbLf & vbLf &
        '                    "Please contact Maintenance to try and resolve this issue."



        'Check if the Config file is accessable. If it is not then the network could be down.

        'Try




        '    checkforconfigfile()
        'Catch ex As Exception
        '    errormessage = ex.Message
        'End Try
        'If configstatus = True Then

        'ElseIf configstatus = False Then
        '    MessageBox.Show(errormessage)
        '    End
        'End If
        'If Not File.Exists(configfile) Then
        ' file does not exist throw a message explaining it
        'MsgBox(errormessage)
        'MessageBox.Show("There seems to be a problem locating the configuration file" & vbLf &
        '                "This is caused by one of the following conditions." & vbLf & vbLf &
        '                "1: A folder in the path has been renamed accidentally" & vbLf &
        '                "2: Unlikley case but possible: The network drive is down for some reason. (" & homeFolder & csvFile & ")" & vbLf & vbLf &
        '                "Please contact Maintenance to try and resolve this issue." & vbLf & vbLf &
        '                "Exiting Now", "Error loading configuration file", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'Me.Close()


        'load the program normally if error are not present (this should eliminate the exception errors on startup)
        'Load the correct form from Config file
        If partStyle = 1 Then
            frmArches.Show()

        ElseIf partStyle = 2 Then
            frmCladdings.Show()

        ElseIf partStyle = 3 Then
            frmRline.Show()

        Else
            Label1.Text = "Incorrect Settings in Config File" & vbLf & "See Style number setting"
            MessageBox.Show("Incorrect Settings in Config File" & vbLf & "See Style number setting" & vbLf & vbLf & "The Program will now close. If this problem continues please call Maintenance.", "Error Found in configuration file", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
        Me.Close()

        'End If



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        End

    End Sub
    Private Sub checkforconfigfile()
        '' Try
        'File.OpenRead(homeFolder & csvFile)

        '    configstatus = True

        'Catch ex As Exception

        'configstatus = False
        'errormessage = Er.message
        'Stop

        'Exit Try

        ' Finally
        '
        ' End Try
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class