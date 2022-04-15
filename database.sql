-- Adminer 4.7.7 MySQL dump

SET NAMES utf8;
SET time_zone = '+00:00';
SET foreign_key_checks = 0;
SET sql_mode = 'NO_AUTO_VALUE_ON_ZERO';

SET NAMES utf8mb4;

DROP TABLE IF EXISTS `tb_hasil_perhitungan`;
CREATE TABLE `tb_hasil_perhitungan` (
  `id_hasil` int(11) NOT NULL AUTO_INCREMENT,
  `id_siswa` int(11) NOT NULL,
  `nilai` decimal(10,2) NOT NULL,
  `id_hitung` int(11) NOT NULL,
  PRIMARY KEY (`id_hasil`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;


DROP TABLE IF EXISTS `tb_hitung`;
CREATE TABLE `tb_hitung` (
  `id_hitung` int(11) NOT NULL AUTO_INCREMENT,
  `nm_hitung` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `tgl_hitung` datetime NOT NULL ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`id_hitung`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;


DROP TABLE IF EXISTS `tb_kriteria`;
CREATE TABLE `tb_kriteria` (
  `id_kriteria` int(11) NOT NULL AUTO_INCREMENT,
  `nm_kriteria` varchar(255) NOT NULL,
  `bobot` int(11) NOT NULL,
  PRIMARY KEY (`id_kriteria`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

INSERT INTO `tb_kriteria` (`id_kriteria`, `nm_kriteria`, `bobot`) VALUES
(1,	'Pendapatan Orang Tua',	40),
(2,	'Kondisi Orang Tua',	20),
(3,	'Nilai Raport',	10),
(4,	'Jumlah Tanggungan Orang Tua',	30);

DROP TABLE IF EXISTS `tb_nilai`;
CREATE TABLE `tb_nilai` (
  `id_nilai` int(11) NOT NULL AUTO_INCREMENT,
  `id_kriteria` int(11) NOT NULL,
  `id_siswa` int(11) NOT NULL,
  `nilai` int(11) NOT NULL,
  `id_hitung` int(11) NOT NULL,
  PRIMARY KEY (`id_nilai`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

INSERT INTO `tb_nilai` (`id_nilai`, `id_kriteria`, `id_siswa`, `nilai`, `id_hitung`) VALUES
(1,	1,	1,	75,	0),
(2,	2,	1,	100,	0),
(3,	3,	1,	80,	0),
(4,	4,	1,	90,	0),
(5,	5,	1,	65,	0),
(6,	1,	2,	90,	0),
(7,	2,	2,	100,	0),
(8,	3,	2,	60,	0),
(9,	4,	2,	75,	0),
(10,	5,	2,	70,	0),
(11,	1,	3,	80,	0),
(12,	2,	3,	90,	0),
(13,	3,	3,	85,	0),
(14,	4,	3,	60,	0),
(15,	5,	3,	70,	0),
(16,	1,	4,	70,	0),
(17,	2,	4,	80,	0),
(18,	3,	4,	50,	0),
(19,	4,	4,	45,	0),
(20,	5,	4,	80,	0);

DROP TABLE IF EXISTS `tb_siswa`;
CREATE TABLE `tb_siswa` (
  `id_siswa` int(11) NOT NULL AUTO_INCREMENT,
  `nis` varchar(20) NOT NULL,
  `nm_siswa` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `tempat_lahir` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `tgl_lahir` date DEFAULT NULL,
  `kelas` varchar(25) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `alamat` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `jk` enum('Laki-laki','Perempuan') CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  PRIMARY KEY (`id_siswa`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

INSERT INTO `tb_siswa` (`id_siswa`, `nis`, `nm_siswa`, `tempat_lahir`, `tgl_lahir`, `kelas`, `alamat`, `jk`) VALUES
(1,	'',	'Siswa 1',	'Padang',	'1995-10-10',	'XII.4',	'Alamat 1 ',	'Laki-laki'),
(2,	'',	'Siswa 2',	'Padang 2',	'1995-10-11',	'XII.2',	'Alamat 2',	'Perempuan'),
(3,	'',	'Siswa 3',	'Padang 3',	'1995-10-12',	'X.4',	'Alamat 4',	'Laki-laki'),
(4,	'',	'Siswa 4',	'Padang 4',	'1995-10-09',	'X.1',	'Alamat 5',	'Laki-laki');

-- 2022-04-15 16:45:24