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
using DAL;
using BLL;
using WinUI.Helper;
using WinFormExtensions;
using EnumType;

namespace WinUI.WinForms
{
    public partial class fmPersCard : Form
    {
        private List<PersCard> persCards = null; //Кеширование
        private PersCardRepository _repository = new PersCardRepository(SetupProgram.Connection);

        //Вставка строки
        private void InsertRecord()
        {
            fmPersCardEdit fmEdit = new fmPersCardEdit(EnumFormMode.Insert, "Створення картки");
            if (fmEdit.ShowDialog() == DialogResult.OK)
            {
                string error;
                PersCard card = fmEdit.GetData();

                if (!_repository.AddCard(card, out error))
                {
                    MessageBox.Show("Помилка додавання картки.\nТехнічна інформація: " + error, "Помилка");
                    return;
                }
                RefreshTable();
            }
        }
        //Обновление строки
        private void UpdateRecord()
        {
            if (dgvPersCard.CurrentRow == null) return;
            PersCard persCard = dgvPersCard.CurrentRow.DataBoundItem as PersCard;
            if (persCard == null)
            {
                MessageBox.Show("Не знайдена картка для оновлення", "Помилка");
                return;
            }
            fmPersCardEdit fmEdit = new fmPersCardEdit(EnumFormMode.Edit, "Зміна картки");
            fmEdit.SetData(persCard);
            if (fmEdit.ShowDialog() == DialogResult.OK)
            {
                persCard = fmEdit.GetData();
                string error;
                if (!_repository.ModifyCard(persCard, out error))
                {
                    MessageBox.Show("Помилка оновлення картки.\nТехнічна інформація: " + error, "Помилка");
                    return;
                }
                RefreshTable();
            }
        }
        //Физическое удаление строки
        private void DeleteRecord()
        {
            List<PersCard> checkedCard = dgvPersCard.GetCheckedRecords<PersCard>();
            if(checkedCard.Count > 0)
            {
                if (MessageBox.Show("Ви впевнені, що бажаєте видалити обрані картки обліку?", "Видалення", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Coffee.Init("Видалення карток");
                    foreach (PersCard card in checkedCard)
                    {
                        string error;
                        if (!_repository.DeleteCard(card.PersCard_Id, out error))
                        {
                            MessageBox.Show("Помилка видалення.\nТехнічна інформація: " + error, "Помилка");
                            break;
                        }

                    }
                    Coffee.Term();
                    RefreshTable();
                }
            }
            else
            {
                if (dgvPersCard.CurrentRow == null) return;
                if (MessageBox.Show("Ви впевнені, що бажаєте видалити картку обліку?", "Видалення", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;
                PersCard persCard = dgvPersCard.CurrentRow.DataBoundItem as PersCard;
                if (persCard == null)
                {
                    MessageBox.Show("Не знайдена картка для видалення", "Помилка");
                    return;
                }
                string error;
                if (!_repository.DeleteCard(persCard.PersCard_Id, out error))
                {
                    MessageBox.Show("Помилка видалення.\nТехнічна інформація: " + error, "Помилка");
                    return;
                }
                RefreshTable();
            }
        }
        //Перезачитать данные таблицы
        private void RefreshTable()
        {
            dgvPersCard.StorePosition();
            string error;
            persCards = _repository.GetAllCards(out error);
            if (error != string.Empty)
            {
                MessageBox.Show("Помилка оновлення таблиці.\nТехнічна інформація: " + error, "Помилка");
                return;
            }
            dgvPersCard.DataSource = persCards;
            dgvPersCard.RestPosition();
        }
        //Инициализация грида
        private void InitGrid()
        {
            dgvPersCard.BaseGrigStyle();
            dgvPersCard.AddBirdColumn();
            dgvPersCard.AddRefreshMenu(RefreshMenu);
            dgvPersCard.AddSortGrid(SortGrid);
            string error;
            persCards = _repository.GetAllCards(out error);
            if (error != string.Empty)
            {
                MessageBox.Show("Помилка ініціалізації.\nТехнічна інформація: " + error, "Помилка");
                return;
            }
            dgvPersCard.DataSource = persCards;
        }
        //Обновить меню
        private void RefreshMenu()
        {
            bool isEnableMenu = dgvPersCard.CurrentRow == null ? false : true;
            MenuItemCreate.Enabled = true;
            MenuItemEdit.Enabled = isEnableMenu;
            MenuItemDelete.Enabled = isEnableMenu;
        }
        //Функция сортировки грида
        private void SortGrid(DataGridViewCellMouseEventArgs e)
        {
            string strColumnName = dgvPersCard.Columns[e.ColumnIndex].Name;
            SortOrder strSortOrder = dgvPersCard.getSortOrder(e.ColumnIndex);

            if (strSortOrder == SortOrder.Ascending)
            {
                persCards = persCards.OrderBy(x => typeof(PersCard).GetProperty(strColumnName).GetValue(x, null)).ToList();
            }
            else
            if (strSortOrder == SortOrder.Descending)
            {
                persCards = persCards.OrderByDescending(x => typeof(PersCard).GetProperty(strColumnName).GetValue(x, null)).ToList();
            }
            if (strSortOrder == SortOrder.None)
            {
                persCards = persCards.OrderBy(x => typeof(PersCard).GetProperty("PersCard_Id").GetValue(x, null)).ToList();
            }
            dgvPersCard.DataSource = persCards;
            dgvPersCard.Columns[e.ColumnIndex].HeaderCell.SortGlyphDirection = strSortOrder;
        }
        public fmPersCard(Form owner)
        {
            this.SingleFormMode(owner);
            InitializeComponent();
        }

        private void fmPersCard_Load(object sender, EventArgs e)
        {
            InitGrid();
        }

        private void fmPersCard_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }
        private void dgvPersCard_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }
        //--------------------События меню----------------------------
        private void MenuItemCreate_Click(object sender, EventArgs e)
        {
            InsertRecord();
        }

        private void MenuItemEdit_Click(object sender, EventArgs e)
        {
            UpdateRecord();
        }

        private void MenuItemDelete_Click(object sender, EventArgs e)
        {
            DeleteRecord();
        }

        private void MenuItemRefresh_Click(object sender, EventArgs e)
        {
            RefreshTable();
        }

        private void MenuItemExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        //----------------------------------------------------------
    }
}
