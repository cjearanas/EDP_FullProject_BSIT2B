-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 12, 2026 at 05:02 PM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.0.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `aranas_db`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbllogincredentials`
--

CREATE TABLE `tbllogincredentials` (
  `loginID` int(11) NOT NULL,
  `user_username` varchar(50) NOT NULL,
  `user_password` varchar(50) NOT NULL,
  `userID` int(11) NOT NULL,
  `is_active` int(11) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbllogincredentials`
--

INSERT INTO `tbllogincredentials` (`loginID`, `user_username`, `user_password`, `userID`, `is_active`) VALUES
(2, 'user11', 'password', 2, 0),
(3, 'admin', '1234', 1, 1),
(4, 'boss', 'araykoo', 3, 1),
(5, 'boss', '`boss', 4, 1),
(6, 'awe', 'awe', 5, 1),
(7, 'ewrqwerqw', 'ewqrqwerewq', 6, 0);

-- --------------------------------------------------------

--
-- Table structure for table `tbluserinformation`
--

CREATE TABLE `tbluserinformation` (
  `userID` int(11) NOT NULL,
  `firstname` varchar(50) NOT NULL,
  `middlename` varchar(50) DEFAULT NULL,
  `lastname` varchar(50) NOT NULL,
  `emailAddress` varchar(255) NOT NULL,
  `homeAddress` varchar(255) NOT NULL,
  `birthDate` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbluserinformation`
--

INSERT INTO `tbluserinformation` (`userID`, `firstname`, `middlename`, `lastname`, `emailAddress`, `homeAddress`, `birthDate`) VALUES
(1, 'Carl', 'Estipona', 'Aranas', 'carljerald@gmail.com', 'paliparan3', '1998-08-15'),
(2, 'user1', 'user', 'user', 'user@gmail.com', 'user', '2026-04-15'),
(3, 'Bruce', 'Jet', 'Lee', 'bruce.lee@gmail.com', 'cavite city', '2026-04-14'),
(4, 'asdfas', 'saga', 'sadfe', 'sdfaf@gmail.com', 'asdfweqrwq', '2026-05-02'),
(5, 'aewqrwq', 'aea', 'ae', 'ae', 'ae', '2026-05-02'),
(6, 'asdfew', 'qerqewr', 'qewrqewr', 'qwerqwer', 'weqrqwerqew', '2026-05-02');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbllogincredentials`
--
ALTER TABLE `tbllogincredentials`
  ADD PRIMARY KEY (`loginID`);

--
-- Indexes for table `tbluserinformation`
--
ALTER TABLE `tbluserinformation`
  ADD PRIMARY KEY (`userID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tbllogincredentials`
--
ALTER TABLE `tbllogincredentials`
  MODIFY `loginID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT for table `tbluserinformation`
--
ALTER TABLE `tbluserinformation`
  MODIFY `userID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
