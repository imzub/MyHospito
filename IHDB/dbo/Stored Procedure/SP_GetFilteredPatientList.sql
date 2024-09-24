--USE [HospitoDB]
--GO

/****** Object:  StoredProcedure [dbo].[SP_GetFilteredPatientList]    Script Date: 26/Sep/2023 09:44:24 ******/
--DROP PROCEDURE [dbo].[SP_GetFilteredPatientList]
--GO

--/****** Object:  StoredProcedure [dbo].[SP_GetFilteredPatientList]    Script Date: 26/Sep/2023 09:44:24 ******/
--SET ANSI_NULLS ON
--GO

--SET QUOTED_IDENTIFIER ON
--GO

CREATE PROCEDURE [dbo].[SP_GetFilteredPatientList]      
 @name NVARCHAR(50) = NULL,      
 @contact NVARCHAR(30) = NULL,      
 @email NVARCHAR(50) = NULL,      
 @gender NVARCHAR(50) = NULL,      
 @doctorId INT = 0      
AS      
BEGIN      
IF @doctorId = 0      
BEGIN      
    SELECT 
    p.patientId,
    p.name,
    p.contact,
    p.address,
    p.email,
    p.gender,
    d.name AS doctorName
FROM Patient p
INNER JOIN Doctor d ON p.doctorId = d.doctorId    
    WHERE      
        p.name LIKE '%' + @name + '%'      
        AND p.contact LIKE '%' + @contact + '%'      
        AND p.email LIKE '%' + @email + '%'      
        AND p.gender LIKE '%' + @gender + '%' 
        Order By p.name;
END      
ELSE      
BEGIN      
    SELECT 
    p.patientId,
    p.name,
    p.contact,
    p.address,
    p.email,
    p.gender,
    d.name AS doctorName
FROM Patient p    
INNER JOIN Doctor d ON p.doctorId = d.doctorId 
    WHERE      
        p.doctorId = @doctorId      
        AND p.name LIKE '%' + @name + '%'      
        AND p.contact LIKE '%' + @contact + '%'      
        AND p.email LIKE '%' + @email + '%'      
        AND p.gender LIKE '%' + @gender + '%'   
        Order By p.name;
END      
END
GO


