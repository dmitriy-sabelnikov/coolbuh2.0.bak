/****** Script Date: 19.03.2018 9:00:22 ******/
/*Вставка в таблицу RefAdm*/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[spRefAdmInsert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[spRefAdmInsert];
GO
Create Procedure [dbo].[spRefAdmInsert] 
	@inRefAdm_DolNm     nvarchar(50),
	@inRefAdm_TIN	    nvarchar(10),
	@inRefAdm_FIO	    nvarchar(50),
	@inRefAdm_OrgCd     nvarchar(10),
	@inRefAdm_Tel       nvarchar(12)
AS                            
BEGIN
    insert into RefAdm (RefAdm_DolNm, RefAdm_TIN, RefAdm_FIO, RefAdm_OrgCd, RefAdm_Tel) 
	      values (@inRefAdm_DolNm, @inRefAdm_TIN, @inRefAdm_FIO, @inRefAdm_OrgCd, @inRefAdm_Tel);
END
