USE Company_SD
GO

----------------------------------------- Answer Lab of Day 4 DQL ---------------------------------------
-- DQL
-- 1.	For each project, list the project name and the total hours per week (for all employees) spent on that project.

SELECT
	e.Fname AS 'Emp Name'
   ,p.Pname AS 'Project Name'
   ,SUM(wf.Hours) / 4 AS 'Total Hours Per Week'
FROM Project p
JOIN Works_for wf
	ON p.Pnumber = wf.Pno
JOIN Employee e
	ON wf.ESSn = e.SSN
GROUP BY e.Fname
		,p.Pname

-- 2.	Display the data of the department which has the smallest employee ID over all employees' ID.

SELECT
	d.Dname
   ,d.Dnum
   ,d.MGRSSN
   ,D.[MGRStart Date]
   ,e.SSN
FROM Departments d,Employee e
WHERE d.Dnum=e.Dno and e.SSN = (SELECT
		MIN(e1.SSN)
	FROM Employee e1)

-- 3.	For each department, retrieve the department name and the maximum, minimum and average salary of its employees.

SELECT
	d.Dname 'Dept Name'
   ,MAX(e.Salary) AS 'Max Salary'
   ,MIN(e.Salary) AS 'Min Salary'
   ,AVG(e.Salary) AS 'Avarage Salary'
FROM Departments d
	,Employee e
WHERE d.Dnum = e.Dno
GROUP BY d.Dname

-- 4.	List the last name of all managers who have no dependents.

SELECT DISTINCT
	e.Lname
FROM Employee e
JOIN Departments d
	ON e.SSN = d.MGRSSN
JOIN Dependent d1
	ON D.MGRSSN != d1.ESSn

-- 5.	For each department-- if its average salary is less than the average salary of all employees
-- display its number, name and number of its employees.

SELECT
	d.Dnum
   ,d.Dname
   ,COUNT(e.SSN) AS 'Number of Emp'
   ,AVG(e.Salary) AS 'Average Salary Employees'
FROM Departments d
	,Employee e
WHERE d.Dnum = e.Dno
GROUP BY d.Dnum
		,d.Dname
HAVING AVG(e.Salary) < (SELECT
		AVG(e1.Salary)
	FROM Employee e1)

-- 6.	Retrieve a list of employees and the projects they are working on ordered by department and within each department, 
--      ordered alphabetically by last name, first name.

SELECT
	e.*
   ,p.Pname
FROM Employee e
JOIN Works_for wf
	ON e.SSN = wf.ESSn
JOIN Project p
	ON wf.Pno = p.Pnumber
ORDER BY e.Dno, e.Lname, e.Fname

-- 7.	Try to update all salaries of employees who work in Project ‘Al Rabwah’ by 30% 

-- First Method Sub Query

UPDATE Employee
SET Salary += Salary * 0.30
WHERE Employee.SSN = (SELECT
		wf.ESSn
	FROM Employee e
	JOIN Works_for wf
		ON e.SSN = wf.ESSn
	JOIN Project p
		ON wf.Pno = p.Pnumber
	WHERE p.Pname = 'Al Rabwah')

-- Second Method Advanced Sub Query

UPDATE Employee
SET Salary += Salary * 0.30
FROM Employee e
JOIN Works_for wf
	ON e.SSN = wf.ESSn
JOIN Project p
	ON wf.Pno = p.Pnumber
WHERE p.Pname = 'Al Rabwah'


-- 8.	Display the employee number and name if at least one of them have dependents (use exists keyword) self-study.
SELECT
	e.SSN
   ,e.Fname
FROM Employee e
WHERE EXISTS (SELECT
		e1.Fname
	FROM Employee e1
		,Dependent d
	WHERE e1.SSN = d.ESSn
	
	)
