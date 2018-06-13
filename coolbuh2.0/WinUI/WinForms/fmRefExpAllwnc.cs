using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinUI.Helper;
using Entities;
using DAL;
using BLL;
using WinFormExtensions;
using EnumType;

namespace WinUI.WinForms
{
    public partial class fmRefExpAllwnc : Form
    {
        private List<RefExpAllwnc> _refExpAllwncs = null; //Кеширование
        private List<v_RefExpAllwnc> _vRefExpAllwncs = null; //Кеширование
        private List<RefDep> _refDeps = null; //Кеширование

        private RefExpAllwncRepository _repository = new RefExpAllwncRepository(SetupProgram.Connection);
        private RefDepRepository _refDepRepo = new RefDepRepository(SetupProgram.Connection);

        private List<v_RefExpAllwnc> GetViewAllowance(List<RefExpAllwnc> Allowance, List<RefDep> refDeps)
        {
            List<v_RefExpAllwnc> v_allwncs = new List<v_RefExpAllwnc>();
            foreach (RefExpAllwnc allwnc in Allowance)
            {
                RefDep refDep = refDeps.FirstOrDefault(s => s.RefDep_Id == allwnc.RefExpAllwncMech_RefDep_Id);
                v_RefExpAllwnc v_allwnc = new v_RefExpAllwnc();
                v_allwnc.RefExpAllwnc_Id = allwnc.RefExpAllwnc_Id;
                v_allwnc.RefExpAllwnc_Cd = allwnc.RefExpAllwnc_Cd;
                v_allwnc.RefExpAllwnc_Nm = allwnc.RefExpAllwnc_Nm;
                v_allwnc.RefExpAllwnc_Year = allwnc.RefExpAllwnc_Year;
                v_allwnc.RefExpAllwnc_Mech = allwnc.RefExpAllwnc_Mech;
                if (refDep != null)
                {
                    v_allwnc.RefExpAllwncMech_RefDep_Id = refDep.RefDep_Id;
                    v_allwnc.RefExpAllwncMech_RefDep_Nm = refDep.RefDep_Nm;
                }
                v_allwnc.RefExpAllwnc_Oth = allwnc.RefExpAllwnc_Oth;
                v_allwnc.RefExpAllwnc_Use = (allwnc.RefExpAllwnc_Flg & (int)EnumExpAllwnc_Flg.ALLWNC_NOTUSE) > 0 ? 0 : 1;
                v_allwncs.Add(v_allwnc);
            }
            return v_allwncs;
        }
        //Вставка строки
        private void InsertRecord()
        {
            fmRefExpAllwncEdit fmEdit = new fmRefExpAllwncEdit(EnumFormMode.Insert, "Створення надбавки");
            if (fmEdit.ShowDialog() == DialogResult.OK)
            {
                string error;
                RefExpAllwnc expAllwnc = fmEdit.GetData();

                if (!_repository.AddExpAllwnc(expAllwnc, out error))
                {
                    MessageBox.Show("Помилка додавання картки.\nТехнічна інформація: " + error, "Помилка");
                    return;
                }
                RefreshTable();
            }
        }
        //Обновление строки
        private void UpdateRecord()
        {
            if (dgvRefExpAllwnc.CurrentRow == null) return;
            string error;
            v_RefExpAllwnc v_expAllwnc = dgvRefExpAllwnc.CurrentRow.DataBoundItem as v_RefExpAllwnc;
            if (v_expAllwnc == null)
            {
                MessageBox.Show("Не знайдена надбавка для оновлення", "Помилка");
                return;
            }

            fmRefExpAllwncEdit fmEdit = new fmRefExpAllwncEdit(EnumFormMode.Edit, "Зміна надбавки");
            fmEdit.SetData(v_expAllwnc);
            if (fmEdit.ShowDialog() == DialogResult.OK)
            {
                RefExpAllwnc expAllwnc = fmEdit.GetData();
                if (!_repository.ModifyExpAllwnc(expAllwnc, out error))
                {
                    MessageBox.Show("Помилка оновлення надбавки.\nТехнічна інформація: " + error, "Помилка");
                    return;
                }
                RefreshTable();
            }
        }
        //Физическое удаление строки
        private void DeleteRecord()
        {
            if (dgvRefExpAllwnc.CurrentRow == null) return;
            if (MessageBox.Show("Ви впевнені, що бажаєте видалити надбавку?", "Видалення", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            v_RefExpAllwnc v_expAllwnc = dgvRefExpAllwnc.CurrentRow.DataBoundItem as v_RefExpAllwnc;
            if (v_expAllwnc == null)
            {
                MessageBox.Show("Не знайдена надбавка для оновлення", "Помилка");
                return;
            }
            string error;
            if (!_repository.DeleteExpAllwnc(v_expAllwnc.RefExpAllwnc_Id, out error))
            {
                MessageBox.Show("Помилка видалення надбавки.\nТехнічна інформація: " + error, "Помилка");
                return;
            }
            RefreshTable();
        }
        //Перезачитать данные таблицы
        private void RefreshTable()
        {
            dgvRefExpAllwnc.StorePosition();
            string error;
            _refExpAllwncs = _repository.GetAllExpAllwnc(out error);
            if (error != string.Empty)
            {
                MessageBox.Show("Помилка оновлення таблиці.\nТехнічна інформація: " + error, "Помилка");
                return;
            }
            _refDeps = _refDepRepo.GetAllDeps(out error);
            if (error != string.Empty)
            {
                MessageBox.Show("Помилка оновлення таблиці.\nТехнічна інформація: " + error, "Помилка");
                return;
            }
            _vRefExpAllwncs = GetViewAllowance(_refExpAllwncs, _refDeps);
            dgvRefExpAllwnc.DataSource = _vRefExpAllwncs;
            dgvRefExpAllwnc.RestPosition();
        }
        //Инициализация грида
        private void InitGrid()
        {
            dgvRefExpAllwnc.BaseGrigStyle();
            dgvRefExpAllwnc.AddRefreshMenu(RefreshMenu);
            dgvRefExpAllwnc.AddSortGrid(SortGrid);
            string error;
            _refExpAllwncs = _repository.GetAllExpAllwnc(out error);
            if (error != string.Empty)
            {
                MessageBox.Show("Помилка ініціалізації.\nТехнічна інформація: " + error, "Помилка");
                return;
            }
            _refDeps = _refDepRepo.GetAllDeps(out error);
            if (error != string.Empty)
            {
                MessageBox.Show("Помилка ініціалізації.\nТехнічна інформація: " + error, "Помилка");
                return;
            }

            _vRefExpAllwncs = GetViewAllowance(_refExpAllwncs, _refDeps);
            dgvRefExpAllwnc.DataSource = _vRefExpAllwncs;            
        }
        //Обновить меню
        private void RefreshMenu()
        {
            bool isEnableMenu = dgvRefExpAllwnc.CurrentRow == null ? false : true;
            MenuItemCreate.Enabled = true;
            MenuItemEdit.Enabled = isEnableMenu;
            MenuItemDelete.Enabled = isEnableMenu;
        }
        //Функция сортировки грида
        private void SortGrid(DataGridViewCellMouseEventArgs e)
        {
            string strColumnName = dgvRefExpAllwnc.Columns[e.ColumnIndex].Name;
            SortOrder strSortOrder = dgvRefExpAllwnc.getSortOrder(e.ColumnIndex);

            if (strSortOrder == SortOrder.Ascending)
            {
                _vRefExpAllwncs = _vRefExpAllwncs.OrderBy(x => typeof(v_RefExpAllwnc).GetProperty(strColumnName).GetValue(x, null)).ToList();
            }
            else
            if (strSortOrder == SortOrder.Descending)
            {
                _vRefExpAllwncs = _vRefExpAllwncs.OrderByDescending(x => typeof(v_RefExpAllwnc).GetProperty(strColumnName).GetValue(x, null)).ToList();
            }
            if (strSortOrder == SortOrder.None)
            {
                _vRefExpAllwncs = _vRefExpAllwncs.OrderBy(x => typeof(v_RefExpAllwnc).GetProperty("RefExpAllwnc_Id").GetValue(x, null)).ToList();
            }
            dgvRefExpAllwnc.DataSource = _vRefExpAllwncs;
            dgvRefExpAllwnc.Columns[e.ColumnIndex].HeaderCell.SortGlyphDirection = strSortOrder;
        }

        public fmRefExpAllwnc(Form owner)
        {
            this.SingleFormMode(owner);
            InitializeComponent();
        }

        private void fmRefExpAllwnc_Load(object sender, EventArgs e)
        {
            InitGrid();
        }

        private void fmRefExpAllwnc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }

        private void dgvRefExpAllwnc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }

        //--------------------События меню----------------------------
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
            RefreshTable();
        }

        private void MenuItemExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        //----------------------------------------------------------
    }
}
