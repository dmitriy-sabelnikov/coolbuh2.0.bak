namespace ComboBoxes.WinWorms
{
    partial class fmCmbOthAllwnc
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
            this.dgvOthAllwnc = new System.Windows.Forms.DataGridView();
            this.RefOthAllwnc_Cd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RefOthAllwnc_Nm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RefOthAllwnc_Pct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MenuRefAdm = new System.Windows.Forms.MenuStrip();
            this.MenuStripRegister = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemChoose = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.pnl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOthAllwnc)).BeginInit();
            this.MenuRefAdm.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl2
            // 
            this.pnl2.Controls.Add(this.btnOk);
            this.pnl2.Controls.Add(this.btnCancel);
            this.pnl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl2.Location = new System.Drawing.Point(0, 288);
            this.pnl2.Name = "pnl2";
            this.pnl2.Size = new System.Drawing.Size(341, 39);
            this.pnl2.TabIndex = 19;
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(172, 8);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(253, 8);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Відміна";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // dgvOthAllwnc
            // 
            this.dgvOthAllwnc.AllowUserToAddRows = false;
            this.dgvOthAllwnc.AllowUserToDeleteRows = false;
            this.dgvOthAllwnc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOthAllwnc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RefOthAllwnc_Cd,
            this.RefOthAllwnc_Nm,
            this.RefOthAllwnc_Pct});
            this.dgvOthAllwnc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOthAllwnc.Location = new System.Drawing.Point(0, 24);
            this.dgvOthAllwnc.Name = "dgvOthAllwnc";
            this.dgvOthAllwnc.ReadOnly = true;
            this.dgvOthAllwnc.Size = new System.Drawing.Size(341, 303);
            this.dgvOthAllwnc.TabIndex = 18;
            this.dgvOthAllwnc.DoubleClick += new System.EventHandler(this.dgvOthAllwnc_DoubleClick);
            // 
            // RefOthAllwnc_Cd
            // 
            this.RefOthAllwnc_Cd.DataPropertyName = "RefOthAllwnc_Cd";
            this.RefOthAllwnc_Cd.HeaderText = "Код";
            this.RefOthAllwnc_Cd.Name = "RefOthAllwnc_Cd";
            this.RefOthAllwnc_Cd.ReadOnly = true;
            // 
            // RefOthAllwnc_Nm
            // 
            this.RefOthAllwnc_Nm.DataPropertyName = "RefOthAllwnc_Nm";
            this.RefOthAllwnc_Nm.HeaderText = "Найменування";
            this.RefOthAllwnc_Nm.Name = "RefOthAllwnc_Nm";
            this.RefOthAllwnc_Nm.ReadOnly = true;
            // 
            // RefOthAllwnc_Pct
            // 
            this.RefOthAllwnc_Pct.DataPropertyName = "RefOthAllwnc_Pct";
            this.RefOthAllwnc_Pct.HeaderText = "Відсоток";
            this.RefOthAllwnc_Pct.Name = "RefOthAllwnc_Pct";
            this.RefOthAllwnc_Pct.ReadOnly = true;
            // 
            // MenuRefAdm
            // 
            this.MenuRefAdm.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuRefAdm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuStripRegister});
            this.MenuRefAdm.Location = new System.Drawing.Point(0, 0);
            this.MenuRefAdm.Name = "MenuRefAdm";
            this.MenuRefAdm.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.MenuRefAdm.Size = new System.Drawing.Size(341, 24);
            this.MenuRefAdm.TabIndex = 17;
            this.MenuRefAdm.Text = "MenuRefAdm";
            // 
            // MenuStripRegister
            // 
            this.MenuStripRegister.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemChoose,
            this.toolStripSeparator2,
            this.MenuItemExit});
            this.MenuStripRegister.Name = "MenuStripRegister";
            this.MenuStripRegister.Size = new System.Drawing.Size(56, 20);
            this.MenuStripRegister.Text = "Реєстр";
            // 
            // MenuItemChoose
            // 
            this.MenuItemChoose.Name = "MenuItemChoose";
            this.MenuItemChoose.ShortcutKeyDisplayString = "Enter";
            this.MenuItemChoose.Size = new System.Drawing.Size(154, 22);
            this.MenuItemChoose.Text = "Вибрати";
            this.MenuItemChoose.Click += new System.EventHandler(this.MenuItemChoose_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(151, 6);
            // 
            // MenuItemExit
            // 
            this.MenuItemExit.Name = "MenuItemExit";
            this.MenuItemExit.ShortcutKeyDisplayString = "Esc";
            this.MenuItemExit.Size = new System.Drawing.Size(154, 22);
            this.MenuItemExit.Text = "Вихід";
            this.MenuItemExit.Click += new System.EventHandler(this.MenuItemExit_Click);
            // 
            // fmCmbOthAllwnc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 327);
            this.Controls.Add(this.pnl2);
            this.Controls.Add(this.dgvOthAllwnc);
            this.Controls.Add(this.MenuRefAdm);
            this.Name = "fmCmbOthAllwnc";
            this.Text = "fmCmbOthAllwnc";
            this.Load += new System.EventHandler(this.fmCmbOthAllwnc_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fmCmbOthAllwnc_KeyDown);
            this.pnl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOthAllwnc)).EndInit();
            this.MenuRefAdm.ResumeLayout(false);
            this.MenuRefAdm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl2;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView dgvOthAllwnc;
        private System.Windows.Forms.MenuStrip MenuRefAdm;
        private System.Windows.Forms.ToolStripMenuItem MenuStripRegister;
        private System.Windows.Forms.ToolStripMenuItem MenuItemChoose;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem MenuItemExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn RefOthAllwnc_Cd;
        private System.Windows.Forms.DataGridViewTextBoxColumn RefOthAllwnc_Nm;
        private System.Windows.Forms.DataGridViewTextBoxColumn RefOthAllwnc_Pct;
    }
}