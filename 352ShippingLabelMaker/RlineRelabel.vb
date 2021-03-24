Public Class RlineRelabel
    Public LabelTextFileTable As DataTable = Nothing
    Private Sub RlineRelabel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataGrid(LabelTextFileTable)
        Me.DataGridView1.DataSource = LabelTextFileTable
        Me.Show() 'show the form

        TxtLookup.Select() ' set the cursor in the text lookup field
    End Sub
End Class