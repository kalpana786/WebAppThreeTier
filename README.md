# WebAppThreeTier
Webapplication with 3 Tier architecture

Database : ComapanyDB
Table : Employee
---------------------------------------------------------------------------
CREATE TABLE Employee(
	Eno int NOT NULL,
	Ename varchar(50) NULL,
	Salary decimal(18, 0) NULL,
	Status bit NULL DEFAULT ((1)),

 CONSTRAINT PK_Employee PRIMARY KEY (Eno )

Stored Procedure
--------------------------------------------------------------------------------------------
CREATE PROCEDURE Procedure_insertEmployee
	@id int,@ename varchar(20),@salary decimal(12,2)
AS
BEGIN
	INSERT INTO Employee(Eno, Ename, Salary) VALUES(@id,@ename,@salary)
END


CREATE PROCEDURE Procedure_deleteEmployee
	@id int
AS
BEGIN
	update  Employee set status=0 where eno=@id
END



CREATE PROCEDURE Procedure_updateEmployee
	@id int,@ename varchar(20),@salary decimal(12,2)
AS
BEGIN
	update  Employee set Ename=@ename, Salary=@salary where Eno=@id
END



CREATE PROCEDURE Procedure_searchEmployee
	(@id int)
AS
BEGIN
SELECT Eno,Ename,Salary from Employee where Eno=@id	
END


CREATE PROCEDURE Procedure_AllEmployee
AS
BEGIN
SELECT Eno,Ename,Salary from Employee where status=1	
END

