-- Створення бази даних "Готель"
CREATE DATABASE HotelSystemDbFirst;
GO

-- Використання бази даних "Готель"
USE HotelSystemDbFirst
GO

-- Таблиця "User"
CREATE TABLE Users (
   UserId INT PRIMARY KEY,
   FirstName VARCHAR(255),
   LastName VARCHAR(255),
   Email VARCHAR(255),
   Username VARCHAR(255),
   Password VARCHAR(255)
);

-- Таблиця "Rooms" (Номери)
CREATE TABLE Rooms (
   RoomId INT PRIMARY KEY,
   RoomNumber VARCHAR(255),
   RoomType VARCHAR(255),
   Price DECIMAL(10, 2),
   UserId INT UNIQUE,
   FOREIGN KEY (UserId) REFERENCES Users(UserId)
);

-- Таблиця "Bookings" (Бронювання)
CREATE TABLE Bookings (
   BookingId INT PRIMARY KEY,
   UserId INT,
   RoomId INT,
   CheckInDate DATE,
   CheckOutDate DATE,
   FOREIGN KEY (UserId) REFERENCES Users(UserId),
   FOREIGN KEY (RoomId) REFERENCES Rooms(RoomId)
);

-- Таблиця "Services" (Послуги)
CREATE TABLE Services (
   ServiceId INT PRIMARY KEY,
   ServiceName VARCHAR(255),
   Description VARCHAR(255),
   Price DECIMAL(10, 2)
);

-- Таблиця "Booking_Services" (Бронювання_Послуги)
CREATE TABLE Booking_Services (
   Id INT PRIMARY KEY,
   BookingId INT,
   ServiceId INT,
   Quantity INT,
   FOREIGN KEY (BookingId) REFERENCES Bookings(BookingId),
   FOREIGN KEY (ServiceId) REFERENCES Services(ServiceId)
);

-- Таблиця "Employees" (Працівники)
CREATE TABLE Employees (
   EmployeeId INT PRIMARY KEY,
   FirstName VARCHAR(255),
   LastName VARCHAR(255),
   Position VARCHAR(255)
);

-- Таблиця "Employee_Rooms" (Працівник_Номери)
CREATE TABLE Employee_Rooms (
   EmployeeRoomsId INT PRIMARY KEY,
   EmployeeId INT,
   RoomId INT,
   FOREIGN KEY (EmployeeId) REFERENCES Employees(EmployeeId),
   FOREIGN KEY (RoomId) REFERENCES Rooms(RoomId)
);

-- Таблиця "Payments" (Оплати)
CREATE TABLE Payments (
   PaymentId INT PRIMARY KEY,
   BookingId INT,
   Amount DECIMAL(10, 2),
   PaymentDate DATE,
   FOREIGN KEY (BookingId) REFERENCES Bookings(BookingId)
);

-- Таблиця "Amenities" (Зручності)
CREATE TABLE Amenities (
   AmenityId INT PRIMARY KEY,
   Name VARCHAR(255),
   Description VARCHAR(255)
);

-- Таблиця "RoomAmenity" (Зв'язок між Номерами та Зручностями)
CREATE TABLE RoomAmenity (
   RoomId INT,
   AmenityId INT,
   PRIMARY KEY (RoomId, AmenityId),
   FOREIGN KEY (RoomId) REFERENCES Rooms(RoomId),
   FOREIGN KEY (AmenityId) REFERENCES Amenities(AmenityId)
);

-- Таблиця "Reviews" (Відгуки)
CREATE TABLE Reviews (
   ReviewId INT PRIMARY KEY,
   UserId INT,
   Rating INT,
   Comment VARCHAR(255),
   ReviewDate DATE,
   FOREIGN KEY (UserId) REFERENCES Users(UserId)
);
