﻿SELECT DISTINCT city FROM station WHERE Right(CITY,1) NOT IN ('a','A','e','E','i','I','O','o','u','U') AND LEFT(CITY,1) NOT IN ('a','A','e','E','i','I','O','o','u','U');