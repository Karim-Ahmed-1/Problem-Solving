-- Problem :
-- https://leetcode.com/problems/big-countries/?envType=study-plan&id=sql-i
-----------------------------------------------------------

--solution :
SELECT w.name,w.population,w.area
FROM World AS w
WHERE w.area >= 3000000 OR w.population>= 25000000