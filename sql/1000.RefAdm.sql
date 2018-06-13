/****** Скрипт заливки справочник администраций (RefAdm из imp_ADMIN) ******/
INSERT INTO RefAdm (RefAdm_DolNm, RefAdm_TIN, RefAdm_FIO, RefAdm_OrgCd, RefAdm_Tel)
  SELECT POSADA RefAdm_DolNm, 
         KOD RefAdm_TIN, 
         PIB RefAdm_FIO, 
         KOD_ORG RefAdm_OrgCd, 
         TEL RefAdm_Tel 
    FROM imp_ADMIN;