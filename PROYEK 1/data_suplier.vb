Imports MySql.Data.MySqlClient
Public Class data_suplier
    Private Sub Form5_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call koneksi()
        Call tampildatasuplier()
        Call datagrind()
    End Sub
    Sub tambahsuplier()
        Try
            Call koneksi()
            Dim str As String
            str = "insert into data_suplier(KODE_SUPLIER,NAMA_SUPLIER,ALAMAT,TELEPON,EMAIL) values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox5.Text & "','" & TextBox4.Text & "')"

            cmd = New MySqlCommand(str, conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("data suplier berhasil ditambahkan")
            Call tampildatasuplier()
        Catch ex As Exception
            MessageBox.Show("data suplier tidak berhasil ditambahkan")
        End Try
    End Sub

    Private Sub Tambah_Click(sender As System.Object, e As System.EventArgs) Handles Tambah.Click
        Call tambahsuplier()
    End Sub
    Sub tampildatasuplier()

        Call koneksi()
        da = New MySqlDataAdapter("select * from data_suplier", conn)

        ds = New DataSet()

        da.Fill(ds, "data_suplier")

        DataGridView1.DataSource = ds.Tables(0)

    End Sub
    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        TextBox1.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value()
        TextBox2.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value()
        TextBox3.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value()
        TextBox5.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value()
        TextBox4.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value()

    End Sub
    Sub datagrind()
        Call koneksi()
        Try
            DataGridView1.Columns(0).Width = 200
            DataGridView1.Columns(1).Width = 200
            DataGridView1.Columns(2).Width = 200
            DataGridView1.Columns(3).Width = 200
            DataGridView1.Columns(4).Width = 200
            DataGridView1.Columns(0).HeaderText = "KODE_SUPLIER"
            DataGridView1.Columns(1).HeaderText = "NAMA_SUPLIER"
            DataGridView1.Columns(2).HeaderText = "ALAMAT"
            DataGridView1.Columns(3).HeaderText = "TELEPON"
            DataGridView1.Columns(4).HeaderText = "EMAIL"
        Catch ex As Exception

        End Try
    End Sub
    Sub editdatasuplier()
        Try
            Call koneksi()
            Dim str As String
            str = "Update data_suplier set KODE_SUPLIER = '" & TextBox1.Text & "', NAMA_SUPLIER = '" & TextBox2.Text & "', ALAMAT= '" & TextBox3.Text & "', TELEPON = '" & TextBox5.Text & "',EMAIL ='" & TextBox4.Text & "'"
            cmd = New MySqlCommand(str, conn)
            cmd.ExecuteNonQuery()

            MessageBox.Show("data suplier Berhasil Dirubah")
            Call tampildatasuplier()
        Catch ex As Exception
            MessageBox.Show("data suplier gagal diubah")
        End Try
    End Sub

    Private Sub Edit_Click(sender As System.Object, e As System.EventArgs) Handles Edit.Click
        Call editdatasuplier()
    End Sub
    Sub deletesuplier()
        Try
            Call koneksi()
            Dim str As String
            str = "delete from data_suplier where KODE_SUPLIER = '" & TextBox1.Text & "'"
            cmd = New MySqlCommand(str, conn)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Data suplier berhasil dihapus.")
            Call tampildatasuplier()
        Catch ex As Exception
            MessageBox.Show("Data suplier gagal dihapus.")
        End Try
    End Sub

    Private Sub Hapus_Click(sender As System.Object, e As System.EventArgs) Handles Hapus.Click
        Call deletesuplier()

    End Sub

    Private Sub Cancel_Click_1(sender As System.Object, e As System.EventArgs) Handles Cancel.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox5.Clear()
        TextBox4.Clear()
    End Sub
End Class