using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinUI.WinForms
{
    public partial class fmCalcResult : Form
    {
        public fmCalcResult(StringBuilder text)
        {
            InitializeComponent();
            rtbCalcResult.AppendText(text.ToString());
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
