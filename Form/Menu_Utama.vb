Imports System.Text

Public Class Menu_Utama

    Public FBeranda As New Beranda
    Public FBarang As New Data_Barang
    Public FSupplier As New Data_Supplier
    Public FPembelian As New Data_Pembelian
    Public FPenjualan As New Data_Penjualan
    Public FPengguna As New Data_Pengguna
    Public FLaporanPenjualan As New Laporan_Penjualan
    Public FLaporanPembelian As New Laporan_Pembelian
    Public Frop As New Data_Rop
    Public listForm() As Control
    Public currentForm As UserControl
    Public Sub ShowForm(ByVal uc As UserControl, ByVal form As Form)
        Me.currentForm = uc
        form.Size = New Point(uc.Size.Width, uc.Size.Height + 50)
        If uc.Equals(FBeranda) Then
            form.WindowState = FormWindowState.Maximized
        Else
            form.WindowState = FormWindowState.Normal
            form.Location = New Point((My.Computer.Screen.WorkingArea.Width / 2) - (form.Size.Width / 2), (My.Computer.Screen.WorkingArea.Height / 2) - (form.Size.Height / 2))
            uc.Location = New Point(0, 25)
        End If
        For Each f As UserControl In listForm
            f.Hide()
        Next
        uc.Show()
        uc.BringToFront()
    End Sub
    Public Sub HideForm(ByVal uc As UserControl)
        uc.Hide()
    End Sub
    Private Sub Keluar(ByVal sender As Object, ByVal e As EventArgs) Handles KeluarToolStripMenuItem1.Click
        Aplikasi.Show()
        Me.Close()
    End Sub

    Private Sub Init(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen
        listForm = {FBeranda, FBarang, FSupplier, FPembelian, FPenjualan, FLaporanPenjualan, FLaporanPembelian, FPengguna, Frop}
        If Aplikasi.level = "Admin" Then
            TSMENTRI.Enabled = True
            PenggunaToolStripMenuItem.Enabled = True
            PenjualanToolStripMenuItem.Enabled = True
            BarangToolStripMenuItem.Enabled = False
            SupplierToolStripMenuItem.Enabled = False
            PembelianToolStripMenuItem.Enabled = False
            PerhitunganROPToolStripMenuItem.Enabled = False
            TSMlaporan.Enabled = False
        ElseIf Aplikasi.level = "Gudang" Then
            TSMENTRI.Enabled = True
            PenggunaToolStripMenuItem.Enabled = False
            PenjualanToolStripMenuItem.Enabled = False
            BarangToolStripMenuItem.Enabled = True
            SupplierToolStripMenuItem.Enabled = True
            PembelianToolStripMenuItem.Enabled = True
            PerhitunganROPToolStripMenuItem.Enabled = True
            TSMlaporan.Enabled = False
        Else
            TSMENTRI.Enabled = False
            TSMlaporan.Enabled = True
        End If
        Me.Controls.AddRange(listForm)
        ShowForm(FBeranda, Me)
    End Sub

    Private Sub Tampil_Barang(ByVal sender As Object, ByVal e As EventArgs) Handles BarangToolStripMenuItem.Click
        ShowForm(FBarang, Me)
        FBarang.BukaForm()
    End Sub

    Private Sub Tampil_Supplier(ByVal sender As Object, ByVal e As EventArgs) Handles SupplierToolStripMenuItem.Click
        ShowForm(FSupplier, Me)
        FSupplier.BukaForm()
    End Sub

    Private Sub Tampil_Menu_Utama(ByVal sender As Object, ByVal e As EventArgs)
        ShowForm(FBeranda, Me)
    End Sub

    Private Sub Tampil_Pembelian(ByVal sender As Object, ByVal e As EventArgs) Handles PembelianToolStripMenuItem.Click
        ShowForm(FPembelian, Me)
        FPembelian.BukaForm()
    End Sub

    Private Sub Tampil_Penjualan(ByVal sender As Object, ByVal e As EventArgs) Handles PenjualanToolStripMenuItem.Click
        ShowForm(FPenjualan, Me)
        FPenjualan.BukaForm()
    End Sub

    Private Sub LaporanBarang(ByVal sender As Object, ByVal e As EventArgs) Handles BarangToolStripMenuItem1.Click
        Dim data_tmp As DataTable = Aplikasi.Db.JalankanDanAmbilData("SELECT * FROM barang ORDER BY kode_barang")
        Dim html_data As New StringBuilder
        Dim no As Integer = 1
        For Each row As DataRow In data_tmp.Rows
            html_data.Append("<tr>")
            html_data.Append("<td class='table-td'>" & no & "</td>")
            html_data.Append("<td class='table-td'>" & row("kode_barang") & "</td>")
            html_data.Append("<td class='table-td'>" & row("nama_barang") & "</td>")
            html_data.Append("<td class='table-td'>" & row("satuan") & "</td>")
            html_data.Append("<td class='table-td'>" & row("harga_barang") & "</td>")
            html_data.Append("<td class='table-td'>" & row("stock") & "</td>")
            html_data.Append("</tr>")
            no += 1
        Next row
        Cetak_Laporan.url = Aplikasi.url_laporan & "laporan-barang.html"
        Cetak_Laporan.SetData("tanggal", Date.Today.ToString("dd-MM-yyyy"))
        Cetak_Laporan.SetData("data_barang", html_data.ToString)
        Cetak_Laporan.ShowDialog()
    End Sub

    Private Sub MenuLaporanPenjualanHarian(ByVal sender As Object, ByVal e As EventArgs)
        ShowForm(FLaporanPenjualan, Me)
    End Sub

    Private Sub MenuSupplier(ByVal sender As Object, ByVal e As EventArgs) Handles SupplierToolStripMenuItem1.Click
        Dim data_tmp As DataTable = Aplikasi.Db.JalankanDanAmbilData("SELECT * FROM supplier ORDER BY kode_supplier")
        Dim html_data As New StringBuilder
        Dim no As Integer = 1
        For Each row As DataRow In data_tmp.Rows
            html_data.Append("<tr>")
            html_data.Append("<td class='table-td'>" & no & "</td>")
            html_data.Append("<td class='table-td'>" & row("kode_supplier") & "</td>")
            html_data.Append("<td class='table-td'>" & row("nama_supplier") & "</td>")
            html_data.Append("<td class='table-td'>" & row("alamat") & "</td>")
            html_data.Append("<td class='table-td'>" & row("no_telp") & "</td>")
            html_data.Append("</tr>")
            no += 1
        Next row
        Cetak_Laporan.url = Aplikasi.url_laporan & "laporan-supplier.html"
        Cetak_Laporan.SetData("tanggal", Date.Today.ToString("dd-MM-yyyy"))
        Cetak_Laporan.SetData("data_supplier", html_data.ToString)
        Cetak_Laporan.ShowDialog()
    End Sub

    Private Sub MenuPembelian(ByVal sender As Object, ByVal e As EventArgs) Handles PembelianToolStripMenuItem1.Click
        Me.ShowForm(FLaporanPembelian, Me)
    End Sub

    Private Sub PenggunaToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles PenggunaToolStripMenuItem.Click
        Me.ShowForm(FPengguna, Me)
        FPengguna.BukaForm()
    End Sub

    Private Sub PenjualanToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PenjualanToolStripMenuItem1.Click
        ShowForm(FLaporanPenjualan, Me)
    End Sub

    Private Sub PerhitunganROPToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PerhitunganROPToolStripMenuItem.Click
        ShowForm(Frop, Me)
    End Sub

    Private Sub ROPToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ROPToolStripMenuItem.Click
        Dim data_tmp As DataTable = Aplikasi.Db.JalankanDanAmbilData("SELECT eoq_rop.*, barang.nama_barang FROM eoq_rop JOIN barang ON eoq_rop.kode_barang = barang.kode_barang ORDER BY eoq_rop.tgl_hitung DESC")
        Dim html_data As New StringBuilder
        Dim no As Integer = 1
        For Each row As DataRow In data_tmp.Rows
            html_data.Append("<tr>")
            html_data.Append("<td class='table-td'>" & no & "</td>")
            html_data.Append("<td class='table-td'>" & row("kode_hitung") & "</td>")
            html_data.Append("<td class='table-td'>" & row("kode_barang") & "</td>")
            html_data.Append("<td class='table-td'>" & row("nama_barang") & "</td>")
            html_data.Append("<td class='table-td'>" & row("tgl_hitung") & "</td>")
            html_data.Append("<td class='table-td'>" & row("kebutuhan_per_hari") & "</td>")
            html_data.Append("<td class='table-td'>" & row("kebutuhan_per_tahun") & "</td>")
            html_data.Append("<td class='table-td'>" & row("biaya_pesan") & "</td>")
            html_data.Append("<td class='table-td'>" & row("harga_beli") & "</td>")
            html_data.Append("<td class='table-td'>" & row("biaya_simpan") & "</td>")
            html_data.Append("<td class='table-td'>" & row("leadtime") & "</td>")
            html_data.Append("<td class='table-td'>" & row("eoq") & "</td>")
            html_data.Append("<td class='table-td'>" & row("rop") & "</td>")
            html_data.Append("</tr>")
            no += 1
        Next row
        Cetak_Laporan.url = Aplikasi.url_laporan & "laporan-eoq-rop.html"
        Cetak_Laporan.SetData("tanggal", Date.Today.ToString("dd-MM-yyyy"))
        Cetak_Laporan.SetData("data_rop", html_data.ToString)
        Cetak_Laporan.ShowDialog()
    End Sub

    Private Sub Menu_Utama_SizeChanged(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
        If currentForm IsNot Nothing Then
            currentForm.Location = New Point((Me.Width / 2) - (currentForm.Size.Width / 2), (Me.Height / 2) - (currentForm.Size.Height / 2))
        End If
    End Sub
End Class