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
using DAL;
using Entities;
using BLL;

namespace WinUI.WinForms
{
    public partial class fmLawContract : Form
    {
        public fmLawContract(Form owner)
        {
            InitializeComponent();
            this.SingleFormMode(owner);
        }
    }
}
