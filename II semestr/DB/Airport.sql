CREATE DATABASE Airport
GO

USE Airport 
GO

CREATE TABLE Passenger
(
	id INT PRIMARY KEY IDENTITY,
	full_name NVARCHAR(100) UNIQUE NOT NULL,
	email NVARCHAR(50) UNIQUE NOT NULL,
)
GO

CREATE TABLE Pilot
(
	id INT PRIMARY KEY IDENTITY,
	first_name NVARCHAR(30) UNIQUE NOT NULL,
	last_name NVARCHAR(30) UNIQUE NOT NULL,
	age TINYINT NOT NULL,
	rating FLOAT(1) NULL,

	CHECK(age BETWEEN 18 AND 61),
	CHECK(rating BETWEEN 0.0 AND 10.0),
)
GO

CREATE TABLE AircraftType
(
	id INT PRIMARY KEY IDENTITY,
	[type_name] NVARCHAR(30) UNIQUE NOT NULL,
)
GO

CREATE TABLE Airport
(
	id INT PRIMARY KEY IDENTITY,
	airport_name NVARCHAR(70) UNIQUE NOT NULL,
	country NVARCHAR(100) UNIQUE NOT NULL,
)
GO

CREATE TABLE Aircraft 
(
	id INT PRIMARY KEY IDENTITY,
	manufacturer NVARCHAR(25) NOT NULL,
	model NVARCHAR(30) NOT NULL,
	[year] INT NOT NULL,
	flight_hours INT NULL,
	condition CHAR(1) NOT NULL,
	aircraft_type_id INT NOT NULL,
	
	FOREIGN KEY (aircraft_type_id) REFERENCES AircraftType(id),
)
GO

CREATE TABLE FlightDestination
(
	flight_destination_id INT PRIMARY KEY IDENTITY,
	airport_id INT NOT NULL,
	[start] DATETIME NOT NULL,
	aircraft_id INT NOT NULL,
	passenger_id INT NOT NULL,
	ticket_price DECIMAL(18, 2) NOT NULL,
	first_pilot_id INT NOT NULL,
	second_pilot_id INT NOT NULL,

	FOREIGN KEY (airport_id) REFERENCES Airport(id),
	FOREIGN KEY (aircraft_id) REFERENCES Aircraft(id),
	FOREIGN KEY (passenger_id) REFERENCES Passenger(id),
	FOREIGN KEY (first_pilot_id) REFERENCES Pilot(id),
	FOREIGN KEY (second_pilot_id) REFERENCES Pilot(id),
)
