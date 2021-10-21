Imports FontAwesome.Sharp
Imports FireSharp.Config
Imports FireSharp.Response
Imports FireSharp.Interfaces
Imports System.IO
Imports Newtonsoft.Json
Imports System.Text.RegularExpressions

Public Class ViewResults

#Region "Global Variables"
    'global variables
    Dim survCount As Integer = 0
    Dim sumAge As Integer = 0
    Dim avgAge As Double = 0.00

    Dim oldPersonNum As Integer = 0
    Dim oldName As String = ""

    Dim minAge As Integer = 120
    Dim minName As String

    Dim pizzaTotal As Integer = 0
    Dim pastaTotal As Integer = 0
    Dim pAwTotal As Integer = 0

    Dim eatOutTot As Integer = 0
    Dim moviesTot As Integer = 0
    Dim tvTot As Integer = 0
    Dim radioTot As Integer = 0

    Dim eatOutAvg As Double = 0.00
    Dim moviesAvg As Double = 0.00
    Dim tvAvg As Double = 0.00
    Dim radioAvg As Double = 0.00
#End Region

    'connect to the database
    Private fcon As New FirebaseConfig() With
        {
    .AuthSecret = "SDvxmJN0TDOK0MPuhWWv0esngVk1lxO7EG2WAwnZ",
    .BasePath = "https://munch-and-pto-survey-default-rtdb.asia-southeast1.firebasedatabase.app/"
        }
    Private client As IFirebaseClient

    Private Sub ViewResults_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            client = New FireSharp.FirebaseClient(fcon)
        Catch
            MessageBox.Show("there was a problem in internet connection")
        End Try


        'retrieve data from the database and calculate averages and percentages 

        Dim res2 As FirebaseResponse = client.Get("SurveyList")
        Dim data As Dictionary(Of String, MAPS) = JsonConvert.DeserializeObject(Of Dictionary(Of String, MAPS))(res2.Body.ToString)

        For Each item In data

            If item.Value.Age > oldPersonNum Then
                oldPersonNum = item.Value.Age
                oldName = item.Value.Surname
            End If

            If item.Value.Age < minAge Then
                minName = item.Value.Surname
                minAge = item.Value.Age
            End If

            sumAge = sumAge + item.Value.Age
            survCount = survCount + 1

            pizzaTotal = pizzaTotal + item.Value.Pizza
            pastaTotal = pastaTotal + item.Value.Paster
            pAwTotal = pAwTotal + item.Value.PapAndWors

            If item.Value.EatOut > 0 Then
                eatOutTot = eatOutTot + item.Value.EatOut
            End If

            If item.Value.Movies > 0 Then
                moviesTot = moviesTot + item.Value.Movies
            End If

            If item.Value.Television > 0 Then
                tvTot = tvTot + item.Value.Television
            End If

            If item.Value.Radio > 0 Then
                radioTot = radioTot + item.Value.Radio
            End If
        Next
        'calculate averages and totals
        avgAge = sumAge / survCount
        eatOutAvg = eatOutTot / survCount
        moviesAvg = moviesTot / survCount
        tvAvg = tvTot / survCount
        radioAvg = radioTot / survCount

        'Display totals
        totalNumSurv.Text = survCount
        avgAgelbl.Text = Math.Round(avgAge, 2).ToString
        oldPerslbl.Text = oldName + " with the age of " + oldPersonNum.ToString + " years."
        minAgeLbl.Text = minName + " with the age of " + Math.Round(minAge, 2).ToString + " yaers."
        pizzaLbl.Text = Math.Round(((100 * pizzaTotal) / survCount), 2).ToString + "%"
        pastaLbl.Text = Math.Round(((100 * pastaTotal) / survCount), 2).ToString + "%"
        pAwLbl.Text = Math.Round(((100 * pAwTotal) / survCount), 2).ToString + "%"
        eatOutLbl.Text = Math.Round(eatOutAvg, 2).ToString
        movieLbl.Text = Math.Round(moviesAvg, 2).ToString
        tvLbl.Text = Math.Round(tvAvg, 2).ToString
        radioLbl.Text = Math.Round(radioAvg, 2).ToString


        'initialize variables back to zero
        sumAge = 0
        survCount = 0
        oldPersonNum = 0
        minAge = 0
        pizzaTotal = 0
        pastaTotal = 0
        pAwTotal = 0
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class