
Imports System.IO
Imports System.Reflection
Public Class FormAdminControlPanel

    'below formats the filename for data collection eg:  R:\Maintenance\352ShippingLabelMaker\logs\Jan-01-2018-Arches.csv
    Dim AdminFileName As String = logFile & "\" & DateTime.Today.ToString("MMM-dd-yyyy") & "-" & cellName & ".csv"
    Dim AdminFileTable As DataTable = Nothing
    Public VersionInfo As String

    Private Sub AdminControlPanel_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not System.IO.File.Exists(AdminFileName) Then
            ' file does not exist throw a message explaining it

            MessageBox.Show("There seems to be no data for the log file." & vbLf &
                            "This is caused by one of the following conditions." & vbLf & vbLf &
                            "1: Most Likley you have entered this page after Midnight or before any labels have been created for todays date" & vbLf & vbLf &
                            "2: There could be network issues, if you see this error repeatedly call Maintenance to troubleshoot network issues" & vbLf & vbLf &
                            "I Will try to recreate the logfile now", "Error loading Log File", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'Try to create a blank file for future use, this is only used if NO LABELS have been printed yet today
            Dim filePath As String = String.Format(logFile & "\{0}-{1}.csv", DateTime.Today.ToString("MMM-dd-yyyy"), cellName)

            Dim fileExists As Boolean = File.Exists(filePath)

            Using writer As New StreamWriter(filePath, True)
                If Not fileExists Then
                    writer.WriteLine("Cell,Part Number,Description,Quantity,Series Level,Time Label created")
                End If
                'line below is only used in data Collection to store a part created ignore it for now
                ' writer.WriteLine(cellName & "," & currentPart & "," & partName & " - " & partColour & "," & partQty & "," & partSeries & "," & Date.Now)
            End Using

        End If


        LoadAdminGrid(AdminFileTable)
        Me.AdminProductionGrid.DataSource = AdminFileTable

        LblInformation.Text = "User: " & adminName & vbLf
        LblInformation.Text = LblInformation.Text & "Cell : " & cellName & vbLf

        If Application.OpenForms().OfType(Of frmCladdings).Any Then

            BtnReprintCladding.Enabled = True


        ElseIf Application.OpenForms().OfType(Of frmArches).Any Then
            BtnReprintArch.Enabled = True

        ElseIf Application.OpenForms().OfType(Of frmRline).Any Then

            BtnReprintRline.Enabled = True
            BtnRelabelRline.Enabled = True

        Else
            MsgBox("Error in Configuration, Check Cell Name setting.")
        End If
        'Below is code to enable some buttons only visible to myself for testing / debugging features
        If adminUserName = "kquast" Then
            BtnKennySecret.Visible = True
            BtnUpdateSoftware.Visible = True
            BtnAddUser.Visible = True
        End If
        'If adminUserName = "kquast" Then

        'End If
        Exit Sub

    End Sub


    Private Sub LoadAdminGrid(ByRef AdminFileTable)
        'Load the CSV file to a workable datagridview which is hidden on screen because we do not need to view the data
        'just need to access it

        Dim AdminFileReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(AdminFileName)
        'Dim TextFileTable As DataTable = Nothing
        AdminFileReader.TextFieldType = FileIO.FieldType.Delimited
        AdminFileReader.SetDelimiters(",")

        Dim Column As DataColumn
        Dim Row As DataRow
        Dim UpperBound As Int32
        Dim ColumnCount As Int32
        Dim CurrentRow As String()

        While Not AdminFileReader.EndOfData
            Try
                CurrentRow = AdminFileReader.ReadFields()
                If Not CurrentRow Is Nothing Then
                    ''# Check if DataTable has been created
                    If AdminFileTable Is Nothing Then
                        AdminFileTable = New DataTable("AdminFileTable")
                        ''# Get number of columns
                        UpperBound = CurrentRow.GetUpperBound(0)
                        ''# Create new DataTable
                        For ColumnCount = 0 To UpperBound
                            Column = New DataColumn()
                            Column.DataType = System.Type.GetType("System.String")
                            Column.ColumnName = "Column" & ColumnCount
                            Column.Caption = "Column" & ColumnCount
                            Column.ReadOnly = True
                            Column.Unique = False
                            AdminFileTable.Columns.Add(Column)
                        Next
                    End If
                    Row = AdminFileTable.NewRow
                    For ColumnCount = 0 To UpperBound
                        Row("Column" & ColumnCount) = CurrentRow(ColumnCount).ToString
                    Next
                    AdminFileTable.Rows.Add(Row)
                End If
            Catch ex As _
                Microsoft.VisualBasic.FileIO.MalformedLineException
                MsgBox("Line " & ex.Message &
                    "is not valid and will be skipped.")
            End Try
        End While
        AdminFileReader.Dispose()
        Return
    End Sub

    Private Sub BtnReprintArch_Click(sender As Object, e As EventArgs) Handles BtnReprintArch.Click
        'This is for reprinting the last Arch Label it will NOT production report.
        Dim pd As New PrintDialog()
        RawPrinterHelper.SendStringToPrinter(pd.PrinterSettings.PrinterName, data) ' Print first label
        RawPrinterHelper.SendStringToPrinter(pd.PrinterSettings.PrinterName, data) ' Print Second label
    End Sub

    Private Sub BtnReprintCladding_Click(sender As Object, e As EventArgs) Handles BtnReprintCladding.Click
        'This is for reprinting the last Cladding Label it will NOT production report.
        Dim pd As New PrintDialog()
        RawPrinterHelper.SendStringToPrinter(pd.PrinterSettings.PrinterName, frmCladdings.data1) ' Print first label
        RawPrinterHelper.SendStringToPrinter(pd.PrinterSettings.PrinterName, frmCladdings.data1) ' Print Second label
    End Sub

    Private Sub BtnReprintRline_Click(sender As Object, e As EventArgs) Handles BtnReprintRline.Click
        'This is for reprinting the last Rline Label it will NOT production report.
        Dim pd As New PrintDialog()
        RawPrinterHelper.SendStringToPrinter(pd.PrinterSettings.PrinterName, data) ' Print first label
        RawPrinterHelper.SendStringToPrinter(pd.PrinterSettings.PrinterName, data) ' Print Second label
    End Sub


    Private Sub BtnPartLabel_Click(sender As Object, e As EventArgs) Handles BtnPartLabel.Click
        Me.TopMost = False
        PartLabel.Show()
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub BtnUpdateSoftware_Click(sender As Object, e As EventArgs) Handles BtnUpdateSoftware.Click
        'Check if current version = version on server
        GetCurrentVersion()
        'Check if Current running version matches server version
        If VersionInfo = Application.ProductVersion Then
            MessageBox.Show("The software is currently up to date and doesn't require an upgrade", "Current Software is already insatlled", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            Select Case MessageBox.Show("The software requires an update." & vbLf &
                            "Would you like to update the software now?", "Software Update Required", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                Case MsgBoxResult.Yes
                    'exit the program and update the files via the updater program

                    'copy/rename the updater file so it can be updated IF there is any checnged to the updater file itself.
                    My.Computer.FileSystem.CopyFile("352ShippingLabelMakerUpdater.exe", "~352ShippingLabelMakerUpdater.exe")
                    'build a command
                    'Upon Startup of this software it will check if ~352ShippingLabelMakerUpdater.exe and delete if required
                    Dim startInfo As New ProcessStartInfo
                    startInfo.FileName = "~352ShippingLabelMakerUpdater.exe"
                    'tell the updater app where the server home folder is (accordign to this softwares configuration.
                    startInfo.Arguments = homeFolder
                    'Run the Updater and close this software for updating.
                    Process.Start(startInfo)
                    Application.Exit()
                    End
                Case MsgBoxResult.No
                    MessageBox.Show("For proper fuctionality the software should be updated to the correct version. This only takes a couple seconds", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Select
        End If




    End Sub
    Private Sub GetCurrentVersion()

        'read a file that contains the most current version info from the server
        Dim lines() As String = IO.File.ReadAllLines(homeFolder & "\currentversion.txt")
        VersionInfo = lines(0)

    End Sub

    Private Sub BtnKennySecret_Click(sender As Object, e As EventArgs) Handles BtnKennySecret.Click

    End Sub

    Private Sub BtnAddUser_Click(sender As Object, e As EventArgs) Handles BtnAddUser.Click
        LblClockNumber.Visible = True
        LblUsername.Visible = True
        LblFullName.Visible = True
        TxtFullName.Visible = True
        TxtClockNumber.Visible = True
        TxtUsername.Visible = True
        BtnAddUserSubmit.Visible = True
        TxtClockNumber.Text = ""
        TxtUsername.Text = ""
        TxtFullName.Text = ""

    End Sub


    Private Sub BtnAddUserSubmit_Click(sender As Object, e As EventArgs) Handles BtnAddUserSubmit.Click
        Dim filePath As String = String.Format(homeFolder & "\admin\admin.csv")

        Dim fileExists As Boolean = File.Exists(filePath)

        Using writer As New StreamWriter(filePath, True)
            'if for some reason this file doesnt exist, it will create a blank dummy file
            'so the application doesnt throw an error
            'Future could have the code in an if else statment to crate the username, but
            'doen this way due to production running and not able to test the non admin file part

            If Not fileExists Then
                writer.WriteLine("Login Code,username,Full Name")
            End If
            writer.WriteLine(TxtClockNumber.Text & "," & TxtUsername.Text & "," & TxtFullName.Text)
        End Using
        LblClockNumber.Visible = False
        LblUsername.Visible = False
        LblFullName.Visible = False
        TxtFullName.Visible = False
        TxtClockNumber.Visible = False
        TxtUsername.Visible = False


        BtnAddUserSubmit.Visible = False
    End Sub

    Private Sub BtnRelabelRline_Click(sender As Object, e As EventArgs) Handles BtnRelabelRline.Click
        RlineRelabel.Show()
    End Sub
End Class