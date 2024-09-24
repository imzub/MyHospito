CREATE TABLE [dbo].[Excercises] (
    [eId]       INT      IDENTITY(1,1)     NOT NULL,
    [eName]     VARCHAR (100) NULL,
    [eDesc]     VARCHAR (300) NULL,
    [eDuration] INT           NULL,
    PRIMARY KEY CLUSTERED ([eId] ASC)
);

