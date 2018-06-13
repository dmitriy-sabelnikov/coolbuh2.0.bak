/****** Script Date: 19.03.2018 9:00:22 ******/
/*������� � ������� RefPensAllwnc*/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[spRefPensAllwncInsert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[spRefPensAllwncInsert];
GO
Create Procedure [dbo].[spRefPensAllwncInsert] 
    @inRefPensAllwnc_Cd             varchar(25)               , --���
    @inRefPensAllwnc_Nm             varchar(50)               , --������������
    @inRefPensAllwnc_Pct            numeric(5,2)              , --�������
    @inRefPensAllwnc_Flg            int                         --�����
AS                            
BEGIN
    insert into RefPensAllwnc (RefPensAllwnc_Cd, RefPensAllwnc_Nm, RefPensAllwnc_Pct, RefPensAllwnc_Flg) 
	      values (@inRefPensAllwnc_Cd, @inRefPensAllwnc_Nm, @inRefPensAllwnc_Pct, @inRefPensAllwnc_Flg);
END
