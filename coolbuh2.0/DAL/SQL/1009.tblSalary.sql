/****** Object:  Table [dbo].[Salary]    Script Date: 19.03.2018 8:58:01 ******/
--������ ��������
IF OBJECT_ID(N'[Salary]','U') IS NULL
begin
CREATE TABLE [dbo].[Salary]
(
	Salary_Id             int IDENTITY(1,1)      NOT NULL,
	Salary_PersCard_Id    int                    NOT NULL,  --������ �� �������� ���������
	Salary_RefDep_Id      int                    NOT NULL,  --������ �� ���������� �������������
	Salary_Date           date                           ,  --����
	Salary_Days           int DEFAULT (0)                ,  --������������ ���
	Salary_Hours          numeric(5,2)  DEFAULT (0)      ,  --������������ ����
	Salary_BaseSm         numeric(10,2) DEFAULT (0)      ,  --�������� ��������
	Salary_PensId         int                            ,  --������� ����������(id ������� �� Allowance)
	Salary_PensPct        numeric(5,2)  DEFAULT (0)      ,  --������� ����������(�������)
	Salary_PensSm         numeric(10,2) DEFAULT (0)      ,  --������� ����������(�����) 
	Salary_ExpId          int                            ,  --������� �� ����(id ������� �� Allowance)
	Salary_ExpPct         numeric(5,2) DEFAULT (0)       ,  --������� �� ����(�������)
	Salary_ExpSm          numeric(10,2) DEFAULT (0)      ,  --������� �� ����(�����)
	Salary_GradeId        int                            ,  --������� �� ���������(id ������� �� Allowance)
	Salary_GradePct       numeric(5,2) DEFAULT (0)       ,  --������� �� ���������(�������)
	Salary_GradeSm        numeric(10,2) DEFAULT (0)      ,  --������� �� ���������(�����)
	Salary_OthId          int                            ,  --������ �������(id ������� �� Allowance)
	Salary_OthPct         numeric(5,2) DEFAULT (0)       ,  --������ �������(�������)
	Salary_OthSm          numeric(10,2) DEFAULT (0)      ,  --������ �������(�����)
	Salary_KTU            numeric(5,2)  DEFAULT (0)      ,  --���
	Salary_KTUSm          numeric(10,2) DEFAULT (0)      ,  --������� �� ���
	Salary_ResSm          numeric(10,2) DEFAULT (0)         --�������� �����
 CONSTRAINT [PK_Salary.Salary] PRIMARY KEY CLUSTERED 
 (
	[Salary_Id] ASC
 ),
 CONSTRAINT FK_Salary_RefDep_Id FOREIGN KEY (Salary_RefDep_Id)     
    REFERENCES RefDep (RefDep_Id), 
 CONSTRAINT FK_Salary_PersCard_Id FOREIGN KEY (Salary_PersCard_Id)     
    REFERENCES PersCard (PersCard_Id), 
 CONSTRAINT FK_Salary_PensId FOREIGN KEY (Salary_PensId)     
    REFERENCES RefPensAllwnc (RefPensAllwnc_Id), 
 CONSTRAINT FK_Salary_ExpId FOREIGN KEY (Salary_ExpId)     
    REFERENCES RefExpAllwnc (RefExpAllwnc_Id),
 CONSTRAINT FK_Salary_GradeId FOREIGN KEY (Salary_GradeId)     
    REFERENCES RefGradeAllwnc (RefGradeAllwnc_Id), 
 CONSTRAINT FK_Salary_OthId FOREIGN KEY (Salary_OthId)     
    REFERENCES RefOthAllwnc (RefOthAllwnc_Id) 
)

create index ind_Salary_1_1 on Salary (Salary_PersCard_Id);
create index ind_Salary_1_2 on Salary (Salary_RefDep_Id);
end; 

