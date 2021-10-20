Imports FontAwesome.Sharp
Imports FireSharp.Config
Imports FireSharp.Response
Imports FireSharp.Interfaces
Imports System.IO
Imports Newtonsoft.Json
Imports System.Text.RegularExpressions

Public Class SelectOpt
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'MessageBox.Show("hello")

    End Sub

    Private Sub IconButton5_Click(sender As Object, e As EventArgs) Handles IconButton5.Click
        ExitApplication.ShowDialog()
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        ViewResults.ShowDialog()
    End Sub

    Private Sub btnFill_Click(sender As Object, e As EventArgs) Handles btnFill.Click
        TakeSurvey.ShowDialog()
    End Sub
    'Private Sub Admin_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize

    '    If WindowState = FormWindowState.Minimized Then
    '        FormBorderStyle = FormBorderStyle.None
    '    Else
    '        FormBorderStyle = FormBorderStyle.Sizable
    '    End If

    'End Sub
    'Private Sub btnFill_Click(sender As Object, e As EventArgs) Handles btnFill.Click
    '    TakeSurvey.ShowDialog()
    'End Sub


    'Private Shared Sub ReleaseCapture()
    'End Sub
    'Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal IParam As Integer)
    'End Sub
    'Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
    '    ReleaseCapture()
    '    SendMessage(Me.Handle, &H112&, &HF012&, 0)
    'End Sub
End Class