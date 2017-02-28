SELECT DISTINCT City FROM STATION 
WHERE RIGHT(City,1) IN ('a', 'e', 'i', 'o', 'u') AND LEFT(City,1) IN ('a', 'e', 'i', 'o', 'u');