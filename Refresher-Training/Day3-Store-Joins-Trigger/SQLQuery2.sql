USE HealthcareDB;
GO

-- View Existing Tables

SELECT * FROM dbo.Doctor;
SELECT * FROM dbo.Patient;

GO

-- Create Patient Audit Table

CREATE TABLE Patient_Audit
(
    Audit_ID INT IDENTITY(1,1) PRIMARY KEY,
    Patient_ID INT,
    Name VARCHAR(100),
    Gender VARCHAR(10),
    Date_Of_Birth DATE,
    Phone VARCHAR(15),
    Email VARCHAR(100),
    Address VARCHAR(100),
    Action_Type VARCHAR(20),
    Action_Date DATETIME DEFAULT GETDATE()
);
GO

-- Create AFTER INSERT Trigger

CREATE TRIGGER trg_Patient_Insert
ON dbo.Patient
AFTER INSERT
AS
BEGIN

    INSERT INTO Patient_Audit
    (
        Patient_ID,
        Name,
        Gender,
        Date_Of_Birth,
        Phone,
        Email,
        Address,
        Action_Type
    )

    SELECT
        Patient_ID,
        Name,
        Gender,
        Date_Of_Birth,
        Phone,
        Email,
        Address,
        'INSERT'
    FROM inserted;

END;
GO

-- Test INSERT Trigger

INSERT INTO dbo.Patient
(
    Name,
    Gender,
    Date_Of_Birth,
    Phone,
    Email,
    Address
)
VALUES
(
    'Rohan Gupta',
    'Male',
    '1999-04-15',
    '9999999991',
    'rohan@gmail.com',
    'Lucknow'
);

SELECT * FROM Patient_Audit;

GO

-- Create AFTER UPDATE Trigger

CREATE TRIGGER trg_Patient_Update
ON dbo.Patient
AFTER UPDATE
AS
BEGIN

    INSERT INTO Patient_Audit
    (
        Patient_ID,
        Name,
        Gender,
        Date_Of_Birth,
        Phone,
        Email,
        Address,
        Action_Type
    )

    SELECT
        Patient_ID,
        Name,
        Gender,
        Date_Of_Birth,
        Phone,
        Email,
        Address,
        'UPDATE'
    FROM inserted;

END;
GO

-- Test UPDATE Trigger

UPDATE dbo.Patient
SET Address='Mumbai'
WHERE Patient_ID=1;

SELECT * FROM Patient_Audit;

GO

-- Create AFTER DELETE Trigger

CREATE TRIGGER trg_Patient_Delete
ON dbo.Patient
AFTER DELETE
AS
BEGIN

    INSERT INTO Patient_Audit
    (
        Patient_ID,
        Name,
        Gender,
        Date_Of_Birth,
        Phone,
        Email,
        Address,
        Action_Type
    )

    SELECT
        Patient_ID,
        Name,
        Gender,
        Date_Of_Birth,
        Phone,
        Email,
        Address,
        'DELETE'
    FROM deleted;

END;
GO

-- Find Patients without Appointments

SELECT *
FROM Patient
WHERE Patient_ID NOT IN
(
    SELECT Patient_ID
    FROM Appointment
);

GO

-- Test DELETE Trigger

DELETE FROM Patient
WHERE Patient_ID = 4;

SELECT * FROM Patient_Audit;

GO

-- Create INSERT Stored Procedure

CREATE PROCEDURE sp_InsertDoctor
(
    @Name VARCHAR(100),
    @Specialty VARCHAR(100),
    @Phone VARCHAR(15),
    @Email VARCHAR(100),
    @Experience_Years INT
)
AS
BEGIN

    INSERT INTO Doctor
    (
        Name,
        Specialty,
        Phone,
        Email,
        experience_years
    )
    VALUES
    (
        @Name,
        @Specialty,
        @Phone,
        @Email,
        @Experience_Years
    );

END;
GO

-- Execute INSERT Procedure

EXEC sp_InsertDoctor
'Dr. Rahul',
'Cardiologist',
'9876543210',
'rahul@gmail.com',
10;

GO

-- Create UPDATE Stored Procedure

CREATE PROCEDURE sp_UpdateDoctor
(
    @Doctor_ID INT,
    @Phone VARCHAR(15),
    @Email VARCHAR(100)
)
AS
BEGIN

    UPDATE Doctor
    SET
        Phone=@Phone,
        Email=@Email
    WHERE Doctor_ID=@Doctor_ID;

END;
GO

-- Execute UPDATE Procedure

EXEC sp_UpdateDoctor
1,
'9999999999',
'newrahul@gmail.com';

GO

-- Create DELETE Stored Procedure

CREATE PROCEDURE sp_DeleteDoctor
(
    @Doctor_ID INT
)
AS
BEGIN

    DELETE FROM Doctor
    WHERE Doctor_ID=@Doctor_ID;

END;
GO

-- Execute DELETE Procedure

EXEC sp_DeleteDoctor 5;

GO

-- Verify Doctor Table

SELECT * FROM Doctor;

GO