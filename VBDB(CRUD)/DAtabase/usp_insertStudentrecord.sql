ALTER PROCEDURE [dbo].[usp_insertStudentrecord]
(
@FirstName NVARCHAR(50),
@LastName NVARCHAR(50),
@Email NVARCHAR(50),
@Mobile NVARCHAR(50),
@Phone NVARCHAR(50)

)

AS 

	BEGIN
	 INSERT INTO [dbo] .[Students] (FirstName ,LastName ,Email , Mobile,Phone)
	 VALUES(@FirstName ,@LastName ,@Email ,@Mobile ,@Phone )
	 
	END