using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Entities
{
    //Справочник администрации
    public class RefAdm
    {
        public int RefAdm_Id { get; set; }
        public string RefAdm_DolNm { get; set; }   //Должность
        public string RefAdm_TIN { get; set; }     //ИНН
        public string RefAdm_FIO { get; set; }     //ФИО
        public string RefAdm_OrgCd { get; set; }   //Код организации
        public string RefAdm_Tel { get; set; }     //Телефон
    }
}
