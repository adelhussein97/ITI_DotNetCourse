
--------------------------------- SQL Server lab 4  ----------------------------------

--1.  Create a stored procedure to show the number of students per department.[use ITI DB]

CREATE PROC SP_Count_StudentsPerDepartement
AS
	SELECT
		d.Dept_Name
	   ,COUNT(s.St_Id) 'Number of Students Per Dept'
	FROM Department d
	JOIN Student s
		ON d.Dept_Id = s.Dept_Id
	GROUP BY d.Dept_Name

	/* 2.	Create a stored procedure that will check for the # of employees in the project p1=100
			if they are more than 3 print a message to the user “'The number of employees in the project p1 is 3 or more'”
			if they are less display a message to the user “'The following employees work for the project p1'” 
			in addition to the first name and last name of each one. [Company DB] 
	*/

	CREATE PROC SP_CheckNumberOFEmploees
	AS
		DECLARE @CountEmp INT
			   ,@RESULT NVARCHAR(MAX)

		SELECT
			@CountEmp = COUNT(e.SSN)
		FROM Employee e
		JOIN Works_for wf
			ON e.SSN = wf.ESSn
		JOIN Project p
			ON wf.Pno = p.Pnumber
		WHERE wf.Pno = 100

		IF @CountEmp >= 3
			SELECT
				@RESULT = 'The number of employees in the project p1 is 3 or more'
		ELSE
		IF @CountEmp < 3
			SELECT
				@RESULT = 'The following employees work for the project p1'

		SELECT
			e.Fname
		   ,e.Lname
		   ,@RESULT
		FROM Employee e
		JOIN Works_for wf
			ON e.SSN = wf.ESSn
		JOIN Project p
			ON wf.Pno = p.Pnumber
		WHERE wf.Pno = 100


------------- With exist Try it 
/*3.	 Create a stored procedure that will be used in case there is an old employee has left the project
and a new one become instead of him. The procedure should take 3 parameters 
(old Emp. number, new Emp. number and the project number) 
and it will be used to update works_for table. [Company DB]
*/

ALTER PROC SP_UpdateEmployeeInProject -- 669955,111231,400
@oldEmpNumber INT,
@newEmpNumber INT,
@projecNumber INT
AS
BEGIN TRY
UPDATE Employee 
SET SSN=@newEmpNumber
WHERE SSN=@oldEmpNumber

UPDATE Works_for
SET ESSn=@newEmpNumber
WHERE ESSn=@oldEmpNumber AND Pno=@projecNumber
END TRY
BEGIN CATCH
	SELECT 'You Can not Updat on Employees Or Projects Because there are a relationships ' AS 'Error Msg'
END CATCH


/*
4. Create an Audit table with the following structure
ProjectNo	UserName	ModifiedDate	Hours_Old	Hours_New
p2			Dbo			2008-01-31		10			20
 
This table will be used to audit the update trials on the Hours column (works_for table, Company DB)
Example:
If a user updated the Hours column then the project number, the user name that made that update,
the date of the modification and the value of the old and the new Hours will be inserted into the Audit table
Note: This process will take place only if the user updated the Hours column
*/

CREATE TABLE Tbl_Audit
(
	ProjectNo INT,
	UserName NVARCHAR(50),
	ModifiedDate DATE,
	Hours_Old INT ,
	Hours_New INT
)

CREATE TRIGGER TrackingHours
ON Works_for 
AFTER UPDATE
as
IF UPDATE([Hours])
BEGIN
DECLARE @PNo INT,@HoursOld INT ,@HoursNew INT

SELECT @PNo=Pno,@HoursOld=[Hours] FROM DELETED
SELECT @HoursNew=[Hours] FROM INSERTED

INSERT INTO Tbl_Audit VALUES (@PNo,SUSER_NAME(),GETDATE(),@HoursOld,@HoursNew)

end


UPDATE Works_for
SET HOURS =20
WHERE Pno=200

SELECT * FROM Tbl_Audit ta


-- 5. Create a trigger to prevent anyone from inserting a new record in the Department table [ITI DB]
-- Print a message for the user to tell him that he ‘can’t insert a new record in that table’

CREATE TRIGGER Prevent_InsertDept
ON Department
FOR INSERT
AS SELECT 'can’t insert a new record in that table'
ROLLBACK

INSERT INTO Department 
	VALUES (80,'EB','E-Business','Alex',7,'2009-05-20');

SELECT * FROM Department d


--6. Create a trigger that prevents the insertion Process for the Employee table in September and test i  [Company DB].

ALTER TRIGGER Prevent_InsertionEmpl_September
ON Employee
FOR INSERT
AS
 DECLARE @CurrentMonth NVARCHAR(50) 
 -- SELECT @CurrentMonth=DATENAME(MONTH,'2022-09-01')
 SELECT @CurrentMonth=DATENAME(MONTH,GETDATE())
  IF @CurrentMonth='September'
	 BEGIN
		SELECT 'can’t insert a new record in September Try in Another Month'
		ROLLBACK
	 END
   

	INSERT INTO Employee (Fname, Lname, SSN, Bdate, Address, Sex, Salary, Superssn, Dno)
	VALUES (N'Omar', N'Hussein', 100000221, GETDATE(), N'Bns', N'M', 900, 102660, 10);

---7. Create a trigger that prevents users from altering any table in Company DB.

CREATE TRIGGER PreventAlterTable
ON DATABASE
FOR ALTER_TABLE
AS
SELECT 'Can Not Alter in any Table in Company_DB '
ROLLBACK

ALTER TABLE test ALTER COLUMN CName NVARCHAR(20)

/*
8. Create a trigger on student table after insert to add Row in a Student Audit table 
(Server User Name, Date, Note) where the note will be “[username]
Insert New Row with Key=[Key Value] in table [table name]”
	Server User Name    	date        	Note
*/
CREATE TABLE Tbl_Auditing
(
Server_UserName NVARCHAR(50),
[Date] DATE,
Note NVARCHAR(MAX)
)

alter TRIGGER Tracking_InsertionSTD
ON Student
AFTER INSERT
AS
DECLARE @Key_Value NCHAR(10)= CONVERT(NCHAR(10),(SELECT St_Id FROM INSERTED))

INSERT INTO Tbl_Auditing (Server_UserName, Date, Note)
	VALUES (@@servername, GETDATE(), '['+SUSER_SNAME()+'] Insert New Row with Key=['+@Key_Value+'] in table [ dbo.Student ]')

	
INSERT INTO Student (St_Id, St_Fname, St_Lname, St_Address, St_Age, Dept_Id, St_super)
	VALUES (17, N'Hamada', N'Salah', N'Bns', 40, 40, 9);

SELECT * FROM Tbl_Auditing

-- 9. Create a trigger on student table instead of delete to add Row in Student Audit table
--   (Server User Name, Date, Note) where the note will be“ try to delete Row with Key=[Key Value]”


CREATE TRIGGER Tracking_DeletionStd
ON Student
INSTEAD OF DELETE
AS

INSERT INTO Tbl_Auditing (Server_UserName, Date, Note)
	VALUES (@@servername, GETDATE(), 'try to delete Row with Key=[Key Value]')

DELETE FROM Student
WHERE St_Id=16


---------------------------------------------------------- Bonus ----------------------------------------------------------------










