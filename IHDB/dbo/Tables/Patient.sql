CREATE TABLE [dbo].[Patient] (
    [patientId] INT  IDENTITY(1,1),
    [name]      VARCHAR (100) NULL,
    [contact]   VARCHAR (50)  NULL,
    [address]   VARCHAR (50)  NULL,
    [email]     VARCHAR (50)  NULL,
    [gender]    VARCHAR (20)  NULL,
    [doctorId]  INT           NOT NULL,
    [photo] IMAGE NULL, 
    PRIMARY KEY CLUSTERED ([patientId] ASC)
);

