using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinUI.Helper
{
    public static class MainMenuName
    {
        public static string MainMenu       = "MainMenu";       //1      Главное меню
        //================================                      
        public static string Ref            = "Ref";            //1.1    Справочники
        public static string RefDep         = "RefDep";         //1.1.1  Справочник подразделений
        public static string RefAdm         = "RefAdm";         //1.1.2  Справочник администрации
        public static string RefSpecExp     = "RefSpecExp";     //1.1.3  Справочник спецстажей
        public static string RefExpAllwnc   = "RefExpAllwnc";   //1.1.3  Справочник надбавок за стаж
        public static string RefGradeAllwnc = "RefGradeAllwnc"; //1.1.4  Справочник надбавок за классность
        public static string RefPensAllwnc  = "RefPensAllwnc";  //1.1.5  Справочник надбавок пенсионеру
        public static string RefOthAllwnc   = "RefOthAllwnc";   //1.1.6  Справочник надбавок прочих
 
        //================================
        public static string Service        = "Service";        //1.2    Сервис
        public static string ImportDB       = "ImportDB";       //1.2.1  Импорт базы
        public static string Setup          = "Setup";          //1.2.2  Настройка
        public static string UpdateDB       = "UpdateDB";       //1.2.3  Обновление серверных объектов
        //================================                      
        public static string Personal       = "Personal";       //1.3    Кадры
        public static string PersCard       = "PersCard";       //1.3.1  Карточка учета
        //================================                      
        public static string Accrual        = "Accrual";        //1.4.   Начисления
        public static string Salary         = "Salary";         //1.4.1  Начисление. Заработная плата
        public static string Vocation       = "Vocation";       //1.4.2  Начисление. Отпуск
        public static string SickList       = "SickList";       //1.4.3  Начисление. Больничный
        public static string LawContract    = "LawContract";    //1.4.4  Начисление. Договор ГПХ
        public static string AddPay         = "AddPay";         //1.4.5  Дополнительные начисления
        public static string IncTax         = "IncTax";         //1.4.6  Корректировка подоходного налога
        //================================                      
        public static string Close          = "Close";          //2      Выход
    }
}
