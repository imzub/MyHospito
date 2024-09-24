/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

-- Truncate and Insert test data into the doctor table
TRUNCATE TABLE [dbo].[Doctor];
INSERT INTO [dbo].[Doctor]
           ([name]
           ,[contact]
           ,[address]
           ,[email]
           ,[gender])
     VALUES
           ('Test Doctor 1','9999999999','Test Address 1','test@test.com','Male');
GO
INSERT INTO [dbo].[Doctor]
           ([name]
           ,[contact]
           ,[address]
           ,[email]
           ,[gender])
     VALUES
           ('Test Doctor 2','8888888888','Test Address 2','test2@test.com','Female');
GO
INSERT INTO [dbo].[Doctor]
           ([name]
           ,[contact]
           ,[address]
           ,[email]
           ,[gender])
     VALUES
           ('Test Doctor 3','7777777777','Test Address 3','test3@test.com','Male');
GO

--For Fees Table
INSERT INTO Fees ([feesName], [fees])
VALUES
    ('Major Surgery Fee', 1000.00),
    ('Medical Imaging Fee', 200.00),
    ('Specialized Treatment Fee', 350.00),
    ('Hospital Stay Fee', 500.00),
    ('Emergency Procedure Fee', 600.00),
    ('Intensive Care Fee', 800.00),
    ('Medical Equipment Fee', 300.00),
    ('Rehabilitation Fee', 250.00),
    ('Surgical Supplies Fee', 180.00),
    ('Outpatient Procedure Fee', 150.00);


-- Test data for FileLocation table
INSERT INTO FileLocation (FileName, PhysicalPath, LastUpdated, Description)
VALUES
    ('Sample_PDF_1.pdf', 'C:\Files\Sample_PDF_1.pdf', '2023-10-10 08:30:00', 'PDF document for review.'),
    ('Financial_Report.xlsx', 'D:\Files\Financial_Report.xlsx', '2023-10-11 14:45:00', 'Quarterly financial report.'),
    ('Meeting_Agenda.pdf', 'E:\Files\Meeting_Agenda.pdf', '2023-10-12 10:15:00', 'Agenda for the team meeting.'),
    ('Sample_PDF_2.pdf', 'F:\Files\Sample_PDF_2.pdf', '2023-10-13 18:20:00', 'Another PDF document.'),
    ('Sales_Data.xlsx', 'G:\Files\Sales_Data.xlsx', '2023-10-14 09:30:00', 'Monthly sales data report.'),
    ('Employee_Handbook.pdf', 'H:\Files\Employee_Handbook.pdf', '2023-10-15 15:00:00', 'Company employee handbook.'),
    ('Sample_PDF_3.pdf', 'I:\Files\Sample_PDF_3.pdf', '2023-10-16 11:45:00', 'Yet another PDF document.'),
    ('Project_Plan.xlsx', 'J:\Files\Project_Plan.xlsx', '2023-10-17 20:10:00', 'Project planning spreadsheet.'),
    ('Presentation_Slides.pdf', 'K:\Files\Presentation_Slides.pdf', '2023-10-18 12:30:00', 'Slides for the presentation.'),
    ('Expenses_Report.xlsx', 'L:\Files\Expenses_Report.xlsx', '2023-10-19 13:25:00', 'Quarterly expenses report.');

-- You can add more test data as needed




GO
