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
using WinUI.Helper;
using ComboBoxes;
using BLL;
using WinFormExtensions;
using EnumType;

namespace WinUI.WinForms
{
    public partial class fmRefAdmEdit : Form
    {
        private int id = 0;
        private ToolTip tooltip = new ToolTip();
        private bool CanSaveAdm()
        {
            if (tbFIO.Text == string.Empty)
            {
                tbFIO.Focus();
                return false;
            }
            if (tbDolNm.Text == string.Empty)
            {
                tbDolNm.Focus();
                return false;
            }
            return true;
        }
        public void SetData(RefAdm adm)
        {
            if (adm == null) return;
            id           = adm.RefAdm_Id;
            tbFIO.Text   = adm.RefAdm_FIO;
            tbTIN.Text   = adm.RefAdm_TIN;
            tbDolNm.Text = adm.RefAdm_DolNm;
            tbOrgCd.Text = adm.RefAdm_OrgCd;
            tbTel.Text   = adm.RefAdm_Tel;
        }

        public RefAdm GetData()
        {
            return new RefAdm()
            {
                RefAdm_Id    = id,
                RefAdm_FIO   = tbFIO.Text,
                RefAdm_TIN   = tbTIN.Text,
                RefAdm_DolNm = tbDolNm.Text,
                RefAdm_OrgCd = tbOrgCd.Text,
                RefAdm_Tel   = tbTel.Text
            };
        }
        public fmRefAdmEdit(EnumFormMode mode, string caption)
        {
            InitializeComponent();
            Text = caption;
            btnOk.Enabled = false;
        }

        private void tbTIN_Validating(object sender, CancelEventArgs e)
        {
            string error;
            tooltip.Hide(tbTIN);
            if (tbTIN.Text == string.Empty)
                return;

            if (!CheckTIN.CheckNumberTIN(tbTIN.Text, out error))
            {
                tbTIN.SetToolTipe(error);
                tbTIN.Focus();
                return;
            }

        }

        private void fmRefAdmEdit_Load(object sender, EventArgs e)
        {
            tbFIO.NecessaryField();
            tbDolNm.NecessaryField();

            tbTIN.AddNumericField();
            tbOrgCd.AddNumericField();

            tbFIO.IsModifyField(() => { btnOk.Enabled = true; });
            tbTIN.IsModifyField(() => { btnOk.Enabled = true; });
            tbDolNm.IsModifyField(() => { btnOk.Enabled = true; });
            tbOrgCd.IsModifyField(() => { btnOk.Enabled = true; });
            tbTel.IsModifyField(() => { btnOk.Enabled = true; });
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!CanSaveAdm())
                return;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
            Close();
        }

        private void fmRefAdmEdit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }
    }
}
