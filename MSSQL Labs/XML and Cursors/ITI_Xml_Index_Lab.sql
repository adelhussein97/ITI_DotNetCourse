
------------------------------------------------  SQL Server lab 5 ------------------------------------
/*
1. Display all the data from the Employee table (HumanResources
Schema) As an XML document “Use XML Raw”. “Use Adventure
works DB”
A) Elements
B) Attributes
*/

-- A) Elements
SELECT
	*
FROM HR.Employee e
FOR XML RAW ('EmployeeData'), ELEMENTS, ROOT ('AllEmployeesData')

-- B) Attributes
SELECT
	*
FROM HR.Employee e
FOR XML RAW ('EmployeeData'), ROOT ('AllEmployeesData')

------------------------------------------------------------------------------------------------

/*

Display Each Department Name with its instructors. “Use ITI DB”
A) Use XML Raw :
<instructors_mangers>
<manger>
<Ins_Name>Ahmed</Ins_Name>
<Dept_Name>SD</Dept_Name>
</manger>
<manger>
<Ins_Name>Amr</Ins_Name>
<Dept_Name>EL</Dept_Name>
</manger>
..
..
</instructors_mangers>
*/
SELECT
	i.Ins_Name
   ,d.Dept_Name
FROM Department d
JOIN Instructor i
	ON d.Dept_Manager = i.Ins_Id
FOR XML RAW ('manager'), ELEMENTS, ROOT ('instructors_mangers')


/*
B) B) Use XML Path:
<instructors_mangers>
<department id="10">
<name>SD</name>
<manger_name>Ahmed</manger_name>
</department>
</instructors_mangers>
<instructors_mangers>
<department id="20">
<name>EL</name>
<manger_name>Amr</manger_name>
</department>
..
..
</instructors_mangers>

*/

SELECT
	d.Dept_Id "Departemnet/@id"
   ,d.Dept_Name "name"
   ,i.Ins_Name manger_name
FROM Department d
JOIN Instructor i
	ON d.Dept_Manager = i.Ins_Id
FOR XML PATH ('instructors_mangers'), ELEMENTS, ROOT ('Allinstructors_mangers')

------------------------------------------------------------------------------------------------------------

/*
3. Use the following variable to create a new table “customers”
inside the company DB. Use OpenXML
‘<customers>
<customer FirstName="Bob" Zipcode="91126">
<order ID="12221">Laptop</order>
</customer>
<customer FirstName="Judy" Zipcode="23235">
<order ID="12221">Workstation</order>
</customer>
<customer FirstName="Howard" Zipcode="20009"><order ID="3331122">Laptop</order>
</customer>
<customer FirstName="Mary" Zipcode="12345">
<order ID="555555">Server</order>
</customer>
</customers> ‘
*/

DECLARE @doc XML =
'<customers>
<customer FirstName="Bob" Zipcode="91126">
<order ID="12221">Laptop</order>
</customer>
<customer FirstName="Judy" Zipcode="23235">
<order ID="12221">Workstation</order>
</customer>
<customer FirstName="Howard" Zipcode="20009"><order ID="3331122">Laptop</order>
</customer>
<customer FirstName="Mary" Zipcode="12345">
<order ID="555555">Server</order>
</customer>
</customers> '

DECLARE @hdocs INT
EXEC sys.sp_xml_preparedocument @hdocs OUTPUT
							   ,@doc
SELECT
	* INTO customers
FROM OPENXML(@hdocs, '//customer')
WITH
(
FirstName NVARCHAR(50) '@FirstName',
Zipcode INT '@Zipcode',
OrderID INT 'order/@ID',
ProductName NVARCHAR(50) 'order'
)

SELECT
	*
FROM customers c


-----------------------------------------------------------------------------------------------------------

-----------------------------------------using AdventureWorks2012 database --------------------------

--4. Create an index on column (Hiredate) that allows you to cluster
--   the data in the table Department. What will happen?

CREATE CLUSTERED INDEX Cluster_Hirdate ON HR.Employee (HireDate)  -- Result Error 
-- because there is one cluster index on this table(PK) and can not create more than one clusterd index on table
-- if you want to create index on this column can create non cluster index

CREATE NONCLUSTERED INDEX Cluster_Hirdate ON HR.Employee (HireDate)

/*  5. Create an index that allows you to enter unique ages in the
    student table. What will happen?*/

CREATE UNIQUE INDEX Unique_ClusterAge ON dbo.Student (St_Age)  -- Result Error 

-- can not create unique index because there are dublicates key and more than one value dublicated 


/*
	6. create a non-clustered index on column(Manager_hiredate)
	that allows you to enter a unique instructor id in the table
	Department.

*/
CREATE UNIQUE INDEX UniqueInstructID ON Department (Dept_Manager)
CREATE NONCLUSTERED INDEX NonClustMgr ON Department (Manager_hiredate)

/*
	7. find the count of times that Ahmed appear Khalid after Khalid in
	st_Fname column (using the cursor)
*/

DECLARE Cursor1 CURSOR FOR SELECT
	s.St_Fname
FROM Student s
FOR READ ONLY
DECLARE @countAhmed INT = 0
	   ,@F_name NVARCHAR(50)

OPEN Cursor1
FETCH Cursor1 INTO @F_name
WHILE @@fetch_status = 0
BEGIN
IF @F_name = 'Ahmed'
BEGIN
	FETCH Cursor1 INTO @F_name
	SELECT
		@countAhmed += COUNT(@F_name)
	WHERE @F_name = 'Khalid'
	
	
END
ELSE
	FETCH Cursor1 INTO @F_name
--IF @F_name = 'khalid'
--	BREAK

END
SELECT
	@countAhmed AS 'Count Show Ahmed Before Khalid'
CLOSE Cursor1
DEALLOCATE Cursor1












