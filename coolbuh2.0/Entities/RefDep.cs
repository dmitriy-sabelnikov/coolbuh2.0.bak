using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Entities
{
    //Справочник подразделений
    public class RefDep
    {
        public int RefDep_Id { get; set; }     
        public string RefDep_Cd { get; set; }   //Код
        public string RefDep_Nm { get; set; } //Наименование
    }
}
