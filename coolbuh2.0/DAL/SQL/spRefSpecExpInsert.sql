/****** Script Date: 19.03.2018 9:00:22 ******/
/*������� � ������� RefSpecExp*/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[spRefSpecExpInsert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[spRefSpecExpInsert];
GO
Create Procedure [dbo].[spRefSpecExpInsert] 
	@inRefSpecExp_Cd   nvarchar(25),       --��� ���������  
	@inRefSpecExp_ShortName nvarchar(25),  --������� ������������ 
	@inRefSpecExp_Name nvarchar(250)       --������ ������������
AS                            
BEGIN
    insert into RefSpecExp (RefSpecExp_Cd, RefSpecExp_ShortName, RefSpecExp_Name) 
	                values (@inRefSpecExp_Cd, @inRefSpecExp_ShortName, @inRefSpecExp_Name);
END