use  HealthcareDB;
CREATE TABLE Rooms 
(
    Room_ID INT IDENTITY(1,1) PRIMARY KEY,
    Room_Number VARCHAR(20) NOT NULL UNIQUE,
    Floor_No INT,
    Room_Type VARCHAR(50)
);
CREATE TABLE Doctor_Room
(
    Doctor_ID INT,
    Room_ID INT,

    PRIMARY KEY (Doctor_ID, Room_ID),

    FOREIGN KEY (Doctor_ID)
        REFERENCES Doctor(Doctor_ID),

    FOREIGN KEY (Room_ID)
        REFERENCES Rooms(Room_ID)
);
INSERT INTO Rooms
(Room_Number, Floor_No, Room_Type)

VALUES
('R101',1,'Consultation'),
('R102',1,'Consultation'),
('R201',2,'Operation');

INSERT INTO Doctor_Room
VALUES
(1,1),
(2,2),
(3,3),
(1,2);

SELECT *
FROM Doctor_Room dr
JOIN Doctor d
ON dr.Doctor_ID=d.Doctor_ID
JOIN Rooms r
ON dr.Room_ID=r.Room_ID;