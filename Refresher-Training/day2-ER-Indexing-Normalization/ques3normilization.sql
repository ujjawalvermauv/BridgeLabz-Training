CREATE TABLE Patient_Phones
(
    Phone_ID INT IDENTITY(1,1) PRIMARY KEY,
    Patient_ID INT NOT NULL,
    Phone VARCHAR(15) NOT NULL,

    FOREIGN KEY (Patient_ID)
    REFERENCES Patient(Patient_ID)
);

INSERT INTO Patient_Phones (Patient_ID, Phone)
VALUES
(1,'9999999999'),
(1,'8888888888'),
(2,'7777777777'),
(3,'6666666666');

SELECT * FROM Patient_Phones;

-- 1NF:
-- Each phone number is stored in a separate row.
-- No multi-valued attributes.

-- 2NF:
-- All non-key attributes depend on the primary key (Phone_ID).
-- No partial dependency.

-- 3NF:
-- No transitive dependency.
-- Non-key attributes depend only on the primary key.