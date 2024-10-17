use cs3230f24f;

DROP TABLE IF EXISTS patient;

CREATE TABLE `patient` (
patient_id integer auto_increment primary key,
last_name varchar(60) not null,
first_name varchar(60) not null,
date_of_birth DATE not null,
address1 varchar(100) not null,
address2 varchar(100),
city varchar(50) not null,
state char(2) not null,
zip_code varchar(10) not null,
phone_number varchar(10),
`status` boolean not null
);