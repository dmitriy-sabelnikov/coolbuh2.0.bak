/****** Object:  Table [dbo].[RefGradeAllwnc]    Script Date: 19.03.2018 8:58:01 ******/
--�������� �� ����������
IF OBJECT_ID(N'[RefGradeAllwnc]','U') IS NULL
begin
CREATE TABLE [dbo].[RefGradeAllwnc]
(
    RefGradeAllwnc_Id             int IDENTITY(1,1)      NOT NULL,
    RefGradeAllwnc_Cd             varchar(25)                    , --���
    RefGradeAllwnc_Nm             varchar(50)                    , --������������
    RefGradeAllwnc_Pct            numeric(5,2)                   , --�������
    RefGradeAllwnc_Grade          int DEFAULT (0)                , --������� ����������. ����������
    RefGradeAllwnc_RefDep_Id      int                            , --������� ����������. �������������
    RefGradeAllwnc_Flg            int                            , --�����
 CONSTRAINT [PK_RefGradeAllwnc.RefGradeAllwnc] PRIMARY KEY CLUSTERED 
 (
	[RefGradeAllwnc_Id] ASC
 ),
  CONSTRAINT FK_RefGradeAllwnc_RefDep_Id FOREIGN KEY (RefGradeAllwnc_RefDep_Id)     
    REFERENCES RefDep (RefDep_Id) 
)
end; 

