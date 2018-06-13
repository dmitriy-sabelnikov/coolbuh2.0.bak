using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    //Справочник спецстажей
    public class RefSpecExp
    {
        public int RefSpecExp_Id { get; set; }
        public string RefSpecExp_Cd { get; set; }        //Код
        public string RefSpecExp_ShortName { get; set; } //Краткое наименование
        public string RefSpecExp_Name { get; set; }      //Полное наименование
    }
}
