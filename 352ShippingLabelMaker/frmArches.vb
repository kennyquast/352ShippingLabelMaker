'Stuff to do still
'future work : create an administraition screen that will allow reprint of barcode labels if needed and switch to 
'different type of part
'(Second printer at station? Or change labels out when needed??)
Imports System.IO

Public Class frmArches

    Public TextFileTable As DataTable = Nothing

    'possibly need to add revision level for on the fly label reprints (or possibly add to WIP label)
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            LoadDataGrid(TextFileTable)
        Catch ex As Exception
            LogError(ex)
        End Try
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
            Button1.PerformClick()
        End If
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        If TxtLookup.Text = "" Then
            ' This is a crude error handling for the search box containing nothing. it will not seem to use
            'current errorhandling partNotFound() The chances of a user clicking enter is not common with a barcode 
            'scanner So I am not too worried about this popup showing
            MsgBox("No Data Inputed", Title:="No Data Received")
            'getData()
            timerClearSearch.Enabled = True

            Exit Sub
        End If


        prevPart = currentPart
                currentPart = TxtLookup.Text
        getData()

        timerClearSearch.Enabled = True
        'MsgBox("currentPart : " & currentPart & " | TempKitNumber : " & TempKitNumber & " | TempKitNumber2 : " & TempKitNumber2)
        If TempKitNumber = currentPart Then
            CountPart()
            UpdateScreen()

        Else
            OpenNewPartScannedWindow()
            If frmNewPartScanned.DialogResult = DialogResult.Cancel Then
                ' MessageBox.Show("Cancel was pressed")


                'TempKitNumber = TempKitNumber2

                'MsgBox("PartKitNumber : " & partKitNumber1 & " | TempKitNumber : " & TempKitNumber & " | TempKitNumber2 : " & TempKitNumber2)
                timerClearSearch.Enabled = True
                currentPart = TempKitNumber2
            ElseIf frmNewPartScanned.DialogResult = DialogResult.OK Then

                'MsgBox("OK was pressed")
                TempKitNumber = currentPart
                partCount = 0 ' reset part counter after max parts reached
                CountPart()

                UpdateScreen()
            End If
        End If

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
        TxtLookup.Text = "" ' clear text box
        TxtLookup.Select() ' set the cursor in the text lookup feild
        timerClearSearch.Enabled = False
    End Sub

    Private Sub EXitToolStripMenuItem_Click(sender As Object, e As EventArgs)
        End
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox1.Show()
    End Sub

    Public Sub CountPart()
        Try
            If prevPart = currentPart Then
                partCount = partCount + 1 'count up by 1 (even I can do this)

            Else
                partCount = 1 ' reset part counter to 1 on new part scanned (mis-matched parts)
                'data = System.IO.File.ReadAllText(homeFolder & "\templates\" & labelType & ".lbl")
                skidCount = 0 ' reset the skid counter
                lblSkidCount.Text = skidCount ' reset the screen skid counter

            End If
            If partCount = partQty Then
                LabelDate = Date.Now
                generateLabel() 'pretty self explanitory, but goto the label printing method
                'MsgBox(data) ' used for testing - uncomment to bypass label print
                'Below Is to send data to printer comment out to bypass printer
                Dim pd As New PrintDialog()
                RawPrinterHelper.SendStringToPrinter(pd.PrinterSettings.PrinterName, data) ' Print first label
                RawPrinterHelper.SendStringToPrinter(pd.PrinterSettings.PrinterName, data) ' Print Second label
                DataCollection() 'Collect Data and log it in spreadsheet
                partCount = 0 ' reset part counter after max parts reached
                skidCount = skidCount + 1 'count up skids by 1 (even I can do this)

                lblSkidCount.Text = skidCount



            End If
        Catch ex As Exception
            LogError(ex)
        End Try
    End Sub
    Public Sub getData()
        'Method to scan through datagrid and select part row for usage.
        'may have to move some code to other areas eg: colour change code so we can use this
        'method for other areas of the program
        'borrow variables from claddings thats not used right now
        TempKitNumber2 = prevPart 'set the last part into holding
        prevPart = currentPart ' set the current part into holding
        Try
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
                    partQty = row.Cells("column4").Value.ToString()
                    partSeries = row.Cells("column5").Value.ToString()

                    Exit For
                End If

            Next

            If Not found Then

                PartNotFound() ' goto not found routine
                'timerClearSearch.Enabled = True
                Exit Sub
            End If
        Catch ex As Exception
            LogError(ex)
        End Try
        'CountPart()

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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles CladServiceButton.Click
        frmCladdings.Show()
        Me.Close()
    End Sub

    Private Sub ArchServiceButton_Click(sender As Object, e As EventArgs) Handles ArchServiceButton.Click
        ArchServiceButton.Visible = False
        ArchProductionButton.Visible = True
        LabelArches.Text = "SERVICE"
        Me.BackColor = Color.RoyalBlue

    End Sub

    Private Sub ArchProductionButton_Click(sender As Object, e As EventArgs) Handles ArchProductionButton.Click
        ArchServiceButton.Visible = True
        ArchProductionButton.Visible = False
        LabelArches.Text = "ARCHES"

        Me.BackColor = DefaultBackColor
    End Sub
    Private Sub UpdateScreen()

        lblPartNumber.ForeColor = Color.Black
        lblPartDescription.ForeColor = Color.Black
        lblSeries.ForeColor = Color.Black
        lblPartNumber.Text = partNumber
        lblPartDescription.Text = partName & vbLf & partColour
        lblStdPack.Text = partQty
        lblSeries.Text = partSeries
        lblPartCount.Text = partCount
    End Sub

End Class

