--Find the number of employees
SELECT COUNT(emp_id)
FROM employee;

--Find the number of employees with supervisor
SELECT count(super_id)
FROM employee;

--Find the number of female employees born after 1970
SELECT COUNT(emp_id)
FROM employee
WHERE sex ='F' AND birth_day >= '1971-01-01';

--Find the average of all employees salary
SELECT AVG(salary)
FROM employee;

--Find the average of all male employees
SELECT AVG(salary)
FROM employee
WHERE sex = 'M';

--Find the sum of all employees salary
SELECT SUM(salary)
FROM employee;

--Aggregation
--Find out how many males and females there are
SELECT COUNT(sex) AS 'Number of employees', sex AS 'Sex' 
FROM employee
GROUP BY sex;

--Find the total sales of each salesman
SELECT SUM(total_sales) AS 'Total Sales', emp_id
FROM works_with
GROUP BY emp_id



