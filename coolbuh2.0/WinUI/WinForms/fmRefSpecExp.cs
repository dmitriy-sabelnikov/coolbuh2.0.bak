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
    public partial class fmRefSpecExp : Form
    {
        private List<RefSpecExp> specExps = null; //Кеширование
        private RefSpecExpRepository _repository = new RefSpecExpRepository(SetupProgram.Connection);

        //Вставка строки
        private void InsertRecord()
        {
            fmRefSpecExpEdit fmEdit = new fmRefSpecExpEdit(EnumFormMode.Insert, "Створення спецстажу");
            if (fmEdit.ShowDialog() == DialogResult.OK)
            {
                string error;
                RefSpecExp specExp = fmEdit.GetData();

                if (!_repository.AddSpecExp(specExp, out error))
                {
                    MessageBox.Show("Помилка додавання спецстажу.\nТехнічна інформація: " + error, "Помилка");
                    return;
                }
                RefreshTable();
            }
        }
        //Обновление строки
        private void UpdateRecord()
        {
            if (dgvRefSpecExp.CurrentRow == null) return;
            RefSpecExp specExp = dgvRefSpecExp.CurrentRow.DataBoundItem as RefSpecExp;
            if (specExp == null)
            {
                MessageBox.Show("Не знайдений спецстаж для оновлення", "Помилка");
                return;
            }
            fmRefSpecExpEdit fmEdit = new fmRefSpecExpEdit(EnumFormMode.Edit, "Зміна спецстажу");
            fmEdit.SetData(specExp);
            if (fmEdit.ShowDialog() == DialogResult.OK)
            {
                string error;
                specExp = fmEdit.GetData();
                if (!_repository.ModifySpecExp(specExp, out error))
                {
                    MessageBox.Show("Помилка оновлення спецстажу.\nТехнічна інформація: " + error, "Помилка");
                    return;
                }
                RefreshTable();
            }
        }
        //Физическое удаление строки
        private void DeleteRecord()
        {
            if (dgvRefSpecExp.CurrentRow == null) return;
            if (MessageBox.Show("Ви впевнені, що бажаєте видалити спецстаж?", "Видалення", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            RefSpecExp specExp = dgvRefSpecExp.CurrentRow.DataBoundItem as RefSpecExp;
            string error;
            if (!_repository.DeleteSpecExp(specExp.RefSpecExp_Id, out error))
            {
                MessageBox.Show("Помилка видалення спецстажу.\nТехнічна інформація: " + error, "Помилка");
                return;
            }
            RefreshTable();
        }
        //Перезачитать данные таблицы
        private void RefreshTable()
        {
            dgvRefSpecExp.StorePosition();
            string error;
            specExps = _repository.GetAllSpecExps(out error);
            if (error != string.Empty)
            {
                MessageBox.Show("Помилка оновлення таблиці.\nТехнічна інформація: " + error, "Помилка");
                return;
            }
            dgvRefSpecExp.DataSource = specExps;
            dgvRefSpecExp.RestPosition();
        }
        //Инициализация грида
        private void InitGrid()
        {
            dgvRefSpecExp.BaseGrigStyle();
            dgvRefSpecExp.AddRefreshMenu(RefreshMenu);
            dgvRefSpecExp.AddSortGrid(SortGrid);
            string error;
            specExps = _repository.GetAllSpecExps(out error);
            if (error != string.Empty)
            {
                MessageBox.Show("Помилка ініціалізації.\nТехнічна інформація: " + error, "Помилка");
                return;
            }
            dgvRefSpecExp.DataSource = specExps;
        }
        //Обновить меню
        private void RefreshMenu()
        {
            bool isEnableMenu = dgvRefSpecExp.CurrentRow == null ? false : true;
            MenuItemCreate.Enabled = true;
            MenuItemEdit.Enabled = isEnableMenu;
            MenuItemDelete.Enabled = isEnableMenu;
        }
        //Функция сортировки грида
        private void SortGrid(DataGridViewCellMouseEventArgs e)
        {
            string strColumnName = dgvRefSpecExp.Columns[e.ColumnIndex].Name;
            SortOrder strSortOrder = dgvRefSpecExp.getSortOrder(e.ColumnIndex);

            if (strSortOrder == SortOrder.Ascending)
            {
                specExps = specExps.OrderBy(x => typeof(RefSpecExp).GetProperty(strColumnName).GetValue(x, null)).ToList();
            }
            else
            if (strSortOrder == SortOrder.Descending)
            {
                specExps = specExps.OrderByDescending(x => typeof(RefSpecExp).GetProperty(strColumnName).GetValue(x, null)).ToList();
            }
            if (strSortOrder == SortOrder.None)
            {
                specExps = specExps.OrderBy(x => typeof(RefSpecExp).GetProperty("RefSpecExp_Id").GetValue(x, null)).ToList();
            }
            dgvRefSpecExp.DataSource = specExps;
            dgvRefSpecExp.Columns[e.ColumnIndex].HeaderCell.SortGlyphDirection = strSortOrder;
        }

        public fmRefSpecExp(Form owner)
        {
            this.SingleFormMode(owner);
            InitializeComponent();
        }

        private void fmRefSpecExp_Load(object sender, EventArgs e)
        {
            InitGrid();
        }

        private void fmRefSpecExp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }

        private void dgvRefSpecExp_KeyDown(object sender, KeyEventArgs e)
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
        //-------------------------------------------------------------
    }
}
