

ALTER PROCEDURE [dbo].[ups_GetStudentDetailsById]
(
@Studentid INT
)
AS 
	BEGIN
		SELECT	FirstName	 AS 'FirstName', 
				LastName	 AS 'LastName' ,
				Email		 AS 'EMail',
				Mobile		AS 'Mobile',
				Phone 	 AS 'Phone' 
		 FROM dbo .Students 
		WHERE StudentId = @Studentid 
	End 