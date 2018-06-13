namespace WinUI.WinForms
{
    partial class fmPersCardEdit
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tbDOP = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbDOD = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbDOR = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbDOB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbGrade = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbExp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbTIN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbLName = new System.Windows.Forms.TextBox();
            this.tbFName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvAddInfo = new System.Windows.Forms.DataGridView();
            this.MonthName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Child = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl2.SuspendLayout();
            this.pnl1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl2
            // 
            this.pnl2.Controls.Add(this.btnOk);
            this.pnl2.Controls.Add(this.btnCancel);
            this.pnl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl2.Location = new System.Drawing.Point(0, 319);
            this.pnl2.Name = "pnl2";
            this.pnl2.Size = new System.Drawing.Size(338, 39);
            this.pnl2.TabIndex = 9;
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(169, 9);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(250, 9);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Відміна";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pnl1
            // 
            this.pnl1.Controls.Add(this.tabControl1);
            this.pnl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl1.Location = new System.Drawing.Point(0, 0);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(338, 319);
            this.pnl1.TabIndex = 8;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(338, 319);
            this.tabControl1.TabIndex = 19;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tbDOP);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.tbDOD);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.tbDOR);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.tbDOB);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.tbGrade);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.tbExp);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.tbTIN);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.tbMName);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.tbLName);
            this.tabPage1.Controls.Add(this.tbFName);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(330, 293);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Загальні відомості";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tbDOP
            // 
            this.tbDOP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDOP.Location = new System.Drawing.Point(135, 226);
            this.tbDOP.Name = "tbDOP";
            this.tbDOP.Size = new System.Drawing.Size(177, 20);
            this.tbDOP.TabIndex = 38;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 230);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 13);
            this.label10.TabIndex = 37;
            this.label10.Text = "Дата виходу на пенсію:";
            // 
            // tbDOD
            // 
            this.tbDOD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDOD.Location = new System.Drawing.Point(135, 200);
            this.tbDOD.Name = "tbDOD";
            this.tbDOD.Size = new System.Drawing.Size(177, 20);
            this.tbDOD.TabIndex = 36;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 204);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = "Дата звільнення:";
            // 
            // tbDOR
            // 
            this.tbDOR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDOR.Location = new System.Drawing.Point(135, 176);
            this.tbDOR.Name = "tbDOR";
            this.tbDOR.Size = new System.Drawing.Size(177, 20);
            this.tbDOR.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 180);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "Дата прийому:";
            // 
            // tbDOB
            // 
            this.tbDOB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDOB.Location = new System.Drawing.Point(135, 151);
            this.tbDOB.Name = "tbDOB";
            this.tbDOB.Size = new System.Drawing.Size(177, 20);
            this.tbDOB.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Дата народження:";
            // 
            // tbGrade
            // 
            this.tbGrade.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbGrade.Location = new System.Drawing.Point(135, 127);
            this.tbGrade.Name = "tbGrade";
            this.tbGrade.Size = new System.Drawing.Size(177, 20);
            this.tbGrade.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Класність:";
            // 
            // tbExp
            // 
            this.tbExp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbExp.Location = new System.Drawing.Point(135, 102);
            this.tbExp.Name = "tbExp";
            this.tbExp.Size = new System.Drawing.Size(177, 20);
            this.tbExp.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Стаж:";
            // 
            // tbTIN
            // 
            this.tbTIN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTIN.Location = new System.Drawing.Point(135, 78);
            this.tbTIN.Name = "tbTIN";
            this.tbTIN.Size = new System.Drawing.Size(177, 20);
            this.tbTIN.TabIndex = 25;
            this.tbTIN.Validating += new System.ComponentModel.CancelEventHandler(this.tbTIN_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "ІПН:";
            // 
            // tbMName
            // 
            this.tbMName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMName.Location = new System.Drawing.Point(135, 54);
            this.tbMName.Name = "tbMName";
            this.tbMName.Size = new System.Drawing.Size(177, 20);
            this.tbMName.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "По батькові:";
            // 
            // tbLName
            // 
            this.tbLName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLName.BackColor = System.Drawing.SystemColors.Window;
            this.tbLName.Location = new System.Drawing.Point(135, 7);
            this.tbLName.Name = "tbLName";
            this.tbLName.Size = new System.Drawing.Size(177, 20);
            this.tbLName.TabIndex = 19;
            // 
            // tbFName
            // 
            this.tbFName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFName.Location = new System.Drawing.Point(135, 29);
            this.tbFName.Name = "tbFName";
            this.tbFName.Size = new System.Drawing.Size(177, 20);
            this.tbFName.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Прізвище:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Ім\'я:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvAddInfo);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(330, 293);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Допоміжні відомості";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvAddInfo
            // 
            this.dgvAddInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAddInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MonthName,
            this.Child});
            this.dgvAddInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAddInfo.Location = new System.Drawing.Point(2, 2);
            this.dgvAddInfo.Margin = new System.Windows.Forms.Padding(2);
            this.dgvAddInfo.Name = "dgvAddInfo";
            this.dgvAddInfo.RowHeadersVisible = false;
            this.dgvAddInfo.RowTemplate.Height = 24;
            this.dgvAddInfo.Size = new System.Drawing.Size(326, 289);
            this.dgvAddInfo.TabIndex = 0;
            // 
            // MonthName
            // 
            this.MonthName.DataPropertyName = "MonthName";
            this.MonthName.HeaderText = "Місяць";
            this.MonthName.Name = "MonthName";
            this.MonthName.ReadOnly = true;
            // 
            // Child
            // 
            this.Child.DataPropertyName = "Child";
            this.Child.HeaderText = "Діти";
            this.Child.Name = "Child";
            this.Child.ReadOnly = true;
            // 
            // fmPersCardEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 358);
            this.Controls.Add(this.pnl1);
            this.Controls.Add(this.pnl2);
            this.Name = "fmPersCardEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "fmPersCardEdit";
            this.Load += new System.EventHandler(this.fmPersCardEdit_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fmPersCardEdit_KeyDown);
            this.pnl2.ResumeLayout(false);
            this.pnl1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl2;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel pnl1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox tbDOD;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbDOR;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbDOB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbGrade;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbExp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbTIN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbMName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbLName;
        private System.Windows.Forms.TextBox tbFName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvAddInfo;
        private System.Windows.Forms.TextBox tbDOP;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn MonthName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Child;
    }
}