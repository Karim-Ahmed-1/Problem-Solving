select max(a.salary) as SecondHighestSalary 
from employee a, employee b
where a.salary < b.salary;