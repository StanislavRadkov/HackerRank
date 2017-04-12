SELECT Name + '(' + LEFT(Occupation , 1) + ')' 
FROM Occupations
ORDER BY Name

DECLARE @a AS VARCHAR(50);
SET @a = 'There are total ';

SELECT @a + CONVERT(varchar(10), COUNT(*)) + ' ' + LOWER(Occupation) + 's.'
FROM Occupations
GROUP BY Occupation    
ORDER BY COUNT(*) ASC, Occupation ASC