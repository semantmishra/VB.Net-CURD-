ALTER PROCEDURE [dbo].[usp_EmailExists]
(
@IsEamil NVARCHAR(50)
)
AS 
	BEGIN
		DECLARE @Email BIT
		SET @Email = 0
		
		IF EXISTS (SELECT * FROM [dbo] .[Students]WHERE [Email]  = @IsEamil )
			BEGIN 
				SET @Email = 1
			END 
			SELECT @Email  AS  'Email'
	
	END 