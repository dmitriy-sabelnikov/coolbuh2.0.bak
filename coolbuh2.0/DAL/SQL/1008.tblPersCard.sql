/****** Object:  Table [dbo].[PersCard]    Script Date: 19.03.2018 8:58:01 ******/
--Личные карточки
IF OBJECT_ID(N'[PersCard]','U') IS NULL
CREATE TABLE [dbo].[PersCard]
(
    PersCard_Id           int IDENTITY(1,1)      NOT NULL,
    PersCard_FName        nvarchar(35)	             ,  --Имя
    PersCard_MName        nvarchar(35)                   ,  --Отчество
    PersCard_LName        nvarchar(35)	             ,  --Фамилия
    PersCard_TIN          nvarchar(12)	     NOT NULL,  --ИНН
    PersCard_Exp          int DEFAULT (0)                ,  --Стаж(excperience)
    PersCard_Grade        int DEFAULT (0)                ,  --Классность
    PersCard_DOB          Date	                     ,  --Дата рождения(date of birth)
    PersCard_DOR          Date	                     ,  --Дата поступления(date of receipt)
    PersCard_DOD          Date	                     ,  --Дата увольнения(date of dismissal)
    PersCard_DOP          Date	                     ,  --Дата выхода на пенсию (date of pens)
--	PersCard_Pens         int DEFAULT (0)                ,  --Маска пенсионности(по месяцам)
    PersCard_ChldM1       int DEFAULT (0)                ,  --Дети месяц 1  
    PersCard_ChldM2       int DEFAULT (0)                ,  --Дети месяц 2  
    PersCard_ChldM3       int DEFAULT (0)                ,  --Дети месяц 3  
    PersCard_ChldM4       int DEFAULT (0)                ,  --Дети месяц 4  
    PersCard_ChldM5       int DEFAULT (0)                ,  --Дети месяц 5  
    PersCard_ChldM6       int DEFAULT (0)                ,  --Дети месяц 6  
    PersCard_ChldM7       int DEFAULT (0)                ,  --Дети месяц 7  
    PersCard_ChldM8       int DEFAULT (0)                ,  --Дети месяц 8  
    PersCard_ChldM9       int DEFAULT (0)                ,  --Дети месяц 9  
    PersCard_ChldM10      int DEFAULT (0)                ,  --Дети месяц 10  
    PersCard_ChldM11      int DEFAULT (0)                ,  --Дети месяц 11  
    PersCard_ChldM12      int DEFAULT (0)                ,  --Дети месяц 12  
    --PersCard_SpecExpIdM1  int                            ,  --Id спецстажа 
    --PersCard_SpecExpIdM2  int                            ,  --Id спецстажа 
    --PersCard_SpecExpIdM3  int                            ,  --Id спецстажа 
    --PersCard_SpecExpIdM4  int                            ,  --Id спецстажа 
    --PersCard_SpecExpIdM5  int                            ,  --Id спецстажа 
    --PersCard_SpecExpIdM6  int                            ,  --Id спецстажа 
    --PersCard_SpecExpIdM7  int                            ,  --Id спецстажа 
    --PersCard_SpecExpIdM8  int                            ,  --Id спецстажа 
    --PersCard_SpecExpIdM9  int                            ,  --Id спецстажа 
    --PersCard_SpecExpIdM10 int                            ,  --Id спецстажа 
    --PersCard_SpecExpIdM11 int                            ,  --Id спецстажа 
    --PersCard_SpecExpIdM12 int                            ,  --Id спецстажа 
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


