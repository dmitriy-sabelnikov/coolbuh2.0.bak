/****** Script Date: 19.03.2018 9:00:22 ******/
/*�������� ������ �� ������� Salary*/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[spSalaryDelete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
  drop procedure [dbo].[spSalaryDelete];
GO
Create Procedure [dbo].[spSalaryDelete]
	@inSalary_Id   int           --id ��������  
AS                            
BEGIN
	DELETE 
	  FROM Salary
	 WHERE Salary_Id = @inSalary_Id;
END
