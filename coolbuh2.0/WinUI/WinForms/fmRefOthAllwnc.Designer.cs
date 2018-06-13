namespace WinUI.WinForms
{
    partial class fmRefOthAllwnc
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
            this.dgvOthAllwnc = new System.Windows.Forms.DataGridView();
            this.RefOthAllwnc_Cd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RefOthAllwnc_Nm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RefOthAllwnc_Pct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Використовувати = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.MenuAllowance = new System.Windows.Forms.MenuStrip();
            this.MenuStripRegister = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemCreate = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOthAllwnc)).BeginInit();
            this.MenuAllowance.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvOthAllwnc
            // 
            this.dgvOthAllwnc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOthAllwnc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RefOthAllwnc_Cd,
            this.RefOthAllwnc_Nm,
            this.RefOthAllwnc_Pct,
            this.Використовувати});
            this.dgvOthAllwnc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOthAllwnc.Location = new System.Drawing.Point(0, 24);
            this.dgvOthAllwnc.Margin = new System.Windows.Forms.Padding(2);
            this.dgvOthAllwnc.Name = "dgvOthAllwnc";
            this.dgvOthAllwnc.RowTemplate.Height = 24;
            this.dgvOthAllwnc.Size = new System.Drawing.Size(602, 388);
            this.dgvOthAllwnc.TabIndex = 5;
            this.dgvOthAllwnc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvOthAllwnc_KeyDown);
            // 
            // RefOthAllwnc_Cd
            // 
            this.RefOthAllwnc_Cd.DataPropertyName = "RefOthAllwnc_Cd";
            this.RefOthAllwnc_Cd.HeaderText = "Код";
            this.RefOthAllwnc_Cd.Name = "RefOthAllwnc_Cd";
            // 
            // RefOthAllwnc_Nm
            // 
            this.RefOthAllwnc_Nm.DataPropertyName = "RefOthAllwnc_Nm";
            this.RefOthAllwnc_Nm.HeaderText = "Найменування";
            this.RefOthAllwnc_Nm.Name = "RefOthAllwnc_Nm";
            // 
            // RefOthAllwnc_Pct
            // 
            this.RefOthAllwnc_Pct.DataPropertyName = "RefOthAllwnc_Pct";
            this.RefOthAllwnc_Pct.HeaderText = "Відсоток";
            this.RefOthAllwnc_Pct.Name = "RefOthAllwnc_Pct";
            // 
            // Використовувати
            // 
            this.Використовувати.DataPropertyName = "RefOthAllwnc_Use";
            this.Використовувати.FalseValue = "1";
            this.Використовувати.HeaderText = "Використовувати";
            this.Використовувати.Name = "Використовувати";
            this.Використовувати.TrueValue = "0";
            // 
            // MenuAllowance
            // 
            this.MenuAllowance.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuAllowance.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuStripRegister});
            this.MenuAllowance.Location = new System.Drawing.Point(0, 0);
            this.MenuAllowance.Name = "MenuAllowance";
            this.MenuAllowance.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.MenuAllowance.Size = new System.Drawing.Size(602, 24);
            this.MenuAllowance.TabIndex = 4;
            this.MenuAllowance.Text = "MenuAllowance";
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
            this.MenuItemCreate.Size = new System.Drawing.Size(152, 22);
            this.MenuItemCreate.Text = "Створити";
            this.MenuItemCreate.Click += new System.EventHandler(this.MenuItemCreate_Click);
            // 
            // MenuItemEdit
            // 
            this.MenuItemEdit.Name = "MenuItemEdit";
            this.MenuItemEdit.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.MenuItemEdit.Size = new System.Drawing.Size(152, 22);
            this.MenuItemEdit.Text = "Змінити";
            this.MenuItemEdit.Click += new System.EventHandler(this.MenuItemEdit_Click);
            // 
            // MenuItemDelete
            // 
            this.MenuItemDelete.Name = "MenuItemDelete";
            this.MenuItemDelete.ShortcutKeys = System.Windows.Forms.Keys.F8;
            this.MenuItemDelete.Size = new System.Drawing.Size(152, 22);
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
            this.MenuItemRefresh.Size = new System.Drawing.Size(152, 22);
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
            this.MenuItemExit.Size = new System.Drawing.Size(152, 22);
            this.MenuItemExit.Text = "Вихід";
            this.MenuItemExit.Click += new System.EventHandler(this.MenuItemExit_Click);
            // 
            // fmRefOthAllwnc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 412);
            this.Controls.Add(this.dgvOthAllwnc);
            this.Controls.Add(this.MenuAllowance);
            this.Name = "fmRefOthAllwnc";
            this.Text = "fmRefOthAllwnc";
            this.Load += new System.EventHandler(this.fmRefOthAllwnc_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fmRefOthAllwnc_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOthAllwnc)).EndInit();
            this.MenuAllowance.ResumeLayout(false);
            this.MenuAllowance.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOthAllwnc;
        private System.Windows.Forms.MenuStrip MenuAllowance;
        private System.Windows.Forms.ToolStripMenuItem MenuStripRegister;
        private System.Windows.Forms.ToolStripMenuItem MenuItemCreate;
        private System.Windows.Forms.ToolStripMenuItem MenuItemEdit;
        private System.Windows.Forms.ToolStripMenuItem MenuItemDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem MenuItemRefresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem MenuItemExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn RefOthAllwnc_Cd;
        private System.Windows.Forms.DataGridViewTextBoxColumn RefOthAllwnc_Nm;
        private System.Windows.Forms.DataGridViewTextBoxColumn RefOthAllwnc_Pct;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Використовувати;
    }
}