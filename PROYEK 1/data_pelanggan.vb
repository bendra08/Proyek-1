Imports MySql.Data.MySqlClient
Public Class data_pelanggan
    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call koneksi()
        Call tampildatapelanggan()
        Call datagrind()
    End Sub
    Sub tambahpelanggan()
        Try
            Call koneksi()
            Dim str As String
            str = "insert into data_pelanggan(KODE_PELANGGAN,NAMA_PELANGGAN,ALAMAT,NO_HP,TIPE_PELANGGAN,TANGGAL_MASUK_PELANGGAN) values('" & TextBox4.Text & "','" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & ComboBox1.Text & "','" & DateTimePicker1.Value & "')"

            cmd = New MySqlCommand(str, conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("data pelanggan berhasil ditambahkan")
            Call tampildatapelanggan()
        Catch ex As Exception
            MessageBox.Show("data pelanggan tidak berhasil ditambahkan")
        End Try

    End Sub

    Private Sub Tambah_Click(sender As System.Object, e As System.EventArgs) Handles Tambah.Click
        Call tambahpelanggan()

    End Sub
    Sub tampildatapelanggan()

        Call koneksi()
        da = New MySqlDataAdapter("select * from data_pelanggan", conn)

        ds = New DataSet()

        da.Fill(ds, "data_pelanggan")

        DataGridView1.DataSource = ds.Tables(0)

    End Sub
    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        TextBox4.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value()
        TextBox1.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value()
        TextBox2.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value()
        TextBox3.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value()
        ComboBox1.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value()
        DateTimePicker1.Value = DataGridView1.Rows(e.RowIndex).Cells(5).Value()
    End Sub
    Sub datagrind()
        Call koneksi()
        Try
            DataGridView1.Columns(0).Width = 100
            DataGridView1.Columns(1).Width = 150
            DataGridView1.Columns(2).Width = 150
            DataGridView1.Columns(3).Width = 150
            DataGridView1.Columns(4).Width = 150
            DataGridView1.Columns(5).Width = 150
            DataGridView1.Columns(0).HeaderText = "KODE_PELANGGAN"
            DataGridView1.Columns(1).HeaderText = "NAMA_PELANGGAN"
            DataGridView1.Columns(2).HeaderText = "ALAMAT_PELANGGAN"
            DataGridView1.Columns(3).HeaderText = "NO_HP"
            DataGridView1.Columns(4).HeaderText = "TIPE_PELANGGAN"
            DataGridView1.Columns(5).HeaderText = "TANGGAL_MASUK_PELANGGAN"
        Catch ex As Exception

        End Try
    End Sub
    Sub editdatapelanggan()

        Try
            Call koneksi()
            Dim str As String
            str = "Update data_pelanggan set KODE_PELANGGAN = '" & TextBox4.Text & "', NAMA_PELANGGAN = '" & TextBox1.Text & "', ALAMAT = '" & TextBox2.Text & "', NO_HP = '" & TextBox4.Text & "', TIPE_PELANGGAN = '" & ComboBox1.Text & "',TANGGAL_MASUK_PELANGGAN ='" & DateTimePicker1.Value & "'"
            cmd = New MySqlCommand(str, conn)
            cmd.ExecuteNonQuery()

            MessageBox.Show("data pelanggan Berhasil Dirubah")
            Call tampildatapelanggan()
        Catch ex As Exception
            MessageBox.Show("data pelanggan tidak dapat diubah")
        End Try
    End Sub
    Private Sub Edit_Click(sender As System.Object, e As System.EventArgs) Handles Edit.Click
        Call editdatapelanggan()
    End Sub
    Sub deletepelanggan()
        Try
            Call koneksi()
            Dim str As String
            str = "delete from data_pelanggan where KODE_PELANGGAN = '" & TextBox4.Text & "'"
            cmd = New MySqlCommand(str, conn)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Data pelanggan berhasil dihapus.")
            Call tampildatapelanggan()
        Catch ex As Exception
            MessageBox.Show("Data pelanggan tidak dapat dihapus.")

        End Try
    End Sub
    Private Sub Hapus_Click(sender As System.Object, e As System.EventArgs) Handles Hapus.Click
        Call deletepelanggan()
    End Sub

    Private Sub Cancel_Click(sender As System.Object, e As System.EventArgs) Handles Cancel.Click
        TextBox4.Clear()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()

    End Sub
End Class