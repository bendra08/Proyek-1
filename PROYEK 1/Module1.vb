﻿Imports MySql.Data.MySqlClient
Module Module1
    Public conn As MySqlConnection
    Public cmd As MysqlCommand
    Public rd As MysqlDataReader
    Public da As MysqlDataAdapter
    Public ds As DataSet
    Public str As String
    Public status As StringFormat


    Sub koneksi()
        Try
            Dim str As String = "Server=localhost;user id=root;password=;database=proyek_1; Convert Zero Datetime=True"
            conn = New MySqlConnection(str)
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub
End Module





