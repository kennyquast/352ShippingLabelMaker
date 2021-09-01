'Stuff to do still
'LOTS

'need to access getdata() from other forma nd see if it'll scan

'future work : create an administraition screen that will allow reprint of barcode labels if needed 
'(Second printer at station? Or change labels out when needd??)
'
Imports System.IO
Public Class frmCladdings
    Public prevPart As String = "" ' last part scanned
    Public currentPart As String 'current part scanned
    Public CladdingNumber1 As String ' part number from CSV
    Public CladdingNumber2 As String ' part number from CSV

    Public partKitNumber1 As String ' kit number from CSV file (used for Unique identifier for cladding sets) 
    Public partKitNumber2 As String ' kit number from CSV file (used for Unique identifier for cladding sets) 
    'PartKitNumber is located in Common.vb
    Public partName1 As String ' part name from CSV
    Public partName2 As String ' part name from CSV
    Public partColour1 As String ' part colour from CSV file
    Public partColour2 As String ' part colour from CSV file
    Public partQty As Integer ' Standard pack from CSV
    Public partQty1 As Integer ' Standard pack from CSV
    Public partQty2 As Integer ' Standard pack from CSV
    Public partCount As Integer = 0 ' Current part count
    Public partSeries As String ' part kanban from CSV (may not use this)
    Public partSeries1 As String ' part kanban from CSV (may not use this)
    Public partSeries2 As String ' part kanban from CSV (may not use this)
    Public data1 As String = System.IO.File.ReadAllText(homeFolder & "\templates\" & labelType & "-CLADDING.lbl")
    'Public data2 As String = System.IO.File.ReadAllText(homeFolder & "\templates\" & labelType & "-CLADDING.lbl")
    Public TextFileTable As DataTable = Nothing
    Public serial1 As String = "Initilize1"
    Public serial2 As String = "Initilize2"
    Public lastSerial1 As String
    Public lastSerial2 As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            LoadDataGrid(TextFileTable)
            Me.DataGridView1.DataSource = TextFileTable
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            LogError(ex)
            End
            Exit Try

        Finally

        End Try

        Me.Show() 'show the form
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.Location = New Point(0, 0)
        Me.Size = SystemInformation.PrimaryMonitorSize
        txtLookup1.Select() ' set the cursor in the text lookup feild
    End Sub

    Private Sub EXitToolStripMenuItem_Click(sender As Object, e As EventArgs)
        End
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox1.Show()

    End Sub
    Private Sub TxtLookup1_KeyDown(sender As Object, e As KeyEventArgs) Handles txtLookup1.KeyDown
        'if the user types a code and hits enter *used in barcodes as carrige return*

        If e.KeyCode = Keys.Enter Then

            e.SuppressKeyPress = True

            getCladding1()

            If TempKitNumber = partKitNumber1 Then
                lblPartNumber1.Text = CladdingNumber1
                lblPartDescription.Text = partName1 & " - " & partColour1
                lblPartNumber2.Text = ""
                lblKitNumber.Text = ""
                txtLookup2.Select()
            Else 'MsgBox("PartKitNumber : " & partKitNumber1 & " | TempKitNumber : " & TempKitNumber & " | TempKitNumber2 : " & TempKitNumber2)
                OpenNewPartScannedWindow()

                If frmNewPartScanned.DialogResult = DialogResult.Cancel Then
                    'MessageBox.Show("Cancel was pressed")


                    'TempKitNumber = TempKitNumber2

                    'MsgBox("PartKitNumber : " & partKitNumber1 & " | TempKitNumber : " & TempKitNumber & " | TempKitNumber2 : " & TempKitNumber2)
                    timerClearSearch.Enabled = True
                    partKitNumber1 = TempKitNumber2
                ElseIf frmNewPartScanned.DialogResult = DialogResult.OK Then
                    lblPartNumber1.Text = CladdingNumber1
                    lblPartDescription.Text = partName1 & " - " & partColour1
                    lblPartNumber2.Text = ""
                    lblKitNumber.Text = ""
                    txtLookup2.Focus()
                End If
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If txtLookup1.Text = "" Or txtLookup2.Text = "" Then
            'Try
            '    Throw New Exception("Same part scanned twice : " & txtLookup1.Text & " & " & txtLookup2.Text)
            'Catch ex As Exception
            '    LogError(ex)
            'End Try
            ' This is a crude error handling for the search box containing nothing. it will not seem to use
            'current errorhandling partNotFound() The chances of a user clicking enter is not common with a barcode 
            'scanner So I am not too worried about this popup showing
            MsgBox("Incomplete Data Inputed", Title:="Incomplete Data Received")
            'getData()
            timerClearSearch.Enabled = True

            Exit Sub
        Else
            'currentPart = TxtLookup.Text
            getCladding2()
            If validatedPart = True Then

                CountCladding()
            Else
            End If

            ' lblPartNumber1.Text = CladdingNumber1
            lblPartNumber2.Text = CladdingNumber2

            lblPartDescription.Text = lblPartDescription.Text & vbLf & partName2 & " - " & partColour2
            'MsgBox(CladdingNumber1 & vbLf &
            '    partKitNumber & vbLf &
            '    partName1 & vbLf &
            '    partColour1 & vbLf &
            '    partQty1 & vbLf &
            '    partSeries1 & vbLf & "____________________________________" & vbLf &
            '    CladdingNumber2 & vbLf &
            '    partKitNumber & vbLf &
            '    partName2 & vbLf &
            '    partColour2 & vbLf &
            '    partQty2 & vbLf &
            '    partSeries2 & vbLf)
        End If
        'lblPartNumber1.Text = partNumber
        'lblPartDescription.Text = partName & vbLf & partColour
        lblStdPack.Text = partQty
        lblSeries.Text = partSeries
        lblPartCount.Text = partCount



        timerClearSearch.Enabled = True
    End Sub

    Private Sub ExitToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub AdminToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdminToolStripMenuItem.Click
        AdminLogin.Show()
    End Sub

    Private Sub TxtLookup2_KeyDown(sender As Object, e As KeyEventArgs) Handles txtLookup2.KeyDown
        'if the user types a code and hits enter *used in barcodes as carrige return*
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            Button1.PerformClick()
        End If
    End Sub
    Public Sub getCladding1()
        Try
            'Method to scan through datagrid and select part row for usage.
            'may have to move some code to other areas eg: colour change code so we can use this
            'method for other areas of the program
            TempKitNumber2 = TempKitNumber
            TempKitNumber = partKitNumber1
            'MessageBox.Show("XxX PartKitNumber : " & partKitNumber1 & " | TempKitNumber : " & TempKitNumber & " | TempKitNumber2 : " & TempKitNumber2)
            ''extract part number and serial from barcode.
            Dim str As String = txtLookup1.Text
            Dim str2() As String = Split(str, ",") ' split the barcode at the comma and create an array
            'load the last serial number into memory so the same label cannot be scanned twice in a row.
            lastSerial1 = serial1
            serial1 = str2(1) ' set the seraial number from the barode / array
            Dim part1 As String = str2(0)


            Dim rowindex As String = "0"
            Dim found As Boolean = False
            For Each row As DataGridViewRow In DataGridView1.Rows
                'scan each row of the datagrid to match part scanned if found, load values into memory.
                If row.Cells.Item("Column0").Value = part1 Then
                    rowindex = row.Index.ToString()
                    found = True
                    CladdingNumber1 = row.Cells("column0").Value.ToString()
                    partKitNumber1 = row.Cells("column1").Value.ToString()
                    partName1 = row.Cells("column2").Value.ToString()
                    partColour1 = row.Cells("column3").Value.ToString()
                    partQty1 = row.Cells("column4").Value.ToString()
                    partSeries1 = row.Cells("column5").Value.ToString()
                    MessageBox.Show("|Part Number: " + str2(0) + "|Current Serial: " + serial1 + "|Last Serial Number: " + lastSerial1)
                    Exit For

                End If

            Next
            'Reset colours incase of previous error scanning
            lblPartDescription.ForeColor = Color.Black
            lblPartNumber1.ForeColor = Color.Black
            lblPartDescription.ForeColor = Color.Black
            lblKitNumber.ForeColor = Color.Black
            lblStdPack.ForeColor = Color.Black
            If Not found Then
                CladdingNotFound1() ' goto not found routine
                timerClearSearch.Enabled = True
                Exit Sub
            End If

        Catch ex As Exception
            LogError(ex)
        End Try

        ' CountCladding()
    End Sub
    Public Sub getCladding2()
        Try
            'Method to scan through datagrid and select part row for usage.
            'may have to move some code to other areas eg: colour change code so we can use this
            'method for other areas of the program
            Dim rowindex As String
            Dim found As Boolean = False
            Dim str As String = txtLookup2.Text
            Dim str2() As String = Split(str, ",") ' split the barcode at the comma and create an array
            'load the last serial number into memory so the same label cannot be scanned twice in a row.
            lastSerial2 = serial2
            serial2 = str2(1) ' set the seraial number from the barode / array
            Dim part2 As String = str2(0)

            For Each row As DataGridViewRow In DataGridView1.Rows
                'scan each row of the datagrid to match part scanned if found, load values into memory.
                If row.Cells.Item("Column0").Value = part2 Then
                    rowindex = row.Index.ToString()
                    found = True
                    CladdingNumber2 = row.Cells("column0").Value.ToString()
                    partKitNumber2 = row.Cells("column1").Value.ToString()
                    partName2 = row.Cells("column2").Value.ToString()
                    partColour2 = row.Cells("column3").Value.ToString()
                    partQty2 = row.Cells("column4").Value.ToString()
                    partSeries2 = row.Cells("column5").Value.ToString()
                    MessageBox.Show("|Part Number: " + str2(0) + "|Current Serial: " + serial2 + "|Last Serial Number: " + lastSerial2)
                    Exit For
                End If

            Next

            ' Validate the part, and get the current part number to send back to the button click
            ' to count the parts correctly.
            validateMatch()

            'Reset colours incase of previous error scanning
            lblSeries.ForeColor = Color.Black
            lblPartNumber2.ForeColor = Color.Black
            lblPartDescription.ForeColor = Color.Black
            lblKitNumber.ForeColor = Color.Black
            If Not found Then
                CladdingNotFound2() ' goto not found routine
                Exit Sub
            End If

        Catch ex As Exception
            LogError(ex)
        End Try
        'CountCladding()
    End Sub
    Public Sub CountCladding()
        Try
            If validatedPart = True Then
                If prevPart = currentPart Then
                    partCount = partCount + 1 'count up by 1 (even I can do this)
                    validatedPart = False
                Else

                    partCount = 1 ' reset part counter to 1 on new part scanned (mis-matched parts)
                    'data1 = System.IO.File.ReadAllText(homeFolder & "\templates\" & labelType & "-CLADDING.lbl")
                    'data2 = System.IO.File.ReadAllText(homeFolder & "\templates\" & labelType & "-CLADDING.lbl")
                    skidCount = 0 ' reset the skid counter
                    lblSkidCount.Text = skidCount ' reset the screen skid counter

                End If
                If partCount = partQty Then
                    generateCladdingLabel() 'pretty self explanitory, but goto the label printing method
                    CladdingDataCollection() 'Collect Data and log it in spreadsheet
                    'MsgBox(data1) ' used for testing - uncomment to bypass label print
                    'Below is to send data to printer comment out to bypass printer
                    Dim pd As New PrintDialog()
                    RawPrinterHelper.SendStringToPrinter(pd.PrinterSettings.PrinterName, data1)
                    RawPrinterHelper.SendStringToPrinter(pd.PrinterSettings.PrinterName, data1)
                    partCount = 0 ' reset part counter after max parts reached
                    skidCount = skidCount + 1 'count up skids by 1 (even I can do this)
                    lblSkidCount.Text = skidCount ' Update Display


                End If
            End If
        Catch ex As Exception
            LogError(ex)
        End Try
    End Sub

    Public Sub CladdingNotFound1()
        Try
            Throw New Exception("Cladding # 1 not found : " & txtLookup1.Text)
        Catch ex As Exception
            LogError(ex)
        End Try
        lblPartNumber1.ForeColor = Color.Red
        lblPartDescription.ForeColor = Color.Red
        lblSeries.ForeColor = Color.Red
        CladdingNumber1 = txtLookup1.Text
        partKitNumber = "Part Not Found in Database"
        partName1 = "Part Not Found in Database"
        partSeries1 = "Part Not Found in Database"
        validatedPart = False
    End Sub
    Public Sub CladdingNotFound2()
        Try
            Throw New Exception("Cladding # 2 not found : " & txtLookup2.Text)
        Catch ex As Exception
            LogError(ex)
        End Try
        lblPartNumber2.ForeColor = Color.Red
        lblPartDescription.ForeColor = Color.Red
        lblKitNumber.ForeColor = Color.Red
        CladdingNumber2 = txtLookup2.Text
        partKitNumber = "Part Not Found in Database"
        partName2 = "Part Not Found in Database"
        partKitNumber = "Part Not Found in Database"
        validatedPart = False
    End Sub

    Private Sub timerClearSearch_Tick(sender As Object, e As EventArgs) Handles timerClearSearch.Tick
        txtLookup1.Text = "" ' clear text box
        txtLookup2.Text = "" ' clear text box
        txtLookup1.Select() ' set the cursor in the first text lookup feild
        timerClearSearch.Enabled = False
    End Sub
    Public Sub validateMatch()

        'Check to see if the claddings scanned were the same
        Try
            If CladdingNumber1 = CladdingNumber2 Then
                OpenSamePartScannedWindow()
                lblPartDescription.ForeColor = Color.Red
                lblPartDescription.Text = "          Same part scanned Twice          " & vbLf & "          Please re-scan both parts          "
                validatedPart = False
                Exit Sub
            Else
                'Validate the parts have the same Series number 
                '(can't remember why) I found this code a couple years after programmig,
                'I will update when i remember why it was there
                'It appears to be a simple validation to make sure we have the 
                'correct Series level on the label
                Try
                    If partSeries1 = partSeries2 Then
                        partSeries = partSeries1
                        lblSeries.Text = partSeries


                    Else
                        'Throw an error if the series don't match 
                        '(this would be a datafile error)
                        lblSeries.ForeColor = Color.Red
                        lblSeries.Text = "ERROR PLEASE NOTIFY MAINTENANCE"
                        validatedPart = False

                    End If
                Catch ex As Exception
                    LogError(ex)
                End Try
                'Checks if the two parts scanned have the same kit number to validate
                'the parts match.
                Try
                    If partKitNumber1 = partKitNumber2 Then
                        prevPart = currentPart
                        currentPart = partKitNumber1
                        validatedPart = True
                        lblKitNumber.Text = currentPart

                    Else
                        'If the parts do not match throw an error
                        'POP UP THE WARNING WINOW
                        OpenSamePartScannedWindow()
                        lblKitNumber.ForeColor = Color.Red
                        lblKitNumber.Text = "ERROR PLEASE NOTIFY MAINTENANCE"
                        validatedPart = False

                    End If
                Catch ex As Exception
                    LogError(ex)
                End Try
                'Just checking the database to make sure STD PACK matches
                Try
                    If partQty1 = partQty2 Then
                        partQty = partQty1
                        lblStdPack.Text = partQty
                    Else
                        'If not throw an error as usual
                        lblStdPack.ForeColor = Color.Red
                        lblStdPack.Text = "ERROR PLEASE NOTIFY MAINTENANCE"
                        validatedPart = False
                    End If
                Catch ex As Exception
                    LogError(ex)
                End Try

            End If
        Catch ex As Exception
            LogError(ex)
        End Try
    End Sub
    Public Sub validateSerial()
        Try
            If lastSerial1 = serial1 Then
                MessageBox.Show("Serial # 1 matches")
            Else
                MessageBox.Show("Serial # 1 Does Not Match")

            End If
            If lastSerial2 = serial2 Then
                MessageBox.Show("Serial # 2 matches")
            Else
                MessageBox.Show("Serial # 2 Does Not Match")
            End If
        Catch ex As Exception
            LogError(ex)
        End Try

    End Sub
    Public Sub generateCladdingLabel()
        Try
            'Simple way to load data from "text" file and fill in contents to be used for generating label 
            'From existing IPL template
            'Dim data As String = System.IO.File.ReadAllText("R:\VWLabels\templates\WIP.lbl")
            'part1
            ''data1 = "" ' try to clear the previous label template to try and eliminate the IO error 




            data1 = System.IO.File.ReadAllText(homeFolder & "\templates\" & labelType & "-CLADDING.lbl") 'reset the template

            data1 = data1.Replace("%PartNumber%", partKitNumber1)
            data1 = data1.Replace("%Quantity%", partQty1)
            data1 = data1.Replace("%Series%", partSeries1)
            data1 = data1.Replace("%Description%", partName1)
            data1 = data1.Replace("%Description2%", partName2)
            data1 = data1.Replace("%PartColour%", partColour1)
            data1 = data1.Replace("%Cell%", cellName)
            data1 = data1.Replace("%Date%", Date.Now)
        Catch ex As Exception
            LogError(ex)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        frmArches.Show()
        Me.Hide()
    End Sub

    Private Sub btnShiftReset_Click(sender As Object, e As EventArgs) Handles btnShiftReset.Click
        skidCount = 0
        lblSkidCount.Text = skidCount
    End Sub
    Public Sub CladdingDataCollection()
        Try


            'Demonstrating Data Logging
            Dim filePath As String = String.Format(logFile & "\{0}-{1}.csv", DateTime.Today.ToString("MMM-dd-yyyy"), cellName)

            Dim fileExists As Boolean = File.Exists(filePath)

            Using writer As New StreamWriter(filePath, True)
                If Not fileExists Then
                    writer.WriteLine("Cell,Kit Number,Description,Quantity,Series Level,Time Label created")
                End If
                writer.WriteLine(cellName & "," & partKitNumber1 & "," & partName1 & " & " & partName2 & " - " & partColour1 & "," & partQty1 & "," & partSeries1 & "," & Date.Now)
            End Using
        Catch ex As Exception
            LogError(ex)
        End Try
    End Sub

    Private Sub TmrClock_Tick(sender As Object, e As EventArgs) Handles TmrClock.Tick
        LblClock.Text = Format(Now, "hh:mm:ss")


    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        frmArches.Show()
        frmArches.LabelArches.Text = "SERVICE"
        frmArches.CladServiceButton.Visible = True
        frmArches.BackColor = Color.RoyalBlue
        frmArches.ArchServiceButton.Visible = False
        frmArches.ArchProductionButton.Visible = False

        Me.Close()
    End Sub

End Class



