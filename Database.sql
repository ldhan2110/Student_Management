CREATE DATABASE University
GO
USE University

------------------------------------------------------------------------

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