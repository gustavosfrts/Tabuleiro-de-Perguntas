USE [TabuleiroPerguntas]
GO

/****** Object:  Table [dbo].[respostas]    Script Date: 07/11/2021 19:50:17 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[respostas](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_perguntas] [int] NOT NULL,
	[resposta] [varchar](1000) NOT NULL,
	[resposta_certa] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[respostas]  WITH CHECK ADD FOREIGN KEY([id_perguntas])
REFERENCES [dbo].[perguntas] ([id])
GO


