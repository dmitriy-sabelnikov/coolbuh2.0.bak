/****** Script Date: 19.03.2018 9:00:22 ******/
/*���������� ������� SetupApp*/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[spSetupAppUpdate]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[spSetupAppUpdate];
GO
Create Procedure [dbo].[spSetupAppUpdate]
	@inSetupApp_Type        int,  --��� ���������  
	@inSetupApp_ValueDigit  int,  --�������� �������� 
	@inSetupApp_ValueString nvarchar(250) --���������� �������� 
AS                            
BEGIN
	UPDATE SetupApp SET
		SetupApp_ValueDigit  = @inSetupApp_ValueDigit,
		SetupApp_ValueString = @inSetupApp_ValueString
    WHERE SetupApp_Type = @inSetupApp_Type;
END
