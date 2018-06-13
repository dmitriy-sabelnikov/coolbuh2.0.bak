using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormExtensions
{
    public static class CheckBoxExtension
    {
        public static void IsModifyField(this CheckBox checkbox, Action isModify)
        {
            checkbox.CheckStateChanged += (object sender, EventArgs e) =>
            {
                isModify();
            };
        }
    }
}
