﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using Entities;
using BLL;
using WinUI.Helper;
using WinFormExtensions;
using WinUI.WinForms;
using EnumType;

namespace WinUI.WinForms
{
    public partial class fmSalary : Form
    {
        private PersCardRepository _repoPersCard = new PersCardRepository(SetupProgram.Connection);
        private SalaryRepository _repoSalary = new SalaryRepository(SetupProgram.Connection);
        private RefDepRepository _repoDep = new RefDepRepository(SetupProgram.Connection);

        private List<RefDep> _refDeps = new List<RefDep>(); //кэш
        private List<Salary> _salaries = new List<Salary>(); //кэш
        private List<PersCard> _persCards = new List<PersCard>(); //кэш
        //Параметры запроса
        private int _depId = 0;
        private DateTime _datBeg = DateTime.MinValue;
        private DateTime _datEnd = DateTime.MinValue;

        //Вставка строки
        private void InsertRecord()
        {
            fmSalaryAdd fmEdit = new fmSalaryAdd(EnumFormMode.Insert, "Створення зарлати");
            Salary sal = new Salary();
            int month = SalaryHelper.GetMonthByIndex(cmbCalendar.SelectedIndex, true);

            if (month == 0)
            {
                sal.Salary_Date = DateTime.MinValue.AddYears(DateTime.Today.Year - 1).AddMonths(DateTime.Today.Month - 1);
            }
            else
            {
                int year = SalaryHelper.GetYearByIndex(DateTime.Today.Year - SetupProgram.YearSalary, cmbCalendar.SelectedIndex, true);
                sal.Salary_Date = DateTime.MinValue.AddYears(year - 1).AddMonths(month - 1);
            }

            if(MenuItemDeps.CheckState == CheckState.Checked)
            {
                v_Dep dep = dgvDep.CurrentRow.DataBoundItem as v_Dep;
                if (dep != null)
                    sal.Salary_RefDep_Id = dep.Id;
            }
            fmEdit.SetData(sal);
            if (fmEdit.ShowDialog() == DialogResult.OK)
            {
                string error;
                Salary salary = fmEdit.GetData();
                if (!_repoSalary.AddSalary(salary, out error))
                {
                    MessageBox.Show("Помилка додавання зарлати.\nТехнічна інформація: " + error, "Помилка");
                    return;
                }

                RefreshTableSalary(_depId, _datBeg, _datEnd);
            }
        }
        //Обновление строки
        private void UpdateRecord()
        {
            if (dgvSalary.CurrentRow == null) return;
            v_Salary vsalary = dgvSalary.CurrentRow.DataBoundItem as v_Salary;
            if (vsalary == null)
            {
                MessageBox.Show("Не знайдений рядок зарплати для оновлення", "Помилка");
                return;
            }
            fmSalaryAdd fmEdit = new fmSalaryAdd(EnumFormMode.Edit, "Зміна зарплати");
            fmEdit.SetData(vsalary);
            if (fmEdit.ShowDialog() == DialogResult.OK)
            {
                Salary salary = fmEdit.GetData();
                string error;
                if (!_repoSalary.ModifySalary(salary, out error))
                {
                    MessageBox.Show("Помилка оновлення зарплати.\nТехнічна інформація: " + error, "Помилка");
                    return;
                }
                RefreshTableSalary(_depId, _datBeg, _datEnd);
            }
        }
        //Физическое удаление строки
        private void DeleteRecord()
        {
            List<v_Salary> checkedSalaries = dgvSalary.GetCheckedRecords<v_Salary>();
            if (checkedSalaries.Count > 0)
            {
                if (MessageBox.Show("Ви впевнені, що бажаєте видалити обрані рядки зарплати?", "Видалення", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Coffee.Init("Видалення зарплати");
                    foreach (v_Salary salary in checkedSalaries)
                    {
                        string error;
                        if (!_repoSalary.DeleteSalary(salary.Salary_Id, out error))
                        {
                            MessageBox.Show("Помилка видалення.\nТехнічна інформація: " + error, "Помилка");
                            break;
                        }

                    }
                    Coffee.Term();
                    RefreshTableSalary(_depId, _datBeg, _datEnd);
                }
            }
            else
            {
                if (dgvSalary.CurrentRow == null) return;
                if (MessageBox.Show("Ви впевнені, що бажаєте видалити рядок зарплати?", "Видалення", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;
                v_Salary salary = dgvSalary.CurrentRow.DataBoundItem as v_Salary;
                if (salary == null)
                {
                    MessageBox.Show("Не знайдений рядок для видалення", "Помилка");
                    return;
                }
                string error;
                if (!_repoSalary.DeleteSalary(salary.Salary_Id, out error))
                {
                    MessageBox.Show("Помилка видалення.\nТехнічна інформація: " + error, "Помилка");
                    return;
                }
                RefreshTableSalary(_depId, _datBeg, _datEnd);
            }
        }
        //Перезачитать данные таблицы
        private void RefreshTableSalary(int depId, DateTime dtBeg, DateTime dtEnd)
        {
            dgvSalary.StorePosition();
            LoadDataToGridSalary(0, depId, dtBeg, dtEnd);
            dgvSalary.RestPosition();
        }
        //Перезачитать данные таблицы
        private void RefreshTableDep()
        {
            //Отпишемся от событий чтобы предотвратить "лишние" срабатывания
            dgvDep.SelectionChanged -= new EventHandler(dgvDep_SelectionChanged);

            dgvDep.StorePosition();
            LoadDataToGridDep();
            dgvDep.RestPosition();

            dgvDep.SelectionChanged += new EventHandler(dgvDep_SelectionChanged);

        }
        //Получение периода на основании выбранного значения из комбика
        private bool GetDateBySelectCmbCalendar(ref DateTime datBeg, ref DateTime dateEnd)
        {
            datBeg = DateTime.MinValue;
            dateEnd = DateTime.MinValue;

            int year = SalaryHelper.GetYearByIndex(DateTime.Today.Year - SetupProgram.YearSalary, cmbCalendar.SelectedIndex, true);
            if (year == 0)
                return false;

            int month = SalaryHelper.GetMonthByIndex(cmbCalendar.SelectedIndex, true);
            if (month == 0)
            {
                datBeg = datBeg.AddYears(year - 1);
                dateEnd = dateEnd.AddYears(year - 1).AddMonths(12 - 1);
            }
            else
            {
                datBeg = datBeg.AddYears(year - 1).AddMonths(month - 1);
                dateEnd = dateEnd.AddYears(year - 1).AddMonths(month - 1);
            }
            return true;
        }
        //Инициализация календаря
        private void InitCmbCalendar()
        {
            List<string> monthNames = SalaryHelper.GetMonthNames(DateTime.Today.Year-SetupProgram.YearSalary, true);
            cmbCalendar.DataSource = monthNames;
        }
        //Инициализация грида подразделений
        private void InitGridDep()
        {
            dgvDep.BaseGrigStyle();
        }
        //Инициализация грида зарплаты
        private void InitGridSalary()
        {
            dgvSalary.BaseGrigStyle();
            dgvSalary.AddBirdColumn();
            dgvSalary.AddRefreshMenu(RefreshMenu);
        }
        //Загрузка данных в грид "Подразделения"
        private bool LoadDataToGridDep()
        {
            string error;
            _refDeps = _repoDep.GetAllDeps(out error);
            if (error != string.Empty)
            {
                MessageBox.Show("Помилка завантаження підрозділів.\nТехнічна інформація: " + error, "Помилка");
                return false;
            }
            BindingSource source = new BindingSource();
            source.DataSource = GetViewDeps(_refDeps);
            dgvDep.DataSource = source;
            return true;
        }
        //Загрузка данных в грид "Зарплата"
        private bool LoadDataToGridSalary(int salaryId, int depId, DateTime datBeg, DateTime datEnd)
        {
            string error;
            _salaries = _repoSalary.GetSalariesByParams(salaryId, depId, datBeg, datEnd, out error);
            if (error != string.Empty)
            {
                MessageBox.Show("Помилка ініціалізації зарплати.\nТехнічна інформація: " + error, "Помилка");
                return false;
            }
            _persCards = _repoPersCard.GetAllCards(out error);
            if (error != string.Empty)
            {
                MessageBox.Show("Помилка ініціалізації картки обліку.\nТехнічна інформація: " + error, "Помилка");
                return false;
            }
            if (_refDeps.Count == 0)
            {
                _refDeps = _repoDep.GetAllDeps(out error);
                if (error != string.Empty)
                {
                    MessageBox.Show("Помилка завантаження підрозділів.\nТехнічна інформація: " + error, "Помилка");
                    return false;
                }
            }

            BindingSource source = new BindingSource();
            List<v_Salary> vSalaries = GetViewSalaries(_salaries, _persCards, _refDeps);
            source.DataSource = vSalaries;
            dgvSalary.DataSource = source;
            return true;
        }
        //Получить view "Подразделения"
        private List<v_Dep> GetViewDeps(List<RefDep> deps)
        {
            return deps.Select(dep => new v_Dep
            {
                Id = dep.RefDep_Id,
                Name = dep.RefDep_Cd + "." + dep.RefDep_Nm
            }).ToList();
        }
        //Получить view "Зарплата"
        private List<v_Salary> GetViewSalaries(List<Salary> salaries, List<PersCard> cards, List<RefDep> deps)
        {
            List<v_Salary> res =  (from salary in salaries
                                  join card in cards on salary.Salary_PersCard_Id equals card.PersCard_Id
                                  join dep in deps on salary.Salary_RefDep_Id equals dep.RefDep_Id
                                select new v_Salary
                                {
                                    Salary_Id = salary.Salary_Id,
                                    Salary_Date = salary.Salary_Date,
                                    Salary_PersCard_Id = salary.Salary_PersCard_Id,
                                    Salary_RefDep_Id = salary.Salary_RefDep_Id,
                                    Salary_Days = salary.Salary_Days,
                                    Salary_Hours = salary.Salary_Hours,
                                    Salary_BaseSm = salary.Salary_BaseSm,
                                    Salary_PensId = salary.Salary_PensId,
                                    Salary_PensSm = salary.Salary_PensSm,
                                    Salary_ExpId = salary.Salary_ExpId,
                                    Salary_ExpSm = salary.Salary_ExpSm,
                                    Salary_GradeId = salary.Salary_GradeId,
                                    Salary_GradeSm = salary.Salary_GradeSm,
                                    Salary_OthId = salary.Salary_OthId,
                                    Salary_OthSm = salary.Salary_OthSm,
                                    Salary_KTU = salary.Salary_KTU,
                                    Salary_KTUSm = salary.Salary_KTUSm,
                                    PersCard_FullName = card.PersCard_LName +" " + card.PersCard_FName.Substring(0,1) + ". " +card.PersCard_MName.Substring(0, 1) + ".",
                                    PersCard_TIN = card.PersCard_TIN,
                                    RefDep_Name = dep.RefDep_Nm,
                                    Salary_ResSm = salary.Salary_ResSm
                                }).ToList();
            return res;
        }

        public fmSalary(Form owner)
        {
            InitializeComponent();
            this.SingleFormMode(owner);
        }

        private void fmSalary_Load(object sender, EventArgs e)
        {
            //Отпишемся от событий чтобы предотвратить "лишние" срабатывания при наcтройке
            cmbCalendar.SelectedIndexChanged -= new EventHandler(cmbCalendar_SelectedIndexChanged);
            dgvDep.SelectionChanged -= new EventHandler(dgvDep_SelectionChanged);

            InitCmbCalendar();
            cmbCalendar.SelectedIndex = cmbCalendar.Items.Count - 1;
            InitGridDep();
            if (!LoadDataToGridDep())
                return;

            InitGridSalary();

            if(MenuItemDeps.CheckState == CheckState.Checked)
            {
                dgvDep.CurrentCell = dgvDep.Rows[0].Cells[0];
                v_Dep dep = dgvDep.CurrentRow.DataBoundItem as v_Dep;
                if (dep == null)
                {
                    MessageBox.Show("Помилка вибору підрозділу.\nТехнічна інформація: dep == null", "Помилка");
                    return;
                }
                _depId = dep.Id;
            }
            else
            {
                _depId = 0;
            }
            GetDateBySelectCmbCalendar(ref _datBeg, ref _datEnd);
            if (_datBeg == DateTime.MinValue || _datEnd == DateTime.MinValue)
            {
                MessageBox.Show("Помилка вибору підрозділу.\nТехнічна інформація: _datBeg == DateTime.MinValue || _dateEnd == DateTime.MinValue", "Помилка");
                return;
            }
            if (!LoadDataToGridSalary(0, _depId, _datBeg, _datEnd))
                return;

            //Восстновим подписку на события
            cmbCalendar.SelectedIndexChanged += new EventHandler(cmbCalendar_SelectedIndexChanged);
            dgvDep.SelectionChanged += new EventHandler(dgvDep_SelectionChanged);
        }
        //Обновить меню
        private void RefreshMenu()
        {
            bool isEnableMenu = dgvSalary.CurrentRow != null && dgvSalary.Focused ? true : false;
            MenuItemCreate.Enabled = true && dgvSalary.Focused;
            MenuItemEdit.Enabled = isEnableMenu;
            MenuItemDelete.Enabled = isEnableMenu;
        }

        private void fmSalary_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }

        private void dgvDep_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }

        private void dgvSalary_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }

        private void cmbCalendar_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetDateBySelectCmbCalendar(ref _datBeg, ref _datEnd);
            if (_datBeg == DateTime.MinValue || _datEnd == DateTime.MinValue)
            {
                MessageBox.Show("Помилка вибору підрозділу.\nТехнічна інформація: _datBeg == DateTime.MinValue || _dateEnd == DateTime.MinValue", "Помилка");
                return;
            }
            LoadDataToGridSalary(0, _depId, _datBeg, _datEnd);
        }

        private void dgvDep_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDep.CurrentRow == null)
                return;

            if (_datBeg == DateTime.MinValue || _datEnd == DateTime.MinValue)
            {
                MessageBox.Show("Помилка вибору підрозділу.\nТехнічна інформація: _datBeg == DateTime.MinValue || _dateEnd == DateTime.MinValue", "Помилка");
                return;
            }

            v_Dep dep = dgvDep.CurrentRow.DataBoundItem as v_Dep;

            if (dep == null)
            {
                MessageBox.Show("Помилка вибору підрозділу.\nТехнічна інформація: dep == null", "Помилка");
                return;
            }

            _depId = dep.Id;
            LoadDataToGridSalary(0, _depId, _datBeg, _datEnd);
        }
        //--------------------События меню----------------------------
        private void MenuItemDeps_Click(object sender, EventArgs e)
        {
            MenuItemDeps.CheckState = MenuItemDeps.CheckState == CheckState.Checked ?
                CheckState.Unchecked : CheckState.Checked;
            if (MenuItemDeps.CheckState == CheckState.Checked)
            {
                left_pnl.Visible = true;
                if (dgvDep.CurrentRow == null)
                {
                    dgvDep.CurrentCell = dgvDep.Rows[0].Cells[0];
                }
                v_Dep dep = dgvDep.CurrentRow.DataBoundItem as v_Dep;

                if (dep == null)
                {
                    MessageBox.Show("Помилка вибору підрозділу.\nТехнічна інформація: dep == null", "Помилка");
                    return;
                }
                _depId = dep.Id;

            }
            else
            {
                _depId = 0;
                left_pnl.Visible = false;
            }
            LoadDataToGridSalary(0, _depId, _datBeg, _datEnd);
        }

        private void MenuItemCreate_Click(object sender, EventArgs e)
        {
            InsertRecord();
        }

        private void MenuItemEdit_Click(object sender, EventArgs e)
        {
            UpdateRecord();
        }

        private void MenuItemDelete_Click(object sender, EventArgs e)
        {
            DeleteRecord();
        }

        private void MenuItemRefresh_Click(object sender, EventArgs e)
        {
            if(dgvDep.Focused)
            {
                RefreshTableDep();
                RefreshTableSalary(_depId, _datBeg, _datEnd);
            }
            if (dgvSalary.Focused)
            {
                RefreshTableSalary(_depId, _datBeg, _datEnd);
            }
        }

        private void MenuItemExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        //--------------------------------------------------------------
    }
}
