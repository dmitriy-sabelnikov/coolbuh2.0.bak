/****** ������ ��� ������� ������ � PersCard �� Litc (�������� �����) ******/
INSERT INTO PersCard (PersCard_FName, PersCard_MName, PersCard_LName, PersCard_TIN, PersCard_Exp, 
                      PersCard_Grade, PersCard_DOB, PersCard_DOR, PersCard_DOD, PersCard_DOP,
                      /*PersCard_Pens,*/
                      PersCard_ChldM1, PersCard_ChldM2, PersCard_ChldM3, PersCard_ChldM4, PersCard_ChldM5, PersCard_ChldM6,
		      PersCard_ChldM7, PersCard_ChldM8, PersCard_ChldM9, PersCard_ChldM10, PersCard_ChldM11, PersCard_ChldM12/*,
   		      PersCard_SpecExpIdM1, PersCard_SpecExpIdM2, PersCard_SpecExpIdM3, PersCard_SpecExpIdM4, PersCard_SpecExpIdM5,
		      PersCard_SpecExpIdM6, PersCard_SpecExpIdM7, PersCard_SpecExpIdM8, PersCard_SpecExpIdM9, PersCard_SpecExpIdM10,
		      PersCard_SpecExpIdM11, PersCard_SpecExpIdM12*/
		     )
 select          
         PersCard_FName,     --���
         PersCard_MName,     --��������
         PersCard_LName,     --�������
         PersCard_TIN,       --���
         PersCard_Exp,       --����(excperience)
         PersCard_Grade,     --����������
         PersCard_DOB,       --���� ��������(date of birth)
         PersCard_DOR,       --���� �����������(date of receipt)
         PersCard_DOD,       --���� ����������(date of dismissal)
         (case when month_pens > 0 then dateadd(mm, month_pens-1, dateadd(yy, Year(GetDate())-1900, 0)) 
		      else NULL
			    end) PersCard_DOP, -- ���� ������ �� ������ (date of pens)
         --p1|p2|p3|p4|p5|p6|p7|p8|p9|p10|p11|p12 PersCard_Pens, --������������
         PersCard_ChldM1,  --���� ����� 1  
         PersCard_ChldM2,  --���� ����� 2  
         PersCard_ChldM3,  --���� ����� 3  
         PersCard_ChldM4,  --���� ����� 4  
         PersCard_ChldM5,  --���� ����� 5  
         PersCard_ChldM6,  --���� ����� 6  
         PersCard_ChldM7,  --���� ����� 7  
         PersCard_ChldM8,  --���� ����� 8  
         PersCard_ChldM9,  --���� ����� 9  
         PersCard_ChldM10,  --���� ����� 10  
         PersCard_ChldM11,  --���� ����� 11  
         PersCard_ChldM12  --���� ����� 12  
         --PersCard_SpecExpIdM1,  --Id ��������� ����� 1 
         --PersCard_SpecExpIdM2,  --Id ��������� ����� 2
         --PersCard_SpecExpIdM3,  --Id ��������� ����� 3
         --PersCard_SpecExpIdM4,  --Id ��������� ����� 4
         --PersCard_SpecExpIdM5,  --Id ��������� ����� 5
         --PersCard_SpecExpIdM6,  --Id ��������� ����� 6
         --PersCard_SpecExpIdM7,  --Id ��������� ����� 7
         --PersCard_SpecExpIdM8,  --Id ��������� ����� 8
         --PersCard_SpecExpIdM9,  --Id ��������� ����� 9
         --PersCard_SpecExpIdM10,  --Id ��������� ����� 10
         --PersCard_SpecExpIdM11,  --Id ��������� ����� 11
         --PersCard_SpecExpIdM12   --Id ��������� ����� 12
  from (
  SELECT 
         A2  PersCard_FName,     --���
         A3  PersCard_MName,     --��������
         A1  PersCard_LName,     --�������
         A4  PersCard_TIN,       --���
         A5  PersCard_Exp,       --����(excperience)
         A6  PersCard_Grade,     --����������
         A12 PersCard_DOB,       --���� ��������(date of birth)
         A7  PersCard_DOR,       --���� �����������(date of receipt)
         A8  PersCard_DOD,       --���� ����������(date of dismissal)
         (case when p1 != '' then 1 
               when p2 != '' then 2 
               when p3 != '' then 3 
               when p4 != '' then 4 
               when p5 != '' then 5
               when p6 != '' then 6
               when p7 != '' then 7
               when p8 != '' then 8
               when p9 != '' then 9
               when p10 != '' then 10
               when p11 != '' then 11
               when p12 != '' then 12
               else 0
           end) month_pens,       --����� ������ �� ������ 
         --(case when p1  is not null then 1 else 0 end) p1, 
         --(case when p2  is not null then 2 else 0 end) p2,
         --(case when p3  is not null then 4 else 0 end) p3,
         --(case when p4  is not null then 8 else 0 end) p4,
	     --(case when p5  is not null then 16 else 0 end) p5,
	     --(case when p6  is not null then 32 else 0 end) p6,
	     --(case when p7  is not null then 64 else 0 end) p7,
         --(case when p8  is not null then 128 else 0 end) p8,
         --(case when p9  is not null then 256 else 0 end) p9,
         --(case when p10 is not null then 512 else 0 end) p10,
         --(case when p11 is not null then 1024 else 0 end) p11,
         --(case when p12 is not null then 2048 else 0 end) p12,
         D1 PersCard_ChldM1,  --���� ����� 1  
         D2 PersCard_ChldM2,  --���� ����� 2  
         D3 PersCard_ChldM3,  --���� ����� 3  
         D4 PersCard_ChldM4,  --���� ����� 4  
         D5 PersCard_ChldM5,  --���� ����� 5  
         D6 PersCard_ChldM6,  --���� ����� 6  
         D7 PersCard_ChldM7,  --���� ����� 7  
         D8 PersCard_ChldM8,  --���� ����� 8  
         D9 PersCard_ChldM9,  --���� ����� 9  
         D10 PersCard_ChldM10,  --���� ����� 10  
         D11 PersCard_ChldM11,  --���� ����� 11  
         D12 PersCard_ChldM12  --���� ����� 12  
         --specExpM1.RefSpecExp_Id PersCard_SpecExpIdM1,  --Id ��������� ����� 1 
         --specExpM2.RefSpecExp_Id PersCard_SpecExpIdM2,  --Id ��������� ����� 2
         --specExpM3.RefSpecExp_Id PersCard_SpecExpIdM3,  --Id ��������� ����� 3
         --specExpM4.RefSpecExp_Id PersCard_SpecExpIdM4,  --Id ��������� ����� 4
         --specExpM5.RefSpecExp_Id PersCard_SpecExpIdM5,  --Id ��������� ����� 5
         --specExpM6.RefSpecExp_Id PersCard_SpecExpIdM6,  --Id ��������� ����� 6
         --specExpM7.RefSpecExp_Id PersCard_SpecExpIdM7,  --Id ��������� ����� 7
         --specExpM8.RefSpecExp_Id PersCard_SpecExpIdM8,  --Id ��������� ����� 8
         --specExpM9.RefSpecExp_Id PersCard_SpecExpIdM9,  --Id ��������� ����� 9
         --specExpM10.RefSpecExp_Id PersCard_SpecExpIdM10,  --Id ��������� ����� 10
         --specExpM11.RefSpecExp_Id PersCard_SpecExpIdM11,  --Id ��������� ����� 11
         --specExpM12.RefSpecExp_Id PersCard_SpecExpIdM12   --Id ��������� ����� 12
         
    FROM  imp_Lits
    /*
	LEFT JOIN RefSpecExp specExpM1 on specExpM1.RefSpecExp_Cd = imp_Lits.SPS1
	LEFT JOIN RefSpecExp specExpM2 on specExpM2.RefSpecExp_Cd = imp_Lits.SPS2
	LEFT JOIN RefSpecExp specExpM3 on specExpM3.RefSpecExp_Cd = imp_Lits.SPS3
	LEFT JOIN RefSpecExp specExpM4 on specExpM4.RefSpecExp_Cd = imp_Lits.SPS4
	LEFT JOIN RefSpecExp specExpM5 on specExpM5.RefSpecExp_Cd = imp_Lits.SPS5
	LEFT JOIN RefSpecExp specExpM6 on specExpM6.RefSpecExp_Cd = imp_Lits.SPS6
	LEFT JOIN RefSpecExp specExpM7 on specExpM7.RefSpecExp_Cd = imp_Lits.SPS7
	LEFT JOIN RefSpecExp specExpM8 on specExpM8.RefSpecExp_Cd = imp_Lits.SPS8
	LEFT JOIN RefSpecExp specExpM9 on specExpM9.RefSpecExp_Cd = imp_Lits.SPS9
	LEFT JOIN RefSpecExp specExpM10 on specExpM10.RefSpecExp_Cd = imp_Lits.SPS10
	LEFT JOIN RefSpecExp specExpM11 on specExpM11.RefSpecExp_Cd = imp_Lits.SPS11
	LEFT JOIN RefSpecExp specExpM12 on specExpM12.RefSpecExp_Cd = imp_Lits.SPS12
    */
	) t
                    