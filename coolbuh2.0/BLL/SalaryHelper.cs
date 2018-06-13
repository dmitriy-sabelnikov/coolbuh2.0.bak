using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace BLL
{
    public static class SalaryHelper
    {
        /// <summary>
        /// Получить наименование месяца по индексу
        /// </summary>
        /// <param name="index">Yомер месяца</param>
        /// <returns>Наименование месяца </returns>
        private static string GetMonthNameById(int index)
        {
            string name = string.Empty;
            switch(index)
            {
                case 1:
                    name = "Січень";
                    break;
                case 2:
                    name = "Лютий";
                    break;
                case 3:
                    name = "Березень";
                    break;
                case 4:
                    name = "Квітень";
                    break;
                case 5:
                    name = "Травень";
                    break;
                case 6:
                    name = "Червень";
                    break;
                case 7:
                    name = "Липень";
                    break;
                case 8:
                    name = "Серпень";
                    break;
                case 9:
                    name = "Вересень";
                    break;
                case 10:
                    name = "Жовтень";
                    break;
                case 11:
                    name = "Листопад";
                    break;
                case 12:
                    name = "Грудень";
                    break;
            }
            return name;
        }

        /// <summary>
        /// Получить календарь в формате месяц-год
        /// </summary>
        /// <param name="yearStart">Год начала отчета</param>
        /// <param name="addRecordAllYear">Добавить строку год без месяца</param>
        /// <returns>Cписок месяц-год</returns>
        public static List<string> GetMonthNames(int yearStart, bool addRecordAllYear)
        {
            List<string> names = new List<string>();

            for (int year = yearStart; year <= DateTime.Today.Year; year++)
            {
                if(addRecordAllYear)
                {
                    names.Add("Рік " + year.ToString());
                }
                for (int month = 1; month <= 12; month++)
                {
                    if (year == DateTime.Today.Year && month > DateTime.Today.Month)
                        break;
                    names.Add(GetMonthNameById(month) + " " + year.ToString());
                }
            }
            return names;
        }
        /// <summary>
        /// Получить год по индексу
        /// </summary>
        /// <param name="yearStart">Год начала отчета</param>
        /// <param name="index">Индекс</param>
        /// <param name="addAllYear">Добавить строку год без месяца</param>
        /// <returns>Год</returns>
        public static int GetYearByIndex(int yearStart, int index, bool addAllYear)
        {
            if(index < 0) return 0;
            int maxCntIndex = addAllYear == true ? 13 : 12;
            return yearStart + index / maxCntIndex;
        }
        /// <summary>
        /// Получить номер месяца по индексу
        /// Если addAllYear = true, то month = 0 это год (напр 2017 год) и month  в диапазоне (1, 12)
        /// </summary>
        /// <param name="index">Индекс</param>
        /// <param name="addAllYear">Добавить строку год без месяца</param>
        /// <returns>Номер месяца</returns>
        public static int GetMonthByIndex(int index, bool addAllYear)
        {
            if (index < 0) return 0;
            int maxCntIndex = addAllYear == true ? 13 : 12;
            int month = index % maxCntIndex;
            if (addAllYear == false)
                month++;
            return month;
        }
        /// <summary>
        /// Получить индекс для комбика по дате
        /// </summary>
        /// <param name="yearStart">Год начала отсчета</param>
        /// <param name="date">Дата для которой определяется индекса</param>
        /// <param name="addAllYear">Добавить строку год без месяца</param>
        /// <returns>Индекс для комбика</returns>
        public static int GetIndexByDate(int yearStart, DateTime date, bool addAllYear)
        {
            if (date == DateTime.MinValue) return 0;
            int maxCntIndex = addAllYear == true ? 13 : 12;

            return (date.Year - yearStart) * maxCntIndex + date.Month - 1;
        }

        ///<summary>
        ///Является ли пенсионером
        ///</summary>
        ///<returns>
        ///true - пенсионер
        /// </returns>
        ///<param name="calcDate">Дата на которую производится расчет</param>
        ///<param name="dop">Дата выхода на пенсию</param>
        public static bool IsPensWorker(DateTime calcDate, DateTime dop)
        {
            if (dop == DateTime.MinValue)
                return false;

            return dop <= calcDate ? true : false;
        }
        /// <summary>
        /// Получить сумму согласно КТУ
        /// </summary>
        /// <param name="ktu">КТУ</param>
        /// <param name="baseSm">Основная зарплата</param>
        /// <param name="allwncTotalSm">Общая сумма доплат</param>
        /// <param name="allwncTotalPct">Общая процент доплат</param>
        /// <param name="infoCalc">Результат расчета</param>
        /// <returns>Сумма КТУ</returns>
        public static double GetKTUSm(double ktu, double baseSm, double allwncTotalSm, double allwncTotalPct, ref StringBuilder infoCalc)
        {
            infoCalc.Clear();
            infoCalc.AppendLine("ПОЧАТКОВІ ДАНІ");
            infoCalc.AppendFormat("  Основна зарплата: {0} грн.\n", baseSm);
            infoCalc.AppendFormat("  Загальна сума доплат: {0} грн.\n", allwncTotalSm);
            infoCalc.AppendFormat("  Загальний відсоток доплат: {0}%\n", allwncTotalPct);
            infoCalc.AppendFormat("  КТУ: {0} \n", ktu);
            infoCalc.AppendLine("РОЗРАХУНОК");
            if (ktu == 1 || ktu == 0)
            {
                infoCalc.AppendLine("  Сума згідно з КТУ: 0.00 грн.\n");
                return 0;
            }
            if (ktu > 1)
            {
                double ktuSm = Math.Round((baseSm + allwncTotalSm) * (ktu - 1), 2);
                infoCalc.AppendFormat("  Сума згідно з КТУ: {0} грн.\n", ktuSm);
                infoCalc.AppendFormat("    - ({0} + {1}) * ({2} - 1)\n", baseSm, allwncTotalSm, ktu);
                return ktuSm;
            }
            if (ktu < 1)
            {
                double ktuPct = (1 - ktu) * 100.00;
                infoCalc.AppendFormat("  Відсоток КТУ: {0}\n", ktuPct);
                infoCalc.AppendFormat("    - (1 - {0}) * 100\n", ktu);
                if (ktuPct < allwncTotalPct)
                {
                    infoCalc.AppendFormat("  {0} < {1}\n", ktuPct, allwncTotalPct);
                    double ktuSm = Math.Round((-1 * (allwncTotalSm) * ktuPct / allwncTotalPct), 2);
                    infoCalc.AppendFormat("  Сума згідно з КТУ: {0} грн.\n", ktuSm);
                    infoCalc.AppendFormat("    - -1 * {0} * {1}/{2}\n", allwncTotalSm, ktuPct, allwncTotalPct);
                    return ktuSm;
                }
                else
                {
                    double ktuSm = -1 * allwncTotalSm;
                    infoCalc.AppendFormat("  {0} >= {1}\n", ktuPct, allwncTotalPct);
                    infoCalc.AppendFormat("  Сума згідно з КТУ: {0} грн.\n", ktuSm);
                    infoCalc.AppendFormat("    - -1 * {0}\n", ktuSm);
                    return ktuSm;
                }
            }
            return 0;
        }
        /// <summary>
        /// Полученние суммы процента от базовой суммы
        /// </summary>
        /// <param name="sm">Исходная сумма</param>
        /// <param name="pct">Процент</param>
        /// <returns>Сумма процента</returns>
        public static double GetSmByPct(double sm, double pct)
        {
            return Math.Round(pct * sm / 100.00, 2);
        }
        /// <summary>
        /// Полученние суммы доплати за стаж от базовой суммы
        /// </summary>
        /// <param name="baseSm">Основная зарплата</param>
        /// <param name="allwncSm">Сумма надбавок</param>
        /// <param name="pct">Процент</param>
        /// <param name="infoCalc">Результат расчета</param>
        /// <returns>Полученние суммы доплати за стаж</returns>
        public static double GetExpSmByPct(double baseSm, double allwncSm, double pct, ref StringBuilder infoCalc)
        {
            infoCalc.Clear();
            infoCalc.AppendLine("ПОЧАТКОВІ ДАНІ");
            infoCalc.AppendFormat("  Основна зарплата: {0} грн.\n", baseSm);
            infoCalc.AppendFormat("  Cума доплат: {0} грн.\n", allwncSm);
            infoCalc.AppendFormat("  Відсоток доплати за стаж: {0}%\n", pct);
            infoCalc.AppendLine("РОЗРАХУНОК");

            double resultSm = Math.Round((baseSm + allwncSm) * pct / 100.00, 2);
            infoCalc.AppendFormat("  Cума доплат за стаж: {0} грн.\n", resultSm);
            infoCalc.AppendFormat("    - ({0} + {1}) * {2}/100\n", baseSm, allwncSm, pct);
            return resultSm;
        }
        /// <summary>
        /// Получение итоговой суммы зарплаты
        /// </summary>
        /// <param name="ktu">КТУ</param>
        /// <param name="baseSm">Основная зарплата</param>
        /// <param name="allwncTotalSm">Общая сумма доплат</param>
        /// <param name="allwncTotalPct">Общая процент доплат</param>
        /// <param name="infoCalc">Результат расчета</param>
        /// <returns>Итоговая сумма</returns>
        public static double GetResultSmSalary(double ktu, double baseSm, double allwncTotalSm, double allwncTotalPct, ref StringBuilder infoCalc)
        {
            infoCalc.Clear();
            infoCalc.AppendLine("ПОЧАТКОВІ ДАНІ");
            infoCalc.AppendFormat("  Основна зарплата: {0} грн.\n", baseSm);
            infoCalc.AppendFormat("  Загальна сума доплат: {0} грн.\n", allwncTotalSm);
            infoCalc.AppendFormat("  Загальний відсоток доплат: {0} %\n", allwncTotalPct);
            infoCalc.AppendFormat("  КТУ: {0}\n", ktu);
            infoCalc.AppendLine("РОЗРАХУНОК");
            double resultSm = 0;
            if (ktu == 1 || ktu == 0)
            {
                resultSm = baseSm + allwncTotalSm;
                infoCalc.AppendFormat("  Всього: {0} грн.\n", resultSm);
                infoCalc.AppendFormat("    - {0} + {1}\n", baseSm, allwncTotalSm);
                return resultSm;
            }
            if (ktu > 1)
            {
                resultSm = Math.Round((baseSm + allwncTotalSm) * ktu, 2);
                infoCalc.AppendFormat("  Всього: {0} грн.\n", resultSm);
                infoCalc.AppendFormat("    - ({0} + {1}) * {2}\n", baseSm, allwncTotalSm, ktu);
                return resultSm;
            }
            if (ktu < 1)
            {
                double ktuPct = (1 - ktu) * 100.00;
                infoCalc.AppendFormat("  Відсоток КТУ: {0}%\n", ktuPct);
                infoCalc.AppendFormat("    - (1 - {0})* 100\n", ktu);
                if(ktuPct < allwncTotalPct)
                {
                    double ktuSm = Math.Round((allwncTotalSm * ktuPct / allwncTotalPct), 2);
                    resultSm = baseSm + allwncTotalSm - ktuSm;
                    infoCalc.AppendFormat("  {0} < {1}\n", ktuPct, allwncTotalPct);
                    infoCalc.AppendFormat("  Проміжна сума: {0} грн.\n", ktuSm);
                    infoCalc.AppendFormat("    - ({0} * {1})/{2}\n", allwncTotalSm, ktuPct, allwncTotalPct);
                    infoCalc.AppendFormat("  Всього: {0} грн.\n", resultSm);
                    infoCalc.AppendFormat("    - {0} + {1} - {2}\n", baseSm, allwncTotalSm, ktuSm);
                    return resultSm;
                }
                else
                {
                    resultSm = baseSm;
                    infoCalc.AppendFormat("  {0} >= {1}\n", ktuPct, allwncTotalPct);
                    infoCalc.AppendFormat("  Всього: {0} грн.\n", resultSm);
                    return resultSm;
                }
            }
            return 0;
        }
    }
}
