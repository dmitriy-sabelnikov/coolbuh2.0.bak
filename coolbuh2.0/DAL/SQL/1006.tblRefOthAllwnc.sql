/****** Object:  Table [dbo].[RefOthAllwnc]    Script Date: 19.03.2018 8:58:01 ******/
--������ �������� 
IF OBJECT_ID(N'[RefOthAllwnc]','U') IS NULL
CREATE TABLE [dbo].[RefOthAllwnc]
(
	RefOthAllwnc_Id             int IDENTITY(1,1) NOT NULL,
	RefOthAllwnc_Cd             varchar(25)               , --���
        RefOthAllwnc_Nm             varchar(50)               , --������������
        RefOthAllwnc_Pct            numeric(5,2)              , --�������
        RefOthAllwnc_Flg            int                       , --�����
 CONSTRAINT [PK_RefOthAllwnc.RefOthAllwnc] PRIMARY KEY CLUSTERED 
 (
	[RefOthAllwnc_Id] ASC
 )
)
