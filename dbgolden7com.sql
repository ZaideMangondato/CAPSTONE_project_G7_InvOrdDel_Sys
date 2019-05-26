-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Apr 21, 2017 at 06:57 PM
-- Server version: 10.1.19-MariaDB
-- PHP Version: 5.6.28

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `dbgolden7com`
--
CREATE DATABASE IF NOT EXISTS `dbgolden7com` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
USE `dbgolden7com`;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_acc`
--

CREATE TABLE `tbl_acc` (
  `user` varchar(55) NOT NULL,
  `pass` varchar(99) NOT NULL,
  `stat` varchar(70) NOT NULL COMMENT 'active/inactive'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_acc`
--

INSERT INTO `tbl_acc` (`user`, `pass`, `stat`) VALUES
('admin', '21232f297a57a5a743894a0e4a801fc3', 'active'),
('bill', 'e8375d7cd983efcbf956da5937050ffc', 'inactive'),
('jhebrel', 'd351707d7bc704a6d0b698799820947e', 'inactive'),
('kid', '7de007e43f108e4b54b079f66e4285d8', 'inactive'),
('raiza', '603bf6bb072059eae13189225dffeb34', 'inactive'),
('senie', '5c1c4dd5771968dfa0a1d9d766f8c2ce', 'inactive'),
('zaide', 'e430fe15540c0ee9932935fd6afc13a5', 'active');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_assigned_emp`
--

CREATE TABLE `tbl_assigned_emp` (
  `delivery_id` varchar(55) NOT NULL,
  `emp_id` varchar(55) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_assigned_emp`
--

INSERT INTO `tbl_assigned_emp` (`delivery_id`, `emp_id`) VALUES
('DT-0439031719', 'E2P174943050228'),
('DT-0439031719', 'E2P174024060225'),
('DT-0456031738', 'E2P173630060225'),
('DT-0456031738', 'E2P174024060225'),
('DT-0435031704', 'E2P172623060225'),
('DT-0435031704', 'E2P173630060225'),
('DT-0424031749', 'E2P172623060225'),
('DT-0424031749', 'E2P173630060225'),
('DT-0527031752', 'E2P172623060225'),
('DT-0527031752', 'E2P173630060225');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_delivery_entries`
--

CREATE TABLE `tbl_delivery_entries` (
  `delivery_id` varchar(35) NOT NULL,
  `vehicle_id` varchar(35) NOT NULL,
  `trans_no` varchar(35) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_delivery_entries`
--

INSERT INTO `tbl_delivery_entries` (`delivery_id`, `vehicle_id`, `trans_no`) VALUES
('DT-0454031708', 'IDV-4401461611', 'TN-1102541703'),
('DT-0405031727', 'IDV-2501071613', 'TN-1102541703'),
('DT-0427031726', 'IDV-3602151611', 'TN-51391610'),
('DT-0427031726', 'IDV-3602151611', 'TN-0712111611'),
('DT-0427031726', 'IDV-3602151611', 'TN-1802151703'),
('DT-0439031719', 'IDV-3602151611', 'TN-51391610'),
('DT-0439031719', 'IDV-3602151611', 'TN-0712111611'),
('DT-0439031719', 'IDV-3602151611', 'TN-1802151703'),
('DT-0456031738', 'IDV-4401461611', 'TN-1102541703'),
('DT-0435031704', 'IDV-2501071612', 'TN-3504131703'),
('DT-0424031749', 'IDV-2501071614', 'TN-4504181703'),
('DT-0424031749', 'IDV-2501071614', 'TN-53151610'),
('DT-0424031749', 'IDV-2501071614', 'TN-2925361702'),
('DT-0424031749', 'IDV-2501071614', 'TN-1306391611'),
('DT-0424031749', 'IDV-2501071614', 'TN-0804341703'),
('DT-0527031752', 'IDV-4401461611', 'TN-3604331703');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_delivery_route`
--

CREATE TABLE `tbl_delivery_route` (
  `route_code` varchar(55) NOT NULL,
  `route_name` varchar(99) NOT NULL,
  `route_desc` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_delivery_route`
--

INSERT INTO `tbl_delivery_route` (`route_code`, `route_name`, `route_desc`) VALUES
('OTM', 'Outside the Municipality', 'n/a'),
('OTP', 'Outside the Province', 'n/a'),
('WTM', 'Within the Municipality', 'n/a');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_employees`
--

CREATE TABLE `tbl_employees` (
  `emp_id` varchar(55) NOT NULL,
  `emp_name` varchar(99) NOT NULL,
  `emp_phone` varchar(35) NOT NULL,
  `emp_address` text NOT NULL,
  `emp_position` varchar(35) NOT NULL,
  `dt_emp_reg` varchar(55) NOT NULL,
  `emp_status` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_employees`
--

INSERT INTO `tbl_employees` (`emp_id`, `emp_name`, `emp_phone`, `emp_address`, `emp_position`, `dt_emp_reg`, `emp_status`) VALUES
('E2P172623060225', 'Rico Madrigal', '09675342825', 'Central Poblacion Kalilangan Bukidnon', 'Helper', '2017-02-25 06:23:51', 'vacant'),
('E2P173630060225', 'Renaldo Ristauro', '09248725439', 'West Poblacion Kalilangan Bukidnon', 'Driver', '2017-02-25 06:31:06', 'vacant'),
('E2P174024060225', 'Karl Mike Trinidad', '09539383746', 'Brgy. Lampanusan Kalilangan Bukidnon', 'Helper', '2017-02-25 06:25:54', 'vacant'),
('E2P174943050228', 'Lando Arkanghel', '09368367886', 'Buntungan Wao Lanao Del Sur', 'Driver', '2017-02-28 05:44:46', 'vacant'),
('E2P175323060225', 'Jayson Dirista', '09872528265', 'West Poblacion Kalilangan Bukidnon', 'Driver', '2017-02-25 06:24:37', 'vacant'),
('E2P175927050228', 'Ramon Singson', '09638836836', 'Lampanusan, Kalilangan Bukidnon', 'Driver', '2017-02-28 05:29:04', 'vacant');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_for_delivery_trans`
--

CREATE TABLE `tbl_for_delivery_trans` (
  `trans_no` varchar(35) NOT NULL,
  `trans_type` varchar(55) NOT NULL,
  `delivery_status` varchar(55) NOT NULL,
  `dt_pending` varchar(55) NOT NULL,
  `dt_delivering` varchar(55) NOT NULL,
  `dt_delivered` varchar(55) NOT NULL,
  `delivery_id` varchar(55) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_for_delivery_trans`
--

INSERT INTO `tbl_for_delivery_trans` (`trans_no`, `trans_type`, `delivery_status`, `dt_pending`, `dt_delivering`, `dt_delivered`, `delivery_id`) VALUES
('TN-0125371702', 'For-Delivery', 'Pending', '2017-02-25 12:38:54', '---', '---', ''),
('TN-0503301703', 'For-Delivery', 'Pending', '2017-03-03 13:35:55', '---', '---', ''),
('TN-0504411611', 'For-Delivery', 'Pending', '2016-11-04 22:42:36', '---', '---', ''),
('TN-0712111611', 'For-Delivery', 'Delivering', '2016-11-12 06:14:05', '2017-03-04 11:39:55', '---', 'DT-0439031719'),
('TN-0804341703', 'For-Delivery', 'Delivered', '2017-03-04 15:39:10', '2017-03-04 16:26:27', '2017-03-04 16:32:06', 'DT-0424031749'),
('TN-1102541703', 'For-Delivery', 'Delivered', '2017-03-02 22:55:16', '2017-03-04 13:56:56', '2017-03-04 15:19:39', 'DT-0456031738'),
('TN-12101610', 'For-Delivery', 'Pending', '2016-10-31 15:14:16', '---', '---', ''),
('TN-1306391611', 'For-Delivery', 'Delivered', '2016-11-06 15:49:52', '2017-03-04 16:26:13', '2017-03-04 16:32:06', 'DT-0424031749'),
('TN-1802151703', 'For-Delivery', 'Delivering', '2017-03-02 06:16:51', '2017-03-04 11:40:03', '---', 'DT-0439031719'),
('TN-2925361702', 'For-Delivery', 'Delivered', '2017-02-25 09:38:15', '2017-03-04 16:26:08', '2017-03-04 16:32:06', 'DT-0424031749'),
('TN-3004391703', 'For-Delivery', 'Pending', '2017-03-04 15:42:14', '---', '---', ''),
('TN-3504131703', 'For-Delivery', 'Delivered', '2017-03-04 09:14:37', '2017-03-04 14:35:51', '2017-03-05 17:23:21', 'DT-0435031704'),
('TN-3604331703', 'For-Delivery', 'Delivering', '2017-03-04 14:34:57', '2017-03-05 22:28:09', '---', 'DT-0527031752'),
('TN-4504181703', 'For-Delivery', 'Delivered', '2017-03-04 16:23:26', '2017-03-04 16:25:56', '2017-03-04 16:32:06', 'DT-0424031749'),
('TN-51391610', 'For-Delivery', 'Delivering', '2016-10-31 13:41:07', '2017-03-04 11:39:41', '---', 'DT-0439031719'),
('TN-53151610', 'For-Delivery', 'Delivered', '2016-10-31 15:16:42', '2017-03-04 16:26:02', '2017-03-04 16:32:06', 'DT-0424031749');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_items`
--

CREATE TABLE `tbl_items` (
  `item_code` varchar(35) NOT NULL,
  `item_name` varchar(95) NOT NULL,
  `item_desc` text NOT NULL,
  `item_weight_kg` double NOT NULL,
  `item_unit` varchar(25) NOT NULL,
  `item_price` double(10,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_items`
--

INSERT INTO `tbl_items` (`item_code`, `item_name`, `item_desc`, `item_weight_kg`, `item_unit`, `item_price`) VALUES
('IT10-16101742', '4x4 Fine Cut Hard Wood', 'Made of Coconut Woods\r\nColor: Brown', 0.4, 'pcs', 15.00),
('IT10-16102054', 'Boysen Enamel White', 'Enamel White Paint.\r\n3 liters\r\n', 3.5, 'can', 250.00),
('IT10-16104135', 'Hallow Block', 'Made of:\r\nHolcim Cement\r\n', 4, 'pcs', 12.00),
('IT10-16104314', '2x2 Hard Woods', 'Made of Coconut lumber', 0.5, 'pcs', 11.00),
('IT11-16111240', 'Latex Flat White Gallon Triton', 'Paint.', 3, 'GAL.', 372.00),
('IT11-16114724', 'Nails No.1', 'Metal Nail', 0.01, 'kg', 25.50),
('IT2-17024142', 'Marine Plywood 3/16', 'n/a', 1.5, 'pcs', 375.00);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_items_inv`
--

CREATE TABLE `tbl_items_inv` (
  `item_code` varchar(35) NOT NULL,
  `no_of_stocks` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_items_inv`
--

INSERT INTO `tbl_items_inv` (`item_code`, `no_of_stocks`) VALUES
('IT10-16101742', 155),
('IT10-16102054', 101),
('IT10-16104135', 2),
('IT10-16104314', 105),
('IT11-16111240', 187),
('IT11-16114724', 38),
('IT2-17024142', 90);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_ordered_items`
--

CREATE TABLE `tbl_ordered_items` (
  `trans_no` varchar(35) NOT NULL,
  `item_code` varchar(35) NOT NULL,
  `item_name` varchar(99) NOT NULL,
  `item_weight_kg` double NOT NULL,
  `total_item_weight_kg` double NOT NULL,
  `ord_qty` int(10) NOT NULL,
  `item_unit` varchar(35) NOT NULL,
  `item_price` double NOT NULL,
  `total_price` double NOT NULL,
  `dt_ordered` varchar(55) NOT NULL,
  `ord_tracecode` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_ordered_items`
--

INSERT INTO `tbl_ordered_items` (`trans_no`, `item_code`, `item_name`, `item_weight_kg`, `total_item_weight_kg`, `ord_qty`, `item_unit`, `item_price`, `total_price`, `dt_ordered`, `ord_tracecode`) VALUES
('TN-3925351702', 'IT10-16101742', '4x4 Fine Cut Hard Wood', 0.4, 36, 90, 'pcs', 15, 1350, '2017-02-25', 'TRC-0217353925'),
('TN-2925361702', 'IT10-16101742', '4x4 Fine Cut Hard Wood', 0.4, 20, 50, 'pcs', 15, 750, '2017-02-25', 'TRC-0217362125'),
('TN-0125371702', 'IT10-16101742', '4x4 Fine Cut Hard Wood', 0.4, 2.4, 6, 'pcs', 15, 90, '2017-02-25', 'TRC-0217370125'),
('TN-2925361702', 'IT10-16102054', 'Boysen Enamel White', 3.5, 245, 70, 'can', 250, 17500, '2017-02-25', 'TRC-0217380225'),
('TN-0125371702', 'IT10-16104135', 'Hallow Block', 4, 360, 90, 'pcs', 12, 1080, '2017-02-25', 'TRC-0217380325'),
('TN-0819391702', 'IT10-16102054', 'Boysen Enamel White', 3.5, 35, 10, 'can', 250, 2500, '2017-02-19', 'TRC-0217392119'),
('TN-3504131703', 'IT10-16102054', 'Boysen Enamel White', 3.5, 21, 6, 'can', 250, 1500, '2017-03-04', 'TRC-0317133504'),
('TN-3504131703', 'IT11-16114724', 'Nails No.1', 0.01, 0.3, 30, 'kg', 25.5, 765, '2017-03-04', 'TRC-0317142404'),
('TN-1802151703', 'IT10-16104135', 'Hallow Block', 4, 200, 50, 'pcs', 12, 600, '2017-03-02', 'TRC-0317151802'),
('TN-4504181703', 'IT10-16104135', 'Hallow Block', 4, 360, 90, 'pcs', 12, 1080, '2017-03-04', 'TRC-0317184504'),
('TN-4504181703', 'IT10-16104314', '2x2 Hard Woods', 0.5, 20, 40, 'pcs', 11, 440, '2017-03-04', 'TRC-0317205204'),
('TN-4504181703', 'IT10-16102054', 'Boysen Enamel White', 3.5, 175, 50, 'can', 250, 12500, '2017-03-04', 'TRC-0317212604'),
('TN-0503301703', 'IT10-16101742', '4x4 Fine Cut Hard Wood', 0.4, 8, 20, 'pcs', 15, 300, '2017-03-03', 'TRC-0317300503'),
('TN-3604331703', 'IT10-16104135', 'Hallow Block', 4, 200, 50, 'pcs', 12, 600, '2017-03-04', 'TRC-0317333604'),
('TN-0503301703', 'IT11-16114724', 'Nails No.1', 0.01, 0.5, 50, 'kg', 25.5, 1275, '2017-03-03', 'TRC-0317343803'),
('TN-3604331703', 'IT10-16104314', '2x2 Hard Woods', 0.5, 32.5, 65, 'pcs', 11, 715, '2017-03-04', 'TRC-0317343904'),
('TN-0503301703', 'IT10-16102054', 'Boysen Enamel White', 3.5, 10.5, 3, 'can', 250, 750, '2017-03-03', 'TRC-0317345403'),
('TN-0804341703', 'IT10-16104314', '2x2 Hard Woods', 0.5, 17.5, 35, 'pcs', 11, 385, '2017-03-04', 'TRC-0317382304'),
('TN-0804341703', 'IT10-16101742', '4x4 Fine Cut Hard Wood', 0.4, 6, 15, 'pcs', 15, 225, '2017-03-04', 'TRC-0317383904'),
('TN-0804341703', 'IT11-16114724', 'Nails No.1', 0.01, 0.01, 1, 'kg', 25.5, 25.5, '2017-03-04', 'TRC-0317384904'),
('TN-3004391703', 'IT10-16104135', 'Hallow Block', 4, 200, 50, 'pcs', 12, 600, '2017-03-04', 'TRC-0317393004'),
('TN-3004391703', 'IT10-16102054', 'Boysen Enamel White', 3.5, 87.5, 25, 'can', 250, 6250, '2017-03-04', 'TRC-0317414704'),
('TN-3004391703', 'IT11-16114724', 'Nails No.1', 0.01, 0.02, 2, 'kg', 25.5, 51, '2017-03-04', 'TRC-0317415804'),
('TN-1102541703', 'IT10-16104135', 'Hallow Block', 4, 200, 50, 'pcs', 12, 600, '2017-03-02', 'TRC-0317541102'),
('TN-1102541703', 'IT10-16104314', '2x2 Hard Woods', 0.5, 10, 20, 'pcs', 11, 220, '2017-03-02', 'TRC-0317550202'),
('TN-59041610', 'IT10-16102054', 'Boysen Enamel White', 3.5, 17.5, 5, 'can', 250, 1250, '2016-10-30', 'TRC-10160459'),
('TN-59041610', 'IT10-16101742', '4x4 Fine Cut Hard Wood', 0.4, 2.4, 6, 'pcs', 15, 90, '2016-10-30', 'TRC-10160512'),
('TN-13091610', 'IT10-16104135', 'Hallow Block', 4, 20, 5, 'pcs', 12, 60, '2016-10-30', 'TRC-10160912'),
('TN-12101610', 'IT10-16104135', 'Hallow Block', 4, 260, 65, 'pcs', 11, 715, '2016-10-31', 'TRC-10161012'),
('TN-33101610', 'IT10-16104135', 'Hallow Block', 4, 4, 1, 'pcs', 12, 12, '2016-10-30', 'TRC-10161033'),
('TN-26121610', 'IT10-16104135', 'Hallow Block', 4, 12, 3, 'pcs', 12, 36, '2016-10-30', 'TRC-10161226'),
('TN-12101610', 'IT10-16104135', 'Hallow Block', 4, 20, 5, 'pcs', 12, 60, '2016-10-31', 'TRC-10161236'),
('TN-21131610', 'IT10-16104135', 'Hallow Block', 4, 8, 2, 'pcs', 12, 24, '2016-10-30', 'TRC-10161321'),
('TN-53151610', 'IT10-16104135', 'Hallow Block', 4, 312, 78, 'pcs', 12, 936, '2016-10-31', 'TRC-10161553'),
('TN-04171610', 'IT10-16104135', 'Hallow Block', 4, 8, 2, 'pcs', 12, 24, '2016-10-30', 'TRC-10161704'),
('TN-18191610', 'IT10-16102054', 'Boysen Enamel White', 3.5, 17.5, 5, 'can', 250, 1250, '2016-10-30', 'TRC-10161918'),
('TN-14211610', 'IT10-16102054', 'Boysen Enamel White', 3.5, 17.5, 5, 'can', 250, 1250, '2016-10-30', 'TRC-10162114'),
('TN-53281610', 'IT10-16102054', 'Boysen Enamel White', 3.5, 7, 2, 'can', 250, 500, '2016-10-30', 'TRC-10162853'),
('TN-48311610', 'IT10-16104135', 'Hallow Block', 4, 20, 5, 'pcs', 12, 60, '2016-10-30', 'TRC-10163148'),
('TN-04321610', 'IT10-16104135', 'Hallow Block', 4, 24, 6, 'pcs', 12, 72, '2016-10-30', 'TRC-10163204'),
('TN-13331610', 'IT10-16102054', 'Boysen Enamel White', 3.5, 14, 4, 'can', 250, 1000, '2016-10-30', 'TRC-10163317'),
('TN-13331610', 'IT10-16104314', '2x2 Hard Woods', 0.5, 2.5, 5, 'pcs', 11, 55, '2016-10-30', 'TRC-10163353'),
('TN-13351610', 'IT10-16104135', 'Hallow Block', 4, 20, 5, 'pcs', 12, 60, '2016-10-30', 'TRC-10163513'),
('TN-43361610', 'IT10-16104135', 'Hallow Block', 4, 20, 5, 'pcs', 12, 60, '2016-10-30', 'TRC-10163643'),
('TN-51391610', 'IT10-16102054', 'Boysen Enamel White', 3.5, 17.5, 5, 'can', 250, 1250, '2016-10-31', 'TRC-10163951'),
('TN-51391610', 'IT10-16104135', 'Hallow Block', 4, 36, 9, 'pcs', 14, 126, '2016-10-31', 'TRC-10164037'),
('TN-47421610', 'IT10-16101742', '4x4 Fine Cut Hard Wood', 0.4, 2, 5, 'pcs', 15, 75, '2016-10-30', 'TRC-10164247'),
('TN-38431610', 'IT10-16102054', 'Boysen Enamel White', 3.5, 17.5, 5, 'can', 250, 1250, '2016-10-30', 'TRC-10164338'),
('TN-00511610', 'IT10-16102054', 'Boysen Enamel White', 3.5, 17.5, 5, 'can', 250, 1250, '2016-10-31', 'TRC-10165100'),
('TN-43551610', 'IT10-16102054', 'Boysen Enamel White', 3.5, 14, 4, 'can', 250, 1000, '2016-10-30', 'TRC-10165543'),
('TN-33571610', 'IT10-16104135', 'Hallow Block', 4, 20, 5, 'pcs', 12, 60, '2016-10-30', 'TRC-10165733'),
('TN-33571610', 'IT10-16104135', 'Hallow Block', 4, 20, 5, 'pcs', 12, 60, '2016-10-30', 'TRC-10165754'),
('TN-33571610', 'IT10-16102054', 'Boysen Enamel White', 3.5, 17.5, 5, 'can', 250, 1250, '2016-10-30', 'TRC-10165824'),
('TN-0712111611', 'IT10-16101742', '4x4 Fine Cut Hard Wood', 0.4, 2.8, 7, 'pcs', 15, 105, '2016-11-12', 'TRC-1116110712'),
('TN-0712111611', 'IT10-16102054', 'Boysen Enamel White', 3.5, 21, 6, 'can', 250, 1500, '2016-11-12', 'TRC-1116112912'),
('TN-0712111611', 'IT11-16114724', 'Nails No.1', 0.01, 0.05, 5, 'kg', 25.5, 127.5, '2016-11-12', 'TRC-1116113812'),
('TN-1306391611', 'IT10-16104135', 'Hallow Block', 4, 108, 27, 'pcs', 12, 324, '2016-11-06', 'TRC-1116392106'),
('TN-0504411611', 'IT10-16104135', 'Hallow Block', 4, 380, 95, 'pcs', 12, 1140, '2016-11-04', 'TRC-1116410504'),
('TN-0504411611', 'IT11-16114724', 'Nails No.1', 0.01, 0.5, 50, 'kg', 25.5, 1275, '2016-11-04', 'TRC-1116421204'),
('TN-1306391611', 'IT11-16111240', 'Latex Flat White Gallon Triton', 3, 15, 5, 'GAL.', 372, 1860, '2016-11-06', 'TRC-1116485606'),
('TN-1306391611', 'IT10-16102054', 'Boysen Enamel White', 3.5, 140, 40, 'can', 250, 10000, '2016-11-06', 'TRC-1116491506'),
('TN-1306391611', 'IT10-16101742', '4x4 Fine Cut Hard Wood', 0.4, 28, 70, 'pcs', 15, 1050, '2016-11-06', 'TRC-1116493306'),
('TN-5001491611', 'IT11-16114724', 'Nail No.1', 0.01, 0.05, 5, 'kg', 25.5, 127.5, '2016-11-01', 'TRC-1116495001');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_saved_delivered`
--

CREATE TABLE `tbl_saved_delivered` (
  `delivery_id` varchar(55) NOT NULL,
  `vehicle_id` varchar(55) NOT NULL,
  `route_code` varchar(55) NOT NULL,
  `load_capacity_kg` double NOT NULL,
  `loaded_kg` double NOT NULL,
  `no_of_orders` int(4) NOT NULL,
  `total_cost` double NOT NULL,
  `est_fuel_cost` double NOT NULL,
  `extra_charges` varchar(123) NOT NULL,
  `extra_chrgs_total_cost` double NOT NULL,
  `delivery_distance` double NOT NULL,
  `est_dt_arrival` varchar(55) NOT NULL,
  `dt_delivery` varchar(55) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_saved_delivered`
--

INSERT INTO `tbl_saved_delivered` (`delivery_id`, `vehicle_id`, `route_code`, `load_capacity_kg`, `loaded_kg`, `no_of_orders`, `total_cost`, `est_fuel_cost`, `extra_charges`, `extra_chrgs_total_cost`, `delivery_distance`, `est_dt_arrival`, `dt_delivery`) VALUES
('DT-0456031738', 'IDV-4401461611', 'OTM', 900, 210, 1, 820, 130.75, 'none', 0, 58, '2017-03-04 02:56:41', '2017-03-04 13:57:44'),
('DT-0424031749', 'IDV-2501071614', 'WTM', 1500, 1446.51, 5, 47075.5, 250, 'none', 0, 90, '2017-03-04 06:25:36', '2017-03-04 16:29:49'),
('DT-0435031704', 'IDV-2501071612', 'OTM', 1500, 21.3, 1, 2265, 140, 'none', 0, 56, '2017-03-04 02:35:13', '2017-03-04 14:36:49');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_saved_delivery`
--

CREATE TABLE `tbl_saved_delivery` (
  `delivery_id` varchar(55) NOT NULL,
  `vehicle_id` varchar(55) NOT NULL,
  `route_code` varchar(55) NOT NULL,
  `load_capacity_kg` double NOT NULL,
  `loaded_kg` double NOT NULL,
  `no_of_orders` int(4) NOT NULL,
  `total_cost` double NOT NULL,
  `est_fuel_cost` double NOT NULL,
  `extra_charges` varchar(123) NOT NULL,
  `extra_chrgs_total_cost` double NOT NULL,
  `delivery_distance` double NOT NULL,
  `est_dt_arrival` varchar(55) NOT NULL,
  `dt_delivery` varchar(55) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_saved_delivery`
--

INSERT INTO `tbl_saved_delivery` (`delivery_id`, `vehicle_id`, `route_code`, `load_capacity_kg`, `loaded_kg`, `no_of_orders`, `total_cost`, `est_fuel_cost`, `extra_charges`, `extra_chrgs_total_cost`, `delivery_distance`, `est_dt_arrival`, `dt_delivery`) VALUES
('DT-0439031719', 'IDV-3602151611', 'WTM', 280, 277.35, 3, 3708.5, 120, 'none', 0, 58, '2017-03-04 12:39:32', '2017-03-04 11:40:49'),
('DT-0527031752', 'IDV-4401461611', 'OTM', 900, 232.5, 1, 1315, 89, 'none', 0, 58, '2017-03-05 11:27:59', '2017-03-05 22:29:13');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_saved_orders`
--

CREATE TABLE `tbl_saved_orders` (
  `trans_no` varchar(35) NOT NULL,
  `sold_to` varchar(35) NOT NULL,
  `contact_no` varchar(55) NOT NULL,
  `del_destination` text NOT NULL,
  `expctd_dt_delivery` varchar(45) NOT NULL,
  `no_of_items` int(10) NOT NULL,
  `total_qty` int(10) NOT NULL,
  `total_weight_kg` double NOT NULL,
  `total_amount` double(10,2) NOT NULL,
  `dt_ordered` varchar(45) NOT NULL,
  `trans_type` varchar(75) NOT NULL COMMENT 'For Delivery/Non-Delivery'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_saved_orders`
--

INSERT INTO `tbl_saved_orders` (`trans_no`, `sold_to`, `contact_no`, `del_destination`, `expctd_dt_delivery`, `no_of_items`, `total_qty`, `total_weight_kg`, `total_amount`, `dt_ordered`, `trans_type`) VALUES
('TN-00511610', 'Mangondato', '09268070114', 'Central Poblacion Kalilangan Bukidnon', '', 1, 5, 17.5, 1250.00, '2016-10-31', 'Non-Delivery'),
('TN-0125371702', 'Ruth Mangondato', '096256353', 'Central Pob. Kalilangan', '2017-02-25', 2, 96, 362.4, 1170.00, '2017-02-25', 'For-Delivery'),
('TN-0503301703', 'Richard Rich', '09886756245', 'Park Area, Wao Lanao Del Sur', '2017-03-05', 3, 73, 19, 2325.00, '2017-03-03', 'For-Delivery'),
('TN-0504411611', 'Alonto Karim', '094675373748', 'Purok 3, West Poblacion Kalilangan Bukidnon', '2017-2-28', 2, 145, 380.5, 2415.00, '2016-11-04', 'For-Delivery'),
('TN-0712111611', 'Reymundo Arnado', '0977687678', 'Blk. 3 Lampanusan, Kalilangan Bukidnon', '2017-2-28', 3, 18, 23.85, 1732.50, '2016-11-12', 'For-Delivery'),
('TN-0804341703', 'Ken Ryan Uy', '09568767564', 'Block 2 Malinao, Kalilangan Bukidnon', '2017-03-05', 3, 51, 23.51, 635.50, '2017-03-04', 'For-Delivery'),
('TN-0819391702', 'Mangondato, Ruth', '09568798567', 'Pamotolon, Elementary School Kalilangan', '', 1, 10, 35, 2500.00, '2017-02-19', 'Non-Delivery'),
('TN-1102541703', 'Hernandes Barana', '09889878675', 'Barandias, Pangantucan Bukidnon', '2017-03-05', 2, 70, 210, 820.00, '2017-03-02', 'For-Delivery'),
('TN-12101610', 'Cagampang', '09359876465', 'P3 Central Poblacion Kalilangan Bukidnon', '2017-2-28', 2, 70, 280, 775.00, '2016-10-31', 'For-Delivery'),
('TN-1306391611', 'Semion Villarias', '09223344123', 'Zone 2 Brgy. Lampanusan. Kalilangan, Bukidnon', '2017-2-28', 4, 142, 291, 13234.00, '2016-11-06', 'For-Delivery'),
('TN-1802151703', 'Bin Rashad Macadato', '09342589346', 'Zone 2 Pamotolon Kalilangan Bukidnon', '2017-03-07', 1, 50, 200, 600.00, '2017-03-02', 'For-Delivery'),
('TN-2925361702', 'Leo Molina', '09667656486', 'Cetral Pob. Kalilangan', '2017-02-26', 2, 120, 265, 18250.00, '2017-02-25', 'For-Delivery'),
('TN-3004391703', 'Arnold Enterins', '09883736736', 'Block 4 Alae, Manolo Fortich Bukidnon', '2017-03-05', 3, 77, 287.52, 6901.00, '2017-03-04', 'For-Delivery'),
('TN-3504131703', 'Cimafranca', '09887653763', 'Zone 2 Banisilan, Cotabato', '2017-03-06', 2, 36, 21.3, 2265.00, '2017-03-04', 'For-Delivery'),
('TN-3604331703', 'Cardo Dalisay', '09778363536', 'Zone 4 Poblacion Maramag Bukidnon', '2017-03-05', 2, 115, 232.5, 1315.00, '2017-03-04', 'For-Delivery'),
('TN-3925351702', 'Coronado', '09668745375', 'West Pob. Kalilangan', '', 1, 90, 36, 1350.00, '2017-02-25', 'Non-Delivery'),
('TN-4504181703', 'Allen James Gomez', '09836286288', 'Block 4 Brgy. Poblacion. Kalilangan Bukidon', '2017-03-05', 3, 180, 555, 14020.00, '2017-03-04', 'For-Delivery'),
('TN-5001491611', 'Rotsen Glodove', '0965383637', 'Kalilangan', '', 1, 5, 0.05, 127.50, '2016-11-01', 'Non-Delivery'),
('TN-51391610', 'Enterina', '09746463837', 'West Pob. Kalilangan Bukidnon', '2017-2-28', 2, 14, 53.5, 1376.00, '2016-10-31', 'For-Delivery'),
('TN-53151610', 'Macarambon', '09342897452', 'Pamotolon Kalilangan, Bukidnon', '2017-2-28', 1, 78, 312, 936.00, '2016-10-31', 'For-Delivery');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_saved_orders_route`
--

CREATE TABLE `tbl_saved_orders_route` (
  `trans_no` varchar(55) NOT NULL,
  `route_code` varchar(55) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_saved_orders_route`
--

INSERT INTO `tbl_saved_orders_route` (`trans_no`, `route_code`) VALUES
('TN-0125371702', 'wtm'),
('TN-0503301703', 'OTP'),
('TN-0504411611', 'wtm'),
('TN-0712111611', 'wtm'),
('TN-0804341703', 'WTM'),
('TN-1102541703', 'OTM'),
('TN-12101610', 'wtm'),
('TN-1306391611', 'wtm'),
('TN-1802151703', 'WTM'),
('TN-2925361702', 'wtm'),
('TN-3004391703', 'OTM'),
('TN-3504131703', 'OTM'),
('TN-3604331703', 'OTM'),
('TN-4504181703', 'WTM'),
('TN-51391610', 'wtm'),
('TN-53151610', 'wtm');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_stock_in`
--

CREATE TABLE `tbl_stock_in` (
  `stock_in_id` varchar(35) NOT NULL,
  `supplier_id` varchar(35) NOT NULL,
  `dt_stock_in` varchar(35) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_stock_in`
--

INSERT INTO `tbl_stock_in` (`stock_in_id`, `supplier_id`, `dt_stock_in`) VALUES
('ST-10491611', 'RSO1', '2016-11-01'),
('ST-15591610', 'SUPP-10022116', '2016-10-29'),
('ST-17151610', 'SUPP-10452116', '2016-10-31'),
('ST-18241610', 'RSO1', '2016-10-29'),
('ST-20321611', 'RSO1', '2016-11-07'),
('ST-22441610', 'SUPP-10022116', '2016-10-30'),
('ST-24501611', 'SUPP-10022116', '2016-11-06'),
('ST-25331611', 'SUPP-10452116', '2016-11-07'),
('ST-25581610', 'SUPP-10022116', '2016-10-30'),
('ST-27561610', 'SUPP-10022116', '2016-10-29'),
('ST-30431703', 'RSO1', '2017-03-04'),
('ST-32181703', 'SUPP-02031617', '2017-03-04'),
('ST-34351702', 'SUPP-02031617', '2017-02-25'),
('ST-36131611', 'RSO1', '2016-11-03'),
('ST-39591610', 'SUPP-10452116', '2016-10-29'),
('ST-40331611', 'SUPP-10452116', '2016-11-07'),
('ST-47281611', 'RSO1', '2016-11-01'),
('ST-47301610', 'SUPP-10452116', '2016-10-30'),
('ST-47551610', 'SUPP-10452116', '2016-10-30'),
('ST-48531702', 'RSO1', '2017-02-10'),
('ST-49121610', 'RSO1', '2016-10-29'),
('ST-54501611', 'RSO1', '2016-11-06'),
('ST-57041702', 'SUPP-02031617', '2017-02-19');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_stock_logs`
--

CREATE TABLE `tbl_stock_logs` (
  `stock_in_id` varchar(35) NOT NULL,
  `item_code` varchar(35) NOT NULL,
  `stock_added` int(10) NOT NULL,
  `dt_stock_logs` varchar(35) NOT NULL,
  `tracecode` varchar(35) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_stock_logs`
--

INSERT INTO `tbl_stock_logs` (`stock_in_id`, `item_code`, `stock_added`, `dt_stock_logs`, `tracecode`) VALUES
('ST-57041702', 'IT10-16102054', 10, '2017-02-19 12:05:21', 'TRC-02170456'),
('ST-57041702', 'IT10-16101742', 34, '2017-02-19 12:05:42', 'TRC-02170523'),
('ST-34351702', 'IT10-16101742', 50, '2017-02-25 12:36:04', 'TRC-02173534'),
('ST-34351702', 'IT10-16104314', 5, '2017-02-25 12:36:22', 'TRC-02173606'),
('ST-48531702', 'IT10-16104135', 7, '2017-02-10 19:54:00', 'TRC-02175348'),
('ST-48531702', 'IT11-16114724', 7, '2017-02-10 19:54:15', 'TRC-02175403'),
('ST-32181703', 'IT10-16104135', 100, '2017-03-04 09:19:08', 'TRC-03171832'),
('ST-32181703', 'IT10-16102054', 80, '2017-03-04 09:19:30', 'TRC-03171913'),
('ST-32181703', 'IT10-16101742', 85, '2017-03-04 09:19:44', 'TRC-03171933'),
('ST-30431703', 'IT10-16101742', 55, '2017-03-04 15:43:38', 'TRC-03174330'),
('ST-30431703', 'IT10-16102054', 76, '2017-03-04 15:43:46', 'TRC-03174340'),
('ST-30431703', 'IT10-16104135', 90, '2017-03-04 15:43:54', 'TRC-03174347'),
('ST-30431703', 'IT10-16104314', 45, '2017-03-04 15:44:00', 'TRC-03174355'),
('ST-30431703', 'IT11-16111240', 44, '2017-03-04 15:44:09', 'TRC-03174401'),
('ST-30431703', 'IT11-16114724', 4, '2017-03-04 15:44:19', 'TRC-03174412'),
('ST-30431703', 'IT2-17024142', 90, '2017-03-04 15:44:31', 'TRC-03174421'),
('ST-39591610', 'IT10-16104135', 30, '2016-10-29 21:02:24', 'TRC-10160209'),
('ST-39591610', 'IT10-16104314', 33, '2016-10-29 21:02:59', 'TRC-10160247'),
('ST-49121610', 'IT10-16102054', 4, '2016-10-29 21:13:00', 'TRC-10161249'),
('ST-17151610', 'IT10-16104135', 100, '2016-10-31 15:15:29', 'TRC-10161517'),
('ST-17151610', 'IT10-16104135', 100, '2016-10-31 15:15:41', 'TRC-10161530'),
('ST-18241610', 'IT10-16101742', 10, '2016-10-29 22:24:37', 'TRC-10162427'),
('ST-18241610', 'IT10-16104135', 56, '2016-10-29 22:24:44', 'TRC-10162438'),
('ST-18241610', 'IT10-16102054', 33, '2016-10-29 22:24:53', 'TRC-10162446'),
('ST-47301610', 'IT10-16104135', 78, '2016-10-30 21:31:01', 'TRC-10163047'),
('ST-47301610', 'IT10-16102054', 66, '2016-10-30 21:31:15', 'TRC-10163103'),
('ST-47301610', 'IT10-16104314', 30, '2016-10-30 21:31:29', 'TRC-10163117'),
('ST-55421610', 'IT10-16104314', 5, '2016-10-29 18:43:42', 'TRC-10164324'),
('ST-22441610', 'IT10-16101742', 80, '2016-10-30 11:44:33', 'TRC-10164422'),
('ST-47551610', 'IT10-16104135', 45, '2016-10-30 19:55:55', 'TRC-10165547'),
('ST-27561610', 'IT10-16104314', 7, '2016-10-29 20:56:35', 'TRC-10165627'),
('ST-27561610', 'IT10-16101742', 11, '2016-10-29 20:56:43', 'TRC-10165637'),
('ST-25581610', 'IT10-16102054', 4, '2016-10-30 21:58:50', 'TRC-10165825'),
('ST-15591610', 'IT10-16101742', 11, '2016-10-29 20:59:29', 'TRC-10165915'),
('ST-36131611', 'IT11-16111240', 8, '2016-11-03 12:13:52', 'TRC-11161336'),
('ST-47281611', 'IT11-16114724', 90, '2016-11-01 20:28:56', 'TRC-11162847'),
('ST-20321611', 'IT11-16111240', 40, '2016-11-07 10:32:49', 'TRC-11163234'),
('ST-25331611', 'IT10-16104135', 95, '2016-11-07 10:33:36', 'TRC-11163250'),
('ST-40331611', 'IT10-16104135', 90, '2016-11-07 10:33:50', 'TRC-11163337'),
('ST-10491611', 'IT11-16114724', 75, '2016-11-01 15:49:23', 'TRC-11164910'),
('ST-10491611', 'IT10-16104314', 50, '2016-11-01 15:49:38', 'TRC-11164925'),
('ST-24501611', 'IT10-16101742', 100, '2016-11-06 15:50:36', 'TRC-11165024'),
('ST-24501611', 'IT10-16104314', 100, '2016-11-06 15:50:47', 'TRC-11165038'),
('ST-54501611', 'IT10-16102054', 100, '2016-11-06 15:51:02', 'TRC-11165049'),
('ST-54501611', 'IT11-16111240', 100, '2016-11-06 15:51:15', 'TRC-11165103'),
('ST-54501611', 'IT11-16114724', 5, '2016-11-06 15:51:30', 'TRC-11165118');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_suppliers`
--

CREATE TABLE `tbl_suppliers` (
  `supplier_id` varchar(35) NOT NULL,
  `supplier_name` varchar(99) NOT NULL,
  `supplier_desc` text NOT NULL,
  `supplier_addr` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_suppliers`
--

INSERT INTO `tbl_suppliers` (`supplier_id`, `supplier_name`, `supplier_desc`, `supplier_addr`) VALUES
('RSO1', 'RSO Hardware', 'Dealer of Hardware, Tools, Equipment and Construction Materials', 'Osmena St. Cagayan de Oro City Mis. Or.'),
('SUPP-02031617', 'RODELIO Construction Supplies', 'Construction supplies dealer\r\n+639878678785', 'Quirino St. Valencia City Bukidnon'),
('SUPP-10022116', 'KARIM Lumber Dealer', 'Hard woods and Lumber', 'West Poblacion Kalilangan Bukidnon'),
('SUPP-10452116', 'Golden Seven Commercial (Own)', 'Hardware and Construction Supplies', 'Kalilangan, Bukidnon');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_vehicles_info`
--

CREATE TABLE `tbl_vehicles_info` (
  `vehicle_id` varchar(45) NOT NULL,
  `plate_no` varchar(155) NOT NULL,
  `model` varchar(95) NOT NULL,
  `type` varchar(55) NOT NULL,
  `color` varchar(55) NOT NULL,
  `vehicle_desc` text NOT NULL,
  `max_weight_kg` double NOT NULL,
  `vehicle_weight_kg` double NOT NULL,
  `vehicle_service_status` varchar(55) NOT NULL COMMENT 'In-service/Out-of-service',
  `vehicle_delivery_status` varchar(55) NOT NULL COMMENT 'Vacant/In-use',
  `dt_vehicle_reg` varchar(55) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_vehicles_info`
--

INSERT INTO `tbl_vehicles_info` (`vehicle_id`, `plate_no`, `model`, `type`, `color`, `vehicle_desc`, `max_weight_kg`, `vehicle_weight_kg`, `vehicle_service_status`, `vehicle_delivery_status`, `dt_vehicle_reg`) VALUES
('IDV-2501071611', 'MNB332', 'ISUZU Elf M125', 'Mini Truck', 'White', 'n/a', 1500, 1200, 'In-service', 'Vacant', '2016-11-01 21:11:18'),
('IDV-2501071612', 'MNB332', 'ISUZU Elf M125', 'Mini Truck', 'White', 'n/a', 1500, 1200, 'In-service', 'Vacant', '2016-11-01 21:11:18'),
('IDV-2501071613', 'MNB332', 'ISUZU Elf M125', 'Mini Truck', 'White', 'n/a', 1500, 1200, 'In-service', 'Vacant', '2016-11-01 21:11:18'),
('IDV-2501071614', 'MNB332', 'ISUZU Elf M125', 'Mini Truck', 'White', 'n/a', 1500, 1200, 'In-service', 'Vacant', '2016-11-01 21:11:18'),
('IDV-3602151611', 'KJH435', 'Honda STX 125', 'Delivery Tricycle', 'Red,Black', 'n/a', 280, 1600, 'In-service', 'In-use', '2016-11-02 21:16:54'),
('IDV-4401461611', 'JKT323', 'Isuzu Transporter L200', 'Delivery Van', 'Red', 'n/a', 900, 890, 'In-service', 'In-use', '2016-11-01 19:48:38');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_vehicle_del_route`
--

CREATE TABLE `tbl_vehicle_del_route` (
  `vehicle_id` varchar(55) NOT NULL,
  `route_code` varchar(55) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_vehicle_del_route`
--

INSERT INTO `tbl_vehicle_del_route` (`vehicle_id`, `route_code`) VALUES
('IDV-2501071611', 'OTP'),
('IDV-2501071612', 'otm'),
('IDV-2501071613', 'otm'),
('IDV-2501071614', 'wtm'),
('IDV-3602151611', 'WTM'),
('IDV-4401461611', 'OTM');

-- --------------------------------------------------------

--
-- Stand-in structure for view `v_delivery_entries`
--
CREATE TABLE `v_delivery_entries` (
`delivery_id` varchar(35)
,`vehicle_id` varchar(35)
,`trans_no` varchar(35)
,`sold_to` varchar(35)
,`contact_no` varchar(55)
,`del_destination` text
,`no_of_items` int(10)
,`total_qty` int(10)
,`total_weight_kg` double
,`total_amount` double(10,2)
,`dt_ordered` varchar(45)
);

-- --------------------------------------------------------

--
-- Stand-in structure for view `v_delivery_trans_orders_full`
--
CREATE TABLE `v_delivery_trans_orders_full` (
`trans_no` varchar(35)
,`sold_to` varchar(35)
,`contact_no` varchar(55)
,`del_destination` text
,`expctd_dt_delivery` varchar(45)
,`no_of_items` int(10)
,`total_qty` int(10)
,`total_weight_kg` double
,`total_amount` double(10,2)
,`dt_ordered` varchar(45)
,`trans_type` varchar(75)
,`dt_pending` varchar(55)
,`dt_delivering` varchar(55)
,`dt_delivered` varchar(55)
,`delivery_id` varchar(55)
);

-- --------------------------------------------------------

--
-- Stand-in structure for view `v_full_items_inv`
--
CREATE TABLE `v_full_items_inv` (
`item_code` varchar(35)
,`item_name` varchar(95)
,`item_desc` text
,`item_weight_kg` double
,`no_of_stocks` int(10)
,`item_unit` varchar(25)
,`item_price` double(10,2)
);

-- --------------------------------------------------------

--
-- Stand-in structure for view `v_saved_for_delivery_orders`
--
CREATE TABLE `v_saved_for_delivery_orders` (
`trans_no` varchar(35)
,`sold_to` varchar(35)
,`contact_no` varchar(55)
,`del_destination` text
,`no_of_items` int(10)
,`total_qty` int(10)
,`total_weight_kg` double
,`total_amount` double(10,2)
,`dt_ordered` varchar(45)
,`trans_type` varchar(75)
,`delivery_status` varchar(55)
);

-- --------------------------------------------------------

--
-- Stand-in structure for view `v_saved_orders_route`
--
CREATE TABLE `v_saved_orders_route` (
`trans_no` varchar(55)
,`route_code` varchar(55)
,`route_name` varchar(99)
);

-- --------------------------------------------------------

--
-- Stand-in structure for view `v_stock_in`
--
CREATE TABLE `v_stock_in` (
`stock_in_id` varchar(35)
,`supplier_id` varchar(35)
,`supplier_name` varchar(99)
,`dt_stock_in` varchar(35)
);

-- --------------------------------------------------------

--
-- Stand-in structure for view `v_stock_logs`
--
CREATE TABLE `v_stock_logs` (
`stock_in_id` varchar(35)
,`item_code` varchar(35)
,`item_name` varchar(95)
,`stock_added` int(10)
,`dt_stock_logs` varchar(35)
,`tracecode` varchar(35)
);

-- --------------------------------------------------------

--
-- Stand-in structure for view `v_vehicle_info_del_route`
--
CREATE TABLE `v_vehicle_info_del_route` (
`vehicle_id` varchar(55)
,`plate_no` varchar(155)
,`model` varchar(95)
,`type` varchar(55)
,`color` varchar(55)
,`vehicle_desc` text
,`max_weight_kg` double
,`vehicle_weight_kg` double
,`vehicle_service_status` varchar(55)
,`vehicle_delivery_status` varchar(55)
,`route_name` varchar(99)
,`dt_vehicle_reg` varchar(55)
);

-- --------------------------------------------------------

--
-- Stand-in structure for view `v_vehicle_selection`
--
CREATE TABLE `v_vehicle_selection` (
`vehicle_id` varchar(55)
,`plate_no` varchar(155)
,`model` varchar(95)
,`type` varchar(55)
,`max_weight_kg` double
,`vehicle_service_status` varchar(55)
,`vehicle_delivery_status` varchar(55)
,`route_code` varchar(55)
,`route_name` varchar(99)
);

-- --------------------------------------------------------

--
-- Structure for view `v_delivery_entries`
--
DROP TABLE IF EXISTS `v_delivery_entries`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `v_delivery_entries`  AS  select `tbl_delivery_entries`.`delivery_id` AS `delivery_id`,`tbl_delivery_entries`.`vehicle_id` AS `vehicle_id`,`tbl_delivery_entries`.`trans_no` AS `trans_no`,`tbl_saved_orders`.`sold_to` AS `sold_to`,`tbl_saved_orders`.`contact_no` AS `contact_no`,`tbl_saved_orders`.`del_destination` AS `del_destination`,`tbl_saved_orders`.`no_of_items` AS `no_of_items`,`tbl_saved_orders`.`total_qty` AS `total_qty`,`tbl_saved_orders`.`total_weight_kg` AS `total_weight_kg`,`tbl_saved_orders`.`total_amount` AS `total_amount`,`tbl_saved_orders`.`dt_ordered` AS `dt_ordered` from (`tbl_delivery_entries` join `tbl_saved_orders`) where (`tbl_delivery_entries`.`trans_no` = `tbl_saved_orders`.`trans_no`) ;

-- --------------------------------------------------------

--
-- Structure for view `v_delivery_trans_orders_full`
--
DROP TABLE IF EXISTS `v_delivery_trans_orders_full`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `v_delivery_trans_orders_full`  AS  select `tbl_saved_orders`.`trans_no` AS `trans_no`,`tbl_saved_orders`.`sold_to` AS `sold_to`,`tbl_saved_orders`.`contact_no` AS `contact_no`,`tbl_saved_orders`.`del_destination` AS `del_destination`,`tbl_saved_orders`.`expctd_dt_delivery` AS `expctd_dt_delivery`,`tbl_saved_orders`.`no_of_items` AS `no_of_items`,`tbl_saved_orders`.`total_qty` AS `total_qty`,`tbl_saved_orders`.`total_weight_kg` AS `total_weight_kg`,`tbl_saved_orders`.`total_amount` AS `total_amount`,`tbl_saved_orders`.`dt_ordered` AS `dt_ordered`,`tbl_saved_orders`.`trans_type` AS `trans_type`,`tbl_for_delivery_trans`.`dt_pending` AS `dt_pending`,`tbl_for_delivery_trans`.`dt_delivering` AS `dt_delivering`,`tbl_for_delivery_trans`.`dt_delivered` AS `dt_delivered`,`tbl_for_delivery_trans`.`delivery_id` AS `delivery_id` from (`tbl_for_delivery_trans` join `tbl_saved_orders`) where (`tbl_saved_orders`.`trans_no` = `tbl_for_delivery_trans`.`trans_no`) ;

-- --------------------------------------------------------

--
-- Structure for view `v_full_items_inv`
--
DROP TABLE IF EXISTS `v_full_items_inv`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `v_full_items_inv`  AS  select `tbl_items_inv`.`item_code` AS `item_code`,`tbl_items`.`item_name` AS `item_name`,`tbl_items`.`item_desc` AS `item_desc`,`tbl_items`.`item_weight_kg` AS `item_weight_kg`,`tbl_items_inv`.`no_of_stocks` AS `no_of_stocks`,`tbl_items`.`item_unit` AS `item_unit`,`tbl_items`.`item_price` AS `item_price` from (`tbl_items_inv` join `tbl_items`) where (`tbl_items_inv`.`item_code` = `tbl_items`.`item_code`) ;

-- --------------------------------------------------------

--
-- Structure for view `v_saved_for_delivery_orders`
--
DROP TABLE IF EXISTS `v_saved_for_delivery_orders`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `v_saved_for_delivery_orders`  AS  select `tbl_saved_orders`.`trans_no` AS `trans_no`,`tbl_saved_orders`.`sold_to` AS `sold_to`,`tbl_saved_orders`.`contact_no` AS `contact_no`,`tbl_saved_orders`.`del_destination` AS `del_destination`,`tbl_saved_orders`.`no_of_items` AS `no_of_items`,`tbl_saved_orders`.`total_qty` AS `total_qty`,`tbl_saved_orders`.`total_weight_kg` AS `total_weight_kg`,`tbl_saved_orders`.`total_amount` AS `total_amount`,`tbl_saved_orders`.`dt_ordered` AS `dt_ordered`,`tbl_saved_orders`.`trans_type` AS `trans_type`,`tbl_for_delivery_trans`.`delivery_status` AS `delivery_status` from (`tbl_saved_orders` join `tbl_for_delivery_trans`) where (`tbl_saved_orders`.`trans_no` = `tbl_for_delivery_trans`.`trans_no`) ;

-- --------------------------------------------------------

--
-- Structure for view `v_saved_orders_route`
--
DROP TABLE IF EXISTS `v_saved_orders_route`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `v_saved_orders_route`  AS  select `tbl_saved_orders_route`.`trans_no` AS `trans_no`,`tbl_saved_orders_route`.`route_code` AS `route_code`,`tbl_delivery_route`.`route_name` AS `route_name` from (`tbl_saved_orders_route` join `tbl_delivery_route`) where (`tbl_saved_orders_route`.`route_code` = `tbl_delivery_route`.`route_code`) ;

-- --------------------------------------------------------

--
-- Structure for view `v_stock_in`
--
DROP TABLE IF EXISTS `v_stock_in`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `v_stock_in`  AS  select `tbl_stock_in`.`stock_in_id` AS `stock_in_id`,`tbl_stock_in`.`supplier_id` AS `supplier_id`,`tbl_suppliers`.`supplier_name` AS `supplier_name`,`tbl_stock_in`.`dt_stock_in` AS `dt_stock_in` from (`tbl_stock_in` join `tbl_suppliers`) where (`tbl_stock_in`.`supplier_id` = `tbl_suppliers`.`supplier_id`) ;

-- --------------------------------------------------------

--
-- Structure for view `v_stock_logs`
--
DROP TABLE IF EXISTS `v_stock_logs`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `v_stock_logs`  AS  select `tbl_stock_logs`.`stock_in_id` AS `stock_in_id`,`tbl_stock_logs`.`item_code` AS `item_code`,`tbl_items`.`item_name` AS `item_name`,`tbl_stock_logs`.`stock_added` AS `stock_added`,`tbl_stock_logs`.`dt_stock_logs` AS `dt_stock_logs`,`tbl_stock_logs`.`tracecode` AS `tracecode` from (`tbl_stock_logs` join `tbl_items`) where (`tbl_stock_logs`.`item_code` = `tbl_items`.`item_code`) ;

-- --------------------------------------------------------

--
-- Structure for view `v_vehicle_info_del_route`
--
DROP TABLE IF EXISTS `v_vehicle_info_del_route`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `v_vehicle_info_del_route`  AS  select `tbl_vehicle_del_route`.`vehicle_id` AS `vehicle_id`,`tbl_vehicles_info`.`plate_no` AS `plate_no`,`tbl_vehicles_info`.`model` AS `model`,`tbl_vehicles_info`.`type` AS `type`,`tbl_vehicles_info`.`color` AS `color`,`tbl_vehicles_info`.`vehicle_desc` AS `vehicle_desc`,`tbl_vehicles_info`.`max_weight_kg` AS `max_weight_kg`,`tbl_vehicles_info`.`vehicle_weight_kg` AS `vehicle_weight_kg`,`tbl_vehicles_info`.`vehicle_service_status` AS `vehicle_service_status`,`tbl_vehicles_info`.`vehicle_delivery_status` AS `vehicle_delivery_status`,`tbl_delivery_route`.`route_name` AS `route_name`,`tbl_vehicles_info`.`dt_vehicle_reg` AS `dt_vehicle_reg` from ((`tbl_vehicles_info` join `tbl_vehicle_del_route`) join `tbl_delivery_route`) where ((`tbl_vehicle_del_route`.`vehicle_id` = `tbl_vehicles_info`.`vehicle_id`) and (`tbl_vehicle_del_route`.`route_code` = `tbl_delivery_route`.`route_code`)) ;

-- --------------------------------------------------------

--
-- Structure for view `v_vehicle_selection`
--
DROP TABLE IF EXISTS `v_vehicle_selection`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `v_vehicle_selection`  AS  select `tbl_vehicle_del_route`.`vehicle_id` AS `vehicle_id`,`tbl_vehicles_info`.`plate_no` AS `plate_no`,`tbl_vehicles_info`.`model` AS `model`,`tbl_vehicles_info`.`type` AS `type`,`tbl_vehicles_info`.`max_weight_kg` AS `max_weight_kg`,`tbl_vehicles_info`.`vehicle_service_status` AS `vehicle_service_status`,`tbl_vehicles_info`.`vehicle_delivery_status` AS `vehicle_delivery_status`,`tbl_vehicle_del_route`.`route_code` AS `route_code`,`tbl_delivery_route`.`route_name` AS `route_name` from ((`tbl_vehicle_del_route` join `tbl_vehicles_info`) join `tbl_delivery_route`) where ((`tbl_vehicle_del_route`.`vehicle_id` = `tbl_vehicles_info`.`vehicle_id`) and (`tbl_vehicle_del_route`.`route_code` = `tbl_delivery_route`.`route_code`)) ;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbl_acc`
--
ALTER TABLE `tbl_acc`
  ADD PRIMARY KEY (`user`);

--
-- Indexes for table `tbl_delivery_route`
--
ALTER TABLE `tbl_delivery_route`
  ADD PRIMARY KEY (`route_code`);

--
-- Indexes for table `tbl_employees`
--
ALTER TABLE `tbl_employees`
  ADD PRIMARY KEY (`emp_id`);

--
-- Indexes for table `tbl_for_delivery_trans`
--
ALTER TABLE `tbl_for_delivery_trans`
  ADD PRIMARY KEY (`trans_no`);

--
-- Indexes for table `tbl_items`
--
ALTER TABLE `tbl_items`
  ADD PRIMARY KEY (`item_code`);

--
-- Indexes for table `tbl_items_inv`
--
ALTER TABLE `tbl_items_inv`
  ADD PRIMARY KEY (`item_code`);

--
-- Indexes for table `tbl_ordered_items`
--
ALTER TABLE `tbl_ordered_items`
  ADD PRIMARY KEY (`ord_tracecode`);

--
-- Indexes for table `tbl_saved_orders`
--
ALTER TABLE `tbl_saved_orders`
  ADD PRIMARY KEY (`trans_no`);

--
-- Indexes for table `tbl_saved_orders_route`
--
ALTER TABLE `tbl_saved_orders_route`
  ADD PRIMARY KEY (`trans_no`);

--
-- Indexes for table `tbl_stock_in`
--
ALTER TABLE `tbl_stock_in`
  ADD PRIMARY KEY (`stock_in_id`);

--
-- Indexes for table `tbl_stock_logs`
--
ALTER TABLE `tbl_stock_logs`
  ADD PRIMARY KEY (`tracecode`);

--
-- Indexes for table `tbl_suppliers`
--
ALTER TABLE `tbl_suppliers`
  ADD PRIMARY KEY (`supplier_id`);

--
-- Indexes for table `tbl_vehicles_info`
--
ALTER TABLE `tbl_vehicles_info`
  ADD PRIMARY KEY (`vehicle_id`);

--
-- Indexes for table `tbl_vehicle_del_route`
--
ALTER TABLE `tbl_vehicle_del_route`
  ADD PRIMARY KEY (`vehicle_id`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
