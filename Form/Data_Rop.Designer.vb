<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Data_Rop
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DGperhitungan = New System.Windows.Forms.DataGridView()
        Me.nis = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nm_siswa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tempat_lahir = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tgl_lahir = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kelas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.alamat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jk = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.nilai_raport = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pendapatan_orang_tua = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.kondisi_orang_tua = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.jumlah_tanggungan_orang_tua = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.pekerjaan_orang_tua = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewComboBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewComboBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewComboBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewComboBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewComboBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Bhitung = New System.Windows.Forms.Button()
        Me.Tnm_perhitungan = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DGperhitungan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(6, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(418, 28)
        Me.Label4.TabIndex = 79
        Me.Label4.Text = "DATA CALON SISWA PENERIMA BEASISWA"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Tnm_perhitungan)
        Me.GroupBox3.Controls.Add(Me.Bhitung)
        Me.GroupBox3.Controls.Add(Me.DGperhitungan)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Location = New System.Drawing.Point(20, 11)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1124, 283)
        Me.GroupBox3.TabIndex = 118
        Me.GroupBox3.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.DataGridView1)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Location = New System.Drawing.Point(20, 300)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(1124, 238)
        Me.GroupBox4.TabIndex = 118
        Me.GroupBox4.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(629, 28)
        Me.Label1.TabIndex = 80
        Me.Label1.Text = "HASIL PERHITUNGAN DATA CALON SISWA PENERIMA BEASISWA"
        '
        'DGperhitungan
        '
        Me.DGperhitungan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGperhitungan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nis, Me.nm_siswa, Me.tempat_lahir, Me.tgl_lahir, Me.kelas, Me.alamat, Me.jk, Me.nilai_raport, Me.pendapatan_orang_tua, Me.kondisi_orang_tua, Me.jumlah_tanggungan_orang_tua, Me.pekerjaan_orang_tua})
        Me.DGperhitungan.Location = New System.Drawing.Point(11, 83)
        Me.DGperhitungan.Name = "DGperhitungan"
        Me.DGperhitungan.Size = New System.Drawing.Size(1093, 159)
        Me.DGperhitungan.TabIndex = 80
        '
        'nis
        '
        Me.nis.HeaderText = "NIS"
        Me.nis.Name = "nis"
        '
        'nm_siswa
        '
        Me.nm_siswa.HeaderText = "Nama Siswa"
        Me.nm_siswa.Name = "nm_siswa"
        '
        'tempat_lahir
        '
        Me.tempat_lahir.HeaderText = "Tempat Lahir"
        Me.tempat_lahir.Name = "tempat_lahir"
        '
        'tgl_lahir
        '
        Me.tgl_lahir.HeaderText = "Tanggal Lahir"
        Me.tgl_lahir.Name = "tgl_lahir"
        '
        'kelas
        '
        Me.kelas.HeaderText = "Kelas"
        Me.kelas.Name = "kelas"
        '
        'alamat
        '
        Me.alamat.HeaderText = "Alamat"
        Me.alamat.Name = "alamat"
        '
        'jk
        '
        Me.jk.HeaderText = "Jenis Kelamin"
        Me.jk.Items.AddRange(New Object() {"-- Pilih Jenis Kelamin --", "Laki-laki", "Perempuan"})
        Me.jk.Name = "jk"
        '
        'nilai_raport
        '
        Me.nilai_raport.HeaderText = "Nilai Raport"
        Me.nilai_raport.Name = "nilai_raport"
        '
        'pendapatan_orang_tua
        '
        Me.pendapatan_orang_tua.HeaderText = "Pendapatan Orang Tua"
        Me.pendapatan_orang_tua.Items.AddRange(New Object() {"-- Pilih Pendapatan --", "<= 1.500.000", "1.500.001 - 2.500.000", "2.500.001 - 3.500.000", "3.500.001 - 4.500.000", "> 4.500.000"})
        Me.pendapatan_orang_tua.Name = "pendapatan_orang_tua"
        '
        'kondisi_orang_tua
        '
        Me.kondisi_orang_tua.HeaderText = "Kondisi Orang Tua"
        Me.kondisi_orang_tua.Items.AddRange(New Object() {"-- Pilih Kondisi --", "Masih Hidup", "Yatim", "Piatu", "Yatim Piatu"})
        Me.kondisi_orang_tua.Name = "kondisi_orang_tua"
        '
        'jumlah_tanggungan_orang_tua
        '
        Me.jumlah_tanggungan_orang_tua.HeaderText = "Jumlah Tanggungan Orang Tua"
        Me.jumlah_tanggungan_orang_tua.Items.AddRange(New Object() {"-- Pilih Jumlah Tanggungan --", ">= 5", "4", "3", "2", "1"})
        Me.jumlah_tanggungan_orang_tua.Name = "jumlah_tanggungan_orang_tua"
        '
        'pekerjaan_orang_tua
        '
        Me.pekerjaan_orang_tua.HeaderText = "Pekerjaan Orang Tua"
        Me.pekerjaan_orang_tua.Items.AddRange(New Object() {"-- Pilih Pekerjaan --", "Tidak Bekerja", "Buruh Pabrik/Petani", "Swasta", "Wiraswasta", "PNS"})
        Me.pekerjaan_orang_tua.Name = "pekerjaan_orang_tua"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewComboBoxColumn1, Me.DataGridViewTextBoxColumn7, Me.DataGridViewComboBoxColumn2, Me.DataGridViewComboBoxColumn3, Me.DataGridViewComboBoxColumn4, Me.DataGridViewComboBoxColumn5})
        Me.DataGridView1.Location = New System.Drawing.Point(11, 47)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1093, 185)
        Me.DataGridView1.TabIndex = 81
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "NIS"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nama Siswa"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Tempat Lahir"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Tanggal Lahir"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Kelas"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "Alamat"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewComboBoxColumn1
        '
        Me.DataGridViewComboBoxColumn1.HeaderText = "Jenis Kelamin"
        Me.DataGridViewComboBoxColumn1.Name = "DataGridViewComboBoxColumn1"
        Me.DataGridViewComboBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewComboBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.HeaderText = "Nilai Raport"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewComboBoxColumn2
        '
        Me.DataGridViewComboBoxColumn2.HeaderText = "Pendapatan Orang Tua"
        Me.DataGridViewComboBoxColumn2.Name = "DataGridViewComboBoxColumn2"
        Me.DataGridViewComboBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewComboBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewComboBoxColumn3
        '
        Me.DataGridViewComboBoxColumn3.HeaderText = "Kondisi Orang Tua"
        Me.DataGridViewComboBoxColumn3.Name = "DataGridViewComboBoxColumn3"
        Me.DataGridViewComboBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewComboBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewComboBoxColumn4
        '
        Me.DataGridViewComboBoxColumn4.HeaderText = "Jumlah Tanggungan Orang Tua"
        Me.DataGridViewComboBoxColumn4.Name = "DataGridViewComboBoxColumn4"
        Me.DataGridViewComboBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewComboBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewComboBoxColumn5
        '
        Me.DataGridViewComboBoxColumn5.HeaderText = "Pekerjaan Orang Tua"
        Me.DataGridViewComboBoxColumn5.Name = "DataGridViewComboBoxColumn5"
        Me.DataGridViewComboBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewComboBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Bhitung
        '
        Me.Bhitung.Location = New System.Drawing.Point(956, 248)
        Me.Bhitung.Name = "Bhitung"
        Me.Bhitung.Size = New System.Drawing.Size(148, 23)
        Me.Bhitung.TabIndex = 81
        Me.Bhitung.Text = "MULAI PERHITUNGAN"
        Me.Bhitung.UseVisualStyleBackColor = True
        '
        'Tnm_perhitungan
        '
        Me.Tnm_perhitungan.Location = New System.Drawing.Point(127, 57)
        Me.Tnm_perhitungan.Name = "Tnm_perhitungan"
        Me.Tnm_perhitungan.Size = New System.Drawing.Size(297, 20)
        Me.Tnm_perhitungan.TabIndex = 82
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 13)
        Me.Label2.TabIndex = 83
        Me.Label2.Text = "Nama Perhitungan"
        '
        'Data_Rop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Name = "Data_Rop"
        Me.Size = New System.Drawing.Size(1162, 552)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.DGperhitungan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents DGperhitungan As DataGridView
    Friend WithEvents nis As DataGridViewTextBoxColumn
    Friend WithEvents nm_siswa As DataGridViewTextBoxColumn
    Friend WithEvents tempat_lahir As DataGridViewTextBoxColumn
    Friend WithEvents tgl_lahir As DataGridViewTextBoxColumn
    Friend WithEvents kelas As DataGridViewTextBoxColumn
    Friend WithEvents alamat As DataGridViewTextBoxColumn
    Friend WithEvents jk As DataGridViewComboBoxColumn
    Friend WithEvents nilai_raport As DataGridViewTextBoxColumn
    Friend WithEvents pendapatan_orang_tua As DataGridViewComboBoxColumn
    Friend WithEvents kondisi_orang_tua As DataGridViewComboBoxColumn
    Friend WithEvents jumlah_tanggungan_orang_tua As DataGridViewComboBoxColumn
    Friend WithEvents pekerjaan_orang_tua As DataGridViewComboBoxColumn
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewComboBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewComboBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewComboBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewComboBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewComboBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Tnm_perhitungan As TextBox
    Friend WithEvents Bhitung As Button
End Class
