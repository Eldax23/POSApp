namespace POSApp
{
    partial class MainForm
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
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            closeToolStripMenuItem = new ToolStripMenuItem();
            usersToolStripMenuItem = new ToolStripMenuItem();
            addUserToolStripMenuItem = new ToolStripMenuItem();
            productsToolStripMenuItem = new ToolStripMenuItem();
            addNewProductToolStripMenuItem = new ToolStripMenuItem();
            manageProductToolStripMenuItem = new ToolStripMenuItem();
            listProductsToolStripMenuItem = new ToolStripMenuItem();
            customersToolStripMenuItem = new ToolStripMenuItem();
            suppliersToolStripMenuItem = new ToolStripMenuItem();
            billToolStripMenuItem = new ToolStripMenuItem();
            reportsToolStripMenuItem = new ToolStripMenuItem();
            btnSalesInv = new Button();
            btnPurshaseInv = new Button();
            btnReports = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, usersToolStripMenuItem, productsToolStripMenuItem, customersToolStripMenuItem, suppliersToolStripMenuItem, billToolStripMenuItem, reportsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1003, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { closeToolStripMenuItem });
            fileToolStripMenuItem.Image = Properties.Resources.istockphoto_1175215972_612x612_1;
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(66, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // closeToolStripMenuItem
            // 
            closeToolStripMenuItem.Image = Properties.Resources.Red_Close_Button_Transparent;
            closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            closeToolStripMenuItem.Size = new Size(128, 26);
            closeToolStripMenuItem.Text = "Close";
            closeToolStripMenuItem.Click += closeToolStripMenuItem_Click;
            // 
            // usersToolStripMenuItem
            // 
            usersToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addUserToolStripMenuItem });
            usersToolStripMenuItem.Image = Properties.Resources._349_3496311_download_users_icon_clipart_computer_icons_user_communication_users_group_icon;
            usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            usersToolStripMenuItem.Size = new Size(78, 24);
            usersToolStripMenuItem.Text = "Users";
            // 
            // addUserToolStripMenuItem
            // 
            addUserToolStripMenuItem.Image = Properties.Resources.male_user_add_25347;
            addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            addUserToolStripMenuItem.Size = new Size(187, 26);
            addUserToolStripMenuItem.Text = "Add New User";
            addUserToolStripMenuItem.Click += addUserToolStripMenuItem_Click;
            // 
            // productsToolStripMenuItem
            // 
            productsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addNewProductToolStripMenuItem, manageProductToolStripMenuItem, listProductsToolStripMenuItem });
            productsToolStripMenuItem.Image = Properties.Resources.product;
            productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            productsToolStripMenuItem.Size = new Size(100, 24);
            productsToolStripMenuItem.Text = "Products";
            // 
            // addNewProductToolStripMenuItem
            // 
            addNewProductToolStripMenuItem.Image = Properties.Resources._10608872;
            addNewProductToolStripMenuItem.Name = "addNewProductToolStripMenuItem";
            addNewProductToolStripMenuItem.Size = new Size(224, 26);
            addNewProductToolStripMenuItem.Text = "Add New Product";
            addNewProductToolStripMenuItem.Click += addNewProductToolStripMenuItem_Click;
            // 
            // manageProductToolStripMenuItem
            // 
            manageProductToolStripMenuItem.Image = Properties.Resources._10608754;
            manageProductToolStripMenuItem.Name = "manageProductToolStripMenuItem";
            manageProductToolStripMenuItem.Size = new Size(224, 26);
            manageProductToolStripMenuItem.Text = "Manage Product";
            // 
            // listProductsToolStripMenuItem
            // 
            listProductsToolStripMenuItem.Image = Properties.Resources.list;
            listProductsToolStripMenuItem.Name = "listProductsToolStripMenuItem";
            listProductsToolStripMenuItem.Size = new Size(224, 26);
            listProductsToolStripMenuItem.Text = "List Products";
            listProductsToolStripMenuItem.Click += listProductsToolStripMenuItem_Click;
            // 
            // customersToolStripMenuItem
            // 
            customersToolStripMenuItem.Image = Properties.Resources._1218712_customers_group_team_user_user_group_icon;
            customersToolStripMenuItem.Name = "customersToolStripMenuItem";
            customersToolStripMenuItem.Size = new Size(112, 24);
            customersToolStripMenuItem.Text = "Customers";
            // 
            // suppliersToolStripMenuItem
            // 
            suppliersToolStripMenuItem.Image = Properties.Resources._7570228;
            suppliersToolStripMenuItem.Name = "suppliersToolStripMenuItem";
            suppliersToolStripMenuItem.Size = new Size(104, 24);
            suppliersToolStripMenuItem.Text = "Suppliers";
            // 
            // billToolStripMenuItem
            // 
            billToolStripMenuItem.Image = Properties.Resources.shopping_cart;
            billToolStripMenuItem.Name = "billToolStripMenuItem";
            billToolStripMenuItem.Size = new Size(64, 24);
            billToolStripMenuItem.Text = "Bill";
            // 
            // reportsToolStripMenuItem
            // 
            reportsToolStripMenuItem.Image = Properties.Resources.report;
            reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            reportsToolStripMenuItem.Size = new Size(94, 24);
            reportsToolStripMenuItem.Text = "Reports";
            // 
            // btnSalesInv
            // 
            btnSalesInv.BackColor = Color.Transparent;
            btnSalesInv.BackgroundImage = Properties.Resources._5705181;
            btnSalesInv.BackgroundImageLayout = ImageLayout.Stretch;
            btnSalesInv.Cursor = Cursors.Hand;
            btnSalesInv.FlatAppearance.BorderSize = 0;
            btnSalesInv.FlatStyle = FlatStyle.Flat;
            btnSalesInv.Location = new Point(744, 333);
            btnSalesInv.Name = "btnSalesInv";
            btnSalesInv.Size = new Size(231, 145);
            btnSalesInv.TabIndex = 8;
            btnSalesInv.UseVisualStyleBackColor = false;
            // 
            // btnPurshaseInv
            // 
            btnPurshaseInv.BackColor = Color.Transparent;
            btnPurshaseInv.BackgroundImage = Properties.Resources.cashier_5672470;
            btnPurshaseInv.BackgroundImageLayout = ImageLayout.Stretch;
            btnPurshaseInv.Cursor = Cursors.Hand;
            btnPurshaseInv.FlatAppearance.BorderSize = 0;
            btnPurshaseInv.FlatStyle = FlatStyle.Flat;
            btnPurshaseInv.Location = new Point(425, 333);
            btnPurshaseInv.Name = "btnPurshaseInv";
            btnPurshaseInv.Size = new Size(231, 145);
            btnPurshaseInv.TabIndex = 9;
            btnPurshaseInv.UseVisualStyleBackColor = false;
            // 
            // btnReports
            // 
            btnReports.BackColor = Color.Transparent;
            btnReports.BackgroundImage = Properties.Resources.list1;
            btnReports.BackgroundImageLayout = ImageLayout.Stretch;
            btnReports.Cursor = Cursors.Hand;
            btnReports.FlatAppearance.BorderSize = 0;
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.Location = new Point(46, 333);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(231, 145);
            btnReports.TabIndex = 10;
            btnReports.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Yu Gothic UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(743, 497);
            label1.Name = "label1";
            label1.Size = new Size(232, 46);
            label1.TabIndex = 11;
            label1.Text = "Sales invoices";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Yu Gothic UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(389, 497);
            label2.Name = "label2";
            label2.Size = new Size(293, 46);
            label2.TabIndex = 12;
            label2.Text = "Purchase Invoices";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Yu Gothic UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(45, 497);
            label3.Name = "label3";
            label3.Size = new Size(139, 46);
            label3.TabIndex = 13;
            label3.Text = "Reports";
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = Properties.Resources.product1;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(744, 42);
            button1.Name = "button1";
            button1.Size = new Size(231, 145);
            button1.TabIndex = 14;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.BackgroundImage = Properties.Resources._1218712_customers_group_team_user_user_group_icon1;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(425, 42);
            button2.Name = "button2";
            button2.Size = new Size(231, 145);
            button2.TabIndex = 15;
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.BackgroundImage = Properties.Resources._75702281;
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(46, 31);
            button3.Name = "button3";
            button3.Size = new Size(231, 145);
            button3.TabIndex = 16;
            button3.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Yu Gothic UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(787, 210);
            label4.Name = "label4";
            label4.Size = new Size(155, 46);
            label4.TabIndex = 17;
            label4.Text = "Products";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Yu Gothic UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(452, 210);
            label5.Name = "label5";
            label5.Size = new Size(184, 46);
            label5.TabIndex = 18;
            label5.Text = "Customers";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Yu Gothic UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(82, 210);
            label6.Name = "label6";
            label6.Size = new Size(163, 46);
            label6.TabIndex = 19;
            label6.Text = "Suppliers";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.desktop_wallpaper_login_background_outlook_login11;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1003, 559);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnReports);
            Controls.Add(btnPurshaseInv);
            Controls.Add(btnSalesInv);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "MainForm";
            Text = "MainForm";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
        private ToolStripMenuItem usersToolStripMenuItem;
        private ToolStripMenuItem addUserToolStripMenuItem;
        private ToolStripMenuItem productsToolStripMenuItem;
        private ToolStripMenuItem addNewProductToolStripMenuItem;
        private ToolStripMenuItem manageProductToolStripMenuItem;
        private ToolStripMenuItem listProductsToolStripMenuItem;
        private ToolStripMenuItem customersToolStripMenuItem;
        private ToolStripMenuItem suppliersToolStripMenuItem;
        private ToolStripMenuItem billToolStripMenuItem;
        private ToolStripMenuItem reportsToolStripMenuItem;
        private Button btnSalesInv;
        private Button btnPurshaseInv;
        private Button btnReports;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}