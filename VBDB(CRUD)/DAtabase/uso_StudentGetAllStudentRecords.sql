
ALTER PROCEDURE [dbo].[uso_StudentGetAllStudentRecords]

as 
	BEGIN
	SELECT StudentId ,
	FirstName+ ' '+LastName AS 'Name',
	Email,
	Mobile,
	Phone
	 FROM Students 
	end
	