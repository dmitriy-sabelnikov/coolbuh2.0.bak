/****** Script Date: 19.03.2018 9:00:22 ******/
/*������� � ������� RefExpAllwnc*/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[spRefExpAllwncInsert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[spRefExpAllwncInsert];
GO
Create Procedure [dbo].[spRefExpAllwncInsert] 
	@inRefExpAllwnc_Cd              varchar(25),  --���
	@inRefExpAllwnc_Nm              varchar(50),  --������������
	@inRefExpAllwnc_Year            int,          --��� 
	@inRefExpAllwnc_Mech            numeric(5,2), --�������� ���������
        @inRefExpAllwncMech_RefDep_Id   int,          --������� ���������� ��� �������� ���������. �������������
	@inRefExpAllwnc_Oth             numeric(5,2), --�������� ������
        @inRefExpAllwnc_Flg            int           --����  
AS                            
BEGIN
    insert into RefExpAllwnc (RefExpAllwnc_Cd, RefExpAllwnc_Nm, RefExpAllwnc_Year, RefExpAllwnc_Mech, RefExpAllwncMech_RefDep_Id, RefExpAllwnc_Oth, RefExpAllwnc_Flg) 
        values (@inRefExpAllwnc_Cd, @inRefExpAllwnc_Nm, @inRefExpAllwnc_Year, @inRefExpAllwnc_Mech, @inRefExpAllwncMech_RefDep_Id, @inRefExpAllwnc_Oth, @inRefExpAllwnc_Flg);
END  