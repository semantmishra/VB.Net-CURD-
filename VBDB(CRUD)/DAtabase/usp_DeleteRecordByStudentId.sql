
ALTER PROCEDURE [dbo].[usp_DeleteRecordByStudentId]
(
@StudentId Int
)

AS 

	BEGIN
	 DELETE  dbo.Students 
	 Where StudentId =  @StudentId
	 
	END