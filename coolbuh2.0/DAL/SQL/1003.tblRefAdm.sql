/****** Object:  Table [dbo].[RefAdm]    Script Date: 19.03.2018 8:58:01 ******/
--���������� �������������
IF OBJECT_ID(N'[RefAdm]','U') IS NULL
CREATE TABLE [dbo].[RefAdm]
(
	RefAdm_Id        int IDENTITY(1,1) NOT NULL,
	RefAdm_DolNm     nvarchar(50)	   NOT NULL,
	RefAdm_TIN	 nvarchar(10)	   NOT NULL,
	RefAdm_FIO	 nvarchar(50)	   NOT NULL,
	RefAdm_OrgCd     nvarchar(10)	   NULL,
	RefAdm_Tel       nvarchar(12)	   NULL,
 CONSTRAINT [PK_RefAdm.RefAdm] PRIMARY KEY CLUSTERED 
 (
	[RefAdm_Id] ASC
 )
)


