USE [PayItForward]
GO
/****** Object:  StoredProcedure [dbo].[sp_ValidarUsuarioEspecialPorCodigo]    Script Date: 29/11/2019 11:59:32 ******/
DROP PROCEDURE [dbo].[sp_ValidarUsuarioEspecialPorCodigo]
GO
/****** Object:  StoredProcedure [dbo].[sp_UsuarioTraerPorID]    Script Date: 29/11/2019 11:59:32 ******/
DROP PROCEDURE [dbo].[sp_UsuarioTraerPorID]
GO
/****** Object:  StoredProcedure [dbo].[sp_UsuariosTraer]    Script Date: 29/11/2019 11:59:32 ******/
DROP PROCEDURE [dbo].[sp_UsuariosTraer]
GO
/****** Object:  StoredProcedure [dbo].[sp_UsuarioModificacion]    Script Date: 29/11/2019 11:59:32 ******/
DROP PROCEDURE [dbo].[sp_UsuarioModificacion]
GO
/****** Object:  StoredProcedure [dbo].[sp_UsuarioBaja]    Script Date: 29/11/2019 11:59:32 ******/
DROP PROCEDURE [dbo].[sp_UsuarioBaja]
GO
/****** Object:  StoredProcedure [dbo].[sp_UsuarioAlta]    Script Date: 29/11/2019 11:59:32 ******/
DROP PROCEDURE [dbo].[sp_UsuarioAlta]
GO
/****** Object:  StoredProcedure [dbo].[sp_UltimaPublicacion]    Script Date: 29/11/2019 11:59:32 ******/
DROP PROCEDURE [dbo].[sp_UltimaPublicacion]
GO
/****** Object:  StoredProcedure [dbo].[sp_TraerUsuarioPorId]    Script Date: 29/11/2019 11:59:32 ******/
DROP PROCEDURE [dbo].[sp_TraerUsuarioPorId]
GO
/****** Object:  StoredProcedure [dbo].[sp_TraerTodasLasPublicaciones]    Script Date: 29/11/2019 11:59:32 ******/
DROP PROCEDURE [dbo].[sp_TraerTodasLasPublicaciones]
GO
/****** Object:  StoredProcedure [dbo].[sp_TraerPublicacionPorId]    Script Date: 29/11/2019 11:59:32 ******/
DROP PROCEDURE [dbo].[sp_TraerPublicacionPorId]
GO
/****** Object:  StoredProcedure [dbo].[sp_TraerPublicacionesPorUsuario]    Script Date: 29/11/2019 11:59:32 ******/
DROP PROCEDURE [dbo].[sp_TraerPublicacionesPorUsuario]
GO
/****** Object:  StoredProcedure [dbo].[sp_TraerPublicacionesPorCategoria]    Script Date: 29/11/2019 11:59:32 ******/
DROP PROCEDURE [dbo].[sp_TraerPublicacionesPorCategoria]
GO
/****** Object:  StoredProcedure [dbo].[sp_TraerPublicacionesBusquedaCategoria]    Script Date: 29/11/2019 11:59:32 ******/
DROP PROCEDURE [dbo].[sp_TraerPublicacionesBusquedaCategoria]
GO
/****** Object:  StoredProcedure [dbo].[sp_TraerNombreCategoriaPorId]    Script Date: 29/11/2019 11:59:32 ******/
DROP PROCEDURE [dbo].[sp_TraerNombreCategoriaPorId]
GO
/****** Object:  StoredProcedure [dbo].[sp_traerIDCategoriaPorNombre]    Script Date: 29/11/2019 11:59:32 ******/
DROP PROCEDURE [dbo].[sp_traerIDCategoriaPorNombre]
GO
/****** Object:  StoredProcedure [dbo].[sp_TraerCategoriasPorNombrePadre]    Script Date: 29/11/2019 11:59:32 ******/
DROP PROCEDURE [dbo].[sp_TraerCategoriasPorNombrePadre]
GO
/****** Object:  StoredProcedure [dbo].[sp_TraerCategoriasPorIdPadre]    Script Date: 29/11/2019 11:59:32 ******/
DROP PROCEDURE [dbo].[sp_TraerCategoriasPorIdPadre]
GO
/****** Object:  StoredProcedure [dbo].[sp_TraerCategoriasPadres]    Script Date: 29/11/2019 11:59:32 ******/
DROP PROCEDURE [dbo].[sp_TraerCategoriasPadres]
GO
/****** Object:  StoredProcedure [dbo].[sp_TraerCategoriaPorID]    Script Date: 29/11/2019 11:59:32 ******/
DROP PROCEDURE [dbo].[sp_TraerCategoriaPorID]
GO
/****** Object:  StoredProcedure [dbo].[sp_TraerCategoriaPadreDesdeCategoriaHija]    Script Date: 29/11/2019 11:59:32 ******/
DROP PROCEDURE [dbo].[sp_TraerCategoriaPadreDesdeCategoriaHija]
GO
/****** Object:  StoredProcedure [dbo].[sp_TraerBannersHome]    Script Date: 29/11/2019 11:59:32 ******/
DROP PROCEDURE [dbo].[sp_TraerBannersHome]
GO
/****** Object:  StoredProcedure [dbo].[sp_RegistroUsuario]    Script Date: 29/11/2019 11:59:32 ******/
DROP PROCEDURE [dbo].[sp_RegistroUsuario]
GO
/****** Object:  StoredProcedure [dbo].[sp_ObtenerPublicacionNoEspecial]    Script Date: 29/11/2019 11:59:32 ******/
DROP PROCEDURE [dbo].[sp_ObtenerPublicacionNoEspecial]
GO
/****** Object:  StoredProcedure [dbo].[sp_ObtenerPublicacionEspecial]    Script Date: 29/11/2019 11:59:32 ******/
DROP PROCEDURE [dbo].[sp_ObtenerPublicacionEspecial]
GO
/****** Object:  StoredProcedure [dbo].[sp_ModificarPublicacion]    Script Date: 29/11/2019 11:59:32 ******/
DROP PROCEDURE [dbo].[sp_ModificarPublicacion]
GO
/****** Object:  StoredProcedure [dbo].[sp_Login]    Script Date: 29/11/2019 11:59:32 ******/
DROP PROCEDURE [dbo].[sp_Login]
GO
/****** Object:  StoredProcedure [dbo].[sp_busquedaPublicacionPorTexto]    Script Date: 29/11/2019 11:59:32 ******/
DROP PROCEDURE [dbo].[sp_busquedaPublicacionPorTexto]
GO
/****** Object:  StoredProcedure [dbo].[sp_borrarCodigoEspecial]    Script Date: 29/11/2019 11:59:32 ******/
DROP PROCEDURE [dbo].[sp_borrarCodigoEspecial]
GO
/****** Object:  StoredProcedure [dbo].[sp_BajaPublicacion]    Script Date: 29/11/2019 11:59:32 ******/
DROP PROCEDURE [dbo].[sp_BajaPublicacion]
GO
/****** Object:  StoredProcedure [dbo].[sp_altaUsuario]    Script Date: 29/11/2019 11:59:32 ******/
DROP PROCEDURE [dbo].[sp_altaUsuario]
GO
/****** Object:  StoredProcedure [dbo].[sp_AltaPublicacion]    Script Date: 29/11/2019 11:59:32 ******/
DROP PROCEDURE [dbo].[sp_AltaPublicacion]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 29/11/2019 11:59:32 ******/
DROP TABLE [dbo].[Usuarios]
GO
/****** Object:  Table [dbo].[Publicaciones]    Script Date: 29/11/2019 11:59:32 ******/
DROP TABLE [dbo].[Publicaciones]
GO
/****** Object:  Table [dbo].[Preguntas_publicacion]    Script Date: 29/11/2019 11:59:32 ******/
DROP TABLE [dbo].[Preguntas_publicacion]
GO
/****** Object:  Table [dbo].[Codigos_especiales]    Script Date: 29/11/2019 11:59:32 ******/
DROP TABLE [dbo].[Codigos_especiales]
GO
/****** Object:  Table [dbo].[Categorias]    Script Date: 29/11/2019 11:59:32 ******/
DROP TABLE [dbo].[Categorias]
GO
/****** Object:  Table [dbo].[Banners]    Script Date: 29/11/2019 11:59:32 ******/
DROP TABLE [dbo].[Banners]
GO
/****** Object:  User [alumno]    Script Date: 29/11/2019 11:59:32 ******/
DROP USER [alumno]
GO
USE [master]
GO
/****** Object:  Database [PayItForward]    Script Date: 29/11/2019 11:59:32 ******/
DROP DATABASE [PayItForward]
GO
/****** Object:  Database [PayItForward]    Script Date: 29/11/2019 11:59:32 ******/
CREATE DATABASE [PayItForward]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'PayItForward', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\PayItForward.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'PayItForward_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\PayItForward_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
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
/****** Object:  User [alumno]    Script Date: 29/11/2019 11:59:32 ******/
CREATE USER [alumno] FOR LOGIN [alumno] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[Banners]    Script Date: 29/11/2019 11:59:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Banners](
	[IdBanner] [int] IDENTITY(1,1) NOT NULL,
	[Imagen] [varchar](255) NOT NULL,
	[Hasta] [date] NOT NULL,
 CONSTRAINT [PK_Banners] PRIMARY KEY CLUSTERED 
(
	[IdBanner] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categorias]    Script Date: 29/11/2019 11:59:33 ******/
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
/****** Object:  Table [dbo].[Codigos_especiales]    Script Date: 29/11/2019 11:59:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Codigos_especiales](
	[codigo] [varchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Preguntas_publicacion]    Script Date: 29/11/2019 11:59:33 ******/
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
/****** Object:  Table [dbo].[Publicaciones]    Script Date: 29/11/2019 11:59:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Publicaciones](
	[IdPublicacion] [int] IDENTITY(1,1) NOT NULL,
	[IdCategoria] [int] NOT NULL,
	[IdUsuario] [int] NOT NULL,
	[Imagen1] [varchar](max) NOT NULL,
	[Imagen2] [varchar](max) NULL,
	[Imagen3] [varchar](max) NULL,
	[Aprobada] [bit] NOT NULL,
	[Valor] [int] NOT NULL,
	[Titulo] [varchar](max) NOT NULL,
	[Descripcion] [varchar](max) NOT NULL,
	[Likes] [int] NOT NULL,
	[Ubicacion] [varchar](max) NULL,
	[Destacada] [bit] NOT NULL,
 CONSTRAINT [PK_Publicaciones] PRIMARY KEY CLUSTERED 
(
	[IdPublicacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 29/11/2019 11:59:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[IdUsuario] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Apellido] [varchar](50) NOT NULL,
	[Mail] [varchar](50) NOT NULL,
	[Contrasena] [varchar](50) NOT NULL,
	[Imagen] [varchar](max) NOT NULL,
	[Puntos] [int] NOT NULL,
	[Especial] [bit] NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Banners] ON 

INSERT [dbo].[Banners] ([IdBanner], [Imagen], [Hasta]) VALUES (1, N'ActitudAnimal.png', CAST(N'2020-05-31' AS Date))
INSERT [dbo].[Banners] ([IdBanner], [Imagen], [Hasta]) VALUES (2, N'apadea.png', CAST(N'2020-05-31' AS Date))
INSERT [dbo].[Banners] ([IdBanner], [Imagen], [Hasta]) VALUES (3, N'aedin.png', CAST(N'2020-05-31' AS Date))
SET IDENTITY_INSERT [dbo].[Banners] OFF
SET IDENTITY_INSERT [dbo].[Categorias] ON 

INSERT [dbo].[Categorias] ([IdCategoria], [IdCategoriaPadre], [Nombre], [Imagen]) VALUES (1, -1, N'Productos', N'productos.png')
INSERT [dbo].[Categorias] ([IdCategoria], [IdCategoriaPadre], [Nombre], [Imagen]) VALUES (2, -1, N'Servicios', N'servicios.png')
INSERT [dbo].[Categorias] ([IdCategoria], [IdCategoriaPadre], [Nombre], [Imagen]) VALUES (4, 1, N'Tecnologia', N'tecnologia.png')
INSERT [dbo].[Categorias] ([IdCategoria], [IdCategoriaPadre], [Nombre], [Imagen]) VALUES (5, 1, N'Ropa', N'ropa.png')
INSERT [dbo].[Categorias] ([IdCategoria], [IdCategoriaPadre], [Nombre], [Imagen]) VALUES (6, 1, N'Juguetes', N'juguete.png')
INSERT [dbo].[Categorias] ([IdCategoria], [IdCategoriaPadre], [Nombre], [Imagen]) VALUES (7, 2, N'Medicina', N'medicina.png')
INSERT [dbo].[Categorias] ([IdCategoria], [IdCategoriaPadre], [Nombre], [Imagen]) VALUES (8, 2, N'Mantenimiento', N'mantenimiento.png')
INSERT [dbo].[Categorias] ([IdCategoria], [IdCategoriaPadre], [Nombre], [Imagen]) VALUES (10, 5, N'Remeras', N'remera.png')
INSERT [dbo].[Categorias] ([IdCategoria], [IdCategoriaPadre], [Nombre], [Imagen]) VALUES (11, 5, N'Shorts', N'shorts.png')
INSERT [dbo].[Categorias] ([IdCategoria], [IdCategoriaPadre], [Nombre], [Imagen]) VALUES (12, 10, N'Deportivo', N'deportivo.png')
SET IDENTITY_INSERT [dbo].[Categorias] OFF
SET IDENTITY_INSERT [dbo].[Publicaciones] ON 

INSERT [dbo].[Publicaciones] ([IdPublicacion], [IdCategoria], [IdUsuario], [Imagen1], [Imagen2], [Imagen3], [Aprobada], [Valor], [Titulo], [Descripcion], [Likes], [Ubicacion], [Destacada]) VALUES (14, 4, 2, N'14_heladera.jpg', NULL, NULL, 1, 20, N'Heladera', N'Kohinor', 13, N'Yatay 240', 1)
INSERT [dbo].[Publicaciones] ([IdPublicacion], [IdCategoria], [IdUsuario], [Imagen1], [Imagen2], [Imagen3], [Aprobada], [Valor], [Titulo], [Descripcion], [Likes], [Ubicacion], [Destacada]) VALUES (15, 12, 2, N'15_river.jpg', NULL, NULL, 0, 34, N'Jersey River', N'Temporada 2019', 0, N'Jorge Newbery x', 0)
INSERT [dbo].[Publicaciones] ([IdPublicacion], [IdCategoria], [IdUsuario], [Imagen1], [Imagen2], [Imagen3], [Aprobada], [Valor], [Titulo], [Descripcion], [Likes], [Ubicacion], [Destacada]) VALUES (16, 11, 2, N'16_sacachispas.jpg', NULL, NULL, 0, 3, N'Short Sacachispas', N'Malardo', 0, N'Villa Soldati', 0)
INSERT [dbo].[Publicaciones] ([IdPublicacion], [IdCategoria], [IdUsuario], [Imagen1], [Imagen2], [Imagen3], [Aprobada], [Valor], [Titulo], [Descripcion], [Likes], [Ubicacion], [Destacada]) VALUES (17, 6, 2, N'17_ludo.jpg', N'17_ludo2.jpg', NULL, 0, 37, N'Ludo', N'Juego de mesa', 0, N'Colegiales', 0)
INSERT [dbo].[Publicaciones] ([IdPublicacion], [IdCategoria], [IdUsuario], [Imagen1], [Imagen2], [Imagen3], [Aprobada], [Valor], [Titulo], [Descripcion], [Likes], [Ubicacion], [Destacada]) VALUES (18, 7, 2, N'18_vacuna.jfif', NULL, NULL, 0, 150, N'Vacuna HPV', N'Vacuna para la HPV mayores a 15', 0, N'Naval', 0)
INSERT [dbo].[Publicaciones] ([IdPublicacion], [IdCategoria], [IdUsuario], [Imagen1], [Imagen2], [Imagen3], [Aprobada], [Valor], [Titulo], [Descripcion], [Likes], [Ubicacion], [Destacada]) VALUES (19, 8, 2, N'19_plomero.jpg', NULL, NULL, 0, 40, N'Plomero', N'A domicilio', 0, N'Tu casa', 0)
INSERT [dbo].[Publicaciones] ([IdPublicacion], [IdCategoria], [IdUsuario], [Imagen1], [Imagen2], [Imagen3], [Aprobada], [Valor], [Titulo], [Descripcion], [Likes], [Ubicacion], [Destacada]) VALUES (20, 4, 7, N'20_lavarropas.jpg', N'', N'', 0, 100, N'Regalo Lavarropas', N'Drean', 0, N'Villa Crespo', 0)
INSERT [dbo].[Publicaciones] ([IdPublicacion], [IdCategoria], [IdUsuario], [Imagen1], [Imagen2], [Imagen3], [Aprobada], [Valor], [Titulo], [Descripcion], [Likes], [Ubicacion], [Destacada]) VALUES (22, 12, 7, N'21_river.jpg', NULL, NULL, 0, 12, N'Remera river', N'imitacion', 0, N'Paternal', 0)
SET IDENTITY_INSERT [dbo].[Publicaciones] OFF
SET IDENTITY_INSERT [dbo].[Usuarios] ON 

INSERT [dbo].[Usuarios] ([IdUsuario], [Nombre], [Apellido], [Mail], [Contrasena], [Imagen], [Puntos], [Especial]) VALUES (2, N'Mariano', N'Resio', N'marianolresio@gmail.com', N'500fa6ecaeb8300905727802af3081', N'rojo.png', 161, 0)
INSERT [dbo].[Usuarios] ([IdUsuario], [Nombre], [Apellido], [Mail], [Contrasena], [Imagen], [Puntos], [Especial]) VALUES (3, N'Matias', N'Len', N'matiaslen25@gmail.com', N'79d21dea5b6567c97156add9c17c12', N'azul.png', 20, 1)
INSERT [dbo].[Usuarios] ([IdUsuario], [Nombre], [Apellido], [Mail], [Contrasena], [Imagen], [Puntos], [Especial]) VALUES (4, N'prueba2', N'bbb', N'bbbb@gmail.com', N'f5f167f44f4964e6c998dee827110c', N'verde.png', 0, 1)
INSERT [dbo].[Usuarios] ([IdUsuario], [Nombre], [Apellido], [Mail], [Contrasena], [Imagen], [Puntos], [Especial]) VALUES (5, N'Ola', N'Alo', N'olita@xd.com', N'd55ad283aa400af464c76d713c07ad', N'azul.png', 0, 0)
INSERT [dbo].[Usuarios] ([IdUsuario], [Nombre], [Apellido], [Mail], [Contrasena], [Imagen], [Puntos], [Especial]) VALUES (6, N'Pruebadmin', N'Adminprueba', N'admin@pif.com', N'd55ad283aa400af464c76d713c07ad', N'azul.png', 0, 1)
INSERT [dbo].[Usuarios] ([IdUsuario], [Nombre], [Apellido], [Mail], [Contrasena], [Imagen], [Puntos], [Especial]) VALUES (7, N'Leo', N'Kristal', N'leo@leo.com', N'759dd1ea6c4c76cedc299039ca4f23', N'verde.png', 8, 0)
INSERT [dbo].[Usuarios] ([IdUsuario], [Nombre], [Apellido], [Mail], [Contrasena], [Imagen], [Puntos], [Especial]) VALUES (8, N'Prueba', N'Prueba', N'prueba@prueba.com', N'0adc3949ba59abbe56e057f20f883e', N'azul.png', 0, 0)
SET IDENTITY_INSERT [dbo].[Usuarios] OFF
/****** Object:  StoredProcedure [dbo].[sp_AltaPublicacion]    Script Date: 29/11/2019 11:59:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_AltaPublicacion]
@pIdCategoria int,
@pIdUsuario int,
@pImagen1 varchar(MAX),
@pImagen2 varchar(MAX),
@pImagen3 varchar(MAX),
@pAprobada bit,
@pValor int,
@pTitulo varchar(MAX),
@pDescripcion varchar(MAX),
@pLikes int,
@pUbicacion varchar(MAX),
@pDestacada bit

AS
INSERT INTO	Publicaciones (IdCategoria, IdUsuario, Aprobada, Imagen1, Imagen2, Imagen3, Valor, Titulo, Descripcion, Likes, Ubicacion, Destacada) 
VALUES (@pIdCategoria, @pIdUsuario, @pAprobada, @pImagen1, @pImagen2, @pImagen3, @pValor, @pTitulo, @pDescripcion, @pLikes, @pUbicacion, @pDestacada)
UPDATE Usuarios SET Puntos = Puntos + 10 WHERE IdUsuario = @pIdUsuario
GO
/****** Object:  StoredProcedure [dbo].[sp_altaUsuario]    Script Date: 29/11/2019 11:59:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_altaUsuario]
@pNombre varchar(50),
@pApellido varchar(50),
@pMail varchar(50),
@pContrasena varchar(50),
@pImagen varchar(MAX),
@pPuntos int,
@pEspecial bit
as
insert into Usuarios (Nombre, Apellido, Mail, Contrasena, Imagen, Puntos, Especial)
values (@pNombre, @pApellido, @pMail, @pContrasena, @pImagen, @pPuntos, @pEspecial)
GO
/****** Object:  StoredProcedure [dbo].[sp_BajaPublicacion]    Script Date: 29/11/2019 11:59:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_BajaPublicacion]
@pId int

as
DELETE FROM Publicaciones WHERE IdPublicacion = @pId
GO
/****** Object:  StoredProcedure [dbo].[sp_borrarCodigoEspecial]    Script Date: 29/11/2019 11:59:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_borrarCodigoEspecial]
@pCodigo varchar(50)
as
delete from Codigos_especiales where codigo = @pCodigo
GO
/****** Object:  StoredProcedure [dbo].[sp_busquedaPublicacionPorTexto]    Script Date: 29/11/2019 11:59:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_busquedaPublicacionPorTexto]
@pBusqueda varchar(MAX)
as
Select * from Publicaciones where Descripcion like '%'+@pBusqueda+'%' or Titulo like '%'+@pBusqueda+'%'
GO
/****** Object:  StoredProcedure [dbo].[sp_Login]    Script Date: 29/11/2019 11:59:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_Login]
@pMail varchar (50),
@pPassword varchar (50)
AS
SELECT * FROM Usuarios WHERE Usuarios.Mail = @pMail AND Usuarios.Contrasena = @pPassword
GO
/****** Object:  StoredProcedure [dbo].[sp_ModificarPublicacion]    Script Date: 29/11/2019 11:59:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ModificarPublicacion]
@pIdPublicacion int,
@pImagen1 varchar(MAX),
@pImagen2 varchar(MAX),
@pImagen3 varchar(MAX),
@pValor int,
@pTitulo varchar(MAX),
@pDescripcion varchar(MAX),
@pUbicacion varchar(MAX),
@pDestacada bit

AS
UPDATE Publicaciones set Imagen1 = @pImagen1, Imagen2 = @pImagen2, Imagen3 = @pImagen3, Valor = @pValor, Titulo = @pTitulo, Descripcion = @pDescripcion, Ubicacion = @pUbicacion, Destacada = @pDestacada
WHERE IdPublicacion = @pIdPublicacion
GO
/****** Object:  StoredProcedure [dbo].[sp_ObtenerPublicacionEspecial]    Script Date: 29/11/2019 11:59:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ObtenerPublicacionEspecial]
@pIdVendedor int,
@pValor int
AS

UPDATE Usuarios SET Puntos = Puntos + @pValor WHERE IdUsuario = @pIdVendedor
GO
/****** Object:  StoredProcedure [dbo].[sp_ObtenerPublicacionNoEspecial]    Script Date: 29/11/2019 11:59:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ObtenerPublicacionNoEspecial]
@pIdComprador int,
@pIdVendedor int,
@pValor int
AS

UPDATE Usuarios SET Puntos = Puntos + @pValor WHERE IdUsuario = @pIdVendedor
UPDATE Usuarios SET Puntos = Puntos- @pValor WHERE IdUsuario = @pIdComprador
GO
/****** Object:  StoredProcedure [dbo].[sp_RegistroUsuario]    Script Date: 29/11/2019 11:59:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_RegistroUsuario]
@pNombre varchar (50),
@pApellido varchar(50),
@pMail varchar (50),
@pPassword varchar (50),
@pPuntos int,
@pImagen varchar(max)
AS
INSERT INTO Usuarios (Nombre, Apellido, Mail, Contrasena, Puntos, Imagen)
VALUES (@pNombre, @pApellido, @pMail, @pPassword, @pPuntos, @pImagen)
GO
/****** Object:  StoredProcedure [dbo].[sp_TraerBannersHome]    Script Date: 29/11/2019 11:59:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_TraerBannersHome]
as

SELECT * FROM Banners
where Hasta > GETDATE()
GO
/****** Object:  StoredProcedure [dbo].[sp_TraerCategoriaPadreDesdeCategoriaHija]    Script Date: 29/11/2019 11:59:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_TraerCategoriaPadreDesdeCategoriaHija]
	@pID int,
	@pIdHija int
AS
BEGIN
	SELECT * FROM Categorias C inner join Publicaciones P on C.IdCategoria = P.IdCategoria
	WHERE C.IdCategoria = @pIdHija AND P.IdUsuario = @pID
END
GO
/****** Object:  StoredProcedure [dbo].[sp_TraerCategoriaPorID]    Script Date: 29/11/2019 11:59:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_TraerCategoriaPorID]
	@pID int
AS
BEGIN
	SELECT * FROM Categorias WHERE IdCategoria = @pID
END
GO
/****** Object:  StoredProcedure [dbo].[sp_TraerCategoriasPadres]    Script Date: 29/11/2019 11:59:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_TraerCategoriasPadres] AS

SELECT * FROM Categorias WHERE Categorias.IdCategoriaPadre = -1
GO
/****** Object:  StoredProcedure [dbo].[sp_TraerCategoriasPorIdPadre]    Script Date: 29/11/2019 11:59:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_TraerCategoriasPorIdPadre] 
@pIdPadre int
AS

SELECT * FROM Categorias
WHERE IdCategoriaPadre = @pIdPadre
GO
/****** Object:  StoredProcedure [dbo].[sp_TraerCategoriasPorNombrePadre]    Script Date: 29/11/2019 11:59:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_TraerCategoriasPorNombrePadre]
@pId int
AS
select * from Categorias where IdCategoriaPadre = @pId
GO
/****** Object:  StoredProcedure [dbo].[sp_traerIDCategoriaPorNombre]    Script Date: 29/11/2019 11:59:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_traerIDCategoriaPorNombre]
@pNombreCate varchar (max)
AS
select * from Categorias where Nombre = @pNombreCate
GO
/****** Object:  StoredProcedure [dbo].[sp_TraerNombreCategoriaPorId]    Script Date: 29/11/2019 11:59:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_TraerNombreCategoriaPorId]
@pId int
AS
SELECT Nombre FROM Categorias WHERE IdCategoria = @pId
GO
/****** Object:  StoredProcedure [dbo].[sp_TraerPublicacionesBusquedaCategoria]    Script Date: 29/11/2019 11:59:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_TraerPublicacionesBusquedaCategoria]
@pIdCate int
as

SELECT * FROM Publicaciones Where IdCategoria = @pIdCate
GO
/****** Object:  StoredProcedure [dbo].[sp_TraerPublicacionesPorCategoria]    Script Date: 29/11/2019 11:59:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_TraerPublicacionesPorCategoria]
@pId int
as
SELECT * FROM Publicaciones WHERE IdCategoria = @pId
GO
/****** Object:  StoredProcedure [dbo].[sp_TraerPublicacionesPorUsuario]    Script Date: 29/11/2019 11:59:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_TraerPublicacionesPorUsuario]
@pId int
AS
SELECT * FROM Publicaciones WHERE IdUsuario = @pId
GO
/****** Object:  StoredProcedure [dbo].[sp_TraerPublicacionPorId]    Script Date: 29/11/2019 11:59:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_TraerPublicacionPorId]
	@pID int
AS
BEGIN
	SELECT * FROM Publicaciones WHERE IdPublicacion = @pID
END
GO
/****** Object:  StoredProcedure [dbo].[sp_TraerTodasLasPublicaciones]    Script Date: 29/11/2019 11:59:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_TraerTodasLasPublicaciones] as
select * from Publicaciones
GO
/****** Object:  StoredProcedure [dbo].[sp_TraerUsuarioPorId]    Script Date: 29/11/2019 11:59:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_TraerUsuarioPorId]
@pId int
AS
SELECT * FROM Usuarios WHERE IdUsuario = @pId
GO
/****** Object:  StoredProcedure [dbo].[sp_UltimaPublicacion]    Script Date: 29/11/2019 11:59:33 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_UsuarioAlta]    Script Date: 29/11/2019 11:59:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_UsuarioAlta]
@pNombre varchar(50),
@pApellido varchar(50),
@pMail varchar(50),
@pPass varchar(50),
@pImg varchar(50),
@pPuntos int
as

insert into Usuarios (Nombre, Apellido, Mail, Contrasena, Imagen, Puntos)
values (@pNombre, @pApellido, @pMail, @pPass, @pImg, @pPuntos)
GO
/****** Object:  StoredProcedure [dbo].[sp_UsuarioBaja]    Script Date: 29/11/2019 11:59:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_UsuarioBaja]
@pId int
as

delete from Usuarios where IdUSuario = @pId
GO
/****** Object:  StoredProcedure [dbo].[sp_UsuarioModificacion]    Script Date: 29/11/2019 11:59:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_UsuarioModificacion]
@pId int,
@pNombre varchar(50),
@pApellido varchar(50),
@pMail varchar(50),
@pPass varchar(50),
@pImg varchar(50),
@pPuntos int
as

update Usuarios set Nombre = @pNombre, Apellido = @pApellido, Mail = @pMail, Contrasena = @pPass, Imagen = @pImg, Puntos = @pPuntos
where IdUsuario = @pId
GO
/****** Object:  StoredProcedure [dbo].[sp_UsuariosTraer]    Script Date: 29/11/2019 11:59:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_UsuariosTraer]
@pId int
as

select * from Usuarios
GO
/****** Object:  StoredProcedure [dbo].[sp_UsuarioTraerPorID]    Script Date: 29/11/2019 11:59:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_UsuarioTraerPorID]
@pId int
as

select * from Usuarios where IdUSuario = @pId
GO
/****** Object:  StoredProcedure [dbo].[sp_ValidarUsuarioEspecialPorCodigo]    Script Date: 29/11/2019 11:59:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_ValidarUsuarioEspecialPorCodigo]
@pCodigo varchar (MAX)
as
select * from Codigos_especiales where codigo = @pCodigo
GO
USE [master]
GO
ALTER DATABASE [PayItForward] SET  READ_WRITE 
GO
