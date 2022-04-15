<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Data_Penjualan
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.DGpenjualan = New System.Windows.Forms.DataGridView()
        Me.nomor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.no_nota = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tgl_beli = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nm_pembeli = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jumlah_beli = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total_harga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.uraian_jual = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ttgl_beli = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Ttotal_harga = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Bsimpan = New System.Windows.Forms.Button()
        Me.DGkeranjang = New System.Windows.Forms.DataGridView()
        Me.id_detail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kode_barang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nama_barang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.harga_barang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jumlah = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.diskon = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sub_total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Tnama_barang = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Ckode_barang = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Tsub_total = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Tharga_beli = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Tjumlah = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Tno_nota = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Tnm_pembeli = New System.Windows.Forms.TextBox()
        Me.Turaian_jual = New System.Windows.Forms.TextBox()
        Me.Tstok = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Tdiskon = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        CType(Me.DGpenjualan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGkeranjang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(632, 165)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(125, 23)
        Me.Button3.TabIndex = 135
        Me.Button3.Text = "HAPUS PENJUALAN"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'DGpenjualan
        '
        Me.DGpenjualan.AllowUserToAddRows = False
        Me.DGpenjualan.AllowUserToDeleteRows = False
        Me.DGpenjualan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGpenjualan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nomor, Me.no_nota, Me.tgl_beli, Me.nm_pembeli, Me.jumlah_beli, Me.total_harga, Me.uraian_jual})
        Me.DGpenjualan.Location = New System.Drawing.Point(21, 46)
        Me.DGpenjualan.Name = "DGpenjualan"
        Me.DGpenjualan.ReadOnly = True
        Me.DGpenjualan.Size = New System.Drawing.Size(736, 113)
        Me.DGpenjualan.TabIndex = 133
        '
        'nomor
        '
        Me.nomor.HeaderText = "No"
        Me.nomor.Name = "nomor"
        Me.nomor.ReadOnly = True
        '
        'no_nota
        '
        Me.no_nota.HeaderText = "No. Faktur"
        Me.no_nota.Name = "no_nota"
        Me.no_nota.ReadOnly = True
        '
        'tgl_beli
        '
        Me.tgl_beli.HeaderText = "Tgl Penjualan"
        Me.tgl_beli.Name = "tgl_beli"
        Me.tgl_beli.ReadOnly = True
        '
        'nm_pembeli
        '
        Me.nm_pembeli.HeaderText = "Nama Pembeli"
        Me.nm_pembeli.Name = "nm_pembeli"
        Me.nm_pembeli.ReadOnly = True
        '
        'jumlah_beli
        '
        Me.jumlah_beli.HeaderText = "Jumlah"
        Me.jumlah_beli.Name = "jumlah_beli"
        Me.jumlah_beli.ReadOnly = True
        '
        'total_harga
        '
        Me.total_harga.HeaderText = "Total Harga"
        Me.total_harga.Name = "total_harga"
        Me.total_harga.ReadOnly = True
        '
        'uraian_jual
        '
        Me.uraian_jual.HeaderText = "Keterangan"
        Me.uraian_jual.Name = "uraian_jual"
        Me.uraian_jual.ReadOnly = True
        '
        'Ttgl_beli
        '
        Me.Ttgl_beli.CustomFormat = "dd-MM-yyyy"
        Me.Ttgl_beli.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Ttgl_beli.Location = New System.Drawing.Point(120, 84)
        Me.Ttgl_beli.Name = "Ttgl_beli"
        Me.Ttgl_beli.Size = New System.Drawing.Size(170, 20)
        Me.Ttgl_beli.TabIndex = 139
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(267, 275)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(93, 17)
        Me.Label10.TabIndex = 138
        Me.Label10.Text = "TOTAL HARGA"
        '
        'Ttotal_harga
        '
        Me.Ttotal_harga.Location = New System.Drawing.Point(375, 275)
        Me.Ttotal_harga.Name = "Ttotal_harga"
        Me.Ttotal_harga.ReadOnly = True
        Me.Ttotal_harga.Size = New System.Drawing.Size(225, 20)
        Me.Ttotal_harga.TabIndex = 137
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label11.Location = New System.Drawing.Point(16, 14)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(251, 28)
        Me.Label11.TabIndex = 136
        Me.Label11.Text = "ENTRI DATA PENJUALAN"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(21, 273)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(125, 23)
        Me.Button2.TabIndex = 132
        Me.Button2.Text = "HAPUS BARANG"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(632, 137)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(130, 23)
        Me.Button1.TabIndex = 131
        Me.Button1.Text = "TAMBAH BARANG"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Bsimpan
        '
        Me.Bsimpan.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bsimpan.Location = New System.Drawing.Point(608, 273)
        Me.Bsimpan.Name = "Bsimpan"
        Me.Bsimpan.Size = New System.Drawing.Size(154, 23)
        Me.Bsimpan.TabIndex = 130
        Me.Bsimpan.Text = "SIMPAN PENJUALAN"
        Me.Bsimpan.UseVisualStyleBackColor = True
        '
        'DGkeranjang
        '
        Me.DGkeranjang.AllowUserToAddRows = False
        Me.DGkeranjang.AllowUserToDeleteRows = False
        Me.DGkeranjang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGkeranjang.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_detail, Me.no, Me.kode_barang, Me.nama_barang, Me.harga_barang, Me.jumlah, Me.diskon, Me.sub_total})
        Me.DGkeranjang.Location = New System.Drawing.Point(21, 166)
        Me.DGkeranjang.Name = "DGkeranjang"
        Me.DGkeranjang.ReadOnly = True
        Me.DGkeranjang.Size = New System.Drawing.Size(741, 106)
        Me.DGkeranjang.TabIndex = 129
        '
        'id_detail
        '
        Me.id_detail.HeaderText = "id_detail"
        Me.id_detail.Name = "id_detail"
        Me.id_detail.ReadOnly = True
        Me.id_detail.Visible = False
        '
        'no
        '
        Me.no.HeaderText = "No"
        Me.no.Name = "no"
        Me.no.ReadOnly = True
        '
        'kode_barang
        '
        Me.kode_barang.HeaderText = "Kode Barang"
        Me.kode_barang.Name = "kode_barang"
        Me.kode_barang.ReadOnly = True
        '
        'nama_barang
        '
        Me.nama_barang.HeaderText = "Nama Barang"
        Me.nama_barang.Name = "nama_barang"
        Me.nama_barang.ReadOnly = True
        '
        'harga_barang
        '
        Me.harga_barang.HeaderText = "Harga Barang"
        Me.harga_barang.Name = "harga_barang"
        Me.harga_barang.ReadOnly = True
        '
        'jumlah
        '
        Me.jumlah.HeaderText = "Jumlah"
        Me.jumlah.Name = "jumlah"
        Me.jumlah.ReadOnly = True
        '
        'diskon
        '
        Me.diskon.HeaderText = "Diskon"
        Me.diskon.Name = "diskon"
        Me.diskon.ReadOnly = True
        '
        'sub_total
        '
        Me.sub_total.HeaderText = "Sub Total"
        Me.sub_total.Name = "sub_total"
        Me.sub_total.ReadOnly = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(18, 137)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 17)
        Me.Label7.TabIndex = 127
        Me.Label7.Text = "Keterangan"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(18, 110)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(96, 17)
        Me.Label9.TabIndex = 125
        Me.Label9.Text = "Nama Pembeli"
        '
        'Tnama_barang
        '
        Me.Tnama_barang.Location = New System.Drawing.Point(388, 84)
        Me.Tnama_barang.Name = "Tnama_barang"
        Me.Tnama_barang.ReadOnly = True
        Me.Tnama_barang.Size = New System.Drawing.Size(150, 20)
        Me.Tnama_barang.TabIndex = 124
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(296, 84)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(91, 17)
        Me.Label16.TabIndex = 123
        Me.Label16.Text = "Nama Barang"
        '
        'Ckode_barang
        '
        Me.Ckode_barang.FormattingEnabled = True
        Me.Ckode_barang.Location = New System.Drawing.Point(388, 57)
        Me.Ckode_barang.Name = "Ckode_barang"
        Me.Ckode_barang.Size = New System.Drawing.Size(150, 21)
        Me.Ckode_barang.TabIndex = 122
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(296, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 17)
        Me.Label4.TabIndex = 121
        Me.Label4.Text = "Kode barang"
        '
        'Tsub_total
        '
        Me.Tsub_total.Location = New System.Drawing.Point(632, 112)
        Me.Tsub_total.Name = "Tsub_total"
        Me.Tsub_total.ReadOnly = True
        Me.Tsub_total.Size = New System.Drawing.Size(130, 20)
        Me.Tsub_total.TabIndex = 120
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(550, 112)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(64, 17)
        Me.Label14.TabIndex = 119
        Me.Label14.Text = "Sub Total"
        '
        'Tharga_beli
        '
        Me.Tharga_beli.Location = New System.Drawing.Point(632, 84)
        Me.Tharga_beli.Name = "Tharga_beli"
        Me.Tharga_beli.ReadOnly = True
        Me.Tharga_beli.Size = New System.Drawing.Size(130, 20)
        Me.Tharga_beli.TabIndex = 118
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(550, 84)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(70, 17)
        Me.Label13.TabIndex = 117
        Me.Label13.Text = "Harga Beli"
        '
        'Tjumlah
        '
        Me.Tjumlah.Location = New System.Drawing.Point(388, 139)
        Me.Tjumlah.Name = "Tjumlah"
        Me.Tjumlah.Size = New System.Drawing.Size(150, 20)
        Me.Tjumlah.TabIndex = 116
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(296, 139)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 17)
        Me.Label8.TabIndex = 115
        Me.Label8.Text = "Jumlah Beli"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(18, 84)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 17)
        Me.Label6.TabIndex = 114
        Me.Label6.Text = "Tgl Penjualan"
        '
        'Tno_nota
        '
        Me.Tno_nota.Location = New System.Drawing.Point(120, 58)
        Me.Tno_nota.Name = "Tno_nota"
        Me.Tno_nota.Size = New System.Drawing.Size(170, 20)
        Me.Tno_nota.TabIndex = 113
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(18, 58)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 17)
        Me.Label5.TabIndex = 112
        Me.Label5.Text = "No. Faktur"
        '
        'Tnm_pembeli
        '
        Me.Tnm_pembeli.Location = New System.Drawing.Point(120, 112)
        Me.Tnm_pembeli.Name = "Tnm_pembeli"
        Me.Tnm_pembeli.Size = New System.Drawing.Size(170, 20)
        Me.Tnm_pembeli.TabIndex = 140
        '
        'Turaian_jual
        '
        Me.Turaian_jual.Location = New System.Drawing.Point(120, 137)
        Me.Turaian_jual.Name = "Turaian_jual"
        Me.Turaian_jual.Size = New System.Drawing.Size(170, 20)
        Me.Turaian_jual.TabIndex = 141
        '
        'Tstok
        '
        Me.Tstok.Location = New System.Drawing.Point(388, 110)
        Me.Tstok.Name = "Tstok"
        Me.Tstok.ReadOnly = True
        Me.Tstok.Size = New System.Drawing.Size(150, 20)
        Me.Tstok.TabIndex = 142
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(296, 110)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(0, 17)
        Me.Label12.TabIndex = 143
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(296, 110)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(62, 17)
        Me.Label15.TabIndex = 144
        Me.Label15.Text = "Sisa Stok"
        '
        'Tdiskon
        '
        Me.Tdiskon.Location = New System.Drawing.Point(632, 58)
        Me.Tdiskon.Name = "Tdiskon"
        Me.Tdiskon.Size = New System.Drawing.Size(130, 20)
        Me.Tdiskon.TabIndex = 149
        Me.Tdiskon.Text = "0"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(550, 58)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(49, 17)
        Me.Label17.TabIndex = 148
        Me.Label17.Text = "Diskon"
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(21, 165)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(125, 23)
        Me.Button4.TabIndex = 150
        Me.Button4.Text = "CETAK FAKTUR"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.DGpenjualan)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 328)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(782, 210)
        Me.GroupBox1.TabIndex = 151
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(16, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(187, 28)
        Me.Label1.TabIndex = 152
        Me.Label1.Text = "DATA PENJUALAN"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Tdiskon)
        Me.GroupBox2.Controls.Add(Me.Tno_nota)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Tjumlah)
        Me.GroupBox2.Controls.Add(Me.Tstok)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Turaian_jual)
        Me.GroupBox2.Controls.Add(Me.Tharga_beli)
        Me.GroupBox2.Controls.Add(Me.Tnm_pembeli)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Ttgl_beli)
        Me.GroupBox2.Controls.Add(Me.Tsub_total)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Ttotal_harga)
        Me.GroupBox2.Controls.Add(Me.Ckode_barang)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Tnama_barang)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Bsimpan)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.DGkeranjang)
        Me.GroupBox2.Location = New System.Drawing.Point(23, 17)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(782, 305)
        Me.GroupBox2.TabIndex = 152
        Me.GroupBox2.TabStop = False
        '
        'Data_Penjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Data_Penjualan"
        Me.Size = New System.Drawing.Size(825, 550)
        CType(Me.DGpenjualan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGkeranjang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button3 As Button
    Friend WithEvents DGpenjualan As DataGridView
    Friend WithEvents Ttgl_beli As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents Ttotal_harga As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Bsimpan As Button
    Friend WithEvents DGkeranjang As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Tnama_barang As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Ckode_barang As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Tsub_total As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Tharga_beli As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Tjumlah As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Tno_nota As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Tnm_pembeli As TextBox
    Friend WithEvents Turaian_jual As TextBox
    Friend WithEvents Tstok As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Tdiskon As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents id_detail As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents kode_barang As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nama_barang As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents harga_barang As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents jumlah As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents diskon As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sub_total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button4 As Button
    Friend WithEvents nomor As DataGridViewTextBoxColumn
    Friend WithEvents no_nota As DataGridViewTextBoxColumn
    Friend WithEvents tgl_beli As DataGridViewTextBoxColumn
    Friend WithEvents nm_pembeli As DataGridViewTextBoxColumn
    Friend WithEvents jumlah_beli As DataGridViewTextBoxColumn
    Friend WithEvents total_harga As DataGridViewTextBoxColumn
    Friend WithEvents uraian_jual As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
End Class
