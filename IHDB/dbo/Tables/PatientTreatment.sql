CREATE TABLE [dbo].[PatientTreatment] (
    [ptId]             INT      IDENTITY(1,1)     NOT NULL,
    [ptDesc]           VARCHAR (200) NULL,
    [patientVisitId]   INT           NOT NULL,
    [patientId]        INT           NOT NULL,
    [tId]              INT           NOT NULL,
    [prescriptionItem] VARCHAR (150) NULL,
    PRIMARY KEY CLUSTERED ([ptId] ASC),
    FOREIGN KEY ([patientId]) REFERENCES [dbo].[Patient] ([patientId]),
    FOREIGN KEY ([patientVisitId]) REFERENCES [dbo].[PatientVisit] ([patientVisitId]),
    FOREIGN KEY ([tId]) REFERENCES [dbo].[Treatment] ([tId])
);

