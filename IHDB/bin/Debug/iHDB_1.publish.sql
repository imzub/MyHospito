﻿/*
Deployment script for TestDB2

This code was generated by a tool.
Changes to this file may cause incorrect behavior and will be lost if
the code is regenerated.
*/

GO
SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER ON;

SET NUMERIC_ROUNDABORT OFF;


GO
:setvar DatabaseName "TestDB2"
:setvar DefaultFilePrefix "TestDB2"
:setvar DefaultDataPath "D:\Apps\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\"
:setvar DefaultLogPath "D:\Apps\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\"

GO
:on error exit
GO
/*
Detect SQLCMD mode and disable script execution if SQLCMD mode is not supported.
To re-enable the script after enabling SQLCMD mode, execute the following:
SET NOEXEC OFF; 
*/
:setvar __IsSqlCmdEnabled "True"
GO
IF N'$(__IsSqlCmdEnabled)' NOT LIKE N'True'
    BEGIN
        PRINT N'SQLCMD mode must be enabled to successfully execute this script.';
        SET NOEXEC ON;
    END


GO
USE [master];


GO

IF (DB_ID(N'$(DatabaseName)') IS NOT NULL) 
BEGIN
    ALTER DATABASE [$(DatabaseName)]
    SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE [$(DatabaseName)];
END

GO
PRINT N'Creating database $(DatabaseName)...'
GO
CREATE DATABASE [$(DatabaseName)]
    ON 
    PRIMARY(NAME = [$(DatabaseName)], FILENAME = N'$(DefaultDataPath)$(DefaultFilePrefix)_Primary.mdf')
    LOG ON (NAME = [$(DatabaseName)_log], FILENAME = N'$(DefaultLogPath)$(DefaultFilePrefix)_Primary.ldf') COLLATE SQL_Latin1_General_CP1_CI_AS
GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET AUTO_CLOSE ON 
            WITH ROLLBACK IMMEDIATE;
    END


GO
USE [$(DatabaseName)];


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET ANSI_NULLS OFF,
                ANSI_PADDING OFF,
                ANSI_WARNINGS OFF,
                ARITHABORT OFF,
                CONCAT_NULL_YIELDS_NULL OFF,
                NUMERIC_ROUNDABORT OFF,
                QUOTED_IDENTIFIER OFF,
                ANSI_NULL_DEFAULT OFF,
                CURSOR_DEFAULT GLOBAL,
                RECOVERY SIMPLE,
                CURSOR_CLOSE_ON_COMMIT OFF,
                AUTO_CREATE_STATISTICS ON,
                AUTO_SHRINK OFF,
                AUTO_UPDATE_STATISTICS ON,
                RECURSIVE_TRIGGERS OFF 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET ALLOW_SNAPSHOT_ISOLATION OFF;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET READ_COMMITTED_SNAPSHOT OFF 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET AUTO_UPDATE_STATISTICS_ASYNC OFF,
                PAGE_VERIFY CHECKSUM,
                DATE_CORRELATION_OPTIMIZATION OFF,
                ENABLE_BROKER,
                PARAMETERIZATION SIMPLE,
                SUPPLEMENTAL_LOGGING OFF 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF IS_SRVROLEMEMBER(N'sysadmin') = 1
    BEGIN
        IF EXISTS (SELECT 1
                   FROM   [master].[dbo].[sysdatabases]
                   WHERE  [name] = N'$(DatabaseName)')
            BEGIN
                EXECUTE sp_executesql N'ALTER DATABASE [$(DatabaseName)]
    SET TRUSTWORTHY OFF,
        DB_CHAINING OFF 
    WITH ROLLBACK IMMEDIATE';
            END
    END
ELSE
    BEGIN
        PRINT N'The database settings cannot be modified. You must be a SysAdmin to apply these settings.';
    END


GO
IF IS_SRVROLEMEMBER(N'sysadmin') = 1
    BEGIN
        IF EXISTS (SELECT 1
                   FROM   [master].[dbo].[sysdatabases]
                   WHERE  [name] = N'$(DatabaseName)')
            BEGIN
                EXECUTE sp_executesql N'ALTER DATABASE [$(DatabaseName)]
    SET HONOR_BROKER_PRIORITY OFF 
    WITH ROLLBACK IMMEDIATE';
            END
    END
ELSE
    BEGIN
        PRINT N'The database settings cannot be modified. You must be a SysAdmin to apply these settings.';
    END


GO
ALTER DATABASE [$(DatabaseName)]
    SET TARGET_RECOVERY_TIME = 60 SECONDS 
    WITH ROLLBACK IMMEDIATE;


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET FILESTREAM(NON_TRANSACTED_ACCESS = OFF),
                CONTAINMENT = NONE 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET AUTO_CREATE_STATISTICS ON(INCREMENTAL = OFF),
                MEMORY_OPTIMIZED_ELEVATE_TO_SNAPSHOT = OFF,
                DELAYED_DURABILITY = DISABLED 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET QUERY_STORE (QUERY_CAPTURE_MODE = AUTO, OPERATION_MODE = READ_WRITE, DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_PLANS_PER_QUERY = 200, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), MAX_STORAGE_SIZE_MB = 1000) 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
        ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
        ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
        ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
        ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
        ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
        ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
        ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET TEMPORAL_HISTORY_RETENTION ON 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF fulltextserviceproperty(N'IsFulltextInstalled') = 1
    EXECUTE sp_fulltext_database 'enable';


GO
PRINT N'Creating Table [dbo].[Diseases]...';


GO
CREATE TABLE [dbo].[Diseases] (
    [dsId]   INT           NOT NULL,
    [dsName] VARCHAR (100) NULL,
    [dsDesc] VARCHAR (200) NULL,
    PRIMARY KEY CLUSTERED ([dsId] ASC)
);


GO
PRINT N'Creating Table [dbo].[Doctor]...';


GO
CREATE TABLE [dbo].[Doctor] (
    [doctorId] INT           NOT NULL,
    [name]     VARCHAR (50)  NOT NULL,
    [contact]  VARCHAR (50)  NULL,
    [address]  VARCHAR (100) NULL,
    [email]    VARCHAR (50)  NULL,
    [gender]   VARCHAR (20)  NOT NULL,
    PRIMARY KEY CLUSTERED ([doctorId] ASC)
);


GO
PRINT N'Creating Table [dbo].[Excercises]...';


GO
CREATE TABLE [dbo].[Excercises] (
    [eId]       INT           NOT NULL,
    [eName]     VARCHAR (100) NULL,
    [eDesc]     VARCHAR (300) NULL,
    [eDuration] INT           NULL,
    PRIMARY KEY CLUSTERED ([eId] ASC)
);


GO
PRINT N'Creating Table [dbo].[Fees]...';


GO
CREATE TABLE [dbo].[Fees] (
    [feesId] INT NOT NULL,
    [fees]   INT NULL,
    PRIMARY KEY CLUSTERED ([feesId] ASC)
);


GO
PRINT N'Creating Table [dbo].[IllnessSeverity]...';


GO
CREATE TABLE [dbo].[IllnessSeverity] (
    [isId]   INT           NOT NULL,
    [isName] VARCHAR (100) NULL,
    [isDesc] VARCHAR (300) NULL,
    PRIMARY KEY CLUSTERED ([isId] ASC)
);


GO
PRINT N'Creating Table [dbo].[Medicines]...';


GO
CREATE TABLE [dbo].[Medicines] (
    [mId]   INT           NOT NULL,
    [mName] VARCHAR (100) NULL,
    [mDesc] VARCHAR (300) NULL,
    [mMRP]  INT           NULL,
    PRIMARY KEY CLUSTERED ([mId] ASC)
);


GO
PRINT N'Creating Table [dbo].[Patient]...';


GO
CREATE TABLE [dbo].[Patient] (
    [patientId] INT           IDENTITY (1, 1) NOT NULL,
    [name]      VARCHAR (100) NULL,
    [contact]   VARCHAR (50)  NULL,
    [address]   VARCHAR (50)  NULL,
    [email]     VARCHAR (50)  NULL,
    [gender]    VARCHAR (20)  NULL,
    [doctorId]  INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([patientId] ASC)
);


GO
PRINT N'Creating Table [dbo].[patientDiseases]...';


GO
CREATE TABLE [dbo].[patientDiseases] (
    [pdId]           INT           NOT NULL,
    [pdDesc]         VARCHAR (100) NULL,
    [patientVisitId] INT           NOT NULL,
    [patientId]      INT           NOT NULL,
    [dsId]           INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([pdId] ASC)
);


GO
PRINT N'Creating Table [dbo].[patientSymptons]...';


GO
CREATE TABLE [dbo].[patientSymptons] (
    [psId]           INT           NOT NULL,
    [psDesc]         VARCHAR (100) NULL,
    [patientVisitId] INT           NOT NULL,
    [patientId]      INT           NOT NULL,
    [smId]           INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([psId] ASC)
);


GO
PRINT N'Creating Table [dbo].[PatientTreatment]...';


GO
CREATE TABLE [dbo].[PatientTreatment] (
    [ptId]             INT           NOT NULL,
    [ptDesc]           VARCHAR (200) NULL,
    [patientVisitId]   INT           NOT NULL,
    [patientId]        INT           NOT NULL,
    [tId]              INT           NOT NULL,
    [prescriptionItem] VARCHAR (150) NULL,
    PRIMARY KEY CLUSTERED ([ptId] ASC)
);


GO
PRINT N'Creating Table [dbo].[PatientVisit]...';


GO
CREATE TABLE [dbo].[PatientVisit] (
    [patientVisitId] INT          NOT NULL,
    [patientId]      INT          NOT NULL,
    [concerns]       VARCHAR (40) NOT NULL,
    [symptoms]       VARCHAR (40) NOT NULL,
    [doctorId]       INT          NOT NULL,
    [feesId]         INT          NULL,
    [paidFees]       INT          NULL,
    PRIMARY KEY CLUSTERED ([patientVisitId] ASC)
);


GO
PRINT N'Creating Table [dbo].[Symptoms]...';


GO
CREATE TABLE [dbo].[Symptoms] (
    [smId]   INT           NOT NULL,
    [smName] VARCHAR (100) NULL,
    [smDesc] VARCHAR (200) NULL,
    PRIMARY KEY CLUSTERED ([smId] ASC)
);


GO
PRINT N'Creating Table [dbo].[Treatment]...';


GO
CREATE TABLE [dbo].[Treatment] (
    [tId]   INT           NOT NULL,
    [tName] VARCHAR (100) NULL,
    [tDesc] VARCHAR (200) NULL,
    [tType] VARCHAR (50)  NULL,
    PRIMARY KEY CLUSTERED ([tId] ASC)
);


GO
PRINT N'Creating Foreign Key unnamed constraint on [dbo].[patientDiseases]...';


GO
ALTER TABLE [dbo].[patientDiseases]
    ADD FOREIGN KEY ([dsId]) REFERENCES [dbo].[Diseases] ([dsId]);


GO
PRINT N'Creating Foreign Key unnamed constraint on [dbo].[patientDiseases]...';


GO
ALTER TABLE [dbo].[patientDiseases]
    ADD FOREIGN KEY ([patientId]) REFERENCES [dbo].[Patient] ([patientId]);


GO
PRINT N'Creating Foreign Key unnamed constraint on [dbo].[patientDiseases]...';


GO
ALTER TABLE [dbo].[patientDiseases]
    ADD FOREIGN KEY ([patientVisitId]) REFERENCES [dbo].[PatientVisit] ([patientVisitId]);


GO
PRINT N'Creating Foreign Key unnamed constraint on [dbo].[patientSymptons]...';


GO
ALTER TABLE [dbo].[patientSymptons]
    ADD FOREIGN KEY ([patientId]) REFERENCES [dbo].[Patient] ([patientId]);


GO
PRINT N'Creating Foreign Key unnamed constraint on [dbo].[patientSymptons]...';


GO
ALTER TABLE [dbo].[patientSymptons]
    ADD FOREIGN KEY ([patientVisitId]) REFERENCES [dbo].[PatientVisit] ([patientVisitId]);


GO
PRINT N'Creating Foreign Key unnamed constraint on [dbo].[patientSymptons]...';


GO
ALTER TABLE [dbo].[patientSymptons]
    ADD FOREIGN KEY ([smId]) REFERENCES [dbo].[Symptoms] ([smId]);


GO
PRINT N'Creating Foreign Key unnamed constraint on [dbo].[PatientTreatment]...';


GO
ALTER TABLE [dbo].[PatientTreatment]
    ADD FOREIGN KEY ([patientId]) REFERENCES [dbo].[Patient] ([patientId]);


GO
PRINT N'Creating Foreign Key unnamed constraint on [dbo].[PatientTreatment]...';


GO
ALTER TABLE [dbo].[PatientTreatment]
    ADD FOREIGN KEY ([patientVisitId]) REFERENCES [dbo].[PatientVisit] ([patientVisitId]);


GO
PRINT N'Creating Foreign Key unnamed constraint on [dbo].[PatientTreatment]...';


GO
ALTER TABLE [dbo].[PatientTreatment]
    ADD FOREIGN KEY ([tId]) REFERENCES [dbo].[Treatment] ([tId]);


GO
PRINT N'Creating Foreign Key unnamed constraint on [dbo].[PatientVisit]...';


GO
ALTER TABLE [dbo].[PatientVisit]
    ADD FOREIGN KEY ([doctorId]) REFERENCES [dbo].[Doctor] ([doctorId]);


GO
PRINT N'Creating Foreign Key unnamed constraint on [dbo].[PatientVisit]...';


GO
ALTER TABLE [dbo].[PatientVisit]
    ADD FOREIGN KEY ([feesId]) REFERENCES [dbo].[Fees] ([feesId]);


GO
PRINT N'Creating Foreign Key unnamed constraint on [dbo].[PatientVisit]...';


GO
ALTER TABLE [dbo].[PatientVisit]
    ADD FOREIGN KEY ([patientId]) REFERENCES [dbo].[Patient] ([patientId]);


GO
DECLARE @VarDecimalSupported AS BIT;

SELECT @VarDecimalSupported = 0;

IF ((ServerProperty(N'EngineEdition') = 3)
    AND (((@@microsoftversion / power(2, 24) = 9)
          AND (@@microsoftversion & 0xffff >= 3024))
         OR ((@@microsoftversion / power(2, 24) = 10)
             AND (@@microsoftversion & 0xffff >= 1600))))
    SELECT @VarDecimalSupported = 1;

IF (@VarDecimalSupported > 0)
    BEGIN
        EXECUTE sp_db_vardecimal_storage_format N'$(DatabaseName)', 'ON';
    END


GO
PRINT N'Update complete.';


GO
