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
    public partial class fmRefAdm : Form
    {
        private List<RefAdm> refAdms = null; //Кеширование
        private RefAdmRepository _repository = new RefAdmRepository(SetupProgram.Connection);

        //Вставка строки
        private void InsertRecord()
        {
            fmRefAdmEdit fmEdit = new fmRefAdmEdit(EnumFormMode.Insert, "Створення адміністрації");
            if (fmEdit.ShowDialog() == DialogResult.OK)
            {
                string error;
                RefAdm adm = fmEdit.GetData();

                if (!_repository.AddAdm(adm, out error))
                {
                    MessageBox.Show("Помилка додавання адміністрації.\nТехнічна інформація: " + error, "Помилка");
                    return;
                }
                RefreshTable();
            }
        }
        //Обновление строки
        private void UpdateRecord()
        {
            if (dgvRefAdm.CurrentRow == null) return;
            RefAdm adm = dgvRefAdm.CurrentRow.DataBoundItem as RefAdm;
            if (adm == null)
            {
                MessageBox.Show("Не знайдена адміністрація для оновлення", "Помилка");
                return;
            }
            fmRefAdmEdit fmEdit = new fmRefAdmEdit(EnumFormMode.Edit, "Зміна адміністрації");
            fmEdit.SetData(adm);
            if (fmEdit.ShowDialog() == DialogResult.OK)
            {
                adm = fmEdit.GetData();
                string error;
                if (!_repository.ModifyAdm(adm, out error))
                {
                    MessageBox.Show("Помилка оновлення адміністрації.\nТехнічна інформація: " + error, "Помилка");
                    return;
                }
                RefreshTable();
            }
        }
        //Физическое удаление строки
        private void DeleteRecord()
        {
            if (dgvRefAdm.CurrentRow == null) return;
            if (MessageBox.Show("Ви впевнені, що бажаєте видалити адміністрацію?", "Видалення", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            RefAdm adm = dgvRefAdm.CurrentRow.DataBoundItem as RefAdm;
            if (adm == null)
            {
                MessageBox.Show("Не знайдена адміністрація для видалення", "Помилка");
                return;
            }
            string error;
            if (!_repository.DeleteAdm(adm.RefAdm_Id, out error))
            {
                MessageBox.Show("Помилка видалення адміністрації.\nТехнічна інформація: " + error, "Помилка");
                return;
            }
            RefreshTable();
        }
        //Перезачитать данные таблицы
        private void RefreshTable()
        {
            dgvRefAdm.StorePosition();
            string error;
            refAdms = _repository.GetAllAdms(out error);
            if (error != string.Empty)
            {
                MessageBox.Show("Помилка оновлення таблиці.\nТехнічна інформація: " + error, "Помилка");
                return;
            }
            dgvRefAdm.DataSource = refAdms;
            dgvRefAdm.RestPosition();
        }
        //Инициализация грида
        private void InitGrid()
        {
            dgvRefAdm.BaseGrigStyle();
            dgvRefAdm.AddRefreshMenu(RefreshMenu);
            dgvRefAdm.AddSortGrid(SortGrid);
            string error;
            refAdms = _repository.GetAllAdms(out error);
            if (error != string.Empty)
            {
                MessageBox.Show("Помилка ініціалізації.\nТехнічна інформація: " + error, "Помилка");
                return;
            }
            dgvRefAdm.DataSource = refAdms;
        }
        //Обновить меню
        private void RefreshMenu()
        {
            bool isEnableMenu = dgvRefAdm.CurrentRow == null ? false : true;
            MenuItemCreate.Enabled = true;
            MenuItemEdit.Enabled = isEnableMenu;
            MenuItemDelete.Enabled = isEnableMenu;
        }
        //Функция сортировки грида
        private void SortGrid(DataGridViewCellMouseEventArgs e)
        {
            string strColumnName = dgvRefAdm.Columns[e.ColumnIndex].Name;
            SortOrder strSortOrder = dgvRefAdm.getSortOrder(e.ColumnIndex);

            if (strSortOrder == SortOrder.Ascending)
            {
                refAdms = refAdms.OrderBy(x => typeof(RefAdm).GetProperty(strColumnName).GetValue(x, null)).ToList();
            }
            else
            if (strSortOrder == SortOrder.Descending)
            {
                refAdms = refAdms.OrderByDescending(x => typeof(RefAdm).GetProperty(strColumnName).GetValue(x, null)).ToList();
            }
            if (strSortOrder == SortOrder.None)
            {
                refAdms = refAdms.OrderBy(x => typeof(RefAdm).GetProperty("RefAdm_Id").GetValue(x, null)).ToList();
            }
            dgvRefAdm.DataSource = refAdms;
            dgvRefAdm.Columns[e.ColumnIndex].HeaderCell.SortGlyphDirection = strSortOrder;
        }

        public fmRefAdm(Form owner)
        {
            this.SingleFormMode(owner);
            InitializeComponent();
        }

        private void fmRefAdm_Load(object sender, EventArgs e)
        {
            InitGrid();
        }

        private void dgvRefAdm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }

        private void fmRefAdm_KeyDown(object sender, KeyEventArgs e)
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
        //-----------------------------------------------------------
    }
}
