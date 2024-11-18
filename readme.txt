Usernames: mf001 or ab001
Passwords: use "pass" for each user (will be changed in upcoming iteration)

Stored Procedures
-----------------------------------------------

CREATE DEFINER=`cs3230f24f`@`%` PROCEDURE `getPatientsWithParams`(
    IN firstName VARCHAR(255),
    IN lastName VARCHAR(255),
    IN dateOfBirth DATE
)
BEGIN
    -- Start with a base query
    SET @query = 'SELECT * FROM patient WHERE 1=1';

    -- Add conditions dynamically based on non-NULL and non-empty parameters
    IF firstName IS NOT NULL AND firstName != '' THEN
        SET @query = CONCAT(@query, ' AND first_name = "', firstName, '"');
    END IF;

    IF lastName IS NOT NULL AND lastName != '' THEN
        SET @query = CONCAT(@query, ' AND last_name = "', lastName, '"');
    END IF;

    IF dateOfBirth IS NOT NULL THEN
        SET @query = CONCAT(@query, ' AND date_of_birth = "', dateOfBirth, '"');
    END IF;

    -- Prepare and execute the dynamic query
    PREPARE stmt FROM @query;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;
END


USE cs3230f24f;

DROP PROCEDURE IF EXISTS `getVisitsWithPatientParams`;
DELIMITER $$

CREATE PROCEDURE `getVisitsWithPatientParams`(
    IN firstName VARCHAR(255),
    IN lastName VARCHAR(255),
    IN dateOfBirth DATE
)

-----------------------------------------------

BEGIN
    -- Start with a base query
    SET @query = 'SELECT * FROM visit WHERE appointment_id IN (SELECT a.appointment_id FROM patient p JOIN appointment AS a ON p.patient_id = a.patient_id WHERE 1=1 ';

    -- Add conditions based on non-NULL parameters
    IF firstName IS NOT NULL OR firstName != "" THEN
        SET @query = CONCAT(@query, ' AND first_name = "', firstName, '"');
    END IF;

    IF lastName IS NOT NULL OR lastName != "" THEN
        SET @query = CONCAT(@query, ' AND last_name = "', lastName, '"');
    END IF;

    IF dateOfBirth IS NOT NULL THEN
        SET @query = CONCAT(@query, ' AND date_of_birth = "', dateOfBirth, '"');
    END IF;
    
    SET @query = CONCAT(@query, ')');

    -- Prepare and execute the dynamic query
    PREPARE stmt FROM @query;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;
END$$

DELIMITER ;

CALL `getVisitsWithPatientParams`(null, null, "2000-09-15");
