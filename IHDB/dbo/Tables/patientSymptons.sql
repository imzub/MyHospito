CREATE TABLE [dbo].[patientSymptons] (
    [psId]           INT      IDENTITY(1,1)     NOT NULL,
    [psDesc]         VARCHAR (100) NULL,
    [patientVisitId] INT           NOT NULL,
    [patientId]      INT           NOT NULL,
    [smId]           INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([psId] ASC),
    FOREIGN KEY ([patientId]) REFERENCES [dbo].[Patient] ([patientId]),
    FOREIGN KEY ([patientVisitId]) REFERENCES [dbo].[PatientVisit] ([patientVisitId]),
    FOREIGN KEY ([smId]) REFERENCES [dbo].[Symptoms] ([smId])
);

