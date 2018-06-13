/****** Object:  Table [dbo].[Vocation]    Script Date: 19.03.2018 8:58:01 ******/
--���������
IF OBJECT_ID(N'[Vocation]','U') IS NULL
begin
CREATE TABLE [dbo].[Vocation]
(
	Vocation_Id             int IDENTITY(1,1)      NOT NULL,
	Vocation_PersCard_Id    int                    NOT NULL,  --������ �� �������� ���������
	Vocation_RefDep_Id      int                    NOT NULL,  --������ �� ���������� �������������
	Vocation_Date           date                           ,  --����
	Vocation_Days           int DEFAULT (0)                ,  --��� �������
	Vocation_Sm             numeric(10,2) DEFAULT (0)      ,  --����� ���������
	Vocation_PayDate        date                           ,  --����, �� ������� ���������� ����������
	Vocation_ResSm          numeric(10,2) DEFAULT (0)         --�������� �����
 CONSTRAINT [PK_Vocation.Vocation] PRIMARY KEY CLUSTERED 
 (
	[Vocation_Id] ASC
 ),
 CONSTRAINT FK_Vocation_RefDep_Id FOREIGN KEY (Vocation_RefDep_Id)     
    REFERENCES RefDep (RefDep_Id), 
 CONSTRAINT FK_Vocation_PersCard_Id FOREIGN KEY (Vocation_PersCard_Id)     
    REFERENCES PersCard (PersCard_Id), 
)

create index ind_Vocation_1_1 on Vocation (Vocation_PersCard_Id);
create index ind_Vocation_1_2 on Vocation (Vocation_RefDep_Id);
end; 

