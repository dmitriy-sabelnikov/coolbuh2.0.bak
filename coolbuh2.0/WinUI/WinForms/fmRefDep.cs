using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DAL;
using Entities;
using BLL;
using WinUI.Helper;
using WinFormExtensions;

namespace WinUI.WinForms
{
    public partial class fmRefDep : Form
    {
        private RefDepRepository _repository = new RefDepRepository(SetupProgram.Connection);
        private List<RefDep> refDeps = null; //Кеширование
        //Вставка строки
        private void InsertRecord()
        {
            fmRefDepEdit fmEdit = new fmRefDepEdit("Створення підрозділу");
            if (fmEdit.ShowDialog() == DialogResult.OK)
            {
                string error;
                RefDep refDep = fmEdit.GetData();
                if (!_repository.AddDep(refDep, out error))
                {
                    MessageBox.Show("Помилка видалення.\nТехнічна інформація: " + error, "Помилка");
                    return;
                }
                RefreshTable();
            }
        }
        //Обновление строки
        private void UpdateRecord()
        {
            if (dgvRefDep.CurrentRow == null) return;
            string error;
            RefDep findDep = dgvRefDep.CurrentRow.DataBoundItem as RefDep;
            if (findDep == null)
            {
                MessageBox.Show("Не знайдений підрозділ для оновлення", "Помилка");
                return;
            }
            fmRefDepEdit fmEdit = new fmRefDepEdit("Зміна підрозділу");
            fmEdit.SetData(findDep);
            if (fmEdit.ShowDialog() == DialogResult.OK)
            {
                findDep = fmEdit.GetData();
                if (!_repository.ModifyDep(findDep, out error))
                {
                    MessageBox.Show("Помилка оновлення підрозділу.\nТехнічна інформація: " + error, "Помилка");
                    return;
                }
                RefreshTable();
            }
        }
        //Физическое удаление строки
        private void DeleteRecord()
        {
            if (dgvRefDep.CurrentRow == null) return;
            if (MessageBox.Show("Ви впевнені, що бажаєте остаточно видалити підрозділ?", "Видалення", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            RefDep findDep = dgvRefDep.CurrentRow.DataBoundItem as RefDep;
            if (findDep == null)
            {
                MessageBox.Show("Не знайдений підрозділ для видалення", "Помилка");
                return;
            }
            string error;
            if (!_repository.DeleteDep(findDep.RefDep_Id, out error))
            {
                MessageBox.Show("Помилка видалення.\nТехнічна інформація: " + error, "Помилка");
                return;
            }
            RefreshTable();
        }
        //Обновить меню
        private void RefreshMenu()
        {
            bool isEnableMenu = dgvRefDep.CurrentRow == null ? false : true;
            MenuItemCreate.Enabled = true;
            MenuItemEdit.Enabled = isEnableMenu;
            MenuItemDelete.Enabled = isEnableMenu;
        }
        //Перезачитать данные таблицы
        private void RefreshTable()
        {
            dgvRefDep.StorePosition();
            string error;
            refDeps = _repository.GetAllDeps(out error);
            if(error != string.Empty)
            {
                MessageBox.Show("Помилка оновлення таблиці.\nТехнічна інформація: " + error, "Помилка");
                return;
            }
            dgvRefDep.DataSource = refDeps;
            dgvRefDep.RestPosition();
        }
        //Инициализация грида
        private void InitGrid()
        {
            dgvRefDep.BaseGrigStyle();
            dgvRefDep.AddRefreshMenu(RefreshMenu);
            dgvRefDep.AddSortGrid(SortGrid);

            string error;
            refDeps = _repository.GetAllDeps(out error);
            if (error != string.Empty)
            {
                MessageBox.Show("Помилка ініціалізації.\nТехнічна інформація: " + error, "Помилка");
                return;
            }
            dgvRefDep.DataSource = refDeps;
        }
        //Функция сортировки грида
        private void SortGrid(DataGridViewCellMouseEventArgs e)
        {
            string strColumnName = dgvRefDep.Columns[e.ColumnIndex].Name;
            SortOrder strSortOrder = dgvRefDep.getSortOrder(e.ColumnIndex);

            if (strSortOrder == SortOrder.Ascending)
            {
                refDeps = refDeps.OrderBy(x => typeof(RefDep).GetProperty(strColumnName).GetValue(x, null)).ToList();
            }
            else
            if (strSortOrder == SortOrder.Descending)
            {
                refDeps = refDeps.OrderByDescending(x => typeof(RefDep).GetProperty(strColumnName).GetValue(x, null)).ToList();
            }
            if (strSortOrder == SortOrder.None)
            {
                refDeps = refDeps.OrderBy(x => typeof(RefDep).GetProperty("RefDep_Id").GetValue(x, null)).ToList();
            }
            dgvRefDep.DataSource = refDeps;
            dgvRefDep.Columns[e.ColumnIndex].HeaderCell.SortGlyphDirection = strSortOrder;
        }
        public fmRefDep(Form owner)
        {
            this.SingleFormMode(owner);
            InitializeComponent();
        }
        private void fmRefDep_Load(object sender, EventArgs e)
        {
            InitGrid();
        }
        private void dgvRefDep_KeyDown(object sender, KeyEventArgs e)
        {
            //Нажатие кнопки Escape
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
        //-----------------------------------События меню--------------------------------------
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
        private void MenuItemExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void MenuItemRefresh_Click(object sender, EventArgs e)
        {
            RefreshTable();
        }
        //---------------------------------------------------------------------------------
    }
}
