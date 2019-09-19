-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Jul 24, 2018 at 09:52 AM
-- Server version: 10.1.19-MariaDB
-- PHP Version: 5.6.28

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `pdfmhs`
--

-- --------------------------------------------------------

--
-- Stand-in structure for view `lunas`
--
CREATE TABLE `lunas` (
`id_pendaftaran` char(13)
,`id_panitia` char(13)
,`sisa_pembayaran` int(10)
,`tgl_pembayaran` date
);

-- --------------------------------------------------------

--
-- Stand-in structure for view `lunas2`
--
CREATE TABLE `lunas2` (
`id_pendaftaran` char(13)
,`id_panitia` char(13)
,`bayar` int(10)
,`sisa_pembayaran` int(10)
,`status_bayar` varchar(15)
,`tgl_pembayaran` date
);

-- --------------------------------------------------------

--
-- Table structure for table `mahasiswa`
--

CREATE TABLE `mahasiswa` (
  `nis` char(13) NOT NULL,
  `nama_mahasiswa` varchar(30) NOT NULL,
  `Tempat_Lahir` varchar(25) NOT NULL,
  `tgl_lahir` date NOT NULL,
  `jk_mahasiswa` char(1) NOT NULL,
  `Agama` varchar(10) NOT NULL,
  `Gol_darah` varchar(5) NOT NULL,
  `alamat` varchar(50) NOT NULL,
  `asal_sekolah` varchar(25) NOT NULL,
  `Telp_mahasiswa` varchar(15) NOT NULL,
  `Email` varchar(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `mahasiswa`
--

INSERT INTO `mahasiswa` (`nis`, `nama_mahasiswa`, `Tempat_Lahir`, `tgl_lahir`, `jk_mahasiswa`, `Agama`, `Gol_darah`, `alamat`, `asal_sekolah`, `Telp_mahasiswa`, `Email`) VALUES
('1610520001', 'RENDI', 'BAYAN', '2014-05-08', 'L', 'ISLAM', 'B', 'LOKOK  KELUNGKUNG', 'SMKN 1 BAYAN', '0878765654', 'RENDI@GMAIL.COK'),
('1610520002', 'Medi', 'BAYAN', '2018-07-23', 'L', 'ISLAM', 'B', 'KLUNGKUNG', 'SMAN 1 BAYAN', '087876776', '@gmail.com'),
('1610520003', 'rahman', 'bayan', '2018-07-13', 'L', 'ISLAM', 'B', 'bayan', 'sman 1 bayan', '09887', 'cmedi2118@gmail.com'),
('1610520004', 'MEDICARE', 'BAYAN', '2018-07-18', 'L', 'ISLAM', 'B', 'LOKOK KELUNGKUNG', 'SMAN 1 BAYAN', '087866555', 'cMEDI2118@GMAIL.COM'),
('1610520009', 'RIANTO', 'BAYAN', '2018-07-10', 'L', 'ISLAM', 'B', 'SENARU', 'SMAN 2 BAYAN', '087865666', 'Rian@gmail.com'),
('1610520010', 'MEDICARE', 'KLUNGKUNG', '2013-11-27', 'L', 'ISLAM', 'B', 'BAYAN', 'SMAN 1 BAYAN', '987887', 'CMEDI2118@GMAIL.COM'),
('1610520011', 'medicare', 'klungkung', '2018-07-11', 'L', 'ISLAM', 'A', 'Bayan', 'SMAN 1 BAYAN', '08786575464', 'Cmedi2118@gmail.com'),
('1610520040', 'DIDIK ABDURAZAK', 'JENGGIK', '2020-02-06', 'L', 'ISLAM', 'A', 'LOMBOK TIMUR', 'tk', '08766998876', 'LAL@YAHOO.LAL'),
('1610520046', 'JONI ISKANDAR', 'SEMBALUN', '2021-02-23', 'L', 'ISLAM', 'AB', 'SEMBALUN', 'SMKN 2 SELONG', '087876688', 'JONI@GMAIL.COM'),
('1610520047', 'BILAL IQBAL BAKTIR', 'MATARAM', '2018-07-24', 'L', 'ISLAM', 'O', 'AMPENAN', 'SMK 2 MATARAM', '081907191922', 'BILALBAKTIR@GMAIL.COM'),
('1610520120', 'medd', 'caraa', '2018-07-19', 'L', 'ISLAM', 'B', 'makaan', 'maaaa', '099989898', 'hshsshsjkakakc'),
('161052178', 'ANGGA', 'PRAYA', '2020-01-29', 'L', 'ISLAM', 'B', 'PRAYA', 'SMKN 2 PRAYA', '0898998898', '@GMAIL.COM'),
('1710510031', 'SUTRISNO', 'PLAMPANG', '2014-05-15', 'L', 'ISLAM', 'A', 'Mataram', 'SMKN 1 PLAMPANG', '087876655', 'sutrisno02@gmail.com'),
('NI12929292', 'MEDICARE', 'KLUNGKUNG', '2018-07-25', 'L', 'ISLAM', 'A', 'BAYAN', 'SMAN 1 BAYAN', '089898', '76777'),
('NIS00001', 'MEDICARE', 'Klungkung', '2018-07-03', 'L', 'Islam', 'o', 'LOKOK KELUNGKUNG', 'SMAN 1BAYAN', '98989898', 'medicare@gmail.com');

-- --------------------------------------------------------

--
-- Table structure for table `panitia`
--

CREATE TABLE `panitia` (
  `id_panitia` char(13) NOT NULL,
  `nama_panitia` varchar(30) NOT NULL,
  `Tempat_Lahir` varchar(25) NOT NULL,
  `tgl_lahir` date NOT NULL,
  `jk_panitia` varchar(1) NOT NULL,
  `Agama` varchar(10) NOT NULL,
  `Gol_darah` varchar(5) NOT NULL,
  `alamat` varchar(35) NOT NULL,
  `Telp_panitia` varchar(15) NOT NULL,
  `Email` varchar(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `panitia`
--

INSERT INTO `panitia` (`id_panitia`, `nama_panitia`, `Tempat_Lahir`, `tgl_lahir`, `jk_panitia`, `Agama`, `Gol_darah`, `alamat`, `Telp_panitia`, `Email`) VALUES
('P00006', 'RIANTI', 'BAYAN', '2018-07-18', 'P', 'BUDHA', 'B', 'LOKOK KELUNGKUNG', '0878656555', 'RIANTI07@GMAIL.COM'),
('P00008', 'RONO', 'CINA', '2018-07-02', 'L', 'ISLAM', 'A', 'LOKOK KELUNGKUNG', '08788777', 'RONO@GMAIL.COM'),
('PAN0003', 'NSNSN', 'abab', '2018-07-13', 'P', 'BUDHA', 'B', 'BSBSBS', '0988', 'EYYEE'),
('PAN003', 'NSNSN', 'ABAB', '2018-07-02', 'P', 'BUDHA', 'B', 'BSBSBS', '0988', 'EYYEE'),
('PAN004', 'NSNS', 'nana', '2018-07-27', 'P', 'BUDHA', 'B', 'KLUNGKUNG', '0879988', 'CMEDI21118@GMAIL.COM\r\n');

-- --------------------------------------------------------

--
-- Table structure for table `pendaftaran`
--

CREATE TABLE `pendaftaran` (
  `id_pendaftaran` char(13) NOT NULL,
  `nis` char(13) NOT NULL,
  `tgl_pendaftran` date NOT NULL,
  `kode_prodi` char(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `pendaftaran`
--

INSERT INTO `pendaftaran` (`id_pendaftaran`, `nis`, `tgl_pendaftran`, `kode_prodi`) VALUES
('DFL12099', '1610520009', '2018-07-20', 'PR005'),
('DFL15747', '1710510031', '2018-07-24', 'PR004'),
('DFL21867', '1610520002', '2018-07-20', 'PR003'),
('DFL22932', '1610520004', '2018-07-24', 'PR004'),
('DFL2740', '1610520002', '2018-07-20', 'PR001'),
('DFL35537', '1610520002', '2018-07-20', 'PR001'),
('DFL43464', '161052178', '2018-07-23', 'PR001'),
('DFL58406', '1610520002', '2018-07-21', 'PR002'),
('DFL59980', '1610520001', '2018-07-20', 'PR001'),
('DFL64621', '1610520120', '2018-07-20', 'PR003'),
('DFL68412', '1610520040', '2018-07-24', 'PR004'),
('DFL74435', '1610520011', '2018-07-21', 'PR004'),
('DFL81102', '1610520047', '2018-07-24', 'PR006'),
('DFL82076', '1610520010', '2018-07-20', 'PR004'),
('DFL90615', '1610520046', '2018-07-24', 'PR003'),
('DFL92303', '1610520003', '2018-07-20', 'PR002');

-- --------------------------------------------------------

--
-- Table structure for table `prodi`
--

CREATE TABLE `prodi` (
  `kdpro` char(5) NOT NULL,
  `nama_prodi` varchar(35) NOT NULL,
  `biaya` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `prodi`
--

INSERT INTO `prodi` (`kdpro`, `nama_prodi`, `biaya`) VALUES
('PR001', 'S1 DKV', 8500000),
('PR002', 'D3 MI', 6000000),
('PR003', 'D3 RPL', 7000000),
('PR004', 'S1 TEKNIK INFORMATIKA', 7500000),
('PR005', 'AKUTANSI', 5000000),
('PR006', 'STATISTIKA', 8000000);

-- --------------------------------------------------------

--
-- Table structure for table `transaksi`
--

CREATE TABLE `transaksi` (
  `id_transaksi` char(13) NOT NULL,
  `id_pendaftaran` char(13) NOT NULL,
  `id_panitia` char(13) NOT NULL,
  `bayar` int(10) NOT NULL,
  `pembayaran` int(10) NOT NULL,
  `sisa_pembayaran` int(10) NOT NULL,
  `tgl_pembayaran` date NOT NULL,
  `status_bayar` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `transaksi`
--

INSERT INTO `transaksi` (`id_transaksi`, `id_pendaftaran`, `id_panitia`, `bayar`, `pembayaran`, `sisa_pembayaran`, `tgl_pembayaran`, `status_bayar`) VALUES
('USR73083', 'DFL74435', 'PAN0003', 7500000, 7500000, 0, '2018-07-21', 'LUNAS'),
('USR82640', 'DFL90615', 'PAN0003', 7000000, 6000000, 1000000, '2018-07-24', 'TIDAK LUNAS'),
('USR83508', 'DFL21867', 'PAN0003', 7000000, 7000000, 0, '2018-07-20', 'LUNAS'),
('USR85612', 'DFL68412', 'PAN0003', 7500000, 7500000, 0, '2018-07-24', 'LUNAS');

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `id_user` char(10) NOT NULL,
  `nama_user` varchar(30) NOT NULL,
  `pass_user` varchar(15) NOT NULL,
  `Email` varchar(35) NOT NULL,
  `status_user` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`id_user`, `nama_user`, `pass_user`, `Email`, `status_user`) VALUES
('USR22809', 'medicare', 'medi', 'Cmedi2118@gmail.com', 'MAHASISWA'),
('USR23376', 'MAMA', 'mama', 'MAMA@GMAIL.COM', 'ADMIN'),
('USR25339', 'medicare', 'care', 'cmedi2118@gmail.com', 'MAHASISWA'),
('USR34924', 'caremedi', 'care', 'Care@gmail.com', 'MAHASISWA'),
('USR37011', 'MEDI', 'care', 'CACA@GMAIL.COM', 'MAHASISWA'),
('USR44903', 'SUTRISNO', 'apadah', 'apada@gmail.com', 'MAHASISWA'),
('USR4911', 'MEDI OPR', 'opr', 'OPR@GMAIL.COM', 'OPERATOR'),
('USR80755', 'mama', 'mami', 'mamsmsm', 'MAHASISWA'),
('USR87616', 'medi', 'medi', 'cmmail.com', 'MAHASISWA');

-- --------------------------------------------------------

--
-- Structure for view `lunas`
--
DROP TABLE IF EXISTS `lunas`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `lunas`  AS  select `transaksi`.`id_pendaftaran` AS `id_pendaftaran`,`transaksi`.`id_panitia` AS `id_panitia`,`transaksi`.`sisa_pembayaran` AS `sisa_pembayaran`,`transaksi`.`tgl_pembayaran` AS `tgl_pembayaran` from `transaksi` where (`transaksi`.`status_bayar` = 'lunas') ;

-- --------------------------------------------------------

--
-- Structure for view `lunas2`
--
DROP TABLE IF EXISTS `lunas2`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `lunas2`  AS  select `transaksi`.`id_pendaftaran` AS `id_pendaftaran`,`transaksi`.`id_panitia` AS `id_panitia`,`transaksi`.`bayar` AS `bayar`,`transaksi`.`sisa_pembayaran` AS `sisa_pembayaran`,`transaksi`.`status_bayar` AS `status_bayar`,`transaksi`.`tgl_pembayaran` AS `tgl_pembayaran` from `transaksi` where (`transaksi`.`status_bayar` = 'Lunas') ;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `mahasiswa`
--
ALTER TABLE `mahasiswa`
  ADD PRIMARY KEY (`nis`);

--
-- Indexes for table `panitia`
--
ALTER TABLE `panitia`
  ADD PRIMARY KEY (`id_panitia`);

--
-- Indexes for table `pendaftaran`
--
ALTER TABLE `pendaftaran`
  ADD PRIMARY KEY (`id_pendaftaran`),
  ADD KEY `nis` (`nis`),
  ADD KEY `kode_prodi` (`kode_prodi`);

--
-- Indexes for table `prodi`
--
ALTER TABLE `prodi`
  ADD PRIMARY KEY (`kdpro`);

--
-- Indexes for table `transaksi`
--
ALTER TABLE `transaksi`
  ADD PRIMARY KEY (`id_transaksi`),
  ADD KEY `id_pendaftaran` (`id_pendaftaran`),
  ADD KEY `id_panitia` (`id_panitia`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`id_user`);

--
-- Constraints for dumped tables
--

--
-- Constraints for table `pendaftaran`
--
ALTER TABLE `pendaftaran`
  ADD CONSTRAINT `pendaftaran_ibfk_4` FOREIGN KEY (`kode_prodi`) REFERENCES `prodi` (`kdpro`),
  ADD CONSTRAINT `pendaftaran_ibfk_5` FOREIGN KEY (`nis`) REFERENCES `mahasiswa` (`nis`);

--
-- Constraints for table `transaksi`
--
ALTER TABLE `transaksi`
  ADD CONSTRAINT `transaksi_ibfk_2` FOREIGN KEY (`id_panitia`) REFERENCES `panitia` (`id_panitia`),
  ADD CONSTRAINT `transaksi_ibfk_3` FOREIGN KEY (`id_pendaftaran`) REFERENCES `pendaftaran` (`id_pendaftaran`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
