CREATE PROCEDURE [dbo].[SP_GetPatientNameAndId]  
 @name NVARCHAR(50) = NULL,  
 @contact NVARCHAR(30) = NULL,  
 @email NVARCHAR(50) = NULL,  
 @gender NVARCHAR(50) = NULL,  
 @doctorId INT = 0  
AS  
BEGIN  
select patientId,name from patient order by name asc;
END