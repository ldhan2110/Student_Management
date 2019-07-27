CREATE DATABASE University
GO
USE University

------------------------------------------------------------------------

CREATE TABLE Students
(
	STT INT IDENTITY(1,1),
	MSSV NVARCHAR(8) PRIMARY KEY,
	HọTên NVARCHAR(50) NOT NULL,
	GiớiTính NVARCHAR(4) CHECK (GiớiTính = 'Nam' or GiớiTính = 'Nữ'),
	CMND NVARCHAR(20), 
	Class NVARCHAR(10) NOT NULL
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

INSERT INTO Students VALUES ('1753028','Vu Van Cuong','Nam','058869175','17CLC1');

DROP DATABASE University;