--problem 
--https://leetcode.com/problems/find-customer-referee/?envType=study-plan&id=sql-i


--sln
SELECT c.name
FROM Customer c
WHERE c.referee_id <> 2 OR c.referee_id  Is NULL