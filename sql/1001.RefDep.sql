/****** Скрипт для заливки данных в RefDep из pidroz(справочник подразделений) ******/
insert into RefDep (RefDep_Cd, RefDep_Nm)
select poz as RefDep_Cd, pi as RefDep_Nm
  From imp_pidroz;