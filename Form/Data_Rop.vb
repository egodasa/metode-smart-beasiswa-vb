Public Class Data_Rop
    Private Sub Keluar(sender As Object, e As EventArgs)
        Menu_Utama.ShowForm(Menu_Utama.FBeranda, Menu_Utama)
    End Sub

    Private Function AmbilNilaiPendapatan(ByVal nilai As String)
        If nilai = "1.500.000" Then
            Return "100"
        ElseIf nilai = "1.501.000 - 2.500.000" Then
            Return "80"
        ElseIf nilai = "2.500.001 - 3.500.000" Then
            Return "60"
        ElseIf nilai = "3.500.001 - 4.500.000" Then
            Return "40"
        ElseIf nilai = "> 4.500.000" Then
            Return "20"
        End If
        Return "0"
    End Function
    Private Function AmbilNilaiKondisiOrtu(ByVal nilai As String)
        If nilai = "Masih Hidup" Then
            Return "20"
        ElseIf nilai = "Yatim" Then
            Return "80"
        ElseIf nilai = "Piatu" Then
            Return "60"
        ElseIf nilai = "Yatim Piatu" Then
            Return "100"
        End If
        Return "0"
    End Function

    Private Function AmbilNilaiRaport(ByVal nilai As String)
        Dim nilai_asli As Integer = CInt(nilai)
        If nilai_asli >= 0 Or nilai_asli <= 100 Then
            Return nilai
        End If
        Return "0"
    End Function
    Private Function AmbilNilaiJumlahTanggungan(ByVal nilai As String)
        If nilai = ">= 5" Then
            Return "100"
        ElseIf nilai = "4" Then
            Return "80"
        ElseIf nilai = "3" Then
            Return "60"
        ElseIf nilai = "2" Then
            Return "40"
        ElseIf nilai = "1" Then
            Return "20"
        End If
        Return "0"
    End Function

    Private Function AmbilNilaiPekerjaan(ByVal nilai As String)
        If nilai = "Tidak Bekerja" Then
            Return "100"
        ElseIf nilai = "Buruh Pabrik/Petani" Then
            Return "80"
        ElseIf nilai = "Swasta" Then
            Return "60"
        ElseIf nilai = "Wiraswasta" Then
            Return "40"
        ElseIf nilai = "PNS" Then
            Return "20"
        End If
        Return "0"
    End Function

    Private Sub Bhitung_Click(sender As Object, e As EventArgs) Handles Bhitung.Click
        If Tnm_perhitungan.Text = "" Then
            MessageBox.Show("Nama perhitungan tidak boleh kosong")
            Return
        End If

        ' masukan data perhitungan dan ambil id nya
        Aplikasi.Db.JalankanSql("INSERT INTO tb_hitung (nm_hitung) VALUE ('" & Tnm_perhitungan.Text & "')")
        Dim id As DataTable = Aplikasi.Db.JalankanDanAmbilData("SELECT LAST_INSERT_ID() AS id")
        If Aplikasi.Db.ApakahError() = True Then
            MessageBox.Show("Error : " & Aplikasi.Db.AmbilPesanError(), "Pesan")
        Else
            ' lanjut entri ke data alternatif

            If Aplikasi.Db.ApakahError() = True Then
                MessageBox.Show("Error : " & Aplikasi.Db.AmbilPesanError(), "Pesan")
            Else
                ' lanjut ke query perhitungan dan simpan (insert dengan select)
                If Aplikasi.Db.ApakahError() = True Then
                    MessageBox.Show("Error : " & Aplikasi.Db.AmbilPesanError(), "Pesan")
                Else
                    'tampilkan hasilnya ke 
                End If

            End If
        End If
    End Sub
End Class