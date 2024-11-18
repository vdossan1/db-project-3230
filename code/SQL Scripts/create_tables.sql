USE cs3230f24f;

SET FOREIGN_KEY_CHECKS=0;

DROP TABLE IF EXISTS `login_credential`;
DROP TABLE IF EXISTS `administrator`;
DROP TABLE IF EXISTS `doctor`;
DROP TABLE IF EXISTS `nurse`;
DROP TABLE IF EXISTS `patient`;
DROP TABLE IF EXISTS `doctor_specialty`;
DROP TABLE IF EXISTS `specialty`;
DROP TABLE IF EXISTS `appointment`;
DROP TABLE IF EXISTS `visit`;
DROP TABLE IF EXISTS `lab_test_result`;
DROP TABLE IF EXISTS `lab_test`;

CREATE TABLE `login_credential`
(
username VARCHAR(40) UNIQUE,
`password` VARCHAR(100)
);

CREATE TABLE `administrator`
(
administrator_id INTEGER AUTO_INCREMENT,
first_name VARCHAR(60),
last_name VARCHAR(60),
date_of_birth DATE,
sex CHAR(1),
address_line1 VARCHAR(100),
address_line2 VARCHAR(100) NULL,
city VARCHAR(50),
`state` CHAR(2),
zip_code VARCHAR(5),
phone_number VARCHAR(10),
ssn CHAR(9) UNIQUE,
username VARCHAR(30) UNIQUE,
PRIMARY KEY (administrator_id),
FOREIGN KEY (username) REFERENCES login_credential(username)
);

CREATE TABLE `doctor`
(
doctor_id INTEGER AUTO_INCREMENT,
first_name VARCHAR(60),
last_name VARCHAR(60),
date_of_birth DATE,
sex CHAR(1),
address_line1 VARCHAR(100),
address_line2 VARCHAR(100) NULL,
city VARCHAR(50),
`state` CHAR(2),
zip_code VARCHAR(5),
phone_number VARCHAR(10),
ssn CHAR(9) UNIQUE,
PRIMARY KEY (doctor_id)
);

CREATE TABLE `nurse`
(
nurse_id INTEGER AUTO_INCREMENT,
first_name VARCHAR(60),
last_name VARCHAR(60),
date_of_birth DATE,
sex CHAR(1),
address_line1 VARCHAR(100),
address_line2 VARCHAR(100) NULL,
city VARCHAR(50),
`state` CHAR(2),
zip_code VARCHAR(5),
phone_number VARCHAR(10),
ssn CHAR(9) UNIQUE,
username VARCHAR(30) UNIQUE,
PRIMARY KEY (nurse_id),
FOREIGN KEY (username) REFERENCES login_credential(username)
);

CREATE TABLE `patient`
(
patient_id INTEGER AUTO_INCREMENT,
first_name VARCHAR(60),
last_name VARCHAR(60),
date_of_birth DATE,
sex CHAR(1),
address_line1 VARCHAR(100),
address_line2 VARCHAR(100) NULL,
city VARCHAR(50),
`state` CHAR(2),
zip_code CHAR(5),
phone_number VARCHAR(10),
ssn CHAR(9) UNIQUE,
`status` tinyint(1),
PRIMARY KEY (patient_id)
);

CREATE TABLE `doctor_specialty`
(
doctor_id INTEGER,
specialty_id INTEGER,
PRIMARY KEY (doctor_id, specialty_id),
FOREIGN KEY (doctor_id) REFERENCES doctor(doctor_id),
FOREIGN KEY (specialty_id) REFERENCES specialty(specialty_id)
);

CREATE TABLE `specialty`
(
specialty_id INTEGER AUTO_INCREMENT,
specialty_name VARCHAR(60),
PRIMARY KEY (specialty_id)
);

CREATE TABLE `appointment`
(
appointment_id INTEGER AUTO_INCREMENT,
patient_id INTEGER,
doctor_id INTEGER,
appointment_date DATETIME,
reason VARCHAR(300),
PRIMARY KEY (appointment_id),
FOREIGN KEY (patient_id) REFERENCES patient(patient_id),
FOREIGN KEY (doctor_id) REFERENCES doctor(doctor_id),
UNIQUE KEY doctor_appointment_unique (doctor_id, appointment_date)
);


CREATE TABLE `visit`
(
visit_id INTEGER AUTO_INCREMENT,
appointment_id INTEGER UNIQUE,
nurse_id INTEGER,
bp_systolic INTEGER,
bp_diastolic INTEGER,
body_temperature DECIMAL(5,2),
`weight` DECIMAL(5,2),
height DECIMAL(5,2),
pulse_rate INTEGER,
symptoms VARCHAR(200),
initial_diagnosis VARCHAR(200),
final_diagnosis VARCHAR(200) NULL,
PRIMARY KEY (visit_id),
FOREIGN KEY (appointment_id) REFERENCES appointment(appointment_id),
FOREIGN KEY (nurse_id) REFERENCES nurse(nurse_id)
);

CREATE TABLE `lab_test_result`
(
result_id INTEGER AUTO_INCREMENT,
visit_id INTEGER,
test_code INTEGER,
test_result VARCHAR(60) NULL,
result_normality ENUM('NORMAL', 'ABNORMAL') NULL,
date_performed DATETIME NULL,
`status` tinyint(1),
PRIMARY KEY (result_id),
FOREIGN KEY (visit_id) REFERENCES visit(visit_id),
FOREIGN KEY (test_code) REFERENCES lab_test(test_code),
UNIQUE KEY lab_test_result_unique (visit_id, test_code)
);

CREATE TABLE `lab_test`
(
test_code INTEGER AUTO_INCREMENT,
test_name VARCHAR(60) UNIQUE,
high_value DECIMAL(5,2) NULL,
low_value DECIMAL(5,2) NULL,
unit_of_measure VARCHAR(30),
PRIMARY KEY (test_code)
);

 SET FOREIGN_KEY_CHECKS=1;