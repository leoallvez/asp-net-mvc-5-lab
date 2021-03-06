
IF NOT EXISTS (SELECT name FROM master.sys.databases WHERE name = 'DoctorWho')
BEGIN
	CREATE DATABASE DoctorWho;
END

USE DoctorWho;

GO

IF  NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Users' AND type = 'U')
BEGIN
	CREATE TABLE Users
	(
		UserId BIGINT IDENTITY(1,1) NOT NULL,
		FullName VARCHAR(100) NOT NULL,
		LoginSystem VARCHAR(30) NOT NULL,
		PasswordSystem VARCHAR(100) NOT NULL,
		Email VARCHAR(100) NOT NULL,
		PRIMARY KEY(UserId)
	);
END

IF  NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Specialties' AND type = 'U')
BEGIN
	CREATE TABLE Specialties
	(
		SpecialtyId BIGINT IDENTITY(1,1) NOT NULL,
		Descriptions VARCHAR(100) NOT NULL,
		PRIMARY KEY(SpecialtyId)
	);
END


IF  NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Cities' AND type = 'U')
BEGIN
	CREATE TABLE Cities
	(
		CityId BIGINT IDENTITY(1,1) NOT NULL,
		FullName VARCHAR(100) NOT NULL,
		PRIMARY KEY(CityId)
	);
END

IF  NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Doctors' AND type = 'U')
BEGIN
	CREATE TABLE Doctors
	(
		DoctorId BIGINT IDENTITY(1,1) NOT NULL,
		CRM VARCHAR(30) NOT NULL,
		FullName VARCHAR(100) NOT NULL,
		Adress VARCHAR(100) NOT NULL,
		Neighborhood VARCHAR(100) NOT NULL,
		Email VARCHAR(100) NOT NULL,
		WorksWithCovenant BIT NOT NULL,
		HasClinic BIT NOT NULL,
		Website VARCHAR(150) NULL,
		CityId BIGINT NOT NULL,
		SpecialtyId BIGINT NOT NULL,
	
		CONSTRAINT REL_DOCTORS_CITIES  FOREIGN KEY(CityId)
			REFERENCES Cities (CityId),
		CONSTRAINT REL_DOCTORS_SPECIALTIES FOREIGN KEY(SpecialtyId)
			REFERENCES Specialties (SpecialtyId),

		PRIMARY KEY (DoctorId)
	);
END




