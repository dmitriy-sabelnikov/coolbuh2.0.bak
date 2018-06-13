using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    //Личная карточка
    public class PersCard
    {
        public int PersCard_Id { get; set; }
        public string PersCard_LName { get; set; } //Фамилия
        public string PersCard_FName { get; set; } //Имя
        public string PersCard_MName { get; set; } //Отчество
        public string PersCard_TIN { get; set; }   //ИНН
        public int PersCard_Exp { get; set; }      //Стаж(excperience)
        public int PersCard_Grade { get; set; }    //Классность
        public DateTime PersCard_DOB { get; set; } //Дата рождения(date of birth)
        public DateTime PersCard_DOR { get; set; } //Дата поступления(date of receipt)
        public DateTime PersCard_DOD { get; set; } //Дата увольнения(date of dismissal)
        public DateTime PersCard_DOP { get; set; } //Дата выхода на пенсию (date of pens)

        //public int PersCard_Pens { get; set; }     //Маска пенсионности(по месяцам)
        public int PersCard_ChldM1 { get; set; }   //Дети месяц 1  
        public int PersCard_ChldM2 { get; set; }   //Дети месяц 2  
        public int PersCard_ChldM3 { get; set; }   //Дети месяц 3  
        public int PersCard_ChldM4 { get; set; }   //Дети месяц 4  
        public int PersCard_ChldM5 { get; set; }   //Дети месяц 5  
        public int PersCard_ChldM6 { get; set; }   //Дети месяц 6  
        public int PersCard_ChldM7 { get; set; }   //Дети месяц 7  
        public int PersCard_ChldM8 { get; set; }   //Дети месяц 8  
        public int PersCard_ChldM9 { get; set; }   //Дети месяц 9  
        public int PersCard_ChldM10 { get; set; }  //Дети месяц 10  
        public int PersCard_ChldM11 { get; set; }  //Дети месяц 11  
        public int PersCard_ChldM12 { get; set; }  //Дети месяц 12  
        //public int PersCard_SpecExpIdM1 { get; set; }  //Id спецстажа
        //public int PersCard_SpecExpIdM2 { get; set; }  //Id спецстажа
        //public int PersCard_SpecExpIdM3 { get; set; }  //Id спецстажа
        //public int PersCard_SpecExpIdM4 { get; set; }  //Id спецстажа
        //public int PersCard_SpecExpIdM5 { get; set; }  //Id спецстажа
        //public int PersCard_SpecExpIdM6 { get; set; }  //Id спецстажа
        //public int PersCard_SpecExpIdM7 { get; set; }  //Id спецстажа
        //public int PersCard_SpecExpIdM8 { get; set; }  //Id спецстажа
        //public int PersCard_SpecExpIdM9 { get; set; }  //Id спецстажа
        //public int PersCard_SpecExpIdM10 { get; set; } //Id спецстажа
        //public int PersCard_SpecExpIdM11 { get; set; } //Id спецстажа
        //public int PersCard_SpecExpIdM12 { get; set; } //Id спецстажа
    }
}
