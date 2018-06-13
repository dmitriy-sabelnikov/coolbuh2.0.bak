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
    public partial class fmCmbCard : Form
    {
        private List<PersCard> _persCards = null;
        public PersCard GetData()
        {
            if (dgvCmbCard.CurrentRow == null)
                return null;
            return dgvCmbCard.CurrentRow.DataBoundItem as PersCard;
        }
        private void InitGrid()
        {
            dgvCmbCard.BaseGrigStyle();
            dgvCmbCard.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCmbCard.DataSource = _persCards;
        }

        public fmCmbCard(List<PersCard> cards)
        {
            InitializeComponent();
            _persCards = cards;
        }

        private void fmCmbCard_Load(object sender, EventArgs e)
        {
            InitGrid();

            btnOk.AddButtonOk(this);
            btnCancel.AddButtonCancel(this);
        }

        private void fmCmbCard_KeyDown(object sender, KeyEventArgs e)
        {
            //Нажатие кнопки Escape
            if (e.KeyCode == Keys.Escape)
            {
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

        private void dgvCmbCard_DoubleClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void dgvCmbCard_KeyDown(object sender, KeyEventArgs e)
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
    }
}
