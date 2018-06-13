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
using BLL;
using DAL;
using WinFormExtensions;
using ComboBoxes;
using EnumType;

namespace WinUI.WinForms
{
    public partial class fmPersCardEdit : Form
    {
        private List<PersCard> persCards = null; //Кеширование
        private PersCardRepository _repository = new PersCardRepository(SetupProgram.Connection);
        private ToolTip tooltip = new ToolTip();
        private int id = 0;

        private List<AddInfo> addInfo = new List<AddInfo> {
            new AddInfo {Id = 1, MonthName ="1 місяць" },
            new AddInfo {Id = 2, MonthName ="2 місяць" },
            new AddInfo {Id = 3, MonthName ="3 місяць" },
            new AddInfo {Id = 4, MonthName ="4 місяць" },
            new AddInfo {Id = 5, MonthName ="5 місяць" },
            new AddInfo {Id = 6, MonthName ="6 місяць" },
            new AddInfo {Id = 7, MonthName ="7 місяць" },
            new AddInfo {Id = 8, MonthName ="8 місяць" },
            new AddInfo {Id = 9, MonthName ="9 місяць" },
            new AddInfo {Id = 10, MonthName ="10 місяць" },
            new AddInfo {Id = 11, MonthName ="11 місяць" },
            new AddInfo {Id = 12, MonthName ="12 місяць" }
        }; 

        public fmPersCardEdit(EnumFormMode mode, string caption)
        {
            InitializeComponent();

            Text = caption;
            btnOk.Enabled = false;

            dgvAddInfo.BaseGrigStyle();
            dgvAddInfo.ReadOnly = false;
            dgvAddInfo.DataSource = addInfo;
            dgvAddInfo.Columns["MonthName"].ReadOnly = true;

            tbLName.NecessaryField();
            tbFName.NecessaryField();
            tbDOB.NecessaryField();
            tbDOR.NecessaryField();
            tbTIN.NecessaryField();

            tbTIN.AddNumericField();
            tbExp.AddNumericField();
            tbGrade.AddNumericField();

            tbDOB.AddDateField('.');
            tbDOR.AddDateField('.');
            tbDOD.AddDateField('.');
            tbDOP.AddDateField('.');
        }

        private bool CanSaveCard()
        {
            if(tbLName.Text == string.Empty)
            {
                tbLName.Focus();
                return false;
            }

            if (tbFName.Text == string.Empty)
            {
                tbFName.Focus();
                return false;
            }

            if (tbDOB.Text == string.Empty)
            {
                tbDOB.Focus();
                return false;
            }

            if (tbDOR.Text == string.Empty)
            {
                tbDOR.Focus();
                return false;
            }

            if (tbTIN.Text == string.Empty)
            {
                tbDOR.Focus();
                return false;
            }

            return true;
        }
        private void fmPersCardEdit_Load(object sender, EventArgs e)
        {
            tbFName.IsModifyField(() => { btnOk.Enabled = true;});
            tbMName.IsModifyField(() => { btnOk.Enabled = true;});
            tbLName.IsModifyField(() => { btnOk.Enabled = true; });
            tbTIN.IsModifyField(() => { btnOk.Enabled = true;});
            tbExp.IsModifyField(() => { btnOk.Enabled = true; });
            tbGrade.IsModifyField(() => { btnOk.Enabled = true; });
            tbDOB.IsModifyField(() => { btnOk.Enabled = true;});
            tbDOR.IsModifyField(() => { btnOk.Enabled = true;});
            tbDOD.IsModifyField(() => { btnOk.Enabled = true; });
            dgvAddInfo.IsModifyField(() => { btnOk.Enabled = true; });
        }

        public void SetData(PersCard card)
        {
            if (card == null) return;
            id = card.PersCard_Id;
            tbFName.Text = card.PersCard_FName;
            tbMName.Text = card.PersCard_MName;
            tbLName.Text = card.PersCard_LName;
            tbTIN.Text = card.PersCard_TIN;
            if (card.PersCard_Exp != 0)
                tbExp.Text = card.PersCard_Exp.ToString();
            if (card.PersCard_Grade != 0)
                tbGrade.Text = card.PersCard_Grade.ToString();
            if (card.PersCard_DOB != DateTime.MinValue)
                tbDOB.Text = card.PersCard_DOB.ToShortDateString();
            if (card.PersCard_DOR != DateTime.MinValue)
                tbDOR.Text = card.PersCard_DOR.ToShortDateString();
            if (card.PersCard_DOD != DateTime.MinValue)
                tbDOD.Text = card.PersCard_DOD.ToShortDateString();
            if (card.PersCard_DOP != DateTime.MinValue)
                tbDOP.Text = card.PersCard_DOP.ToShortDateString();

            for (int n = 0; n < addInfo.Count; n++)
            {
                switch (n+1)
                {
                    case 1:
                        addInfo[n].Child = card.PersCard_ChldM1;
                        break;
                    case 2:
                        addInfo[n].Child = card.PersCard_ChldM2;
                        break;
                    case 3:
                        addInfo[n].Child = card.PersCard_ChldM3;
                        break;
                    case 4:
                        addInfo[n].Child = card.PersCard_ChldM4;
                        break;
                    case 5:
                        addInfo[n].Child = card.PersCard_ChldM5;
                        break;
                    case 6:
                        addInfo[n].Child = card.PersCard_ChldM6;
                        break;
                    case 7:
                        addInfo[n].Child = card.PersCard_ChldM7;
                        break;
                    case 8:
                        addInfo[n].Child = card.PersCard_ChldM8;
                        break;
                    case 9:
                        addInfo[n].Child = card.PersCard_ChldM9;
                        break;
                    case 10:
                        addInfo[n].Child = card.PersCard_ChldM10;
                        break;
                    case 11:
                        addInfo[n].Child = card.PersCard_ChldM11;
                        break;
                    case 12:
                        addInfo[n].Child = card.PersCard_ChldM12;
                        break;
                }
            }
        }

        public PersCard GetData()
        {
            PersCard card = new PersCard();
            card.PersCard_Id = id;
            card.PersCard_FName = tbFName.Text;
            card.PersCard_MName = tbMName.Text;
            card.PersCard_LName = tbLName.Text;
            card.PersCard_TIN = tbTIN.Text;
            int exp = 0;
            int.TryParse(tbExp.Text, out exp);
            card.PersCard_Exp = exp;

            int grade = 0;
            int.TryParse(tbGrade.Text, out grade);
            card.PersCard_Grade = grade;

            DateTime dob;
            DateTime.TryParse(tbDOB.Text, out dob);
            card.PersCard_DOB = dob;

            DateTime dor;
            DateTime.TryParse(tbDOR.Text, out dor);
            card.PersCard_DOR = dor;

            DateTime dod;
            DateTime.TryParse(tbDOD.Text, out dod);
            card.PersCard_DOD = dod;

            DateTime dop;
            DateTime.TryParse(tbDOP.Text, out dop);
            card.PersCard_DOP = dop;

            for (int n = 0; n < dgvAddInfo.RowCount; n++)
            {
                AddInfo info = dgvAddInfo.Rows[n].DataBoundItem as AddInfo;
                if (info != null)
                {
                    switch (info.Id)
                    {
                        case 1:
                            {
                                int res = 0;
                                int.TryParse(info.Child.ToString(), out res);
                                card.PersCard_ChldM1 = res;
                            }
                            break;
                        case 2:
                            {
                                int res = 0;
                                int.TryParse(info.Child.ToString(), out res);
                                card.PersCard_ChldM2 = res;
                            }
                            break;
                        case 3:
                            {
                                int res = 0;
                                int.TryParse(info.Child.ToString(), out res);
                                card.PersCard_ChldM3 = res;
                            }
                            break;
                        case 4:
                            {
                                int res = 0;
                                int.TryParse(info.Child.ToString(), out res);
                                card.PersCard_ChldM4 = res;
                            }
                            break;
                        case 5:
                            {
                                int res = 0;
                                int.TryParse(info.Child.ToString(), out res);
                                card.PersCard_ChldM5 = res;
                            }
                            break;
                        case 6:
                            {
                                int res = 0;
                                int.TryParse(info.Child.ToString(), out res);
                                card.PersCard_ChldM6 = res;
                            }
                            break;
                        case 7:
                            {
                                int res = 0;
                                int.TryParse(info.Child.ToString(), out res);
                                card.PersCard_ChldM7 = res;
                            }
                            break;
                        case 8:
                            {
                                int res = 0;
                                int.TryParse(info.Child.ToString(), out res);
                                card.PersCard_ChldM8 = res;
                            }
                            break;
                        case 9:
                            {
                                int res = 0;
                                int.TryParse(info.Child.ToString(), out res);
                                card.PersCard_ChldM9 = res;
                            }
                            break;
                        case 10:
                            {
                                int res = 0;
                                int.TryParse(info.Child.ToString(), out res);
                                card.PersCard_ChldM10 = res;
                            }
                            break;
                        case 11:
                            {
                                int res = 0;
                                int.TryParse(info.Child.ToString(), out res);
                                card.PersCard_ChldM11 = res;
                            }
                            break;
                        case 12:
                            {
                                int res = 0;
                                int.TryParse(info.Child.ToString(), out res);
                                card.PersCard_ChldM12 = res;
                            }
                            break;
                    }
                }
            }
            return card;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!CanSaveCard())
                return;
            DialogResult = DialogResult.OK;
            Close();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
            Close();
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

            if (persCards == null) //Кеширование
                persCards = _repository.GetAllCards(out error);

            int duplTin = persCards.Where(card => card.PersCard_TIN == tbTIN.Text && card.PersCard_Id != id).Count();

            if(duplTin > 0)
            {
                tbTIN.SetToolTipe("Картка з таким ІПН вже існує");
                tbTIN.Focus();
                return;
            }

            DateTime dtDOB = CheckTIN.GetDateOfBirth(tbTIN.Text, out error);
            if (error == string.Empty)
            {
                tbDOB.Text = dtDOB.ToShortDateString();
                tbDOB.Refresh();
            }
        }

        private void fmPersCardEdit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }
    }
    public class AddInfo
    {
        public int Id { get; set; }
        public string MonthName { get; set; }
        public int? Child { get; set; }
    }
}
