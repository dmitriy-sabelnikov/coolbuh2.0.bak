/****** Script Date: 19.03.2018 9:00:22 ******/
/*���������� ������� RefDep*/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[spRefDepUpdate]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[spRefDepUpdate];
GO
Create Procedure [dbo].[spRefDepUpdate]
	@inRefDep_Id   int,           --id �������������  
	@inRefDep_Cd   nvarchar(25),  --��� �������������  
	@inRefDep_Nm   nvarchar(250)  --������������ ������������� 
AS                            
BEGIN
	UPDATE RefDep SET
		RefDep_Cd   = @inRefDep_Cd, 
		RefDep_Nm   = @inRefDep_Nm
    WHERE RefDep_Id = @inRefDep_Id;
END
