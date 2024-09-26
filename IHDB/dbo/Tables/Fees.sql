CREATE TABLE [dbo].[Fees] (
    [feesId] INT IDENTITY(1,1) NOT NULL,
    [fees]   INT NULL,
    [feesName] VARCHAR(100)
    PRIMARY KEY CLUSTERED ([feesId] ASC)
);

