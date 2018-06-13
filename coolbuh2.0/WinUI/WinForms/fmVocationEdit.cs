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
using BLL;
using WinFormExtensions;
using EnumType;


namespace WinUI.WinForms
{
    public partial class fmVocationEdit : Form
    {
        public Vocation GetData()
        {
            return new Vocation();
        }
        public void SetData(Vocation vocation)
        {

        }
        public fmVocationEdit(EnumFormMode mode, string caption)
        {
            InitializeComponent();
            Text = caption;
            //btnOk.Enabled = false;
        }
    }
}
