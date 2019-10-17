Imports System.IO
Public Class PartLabel
    Public LabelTextFileTable As DataTable = Nothing
    Dim LabelpartNumber
    Dim LabelpartKitNumber
    Dim LabelpartName
    Dim LabelpartColour
    Dim LabelpartQty
    Dim LabelpartSeries
    Dim AdminLabelQty As Integer = 0
    Dim AdminMaxLabels As Integer = 24
    Dim Labeldata = System.IO.File.ReadAllText(homeFolder & "\templates\VWPART.lbl") ' load the template



    Private Sub PartLabel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataGrid(LabelTextFileTable)
        Me.DataGridView1.DataSource = LabelTextFileTable
        Me.Show() 'show the form

        TxtLookup.Select() ' set the cursor in the text lookup field
        If adminUserName = "kquast" Then
            BtnKennySecret.Visible = True
        End If

    End Sub
    Private Sub TxtLookup_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtLookup.KeyDown
        'if the user types a code and hits enter *used in barcodes as carrige return*
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            BtnLookup.PerformClick()
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
            '    prevPart = currentPart
            '    currentPart = TxtLookup.Text
            getData()
            'timerClearSearch.Enabled = True

        End If
        LblDescription.Text = LabelpartName
        LblColour.Text = "Colour : " & LabelpartColour
        LblSeries.Text = "Series : " & LabelpartSeries

        'TxtLookup.Select()
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
                LabelpartNumber = row.Cells("column0").Value.ToString()
                LabelpartKitNumber = row.Cells("column1").Value.ToString()
                LabelpartName = row.Cells("column2").Value.ToString()
                LabelpartColour = row.Cells("column3").Value.ToString()
                LabelpartQty = row.Cells("column4").Value.ToString() ' Temporarily grab the StdPack but this will be changed manually later
                LabelpartSeries = row.Cells("column5").Value.ToString()

                Exit For
            End If

        Next
        BtnService.Enabled = True
        TxtLabelQty.Focus()

        AdminMaxLabels = 24

        If Not found Then

            PartNotFound() ' goto not found routine
            TimerClearSearch.Enabled = True


            Exit Sub
        End If
    End Sub
    Public Sub PartNotFound()
        LabelpartNumber = TxtLookup.Text
        LabelpartName = "Part Not Found in Database"
        LabelpartSeries = ""
        LabelpartColour = ""
        TxtLookup.Focus()
        BtnService.Enabled = False
    End Sub

    Private Sub BtnLookup_Click(sender As Object, e As EventArgs) Handles BtnLookup.Click
        LookupPart()

    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()

    End Sub

    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles BtnSubmit.Click

        If TxtLabelQty.Text = "" Then
            MsgBox("Please Enter a valid number")
            TxtLabelQty.Focus()
            Exit Sub
        ElseIf Txtreason.text = "" Then
            MsgBox("Please Enter a reason for reprinting")
            TxtReason.Focus()
            Exit Sub
        Else

            Dim PartCopies As Integer = 0 ' Reset counter
            AdminLabelQty = TxtLabelQty.Text
            ''MsgBox(AdminLabelQty)
            If AdminLabelQty > AdminMaxLabels Then
                MsgBox("Please Choose " & AdminMaxLabels & " or less not : " & AdminLabelQty)
                TxtLabelQty.Focus()
                Exit Sub

            Else
                Labeldata = System.IO.File.ReadAllText(homeFolder & "\templates\VWPART.lbl") ' reset the template
                generateAdminLabel()
                Dim pd As New PrintDialog()

                Do Until PartCopies = AdminLabelQty
                    'Below is the line to use for selecting the printer out of the config file (ie: netowrk printer)
                    'RawPrinterHelper.SendStringToPrinter(printerName, Labeldata) ' Print label(s) to printer name in config file
                    '----------------------------------------------------------------------------------------------------------
                    'Below is the line used for printign to the default printer at the station (note: requires user to change out media)
                    'RawPrinterHelper.SendStringToPrinter(pd.PrinterSettings.PrinterName, Labeldata) ' Print label(s) to the systems default printer
                    RawPrinterHelper.SendStringToPrinter(printerName, Labeldata) ' Print label(s) to the config file printer
                    PartCopies = PartCopies + 1 'Count how many times the loop has run
                Loop 'loop (Duh)
                AdminLabelDataCollection()
                TxtLookup.Text = ""
                TxtLabelQty.Text = ""
                TxtReason.Text = ""
                LblColour.Text = "Colour :"
                LblSeries.Text = "Series :"
                LblDescription.Text = ""
                TxtLookup.Focus()
            End If
        End If

    End Sub
    Public Sub generateAdminLabel()
        'Simple way to load data from "text" file and fill in contents to be used for generating label 
        'From existing IPL template
        Labeldata = System.IO.File.ReadAllText(homeFolder & "\templates\VWPART.lbl") ' reset the template
        Labeldata = Labeldata.Replace("%PartNumber%", LabelpartNumber)
        Labeldata = Labeldata.Replace("%Series%", LabelpartSeries)
        Labeldata = Labeldata.Replace("%Description%", LabelpartName)
        Labeldata = Labeldata.Replace("%PartColour%", LabelpartColour)
        Labeldata = Labeldata.Replace("%AdminUserName%", adminUserName)
        Labeldata = Labeldata.Replace("%Date%", Date.Now.ToString("MM/dd/yyyy  HH:mm"))


    End Sub


    Private Sub TxtLabelQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtLabelQty.KeyPress

        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
    Public Sub AdminLabelDataCollection()
        'Demonstrating Data Logging
        Dim filePath As String = String.Format(logFile & "\label_reprints\{0}-{1}.csv", DateTime.Today.ToString("MMM-dd-yyyy"), cellName)

        Dim fileExists As Boolean = File.Exists(filePath)

        Using writer As New StreamWriter(filePath, True)
            If Not fileExists Then
                writer.WriteLine("Cell,Part Number,Description,Quantity Reprinted,Series Level,Time Label created,Reprinted By,Reason")
            End If
            writer.WriteLine(cellName & "," & LabelpartNumber & "," & LabelpartName & " - " & LabelpartColour & "," & AdminLabelQty & "," & LabelpartSeries & "," & Date.Now.ToString("MM/dd/yyyy  HH:mm") & "," & adminUserName & "," & TxtReason.Text)
        End Using
    End Sub


    Private Sub TxtLabelQty_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtLabelQty.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            TxtReason.Focus()


        End If
    End Sub
    Private Sub TxtReason_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtReason.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            BtnSubmit.PerformClick()
        End If
    End Sub

    Private Sub PartLabel_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        FormAdminControlPanel.TopMost = True
    End Sub

    Private Sub BtnService_Click(sender As Object, e As EventArgs) Handles BtnService.Click
        'some lines removed as teh service parts are not in the excel sheet
        'this button now only changes the max labels to be printed
        'LabelpartNumber = LabelpartNumber & "S" ' Add the S to the part number for Service
        'TxtLookup.Text = LabelpartNumber ' Add the S to the text box
        'LabelpartName = LabelpartName & " - SERVICE" ' Add the Word Service to the Part Description
        'LblDescription.Text = LabelpartName ' Display the word SERVICE on screen
        AdminMaxLabels = 280 '10 boxes should be enough they can re-do this after 10 moxes are used

        BtnService.Enabled = False ' set the button back to un-clickable to avoid multiple S's in the part number

    End Sub

    Private Sub BtnKennySecret_Click(sender As Object, e As EventArgs) Handles BtnKennySecret.Click
        Dim FixLabelPrinter As String = ""
        'Simple way to load data from "text" file and fill in contents to be used for generating label 
        'From existing IPL template
        Labeldata = System.IO.File.ReadAllText(homeFolder & "\templates\VWPART.lbl") ' reset the template
        'Below is removed so that the labels print out un-usable data
        '
        'Labeldata = Labeldata.Replace("%PartNumber%", LabelpartNumber)
        'Labeldata = Labeldata.Replace("%Series%", LabelpartSeries)
        'Labeldata = Labeldata.Replace("%Description%", LabelpartName)
        'Labeldata = Labeldata.Replace("%PartColour%", LabelpartColour)
        'Labeldata = Labeldata.Replace("%AdminUserName%", adminUserName)
        'Labeldata = Labeldata.Replace("%Date%", Date.Now.ToString("MM/dd/yyyy  HH:mm"))
        RawPrinterHelper.SendStringToPrinter(printerName, Labeldata) ' Print label(s) to the config file printer
        RawPrinterHelper.SendStringToPrinter(printerName, Labeldata) ' Print label(s) to the config file printer
        RawPrinterHelper.SendStringToPrinter(printerName, Labeldata) ' Print label(s) to the config file printer



    End Sub

End Class