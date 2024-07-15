# Write your MySQL query statement below
Select d.name as Department, e.name as Employee, e.salary as Salary
From
    ( Select *, DENSE_RANK() Over (Partition by departmentId Order by salary desc) as SalaryRank
      From Employee ) as e
JOIN Department as d ON e.departmentId = d.id
Where SalaryRank <= 3
Order by d.name, e.salary desc;