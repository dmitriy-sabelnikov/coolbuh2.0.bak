using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Drawing;

namespace WinFormExtensions
{
    public static class DataGridViewExtension
    {
        private static int posY { get; set; }
        private static int posX { get; set; }
        //Сохранить позицию курсора
        public static void StorePosition(this DataGridView dgv)
        {
            posY = dgv.CurrentCell != null ? dgv.CurrentCell.ColumnIndex : 0;
            posX = dgv.CurrentRow != null ? dgv.CurrentRow.Index : 0;
        }
        //Восстановить позицию курсора
        public static void RestPosition(this DataGridView dgv)
        {
            if (dgv.RowCount == 0)
                return;
            int restoreX = 0;
            int restoreY = 0;

            if (dgv.RowCount < posX)
                restoreX = dgv.RowCount - 1;

            if (posX < 0)
                restoreX = 0;
            else if (dgv.RowCount <= posX)
                restoreX = dgv.RowCount - 1;
            else
                restoreX = posX;

            if (posY < 0)
                restoreY = 0;
            else if (dgv.ColumnCount < posY)
                restoreY = dgv.ColumnCount - 1;
            else
                restoreY = posY;
            //Проверка на видимость колонки
            if (dgv.Columns[restoreY].Visible == false)
            {
                //поиск первого видимого столбца
                for (int col = 0; col < dgv.ColumnCount; col++)
                {
                    if (dgv.Columns[col].Visible)
                    {
                        restoreY = col;
                        break;
                    }
                }
            }

            dgv.CurrentCell = dgv.Rows[restoreX].Cells[restoreY];
        }
        //Получить индекс колонки по наименованию
        public static int GetIndexIdGrid(this DataGridView dgv, string id_name)
        {
            int index_id = -1;
            for (int i = 0; i < dgv.ColumnCount; i++)
            {
                if (dgv.Columns[i].Name == id_name)
                {
                    index_id = i;
                    return index_id;
                }
            }
            return index_id;
        }
        public static void AddSortGrid(this DataGridView dgv, Action<DataGridViewCellMouseEventArgs> sort)
        {
            dgv.ColumnHeaderMouseClick += (object sender, DataGridViewCellMouseEventArgs e) =>
            {
                sort(e);
            };
        }

        public static SortOrder getSortOrder(this DataGridView dgv, int columnIndex)
        {
            bool isTextBoxClmn = dgv.Columns[columnIndex] is DataGridViewTextBoxColumn;

            if (dgv.Columns[columnIndex].HeaderCell.SortGlyphDirection == SortOrder.Descending || isTextBoxClmn == false)
            {
                dgv.Columns[columnIndex].HeaderCell.SortGlyphDirection = SortOrder.None;
                return SortOrder.None;
            }
            else if (dgv.Columns[columnIndex].HeaderCell.SortGlyphDirection == SortOrder.None)
            {
                dgv.Columns[columnIndex].HeaderCell.SortGlyphDirection = SortOrder.Ascending;
                return SortOrder.Ascending;
            }
            else if (dgv.Columns[columnIndex].HeaderCell.SortGlyphDirection == SortOrder.Ascending)
            {
                dgv.Columns[columnIndex].HeaderCell.SortGlyphDirection = SortOrder.Descending;
                return SortOrder.Descending;
            }
            return SortOrder.None;
        }
        //Обновление меню
        public static void AddRefreshMenu(this DataGridView dgv, Action refreshMenu)
        {
            dgv.Paint += (object sender, PaintEventArgs e) =>
            {
                refreshMenu();
            };
            dgv.Click += (object sender, EventArgs e) =>
            {
                refreshMenu();
            };
        }
        //Добавление колонки "Птичка" в таблицу
        public static void AddBirdColumn(this DataGridView dgv)
        {
            DataGridViewCheckBoxColumn birdColumn = new DataGridViewCheckBoxColumn();
            birdColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            birdColumn.Name = "Bird";
            birdColumn.HeaderText = string.Empty;
            birdColumn.DisplayIndex = 0;
            birdColumn.ReadOnly = false;
            dgv.Columns.Add(birdColumn);
            dgv.KeyDown += (object sender, KeyEventArgs e) =>
            {
                if (e.KeyCode == Keys.Space)
                {
                    int index_bird = dgv.GetIndexIdGrid("Bird");
                    if (index_bird >= 0)
                        dgv.CurrentRow.Cells[index_bird].Value = dgv.CurrentRow.Cells[index_bird].Value == null ? (object)true : null;
                }
            };
            dgv.Click += (object sender, EventArgs e) =>
            {
                if (dgv.CurrentCell == null) return;
                int index_bird = dgv.GetIndexIdGrid("Bird");
                if (dgv.CurrentCell.ColumnIndex == index_bird)
                {
                    dgv.CurrentRow.Cells[index_bird].Value = dgv.CurrentRow.Cells[index_bird].Value == null ? (object)true : null;
                }
            };
        }

        //Стандартная настройка стиля таблицы 
        public static void BaseGrigStyle(this DataGridView dgv)
        {
            dgv.MultiSelect = false;
            dgv.RowHeadersVisible = false;
            dgv.AllowUserToAddRows = false;
            dgv.AutoGenerateColumns = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.BackgroundColor = Color.White;
            dgv.ReadOnly = true;
            dgv.ScrollBars = ScrollBars.Horizontal;
            //dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.DefaultCellStyle.SelectionBackColor = SystemColors.GradientInactiveCaption;
            dgv.DefaultCellStyle.SelectionForeColor = Color.DarkBlue;
            dgv.DefaultCellStyle.Font = new Font("Arial", 12F, GraphicsUnit.Pixel);
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dgv.DoubleBuffered(true);
        }

        public static List<T> GetCheckedRecords<T>(this DataGridView dgv)
            where T : class 
        {
            List<T> checkedBird = new List<T>();
            int index_bird = dgv.GetIndexIdGrid("Bird");
            if (index_bird == -1)
                return checkedBird;
            dgv.StorePosition();
            for (int i = 0; i < dgv.RowCount; i++)
            {
                if (dgv.Rows[i].Cells[index_bird].Value != null)
                    checkedBird.Add(dgv.Rows[i].DataBoundItem as T);
            }
            dgv.RestPosition();
            return checkedBird;
        }

        public static void DoubleBuffered(this DataGridView dgv, bool setting)
        {
            Type dgvType = dgv.GetType();
            PropertyInfo pi = dgvType.GetProperty("DoubleBuffered",
                  BindingFlags.Instance | BindingFlags.NonPublic);
            pi.SetValue(dgv, setting, null);
        }

        public static void IsModifyField(this DataGridView dgv, Action isModify)
        {
            dgv.CellValueChanged +=(object sender, DataGridViewCellEventArgs e) =>
            {
                isModify();
            };
        }

        /*

public static void AddSortGrid2<T>(this DataGridView dgv, List<T> list, string nameFieldId)
{
    if (list == null) return;
    dgv.ColumnHeaderMouseClick += (object sender, DataGridViewCellMouseEventArgs e) =>
    {
        string strColumnName = dgv.Columns[e.ColumnIndex].Name;
        SortOrder strSortOrder = dgv.getSortOrder(e.ColumnIndex);
        if (strSortOrder == SortOrder.Ascending)
        {
            list = list.OrderBy(x => typeof(T).GetProperty(strColumnName).GetValue(x, null)).ToList();
        }
        if (strSortOrder == SortOrder.Descending)
        {
            list = list.OrderByDescending(x => typeof(T).GetProperty(strColumnName).GetValue(x, null)).ToList();
        }
        if (strSortOrder == SortOrder.None)
        {
            list = list.OrderBy(x => typeof(T).GetProperty(nameFieldId).GetValue(x, null)).ToList();
        }
        dgv.DataSource = list;
        dgv.Columns[e.ColumnIndex].HeaderCell.SortGlyphDirection = strSortOrder;
    };
}
 */
    }
}
