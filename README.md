# metode-smart-beasiswa-vb
Pemilihan siswa mendapatkan beasiswa metode smart

# Query SQL Metode Smart
`SELECT data_akhir.* FROM (SELECT data_nilai.id_alternatif, data_nilai.nm_alternatif, SUM(data_nilai.nilai*data_kriteria.normalisasi) AS nilai_akhir FROM (SELECT tb_alternatif.id_alternatif,tb_alternatif.nm_alternatif, tb_kriteria.id_kriteria, tb_kriteria.nm_kriteria, tb_nilai.nilai FROM tb_nilai join tb_alternatif on tb_nilai.id_alternatif = tb_alternatif.id_alternatif join tb_kriteria on tb_nilai.id_kriteria = tb_kriteria.id_kriteria) data_nilai 
JOIN (SELECT tb_kriteria.*, tb_kriteria.bobot/(SELECT SUM(t.bobot) FROM tb_kriteria t) AS normalisasi FROM tb_kriteria) data_kriteria ON data_nilai.id_kriteria = data_kriteria.id_kriteria GROUP BY data_nilai.nm_alternatif) data_akhir ORDER BY data_akhir.nilai_akhir DESC`
