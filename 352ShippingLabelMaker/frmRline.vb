'Stuff to do still
'future work : create an administraition screen that will allow reprint of barcode labels if needed and switch to 
'different type of part
'(Second printer at station? Or change labels out when needed??)
Imports System.IO

Public Class frmRline
    Dim PartConfigCode As String = "V0000"
    Dim PartColourCode As String = "XXX"
    Dim PartSideCode As String = "000"
    Public TextFileTable As DataTable = Nothing

    'possibly need to add revision level for on the fly label reprints (or possibly add to WIP label)
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

        LoadDataGrid(TextFileTable)
        Me.DataGridView1.DataSource = TextFileTable
        Me.Show() 'show the form
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.Location = New Point(0, 0)
        Me.Size = SystemInformation.PrimaryMonitorSize
        TxtLookup.Select() ' set the cursor in the text lookup field
    End Sub

    Private Sub TxtLookup_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtLookup.KeyDown
        'if the user types a code and hits enter *used in barcodes as carrige return*
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            LookupPart()
        End If
    End Sub
    Private Sub LookupPart()
        If TxtLookup.Text = "" Then
            ' This is a crude error handling for the search box containing nothing. it will not seem to use
            'current errorhandling partNotFound() The chances of a user clicking enter is not common with a barcode 
            'scanner So I am not too worried about this popup showing
            MsgBox("No Data Inputed", Title:="No Data Received")
            'getData()
            timerClearSearch.Enabled = True

            Exit Sub
        Else
            prevPart = currentPart
            currentPart = TxtLookup.Text
            getData()
            'timerClearSearch.Enabled = True

        End If
        lblPartNumber.ForeColor = Color.Black
        lblPartDescription.ForeColor = Color.Black
        lblSeries.ForeColor = Color.Black
        lblPartNumber.Text = partNumber
        lblPartDescription.Text = partName & vbLf & PartColour
        lblStdPack.Text = partQty 'Temporarily show the StdPack but this will be changed manually later
        lblSeries.Text = partSeries
        TextBoxQty.Select()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        partQty = TextBoxQty.Text
        prevPart = currentPart
        currentPart = TxtLookup.Text
        getData()
        'MsgBox(partNumber & " | " & partQty)
        LabelDate = Date.Now
        generateRlineLabel() 'pretty self explanitory, but goto the label printing method
        'MsgBox(data) ' used for testing - uncomment to bypass label print
        'Below Is to send data to printer comment out to bypass printer
        Dim pd As New PrintDialog()
        RawPrinterHelper.SendStringToPrinter(pd.PrinterSettings.PrinterName, data) ' Print first label
        RawPrinterHelper.SendStringToPrinter(pd.PrinterSettings.PrinterName, data) ' Print Second label
        RlineDataCollection() 'Collect Data and log it in spreadsheet
        partCount = 0 ' reset part counter after max parts reached
        skidCount = skidCount + 1 'count up skids by 1 (even I can do this)

        lblSkidCount.Text = skidCount




        'If TxtLookup.Text = "" Then
        '    ' This is a crude error handling for the search box containing nothing. it will not seem to use
        '    'current errorhandling partNotFound() The chances of a user clicking enter is not common with a barcode 
        '    'scanner So I am not too worried about this popup showing
        '    MsgBox("No Data Inputed", Title:="No Data Received")
        '    'getData()
        '    timerClearSearch.Enabled = True

        '    Exit Sub
        'Else
        'prevPart = currentPart
        'currentPart = TxtLookup.Text
        'getData()


        timerClearSearch.Enabled = True

        'End If
        'lblPartNumber.ForeColor = Color.Black
        'lblPartDescription.ForeColor = Color.Black
        'lblSeries.ForeColor = Color.Black
        'lblPartNumber.Text = partNumber
        'lblPartDescription.Text = partName & vbLf & partColour
        lblStdPack.Text = partQty
        'lblSeries.Text = partSeries
        'lblPartCount.Text = partCount
    End Sub
    Public Sub generateRlineLabel()
        'Simple way to load data from "text" file and fill in contents to be used for generating label 
        'From existing IPL template
        data = System.IO.File.ReadAllText(homeFolder & "\templates\" & labelType & ".lbl") ' reset the template
        data = data.Replace("%Date%", Date.Now)
        data = data.Replace("%PartNumber%", currentPart)
        data = data.Replace("%Quantity%", TextBoxQty.Text)
        data = data.Replace("%Series%", partSeries)
        data = data.Replace("%Description%", partName)
        data = data.Replace("%PartColour%", partColour)
        data = data.Replace("%Cell%", cellName)
        data = data.Replace("%Date%", Date.Now)


    End Sub
    Public Sub RlineDataCollection()
        'Demonstrating Data Logging
        Dim filePath As String = String.Format(logFile & "\{0}-{1}.csv", DateTime.Today.ToString("MMM-dd-yyyy"), cellName)

        Dim fileExists As Boolean = File.Exists(filePath)

        Using writer As New StreamWriter(filePath, True)
            If Not fileExists Then
                writer.WriteLine("Cell,Part Number,Description,Quantity,Series Level,Time Label created")
            End If
            writer.WriteLine(cellName & "," & currentPart & "," & partName & " - " & partColour & "," & TextBoxQty.Text & "," & partSeries & "," & Date.Now)
        End Using
    End Sub

    Public Sub PartNotFound()
        lblPartNumber.ForeColor = Color.Red
        lblPartDescription.ForeColor = Color.Red
        lblSeries.ForeColor = Color.Red
        partNumber = TxtLookup.Text
        partName = "Part Not Found in Database"
        partSeries = "Part Not Found in Database"

    End Sub

    Public Sub timerClearSearch_Tick(sender As Object, e As EventArgs) Handles timerClearSearch.Tick
        'TxtLookup.Text = "" ' clear text box
        'TextBoxQty.Text = "" ' Clear the Qty Box
        TxtLookup.Select() ' set the cursor in the text lookup feild
        CboColour.SelectedIndex = -1
        CboConfig.SelectedIndex = -1
        CboSide.SelectedIndex = -1
        TxtLookup.Text = "" ' clear text box
        TextBoxQty.Text = "" ' Clear the Qty Box
        timerClearSearch.Enabled = False
    End Sub

    Private Sub EXitToolStripMenuItem_Click(sender As Object, e As EventArgs)
        End
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox1.Show()
    End Sub

    Public Sub CountPart()

        If prevPart = currentPart Then
            partCount = partCount + 1 'count up by 1 (even I can do this)

        Else
            partCount = 1 ' reset part counter to 1 on new part scanned (mis-matched parts)
            data = System.IO.File.ReadAllText(homeFolder & "\templates\" & labelType & ".lbl")
            skidCount = 0 ' reset the skid counter
            lblSkidCount.Text = skidCount ' reset the screen skid counter

        End If
        'If partCount = partQty Then
        '    LabelDate = Date.Now
        '    generateLabel() 'pretty self explanitory, but goto the label printing method
        '    MsgBox(data) ' used for testing - uncomment to bypass label print
        '    'Below Is to send data to printer comment out to bypass printer
        '    'Dim pd As New PrintDialog()
        '    'RawPrinterHelper.SendStringToPrinter(pd.PrinterSettings.PrinterName, data) ' Print first label
        '    'RawPrinterHelper.SendStringToPrinter(pd.PrinterSettings.PrinterName, data) ' Print Second label
        '    DataCollection() 'Collect Data and log it in spreadsheet
        '    partCount = 0 ' reset part counter after max parts reached
        '    skidCount = skidCount + 1 'count up skids by 1 (even I can do this)

        '    lblSkidCount.Text = skidCount



        'End If

    End Sub
    Public Sub getData()
        'Method to scan through datagrid and select part row for usage.
        'may have to move some code to other areas eg: colour change code so we can use this
        'method for other areas of the program

        Dim rowindex As String
        Dim found As Boolean = False
        For Each row As DataGridViewRow In DataGridView1.Rows
            'scan each row of the datagrid to match part scanned if found, load values into memory.
            If row.Cells.Item("Column0").Value = TxtLookup.Text Then
                rowindex = row.Index.ToString()
                found = True
                partNumber = row.Cells("column0").Value.ToString()
                partKitNumber = row.Cells("column1").Value.ToString()
                partName = row.Cells("column2").Value.ToString()
                partColour = row.Cells("column3").Value.ToString()
                partQty = row.Cells("column4").Value.ToString() ' Temporarily grab the StdPack but this will be changed manually later
                partSeries = row.Cells("column5").Value.ToString()

                Exit For
            End If

        Next

        If Not found Then

            PartNotFound() ' goto not found routine
            timerClearSearch.Enabled = True
            Exit Sub
        End If

        CountPart()

    End Sub
    Private Sub ExitToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub btnShiftReset_Click(sender As Object, e As EventArgs) Handles btnShiftReset.Click
        skidCount = 0
        lblSkidCount.Text = skidCount
    End Sub

    Private Sub AdminToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdminToolStripMenuItem.Click
        AdminLogin.Show()
    End Sub

    Private Sub TmrClock_Tick(sender As Object, e As EventArgs) Handles TmrClock.Tick
        LblClock.Text = Format(Now, "hh:mm:ss")
    End Sub


    Private Sub TextBoxQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxQty.KeyPress

        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub TextBoxQty_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxQty.KeyDown
        'if the user types a code and hits enter *used in barcodes as carrige return*
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            Button1.PerformClick()

        End If

    End Sub

    Private Sub CboConfig_DropDownClosed(sender As Object, e As EventArgs) Handles CboConfig.DropDownClosed
        'Figure out what the person selected
        If CboConfig.SelectedItem = "Front" Then
            PartConfigCode = "V0020"
            TxtLookup.Text = PartConfigCode & "-" & PartSideCode & "-" & PartColourCode 'Update the part Number
        End If
        If CboConfig.SelectedItem = "Rear" Then
            PartConfigCode = "V0023"
            TxtLookup.Text = PartConfigCode & "-" & PartSideCode & "-" & PartColourCode 'Update the part Number
        End If

    End Sub

    Private Sub CboSide_DropDownClosed(sender As Object, e As EventArgs) Handles CboSide.DropDownClosed
        'Figure out what the person selected
        If CboSide.SelectedItem = "Left" Then
            PartSideCode = "100"
            TxtLookup.Text = PartConfigCode & "-" & PartSideCode & "-" & PartColourCode 'Update the part Number
        End If
        If CboSide.SelectedItem = "Right" Then
            PartSideCode = "200"
            TxtLookup.Text = PartConfigCode & "-" & PartSideCode & "-" & PartColourCode 'Update the part Number
        End If

    End Sub

    Private Sub CboColour_DropDownClosed(sender As Object, e As EventArgs) Handles CboColour.DropDownClosed
        'Figure out what the person selected
        If CboColour.SelectedItem = "Left" Then
            PartSideCode = "100"
            TxtLookup.Text = PartConfigCode & "-" & PartSideCode & "-" & PartColourCode 'Update the part Number
        End If
        If CboSide.SelectedItem = "Right" Then
            PartSideCode = "200"
            TxtLookup.Text = PartConfigCode & "-" & PartSideCode & "-" & PartColourCode 'Update the part Number
        End If
    End Sub

    Private Sub CboColour_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboColour.SelectedIndexChanged
        'Figure out what the user selected for Colour. Chooses the colour based off the Index of the text list.
        'Does that make sence? line 1 is index 0, Line 2 is Index 1 and so forth.
        'If you dont like the way indexes work invent a time machine and go back to invent the PC before anyone else does.

        'TITANIUM BEIGE - (A1X)
        'FORTANA RED - (B3Z)
        'KURKUMA MET - (R1X)
        'REFLEX SILVER - (A7W)
        'PURE WHITE - (C9A)
        'DEEP BLACK PEARL - (C9X)
        'TOURMALINE BLUE - (P5Y)
        'PLATINUM GRAY - (D7X)
        'HUNTING BROWN - (A8U)
        'PRIME - (GRU)
        Select Case CboColour.SelectedIndex
            Case 0
                PartColourCode = "A1X"
            Case 1
                PartColourCode = "B3Z"
            Case 2
                PartColourCode = "R1X"
            Case 3
                PartColourCode = "A7W"
            Case 4
                PartColourCode = "C9A"
            Case 5
                PartColourCode = "C9X"
            Case 6
                PartColourCode = "P5Y"
            Case 7
                PartColourCode = "D7X"
            Case 8
                PartColourCode = "A8U"
            Case 9
                PartColourCode = "GRU"
            Case Else
                'MsgBox("Incorrect Part was Choosen. Please notify maintenance of this error.")
        End Select
        TxtLookup.Text = PartConfigCode & "-" & PartSideCode & "-" & PartColourCode 'Update the part Number
        LookupPart()

        TextBoxQty.Focus()
    End Sub
End Class

