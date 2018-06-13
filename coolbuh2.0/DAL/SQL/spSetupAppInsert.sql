/****** Script Date: 19.03.2018 9:00:22 ******/
/*������� � ������� SetupApp*/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[spSetupAppInsert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[spSetupAppInsert];
GO
Create Procedure [dbo].[spSetupAppInsert] 
	@inSetupApp_Type        int,  --��� ���������  
	@inSetupApp_ValueDigit  int,  --�������� �������� 
	@inSetupApp_ValueString nvarchar(250) --���������� �������� 
AS                            
BEGIN
    insert into SetupApp (SetupApp_Type, SetupApp_ValueDigit, SetupApp_ValueString) values (@inSetupApp_Type, @inSetupApp_ValueDigit, @inSetupApp_ValueString);
END
