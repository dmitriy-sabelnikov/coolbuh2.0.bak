using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
using DAL;
using BLL;
using WinUI.Helper;
using WinFormExtensions;
using EnumType;
using System.IO;

namespace WinUI.WinForms
{
    public partial class fmRefGradeAllwnc : Form
    {
        private List<RefGradeAllwnc> _refGradeAllwncs = null; //Кеширование
        private List<RefDep> _refDeps = null; //Кеширование
        private List<v_RefGradeAllwnc> _vRefGradeAllwncs = null; //Кеширование.View

        private RefGradeAllwncRepository _repository = new RefGradeAllwncRepository(SetupProgram.Connection);
        private RefDepRepository _refDepRepo = new RefDepRepository(SetupProgram.Connection);

        private List<v_RefGradeAllwnc> GetViewAllowance(List<RefGradeAllwnc> Allowance, List<RefDep> refDeps)
        {
            List<v_RefGradeAllwnc> v_allwncs = new List<v_RefGradeAllwnc>();
            foreach(RefGradeAllwnc allwnc in Allowance)
            {
                RefDep refDep = refDeps.FirstOrDefault(s => s.RefDep_Id == allwnc.RefGradeAllwnc_RefDep_Id);
                v_RefGradeAllwnc v_allwnc = new v_RefGradeAllwnc();
                v_allwnc.RefGradeAllwnc_Id = allwnc.RefGradeAllwnc_Id;
                v_allwnc.RefGradeAllwnc_Cd = allwnc.RefGradeAllwnc_Cd;
                v_allwnc.RefGradeAllwnc_Nm = allwnc.RefGradeAllwnc_Nm;
                v_allwnc.RefGradeAllwnc_Pct = allwnc.RefGradeAllwnc_Pct;
                v_allwnc.RefGradeAllwnc_Grade = allwnc.RefGradeAllwnc_Grade;
                if(refDep != null)
                {
                    v_allwnc.RefGradeAllwnc_RefDep_Id = allwnc.RefGradeAllwnc_RefDep_Id;
                    v_allwnc.RefGradeAllwnc_RefDep_Nm = refDep.RefDep_Nm;
                }
                v_allwnc.RefGradeAllwnc_Use = (allwnc.RefGradeAllwnc_Flg & (int)EnumGradeAllwnc_Flg.ALLWNC_NOTUSE) > 0 ? 0 : 1; 
                v_allwncs.Add(v_allwnc);
            }
            return v_allwncs;
        }

        //Вставка строки
        private void InsertRecord()
        {
            fmRefGradeAllwncEdit fmEdit = new fmRefGradeAllwncEdit(EnumFormMode.Insert, "Створення доплати");
            if (fmEdit.ShowDialog() == DialogResult.OK)
            {
                string error;
                RefGradeAllwnc gradeAllwncs = fmEdit.GetData();
            
                if (!_repository.AddGradeAllwnc(gradeAllwncs, out error))
                {
                    MessageBox.Show("Помилка додавання доплати.\nТехнічна інформація: " + error, "Помилка");
                    return;
                }
                RefreshTable();
            }
        }
        //Обновление строки
        private void UpdateRecord()
        {
            if (dgvGradeAllwnc.CurrentRow == null) return;
            v_RefGradeAllwnc v_allowance = dgvGradeAllwnc.CurrentRow.DataBoundItem as v_RefGradeAllwnc;
            if (v_allowance == null)
            {
                MessageBox.Show("Не знайдена доплата для оновлення", "Помилка");
                return;
            }
            fmRefGradeAllwncEdit fmEdit = new fmRefGradeAllwncEdit(EnumFormMode.Edit, "Зміна доплати");
            fmEdit.SetData(_refGradeAllwncs.FirstOrDefault(rec => rec.RefGradeAllwnc_Id == v_allowance.RefGradeAllwnc_Id));
            if (fmEdit.ShowDialog() == DialogResult.OK)
            {
                RefGradeAllwnc allowance = fmEdit.GetData();
                string error;
                if (!_repository.ModifyGradeAllwnc(allowance, out error))
                {
                    MessageBox.Show("Помилка оновлення картки.\nТехнічна інформація: " + error, "Помилка");
                    return;
                }
                RefreshTable();
            }
        }
        //Физическое удаление строки
        private void DeleteRecord()
        {
            if (dgvGradeAllwnc.CurrentRow == null) return;

            if (MessageBox.Show("Ви впевнені, що бажаєте видалити надбавку?", "Видалення", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            v_RefGradeAllwnc allowance = dgvGradeAllwnc.CurrentRow.DataBoundItem as v_RefGradeAllwnc;
            if (allowance == null)
            {
                MessageBox.Show("Не знайдена надбавка для оновлення", "Помилка");
                return;
            }

            string error;
            if (!_repository.DeleteGradeAllwnc(allowance.RefGradeAllwnc_Id, out error))
            {
                MessageBox.Show("Помилка видалення.\nТехнічна інформація: " + error, "Помилка");
                return;
            }
            RefreshTable();
        }
        //Перезачитать данные таблицы
        private void RefreshTable()
        {
            dgvGradeAllwnc.StorePosition();
            string error;
            _refGradeAllwncs = _repository.GetAllGradeAllwnc(out error);
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
            _vRefGradeAllwncs = GetViewAllowance(_refGradeAllwncs, _refDeps);
            dgvGradeAllwnc.DataSource = _vRefGradeAllwncs;
            dgvGradeAllwnc.RestPosition();
        }
        //Инициализация грида
        private void InitGrid()
        {
            dgvGradeAllwnc.BaseGrigStyle();
            dgvGradeAllwnc.AddRefreshMenu(RefreshMenu);
            dgvGradeAllwnc.AddSortGrid(SortGrid);
            string error;
            _refGradeAllwncs = _repository.GetAllGradeAllwnc(out error);
            if (error != string.Empty)
            {
                MessageBox.Show("Помилка ініціалізації.\nТехнічна інформація: " + error, "Помилка");
                return;
            }
            _refDeps = _refDepRepo.GetAllDeps(out error);
            if (error != string.Empty)
            {
                MessageBox.Show("Помилка оновлення таблиці.\nТехнічна інформація: " + error, "Помилка");
                return;
            }
            _vRefGradeAllwncs = GetViewAllowance(_refGradeAllwncs, _refDeps);
            dgvGradeAllwnc.DataSource = _vRefGradeAllwncs;
        }
        //Обновить меню
        private void RefreshMenu()
        {
            bool isEnableMenu = dgvGradeAllwnc.CurrentRow == null ? false : true;
            MenuItemCreate.Enabled = true;
            MenuItemEdit.Enabled = isEnableMenu;
            MenuItemDelete.Enabled = isEnableMenu;
        }
        //Функция сортировки грида
        private void SortGrid(DataGridViewCellMouseEventArgs e)
        {
            string strColumnName = dgvGradeAllwnc.Columns[e.ColumnIndex].Name;
            SortOrder strSortOrder = dgvGradeAllwnc.getSortOrder(e.ColumnIndex);

            if (strSortOrder == SortOrder.Ascending)
            {
                _vRefGradeAllwncs = _vRefGradeAllwncs.OrderBy(x => typeof(v_RefGradeAllwnc).GetProperty(strColumnName).GetValue(x, null)).ToList();
            }
            else
            if (strSortOrder == SortOrder.Descending)
            {
                _vRefGradeAllwncs = _vRefGradeAllwncs.OrderByDescending(x => typeof(v_RefGradeAllwnc).GetProperty(strColumnName).GetValue(x, null)).ToList();
            }
            if (strSortOrder == SortOrder.None)
            {
                _vRefGradeAllwncs = _vRefGradeAllwncs.OrderBy(x => typeof(v_RefGradeAllwnc).GetProperty("RefGradeAllwnc_Id").GetValue(x, null)).ToList();
            }
            dgvGradeAllwnc.DataSource = _vRefGradeAllwncs;
            dgvGradeAllwnc.Columns[e.ColumnIndex].HeaderCell.SortGlyphDirection = strSortOrder;
        }

        public fmRefGradeAllwnc(Form owner)
        {
            this.SingleFormMode(owner);
            InitializeComponent();
        }

        private void fmAllowance_Load(object sender, EventArgs e)
        {
            InitGrid();
        }

        private void fmAllowance_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }

        private void dgvAllowance_KeyDown(object sender, KeyEventArgs e)
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
