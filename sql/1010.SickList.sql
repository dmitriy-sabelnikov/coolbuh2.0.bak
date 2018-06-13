/****** Скрипт для заливки данных в SickList из Vi_li (Больничные) ******/
INSERT INTO SickList (
  SickList_PersCard_Id, SickList_RefDep_Id, SickList_Date, SickList_DaysEntprs, SickList_SmEntprs, 
  SickList_DaysSocInsrnc, SickList_SmSocInsrnc, SickList_PayDate, SickList_ResSm        
)
  SELECT PersCard.PersCard_Id                                                    SickList_PersCard_Id,
         RefDep.RefDep_Id                                                        SickList_RefDep_Id, 
         dateadd(mm, mon-1, dateadd(yy, Year(GetDate())-1900, 0) )               SickList_Date,
         coalesce (cast (imp_VI_LI.L2 as integer),0)                             SickList_DaysEntprs,
         coalesce (cast (replace(imp_VI_LI.L3, ',', '.') as numeric(10,2)),0)    SickList_SmEntprs,
         coalesce (cast (imp_VI_LI.L4 as integer),0)                             SickList_DaysSocInsrnc,
         coalesce (cast (replace(imp_VI_LI.L5, ',', '.') as numeric(10,2)),0)    SickList_SmSocInsrnc,
         dateadd(mm, cast(PAY_MNTH as integer)-1, 
           dateadd(yy, cast(PAY_YEAR as integer) - 1900, 0) )                    SickList_PayDate,
         coalesce (cast (replace(SUM_TOTAL, ',', '.') as numeric(10,2)),0)       SickList_ResSm
    FROM imp_VI_LI
	INNER JOIN PersCard on PersCard.PersCard_TIN = imp_VI_LI.KOD
	INNER JOIN RefDep on RefDep.RefDep_Cd = imp_VI_LI.PIDR
	where imp_VI_LI.L1 = 'l'





