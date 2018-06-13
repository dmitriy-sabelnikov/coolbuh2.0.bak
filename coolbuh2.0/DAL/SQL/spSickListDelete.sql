/****** Script Date: 19.03.2018 9:00:22 ******/
/*�������� ������ �� ������� SickList*/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[spSickListDelete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
  drop procedure [dbo].[spSickListDelete];
GO
Create Procedure [dbo].[spSickListDelete]
	@inSickList_Id   int           --id  
AS                            
BEGIN
	DELETE 
	  FROM SickList
	 WHERE SickList_Id = @inSickList_Id;
END
