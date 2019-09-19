-- MySQL dump 10.13  Distrib 5.7.12, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: proyek_1
-- ------------------------------------------------------
-- Server version	5.1.41

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `barang_keluar`
--

DROP TABLE IF EXISTS `barang_keluar`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `barang_keluar` (
  `KODE_BARANG` varchar(20) NOT NULL,
  `NAMA_BARANG` varchar(45) NOT NULL,
  `TANGGAL_BARANG_KELUAR` varchar(45) NOT NULL,
  `JUMLAH_BARANG` int(11) NOT NULL,
  `HARGA_BARANG` int(11) NOT NULL,
  `TIPE_KELUAR_BARANG` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`KODE_BARANG`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `barang_keluar`
--

LOCK TABLES `barang_keluar` WRITE;
/*!40000 ALTER TABLE `barang_keluar` DISABLE KEYS */;
INSERT INTO `barang_keluar` VALUES ('B002','BAN','1/13/2017 9:48:20 PM',100,100000,'Umum'),('B001','AKI','1/2/2017 3:22:54 PM',100,1000,'Umum'),('B003','MESIN','1/11/2017 9:48:20 PM',200,100000,'Service');
/*!40000 ALTER TABLE `barang_keluar` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `barang_masuk`
--

DROP TABLE IF EXISTS `barang_masuk`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `barang_masuk` (
  `KODE_BARANG` varchar(20) NOT NULL,
  `NAMA_BARANG` varchar(45) NOT NULL,
  `NAMA_SUPLIER` varchar(45) NOT NULL,
  `TANGGAL_BARANG_MASUK` varchar(45) NOT NULL,
  `JUMLAH_BARANG` int(11) NOT NULL,
  `HARGA_BARANG` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `barang_masuk`
--

LOCK TABLES `barang_masuk` WRITE;
/*!40000 ALTER TABLE `barang_masuk` DISABLE KEYS */;
/*!40000 ALTER TABLE `barang_masuk` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `data_pelanggan`
--

DROP TABLE IF EXISTS `data_pelanggan`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `data_pelanggan` (
  `KODE_PELANGGAN` varchar(25) NOT NULL,
  `NAMA_PELANGGAN` varchar(45) NOT NULL,
  `ALAMAT` varchar(45) NOT NULL,
  `NO_HP` varchar(45) NOT NULL,
  `TIPE_PELANGGAN` varchar(45) NOT NULL,
  `TANGGAL_MASUK_PELANGGAN` varchar(45) NOT NULL,
  PRIMARY KEY (`KODE_PELANGGAN`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `data_pelanggan`
--

LOCK TABLES `data_pelanggan` WRITE;
/*!40000 ALTER TABLE `data_pelanggan` DISABLE KEYS */;
INSERT INTO `data_pelanggan` VALUES ('P00001','PADANG','JAKARTA','07765656','Umum','1/6/2017 10:02:26 PM');
/*!40000 ALTER TABLE `data_pelanggan` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `data_suplier`
--

DROP TABLE IF EXISTS `data_suplier`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `data_suplier` (
  `KODE_SUPLIER` varchar(25) NOT NULL,
  `NAMA_SUPLIER` varchar(45) NOT NULL,
  `ALAMAT` varchar(45) NOT NULL,
  `TELEPON` varchar(16) NOT NULL,
  `EMAIL` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`KODE_SUPLIER`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `data_suplier`
--

LOCK TABLES `data_suplier` WRITE;
/*!40000 ALTER TABLE `data_suplier` DISABLE KEYS */;
INSERT INTO `data_suplier` VALUES ('S001','Cahya','PADANG','0822878788787','cahya@gmail.com');
/*!40000 ALTER TABLE `data_suplier` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `login`
--

DROP TABLE IF EXISTS `login`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `login` (
  `User_name` varchar(45) NOT NULL DEFAULT '',
  `Password` int(11) DEFAULT NULL,
  PRIMARY KEY (`User_name`),
  UNIQUE KEY `User_name_UNIQUE` (`User_name`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `login`
--

LOCK TABLES `login` WRITE;
/*!40000 ALTER TABLE `login` DISABLE KEYS */;
INSERT INTO `login` VALUES ('Bendra',12345),('Cahya',12345);
/*!40000 ALTER TABLE `login` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2017-01-07 16:01:20
