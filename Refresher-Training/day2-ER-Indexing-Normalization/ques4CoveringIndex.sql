CREATE INDEX IX_Doctor_Date_Status
ON Appointment (Doctor_ID, Appointment_Date, Status);
-- Covering Index contains all required columns.
-- SQL Server uses the index to retrieve data.

SELECT Doctor_ID,Appointment_Date,Status
FROM Appointment
WHERE Doctor_ID = 2;