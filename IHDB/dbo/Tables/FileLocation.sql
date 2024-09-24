CREATE TABLE FileLocation (
    flId INT IDENTITY(1,1) PRIMARY KEY,
    FileName NVARCHAR(255) NOT NULL,
    PhysicalPath NVARCHAR(MAX) NOT NULL,    
    LastUpdated DATETIME,
    Description NVARCHAR(MAX)
);