/****** Script Date: 19.03.2018 9:00:22 ******/
/*�������� ������ �� ������� PersCard*/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[spPersCardDelete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
  drop procedure [dbo].[spPersCardDelete];
GO
Create Procedure [dbo].[spPersCardDelete]
	@inPersCard_Id   int           --id ��������  
AS                            
BEGIN
	DELETE 
	  FROM PersCard
	 WHERE PersCard_Id = @inPersCard_Id;
END
