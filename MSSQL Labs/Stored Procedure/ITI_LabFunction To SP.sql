
------------------------------------ SQLServer Lab Convert All Functions to Sored Procedure ----------------------------------------
--Note: Use ITI DB
-- 1.	 Create a scalar function that takes a date and returns the Month name of that date. test (‘1/12/2009’)
USE ITI_new
GO

CREATE PROC SP_Func_RetMonth  --'1/12/2009'
@date DATE
as
	DECLARE @Month NVARCHAR(50)
	SET @Month = DATENAME(MONTH,@date)
	SELECT @Month





--2. Create a multi-statements table-valued function that takes 2 integers and returns the values between them.

alter PROC SP_Func_MiddleValues --20,30
@FirstVal INT, @SecondVal INT
AS
DECLARE @t TABLE (
	Middle_Value INT
)
	WHILE @FirstVal < @SecondVal-1
	BEGIN
	SET @FirstVal += 1
	
	INSERT INTO @t (Middle_Value)
		SELECT
			@FirstVal
	END
	SELECT * FROM @t



--3. Create a tabled valued function that takes Student No and returns Department Name with Student full name.


CREATE PROC SP_Get_DeptartementName --8
@Std_ID INT
AS
	SELECT
		d.Dept_Name
	   ,s.St_Fname + ' ' + s.St_Lname AS 'Full Name'
	FROM Department d
	JOIN Student s
		ON d.Dept_Id = s.Dept_Id
	WHERE s.St_Id = @Std_ID
	


-- 4.	Create a scalar function that takes Student ID and returns a message to the user (use Case statement)
--        a.	If the first name and Last name are null then display 'First name & last name are null'
--        b.	If the First name is null then display 'first name is null'
--        c.	If the Last name is null then display 'last name is null'
--        d.	Else display 'First name & last name are not null'

CREATE PROC SP_Check_StudentID  --1
@Std_ID INT
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
	SELECT @Result
END



-- 5.	Create a function that takes an integer that represents the format of the Manager hiring date 
--      and displays department name, Manager Name, and hiring date with this format.   


CREATE PROC SP_Represent_Mgr_HiringDate --110
@FormatNo INT
AS
BEGIN
	
		SELECT
			d.Dept_Name
		   ,i.Ins_Name
		   ,CONVERT(NVARCHAR(50), d.Manager_hiredate, @FormatNo)
		FROM Department d
		JOIN Instructor i
			ON d.Dept_Manager = i.Ins_Id
END

-- 6.	Create multi-statements table-valued function that takes a string
--       If string='first name' returns student first name
--       If string='last name' returns student last name 
--       If string='full name' returns Full Name from student table 
--           Note: Use the “ISNULL” function

CREATE PROC SP_Check_StudentName --'last name'
@VarString NVARCHAR(50)
AS
BEGIN
	IF @VarString = 'first name'
	BEGIN
		
			SELECT
				ISNULL(s.St_Fname, 'Empty Name')
			FROM Student s

	END
	ELSE
	IF @VarString = 'last name'
	BEGIN
		
			SELECT
				ISNULL(s.St_Lname, 'Empty Name')
			FROM Student s

	END
	ELSE
	IF @VarString = 'full name'
	BEGIN
		
			SELECT
				ISNULL(s.St_Fname + ' ' + s.St_Lname, 'Empty Name')
			FROM Student s

	END

	
END




--  7.	Write a query that returns the Student No and Student first name without the last char

CREATE PROC SP_GetSTudentWithoutLastChar
as
SELECT
	s.St_Id
   ,SUBSTRING(s.St_Fname, 1, LEN(s.St_Fname) - 1)
FROM Student s

----------------------------------------------------------- Part 2: Use Company DB ------------------------------------

USE Company_SD
GO

-- 1.	Create a function that takes project number and display all employees in this project

CREATE PROC SP_GetAllEmploees_InProject --'100'
@PNum INT
AS
BEGIN
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
	
END


-- Bonus: 
--2.	write a Query that computes the increment in salary that arises if 
--      the salary of employees increased by any value.

-- Declare Two Variables As Table To Save Salary Before Increasing And After Increasing

CREATE TABLE Tbl_AuditSalary
(
	EmpNo INT,
	OldSalary FLOAT ,
	NewSalary FLOAT,
	IncreasingValue FLOAT
)

alter TRIGGER Computing_IncreaseSalary
ON Employee
AFTER UPDATE
AS
BEGIN

DECLARE @EmpNo INT =(SELECT SSN FROM DELETED)
DECLARE @SalaryBefore FLOAT=(SELECT Salary FROM DELETED)
DECLARE @SalaryAfter FLOAT=(SELECT Salary FROM INSERTED)
DECLARE @IncreasingValue FLOAT=@SalaryAfter-@SalaryBefore

INSERT INTO Tbl_AuditSalary VALUES(@EmpNo,@SalaryBefore,@SalaryAfter,@IncreasingValue)
END

UPDATE Employee 
SET Salary+=0.20*Salary
WHERE SSN=21451

SELECT * FROM Tbl_AuditSalary tas






---------------------------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------------








