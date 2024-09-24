CREATE TABLE [dbo].[PatientVisit] (
    [patientVisitId] INT      IDENTITY(1,1)    NOT NULL,
    [patientId]      INT          NOT NULL,
    [concerns]       VARCHAR (100) NULL,
    [symptoms]       VARCHAR (100) NULL,
    [doctorId]       INT          NOT NULL,
    [feesId]         INT          NOT NULL,
    [paidFees]       INT          NOT NULL,
    PRIMARY KEY CLUSTERED ([patientVisitId] ASC),
    FOREIGN KEY ([doctorId]) REFERENCES [dbo].[Doctor] ([doctorId]),
    FOREIGN KEY ([feesId]) REFERENCES [dbo].[Fees] ([feesId]),
    FOREIGN KEY ([patientId]) REFERENCES [dbo].[Patient] ([patientId])
);

