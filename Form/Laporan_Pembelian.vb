Imports System.Text

Public Class Laporan_Pembelian

    Private Sub AksiCetakLaporanPembelian(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim tanggal_awal As String = Ttgl_awal.Value.ToString("yyyy-MM-dd")
        Dim tanggal_akhir As String = Ttgl_akhir.Value.ToString("yyyy-MM-dd")
        Dim data_pembelian_tmp As DataTable = Aplikasi.Db.JalankanDanAmbilData("SELECT pembelian.no_nota, DATE_FORMAT(pembelian.tgl_beli, '%d-%m-%Y') AS tgl_beli, pembelian.kode_supplier, supplier.nama_supplier FROM pembelian JOIN supplier ON pembelian.kode_supplier = supplier.kode_supplier WHERE pembelian.tgl_beli >= DATE('" & tanggal_awal & "') AND pembelian.tgl_beli <= DATE('" & tanggal_akhir & "') ORDER BY pembelian.tgl_beli")
        Dim html_data As New StringBuilder
        Dim no As Integer = 1
        Dim total_harga As Integer = 0
        Dim jumlah_beli As Integer = 0
        Dim jumlah_diskon As Integer = 0
        For Each row As DataRow In data_pembelian_tmp.Rows
            html_data.Append("<table style='text-align: left;width: 70%;'>")
            html_data.Append("<tr>")
            html_data.Append("<th style='text-align:left;width: auto;'>No Nota</th>")
            html_data.Append("<td style='text-align:left;width: auto;'>" & row("no_nota") & "</td>")
            html_data.Append("</tr>")
            html_data.Append("<tr>")
            html_data.Append("<th style='text-align:left;width: auto;'>Tanggal</th>")
            html_data.Append("<td style='text-align:left;width: auto;'>" & row("tgl_beli") & "</td>")
            html_data.Append("</tr>")
            html_data.Append("<tr style='text-align:left;width: auto;'>")
            html_data.Append("<th style='text-align:left;width: auto;'>Supplier</th>")
            html_data.Append("<td>" & row("kode_supplier") & " - " & row("nama_supplier") & "</td>")
            html_data.Append("</tr>")
            html_data.Append("</table><br>")

            Dim data_barang_tmp As DataTable = Aplikasi.Db.JalankanDanAmbilData("Select barang.kode_barang, barang.nama_barang, detail_pembelian.harga_barang, " &
            " detail_pembelian.jumlah, detail_pembelian.diskon, detail_pembelian.sub_total, " &
            " barang.satuan From detail_pembelian Inner Join barang On detail_pembelian.kode_barang = barang.kode_barang " &
            " WHERE detail_pembelian.no_nota = '" & row("no_nota") & "'" &
            " Order By detail_pembelian.id_detail")
            html_data.Append("<table>")
            html_data.Append("<tr>")
            html_data.Append("<th>No</th>")
            html_data.Append("<th>Kode Barang</th>")
            html_data.Append("<th>Nama Barang</th>")
            html_data.Append("<th>Jumlah</th>")
            html_data.Append("<th>Satuan</th>")
            html_data.Append("<th>Diskon</th>")
            html_data.Append("<th>Sub Total</th>")
            html_data.Append("</tr>")

            For Each row_beli As DataRow In data_barang_tmp.Rows
                html_data.Append("<tr>")
                html_data.Append("<td>" & no & "</td>")
                html_data.Append("<td>" & row_beli("kode_barang") & "</td>")
                html_data.Append("<td>" & row_beli("nama_barang") & "</td>")
                html_data.Append("<td>" & row_beli("jumlah") & "</td>")
                html_data.Append("<td>" & row_beli("satuan") & "</td>")
                html_data.Append("<td>" & row_beli("diskon") & "</td>")
                html_data.Append("<td>" & row_beli("sub_total") & "</td>")
                html_data.Append("</tr>")
                no += 1
                total_harga += Val(row_beli("sub_total"))
                jumlah_beli += Val(row_beli("jumlah"))
                jumlah_diskon += Val(row_beli("diskon"))
            Next row_beli
            html_data.Append("<tr>")
            html_data.Append("<td colspan='3' style='text-align: right; font-weight: bold;'>Total</td>")
            html_data.Append("<td>" & jumlah_beli & "</td>")
            html_data.Append("<td></td>")
            html_data.Append("<td>" & jumlah_diskon & "</td>")
            html_data.Append("<td>" & total_harga & "</td>")
            html_data.Append("</tr>")
            no = 1
            total_harga = 0
            jumlah_beli = 0
            jumlah_diskon = 0
           
            html_data.Append("</table><br><br>")
            html_data.Append("<hr>")
            
        Next row
        Cetak_Laporan.url = Aplikasi.url_laporan & "laporan-pembelian.html"
        Cetak_Laporan.SetData("tanggal_awal", Ttgl_awal.Value.ToString("dd-MM-yy"))
        Cetak_Laporan.SetData("tanggal_akhir", Ttgl_akhir.Value.ToString("dd-MM-yy"))
        Cetak_Laporan.SetData("tanggal_sekarang", Date.Today.ToString("dd-MM-yyyy"))
        Cetak_Laporan.SetData("data_pembelian", html_data.ToString)
        Cetak_Laporan.ShowDialog()
    End Sub
End Class
