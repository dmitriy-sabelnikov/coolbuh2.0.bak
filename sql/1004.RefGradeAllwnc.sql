/****** Скрипт для заливки данных в RefGradeAllwnc (надбавки за классность) ******/
INSERT INTO RefGradeAllwnc (RefGradeAllwnc_Cd, RefGradeAllwnc_Nm, RefGradeAllwnc_Pct, RefGradeAllwnc_Grade, RefGradeAllwnc_RefDep_Id, RefGradeAllwnc_Flg) 
               values (1,'25% доплата шоферам', 25, 1, (select RefDep_Id From RefDep where RefDep_Nm = 'Автопарк'), 0);
INSERT INTO RefGradeAllwnc (RefGradeAllwnc_Cd, RefGradeAllwnc_Nm, RefGradeAllwnc_Pct, RefGradeAllwnc_Grade, RefGradeAllwnc_RefDep_Id, RefGradeAllwnc_Flg) 
               values (2,'20% доплата трактористам', 20, 1, (select RefDep_Id From RefDep where RefDep_Nm = 'Тракторна'), 0);
INSERT INTO RefGradeAllwnc (RefGradeAllwnc_Cd, RefGradeAllwnc_Nm, RefGradeAllwnc_Pct, RefGradeAllwnc_Grade, RefGradeAllwnc_RefDep_Id, RefGradeAllwnc_Flg) 
               values (3,'10% доплата за 2 клас', 10, 2, (select RefDep_Id From RefDep where RefDep_Nm = 'Автопарк'), 0);
INSERT INTO RefGradeAllwnc (RefGradeAllwnc_Cd, RefGradeAllwnc_Nm, RefGradeAllwnc_Pct, RefGradeAllwnc_Grade, RefGradeAllwnc_RefDep_Id, RefGradeAllwnc_Flg) 
               values (4, '10% доплата за 2 клас', 10, 2, (select RefDep_Id From RefDep where RefDep_Nm = 'Тракторна'), 0);