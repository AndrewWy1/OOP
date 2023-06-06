-- ��������� ���� ����� "������"
CREATE DATABASE HotelSystemDbFirst;
GO

-- ������������ ���� ����� "������"
USE HotelSystemDbFirst
GO

-- ������� "User"
CREATE TABLE Users (
   UserId INT PRIMARY KEY,
   FirstName VARCHAR(255),
   LastName VARCHAR(255),
   Email VARCHAR(255),
   Username VARCHAR(255),
   Password VARCHAR(255)
);

-- ������� "Rooms" (������)
CREATE TABLE Rooms (
   RoomId INT PRIMARY KEY,
   RoomNumber VARCHAR(255),
   RoomType VARCHAR(255),
   Price DECIMAL(10, 2),
   UserId INT UNIQUE,
   FOREIGN KEY (UserId) REFERENCES Users(UserId)
);

-- ������� "Bookings" (����������)
CREATE TABLE Bookings (
   BookingId INT PRIMARY KEY,
   UserId INT,
   RoomId INT,
   CheckInDate DATE,
   CheckOutDate DATE,
   FOREIGN KEY (UserId) REFERENCES Users(UserId),
   FOREIGN KEY (RoomId) REFERENCES Rooms(RoomId)
);

-- ������� "Services" (�������)
CREATE TABLE Services (
   ServiceId INT PRIMARY KEY,
   ServiceName VARCHAR(255),
   Description VARCHAR(255),
   Price DECIMAL(10, 2)
);

-- ������� "Booking_Services" (����������_�������)
CREATE TABLE Booking_Services (
   Id INT PRIMARY KEY,
   BookingId INT,
   ServiceId INT,
   Quantity INT,
   FOREIGN KEY (BookingId) REFERENCES Bookings(BookingId),
   FOREIGN KEY (ServiceId) REFERENCES Services(ServiceId)
);

-- ������� "Employees" (����������)
CREATE TABLE Employees (
   EmployeeId INT PRIMARY KEY,
   FirstName VARCHAR(255),
   LastName VARCHAR(255),
   Position VARCHAR(255)
);

-- ������� "Employee_Rooms" (���������_������)
CREATE TABLE Employee_Rooms (
   EmployeeRoomsId INT PRIMARY KEY,
   EmployeeId INT,
   RoomId INT,
   FOREIGN KEY (EmployeeId) REFERENCES Employees(EmployeeId),
   FOREIGN KEY (RoomId) REFERENCES Rooms(RoomId)
);

-- ������� "Payments" (������)
CREATE TABLE Payments (
   PaymentId INT PRIMARY KEY,
   BookingId INT,
   Amount DECIMAL(10, 2),
   PaymentDate DATE,
   FOREIGN KEY (BookingId) REFERENCES Bookings(BookingId)
);

-- ������� "Amenities" (��������)
CREATE TABLE Amenities (
   AmenityId INT PRIMARY KEY,
   Name VARCHAR(255),
   Description VARCHAR(255)
);

-- ������� "RoomAmenity" (��'���� �� �������� �� �����������)
CREATE TABLE RoomAmenity (
   RoomId INT,
   AmenityId INT,
   PRIMARY KEY (RoomId, AmenityId),
   FOREIGN KEY (RoomId) REFERENCES Rooms(RoomId),
   FOREIGN KEY (AmenityId) REFERENCES Amenities(AmenityId)
);

-- ������� "Reviews" (³�����)
CREATE TABLE Reviews (
   ReviewId INT PRIMARY KEY,
   UserId INT,
   Rating INT,
   Comment VARCHAR(255),
   ReviewDate DATE,
   FOREIGN KEY (UserId) REFERENCES Users(UserId)
);
