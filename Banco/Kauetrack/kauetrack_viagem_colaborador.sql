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
-- Table structure for table `viagem_colaborador`
--

DROP TABLE IF EXISTS `viagem_colaborador`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `viagem_colaborador` (
  `viagem_id` int NOT NULL,
  `colaborador_id` int NOT NULL,
  PRIMARY KEY (`viagem_id`,`colaborador_id`),
  KEY `FK_viagem_colaborador_colaborador` (`colaborador_id`),
  CONSTRAINT `FK_viagem_colaborador_colaborador` FOREIGN KEY (`colaborador_id`) REFERENCES `colaborador` (`id`),
  CONSTRAINT `FK_viagem_colaborador_viagem` FOREIGN KEY (`viagem_id`) REFERENCES `viagem` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `viagem_colaborador`
--

LOCK TABLES `viagem_colaborador` WRITE;
/*!40000 ALTER TABLE `viagem_colaborador` DISABLE KEYS */;
INSERT INTO `viagem_colaborador` VALUES (1,1),(2,2),(3,3),(4,4),(55,4),(5,5),(50,5),(6,6),(7,7),(8,8),(81,8),(9,9),(32,9),(84,9),(10,10),(11,11),(99,11),(12,12),(76,12),(13,13),(14,14),(28,14),(59,14),(62,14),(15,15),(34,15),(85,15),(87,15),(12,16),(16,16),(61,16),(6,17),(9,17),(17,17),(16,18),(18,18),(29,18),(36,18),(91,18),(19,19),(20,20),(49,20),(97,20),(21,21),(22,22),(23,23),(23,24),(24,24),(14,25),(25,25),(75,25),(86,25),(92,25),(24,26),(26,26),(27,27),(28,28),(93,28),(29,29),(30,30),(82,30),(27,31),(31,31),(69,31),(32,32),(94,32),(7,33),(33,33),(54,33),(34,34),(35,35),(36,36),(11,37),(37,37),(5,38),(38,38),(39,39),(3,40),(40,40),(52,40),(65,40),(41,41),(53,41),(63,41),(13,42),(25,42),(42,42),(43,43),(77,43),(44,44),(45,45),(46,46),(20,47),(47,47),(37,48),(44,48),(48,48),(18,49),(35,49),(49,49),(22,50),(50,50),(2,51),(10,51),(43,51),(51,51),(40,52),(52,52),(1,53),(53,53),(90,53),(47,54),(54,54),(56,54),(58,54),(71,54),(80,54),(55,55),(83,55),(51,56),(56,56),(21,57),(57,57),(68,57),(58,58),(72,58),(59,59),(60,60),(61,61),(62,62),(70,62),(63,63),(64,64),(88,64),(65,65),(78,65),(66,66),(38,67),(67,67),(68,68),(69,69),(17,70),(70,70),(15,71),(71,71),(46,72),(72,72),(45,73),(73,73),(74,74),(39,75),(75,75),(76,76),(89,76),(57,77),(77,77),(78,78),(33,79),(79,79),(80,80),(31,81),(81,81),(82,82),(83,83),(84,84),(4,85),(85,85),(95,85),(86,86),(87,87),(88,88),(100,88),(41,89),(64,89),(73,89),(89,89),(66,90),(90,90),(91,91),(79,92),(92,92),(42,93),(93,93),(48,94),(60,94),(94,94),(30,95),(95,95),(74,96),(96,96),(19,97),(26,97),(97,97),(98,97),(8,98),(67,98),(98,98),(99,99),(96,100),(100,100);
/*!40000 ALTER TABLE `viagem_colaborador` ENABLE KEYS */;
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
