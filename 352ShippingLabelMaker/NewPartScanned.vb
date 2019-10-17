Public Class frmNewPartScanned
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnOK.Click
        Try
            Throw New Exception("User Clicked OK on a new part style")
        Catch ex As Exception
            LogError(ex)
        End Try

        DialogResult = DialogResult.OK
        Me.Close()

    End Sub

    Private Sub NewPartScanned_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.BackColor = Color.White
        Timer2.Enabled = True
        Timer1.Enabled = False
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Me.BackColor = Color.Red
        Timer2.Enabled = False
        Timer1.Enabled = True
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Try
            Throw New Exception("User Clicked CANCEL on a new part style")
        Catch ex As Exception
            LogError(ex)
        End Try
        DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class