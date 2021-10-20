Public Class ExitApplication
    Private Sub noIcBtn_Click(sender As Object, e As EventArgs) Handles noIcBtn.Click
        Me.Close()
    End Sub

    Private Sub yesIcBtn_Click(sender As Object, e As EventArgs) Handles yesIcBtn.Click
        SelectOpt.Close()
        SelectOpt.Hide()
        Timer1.Enabled = True
        ProgressBar1.Visible = False

        Label1.Visible = False
        noIcBtn.Visible = False
        yesIcBtn.Visible = False
    End Sub

    Private Sub ExitApplication_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProgressBar1.Visible = False
        statsulbl.Visible = False
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        ProgressBar1.Value += 5

        If (ProgressBar1.Value <= 100) Then
            statsulbl.Text = "MAPS System BY K.L.MOLEFE"
            statsulbl.Visible = True

            If ProgressBar1.Value = 100 Then
                Timer1.Dispose()
                Application.Exit()
            End If

        End If

    End Sub
End Class