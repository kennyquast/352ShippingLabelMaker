Imports System.Drawing.Printing ' for Printing
Imports System.Runtime.InteropServices ' For Printing
Imports System.IO
Module common
    Public todayDate As String = Today.ToString("M-d-yyyy") 'Format the date string
    Public LabelDate As String = Nothing
    Public printerName As String = My.Settings.SparePrinterName
    Public homeFolder As String = My.Settings.homeFolder
    Public logFile As String = My.Settings.logFile
    Public cellName As String = My.Settings.cellName
    Public labelType As String = My.Settings.labelType
    Public csvFile As String = My.Settings.csvFile
    Public data As String = System.IO.File.ReadAllText(homeFolder & "\templates\" & labelType & ".lbl")
    Public partNumber As String ' part number from CSV
    Public partKitNumber As String ' kit number from CSV file (used for Unique identifier for cladding sets) 
    Public partName As String ' part name from CSV
    Public TempKitNumber As String 'used to store the last part number's Kit for validation
    Public TempKitNumber2 As String ' used to store 2 parts ago incase of error, the software can go back to the last part style without a reset.
    Public partColour As String ' part colour from CSV file
    Public partQty As Integer ' Standard pack from CSV
    Public partSeries As String ' part kanban from CSV (may not use this)
    Public prevPart As String ' last part scanned
    Public currentPart As String 'current part scanned 
    Public partCount As Integer = 0 ' Current part count
    Public skidCount As Integer = 0 ' total skids built of current product
    Public validatedPart As Boolean = False ' used to test of the part is correct or not
    Public adminName As String = "" ' admin Full Name
    Public adminPassword As String = "" ' Admin login
    Public adminUserName As String = "" 'Admin username (used for future manual label reprints)
    Public PartLabelData As String = File.ReadAllText(homeFolder & "\templates\VWPART.lbl") 'loads the part label tempalte



    Public Sub LoadDataGrid(ByRef TextFileTable)
        'Load the CSV file to a workable datagridview which is hidden on screen because we do not need to view the data
        'just need to access it
        Dim TextFileReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(homeFolder & csvFile)
        'Dim TextFileTable As DataTable = Nothing
        TextFileReader.TextFieldType = FileIO.FieldType.Delimited
        TextFileReader.SetDelimiters(",")



        Dim Column As DataColumn
        Dim Row As DataRow
        Dim UpperBound As Int32
        Dim ColumnCount As Int32
        Dim CurrentRow As String()

        While Not TextFileReader.EndOfData
            Try
                CurrentRow = TextFileReader.ReadFields()
                If Not CurrentRow Is Nothing Then
                    ''# Check if DataTable has been created
                    If TextFileTable Is Nothing Then
                        TextFileTable = New DataTable("TextFileTable")
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
                            TextFileTable.Columns.Add(Column)
                        Next
                    End If
                    Row = TextFileTable.NewRow
                    For ColumnCount = 0 To UpperBound
                        Row("Column" & ColumnCount) = CurrentRow(ColumnCount).ToString
                    Next
                    TextFileTable.Rows.Add(Row)
                End If
            Catch ex As _
            Microsoft.VisualBasic.FileIO.MalformedLineException
                MsgBox("Line " & ex.Message &
                "is not valid and will be skipped.")
            End Try
        End While
        TextFileReader.Dispose()
        Return
    End Sub

    Public Class RawPrinterHelper
        ' Structure and API declarions:
        <StructLayout(LayoutKind.Sequential, CharSet:=CharSet.Unicode)>
        Structure DOCINFOW
            <MarshalAs(UnmanagedType.LPWStr)> Public pDocName As String
            <MarshalAs(UnmanagedType.LPWStr)> Public pOutputFile As String
            <MarshalAs(UnmanagedType.LPWStr)> Public pDataType As String
        End Structure

        <DllImport("winspool.Drv", EntryPoint:="OpenPrinterW",
           SetLastError:=True, CharSet:=CharSet.Unicode,
           ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)>
        Public Shared Function OpenPrinter(ByVal src As String, ByRef hPrinter As IntPtr, ByVal pd As Long) As Boolean
        End Function
        <DllImport("winspool.Drv", EntryPoint:="ClosePrinter",
           SetLastError:=True, CharSet:=CharSet.Unicode,
           ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)>
        Public Shared Function ClosePrinter(ByVal hPrinter As IntPtr) As Boolean
        End Function
        <DllImport("winspool.Drv", EntryPoint:="StartDocPrinterW",
           SetLastError:=True, CharSet:=CharSet.Unicode,
           ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)>
        Public Shared Function StartDocPrinter(ByVal hPrinter As IntPtr, ByVal level As Int32, ByRef pDI As DOCINFOW) As Boolean
        End Function
        <DllImport("winspool.Drv", EntryPoint:="EndDocPrinter",
           SetLastError:=True, CharSet:=CharSet.Unicode,
           ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)>
        Public Shared Function EndDocPrinter(ByVal hPrinter As IntPtr) As Boolean
        End Function
        <DllImport("winspool.Drv", EntryPoint:="StartPagePrinter",
           SetLastError:=True, CharSet:=CharSet.Unicode,
           ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)>
        Public Shared Function StartPagePrinter(ByVal hPrinter As IntPtr) As Boolean
        End Function
        <DllImport("winspool.Drv", EntryPoint:="EndPagePrinter",
           SetLastError:=True, CharSet:=CharSet.Unicode,
           ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)>
        Public Shared Function EndPagePrinter(ByVal hPrinter As IntPtr) As Boolean
        End Function
        <DllImport("winspool.Drv", EntryPoint:="WritePrinter",
           SetLastError:=True, CharSet:=CharSet.Unicode,
           ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)>
        Public Shared Function WritePrinter(ByVal hPrinter As IntPtr, ByVal pBytes As IntPtr, ByVal dwCount As Int32, ByRef dwWritten As Int32) As Boolean
        End Function
        <DllImport("kernel32.dll", EntryPoint:="GetLastError",
           SetLastError:=True, CharSet:=CharSet.Unicode,
           ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)>
        Public Shared Function GetLastError() As Int32
        End Function

        ' SendBytesToPrinter()
        ' When the function is given a printer name and an unmanaged array of  
        ' bytes, the function sends those bytes to the print queue.
        ' Returns True on success or False on failure.
        Public Shared Function SendBytesToPrinter(ByVal szPrinterName As String, ByVal pBytes As IntPtr, ByVal dwCount As Int32) As Boolean
            Dim hPrinter As IntPtr      ' The printer handle.
            Dim dwError As Int32        ' Last error - in case there was trouble.
            Dim di As DOCINFOW          ' Describes your document (name, port, data type).
            Dim dwWritten As Int32      ' The number of bytes written by WritePrinter().
            Dim bSuccess As Boolean     ' Your success code.

            ' Set up the DOCINFO structure.
            With di
                .pDocName = "My Visual Basic .NET RAW Document"
                .pDataType = "RAW"

            End With
            ' Assume failure unless you specifically succeed.
            bSuccess = False
            If OpenPrinter(szPrinterName, hPrinter, 0) Then
                If StartDocPrinter(hPrinter, 1, di) Then
                    If StartPagePrinter(hPrinter) Then
                        ' Write your printer-specific bytes to the printer.
                        bSuccess = WritePrinter(hPrinter, pBytes, dwCount, dwWritten)
                        EndPagePrinter(hPrinter)
                    End If
                    EndDocPrinter(hPrinter)
                End If
                ClosePrinter(hPrinter)
            End If
            ' If you did not succeed, GetLastError may give more information
            ' about why not.
            If bSuccess = False Then
                dwError = GetLastError()
            End If
            Return bSuccess
        End Function ' SendBytesToPrinter()

        ' SendFileToPrinter()
        ' When the function is given a file name and a printer name,
        ' the function reads the contents of the file and sends the
        ' contents to the printer.
        ' Presumes that the file contains printer-ready data.
        ' Shows how to use the SendBytesToPrinter function.
        ' Returns True on success or False on failure.
        'Public Shared Function SendFileToPrinter(ByVal szPrinterName As String, ByVal szFileName As String) As Boolean
        '    ' Open the file.
        '    Dim fs As New FileStream(szFileName, FileMode.Open)
        '    ' Create a BinaryReader on the file.
        '    Dim br As New BinaryReader(fs)
        '    ' Dim an array of bytes large enough to hold the file's contents.
        '    Dim bytes(fs.Length) As Byte
        '    Dim bSuccess As Boolean
        '    ' Your unmanaged pointer
        '    Dim pUnmanagedBytes As IntPtr

        '    ' Read the contents of the file into the array.
        '    bytes = br.ReadBytes(fs.Length)
        '    ' Allocate some unmanaged memory for those bytes.
        '    pUnmanagedBytes = Marshal.AllocCoTaskMem(fs.Length)
        '    ' Copy the managed byte array into the unmanaged array.
        '    Marshal.Copy(bytes, 0, pUnmanagedBytes, fs.Length)
        '    ' Send the unmanaged bytes to the printer.
        '    bSuccess = SendBytesToPrinter(szPrinterName, pUnmanagedBytes, fs.Length)
        '    ' Free the unmanaged memory that you allocated earlier.
        '    Marshal.FreeCoTaskMem(pUnmanagedBytes)
        '    Return bSuccess
        'End Function ' SendFileToPrinter()

        ' When the function is given a string and a printer name,
        ' the function sends the string to the printer as raw bytes.
        Public Shared Function SendStringToPrinter(ByVal szPrinterName As String, ByVal szString As String)
            Dim pBytes As IntPtr
            Dim dwCount As Int32
            ' How many characters are in the string?
            dwCount = szString.Length()
            ' Assume that the printer is expecting ANSI text, and then convert
            ' the string to ANSI text.
            pBytes = Marshal.StringToCoTaskMemAnsi(szString)
            ' Send the converted ANSI string to the printer.
            SendBytesToPrinter(szPrinterName, pBytes, dwCount)
            Marshal.FreeCoTaskMem(pBytes)
            'added the following code to remove a build error, we dont need a return on anything to lets just return anything and see if it still prints. KQ Remove below line if errors whie printing arise
            Return szString
        End Function
    End Class
    Public Sub generateLabel()
        'Simple way to load data from "text" file and fill in contents to be used for generating label 
        'From existing IPL template
        data = System.IO.File.ReadAllText(homeFolder & "\templates\" & labelType & ".lbl") ' reset the template
        data = data.Replace("%Date%", Date.Now)
        data = data.Replace("%PartNumber%", currentPart)
        data = data.Replace("%Quantity%", partQty)
        data = data.Replace("%Series%", partSeries)
        data = data.Replace("%Description%", partName)
        data = data.Replace("%PartColour%", partColour)
        data = data.Replace("%Cell%", cellName)
        data = data.Replace("%Date%", Date.Now)


    End Sub
    Public Sub DataCollection()
        'Demonstrating Data Logging
        Dim filePath As String = String.Format(logFile & "\{0}-{1}.csv", DateTime.Today.ToString("MMM-dd-yyyy"), cellName)

        Dim fileExists As Boolean = File.Exists(filePath)

        Using writer As New StreamWriter(filePath, True)
            If Not fileExists Then
                writer.WriteLine("Cell,Part Number,Description,Quantity,Series Level,Time Label created")
            End If
            writer.WriteLine(cellName & "," & currentPart & "," & partName & " - " & partColour & "," & partQty & "," & partSeries & "," & Date.Now)
        End Using
    End Sub
    Public Sub OpenNewPartScannedWindow()
        frmNewPartScanned.ShowDialog()


    End Sub
    Public Sub OpenSamePartScannedWindow()
        frmSamePartScanned.ShowDialog()

    End Sub

End Module
