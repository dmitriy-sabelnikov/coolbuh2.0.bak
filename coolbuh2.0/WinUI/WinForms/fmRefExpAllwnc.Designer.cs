namespace WinUI.WinForms
{
    partial class fmRefExpAllwnc
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
            this.MenuRefExpAllwnc = new System.Windows.Forms.MenuStrip();
            this.MenuStripRegister = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemCreate = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvRefExpAllwnc = new System.Windows.Forms.DataGridView();
            this.RefExpAllwnc_Cd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RefExpAllwnc_Nm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RefExpAllwnc_Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RefExpAllwnc_Mech = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RefExpAllwncMech_RefDep_Nm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RefExpAllwnc_Oth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RefExpAllwnc_Use = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.MenuRefExpAllwnc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRefExpAllwnc)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuRefExpAllwnc
            // 
            this.MenuRefExpAllwnc.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuRefExpAllwnc.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuStripRegister});
            this.MenuRefExpAllwnc.Location = new System.Drawing.Point(0, 0);
            this.MenuRefExpAllwnc.Name = "MenuRefExpAllwnc";
            this.MenuRefExpAllwnc.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.MenuRefExpAllwnc.Size = new System.Drawing.Size(775, 28);
            this.MenuRefExpAllwnc.TabIndex = 1;
            this.MenuRefExpAllwnc.Text = "MenuRefExpAllwnc";
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
            this.MenuItemCreate.Click += new System.EventHandler(this.MenuItemCreate_Click);
            // 
            // MenuItemEdit
            // 
            this.MenuItemEdit.Name = "MenuItemEdit";
            this.MenuItemEdit.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.MenuItemEdit.Size = new System.Drawing.Size(176, 26);
            this.MenuItemEdit.Text = "Змінити";
            this.MenuItemEdit.Click += new System.EventHandler(this.MenuItemEdit_Click);
            // 
            // MenuItemDelete
            // 
            this.MenuItemDelete.Name = "MenuItemDelete";
            this.MenuItemDelete.ShortcutKeys = System.Windows.Forms.Keys.F8;
            this.MenuItemDelete.Size = new System.Drawing.Size(176, 26);
            this.MenuItemDelete.Text = "Видалити";
            this.MenuItemDelete.Click += new System.EventHandler(this.MenuItemDelete_Click);
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
            this.MenuItemRefresh.Click += new System.EventHandler(this.MenuItemRefresh_Click);
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
            this.MenuItemExit.Click += new System.EventHandler(this.MenuItemExit_Click);
            // 
            // dgvRefExpAllwnc
            // 
            this.dgvRefExpAllwnc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRefExpAllwnc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RefExpAllwnc_Cd,
            this.RefExpAllwnc_Nm,
            this.RefExpAllwnc_Year,
            this.RefExpAllwnc_Mech,
            this.RefExpAllwncMech_RefDep_Nm,
            this.RefExpAllwnc_Oth,
            this.RefExpAllwnc_Use});
            this.dgvRefExpAllwnc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRefExpAllwnc.Location = new System.Drawing.Point(0, 28);
            this.dgvRefExpAllwnc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvRefExpAllwnc.Name = "dgvRefExpAllwnc";
            this.dgvRefExpAllwnc.RowTemplate.Height = 24;
            this.dgvRefExpAllwnc.Size = new System.Drawing.Size(775, 438);
            this.dgvRefExpAllwnc.TabIndex = 3;
            this.dgvRefExpAllwnc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvRefExpAllwnc_KeyDown);
            // 
            // RefExpAllwnc_Cd
            // 
            this.RefExpAllwnc_Cd.DataPropertyName = "RefExpAllwnc_Cd";
            this.RefExpAllwnc_Cd.HeaderText = "Код";
            this.RefExpAllwnc_Cd.Name = "RefExpAllwnc_Cd";
            // 
            // RefExpAllwnc_Nm
            // 
            this.RefExpAllwnc_Nm.DataPropertyName = "RefExpAllwnc_Nm";
            this.RefExpAllwnc_Nm.HeaderText = "Найменування";
            this.RefExpAllwnc_Nm.Name = "RefExpAllwnc_Nm";
            // 
            // RefExpAllwnc_Year
            // 
            this.RefExpAllwnc_Year.DataPropertyName = "RefExpAllwnc_Year";
            this.RefExpAllwnc_Year.HeaderText = "Рік";
            this.RefExpAllwnc_Year.Name = "RefExpAllwnc_Year";
            // 
            // RefExpAllwnc_Mech
            // 
            this.RefExpAllwnc_Mech.DataPropertyName = "RefExpAllwnc_Mech";
            this.RefExpAllwnc_Mech.HeaderText = "Відсоток механикам";
            this.RefExpAllwnc_Mech.Name = "RefExpAllwnc_Mech";
            // 
            // RefExpAllwncMech_RefDep_Nm
            // 
            this.RefExpAllwncMech_RefDep_Nm.DataPropertyName = "RefExpAllwncMech_RefDep_Nm";
            this.RefExpAllwncMech_RefDep_Nm.HeaderText = "Підрозділ механиків";
            this.RefExpAllwncMech_RefDep_Nm.Name = "RefExpAllwncMech_RefDep_Nm";
            // 
            // RefExpAllwnc_Oth
            // 
            this.RefExpAllwnc_Oth.DataPropertyName = "RefExpAllwnc_Oth";
            this.RefExpAllwnc_Oth.HeaderText = "Відсоток іншим";
            this.RefExpAllwnc_Oth.Name = "RefExpAllwnc_Oth";
            // 
            // RefExpAllwnc_Use
            // 
            this.RefExpAllwnc_Use.DataPropertyName = "RefExpAllwnc_Use";
            this.RefExpAllwnc_Use.FalseValue = "0";
            this.RefExpAllwnc_Use.HeaderText = "Використовувати";
            this.RefExpAllwnc_Use.Name = "RefExpAllwnc_Use";
            this.RefExpAllwnc_Use.TrueValue = "1";
            // 
            // fmRefExpAllwnc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 466);
            this.Controls.Add(this.dgvRefExpAllwnc);
            this.Controls.Add(this.MenuRefExpAllwnc);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "fmRefExpAllwnc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "fmRefExpAllwnc";
            this.Load += new System.EventHandler(this.fmRefExpAllwnc_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fmRefExpAllwnc_KeyDown);
            this.MenuRefExpAllwnc.ResumeLayout(false);
            this.MenuRefExpAllwnc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRefExpAllwnc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuRefExpAllwnc;
        private System.Windows.Forms.ToolStripMenuItem MenuStripRegister;
        private System.Windows.Forms.ToolStripMenuItem MenuItemCreate;
        private System.Windows.Forms.ToolStripMenuItem MenuItemEdit;
        private System.Windows.Forms.ToolStripMenuItem MenuItemDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem MenuItemRefresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem MenuItemExit;
        private System.Windows.Forms.DataGridView dgvRefExpAllwnc;
        private System.Windows.Forms.DataGridViewTextBoxColumn RefExpAllwnc_Cd;
        private System.Windows.Forms.DataGridViewTextBoxColumn RefExpAllwnc_Nm;
        private System.Windows.Forms.DataGridViewTextBoxColumn RefExpAllwnc_Year;
        private System.Windows.Forms.DataGridViewTextBoxColumn RefExpAllwnc_Mech;
        private System.Windows.Forms.DataGridViewTextBoxColumn RefExpAllwncMech_RefDep_Nm;
        private System.Windows.Forms.DataGridViewTextBoxColumn RefExpAllwnc_Oth;
        private System.Windows.Forms.DataGridViewCheckBoxColumn RefExpAllwnc_Use;
    }
}