# EF_DYNAM-C_MASKED
Entity Framework ve Sql Server 2016 ile Dinamik Masked işlenmiştir. 

USE [MasketDB]
GO

/****** Object:  Table [dbo].[Person]    Script Date: 15.05.2019 21:52:51 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Person](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NULL,
	[Surname] [nvarchar](100) MASKED WITH (FUNCTION = 'partial(1, "***", 0)') NOT NULL,
	[EMail] [nvarchar](100) MASKED WITH (FUNCTION = 'partial(1, "***", 0)') NOT NULL,
	[Adress] [nvarchar](200) MASKED WITH (FUNCTION = 'partial(1, "***", 0)') NOT NULL,
	[Phone] [nvarchar](100) MASKED WITH (FUNCTION = 'partial(1, "***", 0)') NOT NULL,
	[PrivateKey] [nvarchar](11) MASKED WITH (FUNCTION = 'partial(1, "***", 0)') NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO




![alt text](https://github.com/serifaydin/EF_DYNAMIC_MASKED/blob/master/masked_.PNG)
