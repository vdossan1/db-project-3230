use cs3230f24f;

DROP TABLE IF EXISTS `login_credential`;

CREATE TABLE `login_credential` (
user_name VARCHAR (20),
`password` VARCHAR (256)
);

INSERT INTO `login_credential` VALUES ("jd0001", "pass")