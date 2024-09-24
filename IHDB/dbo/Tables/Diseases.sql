CREATE TABLE [dbo].[Diseases] (
    [dsId]   INT  Identity(1,1)         NOT NULL,
    [dsName] VARCHAR (100) NULL,
    [dsDesc] VARCHAR (200) NULL,
    PRIMARY KEY CLUSTERED ([dsId] ASC)
);

