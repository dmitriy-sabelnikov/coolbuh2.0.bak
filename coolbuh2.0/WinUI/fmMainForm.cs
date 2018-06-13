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
using BLL;
using DAL;
using WinUI.WinForms;

namespace WinUI
{
    public partial class fmMainForm : Form
    {
        //Настройка отображения дерева меню
        private void SetupStyleMainTreeView(TreeNodeCollection nodes)
        {
            foreach (TreeNode node in nodes)
            {
                if (node.Nodes.Count != 0)
                    SetupStyleMainTreeView(node.Nodes);

                if (node.Name == MainMenuName.MainMenu || node.Name == MainMenuName.Close)
                {
                    node.NodeFont = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0); ;
                    continue;
                }
                if (node.Name == MainMenuName.Service || node.Name == MainMenuName.Ref)
                { 
                    node.NodeFont = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
                    continue;
                }
                node.NodeFont = new Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            }
        }
        //Вход в модуль
        private void EnterToModules(string nameModule)
        {
            if(nameModule == MainMenuName.Salary)
            {
                fmSalary salary = new fmSalary(this);
                salary.ShowDialog();
            }
            else if (nameModule == MainMenuName.Vocation)
            {
                fmVocation vocation = new fmVocation(this);
                vocation.ShowDialog();

            }
            else if (nameModule == MainMenuName.SickList)
            {
                fmSickList sickList = new fmSickList(this);
                sickList.ShowDialog();
            }
            else if (nameModule == MainMenuName.LawContract)
            {
                fmLawContract lawContract = new fmLawContract(this);
                lawContract.ShowDialog();
            }
            else if (nameModule == MainMenuName.AddPay)
            {

            }
            else if (nameModule == MainMenuName.IncTax)
            {

            }
            else if (nameModule == MainMenuName.PersCard)
            {
                fmPersCard persCard = new fmPersCard(this);
                persCard.ShowDialog();
            }
            else if (nameModule == MainMenuName.RefDep)
            {
                fmRefDep refDep = new fmRefDep(this);
                refDep.ShowDialog();
            }
            else if (nameModule == MainMenuName.RefAdm)
            {
                fmRefAdm refAdm = new fmRefAdm(this);
                refAdm.ShowDialog();
            }
            else if (nameModule == MainMenuName.RefExpAllwnc)
            {
                fmRefExpAllwnc refExpAllwnc = new fmRefExpAllwnc(this);
                refExpAllwnc.ShowDialog();
            }
            else if (nameModule == MainMenuName.RefSpecExp)
            {
                fmRefSpecExp refSpecExp = new fmRefSpecExp(this);
                refSpecExp.ShowDialog();
            }
            else if (nameModule == MainMenuName.RefPensAllwnc)
            {
                fmRefPensAllwnc refPensAllwnc = new fmRefPensAllwnc(this);
                refPensAllwnc.ShowDialog();
            }
            else if (nameModule == MainMenuName.RefGradeAllwnc)
            {
                fmRefGradeAllwnc refGradeExp = new fmRefGradeAllwnc(this);
                refGradeExp.ShowDialog();
            }
            else if (nameModule == MainMenuName.RefOthAllwnc)
            {
                fmRefOthAllwnc refOthExp = new fmRefOthAllwnc(this);
                refOthExp.ShowDialog();
            }

            else if (nameModule == MainMenuName.ImportDB)
            {
                bool bRet = true;
                bRet = bRet && Service.ImportDB(SetupProgram.PathToDBFFile, SetupProgram.Connection);
                bRet = bRet && Service.RunSqlSript(SetupProgram.PathToSQLFile, SetupProgram.Connection);
            }
            else if(nameModule == MainMenuName.Setup)
            {
                fmSetup setup = new fmSetup(this);
                setup.ShowDialog();

            }
            else if(nameModule == MainMenuName.UpdateDB)
            {
                Service.UpdateServerObject(SetupProgram.Connection);
            }
            else if (nameModule == MainMenuName.Close)
            {
                Exit();
            }
            
        }
        //Выход
        private void Exit()
        {
            if (MessageBox.Show("Ви впевнені, що бажаєте вийти?", "Вихід", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Close();
        }
        //Событие нажатия клавиши Enter на главное дерево
        private void EventEnterNodeTreeView()
        {
            TreeNode selectedNode = tvMainMenu.SelectedNode;
            if (selectedNode.Nodes.Count != 0)
            {
                // Свернуть/развернуть родительские узлы
                if (selectedNode.IsExpanded)
                    selectedNode.Collapse();
                else
                    selectedNode.Expand();
            }
            else
            {
                // Вход в модуль
                EnterToModules(selectedNode.Name);
            }
        }

        private void tvMainMenu_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            //Разворачивание/сворачивание ветки меню обрабатывается автоматически при клике мышью
            TreeNode selectedNode = e.Node;
            if (selectedNode.Nodes.Count == 0)
            {
                EventEnterNodeTreeView();
            }
        }
        public fmMainForm()
        {
            InitializeComponent();
        }

        private void fmMainForm_Load(object sender, EventArgs e)
        {
            SetupStyleMainTreeView(tvMainMenu.Nodes);
        }

        private void tvMainMenu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                EventEnterNodeTreeView();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                Exit();
            }
        }
    }
}
