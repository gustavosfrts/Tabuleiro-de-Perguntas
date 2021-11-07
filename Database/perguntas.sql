USE [TabuleiroPerguntas]
GO

/****** Object:  Table [dbo].[perguntas]    Script Date: 07/11/2021 19:49:48 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[perguntas](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[pergunta] [varchar](1000) NOT NULL,
	[nivel_pergunta] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


