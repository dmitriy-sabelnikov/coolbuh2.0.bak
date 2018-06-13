/****** Script Date: 19.03.2018 9:00:22 ******/
/*������� � ������� Salary*/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[spSalaryInsert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[spSalaryInsert];
GO
Create Procedure [dbo].[spSalaryInsert]
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
    insert into Salary (Salary_PersCard_Id, Salary_RefDep_Id, Salary_Date, Salary_Days,Salary_Hours, Salary_BaseSm,
	         Salary_PensId, Salary_PensPct, Salary_PensSm, Salary_ExpId, Salary_ExpPct, Salary_ExpSm, 
                 Salary_GradeId, Salary_GradePct, Salary_GradeSm, Salary_OthId, Salary_OthPct, Salary_OthSm, 
                 Salary_KTU, Salary_KTUSm, Salary_ResSm) 
	 values (@inSalary_PersCard_Id, @inSalary_RefDep_Id, @inSalary_Date, @inSalary_Days,@inSalary_Hours, @inSalary_BaseSm,
	         @inSalary_PensId, @inSalary_PensPct, @inSalary_PensSm, @inSalary_ExpId, @inSalary_ExpPct, @inSalary_ExpSm, 
                 @inSalary_GradeId, @inSalary_GradePct, @inSalary_GradeSm, @inSalary_OthId, @inSalary_OthPct, @inSalary_OthSm, 
                 @inSalary_KTU, @inSalary_KTUSm, @inSalary_ResSm  
	  );
END

 