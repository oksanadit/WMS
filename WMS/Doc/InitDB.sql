SET NOCOUNT ON
GO

USE [MASTER]
GO

CREATE DATABASE [WMS]

SET DATEFORMAT mdy
GO

Use [WMS];
 

CREATE TABLE Document (
    ID_Document INT PRIMARY KEY IDENTITY (1, 1) not null,
    Name VARCHAR (50) NOT NULL,
    Client VARCHAR (50) NOT NULL,
    Created DATETIME,  
)

CREATE TABLE DocumentPosition (
    ID_Position INT PRIMARY KEY IDENTITY (1, 1) not null,
    Name VARCHAR (50) NOT NULL,
    Gross float NOT NULL,
	Net float NOT NULL,
	Amount int,
    Created DATETIME, 
	ID_Document INT NOT NULL,
    FOREIGN KEY (ID_Document) REFERENCES Document (ID_Document)
)

CREATE TABLE EventLog (
    ID_EventLog INT PRIMARY KEY IDENTITY (1, 1) not null,
    Type VARCHAR (10) NOT NULL,
	CreatedDate DATETIME, 
	Description NVARCHAR (max),
	ID_Document INT NOT NULL
)
SET IDENTITY_INSERT Document ON 
GO 
INSERT INTO Document
(ID_Document, Name, Client, Created )
VALUES
(1,'Invoice 1/2022', 'Client1', '2022-08-02 00:00:00.000' ),
(2,'Invoice 2/2022', 'Client2', '2022-08-01 00:00:00.000' ),
(3,'Invoice 3/2022', 'Client3', '2022-08-22 00:00:00.000' ),
(4,'Invoice 4/2022', 'Client1', '2022-08-02 00:00:00.000' ),
(5,'Invoice 5/2022', 'Client4', '2022-08-02 00:00:00.000' )
;
SET IDENTITY_INSERT Document OFF 
GO 
INSERT INTO DocumentPosition
(Name, Amount, Gross, Net, ID_Document, Created)
VALUES
('Art1', 1,3,2,1,'2022-08-02 00:00:00.000' ),
('Art2', 2,3,2,1, '2022-08-01 00:00:00.000' ),
('Art3', 3,2,1,1, '2022-08-22 00:00:00.000' ),
('Art4', 1,12,11,2, '2022-08-02 00:00:00.000' ),
('Art5', 11,125,120,2, '2022-08-02 00:00:00.000' ),
('Art6', 11,12,11,3, '2022-08-02 00:00:00.000' ),
('Art7', 11,12,12,3, '2022-08-02 00:00:00.000' ),
('Art8', 11,12,11,4, '2022-08-02 00:00:00.000' ),
('Art9', 11,13,10,5, '2022-08-02 00:00:00.000' )
;
