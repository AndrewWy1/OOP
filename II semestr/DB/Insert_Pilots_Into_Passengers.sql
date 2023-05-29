USE Airport

INSERT INTO  Passenger(full_name, email)
SELECT first_name + ' ' + last_name, first_name + last_name + '@gmail.com'
FROM Pilot
WHERE pilot_id BETWEEN 5 AND 15
