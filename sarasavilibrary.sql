-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: Mar 11, 2025 at 03:15 PM
-- Server version: 9.1.0
-- PHP Version: 7.4.33

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `sarasavilibrary`
--

-- --------------------------------------------------------

--
-- Table structure for table `admin_login`
--

DROP TABLE IF EXISTS `admin_login`;
CREATE TABLE IF NOT EXISTS `admin_login` (
  `id` int NOT NULL AUTO_INCREMENT,
  `username` varchar(250) COLLATE utf8mb4_general_ci NOT NULL,
  `password` varchar(250) COLLATE utf8mb4_general_ci NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `admin_login`
--

INSERT INTO `admin_login` (`id`, `username`, `password`) VALUES
(1, 'Admin', '123');

-- --------------------------------------------------------

--
-- Table structure for table `books`
--

DROP TABLE IF EXISTS `books`;
CREATE TABLE IF NOT EXISTS `books` (
  `BookID` int NOT NULL AUTO_INCREMENT,
  `Classification` char(1) COLLATE utf8mb4_general_ci NOT NULL,
  `Title` varchar(255) COLLATE utf8mb4_general_ci NOT NULL,
  `Author` varchar(255) COLLATE utf8mb4_general_ci DEFAULT NULL,
  `ISBN` varchar(20) COLLATE utf8mb4_general_ci NOT NULL,
  `Publisher` varchar(255) COLLATE utf8mb4_general_ci DEFAULT NULL,
  `ClassificationCode` varchar(5) COLLATE utf8mb4_general_ci NOT NULL,
  PRIMARY KEY (`BookID`),
  UNIQUE KEY `ClassificationCode` (`ClassificationCode`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `books`
--

INSERT INTO `books` (`BookID`, `Classification`, `Title`, `Author`, `ISBN`, `Publisher`, `ClassificationCode`) VALUES
(1, 'A', 'Introduction to Algorithms', 'Thomas H. Cormen', '978-0262033848', 'The MIT Press', 'A0001'),
(2, 'B', 'The Catcher in the Rye', 'J.D. Salinger', '9780316769488', 'Little, Brown & Co.', 'B0001'),
(3, 'C', 'To Kill a Mockingbird', 'Harper Lee', '9780061120084', 'HarperCollins', 'C0001'),
(4, 'A', '1984', 'George Orwell', '9780451524935', 'Penguin Books', 'A0002'),
(5, 'A', 'The Great Gatsby', 'F. Scott Fitzgerald', '9780743273565', 'Scribner', 'A0005');

-- --------------------------------------------------------

--
-- Table structure for table `copies`
--

DROP TABLE IF EXISTS `copies`;
CREATE TABLE IF NOT EXISTS `copies` (
  `CopyID` int NOT NULL AUTO_INCREMENT,
  `BookID` int NOT NULL,
  `CopyNumber` varchar(10) COLLATE utf8mb4_general_ci NOT NULL,
  `Status` enum('Reference','Borrowable') COLLATE utf8mb4_general_ci NOT NULL,
  PRIMARY KEY (`CopyID`),
  KEY `BookID` (`BookID`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `copies`
--

INSERT INTO `copies` (`CopyID`, `BookID`, `CopyNumber`, `Status`) VALUES
(1, 1, 'A0001-1', 'Borrowable'),
(2, 1, 'A0001-2', 'Borrowable'),
(3, 1, 'A0001-3', 'Borrowable'),
(4, 2, 'B0001-1', 'Borrowable'),
(5, 2, 'B0001-2', 'Borrowable'),
(6, 2, 'B0001-3', 'Borrowable'),
(7, 2, 'B0001-4', 'Borrowable'),
(8, 2, 'B0001-5', 'Borrowable'),
(9, 3, 'C0001-1', 'Reference'),
(10, 4, 'A0002-1', 'Borrowable'),
(11, 4, 'A0002-2', 'Borrowable'),
(12, 4, 'A0002-3', 'Borrowable'),
(13, 4, 'A0002-4', 'Borrowable'),
(14, 4, 'A0002-5', 'Borrowable'),
(15, 5, 'A0005-1', 'Reference');

-- --------------------------------------------------------

--
-- Table structure for table `inquiries`
--

DROP TABLE IF EXISTS `inquiries`;
CREATE TABLE IF NOT EXISTS `inquiries` (
  `InquiryID` int NOT NULL AUTO_INCREMENT,
  `UserID` int DEFAULT NULL,
  `BookID` int DEFAULT NULL,
  `InquiryDate` datetime DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`InquiryID`),
  KEY `UserID` (`UserID`),
  KEY `BookID` (`BookID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `loans`
--

DROP TABLE IF EXISTS `loans`;
CREATE TABLE IF NOT EXISTS `loans` (
  `LoanID` int NOT NULL AUTO_INCREMENT,
  `UserID` int NOT NULL,
  `CopyID` int NOT NULL,
  `LoanDate` date NOT NULL,
  `ReturnDate` date NOT NULL,
  `DueDate` datetime DEFAULT NULL,
  PRIMARY KEY (`LoanID`),
  KEY `UserID` (`UserID`),
  KEY `CopyID` (`CopyID`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `loans`
--

INSERT INTO `loans` (`LoanID`, `UserID`, `CopyID`, `LoanDate`, `ReturnDate`, `DueDate`) VALUES
(2, 1, 2, '2024-12-20', '2025-03-11', '2025-01-03 12:02:41');

-- --------------------------------------------------------

--
-- Table structure for table `reservations`
--

DROP TABLE IF EXISTS `reservations`;
CREATE TABLE IF NOT EXISTS `reservations` (
  `ReservationID` int NOT NULL AUTO_INCREMENT,
  `CopyID` int NOT NULL,
  `UserID` int NOT NULL,
  `ReservedDate` datetime NOT NULL,
  `IsFulfilled` tinyint(1) DEFAULT '0',
  PRIMARY KEY (`ReservationID`),
  KEY `CopyID` (`CopyID`),
  KEY `UserID` (`UserID`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `reservations`
--

INSERT INTO `reservations` (`ReservationID`, `CopyID`, `UserID`, `ReservedDate`, `IsFulfilled`) VALUES
(1, 1, 1, '2024-12-20 12:06:04', 0);

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
CREATE TABLE IF NOT EXISTS `users` (
  `UserID` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(100) COLLATE utf8mb4_general_ci NOT NULL,
  `Sex` enum('Male','Female','Other') COLLATE utf8mb4_general_ci NOT NULL,
  `NIC` varchar(15) COLLATE utf8mb4_general_ci NOT NULL,
  `Address` varchar(255) COLLATE utf8mb4_general_ci NOT NULL,
  `UserType` enum('Member','Visitor') COLLATE utf8mb4_general_ci NOT NULL,
  PRIMARY KEY (`UserID`),
  UNIQUE KEY `NIC` (`NIC`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`UserID`, `Name`, `Sex`, `NIC`, `Address`, `UserType`) VALUES
(1, 'Kamal Perera', 'Male', '200012345678', '10, Main Street, Colombo', 'Member'),
(2, 'Nimal Fernando', 'Male', '199856789012', '25, Lake Road, Kandy', 'Member'),
(3, 'Anusha Silva', 'Female', '199945678901', '50, Green Lane, Kurunegala', 'Visitor');

--
-- Constraints for dumped tables
--

--
-- Constraints for table `copies`
--
ALTER TABLE `copies`
  ADD CONSTRAINT `copies_ibfk_1` FOREIGN KEY (`BookID`) REFERENCES `books` (`BookID`);

--
-- Constraints for table `inquiries`
--
ALTER TABLE `inquiries`
  ADD CONSTRAINT `inquiries_ibfk_1` FOREIGN KEY (`UserID`) REFERENCES `users` (`UserID`),
  ADD CONSTRAINT `inquiries_ibfk_2` FOREIGN KEY (`BookID`) REFERENCES `books` (`BookID`);

--
-- Constraints for table `loans`
--
ALTER TABLE `loans`
  ADD CONSTRAINT `loans_ibfk_1` FOREIGN KEY (`UserID`) REFERENCES `users` (`UserID`),
  ADD CONSTRAINT `loans_ibfk_2` FOREIGN KEY (`CopyID`) REFERENCES `copies` (`CopyID`);

--
-- Constraints for table `reservations`
--
ALTER TABLE `reservations`
  ADD CONSTRAINT `reservations_ibfk_1` FOREIGN KEY (`CopyID`) REFERENCES `copies` (`CopyID`),
  ADD CONSTRAINT `reservations_ibfk_2` FOREIGN KEY (`UserID`) REFERENCES `users` (`UserID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
