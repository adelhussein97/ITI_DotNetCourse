-USE Company_SD
GO
-----***************************************************************************************-----
--1. Display all the employees Data
BEGIN

	SELECT
		*
	FROM Employee;

END
--2. Display the employee First name, last name, Salary and Department number.

BEGIN

	SELECT
		e.Fname
	   ,e.Lname
	   ,e.Salary
	   ,d.Dnum
	FROM Employee e
		,Departments d
	WHERE d.Dnum = e.Dno


END

--3.	Display all the projects names, locations and the department which is responsible about it

BEGIN

	SELECT
		p.Pname
	   ,p.Plocation
	   ,d.Dname
	FROM Project p
	INNER JOIN Departments d
		ON d.Dnum = p.Dnum

END
/*
4.If you know that the company policy is to pay an annual commission for each employee 
with specific percent equals 10% of his/her annual salary 
.Display each employee full name and his annual commission in an ANNUAL COMM column (alias).
*/

BEGIN

	SELECT
		e.Fname + ' ' + e.Lname 'FULL Name'
	   ,(e.Salary * 12 * 0.10) 'Annual Comm'
	FROM Employee e

END

--5.	Display the employees Id, name who earns more than 1000 LE monthly.

BEGIN

	SELECT
		e.SSN
	   ,e.Fname
	FROM Employee e
	WHERE e.Salary > 1000

END

-- 6.	Display the employees Id, name who earns more than 10000 LE annually.

BEGIN

	SELECT
		e.SSN
	   ,e.Fname
	FROM Employee e
	WHERE (e.Salary * 12) > 10000

END

--7.	Display the names and salaries of the female employees 

BEGIN

	SELECT
		e.Fname
	   ,e.Salary
	FROM Employee e
	WHERE e.Sex = 'F'

END

--8.	Display each department id, name which managed by a manager with id equals 968574.

BEGIN

	SELECT
		d.Dnum
	   ,e.Fname
	FROM Departments d
	INNER JOIN Employee e
		ON e.SSN = d.MGRSSN
	WHERE d.MGRSSN = 968574

END

--9.	Dispaly the ids, names and locations of  the pojects which controled with department 10.

BEGIN

	SELECT
		p.Pnumber 'Project ID'
	   ,p.Pname 'Project Name'
	   ,p.Plocation 'Project Location'
	FROM Project p
	INNER JOIN Departments d
		ON d.Dnum = p.Dnum
	WHERE d.Dnum = 10

END

--10.	Display the Department id, name and id and the name of its manager.

BEGIN

	SELECT
		d.Dnum 'Dapt Number'
	   ,d.Dname 'Dapartment Name'
	   ,e.SSN 'Manager ID'
	   ,e.Fname 'MAnager Name'
	FROM Departments d
		,Employee e
	WHERE e.SSN = d.MGRSSN

END

-- 11.	Display the name of the departments and the name of the projects under its control.

BEGIN

	SELECT
		d.Dname
	   ,p.Pname
	FROM Departments d
		,Project p
	WHERE d.Dnum = p.Dnum


END

-- 12.	Display the full data about all the dependence associated with the name of the employee they depend on him/her.

BEGIN

	SELECT
		d.*
	FROM Employee e
	INNER JOIN Dependent d
		ON e.SSN = d.ESSN

END

--13.	Display the Id, name and location of the projects in Cairo or Alex city.

BEGIN
	-- IN
	SELECT
		p.Pnumber
	   ,p.Pname
	   ,p.Plocation
	FROM Project p
	WHERE p.City IN ('Cairo', 'Alex')

	-- OR
	SELECT
		p.Pnumber
	   ,p.Pname
	   ,p.Plocation
	FROM Project p
	WHERE p.City = 'Cairo'
	OR p.City = 'Alex'


END

-- 14.	Display the Projects full data of the projects with a name starts with "a" letter.

BEGIN

	SELECT
		*
	FROM Project p
	WHERE p.Pname LIKE 'a%'

END

--15.	display all the employees in department 30 whose salary from 1000 to 2000 LE monthly

BEGIN

	-- Between
	SELECT
		*
	FROM Employee e
		,Departments d
	WHERE d.Dnum = e.Dno
	AND d.Dnum = 30
	AND e.Salary BETWEEN 1000 AND 2000

	--OR Inner Join
	SELECT
		*
	FROM Employee e
	INNER JOIN Departments d
		ON d.Dnum = e.Dno
	WHERE d.Dnum = 30
	AND e.Salary BETWEEN 1000 AND 2000

	-- Or Using >= and <=
	SELECT
		*
	FROM Employee e
	INNER JOIN Departments d
		ON d.Dnum = e.Dno
	WHERE d.Dnum = 30
	AND e.Salary >= 1000
	AND e.Salary <= 2000

END

/* 16.	Retrieve the names of all employees in department 10 who works more than 
or equal 10 hours per week on "AL Rabwah" project. */
BEGIN

	SELECT
		e.*
	   ,wf.Hours
	   ,p.Pname
	FROM Departments d
	INNER JOIN Employee e
		ON d.MGRSSN = e.SSN
			AND d.Dnum = e.Dno
	INNER JOIN Project p
		ON d.Dnum = p.Dnum
	INNER JOIN Works_for wf
		ON p.Pnumber = wf.Pno
			AND e.SSN = wf.ESSN
	WHERE d.Dnum = 10
	AND wf.Hours >= 10
	AND p.Pname = 'AL Rabwah'

END

--17.	Find the names of the employees who directly supervised with Kamel Mohamed.

BEGIN

	SELECT
		emp.*
	FROM Employee Supervisor
	JOIN Employee emp
		ON Supervisor.SSN = emp.Superssn
	WHERE Supervisor.Fname = 'Kamel'
	AND Supervisor.Lname = 'Mohamed'

END

-- 18.	Retrieve the names of all employees and the names of the projects they are working on, sorted by the project name.

BEGIN

	SELECT
		e.Fname + ' ' + e.Lname 'Full Name'
	   ,p.Pname 'Project Name'
	FROM Employee e
	INNER JOIN Works_for wf
		ON e.SSN = wf.ESSN
	INNER JOIN Project p
		ON p.Pnumber = wf.Pno
	ORDER BY p.Pname

END

/*19.	For each project located in Cairo City , find the project number, the controlling department name 
,the department manager last name ,address and birthdate.*/

BEGIN

	SELECT
		p.Pnumber
	   ,d.Dname
	   ,e.Lname
	   ,e.[Address]
	   ,e.Bdate
	FROM Project p
	INNER JOIN Departments d
		ON p.Dnum = d.Dnum
	INNER JOIN Employee e
		ON d.MGRSSN = e.SSN
	WHERE p.City = 'Cairo'

END

-- 20.	Display All Data of the mangers

BEGIN

	SELECT
		e.*
	FROM Employee e
		,Departments d
	WHERE e.SSN = d.MGRSSN

--SELECT
--	*
--FROM Employee e
--WHERE e.Superssn IS NULL

END


/*21.	Display All Employees data and the data of their dependents even if they have no dependents*/

BEGIN

	SELECT
		*
	FROM Employee e
	LEFT OUTER JOIN Dependent d
		ON e.SSN = d.ESSN
END


------**************************************  Part Two DML *********************************************-------------

/*
Data Manipulating Language:

1.	Insert your personal data to the employee table as a new employee in department number 30, SSN = 102672, Superssn = 112233, salary=3000.

*/

BEGIN

	INSERT INTO Employee (Fname, Lname, SSN, Bdate, Address, Sex, Salary, Superssn, Dno)
		VALUES (N'Adel', N'Hussein', 102672, GETDATE(), N'Beni Suef', N'M', 3000, 112233, 30);

END

/*
2.	Insert another employee with personal data your friend as new employee in department number 30, SSN = 102660,
but don’t enter any value for salary or manager number to him.
*/


BEGIN


	INSERT INTO Employee (Fname, Lname, SSN, Bdate, Address, Sex, Dno)
		VALUES (N'Mazin', N'Adel', 102660, GETDATE(), N'Beni Suef', N'M', 30);

END

-- 3.	Upgrade your salary by 20 % of its last value.


BEGIN

	UPDATE Employee
	SET Salary = Salary + (Salary * 0.20)
	WHERE SSN = 102672


END

-- Confirm data Upgrade salary to 20%

SELECT
	*
FROM Employee e
WHERE e.SSN = 102672




--- Self Study  (delete all employees who have more than two dependant )

DELETE FROM Employee
WHERE SSN = ANY (SELECT
			d.ESSN
		FROM Dependent d
		GROUP BY d.ESSN
		HAVING COUNT(d.Dependent_name) > 2)

























