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
using DAL;
using Entities;

namespace ComboBoxes.WinWorms
{
    public partial class fmCmbPensAllwnc : Form
    {
        private List<RefPensAllwnc> _allowances = null;

        public RefPensAllwnc GetData()
        {
            if (dgvPensAllwnc.CurrentRow == null)
                return null;

            RefPensAllwnc allowance = dgvPensAllwnc.CurrentRow.DataBoundItem as RefPensAllwnc;

            return allowance;
        }
        private void InitGrid()
        {
            dgvPensAllwnc.BaseGrigStyle();
            dgvPensAllwnc.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPensAllwnc.DataSource = _allowances;
        }
        public fmCmbPensAllwnc(List<RefPensAllwnc> allwncs)
        {
            InitializeComponent();
            _allowances = allwncs;
        }

        private void fmCmbPensAllwnc_Load(object sender, EventArgs e)
        {
            InitGrid();

            btnOk.AddButtonOk(this);
            btnCancel.AddButtonCancel(this);
        }

        private void fmCmbPensAllwnc_KeyDown(object sender, KeyEventArgs e)
        {
            //Нажатие кнопки Escape
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void dgvPensAllwnc_DoubleClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void MenuItemChoose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void MenuItemExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
