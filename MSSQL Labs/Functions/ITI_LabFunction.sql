
------------------------------------ SQLServer Lab ----------------------------------------
--Note: Use ITI DB
-- 1.	 Create a scalar function that takes a date and returns the Month name of that date. test (‘1/12/2009’)
USE ITI_new
GO

alter FUNCTION Func_RetMonth (@date DATE)
RETURNS NVARCHAR(50)
AS
BEGIN
	DECLARE @Month NVARCHAR(50)
	SET @Month = DATENAME(MONTH,@date)
	RETURN @Month
END

SELECT
	dbo.Func_RetMonth(GETDATE())
SELECT
	dbo.Func_RetMonth('2009-12-01')
SELECT
	dbo.Func_RetMonth('1/12/2009')



--2. Create a multi-statements table-valued function that takes 2 integers and returns the values between them.

alter FUNCTION Func_MiddleValues (@FirstVal INT, @SecondVal INT)
RETURNS @t TABLE (
	Middle_Value INT
)
AS
BEGIN
	WHILE @FirstVal < @SecondVal-1
	BEGIN
	SET @FirstVal += 1
	--IF @FirstVal = @SecondVal
	--	BREAK
	INSERT INTO @t (Middle_Value)
		SELECT
			@FirstVal
	END
	RETURN
END

SELECT
	*
FROM dbo.Func_MiddleValues(20, 50)


--3. Create a tabled valued function that takes Student No and returns Department Name with Student full name.


CREATE FUNCTION Get_DeptartementName (@Std_ID INT)
RETURNS TABLE
AS
	RETURN
	(

	SELECT
		d.Dept_Name
	   ,s.St_Fname + ' ' + s.St_Lname AS 'Full Name'
	FROM Department d
	JOIN Student s
		ON d.Dept_Id = s.Dept_Id
	WHERE s.St_Id = @Std_ID
	)

SELECT
	*
FROM dbo.Get_DeptartementName(8)

-- 4.	Create a scalar function that takes Student ID and returns a message to the user (use Case statement)
--        a.	If the first name and Last name are null then display 'First name & last name are null'
--        b.	If the First name is null then display 'first name is null'
--        c.	If the Last name is null then display 'last name is null'
--        d.	Else display 'First name & last name are not null'

CREATE FUNCTION Check_StudentID (@Std_ID INT)
RETURNS NVARCHAR(MAX)
AS
BEGIN

	DECLARE @FirstName NVARCHAR(50)
	DECLARE @LastName NVARCHAR(50)
	DECLARE @Result NVARCHAR(MAX)
	SELECT
		@FirstName = s.St_Fname
	   ,@LastName = s.St_Lname
	FROM Student s
	WHERE s.St_Id = @Std_ID
	------------------------- Using Case Statement
	SET @Result =
	CASE
		WHEN @FirstName IS NULL AND
			@LastName IS NULL THEN 'First name & last name are null'
		WHEN @FirstName IS NULL AND
			@LastName IS NOT NULL THEN 'first name is null'
		WHEN @FirstName IS NOT NULL AND
			@LastName IS NULL THEN 'last name is null'
		WHEN @FirstName IS NOT NULL AND
			@LastName IS NOT NULL THEN 'First name & last name are not null'
	END
	RETURN @Result
END

SELECT
	dbo.Check_StudentID(9) -- can try 1 or 14 or 9 or 13
SELECT
	*
FROM Student s

-- 5.	Create a function that takes an integer that represents the format of the Manager hiring date 
--      and displays department name, Manager Name, and hiring date with this format.   


CREATE FUNCTION Represent_Mgr_HiringDate (@FormatNo INT)
RETURNS @tbl TABLE (
	Dept_Name NVARCHAR(50)
   ,Manager_Name NVARCHAR(50)
   ,Hiring_Date NVARCHAR(50)
)
AS
BEGIN
	INSERT INTO @tbl
		SELECT
			d.Dept_Name
		   ,i.Ins_Name
		   ,CONVERT(NVARCHAR(50), d.Manager_hiredate, @FormatNo)
		FROM Department d
		JOIN Instructor i
			ON d.Dept_Manager = i.Ins_Id
	RETURN
END

SELECT
	*
FROM dbo.Represent_Mgr_HiringDate(109) -- can try 109 / 110 / 111 ...etc


-- 6.	Create multi-statements table-valued function that takes a string
--       If string='first name' returns student first name
--       If string='last name' returns student last name 
--       If string='full name' returns Full Name from student table 
--           Note: Use the “ISNULL” function

CREATE FUNCTION Check_StudentName (@VarString NVARCHAR(50))
RETURNS @Tbl TABLE (
	Student_Name NVARCHAR(50)
)
AS
BEGIN
	IF @VarString = 'first name'
	BEGIN
		INSERT INTO @Tbl
			SELECT
				ISNULL(s.St_Fname, 'Empty Name')
			FROM Student s

	END
	ELSE
	IF @VarString = 'last name'
	BEGIN
		INSERT INTO @Tbl
			SELECT
				ISNULL(s.St_Lname, 'Empty Name')
			FROM Student s

	END
	ELSE
	IF @VarString = 'full name'
	BEGIN
		INSERT INTO @Tbl
			SELECT
				ISNULL(s.St_Fname + ' ' + s.St_Lname, 'Empty Name')
			FROM Student s

	END

	RETURN
END

SELECT
	*
FROM dbo.Check_StudentName('full name')


--  7.	Write a query that returns the Student No and Student first name without the last char


SELECT
	s.St_Id
   ,SUBSTRING(s.St_Fname, 1, LEN(s.St_Fname) - 1)
FROM Student s

----------------------------------------------------------- Part 2: Use Company DB ------------------------------------

USE Company_SD
GO

-- 1.	Create a function that takes project number and display all employees in this project

CREATE FUNCTION GetAllEmploees_InProject (@PNum INT)
RETURNS @Tbl TABLE (
	Emp_SSN INT
   ,Emp_FullName NVARCHAR(50)
   ,Project_Name NVARCHAR(50)
)
AS
BEGIN
	INSERT INTO @Tbl
		SELECT
			e.SSN
		   ,e.Fname + ' ' + e.Lname
		   ,p.Pname
		FROM Employee e
		JOIN Works_for wf
			ON e.SSN = wf.ESSn
		JOIN Project p
			ON wf.Pno = p.Pnumber
		WHERE p.Pnumber = @PNum
		ORDER BY p.Pname
	RETURN
END

SELECT
	*
FROM dbo.GetAllEmploees_InProject(100)

-- Bonus: 
--2.	write a Query that computes the increment in salary that arises if 
--      the salary of employees increased by any value.

-- Declare Two Variables As Table To Save Salary Before Increasing And After Increasing

CREATE FUNCTION Get_EmployeesSalaryAfterIncreasing (@IncreaseSalary FLOAT)
RETURNS @Tbl TABLE (
	Emp_SSN INT
   ,Emp_FName NVARCHAR(50)
   ,Emp_Salary_BeforeIncrease FLOAT
   ,Emp_Salary_AfterIncrease FLOAT
   ,ValueSalary_Increase FLOAT
)
AS
BEGIN
	DECLARE @tempBefore TABLE (
		Emp_SSN INT
	   ,Emp_FName NVARCHAR(50)
	   ,Emp_Salary_BeforeIncrease FLOAT
	)
	DECLARE @tempAfter TABLE (
		Emp_SSN INT
	   ,Emp_FName NVARCHAR(50)
	   ,Emp_Salary_AfterIncrease FLOAT
	)
	INSERT INTO @tempBefore
		SELECT
			e.SSN
		   ,e.Fname + ' ' + e.Lname
		   ,e.Salary
		FROM Employee e

	INSERT INTO @tempAfter
		SELECT
			e.SSN
		   ,e.Fname + ' ' + e.Lname
		   ,e.Salary + (e.Salary * @IncreaseSalary)
		FROM Employee e
	INSERT INTO @Tbl
		SELECT
			a.Emp_SSN
		   ,a.Emp_FName
		   ,b.Emp_Salary_BeforeIncrease
		   ,a.Emp_Salary_AfterIncrease
		   ,(a.Emp_Salary_AfterIncrease - b.Emp_Salary_BeforeIncrease)
		FROM @tempBefore b
			,@tempAfter a
		WHERE b.Emp_SSN = a.Emp_SSN
	RETURN
END

SELECT
	*
FROM Employee e

SELECT
	*
FROM Get_EmployeesSalaryAfterIncreasing(0.35)













