Imports System.Text

Public Class Laporan_Penjualan
    Private Sub AksiCetakPejualanHarian(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        Dim tanggal As String = Ttgl.Value.ToString("yyyy-MM-dd")
        Dim data_tmp As DataTable = Aplikasi.Db.JalankanDanAmbilData("SELECT barang.kode_barang, barang.nama_barang, barang.satuan, IFNULL(laporan.total_harga, 0) AS total_harga, IFNULL(laporan.jumlah_terjual, 0) AS jumlah_terjual FROM barang LEFT JOIN (Select " &
    " barang.kode_barang, SUM(detail_penjualan.sub_total) AS total_harga, SUM(detail_penjualan.jumlah) AS jumlah_terjual " &
    " From barang Inner Join detail_penjualan On detail_penjualan.kode_barang = barang.kode_barang Inner Join " &
    " penjualan On detail_penjualan.no_nota = penjualan.no_nota where penjualan.tgl_jual = DATE('" & tanggal & "') group by barang.kode_barang) laporan ON barang.kode_barang = laporan.kode_barang ORDER BY barang.kode_barang")
        Dim html_data As New StringBuilder
        Dim no As Integer = 1
        Dim total_harga As Integer = 0
        Dim jumlah_terjual As Integer = 0
        For Each row As DataRow In data_tmp.Rows
            html_data.Append("<tr>")
            html_data.Append("<td class='table-td'>" & no & "</td>")
            html_data.Append("<td class='table-td'>" & row("kode_barang") & "</td>")
            html_data.Append("<td class='table-td'>" & row("nama_barang") & "</td>")
            html_data.Append("<td class='table-td'>" & row("jumlah_terjual") & "</td>")
            html_data.Append("<td class='table-td'>" & row("satuan") & "</td>")
            html_data.Append("<td class='table-td'>" & row("total_harga") & "</td>")
            html_data.Append("</tr>")
            no += 1
            total_harga += Val(row("total_harga"))
            jumlah_terjual += Val(row("jumlah_terjual"))
        Next row
        Cetak_Laporan.url = Aplikasi.url_laporan & "laporan-penjualan-harian.html"
        Cetak_Laporan.SetData("tanggal", Ttgl.Value.ToString("dd-MM-yy"))
        Cetak_Laporan.SetData("tanggal_sekarang", Date.Today.ToString("dd-MM-yyyy"))
        Cetak_Laporan.SetData("data_penjualan", html_data.ToString)
        Cetak_Laporan.SetData("total_harga", total_harga)
        Cetak_Laporan.SetData("jumlah_terjual", jumlah_terjual)
        Cetak_Laporan.ShowDialog()
    End Sub

    Private Sub AksiCetakLaporanPenjualanBulanan(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim tanggal As String = Tbulan.Value.ToString("yyyy-MM-01")
        Dim data_tmp As DataTable = Aplikasi.Db.JalankanDanAmbilData("SELECT barang.kode_barang, barang.nama_barang, barang.satuan, IFNULL(laporan.total_harga, 0) AS total_harga, IFNULL(laporan.jumlah_terjual, 0) AS jumlah_terjual FROM barang LEFT JOIN (Select " &
    " barang.kode_barang, SUM(detail_penjualan.sub_total) AS total_harga, SUM(detail_penjualan.jumlah) AS jumlah_terjual " &
    " From barang Inner Join detail_penjualan On detail_penjualan.kode_barang = barang.kode_barang Inner Join " &
    " penjualan On detail_penjualan.no_nota = penjualan.no_nota where MONTH(penjualan.tgl_jual) = MONTH('" & tanggal & "') AND YEAR(penjualan.tgl_jual) = YEAR('" & tanggal & "') group by barang.kode_barang) laporan ON barang.kode_barang = laporan.kode_barang ORDER BY barang.kode_barang")
        Dim html_data As New StringBuilder
        Dim no As Integer = 1
        Dim total_harga As Integer = 0
        Dim jumlah_terjual As Integer = 0
        For Each row As DataRow In data_tmp.Rows
            html_data.Append("<tr>")
            html_data.Append("<td class='table-td'>" & no & "</td>")
            html_data.Append("<td class='table-td'>" & row("kode_barang") & "</td>")
            html_data.Append("<td class='table-td'>" & row("nama_barang") & "</td>")
            html_data.Append("<td class='table-td'>" & row("jumlah_terjual") & "</td>")
            html_data.Append("<td class='table-td'>" & row("satuan") & "</td>")
            html_data.Append("<td class='table-td'>" & row("total_harga") & "</td>")
            html_data.Append("</tr>")
            no += 1
            total_harga += Val(row("total_harga"))
            jumlah_terjual += Val(row("jumlah_terjual"))
        Next row
        Cetak_Laporan.url = Aplikasi.url_laporan & "laporan-penjualan-bulanan.html"
        Cetak_Laporan.SetData("tanggal", Tbulan.Value.ToString("MM-yyyy"))
        Cetak_Laporan.SetData("tanggal_sekarang", Date.Today.ToString("dd-MM-yyyy"))
        Cetak_Laporan.SetData("data_penjualan", html_data.ToString)
        Cetak_Laporan.SetData("total_harga", total_harga)
        Cetak_Laporan.SetData("jumlah_terjual", jumlah_terjual)
        Cetak_Laporan.ShowDialog()
    End Sub

    Private Sub AksiCetakLaporanPenjualanTahunan(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim tanggal As String = Ttahun.Value.ToString("yyyy-01-01")
        Dim data_tmp As DataTable = Aplikasi.Db.JalankanDanAmbilData("SELECT barang.kode_barang, barang.nama_barang, barang.satuan, IFNULL(laporan.total_harga, 0) AS total_harga, IFNULL(laporan.jumlah_terjual, 0) AS jumlah_terjual FROM barang LEFT JOIN (Select " &
    " barang.kode_barang, SUM(detail_penjualan.sub_total) AS total_harga, SUM(detail_penjualan.jumlah) AS jumlah_terjual " &
    " From barang Inner Join detail_penjualan On detail_penjualan.kode_barang = barang.kode_barang Inner Join " &
    " penjualan On detail_penjualan.no_nota = penjualan.no_nota where YEAR(penjualan.tgl_jual) = YEAR('" & tanggal & "') group by barang.kode_barang) laporan ON barang.kode_barang = laporan.kode_barang ORDER BY barang.kode_barang")
        Dim html_data As New StringBuilder
        Dim no As Integer = 1
        Dim total_harga As Integer = 0
        Dim jumlah_terjual As Integer = 0
        For Each row As DataRow In data_tmp.Rows
            html_data.Append("<tr>")
            html_data.Append("<td class='table-td'>" & no & "</td>")
            html_data.Append("<td class='table-td'>" & row("kode_barang") & "</td>")
            html_data.Append("<td class='table-td'>" & row("nama_barang") & "</td>")
            html_data.Append("<td class='table-td'>" & row("jumlah_terjual") & "</td>")
            html_data.Append("<td class='table-td'>" & row("satuan") & "</td>")
            html_data.Append("<td class='table-td'>" & row("total_harga") & "</td>")
            html_data.Append("</tr>")
            no += 1
            total_harga += Val(row("total_harga"))
            jumlah_terjual += Val(row("jumlah_terjual"))
        Next row
        Cetak_Laporan.url = Aplikasi.url_laporan & "laporan-penjualan-tahunan.html"
        Cetak_Laporan.SetData("tanggal", Ttahun.Value.ToString("yyyy"))
        Cetak_Laporan.SetData("tanggal_sekarang", Date.Today.ToString("dd-MM-yyyy"))
        Cetak_Laporan.SetData("data_penjualan", html_data.ToString)
        Cetak_Laporan.SetData("total_harga", total_harga)
        Cetak_Laporan.SetData("jumlah_terjual", jumlah_terjual)
        Cetak_Laporan.ShowDialog()
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub Ttgl_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ttgl.ValueChanged

    End Sub
End Class
