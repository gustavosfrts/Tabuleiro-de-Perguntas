USE [TabuleiroPerguntas]
GO

/****** Object:  Table [dbo].[jogadores]    Script Date: 07/11/2021 19:49:15 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[jogadores](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nome_jogador] [varchar](255) NOT NULL,
	[pontos] [int] NOT NULL
) ON [PRIMARY]
GO


