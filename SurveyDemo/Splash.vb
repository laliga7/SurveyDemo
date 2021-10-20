Public Class Splash
    Private Sub Splash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Value += 1
        status.Visible = False


        If (ProgressBar1.Value <= 10) Then
            status.Text = "Initilizing System..."
            status.Visible = True
        ElseIf (ProgressBar1.Value <= 30) Then
            status.Text = "Loading componets....."
            status.Visible = True
            status.Text = "Loading all componets.."
        ElseIf (ProgressBar1.Value <= 50) Then
            status.Text = "Loading all componets...."
            status.Visible = True
            status.Text = "connecting to server....."
            status.Visible = True
        ElseIf (ProgressBar1.Value <= 70) Then
            status.Text = "connecting to  firbase....."
            status.Visible = True
        ElseIf (ProgressBar1.Value <= 80) Then
            status.Text = "Please wait..."
            status.Visible = True

            'ElseIf (ProgressBar1.Value <= 90) Then
            '    status.Text = "Please wait....."
            '    status.Visible = True
        ElseIf (ProgressBar1.Value <= 100) Then

            status.Text = "Welcome to MAPS System"
            status.Visible = True


            If ProgressBar1.Value = 100 Then

                Timer1.Dispose()
                Dim Menu As New SelectOpt
                Menu.Show()
                Me.Hide()
            End If

        End If


    End Sub
End Class