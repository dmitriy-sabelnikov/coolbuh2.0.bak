/****** Script Date: 19.03.2018 9:00:22 ******/
/*Обновление таблицы RefAdm*/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[spRefAdmUpdate]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[spRefAdmUpdate];
GO
Create Procedure [dbo].[spRefAdmUpdate]
	@inRefAdm_Id        int,           --id   
	@inRefAdm_DolNm     nvarchar(50),
	@inRefAdm_TIN	    nvarchar(10),
	@inRefAdm_FIO	    nvarchar(50),
	@inRefAdm_OrgCd     nvarchar(10),
	@inRefAdm_Tel       nvarchar(12)
AS                            
BEGIN
	UPDATE RefAdm SET
     	   RefAdm_DolNm = @inRefAdm_DolNm,
     	   RefAdm_TIN   = @inRefAdm_TIN,
     	   RefAdm_FIO   = @inRefAdm_FIO,
     	   RefAdm_OrgCd = @inRefAdm_OrgCd,
     	   RefAdm_Tel   = @inRefAdm_Tel   
    WHERE RefAdm_Id = @inRefAdm_Id;
END
