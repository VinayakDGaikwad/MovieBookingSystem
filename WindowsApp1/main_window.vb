Imports MySqlConnector

Public Class main_window
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim conn As MySqlConnection
        conn = New MySqlConnection("server=localhost;user id=root;password=89660;database=movies;persistsecurityinfo=True")
        conn.Open()
        Dim query As String
        query = " show databases; "
        Dim results
        Dim Command As New MySqlCommand(query, conn)
        Dim rd As MySqlDataReader
        rd = Command.ExecuteReader()
        Do While rd.Read()
            results = results & rd.GetString(0) & vbTab
        Loop
        MsgBox("Data saved Successfully" + results, MsgBoxStyle.MsgBoxRight, "Done")
        conn.Close()
    End Sub

End Class
