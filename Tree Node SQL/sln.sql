--#1
select max(salary) as SecondHighestSalary 
from employee
where salary < (select max(salary) from employee);


--#
select max(a.salary) as SecondHighestSalary 
from employee a, employee b
where a.salary < b.salary;

