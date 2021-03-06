USE [VBDB]
GO
/****** Object:  Table [dbo].[Students]    Script Date: 01/08/2019 12:37:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Students](
	[StudentId] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[Mobile] [nvarchar](50) NULL,
	[Phone] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[usp_UpdateStudentrecord]    Script Date: 01/08/2019 12:37:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_UpdateStudentrecord]
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
GO
/****** Object:  StoredProcedure [dbo].[usp_insertStudentrecord]    Script Date: 01/08/2019 12:37:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_insertStudentrecord]
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
GO
/****** Object:  StoredProcedure [dbo].[usp_EmailExists]    Script Date: 01/08/2019 12:37:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_EmailExists]
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
GO
/****** Object:  StoredProcedure [dbo].[usp_DeleteRecordByStudentId]    Script Date: 01/08/2019 12:37:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_DeleteRecordByStudentId]
(
@StudentId Int
)

AS 

	BEGIN
	 DELETE  dbo.Students 
	 Where StudentId =  @StudentId
	 
	END
GO
/****** Object:  StoredProcedure [dbo].[uso_StudentGetAllStudentRecords]    Script Date: 01/08/2019 12:37:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uso_StudentGetAllStudentRecords]

as 
	BEGIN
	SELECT StudentId ,
	FirstName+ ' '+LastName AS 'Name',
	Email,
	Mobile,
	Phone
	 FROM Students 
	end
GO
/****** Object:  StoredProcedure [dbo].[ups_GetStudentDetailsById]    Script Date: 01/08/2019 12:37:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ups_GetStudentDetailsById]
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
GO
