CREATE TABLE [dbo].[Medicines] (
    [mId]   INT       IDENTITY(1,1)    NOT NULL,
    [mName] VARCHAR (100) NULL,
    [mDesc] VARCHAR (300) NULL,
    [mMRP]  INT           NULL,
    PRIMARY KEY CLUSTERED ([mId] ASC)
);

