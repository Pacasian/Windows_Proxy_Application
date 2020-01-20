Imports System.Data.SqlClient

Public Class Admin

    Dim con As New SqlConnection("server=TEAMIT-PC;database=testclass;integrated security=SSPI")
    Private Sub goTxt_TextChanged(sender As Object, e As EventArgs) Handles goTxt.Click
        If goTxt.Text = "Search" Then
            goTxt.Text = ""
        End If
    End Sub

    Private Sub cpyHost_TextChanged(sender As Object, e As EventArgs) Handles cpyHost.Click
        If cpyHost.Text = "Copy the Host URl from HERE" Then
            cpyHost.Text = ""
        End If

    End Sub
    ' START BROWSER
    ' Getting the Host on click 
    Private Sub btnHost_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Browser_Window_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WebBrowser1.ScriptErrorsSuppressed = True

    End Sub

    'Checking the Host URL 
    Sub checkAddress() Handles WebBrowser1.DocumentCompleted
        cpyHost.Text = WebBrowser1.Url.Host.ToString

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

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If My.Settings.SE = "Google" Then
            WebBrowser1.Navigate(My.Settings.Google + goTxt.Text)
        ElseIf My.Settings.SE = "Bing" Then
            WebBrowser1.Navigate(My.Settings.Bing + goTxt.Text)
        End If

    End Sub


    ' END BROWSER

    'START DATAGRIDVIEW SECTION
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub
    Private Sub btnSearch1_Click(sender As Object, e As EventArgs) Handles btnSearch1.Click
        SearchTab(eid.Text)
    End Sub
    Public Sub SearchTab(idToSearch As String)

        Dim searchRecord As String = "select * from SiteHistory where Eid = '" & idToSearch & "'"
        Dim cmd As New SqlCommand(searchRecord, con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable()
        adapter.Fill(table)
        DataGridView1.DataSource = table
    End Sub

    Private Sub btnViewBLK_Click(sender As Object, e As EventArgs) Handles btnViewBLK.Click
        SearchTab1(Div3.Text)
    End Sub
    Public Sub SearchTab1(idToSearch1 As String)

        Dim searchRecord As String = "select * from block_Site where Empl_Status = '" & idToSearch1 & "'"
        Dim cmd As New SqlCommand(searchRecord, con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable()
        adapter.Fill(table)
        DataGridView1.DataSource = table
    End Sub


    'END DATAGRIDVIEW SECTION



    'START BLOCK SITE FOR USER SECTION
    Private Sub btnBlock_Click(sender As Object, e As EventArgs) Handles btnBlock.Click
        If Not String.IsNullOrEmpty(hostTxt1.Text) And Not String.IsNullOrEmpty(Div1.Text) Then
            If Div1.Text.ToUpper = "H" Or Div1.Text.ToUpper = "E" Then
                Dim insertquery As String = "insert into block_Site(site,Empl_Status) values('" & hostTxt1.Text & "','" & Div1.Text.ToUpper & "')"
                Dim cmd As New SqlCommand(insertquery, con)
                con.Open()
                cmd.ExecuteNonQuery()
                MsgBox("Successful")
                con.Close()

            ElseIf Div1.Text.ToUpper = "A" Then
                MsgBox("Cannot assign restrict to Admin")
            Else
                MsgBox("Unknown Employee Status")
            End If
        Else
            MsgBox("Enter the site credentials")
        End If
    End Sub



    'END BLOCK SITE FOR USER SECTION

    'START UN-BLOCK SITE FOR USER SECTION
    Private Sub btnUBlock_Click(sender As Object, e As EventArgs) Handles btnUBlock.Click
        If Not String.IsNullOrEmpty(hostTxt2.Text) Then
            Dim deleteRecord As String = " delete block_Site where site ='" & hostTxt2.Text & "'"
            Dim cmd As New SqlCommand(deleteRecord, con)
            con.Open()
            cmd.ExecuteNonQuery()
            MsgBox("Successfully Deleted")
            con.Close()
        Else
            MsgBox("Enter a non null host url")
        End If
    End Sub


    'END UN-BLOCK SITE FOR USER SECTION


    'START CHANGE SITE CREDENTIALS SECTION
    Private Sub btnChange_Click(sender As Object, e As EventArgs) Handles btnChange.Click
        If Not String.IsNullOrEmpty(hostTxt3.Text) And Not String.IsNullOrEmpty(Div2.Text) Then
            Dim updateQuery As String = "update block_Site set Empl_Status ='" & Div2.Text.ToUpper & "' where site = '" & hostTxt3.Text & "'"
            Dim cmd As New SqlCommand(updateQuery, con)
            con.Open()
            cmd.ExecuteNonQuery()
            MsgBox("Successfully changed")
            con.Close()
        Else
            MsgBox("Enter a non null values ")
        End If
    End Sub


    'END CHANGE SITE CREDENTIALS SECTION


End Class