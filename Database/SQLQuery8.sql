--Find a list of employee and branch names
SELECT first_name AS 'Company Names'
FROM employee
UNION
SELECT branch_name 
FROM branch
UNION
SELECT client_name 
FROM client;

--RULES
-- 1) Both searches must look for the same number of columns
--    i.e. first_name and branch_name only
-- 2) Both seraches must be for same data types

--Find a list of all supllier and client names
SELECT client_name
FROM client
UNION
SELECT supplier_name
FROM branch_supplier;

--Find a list of all clients and branch suppliers' names
SELECT client_name, branch_id
FROM client
UNION
SELECT supplier_name, branch_id
FROM branch_supplier;

--Find a list of all clients and branch suppliers' names
SELECT client_name, client.branch_id
FROM client
UNION
SELECT supplier_name, branch_supplier.branch_id
FROM branch_supplier;

--Find a list of all money spent or earner by the company
SELECT salary
FROM employee
UNION
SELECT total_sales
FROM works_with

INSERT INTO branch VALUES(4,'Buffalo',NULL,NULL)

--Find all branches and the names of their managers
SELECT employee.emp_Id, employee.first_name,employee.last_name,branch.branch_name
FROM employee
FULL OUTER JOIN branch 
ON employee.emp_Id = branch.mgr_id; --Combines all of the rows from the employee table
									--and all of the rows from the branch table where emp_Id = mgr_Id
--Only shows results for employees which are also managers

--Find names of all employees who have
--sold over 30 000 to a single client
SELECT employee.first_name, employee.last_name
FROM employee
WHERE employee.emp_id IN 
	(
	SELECT works_with.emp_id
	FROM works_with
	WHERE works_with.total_sales > 30000
	);

--Find all clients who are handled by the branch
--that Michael Scott manages
--Assume you know Michael's ID

SELECT client.client_name
FROM client
WHERE client.branch_id = 
	(
	SELECT branch.branch_id
	FROM branch
	WHERE branch.mgr_id	= 102
	);

