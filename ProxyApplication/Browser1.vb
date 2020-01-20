Imports System.Data.SqlClient

Public Class Browser1
    Dim con As New SqlConnection("server=TEAMIT-PC;database=testclass;integrated security=SSPI")
    Private Sub Eid_TextChanged(sender As Object, e As EventArgs) Handles Eid.Click
        If Eid.Text = "ID" Then
            Eid.Text = ""
        End If
    End Sub

    Private Sub Pass_TextChanged(sender As Object, e As EventArgs) Handles Pass.Click
        If Pass.Text = "Password" Then
            Pass.Text = ""
        End If
    End Sub

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        If Not String.IsNullOrEmpty(Eid.Text) And Not String.IsNullOrEmpty(Pass.Text) Then
            Dim sql As String = "Select * from table_2 where ID ='" & Eid.Text & "' and Password ='" & Pass.Text & "'"
            MsgBox("Pass1")
            Dim cmd As New SqlCommand(sql, con)
            Dim adapter As New SqlDataAdapter(cmd)
            Dim dt As New DataTable()
            con.Open()
            adapter = New SqlDataAdapter(sql, con)
            adapter.Fill(dt)

            If dt.Rows.Count > 0 Then
                If dt.Rows.Item(0).Item("Empl_Status").SubString(0, 1).ToString.ToUpper = "A" Then
                    Dim crt As New Admin()
                    crt.Show()
                    MsgBox("Welcome Admin")
                ElseIf dt.Rows.Item(0).Item("Empl_Status").SubString(0, 1).ToString.ToUpper = "H" Then
                    Dim crt As New Form1(dt.Rows.Item(0).Item("ID").ToString)
                    crt.Show()
                    MsgBox("Welcome HOD")
                ElseIf dt.Rows.Item(0).Item("Empl_Status").SubString(0, 1).ToString.ToUpper = "E" Then
                    Dim crt As New Browser_E(dt.Rows.Item(0).Item("ID").ToString)
                    crt.Show()
                    MsgBox("Welcome")
                Else
                    MsgBox("ID not Registered ! (ERRSQLNOFND)")
                End If
                con.Close()
            End If
        Else
            MsgBox("Enter a Valid ID and Passcode (ERRTXTNULL)")

        End If
    End Sub
End Class