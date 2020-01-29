
/****** Object:  Table [dbo].[Cep]    Script Date: 29/01/2020 11:47:11 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Cep](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Cep] [varchar](50) NULL,
	[Logradouro] [varchar](50) NULL,
	[Complemento] [varchar](50) NULL,
	[Bairro] [varchar](50) NULL,
	[Localidade] [varchar](50) NULL,
	[Uf] [varchar](50) NULL,
	[Unidade] [varchar](50) NULL,
	[IBGE] [varchar](50) NULL,
	[GIA] [varchar](50) NULL,
 CONSTRAINT [PK_Cep] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


