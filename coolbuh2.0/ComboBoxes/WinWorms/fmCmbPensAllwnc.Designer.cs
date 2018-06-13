﻿namespace ComboBoxes.WinWorms
{
    partial class fmCmbPensAllwnc
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
            this.dgvPensAllwnc = new System.Windows.Forms.DataGridView();
            this.RefPensAllwnc_Cd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RefPensAllwnc_Nm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RefPensAllwnc_Pct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MenuRefAdm = new System.Windows.Forms.MenuStrip();
            this.MenuStripRegister = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemChoose = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.pnl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPensAllwnc)).BeginInit();
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
            this.pnl2.TabIndex = 16;
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
            // dgvPensAllwnc
            // 
            this.dgvPensAllwnc.AllowUserToAddRows = false;
            this.dgvPensAllwnc.AllowUserToDeleteRows = false;
            this.dgvPensAllwnc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPensAllwnc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RefPensAllwnc_Cd,
            this.RefPensAllwnc_Nm,
            this.RefPensAllwnc_Pct});
            this.dgvPensAllwnc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPensAllwnc.Location = new System.Drawing.Point(0, 24);
            this.dgvPensAllwnc.Name = "dgvPensAllwnc";
            this.dgvPensAllwnc.ReadOnly = true;
            this.dgvPensAllwnc.Size = new System.Drawing.Size(341, 303);
            this.dgvPensAllwnc.TabIndex = 15;
            this.dgvPensAllwnc.DoubleClick += new System.EventHandler(this.dgvPensAllwnc_DoubleClick);
            // 
            // RefPensAllwnc_Cd
            // 
            this.RefPensAllwnc_Cd.DataPropertyName = "RefPensAllwnc_Cd";
            this.RefPensAllwnc_Cd.HeaderText = "Код";
            this.RefPensAllwnc_Cd.Name = "RefPensAllwnc_Cd";
            this.RefPensAllwnc_Cd.ReadOnly = true;
            // 
            // RefPensAllwnc_Nm
            // 
            this.RefPensAllwnc_Nm.DataPropertyName = "RefPensAllwnc_Nm";
            this.RefPensAllwnc_Nm.HeaderText = "Найменування";
            this.RefPensAllwnc_Nm.Name = "RefPensAllwnc_Nm";
            this.RefPensAllwnc_Nm.ReadOnly = true;
            // 
            // RefPensAllwnc_Pct
            // 
            this.RefPensAllwnc_Pct.DataPropertyName = "RefPensAllwnc_Pct";
            this.RefPensAllwnc_Pct.HeaderText = "Відсоток";
            this.RefPensAllwnc_Pct.Name = "RefPensAllwnc_Pct";
            this.RefPensAllwnc_Pct.ReadOnly = true;
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
            this.MenuRefAdm.TabIndex = 14;
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
            // fmCmbPensAllwnc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 327);
            this.Controls.Add(this.pnl2);
            this.Controls.Add(this.dgvPensAllwnc);
            this.Controls.Add(this.MenuRefAdm);
            this.Name = "fmCmbPensAllwnc";
            this.Text = "fmCmbPensAllwnc";
            this.Load += new System.EventHandler(this.fmCmbPensAllwnc_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fmCmbPensAllwnc_KeyDown);
            this.pnl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPensAllwnc)).EndInit();
            this.MenuRefAdm.ResumeLayout(false);
            this.MenuRefAdm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl2;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView dgvPensAllwnc;
        private System.Windows.Forms.MenuStrip MenuRefAdm;
        private System.Windows.Forms.ToolStripMenuItem MenuStripRegister;
        private System.Windows.Forms.ToolStripMenuItem MenuItemChoose;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem MenuItemExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn RefPensAllwnc_Cd;
        private System.Windows.Forms.DataGridViewTextBoxColumn RefPensAllwnc_Nm;
        private System.Windows.Forms.DataGridViewTextBoxColumn RefPensAllwnc_Pct;
    }
}