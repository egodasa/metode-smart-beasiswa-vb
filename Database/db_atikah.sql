-- Adminer 4.7.7 MySQL dump

SET NAMES utf8;
SET time_zone = '+00:00';
SET foreign_key_checks = 0;
SET sql_mode = 'NO_AUTO_VALUE_ON_ZERO';

DROP TABLE IF EXISTS `barang`;
CREATE TABLE `barang` (
  `kode_barang` varchar(20) NOT NULL,
  `nama_barang` varchar(100) NOT NULL,
  `harga_barang` int(11) NOT NULL,
  `stock` int(11) NOT NULL,
  `satuan` varchar(10) NOT NULL,
  PRIMARY KEY (`kode_barang`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;


DROP TABLE IF EXISTS `detail_pembelian`;
CREATE TABLE `detail_pembelian` (
  `id_detail` int(11) NOT NULL AUTO_INCREMENT,
  `no_nota` varchar(20) NOT NULL,
  `kode_barang` varchar(20) NOT NULL,
  `harga_barang` int(11) NOT NULL,
  `sub_total` int(11) NOT NULL,
  `diskon` int(11) NOT NULL,
  `jumlah` int(11) NOT NULL,
  PRIMARY KEY (`id_detail`),
  KEY `no_nota` (`no_nota`),
  KEY `kode_barang` (`kode_barang`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;


DELIMITER ;;

CREATE TRIGGER `tambahStokDariPembelian` BEFORE INSERT ON `detail_pembelian` FOR EACH ROW
UPDATE barang SET stock = stock + NEW.jumlah WHERE kode_barang =  NEW.kode_barang;;

CREATE TRIGGER `kurangiStokDariPembelian` AFTER DELETE ON `detail_pembelian` FOR EACH ROW
UPDATE barang SET stock = stock - OLD.jumlah WHERE kode_barang = OLD.kode_barang;;

DELIMITER ;

DROP TABLE IF EXISTS `detail_penjualan`;
CREATE TABLE `detail_penjualan` (
  `id_detail` int(11) NOT NULL AUTO_INCREMENT,
  `no_nota` varchar(20) NOT NULL,
  `kode_barang` varchar(20) NOT NULL,
  `harga_barang` int(11) NOT NULL,
  `sub_total` int(11) NOT NULL,
  `diskon` int(11) NOT NULL,
  `jumlah` int(11) NOT NULL,
  PRIMARY KEY (`id_detail`),
  KEY `no_nota` (`no_nota`),
  KEY `kode_barang` (`kode_barang`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;


DELIMITER ;;

CREATE TRIGGER `kurangiStokDariPenjualan` BEFORE INSERT ON `detail_penjualan` FOR EACH ROW
UPDATE barang SET stock = stock - NEW.jumlah WHERE kode_barang = NEW.kode_barang;;

CREATE TRIGGER `tambahStokDariPenjualan` AFTER DELETE ON `detail_penjualan` FOR EACH ROW
UPDATE barang SET stock = stock + OLD.jumlah WHERE kode_barang = OLD.kode_barang;;

DELIMITER ;

SET NAMES utf8mb4;

DROP TABLE IF EXISTS `eoq_rop`;
CREATE TABLE `eoq_rop` (
  `kode_hitung` varchar(10) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `kode_barang` varchar(10) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `tgl_hitung` timestamp NOT NULL,
  `kebutuhan_per_tahun` int(11) NOT NULL,
  `kebutuhan_per_hari` int(11) NOT NULL,
  `leadtime` int(11) NOT NULL,
  `biaya_pesan` int(11) NOT NULL,
  `harga_beli` int(11) NOT NULL,
  `biaya_simpan` int(11) NOT NULL,
  `rop` int(11) NOT NULL,
  `eoq` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;


DROP TABLE IF EXISTS `pembelian`;
CREATE TABLE `pembelian` (
  `no_nota` varchar(50) NOT NULL,
  `tgl_beli` datetime NOT NULL,
  `total_harga` int(11) NOT NULL,
  `kode_supplier` varchar(20) NOT NULL,
  PRIMARY KEY (`no_nota`),
  KEY `kode_supplier` (`kode_supplier`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;


DROP TABLE IF EXISTS `pengguna`;
CREATE TABLE `pengguna` (
  `id_pengguna` int(11) NOT NULL AUTO_INCREMENT,
  `username` varchar(20) NOT NULL,
  `password` varchar(255) NOT NULL,
  `level` varchar(20) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `nohp` varchar(15) NOT NULL,
  `alamat` varchar(255) NOT NULL,
  PRIMARY KEY (`id_pengguna`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

INSERT INTO `pengguna` (`id_pengguna`, `username`, `password`, `level`, `nohp`, `alamat`) VALUES
(2,	'pimpinan',	'90973652b88fe07d05a4304f0a945de8',	'Pimpinan',	'',	''),
(3,	'gudang',	'202446dd1d6028084426867365b0c7a1',	'Gudang',	'',	''),
(4,	'admin',	'21232f297a57a5a743894a0e4a801fc3',	'Admin',	'',	'');

DROP TABLE IF EXISTS `penjualan`;
CREATE TABLE `penjualan` (
  `no_nota` varchar(50) NOT NULL,
  `tgl_jual` datetime NOT NULL,
  `nm_pembeli` varchar(50) NOT NULL,
  `uraian_jual` varchar(100) NOT NULL,
  `total_harga` int(11) NOT NULL,
  PRIMARY KEY (`no_nota`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;


DROP TABLE IF EXISTS `supplier`;
CREATE TABLE `supplier` (
  `kode_supplier` varchar(20) NOT NULL,
  `nama_supplier` varchar(50) NOT NULL,
  `alamat` varchar(255) NOT NULL,
  `no_telp` varchar(15) NOT NULL,
  PRIMARY KEY (`kode_supplier`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;


-- 2021-12-14 08:34:26
