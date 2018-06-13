/****** Script Date: 19.03.2018 9:00:22 ******/
/*������� �� ������� RefPensAllwnc*/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[spRefPensAllwncSelect]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[spRefPensAllwncSelect];
GO
Create Procedure [dbo].[spRefPensAllwncSelect]
	@inRefPensAllwnc_Id   int = 0       --id   
AS                            
BEGIN
    SELECT *
      FROM RefPensAllwnc
     WHERE (RefPensAllwnc_Id = @inRefPensAllwnc_Id or @inRefPensAllwnc_Id = 0) 
END
