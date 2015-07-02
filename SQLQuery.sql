Create Database Student

use Student

GO 

Create Table StudentDetails
(
StudentID nchar(10) Primary key,
FullName varChar(50),
DOB nchar(10),
GPA decimal(18,2),
Status nchar(10) 
);

--Use of procedures: Create procedure to insert Data--
use Student
Go

CREATE PROCEDURE RegisterStudent
	@StudentID nchar(10),
	@FullName varChar(50),
	@DOB nchar(10),
	@GPA decimal(18,2),
	@Status nchar(10)

AS
	
	Insert Into StudentDetails (StudentID, FullName, DOB, GPA, Status)
	Values (@StudentID, @FullName, @DOB, @GPA, @Status)
	
--Create procedure to read Data--


CREATE PROCEDURE ReadStudents
	
AS
	Select StudentID, FullName, DOB, GPA, Status From StudentDetails