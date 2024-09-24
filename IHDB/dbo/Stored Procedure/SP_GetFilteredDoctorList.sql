CREATE PROCEDURE SP_GetFilteredDoctorList 
 @name NVARCHAR(50) = NULL,  
 @contact NVARCHAR(30) = NULL, 
 @address NVARCHAR(50) = NULL,
 @email NVARCHAR(50) = NULL,  
 @gender NVARCHAR(50) = NULL
AS  
BEGIN  
    SELECT *  
    FROM Doctor  
    WHERE  
        name LIKE '%' + @name + '%'  
        AND contact LIKE '%' + @contact + '%'  
		AND address LIKE '%' + @address + '%'  
		AND email LIKE '%' + @email + '%'  
        AND gender LIKE '%' + @gender + '%'  
END  