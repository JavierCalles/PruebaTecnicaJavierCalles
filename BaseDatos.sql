/****** Object:  Database [PT_JAVIERCALLES]    Script Date: 3/27/2022 6:53:12 PM ******/
CREATE DATABASE [PT_JAVIERCALLES]
GO
USE [PT_JAVIERCALLES]
GO
/****** Object:  Table [dbo].[cliente]    Script Date: 3/27/2022 6:53:12 PM ******/
CREATE TABLE [dbo].[cliente](
	[idCliente] [int] IDENTITY(1,1) NOT NULL,
	[documentoIdentidad] [nvarchar](20) NULL,
	[primerNombre] [nvarchar](50) NOT NULL,
	[primerApellido] [nvarchar](50) NOT NULL,
	[Edad] [int] NOT NULL,
	[FechaIngreso] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

