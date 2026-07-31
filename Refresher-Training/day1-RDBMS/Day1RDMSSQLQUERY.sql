create database HealthcareDB;
use HealthcareDB;
CREATE TABLE Patient
(
    Patient_ID INT IDENTITY(1,1) PRIMARY KEY,
    Name VARCHAR(100) NOT NULL,
    Gender VARCHAR(10),
    Date_Of_Birth DATE,
    Phone VARCHAR(15),
    Email VARCHAR(100),
    Address VARCHAR(255)
);
create table Doctor(
    Doctor_ID INT IDENTITY(1,1) PRIMARY KEY,
    Name VARCHAR(100) NOT NULL,
    Specialty VARCHAR(100),
    phone VARCHAR(15),
    Email VARCHAR(100),
    experience_years INT
);
CREATE TABLE Appointment
(
    Appointment_ID INT IDENTITY(1,1) PRIMARY KEY,

    Patient_ID INT NOT NULL,
    Doctor_ID INT NOT NULL,

    Appointment_Date DATE,
    Start_Time TIME,
    End_Time TIME,
    Status VARCHAR(20),

    CONSTRAINT FK_Appointment_Patient
        FOREIGN KEY (Patient_ID)
        REFERENCES Patient(Patient_ID),

    CONSTRAINT FK_Appointment_Doctor
        FOREIGN KEY (Doctor_ID)
        REFERENCES Doctor(Doctor_ID)
);
INSERT INTO Patient (Name, Gender, Date_Of_Birth, Phone, Email, Address)
VALUES
('Rahul Sharma', 'Male', '2001-05-15', '9876543210', 'rahul@gmail.com', 'Delhi'),
('Priya Verma', 'Female', '2002-08-20', '9876501234', 'priya@gmail.com', 'Noida'),
('Aman Singh', 'Male', '2000-11-10', '9876512345', 'aman@gmail.com', 'Kanpur');

SELECT * FROM Patient;

INSERT INTO Doctor (Name, Specialty, Phone, Email, experience_years)
VALUES
('Dr. Raj Sharma', 'Cardiologist', '9123456789', 'raj@gmail.com', 10),
('Dr. Neha Gupta', 'Dermatologist', '9234567890', 'neha@gmail.com', 7),
('Dr. Amit Kumar', 'Orthopedic', '9345678901', 'amit@gmail.com', 12);
SELECT * FROM Doctor;


INSERT INTO Appointment
(Patient_ID, Doctor_ID, Appointment_Date, Start_Time, End_Time, Status)
VALUES
(1, 1, '2026-08-01', '09:00:00', '09:30:00', 'Completed'),
(2, 2, '2026-08-01', '10:00:00', '10:30:00', 'Scheduled'),
(3, 3, '2026-08-02', '11:00:00', '11:45:00', 'Pending'),
(1, 2, '2026-08-03', '02:00:00', '02:30:00', 'Scheduled');

SELECT * FROM Appointment;