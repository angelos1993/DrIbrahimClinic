USE [master]
GO
/****** Object:  Database [DrIbrahimClinic]    Script Date: 1/27/2017 6:43:19 PM ******/
CREATE DATABASE [DrIbrahimClinic]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DrIbrahimClinic', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\DrIbrahimClinic.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'DrIbrahimClinic_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\DrIbrahimClinic_log.ldf' , SIZE = 2304KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [DrIbrahimClinic] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DrIbrahimClinic].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DrIbrahimClinic] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DrIbrahimClinic] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DrIbrahimClinic] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DrIbrahimClinic] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DrIbrahimClinic] SET ARITHABORT OFF 
GO
ALTER DATABASE [DrIbrahimClinic] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DrIbrahimClinic] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [DrIbrahimClinic] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DrIbrahimClinic] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DrIbrahimClinic] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DrIbrahimClinic] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DrIbrahimClinic] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DrIbrahimClinic] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DrIbrahimClinic] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DrIbrahimClinic] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DrIbrahimClinic] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DrIbrahimClinic] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DrIbrahimClinic] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DrIbrahimClinic] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DrIbrahimClinic] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DrIbrahimClinic] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DrIbrahimClinic] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DrIbrahimClinic] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DrIbrahimClinic] SET RECOVERY FULL 
GO
ALTER DATABASE [DrIbrahimClinic] SET  MULTI_USER 
GO
ALTER DATABASE [DrIbrahimClinic] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DrIbrahimClinic] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DrIbrahimClinic] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DrIbrahimClinic] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [DrIbrahimClinic]
GO
/****** Object:  StoredProcedure [dbo].[ResetDB]    Script Date: 1/27/2017 6:43:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ResetDB]
AS
BEGIN
	--delete all records
	--use truncate instead (ry7 dma8k ;) :D )
	--reset identity
	DBCC CHECKIDENT('Examinations', RESEED, 0);
	DBCC CHECKIDENT('ExaminationSign', RESEED, 0);
	DBCC CHECKIDENT('ExaminationSymptom', RESEED, 0);
	DBCC CHECKIDENT('ExaminationTreatment', RESEED, 0);
	DBCC CHECKIDENT('Patients', RESEED, 0);
	DBCC CHECKIDENT('Signs', RESEED, 0);
	DBCC CHECKIDENT('Symptoms', RESEED, 0);
	DBCC CHECKIDENT('Treatments', RESEED, 0);
END
GO
/****** Object:  Table [dbo].[Diagnosis]    Script Date: 1/27/2017 6:43:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Diagnosis](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Signs] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ExaminationDiagnosis]    Script Date: 1/27/2017 6:43:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ExaminationDiagnosis](
	[Id] [int] NOT NULL,
	[ExaminationId] [int] NULL,
	[DisgnosisId] [int] NOT NULL,
 CONSTRAINT [PK_ExaminationSign] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Examinations]    Script Date: 1/27/2017 6:43:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Examinations](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PatientId] [int] NOT NULL,
	[Date] [date] NOT NULL,
	[ExaminationType] [tinyint] NOT NULL,
	[Complaint] [nvarchar](max) NOT NULL,
	[PatientLength] [float] NOT NULL,
	[PatientWeight] [float] NOT NULL,
	[HeadCircumference] [float] NOT NULL,
 CONSTRAINT [PK_Examination] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ExaminationTreatment]    Script Date: 1/27/2017 6:43:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ExaminationTreatment](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ExaminationId] [int] NOT NULL,
	[MedicationId] [int] NOT NULL,
	[Description] [nvarchar](max) NULL,
 CONSTRAINT [PK_ExaminationMedication] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Inoculations]    Script Date: 1/27/2017 6:43:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Inoculations](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PatientId] [int] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Date] [date] NULL,
 CONSTRAINT [PK_Inoculations] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[MedicalHistory]    Script Date: 1/27/2017 6:43:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MedicalHistory](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PatientId] [int] NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_MedicalHistory] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Patients]    Script Date: 1/27/2017 6:43:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Patients](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Birthdate] [date] NULL,
	[Gender] [char](1) NOT NULL,
	[Address] [nvarchar](50) NULL,
	[Phone] [nvarchar](11) NULL,
	[BirthType] [tinyint] NOT NULL,
	[SucklingType] [tinyint] NOT NULL,
 CONSTRAINT [PK_Patient] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Treatments]    Script Date: 1/27/2017 6:43:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Treatments](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Medications] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[ExaminationDiagnosis]  WITH CHECK ADD  CONSTRAINT [FK_ExaminationSign_Examinations] FOREIGN KEY([ExaminationId])
REFERENCES [dbo].[Examinations] ([Id])
GO
ALTER TABLE [dbo].[ExaminationDiagnosis] CHECK CONSTRAINT [FK_ExaminationSign_Examinations]
GO
ALTER TABLE [dbo].[ExaminationDiagnosis]  WITH CHECK ADD  CONSTRAINT [FK_ExaminationSign_Signs] FOREIGN KEY([DisgnosisId])
REFERENCES [dbo].[Diagnosis] ([Id])
GO
ALTER TABLE [dbo].[ExaminationDiagnosis] CHECK CONSTRAINT [FK_ExaminationSign_Signs]
GO
ALTER TABLE [dbo].[Examinations]  WITH CHECK ADD  CONSTRAINT [FK_Examinations_Patients] FOREIGN KEY([PatientId])
REFERENCES [dbo].[Patients] ([Id])
GO
ALTER TABLE [dbo].[Examinations] CHECK CONSTRAINT [FK_Examinations_Patients]
GO
ALTER TABLE [dbo].[ExaminationTreatment]  WITH CHECK ADD  CONSTRAINT [FK_ExaminationMedication_Examinations] FOREIGN KEY([ExaminationId])
REFERENCES [dbo].[Examinations] ([Id])
GO
ALTER TABLE [dbo].[ExaminationTreatment] CHECK CONSTRAINT [FK_ExaminationMedication_Examinations]
GO
ALTER TABLE [dbo].[ExaminationTreatment]  WITH CHECK ADD  CONSTRAINT [FK_ExaminationMedication_Medications] FOREIGN KEY([MedicationId])
REFERENCES [dbo].[Treatments] ([Id])
GO
ALTER TABLE [dbo].[ExaminationTreatment] CHECK CONSTRAINT [FK_ExaminationMedication_Medications]
GO
ALTER TABLE [dbo].[Inoculations]  WITH CHECK ADD  CONSTRAINT [FK_Inoculations_Patients] FOREIGN KEY([PatientId])
REFERENCES [dbo].[Patients] ([Id])
GO
ALTER TABLE [dbo].[Inoculations] CHECK CONSTRAINT [FK_Inoculations_Patients]
GO
ALTER TABLE [dbo].[MedicalHistory]  WITH CHECK ADD  CONSTRAINT [FK_MedicalHistory_Patients] FOREIGN KEY([PatientId])
REFERENCES [dbo].[Patients] ([Id])
GO
ALTER TABLE [dbo].[MedicalHistory] CHECK CONSTRAINT [FK_MedicalHistory_Patients]
GO
USE [master]
GO
ALTER DATABASE [DrIbrahimClinic] SET  READ_WRITE 
GO
