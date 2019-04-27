ALTER PROCEDURE [dbo].[usp_UpdateStudentrecord]
(
@Sid Int,
@FirstName NVARCHAR(50),
@LastName NVARCHAR(50),
@Email NVARCHAR(50),
@Mobile NVARCHAR(50),
@Phone NVARCHAR(50)

)

AS 

	BEGIN
	 UPDATE dbo.Students
	 SET FirstName = @FirstName ,
	 LastName = @LastName  ,
	 Email = @Email ,
	 Mobile = @Mobile ,
	 Phone = @Phone 
	 Where StudentId = @Sid 
	 
	END