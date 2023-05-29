USE Airport

DELETE FROM Passenger
WHERE LEN(full_name) <= 10