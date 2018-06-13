namespace WinUI.WinForms
{
    partial class fmPersCard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MenuPersCard = new System.Windows.Forms.MenuStrip();
            this.MenuStripRegister = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemCreate = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvPersCard = new System.Windows.Forms.DataGridView();
            this.PersCard_FName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersCard_MName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersCard_LName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersCard_TIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersCard_Exp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersCard_Grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersCard_DOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersCard_DOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersCard_DOD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersCard_DOP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MenuPersCard.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersCard)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuPersCard
            // 
            this.MenuPersCard.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuPersCard.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuStripRegister});
            this.MenuPersCard.Location = new System.Drawing.Point(0, 0);
            this.MenuPersCard.Name = "MenuPersCard";
            this.MenuPersCard.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.MenuPersCard.Size = new System.Drawing.Size(525, 24);
            this.MenuPersCard.TabIndex = 0;
            this.MenuPersCard.Text = "MenuPersCard";
            // 
            // MenuStripRegister
            // 
            this.MenuStripRegister.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemCreate,
            this.MenuItemEdit,
            this.MenuItemDelete,
            this.toolStripSeparator1,
            this.MenuItemRefresh,
            this.toolStripSeparator2,
            this.MenuItemExit});
            this.MenuStripRegister.Name = "MenuStripRegister";
            this.MenuStripRegister.Size = new System.Drawing.Size(56, 20);
            this.MenuStripRegister.Text = "Реєстр";
            // 
            // MenuItemCreate
            // 
            this.MenuItemCreate.Name = "MenuItemCreate";
            this.MenuItemCreate.ShortcutKeys = System.Windows.Forms.Keys.Insert;
            this.MenuItemCreate.Size = new System.Drawing.Size(148, 22);
            this.MenuItemCreate.Text = "Створити";
            this.MenuItemCreate.Click += new System.EventHandler(this.MenuItemCreate_Click);
            // 
            // MenuItemEdit
            // 
            this.MenuItemEdit.Name = "MenuItemEdit";
            this.MenuItemEdit.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.MenuItemEdit.Size = new System.Drawing.Size(148, 22);
            this.MenuItemEdit.Text = "Змінити";
            this.MenuItemEdit.Click += new System.EventHandler(this.MenuItemEdit_Click);
            // 
            // MenuItemDelete
            // 
            this.MenuItemDelete.Name = "MenuItemDelete";
            this.MenuItemDelete.ShortcutKeys = System.Windows.Forms.Keys.F8;
            this.MenuItemDelete.Size = new System.Drawing.Size(148, 22);
            this.MenuItemDelete.Text = "Видалити";
            this.MenuItemDelete.Click += new System.EventHandler(this.MenuItemDelete_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(145, 6);
            // 
            // MenuItemRefresh
            // 
            this.MenuItemRefresh.Name = "MenuItemRefresh";
            this.MenuItemRefresh.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.MenuItemRefresh.Size = new System.Drawing.Size(148, 22);
            this.MenuItemRefresh.Text = "Оновити";
            this.MenuItemRefresh.Click += new System.EventHandler(this.MenuItemRefresh_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(145, 6);
            // 
            // MenuItemExit
            // 
            this.MenuItemExit.Name = "MenuItemExit";
            this.MenuItemExit.ShortcutKeyDisplayString = "Esc";
            this.MenuItemExit.Size = new System.Drawing.Size(148, 22);
            this.MenuItemExit.Text = "Вихід";
            this.MenuItemExit.Click += new System.EventHandler(this.MenuItemExit_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvPersCard);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(525, 263);
            this.panel1.TabIndex = 1;
            // 
            // dgvPersCard
            // 
            this.dgvPersCard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersCard.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PersCard_FName,
            this.PersCard_MName,
            this.PersCard_LName,
            this.PersCard_TIN,
            this.PersCard_Exp,
            this.PersCard_Grade,
            this.PersCard_DOB,
            this.PersCard_DOR,
            this.PersCard_DOD,
            this.PersCard_DOP});
            this.dgvPersCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPersCard.Location = new System.Drawing.Point(0, 0);
            this.dgvPersCard.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPersCard.Name = "dgvPersCard";
            this.dgvPersCard.RowTemplate.Height = 24;
            this.dgvPersCard.Size = new System.Drawing.Size(525, 263);
            this.dgvPersCard.TabIndex = 0;
            this.dgvPersCard.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvPersCard_KeyDown);
            // 
            // PersCard_FName
            // 
            this.PersCard_FName.DataPropertyName = "PersCard_FName";
            this.PersCard_FName.HeaderText = "Ім\'я";
            this.PersCard_FName.Name = "PersCard_FName";
            // 
            // PersCard_MName
            // 
            this.PersCard_MName.DataPropertyName = "PersCard_MName";
            this.PersCard_MName.HeaderText = "По батькові";
            this.PersCard_MName.Name = "PersCard_MName";
            // 
            // PersCard_LName
            // 
            this.PersCard_LName.DataPropertyName = "PersCard_LName";
            this.PersCard_LName.HeaderText = "Прізвище";
            this.PersCard_LName.Name = "PersCard_LName";
            // 
            // PersCard_TIN
            // 
            this.PersCard_TIN.DataPropertyName = "PersCard_TIN";
            this.PersCard_TIN.HeaderText = "ІПН";
            this.PersCard_TIN.Name = "PersCard_TIN";
            // 
            // PersCard_Exp
            // 
            this.PersCard_Exp.DataPropertyName = "PersCard_Exp";
            this.PersCard_Exp.HeaderText = "Стаж";
            this.PersCard_Exp.Name = "PersCard_Exp";
            // 
            // PersCard_Grade
            // 
            this.PersCard_Grade.DataPropertyName = "PersCard_Grade";
            this.PersCard_Grade.HeaderText = "Класність";
            this.PersCard_Grade.Name = "PersCard_Grade";
            // 
            // PersCard_DOB
            // 
            this.PersCard_DOB.DataPropertyName = "PersCard_DOB";
            this.PersCard_DOB.HeaderText = "Дата народження";
            this.PersCard_DOB.Name = "PersCard_DOB";
            // 
            // PersCard_DOR
            // 
            this.PersCard_DOR.DataPropertyName = "PersCard_DOR";
            this.PersCard_DOR.HeaderText = "Дата прийому";
            this.PersCard_DOR.Name = "PersCard_DOR";
            // 
            // PersCard_DOD
            // 
            this.PersCard_DOD.DataPropertyName = "PersCard_DOD";
            this.PersCard_DOD.HeaderText = "Дата звільнення";
            this.PersCard_DOD.Name = "PersCard_DOD";
            // 
            // PersCard_DOP
            // 
            this.PersCard_DOP.DataPropertyName = "PersCard_DOP";
            this.PersCard_DOP.HeaderText = "Дата виходу на пенсію";
            this.PersCard_DOP.Name = "PersCard_DOP";
            // 
            // fmPersCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 287);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MenuPersCard);
            this.MainMenuStrip = this.MenuPersCard;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "fmPersCard";
            this.Text = "Картки обліку";
            this.Load += new System.EventHandler(this.fmPersCard_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fmPersCard_KeyDown);
            this.MenuPersCard.ResumeLayout(false);
            this.MenuPersCard.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersCard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuPersCard;
        private System.Windows.Forms.ToolStripMenuItem MenuStripRegister;
        private System.Windows.Forms.ToolStripMenuItem MenuItemCreate;
        private System.Windows.Forms.ToolStripMenuItem MenuItemEdit;
        private System.Windows.Forms.ToolStripMenuItem MenuItemDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem MenuItemRefresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem MenuItemExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvPersCard;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersCard_FName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersCard_MName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersCard_LName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersCard_TIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersCard_Exp;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersCard_Grade;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersCard_DOB;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersCard_DOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersCard_DOD;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersCard_DOP;
    }
}