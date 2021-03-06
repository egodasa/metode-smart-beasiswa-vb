Public Class Aplikasi
    Public Db As New Db()
    Public level As String
    Public username As String
    Public url_laporan As String = "Laporan\"
    Private Sub Keluar(sender As Object, e As EventArgs) Handles Breset.Click
        Me.Close()
    End Sub

    Private Sub ResetLogin()
        Tusername.Clear()
        Tpassword.Clear()
    End Sub

    Private Sub Login(sender As Object, e As EventArgs) Handles Bsimpan.Click
        Dim username As String = Tusername.Text
        Dim password As String = Tpassword.Text
        Dim cek_login As New DataTable
        cek_login = Db.JalankanDanAmbilData("SELECT * FROM pengguna WHERE username = '" & username & "' AND password = md5('" & password & "')")
        If cek_login.Rows.Count = 0 Then
            MessageBox.Show("Username atau password salah!", "Peringatan")
        Else
            Me.username = username
            Me.level = cek_login.Rows(0).Item("level").ToString
            MessageBox.Show("Anda berhasil login, " & username, "Pesan")
            Me.Hide()
            Menu_Utama.Show()
        End If
        ResetLogin()
    End Sub



    Public Function GenerateKode(ByVal tabel As String, ByVal kolom As String, ByVal prefix As String, Optional ByVal banyak_nol As Integer = 5)
        Dim no_nota As String
        Dim nomor As DataTable = Db.JalankanDanAmbilData("SELECT CONCAT('" & prefix & "', LPAD((right(" & kolom & ", " & banyak_nol + 1 & ") + 1), " & banyak_nol + 1 & ", '0')) AS kode FROM `" & tabel & "` ORDER BY `" & kolom & "` DESC LIMIT 1")
        If nomor.Rows.Count = 0 Then
            no_nota = prefix + "1".PadLeft(banyak_nol + 1, "0")
        Else
            no_nota = nomor.Rows(0).Item("kode")
        End If
        Return no_nota
    End Function

    Private Sub ResizeControl()
        'WBcetak.Width = Me.Width
        'WBcetak.Height = (Me.Height - Panel1.Height)
        'Panel1.Width = Me.Width
    End Sub

    Private Sub Aplikasi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Location = New Point((My.Computer.Screen.WorkingArea.Width / 2) - (Me.Size.Width / 2), (My.Computer.Screen.WorkingArea.Height / 2) - (Me.Size.Height / 2))
    End Sub
End Class