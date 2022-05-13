Imports MySqlConnector

Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Establish Connection to Localhost Server
        Dim conn As MySqlConnection
        conn = New MySqlConnection("server=localhost;user id=root;password=89660;database=movies;persistsecurityinfo=True")
        conn.Open()

        'Make Query
        Dim query As String
        query = " select * from showtimes; "

        Dim Command As New MySqlCommand(query, conn)

        'Result is Stored Here
        Dim result As MySqlDataReader
        result = Command.ExecuteReader()

        'For each record in result
        Do While result.Read()
            Dim newL As New Label
            newL.Name = "tbNew"
            newL.Text = result.GetString(0)
            'Set location, size and so on if you like
            Me.FlowLayoutPanel1.Controls.Add(newL)
        Loop

        'MsgBox("Data saved Successfully", MsgBoxStyle.MsgBoxRight, "Done")

        conn.Close()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class