/****** Script Date: 19.03.2018 9:00:22 ******/
/*�������� ������ �� ������� RefAdm*/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[spRefAdmDelete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
  drop procedure [dbo].[spRefAdmDelete];
GO
Create Procedure [dbo].[spRefAdmDelete]
	@inRefAdm_Id   int           --id  
AS                            
BEGIN
	DELETE 
	  FROM RefAdm
	 WHERE RefAdm_Id = @inRefAdm_Id;
END
