--problem
--https://leetcode.com/problems/recyclable-and-low-fat-products/?envType=study-plan&id=sql-i

--solution
select product_id
from products
where low_fats = 'Y' and recyclable = 'Y'