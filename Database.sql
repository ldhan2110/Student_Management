CREATE DATABASE University
GO
USE University

------------------------------------------------------------------------

CREATE TABLE Students
(
	STT char(1),
	MSSV VARCHAR(8) PRIMARY KEY,
	Họ tên VARCHAR(50) NOT NULL,
	Gender CHAR(3) CHECK (Gender = 'Nam' or Gender = 'Nữ'),
	CMND VARCHAR(10), 
	Class VARCHAR(10) NOT NULL
)

CREATE TABLE Users
(
	Username NVARCHAR(50) UNIQUE,
	Password NVARCHAR(20),
	Roles CHAR(1) CHECK (Roles = 'A' OR Roles = 'G' OR Roles = 'S')
)

INSERT INTO Users VALUES('admin','123','A');
INSERT INTO Users VALUES('htthanh','123','G');
INSERT INTO Users VALUES('1753027','123','S');

DROP DATABASE University;