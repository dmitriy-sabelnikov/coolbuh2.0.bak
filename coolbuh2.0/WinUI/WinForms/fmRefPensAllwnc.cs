using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormExtensions;
using Entities;
using EnumType;
using DAL;
using BLL;

namespace WinUI.WinForms
{
    public partial class fmRefPensAllwnc : Form
    {
        private List<RefPensAllwnc> _refPensAllwncs = null; //Кеширование
        private List<v_RefPensAllwnc> _vRefPensAllwncs = null; //Кеширование

        private RefPensAllwncRepository _repository = new RefPensAllwncRepository(SetupProgram.Connection);

        private List<v_RefPensAllwnc> GetViewAllowance(List<RefPensAllwnc> Allowance)
        {
            List<v_RefPensAllwnc> v_allwncs = new List<v_RefPensAllwnc>();
            foreach (RefPensAllwnc allwnc in Allowance)
            {
                v_RefPensAllwnc v_allwnc = new v_RefPensAllwnc();
                v_allwnc.RefPensAllwnc_Id = allwnc.RefPensAllwnc_Id;
                v_allwnc.RefPensAllwnc_Cd = allwnc.RefPensAllwnc_Cd;
                v_allwnc.RefPensAllwnc_Nm = allwnc.RefPensAllwnc_Nm;
                v_allwnc.RefPensAllwnc_Pct = allwnc.RefPensAllwnc_Pct;
                v_allwnc.RefPensAllwnc_Use = (allwnc.RefPensAllwnc_Flg & (int)EnumPensAllwnc_Flg.ALLWNC_NOTUSE) > 0 ? 0 : 1;
                v_allwncs.Add(v_allwnc);
            }
            return v_allwncs;
        }

        //Вставка строки
        private void InsertRecord()
        {
            fmRefPensAllwncEdit fmEdit = new fmRefPensAllwncEdit(EnumFormMode.Insert, "Створення надбавки");
            if (fmEdit.ShowDialog() == DialogResult.OK)
            {
                string error;
                RefPensAllwnc pensAllwnc = fmEdit.GetData();
        
                if (!_repository.AddPensAllwnc(pensAllwnc, out error))
                {
                    MessageBox.Show("Помилка додавання.\nТехнічна інформація: " + error, "Помилка");
                    return;
                }
                RefreshTable();
            }
        }
        //Обновление строки
        private void UpdateRecord()
        {
            if (dgvPensAllwnc.CurrentRow == null) return;
            string error;
            v_RefPensAllwnc v_pensAllwnc = dgvPensAllwnc.CurrentRow.DataBoundItem as v_RefPensAllwnc;
            if (v_pensAllwnc == null)
            {
                MessageBox.Show("Не знайдена надбавка для оновлення", "Помилка");
                return;
            }
        
            fmRefPensAllwncEdit fmEdit = new fmRefPensAllwncEdit(EnumFormMode.Edit, "Зміна надбавки");
            fmEdit.SetData(v_pensAllwnc);
            if (fmEdit.ShowDialog() == DialogResult.OK)
            {
                RefPensAllwnc pensAllwnc = fmEdit.GetData();
                if (!_repository.ModifyPensAllwnc(pensAllwnc, out error))
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
            if (dgvPensAllwnc.CurrentRow == null) return;
            if (MessageBox.Show("Ви впевнені, що бажаєте видалити надбавку?", "Видалення", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            v_RefPensAllwnc v_pensAllwnc = dgvPensAllwnc.CurrentRow.DataBoundItem as v_RefPensAllwnc;
            if (v_pensAllwnc == null)
            {
                MessageBox.Show("Не знайдена надбавка для оновлення", "Помилка");
                return;
            }
            string error;
            if (!_repository.DeletePensAllwnc(v_pensAllwnc.RefPensAllwnc_Id, out error))
            {
                MessageBox.Show("Помилка видалення надбавки.\nТехнічна інформація: " + error, "Помилка");
                return;
            }
            RefreshTable();
        }

        //Перезачитать данные таблицы
        private void RefreshTable()
        {
            dgvPensAllwnc.StorePosition();
            string error;
            _refPensAllwncs = _repository.GetAllPensAllwnc(out error);
            if (error != string.Empty)
            {
                MessageBox.Show("Помилка оновлення таблиці.\nТехнічна інформація: " + error, "Помилка");
                return;
            }
            _vRefPensAllwncs = GetViewAllowance(_refPensAllwncs);
            dgvPensAllwnc.DataSource = _vRefPensAllwncs;
            dgvPensAllwnc.RestPosition();
        }
        //Инициализация грида
        private void InitGrid()
        {
            dgvPensAllwnc.BaseGrigStyle();
            dgvPensAllwnc.AddRefreshMenu(RefreshMenu);
            dgvPensAllwnc.AddSortGrid(SortGrid);
            string error;
            _refPensAllwncs = _repository.GetAllPensAllwnc(out error);
            if (error != string.Empty)
            {
                MessageBox.Show("Помилка ініціалізації.\nТехнічна інформація: " + error, "Помилка");
                return;
            }
            _vRefPensAllwncs = GetViewAllowance(_refPensAllwncs);
            dgvPensAllwnc.DataSource = _vRefPensAllwncs;
        }
        //Обновить меню
        private void RefreshMenu()
        {
            bool isEnableMenu = dgvPensAllwnc.CurrentRow == null ? false : true;
            MenuItemCreate.Enabled = true;
            MenuItemEdit.Enabled = isEnableMenu;
            MenuItemDelete.Enabled = isEnableMenu;
        }
        //Функция сортировки грида
        private void SortGrid(DataGridViewCellMouseEventArgs e)
        {
            string strColumnName = dgvPensAllwnc.Columns[e.ColumnIndex].Name;
            SortOrder strSortOrder = dgvPensAllwnc.getSortOrder(e.ColumnIndex);

            if (strSortOrder == SortOrder.Ascending)
            {
                _vRefPensAllwncs = _vRefPensAllwncs.OrderBy(x => typeof(v_RefPensAllwnc).GetProperty(strColumnName).GetValue(x, null)).ToList();
            }
            else
            if (strSortOrder == SortOrder.Descending)
            {
                _vRefPensAllwncs = _vRefPensAllwncs.OrderByDescending(x => typeof(v_RefPensAllwnc).GetProperty(strColumnName).GetValue(x, null)).ToList();
            }
            if (strSortOrder == SortOrder.None)
            {
                _vRefPensAllwncs = _vRefPensAllwncs.OrderBy(x => typeof(v_RefPensAllwnc).GetProperty("RefPensAllwnc_Id").GetValue(x, null)).ToList();
            }
            dgvPensAllwnc.DataSource = _vRefPensAllwncs;
            dgvPensAllwnc.Columns[e.ColumnIndex].HeaderCell.SortGlyphDirection = strSortOrder;
        }

        public fmRefPensAllwnc(Form owner)
        {
            InitializeComponent();
            this.SingleFormMode(owner);
        }

        private void fmRefPensAllwnc_Load(object sender, EventArgs e)
        {
            InitGrid();
        }

        private void fmRefPensAllwnc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }

        private void dgvPensAllwnc_KeyDown(object sender, KeyEventArgs e)
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
    }
}
