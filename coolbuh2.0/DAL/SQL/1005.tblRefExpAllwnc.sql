/****** Object:  Table [dbo].[RefExpAllwnc]    Script Date: 19.03.2018 8:43:50 ******/
--���������� �������� �� ����
IF OBJECT_ID(N'[RefExpAllwnc]','U') IS NULL
CREATE TABLE [dbo].[RefExpAllwnc]
(
	RefExpAllwnc_Id              int IDENTITY(1,1) NOT NULL,
	RefExpAllwnc_Cd              varchar(25)               , --���
        RefExpAllwnc_Nm              varchar(50)               , --������������
	RefExpAllwnc_Year            int DEFAULT (0)   NOT NULL, --���
	RefExpAllwnc_Mech            numeric(5,2)              , --�������� ���������
        RefExpAllwncMech_RefDep_Id   int                       , --������� ���������� ��� �������� ���������. �������������
	RefExpAllwnc_Oth             numeric(5,2)              , --�������� ������ ����������
        RefExpAllwnc_Flg            int                       , --����  
 CONSTRAINT [PK_RefExpAllwnc.RefExpAllwnc] PRIMARY KEY CLUSTERED 
 (
	[RefExpAllwnc_Id] ASC
 ),
  CONSTRAINT FK_RefExpAllwncMech_RefDep_Id FOREIGN KEY (RefExpAllwncMech_RefDep_Id)     
    REFERENCES RefDep (RefDep_Id) 

)