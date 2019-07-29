﻿CREATE DATABASE University
GO
USE University

------------------------------------------------------------------------

CREATE TABLE Students
(
	STT INT IDENTITY(1,1),
	MSSV NVARCHAR(8) PRIMARY KEY,
	HọTên NVARCHAR(50) NOT NULL,
	GiớiTính NVARCHAR(4) CHECK (GiớiTính = N'Nam' or GiớiTính = N'Nữ'),
	CMND NVARCHAR(20) NOT NULL, 
	Class NVARCHAR(10) NOT NULL
)

CREATE TABLE Courses
(
	STT INT IDENTITY(1,1),
	MãMôn NVARCHAR(8),
	TênMôn NVARCHAR(50) NOT NULL,
	PhòngHọc NVARCHAR(5) NOT NULL,
	Class	NVARCHAR(20) NOT NULL,

	PRIMARY KEY(Mãmôn,Class)
)

CREATE TABLE Users
(
	Username NVARCHAR(50) UNIQUE,
	Password NVARCHAR(20),
	Roles CHAR(1) CHECK (Roles = 'A' OR Roles = 'G' OR Roles = 'S')
)

CREATE TABLE ClassCourses
(
	STT INT IDENTITY(1,1),
	MSSV NVARCHAR(8) NOT NULL,
	MãMôn NVARCHAR(8) NOT NULL,
	Class NVARCHAR(20) NOT NULL,
	PRIMARY KEY(MSSV,MãMôn,Class)
)

INSERT INTO Users VALUES('admin','123','A');
INSERT INTO Users VALUES('htthanh','123','G');
INSERT INTO Users VALUES('1753027','123','S');

INSERT INTO Students VALUES ('1753056','Vu Van Ti',N'Nữ','058869175','17CLC1');

DROP DATABASE University;