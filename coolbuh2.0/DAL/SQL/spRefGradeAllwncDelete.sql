/****** Script Date: 19.03.2018 9:00:22 ******/
/*�������� ������ �� ������� RefGradeAllwnc*/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[spRefGradeAllwncDelete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
  drop procedure [dbo].[spRefGradeAllwncDelete];
GO
Create Procedure [dbo].[spRefGradeAllwncDelete]
	@inRefGradeAllwnc_Id   int           --id  
AS                            
BEGIN
	DELETE 
	  FROM RefGradeAllwnc
	 WHERE RefGradeAllwnc_Id = @inRefGradeAllwnc_Id;
END
