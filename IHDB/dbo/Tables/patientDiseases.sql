CREATE TABLE [dbo].[patientDiseases] (
    [pdId]           INT      IDENTITY(1,1)     NOT NULL,
    [pdDesc]         VARCHAR (100) NULL,
    [patientVisitId] INT           NOT NULL,
    [patientId]      INT           NOT NULL,
    [dsId]           INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([pdId] ASC),
    FOREIGN KEY ([dsId]) REFERENCES [dbo].[Diseases] ([dsId]),
    FOREIGN KEY ([patientId]) REFERENCES [dbo].[Patient] ([patientId]),
    FOREIGN KEY ([patientVisitId]) REFERENCES [dbo].[PatientVisit] ([patientVisitId])
);

