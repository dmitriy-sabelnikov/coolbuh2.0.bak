namespace ComboBoxes.WinWorms
{
    partial class fmCmbDep
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
            this.pnl2 = new System.Windows.Forms.Panel();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnl1 = new System.Windows.Forms.Panel();
            this.dgvCmbDep = new System.Windows.Forms.DataGridView();
            this.MenuRefAdm = new System.Windows.Forms.MenuStrip();
            this.MenuStripRegister = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemChoose = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.RefDep_Cd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RefDep_Nm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl2.SuspendLayout();
            this.pnl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCmbDep)).BeginInit();
            this.MenuRefAdm.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl2
            // 
            this.pnl2.Controls.Add(this.btnOk);
            this.pnl2.Controls.Add(this.btnCancel);
            this.pnl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl2.Location = new System.Drawing.Point(0, 354);
            this.pnl2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnl2.Name = "pnl2";
            this.pnl2.Size = new System.Drawing.Size(455, 48);
            this.pnl2.TabIndex = 11;
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(229, 10);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(100, 28);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(337, 10);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 28);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Відміна";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // pnl1
            // 
            this.pnl1.Controls.Add(this.dgvCmbDep);
            this.pnl1.Controls.Add(this.MenuRefAdm);
            this.pnl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl1.Location = new System.Drawing.Point(0, 0);
            this.pnl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(455, 354);
            this.pnl1.TabIndex = 10;
            // 
            // dgvCmbDep
            // 
            this.dgvCmbDep.AllowUserToAddRows = false;
            this.dgvCmbDep.AllowUserToDeleteRows = false;
            this.dgvCmbDep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCmbDep.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RefDep_Cd,
            this.RefDep_Nm});
            this.dgvCmbDep.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCmbDep.Location = new System.Drawing.Point(0, 28);
            this.dgvCmbDep.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvCmbDep.Name = "dgvCmbDep";
            this.dgvCmbDep.ReadOnly = true;
            this.dgvCmbDep.Size = new System.Drawing.Size(455, 326);
            this.dgvCmbDep.TabIndex = 5;
            this.dgvCmbDep.DoubleClick += new System.EventHandler(this.dgvCmbDep_DoubleClick);
            this.dgvCmbDep.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvCmbDep_KeyDown);
            // 
            // MenuRefAdm
            // 
            this.MenuRefAdm.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuRefAdm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuStripRegister});
            this.MenuRefAdm.Location = new System.Drawing.Point(0, 0);
            this.MenuRefAdm.Name = "MenuRefAdm";
            this.MenuRefAdm.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.MenuRefAdm.Size = new System.Drawing.Size(455, 28);
            this.MenuRefAdm.TabIndex = 4;
            this.MenuRefAdm.Text = "MenuRefAdm";
            // 
            // MenuStripRegister
            // 
            this.MenuStripRegister.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemChoose,
            this.toolStripSeparator2,
            this.MenuItemExit});
            this.MenuStripRegister.Name = "MenuStripRegister";
            this.MenuStripRegister.Size = new System.Drawing.Size(66, 24);
            this.MenuStripRegister.Text = "Реєстр";
            // 
            // MenuItemChoose
            // 
            this.MenuItemChoose.Name = "MenuItemChoose";
            this.MenuItemChoose.ShortcutKeyDisplayString = "Enter";
            this.MenuItemChoose.Size = new System.Drawing.Size(186, 26);
            this.MenuItemChoose.Text = "Вибрати";
            this.MenuItemChoose.Click += new System.EventHandler(this.MenuItemChoose_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(183, 6);
            // 
            // MenuItemExit
            // 
            this.MenuItemExit.Name = "MenuItemExit";
            this.MenuItemExit.ShortcutKeyDisplayString = "Esc";
            this.MenuItemExit.Size = new System.Drawing.Size(186, 26);
            this.MenuItemExit.Text = "Вихід";
            this.MenuItemExit.Click += new System.EventHandler(this.MenuItemExit_Click);
            // 
            // RefDep_Cd
            // 
            this.RefDep_Cd.DataPropertyName = "RefDep_Cd";
            this.RefDep_Cd.HeaderText = "Код";
            this.RefDep_Cd.Name = "RefDep_Cd";
            this.RefDep_Cd.ReadOnly = true;
            // 
            // RefDep_Nm
            // 
            this.RefDep_Nm.DataPropertyName = "RefDep_Nm";
            this.RefDep_Nm.HeaderText = "Найменування";
            this.RefDep_Nm.Name = "RefDep_Nm";
            this.RefDep_Nm.ReadOnly = true;
            // 
            // fmCmbDep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 402);
            this.Controls.Add(this.pnl1);
            this.Controls.Add(this.pnl2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "fmCmbDep";
            this.Text = "fmCmbDep";
            this.Load += new System.EventHandler(this.fmCmbDep_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fmCmbDep_KeyDown);
            this.pnl2.ResumeLayout(false);
            this.pnl1.ResumeLayout(false);
            this.pnl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCmbDep)).EndInit();
            this.MenuRefAdm.ResumeLayout(false);
            this.MenuRefAdm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl2;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel pnl1;
        private System.Windows.Forms.MenuStrip MenuRefAdm;
        private System.Windows.Forms.ToolStripMenuItem MenuStripRegister;
        private System.Windows.Forms.ToolStripMenuItem MenuItemChoose;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem MenuItemExit;
        private System.Windows.Forms.DataGridView dgvCmbDep;
        private System.Windows.Forms.DataGridViewTextBoxColumn RefDep_Cd;
        private System.Windows.Forms.DataGridViewTextBoxColumn RefDep_Nm;
    }
}