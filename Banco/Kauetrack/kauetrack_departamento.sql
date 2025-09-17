-- MySQL dump 10.13  Distrib 8.0.33, for Win64 (x86_64)
--
-- Host: localhost    Database: kauetrack3
-- ------------------------------------------------------
-- Server version	8.0.23

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `departamento`
--

DROP TABLE IF EXISTS `departamento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `departamento` (
  `id` int NOT NULL AUTO_INCREMENT,
  `nome` varchar(90) NOT NULL,
  `sigla` varchar(5) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=201 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `departamento`
--

LOCK TABLES `departamento` WRITE;
/*!40000 ALTER TABLE `departamento` DISABLE KEYS */;
INSERT INTO `departamento` VALUES (1,'Departamento 1','D001'),(2,'Departamento 2','D002'),(3,'Departamento 3','D003'),(4,'Departamento 4','D004'),(5,'Departamento 5','D005'),(6,'Departamento 6','D006'),(7,'Departamento 7','D007'),(8,'Departamento 8','D008'),(9,'Departamento 9','D009'),(10,'Departamento 10','D010'),(11,'Departamento 11','D011'),(12,'Departamento 12','D012'),(13,'Departamento 13','D013'),(14,'Departamento 14','D014'),(15,'Departamento 15','D015'),(16,'Departamento 16','D016'),(17,'Departamento 17','D017'),(18,'Departamento 18','D018'),(19,'Departamento 19','D019'),(20,'Departamento 20','D020'),(21,'Departamento 21','D021'),(22,'Departamento 22','D022'),(23,'Departamento 23','D023'),(24,'Departamento 24','D024'),(25,'Departamento 25','D025'),(26,'Departamento 26','D026'),(27,'Departamento 27','D027'),(28,'Departamento 28','D028'),(29,'Departamento 29','D029'),(30,'Departamento 30','D030'),(31,'Departamento 31','D031'),(32,'Departamento 32','D032'),(33,'Departamento 33','D033'),(34,'Departamento 34','D034'),(35,'Departamento 35','D035'),(36,'Departamento 36','D036'),(37,'Departamento 37','D037'),(38,'Departamento 38','D038'),(39,'Departamento 39','D039'),(40,'Departamento 40','D040'),(41,'Departamento 41','D041'),(42,'Departamento 42','D042'),(43,'Departamento 43','D043'),(44,'Departamento 44','D044'),(45,'Departamento 45','D045'),(46,'Departamento 46','D046'),(47,'Departamento 47','D047'),(48,'Departamento 48','D048'),(49,'Departamento 49','D049'),(50,'Departamento 50','D050'),(51,'Departamento 51','D051'),(52,'Departamento 52','D052'),(53,'Departamento 53','D053'),(54,'Departamento 54','D054'),(55,'Departamento 55','D055'),(56,'Departamento 56','D056'),(57,'Departamento 57','D057'),(58,'Departamento 58','D058'),(59,'Departamento 59','D059'),(60,'Departamento 60','D060'),(61,'Departamento 61','D061'),(62,'Departamento 62','D062'),(63,'Departamento 63','D063'),(64,'Departamento 64','D064'),(65,'Departamento 65','D065'),(66,'Departamento 66','D066'),(67,'Departamento 67','D067'),(68,'Departamento 68','D068'),(69,'Departamento 69','D069'),(70,'Departamento 70','D070'),(71,'Departamento 71','D071'),(72,'Departamento 72','D072'),(73,'Departamento 73','D073'),(74,'Departamento 74','D074'),(75,'Departamento 75','D075'),(76,'Departamento 76','D076'),(77,'Departamento 77','D077'),(78,'Departamento 78','D078'),(79,'Departamento 79','D079'),(80,'Departamento 80','D080'),(81,'Departamento 81','D081'),(82,'Departamento 82','D082'),(83,'Departamento 83','D083'),(84,'Departamento 84','D084'),(85,'Departamento 85','D085'),(86,'Departamento 86','D086'),(87,'Departamento 87','D087'),(88,'Departamento 88','D088'),(89,'Departamento 89','D089'),(90,'Departamento 90','D090'),(91,'Departamento 91','D091'),(92,'Departamento 92','D092'),(93,'Departamento 93','D093'),(94,'Departamento 94','D094'),(95,'Departamento 95','D095'),(96,'Departamento 96','D096'),(97,'Departamento 97','D097'),(98,'Departamento 98','D098'),(99,'Departamento 99','D099'),(100,'Departamento 100','D100'),(101,'Financeiro 1','FIN'),(102,'Tecnologia da Informação 2','TI'),(103,'Marketing 3','MKT'),(104,'Vendas 4','VEN'),(105,'Jurídico 5','JUR'),(106,'Logística 6','LOG'),(107,'Compras 7','COM'),(108,'Produção 8','PRD'),(109,'Pesquisa e Desenvolvimento 9','P&D'),(110,'Recursos Humanos 10','RH'),(111,'Financeiro 11','FIN'),(112,'Tecnologia da Informação 12','TI'),(113,'Marketing 13','MKT'),(114,'Vendas 14','VEN'),(115,'Jurídico 15','JUR'),(116,'Logística 16','LOG'),(117,'Compras 17','COM'),(118,'Produção 18','PRD'),(119,'Pesquisa e Desenvolvimento 19','P&D'),(120,'Recursos Humanos 20','RH'),(121,'Financeiro 21','FIN'),(122,'Tecnologia da Informação 22','TI'),(123,'Marketing 23','MKT'),(124,'Vendas 24','VEN'),(125,'Jurídico 25','JUR'),(126,'Logística 26','LOG'),(127,'Compras 27','COM'),(128,'Produção 28','PRD'),(129,'Pesquisa e Desenvolvimento 29','P&D'),(130,'Recursos Humanos 30','RH'),(131,'Financeiro 31','FIN'),(132,'Tecnologia da Informação 32','TI'),(133,'Marketing 33','MKT'),(134,'Vendas 34','VEN'),(135,'Jurídico 35','JUR'),(136,'Logística 36','LOG'),(137,'Compras 37','COM'),(138,'Produção 38','PRD'),(139,'Pesquisa e Desenvolvimento 39','P&D'),(140,'Recursos Humanos 40','RH'),(141,'Financeiro 41','FIN'),(142,'Tecnologia da Informação 42','TI'),(143,'Marketing 43','MKT'),(144,'Vendas 44','VEN'),(145,'Jurídico 45','JUR'),(146,'Logística 46','LOG'),(147,'Compras 47','COM'),(148,'Produção 48','PRD'),(149,'Pesquisa e Desenvolvimento 49','P&D'),(150,'Recursos Humanos 50','RH'),(151,'Financeiro 51','FIN'),(152,'Tecnologia da Informação 52','TI'),(153,'Marketing 53','MKT'),(154,'Vendas 54','VEN'),(155,'Jurídico 55','JUR'),(156,'Logística 56','LOG'),(157,'Compras 57','COM'),(158,'Produção 58','PRD'),(159,'Pesquisa e Desenvolvimento 59','P&D'),(160,'Recursos Humanos 60','RH'),(161,'Financeiro 61','FIN'),(162,'Tecnologia da Informação 62','TI'),(163,'Marketing 63','MKT'),(164,'Vendas 64','VEN'),(165,'Jurídico 65','JUR'),(166,'Logística 66','LOG'),(167,'Compras 67','COM'),(168,'Produção 68','PRD'),(169,'Pesquisa e Desenvolvimento 69','P&D'),(170,'Recursos Humanos 70','RH'),(171,'Financeiro 71','FIN'),(172,'Tecnologia da Informação 72','TI'),(173,'Marketing 73','MKT'),(174,'Vendas 74','VEN'),(175,'Jurídico 75','JUR'),(176,'Logística 76','LOG'),(177,'Compras 77','COM'),(178,'Produção 78','PRD'),(179,'Pesquisa e Desenvolvimento 79','P&D'),(180,'Recursos Humanos 80','RH'),(181,'Financeiro 81','FIN'),(182,'Tecnologia da Informação 82','TI'),(183,'Marketing 83','MKT'),(184,'Vendas 84','VEN'),(185,'Jurídico 85','JUR'),(186,'Logística 86','LOG'),(187,'Compras 87','COM'),(188,'Produção 88','PRD'),(189,'Pesquisa e Desenvolvimento 89','P&D'),(190,'Recursos Humanos 90','RH'),(191,'Financeiro 91','FIN'),(192,'Tecnologia da Informação 92','TI'),(193,'Marketing 93','MKT'),(194,'Vendas 94','VEN'),(195,'Jurídico 95','JUR'),(196,'Logística 96','LOG'),(197,'Compras 97','COM'),(198,'Produção 98','PRD'),(199,'Pesquisa e Desenvolvimento 99','P&D'),(200,'Recursos Humanos 100','RH');
/*!40000 ALTER TABLE `departamento` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-09-16 19:06:09
