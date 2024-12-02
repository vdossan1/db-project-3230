-- MySQL dump 10.13  Distrib 8.0.38, for Win64 (x86_64)
--
-- Host: cs-dblab01.uwg.westga.edu    Database: cs3230f24f
-- ------------------------------------------------------
-- Server version	8.4.2

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
-- Table structure for table `administrator`
--

DROP TABLE IF EXISTS `administrator`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `administrator` (
  `administrator_id` int NOT NULL AUTO_INCREMENT,
  `first_name` varchar(60) DEFAULT NULL,
  `last_name` varchar(60) DEFAULT NULL,
  `date_of_birth` date DEFAULT NULL,
  `sex` char(1) DEFAULT NULL,
  `address_line1` varchar(100) DEFAULT NULL,
  `address_line2` varchar(100) DEFAULT NULL,
  `city` varchar(50) DEFAULT NULL,
  `state` char(2) DEFAULT NULL,
  `zip_code` varchar(5) DEFAULT NULL,
  `phone_number` varchar(10) DEFAULT NULL,
  `ssn` char(9) DEFAULT NULL,
  `username` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`administrator_id`),
  UNIQUE KEY `ssn` (`ssn`),
  UNIQUE KEY `username` (`username`),
  CONSTRAINT `administrator_ibfk_1` FOREIGN KEY (`username`) REFERENCES `login_credential` (`username`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `administrator`
--

LOCK TABLES `administrator` WRITE;
/*!40000 ALTER TABLE `administrator` DISABLE KEYS */;
INSERT INTO `administrator` VALUES (1,'Jack','Doe','1970-03-15','M','123 Main St',NULL,'Atlanta','GA','90001','5551234567','123456789','jd001'),(2,'Jane','Smith','1985-07-22','F','456 Oak St',NULL,'Orlando','FL','90002','5559876543','987654321','js001');
/*!40000 ALTER TABLE `administrator` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `appointment`
--

DROP TABLE IF EXISTS `appointment`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `appointment` (
  `appointment_id` int NOT NULL AUTO_INCREMENT,
  `patient_id` int DEFAULT NULL,
  `doctor_id` int DEFAULT NULL,
  `appointment_date` datetime DEFAULT NULL,
  `reason` varchar(300) DEFAULT NULL,
  PRIMARY KEY (`appointment_id`),
  UNIQUE KEY `doctor_appointment_unique` (`doctor_id`,`appointment_date`),
  KEY `patient_id` (`patient_id`),
  CONSTRAINT `appointment_ibfk_1` FOREIGN KEY (`patient_id`) REFERENCES `patient` (`patient_id`),
  CONSTRAINT `appointment_ibfk_2` FOREIGN KEY (`doctor_id`) REFERENCES `doctor` (`doctor_id`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `appointment`
--

LOCK TABLES `appointment` WRITE;
/*!40000 ALTER TABLE `appointment` DISABLE KEYS */;
INSERT INTO `appointment` VALUES (1,1,1,'2024-10-15 10:00:00','Chest pain'),(2,2,2,'2024-10-16 11:30:00','Routine check-up'),(3,3,2,'2025-06-18 09:30:00','Routine check-up'),(4,2,2,'2024-11-28 09:58:00','checkup'),(5,1,1,'2024-11-19 10:30:00','headache'),(7,2,1,'2024-11-21 07:45:00','vomit'),(8,4,1,'2024-12-01 10:25:00','my toes hurt'),(9,4,2,'2024-12-19 14:21:00','somehting');
/*!40000 ALTER TABLE `appointment` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `doctor`
--

DROP TABLE IF EXISTS `doctor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `doctor` (
  `doctor_id` int NOT NULL AUTO_INCREMENT,
  `first_name` varchar(60) DEFAULT NULL,
  `last_name` varchar(60) DEFAULT NULL,
  `date_of_birth` date DEFAULT NULL,
  `sex` char(1) DEFAULT NULL,
  `address_line1` varchar(100) DEFAULT NULL,
  `address_line2` varchar(100) DEFAULT NULL,
  `city` varchar(50) DEFAULT NULL,
  `state` char(2) DEFAULT NULL,
  `zip_code` varchar(5) DEFAULT NULL,
  `phone_number` varchar(10) DEFAULT NULL,
  `ssn` char(9) DEFAULT NULL,
  PRIMARY KEY (`doctor_id`),
  UNIQUE KEY `ssn` (`ssn`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `doctor`
--

LOCK TABLES `doctor` WRITE;
/*!40000 ALTER TABLE `doctor` DISABLE KEYS */;
INSERT INTO `doctor` VALUES (1,'Ayrton','Senna','1960-03-21','M','789 Pine St',NULL,'Tuscon','AZ','90003','5555551234','456789123'),(2,'Emily','White','1975-11-05','F','987 Maple St',NULL,'San Diego','CA','90004','5556667890','321654987');
/*!40000 ALTER TABLE `doctor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `doctor_specialty`
--

DROP TABLE IF EXISTS `doctor_specialty`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `doctor_specialty` (
  `doctor_id` int NOT NULL,
  `specialty_id` int NOT NULL,
  PRIMARY KEY (`doctor_id`,`specialty_id`),
  KEY `specialty_id` (`specialty_id`),
  CONSTRAINT `doctor_specialty_ibfk_1` FOREIGN KEY (`doctor_id`) REFERENCES `doctor` (`doctor_id`),
  CONSTRAINT `doctor_specialty_ibfk_2` FOREIGN KEY (`specialty_id`) REFERENCES `specialty` (`specialty_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `doctor_specialty`
--

LOCK TABLES `doctor_specialty` WRITE;
/*!40000 ALTER TABLE `doctor_specialty` DISABLE KEYS */;
INSERT INTO `doctor_specialty` VALUES (1,1),(2,3);
/*!40000 ALTER TABLE `doctor_specialty` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `lab_test`
--

DROP TABLE IF EXISTS `lab_test`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `lab_test` (
  `test_code` int NOT NULL AUTO_INCREMENT,
  `test_name` varchar(60) DEFAULT NULL,
  `high_value` decimal(5,2) DEFAULT NULL,
  `low_value` decimal(5,2) DEFAULT NULL,
  `unit_of_measure` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`test_code`),
  UNIQUE KEY `test_name` (`test_name`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `lab_test`
--

LOCK TABLES `lab_test` WRITE;
/*!40000 ALTER TABLE `lab_test` DISABLE KEYS */;
INSERT INTO `lab_test` VALUES (1,'Blood Test',7.00,4.00,'g/dL'),(2,'X-Ray',NULL,NULL,'N/A'),(3,'Hemoglobin',17.50,12.00,'g/dL'),(4,'White Blood Cell Count',11.00,4.00,'10^9/L'),(5,'Platelet Count',450.00,150.00,'10^9/L'),(6,'Fasting Glucose',100.00,70.00,'mg/dL'),(7,'Calcium',10.50,8.50,'mg/dL'),(8,'Sodium',145.00,135.00,'mmol/L'),(9,'Potassium',5.00,3.50,'mmol/L'),(10,'Cholesterol',200.00,125.00,'mg/dL');
/*!40000 ALTER TABLE `lab_test` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `lab_test_result`
--

DROP TABLE IF EXISTS `lab_test_result`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `lab_test_result` (
  `result_id` int NOT NULL AUTO_INCREMENT,
  `visit_id` int DEFAULT NULL,
  `test_code` int DEFAULT NULL,
  `test_result` varchar(60) DEFAULT NULL,
  `result_normality` enum('NORMAL','ABNORMAL') DEFAULT NULL,
  `date_performed` datetime DEFAULT NULL,
  `status` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`result_id`),
  UNIQUE KEY `lab_test_result_unique` (`visit_id`,`test_code`),
  KEY `test_code` (`test_code`),
  CONSTRAINT `lab_test_result_ibfk_1` FOREIGN KEY (`visit_id`) REFERENCES `visit` (`visit_id`),
  CONSTRAINT `lab_test_result_ibfk_2` FOREIGN KEY (`test_code`) REFERENCES `lab_test` (`test_code`)
) ENGINE=InnoDB AUTO_INCREMENT=30 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `lab_test_result`
--

LOCK TABLES `lab_test_result` WRITE;
/*!40000 ALTER TABLE `lab_test_result` DISABLE KEYS */;
INSERT INTO `lab_test_result` VALUES (1,1,1,'6.5','NORMAL','2024-10-15 12:00:00',0),(2,2,2,'No abnormalities','NORMAL','2024-10-16 13:00:00',0),(3,3,1,'5','NORMAL','2024-11-17 00:00:00',1),(4,3,10,'124','ABNORMAL','2024-11-17 00:00:00',1),(5,3,6,'72','NORMAL','2024-11-15 00:00:00',1),(6,3,3,'12','NORMAL','2024-10-30 00:00:00',1),(7,4,1,'100','ABNORMAL','2024-11-27 00:00:00',1),(9,6,7,'5','ABNORMAL','2024-11-28 00:00:00',1),(10,6,2,NULL,NULL,NULL,0),(11,6,6,'50','ABNORMAL','2024-11-29 00:00:00',1),(12,7,1,'5','NORMAL','2024-11-28 00:00:00',1),(13,7,7,'15','ABNORMAL','2024-11-30 00:00:00',1),(21,6,3,'20','ABNORMAL','2024-11-26 00:00:00',1),(28,5,1,NULL,NULL,NULL,0),(29,5,7,NULL,NULL,NULL,0);
/*!40000 ALTER TABLE `lab_test_result` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `login_credential`
--

DROP TABLE IF EXISTS `login_credential`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `login_credential` (
  `username` varchar(40) NOT NULL,
  `password` varchar(256) NOT NULL,
  `salt` varchar(256) DEFAULT NULL,
  UNIQUE KEY `username` (`username`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `login_credential`
--

LOCK TABLES `login_credential` WRITE;
/*!40000 ALTER TABLE `login_credential` DISABLE KEYS */;
INSERT INTO `login_credential` VALUES ('ab001','Mu3hurd2GeSHjkHITOMHTpHy4htJr6GDs6VQBqXrKTQ=','FaI0rPE5hf1+dhz21VsljA=='),('jd001','eY12AUs+ne4zSvHNJ1YW6aGRIVrip+3r9K9sLAcRhX0=','Chk2KjEsWfWc/pPtOhdbzg=='),('js001','UJlpKuYAUYSiAbysW+D7CGdGARGFMmnuhO0S0AwF/vY=','mmJhqJj4DUgmTggQmTsZUA=='),('mf001','F6bM3BiX7MgV/9trcOoodSG8FDdB98/UcQ56YGqG97I=','4L6ixMp89qx2Tj16aa/QUw=='),('mf002','mXT/dSNNjE/X/+lhJSthzLCMhnw/UwttZYtOienqGug=','7OQRprAWm7wFdrcjn3QNbQ=='),('mf003','SIWzGKXs2zzZXwuSbRXBQxq+mk2rxj7GXdB+rYf7Yhg=','nKPLExFX0u+Vh4wxaKcTpw=='),('mf004','RrP5+7nJt7NI9deM0CCRhDA4RZB5IVhIuhRfXotes+U=','fOtfTTj2VtuTN4/9VPBd5g==');
/*!40000 ALTER TABLE `login_credential` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `nurse`
--

DROP TABLE IF EXISTS `nurse`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `nurse` (
  `nurse_id` int NOT NULL AUTO_INCREMENT,
  `first_name` varchar(60) DEFAULT NULL,
  `last_name` varchar(60) DEFAULT NULL,
  `date_of_birth` date DEFAULT NULL,
  `sex` char(1) DEFAULT NULL,
  `address_line1` varchar(100) DEFAULT NULL,
  `address_line2` varchar(100) DEFAULT NULL,
  `city` varchar(50) DEFAULT NULL,
  `state` char(2) DEFAULT NULL,
  `zip_code` varchar(5) DEFAULT NULL,
  `phone_number` varchar(10) DEFAULT NULL,
  `ssn` char(9) DEFAULT NULL,
  `username` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`nurse_id`),
  UNIQUE KEY `ssn` (`ssn`),
  UNIQUE KEY `username` (`username`),
  CONSTRAINT `nurse_ibfk_1` FOREIGN KEY (`username`) REFERENCES `login_credential` (`username`) ON DELETE SET NULL
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `nurse`
--

LOCK TABLES `nurse` WRITE;
/*!40000 ALTER TABLE `nurse` DISABLE KEYS */;
INSERT INTO `nurse` VALUES (1,'Megan','Fox','1986-05-16','F','654 Birch St',NULL,'Green Bay','WI','90005','5552223344','654321987','mf001'),(2,'Alex','Brown','1988-06-30','M','321 Cedar St',NULL,'Huntsville','AL','90006','5551112233','789456123','ab001'),(9,'Madeleine','Field','1990-01-31','F','Test Street',NULL,'Newnan','GA','30344','6789991111','111111111','mf002'),(10,'Max','Field','2000-02-01','M','123 Test Dr',NULL,'Kali','AZ','45032','6788764444','111111144','mf003'),(11,'Megan','Fischer','2024-05-07','F','Test 45',NULL,'Newnan','AZ','77565','1233454455','666666633','mf004');
/*!40000 ALTER TABLE `nurse` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `patient`
--

DROP TABLE IF EXISTS `patient`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `patient` (
  `patient_id` int NOT NULL AUTO_INCREMENT,
  `first_name` varchar(60) DEFAULT NULL,
  `last_name` varchar(60) DEFAULT NULL,
  `date_of_birth` date DEFAULT NULL,
  `sex` char(1) DEFAULT NULL,
  `address_line1` varchar(100) DEFAULT NULL,
  `address_line2` varchar(100) DEFAULT NULL,
  `city` varchar(50) DEFAULT NULL,
  `state` char(2) DEFAULT NULL,
  `zip_code` char(5) DEFAULT NULL,
  `phone_number` varchar(10) DEFAULT NULL,
  `ssn` char(9) DEFAULT NULL,
  `status` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`patient_id`),
  UNIQUE KEY `ssn` (`ssn`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `patient`
--

LOCK TABLES `patient` WRITE;
/*!40000 ALTER TABLE `patient` DISABLE KEYS */;
INSERT INTO `patient` VALUES (1,'Vitor','Johnson','2010-12-31','M','123 Walnut St',NULL,'Portland','UT','90009','2222222222','112233445',1),(2,'Laura','Johnson','1995-12-20','F','456 Elm St',NULL,'Los Angeles','CA','90008','5554445566','223344556',1),(3,'Marty','McFly','1968-06-12','M','88 Time Dr',NULL,'Hill Valley','CA','90055','5347568252','787878787',1),(4,'Michelle','dos Santos','1997-04-08','F','40 Beaver Creek Ln',NULL,'Newnan','GA','83940','8127638762','696969696',1);
/*!40000 ALTER TABLE `patient` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `specialty`
--

DROP TABLE IF EXISTS `specialty`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `specialty` (
  `specialty_id` int NOT NULL AUTO_INCREMENT,
  `specialty_name` varchar(60) DEFAULT NULL,
  PRIMARY KEY (`specialty_id`)
) ENGINE=InnoDB AUTO_INCREMENT=24 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `specialty`
--

LOCK TABLES `specialty` WRITE;
/*!40000 ALTER TABLE `specialty` DISABLE KEYS */;
INSERT INTO `specialty` VALUES (1,'Cardiology'),(2,'Dermatology'),(3,'Pediatrics'),(4,'Neurology'),(5,'Oncology'),(6,'Orthopedics'),(7,'Gastroenterology'),(8,'Endocrinology'),(9,'Nephrology'),(10,'Ophthalmology'),(11,'Pulmonology'),(12,'Hematology'),(13,'Psychiatry'),(14,'Urology'),(15,'Allergy and Immunology'),(16,'Infectious Disease'),(17,'General Surgery'),(18,'Family Medicine'),(19,'Anesthesiology'),(20,'Plastic Surgery'),(21,'Radiology'),(22,'Emergency Medicine'),(23,'Pathology');
/*!40000 ALTER TABLE `specialty` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `visit`
--

DROP TABLE IF EXISTS `visit`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `visit` (
  `visit_id` int NOT NULL AUTO_INCREMENT,
  `appointment_id` int DEFAULT NULL,
  `nurse_id` int DEFAULT NULL,
  `bp_systolic` int DEFAULT NULL,
  `bp_diastolic` int DEFAULT NULL,
  `body_temperature` decimal(5,2) DEFAULT NULL,
  `weight` decimal(5,2) DEFAULT NULL,
  `height` decimal(5,2) DEFAULT NULL,
  `pulse_rate` int DEFAULT NULL,
  `symptoms` varchar(200) DEFAULT NULL,
  `initial_diagnosis` varchar(200) DEFAULT NULL,
  `final_diagnosis` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`visit_id`),
  UNIQUE KEY `appointment_id` (`appointment_id`),
  KEY `nurse_id` (`nurse_id`),
  CONSTRAINT `visit_ibfk_1` FOREIGN KEY (`appointment_id`) REFERENCES `appointment` (`appointment_id`),
  CONSTRAINT `visit_ibfk_2` FOREIGN KEY (`nurse_id`) REFERENCES `nurse` (`nurse_id`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `visit`
--

LOCK TABLES `visit` WRITE;
/*!40000 ALTER TABLE `visit` DISABLE KEYS */;
INSERT INTO `visit` VALUES (1,1,1,120,80,98.60,180.50,72.40,72,'Chest tightness','dead',NULL),(2,2,2,110,70,98.20,155.30,65.50,65,'Mild fever','Viral infection',NULL),(3,5,2,200,100,110.40,100.40,607.30,200,'headache','ahsudhau','eat less salt'),(4,7,2,800,300,123.00,999.00,963.00,2,'throwing up some green stuff',NULL,NULL),(5,4,2,520,130,123.00,563.00,123.00,20,'test editing without changing tests','need more tests',NULL),(6,8,2,999,999,100.00,222.00,333.00,99,'WORKING','WORKING',NULL),(7,9,2,125,13,990.00,100.00,622.00,133,'FIXING','IS UPDATING?',NULL);
/*!40000 ALTER TABLE `visit` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-12-01 23:49:16
