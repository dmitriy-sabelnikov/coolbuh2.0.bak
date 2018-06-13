/****** Script Date: 19.03.2018 9:00:22 ******/
/*������� �� ������� RefAdm*/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[spRefAdmSelect]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[spRefAdmSelect];
GO
Create Procedure [dbo].[spRefAdmSelect]
	@inRefAdm_Id   int = 0       --id   
AS                            
BEGIN
    SELECT *
      FROM RefAdm
     WHERE (RefAdm_Id = @inRefAdm_Id or @inRefAdm_Id = 0) 
END
