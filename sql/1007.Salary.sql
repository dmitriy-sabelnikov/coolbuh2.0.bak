/****** Скрипт для заливки данных в Salary из Work (заработная плата) ******/
INSERT INTO Salary (
  Salary_PersCard_Id, Salary_RefDep_Id, Salary_Date, Salary_Days, Salary_Hours, Salary_BaseSm, Salary_PensSm, 
  Salary_ExpSm, Salary_GradeSm, Salary_OthSm, Salary_KTU, Salary_KTUSm, Salary_ResSm
)
  SELECT PersCard.PersCard_Id                                      Salary_PersCard_Id, 
		 RefDep.RefDep_Id                                          Salary_RefDep_Id, 
		 dateadd(mm, mon-1, dateadd(yy, Year(GetDate())-1900, 0) ) Salary_Date,
		 B1                                                        Salary_Days, 
		 cast(B2 as numeric(5,2)) 		                   salary_Hours, 
		 cast(replace(imp_WORKS.SUM, ',','.') as numeric(10,2))    Salary_BaseSm, 
		 cast(replace(SUM_1, ',','.') as numeric(10,2))            Salary_PensSm, 
		 cast(replace(SUM_2, ',','.') as numeric(10,2))            Salary_ExpSm, 
		 cast(replace(SUM_3, ',','.') as numeric(10,2))            Salary_GradeSm, 
		 cast(replace(SUM_4, ',','.') as numeric(10,2))            Salary_OthSm, 
		 cast(replace(KTU, ',','.')   as numeric(5,2))             Salary_KTU, 
		 cast(replace(Z_KTU, ',','.') as numeric(10,2))            Salary_KTUSm,
                 cast(replace(vsogo, ',','.') as numeric(10,2))            Salary_ResSm
    FROM imp_WORKS
	INNER JOIN PersCard on PersCard.PersCard_TIN = imp_WORKS.KOD
	INNER JOIN RefDep on RefDep.RefDep_Cd = imp_WORKS.PIDR
	where mon is not NULL
