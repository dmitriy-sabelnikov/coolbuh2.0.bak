﻿using System;
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
    public partial class fmRefOthAllwnc : Form
    {
        private List<RefOthAllwnc> _refOthAllwncs = null; //Кеширование
        private List<v_RefOthAllwnc> _vRefOthAllwncs = null; //Кеширование

        private RefOthAllwncRepository _repository = new RefOthAllwncRepository(SetupProgram.Connection);

        private List<v_RefOthAllwnc> GetViewAllowance(List<RefOthAllwnc> Allowance)
        {
            List<v_RefOthAllwnc> v_allwncs = new List<v_RefOthAllwnc>();
            foreach (RefOthAllwnc allwnc in Allowance)
            {
                v_RefOthAllwnc v_allwnc = new v_RefOthAllwnc();
                v_allwnc.RefOthAllwnc_Id = allwnc.RefOthAllwnc_Id;
                v_allwnc.RefOthAllwnc_Cd = allwnc.RefOthAllwnc_Cd;
                v_allwnc.RefOthAllwnc_Nm = allwnc.RefOthAllwnc_Nm;
                v_allwnc.RefOthAllwnc_Pct = allwnc.RefOthAllwnc_Pct;
                v_allwnc.RefOthAllwnc_Use = (allwnc.RefOthAllwnc_Flg & (int)EnumOthAllwnc_Flg.ALLWNC_NOTUSE) > 0 ? 0 : 1;
                v_allwncs.Add(v_allwnc);
            }
            return v_allwncs;
        }
        //Вставка строки
        private void InsertRecord()
        {
            fmRefOthAllwncEdit fmEdit = new fmRefOthAllwncEdit(EnumFormMode.Insert, "Створення надбавки");
            if (fmEdit.ShowDialog() == DialogResult.OK)
            {
                string error;
                RefOthAllwnc othAllwnc = fmEdit.GetData();

                if (!_repository.AddOthAllwnc(othAllwnc, out error))
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
            if (dgvOthAllwnc.CurrentRow == null) return;
            string error;
            v_RefOthAllwnc v_othAllwnc = dgvOthAllwnc.CurrentRow.DataBoundItem as v_RefOthAllwnc;
            if (v_othAllwnc == null)
            {
                MessageBox.Show("Не знайдена надбавка для оновлення", "Помилка");
                return;
            }

            fmRefOthAllwncEdit fmEdit = new fmRefOthAllwncEdit(EnumFormMode.Edit, "Зміна надбавки");
            fmEdit.SetData(v_othAllwnc);
            if (fmEdit.ShowDialog() == DialogResult.OK)
            {
                RefOthAllwnc OthAllwnc = fmEdit.GetData();
                if (!_repository.ModifyOthAllwnc(OthAllwnc, out error))
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
            if (dgvOthAllwnc.CurrentRow == null) return;
            if (MessageBox.Show("Ви впевнені, що бажаєте видалити надбавку?", "Видалення", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            v_RefOthAllwnc v_othAllwnc = dgvOthAllwnc.CurrentRow.DataBoundItem as v_RefOthAllwnc;
            if (v_othAllwnc == null)
            {
                MessageBox.Show("Не знайдена надбавка для оновлення", "Помилка");
                return;
            }
            string error;
            if (!_repository.DeleteOthAllwnc(v_othAllwnc.RefOthAllwnc_Id, out error))
            {
                MessageBox.Show("Помилка видалення надбавки.\nТехнічна інформація: " + error, "Помилка");
                return;
            }
            RefreshTable();
        }
        //Перезачитать данные таблицы
        private void RefreshTable()
        {
            dgvOthAllwnc.StorePosition();
            string error;
            _refOthAllwncs = _repository.GetAllOthAllwnc(out error);
            if (error != string.Empty)
            {
                MessageBox.Show("Помилка оновлення таблиці.\nТехнічна інформація: " + error, "Помилка");
                return;
            }
            _vRefOthAllwncs = GetViewAllowance(_refOthAllwncs);
            dgvOthAllwnc.DataSource = _vRefOthAllwncs;
            dgvOthAllwnc.RestPosition();
        }
        //Инициализация грида
        private void InitGrid()
        {
            dgvOthAllwnc.BaseGrigStyle();
            dgvOthAllwnc.AddRefreshMenu(RefreshMenu);
            dgvOthAllwnc.AddSortGrid(SortGrid);
            string error;
            _refOthAllwncs = _repository.GetAllOthAllwnc(out error);
            if (error != string.Empty)
            {
                MessageBox.Show("Помилка ініціалізації.\nТехнічна інформація: " + error, "Помилка");
                return;
            }
            _vRefOthAllwncs = GetViewAllowance(_refOthAllwncs);
            dgvOthAllwnc.DataSource = _vRefOthAllwncs;
        }
        //Обновить меню
        private void RefreshMenu()
        {
            bool isEnableMenu = dgvOthAllwnc.CurrentRow == null ? false : true;
            MenuItemCreate.Enabled = true;
            MenuItemEdit.Enabled = isEnableMenu;
            MenuItemDelete.Enabled = isEnableMenu;
        }
        //Функция сортировки грида
        private void SortGrid(DataGridViewCellMouseEventArgs e)
        {
            string strColumnName = dgvOthAllwnc.Columns[e.ColumnIndex].Name;
            SortOrder strSortOrder = dgvOthAllwnc.getSortOrder(e.ColumnIndex);

            if (strSortOrder == SortOrder.Ascending)
            {
                _vRefOthAllwncs = _vRefOthAllwncs.OrderBy(x => typeof(v_RefOthAllwnc).GetProperty(strColumnName).GetValue(x, null)).ToList();
            }
            else
            if (strSortOrder == SortOrder.Descending)
            {
                _vRefOthAllwncs = _vRefOthAllwncs.OrderByDescending(x => typeof(v_RefOthAllwnc).GetProperty(strColumnName).GetValue(x, null)).ToList();
            }
            if (strSortOrder == SortOrder.None)
            {
                _vRefOthAllwncs = _vRefOthAllwncs.OrderBy(x => typeof(v_RefOthAllwnc).GetProperty("RefOthAllwnc_Id").GetValue(x, null)).ToList();
            }
            dgvOthAllwnc.DataSource = _vRefOthAllwncs;
            dgvOthAllwnc.Columns[e.ColumnIndex].HeaderCell.SortGlyphDirection = strSortOrder;
        }
        public fmRefOthAllwnc(Form owner)
        {
            InitializeComponent();
            this.SingleFormMode(owner);
        }

        private void fmRefOthAllwnc_Load(object sender, EventArgs e)
        {
            InitGrid();
        }

        private void fmRefOthAllwnc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }

        private void dgvOthAllwnc_KeyDown(object sender, KeyEventArgs e)
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
