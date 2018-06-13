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
    public partial class fmVocation : Form
    {
        private PersCardRepository _repoPersCard = new PersCardRepository(SetupProgram.Connection);
        private VocationRepository _repoVocation = new VocationRepository(SetupProgram.Connection);
        private RefDepRepository _repoDep = new RefDepRepository(SetupProgram.Connection);

        private List<RefDep> _refDeps = new List<RefDep>(); //кэш
        private List<Vocation> _vocations = new List<Vocation>(); //кэш
        private List<PersCard> _persCards = new List<PersCard>(); //кэш
        //Параметры запроса
        private int _depId = 0;
        private DateTime _datBeg = DateTime.MinValue;
        private DateTime _datEnd = DateTime.MinValue;

        //Вставка строки
        private void InsertRecord()
        {
            fmVocationEdit fmEdit = new fmVocationEdit(EnumFormMode.Insert, "Створення відпускних");
            Vocation setVocation = new Vocation();
            int month = SalaryHelper.GetMonthByIndex(cmbCalendar.SelectedIndex, true);

            if (month == 0)
            {
                setVocation.Vocation_Date = DateTime.MinValue.AddYears(DateTime.Today.Year - 1).AddMonths(DateTime.Today.Month - 1);
            }
            else
            {
                int year = SalaryHelper.GetYearByIndex(DateTime.Today.Year - SetupProgram.YearSalary, cmbCalendar.SelectedIndex, true);
                setVocation.Vocation_Date = DateTime.MinValue.AddYears(year - 1).AddMonths(month - 1);
            }

            if (MenuItemDeps.CheckState == CheckState.Checked)
            {
                v_Dep dep = dgvDep.CurrentRow.DataBoundItem as v_Dep;
                if (dep != null)
                    setVocation.Vocation_RefDep_Id = dep.Id;
            }
            fmEdit.SetData(setVocation);
            if (fmEdit.ShowDialog() == DialogResult.OK)
            {
                string error;
                Vocation getVocation = fmEdit.GetData();
                if (!_repoVocation.AddVocation(getVocation, out error))
                {
                    MessageBox.Show("Помилка додавання відпускного.\nТехнічна інформація: " + error, "Помилка");
                    return;
                }
                RefreshTableVocation(_depId, _datBeg, _datEnd);
            }
        }
        //Обновление строки
        private void UpdateRecord()
        {
            if (dgvVocation.CurrentRow == null) return;
            v_Vocation vvocation = dgvVocation.CurrentRow.DataBoundItem as v_Vocation;
            if (vvocation == null)
            {
                MessageBox.Show("Не знайдений рядок відпускних для оновлення", "Помилка");
                return;
            }
            fmVocationEdit fmEdit = new fmVocationEdit(EnumFormMode.Edit, "Зміна відпускного");
            fmEdit.SetData(vvocation);
            if (fmEdit.ShowDialog() == DialogResult.OK)
            {
                Vocation vocation = fmEdit.GetData();
                string error;
                if (!_repoVocation.ModifyVocation(vocation, out error))
                {
                    MessageBox.Show("Помилка оновлення відпускного.\nТехнічна інформація: " + error, "Помилка");
                    return;
                }
                RefreshTableVocation(_depId, _datBeg, _datEnd);
            }
        }
        //Физическое удаление строки
        private void DeleteRecord()
        {
            List<v_Vocation> checkedVocations = dgvVocation.GetCheckedRecords<v_Vocation>();
            if (checkedVocations.Count > 0)
            {
                if (MessageBox.Show("Ви впевнені, що бажаєте видалити обрані рядки?", "Видалення", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Coffee.Init("Видалення відпускного");
                    foreach (v_Vocation vocation in checkedVocations)
                    {
                        string error;
                        if (!_repoVocation.DeleteVocation(vocation.Vocation_Id, out error))
                        {
                            MessageBox.Show("Помилка видалення.\nТехнічна інформація: " + error, "Помилка");
                            break;
                        }

                    }
                    Coffee.Term();
                    RefreshTableVocation(_depId, _datBeg, _datEnd);
                }
            }
            else
            {
                if (dgvVocation.CurrentRow == null) return;
                if (MessageBox.Show("Ви впевнені, що бажаєте видалити рядок?", "Видалення", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;
                v_Vocation vocation = dgvVocation.CurrentRow.DataBoundItem as v_Vocation;
                if (vocation == null)
                {
                    MessageBox.Show("Не знайдений рядок для видалення", "Помилка");
                    return;
                }
                string error;
                if (!_repoVocation.DeleteVocation(vocation.Vocation_Id, out error))
                {
                    MessageBox.Show("Помилка видалення.\nТехнічна інформація: " + error, "Помилка");
                    return;
                }
                RefreshTableVocation(_depId, _datBeg, _datEnd);
            }
        }
        //Перезачитать данные таблицы
        private void RefreshTableVocation(int depId, DateTime dtBeg, DateTime dtEnd)
        {
            dgvVocation.StorePosition();
            LoadDataToGridVocation(0, depId, dtBeg, dtEnd);
            dgvVocation.RestPosition();
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
            List<string> monthNames = SalaryHelper.GetMonthNames(DateTime.Today.Year - SetupProgram.YearSalary, true);
            cmbCalendar.DataSource = monthNames;
        }
        //Инициализация грида подразделений
        private void InitGridDep()
        {
            dgvDep.BaseGrigStyle();
        }
        //Инициализация грида отпускные
        private void InitGridVocation()
        {
            dgvVocation.BaseGrigStyle();
            dgvVocation.AddBirdColumn();
            dgvVocation.AddRefreshMenu(RefreshMenu);
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

        //Загрузка данных в грид "Отпускные"
        private bool LoadDataToGridVocation(int vocationId, int depId, DateTime datBeg, DateTime datEnd)
        {
            string error;
            _vocations = _repoVocation.GetVocationsByParams(vocationId, depId, datBeg, datEnd, out error);
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
            List<v_Vocation> vVocations = GetViewVocations(_vocations, _persCards, _refDeps);
            source.DataSource = vVocations;
            dgvVocation.DataSource = source;
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
        private List<v_Vocation> GetViewVocations(List<Vocation> vocations, List<PersCard> cards, List<RefDep> deps)
        {
            List<v_Vocation> res = (from vocation in vocations
                                    join card in cards on vocation.Vocation_PersCard_Id equals card.PersCard_Id
                                    join dep in deps on vocation.Vocation_RefDep_Id equals dep.RefDep_Id
                                  select new v_Vocation
                                  {
                                      Vocation_Id = vocation.Vocation_Id,
                                      Vocation_PersCard_Id = vocation.Vocation_PersCard_Id,
                                      Vocation_RefDep_Id = vocation.Vocation_RefDep_Id,
                                      Vocation_Date = vocation.Vocation_Date,
                                      Vocation_Days = vocation.Vocation_Days,
                                      Vocation_Sm = vocation.Vocation_Sm,
                                      Vocation_PayDate = vocation.Vocation_PayDate,
                                      Vocation_ResSm = vocation.Vocation_ResSm,
                                      PersCard_FullName = card.PersCard_LName + " " + card.PersCard_FName.Substring(0, 1) + ". " + card.PersCard_MName.Substring(0, 1) + ".",
                                      PersCard_TIN = card.PersCard_TIN,
                                      RefDep_Name = dep.RefDep_Nm
                                  }).ToList();
            return res;
        }
        public fmVocation(Form owner)
        {
            InitializeComponent();
            this.SingleFormMode(owner);
        }

        private void fmVocation_Load(object sender, EventArgs e)
        {
            //Отпишемся от событий чтобы предотвратить "лишние" срабатывания при наcтройке
            cmbCalendar.SelectedIndexChanged -= new EventHandler(cmbCalendar_SelectedIndexChanged);
            dgvDep.SelectionChanged -= new EventHandler(dgvDep_SelectionChanged);

            InitCmbCalendar();
            cmbCalendar.SelectedIndex = cmbCalendar.Items.Count - 1;
            InitGridDep();
            if (!LoadDataToGridDep())
                return;

            InitGridVocation();

            if (MenuItemDeps.CheckState == CheckState.Checked)
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
            if (!LoadDataToGridVocation(0, _depId, _datBeg, _datEnd))
                return;

            //Восстновим подписку на события
            cmbCalendar.SelectedIndexChanged += new EventHandler(cmbCalendar_SelectedIndexChanged);
            dgvDep.SelectionChanged += new EventHandler(dgvDep_SelectionChanged);
        }
        private void RefreshMenu()
        {
            bool isEnableMenu = dgvVocation.CurrentRow != null && dgvVocation.Focused ? true : false;
            MenuItemCreate.Enabled = true && dgvVocation.Focused;
            MenuItemEdit.Enabled = isEnableMenu;
            MenuItemDelete.Enabled = isEnableMenu;
        }

        private void dgvDep_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }

        private void dgvVocation_KeyDown(object sender, KeyEventArgs e)
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
            LoadDataToGridVocation(0, _depId, _datBeg, _datEnd);
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
            LoadDataToGridVocation(0, _depId, _datBeg, _datEnd);
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
            LoadDataToGridVocation(0, _depId, _datBeg, _datEnd);
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
            if (dgvDep.Focused)
            {
                RefreshTableDep();
                RefreshTableVocation(_depId, _datBeg, _datEnd);
            }
            if (dgvVocation.Focused)
            {
                RefreshTableVocation(_depId, _datBeg, _datEnd);
            }
        }

        private void MenuItemExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        //--------------------------------------------------------------
    }
}
