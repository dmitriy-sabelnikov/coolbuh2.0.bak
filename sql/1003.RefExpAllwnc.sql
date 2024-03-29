/****** Скрипт для заливки данных в RefExpAllwnc из STAZH (надбавки за стаж) ******/
insert into RefExpAllwnc (RefExpAllwnc_Cd, RefExpAllwnc_Nm, RefExpAllwnc_Year, RefExpAllwnc_Mech, RefExpAllwncMech_RefDep_Id, RefExpAllwnc_Oth, RefExpAllwnc_Flg)
select row_number() OVER (ORDER BY cast (YE as Integer)) RefExpAllwnc_Cd, ('Доплата за ' + cast(YE as varchar) + ' р. стажу') RefExpAllwnc_Nm,  YE _Year, ST_M as RefExpAllwnc_Mech, 
      (select RefDep_Id From RefDep where RefDep_Nm = 'Тракторна') RefExpAllwncMech_RefDep_Id, ST_I RefExpAllwnc_Oth, 0 RefExpAllwnc_Flg 
  From imp_STAZH
 where coalesce(YE,0) != 0
