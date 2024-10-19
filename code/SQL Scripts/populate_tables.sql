USE cs3230f24f;

INSERT INTO login_credential (username, password) 
VALUES 
('jd001', 'pass'),
('js001', 'pass'),
('mf001', 'pass'),
('ab001', 'pass');

INSERT INTO administrator (first_name, last_name, date_of_birth, sex, address_line1, city, state, zip_code, phone_number, ssn, username)
VALUES 
('John', 'Doe', '1970-03-15', 'M', '123 Main St', 'Atlanta', 'GA', '90001', '5551234567', '123456789', 'jd001'),
('Jane', 'Smith', '1985-07-22', 'F', '456 Oak St', 'Orlando', 'FL', '90002', '5559876543', '987654321', 'js001');

INSERT INTO doctor (first_name, last_name, date_of_birth, sex, address_line1, city, state, zip_code, phone_number, ssn)
VALUES 
('Ayrton', 'Senna', '1960-03-21', 'M', '789 Pine St', 'Tuscon', 'AZ', '90003', '5555551234', '456789123'),
('Emily', 'White', '1975-11-05', 'F', '987 Maple St', 'San Diego', 'CA', '90004', '5556667890', '321654987');

INSERT INTO nurse (first_name, last_name, date_of_birth, sex, address_line1, city, state, zip_code, phone_number, ssn, username)
VALUES 
('Megan', 'Fox', '1986-05-16', 'F', '654 Birch St', 'Green Bay', 'WI', '90005', '5552223344', '654321987', 'mf001'),
('Alex', 'Brown', '1988-06-30', 'M', '321 Cedar St', 'Huntsville', 'AL', '90006', '5551112233', '789456123', 'ab001');

INSERT INTO patient (first_name, last_name, date_of_birth, sex, address_line1, city, state, zip_code, phone_number, ssn, status)
VALUES 
('David', 'Miller', '2000-09-15', 'M', '123 Walnut St', 'Portland', 'OR', '90007', '5553334455', '112233445', 1),
('Laura', 'Johnson', '1995-12-20', 'F', '456 Elm St', 'Los Angeles', 'CA', '90008', '5554445566', '223344556', 1);

INSERT INTO specialty (specialty_name) 
VALUES 
('Cardiology'),
('Dermatology'),
('Pediatrics');

INSERT INTO doctor_specialty (doctor_id, specialty_id) 
VALUES 
(1, 1),
(2, 3);

INSERT INTO appointment (patient_id, doctor_id, appointment_date, reason) 
VALUES 
(1, 1, '2024-10-15 10:00:00', 'Chest pain'),
(2, 2, '2024-10-16 11:30:00', 'Routine check-up');

INSERT INTO visit (appointment_id, nurse_id, bp_systolic, bp_diastolic, body_temperature, weight, height, pulse_rate, symptoms, initial_diagnosis)
VALUES 
(1, 1, 120, 80, 98.6, 180.5, 72.4, 72, 'Chest tightness', 'Angina'),
(2, 2, 110, 70, 98.2, 155.3, 65.5, 65, 'Mild fever', 'Viral infection');

INSERT INTO lab_test (test_name, high_value, low_value, unit_of_measure) 
VALUES 
('Blood Test', 7.0, 4.0, 'g/dL'),
('X-Ray', NULL, NULL, 'N/A');

INSERT INTO lab_test_result (visit_id, test_code, test_result, result_normality, date_preformed)
VALUES 
(1, 1, '6.5', 'normal', '2024-10-15 12:00:00'),
(2, 2, 'No abnormalities', 'normal', '2024-10-16 13:00:00');
