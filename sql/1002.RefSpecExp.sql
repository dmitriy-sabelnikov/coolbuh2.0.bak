/****** Скрипт для заливки данных в RefSpecExp из SPS (спецстаж)******/
insert into RefSpecExp (RefSpecExp_Cd, RefSpecExp_ShortName, RefSpecExp_Name)
select NUM as RefSpecExp_Cd, C_PID as RefSpecExp_ShortName, NAME as RefSpecExp_Name
  From imp_SPS;