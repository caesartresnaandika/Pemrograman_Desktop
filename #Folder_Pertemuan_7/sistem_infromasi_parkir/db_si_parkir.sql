-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Mar 19, 2025 at 05:59 AM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_si_parkir`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbllangganan`
--

CREATE TABLE `tbllangganan` (
  `id` int(11) NOT NULL,
  `no_plat` varchar(50) DEFAULT NULL,
  `nama` varchar(50) DEFAULT NULL,
  `jenis` varchar(50) DEFAULT NULL,
  `biaya` int(11) DEFAULT NULL,
  `expired` timestamp NULL DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `tblparkir`
--

CREATE TABLE `tblparkir` (
  `id` int(11) NOT NULL,
  `no_plat` varchar(10) NOT NULL,
  `waktu_masuk` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp(),
  `waktu_keluar` timestamp NULL DEFAULT NULL,
  `jenis` set('Motor','Mobil','Taksi/Umum','Sepeda','Bus/Truk') NOT NULL DEFAULT 'Motor',
  `harga` int(11) NOT NULL,
  `user` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tblparkir`
--

INSERT INTO `tblparkir` (`id`, `no_plat`, `waktu_masuk`, `waktu_keluar`, `jenis`, `harga`, `user`) VALUES
(1, 'D 1134 FG', '2025-03-19 04:03:54', NULL, 'Taksi/Umum', 0, 'anton'),
(2, '', '2025-03-19 04:14:36', '2025-03-19 04:14:36', 'Taksi/Umum', 3000, 'anton'),
(3, 'AB 1145 DA', '2025-03-19 04:15:10', '2025-03-19 04:15:10', 'Bus/Truk', 4000, 'anton');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `username` varchar(50) DEFAULT NULL,
  `password` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`username`, `password`) VALUES
('dika', 'dika');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbllangganan`
--
ALTER TABLE `tbllangganan`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `tblparkir`
--
ALTER TABLE `tblparkir`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tbllangganan`
--
ALTER TABLE `tbllangganan`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `tblparkir`
--
ALTER TABLE `tblparkir`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
