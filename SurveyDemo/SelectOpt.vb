Imports FontAwesome.Sharp
Imports FireSharp.Config
Imports FireSharp.Response
Imports FireSharp.Interfaces
Imports System.IO
Imports Newtonsoft.Json
Imports System.Text.RegularExpressions

Public Class SelectOpt
    Private Sub IconButton5_Click(sender As Object, e As EventArgs) Handles IconButton5.Click
        ExitApplication.ShowDialog()
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        ViewResults.ShowDialog()
    End Sub

    Private Sub btnFill_Click(sender As Object, e As EventArgs) Handles btnFill.Click
        TakeSurvey.ShowDialog()
    End Sub

End Class