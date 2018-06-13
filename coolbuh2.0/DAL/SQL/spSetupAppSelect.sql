/****** Script Date: 19.03.2018 9:00:22 ******/
/*������� �� ������� SetupApp*/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[spSetupAppSelect]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[spSetupAppSelect];
GO
Create Procedure [dbo].[spSetupAppSelect]
	@inSetupApp_Type int = 0  --��� ���������  
AS                            
BEGIN
    SELECT *
      FROM SetupApp
     WHERE (SetupApp_Type = @inSetupApp_Type or @inSetupApp_Type = 0) 
END
