--problem
-- https://leetcode.com/problems/customers-who-never-order/?envType=study-plan&id=sql-i

--sln
select customers.name as Customers from customers
left join orders
on customers.id = orders.customerid
where orders.customerid is null;