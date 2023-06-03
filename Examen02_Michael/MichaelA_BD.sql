USE [master]
GO
/****** Object:  Database [MichaelA_BD]    Script Date: 30/5/2023 04:47:24 ******/
CREATE DATABASE [MichaelA_BD]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'MichaelA_BD', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\MichaelA_BD.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'MichaelA_BD_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\MichaelA_BD_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [MichaelA_BD] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MichaelA_BD].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MichaelA_BD] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MichaelA_BD] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MichaelA_BD] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MichaelA_BD] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MichaelA_BD] SET ARITHABORT OFF 
GO
ALTER DATABASE [MichaelA_BD] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [MichaelA_BD] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MichaelA_BD] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MichaelA_BD] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MichaelA_BD] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [MichaelA_BD] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MichaelA_BD] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MichaelA_BD] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MichaelA_BD] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MichaelA_BD] SET  DISABLE_BROKER 
GO
ALTER DATABASE [MichaelA_BD] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MichaelA_BD] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MichaelA_BD] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MichaelA_BD] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MichaelA_BD] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MichaelA_BD] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [MichaelA_BD] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MichaelA_BD] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [MichaelA_BD] SET  MULTI_USER 
GO
ALTER DATABASE [MichaelA_BD] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MichaelA_BD] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MichaelA_BD] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MichaelA_BD] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [MichaelA_BD] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [MichaelA_BD] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'MichaelA_BD', N'ON'
GO
ALTER DATABASE [MichaelA_BD] SET QUERY_STORE = OFF
GO
USE [MichaelA_BD]
GO
/****** Object:  Table [dbo].[tbChofers]    Script Date: 30/5/2023 04:47:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbChofers](
	[cedula] [nchar](12) NOT NULL,
	[nombre] [nchar](12) NOT NULL,
	[apellido1] [nchar](12) NOT NULL,
	[apellido2] [nchar](12) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[cedula] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbLicenciaChofer]    Script Date: 30/5/2023 04:47:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbLicenciaChofer](
	[idLicencia] [nchar](12) NOT NULL,
	[idTipoLicencia] [nchar](3) NOT NULL,
	[fechaEmicion] [date] NOT NULL,
	[fechaVenc] [date] NOT NULL,
 CONSTRAINT [PK__tbLicenc__3213E83FD6450157] PRIMARY KEY CLUSTERED 
(
	[idLicencia] ASC,
	[idTipoLicencia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbTipoLicencia]    Script Date: 30/5/2023 04:47:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbTipoLicencia](
	[idTipoLicencia] [nchar](3) NOT NULL,
	[descripcion] [varchar](500) NULL,
	[estado] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idTipoLicencia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[tbLicenciaChofer]  WITH CHECK ADD  CONSTRAINT [FK_tbLicenciaChofer_tbChofers] FOREIGN KEY([idLicencia])
REFERENCES [dbo].[tbChofers] ([cedula])
GO
ALTER TABLE [dbo].[tbLicenciaChofer] CHECK CONSTRAINT [FK_tbLicenciaChofer_tbChofers]
GO
ALTER TABLE [dbo].[tbLicenciaChofer]  WITH CHECK ADD  CONSTRAINT [FK_tbLicenciaChofer_tbTipoLicencia] FOREIGN KEY([idTipoLicencia])
REFERENCES [dbo].[tbTipoLicencia] ([idTipoLicencia])
GO
ALTER TABLE [dbo].[tbLicenciaChofer] CHECK CONSTRAINT [FK_tbLicenciaChofer_tbTipoLicencia]
GO
USE [master]
GO
ALTER DATABASE [MichaelA_BD] SET  READ_WRITE 
GO
