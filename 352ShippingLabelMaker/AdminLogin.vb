Public Class AdminLogin
    Public AdminFileReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(homeFolder & "\admin\admin.csv")
    Public AdminFileTable As DataTable = Nothing


    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub AdminLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAdminDataGrid()
        Me.DataGridView1.DataSource = AdminFileTable
        Me.Show()
        txtLogin.Focus()
    End Sub
    Public Sub LoadAdminDataGrid()
        'Load the CSV file to a workable datagridview which is hidden on screen because we do not need to view the data
        'just need to access it
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
                        AdminFileTable = New DataTable("TextFileTable")
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

    Private Sub txtLogin__KeyDown(sender As Object, e As KeyEventArgs) Handles txtLogin.KeyDown
        'if the user types a code and hits enter *used in barcodes as carrige return*
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            btnLogin.PerformClick()
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtLogin.Text = "" Then
            ' This is a crude error handling for the search box containing nothing. it will not seem to use
            'current errorhandling partNotFound() The chances of a user clicking enter is not common with a barcode 
            'scanner So I am not too worried about this popup showing
            MsgBox("No Data Inputed", Title:="No Data Received")
            'getData()

            Exit Sub
        Else
            getUser()
        End If
    End Sub
    Public Sub getUser()
        'Method to scan through datagrid and select part row for usage.
        'may have to move some code to other areas eg: colour change code so we can use this
        'method for other areas of the program

        Dim rowindex As String
        Dim found As Boolean = False
        For Each row As DataGridViewRow In DataGridView1.Rows
            'scan each row of the datagrid to match part scanned if found, load values into memory.
            If row.Cells.Item("Column0").Value = txtLogin.Text Then
                rowindex = row.Index.ToString()
                found = True
                adminPassword = row.Cells("column0").Value.ToString()
                adminUserName = row.Cells("column1").Value.ToString()
                adminName = row.Cells("column2").Value.ToString()
                Exit For
            End If

        Next

        If Not found Then

            MsgBox("Invalid Password", Title:="Invalid Password")
            Me.Close()
        Else
            'Show admin Control Panel Here
            FormAdminControlPanel.Show()
            Me.Close()

        End If

    End Sub
End Class