using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DAL;
using Entities;
using EnumType;

namespace BLL
{
    public static class SetupProgram
    {
        public static void InitSetups(List<SetupApp> setups)
        {
            foreach (SetupApp setup in setups)
            {
                switch(setup.SetupApp_Type)
                {
                    case (int)SetupAppType.PathToDBFFile:
                        PathToDBFFile = setup.SetupApp_ValueString;
                        break;
                    case (int)SetupAppType.PathToSQLFile:
                        PathToSQLFile = setup.SetupApp_ValueString;
                        break;
                    case (int)SetupAppType.ConvertCp1252To866:
                        IsNeedConvertCp1252To866 = setup.SetupApp_ValueDigit > 0 ? true : false;
                        break;
                    case (int)SetupAppType.YearSalary:
                        YearSalary = setup.SetupApp_ValueDigit;
                        break;
                }
            }
            CurrentProcessId = System.Diagnostics.Process.GetCurrentProcess().Id;
        }
        public static int CurrentProcessId { get; set; }      //id текущей сессии
        //===============================Настройка иморта===============================
        public static SqlConnection Connection { get; set; }  //соединение с сервером БД
        public static string PathToDBFFile { get; set; }      //путь к DBF файлам
        public static string PathToSQLFile { get; set; }      //путь к SQL скриптам
        public static bool IsNeedConvertCp1252To866 { get; set; }
        //===============================Настройка зарплаты===============================
        public static int YearSalary { get; set; }           //Кол-во лет отображения периодов
    }
}
