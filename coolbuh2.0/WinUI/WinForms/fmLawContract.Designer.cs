namespace WinUI.WinForms
{
    partial class fmLawContract
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
            this.MenuStripView = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemDeps = new System.Windows.Forms.ToolStripMenuItem();
            this.horizontal_pnl = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCalendar = new System.Windows.Forms.ComboBox();
            this.left_pnl = new System.Windows.Forms.Panel();
            this.dgvDep = new System.Windows.Forms.DataGridView();
            this.DepName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.rigth_pnl = new System.Windows.Forms.Panel();
            this.dgvLawContract = new System.Windows.Forms.DataGridView();
            this.MenuPersCard.SuspendLayout();
            this.horizontal_pnl.SuspendLayout();
            this.left_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDep)).BeginInit();
            this.rigth_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLawContract)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuPersCard
            // 
            this.MenuPersCard.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuPersCard.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuStripRegister,
            this.MenuStripView});
            this.MenuPersCard.Location = new System.Drawing.Point(0, 0);
            this.MenuPersCard.Name = "MenuPersCard";
            this.MenuPersCard.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.MenuPersCard.Size = new System.Drawing.Size(792, 28);
            this.MenuPersCard.TabIndex = 3;
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
            this.MenuStripRegister.Size = new System.Drawing.Size(66, 24);
            this.MenuStripRegister.Text = "Реєстр";
            // 
            // MenuItemCreate
            // 
            this.MenuItemCreate.Name = "MenuItemCreate";
            this.MenuItemCreate.ShortcutKeys = System.Windows.Forms.Keys.Insert;
            this.MenuItemCreate.Size = new System.Drawing.Size(176, 26);
            this.MenuItemCreate.Text = "Створити";
            // 
            // MenuItemEdit
            // 
            this.MenuItemEdit.Name = "MenuItemEdit";
            this.MenuItemEdit.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.MenuItemEdit.Size = new System.Drawing.Size(176, 26);
            this.MenuItemEdit.Text = "Змінити";
            // 
            // MenuItemDelete
            // 
            this.MenuItemDelete.Name = "MenuItemDelete";
            this.MenuItemDelete.ShortcutKeys = System.Windows.Forms.Keys.F8;
            this.MenuItemDelete.Size = new System.Drawing.Size(176, 26);
            this.MenuItemDelete.Text = "Видалити";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(173, 6);
            // 
            // MenuItemRefresh
            // 
            this.MenuItemRefresh.Name = "MenuItemRefresh";
            this.MenuItemRefresh.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.MenuItemRefresh.Size = new System.Drawing.Size(176, 26);
            this.MenuItemRefresh.Text = "Оновити";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(173, 6);
            // 
            // MenuItemExit
            // 
            this.MenuItemExit.Name = "MenuItemExit";
            this.MenuItemExit.ShortcutKeyDisplayString = "Esc";
            this.MenuItemExit.Size = new System.Drawing.Size(176, 26);
            this.MenuItemExit.Text = "Вихід";
            // 
            // MenuStripView
            // 
            this.MenuStripView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemDeps});
            this.MenuStripView.Name = "MenuStripView";
            this.MenuStripView.Size = new System.Drawing.Size(47, 24);
            this.MenuStripView.Text = "Вид";
            // 
            // MenuItemDeps
            // 
            this.MenuItemDeps.Checked = true;
            this.MenuItemDeps.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MenuItemDeps.Name = "MenuItemDeps";
            this.MenuItemDeps.Size = new System.Drawing.Size(235, 26);
            this.MenuItemDeps.Text = "Навігатор підрозділів";
            // 
            // horizontal_pnl
            // 
            this.horizontal_pnl.Controls.Add(this.label1);
            this.horizontal_pnl.Controls.Add(this.cmbCalendar);
            this.horizontal_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.horizontal_pnl.Location = new System.Drawing.Point(0, 28);
            this.horizontal_pnl.Margin = new System.Windows.Forms.Padding(4);
            this.horizontal_pnl.Name = "horizontal_pnl";
            this.horizontal_pnl.Size = new System.Drawing.Size(792, 38);
            this.horizontal_pnl.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Період:";
            // 
            // cmbCalendar
            // 
            this.cmbCalendar.FormattingEnabled = true;
            this.cmbCalendar.Location = new System.Drawing.Point(68, 4);
            this.cmbCalendar.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCalendar.Name = "cmbCalendar";
            this.cmbCalendar.Size = new System.Drawing.Size(211, 24);
            this.cmbCalendar.TabIndex = 0;
            // 
            // left_pnl
            // 
            this.left_pnl.Controls.Add(this.dgvDep);
            this.left_pnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.left_pnl.Location = new System.Drawing.Point(0, 66);
            this.left_pnl.Margin = new System.Windows.Forms.Padding(4);
            this.left_pnl.Name = "left_pnl";
            this.left_pnl.Size = new System.Drawing.Size(280, 412);
            this.left_pnl.TabIndex = 5;
            // 
            // dgvDep
            // 
            this.dgvDep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDep.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DepName});
            this.dgvDep.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDep.Location = new System.Drawing.Point(0, 0);
            this.dgvDep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDep.Name = "dgvDep";
            this.dgvDep.RowTemplate.Height = 24;
            this.dgvDep.Size = new System.Drawing.Size(280, 412);
            this.dgvDep.TabIndex = 2;
            // 
            // DepName
            // 
            this.DepName.DataPropertyName = "Name";
            this.DepName.HeaderText = "Найменування";
            this.DepName.Name = "DepName";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(280, 66);
            this.splitter1.Margin = new System.Windows.Forms.Padding(4);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1, 412);
            this.splitter1.TabIndex = 6;
            this.splitter1.TabStop = false;
            // 
            // rigth_pnl
            // 
            this.rigth_pnl.Controls.Add(this.dgvLawContract);
            this.rigth_pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rigth_pnl.Location = new System.Drawing.Point(281, 66);
            this.rigth_pnl.Margin = new System.Windows.Forms.Padding(4);
            this.rigth_pnl.Name = "rigth_pnl";
            this.rigth_pnl.Size = new System.Drawing.Size(511, 412);
            this.rigth_pnl.TabIndex = 7;
            // 
            // dgvLawContract
            // 
            this.dgvLawContract.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLawContract.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLawContract.Location = new System.Drawing.Point(0, 0);
            this.dgvLawContract.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvLawContract.Name = "dgvLawContract";
            this.dgvLawContract.RowTemplate.Height = 24;
            this.dgvLawContract.Size = new System.Drawing.Size(511, 412);
            this.dgvLawContract.TabIndex = 1;
            // 
            // fmLawContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 478);
            this.Controls.Add(this.rigth_pnl);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.left_pnl);
            this.Controls.Add(this.horizontal_pnl);
            this.Controls.Add(this.MenuPersCard);
            this.Name = "fmLawContract";
            this.Text = "Договора ЦПХ";
            this.MenuPersCard.ResumeLayout(false);
            this.MenuPersCard.PerformLayout();
            this.horizontal_pnl.ResumeLayout(false);
            this.horizontal_pnl.PerformLayout();
            this.left_pnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDep)).EndInit();
            this.rigth_pnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLawContract)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem MenuStripView;
        private System.Windows.Forms.ToolStripMenuItem MenuItemDeps;
        private System.Windows.Forms.Panel horizontal_pnl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCalendar;
        private System.Windows.Forms.Panel left_pnl;
        private System.Windows.Forms.DataGridView dgvDep;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepName;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel rigth_pnl;
        private System.Windows.Forms.DataGridView dgvLawContract;
    }
}