
/****** Object:  Database [PayItForward]    Script Date: 7/6/2019 12:01:41 ******/
CREATE DATABASE [PayItForward]
 GO
ALTER DATABASE [PayItForward] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [PayItForward].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [PayItForward] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [PayItForward] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [PayItForward] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [PayItForward] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [PayItForward] SET ARITHABORT OFF 
GO
ALTER DATABASE [PayItForward] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [PayItForward] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [PayItForward] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [PayItForward] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [PayItForward] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [PayItForward] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [PayItForward] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [PayItForward] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [PayItForward] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [PayItForward] SET  DISABLE_BROKER 
GO
ALTER DATABASE [PayItForward] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [PayItForward] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [PayItForward] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [PayItForward] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [PayItForward] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [PayItForward] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [PayItForward] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [PayItForward] SET RECOVERY FULL 
GO
ALTER DATABASE [PayItForward] SET  MULTI_USER 
GO
ALTER DATABASE [PayItForward] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [PayItForward] SET DB_CHAINING OFF 
GO
ALTER DATABASE [PayItForward] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [PayItForward] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [PayItForward] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'PayItForward', N'ON'
GO
ALTER DATABASE [PayItForward] SET QUERY_STORE = OFF
GO
USE [PayItForward]
GO
ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [PayItForward]
GO
/****** Object:  User [alumno]    Script Date: 7/6/2019 12:01:41 ******/
CREATE USER [alumno] FOR LOGIN [alumno] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[Banners]    Script Date: 7/6/2019 12:01:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Banners](
	[IdBanner] [int] IDENTITY(1,1) NOT NULL,
	[Imagen] [varchar](255) NOT NULL,
	[Desde] [date] NOT NULL,
	[Hasta] [date] NOT NULL,
 CONSTRAINT [PK_Banners] PRIMARY KEY CLUSTERED 
(
	[IdBanner] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categorias]    Script Date: 7/6/2019 12:01:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categorias](
	[IdCategoria] [int] IDENTITY(1,1) NOT NULL,
	[IdCategoriaPadre] [int] NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Imagen] [varchar](max) NOT NULL,
 CONSTRAINT [PK_Categorias] PRIMARY KEY CLUSTERED 
(
	[IdCategoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Imagenes_publicacion]    Script Date: 7/6/2019 12:01:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Imagenes_publicacion](
	[IdPublicacion] [int] NOT NULL,
	[Imagen] [varchar](255) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Preguntas_publicacion]    Script Date: 7/6/2019 12:01:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Preguntas_publicacion](
	[IdPreguntas] [int] IDENTITY(1,1) NOT NULL,
	[Pregunta] [varchar](max) NOT NULL,
	[Respuesta] [varchar](max) NULL,
	[IdPublicacion] [int] NOT NULL,
 CONSTRAINT [PK_Preguntas_publicacion] PRIMARY KEY CLUSTERED 
(
	[IdPreguntas] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Publicaciones]    Script Date: 7/6/2019 12:01:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Publicaciones](
	[IdPublicacion] [int] IDENTITY(1,1) NOT NULL,
	[IdCategoria] [int] NOT NULL,
	[IdUsuario] [int] NOT NULL,
	[Aprobada] [bit] NOT NULL,
	[Valor] [int] NOT NULL,
	[Titulo] [varchar](max) NOT NULL,
	[Descripcion] [varchar](max) NOT NULL,
	[Likes] [int] NOT NULL,
	[Ubicacion] [varchar](max) NULL,
 CONSTRAINT [PK_Publicaciones] PRIMARY KEY CLUSTERED 
(
	[IdPublicacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Banners] ON 

INSERT [dbo].[Banners] ([IdBanner], [Imagen], [Desde], [Hasta]) VALUES (1, N'ActitudAnimal.png', CAST(N'2019-05-31' AS Date), CAST(N'2020-05-31' AS Date))
INSERT [dbo].[Banners] ([IdBanner], [Imagen], [Desde], [Hasta]) VALUES (2, N'apadea.png', CAST(N'2019-05-31' AS Date), CAST(N'2020-05-31' AS Date))
INSERT [dbo].[Banners] ([IdBanner], [Imagen], [Desde], [Hasta]) VALUES (3, N'aedin.png', CAST(N'2019-05-31' AS Date), CAST(N'2020-05-31' AS Date))
SET IDENTITY_INSERT [dbo].[Banners] OFF
SET IDENTITY_INSERT [dbo].[Categorias] ON 

INSERT [dbo].[Categorias] ([IdCategoria], [IdCategoriaPadre], [Nombre], [Imagen]) VALUES (1, -1, N'Productos', N'productos.png')
INSERT [dbo].[Categorias] ([IdCategoria], [IdCategoriaPadre], [Nombre], [Imagen]) VALUES (2, -1, N'Servicios', N'servicios.png')
INSERT [dbo].[Categorias] ([IdCategoria], [IdCategoriaPadre], [Nombre], [Imagen]) VALUES (4, 1, N'Tecnologia', N'tecnologia.png')
INSERT [dbo].[Categorias] ([IdCategoria], [IdCategoriaPadre], [Nombre], [Imagen]) VALUES (5, 1, N'Ropa', N'ropa.png')
INSERT [dbo].[Categorias] ([IdCategoria], [IdCategoriaPadre], [Nombre], [Imagen]) VALUES (6, 1, N'Juguetes', N'juguete.png')
INSERT [dbo].[Categorias] ([IdCategoria], [IdCategoriaPadre], [Nombre], [Imagen]) VALUES (7, 2, N'Medicina', N'medicina.png')
INSERT [dbo].[Categorias] ([IdCategoria], [IdCategoriaPadre], [Nombre], [Imagen]) VALUES (8, 2, N'Mantenimiento', N'mantenimiento.png')
SET IDENTITY_INSERT [dbo].[Categorias] OFF
/****** Object:  StoredProcedure [dbo].[sp_AltaImagen]    Script Date: 7/6/2019 12:01:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_AltaImagen]
@pImagen varchar(max),
@pId int

as

insert into Imagenes_publicacion (IdPublicacion, Imagen) values (@pId, @pImagen)
GO
/****** Object:  StoredProcedure [dbo].[sp_AltaPublicacion]    Script Date: 7/6/2019 12:01:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_AltaPublicacion]
@pIdCategoria int,
@pIdUsuario int,
@pAprobada bit,
@pValor int,
@pTitulo varchar(MAX),
@pDescripcion varchar(MAX),
@pLikes int,
@pUbicacion varchar(MAX)

AS
INSERT INTO	Publicaciones (IdCategoria, IdUsuario, Aprobada, Valor, Titulo, Descripcion, Likes, Ubicacion) 
VALUES (@pIdCategoria, @pIdUsuario, @pAprobada, @pValor, @pTitulo, @pDescripcion, @pLikes, @pUbicacion)
GO
/****** Object:  StoredProcedure [dbo].[sp_BajaPublicacion]    Script Date: 7/6/2019 12:01:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_BajaPublicacion]
@pId int

as
DELETE FROM Publicaciones WHERE IdPublicacion = @pId
GO
/****** Object:  StoredProcedure [dbo].[sp_ModificarPublicacion]    Script Date: 7/6/2019 12:01:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ModificarPublicacion]
@pIdPublicacion int,
@pIdCategoria int,
@pAprobada bit,
@pValor int,
@pTitulo varchar(MAX),
@pDescripcion varchar(MAX),
@pUbicacion varchar(MAX)

AS
UPDATE Publicaciones set IdCategoria = @pIdCategoria, Aprobada = @pAprobada, Valor = @pValor, Titulo = @pTitulo, Descripcion = @pDescripcion, Ubicacion = @pUbicacion
WHERE IdPublicacion = @pIdPublicacion
GO
/****** Object:  StoredProcedure [dbo].[sp_TraerBannersHome]    Script Date: 7/6/2019 12:01:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_TraerBannersHome]
as

SELECT * FROM Banners
GO
/****** Object:  StoredProcedure [dbo].[sp_TraerCategoriasPadres]    Script Date: 7/6/2019 12:01:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_TraerCategoriasPadres] AS

SELECT * FROM Categorias WHERE Categorias.IdCategoriaPadre = -1
GO
/****** Object:  StoredProcedure [dbo].[sp_TraerCategoriasPorIdPadre]    Script Date: 7/6/2019 12:01:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_TraerCategoriasPorIdPadre] 
@pIdPadre int
AS

SELECT * FROM Categorias
WHERE Categorias.IdCategoriaPadre = @pIdPadre
GO
/****** Object:  StoredProcedure [dbo].[sp_TraerPublicacionesPorUsuario]    Script Date: 7/6/2019 12:01:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_TraerPublicacionesPorUsuario]
@pId int
AS
SELECT * FROM Publicaciones WHERE IdUsuario = @pId
GO
/****** Object:  StoredProcedure [dbo].[sp_UltimaPublicacion]    Script Date: 7/6/2019 12:01:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- ================================================

CREATE PROCEDURE [dbo].[sp_UltimaPublicacion]
	
AS
BEGIN
	SELECT MAX (IdPublicacion) AS UltimaPublicacion from Publicaciones 
END
GO
USE [master]
GO
ALTER DATABASE [PayItForward] SET  READ_WRITE 
GO
