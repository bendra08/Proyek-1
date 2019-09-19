Imports MySql.Data.MySqlClient
Public Class barang_keluar
    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call koneksi()
        Call tampilbarangkeluar()
        Call datagrind()
    End Sub
    Sub tambahbarang()
        Try
            Call koneksi()
            Dim str As String
            str = "insert into barang_keluar(KODE_BARANG,NAMA_BARANG,TANGGAL_BARANG_KELUAR,JUMLAH_BARANG,HARGA_BARANG) values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & DateTimePicker1.Value & "','" & TextBox3.Text & "','" & TextBox4.Text & "')"
            cmd = New MySqlCommand(str, conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Barang berhasil ditambahkan")
            Call tampilbarangkeluar()
        Catch ex As Exception
            MessageBox.Show("Barang tidak berhasil ditambahkan")
        End Try

    End Sub

    Private Sub Tambah_Click(sender As System.Object, e As System.EventArgs) Handles Tambah.Click
        Call tambahbarang()
    End Sub
    Sub tampilbarangkeluar()

        Call koneksi()
        da = New MySqlDataAdapter("select * from barang_keluar", conn)

        ds = New DataSet()

        da.Fill(ds, "barang_keluar")

        DataGridView1.DataSource = ds.Tables(0)

    End Sub
    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        TextBox1.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value()
        TextBox2.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value()
        DateTimePicker1.Value = DataGridView1.Rows(e.RowIndex).Cells(2).Value()
        TextBox3.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value()
        TextBox4.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value()
    End Sub
    Sub datagrind()
        Call koneksi()
        Try
            DataGridView1.Columns(0).Width = 100
            DataGridView1.Columns(1).Width = 150
            DataGridView1.Columns(2).Width = 150
            DataGridView1.Columns(3).Width = 150
            DataGridView1.Columns(4).Width = 150
            DataGridView1.Columns(0).HeaderText = "KODE_BARANG"
            DataGridView1.Columns(1).HeaderText = "NAMA_BARANG"
            DataGridView1.Columns(2).HeaderText = "TANGGAL_BARANG_KELUAR"
            DataGridView1.Columns(3).HeaderText = "JUMLAH_BARANG"
            DataGridView1.Columns(4).HeaderText = "HARGA_BARANG"

        Catch ex As Exception

        End Try
    End Sub
    Sub editbarangkeluar()

        Try
            Call koneksi()
            Dim str As String
            str = "Update barang_keluar set KODE_BARANG = '" & TextBox1.Text & "', NAMA_BARANG = '" & TextBox2.Text & "', TANGGAL_BARANG_KELUAR = '" & DateTimePicker1.Value & "', JUMLAH_BARANG = '" & TextBox3.Text & "', HARGA_BARANG = '" & TextBox4.Text & "'"
            cmd = New MySqlCommand(str, conn)
            cmd.ExecuteNonQuery()

            MessageBox.Show("barang Berhasil Dirubah")
            Call tampilbarangkeluar()
        Catch ex As Exception
            MessageBox.Show("barang tidak dapat diubah")
        End Try
    End Sub

    Private Sub Edit_Click(sender As System.Object, e As System.EventArgs) Handles Edit.Click
        Call Editbarangkeluar()
    End Sub
    Sub deleteBarang()
        Try
            Call koneksi()
            Dim str As String
            str = "delete from barang_keluar where KODE_BARANG = '" & TextBox1.Text & "'"
            cmd = New MySqlCommand(str, conn)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Data barang berhasil dihapus.")
            Call tampilbarangkeluar()
        Catch ex As Exception
            MessageBox.Show("Data barang tidak dapat dihapus.")

        End Try
    End Sub

    Private Sub Hapus_Click(sender As System.Object, e As System.EventArgs) Handles Hapus.Click
        Call deleteBarang()
    End Sub

    Private Sub Cancel_Click(sender As System.Object, e As System.EventArgs) Handles Cancel.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
    End Sub
End Class
