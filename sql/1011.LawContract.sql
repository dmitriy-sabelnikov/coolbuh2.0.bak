/****** Скрипт для заливки данных в LawContract из Vi_li (Договора ГПХ) ******/
INSERT INTO LawContract (
  LawContract_PersCard_Id, LawContract_RefDep_Id, LawContract_Date, 
  LawContract_Days, LawContract_Sm, LawContract_PayDate, LawContract_ResSm        
)
  SELECT PersCard.PersCard_Id                                                    LawContract_PersCard_Id, 
         RefDep.RefDep_Id                                                        LawContract_RefDep_Id, 
         dateadd(mm, mon-1, dateadd(yy, Year(GetDate())-1900, 0) )               LawContract_Date,
         coalesce (cast (imp_VI_LI.L2 as integer),0)                             LawContract_Days,
         coalesce (cast (replace(imp_VI_LI.L3, ',', '.') as numeric(10,2)),0)    LawContract_Sm,
         dateadd(mm, cast(PAY_MNTH as integer)-1, 
         dateadd(yy, cast(PAY_YEAR as integer) - 1900, 0) )                      LawContract_PayDate,
         coalesce (cast (replace(SUM_TOTAL, ',', '.') as numeric(10,2)),0)       LawContract_ResSm
    FROM imp_VI_LI
	INNER JOIN PersCard on PersCard.PersCard_TIN = imp_VI_LI.KOD
	INNER JOIN RefDep on RefDep.RefDep_Cd = imp_VI_LI.PIDR
	where imp_VI_LI.L1 = 'd'
