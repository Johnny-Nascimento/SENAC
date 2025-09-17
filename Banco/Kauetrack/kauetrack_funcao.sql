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
-- Table structure for table `funcao`
--

DROP TABLE IF EXISTS `funcao`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `funcao` (
  `id` int NOT NULL AUTO_INCREMENT,
  `nome_funcao` varchar(40) NOT NULL,
  `nivel` enum('MARCOS','PLENO','THIAGO') DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=201 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `funcao`
--

LOCK TABLES `funcao` WRITE;
/*!40000 ALTER TABLE `funcao` DISABLE KEYS */;
INSERT INTO `funcao` VALUES (1,'Analista 1','PLENO'),(2,'Analista 2','THIAGO'),(3,'Analista 3','MARCOS'),(4,'Analista 4','PLENO'),(5,'Analista 5','THIAGO'),(6,'Analista 6','MARCOS'),(7,'Analista 7','PLENO'),(8,'Analista 8','THIAGO'),(9,'Analista 9','MARCOS'),(10,'Analista 10','PLENO'),(11,'Analista 11','THIAGO'),(12,'Analista 12','MARCOS'),(13,'Analista 13','PLENO'),(14,'Analista 14','THIAGO'),(15,'Analista 15','MARCOS'),(16,'Analista 16','PLENO'),(17,'Analista 17','THIAGO'),(18,'Analista 18','MARCOS'),(19,'Analista 19','PLENO'),(20,'Analista 20','THIAGO'),(21,'Analista 21','MARCOS'),(22,'Analista 22','PLENO'),(23,'Analista 23','THIAGO'),(24,'Analista 24','MARCOS'),(25,'Analista 25','PLENO'),(26,'Analista 26','THIAGO'),(27,'Analista 27','MARCOS'),(28,'Analista 28','PLENO'),(29,'Analista 29','THIAGO'),(30,'Analista 30','MARCOS'),(31,'Analista 31','PLENO'),(32,'Analista 32','THIAGO'),(33,'Analista 33','MARCOS'),(34,'Analista 34','PLENO'),(35,'Analista 35','THIAGO'),(36,'Analista 36','MARCOS'),(37,'Analista 37','PLENO'),(38,'Analista 38','THIAGO'),(39,'Analista 39','MARCOS'),(40,'Analista 40','PLENO'),(41,'Analista 41','THIAGO'),(42,'Analista 42','MARCOS'),(43,'Analista 43','PLENO'),(44,'Analista 44','THIAGO'),(45,'Analista 45','MARCOS'),(46,'Analista 46','PLENO'),(47,'Analista 47','THIAGO'),(48,'Analista 48','MARCOS'),(49,'Analista 49','PLENO'),(50,'Analista 50','THIAGO'),(51,'Analista 51','MARCOS'),(52,'Analista 52','PLENO'),(53,'Analista 53','THIAGO'),(54,'Analista 54','MARCOS'),(55,'Analista 55','PLENO'),(56,'Analista 56','THIAGO'),(57,'Analista 57','MARCOS'),(58,'Analista 58','PLENO'),(59,'Analista 59','THIAGO'),(60,'Analista 60','MARCOS'),(61,'Analista 61','PLENO'),(62,'Analista 62','THIAGO'),(63,'Analista 63','MARCOS'),(64,'Analista 64','PLENO'),(65,'Analista 65','THIAGO'),(66,'Analista 66','MARCOS'),(67,'Analista 67','PLENO'),(68,'Analista 68','THIAGO'),(69,'Analista 69','MARCOS'),(70,'Analista 70','PLENO'),(71,'Analista 71','THIAGO'),(72,'Analista 72','MARCOS'),(73,'Analista 73','PLENO'),(74,'Analista 74','THIAGO'),(75,'Analista 75','MARCOS'),(76,'Analista 76','PLENO'),(77,'Analista 77','THIAGO'),(78,'Analista 78','MARCOS'),(79,'Analista 79','PLENO'),(80,'Analista 80','THIAGO'),(81,'Analista 81','MARCOS'),(82,'Analista 82','PLENO'),(83,'Analista 83','THIAGO'),(84,'Analista 84','MARCOS'),(85,'Analista 85','PLENO'),(86,'Analista 86','THIAGO'),(87,'Analista 87','MARCOS'),(88,'Analista 88','PLENO'),(89,'Analista 89','THIAGO'),(90,'Analista 90','MARCOS'),(91,'Analista 91','PLENO'),(92,'Analista 92','THIAGO'),(93,'Analista 93','MARCOS'),(94,'Analista 94','PLENO'),(95,'Analista 95','THIAGO'),(96,'Analista 96','MARCOS'),(97,'Analista 97','PLENO'),(98,'Analista 98','THIAGO'),(99,'Analista 99','MARCOS'),(100,'Analista 100','PLENO'),(101,'Analista 1','MARCOS'),(102,'Coordenador 2','PLENO'),(103,'Gerente 3','THIAGO'),(104,'Assistente 4','MARCOS'),(105,'Supervisor 5','PLENO'),(106,'Diretor 6','THIAGO'),(107,'Analista 7','MARCOS'),(108,'Coordenador 8','PLENO'),(109,'Gerente 9','THIAGO'),(110,'Assistente 10','MARCOS'),(111,'Supervisor 11','PLENO'),(112,'Diretor 12','THIAGO'),(113,'Analista 13','MARCOS'),(114,'Coordenador 14','PLENO'),(115,'Gerente 15','THIAGO'),(116,'Assistente 16','MARCOS'),(117,'Supervisor 17','PLENO'),(118,'Diretor 18','THIAGO'),(119,'Analista 19','MARCOS'),(120,'Coordenador 20','PLENO'),(121,'Gerente 21','THIAGO'),(122,'Assistente 22','MARCOS'),(123,'Supervisor 23','PLENO'),(124,'Diretor 24','THIAGO'),(125,'Analista 25','MARCOS'),(126,'Coordenador 26','PLENO'),(127,'Gerente 27','THIAGO'),(128,'Assistente 28','MARCOS'),(129,'Supervisor 29','PLENO'),(130,'Diretor 30','THIAGO'),(131,'Analista 31','MARCOS'),(132,'Coordenador 32','PLENO'),(133,'Gerente 33','THIAGO'),(134,'Assistente 34','MARCOS'),(135,'Supervisor 35','PLENO'),(136,'Diretor 36','THIAGO'),(137,'Analista 37','MARCOS'),(138,'Coordenador 38','PLENO'),(139,'Gerente 39','THIAGO'),(140,'Assistente 40','MARCOS'),(141,'Supervisor 41','PLENO'),(142,'Diretor 42','THIAGO'),(143,'Analista 43','MARCOS'),(144,'Coordenador 44','PLENO'),(145,'Gerente 45','THIAGO'),(146,'Assistente 46','MARCOS'),(147,'Supervisor 47','PLENO'),(148,'Diretor 48','THIAGO'),(149,'Analista 49','MARCOS'),(150,'Coordenador 50','PLENO'),(151,'Gerente 51','THIAGO'),(152,'Assistente 52','MARCOS'),(153,'Supervisor 53','PLENO'),(154,'Diretor 54','THIAGO'),(155,'Analista 55','MARCOS'),(156,'Coordenador 56','PLENO'),(157,'Gerente 57','THIAGO'),(158,'Assistente 58','MARCOS'),(159,'Supervisor 59','PLENO'),(160,'Diretor 60','THIAGO'),(161,'Analista 61','MARCOS'),(162,'Coordenador 62','PLENO'),(163,'Gerente 63','THIAGO'),(164,'Assistente 64','MARCOS'),(165,'Supervisor 65','PLENO'),(166,'Diretor 66','THIAGO'),(167,'Analista 67','MARCOS'),(168,'Coordenador 68','PLENO'),(169,'Gerente 69','THIAGO'),(170,'Assistente 70','MARCOS'),(171,'Supervisor 71','PLENO'),(172,'Diretor 72','THIAGO'),(173,'Analista 73','MARCOS'),(174,'Coordenador 74','PLENO'),(175,'Gerente 75','THIAGO'),(176,'Assistente 76','MARCOS'),(177,'Supervisor 77','PLENO'),(178,'Diretor 78','THIAGO'),(179,'Analista 79','MARCOS'),(180,'Coordenador 80','PLENO'),(181,'Gerente 81','THIAGO'),(182,'Assistente 82','MARCOS'),(183,'Supervisor 83','PLENO'),(184,'Diretor 84','THIAGO'),(185,'Analista 85','MARCOS'),(186,'Coordenador 86','PLENO'),(187,'Gerente 87','THIAGO'),(188,'Assistente 88','MARCOS'),(189,'Supervisor 89','PLENO'),(190,'Diretor 90','THIAGO'),(191,'Analista 91','MARCOS'),(192,'Coordenador 92','PLENO'),(193,'Gerente 93','THIAGO'),(194,'Assistente 94','MARCOS'),(195,'Supervisor 95','PLENO'),(196,'Diretor 96','THIAGO'),(197,'Analista 97','MARCOS'),(198,'Coordenador 98','PLENO'),(199,'Gerente 99','THIAGO'),(200,'Assistente 100','MARCOS');
/*!40000 ALTER TABLE `funcao` ENABLE KEYS */;
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
