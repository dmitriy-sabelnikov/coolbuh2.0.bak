/****** Script Date: 19.03.2018 9:00:22 ******/
/*������� � ������� PersCard*/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[spPersCardInsert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[spPersCardInsert];
GO
Create Procedure [dbo].[spPersCardInsert] 
	@inPersCard_FName        nvarchar(35),       --���  
	@inPersCard_MName        nvarchar(35),       --��������
	@inPersCard_LName        nvarchar(35),       --�������
	@inPersCard_TIN          nvarchar(12),       --���
	@inPersCard_Exp          int,                --����(excperience)
	@inPersCard_Grade        int,                --����������
	@inPersCard_DOB          Date,               --���� ��������(date of birth)
	@inPersCard_DOR          Date,               --���� �����������(date of receipt)
	@inPersCard_DOD          Date,               --���� ����������(date of dismissal)
	@inPersCard_DOP          Date,               --���� ����� �� ������
    --@inPersCard_Pens         int,                --����� ������������(�� �������)
    @inPersCard_ChldM1       int,                --���� ����� 1  
    @inPersCard_ChldM2       int,                --���� ����� 2  
    @inPersCard_ChldM3       int,                --���� ����� 3  
    @inPersCard_ChldM4       int,                --���� ����� 4  
    @inPersCard_ChldM5       int,                --���� ����� 5  
    @inPersCard_ChldM6       int,                --���� ����� 6  
    @inPersCard_ChldM7       int,                --���� ����� 7  
    @inPersCard_ChldM8       int,                --���� ����� 8  
    @inPersCard_ChldM9       int,                --���� ����� 9   
    @inPersCard_ChldM10      int,                --���� ����� 10  
    @inPersCard_ChldM11      int,                --���� ����� 11  
    @inPersCard_ChldM12      int                  --���� ����� 12  
    --@inPersCard_SpecExpIdM1  int,                 --Id ��������� 
    --@inPersCard_SpecExpIdM2  int,                --Id ��������� 
    --@inPersCard_SpecExpIdM3  int,                --Id ��������� 
    --@inPersCard_SpecExpIdM4  int,                --Id ��������� 
    --@inPersCard_SpecExpIdM5  int,                --Id ��������� 
    --@inPersCard_SpecExpIdM6  int,                --Id ��������� 
    --@inPersCard_SpecExpIdM7  int,                --Id ��������� 
    --@inPersCard_SpecExpIdM8  int,                --Id ��������� 
    --@inPersCard_SpecExpIdM9  int,                --Id ��������� 
    --@inPersCard_SpecExpIdM10 int,                --Id ��������� 
    --@inPersCard_SpecExpIdM11 int,                --Id ��������� 
    --@inPersCard_SpecExpIdM12 int                 --Id ��������� 
AS                            
BEGIN
    insert into PersCard (PersCard_FName, PersCard_MName, PersCard_LName, PersCard_TIN, PersCard_Exp, 
      PersCard_Grade, PersCard_DOB, PersCard_DOR, PersCard_DOD, PersCard_DOP
	  /*,PersCard_Pens*/, PersCard_ChldM1, PersCard_ChldM2, PersCard_ChldM3, PersCard_ChldM4, PersCard_ChldM5, PersCard_ChldM6, PersCard_ChldM7, PersCard_ChldM8, 
	  PersCard_ChldM9, PersCard_ChldM10, PersCard_ChldM11, PersCard_ChldM12/*, PersCard_SpecExpIdM1, PersCard_SpecExpIdM2, PersCard_SpecExpIdM3,  PersCard_SpecExpIdM4, 
	  PersCard_SpecExpIdM5, PersCard_SpecExpIdM6, PersCard_SpecExpIdM7, PersCard_SpecExpIdM8, PersCard_SpecExpIdM9, PersCard_SpecExpIdM10, PersCard_SpecExpIdM11, 
	  PersCard_SpecExpIdM12*/) 
	 values (@inPersCard_FName, @inPersCard_MName, @inPersCard_LName, @inPersCard_TIN, @inPersCard_Exp, @inPersCard_Grade, @inPersCard_DOB, @inPersCard_DOR, 
	  @inPersCard_DOD, @inPersCard_DOP
	  /*@inPersCard_Pens*/, @inPersCard_ChldM1, @inPersCard_ChldM2, @inPersCard_ChldM3, @inPersCard_ChldM4, @inPersCard_ChldM5, @inPersCard_ChldM6,       
	  @inPersCard_ChldM7, @inPersCard_ChldM8, @inPersCard_ChldM9, @inPersCard_ChldM10, @inPersCard_ChldM11, @inPersCard_ChldM12/*, @inPersCard_SpecExpIdM1, 
	  @inPersCard_SpecExpIdM2, @inPersCard_SpecExpIdM3, @inPersCard_SpecExpIdM4, @inPersCard_SpecExpIdM5, @inPersCard_SpecExpIdM6, @inPersCard_SpecExpIdM7, 
	  @inPersCard_SpecExpIdM8, @inPersCard_SpecExpIdM9, @inPersCard_SpecExpIdM10, @inPersCard_SpecExpIdM11, @inPersCard_SpecExpIdM12*/ 
	  );
END