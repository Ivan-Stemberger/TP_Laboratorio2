USE [master]
GO
/****** Object:  Database [Games]    Script Date: 05/12/2021 23:31:37 ******/
CREATE DATABASE [Games]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Games', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Games.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Games_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Games_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Games] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Games].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Games] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Games] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Games] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Games] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Games] SET ARITHABORT OFF 
GO
ALTER DATABASE [Games] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Games] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Games] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Games] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Games] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Games] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Games] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Games] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Games] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Games] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Games] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Games] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Games] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Games] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Games] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Games] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Games] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Games] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Games] SET  MULTI_USER 
GO
ALTER DATABASE [Games] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Games] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Games] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Games] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Games] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Games] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Games] SET QUERY_STORE = OFF
GO
USE [Games]
GO
/****** Object:  Table [dbo].[Elo]    Script Date: 05/12/2021 23:31:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Elo](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Elo] PRIMARY KEY CLUSTERED 
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Games]    Script Date: 05/12/2021 23:31:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Games](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Lol_Champions]    Script Date: 05/12/2021 23:31:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lol_Champions](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Lol_Champions] PRIMARY KEY CLUSTERED 
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Lol_Matches]    Script Date: 05/12/2021 23:31:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lol_Matches](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Champion] [nvarchar](50) NOT NULL,
	[Role] [nvarchar](50) NOT NULL,
	[Elo] [nvarchar](50) NOT NULL,
	[Region] [nvarchar](50) NOT NULL,
	[Win] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Lol_Roles]    Script Date: 05/12/2021 23:31:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lol_Roles](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Lol_Roles_1] PRIMARY KEY CLUSTERED 
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Regions]    Script Date: 05/12/2021 23:31:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Regions](
	[ID] [int] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Regions_1] PRIMARY KEY CLUSTERED 
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tft_Compositions]    Script Date: 05/12/2021 23:31:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tft_Compositions](
	[Id] [int] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Tft_Compositions_1] PRIMARY KEY CLUSTERED 
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tft_Matches]    Script Date: 05/12/2021 23:31:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tft_Matches](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Composition] [nvarchar](50) NULL,
	[Elo] [nvarchar](50) NULL,
	[Position] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tft_Positions]    Script Date: 05/12/2021 23:31:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tft_Positions](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Tft_Positions] PRIMARY KEY CLUSTERED 
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Lol_Matches]  WITH CHECK ADD  CONSTRAINT [FK_Lol_Matches_Elo] FOREIGN KEY([Elo])
REFERENCES [dbo].[Elo] ([Name])
GO
ALTER TABLE [dbo].[Lol_Matches] CHECK CONSTRAINT [FK_Lol_Matches_Elo]
GO
ALTER TABLE [dbo].[Lol_Matches]  WITH CHECK ADD  CONSTRAINT [FK_Lol_Matches_Lol_Champions] FOREIGN KEY([Champion])
REFERENCES [dbo].[Lol_Champions] ([Name])
GO
ALTER TABLE [dbo].[Lol_Matches] CHECK CONSTRAINT [FK_Lol_Matches_Lol_Champions]
GO
ALTER TABLE [dbo].[Lol_Matches]  WITH CHECK ADD  CONSTRAINT [FK_Lol_Matches_Lol_Roles] FOREIGN KEY([Role])
REFERENCES [dbo].[Lol_Roles] ([Name])
GO
ALTER TABLE [dbo].[Lol_Matches] CHECK CONSTRAINT [FK_Lol_Matches_Lol_Roles]
GO
ALTER TABLE [dbo].[Lol_Matches]  WITH CHECK ADD  CONSTRAINT [FK_Lol_Matches_Regions] FOREIGN KEY([Region])
REFERENCES [dbo].[Regions] ([Name])
GO
ALTER TABLE [dbo].[Lol_Matches] CHECK CONSTRAINT [FK_Lol_Matches_Regions]
GO
ALTER TABLE [dbo].[Tft_Matches]  WITH CHECK ADD  CONSTRAINT [FK_Tft_Matches_Elo] FOREIGN KEY([Elo])
REFERENCES [dbo].[Elo] ([Name])
GO
ALTER TABLE [dbo].[Tft_Matches] CHECK CONSTRAINT [FK_Tft_Matches_Elo]
GO
ALTER TABLE [dbo].[Tft_Matches]  WITH CHECK ADD  CONSTRAINT [FK_Tft_Matches_Tft_Compositions] FOREIGN KEY([Composition])
REFERENCES [dbo].[Tft_Compositions] ([Name])
GO
ALTER TABLE [dbo].[Tft_Matches] CHECK CONSTRAINT [FK_Tft_Matches_Tft_Compositions]
GO
ALTER TABLE [dbo].[Tft_Matches]  WITH CHECK ADD  CONSTRAINT [FK_Tft_Matches_Tft_Positions] FOREIGN KEY([Position])
REFERENCES [dbo].[Tft_Positions] ([Name])
GO
ALTER TABLE [dbo].[Tft_Matches] CHECK CONSTRAINT [FK_Tft_Matches_Tft_Positions]
GO
USE [master]
GO
ALTER DATABASE [Games] SET  READ_WRITE 
GO
