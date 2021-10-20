Imports FontAwesome.Sharp
Imports FireSharp.Config
Imports FireSharp.Response
Imports FireSharp.Interfaces
Imports System.IO
Imports Newtonsoft.Json
Imports System.Text.RegularExpressions

Public Class TakeSurvey
    Dim eatOut As Integer = 0
    Dim movies As Integer = 0
    Dim tv As Integer = 0
    Dim radio As Integer = 0

    Dim SA As Integer = 1
    Dim AG As Integer = 2
    Dim NU As Integer = 3
    Dim DA As Integer = 4
    Dim SD As Integer = 5

    Dim survCount As Integer = 0
    Dim countt As Integer = 0

    Private fcon As New FirebaseConfig() With
        {
    .AuthSecret = "SDvxmJN0TDOK0MPuhWWv0esngVk1lxO7EG2WAwnZ",
    .BasePath = "https://munch-and-pto-survey-default-rtdb.asia-southeast1.firebasedatabase.app/"
        }
    Private client As IFirebaseClient

    Private Sub TakeSurvey_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            client = New FireSharp.FirebaseClient(fcon)
        Catch
            MessageBox.Show("there was a problem in internet connection")
        End Try

        Dim res2 As FirebaseResponse = client.Get("SurveyList")
        Dim data As Dictionary(Of String, MAPS) = JsonConvert.DeserializeObject(Of Dictionary(Of String, MAPS))(res2.Body.ToString)

        For Each item In data
            countt = item.Value.SurveyID
            survCount = survCount + 1
        Next


    End Sub

#Region "Place Holders"
    'full name validation
    Private Sub fnameTbox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles fnametbx.KeyPress
        Dim allowednos As String = "abcdefghijklmnopqrstuvwxyzABCDEFGHOJKLMNOPQRSTUVWXYZ' '"
        If Not allowednos.Contains(e.KeyChar.ToString) Then

            If Asc(e.KeyChar) <> 8 Then
                e.KeyChar = " "
                e.Handled = True
            End If
        End If

    End Sub

    'full name placeholder
    Private Sub txtDetails_MouseEnter(sender As Object, e As EventArgs) Handles fnametbx.MouseEnter
        If fnametbx.Text = "Enter full name" Then
            fnametbx.Text = ""
            fnametbx.ForeColor = Color.Black
        End If
    End Sub
    Private Sub txtDetails_MouseLeave(sender As Object, e As EventArgs) Handles fnametbx.MouseLeave

        If fnametbx.Text = "" Then
            fnametbx.Text = "Enter full name"
            fnametbx.ForeColor = Color.Gray

        End If
    End Sub

    'last name validation
    Private Sub lnameTbox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles surnametbx.KeyPress
        Dim allowednos As String = "abcdefghijklmnopqrstuvwxyzABCDEFGHOJKLMNOPQRSTUVWXYZ' '"
        If Not allowednos.Contains(e.KeyChar.ToString) Then
            If Asc(e.KeyChar) <> 8 Then
                e.KeyChar = " "
                e.Handled = True
            End If
        End If
    End Sub

    'last name placeholder
    Private Sub lnameTbox_MouseEnter(sender As Object, e As EventArgs) Handles surnametbx.MouseEnter
        If surnametbx.Text = "Enter surname name" Then
            surnametbx.Text = ""
            surnametbx.ForeColor = Color.Black
        End If
    End Sub
    Private Sub lnameTbox_MouseLeave(sender As Object, e As EventArgs) Handles surnametbx.MouseLeave

        If surnametbx.Text = "" Then
            surnametbx.Text = "Enter surname name"
            surnametbx.ForeColor = Color.Gray

        End If
    End Sub
    Private Sub cellnoTbox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cnumbertbx.KeyPress
        Dim allowednos As String = "0123456789"

        If Not allowednos.Contains(e.KeyChar.ToString) Then
            If Asc(e.KeyChar) <> 8 Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
        If cnumbertbx.Text.Length >= 10 Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
                MessageBox.Show("Digits should not be more than 10")
            End If
        End If
    End Sub

    'cell no name placeholder
    Private Sub cellnoTbox_MouseEnter(sender As Object, e As EventArgs) Handles cnumbertbx.MouseEnter
        If cnumbertbx.Text = "079..." Then
            cnumbertbx.Text = ""
            cnumbertbx.ForeColor = Color.Black
        End If
    End Sub
    Private Sub cellnoTbox_MouseLeave(sender As Object, e As EventArgs) Handles cnumbertbx.MouseLeave

        If cnumbertbx.Text = "" Then
            cnumbertbx.Text = "079..."
            cnumbertbx.ForeColor = Color.Gray

        End If
    End Sub

#End Region

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

#Region "checkbox addition"
        Dim pizza As Integer = 0
        Dim pasta As Integer = 0
        Dim papAndwors As Integer = 0
        Dim chickenSF As Integer = 0
        Dim beefSF As Integer = 0
        Dim other As Integer = 0

        Select Case pizzacbx.Checked
            Case True
                pizza = 1
            Case Else
                pizza = 0
        End Select

        Select Case pastacbx.Checked
            Case True
                pasta = 1
            Case Else
                pasta = 0
        End Select

        Select Case papcbx.Checked
            Case True
                papAndwors = 1
            Case Else
                papAndwors = 0
        End Select

        Select Case chickencbx.Checked
            Case True
                chickenSF = 1
            Case Else
                chickenSF = 0
        End Select

        Select Case beefcbx.Checked
            Case True
                beefSF = 1
            Case Else
                beefSF = 0
        End Select

        Select Case othercbx.Checked
            Case True
                other = 1
            Case Else
                other = 0
        End Select
#End Region


        If surnametbx.Text = String.Empty Or fnametbx.Text = String.Empty Or cnumbertbx.Text = String.Empty Or ageSel.Value = 0 Or
        (pastacbx.Checked = False And pizzacbx.Checked = False And papcbx.Checked = False And chickencbx.Checked = False And beefcbx.Checked = False And othercbx.Checked = False) Or
        (sargp1.Checked = False And aargp1.Checked = False And drgp1.Checked = False And nrgp1.Checked = False And sdrgp1.Checked = False) Or
        (sargp2.Checked = False And aargp2.Checked = False And drgp2.Checked = False And nrgp2.Checked = False And sdrgp2.Checked = False) Or
        (sargp3.Checked = False And aargp3.Checked = False And drgp3.Checked = False And nrgp3.Checked = False And sdrgp3.Checked = False) Or
        (sargp4.Checked = False And aargp4.Checked = False And drgp4.Checked = False And nrgp4.Checked = False And sdrgp4.Checked = False) Then
            MessageBox.Show("Missing fields required!")
        Else
            Dim std As New MAPS() With
            {
            .SurveyID = countt + 2.ToString,
    .Surname = surnametbx.Text,
    .FirstName = fnametbx.Text,
    .ContactNo = cnumbertbx.Text,
    .DateD = DateTimePicker1.Value,
    .Age = ageSel.Value,
    .Pizza = pizza.ToString,
    .Paster = pasta.ToString,
    .PapAndWors = papAndwors.ToString,
    .ChickenStirFry = chickenSF.ToString,
    .BeefStirFry = beefSF.ToString,
    .Other = other.ToString,
    .EatOut = eatOut.ToString,
    .Movies = movies.ToString,
    .Radio = radio.ToString,
    .Television = tv.ToString
            }
            Dim setter = client.Set("SurveyList/" + (countt + 2).ToString, std)
            survCount = 0
            MessageBox.Show("Survey submitted successfully!")
            Me.Close()

#Region "Reset to default"
            surnametbx.Text = ""
            fnametbx.Text = ""
            cnumbertbx.Text = ""
            ageSel.Value = 0
            pizzacbx.Checked = False
            pastacbx.Checked = False
            papcbx.Checked = False
            chickencbx.Checked = False
            beefcbx.Checked = False
            othercbx.Checked = False

            sargp1.Checked = False
            sargp2.Checked = False
            sargp3.Checked = False
            sargp4.Checked = False

            aargp1.Checked = False
            aargp2.Checked = False
            aargp3.Checked = False
            aargp4.Checked = False

            nrgp1.Checked = False
            nrgp2.Checked = False
            nrgp3.Checked = False
            nrgp4.Checked = False

            drgp1.Checked = False
            drgp2.Checked = False
            drgp3.Checked = False
            drgp4.Checked = False

            sdrgp1.Checked = False
            sdrgp2.Checked = False
            sdrgp3.Checked = False
            sdrgp4.Checked = False
#End Region
        End If
    End Sub

#Region "raidobox addition"
    Private Sub sargp1_CheckedChanged(sender As Object, e As EventArgs) Handles sargp1.CheckedChanged
        If sargp1.Checked = True Then
            eatOut = SA
        End If
    End Sub

    Private Sub aargp1_CheckedChanged(sender As Object, e As EventArgs) Handles aargp1.CheckedChanged
        If aargp1.Checked = True Then
            eatOut = AG
        End If
    End Sub

    Private Sub nrgp1_CheckedChanged(sender As Object, e As EventArgs) Handles nrgp1.CheckedChanged
        If nrgp1.Checked = True Then
            eatOut = NU
        End If
    End Sub

    Private Sub drgp1_CheckedChanged(sender As Object, e As EventArgs) Handles drgp1.CheckedChanged
        If drgp1.Checked = True Then
            eatOut = DA
        End If
    End Sub

    Private Sub sdrgp1_CheckedChanged(sender As Object, e As EventArgs) Handles sdrgp1.CheckedChanged
        If sdrgp1.Checked = True Then
            eatOut = SD
        End If
    End Sub

    ''' '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

    Private Sub sargp2_CheckedChanged(sender As Object, e As EventArgs) Handles sargp2.CheckedChanged
        If sargp2.Checked = True Then
            movies = SA
        End If
    End Sub

    Private Sub aargp2_CheckedChanged(sender As Object, e As EventArgs) Handles aargp2.CheckedChanged
        If aargp2.Checked = True Then
            movies = AG
        End If
    End Sub

    Private Sub nrgp2_CheckedChanged(sender As Object, e As EventArgs) Handles nrgp2.CheckedChanged
        If nrgp2.Checked = True Then
            movies = NU
        End If
    End Sub

    Private Sub drgp2_CheckedChanged(sender As Object, e As EventArgs) Handles drgp2.CheckedChanged
        If drgp2.Checked = True Then
            movies = DA
        End If
    End Sub

    Private Sub sdrgp2_CheckedChanged(sender As Object, e As EventArgs) Handles sdrgp2.CheckedChanged
        If sdrgp2.Checked = True Then
            movies = SD
        End If
    End Sub

    Private Sub sargp3_CheckedChanged(sender As Object, e As EventArgs) Handles sargp3.CheckedChanged
        If sargp3.Checked = True Then
            tv = SA
        End If
    End Sub

    Private Sub aargp3_CheckedChanged(sender As Object, e As EventArgs) Handles aargp3.CheckedChanged
        If aargp3.Checked = True Then
            tv = AG
        End If
    End Sub

    Private Sub nrgp3_CheckedChanged(sender As Object, e As EventArgs) Handles nrgp3.CheckedChanged
        If nrgp3.Checked = True Then
            tv = NU
        End If
    End Sub

    Private Sub drgp3_CheckedChanged(sender As Object, e As EventArgs) Handles drgp3.CheckedChanged
        If drgp3.Checked = True Then
            tv = DA
        End If
    End Sub

    Private Sub sdrgp3_CheckedChanged(sender As Object, e As EventArgs) Handles sdrgp3.CheckedChanged
        If sdrgp3.Checked = True Then
            tv = SD
        End If
    End Sub

    Private Sub sargp4_CheckedChanged(sender As Object, e As EventArgs) Handles sargp4.CheckedChanged
        If sargp4.Checked = True Then
            radio = SA
        End If
    End Sub

    Private Sub aargp4_CheckedChanged(sender As Object, e As EventArgs) Handles aargp4.CheckedChanged
        If aargp4.Checked = True Then
            radio = AG
        End If
    End Sub

    Private Sub nrgp4_CheckedChanged(sender As Object, e As EventArgs) Handles nrgp4.CheckedChanged
        If nrgp4.Checked = True Then
            radio = NU
        End If
    End Sub

    Private Sub drgp4_CheckedChanged(sender As Object, e As EventArgs) Handles drgp4.CheckedChanged
        If drgp4.Checked = True Then
            radio = DA
        End If
    End Sub

    Private Sub sdrgp4_CheckedChanged(sender As Object, e As EventArgs) Handles sdrgp4.CheckedChanged
        If sdrgp4.Checked = True Then
            radio = SA
        End If
    End Sub
#End Region



    'Private Sub sargp1_CheckedChanged(sender As Object, e As EventArgs) Handles sargp1.CheckedChanged
    '    If aargp1.Checked = True Or drgp1.Checked = True Or nrgp1.Checked = True Or drgp1.Checked = True Or sdrgp1.Checked = True Then
    '        sargp1.Checked = False
    '    Else
    '        sargp1.Checked = True
    '        drgp1.Checked = False
    '        nrgp1.Checked = False
    '        drgp1.Checked = False
    '        sdrgp1.Checked = False
    '    End If
    'End Sub

End Class