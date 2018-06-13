/****** Object:  Table [dbo].[PersCard]    Script Date: 19.03.2018 8:58:01 ******/
--������ ��������
IF OBJECT_ID(N'[PersCard]','U') IS NULL
CREATE TABLE [dbo].[PersCard]
(
    PersCard_Id           int IDENTITY(1,1)      NOT NULL,
    PersCard_FName        nvarchar(35)	             ,  --���
    PersCard_MName        nvarchar(35)                   ,  --��������
    PersCard_LName        nvarchar(35)	             ,  --�������
    PersCard_TIN          nvarchar(12)	     NOT NULL,  --���
    PersCard_Exp          int DEFAULT (0)                ,  --����(excperience)
    PersCard_Grade        int DEFAULT (0)                ,  --����������
    PersCard_DOB          Date	                     ,  --���� ��������(date of birth)
    PersCard_DOR          Date	                     ,  --���� �����������(date of receipt)
    PersCard_DOD          Date	                     ,  --���� ����������(date of dismissal)
    PersCard_DOP          Date	                     ,  --���� ������ �� ������ (date of pens)
--	PersCard_Pens         int DEFAULT (0)                ,  --����� ������������(�� �������)
    PersCard_ChldM1       int DEFAULT (0)                ,  --���� ����� 1  
    PersCard_ChldM2       int DEFAULT (0)                ,  --���� ����� 2  
    PersCard_ChldM3       int DEFAULT (0)                ,  --���� ����� 3  
    PersCard_ChldM4       int DEFAULT (0)                ,  --���� ����� 4  
    PersCard_ChldM5       int DEFAULT (0)                ,  --���� ����� 5  
    PersCard_ChldM6       int DEFAULT (0)                ,  --���� ����� 6  
    PersCard_ChldM7       int DEFAULT (0)                ,  --���� ����� 7  
    PersCard_ChldM8       int DEFAULT (0)                ,  --���� ����� 8  
    PersCard_ChldM9       int DEFAULT (0)                ,  --���� ����� 9  
    PersCard_ChldM10      int DEFAULT (0)                ,  --���� ����� 10  
    PersCard_ChldM11      int DEFAULT (0)                ,  --���� ����� 11  
    PersCard_ChldM12      int DEFAULT (0)                ,  --���� ����� 12  
    --PersCard_SpecExpIdM1  int                            ,  --Id ��������� 
    --PersCard_SpecExpIdM2  int                            ,  --Id ��������� 
    --PersCard_SpecExpIdM3  int                            ,  --Id ��������� 
    --PersCard_SpecExpIdM4  int                            ,  --Id ��������� 
    --PersCard_SpecExpIdM5  int                            ,  --Id ��������� 
    --PersCard_SpecExpIdM6  int                            ,  --Id ��������� 
    --PersCard_SpecExpIdM7  int                            ,  --Id ��������� 
    --PersCard_SpecExpIdM8  int                            ,  --Id ��������� 
    --PersCard_SpecExpIdM9  int                            ,  --Id ��������� 
    --PersCard_SpecExpIdM10 int                            ,  --Id ��������� 
    --PersCard_SpecExpIdM11 int                            ,  --Id ��������� 
    --PersCard_SpecExpIdM12 int                            ,  --Id ��������� 
 CONSTRAINT [PK_PersCard.PersCard] PRIMARY KEY CLUSTERED 
 (
	[PersCard_Id] ASC
 )
/*
,
 CONSTRAINT FK_RefSpecExp_IdM1 FOREIGN KEY (PersCard_SpecExpIdM1)     
    REFERENCES RefSpecExp (RefSpecExp_Id), 
 CONSTRAINT FK_RefSpecExp_IdM2 FOREIGN KEY (PersCard_SpecExpIdM2)     
    REFERENCES RefSpecExp (RefSpecExp_Id), 
 CONSTRAINT FK_RefSpecExp_IdM3 FOREIGN KEY (PersCard_SpecExpIdM3)     
    REFERENCES RefSpecExp (RefSpecExp_Id), 
 CONSTRAINT FK_RefSpecExp_IdM4 FOREIGN KEY (PersCard_SpecExpIdM4)     
    REFERENCES RefSpecExp (RefSpecExp_Id), 
 CONSTRAINT FK_RefSpecExp_IdM5 FOREIGN KEY (PersCard_SpecExpIdM5)     
    REFERENCES RefSpecExp (RefSpecExp_Id), 
 CONSTRAINT FK_RefSpecExp_IdM6 FOREIGN KEY (PersCard_SpecExpIdM6)     
    REFERENCES RefSpecExp (RefSpecExp_Id), 
 CONSTRAINT FK_RefSpecExp_IdM7 FOREIGN KEY (PersCard_SpecExpIdM7)     
    REFERENCES RefSpecExp (RefSpecExp_Id), 
 CONSTRAINT FK_RefSpecExp_IdM8 FOREIGN KEY (PersCard_SpecExpIdM8)     
    REFERENCES RefSpecExp (RefSpecExp_Id), 
 CONSTRAINT FK_RefSpecExp_IdM9 FOREIGN KEY (PersCard_SpecExpIdM9)     
    REFERENCES RefSpecExp (RefSpecExp_Id), 
 CONSTRAINT FK_RefSpecExp_IdM10 FOREIGN KEY (PersCard_SpecExpIdM10)     
    REFERENCES RefSpecExp (RefSpecExp_Id), 
 CONSTRAINT FK_RefSpecExp_IdM11 FOREIGN KEY (PersCard_SpecExpIdM11)     
    REFERENCES RefSpecExp (RefSpecExp_Id), 
 CONSTRAINT FK_RefSpecExp_IdM12 FOREIGN KEY (PersCard_SpecExpIdM12)     
    REFERENCES RefSpecExp (RefSpecExp_Id) 
*/
)


