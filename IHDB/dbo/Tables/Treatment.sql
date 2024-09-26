CREATE TABLE [dbo].[Treatment] (
    [tId]   INT        IDENTITY(1,1)   NOT NULL,
    [tName] VARCHAR (100) NULL,
    [tDesc] VARCHAR (200) NULL,
    [tType] VARCHAR (50)  NULL,
    PRIMARY KEY CLUSTERED ([tId] ASC)
);

