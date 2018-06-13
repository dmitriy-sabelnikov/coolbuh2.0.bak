/****** Скрипт для заливки данных в Vocation из Vi_li (отпускные) ******/
INSERT INTO Vocation (
  Vocation_PersCard_Id, Vocation_RefDep_Id, Vocation_Date, Vocation_Days, Vocation_Sm, Vocation_PayDate, Vocation_ResSm
)
  SELECT PersCard.PersCard_Id                                               Vocation_PersCard_Id, 
         RefDep.RefDep_Id                                                   Vocation_RefDep_Id, 
         dateadd(mm, mon-1, dateadd(yy, Year(GetDate())-1900, 0) )          Vocation_Date,
         coalesce (cast (L2 as integer),0)                                  Vocation_Days,
         coalesce (cast (replace(L3, ',', '.') as numeric(10,2)),0)         Vocation_Sm,
         dateadd(mm, cast(PAY_MNTH as integer)-1, 
           dateadd(yy, cast(PAY_YEAR as integer) - 1900, 0) )               Vocation_PayDate,
         coalesce (cast (replace(SUM_TOTAL, ',', '.') as numeric(10,2)),0)  Vocation_ResSm
    FROM imp_VI_LI
	INNER JOIN PersCard on PersCard.PersCard_TIN = imp_VI_LI.KOD
	INNER JOIN RefDep on RefDep.RefDep_Cd = imp_VI_LI.PIDR
	where imp_VI_LI.L1 = 'v'
