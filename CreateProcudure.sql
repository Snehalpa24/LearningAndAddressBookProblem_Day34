Create procedure [dbo].[SpUpdateEmployeeSalary]
@id int,
@month varchar(20),
@salary int,
@EmpId int

AS 
BEGIN

SET XACT_ABORT ON;
BEGIN TRY
BEGIN TRANSACTION;
Update Salary 
set EmpSalary=@salary
where SalaryID=@id and SalaryMonth=@month and EmpId=@EmpId;

select e.EmployeeID,e.EmployeeName,s.EmpSalary,s.SalaryMonth,s.SalaryId
from EmployeeTable1 e inner join Salary s on e.EmployeeID=s.EmpId where s.SalaryId=@id;
COMMIT TRANSACTION
END TRY 
BEGIN CATCH 


select ERROR_NUMBER() As ErrorNumber, ERROR_MESSAGE() as ErrorMessage;
if(XACT_STATE())= -1
BEGIN 
PRINT N'the transaction is in an uncommittable state.'+'Rolling back transaction.'
ROLLBACK TRANSACTION
END;
if(XACT_STATE())=1
BEGIN 
PRINT 
N' The transaction is committable.'+'Committing transaction.'
COMMIT TRANSACTION 
END 
END CATCH
END
