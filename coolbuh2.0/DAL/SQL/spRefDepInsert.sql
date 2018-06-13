/****** Script Date: 19.03.2018 9:00:22 ******/
/*������� � ������� RefDep*/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[spRefDepInsert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[spRefDepInsert];
GO
Create Procedure [dbo].[spRefDepInsert] 
	@inRefDep_Cd   nvarchar(25),  --��� �������������  
	@inRefDep_Nm   nvarchar(250) --������������ ������������� 
AS                            
BEGIN
    insert into RefDep (RefDep_Cd, RefDep_Nm) values (@inRefDep_Cd, @inRefDep_Nm);
END