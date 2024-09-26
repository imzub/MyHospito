CREATE TABLE [dbo].[Doctor] (
    [doctorId] INT      IDENTITY(1,1)     NOT NULL,
    [name]     VARCHAR (50)  NOT NULL,
    [contact]  VARCHAR (50)  NULL,
    [address]  VARCHAR (100) NULL,
    [email]    VARCHAR (50)  NULL,
    [gender]   VARCHAR (20)  NOT NULL,
    PRIMARY KEY CLUSTERED ([doctorId] ASC)
);

