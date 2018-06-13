/****** Script Date: 19.03.2018 9:00:22 ******/
/*������� � ������� LawContract*/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[spLawContractInsert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[spLawContractInsert];
GO
Create Procedure [dbo].[spLawContractInsert] 
    @inLawContract_PersCard_Id    int,
    @inLawContract_RefDep_Id      int,
    @inLawContract_Date           date,
    @inLawContract_Days           int,
    @inLawContract_Sm             numeric(10,2),
    @inLawContract_PayDate        date,
    @inLawContract_ResSm          numeric(10,2)
AS                            
BEGIN
    insert into LawContract (LawContract_PersCard_Id, LawContract_RefDep_Id, LawContract_Date, LawContract_Days, LawContract_Sm, LawContract_PayDate, LawContract_ResSm) 
	      values (@inLawContract_PersCard_Id, @inLawContract_RefDep_Id, @inLawContract_Date, @inLawContract_Days, @inLawContract_Sm, @inLawContract_PayDate, @inLawContract_ResSm);
END



