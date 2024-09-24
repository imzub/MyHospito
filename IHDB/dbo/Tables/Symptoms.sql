CREATE TABLE [dbo].[Symptoms] (
    [smId]   INT      IDENTITY(1,1)     NOT NULL,
    [smName] VARCHAR (100) NULL,
    [smDesc] VARCHAR (200) NULL,
    PRIMARY KEY CLUSTERED ([smId] ASC)
);

