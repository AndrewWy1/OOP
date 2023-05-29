USE Airport

UPDATE Aircraft
SET condition = 'A'
WHERE (condition = 'C' OR condition = 'B') AND (flight_hours IS NULL OR flight_hours <= 101) AND ([year] >= 2013)