/****** ������ ��� ������� ������ � RefGradeAllwnc (�������� �� ����������) ******/
INSERT INTO RefGradeAllwnc (RefGradeAllwnc_Cd, RefGradeAllwnc_Nm, RefGradeAllwnc_Pct, RefGradeAllwnc_Grade, RefGradeAllwnc_RefDep_Id, RefGradeAllwnc_Flg) 
               values (1,'25% ������� �������', 25, 1, (select RefDep_Id From RefDep where RefDep_Nm = '��������'), 0);
INSERT INTO RefGradeAllwnc (RefGradeAllwnc_Cd, RefGradeAllwnc_Nm, RefGradeAllwnc_Pct, RefGradeAllwnc_Grade, RefGradeAllwnc_RefDep_Id, RefGradeAllwnc_Flg) 
               values (2,'20% ������� ������������', 20, 1, (select RefDep_Id From RefDep where RefDep_Nm = '���������'), 0);
INSERT INTO RefGradeAllwnc (RefGradeAllwnc_Cd, RefGradeAllwnc_Nm, RefGradeAllwnc_Pct, RefGradeAllwnc_Grade, RefGradeAllwnc_RefDep_Id, RefGradeAllwnc_Flg) 
               values (3,'10% ������� �� 2 ����', 10, 2, (select RefDep_Id From RefDep where RefDep_Nm = '��������'), 0);
INSERT INTO RefGradeAllwnc (RefGradeAllwnc_Cd, RefGradeAllwnc_Nm, RefGradeAllwnc_Pct, RefGradeAllwnc_Grade, RefGradeAllwnc_RefDep_Id, RefGradeAllwnc_Flg) 
               values (4, '10% ������� �� 2 ����', 10, 2, (select RefDep_Id From RefDep where RefDep_Nm = '���������'), 0);