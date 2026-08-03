--query without index
SELECT *
FROM Appointment
WHERE Status='Scheduled';

--Single Column Index
--only matching rows are searched
CREATE INDEX Appointment_Status
ON Appointment(Status);

SELECT *
FROM Appointment
WHERE Status='Scheduled';

--Composite Index
--Searching becomes faster because both columns are indexed together.
CREATE INDEX IX_Doctor_Date
ON Appointment(Doctor_ID, Appointment_Date);
SELECT *
FROM Appointment
WHERE Doctor_ID = 2
AND Appointment_Date = '2026-08-01';