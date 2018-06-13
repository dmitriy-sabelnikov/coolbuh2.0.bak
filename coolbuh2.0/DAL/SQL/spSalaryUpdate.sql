/****** Script Date: 19.03.2018 9:00:22 ******/
/*���������� ������� Salary*/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[spSalaryUpdate]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[spSalaryUpdate];
GO
Create Procedure [dbo].[spSalaryUpdate]
	@inSalary_Id             int             ,  --id
	@inSalary_PersCard_Id    int             ,  --������ �� �������� ���������
	@inSalary_RefDep_Id      int             ,  --������ �� ���������� �������������
	@inSalary_Date           date            ,  --����
	@inSalary_Days           int             ,  --������������ ���
	@inSalary_Hours          numeric(5,2)    ,  --������������ ����
	@inSalary_BaseSm         numeric(10,2)   ,  --�������� ��������
	@inSalary_PensId         int             ,  --������� ����������(id ������� �� Allowance)
	@inSalary_PensPct        numeric(5,2)    ,  --������� ����������(�������)
	@inSalary_PensSm         numeric(10,2)   ,  --������� ����������(�����)
	@inSalary_ExpId          int             ,  --������� �� ����(id ������� �� Allowance)
	@inSalary_ExpPct         numeric(5,2)    ,  --������� �� ����(�������)
	@inSalary_ExpSm          numeric(10,2)   ,  --������� �� ����(�����)
	@inSalary_GradeId        int             ,  --������� �� ���������(id ������� �� Allowance)
	@inSalary_GradePct       numeric(5,2)    ,  --������� �� ���������(�������)
	@inSalary_GradeSm        numeric(10,2)   ,  --������� �� ���������(�����)
	@inSalary_OthId          int             ,  --������ �������(id ������� �� Allowance)
	@inSalary_OthPct         numeric(5,2)    ,  --������ �������(�������)
	@inSalary_OthSm          numeric(10,2)   ,  --������ �������(�����)
	@inSalary_KTU            numeric(5,2)    ,  --���
	@inSalary_KTUSm          numeric(10,2)   ,  --������� �� ���
        @inSalary_ResSm          numeric(10,2)      --�������� �����
AS                            
BEGIN
	UPDATE Salary SET
	  Salary_PersCard_Id = @inSalary_PersCard_Id,
	  Salary_RefDep_Id    = @inSalary_RefDep_Id,  
	  Salary_Date         = @inSalary_Date,
	  Salary_Days         = @inSalary_Days,       
	  Salary_Hours        = @inSalary_Hours,      
	  Salary_BaseSm       = @inSalary_BaseSm,     
	  Salary_PensId       = @inSalary_PensId,     
	  Salary_PensPct      = @inSalary_PensPct,     
	  Salary_PensSm       = @inSalary_PensSm,     
	  Salary_ExpId        = @inSalary_ExpId,      
	  Salary_ExpPct       = @inSalary_ExpPct,      
	  Salary_ExpSm        = @inSalary_ExpSm,      
	  Salary_GradeId      = @inSalary_GradeId,    
	  Salary_GradePct     = @inSalary_GradePct,    
	  Salary_GradeSm      = @inSalary_GradeSm,    
	  Salary_OthId        = @inSalary_OthId,      
	  Salary_OthPct       = @inSalary_OthPct,      
	  Salary_OthSm        = @inSalary_OthSm,      
	  Salary_KTU          = @inSalary_KTU,        
	  Salary_KTUSm        = @inSalary_KTUSm,
          Salary_ResSm        = @inSalary_ResSm
    WHERE Salary_Id = @inSalary_Id;
END
