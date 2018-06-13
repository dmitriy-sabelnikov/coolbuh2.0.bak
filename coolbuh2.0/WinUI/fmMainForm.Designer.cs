namespace WinUI
{
    partial class fmMainForm
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Заробітна плата");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Відпускні");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Лікарняні");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Договір ЦПХ");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Додаткові нарахування");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Корегування прибуткового податку");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Нарахування", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Картки обліку");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Кадри", new System.Windows.Forms.TreeNode[] {
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Підрозділи");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Адміністрація");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Надбавка пенсіонеру");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Надбавки за стаж");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Надбавка за классність");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Інші надбавки");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Спецстаж");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Довідники", new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode11,
            treeNode12,
            treeNode13,
            treeNode14,
            treeNode15,
            treeNode16});
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Импорт бази");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Налаштування");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Оновлення серверних об\'єктів");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Сервіс", new System.Windows.Forms.TreeNode[] {
            treeNode18,
            treeNode19,
            treeNode20});
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Головне меню", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode9,
            treeNode17,
            treeNode21});
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Вихід");
            this.tvMainMenu = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // tvMainMenu
            // 
            this.tvMainMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvMainMenu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvMainMenu.FullRowSelect = true;
            this.tvMainMenu.Location = new System.Drawing.Point(0, 0);
            this.tvMainMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tvMainMenu.Name = "tvMainMenu";
            treeNode1.Name = "Salary";
            treeNode1.Text = "Заробітна плата";
            treeNode2.Name = "Vocation";
            treeNode2.Text = "Відпускні";
            treeNode3.Name = "SickList";
            treeNode3.Text = "Лікарняні";
            treeNode4.Name = "LawContract";
            treeNode4.Text = "Договір ЦПХ";
            treeNode5.Name = "AddPay";
            treeNode5.Text = "Додаткові нарахування";
            treeNode6.Name = "IncTax";
            treeNode6.Text = "Корегування прибуткового податку";
            treeNode7.Name = "Accrual";
            treeNode7.Text = "Нарахування";
            treeNode8.Name = "PersCard";
            treeNode8.Text = "Картки обліку";
            treeNode9.Name = "Personal";
            treeNode9.Text = "Кадри";
            treeNode10.Name = "RefDep";
            treeNode10.Text = "Підрозділи";
            treeNode11.Name = "RefAdm";
            treeNode11.Text = "Адміністрація";
            treeNode12.Name = "RefPensAllwnc";
            treeNode12.Text = "Надбавка пенсіонеру";
            treeNode13.Name = "RefExpAllwnc";
            treeNode13.Text = "Надбавки за стаж";
            treeNode14.Name = "RefGradeAllwnc";
            treeNode14.Text = "Надбавка за классність";
            treeNode15.Name = "RefOthAllwnc";
            treeNode15.Text = "Інші надбавки";
            treeNode16.Name = "RefSpecExp";
            treeNode16.Text = "Спецстаж";
            treeNode17.Name = "Ref";
            treeNode17.Text = "Довідники";
            treeNode18.Name = "ImportDB";
            treeNode18.Text = "Импорт бази";
            treeNode19.Name = "Setup";
            treeNode19.Text = "Налаштування";
            treeNode20.Name = "UpdateDB";
            treeNode20.Text = "Оновлення серверних об\'єктів";
            treeNode21.Name = "Service";
            treeNode21.Text = "Сервіс";
            treeNode22.Name = "MainMenu";
            treeNode22.NodeFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode22.Text = "Головне меню";
            treeNode23.Name = "Close";
            treeNode23.NodeFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode23.Text = "Вихід";
            this.tvMainMenu.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode22,
            treeNode23});
            this.tvMainMenu.Size = new System.Drawing.Size(677, 550);
            this.tvMainMenu.TabIndex = 0;
            this.tvMainMenu.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvMainMenu_NodeMouseDoubleClick);
            this.tvMainMenu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tvMainMenu_KeyDown);
            // 
            // fmMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 550);
            this.Controls.Add(this.tvMainMenu);
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "fmMainForm";
            this.Text = "coolbuh2.0";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.fmMainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TreeView tvMainMenu;
    }
}

