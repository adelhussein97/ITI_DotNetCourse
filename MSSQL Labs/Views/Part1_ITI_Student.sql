
--------------------------------- Part1:Use ITI DB --------------------------------------------
USE ITI_new
GO
-----------------------------------------------------------------------------------------------
-- 1. Create a view that displays the student’s full name, course name if the student has a grade of more than 50.
CREATE VIEW Display_Students
AS
SELECT
	s.St_Fname + ' ' + s.St_Lname AS 'Full Name'
   ,c.Crs_Name 'Course Name'
FROM Student s
JOIN Stud_Course sc
	ON s.St_Id = sc.St_Id
JOIN Course c
	ON sc.Crs_Id = c.Crs_Id
WHERE sc.Grade > 50

SELECT
	*
FROM Display_Students ds

-- 2. Create an Encrypted view that displays manager names and the topics they teach. 

CREATE VIEW Display_MAnager
WITH ENCRYPTION
AS
SELECT DISTINCT
	i.Ins_Name
   ,t.Top_Name
FROM Department d
JOIN Instructor i
	ON d.Dept_Manager = i.Ins_Id
JOIN Ins_Course ic
	ON i.Ins_Id = ic.Ins_Id
JOIN Course c
	ON ic.Crs_Id = c.Crs_Id
JOIN Topic t
	ON c.Top_Id = t.Top_Id

SELECT
	*
FROM Display_MAnager dm

-- 3. Create a view that will display Instructor Name, Department Name for the ‘SD’ or ‘Java’ Department “.

CREATE VIEW Display_All_Instructor_SD_Java
AS
SELECT
	i.Ins_Name
   ,d.Dept_Name
FROM Department d
JOIN Instructor i
	ON d.Dept_Id = i.Dept_Id
WHERE d.Dept_Name IN ('SD', 'Java')

SELECT
	*
FROM Display_All_Instructor_SD_Java dm

-- 4.	Create a view “V1” that displays student data for the student who lives in Alex or .
/* Display student data in Alex and Cairo 
Note: Prevent the users to run the following query 
Update V1 
set st_address=’tanta’ 
Where st_address=’alex’;
*/
CREATE VIEW V1
AS
SELECT
	*
FROM Student s
WHERE s.St_Address IN ('Alex', 'Cairo')
WITH CHECK OPTION

SELECT
	*
FROM V1 v

UPDATE V1
SET St_Address = 'tanta'
WHERE St_Address = 'alex'   -- error result 

-- 5.	Create a temporary table [Session based] on Company DB to save employee name and his today task.


CREATE TABLE Company_SD.#Temp_Tbl (
	EmpID INT NOT NULL
   ,Emp_Name NVARCHAR(MAX)
   ,Task_Name NVARCHAR(MAX)
)

INSERT INTO #Temp_Tbl
	SELECT TOP (1)
		e.SSN
	   ,e.Fname + ' ' + e.Lname
	   ,'Ending Task Today View & Temporary Table'
	FROM Company_SD.dbo.Employee e

SELECT
	*
FROM #Temp_Tbl

------------------------------------------------- Part2:Use CompanyDB ---------------------------------------------

USE Company_SD
GO
--1.  Create a view that will display the project name and the number of employees works on it.

CREATE VIEW Display_Project_EmployeesID
AS
SELECT
	p.Pname
   ,wf.ESSn
FROM Project p
	,Works_for wf
WHERE p.Pnumber = wf.Pno

SELECT
	*
FROM Display_Project_EmployeesID

-- 2)	Create a view named   “v_D30” that will display employee number, project number,
--     hours of the projects in department 30.

CREATE VIEW v_D30
AS
SELECT
	wf.ESSn
   ,p.Pnumber
   ,wf.Hours
FROM Project p
	,Works_for wf
WHERE p.Pnumber = wf.Pno
AND p.Dnum = 30

SELECT
	*
FROM v_D30 vd

-- 3)	Create a view named  “v_count “ that will display the project name and the number of hours for each one. 

CREATE VIEW v_count
AS
SELECT
	p.Pname
   ,sum(wf.Hours) AS 'Number of Hours'
FROM Project p
	,Works_for wf
WHERE p.Pnumber = wf.Pno
GROUP BY p.Pname

SELECT
	*
FROM v_count vc

-- 4)	Create a view named ” v_project_500” that will display the emp no. 
--      for the project 500, use the previously created view  “v_D30”


CREATE VIEW v_project_500
AS
SELECT
	vd.ESSn
FROM v_D30 vd
WHERE vd.Pnumber = 500

SELECT
	*
FROM v_project_500

-- 5)	modify the view named  “v_without_budget”  to display all DATA in project 300 and 400

-- First create view named “v_without_budget”  to display all DATA in project
CREATE VIEW v_without_budget
AS
SELECT
	*
FROM Project p

-- Secondly Modify Structure View named “v_without_budget”  to PNumber 300 and 400
ALTER VIEW v_without_budget
AS
SELECT
	*
FROM Project p
WHERE p.Pnumber IN (300, 400)

SELECT
	*
FROM v_without_budget vwb

--6)	Delete the views  “v_D30” and “v_count”

DROP VIEW v_D30, v_count


---------------------------------------------------- Part 3 New Data Type -----------------------------------

-- 1.	Make a rule that makes sure the value is less than 1000 then bind it on the Salary in Employee table.

CREATE RULE Salary1000 AS @Salary < 1000

SP_BINDRULE Salary1000 , 'Employee.Salary'

--------------------------------------------------------------------------------------------------------------
USE Company_SD
GO
-- 2.	Create a new user data type named loc with the following Criteria:
-- •	nchar(2)
-- •	default: NY 
-- •	create a rule for this Datatype :values in (NY,DS,KW)) and associate it to the location column

--1st step Create Type
CREATE TYPE loc FROM NCHAR(2)

--2nd step create Rule Default
CREATE DEFAULT DefLoc AS 'NY'

-- 3rd step Bind Default To Type
SP_BINDEFAULT DefLoc , loc

-- 4th step create rule to check values
CREATE RULE CheckVal AS @Val IN ('NY', 'DS', 'KW')

-- 5th bind rule to type loc
SP_BINDRULE CheckVal,loc

-- finally create new table and create Lcoation fron new type loc

-- Two Opinion to apply UDD 1. Apply on column of project or create new table 
SP_BINDEFAULT DefLoc,'Project.PLocation'
SP_BINDRULE CheckVal,'Project.PLocation'

-- second solve of UDD

CREATE TABLE test (
	ID INT IDENTITY (1, 1)
   ,Plocation loc
   ,CName NVARCHAR(50)
)

-------------------------------------------------------------------------------------------------------
USE ITI_new
GO
-- 3.	Create a New table Named newStudent, and use the new UDD on it you just have made and ID column 
--      and don’t make it identity.

CREATE TABLE newStudent (
	ID INT NOT NULL
   ,Std_Location loc
)

---------------------------------------------------------------------------------------------------------

-- 4.	Create a new sequence for the ID values of the previous table.
-- 1st create sequence firstly 

CREATE SEQUENCE [dbo].[SequenceObject]
AS INT
START WITH 1
INCREMENT BY 1

--a.	Insert 3 records in the table using the sequence.

INSERT INTO newStudent (ID, Std_Location)
	VALUES (NEXT VALUE FOR SequenceObject, 'KW');
INSERT INTO newStudent (ID, Std_Location)
	VALUES (NEXT VALUE FOR SequenceObject, 'NY');
INSERT INTO newStudent (ID, Std_Location)
	VALUES (NEXT VALUE FOR SequenceObject, 'DS');

SELECT
	*
FROM newStudent s

-- b.	Delete the second row of the table.
DELETE newStudent
WHERE ID = 2

-- c.	Insert 2 other records using the sequence.
INSERT INTO newStudent (ID, Std_Location)
	VALUES (NEXT VALUE FOR SequenceObject, 'KW');
INSERT INTO newStudent (ID, Std_Location)
	VALUES (NEXT VALUE FOR SequenceObject, 'NY');

SELECT
	*
FROM newStudent s

--d.	Can you insert another record without using the sequence? Try it!
--      Can you do the same if it was an identity column?
INSERT INTO newStudent (Std_Location)
	VALUES ('KW');

--e.	Can you edit the value if the ID column in any of the inserted records? Try it!
--      Can you do the same if it was an identity column?

UPDATE newStudent
SET ID = 3
WHERE ID = 5

/*
f.	Can you use the same sequence to insert in another table?
g.	If yes, do you think that the sequence will start from its initial value in the new table and insert the same IDs that were inserted in the old table?

*/
CREATE TABLE test_seq (
	ID INT
   ,Name NVARCHAR(50)
)

INSERT INTO test_seq (ID, Name)
	VALUES (NEXT VALUE FOR SequenceObject, 'Adel');

SELECT
	*
FROM test_seq ts

SELECT
	NEXT VALUE FOR SequenceObject

/*
h.	How to skip some values from the sequence not to be inserted in the table? Try it.
    Can you do the same with the Identity column?

>>>>> Answer : using min , max value and cycle to reset the value when reach max value 

*/

CREATE SEQUENCE [dbo].[ResetSequence]
AS INT
START WITH 1
INCREMENT BY 1
MINVALUE 1
MAXVALUE 3
CYCLE





    