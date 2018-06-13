/****** Script Date: 19.03.2018 9:00:22 ******/
/*���������� ������� RefExpAllwnc*/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[spRefExpAllwncUpdate]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[spRefExpAllwncUpdate];
GO
Create Procedure [dbo].[spRefExpAllwncUpdate]
	@inRefExpAllwnc_Id              int,          --id 
	@inRefExpAllwnc_Cd              varchar(25),  --���
	@inRefExpAllwnc_Nm              varchar(50),  --������������
	@inRefExpAllwnc_Year            int,          --��� 
	@inRefExpAllwnc_Mech            numeric(5,2), --�������� ���������
        @inRefExpAllwncMech_RefDep_Id   int,          --������� ���������� ��� �������� ���������. �������������
	@inRefExpAllwnc_Oth             numeric(5,2), --�������� ������
        @inRefExpAllwnc_Flg            int           --����  
AS                            
BEGIN
	UPDATE RefExpAllwnc SET
           RefExpAllwnc_Cd            = @inRefExpAllwnc_Cd,         
           RefExpAllwnc_Nm            = @inRefExpAllwnc_Nm,         
           RefExpAllwnc_Year          = @inRefExpAllwnc_Year,          
           RefExpAllwnc_Mech          = @inRefExpAllwnc_Mech,          
           RefExpAllwncMech_RefDep_Id = @inRefExpAllwncMech_RefDep_Id, 
           RefExpAllwnc_Oth           = @inRefExpAllwnc_Oth,           
           RefExpAllwnc_Flg           = @inRefExpAllwnc_Flg          
    WHERE RefExpAllwnc_Id = @inRefExpAllwnc_Id;
END
