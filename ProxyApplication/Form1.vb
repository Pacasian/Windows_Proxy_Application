Imports System.Data.SqlClient

Public Class Form1

    Dim con As New SqlConnection("server=TEAMIT-PC;database=testclass;integrated security=SSPI")

    Public Eid As String

    'Retriving the Data from the login Page 
    Public Sub New(ByVal val1 As String)

        ' This call is required by the designer.
        InitializeComponent()
        Eid = val1

    End Sub

    'changing the Textbox Value 
    Private Sub urlTxt_TextChanged(sender As Object, e As EventArgs) Handles urlTxt.Click
        If urlTxt.Text = "Search by Url" Then
            urlTxt.Text = ""
        End If
    End Sub

    Private Sub goTxt_TextChanged(sender As Object, e As EventArgs) Handles goTxt.Click
        If goTxt.Text = "Search" Then
            goTxt.Text = ""
        End If
    End Sub


    ' Enabling the Script in the browser 
    Private Sub Browser_Window_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WebBrowser1.ScriptErrorsSuppressed = True

    End Sub

    'Checking the url and Updating the log into the SQl database
    Sub checkAddress() Handles WebBrowser1.DocumentCompleted
        urlTxt.Text = WebBrowser1.Url.ToString

        Dim BlockQuery As String = "insert into SiteHistory(Eid,Site,time_Stamp) values('" & Eid & "',@Site,@time_Stamp)"
        runQuery(BlockQuery)

    End Sub

    'Updation Query Parameters 
    Public Sub runQuery(ByVal query As String)
        Dim cmd As New SqlCommand(query, con)
        cmd.Parameters.AddWithValue("@Site", WebBrowser1.Url.Host.ToString)
        cmd.Parameters.AddWithValue("@time_Stamp", DateTime.Now.ToString())
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub

    'Blocking or Redirecting the Restricted Sites
    Private Sub WebBrowser1_DocumentCompleted(sender As System.Object, e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted

        Dim BlockQuery As String = "Select * from block_Site where site = '" & WebBrowser1.Url.Host.ToString & "' and Empl_Status = 'H'"
        Dim cmd As New SqlCommand(BlockQuery, con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim dt As New DataTable()
        con.Open()
        adapter = New SqlDataAdapter(BlockQuery, con)
        adapter.Fill(dt)
        'MsgBox(dt.Rows.Count)
        If dt.Rows.Count > 0 Then

            WebBrowser1.Navigate("https://www.fcae.com/")
        End If
        con.Close()
    End Sub

    'Function for Button Go Back
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnB.Click
        If WebBrowser1.CanGoBack = True Then
            WebBrowser1.GoBack()

        End If
    End Sub

    'Function for Forward Button
    Private Sub btnForward_Click(sender As Object, e As EventArgs) Handles btnF.Click
        If WebBrowser1.CanGoForward = True Then
            WebBrowser1.GoForward()
        End If

    End Sub

    'Function for Refresh Button
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        WebBrowser1.Refresh()

    End Sub




    Private Sub btnSetting_Click(sender As Object, e As EventArgs) Handles btnSetting.Click
        Settings.Show()

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If My.Settings.SE = "Google" Then
            WebBrowser1.Navigate(My.Settings.Google + goTxt.Text)
        ElseIf My.Settings.SE = "Bing" Then
            WebBrowser1.Navigate(My.Settings.Bing + goTxt.Text)
        End If
    End Sub
End Class
