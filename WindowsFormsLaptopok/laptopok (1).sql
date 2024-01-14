-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2024. Jan 14. 08:06
-- Kiszolgáló verziója: 10.4.28-MariaDB
-- PHP verzió: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `laptopok`
--
CREATE DATABASE IF NOT EXISTS `laptopok` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE `laptopok`;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `laptop`
--

CREATE TABLE `laptop` (
  `laptopId` bigint(20) NOT NULL,
  `marka` varchar(50) NOT NULL,
  `model` varchar(40) NOT NULL,
  `szin` varchar(40) NOT NULL,
  `processzor` varchar(40) NOT NULL,
  `memoria` int(11) NOT NULL COMMENT 'GB-ban megadva',
  `kepernyomeret` int(11) NOT NULL COMMENT 'coll-ban megadva',
  `felbontas` varchar(40) DEFAULT NULL,
  `merevlemezkapacitas` int(11) NOT NULL COMMENT 'GB-ban megadva',
  `ar` int(11) NOT NULL COMMENT 'EUR-ban megadva'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- A tábla adatainak kiíratása `laptop`
--

INSERT INTO `laptop` (`laptopId`, `marka`, `model`, `szin`, `processzor`, `memoria`, `kepernyomeret`, `felbontas`, `merevlemezkapacitas`, `ar`) VALUES
(1, 'HP', 'Pavilion', 'Fekete', 'Intel Core i5', 8, 15, '1920x1080', 512, 800),
(2, 'Dell', 'Inspiron', 'Ezüst', 'AMD Ryzen 7', 16, 17, '2560x1440', 1000, 1200),
(3, 'Lenovo', 'IdeaPad', 'Kék', 'Intel Core i7', 12, 14, '1920x1080', 256, 900),
(4, 'Asus', 'ROG', 'Fekete-piros', 'Intel Core i9', 32, 15, '3840x2160', 1000, 2000),
(5, 'Acer', 'Swift', 'Arany', 'AMD Ryzen 5', 8, 13, '2560x1600', 512, 1100),
(6, 'Apple', 'MacBook Air', 'Ezüst', 'Apple M1', 16, 13, '2560x1600', 256, 1300),
(7, 'Microsoft', 'Surface Laptop', 'Platina', 'Intel Core i5', 16, 15, '2256x1504', 512, 1500),
(8, 'HP', 'Elite Dragonfly', 'Zöld', 'Intel Core i5', 16, 13, '1920x1080', 512, 1800),
(9, 'Dell', 'XPS', 'Fehér', 'Intel Core i7', 32, 15, '3840x2400', 1000, 2200),
(10, 'Lenovo', 'ThinkPad', 'Fekete', 'Intel Core i7', 16, 14, '2560x1440', 512, 1200),
(11, 'Asus', 'ZenBook', 'Ezüst', 'AMD Ryzen 9', 32, 14, '3840x2160', 1000, 2000),
(12, 'Acer', 'Predator', 'Fekete-kék', 'Intel Core i9', 64, 17, '3840x2160', 2000, 2500),
(13, 'Apple', 'MacBook Pro', 'Szürke', 'Intel Core i9', 64, 16, '3072x1920', 1000, 2500),
(14, 'Microsoft', 'Surface Book', 'Barna', 'Intel Core i7', 32, 15, '3000x2000', 512, 2000),
(15, 'HP', 'Spectre', 'Rózsaszín', 'Intel Core i7', 16, 13, '1920x1080', 512, 1600),
(16, 'Dell', 'Latitude', 'Fekete', 'Intel Core i5', 8, 14, '1920x1080', 256, 900),
(17, 'Lenovo', 'Yoga', 'Arany-rózsaszín', 'AMD Ryzen 7', 16, 15, '2560x1440', 512, 1200),
(18, 'Asus', 'VivoBook', 'Ezüst', 'Intel Core i5', 8, 15, '1920x1080', 256, 800),
(19, 'Acer', 'Aspire', 'Kék', 'AMD Ryzen 5', 12, 17, '2560x1600', 512, 1000),
(20, 'Apple', 'MacBook', 'Ezüst', 'Apple M1', 8, 13, '2560x1600', 256, 1300),
(21, 'Microsoft', 'Surface Pro', 'Fekete', 'Intel Core i5', 16, 12, '2736x1824', 512, 1200),
(22, 'HP', 'Envy', 'Arany', 'Intel Core i7', 16, 15, '3840x2160', 512, 1700),
(23, 'Dell', 'Precision', 'Fekete', 'Intel Xeon', 64, 17, '3840x2400', 1000, 2500),
(24, 'Lenovo', 'Legion', 'Piros-fekete', 'AMD Ryzen 9', 32, 15, '3840x2160', 1000, 2000),
(25, 'Asus', 'TUF', 'Fekete', 'AMD Ryzen 7', 16, 17, '2560x1440', 512, 1200),
(26, 'Acer', 'Chromebook', 'Fehér', 'Intel Celeron', 4, 14, '1920x1080', 64, 300),
(27, 'Apple', 'MacBook Air M2', 'Ezüst', 'Apple M2', 16, 13, '2560x1600', 512, 1500),
(28, 'Microsoft', 'Surface Laptop Go', 'Kék', 'Intel Core i5', 8, 12, '1536x1024', 256, 600),
(29, 'HP', 'Pavilion x360', 'Arany-rózsaszín', 'AMD Ryzen 5', 8, 14, '1920x1080', 256, 800),
(30, 'Dell', 'Inspiron 2-in-1', 'Fehér', 'Intel Core i7', 16, 15, '1920x1080', 512, 1100),
(31, 'Lenovo', 'IdeaPad Flex', 'Ezüst', 'Intel Core i5', 12, 14, '1920x1080', 256, 900),
(32, 'Asus', 'ROG Zephyrus', 'Fekete', 'AMD Ryzen 9', 32, 15, '3840x2160', 1000, 2000),
(33, 'Acer', 'Swift 3', 'Arany', 'AMD Ryzen 7', 16, 13, '2560x1600', 512, 1100),
(34, 'Apple', 'MacBook Pro M2', 'Szürke', 'Apple M2', 64, 16, '3072x1920', 1000, 2500),
(35, 'Microsoft', 'Surface Go', 'Barna', 'Intel Pentium', 8, 10, '1800x1200', 128, 400),
(36, 'HP', 'Elite Dragonfly G2', 'Zöld', 'Intel Core i7', 16, 13, '1920x1080', 512, 2000),
(37, 'Dell', 'XPS 13', 'Fehér', 'Intel Core i7', 32, 13, '3840x2400', 1000, 2200),
(38, 'Lenovo', 'ThinkPad X1 Carbon', 'Fekete', 'Intel Core i7', 16, 14, '2560x1440', 512, 1200),
(39, 'Asus', 'ZenBook Pro', 'Ezüst', 'Intel Core i9', 32, 15, '3840x2160', 1000, 2000),
(40, 'Acer', 'Predator Helios', 'Fekete-kék', 'Intel Core i9', 64, 17, '3840x2160', 2000, 2500),
(41, 'Apple', 'MacBook Air M3', 'Ezüst', 'Apple M3', 16, 13, '2560x1600', 512, 1500),
(42, 'Microsoft', 'Surface Book 3', 'Barna', 'Intel Core i7', 32, 15, '3000x2000', 512, 2000),
(43, 'HP', 'Spectre x360', 'Rózsaszín', 'Intel Core i7', 16, 13, '1920x1080', 512, 1600),
(44, 'Dell', 'Latitude 2-in-1', 'Fekete', 'Intel Core i5', 8, 14, '1920x1080', 256, 900),
(45, 'Lenovo', 'Yoga C940', 'Arany-rózsaszín', 'Intel Core i7', 16, 15, '2560x1440', 512, 1200),
(46, 'Asus', 'VivoBook S', 'Ezüst', 'Intel Core i5', 8, 15, '1920x1080', 256, 800),
(47, 'Acer', 'Aspire 5', 'Kék', 'AMD Ryzen 5', 12, 17, '2560x1600', 512, 1000),
(48, 'Apple', 'MacBook Pro M3', 'Ezüst', 'Apple M3', 64, 16, '3072x1920', 1000, 2500),
(49, 'Microsoft', 'Surface Laptop 4', 'Fekete', 'Intel Core i5', 16, 15, '2256x1504', 512, 1500),
(50, 'HP', 'Envy x360', 'Arany', 'Intel Core i7', 16, 15, '3840x2160', 512, 1700);

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `laptop`
--
ALTER TABLE `laptop`
  ADD PRIMARY KEY (`laptopId`);

--
-- A kiírt táblák AUTO_INCREMENT értéke
--

--
-- AUTO_INCREMENT a táblához `laptop`
--
ALTER TABLE `laptop`
  MODIFY `laptopId` bigint(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=51;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
