/****** Script Date: 19.03.2018 9:00:22 ******/
/*�������� ������ �� ������� RefDep*/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[spRefDepDelete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
  drop procedure [dbo].[spRefDepDelete];
GO
Create Procedure [dbo].[spRefDepDelete]
	@inRefDep_Id   int           --id �������������  
AS                            
BEGIN
	DELETE 
	  FROM RefDep
	 WHERE RefDep_Id = @inRefDep_Id;
END
