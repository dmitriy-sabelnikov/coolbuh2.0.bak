using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using WinFormExtensions;
using DAL;
using Entities;


namespace ComboBoxes.WinWorms
{
    public partial class fmCmbDep : Form
    {
        private List<RefDep> _refDeps = null;
        public RefDep GetData()
        {
            if (dgvCmbDep.CurrentRow == null)
                return null;
            return dgvCmbDep.CurrentRow.DataBoundItem as RefDep;                
        }
        private void InitGrid()
        {
            dgvCmbDep.BaseGrigStyle();
            dgvCmbDep.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCmbDep.DataSource = _refDeps;
        }
        public fmCmbDep(List<RefDep> deps)
        {
            InitializeComponent();
            _refDeps = deps;
        }

        private void fmCmbDep_Load(object sender, EventArgs e)
        {
            InitGrid();

            btnOk.AddButtonOk(this);
            btnCancel.AddButtonCancel(this);
        }

        private void fmCmbDep_KeyDown(object sender, KeyEventArgs e)
        {
            //Нажатие кнопки Escape
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void dgvCmbDep_KeyDown(object sender, KeyEventArgs e)
        {
            //Нажатие кнопки Escape
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
            if (e.KeyCode == Keys.Enter)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
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

        private void dgvCmbDep_DoubleClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
