USE [master]
GO
/****** Object:  Database [SalasDeConferencia]    Script Date: 12/11/2020 12:23:57 ******/
CREATE DATABASE [SalasDeConferencia]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SalasDeConferencia', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\SalasDeConferencia.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'SalasDeConferencia_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\SalasDeConferencia_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [SalasDeConferencia] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SalasDeConferencia].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SalasDeConferencia] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SalasDeConferencia] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SalasDeConferencia] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SalasDeConferencia] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SalasDeConferencia] SET ARITHABORT OFF 
GO
ALTER DATABASE [SalasDeConferencia] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SalasDeConferencia] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SalasDeConferencia] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SalasDeConferencia] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SalasDeConferencia] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SalasDeConferencia] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SalasDeConferencia] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SalasDeConferencia] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SalasDeConferencia] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SalasDeConferencia] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SalasDeConferencia] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SalasDeConferencia] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SalasDeConferencia] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SalasDeConferencia] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SalasDeConferencia] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SalasDeConferencia] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SalasDeConferencia] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SalasDeConferencia] SET RECOVERY FULL 
GO
ALTER DATABASE [SalasDeConferencia] SET  MULTI_USER 
GO
ALTER DATABASE [SalasDeConferencia] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SalasDeConferencia] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SalasDeConferencia] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SalasDeConferencia] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [SalasDeConferencia] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'SalasDeConferencia', N'ON'
GO
USE [SalasDeConferencia]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 12/11/2020 12:23:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Reservas]    Script Date: 12/11/2020 12:23:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reservas](
	[ReservasId] [int] IDENTITY(1,1) NOT NULL,
	[SalaId] [int] NOT NULL,
	[HoraInicio] [datetime] NOT NULL,
	[HoraFin] [datetime] NOT NULL,
	[NombreReserva] [nvarchar](50) NOT NULL,
	[CantidadDeGente] [int] NOT NULL,
	[EstadoReservacion] [nvarchar](max) NULL,
	[AccesoInet] [bit] NOT NULL DEFAULT (CONVERT([bit],(0))),
	[Pizarra] [bit] NOT NULL DEFAULT (CONVERT([bit],(0))),
	[Proyector] [bit] NOT NULL DEFAULT (CONVERT([bit],(0))),
 CONSTRAINT [PK_Reservas] PRIMARY KEY CLUSTERED 
(
	[ReservasId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Salas]    Script Date: 12/11/2020 12:23:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Salas](
	[SalaId] [int] IDENTITY(1,1) NOT NULL,
	[NumeroDeSala] [int] NOT NULL,
	[Capacidad] [int] NOT NULL,
	[Proyector] [bit] NOT NULL,
	[Pizarra] [bit] NOT NULL,
	[AccesoInet] [bit] NOT NULL,
 CONSTRAINT [PK_Salas] PRIMARY KEY CLUSTERED 
(
	[SalaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
USE [master]
GO
ALTER DATABASE [SalasDeConferencia] SET  READ_WRITE 
GO
