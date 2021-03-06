Public Class Data_Barang
    Private Sub Keluar(sender As Object, e As EventArgs) 
        Menu_Utama.ShowForm(Menu_Utama.FBeranda, Menu_Utama)
    End Sub
    Private Sub TampilData()
        DGbarang.Rows.Clear()
        DGbarang.DataSource = Nothing
        Dim data_barang As DataTable = Aplikasi.Db.JalankanDanAmbilData("SELECT * FROM barang")
        Dim nomor As Int16 = 1
        For Each row As DataRow In data_barang.Rows
            DGbarang.Rows.Add(New String() {
            nomor.ToString,
            row.Item("kode_barang"),
            row.Item("nama_barang"),
            row.Item("harga_barang"),
            row.Item("stock"),
            row.Item("satuan")
            })
            nomor += 1
        Next row
    End Sub
    Private Sub TambahData()
        Dim kode_barang As String = Tkode_barang.Text
        Dim nama_barang As String = Tnama_barang.Text
        Dim harga_barang As Integer = Tharga_barang.Text
        Dim stock As Integer = Tstock.Text
        Dim satuan As String = Tsatuan.Text
        Dim sql_tambah As String = "INSERT INTO barang " &
            "(kode_barang, nama_barang, harga_barang, stock, satuan) VALUES " &
            "('" & kode_barang & "','" & nama_barang & "','" & harga_barang & "','" & stock & "', '" & satuan & "')"
        Aplikasi.Db.JalankanSql(sql_tambah)
        If Aplikasi.Db.ApakahError() = True Then
            MessageBox.Show("Error : " & Aplikasi.Db.AmbilPesanError(), "Pesan")
        Else
            MessageBox.Show("Data berhasil disimpan!", "Pesan")
            ResetData()
            TampilData()
        End If
    End Sub
    Private Sub EditData()
        Dim kode_barang As String = Tkode_barang.Text
        Dim nama_barang As String = Tnama_barang.Text
        Dim harga_barang As Integer = Tharga_barang.Text
        Dim stock As Integer = Tstock.Text
        Dim satuan As String = Tsatuan.Text
        Dim sql_edit As String = "UPDATE barang SET nama_barang = '" & nama_barang & "'," &
            "harga_barang = '" & harga_barang & "', " &
            "stock = '" & stock & "', " &
            "satuan = '" & satuan & "' WHERE kode_barang = '" & kode_barang & "'"
        Aplikasi.Db.JalankanSql(sql_edit)
        If Aplikasi.Db.ApakahError() = True Then
            MessageBox.Show("Error : " & Aplikasi.Db.AmbilPesanError(), "Pesan")
        Else
            MessageBox.Show("Data berhasil disimpan!", "Pesan")
            ResetData()
            TampilData()
        End If
    End Sub
    Private Sub HapusData()
        Dim data_terpilih As Int16 = DGbarang.CurrentRow.Index
        Dim sql_hapus As String = "DELETE FROM barang WHERE kode_barang = '" & DGbarang.Rows(data_terpilih).Cells("kode_barang").Value & "'"
        Aplikasi.Db.JalankanSql(sql_hapus)
        If Aplikasi.Db.ApakahError() = True Then
            MessageBox.Show("Error : " & Aplikasi.Db.AmbilPesanError(), "Pesan")
        Else
            MessageBox.Show("Data berhasil dihapus!", "Pesan")
            TampilData()
        End If
        TampilData()
    End Sub
    Private Sub AmbilData()
        Dim data_terpilih As Int16 = DGbarang.CurrentRow.Index
        Tkode_barang.Text = DGbarang.Rows(data_terpilih).Cells("kode_barang").Value
        Tnama_barang.Text = DGbarang.Rows(data_terpilih).Cells("nama_barang").Value
        Tharga_barang.Text = DGbarang.Rows(data_terpilih).Cells("harga_barang").Value
        Tstock.Text = DGbarang.Rows(data_terpilih).Cells("stock").Value
        Tsatuan.Text = DGbarang.Rows(data_terpilih).Cells("satuan").Value
    End Sub
    Private Sub ResetData()
        Tkode_barang.Clear()
        Tnama_barang.Clear()
        Tharga_barang.Value = 0
        Tstock.Value = 0
        Tsatuan.Clear()
        Tkode_barang.Text = Aplikasi.GenerateKode("barang", "kode_barang", "BR", 2)
    End Sub

    Private Sub Simpan(sender As Object, e As EventArgs) Handles Bsimpan.Click
        TambahData()
    End Sub

    Private Sub Edit(sender As Object, e As EventArgs) Handles Button1.Click
        EditData()
    End Sub

    Private Sub Hapus(sender As Object, e As EventArgs) Handles Button2.Click
        HapusData()
        ResetData()
    End Sub

    Private Sub AmbilDataBarang(sender As Object, e As DataGridViewCellEventArgs) Handles DGbarang.CellContentClick
        AmbilData()
    End Sub

    Public Sub BukaForm()
        TampilData()
        ResetData()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ResetData()
    End Sub

    Private Sub Data_Barang_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
