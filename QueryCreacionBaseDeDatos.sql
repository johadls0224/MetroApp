USE [master]
GO
/****** Object:  Database [MetroApp]    Script Date: 24/03/06 10:15:52 PM ******/
CREATE DATABASE [MetroApp]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'MetroApp', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\MetroApp.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'MetroApp_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\MetroApp_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [MetroApp] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MetroApp].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MetroApp] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MetroApp] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MetroApp] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MetroApp] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MetroApp] SET ARITHABORT OFF 
GO
ALTER DATABASE [MetroApp] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [MetroApp] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MetroApp] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MetroApp] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MetroApp] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [MetroApp] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MetroApp] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MetroApp] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MetroApp] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MetroApp] SET  DISABLE_BROKER 
GO
ALTER DATABASE [MetroApp] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MetroApp] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MetroApp] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MetroApp] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MetroApp] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MetroApp] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [MetroApp] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MetroApp] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [MetroApp] SET  MULTI_USER 
GO
ALTER DATABASE [MetroApp] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MetroApp] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MetroApp] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MetroApp] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [MetroApp] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [MetroApp] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [MetroApp] SET QUERY_STORE = ON
GO
ALTER DATABASE [MetroApp] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [MetroApp]
GO
/****** Object:  Table [dbo].[Notificacion]    Script Date: 24/03/06 10:15:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Notificacion](
	[RecargaId] [int] IDENTITY(1,1) NOT NULL,
	[Fecha] [datetime] NULL,
	[Monto] [numeric](18, 0) NULL,
	[Cedula] [nvarchar](50) NULL,
	[TarjetaId] [int] NULL,
 CONSTRAINT [PK_Notificacion] PRIMARY KEY CLUSTERED 
(
	[RecargaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pagos]    Script Date: 24/03/06 10:15:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pagos](
	[PagoId] [int] IDENTITY(1,1) NOT NULL,
	[Fecha] [datetime] NULL,
	[Monto] [numeric](18, 0) NULL,
	[EstadoPago] [int] NULL,
	[Cedula] [nvarchar](50) NULL,
	[TarjetaId] [int] NULL,
 CONSTRAINT [PK_Pagos] PRIMARY KEY CLUSTERED 
(
	[PagoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TarjetaMetro]    Script Date: 24/03/06 10:15:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TarjetaMetro](
	[TarjetaId] [int] IDENTITY(1,1) NOT NULL,
	[NumeroTarjeta] [nvarchar](40) NULL,
	[Saldo] [numeric](18, 0) NULL,
	[Cedula] [nvarchar](40) NULL,
 CONSTRAINT [PK_TarjetaMetro] PRIMARY KEY CLUSTERED 
(
	[TarjetaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TarjetaPagos]    Script Date: 24/03/06 10:15:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TarjetaPagos](
	[TarjetaPagoId] [int] NOT NULL,
	[Tipo] [int] NULL,
	[NumeroTarjeta] [nvarchar](50) NULL,
	[FechaVencimiento] [datetime] NULL,
	[CodigoSeguridad] [int] NULL,
	[Cedula] [nvarchar](50) NULL,
 CONSTRAINT [PK_TarjetaPagos] PRIMARY KEY CLUSTERED 
(
	[TarjetaPagoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 24/03/06 10:15:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[Cedula] [nvarchar](30) NOT NULL,
	[TipoDocumento] [int] NULL,
	[Nombre] [nvarchar](30) NULL,
	[Email] [nvarchar](50) NULL,
	[Password] [nvarchar](30) NULL,
	[Telefono] [int] NULL,
	[FechaRegistro] [datetime] NULL,
	[EstadoUsuario] [nvarchar](50) NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[Cedula] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [MetroApp] SET  READ_WRITE 
GO