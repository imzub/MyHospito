CREATE TABLE [dbo].[IllnessSeverity] (
    [isId]   INT       IDENTITY(1,1)    NOT NULL,
    [isName] VARCHAR (100) NULL,
    [isDesc] VARCHAR (300) NULL,
    PRIMARY KEY CLUSTERED ([isId] ASC)
);

