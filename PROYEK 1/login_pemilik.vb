Imports MySql.Data.MySqlClient
Public Class login_pemilik

    Private Sub Button_1_Click(sender As System.Object, e As System.EventArgs) Handles Button_1.Click
        Dim conn As MySqlConnection
        Dim comm As MySqlCommand
        Dim Reader As MySqlDataReader
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;user id=root;database=proyek_1"

        Try
            conn.Open()
            Dim Query As String
            Dim count As Integer

            Query = "select * from proyek_1.login where user_name='" & TextBox1.Text & "' and password='" & TextBox2.Text & "'"

            comm = New MySqlCommand(Query, conn)
            Reader = comm.ExecuteReader
            count = 0
            While Reader.Read
                count = count + 1
            End While

            If count = 1 Then
                MessageBox.Show("Welcome!")
                menu_pemilik.Show()

            ElseIf count > 1 Then
                MessageBox.Show("Username and Password are duplicate")

            Else
                MessageBox.Show("Username and Password are not correct")

            End If

            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try


    End Sub
End Class